using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Info;
using Kiloo.Common.JsonUtil;
using Missions;
using SYBO.Components.Utilities;
using UI.FreeStuff;
using UI.Generic;
using UI.Generic.Layout;
using UI.Screens;
using UI.Screens.RewardManagement;
using UI.SlideIns;
using UnityEngine;

public class SaveMePopup : UIScreen
{
	private enum ClickAction
	{
		WatchAd,
		SpendKeys
	}

	private sealed class _003CStartClockAnimation_003Ed__33(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SaveMePopup _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_016e: Expected I, but got Obj
				//IL_0184: Expected Obj, but got I
				//IL_032a: Expected Obj, but got I4
				//IL_0338: Expected I, but got Obj
				//IL_034e: Expected Obj, but got I
				//IL_009c: Expected I, but got Obj
				//IL_00b2: Expected Obj, but got I
				//IL_01af: Expected I, but got Obj
				//IL_01fc: Expected I, but got Obj
				//IL_00dd: Expected I, but got Obj
				//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ed: Expected Obj, but got Unknown
				//IL_02f6: Expected Obj, but got I4
				//IL_030a: Expected Obj, but got I4
				SaveMePopup saveMePopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					saveMePopup.AnimTimeLeft__BackingField = 4f;
				}
				if (saveMePopup.AnimTimeLeft__BackingField > -0.2f)
				{
					nint num = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v40 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v51 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num3 = saveMePopup.AnimTimeLeft__BackingField * 0.25f;
					if (num3 < 0f)
					{
						num3 = 0f;
					}
					else if (num3 > 1f)
					{
						num3 = 1f;
					}
					((IngameScreen)(object)saveMePopup._saveMeAnimateClock).RestartHidingScoreboosterSpeedometer(num3);
					float unscaledTime = Time.unscaledTime;
					float num4 = saveMePopup.AnimTimeLeft__BackingField - unscaledTime;
					saveMePopup.AnimTimeLeft__BackingField = num4;
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				nint num5 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v33 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag).ClosePopup((GameObject)(object)saveMePopup.screenName);
				nint num7 = (nint)typeof(Revive);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v22 (Il2CppClass<Revive>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(Revive);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v29 (Il2CppClass<Revive>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string deviceToken = RemoteNotificationControl.GetDeviceToken();
				((Revive)(object)deviceToken)._002Ector();
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
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

	public const float TIMEOUT_ANIMATION_DURATION = 4f;

	private const float TIMEOUT_VIDEO_LOAD = 5f;

	private UIWidget _outline;

	private SaveMeAnimateClock _saveMeAnimateClock;

	private float AnimTimeLeft__BackingField;

	private UILabel _saveMeButtonLabel;

	private UILabel _keyCostLabel;

	private UILabel _freeLabel;

	private HorizontalLayout _buttonLayout;

	private GameObject _spendKeysButton;

	private GameObject _watchAdButton;

	private UIWidget _animatedTVIconContainer;

	private GameObject _animatedTVIconPrefab;

	private Coroutine countdownCoroutine;

	private static bool _revivedWithAds;

	private static bool _adsFailed;

	private static bool _adsNotAvailable;

	private bool _isWatchingVideoForRevive;

	public float AnimTimeLeft
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)_footerPrefab;
		}
		private set
		{
			//IL_0014: Expected I4, but got Obj
			//IL_0023: Expected I4, but got Obj
			((RectTransform)(object)this).SetSizeWithCurrentAnchors((RectTransform.Axis)"SetScoreboosterTimePeriodIsActive", value);
			((RectTransform)(object)this).SetSizeWithCurrentAnchors((RectTransform.Axis)"DeactivateScoreboosterSpeedometer", value);
		}
	}

	public bool VideoIsPlaying
	{
		get
		{
			//IL_012c: Expected I, but got Obj
			//IL_0142: Expected Obj, but got I
			//IL_01cf: Expected Obj, but got I
			//IL_01df: Expected Obj, but got I
			//IL_01ef: Expected Obj, but got I
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected Obj, but got Unknown
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Expected Obj, but got Unknown
			//IL_0232: Expected I, but got Obj
			//IL_0248: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01a6: Expected Obj, but got I
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Expected I4, but got Unknown
			//IL_00df: Expected I, but got Obj
			//IL_016a: Expected I4, but got Obj
			//IL_0079: Expected I, but got Obj
			nint num = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v44 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
			object obj7 = default;
			bool flag = (nint)obj7 > -1;
			nint num4 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v6 (Il2CppClass<RewardManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			bool flag2 = obj8 != null;
			if (flag)
			{
				if (flag2)
				{
					nint num5 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v38 (Il2CppClass<RewardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (byte)RewardManager.PENDING_REWARD_PRIORITY.get_Item((CelebrationRewardOrigin)this) != 0;
			}
			if (flag2)
			{
				nint num6 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v26 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<CelebrationRewardOrigin, int> pENDING_REWARD_PRIORITY = RewardManager.PENDING_REWARD_PRIORITY;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v22 (System.Collections.Generic.Dictionary`2<UI.Screens.RewardManagement.CelebrationRewardOrigin, System.Int32>)+10]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v22 (System.Collections.Generic.Dictionary`2<UI.Screens.RewardManagement.CelebrationRewardOrigin, System.Int32>)+1C]");
			object obj9 = num7 - 0;
			return (byte)(obj9 + 1) != 0;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected Obj, but got Unknown
			//IL_0219: Expected Obj, but got I4
			//IL_0230: Expected Obj, but got I
			//IL_0230: Expected Obj, but got I4
			//IL_0234: Expected VT, but got Obj
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			object obj5 = this + 32;
			obj5 = value;
			bool footerInited = base._footerInited;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
			_0021_00210 val = (_0021_00210)((SlideInData)footerInited).InstantiateSlideIn<T>((Transform)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			object obj7 = obj4 + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj4 + obj9;
			obj10 = 69;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj4 + obj11;
				if ((nint)obj12 == 69)
				{
					object obj13 = obj4 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					goto IL_0291;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0291;
			IL_0291:
			((QuickVideoButtonHelper)(object)this)._002Ector();
		}
	}

	public override void Init()
	{
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		((InventorySave)(object)this)._002Ector();
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<RewardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v29 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (RewardManager.OnRewardPaidOut == null)
		{
			return;
		}
		nint num3 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<RewardManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardManager.OnRewardPaidOut((CelebrationReward)(object)this);
	}

	public override void Show()
	{
		//IL_00ea: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_011d: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01cd: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_00ca: Expected I4, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(UIScreenController);
		if (!flag)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(UIScreenController);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(UIScreenController);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ L1_v2 (Il2CppClass<UIScreenController>)+5C]");
		object obj2 = (nint)0 + (nint)76;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S6_v3 (Il2CppClass<UIScreenController>)+5C]");
		object obj3 = (nint)0 + (nint)76;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v6 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SAVE_ME_POPUP_BUTTON_LABEL");
		_saveMeButtonLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("FREE");
		_freeLabel.fontSize = (int)text2;
		OnApplicationResumed();
	}

	public unsafe override void Hide()
	{
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_04f2: Expected Obj, but got I4
		//IL_0506: Expected I, but got Obj
		//IL_051c: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_0573: Expected I, but got Obj
		//IL_0589: Expected Obj, but got I
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_0118: Expected I, but got Obj
		//IL_05e0: Expected I, but got Obj
		//IL_05f6: Expected Obj, but got I
		//IL_0625: Expected Obj, but got I4
		//IL_0636: Expected Obj, but got I4
		//IL_01a6: Expected I, but got Obj
		//IL_024a: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_01f3: Expected I, but got Obj
		//IL_028b: Expected I, but got Obj
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_0334: Expected I, but got Obj
		//IL_034a: Expected Obj, but got I
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected Obj, but got Unknown
		//IL_06bb: Expected Obj, but got I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_0375: Expected I, but got Obj
		//IL_040f: Expected I, but got Obj
		//IL_0425: Expected Obj, but got I
		//IL_049e: Expected I4, but got Obj
		//IL_0450: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		base.Hide();
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<SaveMeManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v118 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveMeManager.IncrementRevivalCountInCurrentRun();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B9");
		object obj4 = default;
		object obj5;
		if (obj4 != null)
		{
			obj5 = "NotShown";
		}
		else
		{
			nint num3 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v105 (Il2CppClass<SaveMeManager>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v113 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = ((SaveMeManager.GetNumberOfKeysToSaveMe() == 0) ? "NoFill" : "Available");
		}
		nint num5 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v9 (Il2CppClass<SaveMeManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v72 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B2");
		object obj8 = default;
		obj = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		IFormatProvider provider = default;
		object obj9 = ((IConvertible)obj5).ToType((Type)(object)";", provider);
		nint num7 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v23 (Il2CppClass<Flurry>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num8 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v100 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnVideoOverlayClosed();
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v29 (Il2CppClass<UIScreenController>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v96 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		UIScreen uIScreen = ((UIScreenController)flag)._ActivateScreen((string)(object)enumerator);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj13 = default;
		if (obj13 != null)
		{
			SDebug.LogFormat("IngameScreen == NULL", null);
		}
		else
		{
			((IngameScreen)obj13).OnHeadstartActivated(0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		_ = 0;
		Action<string> action = default;
		object obj14 = action + 16;
		obj14 = this;
		AdSystemManager.onFailedToShowVideo -= action;
		nint num14 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v56 (Il2CppClass<UIScreenController>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num15 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v85 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(SaveMePopup.OnVideoOverlayClosed);
		object obj16 = action2 + 16;
		obj16 = this;
		((UIScreenController)flag2).OnOverlayManuallyClosed -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(SaveMePopup.OnApplicationResumed);
		object obj17 = action3 + 16;
		obj17 = this;
		UIScreenController.OnApplicationResumed -= action3;
		nint num16 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v51 (Il2CppClass<SaveMeManager>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num17 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v66 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72BF");
		object obj19 = default;
		obj2 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array = default;
		string text = string.Concat(array);
		_keyCostLabel.fontSize = (int)text;
		_adsFailed = false;
		_revivedWithAds = false;
		bool adsNotAvailable = SaveMeManager.IsSaveMePopupEnabled();
		_adsNotAvailable = adsNotAvailable;
		_isWatchingVideoForRevive = false;
		LogAttemptToShowButton();
	}

	private void CreateTVIcon()
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		AdSystemManager.onDismissedVideo += action;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v30 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		string text = default;
		text.m_stringLength = (int)num4;
		_ = 0;
		object obj3 = text + 16;
		obj3 = this;
		((UIScreenController)flag).ShowVideoAdsOverlay(text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj4 = action2 + 16;
		obj4 = this;
		UIScreenController.OnPopupShown += action2;
	}

	private void OnApplicationResumed()
	{
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_00bb: Expected I4, but got Obj
		//IL_00c8: Expected Obj, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00ed: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		string go = _animatedTVIconContainer.tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v2 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v7 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)_animatedTVIconPrefab != 0);
		FitSpriteToWidget component = ((GameObject)num3).GetComponent<FitSpriteToWidget>();
		object obj2 = component + 16;
		obj2 = _animatedTVIconContainer;
		FitSpriteToWidget component2 = ((GameObject)num3).GetComponent<FitSpriteToWidget>();
		component2.FitStretch();
	}

	private void UpdateButtonStates()
	{
		LogAttemptToShowButton();
	}

	private void LogAttemptToShowButton()
	{
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_018f: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = SaveMeManager.IsSaveMePopupEnabled();
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<AdLocations>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v30 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((WaterFallReach)(object)AdLocations.REVIVAL_VIDEOS).OnFailedToCacheVideo((string)flag);
		((SaveMePopup)null).StartCountdown();
		_watchAdButton.tag = (string)flag;
		object obj3 = this - -64;
		UIWidget component = ((Component)obj3).GetComponent<UIWidget>();
		int height = ((!flag) ? 180 : 256);
		component.height = height;
		object obj4 = this - -64;
		((RewardForVideoButton)obj4).Init((VideoButtonPayload)null);
	}

	public void StartCountdown()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72B9");
		object obj2 = default;
		if (obj2 != null)
		{
			return;
		}
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<AdLocations>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v22 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AdTrackingSystemLogger.LogVideoAdButtonClick(AdLocations.REVIVAL_VIDEOS);
	}

	private IEnumerator StartClockAnimation()
	{
		//IL_0019: Expected Obj, but got I4
		bool isWatchingVideoForRevive = _isWatchingVideoForRevive;
		return (IEnumerator)isWatchingVideoForRevive;
	}

	private void OnVideoOverlayClosed()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		object obj = this + 84;
		SSEventCategory eventCategory = ((SSEventsPopup)this).GetEventCategory();
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)eventCategory);
		obj = coroutine;
	}

	private void OnFinishedWatchingVideo()
	{
		rewardedBreakComplete(withReward: false);
	}

	private void OnShowVideoFailure(string id)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool isWatchingVideoForRevive = (byte)(id & 1) != 0;
		_isWatchingVideoForRevive = isWatchingVideoForRevive;
	}

	public unsafe void OnWatchAdClicked()
	{
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_0200: Expected I, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b2: Expected F4, but got I
		//IL_00ad: Expected native int or pointer, but got VT
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I4
		//IL_012d: Expected I, but got Obj
		_isWatchingVideoForRevive = false;
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v34 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (Il2CppClass<SaveMeManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v30 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72BB");
		DeviceInfo instance = DeviceInfo.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = num5;
		_ = 0;
		object obj3 = vector + 16;
		obj3 = 0;
		((Curve)(object)instance).AddKey(5f, vector);
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v20 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)"SaveMePopup");
	}

	public void rewardedBreakComplete(bool withReward)
	{
		_adsFailed = true;
		OnWatchAdClicked();
	}

	public void OnSpendKeysClicked()
	{
		//IL_00d9: Expected I, but got Obj
		//IL_00ef: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I4
		((SSEventsPopup)null).SetExtraSettingsForState(SSEventType.None);
		_revivedWithAds = true;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v24 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AdTrackingSystemLogger.LogFillRequest(AdLocations.REVIVAL_VIDEOS);
		StopCoroutine((string)(object)countdownCoroutine);
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj2 = this;
		object obj4 = (isInitialized ? 1 : 0) + 20;
		obj4 = obj3;
		bool isInitialized2 = AdSystemManager.isInitialized;
		((PokiUnitySDK)isInitialized2).checkInit();
		_isWatchingVideoForRevive = true;
	}

	private void ReviveWithKeys()
	{
		((SSEventsPopup)null).SetExtraSettingsForState(SSEventType.SpecialPowerBoard);
		((SaveMePopup)null)._002Ector();
	}

	private void PostSaveMeClickEvent(ClickAction action)
	{
		//IL_00da: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got I
		//IL_0152: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c6: Expected VT, but got I4
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.RefreshOnlineSettingsAndInappsIfNeeded();
		_isWatchingVideoForRevive = false;
		nint num3 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v24 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError("Rewarded break finished");
		if (action != ClickAction.WatchAd)
		{
			OnWatchAdClicked();
			return;
		}
		DeviceInfo instance = DeviceInfo.Instance;
		((Curve)(object)instance).AddKey(5f, (Vector3)0);
	}

	private static void RevivePlayer()
	{
		//IL_0019: Expected I8, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0049: Expected Obj, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0145: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_01a1: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01fd: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I
		//IL_021d: Expected Obj, but got I
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0259: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02b5: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I
		//IL_02d5: Expected Obj, but got I
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_0311: Expected Obj, but got I
		//IL_0321: Expected Obj, but got I
		//IL_0331: Expected Obj, but got I
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_036d: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_03c9: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I
		//IL_03e9: Expected Obj, but got I
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_0425: Expected Obj, but got I
		//IL_0435: Expected Obj, but got I
		//IL_0445: Expected Obj, but got I
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected Obj, but got Unknown
		//IL_0479: Expected I, but got Obj
		//IL_048f: Expected Obj, but got I
		RewardManager.canShowMultipleQueuedCelebrations = false;
		RewardManager._nextRewardUid = -1L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70 @ S5_v10 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S4_v17+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S4_v18+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v87 @ S5_v14 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S4_v22+60]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S4_v23+48]");
		object obj23 = 0;
		object obj24 = obj23 & 0x7FF;
		object obj25 = obj24 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S5_v18 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S4_v27+60]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S4_v28+48]");
		object obj28 = 0;
		object obj29 = obj28 & 0x7FF;
		object obj30 = obj29 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v121 @ S5_v22 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v32+60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S4_v33+48]");
		object obj33 = 0;
		object obj34 = obj33 & 0x7FF;
		object obj35 = obj34 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v138 @ S5_v26 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S4_v37+60]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S4_v38+48]");
		object obj38 = 0;
		object obj39 = obj38 & 0x7FF;
		object obj40 = obj39 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v155 @ S5_v30 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v42+60]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S4_v43+48]");
		object obj43 = 0;
		object obj44 = obj43 & 0x7FF;
		object obj45 = obj44 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v172 @ S5_v34 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S4_v46 (Il2CppMethodInfo)+C]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S4_v47+60]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S4_v48+48]");
		object obj48 = 0;
		object obj49 = obj48 & 0x7FF;
		object obj50 = obj49 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v189 @ S5_v38 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S4_v51 (Il2CppMethodInfo)+C]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S4_v52+60]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S4_v53+48]");
		object obj53 = 0;
		object obj54 = obj53 & 0x7FF;
		object obj55 = obj54 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v206 @ S5_v42 (should have been resolved before IL gen)");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S4_v56 (Il2CppMethodInfo)+C]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S4_v57+60]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S4_v58+48]");
		object obj58 = 0;
		object obj59 = obj58 & 0x7FF;
		object obj60 = obj59 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v223 @ S5_v46 (should have been resolved before IL gen)");
		nint num13 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v37 (Il2CppClass<RewardManager>)+5C]");
		object obj61 = (nint)0 + (nint)24;
		object obj62 = default;
		obj61 = obj62;
	}

	public SaveMePopup()
	{
		//IL_02e0: Expected VT, but got Obj
		//IL_02f4: Expected I, but got Obj
		//IL_030a: Expected Obj, but got I
		//IL_0152: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01c3: Expected I, but got Obj
		//IL_01d9: Expected Obj, but got I
		//IL_0383: Expected I, but got Obj
		//IL_0399: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I4
		//IL_01b0: Expected I4, but got Obj
		//IL_0422: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0256: Expected I, but got Obj
		//IL_026c: Expected Obj, but got I
		//IL_0204: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_040b: Expected Obj, but got I4
		//IL_0297: Expected I, but got Obj
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		_ = 1;
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<SaveMeManager>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v83 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72BF");
		int num3 = default;
		if (num3 > InventorySave.coins)
		{
			nint num4 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v55 (Il2CppClass<SaveMeManager>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num5 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v77 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveMeManager.isPurchaseMadeFromIngame = true;
			SaveMeManager.isPurchaseRunningIngame = true;
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v65 (Il2CppClass<UIScreenController>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num7 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v73 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).DebugCloseAllPopups();
			SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
			((PurchaseUpdater)(object)instance).UpgradePurchased((UpgradeType)num3);
			return;
		}
		InventorySave.LogEarnedEvent(num3, (InAppItemModel.ItemType)"Revive", "N/A");
		if (InventorySave.coins <= -1)
		{
			InventorySave.IncreaseAmount((UpgradeType)(-InventorySave.coins), (int)"Revive");
		}
		nint num8 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v23 (Il2CppClass<SaveMeManager>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num9 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v48 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveMeManager.IncrementSaveMePopupCountInCurrentRun();
		SaveMeManager.isPurchaseMadeFromIngame = false;
		SaveMeManager.isPurchaseRunningIngame = false;
		((OwnBoardsAward)(object)StayInOneLaneMission.instance)._002Ector((AwardStaticData)71, (PersistentAwardProgress)num3, (Action<Award>)(-1));
		SSEventsPopup.ShowIfNeeded();
		nint num10 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v38 (Il2CppClass<UIScreenController>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num11 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v44 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).ClosePopup((GameObject)(object)"SaveMePopup");
	}
}
