using System;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

namespace SYBO.Common.Visuals;

[Serializable]
public class QualityFx
{
	private QualityFeature _feature;

	private MonoBehaviour _unsupportedPrefab;

	private MonoBehaviour _supportedPrefab;

	public T InstantiateEffect<T>() where T : MonoBehaviour
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0057: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v11 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v12 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		nint num5 = 0;
		IntPtr intPtr = num5;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		obj = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S0_v17 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Visuals.QualityFx::InstantiateEffect>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public unsafe T InstantiateEffect<T>(Vector3 position, Quaternion rotation) where T : MonoBehaviour
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Expected VT, but got Obj
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got F4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected VT, but got Unknown
		//IL_00ec: Expected F4, but got I
		//IL_00e7: Expected native int or pointer, but got VT
		//IL_00f9: Expected F4, but got Obj
		//IL_00f4: Expected native int or pointer, but got VT
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		object obj3 = 16;
		obj3 = 12;
		object prefab = (object)this + obj3;
		_ = position.z;
		_ = position.x;
		_ = rotation.z;
		obj = rotation.x;
		object obj4 = obj - 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		obj4 = obj;
		Quaternion quaternion = (Quaternion)(obj4 - 32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v17+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v17+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v17+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		((Quaternion*)(nint)quaternion)->x = (float)obj4;
		Vector3 position2 = (Vector3)(quaternion + 16);
		T val2 = (T)(object)InstantiateInternal<T>((T)prefab, position2, quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		T result = default;
		return result;
	}

	private T InstantiateInternal<T>(T prefab, Vector3 position, Quaternion rotation) where T : MonoBehaviour
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I
		//IL_007e: Expected Obj, but got F4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		if (prefab == null)
		{
			string name = prefab.name;
			string text = "Could not instantiate effect: " + name;
		}
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v15 (Il2CppMethodRgctx<SYBO.Common.Visuals.QualityFx::InstantiateInternal>)+4]");
		object obj3 = 0;
		nint num2 = 0;
		_ = position.z;
		_ = position.x;
		_ = rotation.z;
		obj = rotation.x;
		object obj4 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S0_v16+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}
}
