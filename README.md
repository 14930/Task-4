# Medical VR Suite 2.0 🏥

[![Python Version](https://img.shields.io/badge/python-3.8%2B-blue.svg)](https://www.python.org/downloads/)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)
[![Platform](https://img.shields.io/badge/platform-Windows%20%7C%20Linux%20%7C%20macOS-lightgrey.svg)]()

> **An advanced interactive medical simulation platform for surgical training and anatomical visualization**

Medical VR Suite 2.0 is a comprehensive virtual reality medical training application that provides realistic, physics-based simulations of various surgical procedures and anatomical interactions. Built with Python and leveraging cutting-edge graphics engines, this suite offers hands-on experience with complex medical scenarios in a safe, controlled environment.
<img width="1914" height="1017" alt="Screenshot 2025-11-27 102009" src="https://github.com/user-attachments/assets/693e3a2e-7eaa-47ff-bfac-8a0b6a70f479" />

---

## 📋 Table of Contents

- [Features](#-features)
- [System Architecture](#-system-architecture)
- [Installation](#-installation)
- [Module Overview](#-module-overview)
- [Usage Guide](#-usage-guide)
- [Screenshots & Media](#-screenshots--media)
- [Technical Documentation](#-technical-documentation)
- [Contributing](#-contributing)
- [License](#-license)

---

## ✨ Features

### Core Capabilities

- **🎮 Interactive VR Controls**: Keyboard and mouse-based VR hand emulation (WASD + QE movement)
- **🔬 Real-Time Physics**: Soft-body deformation with spring-mass systems
- **🎨 Advanced Rendering**: PBR materials, dynamic lighting, and shadow mapping
- **📝 Medical Notes System**: Integrated whiteboard and patient record management
- **🔊 Audio Feedback**: Realistic surgical sound effects
- **💾 Persistent Storage**: Patient records and simulation data storage

### Simulation Modules

1. **Cardiac Surgery (Heart)** - Dynamic heartbeat animation with deformation
2. **Hepatic Procedures (Liver)** - Real-time tissue squeezing and manipulation
3. **ENT Surgery (Nose)** - Internal cavity exploration with zoom and squeeze mechanics
4. **Vascular Flow** - Blood flow simulation with clotting mechanics
5. **Orthopedic Trauma (Abdomen/Arm)** - Multi-layer tissue cutting with depth visualization
6. **Dental Training (Teeth)** - Tooth extraction and replacement procedures

---

## 🏗 System Architecture

```
Medical-VR-Suite/
├── main.py                    # Application launcher and menu system
├── liver.py                   # Liver simulation module (Panda3D)
├── cutting.py                 # Surgical cutting simulation (NumPy-based)
├── note.py                    # Medical notes and whiteboard system
├── Patient_Records/           # Patient data storage directory
│   └── Patient_Log.txt
├── models/                    # 3D model assets
│   ├── NasalBlender.obj       # Nasal cavity model (LFS)
│   └── hepatitis liver.obj    # Liver pathology model (LFS)
├── sounds/                    # Audio assets
│   └── slimey-gooey-squash-joshua-chivers-4-4-00-03.wav
└── README.md
```

### Technology Stack

- **Graphics Engine**: Panda3D (3D rendering and physics)
- **Scientific Computing**: NumPy, Trimesh
- **UI Framework**: Tkinter (native cross-platform GUI)
- **3D Format Support**: OBJ, FBX, GLTF, GLB, STL, EGG
- **Version Control**: Git LFS (Large File Storage for 3D assets)

---

## 🚀 Installation

### Prerequisites

```bash
# Required Python Version
Python 3.8 or higher

# System Requirements
- OS: Windows 10/11, Linux (Ubuntu 20.04+), macOS 10.15+
- RAM: 8GB minimum, 16GB recommended
- GPU: Dedicated graphics card with OpenGL 3.3+ support
- Storage: 2GB available space
```

### Setup Instructions

1. **Clone the Repository**
   ```bash
   git clone https://github.com/yourusername/medical-vr-suite.git
   cd medical-vr-suite
   ```

2. **Install Dependencies**
   ```bash
   pip install numpy panda3d trimesh
   ```

3. **Configure Git LFS** (for 3D models)
   ```bash
   git lfs install
   git lfs pull
   ```

4. **Verify Audio Path**
   Edit `liver.py` line 47 to match your audio file location:
   ```python
   SOUND_FILE_PATH = r"path/to/your/audio/file.wav"
   ```

5. **Launch Application**
   ```bash
   python main.py
   ```

---

## 🔬 Module Overview

### 1. Cardiac Surgery Module ❤️

**Features:**
- Realistic heartbeat animation with rhythmic deformation
- Multiple cardiac cycle phases visualization
- Dynamic muscle tissue simulation

**Controls:**
- Observe automatic beating animation
- Adjust heart rate parameters via UI



https://github.com/user-attachments/assets/cb004089-0bce-40ae-a4be-3ce11d01f034


---

### 2. Hepatic Procedures Module 🟤

**Features:**
- Soft-body physics with real-time vertex deformation
- Dual interaction modes: Mouse-based and VR hand emulation
- Force adjustment (0-200N) with visual feedback
- Two tissue types: Hard (bone-like) and Soft (flesh-like)
- Material response with recovery dynamics

**Controls:**
- **VR Mode (Default)**: WASD + QE to move virtual hand, automatic squeeze on contact
- **Mouse Mode**: Left-click to squeeze, Right-click to rotate organ
- **Force Slider**: Adjust compression strength
- **Reset Button**: Restore original mesh geometry

**Technical Details:**
```python
# Physics Parameters
user_force: 0-200N (adjustable)
recovery_speed: 8.0 (spring constant)
damping: 10.0 (velocity damping)
interaction_radius: 2.0 (hard) / 4.0 (soft)
```



https://github.com/user-attachments/assets/bcbb9c1f-4b93-4e3c-9f40-33c21fb05475



---

### 3. ENT Surgery Module 👃

**Features:**
- High-resolution nasal cavity model (70MB detailed mesh)
- Camera zoom functionality for internal exploration
- Navigate through nasal passages
- Squeeze mechanics applicable to internal structures
- Real-time tissue response inside cavity

**Controls:**
- **Zoom**: Mouse scroll or designated keys
- **Navigate**: WASD for camera movement inside cavity
- **Squeeze**: Left-click on internal tissues
- **Rotate View**: Right-click drag

**Unique Capabilities:**
- Explore sinus cavities
- Visualize turbinate structures
- Practice endoscopic navigation

![Nasal External](images/nasal_external.png)
*External view of nasal model before zoom*

![Nasal Internal](images/nasal_internal.png)
*Internal cavity view showing detailed turbinate structures*

![Nasal Zoom Exploration](videos/nasal_zoom_exploration.mp4)
*Complete navigation through nasal passages from entrance to pharynx*

![Nasal Internal Squeeze](videos/nasal_internal_squeeze.mp4)
*Demonstration of tissue interaction inside nasal cavity*

---

### 4. Vascular Flow Simulation 💧

**Features:**
- Particle-based blood flow visualization
- Laminar and turbulent flow patterns
- Clotting mechanism simulation
- Vessel wall interaction
- Flow velocity adjustment

**Controls:**
- Adjust flow rate with slider
- Introduce clotting factors
- Observe hemodynamic changes

**Medical Applications:**
- Thrombosis visualization
- Embolism simulation
- Vascular occlusion training

![Vascular Flow Normal](images/vascular_flow_normal.png)
*Normal laminar blood flow pattern*

![Vascular Clotting](images/vascular_clotting.png)
*Clot formation and propagation visualization*

![Vascular Flow Demo](videos/vascular_flow_demo.mp4)
*Complete blood flow simulation with clotting event*

---

### 5. Orthopedic Trauma Module 💪

**Features:**
- Multi-layer tissue cutting simulation
- Depth-based color mapping:
  - **Beige**: Skin layer (surface)
  - **Red**: Muscle tissue (intermediate)
  - **White**: Bone structure (deep)
- Adjustable cutting depth and position
- PLY file export for external 3D viewers

**Technical Implementation:**
```python
# Layer Depth Thresholds
intensity > 0.6  → Bone (white)
intensity > 0.2  → Muscle (red)
intensity ≤ 0.2  → Skin (beige)

# Deformation Formula
push = normal × (-1) × intensity × depth_factor
```

**Controls:**
- **Height Input**: Specify cutting position (0.0 - 5.0)
- **Depth Strength**: Adjust incision depth (0.5 - 2.0)
- **Export**: Generate PLY file for analysis

**Usage Example:**
```bash
python cutting.py
# Enter cutter height (0.0 to 5.0) [default 2.5]: 3.0
# Enter cut depth strength (0.5 to 2.0) [default 1.2]: 1.5
# Output: cut_simulation.ply
```

![Cutting Skin Layer](images/cutting_skin_layer.png)
*Shallow cut showing only skin layer (beige)*

![Cutting Muscle Exposed](images/cutting_muscle_exposed.png)
*Medium depth cut exposing muscle tissue (red)*

![Cutting Bone Visible](images/cutting_bone_visible.png)
*Deep incision revealing bone structure (white)*

![Cutting Progression](videos/cutting_progression.mp4)
*Time-lapse of progressive cutting from skin to bone*

---

### 6. Dental Training Module 🦷

**Features:**
- Individual tooth/molar selection
- Extraction mechanics with resistance simulation
- Replacement and repositioning
- Root structure visualization
- Force feedback during extraction

**Controls:**
- **Select Tooth**: Left-click on tooth
- **Extract**: Click and drag upward
- **Replace**: Drag tooth back to socket
- **Rotate View**: Right-click drag

![Dental Full View](images/dental_full_view.png)
*Complete dental arch overview*

![Dental Extraction](images/dental_extraction.png)
*Tooth extraction in progress showing root structure*

![Dental Extraction Demo](videos/dental_extraction_demo.mp4)
*Full extraction and replacement procedure*

---

## 📖 Usage Guide

### Launching the Application

1. **Start Main Menu**
   ```bash
   python main.py
   ```

2. **Navigate Menu**
   - Click on any module card to launch simulation
   - Use "Notes/Whiteboard" for patient documentation
   - Access "Records & Info" for patient history

![Main Menu](images/main_menu.png)
*Main application launcher showing all six modules*

---

### VR Hand Emulation Guide

The VR hand system provides 3D spatial control without physical VR hardware:

**Movement Controls:**
```
W/S  → Move hand up/down (Z-axis)
A/D  → Move hand left/right (X-axis)
Q/E  → Move hand forward/backward (Y-axis, depth)
```

**Visual Feedback:**
- **Green wireframe sphere**: VR hand position
- **White center dot**: Precise interaction point
- **Transparency**: 30% alpha for visibility

**Interaction Mechanics:**
- Hand exerts force on contact (no clicking required)
- Force magnitude determined by UI slider
- Tissue responds with spring-mass physics

![VR Hand Closeup](images/vr_hand_closeup.png)
*VR hand visual representation near liver surface*

---

### Medical Notes System

**Features:**
- Digital whiteboard for annotations
- Patient record creation and storage
- Timestamped entries
- Search and filter capabilities

**Access:**
Click "📝 Notes / Whiteboard" button on main menu

**Storage Location:**
```
Patient_Records/
├── Patient_Log.txt
├── patient_001_notes.txt
└── ...
```

![Notes Interface](images/notes_interface.png)
*Medical notes interface with whiteboard*

---

## 🎓 Technical Documentation

### Physics Engine Details

**Soft-Body Deformation Algorithm:**
```python
# Spring-Mass System
F_spring = -k × displacement
F_damping = -c × velocity
F_external = user_force × influence_factor

# Verlet Integration
acceleration = (F_spring + F_damping + F_external) / mass
velocity_new = velocity + acceleration × dt
position_new = position + velocity_new × dt
```

**Influence Function:**
```python
influence = (1 - distance/radius)³  # Cubic falloff
force = base_force × influence × direction
```

### Rendering Pipeline

1. **Vertex Transformation**: CPU-side deformation
2. **Normal Recalculation**: Per-frame normal updates
3. **PBR Material Shading**: Blinn-Phong model
4. **Shadow Mapping**: 2048×2048 shadow atlas
5. **Anti-Aliasing**: Multi-sample anti-aliasing (MSAA)

### File Format Support

| Format | Import | Export | Notes |
|--------|--------|--------|-------|
| OBJ    | ✅     | ❌     | Primary format |
| STL    | ✅     | ❌     | Requires trimesh |
| PLY    | ✅     | ✅     | Cutting simulation output |
| FBX    | ✅     | ❌     | Via Panda3D |
| GLTF   | ✅     | ❌     | Modern standard |

---

## 🐛 Troubleshooting

### Common Issues

**Issue: "Audio file not found"**
```
Solution: Edit liver.py line 47 with correct path
SOUND_FILE_PATH = r"C:\path\to\your\audio.wav"
```

**Issue: "Model appears black/unlit"**
```
Solution: Ensure GPU drivers are updated
Check OpenGL version: Should be 3.3+
```

**Issue: "VR hand not responding"**
```
Solution: Verify VR mode is enabled (button should be green)
Check keyboard focus is on application window
```

**Issue: "Lag during tissue deformation"**
```
Solution: Reduce mesh resolution
Lower mesh_res parameter in cutting.py
Close background applications
```

---

## 🤝 Contributing

We welcome contributions from the medical and developer communities!

### Areas for Contribution

- New surgical procedures
- Enhanced physics models
- Additional organ systems
- Performance optimizations
- Documentation improvements
- Bug fixes

### Contribution Process

1. Fork the repository
2. Create feature branch (`git checkout -b feature/new-module`)
3. Commit changes (`git commit -m 'Add new cardiac procedure'`)
4. Push to branch (`git push origin feature/new-module`)
5. Open Pull Request

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 📧 Contact & Development Team
### **Project Contributor: Maryam Moustafa**
- **Email**: maryam23shabaan@gmail.com
- **[GitHub](https://github.com/MARYAM-MOUSTAFA-GITHUB-USERNAME)**
- **[LinkedIn](https://linkedin.com/in/MARYAM-MOUSTAFA-LINKEDIN-USERNAME)**
  
### **Project Contributor: Aya Sayed**
- **Email**: aya.sayed14827@gmail.com
- **[GitHub](https://github.com/AYA-SAYED-GITHUB-USERNAME)**
- **[LinkedIn](https://linkedin.com/in/AYA-SAYED-LINKEDIN-USERNAME)**
  
### **Project Contributor:Yousef Mahmoud**
- **Email**: youssef.abdelrauf23@gmail.com
- **[GitHub](https://github.com/youssefabdelrauf)**
- **[LinkedIn](https://www.linkedin.com/in/youssef-mahmoud-abdelrauf-1905b8370?utm_source=share_via&utm_content=profile&utm_medium=member_ios)**
  
### **Project Contributor: Rahma Ashraf**
- **Email**: ashrafrahma402@gmail.com
- **[GitHub](https://github.com/rahmashraf)**
- **[LinkedIn](https://eg.linkedin.com/in/rahma-ashraf-717012373)**
  
---
 
## 🗺 Roadmap

### Version 2.1 (Q2 2024)
- [ ] Haptic feedback integration
- [ ] Multi-user collaboration mode
- [ ] Advanced blood vessel simulation
- [ ] MRI/CT scan import

### Version 3.0 (Q4 2024)
- [ ] Full VR headset support (Oculus, Vive)
- [ ] AI-powered surgical guidance
- [ ] Performance assessment system
- [ ] Cloud-based patient records

---

## 📊 Performance Metrics

**System Performance:**
- Render FPS: 60+ (recommended GPU)
- Physics Update: 120Hz
- Input Latency: <16ms
- Memory Usage: ~500MB (base) + model size

**Supported Model Sizes:**
- Minimum: 10,000 vertices
- Recommended: 50,000 - 100,000 vertices
- Maximum tested: 500,000 vertices

---

## 🔐 Privacy & Data Security

- Patient records stored locally only
- No telemetry or data collection
- HIPAA compliance considerations for institutional use
- Encrypted storage option available

---

**Made with ❤️ for medical education and surgical training**

*Last Updated: November 2024*
