using System;
using Cpp2ILInjected;
using UnityEngine;

public class PointConstraint : MonoBehaviour
{
	private Transform transformCached;

	public Transform master
	{
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
	}

	private void LateUpdate()
	{
	}

	public PointConstraint()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_006b: Expected VT, but got Obj
		//IL_007f: Expected VT, but got Obj
		//IL_0088: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 36);
		Transform transform2 = (Transform)(obj2 + 24);
		Transform transform3 = (Transform)(obj2 + 12);
		if (!(transformCached != null))
		{
			GameObject gameObject = base.gameObject;
			transform2.localPosition = (Vector3)transformCached;
			transform3.localPosition = (Vector3)transformCached;
			obj2 = 0;
			_ = 0;
			obj2 = transform2;
			_ = 0f;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			transform = (Transform)obj2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
		}
	}
}
