using System;
using System.Collections.Generic;
using ABTest;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using UnityEngine;

namespace Kiloo.Common.JsonUtil;

public class AdSystemEventLogger : AdEventListenerAdapter
{
	private bool clicked__BackingField;

	private CacheFailSource cacheFailSource__BackingField;

	private AdState adState__BackingField;

	public bool clicked
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		private set
		{
		}
	}

	public CacheFailSource cacheFailSource
	{
		get
		{
			return clicked__BackingField ? CacheFailSource.Timeout : CacheFailSource.NoFail;
		}
		private set
		{
			bool flag = (byte)(value & CacheFailSource.Timeout) != 0;
			clicked__BackingField = flag;
		}
	}

	public AdState adState
	{
		get
		{
			return (AdState)cacheFailSource__BackingField;
		}
		private set
		{
			cacheFailSource__BackingField = (CacheFailSource)value;
		}
	}

	public unsafe AdSystemEventLogger()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected VT, but got Unknown
		//IL_00e4: Expected F4, but got Obj
		//IL_00df: Expected native int or pointer, but got VT
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_010c: Expected F4, but got Obj
		//IL_0107: Expected native int or pointer, but got VT
		//IL_0121: Expected F4, but got I
		//IL_011c: Expected native int or pointer, but got VT
		//IL_012a: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.JsonUtil.AdSystemEventLogger)+1C]");
		obj = 0;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v6 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v20 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = obj;
		Vector4 vector = (Vector4)(obj2 + 28);
		((Vector4*)(nint)vector)->x = (float)obj2;
		object obj4 = obj2 + 16;
		Vector3 vector2 = vector;
		((Vector4*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v14+8]");
		((Vector4*)(nint)vector)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
		if (cacheFailSource__BackingField != CacheFailSource.NoFail)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public override void ShowedAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		adState__BackingField = (AdState)(-1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj = this + 32;
		obj = list;
		object obj2 = this + 48;
		obj2 = adType;
		object obj3 = this + 40;
		obj3 = adLocationID;
		object obj4 = this + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		object obj5 = default;
		obj4 = obj5;
	}

	public override void FailedToShowAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_002e: Expected Obj, but got I4
		string adPrefix = AdTrackingSystemLogger.GetAdPrefix(AdType.Interstitial);
		((OfferWallPopup.OfferListAdapter)adType)._002Ector((List<OfferWallCell>)(object)adPrefix, (GameObject)(object)providerID, (GameObject)(object)"Attempt to show ad", (Action)(object)"ShowedAd");
		adState__BackingField = AdState.ShownButNotFinished;
	}

	public override void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached)
	{
	}

	public override void DismissedAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_002e: Expected Obj, but got I4
		string adPrefix = AdTrackingSystemLogger.GetAdPrefix(AdType.Interstitial);
		((OfferWallPopup.OfferListAdapter)adType)._002Ector((List<OfferWallCell>)(object)adPrefix, (GameObject)(object)providerID, (GameObject)(object)"Attempt to show ad", (Action)(object)"FailedShowingAd");
	}

	public override void FinishedWatchingVideo(string providerID, string adLocationID)
	{
		//IL_00d8: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_001a: Expected Obj, but got I
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_0171: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		string id = ((DebugAdProvider)this).id;
		if (id != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.JsonUtil.AdSystemEventLogger)+38]");
			bool flag = ((List<string>)0).Remove(adLocationID);
			nint num = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v40 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v47 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string providerID2 = default;
			AbstractAdProvider.eventInvoker.CachingTimedOut(AdType.Video, providerID2, providerID);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		_ = 1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.JsonUtil.AdSystemEventLogger)+34]");
		object obj2 = (nint)0 + (nint)16;
		object obj3 = default;
		obj2 = obj3;
		_ = 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.JsonUtil.AdSystemEventLogger)+34]");
		object obj4 = (nint)0 + (nint)36;
		obj4 = providerID;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.JsonUtil.AdSystemEventLogger)+38]");
		bool flag2 = ((List<string>)0).Remove(adLocationID);
		nint num3 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v23 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v30 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID3 = default;
		AbstractAdProvider.eventInvoker.DismissedAd(AdType.Video, providerID3, providerID);
	}

	public override void FailedToCacheAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_0013: Expected I4, but got Obj
		//IL_0013: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I4
		Range onClick = ((global::ABTest.ABTest)(object)this).ParseKeyRange((string)adType, (char)(int)providerID);
		((OfferWallPopup.OfferListAdapter)adType)._002Ector((List<OfferWallCell>)(object)adLocationID, (GameObject)(object)providerID, (GameObject)(object)"Result of ad shown", (Action)(object)onClick);
		clicked__BackingField = false;
		adState__BackingField = AdState.NotShown;
	}

	public override void CachingTimedOut(AdType adType, string providerID, string adLocationID)
	{
		//IL_0040: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got I4
		//IL_007b: Expected I4, but got Obj
		//IL_007b: Expected Obj, but got I4
		//IL_0014: Expected I4, but got Obj
		bool flag = ((WaterFallReach)null).CanCacheAVideoAdOnScreen(adLocationID);
		char c = ((string)flag).get_Chars((int)providerID);
		bool flag2 = c == '\0';
		string text = "Failed";
		if (!flag2)
		{
			string text2 = string.ConcatArray((string[])(object)"Failed", (int)"NotCurrent");
			text = text2;
		}
		((WaterFallReach)adType).OnCachedVideo(providerID, (byte)(int)text != 0);
		cacheFailSource__BackingField = CacheFailSource.CacheFail;
	}

	public override void PriorityListWrapped(string waterfallID)
	{
		//IL_000a: Expected I4, but got Obj
		adState__BackingField = (AdState)waterfallID;
	}

	public override void ClickedAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_0017: Expected I4, but got Obj
		//IL_0017: Expected Obj, but got I4
		((WaterFallReach)adType).OnCachedVideo(providerID, (byte)(int)"Timedout" != 0);
		cacheFailSource__BackingField = CacheFailSource.Timeout;
	}

	private unsafe string GetResultOfVideoShown(AdType adType, string providerId)
	{
		//IL_00bb: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		//IL_0013: Expected I4, but got Obj
		ref string reference = ref *(string*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.JsonUtil.AdSystemEventLogger)+1C]");
		if (((Dictionary<string, string>)0).TryGetValue((string)adType, out reference) && reference.get_Chars((int)providerId) == '\0')
		{
			return null;
		}
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S4_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S4_v5+48]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S5_v5 (should have been resolved before IL gen)");
		return (string)1;
	}

	private string GetAdShownPrefix(AdType adType)
	{
		return null;
	}

	private string GetVideoShownPrefix()
	{
		//IL_0007: Expected Obj, but got I4
		return (string)adState__BackingField;
	}

	private string GetIdOfAdlocationBeingShown()
	{
		//IL_0032: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		object obj;
		if (adState__BackingField != AdState.ShownButNotFinished)
		{
			if (adState__BackingField == AdState.ShownAndFinished)
			{
				obj = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string format = default;
				return string.Format((IFormatProvider)(object)"{0}{1}", format, "Finished");
			}
			return string.Empty;
		}
		obj = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format2 = default;
		return string.Format((IFormatProvider)(object)"{0}{1}", format2, "Early");
	}

	private string GetCurrentProviderIDForLocation(string adLocationId)
	{
		if ((nint)adLocationId == 1)
		{
			return GetIdOfAdlocationBeingShown();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}
}
