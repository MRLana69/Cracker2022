using System;
using Cpp2ILInjected;
using UnityEngine;

public class CenterAnchor : MonoBehaviour
{
	private bool hasInited;

	private bool useY;

	private void Start()
	{
		_ = 4;
		_ = 1;
		_ = 2;
		_ = 1;
		_ = 1.45f;
		CancelInvoke();
	}

	public CenterAnchor()
	{
		//IL_0138: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01af: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0091: Expected VT, but got Obj
		//IL_00ad: Expected VT, but got Obj
		//IL_00b6: Expected Obj, but got I4
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 36);
		Transform transform2 = (Transform)(obj2 + 24);
		Transform transform3 = (Transform)(obj2 + 12);
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (System.Boolean)+3C]");
		object obj3 = 0;
		if (~(hasInited ? 1u : 0u) != 0)
		{
			if (~(useY ? 1u : 0u) == 0)
			{
				GameObject gameObject = base.gameObject;
				GameObject gameObject2 = base.gameObject;
				transform2.localPosition = (Vector3)gameObject2;
				GameObject gameObject3 = base.gameObject;
				transform3.localPosition = (Vector3)gameObject3;
				obj2 = 0;
				_ = 0;
				obj2 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21+14]");
				float num3 = 0f * 0.5f;
				_ = ((UnityEngine.Object)transform3).m_CachedPtr;
				transform = (Transform)obj2;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
			}
			hasInited = true;
		}
	}
}
