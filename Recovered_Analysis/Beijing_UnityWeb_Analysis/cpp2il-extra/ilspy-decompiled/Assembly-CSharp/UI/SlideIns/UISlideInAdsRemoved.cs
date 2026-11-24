using System;
using System.Collections;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInAdsRemoved : UISlideIn
{
	private UILabel _title;

	private UILabel _subtext;

	private HorizontalLayout _layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_01d0: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0083: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_00c4: Expected I, but got Obj
		//IL_02d4: Expected Obj, but got F4
		//IL_0111: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_024f: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got F4
		//IL_026c: Expected Obj, but got I4
		//IL_0152: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)base._darkBackground).FindKernel((string)null) != 0)
		{
			base._darkBackground.ResetAnchors();
		}
		object obj2 = this + 56;
		obj2 = slideIn;
		nint num3 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v15 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v56 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		Transform transform = (Transform)(obj4 + 12);
		bool flag = IPhoneXSupport.CheckIsiPhoneXDevice();
		string text = tag;
		if (flag)
		{
			nint num5 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v41 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v52 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isiPhoneXDevice = IPhoneXSupport.IsiPhoneXDevice;
			obj4 = 0;
			_ = 0;
			obj4 = 0f;
			object obj6 = 0 - (isiPhoneXDevice ? 1 : 0);
			_ = 0f;
		}
		else
		{
			object obj7 = this + 28;
			obj4 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v31+8]");
			_ = 0;
		}
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		IEnumerator enumerator = ((SpawnPool)(object)text).DoDespawnAfterSeconds(transform, 10f);
		_ = 1;
		base._slideOutTimer = 3f;
		base._readyForNextTimer = 1f;
		transform = (Transform)0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object value = default;
		Coroutine coroutine = StartCoroutineManaged("InvokeDidShowCallback", value);
		base._triggerSlideOut = true;
	}

	public UISlideInAdsRemoved()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got F4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got F4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		obj = 0f;
		_ = 65f;
		_ = 0f;
		object obj3 = obj2 + 24;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		object obj4 = this + 16;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 0f;
		_ = -5f;
		_ = 0f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 28;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11+8]");
		_ = 0;
		base._slideOutTimer = 3f;
		base._readyForNextTimer = 1f;
		CancelInvoke();
	}
}
