using System;
using System.IO;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public static class GameObjectUtil
{
	public static T GetOrAddComponent<T>(GameObject target) where T : Component
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [target @ L0 (UnityEngine.GameObject)+14]");
		return (T)0;
	}

	public static T GetOrAddComponent<T>(GameObject target, bool willForceHideInInspector) where T : Component
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		object obj3 = target + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		T result = default;
		return result;
	}

	public static Component GetOrAddComponent(Type type, GameObject target, bool willForceHideInInspector)
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot((string)(object)type, (string)(object)target);
		bool flag2 = !willForceHideInInspector;
		bool flag3 = flag;
		if (!flag2)
		{
			bool isNetworkReachable = ((NetworkReachabilityMonitor)flag).IsNetworkReachable;
			flag3 = isNetworkReachable;
		}
		return (Component)flag3;
	}
}
