# Unity Audio Project – Audio Implementation Demo

This project showcases the implementation of interactive audio systems in Unity, fulfilling the specified course requirements.

> ⚠️ **Note to Professor:**  
All audio features are implemented **only in the scene named `Tutorial`**. Please ignore any other scenes — they are not part of the assignment submission.

> 🔁 **Important:**  
Please review **only the branch named `SebastianMoraBermejo-AA3-Unity-Integration`** in the repository. Other branches may contain outdated or unrelated versions.

## ✅ Implemented Features in `Tutorial` Scene

- **12+ Audio Sources** with spatialization and variation.
- **12+ Unique Audio Clips**, including ambient loops, actions, and environmental sounds.
- **3D Spatialization** with:
  - Rolloff curves.
  - Min/Max distance settings.
- **Soundscape Immersion**: ambient breeze, glowing mirror, footsteps, etc.
- **Keyframe-Based Sound**: jump sound triggered via animation event.
- **Collision-Based Sounds**: jumping, footsteps, pushing books.
- **Interactive Audio via Snapshots**:
  - First door → music fades out, breeze starts.
  - Second door → music resumes, breeze stops.
- **Audio Mixer Routing**: all AudioSources are connected to `SFX`, `Music`, or `Ambience` groups.
- **Memory-Optimized Load Types**:
  - Music clips set to `Streaming`.
  - SFX set to `Decompress on Load`.

## 🎮 How to Test

1. Open the scene named `Tutorial`.
2. Play through the level and interact with elements:
   - Walk, jump, push books.
   - Press buttons, collect the key, and open doors.
3. Observe transitions between music and ambient sounds as feedback to player progression.

---

Thank you!

