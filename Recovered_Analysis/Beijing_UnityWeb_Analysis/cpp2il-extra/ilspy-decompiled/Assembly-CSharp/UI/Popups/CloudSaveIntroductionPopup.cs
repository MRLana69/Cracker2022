using System;
using System.Collections;
using System.Collections.Generic;
using Authentication;
using Cloud;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using Kiloo.Common.OnGUIWrappers;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Kiloo.GameCenter;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class CloudSaveIntroductionPopup : UIScreen
{
	private enum HideAction
	{
		None,
		Closed,
		Saved,
		Refreshed
	}

	private sealed class _003CLoginRoutine_003Ed__19(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudSaveIntroductionPopup _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0094: Expected Obj, but got I4
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a7: Expected Obj, but got Unknown
				//IL_00be: Expected I, but got Obj
				//IL_00d4: Expected Obj, but got I
				//IL_036d: Expected I, but got Obj
				//IL_0383: Expected Obj, but got I
				//IL_0618: Expected I, but got Obj
				//IL_062e: Expected Obj, but got I
				//IL_00ff: Expected I, but got Obj
				//IL_0747: Unknown result type (might be due to invalid IL or missing references)
				//IL_074c: Expected Obj, but got Unknown
				//IL_0772: Expected Obj, but got I4
				//IL_014c: Expected I, but got Obj
				//IL_0162: Expected Obj, but got I
				//IL_045d: Expected I, but got Obj
				//IL_0473: Expected Obj, but got I
				//IL_03ae: Expected I, but got Obj
				//IL_02f6: Expected I, but got Obj
				//IL_0705: Expected Obj, but got I4
				//IL_0717: Expected Obj, but got I4
				//IL_040d: Expected Obj, but got I4
				//IL_018d: Expected I, but got Obj
				//IL_049e: Expected I, but got Obj
				//IL_01da: Expected I, but got Obj
				//IL_01f0: Expected Obj, but got I
				//IL_053f: Expected I, but got Obj
				//IL_0555: Expected Obj, but got I
				//IL_043c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0441: Expected Obj, but got Unknown
				//IL_0737: Expected Obj, but got I4
				//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0501: Expected Obj, but got Unknown
				//IL_050a: Expected Obj, but got I4
				//IL_051e: Expected Obj, but got I4
				//IL_0268: Expected I, but got Obj
				//IL_027e: Expected Obj, but got I
				//IL_021b: Expected I, but got Obj
				//IL_0580: Expected I, but got Obj
				//IL_06b9: Expected VT, but got Obj
				//IL_02a9: Expected I, but got Obj
				CloudSaveIntroductionPopup cloudSaveIntroductionPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							goto IL_044f;
						}
						return null;
					}
					_003C_003E1__state = -1;
					goto IL_035f;
				}
				_003C_003E1__state = -1;
				string tag = cloudSaveIntroductionPopup._buttonText.tag;
				((GameObject)(object)tag).tag = null;
				string tag2 = cloudSaveIntroductionPopup._spinner.tag;
				((GameObject)(object)tag2).tag = (string)1;
				object obj = cloudSaveIntroductionPopup - -64;
				((UIButtonOverlayOff)obj).GoToSelectedState();
				nint num = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v66 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v110 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (GameCenterPlugin.hasLoginView)
				{
					nint num3 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v87 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v106 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!GameCenterPlugin.initialAuthenticationComplete)
					{
						nint num5 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v95 (Il2CppClass<Strings>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num6 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v102 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text = Strings.GetDefault("CLOUDSAVE_GAMECENTER_LOGIN_UNAVAILABLE_TITLE");
						string text2 = Strings.GetDefault("CLOUDSAVE_GAMECENTER_LOGIN_UNAVAILABLE_MESSAGE");
						string content = Strings.GetDefault("CLOUDSAVE_GAMECENTER_LOGIN_UNAVAILABLE_DISMISS");
						nint num7 = (nint)typeof(DeviceUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S3_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num8 = (nint)typeof(DeviceUtility);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S3_v11 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((GUIArea)(object)text)._002Ector((Rect)text2, content, (string)null);
						goto IL_035f;
					}
				}
				nint num9 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v74 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num10 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v82 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj7 = this + 12;
				Coroutine coroutine = CloudSave.UpdateAsync();
				obj7 = coroutine;
				_003C_003E1__state = 1;
				return 1;
				IL_044f:
				nint num11 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num12 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v37 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				bool isShowingPopup = ((UIScreenController)flag).isShowingPopup;
				if ((string)isShowingPopup != "CloudSaveCelebrationPopup")
				{
					object obj9 = this + 12;
					obj9 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				cloudSaveIntroductionPopup._hideSourceAction = HideAction.Refreshed;
				nint num13 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v22 (Il2CppClass<UIScreenController>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num14 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag2).ClosePopup((GameObject)(object)"CloudSaveIntroductionPopup");
				return null;
				IL_035f:
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num16 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)cloudSaveIntroductionPopup._buttonText).FindKernel((string)null) != 0)
				{
					string tag3 = cloudSaveIntroductionPopup._buttonText.tag;
					((GameObject)(object)tag3).tag = (string)1;
					string tag4 = cloudSaveIntroductionPopup._spinner.tag;
					((GameObject)(object)tag4).tag = null;
					object obj12 = cloudSaveIntroductionPopup - -64;
					((UIButtonOverlayOff)obj12).GoToNotAvailableState();
				}
				goto IL_044f;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UILabel _header;

	private UILabel _speechBubbleText;

	private UILabel _bottomText;

	private UIWidget _skyline;

	private UIWidget _skylineFiller;

	private UILabel _buttonText;

	private UIButtonOverlayOff _buttonOverlay;

	private UISprite _spinner;

	private bool _isLoggedInNative;

	private HideAction _hideSourceAction;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Auth);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<Authentication.Auth>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v14 (Il2CppClass<Authentication.Auth>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isAuthorized = Auth.isAuthorized;
		_isLoggedInNative = isAuthorized;
		LocalizeLoggedIn();
		SetupBasic();
	}

	public override void Hide()
	{
		base.Hide();
		_hideSourceAction = HideAction.None;
	}

	private void Localize()
	{
		//IL_0059: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I
		//IL_009a: Expected I, but got Obj
		base.LoseFocus();
		if (_hideSourceAction == HideAction.Saved || _hideSourceAction == HideAction.Refreshed)
		{
			return;
		}
		if (~(_isLoggedInNative ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v27 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CloudSave.Disable();
			IEnumerator enumerator = CloudSave.Update_Routine((Action)null);
			this._002Ector();
		}
		((CloudSaveIntroductionPopup)null).FlurryLogCloudSaveEnabled();
		((CloudSaveProgressCell)(object)this).SetupCell((CloudSaveProgressCell.CloudSaveProgressCellPayload)(object)"CloseClicked");
	}

	private void SetupBasic()
	{
		//IL_025d: Expected I, but got Obj
		//IL_0273: Expected Obj, but got I
		//IL_0339: Expected I4, but got Obj
		//IL_0347: Expected I, but got Obj
		//IL_035d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02dd: Expected I4, but got Obj
		//IL_0199: Expected I4, but got Obj
		//IL_014b: Expected I, but got Obj
		//IL_02ad: Expected I4, but got Obj
		//IL_01ba: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_00d2: Expected I4, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_0249: Expected I4, but got Obj
		//IL_01fb: Expected I, but got Obj
		//IL_0114: Expected I4, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v32 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("CLOUDSAVE_INTRODUCTION_HEADER");
		_header.fontSize = (int)text;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v10 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		if (~(_isLoggedInNative ? 1u : 0u) == 0)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v37 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("CLOUDSAVE_INTRODUCTION_JAKE_B");
			_speechBubbleText.fontSize = (int)text2;
			string text3 = Strings.GetDefault("CLOUDSAVE_INTRODUCTION_BUTTON_B");
			_buttonText.fontSize = (int)text3;
			string text4 = Strings.GetDefault("CLOUDSAVE_INTRODUCTION_DESCRIPTION_B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
			object obj3 = default;
			string text5 = text4 + obj3;
			_bottomText.fontSize = (int)text5;
			return;
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v25 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text6 = Strings.GetDefault("CLOUDSAVE_INTRODUCTION_JAKE");
		_speechBubbleText.fontSize = (int)text6;
		string text7 = Strings.GetDefault("CLOUDSAVE_INTRODUCTION_BUTTON");
		_buttonText.fontSize = (int)text7;
		string format = Strings.GetDefault("CLOUDSAVE_INTRODUCTION_DESCRIPTION");
		nint num6 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S2_v11 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v19 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		string checksumToShow = ((OnlineSettings)(object)saveDataPath).GetChecksumToShow();
		string text8 = string.Format(format, (object[])(object)checksumToShow);
		_bottomText.fontSize = (int)text8;
	}

	private unsafe void LocalizeLoggedIn()
	{
		//IL_02ff: Expected I, but got Obj
		//IL_0315: Expected Obj, but got I
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0357: Expected Obj, but got I4
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected I4, but got Unknown
		//IL_0387: Expected I4, but got Obj
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected Obj, but got Unknown
		//IL_03bf: Expected Obj, but got I4
		//IL_03e1: Expected I4, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0090: Expected I4, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_00ea: Expected I4, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_0147: Expected I4, but got Obj
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_01a1: Expected I4, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01dc: Expected Obj, but got I4
		//IL_01fe: Expected I4, but got Obj
		//IL_0228: Expected Obj, but got I4
		//IL_024a: Expected I4, but got Obj
		//IL_02cd: Expected Obj, but got I4
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v43 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 + 112;
		object obj4 = (flag ? 1 : 0) + 140;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 128);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_header.rawPivot = pivot;
		object obj5 = obj3 + 96;
		object obj6 = (flag ? 1 : 0) + 92;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		_speechBubbleText.rawPivot = pivot;
		object obj7 = obj3 + 80;
		object obj8 = (flag ? 1 : 0) + 604;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v18+8]");
		_ = 0;
		_buttonText.rawPivot = pivot;
		object obj9 = obj3 - -64;
		object obj10 = (flag ? 1 : 0) + 732;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v37+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v24+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		object obj11 = obj3 + 48;
		object obj12 = (flag ? 1 : 0) + 524;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S2_v48+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v30+8]");
		_ = 0;
		_bottomText.rawPivot = pivot;
		object obj13 = obj3 + 32;
		object obj14 = (flag ? 1 : 0) + 732;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S2_v59+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v36+8]");
		_ = 0;
		Vector2 effectDistance2 = ((UILabel)pivot).effectDistance;
		object obj15 = obj3 + 16;
		object obj16 = (flag ? 1 : 0) + 124;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S2_v70+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v42+8]");
		_ = 0;
		_skyline.rawPivot = pivot;
		object obj17 = (flag ? 1 : 0) + 124;
		obj3 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S2_v80+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_skylineFiller.rawPivot = pivot;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)1;
		}
		string text3 = _spinner.tag;
		((GameObject)(object)text3).tag = null;
	}

	private void LocalizeLoggedOut()
	{
		_isLoggedInNative = true;
		SetupBasic();
	}

	public void CloseClicked()
	{
		_isLoggedInNative = false;
		SetupBasic();
	}

	public void SaveNowClicked()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		_hideSourceAction = HideAction.Closed;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v13 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
	}

	private IEnumerator LoginRoutine()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void LogLastShownTime()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		_hideSourceAction = HideAction.Saved;
		if (~(_isLoggedInNative ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).DebugCloseAllPopups();
			nint num3 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v30 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CloudSave.Disable();
			IEnumerator enumerator = CloudSave.Update_Routine((Action)null);
		}
		else
		{
			IEnumerator list = ((CloudSaveStatusPopup)this).DelayedGainFocus();
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
		}
		((CloudSaveIntroductionPopup)null).FlurryLogCloudSaveEnabled();
		this._002Ector();
		((CloudSaveProgressCell)(object)this).SetupCell((CloudSaveProgressCell.CloudSaveProgressCellPayload)(object)"ButtonClicked");
	}

	private void FlurryLogCloudSaveEnabled()
	{
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_005a: Expected Obj, but got VT
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v21 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasUserRunAppBefore = UserSave.hasUserRunAppBefore;
		bool hasUserRunAppBefore2 = (byte)((hasUserRunAppBefore ? 1u : 0u) + 1u) != 0;
		UserSave.hasUserRunAppBefore = hasUserRunAppBefore2;
		DateTime today = CDateTime.Today;
		object obj2 = today;
		OnboardingSave onboardingSave = (OnboardingSave)(obj2 + 8);
		onboardingSave = (OnboardingSave)obj2;
		onboardingSave._002Ector();
	}

	private void FlurryLogPopupShown(string clickType)
	{
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		HideAction hideSourceAction = _hideSourceAction;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S5_v6 (should have been resolved before IL gen)");
		HideAction hideSourceAction2 = _hideSourceAction;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69 @ S5_v10 (should have been resolved before IL gen)");
		nint num4 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v13 (Il2CppClass<Flurry>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public CloudSaveIntroductionPopup()
	{
		//IL_011c: Expected Obj, but got I
		//IL_012c: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01e5: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_02bd: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I
		//IL_002f: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		//IL_0263: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_0070: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		if (~(_isLoggedInNative ? 1u : 0u) == 0)
		{
			object obj6 = "NativeLoggedIn";
		}
		else
		{
			object obj6 = "NativeLoggedOut";
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S4_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S4_v8+48]");
		object obj9 = 0;
		object obj10 = obj9 & 0x7FF;
		object obj11 = obj10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S4_v12+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S4_v13+48]");
		object obj14 = 0;
		object obj15 = obj14 & 0x7FF;
		object obj16 = obj15 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v77 @ S5_v10 (should have been resolved before IL gen)");
		if (~(_isLoggedInNative ? 1u : 0u) == 0)
		{
			nint num4 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v29 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num5 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v37 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInitialized = Auth.isInitialized;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S4_v17 (Il2CppMethodInfo)+C]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S4_v18+60]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S4_v19+48]");
			object obj20 = 0;
			object obj21 = obj20 & 0x7FF;
			object obj22 = obj21 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v94 @ S5_v15 (should have been resolved before IL gen)");
		}
		nint num7 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v20 (Il2CppClass<Flurry>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num8 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v24 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}
}
