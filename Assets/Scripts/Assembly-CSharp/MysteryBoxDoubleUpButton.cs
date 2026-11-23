using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MysteryBoxDoubleUpButton : MonoBehaviour
{
	private sealed class _003CAnimateAlpha_003Ed__21(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWidget widget;

		public float from;

		public float duration;

		public float to;

		private float _003Cfactor2_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected Obj, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Expected Obj, but got Unknown
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003Cfactor2_003E5__2 < 1f)
					{
						goto IL_00b0;
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			UIWidget uIWidget = widget;
			object obj = uIWidget - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S2_v15+BC] (should have been resolved before IL gen)");
			_003Cfactor2_003E5__2 = 0f;
			goto IL_00b0;
			IL_00b0:
			float deltaTime = Time.deltaTime;
			float num = deltaTime / duration;
			float num2 = _003Cfactor2_003E5__2 + num;
			float num3 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num4 = 0f;
			if (!flag)
			{
				num4 = num3;
			}
			_003Cfactor2_003E5__2 = num4;
			UIWidget uIWidget2 = widget;
			float num5 = to - from;
			float num6 = Math.Max(num4, 0f);
			float num7 = num5 * num6;
			float num8 = from + num7;
			object obj2 = uIWidget2 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S2_v11+BC] (should have been resolved before IL gen)");
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private GameObject _doubleButton;

	private const string ONLINESETTINGS_MYSTERY_BOX_DOUBLE_REWARD_CHANCE_KEY = "mystery_box_double_reward_chance";

	private const int DEFAULT_MYSTERY_BOX_DOUBLE_REWARD_CHANCE = 100;

	private const string ONLINESETTINGS_MYSTERY_BOX_DOUBLE_REWARD_ALLOW_KEYS_KEY = "mystery_box_double_reward_allow_keys";

	private const bool DEFAULT_MYSTERY_BOX_DOUBLE_REWARD_ALLOW_KEYS = false;

	private CelebrationReward _rewardToDouble;

	private bool _wasRewardDoubled;

	private bool _isButtonEnabled;

	private Dictionary<CelebrationRewardType, Action> _doubleRewardCallbacks;

	private Button Double_OnRelease;

	private int chance
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return instance.GetValue("mystery_box_double_reward_chance", 100);
		}
	}

	private bool ChanceRoll()
	{
		int num = ((MysteryBoxDoubleUpButton)null).chance;
		int num2 = UnityEngine.Random.Range(0, 100);
		return num > num2;
	}

	private bool IsVideoAvailable()
	{
		VideoAdsManager instance = VideoAdsManager.instance;
		return instance.IsAnyVideoAvailable();
	}

	private bool IsDoublable(CelebrationReward reward)
	{
		//IL_014b: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		object obj = reward.rewardType - 1;
		bool flag = reward.rewardType == CelebrationRewardType.coins;
		bool result = true;
		if (!flag)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2 && (nint)obj == 3)
				{
					OnlineSettings instance = OnlineSettings.instance;
					return instance.GetValue("mystery_box_double_reward_allow_keys", defaultValue: false);
				}
				result = false;
			}
			else
			{
				object obj2 = reward.powerupType - 1;
				bool flag2 = reward.powerupType == PowerupType.hoverboard;
				result = true;
				if (!flag2)
				{
					if ((nint)obj2 != 1)
					{
						bool flag3 = (nint)obj2 == 2;
						result = true;
						if (flag3)
						{
							goto IL_0176;
						}
					}
					return reward.powerupType == PowerupType.scorebooster;
				}
			}
		}
		goto IL_0176;
		IL_0176:
		return result;
	}

	private bool IsValidOrigin(CelebrationReward reward)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		object obj = reward.CelebrationRewardOrigin - 1;
		if ((nint)obj >= 2)
		{
			object obj2 = reward.CelebrationRewardOrigin - 4;
			if ((nint)obj2 >= 2)
			{
				return reward.CelebrationRewardOrigin == CelebrationRewardOrigin.CharacterEventSuperMysteryBox;
			}
		}
		return true;
	}

	public bool TryEnable(CelebrationReward rewardToDouble, Dictionary<CelebrationRewardType, Action> doubleRewardCallbacks)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_030e: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got Unknown
		//IL_0179: Expected I, but got Obj
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_ = 0;
		_wasRewardDoubled = false;
		bool flag = IsValidOrigin(rewardToDouble);
		bool flag2 = IsDoublable(rewardToDouble);
		object obj3 = flag & flag2;
		bool flag3 = IsVideoAvailable();
		object obj4 = obj3 & flag3;
		bool flag4 = ChanceRoll();
		bool flag5 = (byte)((obj4 & flag4) ? 1 : 0) != 0;
		_isButtonEnabled = flag5;
		_doubleButton.SetActive(flag5);
		if (flag5)
		{
			_rewardToDouble = rewardToDouble;
			_doubleRewardCallbacks = doubleRewardCallbacks;
			UIWidget component = _doubleButton.GetComponent<UIWidget>();
			IEnumerator routine = AnimateAlpha(component, 0.2f, 0f, 1f);
			Coroutine coroutine = StartCoroutine(routine);
		}
		if (obj3 != null)
		{
			object obj5 = "Chance";
			if (!flag4)
			{
				obj5 = "No Chance";
			}
			object obj6 = "Fill";
			if (!flag3)
			{
				obj6 = "No Fill";
			}
			string text = (string)obj5 + " - " + (string)obj6;
			if (!flag3)
			{
				VideoAdsManager instance = VideoAdsManager.instance;
				_ = instance.currentVideoState__BackingField;
				VideoAdsManager instance2 = VideoAdsManager.instance;
				VideoAdProvider currentProvider = instance2.currentProvider;
				string empty = default;
				if (instance2.currentProvider == null)
				{
					empty = string.Empty;
				}
				else
				{
					nint num = (nint)currentProvider;
					object obj7 = currentProvider + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v196 @ S1_v36 (Il2CppClass<VideoAdProvider>)+F4] (should have been resolved before IL gen)");
				}
				_ = -1;
				obj = (Enum)(object)typeof(VideoAdsManager.VideoState);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
				_ = 0;
				string text2 = obj.ToString();
				string text3 = empty + text2;
				string locale = DeviceUtility.GetLocale();
				string contryCodeFromLocale = Utils.GetContryCodeFromLocale(locale);
				string text4 = text3 + ";" + contryCodeFromLocale;
				goto IL_01d6;
			}
		}
		else if (!flag3)
		{
			goto IL_01d6;
		}
		goto IL_02cf;
		IL_01d6:
		VideoAdsManager instance3 = VideoAdsManager.instance;
		VideoAdsManager instance4 = VideoAdsManager.instance;
		if (instance4.state__BackingField != VideoAdsManager.State.Uninitialized)
		{
			VideoAdsManager instance5 = VideoAdsManager.instance;
			instance5.ResumeProvider();
			if (instance3.currentVideoState__BackingField == VideoAdsManager.VideoState.Offline || (instance3.currentVideoState__BackingField != VideoAdsManager.VideoState.Downloading && instance3.currentVideoState__BackingField != VideoAdsManager.VideoState.Ready && instance3.currentVideoState__BackingField == VideoAdsManager.VideoState.NoVideos))
			{
				VideoAdsManager instance6 = VideoAdsManager.instance;
				instance6.TryCachingVideosAgain();
			}
		}
		goto IL_02cf;
		IL_02cf:
		return flag5;
	}

	public void DisableButton()
	{
		if (~(_isButtonEnabled ? 1u : 0u) == 0 && _rewardToDouble != null && !_wasRewardDoubled)
		{
			FlurryLogDoubleUpResultAs(doubledUp: false);
		}
		_wasRewardDoubled = false;
		_doubleButton.SetActive(value: false);
	}

	public unsafe void OnRelease()
	{
		_wasRewardDoubled = true;
		DisableButton();
		VideoAdsManager instance = VideoAdsManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(MysteryBoxDoubleUpButton.OnDoubleReward));
		bool flag = instance.PlayVideoIfAvailable(action);
		UIScreenController instance2 = UIScreenController.Instance;
		if (!flag)
		{
			string message = Strings.Get(StringID.SLIDEIN_VIDEO_PLAY_ERROR);
			instance2.QueueErrorMessageSlidein(message);
		}
		else
		{
			instance2.ShowVideoAdsOverlay();
		}
	}

	private unsafe void OnDoubleReward()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Ref, but got Unknown
		//IL_00c3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		UIScreenController instance = UIScreenController.Instance;
		instance.HideVideoAdsOverlay();
		object obj3 = this + 16;
		if (_rewardToDouble != null && IsDoublable(_rewardToDouble))
		{
			CelebrationReward rewardToDouble = _rewardToDouble;
			if (_doubleRewardCallbacks.TryGetValue(rewardToDouble.rewardType, out *(Action*)(obj + 12)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S0_v31+C] (should have been resolved before IL gen)");
				}
			}
			FlurryLogDoubleUpResultAs(doubledUp: true);
		}
		obj3 = 0;
	}

	private unsafe void OnEnable()
	{
		DisableButton();
		Button double_OnRelease = Double_OnRelease;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(MysteryBoxDoubleUpButton._003COnEnable_003Eb__20_0));
		double_OnRelease.m_OnClick.AddListener(unityAction);
		_rewardToDouble = null;
	}

	private IEnumerator AnimateAlpha(UIWidget widget, float duration, float from, float to)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public unsafe void FlurryLogDoubleUpResultAs(bool doubledUp)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I4, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		CelebrationReward rewardToDouble = _rewardToDouble;
		if (rewardToDouble.rewardType == CelebrationRewardType.powerup)
		{
			_ = -1;
			obj = (Enum)(object)typeof(PowerupType);
			_ = rewardToDouble.powerupType;
			string text = obj.ToString();
		}
		else
		{
			_ = -1;
			obj = (Enum)(object)typeof(CelebrationRewardType);
			_ = rewardToDouble.rewardType;
			string text = obj.ToString();
		}
		CelebrationReward rewardToDouble2 = _rewardToDouble;
		int num = _rewardToDouble + 16;
		if ((nint)((MysteryBoxDoubleUpButton)(object)rewardToDouble2)._doubleButton == 1)
		{
			string text2 = ((MysteryBoxDoubleUpButton)(object)_rewardToDouble).GroupCoinsForFlurryLogging(((int*)num)->m_value);
		}
		else
		{
			string text2 = ((int*)num)->ToString();
		}
		object obj3 = "Doubled";
		if (!doubledUp)
		{
			obj3 = "Not Doubled";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public unsafe string GroupCoinsForFlurryLogging(int originalCoinAmount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected I4, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected I4, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (originalCoinAmount <= 499)
		{
			int num = originalCoinAmount / 10;
			object obj3 = num * 10;
			object obj4 = obj3 + 9;
			int num2 = obj + 8;
			string text = ((int*)num2)->ToString();
			int num3 = obj + 4;
			string text2 = ((int*)num3)->ToString();
			return text + "-" + text2;
		}
		int num4 = obj + 12;
		return ((int*)num4)->ToString();
	}

	private void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public MysteryBoxDoubleUpButton()
	{
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<CelebrationRewardType, System.Action>>>)+4] (should have been resolved before IL gen)");
		Dictionary<CelebrationRewardType, Action> doubleRewardCallbacks = default;
		_doubleRewardCallbacks = doubleRewardCallbacks;
		base._002Ector();
	}

	private void _003COnEnable_003Eb__20_0()
	{
		OnRelease();
	}
}
