# Audio Manager

## Overview

This project is an audio management tool designed for use in Unity. It simplifies the handling of audio clips by utilizing scriptable objects and provides an easy-to-use interface for playing, stopping, and managing audio clips within a Unity project.

## Features

- **Scriptable Object for Audio Clips:** Add, update, and delete audio clips using the `AudioClipContainer` scriptable object.
- **Enum Generation:** Automatically generates enums based on the names of the audio clips.
- **Audio Management:** Use the `AudioService` class to play, stop, and mute audio clips using the generated enums.
- **Flexible Integration:** The `AudioService` class can be used as a MonoBehaviour singleton or injected using a dependency injection framework like Zenject or VContainer.

## Usage

### Adding Audio Clips

1. Navigate to `Assets/AudioManagement/Resources`.
2. Create or select an `AudioClipContainer` scriptable object.
3. Add, update, or delete audio clips within this scriptable object.
4. Enums corresponding to the audio clip names will be automatically generated.

### Managing Audio Clips

Below are examples of how to use the various methods:

- **Play Audio:**
  ```csharp
  audioService.Play(AudioClipEnum.YourClipName);

- **Mute Audio Clip:**
  ```csharp
  audioService.Mute(AudioClipEnum.YourClipName, true);  // Mutes the specific clip

- **Mute Audio by Type:**
  ```csharp
  audioService.MuteType(SoundType.Music, true);  // Mutes all clips of type Music

- **Mute All Audio:**
  ```csharp
  audioService.Play(AudioClipEnum.YourClipName);

- **Play Audio:**
  ```csharp
  audioService.MuteAll(true);  // Mutes all audio clips

- **Get Mute Status:**
  ```csharp
  bool isMuted = audioService.GetMuteStatus(SoundType.Music);  // Returns mute status of Music type clips

- **Stop Audio Clip:**
  ```csharp
  audioService.Stop(AudioClipEnum.YourClipName);  // Stops the specific clip

- **Stop Audio by Type:**
  ```csharp
  audioService.StopType(SoundType.Music);  // Stops all clips of type Music

- **Stop All Audio:**
  ```csharp
  audioService.StopAll();  // Stops all audio clips
  
