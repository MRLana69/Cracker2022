using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using UI.SlideIns;
using UnityEngine;

public class AdSystemTesterCell : MonoBehaviour
{
	private UILabel _statusLabel;

	private GameObject _successIcon;

	private AdLocationInfo _adLocation;

	private const string MAIN_TEXT_COLOR = "[004A80FF]";

	private const string SECONDARY_TEXT_COLOR = "[0374A5FF]";

	public void Init(AdLocationInfo adLocation)
	{
		((ResumeButtonHelper)this)._002Ector();
		if (adLocation == null)
		{
			Friend bestSurpassedFriend = ((BragCelebrationHandler)this)._bestSurpassedFriend;
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)bestSurpassedFriend);
		}
	}

	public void Cache()
	{
		CancelInvoke();
	}

	public void Show()
	{
		OfferWallManager instance = OfferWallManager.instance;
		((AdSystemManager)(object)instance).SkipVideoAd();
	}

	private void OnEnable()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		AdLocationInfo adLocation = _adLocation;
		bool flag = adLocation.adType == AdType.Video;
		OfferWallManager instance = OfferWallManager.instance;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			string text = default;
			text.m_stringLength = (int)num;
			_ = 0;
			object obj = text + 16;
			obj = this;
			((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)_adLocation, text);
		}
		else
		{
			((AdSystemManager)(object)instance).FinishedWatchingVideo((string)(object)_adLocation, (string)null);
		}
	}

	private void OnDisable()
	{
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string, bool> action = default;
		object obj = action + 16;
		obj = this;
		AdSystemManager.onCachedVideo -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj2 = action2 + 16;
		obj2 = this;
		AdSystemManager.onCachedInterstitial -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj3 = action3 + 16;
		obj3 = this;
		AdSystemManager.onFailedToCacheVideo -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj4 = action4 + 16;
		obj4 = this;
		AdSystemManager.onFailedToCacheInterstitial -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action5 = default;
		object obj5 = action5 + 16;
		obj5 = this;
		AdSystemManager.onShowedVideo -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<string> action6 = default;
		object obj6 = action6 + 16;
		obj6 = this;
		AdSystemManager.onShowedInterstitial -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<string> action7 = default;
		object obj7 = action7 + 16;
		obj7 = this;
		AdSystemManager.onFailedToShowVideo -= action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<string> action8 = default;
		object obj8 = action8 + 16;
		obj8 = this;
		AdSystemManager.onFailedToShowInterstitial -= action8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<string> action9 = default;
		object obj9 = action9 + 16;
		obj9 = this;
		AdSystemManager.onDismissedVideo -= action9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		_ = 0;
		Action<string> action10 = default;
		object obj10 = action10 + 16;
		obj10 = this;
		AdSystemManager.onDismissedInterstitial -= action10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		Action<string> action11 = default;
		object obj11 = action11 + 16;
		obj11 = this;
		AdSystemManager.onPriorityListWrapped -= action11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		_ = 0;
		Action<string> action12 = default;
		object obj12 = action12 + 16;
		obj12 = this;
		AdSystemManager.onChangedProvider -= action12;
		((BragCelebrationHandler)this).SetStateGameObjectActive((GameObject)(object)_adLocation);
	}

	private void OnCacheStateChanged(string location)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = location;
		((BragCelebrationHandler)this).SetStateGameObjectActive((GameObject)(object)_adLocation);
	}

	private void OnCacheStateChanged(string location, bool wasAlreadyCached)
	{
		//IL_0111: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)location).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)wasAlreadyCached).FindKernel(null) != 0)
			{
				((UIColorPicker)(object)location).OnPress(wasAlreadyCached);
				return;
			}
		}
		SDebug.LogFormat("ResolutionSetup: Failed to set the reference to the new atlas, one of the atlases is null!", null);
	}

	private void UpdateStatusLabel(AdLocationInfo adLocation)
	{
		((BragCelebrationHandler)this).OnLargePictureDownloaded((Friend)(object)adLocation, (Texture2D)null);
	}

	private unsafe string GetProviderIDForLocation(string adLocationId)
	{
		//IL_0016: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected I4, but got Unknown
		//IL_005d: Expected I4, but got Obj
		//IL_0074: Expected Obj, but got I4
		//IL_00a2: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AdSystemTesterCell)+18]");
		int width = ((RenderTextureDescriptor*)null)->width;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AdSystemTesterCell)+18]");
		bool autoGenerateMips = ((RenderTexture)0).autoGenerateMips;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Logger logger = default;
		LogType logType = default;
		UnityEngine.Object context = default;
		logger.LogFormat(logType, context, (string)width, (object[])autoGenerateMips);
		object obj = default;
		int num = obj + 4;
		((int*)num)->m_value = (int)logger;
		AdLocationInfo adLocation = _adLocation;
		obj = adLocation.adType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "RenderTexture" + text2;
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)logger, (byte)(int)text != 0);
		if (adLocationId != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AdSystemTesterCell)+18]");
			((ResizeWidgetOnLoginFB_TopRun)null).SetEmptyWidgetSize(num, 0);
		}
		return (string)(object)logger;
	}

	private void GiveDebugReward()
	{
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		AdSystemManager.onFailedToCacheVideo += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj2 = action2 + 16;
		obj2 = this;
		AdSystemManager.onFailedToCacheInterstitial += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj3 = action3 + 16;
		obj3 = this;
		AdSystemManager.onFinishedWatchingVideo += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj4 = action4 + 16;
		obj4 = this;
		AdSystemManager.onShowedInterstitial += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action5 = default;
		object obj5 = action5 + 16;
		obj5 = this;
		AdSystemManager.onFailedToShowVideo += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<string> action6 = default;
		object obj6 = action6 + 16;
		obj6 = this;
		AdSystemManager.onFailedToShowInterstitial += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<string> action7 = default;
		object obj7 = action7 + 16;
		obj7 = this;
		AdSystemManager.onDismissedVideo += action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<string> action8 = default;
		object obj8 = action8 + 16;
		obj8 = this;
		AdSystemManager.onDismissedInterstitial += action8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<string, bool> action9 = default;
		object obj9 = action9 + 16;
		obj9 = this;
		AdSystemManager.onCachedVideo += action9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		_ = 0;
		Action<string> action10 = default;
		object obj10 = action10 + 16;
		obj10 = this;
		AdSystemManager.onPriorityListWrapped += action10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		Action<string> action11 = default;
		object obj11 = action11 + 16;
		obj11 = this;
		AdSystemManager.onChangedProvider += action11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		AdSystemManager adSystemManager = default;
		adSystemManager._isInitialized = (byte)num12 != 0;
		adSystemManager._lastShowedProviderPerLocation = (Dictionary<string, string>)0;
		object obj12 = adSystemManager + 16;
		obj12 = this;
		adSystemManager.Initialize();
	}

	public AdSystemTesterCell()
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
		((UIScreenController)flag).QueueSlideIn((SlideIn)(object)"<Empty Debug Reward>");
	}
}
