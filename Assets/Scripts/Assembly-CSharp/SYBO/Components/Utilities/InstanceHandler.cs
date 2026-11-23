using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public static class InstanceHandler
{
	public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

	public delegate void DestroyDelegate(GameObject instance);

	public static InstantiateDelegate InstantiateDelegates;

	public static DestroyDelegate DestroyDelegates;

	internal unsafe static GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b9: Expected F4, but got I
		//IL_00b4: Expected native int or pointer, but got VT
		//IL_00db: Expected F4, but got I
		//IL_00d6: Expected native int or pointer, but got VT
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected VT, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 96);
		if (InstantiateDelegates != null)
		{
			InstantiateDelegate instantiateDelegates = InstantiateDelegates;
			_ = pos.z;
			_ = pos.x;
			_ = rot.z;
			_ = rot.x;
			object obj2 = quaternion + 48;
			object obj3 = quaternion + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v24.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			GameObject result = default;
			return result;
		}
		_ = pos.z;
		_ = pos.x;
		_ = rot.z;
		_ = rot.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		Vector3 position = (Vector3)(quaternion + 16);
		return Object.Instantiate(prefab, position, quaternion);
	}

	internal static void DestroyInstance(GameObject instance)
	{
		if (DestroyDelegates != null)
		{
			DestroyDelegate destroyDelegates = DestroyDelegates;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		else
		{
			Object.Destroy(instance);
		}
	}
}
