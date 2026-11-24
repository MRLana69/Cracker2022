using System;
using System.Collections.Generic;
using ABTest;
using Cpp2ILInjected;
using Kiloo.Common.Ads;

namespace Kiloo.Common.JsonUtil;

public class WaterFallReach
{
	private static readonly string[] SCREENS_THAT_CAN_CACHE_A_VIDEO_AD;

	private bool _hasCachedSuccesFullyOnCurrentScreen;

	private bool _isFirstScreen;

	private int _currentScreenCacheFailCount;

	private string _previousScreenName;

	public WaterFallReach()
	{
		//IL_0026: Expected Obj, but got I4
		OfferWallManager instance = OfferWallManager.instance;
		bool flag = ((AdSystemManager)(object)instance).IsCaching((string)(object)this);
		OnFailedToCacheVideo((string)flag);
	}

	private void OnFailedToCacheVideo(string adLocationId)
	{
		//IL_0052: Expected I4, but got Obj
		//IL_0052: Expected I4, but got Obj
		//IL_0052: Expected Obj, but got I4
		string materialPath = ((adLocationId == null) ? "NoAdAvailable" : "AdAvailable");
		((CharacterMaterial.CharacterMaterialPathInfo)1)._002Ector((CharacterMaterial.CharacterMaterialShaderType)this, (DeviceInfo.PerformanceLevel)"Fill Request", materialPath);
	}

	private void OnCachedVideo(string adLocationId, bool wasAlreadyCached)
	{
		//IL_00b0: Expected Obj, but got I4
		//IL_00c6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		bool flag = IsOnMissionTab();
		string text = string.Format((IFormatProvider)(object)"{0}{1}", (string)flag, "AttemptToCacheResult");
		string text2 = string.Format((IFormatProvider)(object)"{0};{1}", adLocationId, wasAlreadyCached);
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void OnChangedScreen(string screenName)
	{
		int currentScreenCacheFailCount = _currentScreenCacheFailCount + 1;
		_currentScreenCacheFailCount = currentScreenCacheFailCount;
	}

	private void LogWaterFallReach()
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_00e6: Expected Obj, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnChangedScreen -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string, bool> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		AdSystemManager.onCachedVideo -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj4 = action3 + 16;
		obj4 = this;
		AdSystemManager.onFailedToCacheVideo -= action3;
		_isFirstScreen = true;
	}

	private void Reset()
	{
		if (~(_isFirstScreen ? 1u : 0u) != 0 && ~(_hasCachedSuccesFullyOnCurrentScreen ? 1u : 0u) != 0)
		{
			string text = ((global::ABTest.ABTest)this).RangesToText((IEnumerable<Range>)(object)_previousScreenName);
			if (text != null && _currentScreenCacheFailCount > 0)
			{
				AdTrackingSystemLogger.LogFillRequest((AdLocationInfo)(object)_previousScreenName, (byte)_currentScreenCacheFailCount != 0);
			}
		}
	}

	private bool CanCacheAVideoAdOnScreen(string screenName)
	{
		OfferWallManager instance = OfferWallManager.instance;
		return ((AdSystemManager)(object)instance).GetAvailabilityForLocation(screenName);
	}

	private bool IsOnMissionTab()
	{
		//IL_002d: Expected I4, but got Obj
		//IL_003b: Expected I4, but got Obj
		//IL_0049: Expected I4, but got Obj
		if (this != null)
		{
			if ((nint)this == 1)
			{
				return (byte)(int)"vid_" != 0;
			}
			return (byte)(int)string.Empty != 0;
		}
		return (byte)(int)"int_" != 0;
	}
}
