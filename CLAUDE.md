# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this repo is

OpenSpiRobs / SpiRobs — a research toolkit for **logarithmic-spiral soft robots** (`r = a·e^(b·θ)`). It is a mixed-content monorepo: most top-level directories are *reference material*, not software. The **only buildable/runnable code lives in `design-tool/`** (a PySide6 GUI) and its companion `extensions/` and `fabrication/` Python scripts. Everything is in **millimeters** unless converted for MuJoCo.

There are no tests, no linter, and no build step configured anywhere. "Running" means launching one of the Python entry points below.

## Commands

All Python work targets `design-tool/requirements.txt` (PySide6, mujoco, matplotlib, vtk, **cadquery**, numpy). Python 3.10/3.11 are the tested versions; 3.13 works only with the newer `vtk` wheel that `requirements.txt` selects via environment markers.

```bash
# Setup (a single venv covers the GUI + extensions + fabrication)
cd design-tool
python -m pip install -r requirements.txt

# Main design GUI
python DesignTool.py                       # run from design-tool/

# Circular multi-robot array (consumes an exported robot.xml)
python extensions/multi-robot-array/array_gui.py        # GUI, run from repo root
python extensions/multi-robot-array/generate_array.py --help   # CLI

# Split an oversized export for printing (STEP via CadQuery, STL via VTK)
python fabrication/splitter_generator.py design-tool/exports/<file>.step --axis x --max-span-mm 180
```

## Architecture

### One geometry model, two independent consumers

The robot is a chain of **units**. Each unit is a trapezoid sampled between successive spiral angles (`Δθ` = `dtheta_deg`), plus its **mirror** reflected across the "central spiral" edge. The central spiral is the original spiral blended inward by factor `p`. Core parameters live in the `Params` dataclass (`DesignTool.py` top): `a`, `b`, `dtheta_deg`, `theta_max_pi` (total turns ×2π), `p`, elastic layer, cone angles, tip/base hole pos+size, `two_cable` (2 vs 3 cables), and sim stiffness/damping. Tip/base size, taper angle, robot length, and unit count are all *derived* from these.

The same polygon set feeds two unrelated export paths:

- **CAD (`export_cad` / `_build_cad_parts` in `DesignTool.py`, via CadQuery):**
  - 2-cable → extrude the unfolded trapezoid strip in ±Z (a flat ribbon), then subtract cone1/cone2 wedge cuts.
  - 3-cable → **revolve** each unit profile 360° around X (a solid of revolution), then subtract 3 frustum cable holes at 0/120/240°.
  - Writes `exports/spi_rob_<ts>.step` (a Compound) + `.stl` (merged).

- **MuJoCo XML (`export_xml` in `DesignTool.py` → `xml_generator.generate_mujoco_xml`):** exports **one** representative unit as `baselink.stl` (the largest/rightmost unit), then `robot.xml` instantiates it `num_units` times as a **nested kinematic `<body>` chain**, each link scaled by `1/gamma` (`gamma = e^(b·Δθ)`) relative to its parent. Joints are `hinge` for 2-cable, `ball` for 3-cable. Per-link `<site>`s thread tendons (`<spatial>`, 2 for 2-cable, 3 for 3-cable) actuated by `<muscle>`s. Output: `exports/xml_<ts>/{robot.xml, baselink.stl}`.

### `DesignTool.py` is self-contained — `spiral_robot/` is a separate, unused island

`DesignTool.py` reimplements all spiral/unit geometry *inline* and imports only `xml_generator` (a sibling top-level module). It does **not** import the `spiral_robot/` package at all. `spiral_robot/` (`spiral.py`, `design.py`, `viz.py`, `export_cad.py`) is an independent, older library track — its `viz.interactive_forward_polar()` is an alternate matplotlib-only UI, and `design.inverse_design()` implements the SpiRobs paper's Eqs. 1–5 (paper PDF in `related-papers/`). Nothing in the GUI or extensions imports it.

Because the two tracks are duplicated, **editing one does not affect the other**, and they even differ numerically: the central-spiral blend is `c_factor = (1-p) + p·eᵇ` in `DesignTool.py` but `c_factor = p + (1-p)·eᵇ` in `viz.py` (and the `p` slider is 0–0.5 vs 0–1.0). They coincide only at `p=0.5`. When changing geometry math, confirm *which* file the running entry point actually uses.

### GUI rendering stack (`DesignTool.py`)

Three panes: left = matplotlib **2D** (polar spiral + unfolded Cartesian sketch); middle = **VTK** live 3D preview (extrudes/clips `vtkPolyData` directly — this is *not* the CAD export geometry); right = scrollable parameter panel. Updates are debounced via `QTimer` (~120 ms) and paused during splitter drags/resizes. So three different engines render the same design at increasing fidelity: matplotlib (sketch) → VTK (preview) → CadQuery (final export).

### Cross-tool pipeline

`DesignTool.py` export folders are the hand-off interface:

- `generate_array.py` auto-discovers the **latest** `exports/xml_*/robot.xml`, deep-copies the body `count` times into a circular array, prefixes every name with `r{i}_`, and copies `baselink.stl` next to the output (`extensions/multi-robot-array/output/robot_array.xml`). `array_gui.py` wraps this and launches `mujoco.viewer` in a `QProcess` subprocess.
- `splitter_generator.py` slices an oversized STEP/STL along one axis into printable parts + `split_report.json` (geometric cuts only — no joinery/keying yet).

## Conventions & gotchas

- **Units:** the design tool is entirely in **mm**; `xml_generator` multiplies by `0.001` (mm→m) for MuJoCo. Mind the boundary.
- **CadQuery failures are silent:** export methods `try: import cadquery … except: return` (no-op) and print errors to **stdout**, not the GUI. If "Export STEP/STL" or "Export XML" seems to do nothing, check the terminal and that `cadquery` imported.
- **VTK + Qt setup:** `main()` forces an OpenGL 3.2 core `QSurfaceFormat` *before* `QApplication`, and imports VTK via `vtkmodules.*` with a `QVTKOpenGLNativeWidget` → `QVTKRenderWindowInteractor` fallback. Don't reorder this.
- The `extensions/` GUI imports `generate_array.py` by file path via `importlib`, not as a package.

## Non-code directories (reference only — not software)

- `MKS D系列闭环步进驱动器/` — Makerbase closed-loop stepper driver vendor pack (manuals, example zips, Windows tools, firmware). Has its **own `CLAUDE.md`** (in Chinese); read it before touching that folder. Not a git-buildable project.
- `3D建模/` — Siemens NX `.prt` binaries (Chinese filenames) for the physical robot's motor mounts, winch spools, and base. Not readable/editable here.
- `related-papers/` — the SpiRobs 2024 paper (the math reference behind `spiral_robot/design.py`).
- `rl/` — RL **artifacts only** (`checkpoints/ppo_reach.zip`, `videos/`, tensorboard `tb/`). The training code is **not in the repo**; the reach task presumably consumes an exported MuJoCo XML.
- `datasets/`, `hardware/` — empty placeholder folders with stub READMEs.

## License

PolyForm-Noncommercial-1.0.0. Commercial use requires a separate license.
