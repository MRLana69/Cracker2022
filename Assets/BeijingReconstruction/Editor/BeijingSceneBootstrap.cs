using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>Creates a clean playable starter scene and adds available Beijing meshes/materials.</summary>
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
        string folder="Assets/BeijingReconstruction/Scenes";
        if(!Directory.Exists(folder))Directory.CreateDirectory(folder);
        Scene scene=EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
        GameObject sun=new GameObject("Beijing reconstruction lighting");
        Light light=sun.AddComponent<Light>(); light.type=LightType.Directional; light.intensity=1.1f;
        sun.transform.rotation=Quaternion.Euler(38f,-28f,0f);
        GameObject game=new GameObject("Beijing endless runner"); game.AddComponent<BeijingRunnerGame>();
        AddImportedMesh("train_standard", "1.114_Beijing_train.mat", new Vector3(-8.1f,1f,25f), new Vector3(2.2f,2.6f,14f));
        AddImportedMesh("train_standard", "1.114_Beijing_train.mat", new Vector3(8.1f,1f,58f), new Vector3(2.2f,2.6f,14f));
        AddImportedMesh("sl_monument_01", "1.114_Beijing_environment.mat", new Vector3(-7f,0f,17f), new Vector3(3f,3f,3f));
        AddImportedMesh("sl_monument_02", "1.114_Beijing_environment.mat", new Vector3(7f,0f,43f), new Vector3(3f,3f,3f));
        AddImportedMesh("station_platforms", "1.114_Beijing_environment.mat", new Vector3(0f,0f,76f), new Vector3(1f,1f,1f));
        EditorSceneManager.SaveScene(scene,ScenePath);
        EditorBuildSettings.scenes=new[]{new EditorBuildSettingsScene(ScenePath,true)};
        AssetDatabase.SaveAssets(); AssetDatabase.Refresh();
        Debug.Log("Created BeijingRunner scene. Press Play to run the reconstructed starter.");
    }

    static void AddImportedMesh(string meshName,string materialName,Vector3 position,Vector3 targetSize)
    {
        string[] meshGuids=AssetDatabase.FindAssets(meshName+" t:Mesh",new[]{"Assets/Mesh"});
        Mesh mesh=null;
        for(int i=0;i<meshGuids.Length;i++)
        {
            string path=AssetDatabase.GUIDToAssetPath(meshGuids[i]);
            if(Path.GetFileNameWithoutExtension(path)==meshName){mesh=AssetDatabase.LoadAssetAtPath<Mesh>(path);if(mesh!=null)break;}
        }
        if(mesh==null){Debug.LogWarning("Optional Beijing mesh not found: "+meshName);return;}
        GameObject prop=new GameObject("Beijing art - "+meshName);
        prop.transform.position=position;
        MeshFilter filter=prop.AddComponent<MeshFilter>(); filter.sharedMesh=mesh;
        MeshRenderer renderer=prop.AddComponent<MeshRenderer>();
        string[] materialGuids=AssetDatabase.FindAssets(Path.GetFileNameWithoutExtension(materialName)+" t:Material",new[]{"Assets/Material"});
        Material material=null;
        for(int i=0;i<materialGuids.Length;i++)
        {
            string path=AssetDatabase.GUIDToAssetPath(materialGuids[i]);
            if(Path.GetFileName(path)==materialName){material=AssetDatabase.LoadAssetAtPath<Material>(path);if(material!=null)break;}
        }
        if(material!=null)renderer.sharedMaterial=material;
        Vector3 bounds=mesh.bounds.size;
        prop.transform.localScale=new Vector3(bounds.x>0?targetSize.x/bounds.x:1f,bounds.y>0?targetSize.y/bounds.y:1f,bounds.z>0?targetSize.z/bounds.z:1f);
    }
}
