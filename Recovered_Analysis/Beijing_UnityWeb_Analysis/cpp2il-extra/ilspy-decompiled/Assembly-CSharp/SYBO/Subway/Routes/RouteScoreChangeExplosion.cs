using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteScoreChangeExplosion : MonoBehaviour
{
	public static string PREFAB_RESOURCE_PATH;

	public static RouteScoreChangeExplosion CreateAtPosition(Vector3 positionVector3)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [positionVector3 @ L0 (UnityEngine.Vector3)+4C]");
		return (RouteScoreChangeExplosion)((ComputeShader)0).FindKernel(null);
	}

	public RouteScoreChangeExplosion()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}

	static RouteScoreChangeExplosion()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		RouteManagerConfigurationSO.PREFAB_ASSET_PATH = "Assets/Resources/Prefabs/Routes/RouteManagerConfigurationSO.asset";
		nint num = (nint)typeof(RouteManagerConfigurationSO);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<SYBO.Subway.Routes.RouteManagerConfigurationSO>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = "Prefabs/Routes/RouteManagerConfigurationSO";
	}
}
