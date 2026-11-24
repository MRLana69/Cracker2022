using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ABTest;
using Cloud;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using Kiloo.Common.Ads;
using Kiloo.Common.Backend;
using Kiloo.Common.Extensions;
using Kiloo.Common.HTTP;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.UI;
using Microsoft.Win32;
using SYBO.Subway;
using SYBO.Subway.Info;
using SYBO.Subway.Promotion;
using TopRun;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.MessageCenter;
using UI.Screens.FrontScreenInternal;
using UI.SlideIns;
using UI.VideoAdPrizes;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens;

public class FrontScreen : RunStartScreen
{
	private enum AnimatingButton
	{
		SettingsButton,
		MyTourButton,
		HoverboardButton,
		BottomMenuButtons,
		EventButton,
		QuickVideoButton,
		OfferwallButton,
		BoardBundleButton,
		FirstPurchaseBonusButton,
		PromotionButton,
		WelcomePackButton
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__54_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ChallengesScreen._003C_003Ec obj = default;
			ChallengesScreen._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CCheckForCloudSaveWelcomeSlideIn_003Eb__54_0()
		{
		}
	}

	private sealed class _003CAnimateButtonVertical_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject button;

		public float offset;

		public float delay;

		public FrontScreen _003C_003E4__this;

		public Action onComplete;

		private float _003CendY_003E5__2;

		private float _003CstartY_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0063: Expected Obj, but got I4
				//IL_00ae: Expected Obj, but got I4
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cf: Expected Obj, but got Unknown
				//IL_00eb: Expected Obj, but got I4
				//IL_0118: Expected I, but got Obj
				//IL_012e: Expected Obj, but got I
				//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f1: Expected Obj, but got Unknown
				//IL_022a: Expected Obj, but got I4
				//IL_0159: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							TransformExtensions.Reset((Transform)(object)onComplete);
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					int layer = button.layer;
					nint num = (nint)typeof(FrontScreen);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v36 (Il2CppClass<UI.Screens.FrontScreen>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(FrontScreen);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v44 (Il2CppClass<UI.Screens.FrontScreen>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj2 = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7916");
					IEnumerator routine = default;
					Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto(routine);
					obj2 = coroutine;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				button.tag = (string)1;
				_003CendY_003E5__2 = 0f;
				float num3 = _003CendY_003E5__2 + offset;
				_003CstartY_003E5__3 = num3;
				int layer2 = button.layer;
				TransformExtensions.SetLocalPosZ((Transform)layer2, _003CstartY_003E5__3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = delay;
				object obj3 = this + 12;
				object obj4 = default;
				obj3 = obj4;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CAnimateButtonVertical_003Ed__89(int _003C_003E1__state)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got I4
			object obj = this + 12;
			obj = _003C_003E1__state;
			((Container)this).hasTransientState = false;
		}

		void IDisposable.Dispose()
		{
			//IL_0061: Expected I, but got Obj
			//IL_0077: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I4
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
			text.m_stringLength = 19;
			_ = 1;
			((UIScreenController)flag)._QueueMessage(text);
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

	private sealed class _003CAnimateButtonHorizontal_003Ed__90(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject button;

		public FrontScreen _003C_003E4__this;

		public float offset;

		public float delay;

		public Action onComplete;

		private float _003CendX_003E5__2;

		private float _003CstartX_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0063: Expected Obj, but got I4
				//IL_0075: Expected Obj, but got I
				//IL_008c: Expected Obj, but got I
				//IL_00d7: Expected Obj, but got I4
				//IL_0141: Expected I, but got Obj
				//IL_0157: Expected Obj, but got I
				//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Expected Obj, but got Unknown
				//IL_0114: Expected Obj, but got I4
				//IL_021f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0224: Expected Obj, but got Unknown
				//IL_025b: Expected Obj, but got I4
				//IL_0182: Expected I, but got Obj
				FrontScreen frontScreen = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							TransformExtensions.Reset((Transform)(object)onComplete);
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					int layer = button.layer;
					nint num = (nint)typeof(FrontScreen);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v40 (Il2CppClass<UI.Screens.FrontScreen>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(FrontScreen);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v48 (Il2CppClass<UI.Screens.FrontScreen>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj2 = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7916");
					IEnumerator routine = default;
					Coroutine coroutine = frontScreen.StartCoroutine_Auto(routine);
					obj2 = coroutine;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				button.tag = (string)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.FrontScreen)+48]");
				((RewardForVideoButton)0).Init(null);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UI.Screens.FrontScreen)+68]");
				((RewardForVideoButton)0).Init(null);
				_003CendX_003E5__2 = 0f;
				float num3 = _003CendX_003E5__2 + offset;
				_003CstartX_003E5__3 = num3;
				int layer2 = button.layer;
				TransformExtensions.SetLocalPosY((Transform)layer2, _003CstartX_003E5__3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = delay;
				object obj3 = this + 12;
				object obj4 = default;
				obj3 = obj4;
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

	private sealed class _003CAnimateSlideInButton_003Ed__91(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public bool horizontal;

		public Transform t;

		public float start;

		public float end;

		private float _003CcurrentDuration_003E5__2;

		private Action<float> _003CsetPos_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Expected Obj, but got Unknown
				//IL_0375: Unknown result type (might be due to invalid IL or missing references)
				//IL_037a: Expected Obj, but got Unknown
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Expected Obj, but got Unknown
				//IL_0191: Expected I, but got Obj
				//IL_01a7: Expected Obj, but got I
				//IL_0287: Expected I, but got Obj
				//IL_029d: Expected Obj, but got I
				//IL_01d2: Expected I, but got Obj
				//IL_0150: Expected Obj, but got I
				//IL_0161: Unknown result type (might be due to invalid IL or missing references)
				//IL_0166: Expected Obj, but got Unknown
				//IL_016f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0174: Expected Obj, but got Unknown
				//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0402: Expected Obj, but got Unknown
				//IL_040b: Expected Obj, but got I4
				//IL_041f: Expected Obj, but got I4
				//IL_02c8: Expected I, but got Obj
				//IL_031d: Expected Obj, but got I
				//IL_032e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0333: Expected Obj, but got Unknown
				//IL_033c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0341: Expected Obj, but got Unknown
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
					_003CcurrentDuration_003E5__2 = 0f;
					bool flag = horizontal;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					if (flag)
					{
						nint num = 0;
						_ = 0;
						object obj = obj2 + 16;
						obj = t;
					}
					else
					{
						nint num2 = 0;
						_ = 0;
						object obj3 = obj2 + 16;
						obj3 = t;
					}
					object obj4 = this + 36;
					obj4 = obj2;
				}
				if (!(_003CcurrentDuration_003E5__2 < 0.5f))
				{
					if (_003CsetPos_003E5__3 != null)
					{
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v22 (Il2CppMethodInfo)+18]");
						object obj5 = 0;
						object obj6 = obj5;
						object obj7 = obj6 & 0x1FF;
						object obj8 = obj7 + 79894;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v151 @ S3_v13 (should have been resolved before IL gen)");
					}
					return null;
				}
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (t != null)
				{
					return null;
				}
				float unscaledTime = Time.unscaledTime;
				float num6 = _003CcurrentDuration_003E5__2 + unscaledTime;
				_003CcurrentDuration_003E5__2 = num6;
				float num7 = _003CcurrentDuration_003E5__2 * 2f;
				float num8 = num7 - 2f;
				float num9 = num7 * num8;
				float num10 = 0f - num9;
				nint num11 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S2_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num12 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S2_v17 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num13 = Mathf.LerpUnclamped(start, end, num10);
				if (_003CsetPos_003E5__3 != null)
				{
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S2_v14 (Il2CppMethodInfo)+18]");
					object obj11 = 0;
					object obj12 = obj11;
					object obj13 = obj12 & 0x1FF;
					object obj14 = obj13 + 79894;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v216 @ S3_v8 (should have been resolved before IL gen)");
				}
				object obj15 = this + 12;
				obj15 = 0;
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

	private GameObject[] _tweenButtons;

	private UIWidget[] _widgetFrames;

	private GameObject discountStickerNormal;

	private GameObject discountStickerSpecialSale;

	private UISprite sticker;

	private UISprite stickerSpecialSale;

	private UISprite stickerSpecialSaleOutline;

	private BoxCollider startButtonCollider;

	private Layout _topLeftLayout;

	private GameObject _settingsPopupButton;

	private GameObject _showEventsPopupButton;

	private GameObject _hoverboardPopupButton;

	private GameObject _boardBundleButton;

	private UISprite _boardBundleIcon;

	private UIWidget _myTourContainer;

	private GameObject _myTourButton;

	private Layout _topRightLayout;

	private GameObject _quickVideoButton;

	private GameObject _quickVideoButtonPrefab;

	private GameObject _offerWallButton;

	private GameObject _firstPurchaseBonusButtonPrefab;

	private GameObject _welcomePackButtonPrefab;

	private GameObject _promotionButton;

	private GameObject _firstPurchaseBonusButton;

	private GameObject _welcomePackButton;

	private QuickVideoButtonHelper _quickVideoButtonHelper;

	private GameObject _bottomParent;

	private UILabel shopDiscountLabel1;

	private UILabel shopDiscountLabel2;

	private UILabel shopDiscountLabelSingleLine;

	private UILabel shopDiscountLabelSpecialSale;

	private GuidelineButton _guidelineButtonShop;

	private UILabel tapToPlayLabel;

	private const string ONLINESETTINGS_OFFERWALL_POPUP_ENABLED_KEY = "kiloo_offerwall_popup_enabled";

	private const bool DEFAULT_OFFERWALL_POPUP_ENABLED = true;

	private const int MY_TOUR_WIDE_RIGHT_OFFSET = -106;

	private DateTime _frontScreenShowTimeStamp;

	private const float DEFAULT_INTERSTITIAL_SHOW_ONCACHE_TIMEFRAME = 1.5f;

	private const string INTERSTITIAL_FRONTSCREEN_SHOW_ONCACHE_TIMEFRAME = "interstitial_frontscreen_show_oncache_timeframe";

	private bool _buttonsHaveTweened;

	private Dictionary<AnimatingButton, IEnumerator> _buttonAnimationCoroutines;

	private bool _hasShownPromotionPopupThisSession;

	private static bool _firstTimeShown;

	private const float LEFT_SLIDEIN_BUTTON_START_OFFSET = -60f;

	private const float RIGHT_SLIDEIN_BUTTON_START_OFFSET = 60f;

	private const float TOP_SLIDEIN_BUTTON_START_OFFSET = 70f;

	private const float BOTTOM_SLIDEIN_BUTTON_START_OFFSET = -110f;

	private float _iphoneXTopOffset;

	private float _iphoneXBottomOffset;

	private bool _hasShownBefore;

	private bool _animationsAllowed;

	private bool _wasAnimationInterrupted;

	private readonly List<AnimatingButton> _completedButtonAnimations;

	private readonly List<AnimatingButton> _isButtonAnimatingNow;

	private bool _isApplicationResuming;

	protected override string GetFlurryName()
	{
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_boardBundleIcon).FindKernel((string)null) != 0)
		{
			object obj2 = _boardBundleIcon + 220;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v12+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
			bool flag = 0 < (nint)_myTourButton;
			return (string)flag;
		}
		return null;
	}

	public override void Init()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 68;
		object obj2 = default;
		obj = obj2;
		((UpgradeScreen)(object)this).Start();
	}

	private unsafe void InitHttp()
	{
		//IL_0854: Expected I, but got Obj
		//IL_086a: Expected Obj, but got I
		//IL_08a4: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_08f5: Expected I, but got Obj
		//IL_090b: Expected Obj, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Expected Obj, but got Unknown
		//IL_0944: Expected I4, but got Obj
		//IL_0951: Expected Obj, but got I4
		//IL_095d: Expected Obj, but got VT
		//IL_01c1: Expected I, but got Obj
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_020e: Expected I, but got Obj
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_05cb: Expected I, but got Obj
		//IL_05e1: Expected Obj, but got I
		//IL_02ef: Expected I, but got Obj
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected Obj, but got Unknown
		//IL_0b61: Expected I4, but got Obj
		//IL_0b6d: Expected Obj, but got I4
		//IL_0b87: Expected I, but got Obj
		//IL_0b9d: Expected Obj, but got I
		//IL_033c: Expected I, but got Obj
		//IL_0352: Expected Obj, but got I
		//IL_0bcc: Expected Obj, but got I4
		//IL_0bde: Expected I, but got Obj
		//IL_0bf4: Expected Obj, but got I
		//IL_060c: Expected I, but got Obj
		//IL_09db: Expected Obj, but got I4
		//IL_0c1b: Expected Obj, but got I4
		//IL_0659: Expected I, but got Obj
		//IL_03ca: Expected I, but got Obj
		//IL_03e0: Expected Obj, but got I
		//IL_037d: Expected I, but got Obj
		//IL_06a6: Expected I, but got Obj
		//IL_0a09: Expected Obj, but got I4
		//IL_07c0: Expected I, but got Obj
		//IL_07d6: Expected Obj, but got I
		//IL_0702: Expected I, but got Obj
		//IL_0718: Expected Obj, but got I
		//IL_040b: Expected I, but got Obj
		//IL_0a36: Expected I, but got Obj
		//IL_0a4c: Expected Obj, but got I
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Expected Obj, but got Unknown
		//IL_0c68: Expected Obj, but got I4
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Expected Obj, but got Unknown
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected Obj, but got Unknown
		//IL_0a83: Expected I4, but got Obj
		//IL_0a8f: Expected Obj, but got I4
		//IL_0a9d: Expected I, but got Obj
		//IL_0ab3: Expected Obj, but got I
		//IL_0801: Expected I, but got Obj
		//IL_0743: Expected I, but got Obj
		//IL_0aec: Expected Obj, but got I4
		//IL_0476: Expected I, but got Obj
		//IL_0510: Expected I, but got Obj
		//IL_0526: Expected Obj, but got I
		//IL_04c3: Expected I, but got Obj
		//IL_0b1a: Expected Obj, but got I4
		//IL_0551: Expected I, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v114 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("COOL_DEAL_SINGLE_LINE");
		shopDiscountLabelSingleLine.fontSize = (int)text;
		string text2 = Strings.GetDefault("FRONT_UI_TAP_TO_PLAY");
		tapToPlayLabel.fontSize = (int)text2;
		LateUpdate();
		discountStickerSpecialSale.tag = null;
		discountStickerNormal.tag = null;
		HandleOnLastPopupClosed();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj2 = default;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			object obj4 = default;
			object obj3 = obj4 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
		object obj5 = _tweenButtons + 12;
		object obj6 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			object obj7 = _tweenButtons + 16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			((GameObject)obj9).tag = null;
			object obj10 = obj6 + 1;
			obj6 = obj10;
		}
		nint num4 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v27 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num5 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v217 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool iOSOtherAudioPlaying = DeviceUtility.GetIOSOtherAudioPlaying();
		nint num6 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v38 (Il2CppClass<NGUITools>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num7 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v213 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj13 = this + 140;
		int num8 = NGUITools.CalculateNextDepth(_quickVideoButton, (byte)(int)_quickVideoButtonPrefab != 0);
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)num8).GetComponentInChildren<T>();
		obj13 = componentInChildren;
		UIWidget myTourContainer = _myTourContainer;
		UIRect.AnchorPoint rightAnchor = myTourContainer.rightAnchor;
		rightAnchor.absolute = -106;
		((UIRect)_myTourContainer).ParentHasChanged();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FrontScreen.HandleOnQuickVideoStarted);
		object obj14 = action + 16;
		obj14 = this;
		_quickVideoButtonHelper.onVideoStarted -= action;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v97 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_firstPurchaseBonusButtonPrefab).FindKernel((string)null) == 0)
		{
			goto IL_05ae;
		}
		nint num11 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v134 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num12 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v209 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool payloadBool = ABTestManager.GetPayloadBool("mainscreenbuttons");
		Component component;
		if ((string)payloadBool == "C")
		{
			nint num13 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v195 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num14 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v205 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool payloadBool2 = ABTestManager.GetPayloadBool("mainscreenbuttons");
			if ((string)payloadBool2 == "C2")
			{
				component = _topRightLayout;
				goto IL_0a1b;
			}
		}
		component = _topLeftLayout;
		goto IL_0a1b;
		IL_05ae:
		string go = _topRightLayout.tag;
		nint num15 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v61 (Il2CppClass<NGUITools>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num16 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v129 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj19 = this + 136;
		int num17 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)_welcomePackButtonPrefab != 0);
		obj19 = num17;
		_welcomePackButton.tag = null;
		nint num18 = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v70 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num19 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v125 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreen.IsScreenHeightOutOfProportion();
		bool isCurrentPromotionActive = ((PromotionManager)flag).IsCurrentPromotionActive;
		nint num20 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num21 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v121 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)isCurrentPromotionActive).FindKernel(null) != 0)
		{
			string go2 = _topRightLayout.tag;
			nint num22 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v105 (Il2CppClass<NGUITools>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num23 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v117 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj23 = this + 128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v76 (System.Boolean)+18]");
			int num24 = NGUITools.CalculateNextDepth((GameObject)(object)go2, ignoreChildrenWithColliders: false);
			obj23 = num24;
			UIButtonChangeScreen component2 = _promotionButton.GetComponent<UIButtonChangeScreen>();
			object obj24 = component2 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj25 = default;
			obj24 = obj25;
			_promotionButton.tag = null;
		}
		((RewardForVideoButton)(object)_topRightLayout).Init((VideoButtonPayload)null);
		CheckForCloudSaveIntroduction();
		nint num25 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v89 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num26 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S0_v95 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = IPhoneXSupport.CheckIsiPhoneXDevice();
		return;
		IL_0a1b:
		string go3 = component.tag;
		nint num27 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v147 (Il2CppClass<NGUITools>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num28 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v187 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj28 = this + 132;
		int num29 = NGUITools.CalculateNextDepth((GameObject)(object)go3, (byte)(int)_firstPurchaseBonusButtonPrefab != 0);
		obj28 = num29;
		nint num30 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v154 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num31 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v183 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool payloadBool3 = ABTestManager.GetPayloadBool("mainscreenbuttons");
		RewardForVideoButton rewardForVideoButton;
		if ((string)payloadBool3 == "C")
		{
			nint num32 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v169 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num33 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v179 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool payloadBool4 = ABTestManager.GetPayloadBool("mainscreenbuttons");
			if ((string)payloadBool4 == "C2")
			{
				rewardForVideoButton = (RewardForVideoButton)(object)_topRightLayout;
				goto IL_0b2c;
			}
		}
		rewardForVideoButton = (RewardForVideoButton)(object)_topLeftLayout;
		goto IL_0b2c;
		IL_0b2c:
		rewardForVideoButton.Init(null);
		_firstPurchaseBonusButton.tag = null;
		goto IL_05ae;
	}

	private void OnDestroy()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78F0");
		((Request)6).timeout = 2419200f;
		nint num3 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		KilooWebClient.AddTags((string[])(object)"subway_surfers");
	}

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_029b: Expected Obj, but got I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj6 = default;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj8 = default;
			object obj7 = obj8 + 16;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
		KeyValuePair<_00210, _00211> current = (KeyValuePair<_00210, _00211>)((Dictionary<TKey, TValue>.Enumerator*)_buttonAnimationCoroutines)->Current;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj10 = obj5 + 4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		object obj12 = obj11 << 2;
		object obj13 = obj5 + obj12;
		obj13 = 89;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj5 + obj14;
			if ((nint)obj15 == 89)
			{
				object obj16 = obj5 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_0348;
			}
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0348;
		IL_0348:
		((Dictionary<TKey, TValue>)(object)_buttonAnimationCoroutines).Resize();
	}

	public unsafe override void Hide()
	{
		//IL_0c0e: Expected I, but got Obj
		//IL_0c24: Expected Obj, but got I
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0c9c: Expected I, but got Obj
		//IL_0cb2: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_0d23: Expected I, but got Obj
		//IL_0d39: Expected Obj, but got I
		//IL_0213: Expected I, but got Obj
		//IL_0260: Expected I, but got Obj
		//IL_0276: Expected Obj, but got I
		//IL_0138: Expected I, but got Obj
		//IL_0457: Expected I, but got Obj
		//IL_046d: Expected Obj, but got I
		//IL_037c: Expected I, but got Obj
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_03c9: Expected I, but got Obj
		//IL_03df: Expected Obj, but got I
		//IL_02a1: Expected I, but got Obj
		//IL_0d10: Expected Obj, but got I4
		//IL_0dc6: Expected I, but got Obj
		//IL_0ddc: Expected Obj, but got I
		//IL_0498: Expected I, but got Obj
		//IL_0db3: Expected Obj, but got I4
		//IL_02ee: Expected I, but got Obj
		//IL_0304: Expected Obj, but got I
		//IL_01c6: Expected I, but got Obj
		//IL_1158: Unknown result type (might be due to invalid IL or missing references)
		//IL_115d: Expected I4, but got Unknown
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Expected Obj, but got Unknown
		//IL_04e5: Expected I, but got Obj
		//IL_04fb: Expected Obj, but got I
		//IL_040a: Expected I, but got Obj
		//IL_0d97: Expected Obj, but got I4
		//IL_05c9: Expected Obj, but got I4
		//IL_0573: Expected I, but got Obj
		//IL_0e32: Expected Obj, but got I4
		//IL_032f: Expected I, but got Obj
		//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected Obj, but got Unknown
		//IL_05bb: Expected Obj, but got I4
		//IL_0526: Expected I, but got Obj
		//IL_06f8: Expected I, but got Obj
		//IL_070e: Expected Obj, but got I
		//IL_0f1a: Expected Obj, but got I
		//IL_05dc: Expected I, but got Obj
		//IL_05f2: Expected Obj, but got I
		//IL_0f53: Expected Obj, but got I4
		//IL_0739: Expected I, but got Obj
		//IL_0e86: Expected Obj, but got I4
		//IL_0ece: Expected I, but got Obj
		//IL_0ee4: Expected Obj, but got I
		//IL_066a: Expected I, but got Obj
		//IL_0680: Expected Obj, but got I
		//IL_061d: Expected I, but got Obj
		//IL_0e9c: Expected Obj, but got VT
		//IL_0ea9: Expected I4, but got Obj
		//IL_0ebb: Expected Obj, but got I4
		//IL_0844: Expected I, but got Obj
		//IL_07b6: Expected I, but got Obj
		//IL_07cc: Expected Obj, but got I
		//IL_06ab: Expected I, but got Obj
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected Obj, but got Unknown
		//IL_07f7: Expected I, but got Obj
		//IL_0929: Expected I, but got Obj
		//IL_093f: Expected Obj, but got I
		//IL_1096: Expected I, but got Obj
		//IL_10ac: Expected Obj, but got I
		//IL_096a: Expected I, but got Obj
		//IL_10da: Expected Obj, but got VT
		//IL_10e7: Expected I4, but got Obj
		//IL_10f6: Expected VT, but got I4
		//IL_09b7: Expected I, but got Obj
		//IL_09cd: Expected Obj, but got I
		//IL_0bb5: Expected I, but got Obj
		//IL_0abe: Expected I, but got Obj
		//IL_0ad4: Expected Obj, but got I
		//IL_0ffe: Expected I, but got Obj
		//IL_1014: Expected Obj, but got I
		//IL_106e: Expected Obj, but got I4
		//IL_09f8: Expected I, but got Obj
		//IL_0aff: Expected I, but got Obj
		//IL_0a45: Expected I, but got Obj
		base.Hide();
		UnhookEvents();
		nint num = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v330 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string assetBundlesCachePath = AssetBundleManager.GetAssetBundlesCachePath();
		((AssetBundleManager)(object)assetBundlesCachePath).StopAssetbundlesDownload();
		string assetBundlesCachePath2 = AssetBundleManager.GetAssetBundlesCachePath();
		((AssetBundleManager)(object)assetBundlesCachePath2).InitializeDownloadRequests();
		nint num3 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v326 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!AgeRestriction.shouldShowBehaviouralAdsConsentPopup)
		{
			nint num5 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v298 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v320 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(AgeRestriction.shouldSendAgeEvent ? 1u : 0u) == 0)
			{
				nint num7 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v306 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v314 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				AgeRestriction.shouldSendAgeEvent = false;
				bool isInitialized = AdSystemManager.isInitialized;
				int ageThreshold = AgeRestriction.GetAgeThreshold();
				((PokiUnitySDK)isInitialized).togglePlayerAdvertisingConsent((byte)ageThreshold != 0);
			}
		}
		nint num9 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v29 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v293 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!AgeRestriction.countryCodeRestricted)
		{
			nint num11 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v265 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v287 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(AgeRestriction.shouldSendConsentEvent ? 1u : 0u) == 0)
			{
				nint num13 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v273 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num14 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v281 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				AgeRestriction.shouldSendConsentEvent = false;
				bool isInitialized2 = AdSystemManager.isInitialized;
				Dictionary<string, string> lastShowedProviders = AdsSave.lastShowedProviders;
				((PokiUnitySDK)isInitialized2).gameLoadingProgress((PokiUnitySDK.LoadingProgressData)(object)lastShowedProviders);
			}
		}
		nint num15 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v38 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num16 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v260 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (AgeRestriction.shouldShowBehaviouralAdsConsentPopup)
		{
			nint num17 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v250 (Il2CppClass<UIScreenController>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num18 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v256 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag)._ActivateNextPopup("AgeRestrictionPopup");
		}
		else
		{
			nint num19 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v228 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num20 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v245 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (AgeRestriction.countryCodeRestricted)
			{
				nint num21 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v235 (Il2CppClass<UIScreenController>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num22 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v241 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag2)._ActivateNextPopup("ConsentPopup");
			}
		}
		nint num23 = (nint)typeof(FrontScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v46 (Il2CppClass<UI.Screens.FrontScreen>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num24 = (nint)typeof(FrontScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v223 (Il2CppClass<UI.Screens.FrontScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LeaderboardScreenManager instance = LeaderboardScreenManager.Instance;
		object obj13 = default;
		int num25 = obj13 + 16;
		object obj14 = obj13 + 8;
		object obj15 = ((OnboardingSave.numberOfRunsSinceLastGuideline == 0) ? ((object)0) : ((object)1));
		object obj16 = instance & 1;
		object obj17 = obj15 & obj16;
		object obj20;
		if (obj17 != null)
		{
			nint num26 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v196 (Il2CppClass<UIScreenController>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num27 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v217 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag3)._ActivateNextPopup("WelcomePopup");
			DateTime today = CDateTime.Today;
			nint num28 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v205 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num29 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S0_v213 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj14 = today;
			((int*)num25)->m_value = (int)obj14;
			UserSave.numberOfBreadCrumbsShownOnFrontPage = num25;
			obj20 = 1;
		}
		else
		{
			nint num30 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v176 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num31 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v191 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v181 (System.Boolean)+60]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v182+8]");
			if ((nint)0 == 0)
			{
				string flurryName = ((GameOverScreen)this).GetFlurryName();
				if (flurryName != null)
				{
					OfferWallManager instance2 = OfferWallManager.instance;
					nint num32 = (nint)typeof(AdLocations);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S1_v63 (Il2CppClass<AdLocations>)+BA]");
					object obj23 = (nint)0 & (nint)0x200;
					if (obj23 != null)
					{
						nint num33 = (nint)typeof(AdLocations);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S1_v70 (Il2CppClass<AdLocations>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((AdSystemManager)(object)instance2).FinishedWatchingVideo((string)(object)AdLocations.HOME_INTERSTITIALS, (string)null);
				}
			}
			obj20 = 0;
		}
		nint num34 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v62 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num35 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S0_v171 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ABTestManager._002Ecctor();
		if (~(_hasShownBefore ? 1u : 0u) == 0)
		{
			if (~(_wasAnimationInterrupted ? 1u : 0u) == 0)
			{
				RetriggerSlideinAnimations();
			}
			AnimateSettingsButton();
		}
		else
		{
			_hasShownBefore = true;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num36 = 0;
				_ = 0;
				object obj26 = default;
				object obj25 = obj26 + 16;
				obj25 = this;
				throw new ArrayTypeMismatchException();
			}
		}
		if (OnboardingSave.numberOfRunsSinceLastGuideline == 0)
		{
			nint num37 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v127 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num38 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S0_v152 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UserSave.hasMadeOneValidPurchase)
			{
				nint num39 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S0_v135 (Il2CppClass<Flurry>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num40 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S0_v148 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num41 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S0_v140 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num42 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S0_v145 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UserSave.hasMadeOneValidPurchase = true;
			}
		}
		if (OnboardingSave.lastShownTopRunIntroPopupVersionNumber != 0 && !OnboardingSave.isTutorialCompleted)
		{
			OnboardingSave.lastShownTopRunIntroPopupVersionNumber = 0;
			OnboardingSave.isTutorialCompleted = true;
			nint num43 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ S0_v116 (Il2CppClass<UIScreenController>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num44 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S0_v122 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag4)._ActivateNextPopup("TutorialEndGameMissionsPopup");
		}
		((FrontScreen)null).CheckForCloudSaveWelcomeSlideIn();
		((FrontScreen)null).AnimateButtons();
		((FrontScreen)null).CheckForCloudSavePromotion();
		AssetBundleManager instance3 = AssetBundleManager.Instance;
		AssetBundleManager instance4 = AssetBundleManager.Instance;
		((RewardForVideoButton)(object)_topLeftLayout).Init((VideoButtonPayload)null);
		nint num45 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S0_v89 (Il2CppClass<System.DateTime>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num46 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ S0_v97 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime utcNow = DateTime.UtcNow;
		obj13 = utcNow;
		((int*)num25)->m_value = (int)obj13;
		_frontScreenShowTimeStamp = (DateTime)((int*)num25)->m_value;
	}

	private void HookEvents()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		base.LoseFocus();
		CheckForCloudSaveReminder();
		OnAnimationsComplete();
		nint num = (nint)typeof(FrontScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UI.Screens.FrontScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FrontScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v15 (Il2CppClass<UI.Screens.FrontScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_firstTimeShown = false;
	}

	private unsafe void UnhookEvents()
	{
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_0520: Expected I, but got Obj
		//IL_0536: Expected Obj, but got I
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_05a9: Expected I, but got Obj
		//IL_05bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0130: Expected I, but got Obj
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02d9: Expected I, but got Obj
		//IL_02ef: Expected Obj, but got I
		//IL_066e: Expected I, but got Obj
		//IL_0684: Expected Obj, but got I
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Expected Obj, but got Unknown
		//IL_06f6: Expected Obj, but got I4
		//IL_031a: Expected I, but got Obj
		//IL_0367: Expected I, but got Obj
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_0400: Expected Obj, but got I4
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0452: Expected I, but got Obj
		//IL_0468: Expected Obj, but got I
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected Obj, but got Unknown
		//IL_0493: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FrontScreen.AnimateEventButton);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v148 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventChangedHandler -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(FrontScreen.HandleOnLastPopupClosed);
		object obj3 = action2 + 16;
		obj3 = this;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v144 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnLastPopupClosed -= action2;
		AssetBundleManager instance = AssetBundleManager.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(FrontScreen.OnOfferWallOffersRecieved);
		object obj5 = action3 + 16;
		obj5 = this;
		((OfferWallManager)(object)instance).onOfferWallReceived -= action3;
		nint num5 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v140 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr4;
		((Delegate)action4).method = (nint)__ldftn(FrontScreen.OnOnlineSettingsFinishedDownloading);
		object obj7 = action4 + 16;
		obj7 = this;
		((OnlineSettings)(object)saveDataPath).RemoveOnFinishedDownloadingOnlineSettingsHandler(action4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<string> action5 = default;
		object obj8 = action5 + 16;
		obj8 = this;
		UIScreenController.OnPopupClosed -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<string, bool> action6 = default;
		object obj9 = action6 + 16;
		obj9 = this;
		AdSystemManager.onCachedVideo -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<string> action7 = default;
		object obj10 = action7 + 16;
		obj10 = this;
		AdSystemManager.onFailedToCacheVideo -= action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		_ = 0;
		Action<string> action8 = default;
		object obj11 = action8 + 16;
		obj11 = this;
		AdSystemManager.onFinishedWatchingVideo -= action8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		Action<string> action9 = default;
		object obj12 = action9 + 16;
		obj12 = this;
		AdSystemManager.onCachedInterstitial -= action9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Action action10 = default;
		((Delegate)action10).method_ptr = method_ptr5;
		((Delegate)action10).method = (nint)__ldftn(FrontScreen.HandleOnMenuScreenShown);
		object obj13 = action10 + 16;
		obj13 = this;
		nint num12 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v95 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num13 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v136 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnMenuScreenShown -= action10;
		nint num14 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v101 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num15 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v132 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr6 = 0;
		Action action11 = default;
		((Delegate)action11).method_ptr = method_ptr6;
		((Delegate)action11).method = (nint)__ldftn(FrontScreen.AnimateBoardBundleButton);
		object obj16 = action11 + 16;
		obj16 = this;
		((BoardBundlePopupManager)pageIndex).onBoardBundleStartedHandler -= action11;
		int pageIndex2 = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr7 = 0;
		Action action12 = default;
		((Delegate)action12).method_ptr = method_ptr7;
		((Delegate)action12).method = (nint)__ldftn(FrontScreen.AnimateBoardBundleButton);
		object obj17 = action12 + 16;
		obj17 = this;
		((BoardBundlePopupManager)pageIndex2).onBoardBundleExpiredHandler -= action12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr8 = 0;
		Action action13 = default;
		((Delegate)action13).method_ptr = method_ptr8;
		((Delegate)action13).method = (nint)__ldftn(FrontScreen.AnimatePromotionButton);
		object obj18 = action13 + 16;
		obj18 = this;
		nint num16 = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v116 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num17 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v128 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PromotionManager.onPromotionStartedHandler -= action13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr9 = 0;
		Action action14 = default;
		((Delegate)action14).method_ptr = method_ptr9;
		((Delegate)action14).method = (nint)__ldftn(FrontScreen.AnimatePromotionButton);
		object obj20 = action14 + 16;
		obj20 = this;
		PromotionManager.onPromotionExpiredHandler -= action14;
	}

	private unsafe void CheckForCloudSaveReminder()
	{
		//IL_04ec: Expected Obj, but got I
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected Obj, but got Unknown
		//IL_0510: Expected I, but got Obj
		//IL_0526: Expected Obj, but got I
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected Obj, but got Unknown
		//IL_0585: Expected I, but got Obj
		//IL_059b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00db: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_011c: Expected I, but got Obj
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02d5: Expected I, but got Obj
		//IL_02eb: Expected Obj, but got I
		//IL_063e: Expected I, but got Obj
		//IL_0654: Expected Obj, but got I
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Obj, but got Unknown
		//IL_06ba: Expected Obj, but got I4
		//IL_0316: Expected I, but got Obj
		//IL_0363: Expected I, but got Obj
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_03fc: Expected Obj, but got I4
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_044e: Expected I, but got Obj
		//IL_0464: Expected Obj, but got I
		//IL_06e5: Expected Obj, but got I
		//IL_06f0: Expected Obj, but got I
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected Obj, but got Unknown
		//IL_048f: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		SSEventsManagerController sSEventsManagerController = default;
		sSEventsManagerController._currentEventManager = (IEventManager)num;
		_ = 0;
		object obj = sSEventsManagerController + 16;
		obj = this;
		nint num2 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v148 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		sSEventsManagerController.Initialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action = default;
		object obj3 = action + 16;
		obj3 = this;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v144 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupClosed += action;
		AssetBundleManager instance = AssetBundleManager.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<int> action2 = default;
		object obj5 = action2 + 16;
		obj5 = this;
		((OfferWallManager)(object)instance).onPendingRewardsReceived += action2;
		nint num8 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v32 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num9 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v140 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		string text = default;
		text.m_stringLength = (int)num10;
		_ = 0;
		object obj7 = text + 16;
		obj7 = this;
		((OnlineSettings)(object)saveDataPath).SetCurrentChecksum(text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		UIScreenController uIScreenController = default;
		((UnityEngine.Object)uIScreenController).m_CachedPtr = cachedPtr;
		uIScreenController.popupAnchor = (GameObject)0;
		object obj8 = uIScreenController + 16;
		obj8 = this;
		uIScreenController.Awake();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj9 = action3 + 16;
		obj9 = this;
		AdSystemManager.onFailedToCacheVideo += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj10 = action4 + 16;
		obj10 = this;
		AdSystemManager.onFinishedWatchingVideo += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		_ = 0;
		Action<string> action5 = default;
		object obj11 = action5 + 16;
		obj11 = this;
		AdSystemManager.onWillShowInterstitial += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num14 = 0;
		_ = 0;
		Action<string> action6 = default;
		object obj12 = action6 + 16;
		obj12 = this;
		AdSystemManager.onFailedToCacheInterstitial += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action7 = default;
		((Delegate)action7).method_ptr = method_ptr;
		((Delegate)action7).method = (nint)__ldftn(FrontScreen.HandleOnMenuScreenShown);
		object obj13 = action7 + 16;
		obj13 = this;
		nint num15 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v95 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num16 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v136 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameDestroyed += action7;
		nint num17 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v101 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num18 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v132 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr2 = 0;
		UnityEngine.Object obj16 = default;
		obj16.m_CachedPtr = cachedPtr2;
		_ = 0;
		object obj17 = obj16 + 16;
		obj17 = this;
		BoardBundlePopupManager.LogErr((string)pageIndex, obj16);
		int pageIndex2 = ChallengesScreen.GetPageIndex();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action8 = default;
		((Delegate)action8).method_ptr = method_ptr2;
		((Delegate)action8).method = (nint)__ldftn(FrontScreen.AnimateBoardBundleButton);
		object obj18 = action8 + 16;
		obj18 = this;
		((BoardBundlePopupManager)pageIndex2).onBoardBundleExpiredHandler += action8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action9 = default;
		((Delegate)action9).method_ptr = method_ptr3;
		((Delegate)action9).method = (nint)__ldftn(FrontScreen.AnimatePromotionButton);
		object obj19 = action9 + 16;
		obj19 = this;
		nint num19 = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v116 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num20 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v128 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PromotionManager.onPromotionExpiredHandler += action9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num21 = 0;
		PromotionManager promotionManager = default;
		promotionManager._startTimerCoroutine = (IEnumerator)num21;
		promotionManager.currentPromotion = (PromotionDefinition)0;
		object obj21 = promotionManager + 16;
		obj21 = this;
		promotionManager._002Ector();
	}

	private void CheckForCloudSavePromotion()
	{
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected Obj, but got Unknown
		//IL_04b6: Expected Obj, but got I4
		//IL_04c4: Expected I, but got Obj
		//IL_04da: Expected Obj, but got I
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected Obj, but got Unknown
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected Obj, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected Obj, but got Unknown
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected Obj, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0536: Expected I, but got Obj
		//IL_054c: Expected Obj, but got I
		//IL_0571: Expected Obj, but got VT
		//IL_057a: Expected Obj, but got VT
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_01d2: Expected I, but got Obj
		//IL_01e8: Expected Obj, but got I
		//IL_05e9: Expected Obj, but got VT
		//IL_0601: Expected I, but got Obj
		//IL_0617: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I8
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected Obj, but got Unknown
		//IL_0213: Expected I, but got Obj
		//IL_0260: Expected I, but got Obj
		//IL_02ad: Expected I, but got Obj
		//IL_02c3: Expected Obj, but got I
		//IL_02ee: Expected I, but got Obj
		//IL_0344: Expected I, but got Obj
		//IL_035a: Expected Obj, but got I
		//IL_06d6: Expected Obj, but got VT
		//IL_06ee: Expected I, but got Obj
		//IL_0704: Expected Obj, but got I
		//IL_0729: Expected Obj, but got I8
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected Obj, but got Unknown
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected Obj, but got Unknown
		//IL_0385: Expected I, but got Obj
		//IL_03d2: Expected I, but got Obj
		//IL_041f: Expected I, but got Obj
		//IL_0435: Expected Obj, but got I
		//IL_07a6: Expected Obj, but got I4
		//IL_0460: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v166 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 - -64;
		object obj5 = obj2 + 56;
		object obj6 = obj2 + 48;
		object obj7 = obj2 + 40;
		object obj8 = obj2 + 32;
		object obj9 = obj2 + 16;
		object obj10 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj11 = default;
		if ((nint)obj11 == 1)
		{
			return;
		}
		nint num3 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v35 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v162 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj13 = default;
		if (obj13 == null)
		{
			return;
		}
		nint num5 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v42 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num6 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v158 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastCloudSaveReminderShownTime = UserSave.lastCloudSaveReminderShownTime;
		nint num7 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v49 (Il2CppClass<System.DateTime>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num8 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v152 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj6 = lastCloudSaveReminderShownTime;
		obj7 = DateTime.MinValue;
		obj5 = obj6;
		obj4 = obj7;
		object obj16 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		object obj17 = obj4 & 0x3FFFFFFFFFFFFFFFL;
		if (obj16 == obj17)
		{
			return;
		}
		long systemBootTime = Microsoft.Win32.KeyHandler.GetSystemBootTime();
		nint num9 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v67 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num10 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v148 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastCloudSaveReminderShownTime2 = UserSave.lastCloudSaveReminderShownTime;
		obj = lastCloudSaveReminderShownTime2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		nint num11 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v75 (Il2CppClass<System.DateTime>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num12 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v144 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj8 = systemBootTime;
		object obj20 = default;
		obj9 = obj20;
		obj5 = obj8;
		obj4 = obj9;
		object obj21 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		object obj22 = obj4 & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
		{
			return;
		}
		nint num13 = (nint)typeof(FrontScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v88 (Il2CppClass<UI.Screens.FrontScreen>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num14 = (nint)typeof(FrontScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v138 (Il2CppClass<UI.Screens.FrontScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_firstTimeShown ? 1u : 0u) == 0)
		{
			return;
		}
		long systemBootTime2 = Microsoft.Win32.KeyHandler.GetSystemBootTime();
		nint num15 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v99 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num16 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v134 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastEventShownTimestamp = UserSave.lastEventShownTimestamp;
		obj = lastEventShownTimestamp;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		nint num17 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v107 (Il2CppClass<System.DateTime>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num18 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v130 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj10 = systemBootTime2;
		object obj26 = default;
		obj2 = obj26;
		obj5 = obj10;
		obj4 = obj2;
		object obj27 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		object obj28 = obj4 & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28))
		{
			return;
		}
		nint num19 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v120 (Il2CppClass<UIScreenController>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num20 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v126 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._ActivateNextPopup("CloudSaveReminderPopup");
	}

	private void CheckForCloudSaveIntroduction()
	{
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0254: Invalid comparison between I and F4
		//IL_00ff: Invalid comparison between I and F4
		//IL_00a1: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I4
		//IL_01b8: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v50 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj2 = default;
		if ((nint)obj2 != 3)
		{
			return;
		}
		nint num3 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v46 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78EE");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v20+14]");
		object obj4;
		if (0f > 2f)
		{
			obj4 = 1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v20+14]");
			obj4 = ((!(0f < -2f)) ? ((object)0) : ((object)2));
		}
		if ((nint)obj4 != 2 || ~(_hasShownPromotionPopupThisSession ? 1u : 0u) == 0)
		{
			return;
		}
		_hasShownPromotionPopupThisSession = true;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v30 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v36 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._ActivateNextPopup("CloudSavePromotionPopup");
	}

	private void CheckForCloudSaveWelcomeSlideIn()
	{
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_03f4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_01a1: Expected I, but got Obj
		//IL_01ee: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I
		//IL_022f: Expected I, but got Obj
		//IL_028d: Expected Obj, but got VT
		//IL_02a5: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got VT
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_02e6: Expected I, but got Obj
		//IL_0333: Expected I, but got Obj
		//IL_0349: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I4
		//IL_0374: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 16;
		obj5 = 0;
		string savedKilooTag = SaveManager.GetSavedKilooTag();
		if (savedKilooTag != null)
		{
			return;
		}
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v22 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v103 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78FB");
		object obj7 = default;
		if (obj7 == null)
		{
			return;
		}
		int currentOutfitIndex = PlayerSave.currentOutfitIndex;
		if (currentOutfitIndex <= 3)
		{
			return;
		}
		nint num3 = (nint)typeof(FrontScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v32 (Il2CppClass<UI.Screens.FrontScreen>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(FrontScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v97 (Il2CppClass<UI.Screens.FrontScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_firstTimeShown ? 1u : 0u) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v41 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v93 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj10 = default;
		if (obj10 != null)
		{
			return;
		}
		nint num7 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v49 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v89 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UserSave.hasCloudSaveCelebrationBeenShown)
		{
			return;
		}
		DateTime today = CDateTime.Today;
		DateTime currentSkipForVideoIndexSetAt = PlayerSave.currentSkipForVideoIndexSetAt;
		obj5 = currentSkipForVideoIndexSetAt;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		nint num9 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v62 (Il2CppClass<System.DateTime>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num10 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v85 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj4 = today;
		object obj13 = default;
		obj2 = obj13;
		obj3 = obj4;
		obj = obj2;
		object obj14 = obj3 & 0x3FFFFFFFFFFFFFFFL;
		object obj15 = obj & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
		{
			return;
		}
		nint num11 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v75 (Il2CppClass<UIScreenController>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num12 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v81 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._ActivateNextPopup("CloudSaveIntroductionPopup");
	}

	private void AnimateButtons()
	{
		//IL_035a: Expected I, but got Obj
		//IL_0370: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0094: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I
		//IL_00d5: Expected I, but got Obj
		//IL_0122: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_0163: Expected I, but got Obj
		//IL_01b0: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_01f1: Expected I, but got Obj
		//IL_023e: Expected I, but got Obj
		//IL_0254: Expected Obj, but got I
		//IL_027f: Expected I, but got Obj
		//IL_02cc: Expected I, but got Obj
		//IL_02e2: Expected Obj, but got I
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_046e: Expected I, but got Obj
		//IL_0484: Expected Obj, but got I
		//IL_030d: Expected I, but got Obj
		nint num = (nint)typeof(FrontScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FrontScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FrontScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v92 (Il2CppClass<UI.Screens.FrontScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_firstTimeShown ? 1u : 0u) != 0)
		{
			return;
		}
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			return;
		}
		nint num3 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v18 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v88 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78FB");
		object obj3 = default;
		if (obj3 == null)
		{
			return;
		}
		nint num5 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v25 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v84 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UserSave.hasCloudSaveCelebrationBeenShown)
		{
			return;
		}
		nint num7 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v32 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v80 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj6 = default;
		if ((nint)obj6 != 1)
		{
			return;
		}
		nint num9 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v40 (Il2CppClass<UI.Screens.FrontScreen+<>c>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v74 (Il2CppClass<UI.Screens.FrontScreen+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_003C_003Ec._003C_003E9__54_0 == null)
		{
			nint num11 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v51 (Il2CppClass<UI.Screens.FrontScreen+<>c>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num12 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v68 (Il2CppClass<UI.Screens.FrontScreen+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num13 = 0;
			_ = 0;
			object obj10 = default;
			object obj9 = obj10 + 16;
			obj9 = _003C_003Ec._003C_003E9;
			nint num14 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v65 (Il2CppClass<UI.Screens.FrontScreen+<>c>)+5C]");
			object obj11 = (nint)0 + (nint)4;
			obj11 = obj10;
		}
		throw new ArrayTypeMismatchException();
	}

	private void AnimateSettingsButton()
	{
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(this != null))
		{
			AnimateHoverboardButton();
			AnimateBottomButtons();
			AnimateEventButton();
			InterruptCurrentButtonAnimations();
			AnimateQuickVideoButton();
			AnimatePromotionButton();
			AnimateWelcomePackButton();
			AnimateFirstPurchaseBonusButton();
			AnimateOfferwallButton();
			AnimateBoardBundleButton();
			AnimateMyTourButton();
		}
	}

	private void AnimateHoverboardButton()
	{
		//IL_003f: Expected Obj, but got I4
		if (!((GameOverScreen)this).ShouldEnableCharacterDayEventElements((IEventManager)null))
		{
			_settingsPopupButton.tag = (string)1;
			SkipAnimationTween(AnimatingButton.SettingsButton);
		}
	}

	private void AnimateEventButton()
	{
		//IL_02cf: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I4
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_030a: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_034c: Expected Obj, but got I4
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0385: Expected Obj, but got I4
		//IL_0226: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_01cb: Expected I, but got Obj
		//IL_03be: Expected Obj, but got I4
		//IL_0267: Expected I, but got Obj
		if (((GameOverScreen)this).ShouldEnableCharacterDayEventElements((IEventManager)2) || ~(_animationsAllowed ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag;
		if (OnboardingSave.numberOfRunsSinceLastGuideline != 0)
		{
			nint num = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardBundlePopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v70 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int pageIndex = ChallengesScreen.GetPageIndex();
			string bundleIconName = ((BoardBundlePopupManager)pageIndex).GetBundleIconName();
			if (bundleIconName != null)
			{
				flag = false;
			}
			else
			{
				nint num3 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v29 (Il2CppClass<ABTest.ABTestManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(ABTestManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v65 (Il2CppClass<ABTest.ABTestManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool payloadBool = ABTestManager.GetPayloadBool("mainscreenbuttons");
				if ((string)payloadBool != "A")
				{
					flag = true;
				}
				else
				{
					nint num5 = (nint)typeof(ABTestManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v38 (Il2CppClass<ABTest.ABTestManager>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(ABTestManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v60 (Il2CppClass<ABTest.ABTestManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool payloadBool2 = ABTestManager.GetPayloadBool("mainscreenbuttons");
					if ((string)payloadBool2 != "B")
					{
						flag = true;
					}
					else
					{
						nint num7 = (nint)typeof(ABTestManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v47 (Il2CppClass<ABTest.ABTestManager>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(ABTestManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v55 (Il2CppClass<ABTest.ABTestManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool payloadBool3 = ABTestManager.GetPayloadBool("mainscreenbuttons");
						flag = (string)payloadBool3 != "B2";
					}
				}
			}
		}
		else
		{
			flag = false;
		}
		_hoverboardPopupButton.tag = (string)flag;
		if (flag)
		{
			SkipAnimationTween(AnimatingButton.HoverboardButton);
		}
	}

	public void AnimateQuickVideoButton()
	{
		//IL_0039: Expected I, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_007a: Expected I, but got Obj
		if (~(_animationsAllowed ? 1u : 0u) != 0 || OnboardingSave.numberOfRunsSinceLastGuideline == 0)
		{
			return;
		}
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v11 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v20 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		((RewardForVideoButton)(object)_topLeftLayout).Init((VideoButtonPayload)null);
	}

	private void AnimatePromotionButton()
	{
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_00bc: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I4
		if (~(_animationsAllowed ? 1u : 0u) != 0 || OnboardingSave.numberOfRunsSinceLastGuideline == 0)
		{
			return;
		}
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v11 (System.Boolean)+D]");
		if ((nint)0 != 0)
		{
			return;
		}
		OfferWallManager instance = OfferWallManager.instance;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v4 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v20 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((AdSystemManager)(object)instance).IsCaching((string)(object)AdLocations.HOME_VIDEOS);
		AdTrackingSystemLogger.LogAttemptToShowButtonFlow(AdLocations.HOME_VIDEOS, (string)flag);
		((WaterFallReach)(object)AdLocations.HOME_VIDEOS).OnFailedToCacheVideo((string)flag);
		_quickVideoButton.tag = (string)1;
		((RewardForVideoButton)(object)_topRightLayout).Init((VideoButtonPayload)null);
		SlideInData instance2 = SlideInData.instance;
		bool videoIsPlaying = ((VideoAdPrizeManager)(object)instance2).HasVideoAdPrizeIndexChanged();
		((SaveMePopup)(object)_quickVideoButtonHelper).VideoIsPlaying = videoIsPlaying;
		if (!((GameOverScreen)this).ShouldEnableCharacterDayEventElements((IEventManager)5))
		{
			SkipAnimationTween(AnimatingButton.QuickVideoButton);
		}
	}

	private void AnimateBoardBundleButton()
	{
		//IL_019a: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I4
		//IL_00e0: Expected I, but got Obj
		//IL_0210: Expected Obj, but got I4
		//IL_0220: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
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
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_promotionButton) || OnboardingSave.numberOfRunsSinceLastGuideline == 0 || ~(_animationsAllowed ? 1u : 0u) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v14 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v35 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreen.IsScreenHeightOutOfProportion();
		UISprite uISprite = ((SettingsPopup)flag).AddDivider();
		int num6;
		if ((object)uISprite != null)
		{
			int num5 = WelcomePackManager.ParseFirstInstalledVersion();
			num6 = num5 ^ 1;
		}
		else
		{
			num6 = 0;
		}
		_promotionButton.tag = (string)num6;
		((RewardForVideoButton)(object)_topRightLayout).Init((VideoButtonPayload)1);
		if (num6 != 0 && !((GameOverScreen)this).ShouldEnableCharacterDayEventElements((IEventManager)9))
		{
			SkipAnimationTween(AnimatingButton.PromotionButton);
		}
	}

	private void AnimateFirstPurchaseBonusButton()
	{
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_01ec: Expected Obj, but got I4
		//IL_01ff: Expected I4, but got Obj
		//IL_00f0: Expected I, but got Obj
		nint num = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		string bundleIconName = ((BoardBundlePopupManager)pageIndex).GetBundleIconName();
		int num3 = ((bundleIconName != null) ? OnboardingSave.numberOfRunsSinceLastGuideline : 0);
		bool animationsAllowed = _animationsAllowed;
		int num4 = num3 & (animationsAllowed ? 1 : 0);
		_boardBundleButton.tag = (string)num4;
		((RewardForVideoButton)(object)_topLeftLayout).Init((VideoButtonPayload)null);
		if (num4 == 0 || ((GameOverScreen)this).ShouldEnableCharacterDayEventElements((IEventManager)7))
		{
			return;
		}
		nint num5 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v12 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num6 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v20 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex2 = ChallengesScreen.GetPageIndex();
		IEnumerator enumerator = ((BoardScreen)pageIndex2).DelayedRefreshEventBoardAndUI();
		_boardBundleIcon.fillCenter = (byte)(int)enumerator != 0;
		SkipAnimationTween(AnimatingButton.BoardBundleButton);
	}

	private void AnimateWelcomePackButton()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_firstPurchaseBonusButton.tag = null;
		((RewardForVideoButton)(object)_topRightLayout).Init((VideoButtonPayload)null);
	}

	private void OnItemRestored(string result)
	{
		((FriendsOnlineScreen)(object)this).ResetFriendList();
	}

	private void AnimateOfferwallButton()
	{
		//IL_00d9: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I4
		bool flag = WelcomePackManager.ParseFirstInstalledVersion() != 0 && OnboardingSave.numberOfRunsSinceLastGuideline != 0 && _animationsAllowed;
		_welcomePackButton.tag = (string)flag;
		((RewardForVideoButton)(object)_topRightLayout).Init((VideoButtonPayload)null);
		if (flag && !((GameOverScreen)this).ShouldEnableCharacterDayEventElements((IEventManager)10))
		{
			SkipAnimationTween(AnimatingButton.WelcomePackButton);
		}
	}

	private void AnimateMyTourButton()
	{
		if (~(_animationsAllowed ? 1u : 0u) == 0 && OnboardingSave.numberOfRunsSinceLastGuideline != 0)
		{
			AssetBundleManager instance = AssetBundleManager.Instance;
			if (!((OfferWallManager)(object)instance).IsOfferWallAllowed())
			{
				AssetBundleManager instance2 = AssetBundleManager.Instance;
			}
		}
	}

	private void AnimateBottomButtons()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		if (!((GameOverScreen)this).ShouldEnableCharacterDayEventElements((IEventManager)1) && ~(_animationsAllowed ? 1u : 0u) == 0)
		{
			int numberOfRunsSinceLastGuideline = OnboardingSave.numberOfRunsSinceLastGuideline;
			_myTourButton.tag = (string)numberOfRunsSinceLastGuideline;
			if (numberOfRunsSinceLastGuideline != 0)
			{
				SkipAnimationTween(AnimatingButton.MyTourButton);
			}
		}
	}

	private void StartAnimation(AnimatingButton b)
	{
	}

	private unsafe void SkipAnimationTween(AnimatingButton b)
	{
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_06b3: Expected Obj, but got I
		//IL_06c3: Expected Obj, but got I
		//IL_06d3: Expected Obj, but got I
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected Obj, but got Unknown
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected Obj, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_04cf: Expected I, but got Obj
		//IL_04e5: Expected Obj, but got I
		//IL_0728: Expected Obj, but got I4
		//IL_055d: Expected I, but got Obj
		//IL_0573: Expected Obj, but got I
		//IL_0510: Expected I, but got Obj
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_0756: Expected Obj, but got I4
		//IL_059e: Expected I, but got Obj
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		if (HasCompletedAnimation(b))
		{
			return;
		}
		bool flag = Kiloo.Common.Extensions.CollectionExtensions.AddDistinct(_isButtonAnimatingNow, b);
		IEnumerator routine;
		float endX;
		nint method_ptr4;
		Action action4 = default;
		object obj6;
		switch (b)
		{
		case AnimatingButton.SettingsButton:
		{
			_animationsAllowed = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr10 = 0;
			Action action10 = default;
			((Delegate)action10).method_ptr = method_ptr10;
			((Delegate)action10).method = (nint)__ldftn(FrontScreen._003CStartAnimation_003Eb__80_0);
			object obj12 = action10 + 16;
			obj12 = this;
			routine = ((PauseScreen)(object)this).AnimateCell((Transform)(object)_settingsPopupButton, 0f, -60f, action10);
			break;
		}
		case AnimatingButton.MyTourButton:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr7 = 0;
			Action action7 = default;
			((Delegate)action7).method_ptr = method_ptr7;
			((Delegate)action7).method = (nint)__ldftn(FrontScreen._003CStartAnimation_003Eb__80_1);
			object obj9 = action7 + 16;
			obj9 = this;
			float offset = 70f + _iphoneXTopOffset;
			routine = AnimateButtonHorizontal(_myTourButton, 0f, offset, action7);
			break;
		}
		case AnimatingButton.HoverboardButton:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr6 = 0;
			Action action6 = default;
			((Delegate)action6).method_ptr = method_ptr6;
			((Delegate)action6).method = (nint)__ldftn(FrontScreen._003CStartAnimation_003Eb__80_2);
			object obj8 = action6 + 16;
			obj8 = this;
			routine = ((PauseScreen)(object)this).AnimateCell((Transform)(object)_hoverboardPopupButton, 0f, -60f, action6);
			break;
		}
		case AnimatingButton.BottomMenuButtons:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr8 = 0;
			Action action8 = default;
			((Delegate)action8).method_ptr = method_ptr8;
			((Delegate)action8).method = (nint)__ldftn(FrontScreen._003CStartAnimation_003Eb__80_3);
			object obj10 = action8 + 16;
			obj10 = this;
			float offset2 = -110f + _iphoneXBottomOffset;
			routine = AnimateButtonHorizontal(_bottomParent, 0f, offset2, action8);
			break;
		}
		case AnimatingButton.WelcomePackButton:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr5 = 0;
			Action action5 = default;
			((Delegate)action5).method_ptr = method_ptr5;
			((Delegate)action5).method = (nint)__ldftn(FrontScreen._003CStartAnimation_003Eb__80_8);
			object obj7 = action5 + 16;
			obj7 = this;
			routine = ((PauseScreen)(object)this).AnimateCell((Transform)(object)_welcomePackButton, 0f, 60f, action5);
			break;
		}
		case AnimatingButton.QuickVideoButton:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr9 = 0;
			Action action9 = default;
			((Delegate)action9).method_ptr = method_ptr9;
			((Delegate)action9).method = (nint)__ldftn(FrontScreen._003CStartAnimation_003Eb__80_4);
			object obj11 = action9 + 16;
			obj11 = this;
			routine = ((PauseScreen)(object)this).AnimateCell((Transform)(object)_quickVideoButton, 0f, 60f, action9);
			break;
		}
		case AnimatingButton.OfferwallButton:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr3 = 0;
			Action action3 = default;
			((Delegate)action3).method_ptr = method_ptr3;
			((Delegate)action3).method = (nint)__ldftn(FrontScreen._003CStartAnimation_003Eb__80_5);
			object obj5 = action3 + 16;
			obj5 = this;
			routine = ((PauseScreen)(object)this).AnimateCell((Transform)(object)_offerWallButton, 0f, 60f, action3);
			break;
		}
		case AnimatingButton.BoardBundleButton:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action2 = default;
			((Delegate)action2).method_ptr = method_ptr2;
			((Delegate)action2).method = (nint)__ldftn(FrontScreen._003CStartAnimation_003Eb__80_6);
			object obj4 = action2 + 16;
			obj4 = this;
			routine = ((PauseScreen)(object)this).AnimateCell((Transform)(object)_boardBundleButton, 0f, -60f, action2);
			break;
		}
		case AnimatingButton.FirstPurchaseBonusButton:
		{
			nint num = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v98 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v131 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool payloadBool = ABTestManager.GetPayloadBool("mainscreenbuttons");
			if ((string)payloadBool == "C")
			{
				nint num3 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v118 (Il2CppClass<ABTest.ABTestManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(ABTestManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S0_v127 (Il2CppClass<ABTest.ABTestManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool payloadBool2 = ABTestManager.GetPayloadBool("mainscreenbuttons");
				if ((string)payloadBool2 == "C2")
				{
					endX = 60f;
					goto IL_0768;
				}
			}
			endX = -60f;
			goto IL_0768;
		}
		case AnimatingButton.PromotionButton:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(FrontScreen._003CStartAnimation_003Eb__80_9);
			object obj = action + 16;
			obj = this;
			routine = ((PauseScreen)(object)this).AnimateCell((Transform)(object)_promotionButton, 0f, 60f, action);
			break;
		}
		default:
			{
				routine = null;
				break;
			}
			IL_0768:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			method_ptr4 = 0;
			((Delegate)action4).method_ptr = method_ptr4;
			((Delegate)action4).method = (nint)__ldftn(FrontScreen._003CStartAnimation_003Eb__80_7);
			obj6 = action4 + 16;
			obj6 = this;
			routine = ((PauseScreen)(object)this).AnimateCell((Transform)(object)_firstPurchaseBonusButton, 0f, endX, action4);
			break;
		}
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S4_v4 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S4_v5+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S4_v6+48]");
		object obj15 = 0;
		object obj16 = obj15 & 0x7FF;
		object obj17 = obj16 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S5_v6 (should have been resolved before IL gen)");
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private void InterruptCurrentButtonAnimations()
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		if (!((GameOverScreen)this).ShouldEnableCharacterDayEventElements((IEventManager)3) && ~(_animationsAllowed ? 1u : 0u) == 0)
		{
			int numberOfRunsSinceLastGuideline = OnboardingSave.numberOfRunsSinceLastGuideline;
			_bottomParent.tag = (string)numberOfRunsSinceLastGuideline;
			if (numberOfRunsSinceLastGuideline != 0)
			{
				SkipAnimationTween(AnimatingButton.BottomMenuButtons);
			}
		}
	}

	private void OnAnimationsComplete()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0234: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 71)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_0272;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0272;
		IL_0272:
		startButtonCollider.isTrigger = true;
		_wasAnimationInterrupted = true;
		throw new IndexOutOfRangeException();
	}

	private bool IsAnimating(AnimatingButton b)
	{
		//IL_007d: Expected I4, but got Obj
		//IL_007d: Expected Obj, but got I4
		bool flag;
		if (b != AnimatingButton.SettingsButton)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L1 (UI.Screens.FrontScreen+AnimatingButton)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			return false;
		}
		if (~(((UIScreen)this)._isActive ? 1u : 0u) == 0)
		{
			return (byte)((string)b).get_Chars((int)screenName) != 0;
		}
		return false;
	}

	private bool HasCompletedAnimation(AnimatingButton b)
	{
		return _isButtonAnimatingNow.Contains(b);
	}

	private void CompleteAnimation(AnimatingButton b)
	{
		//IL_0161: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_01af: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I4
		//IL_024b: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I4
		//IL_02c0: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I4
		switch (b)
		{
		case AnimatingButton.SettingsButton:
		{
			int layer10 = _settingsPopupButton.layer;
			TransformExtensions.SetLocalPosY((Transform)layer10, 0f);
			break;
		}
		case AnimatingButton.MyTourButton:
		{
			int layer9 = _myTourButton.layer;
			TransformExtensions.SetLocalPosZ((Transform)layer9, 0f);
			break;
		}
		case AnimatingButton.HoverboardButton:
		{
			int layer8 = _hoverboardPopupButton.layer;
			TransformExtensions.SetLocalPosY((Transform)layer8, 0f);
			break;
		}
		case AnimatingButton.BottomMenuButtons:
		{
			int layer7 = _bottomParent.layer;
			TransformExtensions.SetLocalPosZ((Transform)layer7, 0f);
			break;
		}
		case AnimatingButton.WelcomePackButton:
		{
			int layer6 = _welcomePackButton.layer;
			TransformExtensions.SetLocalPosY((Transform)layer6, 0f);
			break;
		}
		case AnimatingButton.QuickVideoButton:
		{
			int layer5 = _quickVideoButton.layer;
			TransformExtensions.SetLocalPosY((Transform)layer5, 0f);
			break;
		}
		case AnimatingButton.OfferwallButton:
		{
			int layer4 = _offerWallButton.layer;
			TransformExtensions.SetLocalPosY((Transform)layer4, 0f);
			break;
		}
		case AnimatingButton.BoardBundleButton:
		{
			int layer3 = _boardBundleButton.layer;
			TransformExtensions.SetLocalPosY((Transform)layer3, 0f);
			break;
		}
		case AnimatingButton.FirstPurchaseBonusButton:
		{
			int layer2 = _firstPurchaseBonusButton.layer;
			TransformExtensions.SetLocalPosY((Transform)layer2, 0f);
			break;
		}
		case AnimatingButton.PromotionButton:
		{
			int layer = _promotionButton.layer;
			TransformExtensions.SetLocalPosY((Transform)layer, 0f);
			break;
		}
		}
	}

	private void ResetAnimation(AnimatingButton b)
	{
		bool flag = Kiloo.Common.Extensions.CollectionExtensions.AddDistinct(_completedButtonAnimations, b);
		bool flag2 = _isButtonAnimatingNow.Remove(b);
	}

	private void RetriggerSlideinAnimations()
	{
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		_wasAnimationInterrupted = false;
		startButtonCollider.isTrigger = true;
		((FrontScreen)null).EventsButtonClicked();
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<RewardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v21 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardManager._002Ecctor();
		_buttonsHaveTweened = true;
		string flurryName = ((GameOverScreen)this).GetFlurryName();
		if (flurryName == null)
		{
			return;
		}
		OfferWallManager instance = OfferWallManager.instance;
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v10 (Il2CppClass<AdLocations>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v17 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)AdLocations.HOME_INTERSTITIALS, (string)null);
	}

	private IEnumerator AnimateButtonVertical(GameObject button, float delay, float offset, Action onComplete)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = button;
		object obj3 = enumerator + 32;
		obj3 = onComplete;
		return enumerator;
	}

	private IEnumerator AnimateButtonHorizontal(GameObject button, float delay, float offset, Action onComplete)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 28;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = button;
		object obj3 = enumerator + 32;
		obj3 = onComplete;
		return enumerator;
	}

	private static IEnumerator AnimateSlideInButton(Transform t, float start, float end, bool horizontal)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 24;
		obj = horizontal;
		return enumerator;
	}

	private void HandleIphoneX()
	{
		throw new IndexOutOfRangeException();
	}

	private void TournamentChanged(object sender, TournamentChangedEventArgs eventArg)
	{
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I4
		//IL_0245: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v42 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasSeenFrontScreenFirstTime = UserSave.hasSeenFrontScreenFirstTime;
		object obj2 = (hasSeenFrontScreenFirstTime ? 1 : 0) + 12;
		object obj12;
		CollectCoinsCell collectCoinsCell = default;
		for (object obj3 = 0; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2); obj12 = obj3 + 1, obj3 = obj12)
		{
			object obj4 = (hasSeenFrontScreenFirstTime ? 1 : 0) + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v20+C]");
			bool flag = (nint)0 != 0;
			if (eventArg != null)
			{
				if (flag)
				{
					continue;
				}
			}
			else
			{
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v20+10]");
					if ((nint)0 > (nint)0)
					{
						goto IL_0140;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v20+C]");
				if ((nint)0 != 0)
				{
					continue;
				}
			}
			goto IL_0140;
			IL_0140:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			collectCoinsCell.cellType = CollectCoinsCellType.DUMMYFRIEND;
			object obj8 = collectCoinsCell + 16;
			obj8 = obj7;
			object obj9 = sender & 1;
			bool useDarkColour = obj9 == null;
			collectCoinsCell.useDarkColour = useDarkColour;
			((List<CollectCoinsCell>)(object)startButtonCollider).Add(collectCoinsCell);
			object obj10 = sender + 1;
			object obj11 = obj10;
		}
	}

	private static bool ShouldDisplayChangeLog()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool result = default;
		return result;
	}

	private static string FormatVersionNumber(string oldVersionNumber)
	{
		return "FrontUI";
	}

	private void OnPopupClosed(string popupName)
	{
		//IL_0014: Expected I4, but got Obj
		bool flag = _completedButtonAnimations.Remove((AnimatingButton)popupName);
	}

	private void HandleOnVideoStateChanged(string adLocationId)
	{
		if (adLocationId != "CoinsUI_quick")
		{
			AnimateWelcomePackButton();
		}
		if (adLocationId != "WelcomePopup")
		{
			AnimateSettingsButton();
		}
		if (adLocationId != "WelcomePackPopup")
		{
			AnimateOfferwallButton();
			AnimateBoardBundleButton();
		}
	}

	private void HandleOnVideoStateChanged(string adLocationId, bool wasAlreadyCached)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TopRunRewardHelper.CalculateBeatenFriendsAward();
	}

	private void HandleOnLastPopupClosed()
	{
		//IL_01b3: Expected I, but got Obj
		//IL_01c9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_01f4: Expected F4, but got I4
		//IL_022a: Expected F4, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I4
		//IL_00b0: Expected I, but got Obj
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I
		//IL_015e: Expected F4, but got I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		nint num = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v42 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			return;
		}
		GameObject gameObject = tapToPlayLabel.gameObject;
		nint num3 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v6 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v34 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.OffsetLocalPosZ((Transform)(object)gameObject, IPhoneXSupport.OFFSET_BOTTOM);
		bool isiPhoneXDevice = IPhoneXSupport.IsiPhoneXDevice;
		float num5 = 0f - (float)(isiPhoneXDevice ? 1 : 0);
		float iphoneXTopOffset = 0f - num5;
		_iphoneXTopOffset = iphoneXTopOffset;
		float iphoneXBottomOffset = -IPhoneXSupport.OFFSET_BOTTOM;
		_iphoneXBottomOffset = iphoneXBottomOffset;
		object obj3 = _widgetFrames + 12;
		object obj4 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			object obj5 = _widgetFrames + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v36+18]");
			object obj9 = 0;
			int num6 = NumberExtensions.CeilToInt(num5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v36+14]");
			object obj10 = 0;
			int num7 = NumberExtensions.CeilToInt(IPhoneXSupport.OFFSET_BOTTOM);
			object obj11 = obj4 + 1;
			obj4 = obj11;
		}
		string self = tag;
		GameObject.Internal_CreateGameObject((GameObject)(object)self, "ResetAndUpdateAnchors");
	}

	private bool CanShowInterstitial()
	{
		//IL_005c: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_00aa: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 46;
		string text = ((string)(object)this).Substring(num);
		bool flag = text.m_firstChar > '\u0001';
		bool flag2 = !flag;
		string text2 = (string)(object)this;
		if (!flag2)
		{
			object format = text + 16;
			object arg = text + 20;
			string text3 = string.Format((IFormatProvider)(object)"{0}.{1}", (string)format, arg);
			text2 = text3;
		}
		return (byte)(int)text2 != 0;
	}

	private void HandleOnCachedInterstitial(string adLocationId)
	{
		((GameOverScreen)this).ActivateEventRibbon(false, (IEventManager)null);
	}

	private void HandleOnQuickVideoStarted()
	{
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_0191: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00ea: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		if (!((string)(object)enumerator != "FrontScreen"))
		{
			return;
		}
		string flurryName = ((GameOverScreen)this).GetFlurryName();
		if (flurryName == null)
		{
			return;
		}
		OfferWallManager instance = OfferWallManager.instance;
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v9 (Il2CppClass<AdLocations>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v16 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)AdLocations.HOME_INTERSTITIALS, (string)null);
	}

	private void HandleOnMenuScreenShown()
	{
		//IL_0017: Expected Obj, but got I4
		_quickVideoButton.tag = null;
		OnPopupClosed((string)5);
	}

	private void OnOnlineSettingsFinishedDownloading()
	{
		//IL_001c: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_005d: Expected I, but got Obj
		string flurryName = ((GameOverScreen)this).GetFlurryName();
		if (flurryName == null)
		{
			return;
		}
		OfferWallManager instance = OfferWallManager.instance;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v5 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v12 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)AdLocations.HOME_INTERSTITIALS, (string)null);
	}

	private void OnOfferWallOffersRecieved()
	{
		AnimateOfferwallButton();
	}

	private void CheckForDiscountButton()
	{
		AnimateMyTourButton();
	}

	private void SetDefaultSaleStickerColors()
	{
	}

	private unsafe void _PauseApplication(bool paused)
	{
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I4
		//IL_0210: Expected I, but got Obj
		//IL_0226: Expected Obj, but got I
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected VT, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		//IL_0382: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_0255: Expected Obj, but got VT
		//IL_025f: Expected Obj, but got VT
		//IL_026c: Expected I8, but got Obj
		//IL_0267: Expected native int or pointer, but got VT
		//IL_0281: Expected Ref, but got VT
		//IL_028d: Expected Obj, but got I8
		//IL_02af: Expected I, but got Obj
		//IL_02c5: Expected Obj, but got I
		//IL_02fe: Expected I4, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_0115: Expected I, but got Obj
		//IL_016b: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_01ac: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<AdLocations>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v51 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
		DateTime dateTime = (DateTime)(obj2 + 24);
		object obj4 = obj2 + 8;
		AdLocationInfo hOME_INTERSTITIALS = AdLocations.HOME_INTERSTITIALS;
		if (!((string)paused != hOME_INTERSTITIALS.id))
		{
			return;
		}
		string flurryName = ((GameOverScreen)this).GetFlurryName();
		if (flurryName == null)
		{
			return;
		}
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v28 (Il2CppClass<System.DateTime>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v47 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime utcNow = DateTime.UtcNow;
		obj4 = utcNow;
		obj2 = _frontScreenShowTimeStamp;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
		formatProvider = (IFormatProvider)obj2;
		long num5 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num5;
		double num6 = (double)obj * 1E-07;
		nint num7 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v26 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v47 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		float startOffset = ((LayoutGroup)(object)saveDataPath).GetStartOffset((int)"interstitial_frontscreen_show_oncache_timeframe", 1.5f);
		if (!(num6 < (double)startOffset))
		{
			return;
		}
		OfferWallManager instance = OfferWallManager.instance;
		nint num9 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v34 (Il2CppClass<AdLocations>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v41 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)AdLocations.HOME_INTERSTITIALS, (string)null);
	}

	private void OnApplicationPause(bool paused)
	{
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		if (paused)
		{
			return;
		}
		_isApplicationResuming = true;
		nint num = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string assetBundlesCachePath = AssetBundleManager.GetAssetBundlesCachePath();
		((AssetBundleManager)(object)assetBundlesCachePath).StopAssetbundlesDownload();
	}

	private void OnApplicationFocus(bool focus)
	{
		OnApplicationPause(focus);
	}

	private unsafe void LateUpdate()
	{
		//IL_019a: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got VT
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected VT, but got Unknown
		//IL_0215: Expected F4, but got Obj
		//IL_0210: Expected native int or pointer, but got VT
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_023d: Expected F4, but got Obj
		//IL_0238: Expected native int or pointer, but got VT
		//IL_0252: Expected F4, but got I
		//IL_024d: Expected native int or pointer, but got VT
		//IL_0261: Expected I4, but got VT
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Expected Obj, but got VT
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_029b: Expected F4, but got Obj
		//IL_0296: Expected native int or pointer, but got VT
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_0083: Expected I4, but got VT
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got VT
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00bd: Expected F4, but got Obj
		//IL_00b8: Expected native int or pointer, but got VT
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ea: Expected F4, but got Obj
		//IL_00e5: Expected native int or pointer, but got VT
		//IL_00ff: Expected F4, but got I
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_010e: Expected I4, but got VT
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got VT
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0148: Expected F4, but got Obj
		//IL_0143: Expected native int or pointer, but got VT
		//IL_0167: Expected F4, but got Obj
		//IL_0162: Expected native int or pointer, but got VT
		//IL_017c: Expected F4, but got I
		//IL_0177: Expected native int or pointer, but got VT
		//IL_018b: Expected I4, but got VT
		nint num = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v48 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 88;
		obj2 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
		object obj4 = obj3 + 96;
		obj4 = obj2;
		Matrix4x4 matrix4x = (Matrix4x4)(obj3 + 104);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		object obj5 = obj3 + 72;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v15+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		sticker.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj6 = obj3 - -64;
		obj6 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
		object obj7 = obj3 + 92;
		obj7 = obj6;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		object obj8 = obj3 + 48;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v25+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		shopDiscountLabel1.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj9 = obj3 + 40;
		obj9 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
		object obj10 = obj3 + 68;
		obj10 = obj9;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		object obj11 = obj3 + 24;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v35+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		shopDiscountLabel2.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj12 = obj3 + 16;
		obj12 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
		object obj13 = obj3 + 44;
		obj13 = obj12;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
		Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		shopDiscountLabelSingleLine.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	private void HandlePopups()
	{
		if (~(_isApplicationResuming ? 1u : 0u) == 0)
		{
			_isApplicationResuming = false;
			AnimatePromotionButton();
		}
	}

	public void EventsButtonClicked()
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
		((UIScreenController)flag).PreloadAllSlideIn();
	}

	public void OfferWallButtonClicked()
	{
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_020e: Expected Obj, but got I4
		//IL_015a: Expected I, but got Obj
		//IL_01f2: Expected Obj, but got I4
		//IL_00e9: Expected I, but got Obj
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v35 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (!((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj2 = default;
		bool flag = (nint)obj2 == 8;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag2 = obj3 == null;
		if (flag)
		{
			if (!flag2)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v31 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag3)._ActivateNextPopup("CharacterNameEventPopup");
			return;
		}
		if (!flag2)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v22 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag4)._ActivateNextPopup("EventsPopup");
	}

	public void BoardBundleButtonClicked()
	{
		AssetBundleManager instance = AssetBundleManager.Instance;
		AnimateMyTourButton();
		AssetBundleManager instance2 = AssetBundleManager.Instance;
	}

	public void FirstPurchaseButtonClicked()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
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
		((UIScreenController)flag)._ActivateNextPopup("BoardBundlePopup");
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected I4, but got Unknown
		string dataPath = Application.dataPath;
		if ((nint)dataPath != 7)
		{
			string dataPath2 = Application.dataPath;
			if (dataPath2 != null)
			{
				bool paused = (byte)(context ^ 1) != 0;
				((FrontScreen)(object)msg).OnApplicationPause(paused);
			}
		}
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public FrontScreen()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
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
		((UIScreenController)flag)._ActivateNextPopup("FirstPurchaseBonusPopup");
	}

	private void _003CStartAnimation_003Eb__80_0()
	{
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
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
		object obj6 = this + 188;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AnimatingButton> list = default;
		list._002Ector();
		object obj8 = this + 208;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AnimatingButton> list2 = default;
		list2._002Ector();
		object obj9 = this + 212;
		obj9 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72D5");
	}

	private void _003CStartAnimation_003Eb__80_1()
	{
		ResetAnimation(AnimatingButton.SettingsButton);
		RetriggerSlideinAnimations();
	}

	private void _003CStartAnimation_003Eb__80_2()
	{
		ResetAnimation(AnimatingButton.MyTourButton);
	}

	private void _003CStartAnimation_003Eb__80_3()
	{
		ResetAnimation(AnimatingButton.HoverboardButton);
	}

	private void _003CStartAnimation_003Eb__80_4()
	{
		ResetAnimation(AnimatingButton.BottomMenuButtons);
	}

	private void _003CStartAnimation_003Eb__80_5()
	{
		ResetAnimation(AnimatingButton.QuickVideoButton);
	}

	private void _003CStartAnimation_003Eb__80_6()
	{
		ResetAnimation(AnimatingButton.OfferwallButton);
	}

	private void _003CStartAnimation_003Eb__80_7()
	{
		ResetAnimation(AnimatingButton.BoardBundleButton);
	}

	private void _003CStartAnimation_003Eb__80_8()
	{
		ResetAnimation(AnimatingButton.FirstPurchaseBonusButton);
	}

	private void _003CStartAnimation_003Eb__80_9()
	{
		ResetAnimation(AnimatingButton.WelcomePackButton);
	}
}
