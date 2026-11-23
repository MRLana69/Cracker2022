# Beijing Unity playable reconstruction (starter)

Unity target: **2019.2.0f1**, matching the WebGL build metadata. This is a separate working copy; the Beijing source analysis and AssetRipper export were not edited.

## Open and run
1. Extract this folder/ZIP on a computer with Unity 2019.2.0f1 installed.
2. Open this project in Unity Hub and wait for asset import.
3. The editor bootstrap creates `Assets/BeijingReconstruction/Scenes/BeijingRunner.unity` and sets it as the first build scene. If it does not, use **Beijing Reconstruction → Create or reset playable scene**.
4. Press **Play**. Desktop: arrow keys/A-D change lanes, Up/W/Space jumps, Down/S slides, R restarts. Touch: swipe in four directions; tap to restart after a crash.

## What this reconstruction is
A fresh, playable endless-runner scaffold with three lanes, increasing speed, coins, jump/slide barriers, a Beijing-inspired red/gold palette, track/camera, score and retry. It is **not** the original game rebuilt byte-for-byte. The exported Beijing art payload is included for future integration/reference; core original gameplay code is not present in the dump.

The AssetRipper C# output was intentionally excluded because it consists of placeholder/stub sources, not recovered implementation. No original scripts have been silently replaced. The playable scene is procedural and independent of those stubs.

## Important validation limit
This environment has no Unity Editor installation, so the project files and gameplay source were prepared but Unity import, C# compilation, Play Mode and platform builds could not be executed here. Unity may report missing-script components when opening preserved AssetRipper scenes/prefabs. The new generated runner scene uses built-in primitives and does not rely on them.

## Included
- Exported assets from the prior AssetRipper export, excluding its `Assets/Scripts` placeholder sources and `Assets/Plugins` payload.
- Unity project settings/packages from the export, with editor target set to 2019.2.0f1.
- Independent `BeijingRunnerGame.cs` runtime and `BeijingSceneBootstrap.cs` Editor scene generator.
- `RECONSTRUCTION_STATUS.json` lists the source and known limitations.
