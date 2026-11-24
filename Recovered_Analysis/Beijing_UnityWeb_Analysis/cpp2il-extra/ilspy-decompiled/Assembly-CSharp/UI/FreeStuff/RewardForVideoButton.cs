using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.Timer;
using Kiloo.Common.Utility;
using UI.Generic;
using UI.Generic.Layout;
using UI.Screens.PauseScreenInternal;
using UnityEngine;

namespace UI.FreeStuff;

public class RewardForVideoButton : MonoBehaviour
{
	private enum VideoState
	{
		Ready,
		Loading,
		NoFill
	}

	private sealed class _003CCheckCacheState_003Ed__38(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RewardForVideoButton _003C_003E4__this;

		private float _003Cdelay_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a7: Expected Obj, but got Unknown
				//IL_02c3: Expected Obj, but got I4
				//IL_0343: Expected Obj, but got I4
				RewardForVideoButton rewardForVideoButton = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					OfferWallManager instance = OfferWallManager.instance;
					VideoButtonPayload payload = rewardForVideoButton._payload;
					bool flag = ((AdSystemManager)(object)instance).IsCaching((string)(object)payload.adLocation__BackingField);
					if (_003Ci_003E5__3 == 0)
					{
						VideoButtonPayload payload2 = rewardForVideoButton._payload;
						string text = payload2.flurryName__BackingField;
						if (payload2.flurryName__BackingField != null && text.m_stringLength != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							VideoButtonPayload payload3 = rewardForVideoButton._payload;
							throw new ArrayTypeMismatchException();
						}
						VideoButtonPayload payload4 = rewardForVideoButton._payload;
						((WaterFallReach)(object)payload4.adLocation__BackingField).OnFailedToCacheVideo((string)flag);
					}
					if (flag)
					{
						_003C_003E4__this.OnVideoWatched(withreward: false);
						return null;
					}
					int num = _003Ci_003E5__3 + 1;
					_003Ci_003E5__3 = num;
				}
				else
				{
					_003C_003E1__state = -1;
					_003Cdelay_003E5__2 = 3.3333333f;
					_003Ci_003E5__3 = 0;
				}
				if (_003Ci_003E5__3 > 2)
				{
					_003C_003E4__this.OnVideoWatched(withreward: true);
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = _003Cdelay_003E5__2;
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
			//IL_000b: Expected Obj, but got I4
			Color color = ((UIWidget)_003C_003E1__state).color;
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

	private UISprite _firstFill;

	private UISprite _firstFillHighlight;

	private UISprite _secondFill;

	private UISprite _secondFillHighlight;

	private UISprite _rewardIcon;

	private UISprite _rewardIconBackground;

	private UILabel _title;

	private UILabel _description;

	private UILabel _loadingLabel;

	private UILabel _noVideosLabel;

	private UILabel _noVideosTryAgainLabel;

	private GameObject _activeState;

	private GameObject _loadingState;

	private GameObject _noFillState;

	private VideoButtonPayload _payload;

	private VideoState _state;

	private bool _subscribed;

	private int _cachedRewardAmount;

	private ButtonPressedColorChange[] _colorPressedManager;

	private IEnumerator _cacheCoroutine;

	private const float CHECK_CACHE_STATE_TIMEOUT = 10f;

	private const int CHECK_CACHE_STATE_COUNT = 3;

	private const string FLURRY_PARAMETER_VALUE_FORMAT = "{0};{1}";

	public int cachedRewardAmount
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			int num = default;
			object obj = num + 16;
			obj = this;
			return num;
		}
	}

	public void Init(VideoButtonPayload payload)
	{
		//IL_002a: Expected I4, but got Obj
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		if (payload == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = new NullReferenceException();
			string text = default;
			text.m_stringLength = (int)ex;
			object obj = text + 16;
			obj = this;
			Timer.Log(text);
		}
	}

	private void SetupBasic()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @84C8");
	}

	private void RefreshState()
	{
		//IL_0051: Expected I4, but got Obj
		//IL_085a: Expected I4, but got Obj
		//IL_0035: Expected I4, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_088a: Expected I4, but got Obj
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0110: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		VideoButtonPayload payload = _payload;
		string text = payload.iconBackgroundName__BackingField;
		bool fillCenter;
		if (payload.iconBackgroundName__BackingField == null || text.m_stringLength == 0)
		{
			fillCenter = (byte)(int)"icon_background_normal" != 0;
		}
		else
		{
			VideoButtonPayload payload2 = _payload;
			fillCenter = (byte)(int)payload2.iconBackgroundName__BackingField != 0;
		}
		_rewardIconBackground.fillCenter = fillCenter;
		VideoButtonPayload payload3 = _payload;
		_rewardIcon.fillCenter = (byte)(int)payload3.iconName__BackingField != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		VideoButtonPayload payload4 = _payload;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S2_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S2_v189 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault(payload4.title__BackingField);
		_title.fontSize = (int)text2;
		VideoButtonPayload payload5 = _payload;
		string text3 = Strings.GetDefault(payload5.description__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = default;
		object obj2 = obj3 + 240;
		obj2 = _cachedRewardAmount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	private void SetState(VideoState state)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got I
		object obj = this + 84;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AA3B");
		object obj2 = default;
		obj = obj2;
		object obj3 = this + 68;
		obj3 = state;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (UI.FreeStuff.RewardForVideoButton+VideoState)+18]");
		int num = ((Func<int>)0)();
		_cachedRewardAmount = num;
		RefreshState();
		OnClick();
		Unsubscribe();
	}

	private void OnClick()
	{
		OnVideoWatched(withreward: false);
	}

	private void OnVideoWatched(bool withreward)
	{
		//IL_0050: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		if (_state == (withreward ? VideoState.Loading : VideoState.Ready))
		{
			return;
		}
		_state = (withreward ? VideoState.Loading : VideoState.Ready);
		bool flag = !withreward;
		_activeState.tag = (string)flag;
		bool flag2 = withreward;
		_loadingState.tag = (string)flag2;
		object obj = this - -64;
		bool flag3 = (withreward ? 1 : 0) == 2;
		((GameObject)obj).tag = (string)flag3;
		string text = (string)((flag2 ? 1 : 0) ^ 1);
		_firstFill.tag = text;
		_secondFill.tag = text;
		_firstFillHighlight.tag = text;
		_secondFillHighlight.tag = text;
		object obj2 = (withreward ? 1 : 0) - 1;
		if (!withreward)
		{
			if ((nint)obj2 == 1)
			{
				this._002Ector();
			}
		}
		else
		{
			CoroutineUtil.StopCoroutine((Coroutine)(object)_cacheCoroutine);
			object obj3 = this + 88;
			string iconBackgroundName = ((VideoButtonPayload)(object)this).iconBackgroundName;
			obj3 = iconBackgroundName;
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_cacheCoroutine);
		}
	}

	private void OnEnable()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I4
		if (_state != VideoState.Ready)
		{
			if (_state != VideoState.Loading && _state == VideoState.NoFill)
			{
				OnClick();
			}
			return;
		}
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		object obj3 = (isInitialized ? 1 : 0) + 20;
		obj3 = obj2;
		bool isInitialized2 = AdSystemManager.isInitialized;
		((PokiUnitySDK)isInitialized2).checkInit();
	}

	private void OnDisable()
	{
		Unsubscribe();
	}

	private void Subscribe()
	{
		//IL_002d: Expected Obj, but got I4
		VideoButtonPayload payload = _payload;
		bool flag = _state == VideoState.Ready;
		AdTrackingSystemLogger.LogAttemptToShowButtonFlow(payload.adLocation__BackingField, (string)flag);
		CoroutineUtil.StopCoroutine((Coroutine)(object)_cacheCoroutine);
		LogButtonShownToFlurry();
	}

	private void OnCachedVideo(string adLocationId, bool wasAlreadyCached)
	{
		//IL_000f: Expected I4, but got Obj
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		((Layout)(object)_rewardIconBackground).Align((byte)(int)adLocationId != 0);
		object obj = adLocationId ^ 1;
		object obj2 = obj & wasAlreadyCached;
		if (obj2 != null)
		{
			((UIEventListener)(object)_firstFillHighlight).OnScroll(0.66f);
			UISprite firstFillHighlight = _firstFillHighlight;
			if (~(((UIBasicSprite)firstFillHighlight).mInvert ? 1u : 0u) == 0)
			{
				((UIBasicSprite)firstFillHighlight).mInvert = false;
				((UIRect)firstFillHighlight).mChanged = true;
			}
		}
	}

	private void OnFailedToCacheVideo(string adLocationId)
	{
		//IL_0214: Expected Obj, but got I4
		//IL_023a: Expected I, but got Obj
		//IL_0250: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I4
		//IL_00bf: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		object obj = 0;
		VideoButtonPayload payload = _payload;
		TransformExtensions.Reset((Transform)(object)payload.onVideoWatched__BackingField);
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<HouseKeeper>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v56 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.RefreshOnlineSettingsAndInappsIfNeeded();
		if (adLocationId != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
			dailyChallengeRewardHelper.Refresh();
			((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)16;
			VideoButtonPayload payload2 = _payload;
			dailyChallengeRewardHelper._rewardLayout = (Layout)payload2.rewardType__BackingField;
			VideoButtonPayload payload3 = _payload;
			dailyChallengeRewardHelper._superMysteryBoxReward = (GameObject)payload3.upgradeType__BackingField;
			dailyChallengeRewardHelper._checkmark = (UISprite)_cachedRewardAmount;
			VideoButtonPayload payload4 = _payload;
			obj = payload4.unlockItemSource__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
	}

	private void OnDismissedVideo(string adLocationId)
	{
		if (_state == VideoState.Loading)
		{
			OnVideoWatched(withreward: true);
		}
	}

	private unsafe void Unsubscribe()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_005d: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I
		//IL_009e: Expected I, but got Obj
		if (~(_subscribed ? 1u : 0u) == 0)
		{
			return;
		}
		_subscribed = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(RewardForVideoButton.RefreshState);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action;
	}

	private IEnumerator CheckCacheState()
	{
		//IL_0007: Expected Obj, but got I4
		return (IEnumerator)_cachedRewardAmount;
	}

	private void LogButtonShownToFlurry()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		if (~(_subscribed ? 1u : 0u) != 0)
		{
			return;
		}
		_subscribed = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action;
	}

	private void LogButtonClickedToFlurry()
	{
		//IL_0022: Expected Obj, but got I4
		VideoButtonPayload payload = _payload;
		AdTrackingSystemLogger.LogAttemptToShowButtonFlow(payload.adLocation__BackingField, (string)1);
		((VideoButtonPayload)(object)this).iconBackgroundName = "Shown";
	}

	private void LogButtonHasNoFill()
	{
		VideoButtonPayload payload = _payload;
		AdTrackingSystemLogger.LogFillRequest(payload.adLocation__BackingField);
		((VideoButtonPayload)(object)this).iconBackgroundName = "Clicked";
	}

	private void LogToFlurryWithParameter(string parameter)
	{
		OnClick();
	}

	public RewardForVideoButton()
	{
		//IL_0022: Expected I4, but got Obj
		VideoButtonPayload payload = _payload;
		AdTrackingSystemLogger.LogWaterFallReach((string)(object)payload.adLocation__BackingField, (int)"NoFillButtonTimeout");
		((VideoButtonPayload)(object)this).iconBackgroundName = "NoFill";
	}
}
