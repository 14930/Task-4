# 🏥 Medical VR Simulation Suite 2.0

[![Python Version](https://img.shields.io/badge/python-3.8%2B-blue.svg)](https://www.python.org/downloads/)
[![Unity Version](https://img.shields.io/badge/unity-2021.3%2B-green.svg)](https://unity.com/)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)
[![Platform](https://img.shields.io/badge/platform-Windows%20%7C%20Linux%20%7C%20macOS-lightgrey.svg)]()

> **An immersive medical training platform combining realistic surgical simulations with advanced physics-based interactions for medical education**

Medical VR Simulation Suite 2.0 is a comprehensive virtual reality training application designed for medical students and surgical trainees. The platform provides hands-on experience with anatomical structures and surgical procedures through interactive simulations powered by real-time physics engines.


<img width="1914" height="1018" alt="Screenshot 2025-12-01 144601" src="https://github.com/user-attachments/assets/e6b970e3-7288-4d7f-957b-b3048639dd38" />


---

## 📋 Table of Contents

- [✨ Features](#-features)
- [🏗️ System Architecture](#️-system-architecture)
- [🚀 Installation](#-installation)
- [🎯 Module Overview](#-module-overview)
- [📖 Usage Guide](#-usage-guide)
- [🎥 Demo Videos](#-demo-videos)
- [💻 Technical Documentation](#-technical-documentation)
- [👥 Development Team](#-development-team)
- [📄 License](#-license)

---

## ✨ Features

### 🎮 Core Capabilities

- **🖱️ Dual Interaction Systems**: Mouse-based precision controls and VR hand emulation (WASD+QE movement)
- **⚡ Real-Time Physics Engine**: Advanced soft-body deformation using spring-mass dynamics
- **🎨 High-Fidelity Rendering**: PBR materials with dynamic lighting and shadow mapping
- **📝 Medical Documentation**: Integrated note-taking system with persistent storage for clinical observations
- **🔊 Immersive Audio**: Realistic surgical soundscapes and haptic feedback simulation
- **💾 Data Persistence**: Patient record management with export capabilities

### 🏥 Six Specialized Training Modules

Each module targets specific surgical skills and anatomical understanding:

1. **❤️ Cardiac Surgery (Heart)** - Rhythmic deformation animation simulating cardiac cycles
2. **🟤 Hepatic Procedures (Liver)** - Interactive soft-tissue manipulation with force feedback
3. **👃 ENT Surgery (Nose)** - Internal cavity exploration with zoom navigation
4. **💧 Vascular Flow** - Dynamic blood flow visualization with clotting mechanics
5. **💪 Orthopedic Trauma (Abdomen)** - Multi-layer tissue cutting with depth visualization
6. **🦷 Dental Training (Teeth)** - Tooth extraction and replacement procedures

---

## 🏗️ System Architecture

```
Medical-VR-Suite/
├── 📄 main.py                    # Application launcher and menu interface
├── 🟤 liver.py                   # Hepatic simulation module (Panda3D)
├── ✂️ cutting.py                 # Surgical cutting mechanics (NumPy)
├── 📝 note.py                    # Medical notes documentation system
├── 📁 Patient_Records/           # Clinical data storage
│   └── Patient_Log.txt
├── 🎮 Unity Scripts/             # VR interaction controllers
│   ├── MeshDeformer.cs          # Tissue deformation physics
│   ├── VRKnife.cs               # Surgical instrument controller
│   ├── ThrustingKnife.cs        # Advanced cutting mechanics
│   ├── PowerKnife.cs            # Force-feedback cutting tool
│   └── SimpleExtraction.cs      # Dental extraction mechanics
├── 🗂️ models/                    # 3D anatomical assets (Git LFS)
│   ├── NasalBlender.obj         # Nasal cavity model (70.8 MB)
│   └── hepatitis liver.obj      # Liver pathology model (8.3 MB)
├── 🔊 sounds/                    # Audio feedback assets
│   └── squash-sound.wav
└── 📖 README.md
```

### 🛠️ Technology Stack

| Component | Technology | Purpose |
|-----------|-----------|---------|
| **Graphics Engine** | Panda3D | 3D rendering and physics simulation |
| **Game Engine** | Unity 2021.3+ | VR interaction and haptics |
| **Scientific Computing** | NumPy, Trimesh | Mesh manipulation and analysis |
| **UI Framework** | Tkinter | Cross-platform menu interface |
| **Version Control** | Git LFS | Large 3D model asset management |

### 📊 Supported File Formats

| Format | Import | Export | Notes |
|--------|--------|--------|-------|
| OBJ | ✅ | ❌ | Primary 3D model format |
| STL | ✅ | ❌ | Requires trimesh library |
| PLY | ✅ | ❌ | Point cloud and mesh data |
| FBX | ✅ | ❌ | Animation-compatible format |
| GLTF/GLB | ✅ | ❌ | Modern web-ready format |
| TXT | ✅ | ✅ | **Medical notes export only** |

> ⚠️ **Note**: The system only exports medical documentation (TXT format) from the integrated note-taking module. 3D models and simulation data are not exportable to maintain educational content integrity.

---

## 🚀 Installation

### 📋 Prerequisites

```bash
# Python Version
Python 3.8 or higher

# System Requirements
- OS: Windows 10/11, Linux (Ubuntu 20.04+), macOS 10.15+
- RAM: 8GB minimum, 16GB recommended for complex models
- GPU: Dedicated graphics card with OpenGL 3.3+ support
- Storage: 2GB available space
- Optional: VR headset (Oculus Quest, HTC Vive) for full VR experience
```

### 🔧 Setup Instructions

**1️⃣ Clone the Repository**
```bash
git clone https://github.com/yourusername/medical-vr-suite.git
cd medical-vr-suite
```

**2️⃣ Install Python Dependencies**
```bash
pip install numpy panda3d trimesh
```

**3️⃣ Configure Git LFS** (for 3D models)
```bash
git lfs install
git lfs pull
```

> 📌 **Important**: This repository uses Git LFS to manage large 3D model files. GitHub's file size limitations require this approach for anatomical meshes.

**4️⃣ Verify Audio Configuration**
Edit `liver.py` line 47 to match your system's audio file path:
```python
SOUND_FILE_PATH = r"path/to/your/sounds/squash-sound.wav"
```

**5️⃣ Launch Application**
```bash
python main.py
```

---

## 🎯 Module Overview

### 1. ❤️ Cardiac Surgery Module

**🎯 Training Objectives:**
- Understanding cardiac anatomy and rhythm
- Observing myocardial contraction patterns
- Recognizing abnormal heartbeat variations

**✨ Features:**
- 🫀 Realistic heartbeat animation with rhythmic deformation
- 📊 Multiple cardiac cycle phase visualization
- 💓 Adjustable heart rate simulation
- 🔄 Dynamic muscle tissue response

**🎮 Controls:**
- **Observation Mode**: Automatic beating animation
- **Parameter Adjustment**: UI sliders for rate control

**📹 Demo:**

https://github.com/user-attachments/assets/cb004089-0bce-40ae-a4be-3ce11d01f034

---

### 2. 🟤 Hepatic Procedures Module

**🎯 Training Objectives:**
- Soft tissue manipulation techniques
- Force application and tactile feedback
- Organ handling and positioning skills

**✨ Features:**
- 🤲 Dual interaction modes: Precision mouse control and 3D VR hand emulation
- ⚖️ Adjustable compression force (0-200N) with real-time visual feedback
- 🧱 Two tissue density presets: Hard (bone-like) and Soft (flesh-like)
- 🔄 Spring-mass physics with natural recovery dynamics
- 🎯 Volumetric interaction radius for realistic contact

**🎮 Controls:**

| Mode | Control | Action |
|------|---------|--------|
| **VR Hand** | `W/A/S/D` | Move hand in X/Z plane |
| **VR Hand** | `Q/E` | Push forward/pull back (depth) |
| **VR Hand** | Auto | Continuous squeeze on contact |
| **Mouse** | Left Click | Apply compression force |
| **Mouse** | Right Click + Drag | Rotate organ view |
| **UI** | Force Slider | Adjust compression strength (0-200N) |
| **UI** | Reset Button | Restore original mesh geometry |

**🔬 Technical Physics:**
```python
# Soft-Body Dynamics Parameters
user_force: 0-200N        # Adjustable via UI slider
recovery_speed: 8.0       # Spring constant (k)
damping: 10.0            # Velocity damping coefficient
interaction_radius: 2.0   # Hard tissue mode
interaction_radius: 4.0   # Soft tissue mode
```

**📹 Demo:**

https://github.com/user-attachments/assets/bcbb9c1f-4b93-4e3c-9f40-33c21fb05475

---

### 3. 👃 ENT Surgery Module

**🎯 Training Objectives:**
- Nasal cavity anatomy exploration
- Endoscopic navigation techniques
- Internal structure identification

**✨ Features:**
- 🔬 High-resolution nasal cavity model (70.8MB detailed mesh)
- 🔍 Dynamic camera zoom for internal exploration
- 🧭 Free navigation through nasal passages and sinus cavities
- 🤲 Squeeze mechanics functional on internal tissues
- 👁️ Real-time tissue response during cavity exploration

**🎮 Controls:**
- **🔍 Zoom**: Mouse scroll wheel or designated keys
- **🧭 Navigate**: `W/A/S/D` for camera movement inside cavity
- **🤲 Squeeze**: Left-click on internal structures
- **🔄 Rotate View**: Right-click and drag

**🏥 Clinical Applications:**
- Turbinate structure visualization
- Sinus cavity exploration
- Endoscopic procedure practice
- Septal deviation assessment

**📹 Demo:**




https://github.com/user-attachments/assets/05b6d75a-c974-4a0b-b4de-9cd6b0139043






---

### 4. 🩸 Vascular Flow Simulation

**🎯 Training Objectives:**
- Understanding hemodynamic principles
- Visualizing blood flow patterns
- Recognizing thrombotic events

**✨ Features:**
- 🌊 Particle-based blood flow visualization
- 💨 Laminar and turbulent flow pattern simulation
- 🩸 Interactive clotting mechanism
- 🧱 Vessel wall interaction dynamics
- ⚡ Adjustable flow velocity parameters

**🎮 Controls:**
- **📊 Flow Rate Slider**: Adjust blood velocity
- **🩸 Clotting Button**: Introduce thrombotic factors
- **👁️ Camera Controls**: Observe flow from multiple angles

**🏥 Medical Applications:**
- 🫀 Thrombosis visualization and progression
- 🚑 Embolism event simulation
- 🩺 Vascular occlusion training scenarios
- 📚 Hemodynamic principle demonstration

**📹 Demo:**

https://github.com/user-attachments/assets/bca783c6-8e14-4dd7-bbb8-7e9516414434

---

### 5. 💪 Orthopedic Trauma Module (Abdomen)

**🎯 Training Objectives:**
- Surgical incision techniques
- Multi-layer tissue identification
- Depth perception and control

**✨ Features:**
- ✂️ Multi-layer tissue cutting simulation
- 🎨 **Depth-based color mapping system:**
  - **🟤 Beige**: Superficial skin layer (intensity ≤ 0.2)
  - **🔴 Red**: Intermediate muscle tissue (0.2 < intensity ≤ 0.6)
  - **⚪ White**: Deep bone structure (intensity > 0.6)
- 📏 Adjustable cutting position (0.0 - 5.0 height units)
- ⚖️ Variable incision depth strength (0.5 - 2.0 multiplier)
- 💾 PLY file generation for external 3D analysis

**🔬 Technical Implementation:**
```python
# Layer Classification Algorithm
if intensity > 0.6:   → Bone (white)
elif intensity > 0.2: → Muscle (red)
else:                 → Skin (beige)

# Deformation Formula
push_vector = normal × (-1) × intensity × depth_factor
new_position = original_position + push_vector
```

**🎮 Controls & Usage:**
```bash
python cutting.py

# Interactive Prompts:
Enter cutter height (0.0 to 5.0) [default 2.5]: 3.0
Enter cut depth strength (0.5 to 2.0) [default 1.2]: 1.5

# Output: cut_simulation.ply
```

**📊 Output File:**
- Opens in Windows 3D Viewer, Blender, or MeshLab
- Displays color-coded anatomical layers
- Suitable for surgical planning review

**📹 Demo:**

https://github.com/user-attachments/assets/2488f977-ea5d-49eb-b160-42616ef73733

---

### 6. 🦷 Dental Training Module

**🎯 Training Objectives:**
- Tooth extraction procedures
- Grip force calibration
- Dental anatomy understanding

**✨ Features:**
- 🦷 Individual tooth and molar selection
- 💪 Extraction mechanics with realistic resistance simulation
- 🔄 Replacement and repositioning capabilities
- 🌳 Root structure visualization
- 📊 Force feedback during extraction process

**🎮 Controls:**
- **🎯 Select Tooth**: Left-click on desired tooth
- **⬆️ Extract**: Click and drag upward motion
- **⬇️ Replace**: Drag tooth back to original socket
- **🔄 Rotate View**: Right-click and drag

**🏥 Clinical Applications:**
- Simple extraction practice
- Forceps grip technique training
- Socket preservation procedures
- Post-extraction assessment

**📹 Demo:**





https://github.com/user-attachments/assets/d35d61b5-a6b4-4e92-b66b-2dfb200ec730





---

## 📖 Usage Guide

### 🚀 Launching the Application

**1️⃣ Start Main Menu**
```bash
python main.py
```

**2️⃣ Navigate Interface**
- 🎯 Click any module card to launch simulation
- 📝 Use **"Notes/Whiteboard"** button for clinical documentation
- ℹ️ Access **"Records & Info"** for patient history management

---

### 🕹️ VR Hand Emulation System

The VR hand emulator provides 3D spatial control without requiring physical VR hardware:

**🎮 Movement Controls:**

| Key | Axis | Action |
|-----|------|--------|
| `W` | +Z | Move hand upward |
| `S` | -Z | Move hand downward |
| `A` | -X | Move hand left |
| `D` | +X | Move hand right |
| `Q` | +Y | Push hand forward (into scene) |
| `E` | -Y | Pull hand backward (toward camera) |

**👁️ Visual Feedback:**
- **🟢 Green Wireframe Sphere**: VR hand boundary volume
- **⚪ White Center Marker**: Precise interaction point
- **👻 30% Transparency**: Maintains visibility of underlying anatomy

**⚡ Interaction Mechanics:**
- 🤲 Hand exerts continuous force upon contact (no button press required)
- ⚖️ Force magnitude controlled by UI slider (0-200N)
- 🔄 Tissue responds with spring-mass physics in real-time
- 🎯 Volumetric interaction radius adapts to tissue density

---

### 📝 Medical Documentation System

**✨ Features:**
- 🖊️ Digital whiteboard for surgical annotations
- 📋 Patient record creation with timestamping
- 💾 **Persistent local storage** (no cloud upload)
- 🔍 Search and filter capabilities for record retrieval
- 📤 **Export functionality**: Save notes as `.txt` files

**🚀 Access Method:**
Click **"📝 Notes / Whiteboard"** button on main menu

**📁 Storage Location:**
```
Medical-VR-Suite/
└── Patient_Records/
    ├── Patient_Log.txt
    ├── patient_001_notes.txt
    ├── patient_002_notes.txt
    └── ...
```

**💡 Use Cases:**
- ✍️ Document surgical observations during simulation
- 📊 Track training progress and skill development
- 🎓 Create study notes for anatomy review
- 📝 Log clinical decision-making rationale

---

## 🎥 Demo Videos

All demonstration videos are embedded throughout the module descriptions above. Each video showcases:

- ✅ Real-time interaction mechanics
- ✅ Physics-based deformation behavior
- ✅ User interface and control schemes
- ✅ Clinical training applications

---

## 💻 Technical Documentation

### ⚙️ Physics Engine Architecture

**🔬 Soft-Body Deformation Algorithm:**

The system uses a spring-mass model with Verlet integration:

```python
# Force Calculations
F_spring = -k × displacement              # Hooke's Law
F_damping = -c × velocity                 # Viscous damping
F_external = user_force × influence_factor # User interaction

# Verlet Integration Scheme
acceleration = (F_spring + F_damping + F_external) / mass
velocity_new = velocity_old + acceleration × Δt
position_new = position_old + velocity_new × Δt
```

**📊 Influence Function:**

Implements cubic falloff for realistic tissue compression:

```python
influence = (1 - distance/radius)³  # Cubic distance falloff
force_vector = base_force × influence × direction_normalized
```

**🎨 Rendering Pipeline:**

1. **Vertex Transformation**: CPU-side deformation calculations
2. **Normal Recalculation**: Per-frame surface normal updates
3. **PBR Shading**: Physically-based rendering with Blinn-Phong model
4. **Shadow Mapping**: 2048×2048 resolution shadow atlas
5. **Anti-Aliasing**: Multi-sample anti-aliasing (MSAA 4x)

---

### 🛠️ Unity VR Scripts Overview

The repository includes Unity C# scripts for advanced VR interactions:

| Script | Purpose | Key Features |
|--------|---------|--------------|
| **MeshDeformer.cs** | Soft-body physics | Spring-mass system, collision handling |
| **VRKnife.cs** | Basic cutting tool | Haptic feedback, deformation on contact |
| **ThrustingKnife.cs** | Motor-powered scalpel | Trigger-activated thrust, enhanced cutting |
| **PowerKnife.cs** | Advanced cutting | Dual cutting modes, variable depth |
| **SimpleExtraction.cs** | Dental extraction | Velocity-based extraction detection |

> 📌 **Note**: Unity project files are not included due to GitHub's file size limitations. Only C# scripts are provided for reference and integration into existing Unity projects.

---

### 🐛 Troubleshooting

**❌ Issue: "Audio file not found"**
```
✅ Solution: Edit liver.py line 47 with the correct audio file path:
SOUND_FILE_PATH = r"C:\full\path\to\your\sounds\squash-sound.wav"
```

**❌ Issue: "Model appears black or unlit"**
```
✅ Solution: 
1. Update GPU drivers to the latest version
2. Verify OpenGL version: Must be 3.3 or higher
3. Check graphics card compatibility with Panda3D
```

**❌ Issue: "VR hand not responding to keyboard"**
```
✅ Solution:
1. Verify VR mode is enabled (button should display green)
2. Ensure keyboard focus is on the application window
3. Check that no other application is capturing WASD input
```

**❌ Issue: "Lag during tissue deformation"**
```
✅ Solution:
1. Reduce mesh resolution in cutting.py (mesh_res parameter)
2. Lower force slider value to reduce physics calculations
3. Close unnecessary background applications
4. Consider upgrading RAM if using complex models
```

**❌ Issue: "Git LFS models not downloading"**
```
✅ Solution:
1. Install Git LFS: git lfs install
2. Pull LFS files: git lfs pull
3. Verify .gitattributes configuration
```

---

## 👥 Development Team

This project was developed by a dedicated team of medical simulation enthusiasts:

### 👩‍💻 **Maryam Moustafa**
- 📧 Email: maryam23shabaan@gmail.com
- 💼 [GitHub](https://github.com/maryam305)
- 🔗 [LinkedIn](https://www.linkedin.com/in/maryam-moustafa-653257378)


### 👩‍💻 **Aya Sayed**
- 📧 Email: aya.sayed14827@gmail.com
- 💼 [GitHub](https://github.com/14930)
- 🔗 [LinkedIn](https://www.linkedin.com/in/aya-sayed-bb6a80397?utm_source=share_via&utm_content=profile&utm_medium=member_android)

### 👨‍💻 **Yousef Mahmoud**
- 📧 Email: youssef.abdelrauf23@gmail.com
- 💼 [GitHub](https://github.com/youssefabdelrauf)
- 🔗 [LinkedIn](https://www.linkedin.com/in/youssef-mahmoud-abdelrauf-1905b8370)

### 👩‍💻 **Rahma Ashraf**
- 📧 Email: ashrafrahma402@gmail.com
- 💼 [GitHub](https://github.com/rahmashraf)
- 🔗 [LinkedIn](https://eg.linkedin.com/in/rahma-ashraf-717012373)

---

## 🗺️ Roadmap

### 📅 Version 2.1 (Q2 2025)
- [ ] 🎮 Full VR headset integration (Oculus Quest, HTC Vive)
- [ ] 🤝 Multi-user collaborative training mode
- [ ] 🩸 Advanced cardiovascular system simulation
- [ ] 📊 MRI/CT scan data import and visualization

### 📅 Version 3.0 (Q4 2025)
- [ ] 🤖 AI-powered surgical guidance and error detection
- [ ] 📈 Performance assessment and skill tracking system
- [ ] ☁️ Cloud-based patient record synchronization
- [ ] 🌐 Web-based deployment for browser access

---

## 📊 Performance Metrics

**💻 System Performance:**
- 🎮 Render FPS: 60+ (with recommended GPU)
- ⚡ Physics Update: 120Hz refresh rate
- ⌨️ Input Latency: <16ms response time
- 💾 Memory Usage: ~500MB base + model size

**🗂️ Supported Model Complexity:**
- Minimum: 10,000 vertices
- Recommended: 50,000 - 100,000 vertices
- Maximum tested: 500,000 vertices

---

## 🔐 Privacy & Data Security

- 🔒 All patient records stored locally only
- 🚫 No telemetry or data collection to external servers
- 🏥 HIPAA compliance considerations for institutional deployment
- 🔐 Encrypted storage option available for sensitive data

---

## 📄 License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for complete terms and conditions.

---

## 🙏 Acknowledgments

Special thanks to:
- 🎓 Medical education advisors for clinical accuracy review
- 🎨 3D modeling community for anatomical asset resources
- 💻 Open-source contributors to Panda3D and Unity ecosystems
- 🏥 Medical students who provided valuable testing feedback

---

<div align="center">

**🏥 Made with ❤️ for advancing medical education through immersive technology**

⭐ **Star this repository if you find it useful!** ⭐

</div>

---

## 📧 Contact & Development Team
### **Project Contributor: Maryam Moustafa**
- **Email**: maryam23shabaan@gmail.com
  
- [GitHub](https://github.com/maryam305)
- [LinkedIn](https://www.linkedin.com/in/maryam-moustafa-653257378)
- 
**Project Contributor**: Aya Sayed
- Email: aya.sayed14827@gmail.com
- [GitHub](https://github.com/14930)
- [LinkedIn](https://www.linkedin.com/in/aya-sayed-bb6a80397?utm_source=share_via&utm_content=profile&utm_medium=member_android)
  
  
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


