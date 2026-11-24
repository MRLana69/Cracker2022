using System;
using Cpp2ILInjected;
using Kiloo.Plugins.Facebook;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Popups.SecretPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups.SettingsPopupInternal;

public class SettingsLogInFacebookButton : MonoBehaviour
{
	private UILabel _title;

	private UILabel _description;

	private Layout _layout;

	private UISprite _fbIcon;

	private UISprite _spinner;

	private GameObject _overlay;

	private UISprite _fill;

	private SettingsPopup _settingsPopup;

	private bool _facebookLoginRunning;

	public void InitButton(SettingsPopup settingsPopup)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
		string text = _fill.tag;
		((GameObject)(object)text).tag = (string)(object)settingsPopup;
		bool isTrigger = (byte)(settingsPopup ^ 1) != 0;
		((Collider)(object)_settingsPopup).isTrigger = isTrigger;
	}

	private void OnClick()
	{
		CancelInvoke();
	}

	private void OnFacebookLoginResult(bool loggedIn)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 40;
		obj = loggedIn;
	}

	private void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		//IL_004f: Expected Obj, but got I4
		if (onFinishCallback == null && ~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			_facebookLoginRunning = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			((SettingsLogInFacebookButton)null).FacebookStatusChanged(flag);
		}
	}

	private void OnFailSlideInFinish()
	{
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_0186: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I
		//IL_01dc: Expected I, but got Obj
		//IL_01f2: Expected Obj, but got I
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0250: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I4
		//IL_0270: Expected Obj, but got I4
		//IL_0107: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		nint num2 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v46 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7855");
		_facebookLoginRunning = true;
		nint num4 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<SocialManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v42 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = this;
		if (SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported, obj6))
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v32 (Il2CppClass<UIScreenController>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v38 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).QueueMessage((string)1);
		}
		this._002Ector();
	}

	private void FacebookStatusChanged(bool success)
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 13;
		_ = 0;
		object obj2 = text + 24;
		obj2 = success;
		((UIScreenController)flag)._QueueMessage(text);
	}

	private void OnEnable()
	{
		((SecretHelper)this).UpdateTitle((string)null);
	}

	private void OnDisable()
	{
		SetToConnectingState();
	}

	private void SetToLogInState()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (~(_facebookLoginRunning ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
		_facebookLoginRunning = false;
	}

	private unsafe void SetToConnectingState()
	{
		//IL_0205: Expected Obj, but got I4
		//IL_0213: Expected I, but got Obj
		//IL_0229: Expected Obj, but got I
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got VT
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected VT, but got Unknown
		//IL_028e: Expected F4, but got Obj
		//IL_0289: Expected native int or pointer, but got VT
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02b6: Expected F4, but got Obj
		//IL_02b1: Expected native int or pointer, but got VT
		//IL_02cb: Expected F4, but got I
		//IL_02c6: Expected native int or pointer, but got VT
		//IL_02da: Expected I4, but got VT
		//IL_0060: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_030b: Expected I4, but got Obj
		//IL_00fd: Expected I4, but got Obj
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_0343: Expected Obj, but got I4
		//IL_0365: Expected F4, but got Obj
		//IL_0360: Expected native int or pointer, but got VT
		//IL_037a: Expected F4, but got I
		//IL_0375: Expected native int or pointer, but got VT
		//IL_0389: Expected I4, but got VT
		//IL_0397: Expected Obj, but got I4
		//IL_03b9: Expected F4, but got Obj
		//IL_03b4: Expected native int or pointer, but got VT
		//IL_03ce: Expected F4, but got I
		//IL_03c9: Expected native int or pointer, but got VT
		//IL_03dd: Expected I4, but got VT
		//IL_014c: Expected I, but got Obj
		//IL_01b9: Expected Obj, but got I4
		_overlay.tag = (string)1;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5 (Il2CppClass<GlobalColors>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v57 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 48;
		obj2 = GlobalColors.TERTIARY_ACTION_COLOR;
		object obj4 = obj3 + 52;
		obj4 = obj2;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 56);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		object obj5 = obj3 + 32;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v16+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_fill.rawPivot = (UIWidget.Pivot)matrix4x;
		string text = _description.tag;
		((GameObject)(object)text).tag = (string)1;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v23 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v53 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("SETTINGS_POPUP_FB_TITLE");
		_title.fontSize = (int)text2;
		string text3 = Strings.GetDefault("SETTINGS_POPUP_FB_LOG_IN_DESC");
		_description.fontSize = (int)text3;
		nint num5 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v20 (Il2CppClass<UI.ColorData>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v41 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj8 = obj3 + 16;
		object obj9 = (flag ? 1 : 0) + 124;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S2_v28+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v35+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_title.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj10 = (flag ? 1 : 0) + 60;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v38+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_description.rawPivot = (UIWidget.Pivot)matrix4x;
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)null);
		string text4 = _fbIcon.tag;
		((GameObject)(object)text4).tag = (string)1;
		string text5 = _spinner.tag;
		((GameObject)(object)text5).tag = null;
		Collider component = GetComponent<Collider>();
		component.isTrigger = true;
	}

	public unsafe SettingsLogInFacebookButton()
	{
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got VT
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected VT, but got Unknown
		//IL_01dd: Expected F4, but got Obj
		//IL_01d8: Expected native int or pointer, but got VT
		//IL_01f7: Expected F4, but got Obj
		//IL_01f2: Expected native int or pointer, but got VT
		//IL_020c: Expected F4, but got I
		//IL_0207: Expected native int or pointer, but got VT
		//IL_021b: Expected I4, but got VT
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_024c: Expected I4, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I4
		_overlay.tag = null;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5 (Il2CppClass<GlobalColors>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v41 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 20;
		obj2 = GlobalColors.SOCIAL_GREY;
		object obj4 = obj3 + 16;
		obj4 = obj2;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_fill.rawPivot = (UIWidget.Pivot)matrix4x;
		string text = _description.tag;
		((GameObject)(object)text).tag = null;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v22 (Il2CppClass<Strings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v37 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("SOCIAL_BUTTON_FEEDBACK_CONNECTING");
		_title.fontSize = (int)text2;
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)null);
		string text3 = _fbIcon.tag;
		((GameObject)(object)text3).tag = null;
		string text4 = _spinner.tag;
		((GameObject)(object)text4).tag = (string)1;
		Collider component = GetComponent<Collider>();
		component.isTrigger = false;
	}
}
