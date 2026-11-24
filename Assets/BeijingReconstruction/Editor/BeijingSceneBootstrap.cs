using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>Creates a clean playable starter scene independent of incomplete recovered assets.</summary>
[InitializeOnLoad]
public static class BeijingSceneBootstrap
{
    const string ScenePath = "Assets/BeijingReconstruction/Scenes/BeijingRunner.unity";

    static BeijingSceneBootstrap()
    {
        EditorApplication.delayCall += CreateIfMissing;
    }

    static void CreateIfMissing()
    {
        if (EditorApplication.isCompiling || EditorApplication.isPlayingOrWillChangePlaymode) return;
        if (File.Exists(ScenePath)) return;
        CreatePlayableScene();
    }

    [MenuItem("Beijing Reconstruction/Create or reset playable scene")]
    public static void CreatePlayableScene()
    {
        string folder = "Assets/BeijingReconstruction/Scenes";
        if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

        Scene scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        GameObject sun = new GameObject("Beijing reconstruction lighting");
        Light light = sun.AddComponent<Light>();
        light.type = LightType.Directional;
        light.intensity = 1.1f;
        sun.transform.rotation = Quaternion.Euler(38f, -28f, 0f);

        GameObject game = new GameObject("Beijing endless runner");
        game.AddComponent<BeijingRunnerGame>();

        EditorSceneManager.SaveScene(scene, ScenePath);
        EditorBuildSettings.scenes = new[] { new EditorBuildSettingsScene(ScenePath, true) };
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("Created BeijingRunner scene. Press Play to run the reconstructed starter.");
    }
}
