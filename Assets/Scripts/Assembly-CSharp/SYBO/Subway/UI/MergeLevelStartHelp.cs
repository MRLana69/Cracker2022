using UnityEngine;
using UnityEngine.SceneManagement;

namespace SYBO.Subway.UI;

public class MergeLevelStartHelp : MonoBehaviour
{
	public static string MERGE_SCENE_NAME_FOR_BUILDS = "Merge";

	public static string GUI_SCENE_NAME = "GUI";

	public static string MERGE_SCENE_NAME_SUBSTRING = "Merge";

	public unsafe static bool IsValidLoadedLevelNameForGameplay()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected VT, but got Unknown
		//IL_0073: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Scene activeScene = SceneManager.GetActiveScene();
		Scene scene = (Scene)(obj + 8);
		string text = ((Scene*)scene)->name;
		string text2 = text.ToLower();
		string value = MERGE_SCENE_NAME_SUBSTRING.ToLower();
		return text2.Contains(value);
	}
}
