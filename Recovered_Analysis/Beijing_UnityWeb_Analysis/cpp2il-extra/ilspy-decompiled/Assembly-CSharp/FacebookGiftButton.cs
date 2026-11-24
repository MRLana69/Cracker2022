using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Timer;
using UnityEngine;

public class FacebookGiftButton : MonoBehaviour
{
	private UILabel title;

	private UILabel description;

	private UILabel _getLabel;

	private GameObject _breadCrumb;

	private int earnCurrencyProfileIndex;

	private Action _onClickDelegate;

	private bool _didEnableBreadCrumb;

	public unsafe void Init(int earnCurrencyProfileIndex, string earnerTitle, string earnerDesc, Action onClickDelegate, UIScrollView _panel)
	{
		//IL_0209: Expected I, but got Obj
		//IL_021f: Expected Obj, but got I
		//IL_024a: Expected Obj, but got Ref
		//IL_0261: Expected I, but got Obj
		//IL_0277: Expected Obj, but got I
		//IL_02d1: Expected Ref, but got VT
		//IL_02e7: Expected Obj, but got Ref
		//IL_02fa: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00d0: Expected I, but got Obj
		//IL_00e6: Expected Obj, but got I
		//IL_0111: Expected I, but got Obj
		GameObject gameObject = title.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v51 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Quaternion reference = default;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		Vector3 one = Vector3.one;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v47 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Quaternion reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 32);
		reference2 = ref *(Quaternion*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference, out reference2);
		reference2 = ref *(Quaternion*)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		Vector3 localScale = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).localScale;
		((UISprite)(object)title).fillCenter = (byte)(int)earnerTitle != 0;
		((GameObject)(object)description).tag = (string)(object)onClickDelegate;
		((UISprite)(object)_breadCrumb).fillCenter = (byte)earnCurrencyProfileIndex != 0;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_getLabel).FindKernel((string)null) != 0)
		{
			((GameObject)(object)_getLabel).tag = earnerDesc;
			AwardStarHandler component = ((GameObject)(object)_getLabel).GetComponent<AwardStarHandler>();
			object obj5 = (object)earnerDesc & (object)_panel;
			if (obj5 != null)
			{
				component.animeStars = true;
				AwardStarHandler component2 = ((GameObject)(object)_getLabel).GetComponent<AwardStarHandler>();
				component2._002Ector();
			}
			else
			{
				component.animeStars = false;
				((GameObject)(object)_onClickDelegate).tag = null;
			}
		}
	}

	private void OnClick()
	{
		CancelInvoke();
	}

	public void LateUpdate()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((HeadstartTier)earnCurrencyProfileIndex)._002Ector();
		if (_onClickDelegate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public FacebookGiftButton()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		if (~(_didEnableBreadCrumb ? 1u : 0u) != 0)
		{
			_didEnableBreadCrumb = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			string text = default;
			text.m_stringLength = (int)num;
			_ = 0;
			object obj = text + 16;
			obj = this;
			Timer.Log(text);
		}
	}

	private void _003CLateUpdate_003Eb__9_0()
	{
		CancelInvoke();
	}
}
