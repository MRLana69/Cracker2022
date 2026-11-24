namespace SYBO.Components.Utilities;

public class AssetLoaderPathAttribute : Attribute
{
	public const string ErrorDirectoryDoesNotExist = "The specified path is deemed invalid. Please ensure that the direcotry exists. Specified path: {0}"; //Field offset: 0x0
	public const string ErrorDirectoryResources = "The specified directory path does not end with '.../Resources'. Specified path: {0}"; //Field offset: 0x0
	public const string ErrorDirectoryAssets = "The specified directory path does not start with 'Assets/'. Specified path: {0}"; //Field offset: 0x0
	public const string FileExtension = ".asset"; //Field offset: 0x0
	private string _directory; //Field offset: 0x8
	private string _assetName; //Field offset: 0xC

	public string AssetName
	{
		 get { } //Length: 25
	}

	public string AssetNameWithFileExtension
	{
		 get { } //Length: 6
	}

	public string Directory
	{
		 get { } //Length: 9
	}

	public string FullPath
	{
		 get { } //Length: 62
	}

	public AssetLoaderPathAttribute(string directoryPath, string assetName) { }

	public string get_AssetName() { }

	public string get_AssetNameWithFileExtension() { }

	public string get_Directory() { }

	public string get_FullPath() { }

	private string GetFullSystemPathTo(string assetFolderRelativePath) { }

	private bool ValidateDirectoryPath(string directoryPath) { }

}

