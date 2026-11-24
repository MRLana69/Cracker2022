using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.DebugUtil;
using InApp;
using Info;
using Kiloo.Plugins.Facebook;
using SYBO.Common.Visuals;
using UI.FreeStuff;
using UI.Screens.CoinScreenInternal;
using UnityEngine;

namespace UI.Screens;

public class EarnCoinsScreen : UIScreen
{
	private sealed class _003CDelayingRefreshForUserFeedback_003Ed__35(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public EarnCoinsScreen _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected Obj, but got Unknown
				//IL_006b: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003E4__this.Update();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 1f;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
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

	private sealed class _003CDelayedSetScrollViewCenterOffset_003Ed__42(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public EarnCoinsScreen _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0065: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003E4__this._002Ector();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
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

	public GameObject WatchVideoPrefab;

	public GameObject coinEarnerPrefab;

	public GameObject facebookGiftPrefab;

	private GameObject _rewardForVideoButtonPrefab;

	public Font headerFont;

	private GameObject _facebookRewardsButtonPrefab;

	private UITable _table;

	private UIScrollView _dragPanel;

	private GameObject _loadingOffersPrefab;

	private GameObject _listTitleComponent;

	private GameObject _scrollBar;

	private GameObject _noOffersLabelGameObject;

	private CoinEarnerLoadingOffer _coinEarnerLoadingOffer;

	private UIPanel _panel;

	private GameObject _facebookRewardsButton;

	private const int TITLE_LABEL_HEIGHT = 39;

	private const int SMALL_CELL_HEIGHT = 65;

	private const int LARGE_CELL_HEIGHT = 79;

	private static bool _facebookLoginRunning;

	private static bool _shouldRefreshCurrencyEarners;

	private int _tableContentCombinedHeight;

	private bool isVideoAdsSupported
	{
		get
		{
			//IL_011a: Expected I, but got Obj
			//IL_0130: Expected Obj, but got I
			//IL_018d: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0087: Expected I, but got Obj
			//IL_009d: Expected Obj, but got I
			//IL_015f: Expected Obj, but got I4
			//IL_0172: Expected Obj, but got I4
			//IL_00c8: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
			if ((string)(object)enumerator != screenName)
			{
				return true;
			}
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			bool isShowingPopup = ((UIScreenController)flag2).isShowingPopup;
			return (string)isShowingPopup != screenName;
		}
	}

	private void OnApplicationPause(bool pause)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		if (!((FrontScreen)this).IsAnimating(pause ? FrontScreen.AnimatingButton.MyTourButton : FrontScreen.AnimatingButton.SettingsButton))
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+8C]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+8C]");
			FirstPurchaseBonusCharacterHelper component = ((GameObject)0).GetComponent<FirstPurchaseBonusCharacterHelper>();
			component.SetupTexts();
		}
	}

	public override void Init()
	{
		//IL_0042: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+A0]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+7C]");
			((RewardForVideoButton)0).Init(null);
			_ = 1;
		}
	}

	public override void Show()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		ShowIfInactive();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
		object obj = this + 92;
		object obj2 = this - -64;
		GameObject gameObject = ((Component)obj2).gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		UIPanel component = parentInternal.GetComponent<UIPanel>();
		obj = component;
	}

	public unsafe override void Hide()
	{
		//IL_0197: Expected Obj, but got I4
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_026f: Expected Obj, but got I4
		//IL_0287: Expected I, but got Obj
		//IL_029d: Expected Obj, but got I
		//IL_0102: Expected I, but got Obj
		//IL_014f: Expected I, but got Obj
		object obj = 0;
		base.Hide();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_footerHandler).FindKernel((string)null) != 0)
		{
			_footerHandler._002Ector();
		}
		AssetBundleManager instance = AssetBundleManager.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(EarnCoinsScreen.OfferWallRequestSuccess);
		object obj3 = action + 16;
		obj3 = this;
		((OfferWallManager)(object)instance).onOfferWallReceived -= action;
		AssetBundleManager instance2 = AssetBundleManager.Instance;
		OfferWallManager instance3 = OfferWallManager.instance;
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v23 (Il2CppClass<AdLocations>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v41 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((AdSystemManager)(object)instance3).IsCaching((string)(object)AdLocations.EARN_COINS_VIDEOS);
		obj = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
		nint num5 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v31 (Il2CppClass<Flurry>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v37 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Update();
	}

	public override void GainFocus()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0041: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_0082: Expected I, but got Obj
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_01e5: Expected I, but got Obj
		//IL_01fb: Expected Obj, but got I
		//IL_0110: Expected I, but got Obj
		//IL_015d: Expected I, but got Obj
		base.LoseFocus();
		AssetBundleManager instance = AssetBundleManager.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<int> action = default;
		object obj = action + 16;
		obj = this;
		((OfferWallManager)(object)instance).onPendingRewardsReceived += action;
		nint num2 = (nint)typeof(EarnCoinsScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v9 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(EarnCoinsScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v40 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_facebookLoginRunning ? 1u : 0u) != 0)
		{
			return;
		}
		nint num4 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v18 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v36 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
		nint num6 = (nint)typeof(EarnCoinsScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v24 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(EarnCoinsScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v30 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_facebookLoginRunning = false;
	}

	public void RefreshCurrencyEarners()
	{
		Update();
	}

	private void Update()
	{
		ForceRefreshOfferWall();
	}

	private void FillTable()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EarnCoinsScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EarnCoinsScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_shouldRefreshCurrencyEarners ? 1u : 0u) == 0)
		{
			Update();
		}
	}

	private unsafe void InsertEarner(int index, ref int numberOfObjects)
	{
		//IL_09af: Expected I, but got Obj
		//IL_09c5: Expected Obj, but got I
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected Obj, but got Unknown
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Expected Obj, but got Unknown
		//IL_012f: Expected I, but got Obj
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected Obj, but got Unknown
		//IL_071f: Expected Obj, but got I
		//IL_0738: Expected Obj, but got I4
		//IL_076e: Expected I4, but got Obj
		//IL_076e: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I4
		//IL_07c9: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I
		//IL_04ce: Expected Obj, but got I4
		//IL_0202: Expected I4, but got Obj
		//IL_0202: Expected Obj, but got I
		//IL_0bfc: Expected I, but got Obj
		//IL_0c12: Expected Obj, but got I
		//IL_07b4: Expected Obj, but got I
		//IL_04fc: Expected I4, but got Obj
		//IL_0215: Expected I, but got Obj
		//IL_022b: Expected Obj, but got I
		//IL_0ca7: Expected Obj, but got I4
		//IL_051c: Expected I, but got Obj
		//IL_0532: Expected Obj, but got I
		//IL_0a79: Expected Obj, but got I
		//IL_0a92: Expected Obj, but got I4
		//IL_083d: Expected Obj, but got I
		//IL_07dc: Expected I, but got Obj
		//IL_0b44: Expected Obj, but got I
		//IL_0b59: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I
		//IL_0256: Expected I, but got Obj
		//IL_0857: Expected Obj, but got I
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected Obj, but got Unknown
		//IL_05e4: Expected Obj, but got I4
		//IL_055d: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I
		//IL_0893: Expected Obj, but got I4
		//IL_08c1: Expected I4, but got Obj
		//IL_08c1: Expected I4, but got Obj
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_061c: Expected I, but got Obj
		//IL_0632: Expected Obj, but got I
		//IL_0317: Expected I4, but got Obj
		//IL_0317: Expected VT, but got I4
		//IL_0317: Expected VT, but got I
		//IL_0317: Expected VT, but got Obj
		//IL_0317: Expected VT, but got Obj
		//IL_0317: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I
		//IL_08d7: Expected Obj, but got I
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected Obj, but got Unknown
		//IL_0901: Expected I, but got Obj
		//IL_0917: Expected Obj, but got I
		//IL_0b90: Expected I, but got Obj
		//IL_0ba6: Expected Obj, but got I
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0357: Expected I, but got Obj
		//IL_036d: Expected Obj, but got I
		//IL_0c40: Expected Obj, but got I
		//IL_065d: Expected I, but got Obj
		//IL_0ab2: Expected Obj, but got I
		//IL_0ac3: Expected Obj, but got I
		//IL_0ad5: Expected I, but got Obj
		//IL_0aeb: Expected Obj, but got I
		//IL_0994: Expected Obj, but got I4
		//IL_0942: Expected I, but got Obj
		//IL_06aa: Expected I, but got Obj
		//IL_0398: Expected I, but got Obj
		//IL_0446: Expected Obj, but got I4
		//IL_03e5: Expected I, but got Obj
		nint num = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v158 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		EarnCoinsData.EarnCurrencyProfile[] profiles = EarnCoinsData.profiles;
		if (profiles.Length <= index)
		{
			return;
		}
		nint num3 = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v154 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!FacebookRewardsInfo.ShouldShowConnectPopupOnGameOver(index))
		{
			return;
		}
		nint num5 = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v30 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v148 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = EarnCoinsData.profiles + 16;
		int num7 = index << 2;
		object obj7 = obj6 + num7;
		OnlineSettings._003CDownloadCoroutine_003Ed__36 obj8 = (OnlineSettings._003CDownloadCoroutine_003Ed__36)obj7;
		ref int reference;
		if (obj8._003C_003E1__state == 8)
		{
			if (!((CoinScreen)null).IsCoinScreenUnderPopup())
			{
				return;
			}
			object obj9 = this + 156;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+74]");
			GameObject gameObject = ((CoinContainer)0).AddChildGo(_rewardForVideoButtonPrefab);
			obj9 = gameObject;
			obj2 = numberOfObjects;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text = $"{args:000}";
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+9C]");
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0, (byte)(int)text != 0);
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S1_v125 (Il2CppClass<Strings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S1_v161 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+1C]");
			string format = Strings.GetDefault((string)0);
			bool flag = obj8.MoveNext();
			obj3 = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args2 = default;
			string text2 = string.Format(format, args2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+9C]");
			CoinEarnerVideoAds component = ((GameObject)0).GetComponent<CoinEarnerVideoAds>();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+18]");
			string text3 = Strings.GetDefault((string)0);
			bool flag2 = obj8.MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+24]");
			((UIModelController)(object)component).UpdateCelebrationRotation((GameObject)index, (Vector3)text3, (Vector3)text2, (Vector3)0, (Vector3)flag2, false, (byte)(int)_facebookRewardsButton != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+9C]");
			UIDragScrollView component2 = ((GameObject)0).GetComponent<UIDragScrollView>();
			object obj11 = component2 + 12;
			obj11 = _facebookRewardsButton;
			nint num10 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S1_v143 (Il2CppClass<NGUITools>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num11 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S1_v157 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+9C]");
			NGUITools.UpdateWidgetCollider((GameObject)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+9C]");
			UIPlaySound component3 = ((GameObject)0).GetComponent<UIPlaySound>();
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v135 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S0_v144 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component3).FindKernel((string)null) != 0)
			{
				component3.tag = null;
			}
			object obj14 = numberOfObjects + 1;
			reference = ref *(int*)obj14;
			return;
		}
		if (obj8._003C_003E1__state == 10)
		{
			string debugSaveDirectory = SaveGameDebug.debugSaveDirectory;
			if (debugSaveDirectory == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+74]");
			GameObject gameObject2 = ((CoinContainer)0).AddChildGo((GameObject)(object)headerFont);
			obj2 = numberOfObjects;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args3 = default;
			string text4 = $"{args3:000}";
			UnityEngine.Object.DestroyImmediate(gameObject2, (byte)(int)text4 != 0);
			FacebookGiftButton component4 = gameObject2.GetComponent<FacebookGiftButton>();
			nint num14 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S2_v31 (Il2CppClass<Strings>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num15 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S2_v47 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+18]");
			string charType = Strings.GetDefault((string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+1C]");
			string boardType = Strings.GetDefault((string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num16 = 0;
			string text5 = default;
			text5.m_stringLength = (int)num16;
			_ = 0;
			object obj16 = text5 + 16;
			obj16 = this;
			((EventTesterManager)(object)component4).UpdateInfo((string)index, charType, boardType, text5, (string)(object)_facebookRewardsButton);
			UIDragScrollView component5 = gameObject2.GetComponent<UIDragScrollView>();
			object obj17 = component5 + 12;
			obj17 = _facebookRewardsButton;
			nint num17 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v87 (Il2CppClass<NGUITools>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num18 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v107 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.UpdateWidgetCollider(gameObject2);
			UIPlaySound component6 = gameObject2.GetComponent<UIPlaySound>();
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v95 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v103 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component6).FindKernel((string)null) != 0)
			{
				component6.tag = null;
			}
		}
		else
		{
			object obj20 = this + 156;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+74]");
			GameObject gameObject3 = ((CoinContainer)0).AddChildGo(coinEarnerPrefab);
			obj20 = gameObject3;
			obj2 = numberOfObjects;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args4 = default;
			string text6 = $"{args4:000}";
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+9C]");
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)0, (byte)(int)text6 != 0);
			string dataPath = Application.dataPath;
			string key;
			if ((nint)dataPath == 8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+20]");
				key = (string)0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+1C]");
				key = (string)0;
			}
			nint num21 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S1_v32 (Il2CppClass<Strings>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num22 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S1_v72 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format2 = Strings.GetDefault(key);
			bool flag3 = obj8.MoveNext();
			obj2 = flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args5 = default;
			string text7 = string.Format(format2, args5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+9C]");
			CoinEarnerButtonHelper component7 = ((GameObject)0).GetComponent<CoinEarnerButtonHelper>();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+18]");
			string text8 = Strings.GetDefault((string)0);
			bool noGCFriends = obj8.MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num23 = 0;
			_ = 0;
			bool flag4 = default;
			object obj22 = (flag4 ? 1 : 0) + 16;
			obj22 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+24]");
			((FacebookLoginButtonOnline)(object)component7).Init((byte)index != 0, (byte)(int)text8 != 0, (byte)(int)text7 != 0, false, noGCFriends, flag4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+9C]");
			UIDragScrollView component8 = ((GameObject)0).GetComponent<UIDragScrollView>();
			object obj23 = component8 + 12;
			obj23 = _facebookRewardsButton;
			nint num24 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S1_v63 (Il2CppClass<NGUITools>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num25 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ S1_v68 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.EarnCoinsScreen)+9C]");
			NGUITools.UpdateWidgetCollider((GameObject)0);
		}
		object obj25 = numberOfObjects + 1;
		reference = ref *(int*)obj25;
	}

	private unsafe void InsertOffer(ref int numberOfObjects, CoinEarnerLoadingOffer.OffersState offerState)
	{
		//IL_09cd: Expected I, but got Obj
		//IL_09e3: Expected Obj, but got I
		//IL_0cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected Obj, but got Unknown
		//IL_0a43: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected Obj, but got Unknown
		//IL_0759: Expected I, but got Obj
		//IL_076f: Expected Obj, but got I
		//IL_0bf1: Expected I4, but got Obj
		//IL_0c02: Expected Obj, but got I4
		//IL_07e6: Expected I4, but got Obj
		//IL_07e6: Expected Obj, but got I4
		//IL_079a: Expected I, but got Obj
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01bb: Expected I, but got Obj
		//IL_01d1: Expected Obj, but got I
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_04ea: Expected I, but got Obj
		//IL_0500: Expected Obj, but got I
		//IL_0a95: Expected I4, but got Obj
		//IL_0aa6: Expected Obj, but got I4
		//IL_0841: Expected Obj, but got I
		//IL_0b3a: Expected I4, but got Obj
		//IL_0b4b: Expected Obj, but got I4
		//IL_0248: Expected I4, but got Obj
		//IL_0248: Expected Obj, but got I4
		//IL_0256: Expected I, but got Obj
		//IL_026c: Expected Obj, but got I
		//IL_01fc: Expected I, but got Obj
		//IL_0c31: Expected I, but got Obj
		//IL_0c47: Expected Obj, but got I
		//IL_082c: Expected Obj, but got I
		//IL_0577: Expected I4, but got Obj
		//IL_0577: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I4
		//IL_052b: Expected I, but got Obj
		//IL_0ad8: Expected Obj, but got I
		//IL_0af1: Expected Obj, but got I4
		//IL_0d0e: Expected Obj, but got I4
		//IL_0597: Expected I, but got Obj
		//IL_05ad: Expected Obj, but got I
		//IL_02f0: Expected Obj, but got I4
		//IL_0297: Expected I, but got Obj
		//IL_08ad: Expected Obj, but got I4
		//IL_0854: Expected I, but got Obj
		//IL_0b7d: Expected Obj, but got I
		//IL_0b92: Expected Obj, but got I
		//IL_0bb2: Expected Obj, but got Ref
		//IL_030a: Expected Obj, but got I
		//IL_08c7: Expected Obj, but got I
		//IL_0620: Expected Obj, but got I4
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Obj, but got Unknown
		//IL_0645: Expected Obj, but got I4
		//IL_05d8: Expected I, but got Obj
		//IL_0350: Expected I4, but got Obj
		//IL_0350: Expected VT, but got I4
		//IL_0350: Expected VT, but got I
		//IL_0350: Expected VT, but got Obj
		//IL_0350: Expected VT, but got Obj
		//IL_0350: Expected Obj, but got Ref
		//IL_0359: Expected Obj, but got I4
		//IL_0907: Expected I4, but got Obj
		//IL_0907: Expected I4, but got Obj
		//IL_0910: Expected Obj, but got I4
		//IL_0653: Expected Obj, but got I4
		//IL_0665: Expected I, but got Obj
		//IL_067b: Expected Obj, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0383: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I4
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected Obj, but got Unknown
		//IL_093f: Expected I, but got Obj
		//IL_0955: Expected Obj, but got I
		//IL_03a3: Expected I, but got Obj
		//IL_03b9: Expected Obj, but got I
		//IL_0c6d: Expected Obj, but got I4
		//IL_06a6: Expected I, but got Obj
		//IL_0980: Expected I, but got Obj
		//IL_03e4: Expected I, but got Obj
		nint num = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v168 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		EarnCoinsData.EarnCurrencyProfile[] profiles = EarnCoinsData.profiles;
		if ((nint)profiles.Length <= (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref numberOfObjects))
		{
			return;
		}
		nint num3 = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v164 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!FacebookRewardsInfo.ShouldShowConnectPopupOnGameOver((int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref numberOfObjects)))
		{
			return;
		}
		nint num5 = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v30 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v158 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = EarnCoinsData.profiles + 16;
		object obj7 = (nuint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref numberOfObjects) << 2;
		object obj8 = obj6 + obj7;
		OnlineSettings._003CDownloadCoroutine_003Ed__36 obj9 = (OnlineSettings._003CDownloadCoroutine_003Ed__36)obj8;
		if (obj9._003C_003E1__state == 8)
		{
			IEnumerator enumerator = ((EarnCoinsScreen)null).DelayingRefreshForUserFeedback();
			if (enumerator == null)
			{
				return;
			}
			object obj10 = this - -64;
			string go = ((Component)obj10).tag;
			nint num7 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S2_v46 (Il2CppClass<NGUITools>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S2_v66 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num9 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)WatchVideoPrefab != 0);
			obj2 = ((CoinEarnerLoadingOffer.OffersState*)(int)offerState)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text = $"{args:000}";
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num9, (byte)(int)text != 0);
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S1_v110 (Il2CppClass<Strings>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num11 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S1_v140 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+1C]");
			string format = Strings.GetDefault((string)0);
			bool flag = obj9.MoveNext();
			obj3 = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args2 = default;
			string text2 = string.Format(format, args2);
			CoinEarnerVideoAds component = ((GameObject)num9).GetComponent<CoinEarnerVideoAds>();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+18]");
			string text3 = Strings.GetDefault((string)0);
			bool flag2 = obj9.MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+24]");
			((UIModelController)(object)component).UpdateCelebrationRotation((GameObject)System.Runtime.CompilerServices.Unsafe.AsPointer(ref numberOfObjects), (Vector3)text3, (Vector3)text2, (Vector3)0, (Vector3)flag2, false, (byte)(int)_dragPanel != 0);
			UIDragScrollView component2 = ((GameObject)num9).GetComponent<UIDragScrollView>();
			object obj13 = component2 + 12;
			obj13 = _dragPanel;
			NGUITools.UpdateWidgetCollider((GameObject)num9);
			UIPlaySound component3 = ((GameObject)num9).GetComponent<UIPlaySound>();
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v144 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v154 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component3).FindKernel((string)null) != 0)
			{
				component3.tag = null;
			}
			int tableContentCombinedHeight = _tableContentCombinedHeight + 65;
			_tableContentCombinedHeight = tableContentCombinedHeight;
			int value__ = ((CoinEarnerLoadingOffer.OffersState*)(int)offerState)->value__ + 1;
			((CoinEarnerLoadingOffer.OffersState*)(int)offerState)->value__ = value__;
			return;
		}
		if (obj9._003C_003E1__state == 10)
		{
			string debugSaveDirectory = SaveGameDebug.debugSaveDirectory;
			if (debugSaveDirectory == null)
			{
				return;
			}
			object obj15 = this - -64;
			string go2 = ((Component)obj15).tag;
			nint num14 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S2_v26 (Il2CppClass<NGUITools>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num15 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S2_v41 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num16 = NGUITools.CalculateNextDepth((GameObject)(object)go2, (byte)(int)facebookGiftPrefab != 0);
			obj2 = ((CoinEarnerLoadingOffer.OffersState*)(int)offerState)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args3 = default;
			string text4 = $"{args3:000}";
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num16, (byte)(int)text4 != 0);
			FacebookGiftButton component4 = ((GameObject)num16).GetComponent<FacebookGiftButton>();
			nint num17 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S1_v71 (Il2CppClass<Strings>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num18 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S1_v94 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+18]");
			string charType = Strings.GetDefault((string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+1C]");
			string boardType = Strings.GetDefault((string)0);
			((EventTesterManager)(object)component4).UpdateInfo((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref numberOfObjects), charType, boardType, (string)null, (string)(object)_dragPanel);
			UIDragScrollView component5 = ((GameObject)num16).GetComponent<UIDragScrollView>();
			object obj18 = component5 + 12;
			obj18 = _dragPanel;
			NGUITools.UpdateWidgetCollider((GameObject)num16);
			UIPlaySound component6 = ((GameObject)num16).GetComponent<UIPlaySound>();
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v104 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component6).FindKernel((string)null) != 0)
			{
				component6.tag = null;
			}
			int tableContentCombinedHeight2 = _tableContentCombinedHeight + 65;
			_tableContentCombinedHeight = tableContentCombinedHeight2;
			int value__2 = ((CoinEarnerLoadingOffer.OffersState*)(int)offerState)->value__ + 1;
			((CoinEarnerLoadingOffer.OffersState*)(int)offerState)->value__ = value__2;
			return;
		}
		object obj20 = this - -64;
		string go3 = ((Component)obj20).tag;
		nint num21 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S2_v4 (Il2CppClass<NGUITools>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num22 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S2_v21 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num23 = NGUITools.CalculateNextDepth((GameObject)(object)go3, (byte)(int)coinEarnerPrefab != 0);
		obj2 = ((CoinEarnerLoadingOffer.OffersState*)(int)offerState)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args4 = default;
		string text5 = $"{args4:000}";
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num23, (byte)(int)text5 != 0);
		string dataPath = Application.dataPath;
		string key;
		if ((nint)dataPath == 8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+20]");
			key = (string)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+1C]");
			key = (string)0;
		}
		nint num24 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S1_v27 (Il2CppClass<Strings>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num25 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S1_v52 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format2 = Strings.GetDefault(key);
		bool flag3 = obj9.MoveNext();
		obj2 = flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args5 = default;
		string text6 = string.Format(format2, args5);
		CoinEarnerButtonHelper component7 = ((GameObject)num23).GetComponent<CoinEarnerButtonHelper>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+18]");
		string text7 = Strings.GetDefault((string)0);
		bool noGCFriends = obj9.MoveNext();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v39 (Info.OnlineSettings+<DownloadCoroutine>d__36)+24]");
		((FacebookLoginButtonOnline)(object)component7).Init((byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref numberOfObjects) != 0, (byte)(int)text7 != 0, (byte)(int)text6 != 0, false, noGCFriends, false);
		UIDragScrollView component8 = ((GameObject)num23).GetComponent<UIDragScrollView>();
		object obj23 = component8 + 12;
		obj23 = _dragPanel;
		nint num26 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v67 (Il2CppClass<NGUITools>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num27 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v74 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.UpdateWidgetCollider((GameObject)num23);
		int tableContentCombinedHeight3 = _tableContentCombinedHeight + 65;
		_tableContentCombinedHeight = tableContentCombinedHeight3;
		int value__3 = ((CoinEarnerLoadingOffer.OffersState*)(int)offerState)->value__ + 1;
		((CoinEarnerLoadingOffer.OffersState*)(int)offerState)->value__ = value__3;
	}

	private unsafe void InsertVideoButtons(ref int numberOfObjects)
	{
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref numberOfObjects) == null)
		{
			Update();
		}
	}

	private unsafe void ForceRefreshOfferWall()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected I4, but got Unknown
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected Obj, but got Unknown
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Expected I4, but got Unknown
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected Obj, but got Unknown
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I4
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected Obj, but got Unknown
		//IL_0af6: Expected I, but got Obj
		//IL_0b0c: Expected Obj, but got I
		//IL_0291: Expected Obj, but got I
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_0838: Expected I4, but got Obj
		//IL_0845: Expected Obj, but got I4
		//IL_0852: Expected Obj, but got I4
		//IL_03a7: Expected I4, but got Obj
		//IL_03a7: Expected Obj, but got I4
		//IL_0349: Expected I, but got Obj
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_00ac: Expected I, but got Obj
		//IL_03ba: Expected I, but got Obj
		//IL_03d0: Expected Obj, but got I
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_0878: Expected Obj, but got I4
		//IL_0887: Expected Obj, but got F4
		//IL_08a6: Expected I4, but got Obj
		//IL_08c9: Expected I4, but got Obj
		//IL_08fa: Expected Obj, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_098e: Expected I, but got Obj
		//IL_09a4: Expected Obj, but got I
		//IL_03fb: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_0548: Expected I, but got Obj
		//IL_055e: Expected Obj, but got I
		//IL_0448: Expected I, but got Obj
		//IL_09d8: Expected I, but got Obj
		//IL_09ee: Expected Obj, but got I
		//IL_0495: Expected I, but got Obj
		//IL_04ab: Expected Obj, but got I
		//IL_0589: Expected I, but got Obj
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected Obj, but got Unknown
		//IL_0a46: Expected I, but got Obj
		//IL_0a5c: Expected Obj, but got I
		//IL_05d6: Expected I, but got Obj
		//IL_04d6: Expected I, but got Obj
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_0632: Expected I4, but got Obj
		//IL_064d: Expected I, but got Obj
		//IL_0663: Expected Obj, but got I
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_0708: Expected I, but got Obj
		//IL_0a8a: Expected F4, but got I
		//IL_068e: Expected I, but got Obj
		//IL_06e1: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		int num = obj2 + 40;
		object obj3 = obj2 + 16;
		bool flag = (byte)(obj2 + 32) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		object obj4 = obj2 + 24;
		obj4 = obj;
		_ = -1;
		_tableContentCombinedHeight = 0;
		object obj5 = this - -64;
		GameObject gameObject = ((Component)obj5).gameObject;
		object current = ((Transform.Enumerator)(object)gameObject).Current;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v180 (Il2CppClass<NGUITools>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v210 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v194 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v203 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj9 = obj4 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj4 + obj11;
		obj12 = 86;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj4 + obj14;
			if ((nint)obj15 == 86)
			{
				object obj16 = obj4 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_0ab6;
			}
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0ab6;
		IL_0ab6:
		((bool*)(flag ? 1 : 0))->m_value = false;
		_noOffersLabelGameObject.tag = null;
		object obj19 = this - -64;
		string go = ((Component)obj19).tag;
		nint num6 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S2_v10 (Il2CppClass<NGUITools>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num7 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S2_v43 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num8 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)_listTitleComponent != 0);
		ListTitleComponentHelper component = ((GameObject)num8).GetComponent<ListTitleComponentHelper>();
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"{args:000}";
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num8, (byte)(int)text != 0);
		nint num9 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S1_v39 (Il2CppClass<Strings>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S1_v97 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("EARN_COINS_TITLE");
		obj2 = 0;
		_ = 0;
		obj2 = 0f;
		_ = 74f / 255f;
		_ = 128f / 255f;
		_ = 1f;
		((int*)num)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((MeshMorpher)(object)component).BuildMesh((int)text2, num, -142.5f);
		((bool*)(flag ? 1 : 0))->m_value = true;
		int tableContentCombinedHeight = _tableContentCombinedHeight + 39;
		_tableContentCombinedHeight = tableContentCombinedHeight;
		object obj22 = 0;
		while (true)
		{
			nint num11 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v54 (Il2CppClass<Info.EarnCoinsData>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num12 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S0_v121 (Il2CppClass<Info.EarnCoinsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EarnCoinsData.EarnCurrencyProfile[] profiles = EarnCoinsData.profiles;
			if ((nint)obj22 >= profiles.Length)
			{
				break;
			}
			nint num13 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S0_v101 (Il2CppClass<Info.EarnCoinsData>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num14 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S0_v115 (Il2CppClass<Info.EarnCoinsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj25 = EarnCoinsData.profiles + 16;
			object obj26 = obj22 << 2;
			object obj27 = obj25 + obj26;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S0_v110+8]");
			if ((nint)0 == 8)
			{
				break;
			}
			object obj29 = obj22 + 1;
			obj22 = obj29;
		}
		OnFacebookLoginResult(flag);
		nint num15 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v63 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num16 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S0_v96 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool waitForAgeRestriction = AgeRestriction.waitForAgeRestriction;
		nint num17 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S1_v87 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_panel).FindKernel((string)null) != 0)
		{
			object obj32 = _panel + 220;
			((int*)num)->m_value = (int)obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ S1_v70+8]");
			_ = 0;
			nint num19 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S1_v75 (Il2CppClass<System.Math>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num20 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ S1_v83 (Il2CppClass<System.Math>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Int32)+C]");
			float num21 = Math.Abs(0f);
			if (num21 < 1f)
			{
				bool flag2 = IsListBiggerThanClip();
				Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag2);
			}
			else
			{
				this._002Ector();
			}
		}
		nint num22 = (nint)typeof(EarnCoinsScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ S0_v74 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num23 = (nint)typeof(EarnCoinsScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S0_v81 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_shouldRefreshCurrencyEarners = false;
	}

	private IEnumerator DelayingRefreshForUserFeedback()
	{
		//IL_000e: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		//IL_00c5: Expected I, but got Obj
		//IL_00db: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got I4
		//IL_0106: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 11)
		{
			return (IEnumerator)1;
		}
		string dataPath2 = Application.dataPath;
		if ((nint)dataPath2 == 8)
		{
			return (IEnumerator)1;
		}
		string dataPath3 = Application.dataPath;
		if ((nint)dataPath3 == 7)
		{
			return (IEnumerator)1;
		}
		string dataPath4 = Application.dataPath;
		if (dataPath4 != null)
		{
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v27 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool dEBUG_SKIP_VIDEO_ADS = Globals.DEBUG_SKIP_VIDEO_ADS;
			return (IEnumerator)dEBUG_SKIP_VIDEO_ADS;
		}
		return (IEnumerator)1;
	}

	private void OfferWallRequestSuccess()
	{
		AssetBundleManager instance = AssetBundleManager.Instance;
	}

	public void FacebookLoginClicked()
	{
		Update();
	}

	public unsafe void OnFacebookLoginResult(bool loggedIn)
	{
		//IL_01dd: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0084: Expected I4, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_023a: Expected I4, but got Obj
		//IL_026b: Expected Obj, but got I4
		//IL_0165: Expected I4, but got Obj
		//IL_0165: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_0119: Expected I, but got Obj
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_0198: Expected Obj, but got I4
		nint num = (nint)typeof(RewardForVideoButtonHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.FreeStuff.RewardForVideoButtonHelper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RewardForVideoButtonHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v48 (Il2CppClass<UI.FreeStuff.RewardForVideoButtonHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = RewardForVideoButtonHelper.rewards + 12;
		object obj3 = 0;
		object[] args = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = RewardForVideoButtonHelper.rewards + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			RewardForVideoButton.VideoState state = (RewardForVideoButton.VideoState)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v25 (UI.FreeStuff.RewardForVideoButton+VideoState)+14]");
			if (((Func<bool>)0)())
			{
				object obj7 = this - -64;
				string go = ((Component)obj7).tag;
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S2_v5 (Il2CppClass<NGUITools>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S2_v15 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num5 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)_rewardForVideoButtonPrefab != 0);
				bool value = (byte)((((bool*)(loggedIn ? 1 : 0))->m_value ? 1u : 0u) + 1u) != 0;
				((bool*)(loggedIn ? 1 : 0))->m_value = value;
				object obj9 = ((bool*)(loggedIn ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text = $"{args:000}";
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num5, (byte)(int)text != 0);
				UIDragScrollView component = ((GameObject)num5).GetComponent<UIDragScrollView>();
				object obj10 = component + 12;
				obj10 = _dragPanel;
				RewardForVideoButton component2 = ((GameObject)num5).GetComponent<RewardForVideoButton>();
				component2.SetState(state);
				int tableContentCombinedHeight = _tableContentCombinedHeight + 65;
				_tableContentCombinedHeight = tableContentCombinedHeight;
			}
			object obj11 = obj3 + 1;
			obj3 = obj11;
		}
	}

	private static void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01d0: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got I
		//IL_021b: Expected I, but got Obj
		//IL_0231: Expected Obj, but got I
		//IL_0266: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02f9: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_02b0: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I4
		//IL_0154: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = onFinishCallback;
		nint num2 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v57 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7855");
		nint num4 = (nint)typeof(EarnCoinsScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(EarnCoinsScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v51 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_facebookLoginRunning = true;
		nint num6 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v28 (Il2CppClass<SocialManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v47 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		object obj7 = default;
		object obj6 = obj7 + 16;
		obj6 = onFinishCallback;
		if (!SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported, obj7))
		{
			return;
		}
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v43 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueueMessage((string)1);
	}

	private void OnFailSlideInFinish()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00db: Expected Obj, but got I4
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
		obj2 = this;
		((UIScreenController)flag)._QueueMessage(text);
	}

	private void FacebookStatusChanged(bool success)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_00e2: Expected I, but got Obj
		if (success)
		{
			return;
		}
		nint num = (nint)typeof(EarnCoinsScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EarnCoinsScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v36 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_facebookLoginRunning ? 1u : 0u) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(EarnCoinsScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(EarnCoinsScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v30 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_facebookLoginRunning = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		EarnCoinsScreen earnCoinsScreen = default;
		((UnityEngine.Object)earnCoinsScreen).m_CachedPtr = cachedPtr;
		earnCoinsScreen._selectedFooterButton = 0;
		object obj3 = earnCoinsScreen + 16;
		obj3 = this;
		earnCoinsScreen.OnFailSlideInFinish();
	}

	private IEnumerator DelayedSetScrollViewCenterOffset()
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

	private void SetScrollViewCenterOffset()
	{
		((FirstPurchaseBonusBecameInactive)(object)this).EndInvoke((IAsyncResult)null);
	}

	private bool IsListBiggerThanClip()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	public EarnCoinsScreen()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0055: Expected I, but got Obj
		//IL_006b: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I4
		//IL_0141: Expected VT, but got Obj
		//IL_014b: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_0096: Expected I, but got Obj
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		string flurryName = ((FrontScreen)this).GetFlurryName();
		if (flurryName != null)
		{
			_dragPanel.tag = (string)1;
			_scrollBar.tag = (string)1;
		}
		else
		{
			object obj = this - -64;
			string id = ((Component)obj).tag;
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v10 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v19 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_0021_00210 val = (_0021_00210)NGUITools.Draw<T>(id, (NGUITools.OnInitFunc<T>)int.MaxValue);
			Color color = ((UIWidget)1000).color;
			_dragPanel.UpdatePosition();
			_dragPanel.tag = null;
			_scrollBar.tag = null;
		}
		object obj3 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	static EarnCoinsScreen()
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got F4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0106: Expected VT, but got Obj
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_015b: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		obj = -132f;
		_ = 19.4f;
		obj2 = obj;
		object obj3 = obj2 + 16;
		obj3 = obj2;
		CoinScreen.MOST_POPULAR_STICKER_POSITION = (Vector2)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v43 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleId = InAppData.GetBundleId((InAppData.BundleTier)"com.kiloo.subwaysurfers.coinstier2.5");
		throw new ArrayTypeMismatchException();
	}
}
