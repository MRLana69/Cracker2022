using System;
using Cpp2ILInjected;
using Kiloo.Common.Ads;

namespace Kiloo.Common.JsonUtil;

public class AdTrackingSystemLogger
{
	private static AdSystemEventLogger _adSystemEventLogger;

	public AdTrackingSystemLogger()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC00");
	}

	public static void SetAdSystemEventLogger(AdSystemEventLogger adSystemEventLogger)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		WaterFallReach waterFallReach = default;
		waterFallReach.LogWaterFallReach();
	}

	public static void LogFlow(AdType adType, AdLocationInfo adLocation, string flowId, string result)
	{
		_ = 1;
	}

	public static void LogFlow(AdType adType, string adLocationId, string providerId, string flowId, string result)
	{
		//IL_0096: Expected I4, but got Obj
		//IL_0096: Expected Obj, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected I4, but got Unknown
		//IL_0074: Expected I4, but got Obj
		//IL_0021: Expected I4, but got Obj
		bool flag = result == null;
		bool flag2 = !flag;
		string[] array = (string[])(object)"AlreadyCached";
		if (!flag2)
		{
			array = (string[])(object)"Success";
		}
		bool flag3 = ((WaterFallReach)null).CanCacheAVideoAdOnScreen(flowId);
		char c = ((string)flag3).get_Chars((int)providerId);
		int num = c ^ 1;
		int num2 = num | result;
		bool flag4 = num2 == 0;
		bool flag5 = !flag4;
		string text = (string)(object)array;
		if (!flag5)
		{
			string text2 = string.ConcatArray(array, (int)"NotCurrent");
			text = text2;
		}
		((WaterFallReach)(object)adLocationId).OnCachedVideo(providerId, (byte)(int)text != 0);
		_ = 0;
	}

	public static void LogAttemptToShowButtonFlow(AdLocationInfo adLocation)
	{
		_adSystemEventLogger = (AdSystemEventLogger)(object)adLocation;
	}

	public static void LogAttemptToShowButtonFlow(AdLocationInfo adLocation, bool isCached)
	{
		if (adLocation.adType == AdType.Video || adLocation.adType == (AdType)3)
		{
			adLocation.adType = (AdType)2;
		}
	}

	public static void LogAttemptToShowButtonFlow(AdLocationInfo adLocation, string result)
	{
		//IL_00b2: Expected I4, but got Obj
		//IL_0018: Expected Obj, but got I4
		//IL_0065: Expected I4, but got Obj
		//IL_0073: Expected I4, but got Obj
		//IL_0081: Expected I4, but got Obj
		AdSystemEventLogger adSystemEventLogger = _adSystemEventLogger;
		bool flag = result == null;
		bool flag2 = !flag;
		int waterfallReach = (int)"Fill";
		if (!flag2)
		{
			object obj = adSystemEventLogger.cacheFailSource__BackingField - 1;
			if (adSystemEventLogger.cacheFailSource__BackingField == CacheFailSource.Timeout)
			{
				waterfallReach = (int)"NoFillCacheTimeout";
			}
			else
			{
				waterfallReach = (((nint)obj != 1) ? ((int)"NoFill") : ((int)"NoFillEndOfWaterfall"));
			}
		}
		LogWaterFallReach((string)(object)adLocation, waterfallReach);
	}

	public static void LogVideoAdButtonClick(AdLocationInfo adLocation)
	{
		//IL_002c: Expected Obj, but got I4
		OfferWallManager instance = OfferWallManager.instance;
		bool flag = ((AdSystemManager)(object)instance).IsCaching((string)(object)adLocation);
		LogAttemptToShowButtonFlow(adLocation, (string)flag);
	}

	public static void LogWaterFallReach(string screenName, int waterfallReach)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_001c: Expected I4, but got Obj
		//IL_001c: Expected I4, but got Obj
		//IL_001c: Expected Obj, but got I4
		((CharacterMaterial.CharacterMaterialPathInfo)1)._002Ector((CharacterMaterial.CharacterMaterialShaderType)screenName, (DeviceInfo.PerformanceLevel)"Attempt to show button", (string)waterfallReach);
	}

	public static void LogFillRequest(AdLocationInfo adLocation)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string text = $"{(object[])(object)adLocation.id}_generic";
		OfferWallManager instance = OfferWallManager.instance;
		bool availabilityForLocation = ((AdSystemManager)(object)instance).GetAvailabilityForLocation(adLocation.id);
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v16 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public static void LogFillRequest(AdLocationInfo adLocation, bool adAvailable)
	{
		//IL_005a: Expected Obj, but got I4
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj = adAvailable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object arg = default;
		string text = string.Format((IFormatProvider)(object)"{0};{1}", (string)(object)adLocation, arg);
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v21 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public static void LogAttemptToCacheResult(AdType adType, string providerId, string result)
	{
		_ = 1;
	}

	private static string GetAdPrefix(AdType adType)
	{
		//IL_0016: Expected Obj, but got I4
		OfferWallManager instance = OfferWallManager.instance;
		return (string)((NativeInterstitialAdObject)(object)instance).Valid;
	}
}
