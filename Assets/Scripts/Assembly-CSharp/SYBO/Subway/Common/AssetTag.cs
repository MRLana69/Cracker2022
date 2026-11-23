using UnityEngine;

namespace SYBO.Subway.Common;

public class AssetTag : MonoBehaviour
{
	private AssetTagThemeUsage _themeUsage;

	public AssetTagThemeUsage ThemeUsage => _themeUsage;

	public bool HasTag(AssetTagThemeUsage themeTags)
	{
		//IL_000f: Expected Obj, but got I4
		object obj = _themeUsage & themeTags;
		return obj != null;
	}
}
