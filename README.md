# Project Boost

A 3D space rocket flight game built in Unity where players must navigate a rocket through various obstacle courses and land safely on designated landing pads.

## Game Overview

Project Boost is an arcade-style game that challenges players to:
- Control a rocket with thrust and rotation mechanics
- Navigate through complex level layouts with obstacles
- Land safely on designated landing pads
- Survive hazardous terrain and enemy obstacles
- Progress through multiple levels of increasing difficulty

## Project Structure

### Assets
The project contains the following asset categories:

#### **Scripts/**
Game logic and mechanics including:
- Rocket movement and control systems
- Level management and collision handling
- UI and game state management
- Audio and particle effects controllers

#### **Scenes/**
Multiple playable levels:
- `Hill.unity` - Introductory terrain level
- `In & Out.unity` - Navigation-based level
- `Maze.unity` - Complex maze level
- Additional challenge levels

#### **Prefabs/**
Reusable game objects:
- `Rocket.prefab` - Player-controlled rocket
- `RocketCam.prefab` - Rocket follow camera
- `Ground.prefab` - Terrain/ground surfaces
- `Obstacle.prefab` - Hazardous obstacles
- `Landingpad.prefab` - Safe landing zones
- `Launchpad.prefab` - Level starting points
- `Directional Light.prefab` - Lighting setup

#### **Materials/**
Visual styling:
- `RocketMaterials/` - Rocket appearance
- `Skyboxes/` - Environment backgrounds
- Ground, obstacle, landing pad, and launchpad materials

#### **Particles/**
Visual effects:
- `Rocket Jet Particles.prefab` - Engine thrust effect
- `Side Thruster Particles.prefab` - Lateral thruster effect
- `Explosion Particles.prefab` - Crash/death effect
- `Success Particles.prefab` - Landing success effect

#### **Audio/**
Sound effects:
- `SFX - Main engine thrust.ogg` - Primary engine sound
- `SFX - Death Explosion.ogg` - Crash sound
- `SFX - Success.ogg` - Landing success sound

## Getting Started

### Prerequisites
- Unity 2020.3 LTS or later
- Basic understanding of Unity Editor

### Installation & Setup
1. Clone or download the project to your local machine
2. Open the project folder in Unity Hub
3. Select a scene from `Assets/Scenes/` to play
4. Press Play in the editor or build for your target platform

### Controls
Typical rocket control scheme (check your InputManager settings):
- **WASD/Arrow Keys** - Rotate rocket
- **Space** - Thrust/main engine
- **Q/E** - Side thrusters (if implemented)

## Level Design

Each level presents unique challenges:
- **Terrain obstacles** to navigate around
- **Landing pads** positioned at varying heights
- **Hazards** that end the level on collision
- **Particle effects** for visual feedback
- **Difficulty progression** from intro to advanced levels

## Technical Features

- **3D Physics** - Realistic rocket movement and gravity
- **Audio Management** - Dynamic sound effects for gameplay actions
- **Particle Systems** - Visual feedback for engines, explosions, and success
- **Prefab System** - Modular level design for easy customization
- **Material System** - Distinct visual identity for game elements

## Building & Deployment

To build the game:
1. Go to **File > Build Settings**
2. Add desired scenes to the build
3. Select target platform (Windows, Mac, Linux, WebGL, etc.)
4. Configure build settings as needed
5. Click **Build**

## Project Settings

Key configuration files in `ProjectSettings/`:
- `InputManager.asset` - Control bindings
- `QualitySettings.asset` - Graphics quality levels
- `Physics2DSettings.asset` / `DynamicsManager.asset` - Physics behavior
- `TagManager.asset` - Game object tags and layers

## Development Notes

- Use prefabs for all reusable game objects to maintain consistency
- Particle effects are pre-configured for visual feedback
- Audio clips are included for key gameplay moments
- Materials can be customized to change visual appearance
- Physics settings are tuned for arcade-style gameplay