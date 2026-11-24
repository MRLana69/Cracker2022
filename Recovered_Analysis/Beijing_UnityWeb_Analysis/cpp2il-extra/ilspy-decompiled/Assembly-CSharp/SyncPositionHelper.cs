using System;
using Cpp2ILInjected;
using UnityEngine;

public class SyncPositionHelper : MonoBehaviour
{
	public GameObject fromObject;

	public GameObject toObject;

	private Transform fromTransform;

	private Transform toTransform;

	private void Start()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		object obj = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		object obj3 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		CancelInvoke();
	}

	private void LateUpdate()
	{
		//IL_0186: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_0158: Expected I4, but got Obj
		//IL_0129: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (fromObject == null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (toObject == null)
			{
				object obj3 = this + 20;
				int layer = fromObject.layer;
				obj3 = layer;
				object obj4 = this + 24;
				int layer2 = toObject.layer;
				obj4 = layer2;
				return;
			}
		}
		string original = tag;
		UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		string msg = string.ConcatArray((string[])(object)"SyncPositionHelper: Both from and to must be set. Disabling self ", (int)obj5);
		SDebug.LogFormat(msg, (object[])(object)this);
		tag = null;
	}

	public SyncPositionHelper()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Expected VT, but got Obj
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003a: Expected VT, but got Obj
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_005c: Expected VT, but got Obj
		//IL_0065: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		object obj = default;
		Transform transform = (Transform)(obj + 36);
		transform.position = (Vector3)fromTransform;
		Transform transform2 = (Transform)(obj + 24);
		transform2.position = (Vector3)toTransform;
		Transform transform3 = (Transform)(obj + 12);
		transform3.position = (Vector3)toTransform;
		obj = 0;
		_ = 0;
		obj = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v7 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		Transform transform4 = (Transform)(obj + 48);
		transform4 = (Transform)obj;
		Transform transform5 = transform4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform4.localPosition;
	}
}
