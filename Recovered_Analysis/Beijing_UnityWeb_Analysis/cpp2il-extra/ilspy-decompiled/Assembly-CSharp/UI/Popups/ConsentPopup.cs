using System;
using Cloud;
using Cpp2ILInjected;
using Info;
using Kiloo.Analytics;
using Kiloo.Common.Extensions;
using UI.Generic;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class ConsentPopup : UIScreen
{
	private UILabel _consentLongDetails;

	private UILabel _consentAffirmation;

	private UILabel _okLabel;

	private UILabel _acceptLabel;

	private UIButtonOverlayOff _okButton;

	private UISprite _acceptButtonFill;

	private UISprite _acceptButtonOverlay;

	private ButtonText _okButtonText;

	private UISprite _checkMarkSprite;

	private bool _isAcceptChecked;

	private TweenAlpha _checkMarkTweenCoroutine;

	public override void Init()
	{
		//IL_01e3: Expected Obj, but got I4
		//IL_0203: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0257: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3+60]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S4_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S4_v8+48]");
		object obj9 = 0;
		object obj10 = obj9 & 0x7FF;
		object obj11 = obj10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S5_v6 (should have been resolved before IL gen)");
		object obj12 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public override void Show()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		ShowIfInactive();
		CheckboxClicked();
		object obj = this + 68;
		ButtonText component = _okLabel.GetComponent<ButtonText>();
		obj = component;
		_okButtonText._002Ector();
	}

	private unsafe void RefreshLabels()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got VT
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected VT, but got Unknown
		//IL_01c0: Expected F4, but got Obj
		//IL_01bb: Expected native int or pointer, but got VT
		//IL_01da: Expected F4, but got Obj
		//IL_01d5: Expected native int or pointer, but got VT
		//IL_01ef: Expected F4, but got I
		//IL_01ea: Expected native int or pointer, but got VT
		//IL_01fe: Expected I4, but got VT
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		base.Hide();
		_okButton.GoToSelectedState();
		_isAcceptChecked = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v40 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool fontSize = Strings.IsMapped("ConsentAcceptUnchecked");
		_acceptLabel.fontSize = (fontSize ? 1 : 0);
		nint num3 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v17 (Il2CppClass<GlobalColors>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v34 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 20;
		obj3 = GlobalColors.PRIMARY_ACTION_COLOR;
		object obj5 = obj4 + 16;
		obj5 = obj3;
		Matrix4x4 matrix4x = (Matrix4x4)(obj4 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_acceptButtonFill.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj6 = this - -64;
		string text = ((Component)obj6).tag;
		((GameObject)(object)text).tag = (string)1;
	}

	public void CheckboxClicked()
	{
		//IL_0195: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool fontSize = Strings.IsMapped("ConsentAffirmation");
		_consentAffirmation.fontSize = (fontSize ? 1 : 0);
		bool flag = Strings.IsMapped("ConsentDetails");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v9 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S2_v27 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string ratingURL = Globals.RatingURL;
		object obj3 = ((IConvertible)"[u][c][2572A8][url=").ToType((Type)(object)ratingURL, (IFormatProvider)(object)"]");
		throw new ArrayTypeMismatchException();
	}

	public unsafe void AllowClicked()
	{
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected VT, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_0393: Expected I, but got Obj
		//IL_03a9: Expected Obj, but got I
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_03cf: Expected Obj, but got VT
		//IL_03e4: Expected F4, but got Obj
		//IL_03df: Expected native int or pointer, but got VT
		//IL_03fe: Expected F4, but got Obj
		//IL_03f9: Expected native int or pointer, but got VT
		//IL_0413: Expected F4, but got I
		//IL_040e: Expected native int or pointer, but got VT
		//IL_0422: Expected I4, but got VT
		//IL_0145: Expected I, but got Obj
		//IL_02d4: Expected I, but got Obj
		//IL_02ea: Expected Obj, but got I
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_0192: Expected I, but got Obj
		//IL_0310: Expected Obj, but got VT
		//IL_0325: Expected F4, but got Obj
		//IL_0320: Expected native int or pointer, but got VT
		//IL_033f: Expected F4, but got Obj
		//IL_033a: Expected native int or pointer, but got VT
		//IL_0354: Expected F4, but got I
		//IL_034f: Expected native int or pointer, but got VT
		//IL_0363: Expected I4, but got VT
		//IL_005f: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0473: Expected Obj, but got I4
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 32);
		object obj2 = obj + 16;
		object obj3 = obj + 24;
		object obj4 = obj + 20;
		bool isAcceptChecked = _isAcceptChecked;
		bool isAcceptChecked2 = (byte)((isAcceptChecked ? 1u : 0u) ^ 1u) != 0;
		_isAcceptChecked = isAcceptChecked2;
		if (~(_isAcceptChecked ? 1u : 0u) == 0)
		{
			_okButton.GoToNotAvailableState();
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v57 (Il2CppClass<Strings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v82 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool fontSize = Strings.IsMapped("ConsentAcceptChecked");
			_acceptLabel.fontSize = (fontSize ? 1 : 0);
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v65 (Il2CppClass<GlobalColors>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v76 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE;
			obj3 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_acceptButtonFill.rawPivot = (UIWidget.Pivot)matrix4x;
		}
		else
		{
			_okButton.GoToSelectedState();
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v26 (Il2CppClass<Strings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v51 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool fontSize2 = Strings.IsMapped("ConsentAcceptUnchecked");
			_acceptLabel.fontSize = (fontSize2 ? 1 : 0);
			nint num7 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v34 (Il2CppClass<GlobalColors>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v45 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.PRIMARY_ACTION_COLOR;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_acceptButtonFill.rawPivot = (UIWidget.Pivot)matrix4x;
		}
		object obj9 = this + 80;
		string text = _checkMarkSprite.tag;
		if (~(_isAcceptChecked ? 1u : 0u) == 0)
		{
			float num9 = 1f;
		}
		else
		{
			float num9 = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @883B");
		object obj10 = default;
		obj9 = obj10;
		object obj11 = this - -64;
		string text2 = ((Component)obj11).tag;
		bool isAcceptChecked3 = _isAcceptChecked;
		string text3 = (string)((isAcceptChecked3 ? 1 : 0) ^ 1);
		((GameObject)(object)text2).tag = text3;
		_okButtonText._002Ector();
	}

	public void PrivacyPolicyClicked(UILabel label)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I4
		//IL_01c3: Expected I, but got Obj
		//IL_01d9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		obj2 = 0;
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v54 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj4 = default;
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public void English()
	{
		//IL_01e5: Expected I, but got Obj
		//IL_01fb: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0230: Expected I, but got Obj
		//IL_0246: Expected Obj, but got I
		//IL_0271: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		//IL_02fe: Expected I, but got Obj
		//IL_0314: Expected Obj, but got I
		//IL_00fe: Expected I, but got Obj
		//IL_02b6: Expected Obj, but got I4
		//IL_014b: Expected I, but got Obj
		//IL_0198: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_checkMarkTweenCoroutine).FindKernel((string)null) != 0)
		{
			MiscExtensions.SafeInvoke((Action)(object)_checkMarkTweenCoroutine);
		}
		nint num3 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v10 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v45 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @89B1");
		nint num5 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v41 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num7 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v21 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v37 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Tracker.CreateEvent(Kiloo.Analytics.EventType.ConsentGiven, null);
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v27 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v33 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
	}

	public void French()
	{
		//IL_0010: Expected I4, but got Obj
		((ConsumablesPopup)this).isVideoPlaying = (byte)(int)"en-US" != 0;
	}

	public void Italian()
	{
		//IL_0010: Expected I4, but got Obj
		((ConsumablesPopup)this).isVideoPlaying = (byte)(int)"fr-FR" != 0;
	}

	public void German()
	{
		//IL_0010: Expected I4, but got Obj
		((ConsumablesPopup)this).isVideoPlaying = (byte)(int)"it-IT" != 0;
	}

	public void Spanish()
	{
		//IL_0010: Expected I4, but got Obj
		((ConsumablesPopup)this).isVideoPlaying = (byte)(int)"de-DE" != 0;
	}

	public void Portuguese()
	{
		//IL_0010: Expected I4, but got Obj
		((ConsumablesPopup)this).isVideoPlaying = (byte)(int)"es-ES" != 0;
	}

	private unsafe void SetLanguage(string locale)
	{
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_01d8: Expected I, but got Obj
		//IL_0270: Expected Obj, but got I
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected VT, but got Unknown
		//IL_02a0: Expected F4, but got Obj
		//IL_029b: Expected native int or pointer, but got VT
		//IL_02cc: Expected I, but got Obj
		//IL_02e2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0069: Expected I, but got Obj
		//IL_0227: Expected I, but got Obj
		//IL_023d: Expected Obj, but got I
		//IL_0314: Expected I4, but got Obj
		//IL_010a: Expected I, but got Obj
		//IL_0157: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(UICamera);
		if (!flag)
		{
			nint num3 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<UICamera>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(UICamera);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(UICamera);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ L0_v2 (Il2CppClass<UICamera>)+5C]");
		object obj2 = (nint)0 + (nint)56;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v6+8]");
		_ = 0;
		Vector2 vector = (Vector2)(obj3 + 12);
		((Vector2*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		string urlAtPosition = ((UILabel)(object)locale).GetUrlAtPosition(vector);
		nint num4 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v21 (Il2CppClass<Globals>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v49 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string ratingURL = Globals.RatingURL;
		if (!(urlAtPosition != ratingURL))
		{
			return;
		}
		nint num6 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v30 (Il2CppClass<Flurry>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v45 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num8 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v35 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num9 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v41 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Tracker.CreateEvent(Kiloo.Analytics.EventType.ConsentPrivacyPolicyOpened, null);
		Application.targetFrameRate = (int)urlAtPosition;
	}

	public ConsentPopup()
	{
		//IL_0010: Expected I4, but got Obj
		((ConsumablesPopup)this).isVideoPlaying = (byte)(int)"pt-BR" != 0;
	}
}
