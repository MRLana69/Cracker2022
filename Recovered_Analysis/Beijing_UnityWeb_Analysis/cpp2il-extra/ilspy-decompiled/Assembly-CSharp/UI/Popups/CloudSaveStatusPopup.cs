using System;
using System.Collections;
using System.Collections.Generic;
using Cloud;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.OnGUIWrappers;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.GameCenter;
using UI.Popups.BoardBundlePopupInternal;
using UI.Popups.CloudSaveConfirmationPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class CloudSaveStatusPopup : UIScreen
{
	private enum Status
	{
		Ok,
		Error,
		Conflict
	}

	private sealed class _003CDelayedGainFocus_003Ed__20(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudSaveStatusPopup _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected Obj, but got Unknown
				//IL_0062: Expected Obj, but got I4
				//IL_0076: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003E4__this.SetupSavedStatus();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				obj = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0247: Expected I, but got Obj
			//IL_025d: Expected Obj, but got I
			//IL_02b4: Expected I, but got Obj
			//IL_02ca: Expected Obj, but got I
			//IL_0291: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_00b5: Expected Obj, but got I
			//IL_00c5: Expected Obj, but got I
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected Obj, but got Unknown
			//IL_0109: Expected Obj, but got I
			//IL_0119: Expected Obj, but got I
			//IL_0129: Expected Obj, but got I
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected Obj, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected Obj, but got Unknown
			//IL_0165: Expected Obj, but got I
			//IL_0175: Expected Obj, but got I
			//IL_0185: Expected Obj, but got I
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected Obj, but got Unknown
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Expected Obj, but got Unknown
			//IL_01b9: Expected I, but got Obj
			//IL_01cf: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_01fa: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CloudSave.HandleAccountMismatch();
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).ClosePopup((GameObject)(object)"CloudSaveReminderPopup");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v3+60]");
			object obj4 = 0;
			object obj5 = obj4;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S4_v4 (should have been resolved before IL gen)");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S4_v6 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v7+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v8+48]");
			object obj10 = 0;
			object obj11 = obj10 & 0x7FF;
			object obj12 = obj11 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v81 @ S5_v6 (should have been resolved before IL gen)");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S4_v11 (Il2CppMethodInfo)+C]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S4_v12+60]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S4_v13+48]");
			object obj15 = 0;
			object obj16 = obj15 & 0x7FF;
			object obj17 = obj16 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v100 @ S5_v10 (should have been resolved before IL gen)");
			nint num8 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v26 (Il2CppClass<Flurry>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num9 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v30 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__28_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudSaveReminderPopup._003C_003Ec obj = default;
			CloudSaveReminderPopup._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CDisconnectClicked_003Eb__28_0()
		{
		}
	}

	private sealed class _003CAuthRoutine_003Ed__29(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudSaveStatusPopup _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0075: Expected Obj, but got I4
				//IL_0096: Expected I, but got Obj
				//IL_00ac: Expected Obj, but got I
				//IL_033e: Expected I, but got Obj
				//IL_0354: Expected Obj, but got I
				//IL_04af: Expected I, but got Obj
				//IL_04c5: Expected Obj, but got I
				//IL_00d7: Expected I, but got Obj
				//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_05d0: Expected Obj, but got Unknown
				//IL_05f6: Expected Obj, but got I4
				//IL_0124: Expected I, but got Obj
				//IL_013a: Expected Obj, but got I
				//IL_037f: Expected I, but got Obj
				//IL_02ce: Expected I, but got Obj
				//IL_03cc: Expected I, but got Obj
				//IL_03e2: Expected Obj, but got I
				//IL_0165: Expected I, but got Obj
				//IL_05c0: Expected Obj, but got I4
				//IL_01b2: Expected I, but got Obj
				//IL_01c8: Expected Obj, but got I
				//IL_040d: Expected I, but got Obj
				//IL_0240: Expected I, but got Obj
				//IL_0256: Expected Obj, but got I
				//IL_01f3: Expected I, but got Obj
				//IL_0550: Expected VT, but got Obj
				//IL_0281: Expected I, but got Obj
				CloudSaveStatusPopup cloudSaveStatusPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						goto IL_0327;
					}
					return null;
				}
				_003C_003E1__state = -1;
				string tag = cloudSaveStatusPopup._buttonLabel.tag;
				((GameObject)(object)tag).tag = null;
				string tag2 = cloudSaveStatusPopup._spinner.tag;
				((GameObject)(object)tag2).tag = (string)1;
				cloudSaveStatusPopup._buttonOverlay.GoToSelectedState();
				nint num = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v47 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v91 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (GameCenterPlugin.hasLoginView)
				{
					nint num3 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v68 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v87 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!GameCenterPlugin.initialAuthenticationComplete)
					{
						nint num5 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v76 (Il2CppClass<Strings>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num6 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v83 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text = Strings.GetDefault("CLOUDSAVE_GAMECENTER_LOGIN_UNAVAILABLE_TITLE");
						string text2 = Strings.GetDefault("CLOUDSAVE_GAMECENTER_LOGIN_UNAVAILABLE_MESSAGE");
						string content = Strings.GetDefault("CLOUDSAVE_GAMECENTER_LOGIN_UNAVAILABLE_DISMISS");
						nint num7 = (nint)typeof(DeviceUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S3_v5 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(DeviceUtility);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S3_v10 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((GUIArea)(object)text)._002Ector((Rect)text2, content, (string)null);
						goto IL_0327;
					}
				}
				nint num9 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v55 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v63 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj6 = this + 12;
				Coroutine coroutine = CloudSave.UpdateAsync();
				obj6 = coroutine;
				_003C_003E1__state = 1;
				return 1;
				IL_0327:
				cloudSaveStatusPopup.SetupSavedStatus();
				nint num11 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v13 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num12 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v33 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
				object obj8 = default;
				if ((nint)obj8 == 1)
				{
					nint num13 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v23 (Il2CppClass<UIScreenController>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num14 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = UIScreenController.ShouldShowOnlineScreen();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					string text3 = default;
					text3.m_stringLength = 19;
					_ = 1;
					((UIScreenController)flag)._QueueMessage(text3);
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I4
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
			((UIScreenController)flag).DebugCloseAllPopups();
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

	private Status _screenStatus;

	private UILabel _headline;

	private UILabel _subline;

	private UILabel _bannerTopLabel;

	private UILabel _bannerBottomLabel;

	private UILabel _disconnectLabel;

	private UILabel _statusLabel;

	private UILabel _buttonLabel;

	private UISprite _banner;

	private UIWidget _skyline;

	private UISprite _statusSprite;

	private UISprite _background;

	private GameObject _rays;

	private GameObject _button;

	private UIButtonOverlayOff _buttonOverlay;

	private UISprite _spinner;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		ShowIfInactive();
		ResetPopup();
	}

	public override void GainFocus()
	{
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_0165: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		base.Hide();
		SetupSavedStatus();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v13 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("CLOUDSAVE_USERNAME");
		nint num3 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v4 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v11 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isAvailable = CloudSave.isAvailable;
		string text = string.Format(format, (object[])isAvailable);
		_subline.fontSize = (int)text;
	}

	private IEnumerator DelayedGainFocus()
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

	private void SetupBasic()
	{
		IEnumerator routine = AuthRoutine();
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private unsafe void ResetPopup()
	{
		//IL_03b9: Expected I, but got Obj
		//IL_03cf: Expected Obj, but got I
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_0441: Expected Obj, but got I4
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected I4, but got Unknown
		//IL_0471: Expected I4, but got Obj
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04a9: Expected Obj, but got I4
		//IL_04cb: Expected I4, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0090: Expected I4, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_00ea: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I4
		//IL_0149: Expected I4, but got Obj
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_0181: Expected Obj, but got I4
		//IL_01a3: Expected I4, but got Obj
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01e0: Expected Obj, but got I4
		//IL_0202: Expected I4, but got Obj
		//IL_022c: Expected Obj, but got I4
		//IL_024e: Expected I4, but got Obj
		//IL_0264: Expected Obj, but got I4
		//IL_02e2: Expected I, but got Obj
		//IL_02f8: Expected Obj, but got I
		//IL_0409: Expected I4, but got Obj
		//IL_0371: Expected I4, but got Obj
		//IL_0323: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got I4
		//IL_0392: Expected I4, but got Obj
		//IL_03a5: Expected I4, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v46 (Il2CppClass<UI.ColorData>)+74]");
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
		_headline.rawPivot = pivot;
		object obj5 = obj3 + 96;
		object obj6 = (flag ? 1 : 0) + 92;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		_subline.rawPivot = pivot;
		object obj7 = obj3 + 80;
		object obj8 = (flag ? 1 : 0) + 380;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v18+8]");
		_ = 0;
		_disconnectLabel.rawPivot = pivot;
		object obj9 = obj3 - -64;
		object obj10 = (flag ? 1 : 0) + 220;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v37+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v24+8]");
		_ = 0;
		_banner.rawPivot = pivot;
		object obj11 = obj3 + 48;
		object obj12 = (flag ? 1 : 0) + 268;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v48+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v30+8]");
		_ = 0;
		_bannerTopLabel.rawPivot = pivot;
		object obj13 = obj3 + 32;
		object obj14 = (flag ? 1 : 0) + 252;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S2_v59+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v36+8]");
		_ = 0;
		_bannerBottomLabel.rawPivot = pivot;
		object obj15 = obj3 + 16;
		object obj16 = (flag ? 1 : 0) + 604;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S2_v70+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v42+8]");
		_ = 0;
		_buttonLabel.rawPivot = pivot;
		object obj17 = (flag ? 1 : 0) + 732;
		obj3 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S2_v80+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)1;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v54 (Il2CppClass<Strings>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S1_v70 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("CLOUDSAVE_STATUS_HEADER");
		_headline.fontSize = (int)text3;
		string text4 = Strings.GetDefault("CLOUDSAVE_STATUS_SAVED_LABELTITLE");
		_bannerTopLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("CLOUDSAVE_STATUS_DISCONNECT");
		string text6 = string.ConcatArray((string[])(object)"[u]", (int)text5);
		_disconnectLabel.fontSize = (int)text6;
	}

	private void SetupStatus()
	{
		//IL_001d: Expected Obj, but got I4
		string text = _buttonLabel.tag;
		((GameObject)(object)text).tag = (string)1;
		string text2 = _spinner.tag;
		((GameObject)(object)text2).tag = null;
		string text3 = _buttonOverlay.tag;
		string text4 = ((GameObject)(object)text3).tag;
		if (text4 != null)
		{
			_buttonOverlay.GoToNotAvailableState();
		}
	}

	private void SetupSavedStatus()
	{
		//IL_0239: Expected I, but got Obj
		//IL_024f: Expected Obj, but got I
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_00a7: Expected I, but got Obj
		//IL_01aa: Expected I, but got Obj
		//IL_01c0: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got VT
		//IL_02f5: Expected I4, but got Obj
		//IL_01eb: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		UserData userData = (UserData)(obj2 + 8);
		if (_buttonLabel != null)
		{
			return;
		}
		SetupStatus();
		nint num3 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v16 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v35 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj5 = default;
		object obj4 = obj5 - 2;
		if ((nint)obj5 != 2)
		{
			if ((nint)obj4 == 1)
			{
				_screenStatus = Status.Conflict;
			}
			else
			{
				_screenStatus = Status.Ok;
			}
		}
		else
		{
			_screenStatus = Status.Error;
		}
		if (_screenStatus != Status.Ok)
		{
			if (_screenStatus != Status.Error)
			{
				if (_screenStatus == Status.Conflict)
				{
					ButtonClicked();
				}
			}
			else
			{
				SetupConflictStatus();
			}
		}
		else
		{
			SetupErrorStatus();
		}
		nint num5 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v18 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v26 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastCloudSaveReminderShownTime = UserSave.lastCloudSaveReminderShownTime;
		obj2 = lastCloudSaveReminderShownTime;
		userData = (UserData)obj2;
		string text = userData.AsString();
		_bannerBottomLabel.fontSize = (int)text;
	}

	private unsafe void SetupErrorStatus()
	{
		//IL_01fd: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_0281: Expected Obj, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected I4, but got Unknown
		//IL_02b1: Expected I4, but got Obj
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02e9: Expected Obj, but got I4
		//IL_030b: Expected I4, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_009b: Expected I4, but got Obj
		//IL_00c3: Expected Obj, but got I4
		//IL_00e5: Expected I4, but got Obj
		//IL_00fb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_0146: Expected I4, but got Obj
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_016e: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_024b: Expected I4, but got Obj
		//IL_01af: Expected I, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v39 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 + 48;
		object obj4 = (flag ? 1 : 0) + 444;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 - -64);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_background.rawPivot = pivot;
		object obj5 = obj3 + 32;
		object obj6 = (flag ? 1 : 0) + 460;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		_skyline.rawPivot = pivot;
		object obj7 = this - -64;
		object obj8 = obj3 + 16;
		object obj9 = (flag ? 1 : 0) + 476;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v19+8]");
		_ = 0;
		((UIWidget)obj7).rawPivot = pivot;
		object obj10 = (flag ? 1 : 0) + 428;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v36+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		_rays.tag = (string)1;
		string text = _banner.tag;
		((GameObject)(object)text).tag = (string)1;
		_statusSprite.fillCenter = (byte)(int)"ic_check" != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		object obj11 = this - -64;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v39 (Il2CppClass<Strings>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v47 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("CLOUDSAVE_STATUS_SAVED_INFO");
		((UILabel)obj11).fontSize = (int)text2;
		_button.tag = null;
	}

	private unsafe void SetupConflictStatus()
	{
		//IL_041e: Expected I, but got Obj
		//IL_0434: Expected Obj, but got I
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Obj, but got Unknown
		//IL_054e: Expected Obj, but got I4
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected I4, but got Unknown
		//IL_057e: Expected I4, but got Obj
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		//IL_05b6: Expected Obj, but got I4
		//IL_05d8: Expected I4, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_009b: Expected I4, but got Obj
		//IL_00c3: Expected Obj, but got I4
		//IL_00e5: Expected I4, but got Obj
		//IL_00fb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I4
		//IL_0153: Expected I4, but got Obj
		//IL_0170: Expected I, but got Obj
		//IL_0186: Expected Obj, but got I
		//IL_023d: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I
		//IL_01b1: Expected I, but got Obj
		//IL_0495: Expected I4, but got Obj
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_02ca: Expected I4, but got Obj
		//IL_027e: Expected I, but got Obj
		//IL_02dd: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_04d0: Expected I4, but got Obj
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_036a: Expected I4, but got Obj
		//IL_031e: Expected I, but got Obj
		//IL_037d: Expected I, but got Obj
		//IL_0393: Expected Obj, but got I
		//IL_050b: Expected I4, but got Obj
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_040a: Expected I4, but got Obj
		//IL_03be: Expected I, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v63 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 + 48;
		object obj4 = (flag ? 1 : 0) + 492;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 - -64);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_background.rawPivot = pivot;
		object obj5 = obj3 + 32;
		object obj6 = (flag ? 1 : 0) + 508;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		_skyline.rawPivot = pivot;
		object obj7 = this - -64;
		object obj8 = obj3 + 16;
		object obj9 = (flag ? 1 : 0) + 572;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v19+8]");
		_ = 0;
		((UIWidget)obj7).rawPivot = pivot;
		object obj10 = (flag ? 1 : 0) + 252;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v36+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		_rays.tag = null;
		string text = _banner.tag;
		((GameObject)(object)text).tag = null;
		_button.tag = (string)1;
		_statusSprite.fillCenter = (byte)(int)"ic_indicator_error" != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		nint num3 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v36 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v59 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7AF1");
		object obj12 = default;
		if (obj12 != null)
		{
			if ((nint)obj12 != 1)
			{
				if ((nint)obj12 != 2)
				{
					return;
				}
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v73 (Il2CppClass<Strings>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v84 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = Strings.GetDefault("CLOUDSAVE_STATUS_OUTDATED_BUTTON");
				_buttonLabel.fontSize = (int)text2;
				object obj14 = this - -64;
				string text3 = Strings.GetDefault("CLOUDSAVE_STATUS_OUTDATED_INFO");
				((UILabel)obj14).fontSize = (int)text3;
				return;
			}
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v57 (Il2CppClass<Strings>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v68 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault("CLOUDSAVE_STATUS_AUTHENTICATE_BUTTON");
			_buttonLabel.fontSize = (int)text4;
			object obj16 = this - -64;
			string text5 = Strings.GetDefault("CLOUDSAVE_STATUS_AUTHENTICATE_INFO");
			((UILabel)obj16).fontSize = (int)text5;
			return;
		}
		nint num9 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v41 (Il2CppClass<Strings>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v52 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text6 = Strings.GetDefault("CLOUDSAVE_STATUS_OFFLINE_BUTTON");
		_buttonLabel.fontSize = (int)text6;
		object obj18 = this - -64;
		string text7 = Strings.GetDefault("CLOUDSAVE_STATUS_OFFLINE_INFO");
		((UILabel)obj18).fontSize = (int)text7;
	}

	public unsafe void ButtonClicked()
	{
		//IL_020c: Expected I, but got Obj
		//IL_0222: Expected Obj, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got I4
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected I4, but got Unknown
		//IL_02cf: Expected I4, but got Obj
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0307: Expected Obj, but got I4
		//IL_0329: Expected I4, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I4
		//IL_009b: Expected I4, but got Obj
		//IL_00c3: Expected Obj, but got I4
		//IL_00e5: Expected I4, but got Obj
		//IL_00fb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I4
		//IL_0153: Expected I4, but got Obj
		//IL_0170: Expected I, but got Obj
		//IL_0186: Expected Obj, but got I
		//IL_025c: Expected I4, but got Obj
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_01fd: Expected I4, but got Obj
		//IL_01b1: Expected I, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v41 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 + 48;
		object obj4 = (flag ? 1 : 0) + 540;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 - -64);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_background.rawPivot = pivot;
		object obj5 = obj3 + 32;
		object obj6 = (flag ? 1 : 0) + 556;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		_skyline.rawPivot = pivot;
		object obj7 = this - -64;
		object obj8 = obj3 + 16;
		object obj9 = (flag ? 1 : 0) + 572;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v19+8]");
		_ = 0;
		((UIWidget)obj7).rawPivot = pivot;
		object obj10 = (flag ? 1 : 0) + 524;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v36+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		_rays.tag = null;
		string text = _banner.tag;
		((GameObject)(object)text).tag = null;
		_button.tag = (string)1;
		_statusSprite.fillCenter = (byte)(int)"ic_indicator_conflict" != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v39 (Il2CppClass<Strings>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v50 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("CLOUDSAVE_STATUS_CONFLICT_BUTTON");
		_buttonLabel.fontSize = (int)text2;
		object obj12 = this - -64;
		string text3 = Strings.GetDefault("CLOUDSAVE_STATUS_CONFLICT_INFO");
		((UILabel)obj12).fontSize = (int)text3;
	}

	public void DisconnectClicked()
	{
		//IL_0359: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I
		//IL_0389: Expected Obj, but got I
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
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
		object obj7 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private IEnumerator AuthRoutine()
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

	public CloudSaveStatusPopup()
	{
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_02ae: Expected I4, but got Obj
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_02fd: Expected I, but got Obj
		//IL_0313: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_023f: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_01e1: Expected Obj, but got I4
		//IL_01f8: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I4
		//IL_013b: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.CloudSaveStatusPopup+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v66 (Il2CppClass<UI.Popups.CloudSaveStatusPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__28_0 == null;
		bool flag2 = !flag;
		Boards.BoardId boardId = (Boards.BoardId)_003C_003Ec._003C_003E9__28_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v43 (Il2CppClass<UI.Popups.CloudSaveStatusPopup+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v60 (Il2CppClass<UI.Popups.CloudSaveStatusPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Boards.BoardId boardId2 = default;
			object obj3 = boardId2 + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v57 (Il2CppClass<UI.Popups.CloudSaveStatusPopup+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = boardId2;
			boardId = boardId2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		string text = default;
		text.m_stringLength = (int)num7;
		_ = 0;
		object obj5 = text + 16;
		obj5 = this;
		nint num8 = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v22 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num9 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v38 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((BoardBundleItem)null).Init(boardId, text);
		nint num10 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v28 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num11 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3).QueuePopup("CloudSaveConfirmationPopup");
	}

	private void _003CDisconnectClicked_003Eb__28_1()
	{
		((UpgradeScreen)this).Start();
	}
}
