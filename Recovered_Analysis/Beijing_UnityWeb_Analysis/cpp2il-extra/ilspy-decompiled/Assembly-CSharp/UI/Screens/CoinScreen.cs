using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AppRefresh;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Extensions;
using Kiloo.Common.Timer;
using Kiloo.Common.Utility;
using Kiloo.Plugins.Facebook;
using SYBO.Common.Visuals;
using SYBO.Subway.Info;
using UI.DoubleCoinsVideo;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Popups;
using UI.Popups.AgeRestrictionPopupInternal;
using UI.Screens.CoinScreenInternal;
using UnityEngine;

namespace UI.Screens;

public class CoinScreen : UIScreen
{
	private const float SPECIAL_SALE_NOTIFICATION_OFFSET = -59.5f;

	private const string WINTER_SALE_OFFER_COLOR_CODE = "[E6E5A2]";

	private const string WINTER_SALE_IGNORE_COLOR_CODE = "[c]";

	private const string WINTER_SALE_IGNORE_COLOR_CLOSING_CODE = "[/c]";

	private const string WINTER_SALE_END_COLOR_CODE = "[-]";

	private const string ONLINESETTINGS_MOST_POPULAR_STICKER_PRODUCT_ID_WITHOUT_PREFIX = "most_popular_sticker_product_id_without_prefix";

	private const int FIRST_PURCHASE_BONUS_BANNER_WIDTH = 330;

	private const int FIRST_PURCHASE_BONUS_BANNER_COINSCREEN_HEIGHT = 60;

	private const int FIRST_PURCHASE_BONUS_BANNER_HEIGHT = 82;

	private const int MOST_POPULAR_STICKER_PADDING = 3;

	private static readonly Vector2 MOST_POPULAR_STICKER_POSITION;

	private static readonly string[] MOST_POPULAR_STICKER_DEFAULT_PRODUCT_ID_WITHOUT_PREFIX;

	public GameObject coinPrefab;

	public GameObject coinEarnerPrefab;

	public GameObject restorePrefab;

	public GameObject watchVideoPrefab;

	public GameObject facebookGiftPrefab;

	public GameObject specialSaleWinterHolidayNotificationPrefab;

	public GameObject specialSaleNewYearNotificationPrefab;

	public Font headerFont;

	private GameObject _facebookRewardsButtonPrefab;

	private GameObject _doubleCoinsPrefab;

	private GameObject _starterPackPrefab;

	private GameObject _firstPurchaseBonusBannerPrefab;

	private GameObject _welcomePackBannerPrefab;

	private GameObject _mostPopularStickerPrefab;

	private UIScrollView _parentDragPanel;

	private UIWidget _outline;

	private GameObject listTitleComponent;

	private UIPanel _coinScreenPanel;

	private UIPanel _scrollPanel;

	private CoinContainer _coinContainer;

	private GameObject _dynamicContentRoot;

	private VerticalLayout _dynamicContentVerticalLayout;

	private ScrollViewHeightResizer _scrollViewHeightResizer;

	private bool shouldShowEarners;

	private static bool _facebookLoginRunning;

	private static bool _shouldRefreshScreen;

	private GameObject _facebookRewardsButton;

	private GameObject _firstPurchaseBonusBannerGo;

	private bool _wasWelcomePackActive;

	private bool _subscribedToEvents;

	private string[] _mostPopularStickerProductIds;

	private Action m_coinScreenHasAppeared;

	public static bool openedFromWelcomePackGetNowClick;

	private GameObject _go;

	private bool _hasUpdatedGeometryOnce;

	private bool isVideoAddsSupported
	{
		get
		{
			//IL_00da: Expected I, but got Obj
			//IL_00f0: Expected Obj, but got I
			//IL_015c: Expected I, but got Obj
			//IL_0172: Expected Obj, but got I
			//IL_0128: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_00ad: Expected Obj, but got I4
			//IL_00b6: Expected Obj, but got I4
			//IL_00c3: Expected Obj, but got I4
			//IL_00c7: Expected I4, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CoinScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = StringUtility.ArrayToString(MOST_POPULAR_STICKER_DEFAULT_PRODUCT_ID_WITHOUT_PREFIX, ",");
			nint num3 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v23 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			bool value = ((OnlineSettings)(object)saveDataPath).GetValue("most_popular_sticker_product_id_without_prefix", (byte)(int)text != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num5 = default;
			object obj3 = num5 + 16;
			obj3 = 44;
			return (byte)(int)((string)value).Substring(num5) != 0;
		}
	}

	public event Action coinScreenHasAppeared
	{
		add
		{
			//IL_00e0: Expected Obj, but got I4
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected Obj, but got Unknown
			//IL_00f7: Expected Obj, but got I4
			//IL_010f: Expected I, but got Obj
			//IL_0125: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00ba: Expected Obj, but got I4
			object obj = 0;
			object obj2 = obj + 8;
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v38 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId = Flurry.flurryUserId;
			if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj4 = default;
				if ((nint)obj4 != 7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj5 = default;
					if ((nint)obj5 != 3)
					{
						goto IL_0176;
					}
				}
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
				_ = 1;
				object obj6 = default;
				obj = obj6;
			}
			goto IL_0176;
			IL_0176:
			CoinScreen coinScreen = (CoinScreen)obj;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_coinScreenHasAppeared;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 152;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public override void Init()
	{
	}

	private void OnApplicationResumed()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_008a: Expected VT, but got Obj
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 24);
		object obj = transform2 + 12;
		obj = 0;
		_ = 0;
		ShowIfInactive();
		if (UI.DoubleCoinsVideo.DoubleCoinsVideo.payoutCap != 0)
		{
			GameObject gameObject = _parentDragPanel.gameObject;
			Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
			transform2.localPosition = (Vector3)parentInternal;
			obj = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			_ = 0f;
			GameObject gameObject2 = _parentDragPanel.gameObject;
			Transform parentInternal2 = ((Transform)(object)gameObject2).parentInternal;
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
	}

	private void Update()
	{
		OnPanelGeometryUpdated();
	}

	public override void Show()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CoinScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_shouldRefreshScreen ? 1u : 0u) == 0)
		{
			Update();
		}
	}

	public unsafe override void Hide()
	{
		//IL_05d8: Expected I, but got Obj
		//IL_05ee: Expected Obj, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0594: Expected I4, but got Obj
		//IL_053f: Expected I, but got Obj
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0093: Expected I, but got Obj
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01e6: Expected I, but got Obj
		//IL_01fc: Expected Obj, but got I
		//IL_015a: Expected I, but got Obj
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected Obj, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected Obj, but got Unknown
		//IL_0286: Expected I, but got Obj
		//IL_029c: Expected Obj, but got I
		//IL_0227: Expected I, but got Obj
		//IL_0367: Expected I, but got Obj
		//IL_037d: Expected Obj, but got I
		//IL_02c7: Expected I, but got Obj
		//IL_0768: Expected I, but got Obj
		//IL_077e: Expected Obj, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_03a8: Expected I, but got Obj
		//IL_03f5: Expected I, but got Obj
		//IL_0442: Expected I, but got Obj
		//IL_0458: Expected Obj, but got I
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected Obj, but got Unknown
		//IL_0483: Expected I, but got Obj
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		base.Hide();
		if (~(_subscribedToEvents ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(CoinScreen.OnApplicationResumed);
			object obj = action + 16;
			obj = this;
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v25 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v121 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIScreenController.OnApplicationResumed -= action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			Action<string> action2 = default;
			object obj3 = action2 + 16;
			obj3 = this;
			UIScreenController.OnPopupShown -= action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			Action<string> action3 = default;
			object obj4 = action3 + 16;
			obj4 = this;
			UIScreenController.OnPopupClosed -= action3;
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v51 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v117 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action4 = default;
			((Delegate)action4).method_ptr = method_ptr2;
			((Delegate)action4).method = (nint)__ldftn(CoinScreen.OnOnlineSettingsFinishedDownloading);
			object obj6 = action4 + 16;
			obj6 = this;
			((OnlineSettings)(object)saveDataPath).RemoveOnFinishedDownloadingOnlineSettingsHandler(action4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr3 = 0;
			FirstPurchaseBonusBecameInactive firstPurchaseBonusBecameInactive = default;
			((Delegate)firstPurchaseBonusBecameInactive).method_ptr = method_ptr3;
			((Delegate)firstPurchaseBonusBecameInactive).method = (nint)__ldftn(CoinScreen.RefreshCurrencyEarners);
			object obj7 = firstPurchaseBonusBecameInactive + 16;
			obj7 = this;
			nint num7 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v64 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(FirstPurchaseBonusManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v113 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FirstPurchaseBonusManager.onFirstPurchaseBonusBecameInactive -= firstPurchaseBonusBecameInactive;
			UIPanel scrollPanel = _scrollPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr4 = 0;
			Delegate obj9 = default;
			obj9.method_ptr = method_ptr4;
			obj9.method = (nint)__ldftn(CoinScreen.OnPanelGeometryUpdated);
			object obj10 = obj9 + 16;
			obj10 = this;
			object obj11 = _scrollPanel + 80;
			Delegate obj12 = ((Delegate)scrollPanel.onGeometryUpdated).CombineImpl(obj9);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj13 = default;
			obj11 = obj13;
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S1_v108 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_scrollViewHeightResizer).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr5 = 0;
				Action action5 = default;
				((Delegate)action5).method_ptr = method_ptr5;
				((Delegate)action5).method = (nint)__ldftn(CoinScreen.FillTable);
				object obj15 = action5 + 16;
				obj15 = this;
				_scrollViewHeightResizer.onRearrangedScrollView -= action5;
			}
			nint num11 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v85 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num12 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v107 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S1_v75 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S1_v97 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)activeInAppOffers).FindKernel((string)null) != 0)
			{
				nint num15 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v95 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num16 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v103 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr6 = 0;
				InAppManager.OnProductRequestDone onProductRequestDone = default;
				((Delegate)onProductRequestDone).method_ptr = method_ptr6;
				((Delegate)onProductRequestDone).method = (nint)__ldftn(CoinScreen.OnProductRequestDone);
				object obj19 = onProductRequestDone + 16;
				obj19 = this;
				((InAppManager)(object)activeInAppOffers2).onProductRequestDone -= onProductRequestDone;
				Dictionary<string, InAppItemModel> activeInAppOffers3 = InAppManager.GetActiveInAppOffers();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr7 = 0;
				InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
				((Delegate)onPurchaseSuccess).method_ptr = method_ptr7;
				((Delegate)onPurchaseSuccess).method = (nint)__ldftn(CoinScreen.OnPurchaseSuccess);
				object obj20 = onPurchaseSuccess + 16;
				obj20 = this;
				((InAppManager)(object)activeInAppOffers3).onPurchaseSuccess -= onPurchaseSuccess;
			}
			_subscribedToEvents = true;
		}
		nint num17 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_footerHandler).FindKernel((string)null) != 0)
		{
			_footerHandler._002Ector();
		}
		OnFacebookLoginResult((byte)(int)this != 0);
		Update();
	}

	public unsafe void RefreshCurrencyEarners()
	{
		//IL_05f9: Expected I, but got Obj
		//IL_060f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_00cc: Expected I, but got Obj
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got I4
		//IL_021b: Expected I, but got Obj
		//IL_0231: Expected Obj, but got I
		//IL_01a3: Expected I, but got Obj
		//IL_070a: Expected I, but got Obj
		//IL_0720: Expected Obj, but got I
		//IL_025c: Expected I, but got Obj
		//IL_0778: Expected I, but got Obj
		//IL_078e: Expected Obj, but got I
		//IL_02a9: Expected I, but got Obj
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_041b: Expected I, but got Obj
		//IL_0431: Expected Obj, but got I
		//IL_0381: Expected I, but got Obj
		//IL_07c2: Expected I, but got Obj
		//IL_07d8: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_045c: Expected I, but got Obj
		//IL_04a9: Expected I, but got Obj
		//IL_04f6: Expected I, but got Obj
		//IL_050c: Expected Obj, but got I
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected Obj, but got Unknown
		//IL_0537: Expected I, but got Obj
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got Unknown
		base.LoseFocus();
		nint num = (nint)typeof(CoinScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v127 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		openedFromWelcomePackGetNowClick = false;
		if (~(_subscribedToEvents ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action = default;
		object obj2 = action + 16;
		obj2 = this;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v23 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v123 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(CoinScreen.OnPopupShown);
		object obj4 = action2 + 16;
		obj4 = this;
		UIScreenController.OnLastPopupClosed += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		UIScreenController uIScreenController = default;
		((UnityEngine.Object)uIScreenController).m_CachedPtr = cachedPtr;
		uIScreenController.popupAnchor = (GameObject)0;
		object obj5 = uIScreenController + 16;
		obj5 = this;
		uIScreenController.Awake();
		nint num6 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v49 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v119 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		string text = default;
		text.m_stringLength = (int)num8;
		_ = 0;
		object obj7 = text + 16;
		obj7 = this;
		((OnlineSettings)(object)saveDataPath).SetCurrentChecksum(text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		RefreshType refreshType = default;
		object obj8 = refreshType + 16;
		obj8 = this;
		nint num10 = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v62 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num11 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v115 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FirstPurchaseBonusManager.AppWillRefresh(refreshType);
		nint num12 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v107 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_scrollPanel).FindKernel((string)null) != 0)
		{
			UIPanel scrollPanel = _scrollPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Delegate obj11 = default;
			obj11.method_ptr = method_ptr2;
			obj11.method = (nint)__ldftn(CoinScreen.OnPanelGeometryUpdated);
			object obj12 = obj11 + 16;
			obj12 = this;
			object obj13 = _scrollPanel + 80;
			Delegate obj14 = ((Delegate)scrollPanel.onGeometryUpdated).RemoveImpl(obj11);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj15 = default;
			obj13 = obj15;
		}
		nint num14 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v93 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_scrollViewHeightResizer).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr2 = 0;
			ScrollViewHeightResizer scrollViewHeightResizer = default;
			((UnityEngine.Object)scrollViewHeightResizer).m_CachedPtr = cachedPtr2;
			scrollViewHeightResizer._scrollPanel = (UIPanel)0;
			object obj17 = scrollViewHeightResizer + 16;
			obj17 = this;
			Vector4 clipping = scrollViewHeightResizer.clipping;
		}
		nint num16 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v76 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num17 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v98 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		nint num18 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S1_v82 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)activeInAppOffers).FindKernel((string)null) != 0)
		{
			nint num20 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v86 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num21 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v94 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr3 = 0;
			InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
			((Delegate)onPurchaseSuccess).method_ptr = method_ptr3;
			((Delegate)onPurchaseSuccess).method = (nint)__ldftn(CoinScreen.OnProductRequestDone);
			object obj21 = onPurchaseSuccess + 16;
			obj21 = this;
			((InAppManager)(object)activeInAppOffers2).onPurchaseSuccess += onPurchaseSuccess;
			Dictionary<string, InAppItemModel> activeInAppOffers3 = InAppManager.GetActiveInAppOffers();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr4 = 0;
			InAppManager.OnPurchaseFailure onPurchaseFailure = default;
			((Delegate)onPurchaseFailure).method_ptr = method_ptr4;
			((Delegate)onPurchaseFailure).method = (nint)__ldftn(CoinScreen.OnPurchaseSuccess);
			object obj22 = onPurchaseFailure + 16;
			obj22 = this;
			((InAppManager)(object)activeInAppOffers3).onPurchaseFailure += onPurchaseFailure;
		}
		_subscribedToEvents = false;
	}

	private void FillTable()
	{
		OnPanelGeometryUpdated();
	}

	private unsafe void OnPanelGeometryUpdated()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e76: Expected Ref, but got Unknown
		//IL_1e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8d: Expected Obj, but got Unknown
		//IL_1e96: Expected Obj, but got I4
		//IL_1ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eaa: Expected Obj, but got Unknown
		//IL_1eda: Expected I, but got Obj
		//IL_1ef0: Expected Obj, but got I
		//IL_1f1b: Expected I, but got Obj
		//IL_1f31: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I4
		//IL_011f: Expected I4, but got Obj
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_1f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6a: Expected Obj, but got Unknown
		//IL_1f73: Expected Obj, but got I4
		//IL_1f82: Expected Obj, but got F4
		//IL_1f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa2: Expected I4, but got Unknown
		//IL_1faf: Expected I4, but got Obj
		//IL_1fd2: Expected I4, but got Obj
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_016e: Expected I, but got Obj
		//IL_02b4: Expected I, but got Obj
		//IL_02ca: Expected Obj, but got I
		//IL_1ff2: Expected I, but got Obj
		//IL_2008: Expected Obj, but got I
		//IL_02f5: Expected I, but got Obj
		//IL_025b: Expected I4, but got Obj
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0298: Expected Obj, but got I4
		//IL_03e2: Expected I, but got Obj
		//IL_0389: Expected I4, but got Obj
		//IL_21bd: Expected I, but got Obj
		//IL_21d3: Expected Obj, but got I
		//IL_042f: Expected I, but got Obj
		//IL_0445: Expected Obj, but got I
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_03c6: Expected Obj, but got I4
		//IL_26a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a9: Expected Obj, but got Unknown
		//IL_26bb: Expected Obj, but got I4
		//IL_0b06: Expected Obj, but got I4
		//IL_0abe: Expected I, but got Obj
		//IL_070e: Expected I, but got Obj
		//IL_0724: Expected Obj, but got I
		//IL_0470: Expected I, but got Obj
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04ed: Expected Obj, but got I
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_0529: Expected I, but got Obj
		//IL_053f: Expected Obj, but got I
		//IL_0bf6: Expected Obj, but got I4
		//IL_0c0c: Expected Obj, but got I4
		//IL_20d7: Expected Obj, but got I4
		//IL_2102: Expected I4, but got Obj
		//IL_074f: Expected I, but got Obj
		//IL_228e: Expected Obj, but got I4
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected Obj, but got Unknown
		//IL_096e: Expected I, but got Obj
		//IL_0984: Expected Obj, but got I
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected Obj, but got Unknown
		//IL_07d5: Expected Obj, but got I
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got Unknown
		//IL_0811: Expected I, but got Obj
		//IL_0827: Expected Obj, but got I
		//IL_056a: Expected I, but got Obj
		//IL_0c29: Expected Obj, but got I4
		//IL_05b7: Expected I, but got Obj
		//IL_05cd: Expected Obj, but got I
		//IL_2214: Unknown result type (might be due to invalid IL or missing references)
		//IL_2219: Expected Obj, but got Unknown
		//IL_09fb: Expected Obj, but got I4
		//IL_09fb: Expected Obj, but got I4
		//IL_09af: Expected I, but got Obj
		//IL_0852: Expected I, but got Obj
		//IL_0c4a: Expected Obj, but got I4
		//IL_21f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_21fe: Expected Obj, but got Unknown
		//IL_0a18: Expected Obj, but got I4
		//IL_0a27: Expected Obj, but got F4
		//IL_0a40: Expected I4, but got Obj
		//IL_0a56: Expected Obj, but got I4
		//IL_0a85: Expected Obj, but got I4
		//IL_089f: Expected I, but got Obj
		//IL_08b5: Expected Obj, but got I
		//IL_05f8: Expected I, but got Obj
		//IL_0c62: Expected Obj, but got I4
		//IL_0c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c72: Expected Obj, but got Unknown
		//IL_0c9f: Expected Obj, but got I4
		//IL_0934: Expected I4, but got Obj
		//IL_08e0: Expected I, but got Obj
		//IL_0cb7: Expected Obj, but got I4
		//IL_0ccf: Expected Obj, but got I4
		//IL_14e0: Expected Obj, but got I
		//IL_0ce7: Expected Obj, but got I4
		//IL_1597: Expected I4, but got Obj
		//IL_0cff: Expected Obj, but got I4
		//IL_1516: Unknown result type (might be due to invalid IL or missing references)
		//IL_151b: Expected Obj, but got Unknown
		//IL_0d17: Expected Obj, but got I4
		//IL_15cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d2: Expected Obj, but got Unknown
		//IL_15ef: Expected Obj, but got I4
		//IL_15fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1602: Expected Obj, but got Unknown
		//IL_162c: Expected Obj, but got I4
		//IL_0d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d39: Expected Obj, but got Unknown
		//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d46: Expected Obj, but got Unknown
		//IL_0d59: Expected Obj, but got I4
		//IL_165c: Expected I4, but got Obj
		//IL_154c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1551: Expected Obj, but got Unknown
		//IL_1679: Unknown result type (might be due to invalid IL or missing references)
		//IL_167e: Expected Obj, but got Unknown
		//IL_1696: Expected I, but got Obj
		//IL_16ac: Expected Obj, but got I
		//IL_22ec: Expected Obj, but got I4
		//IL_27c2: Expected I, but got Obj
		//IL_27d8: Expected Obj, but got I
		//IL_16d7: Expected I, but got Obj
		//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e40: Expected Obj, but got Unknown
		//IL_0e58: Expected I, but got Obj
		//IL_0e6e: Expected Obj, but got I
		//IL_0da6: Expected I, but got Obj
		//IL_0dbc: Expected Obj, but got I
		//IL_1724: Expected I, but got Obj
		//IL_173a: Expected Obj, but got I
		//IL_223f: Expected Obj, but got VT
		//IL_2254: Expected I4, but got Obj
		//IL_2267: Expected Obj, but got I4
		//IL_1e19: Expected I, but got Obj
		//IL_0ee8: Expected Obj, but got I4
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efe: Expected Obj, but got Unknown
		//IL_0e99: Expected I, but got Obj
		//IL_0de7: Expected I, but got Obj
		//IL_1765: Expected I, but got Obj
		//IL_17b2: Expected I, but got Obj
		//IL_17c8: Expected Obj, but got I
		//IL_0ec2: Expected Obj, but got I4
		//IL_0e10: Expected Obj, but got I4
		//IL_234f: Expected I, but got Obj
		//IL_2365: Expected Obj, but got I
		//IL_17f3: Expected I, but got Obj
		//IL_1840: Expected I, but got Obj
		//IL_1945: Expected Obj, but got I4
		//IL_188d: Expected I, but got Obj
		//IL_18a3: Expected Obj, but got I
		//IL_1973: Expected I4, but got Obj
		//IL_1981: Expected I, but got Obj
		//IL_1997: Expected Obj, but got I
		//IL_23bc: Expected Obj, but got I4
		//IL_23cb: Expected Obj, but got F4
		//IL_23ea: Expected I4, but got Obj
		//IL_240d: Expected I4, but got Obj
		//IL_1b0c: Expected I, but got Obj
		//IL_1b22: Expected Obj, but got I
		//IL_18ce: Expected I, but got Obj
		//IL_19f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f5: Expected Obj, but got Unknown
		//IL_1a12: Expected Obj, but got I4
		//IL_19c2: Expected I, but got Obj
		//IL_24bd: Expected I, but got Obj
		//IL_24d3: Expected Obj, but got I
		//IL_1b4d: Expected I, but got Obj
		//IL_1b80: Expected I, but got Obj
		//IL_1b96: Expected Obj, but got I
		//IL_1a36: Expected I, but got Obj
		//IL_1a69: Expected I, but got Obj
		//IL_1a7f: Expected Obj, but got I
		//IL_1bc1: Expected I, but got Obj
		//IL_2454: Unknown result type (might be due to invalid IL or missing references)
		//IL_2459: Expected Obj, but got Unknown
		//IL_246f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2474: Expected Obj, but got Unknown
		//IL_2803: Expected I, but got Obj
		//IL_2819: Expected Obj, but got I
		//IL_1bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf1: Expected Obj, but got Unknown
		//IL_1aaa: Expected I, but got Obj
		//IL_1c50: Expected I4, but got Obj
		//IL_1d14: Expected I, but got Obj
		//IL_1c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c72: Expected Obj, but got Unknown
		//IL_1d47: Expected I, but got Obj
		//IL_1d5d: Expected Obj, but got I
		//IL_1cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cca: Expected Obj, but got Unknown
		//IL_1cd3: Expected Obj, but got I4
		//IL_258c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2591: Expected Obj, but got Unknown
		//IL_25a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ac: Expected Obj, but got Unknown
		//IL_1cf8: Expected Obj, but got I4
		//IL_1d88: Expected I, but got Obj
		//IL_143a: Unknown result type (might be due to invalid IL or missing references)
		//IL_143f: Expected Obj, but got Unknown
		//IL_1448: Unknown result type (might be due to invalid IL or missing references)
		//IL_144d: Expected Obj, but got Unknown
		//IL_1479: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		ref int reference = ref *(int*)(obj2 + 56);
		reference = ref *(int*)null;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = obj;
		_ = -1;
		_coinContainer.ActivateSpecialSale();
		reference = ref *(int*)null;
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v676 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v453 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_firstPurchaseBonusBannerGo).FindKernel((string)null) != 0)
		{
			MiscExtensions.SafeInvoke((Action)(object)_firstPurchaseBonusBannerGo);
		}
		GameObject gameObject = _coinContainer.AddChildGo(listTitleComponent);
		ListTitleComponentHelper component = gameObject.GetComponent<ListTitleComponentHelper>();
		obj2 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"{args:000}";
		UnityEngine.Object.DestroyImmediate(gameObject, (byte)(int)text != 0);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v32 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v448 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("STORE_TITLE");
		object obj8 = obj2 + 16;
		obj8 = 0;
		_ = 0;
		obj8 = 0f;
		_ = 74f / 255f;
		_ = 128f / 255f;
		_ = 1f;
		int num7 = obj2 - -64;
		((int*)num7)->m_value = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v13+8]");
		_ = 0;
		((MeshMorpher)(object)component).BuildMesh((int)text2, num7, -142f);
		UIDragScrollView component2 = gameObject.GetComponent<UIDragScrollView>();
		object obj9 = component2 + 12;
		obj9 = _parentDragPanel;
		object obj10 = reference + 1;
		reference = ref *(int*)obj10;
		if (WelcomePackManager.ParseFirstInstalledVersion() != 0)
		{
			GameObject gameObject2 = _coinContainer.AddChildGo(_welcomePackBannerPrefab);
			((int*)num7)->m_value = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args2 = default;
			string text3 = $"{args2:000}";
			UnityEngine.Object.DestroyImmediate(gameObject2, (byte)(int)text3 != 0);
			UIDragScrollView component3 = gameObject2.GetComponent<UIDragScrollView>();
			object obj11 = component3 + 12;
			obj11 = _parentDragPanel;
			object obj12 = reference + 1;
			reference = ref *(int*)obj12;
		}
		else
		{
			nint num8 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v639 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num9 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v658 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool hasPaidOutFacebookReward = UserSave.hasPaidOutFacebookReward;
			if ((hasPaidOutFacebookReward ? 1 : 0) != 5)
			{
				GameObject gameObject3 = _coinContainer.AddChildGo(_starterPackPrefab);
				((int*)num7)->m_value = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args3 = default;
				string text4 = $"{args3:000}";
				UnityEngine.Object.DestroyImmediate(gameObject3, (byte)(int)text4 != 0);
				UIDragScrollView component4 = gameObject3.GetComponent<UIDragScrollView>();
				object obj14 = component4 + 12;
				obj14 = _parentDragPanel;
				object obj15 = reference + 1;
				reference = ref *(int*)obj15;
			}
		}
		nint num10 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v43 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num11 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v634 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (InAppManager.IsWinterHolidaySpecialSaleActive)
		{
			nint num12 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v538 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num13 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v630 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (InAppManager.IsNewYearSpecialSaleActive)
			{
				object obj18 = this + 156;
				GameObject gameObject4 = _coinContainer.AddChildGo(specialSaleWinterHolidayNotificationPrefab);
				obj18 = gameObject4;
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S2_v179 (Il2CppMethodInfo)+18]");
				object obj19 = 0;
				object obj20 = obj19;
				object obj21 = obj20 & 0x1FFF;
				object obj22 = obj21 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v380 @ S3_v74 (should have been resolved before IL gen)");
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v605 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num16 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v626 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				ComputeShader computeShader = default;
				if (computeShader.FindKernel(null) != 0)
				{
					nint num17 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ S0_v613 (Il2CppClass<Strings>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num18 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S0_v622 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text5 = Strings.GetDefault("SALE_WINTER_OFFER_TEXT");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					throw new ArrayTypeMismatchException();
				}
			}
			else
			{
				nint num19 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S0_v563 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				if (obj25 != null)
				{
					nint num20 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v595 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (AdsSave.behavioralAdsAllowed)
				{
					object obj26 = this + 156;
					object go = this - -64;
					GameObject gameObject5 = _coinContainer.AddChildGo((GameObject)go);
					obj26 = gameObject5;
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ S2_v168 (Il2CppMethodInfo)+18]");
					object obj27 = 0;
					object obj28 = obj27;
					object obj29 = obj28 & 0x1FFF;
					object obj30 = obj29 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v440 @ S3_v65 (should have been resolved before IL gen)");
					nint num22 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S0_v575 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj31 = (nint)0 & (nint)0x200;
					if (obj31 != null)
					{
						nint num23 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v591 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					ComputeShader computeShader2 = default;
					if (computeShader2.FindKernel(null) != 0)
					{
						nint num24 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v582 (Il2CppClass<Strings>)+BA]");
						object obj32 = (nint)0 & (nint)0x200;
						if (obj32 != null)
						{
							nint num25 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ S0_v587 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string centerer = Strings.GetDefault("SALE_NEW_YEAR_HEADER");
						string content = Strings.GetDefault("SALE_NEW_YEAR_SUBHEADER");
						string listView = Strings.GetDefault("SALE_NEW_YEAR_OFFER_TEXT");
						AgeRestrictionPopup.ArrowClicked((byte)(int)computeShader2 != 0, (CenterOnChild)(object)centerer, (List<ListContentElement>)(object)content, (ScrollView)(object)listView);
					}
				}
			}
			obj2 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args4 = default;
			string text6 = $"{args4:000}";
			UnityEngine.Object.DestroyImmediate(_go, (byte)(int)text6 != 0);
			UIDragScrollView component5 = _go.GetComponent<UIDragScrollView>();
			object obj33 = component5 + 12;
			obj33 = _parentDragPanel;
			nint num26 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S1_v349 (Il2CppClass<NGUITools>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num27 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S1_v370 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.UpdateWidgetCollider(_go);
			int layer = _go.layer;
			int layer2 = gameObject.layer;
			((Transform)layer).parentInternal = (Transform)layer2;
			int layer3 = _go.layer;
			obj8 = 0;
			_ = 0;
			obj8 = 0f;
			_ = -59.5f;
			_ = 0f;
			((int*)num7)->m_value = (int)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v13+8]");
			_ = 0;
			Vector3 eulerAngles = ((Transform)num7).eulerAngles;
			CoinContainer coinContainer = _coinContainer;
			coinContainer.offsetForElementsOnDisplay = -150f;
			object obj35 = reference + 1;
			reference = ref *(int*)obj35;
		}
		else
		{
			CoinContainer coinContainer2 = _coinContainer;
			coinContainer2.offsetForElementsOnDisplay = -59.5f;
		}
		nint num28 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v51 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num29 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v531 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj37 = obj2 + 8;
		bool isAnyDiscountAvailable = InAppManager.IsAnyDiscountAvailable;
		Dictionary<string, InAppItemModel>.ValueCollection values = ((Dictionary<string, InAppItemModel>)isAnyDiscountAvailable).Values;
		IEnumerable<_0021_00210> enumerable = (IEnumerable<_0021_00210>)Enumerable.OfType<TResult>((IEnumerable)values);
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v61 (System.Collections.Generic.IEnumerable`1<TResult>)+C]");
		int num30 = 0;
		while (true)
		{
			int num31 = num30 - 1;
			object obj39 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v61 (System.Collections.Generic.IEnumerable`1<TResult>)+C]");
			if ((nint)obj39 >= 0)
			{
				break;
			}
			InAppItemModel inAppItemModel = ((List<InAppItemModel>)enumerable).get_Item(num31);
			if (inAppItemModel.itemOfferType != InAppItemModel.OfferType.Sale)
			{
				InAppItemModel inAppItemModel2 = ((List<InAppItemModel>)enumerable).get_Item(num31);
				if (inAppItemModel2.itemOfferType != InAppItemModel.OfferType.Promotion)
				{
					num30 = num31;
					goto IL_21f0;
				}
			}
			InAppItemModel item = ((List<InAppItemModel>)enumerable).get_Item(num31);
			((List<InAppItemModel>)enumerable).RemoveAt(num31);
			((List<InAppItemModel>)enumerable).Insert(0, item);
			int num32 = num31 + 1;
			num30 = num32;
			goto IL_21f0;
			IL_21f0:
			object obj40 = obj38 + 1;
			obj38 = obj40;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = ((int*)num7)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S2_v20 (System.Int32)+8]");
		_ = 0;
		object obj41 = 0;
		object obj43 = default;
		object obj45 = default;
		object obj47 = default;
		object obj49 = default;
		object obj52 = default;
		object obj42;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 103;
			bool flag = obj43 == null;
			obj42 = 104;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 71;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj42 = 72;
			object obj44 = this + 156;
			obj44 = obj45;
			((int*)num7)->m_value = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 73;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj42 = 74;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj42 = 74;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj42 = 75;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 81;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj42 = 82;
			bool flag2 = (nint)obj41 > 0;
			object obj46 = obj47 ^ 1;
			object obj48 = flag2 | obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
			obj42 = 83;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj49 != null)
			{
				nint num33 = (nint)typeof(CoinScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1277 @ S0_v489 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
				object obj50 = (nint)0 & (nint)0x200;
				if (obj50 != null)
				{
					nint num34 = (nint)typeof(CoinScreen);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1308 @ S0_v503 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						obj42 = 89;
					}
				}
				obj2 = MOST_POPULAR_STICKER_POSITION;
				obj37 = obj2;
				((int*)num7)->m_value = (int)obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
				obj42 = 96;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj51 = obj52 + 12;
			obj51 = _parentDragPanel;
			nint num35 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ S0_v466 (Il2CppClass<NGUITools>)+BA]");
			object obj53 = (nint)0 & (nint)0x200;
			if (obj53 != null)
			{
				nint num36 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ S0_v478 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj42 = 98;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			object obj54 = reference + 1;
			reference = ref *(int*)obj54;
			object obj55 = obj41 + 1;
			obj41 = obj55;
		}
		object obj56 = obj42 - 71;
		object obj59;
		object obj60 = default;
		if ((nint)obj42 != 71)
		{
			if ((nint)obj56 != 1)
			{
				if ((nint)obj56 != 2 && (nint)obj56 != 3 && (nint)obj56 != 4)
				{
					if ((nint)obj56 == 5 || (nint)obj56 == 6 || (nint)obj56 == 7 || (nint)obj56 == 8 || (nint)obj56 == 9)
					{
						goto IL_270e;
					}
					if ((nint)obj56 != 10)
					{
						if ((nint)obj56 != 11)
						{
							if ((nint)obj56 != 12)
							{
								if ((nint)obj56 != 13)
								{
									if ((nint)obj56 == 14 || (nint)obj56 == 15 || (nint)obj56 == 16 || (nint)obj56 == 17)
									{
										goto IL_270e;
									}
									if ((nint)obj56 != 18)
									{
										if ((nint)obj56 == 19 || (nint)obj56 == 20 || (nint)obj56 == 21 || (nint)obj56 == 22 || (nint)obj56 == 23 || (nint)obj56 == 24)
										{
											goto IL_270e;
										}
										if ((nint)obj56 != 25)
										{
											if ((nint)obj56 != 26)
											{
												object obj57;
												if ((nint)obj56 != 27)
												{
													if ((nint)obj56 != 28 && (nint)obj56 != 29 && (nint)obj56 != 30 && (nint)obj56 != 31)
													{
														if ((nint)obj56 == 32)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj58 = default;
															obj57 = obj58;
															obj59 = obj60;
															goto IL_2298;
														}
														if ((nint)obj56 == 33)
														{
															object obj61 = obj4 + 4;
															object obj62 = obj61 + 1;
															obj61 = obj62;
															object obj63 = obj62 << 2;
															object obj64 = obj4 + obj63;
															obj64 = 1184;
														}
													}
													goto IL_270e;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj65 = default;
												obj57 = obj65;
												obj59 = obj60;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj66 = default;
												object obj57 = obj66;
												obj59 = obj60;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj67 = default;
											object obj57 = obj67;
											obj59 = obj60;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj68 = default;
										object obj57 = obj68;
										obj59 = obj60;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj69 = default;
									object obj57 = obj69;
									obj59 = obj60;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj70 = default;
								object obj57 = obj70;
								obj59 = obj60;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj71 = default;
							object obj57 = obj71;
							obj59 = obj60;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj72 = default;
						object obj57 = obj72;
						obj59 = obj60;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj73 = default;
					object obj57 = obj73;
					obj59 = obj60;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj74 = default;
				object obj57 = obj74;
				obj59 = obj60;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj75 = default;
			object obj57 = obj75;
			obj59 = obj60;
		}
		goto IL_2298;
		IL_2298:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj76 = default;
		if (obj59 == obj76)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_270e;
		IL_1afe:
		nint num37 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1571 @ S0_v167 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj77 = (nint)0 & (nint)0x200;
		if (obj77 != null)
		{
			nint num38 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1594 @ S0_v240 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!AgeRestriction.waitForAgeRestriction)
		{
			nint num39 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1609 @ S0_v175 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj78 = (nint)0 & (nint)0x200;
			if (obj78 != null)
			{
				nint num40 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ S0_v237 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UserSave.allAssetBundlesDownloaded)
			{
				object obj79 = this + 136;
				GameObject gameObject6 = _coinContainer.AddChildGo(_facebookRewardsButtonPrefab);
				obj79 = gameObject6;
				((int*)num7)->m_value = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args5 = default;
				string text7 = $"{args5:000}";
				UnityEngine.Object.DestroyImmediate(_facebookRewardsButton, (byte)(int)text7 != 0);
				UIDragScrollView component6 = _facebookRewardsButton.GetComponent<UIDragScrollView>();
				object obj80 = component6 + 12;
				obj80 = _parentDragPanel;
				FacebookRewardsButton component7 = _facebookRewardsButton.GetComponent<FacebookRewardsButton>();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Action action = default;
				((Delegate)action).method_ptr = method_ptr;
				((Delegate)action).method = (nint)(delegate*<void>)(&FacebookLoginClicked);
				object obj81 = action + 16;
				obj81 = 0;
				component7.onFacebookClick -= action;
				object obj82 = reference + 1;
				reference = ref *(int*)obj82;
			}
			int num41 = 0;
			while (true)
			{
				nint num42 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1709 @ S0_v186 (Il2CppClass<Info.EarnCoinsData>)+BA]");
				object obj83 = (nint)0 & (nint)0x200;
				if (obj83 != null)
				{
					nint num43 = (nint)typeof(EarnCoinsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1733 @ S0_v220 (Il2CppClass<Info.EarnCoinsData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				EarnCoinsData.EarnCurrencyProfile[] profiles = EarnCoinsData.profiles;
				if (num41 >= profiles.Length)
				{
					break;
				}
				nint num44 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1754 @ S0_v193 (Il2CppClass<Info.EarnCoinsData>)+BA]");
				object obj84 = (nint)0 & (nint)0x200;
				if (obj84 != null)
				{
					nint num45 = (nint)typeof(EarnCoinsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1774 @ S0_v215 (Il2CppClass<Info.EarnCoinsData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj85 = EarnCoinsData.profiles + 16;
				int num46 = num41 << 2;
				object obj86 = obj85 + num46;
				object obj87 = obj86;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1789 @ S0_v202+8]");
				if ((nint)0 != 8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1789 @ S0_v202+8]");
					if ((nint)0 != 10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1789 @ S0_v202+8]");
						if ((nint)0 != 9)
						{
							((EarnCoinsScreen)this).InsertEarner(num41, ref reference);
						}
					}
				}
				int num47 = num41 + 1;
				num41 = num47;
			}
		}
		goto IL_279d;
		IL_270e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
			object obj88 = (nint)0 << 2;
			object obj89 = obj4 + obj88;
			if ((nint)obj89 == 1184)
			{
				object obj90 = obj4 + 4;
				if ((nint)obj90 > -1)
				{
					object obj91 = obj90 + -1;
					obj90 = obj91;
				}
				goto IL_2733;
			}
		}
		object obj92 = default;
		if (obj92 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_2733;
		IL_2733:
		GameObject gameObject7 = _coinContainer.AddChildGo(_doubleCoinsPrefab);
		((int*)num7)->m_value = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args6 = default;
		string text8 = $"{args6:000}";
		UnityEngine.Object.DestroyImmediate(gameObject7, (byte)(int)text8 != 0);
		DoubleCoinUpgradeHelper component8 = gameObject7.GetComponent<DoubleCoinUpgradeHelper>();
		component8.OnEnable();
		UIDragScrollView component9 = gameObject7.GetComponent<UIDragScrollView>();
		object obj93 = component9 + 12;
		obj93 = _parentDragPanel;
		object obj94 = reference + 1;
		reference = ref *(int*)obj94;
		object obj95 = this + 156;
		GameObject gameObject8 = _coinContainer.AddChildGo(restorePrefab);
		obj95 = gameObject8;
		obj2 = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args7 = default;
		string text9 = $"{args7:000}";
		UnityEngine.Object.DestroyImmediate(_go, (byte)(int)text9 != 0);
		UIDragScrollView component10 = _go.GetComponent<UIDragScrollView>();
		object obj96 = component10 + 12;
		obj96 = _parentDragPanel;
		nint num48 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1259 @ S1_v112 (Il2CppClass<NGUITools>)+BA]");
		object obj97 = (nint)0 & (nint)0x200;
		if (obj97 != null)
		{
			nint num49 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ S1_v226 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.UpdateWidgetCollider(_go);
		object obj98 = reference + 1;
		reference = ref *(int*)obj98;
		if (~(shouldShowEarners ? 1u : 0u) == 0)
		{
			nint num50 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1339 @ S0_v145 (Il2CppClass<Info.EarnCoinsData>)+BA]");
			object obj99 = (nint)0 & (nint)0x200;
			if (obj99 != null)
			{
				nint num51 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ S0_v308 (Il2CppClass<Info.EarnCoinsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = FacebookRewardsInfo.ShouldShowConnectPopupOnFriendsScreen();
			if ((flag3 ? 1 : 0) >= (true ? 1 : 0))
			{
				nint num52 = (nint)typeof(FirstPurchaseBonusManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1441 @ S0_v153 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
				object obj100 = (nint)0 & (nint)0x200;
				if (obj100 != null)
				{
					nint num53 = (nint)typeof(FirstPurchaseBonusManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1472 @ S0_v304 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num54 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ S0_v158 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj101 = (nint)0 & (nint)0x200;
				if (obj101 != null)
				{
					nint num55 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1494 @ S0_v300 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (AgeRestriction.waitForAgeRestriction)
				{
					nint num56 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1513 @ S0_v288 (Il2CppClass<Info.AgeRestriction>)+BA]");
					object obj102 = (nint)0 & (nint)0x200;
					if (obj102 != null)
					{
						nint num57 = (nint)typeof(AgeRestriction);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1531 @ S0_v297 (Il2CppClass<Info.AgeRestriction>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!AgeRestriction.waitForAgeRestriction || !((CoinScreen)null).IsCoinScreenUnderPopup())
					{
						goto IL_1afe;
					}
				}
				GameObject gameObject9 = _coinContainer.AddChildGo(listTitleComponent);
				ListTitleComponentHelper component11 = gameObject9.GetComponent<ListTitleComponentHelper>();
				obj2 = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args8 = default;
				string text10 = $"{args8:000}";
				UnityEngine.Object.DestroyImmediate(gameObject9, (byte)(int)text10 != 0);
				nint num58 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1602 @ S1_v193 (Il2CppClass<Strings>)+BA]");
				object obj103 = (nint)0 & (nint)0x200;
				if (obj103 != null)
				{
					nint num59 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1615 @ S1_v221 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text11 = Strings.GetDefault("EARN_COINS_TITLE");
				obj8 = 0;
				_ = 0;
				obj8 = 0f;
				_ = 74f / 255f;
				_ = 128f / 255f;
				_ = 1f;
				((int*)num7)->m_value = (int)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v13+8]");
				_ = 0;
				((MeshMorpher)(object)component11).BuildMesh((int)text11, num7, -150f);
				UIDragScrollView component12 = gameObject9.GetComponent<UIDragScrollView>();
				object obj104 = component12 + 12;
				obj104 = _parentDragPanel;
				object obj105 = reference + 1;
				reference = ref *(int*)obj105;
				int num60 = 0;
				while (true)
				{
					nint num61 = (nint)typeof(EarnCoinsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1723 @ S0_v255 (Il2CppClass<Info.EarnCoinsData>)+BA]");
					object obj106 = (nint)0 & (nint)0x200;
					if (obj106 != null)
					{
						nint num62 = (nint)typeof(EarnCoinsData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1742 @ S0_v282 (Il2CppClass<Info.EarnCoinsData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					EarnCoinsData.EarnCurrencyProfile[] profiles2 = EarnCoinsData.profiles;
					if (num60 >= profiles2.Length)
					{
						break;
					}
					nint num63 = (nint)typeof(EarnCoinsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1762 @ S0_v262 (Il2CppClass<Info.EarnCoinsData>)+BA]");
					object obj107 = (nint)0 & (nint)0x200;
					if (obj107 != null)
					{
						nint num64 = (nint)typeof(EarnCoinsData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1794 @ S0_v277 (Il2CppClass<Info.EarnCoinsData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj108 = EarnCoinsData.profiles + 16;
					int num65 = num60 << 2;
					object obj109 = obj108 + num65;
					object obj110 = obj109;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1807 @ S0_v271+8]");
					if ((nint)0 != 8)
					{
						int num66 = num60 + 1;
						num60 = num66;
						continue;
					}
					((EarnCoinsScreen)this).InsertEarner(num60, ref reference);
					break;
				}
				goto IL_1afe;
			}
		}
		goto IL_279d;
		IL_279d:
		_coinContainer.RepositionTableNow();
		((RewardForVideoButton)(object)_dynamicContentVerticalLayout).Init((VideoButtonPayload)null);
		nint num67 = (nint)typeof(CoinScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1424 @ S0_v125 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
		object obj111 = (nint)0 & (nint)0x200;
		if (obj111 != null)
		{
			nint num68 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1447 @ S0_v138 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_shouldRefreshScreen = false;
		int num69 = WelcomePackManager.ParseFirstInstalledVersion();
		int wasWelcomePackActive = num69 & 1;
		_wasWelcomePackActive = (byte)wasWelcomePackActive != 0;
		if (this.m_coinScreenHasAppeared != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private bool ShouldShowMostPopularSticker(InAppItemModel activeOffer)
	{
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_01c6: Expected I4, but got Obj
		//IL_01d8: Expected I, but got Obj
		//IL_01ee: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01af: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = CharacterManager.HasCharacterBeenSeen((Characters.CharacterId)activeOffer);
		nint num3 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<Info.Outfits>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v32 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((OutfitSet)(object)activeOffer).HasOutfitWithName((string)flag))
		{
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return CharacterManager.HasCharacterBeenSeen((Characters.CharacterId)activeOffer);
		}
		return false;
	}

	private void RefreshMostPopularStickerProductIds()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		string text = default;
		text.m_stringLength = (int)num;
		_ = 0;
		object obj = text + 16;
		obj = this;
		Timer.Log(text);
	}

	private string[] GetMostPopularStickerProductIdsWithoutPrefix()
	{
		//IL_0007: Expected Obj, but got I4
		return (string[])_selectedFooterButton;
	}

	private unsafe void InsertEarner(int index, ref int numberOfObjects)
	{
		//IL_015b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got Ref
		//IL_01f3: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_01a6: Expected I, but got Obj
		//IL_01bc: Expected Obj, but got I
		//IL_00c0: Expected I, but got Obj
		//IL_010d: Expected I, but got Obj
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v43 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = CharacterManager.IsCollectionComplete((Characters.CharacterId)index);
		bool flag2 = ((UserData)index).StrictlyBetterThan((UserData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref numberOfObjects));
		object obj2 = flag & flag2;
		if (obj2 == null)
		{
			return;
		}
		bool isInstanced = UIScreenController.IsInstanced;
		((UIPowerupHandler)isInstanced).SetPowerupSlotContent((ActivePowerup)index, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref numberOfObjects));
		nint num3 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v17 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v37 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreen.forceCenterOnCurrentlySelectedCharacter = true;
		nint num5 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v24 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v31 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)CharacterScreenManager.onCharacterSelected);
	}

	public static void FacebookLoginClicked()
	{
	}

	public static void OnFacebookLoginResult(bool loggedIn)
	{
		//IL_00c6: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_003c: Expected I4, but got Obj
		bool flag = ((CoinScreen)null).isVideoAddsSupported;
		object obj = (flag ? 1 : 0) + 12;
		object obj2 = 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = (flag ? 1 : 0) + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			string text = string.ConcatArray((string[])(object)"com.kiloo.subwaysurfers.", (int)obj5);
			throw new ArrayTypeMismatchException();
		}
		object obj6 = (loggedIn ? 1 : 0) + 148;
		obj6 = flag;
	}

	private static void OnFailSlideInFinish()
	{
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01c3: Expected Obj, but got I4
		//IL_01d1: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_021c: Expected I, but got Obj
		//IL_0232: Expected Obj, but got I
		//IL_0267: Expected I, but got Obj
		//IL_027d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I4
		//IL_02fb: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I4
		//IL_02b1: Expected Obj, but got I4
		//IL_0154: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num2 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v57 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7855");
		nint num4 = (nint)typeof(CoinScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v51 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_facebookLoginRunning = true;
		nint num6 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28 (Il2CppClass<SocialManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v47 (Il2CppClass<SocialManager>)+74]");
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
		obj6 = 0;
		if (!SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported, obj7))
		{
			return;
		}
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v37 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v43 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueueMessage((string)1);
	}

	private static void FacebookStatusChanged(bool success)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I4
		//IL_00e2: Expected I, but got Obj
		if (success)
		{
			return;
		}
		nint num = (nint)typeof(CoinScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v36 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_facebookLoginRunning ? 1u : 0u) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(CoinScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v30 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_facebookLoginRunning = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		CoinScreen coinScreen = default;
		((UnityEngine.Object)coinScreen).m_CachedPtr = cachedPtr;
		coinScreen._selectedFooterButton = 0;
		object obj3 = coinScreen + 16;
		obj3 = 0;
		coinScreen.OnProductRequestDone();
	}

	private static void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_03f7: Expected I, but got Obj
		//IL_040d: Expected Obj, but got I
		//IL_01b8: Expected I, but got Obj
		//IL_0353: Expected I, but got Obj
		//IL_0369: Expected Obj, but got I
		//IL_0479: Expected I, but got Obj
		//IL_048f: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0293: Expected I, but got Obj
		//IL_03e4: Expected Obj, but got I4
		//IL_02e0: Expected I, but got Obj
		//IL_0246: Expected I, but got Obj
		//IL_0125: Expected I, but got Obj
		//IL_03c8: Expected Obj, but got I4
		//IL_00ba: Expected I, but got Obj
		if (onFinishCallback != null)
		{
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v58 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v81 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool allAssetBundlesDownloaded = UserSave.allAssetBundlesDownloaded;
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v12 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 != null;
			if (allAssetBundlesDownloaded)
			{
				if (flag)
				{
					nint num4 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v77 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text = default;
				text.m_stringLength = 13;
				_ = 1;
				((UIScreenController)flag2)._QueueMessage(text);
			}
			else
			{
				if (flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v69 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag3).QueuePopup("FBPromotionPopup");
			}
		}
		else
		{
			nint num6 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v34 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(CoinScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v51 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(_facebookLoginRunning ? 1u : 0u) == 0)
			{
				nint num8 = (nint)typeof(CoinScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v42 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num9 = (nint)typeof(CoinScreen);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v47 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				FacebookStatusChanged(success: false);
			}
		}
		nint num10 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v8 (Il2CppClass<HouseKeeper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num11 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v29 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
		nint num12 = (nint)typeof(CoinScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v14 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num13 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v23 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_shouldRefreshScreen = true;
		_facebookLoginRunning = false;
	}

	private void OnProductRequestDone()
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

	private unsafe void OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected I4, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02fc: Expected I, but got Obj
		//IL_0312: Expected Obj, but got I
		//IL_0399: Expected Obj, but got I4
		//IL_0279: Expected native int or pointer, but got Obj
		//IL_0282: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		bool flag = (byte)(obj2 + 36) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v116 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		CoinScreen coinScreen;
		if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])wasRestored, flag))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num3 = default;
			object obj6 = num3 + 16;
			obj6 = 44;
			string text = ((string)((bool*)(flag ? 1 : 0))->m_value).Substring(num3);
			if (text.m_firstChar == '\u0003')
			{
				object obj7 = text + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				object obj8 = text + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				object obj9 = text + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				obj2 = 0;
				_ = 0;
				object obj10 = default;
				obj2 = obj10;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				coinScreen = (CoinScreen)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11+8]");
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
				return;
			}
		}
		coinScreen = (CoinScreen)((bool*)(nint)validationResult)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [validationResult @ L3 (System.Boolean)+8]");
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
	}

	private void OnOnlineSettingsFinishedDownloading()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	private void OnPopupClosed(string popupName)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_coinScreenHasAppeared;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)popupName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 152;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private bool IsCoinScreenUnderPopup()
	{
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 11)
		{
			return true;
		}
		string dataPath2 = Application.dataPath;
		if ((nint)dataPath2 == 8)
		{
			return true;
		}
		string dataPath3 = Application.dataPath;
		if (dataPath3 != null)
		{
			string dataPath4 = Application.dataPath;
			return (nint)dataPath4 == 7;
		}
		return true;
	}

	private void OnPopupShown(string popupName)
	{
		//IL_00e8: Expected I4, but got Obj
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		if (!((FrontScreen)this).IsAnimating((FrontScreen.AnimatingButton)popupName) || !((EarnCoinsScreen)this).isVideoAdsSupported)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_firstPurchaseBonusBannerGo).FindKernel((string)null) != 0)
		{
			FirstPurchaseBonusCharacterHelper component = _firstPurchaseBonusBannerGo.GetComponent<FirstPurchaseBonusCharacterHelper>();
			component.OnDisable();
		}
		Update();
	}

	private bool IsPopupOnTopOfCoinScreen(string popupName)
	{
		//IL_0046: Expected Obj, but got I
		string[] mostPopularStickerProductIds = _mostPopularStickerProductIds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [popupName @ L1 (System.String)+10]");
		if (Enumerable.Contains(mostPopularStickerProductIds, (string)0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [popupName @ L1 (System.String)+2C]");
			return (nint)0 == 0;
		}
		return false;
	}

	public CoinScreen()
	{
		Update();
	}

	static CoinScreen()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CoinScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		QueueFacebookFailSlideIn(null);
	}

	private void _003COnPanelGeometryUpdated_003Eb__56_0()
	{
		((UpgradeScreen)this).Start();
	}
}
