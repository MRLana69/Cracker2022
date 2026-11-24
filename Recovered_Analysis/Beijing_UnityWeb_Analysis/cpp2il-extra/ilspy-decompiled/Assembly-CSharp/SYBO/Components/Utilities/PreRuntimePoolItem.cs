using System;
using Cpp2ILInjected;
using SYBO.Components.Json;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class PreRuntimePoolItem : MonoBehaviour
{
	public string poolName;

	public string prefabName;

	public bool despawnOnStart;

	public bool doNotReparent;

	private void Start()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
	}

	public PreRuntimePoolItem()
	{
		//IL_014f: Expected Obj, but got I4
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_00c5: Expected I, but got Obj
		//IL_00db: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01b3: Expected I4, but got Obj
		//IL_0092: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_0106: Expected I, but got Obj
		Transform transform = (Transform)0;
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v38 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform2 = ((SpawnPool)(object)PoolManager.Pools).Spawn((Transform)(object)poolName, transform);
		if ((object)transform2 != null)
		{
			GameObject type = gameObject;
			bool flag = despawnOnStart;
			bool flag2 = doNotReparent;
			JsonContext context = (JsonContext)((flag2 ? 1 : 0) ^ 1);
			((JsonFileSerializer)(object)transform).SerializeToMultipleFiles((Type)(object)type, (object)prefabName, (string)flag, context);
			return;
		}
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v30 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object format = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
		Log.Utilities.LogErrorFormat((int)"PreRuntimePoolItem Error ('{0}'): No pool with the name '{1}' exists! Create one using the PoolManager Inspector interface or PoolManager.CreatePool().See the online docs for more information at http://docs.poolmanager.path-o-logical.com", (string)(object)format, poolName);
	}
}
