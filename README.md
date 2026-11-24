# Beijing Runner Reconstruction (Unity 2019.2.0f1)

A small, independent playable endless-runner prototype with three lanes, keyboard/touch controls, jump, slide, coins, obstacles, score, increasing speed and restart. It is not a byte-for-byte restoration or an official game build.

## Open and build

1. Open this project folder in Unity Editor **2019.2.0f1** and wait for package resolution/import.
2. Open `Assets/BeijingReconstruction/Scenes/BeijingRunner.unity` and press Play.
3. For WebGL, install WebGL Build Support for the same Editor version, choose **File → Build Settings → WebGL → Switch Platform**, verify `BeijingRunner` is enabled in Scenes In Build, then Build.

## Dependencies

The prototype uses Unity built-in modules declared in `Packages/manifest.json`, including `com.unity.modules.inputlegacy` 1.0.0 for `Input.GetKeyDown` and touch input. It requires no third-party package. A target such as WebGL also requires its matching Editor build-support module.

## Validation status

The scene, script GUID, package manifest and Build Settings were checked statically. This sandbox did not have Unity Editor or a C# compiler, so import, compilation, Play Mode and a WebGL build have not been run; therefore a clean compile is not yet verified.
