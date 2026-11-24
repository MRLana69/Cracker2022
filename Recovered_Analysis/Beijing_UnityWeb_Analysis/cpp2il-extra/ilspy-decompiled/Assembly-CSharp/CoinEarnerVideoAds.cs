using System;
using System.Collections;
using System.Collections.Generic;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Info;
using Info.VideoRewardCooldowns;
using Kiloo.Common.Extensions;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.Utility;
using UI.SlideIns;
using UI.VideoAdPrizes;
using UnityEngine;

public class CoinEarnerVideoAds : MonoBehaviour
{
	private enum ButtonState
	{
		Loading,
		NoVideo,
		VideoReady
	}

	private sealed class _003CCheckCacheState_003Ed__45(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CoinEarnerVideoAds _003C_003E4__this;

		private float _003Cdelay_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Expected Obj, but got Unknown
				//IL_024d: Expected Obj, but got I4
				//IL_0071: Expected I, but got Obj
				//IL_0087: Expected Obj, but got I
				//IL_020b: Expected Obj, but got I4
				//IL_00b2: Expected I, but got Obj
				//IL_00ff: Expected I, but got Obj
				//IL_0115: Expected Obj, but got I
				//IL_01a8: Expected Obj, but got I4
				//IL_02c5: Expected Obj, but got I4
				//IL_0140: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					OfferWallManager instance = OfferWallManager.instance;
					nint num = (nint)typeof(AdLocations);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v15 (Il2CppClass<AdLocations>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(AdLocations);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v29 (Il2CppClass<AdLocations>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = ((AdSystemManager)(object)instance).IsCaching((string)(object)AdLocations.EARN_COINS_VIDEOS);
					if (_003Ci_003E5__3 == 0)
					{
						nint num3 = (nint)typeof(AdLocations);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v41 (Il2CppClass<AdLocations>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(AdLocations);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v48 (Il2CppClass<AdLocations>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((WaterFallReach)(object)AdLocations.EARN_COINS_VIDEOS).OnFailedToCacheVideo((string)flag);
					}
					if (flag)
					{
						_003C_003E4__this.SetStateGameObjectActive((GameObject)2);
						return null;
					}
					int num5 = _003Ci_003E5__3 + 1;
					_003Ci_003E5__3 = num5;
				}
				else
				{
					_003C_003E1__state = -1;
					_003Cdelay_003E5__2 = 3.3333333f;
					_003Ci_003E5__3 = 0;
				}
				if (_003Ci_003E5__3 > 2)
				{
					_003C_003E4__this.SetStateGameObjectActive((GameObject)1);
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = _003Cdelay_003E5__2;
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

	private GameObject _videoAvailableGameObject;

	private GameObject _loadingGameObject;

	private UILabel _loadingLabel;

	private GameObject _noVideosGameObject;

	private UILabel _noVideosLabel;

	private UILabel _noVideosTryAgainLabel;

	private GameObject _prizeContent;

	private UISprite _fillOverlay;

	private UISprite _backgroundFill;

	private UISprite _backgroundHighlightFill;

	private UISprite _overlayHighlightFill;

	private Collider _collider;

	private UILabel _title;

	private UILabel _description;

	private UILabel _priceLabelKeys;

	private int _prizeIconDepth;

	private UISprite _spritePrefab;

	private GameObject _tvAnimatedIcon;

	private UIWidget _tvContainer;

	private List<EarnCoinButtonPrizeIconSetup> _prizeIconSetups;

	private int _earnCurrencyProfileIndex;

	private Action _onClickDelegate;

	private ButtonState _currentButtonState;

	private List<UISprite> _prizeIcons;

	private const string BG_SPRITENAME_ACTIVE_DEFAULT = "backgroud_callout_square";

	private const string BG_SPRITENAME_OVERLAY_DEFAULT = "whitebox_div";

	private const string BG_SPRITENAME_INACTIVE = "button_generic_1";

	private bool _hasSubscribedToEvents;

	private const float CHECK_CACHE_STATE_TIMEOUT = 10f;

	private const int CHECK_CACHE_STATE_COUNT = 3;

	private IEnumerator _checkCacheState;

	public void Init(int earnCurrencyProfileIndex, string title, string desc, string iconName, int price, Action onClickDelegate, UIScrollView panel)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00e0: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = earnCurrencyProfileIndex;
		object obj4 = desc & 1;
		int num = price & 1;
		object obj5 = panel & 1;
		object obj6 = iconName & 1;
		object obj7 = obj2 + 24;
		obj7 = onClickDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+16]");
		bool flag = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		bool flag2 = default;
		object obj8 = (flag2 ? 1 : 0) + 16;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		((CharacterCustomizationProp)0).Initialize((CharacterRig)flag, flag2);
	}

	private void OnEnable()
	{
		CancelInvoke();
	}

	private void OnDisable()
	{
		UnsubscribeToEvents();
	}

	private void OnDestroy()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _currentButtonState == ButtonState.VideoReady;
		AdTrackingSystemLogger.LogAttemptToShowButtonFlow(AdLocations.EARN_COINS_VIDEOS, (string)flag);
		UIScreenController_OnApplicationResumed();
		CoroutineUtil.StopCoroutine((Coroutine)(object)_checkCacheState);
	}

	private void SubscribeToEvents()
	{
		UIScreenController_OnApplicationResumed();
		CoroutineUtil.StopCoroutine((Coroutine)(object)_checkCacheState);
	}

	private unsafe void UnsubscribeToEvents()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_005d: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_009e: Expected I, but got Obj
		if (~(_hasSubscribedToEvents ? 1u : 0u) == 0)
		{
			return;
		}
		_hasSubscribedToEvents = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CoinEarnerVideoAds.UIScreenController_OnApplicationResumed);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v42 (Il2CppClass<UIScreenController>)+74]");
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
		AdSystemManager.onFinishedWatchingVideo -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string, bool> action3 = default;
		object obj4 = action3 + 16;
		obj4 = this;
		AdSystemManager.onCachedVideo -= action3;
	}

	private void OnFinishedWatchingVideo(string adLocationId)
	{
		SDebug.LogFormat(adLocationId, null);
	}

	private void OnVideoCached(string adLocationId, bool wasAlreadyCached)
	{
		//IL_0021: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [wasAlreadyCached @ L2 (System.String)+68]");
		float num = 0f * 0.5f;
		CoinEarnerVideoAds coinEarnerVideoAds = (CoinEarnerVideoAds)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [wasAlreadyCached @ L2 (System.String)+64]");
		float num2 = 0f * 0.5f;
		coinEarnerVideoAds = (CoinEarnerVideoAds)num2;
	}

	private ButtonState RefreshButton()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		ButtonState buttonState = default;
		object obj = buttonState + 16;
		obj = this;
		return buttonState;
	}

	private void UIScreenController_OnApplicationResumed()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_008a: Expected I, but got Obj
		if (~(_hasSubscribedToEvents ? 1u : 0u) != 0)
		{
			return;
		}
		_hasSubscribedToEvents = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		AdSystemManager.onWillShowInterstitial += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj4 = action3 + 16;
		obj4 = this;
		AdSystemManager.onFailedToCacheVideo += action3;
	}

	private void OnClick()
	{
		IEnumerator enumerator = CheckCacheState();
	}

	private void SetButtonText(string title, string desc, int price, bool keys)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I4
		object obj = this + 60;
		obj = title;
		object obj2 = this - -64;
		object obj3 = desc & 1;
		obj2 = obj3;
		_priceLabelKeys = (UILabel)price;
		_collider = (Collider)keys;
		((TopRunPlayerCell)this).AnimateMedalIfNeeded();
	}

	private void SetButtonState(ButtonState state)
	{
		IEnumerator enumerator = CheckCacheState();
	}

	private IEnumerator CheckCacheState()
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0121: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I4
		OfferWallManager instance = OfferWallManager.instance;
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<AdLocations>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v16 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((AdSystemManager)(object)instance).IsCaching((string)(object)AdLocations.EARN_COINS_VIDEOS);
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v9 (Il2CppClass<AdLocations>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((WaterFallReach)(object)AdLocations.EARN_COINS_VIDEOS).OnFailedToCacheVideo((string)flag);
		GameObject gameObject = ((!flag) ? null : ((GameObject)2));
		SetStateGameObjectActive(gameObject);
		return (IEnumerator)(object)gameObject;
	}

	private void SetStateGameObjectActive(GameObject go)
	{
		//IL_0284: Expected I, but got Obj
		//IL_029a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0095: Expected I4, but got Obj
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got I4
		//IL_0137: Expected I4, but got Obj
		//IL_014a: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_0307: Expected I4, but got Obj
		//IL_0311: Expected I4, but got Obj
		//IL_018b: Expected I, but got Obj
		//IL_01d8: Expected I, but got Obj
		//IL_01ee: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I4
		//IL_0331: Expected I4, but got Obj
		//IL_0219: Expected I, but got Obj
		//IL_0267: Expected I4, but got Obj
		string text = tag;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)text != null)
		{
			return;
		}
		string text2 = tag;
		string text3 = ((GameObject)(object)text2).tag;
		if (text3 == null)
		{
			return;
		}
		_currentButtonState = (ButtonState)go;
		bool isCountdownActive;
		if ((object)go != null)
		{
			if ((nint)go != 1)
			{
				if ((nint)go == 2)
				{
					nint num3 = (nint)typeof(AdLocations);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v37 (Il2CppClass<AdLocations>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(AdLocations);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v46 (Il2CppClass<AdLocations>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					AdTrackingSystemLogger.LogAttemptToShowButtonFlow(AdLocations.EARN_COINS_VIDEOS, (string)1);
					((CountdownPopupManager)(object)this).IsCountdownActive = (byte)(int)_videoAvailableGameObject != 0;
					((CoinEarnerVideoAds)null)._002Ector();
					return;
				}
				isCountdownActive = (byte)(int)_loadingGameObject != 0;
			}
			else
			{
				nint num5 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v17 (Il2CppClass<AdLocations>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(AdLocations);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v24 (Il2CppClass<AdLocations>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				AdTrackingSystemLogger.LogWaterFallReach((string)(object)AdLocations.EARN_COINS_VIDEOS, (int)"NoFillButtonTimeout");
				isCountdownActive = (byte)(int)_noVideosGameObject != 0;
			}
		}
		else
		{
			CoroutineUtil.StopCoroutine((Coroutine)(object)_checkCacheState);
			object obj4 = this + 112;
			int rewardAmount = ((CoinsForVideoManager)(object)this).GetRewardAmount();
			obj4 = rewardAmount;
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_checkCacheState);
			isCountdownActive = (byte)(int)_loadingGameObject != 0;
		}
		((CountdownPopupManager)(object)this).IsCountdownActive = isCountdownActive;
	}

	private string GetTitleForVideoAdPrize(VideoAdPrizeType type)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)((UserData)(object)this).StrictlyBetterThan((UserData)type);
	}

	private string GetTitleStringIdForVideoAdPrize(VideoAdPrizeType type)
	{
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string descriptionForVideoAdPrize = ((CoinEarnerVideoAds)null).GetDescriptionForVideoAdPrize(type);
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v9 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Strings.GetDefault(descriptionForVideoAdPrize);
	}

	private string GetDescriptionForVideoAdPrize(VideoAdPrizeType type)
	{
		//IL_010b: Expected Obj, but got I4
		object obj = type - 1;
		if (type != VideoAdPrizeType.SuperMysteryBox)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							if ((nint)obj == 5)
							{
								return "PRIZE_POPUP_REWARD_KEY_PLURAL";
							}
							return string.Empty;
						}
						return "FACEBOOK_PROMOTION_COIN_CALLOUT";
					}
					return "PRIZE_POPUP_REWARD_KEY_PLURAL";
				}
				return "MINI_MYSTERY_BOX";
			}
			return "UPGRADES_MYSTERY_BOX";
		}
		return "WEEKLYHUNT_PRIZE_SUPERMYSTERYBOX_TITLE_SHORT";
	}

	private void SetPrizeIconState()
	{
		//IL_0307: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I4
		//IL_0276: Expected I, but got Obj
		//IL_028c: Expected Obj, but got I
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_02b7: Expected I, but got Obj
		//IL_0346: Expected Obj, but got I4
		//IL_00db: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_007f: Expected I, but got Obj
		//IL_0384: Expected Obj, but got I4
		//IL_0176: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I
		//IL_011c: Expected I, but got Obj
		//IL_03a1: Expected I, but got Obj
		//IL_03b7: Expected Obj, but got I
		//IL_03ee: Expected Obj, but got I4
		//IL_01b7: Expected I, but got Obj
		//IL_0204: Expected I, but got Obj
		object obj = _currentButtonState - 1;
		object obj4;
		if (_currentButtonState != ButtonState.NoVideo)
		{
			if ((nint)obj != 1)
			{
				return;
			}
			OfferWallManager instance = OfferWallManager.instance;
			nint num = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v11 (Il2CppClass<AdLocations>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v38 (Il2CppClass<AdLocations>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = ((AdSystemManager)(object)instance).IsCaching((string)(object)AdLocations.EARN_COINS_VIDEOS);
			((WaterFallReach)(object)AdLocations.EARN_COINS_VIDEOS).OnFailedToCacheVideo((string)flag);
			if (!flag)
			{
				IEnumerator enumerator = CheckCacheState();
				return;
			}
			nint num3 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v39 (Il2CppClass<AdLocations>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v65 (Il2CppClass<AdLocations>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AdTrackingSystemLogger.LogFillRequest(AdLocations.EARN_COINS_VIDEOS);
			SetStateGameObjectActive(null);
			obj4 = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] array = default;
			string text = string.Concat(array);
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v53 (Il2CppClass<Flurry>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v61 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num7 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v27 (Il2CppClass<Info.EarnCoinsData>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v33 (Il2CppClass<Info.EarnCoinsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((HeadstartTier)_earnCurrencyProfileIndex)._002Ector();
			TransformExtensions.Reset((Transform)(object)_onClickDelegate);
			return;
		}
		obj4 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] array2 = default;
		string text2 = string.Concat(array2);
		nint num9 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v19 (Il2CppClass<Flurry>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v25 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerator enumerator2 = CheckCacheState();
	}

	private UISprite GetPrizeIcon(int index)
	{
		//IL_0471: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00bc: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_00fd: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I4
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_019e: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got I4
		//IL_01fe: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I
		//IL_023f: Expected I, but got Obj
		//IL_0287: Expected Obj, but got I4
		//IL_029f: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got I
		//IL_02e0: Expected I, but got Obj
		//IL_032d: Expected I, but got Obj
		//IL_0343: Expected Obj, but got I
		//IL_056e: Expected Obj, but got I4
		//IL_036e: Expected I, but got Obj
		//IL_03c8: Expected I, but got Obj
		//IL_03de: Expected Obj, but got I
		//IL_05a5: Expected Obj, but got I4
		//IL_0409: Expected I, but got Obj
		object obj = index - 1;
		object obj3;
		if (index != 1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							if ((nint)obj == 5)
							{
								nint num = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v101 (Il2CppClass<Strings>)+BA]");
								object obj2 = (nint)0 & (nint)0x200;
								if (obj2 != null)
								{
									nint num2 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v109 (Il2CppClass<Strings>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string format = Strings.GetDefault("COIN_BUTTON_HELPER_NUMBER_OF_KEYS");
								obj3 = 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
								object[] args = default;
								return (UISprite)(object)string.Format(format, args);
							}
							return (UISprite)(object)string.Empty;
						}
						nint num3 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v88 (Il2CppClass<Strings>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num4 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v96 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string format2 = Strings.GetDefault("COIN_BUTTON_HELPER_NUMBER_OF_COINS");
						obj3 = 1000;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						object[] args2 = default;
						return (UISprite)(object)string.Format(format2, args2);
					}
					obj3 = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					nint num5 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v73 (Il2CppClass<Strings>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num6 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v83 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string arg = Strings.GetDefault("PRIZE_POPUP_REWARD_KEY_SINGULAR");
					string format3 = default;
					return (UISprite)(object)string.Format((IFormatProvider)(object)"{0} {1}", format3, arg);
				}
				obj3 = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				nint num7 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v54 (Il2CppClass<Strings>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v64 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string arg2 = Strings.GetDefault("MINI_MYSTERY_BOX");
				string format4 = default;
				return (UISprite)(object)string.Format((IFormatProvider)(object)"{0} {1}", format4, arg2);
			}
			obj3 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v35 (Il2CppClass<Strings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v45 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string arg3 = Strings.GetDefault("UPGRADES_MYSTERY_BOX");
			string format5 = default;
			return (UISprite)(object)string.Format((IFormatProvider)(object)"{0} {1}", format5, arg3);
		}
		obj3 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num11 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16 (Il2CppClass<Strings>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string arg4 = Strings.GetDefault("WEEKLYHUNT_PRIZE_SUPERMYSTERYBOX_TITLE_SHORT");
		string format6 = default;
		return (UISprite)(object)string.Format((IFormatProvider)(object)"{0} {1}", format6, arg4);
	}

	private void LogButtonShownToFlurry()
	{
		//IL_00a9: Expected Obj, but got I
		//IL_00ad: Expected VT, but got Obj
		//IL_0020: Expected Obj, but got VT
		//IL_004e: Expected Obj, but got VT
		SlideInData instance = SlideInData.instance;
		bool flag = ((VideoAdPrizeManager)(object)instance).HasVideoAdPrizeIndexChanged();
		List<EarnCoinButtonPrizeIconSetup> prizeIconSetups = _prizeIconSetups;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7 (System.Boolean)+8]");
		_0021_00210 val = (_0021_00210)((SlideInData)(object)prizeIconSetups).InstantiateSlideIn<T>((Transform)0);
		int num = 0;
		while (true)
		{
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (T)+C]");
			if ((nint)num2 < (nint)0)
			{
				EarnCoinButtonPrizeIconSetup earnCoinButtonPrizeIconSetup = ((List<EarnCoinButtonPrizeIconSetup>)val).get_Item(num);
				bool flag2 = ((DeviceInfo)(object)this).IsDeviceCapablePerformance((DeviceInfo.PerformanceLevel)num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				EarnCoinButtonPrizeIconSetup earnCoinButtonPrizeIconSetup2 = ((List<EarnCoinButtonPrizeIconSetup>)val).get_Item(num);
				earnCoinButtonPrizeIconSetup2.Deactivate();
				int num3 = num + 1;
				num = num3;
				continue;
			}
			break;
		}
	}

	public CoinEarnerVideoAds()
	{
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_036b: Expected Obj, but got I4
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_0382: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		object obj3 = obj2 + 12;
		obj3 = 0;
		SlideInData instance = SlideInData.instance;
		bool flag = ((VideoAdPrizeManager)(object)instance).HasVideoAdPrizeIndexChanged();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (System.Boolean)+8]");
		if ((nint)0 == 6)
		{
			AdsSave.cooldowns = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S3_v3+60]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (UI.SlideIns.SlideInData)+1C]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (UI.SlideIns.SlideInData)+1C]");
		if ((nint)0 != 0)
		{
			int currentVideoAdPrizeSeed = AdsSave.currentVideoAdPrizeSeed;
		}
		else
		{
			int currentVideoAdPrizeSeed = AdsSave.currentRandomVideoAdPrizeIndex;
		}
		Cooldowns cooldowns = AdsSave.cooldowns;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}
}
