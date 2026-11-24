namespace SYBO.Subway.Common;

public class AssetTag : MonoBehaviour
{
	private AssetTagThemeUsage _themeUsage; //Field offset: 0xC

	public AssetTagThemeUsage ThemeUsage
	{
		 get { } //Length: 66
	}

	public AssetTag() { }

	public void AddTags(AssetTagThemeUsage themeTags) { }

	public void ClearTags(AssetTagThemeUsage themeTags) { }

	public AssetTagThemeUsage get_ThemeUsage() { }

	public bool HasTag(AssetTagThemeUsage themeTags) { }

}

