namespace SYBO.Components.Utilities;

public class AssetLoader`2 : AssetLoader
{
	private static Loader _instance; //Field offset: 0x0
	public UnityEvent OnAssetsChanged; //Field offset: 0x0
	protected string[] _assetPaths; //Field offset: 0x0
	protected List<T> _includedAssets; //Field offset: 0x0
	protected List<AssetInfo> _assetInfo; //Field offset: 0x0

	public static bool HasInstance
	{
		 get { } //Length: 26
	}

	public static Loader Instance
	{
		 get { } //Length: 546
	}

	private static string LoaderName
	{
		 get { } //Length: 549
	}

	private static string LoaderPath
	{
		 get { } //Length: 104
	}

	public AssetLoader`2() { }

	public static bool get_HasInstance() { }

	public static Loader get_Instance() { }

	private static string get_LoaderName() { }

	private static string get_LoaderPath() { }

	public List<T> LoadAssets() { }

	private void SetIncludedAssets(List<T> value) { }

}

