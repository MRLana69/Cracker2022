using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kiloo.Common.Ads;

public class InterstitialStats
{
	private int seenThisHour__BackingField;

	private int currentHour__BackingField;

	private int seenThisDay__BackingField;

	private int currentDay__BackingField;

	private bool hasSeenFirstInterstitial__BackingField;

	public Dictionary<string, string> listVersionForID;

	public int seenThisHour
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.InterstitialStats)+30]");
			return ((nint)0 != 0) ? 1 : 0;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got I
			//IL_00cb: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.InterstitialStats)+34]");
			object obj2 = 0;
			AbstractAdProvider.EventListenerInvoker eventInvoker = AbstractAdProvider.eventInvoker;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v3+24]");
			string providerID = default;
			eventInvoker.StartedCachingAd((AdType)value, providerID, (string)0);
		}
	}

	public int currentHour
	{
		get
		{
			return seenThisHour__BackingField;
		}
		set
		{
			seenThisHour__BackingField = value;
		}
	}

	public int seenThisDay
	{
		get
		{
			return currentHour__BackingField;
		}
		set
		{
			currentHour__BackingField = value;
		}
	}

	public int currentDay
	{
		get
		{
			return seenThisDay__BackingField;
		}
		set
		{
			seenThisDay__BackingField = value;
		}
	}

	public bool hasSeenFirstInterstitial
	{
		get
		{
			return (byte)currentDay__BackingField != 0;
		}
		set
		{
			currentDay__BackingField = (value ? 1 : 0);
		}
	}

	private int actualCurrentHour => hasSeenFirstInterstitial__BackingField ? 1 : 0;

	private unsafe int actualCurrentDay
	{
		get
		{
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected Obj, but got Unknown
			//IL_00fe: Expected Obj, but got I4
			//IL_010c: Expected I, but got Obj
			//IL_0122: Expected Obj, but got I
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Expected Obj, but got Unknown
			//IL_0163: Expected Obj, but got I8
			//IL_016c: Expected Obj, but got VT
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected VT, but got Unknown
			//IL_0187: Expected I8, but got Obj
			//IL_0182: Expected native int or pointer, but got VT
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Expected Obj, but got Unknown
			//IL_01aa: Expected Ref, but got VT
			//IL_01b6: Expected Obj, but got I8
			//IL_0013: Expected I, but got Obj
			//IL_00e2: Expected I4, but got F8
			object obj2 = default;
			object obj = obj2 + 16;
			obj = 0;
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<System.DateTime>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v42 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
			object obj4 = obj2 + 8;
			obj4 = systemTimeAsFileTime;
			obj2 = DateTime.MinValue;
			DateTime dateTime = (DateTime)(obj2 + 24);
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
			IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
			formatProvider = (IFormatProvider)obj2;
			long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			obj = num3;
			double num4 = (double)obj * 2.7777777777777777E-11;
			if (num4 != num4)
			{
				return int.MinValue;
			}
			if (!(num4 < 2147483648.0))
			{
				return int.MinValue;
			}
			if (!(num4 > -2147483649.0))
			{
				return int.MinValue;
			}
			return (int)num4;
		}
	}

	public InterstitialStats()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.InterstitialStats)+34]");
		object obj2 = 0;
		AbstractAdProvider.EventListenerInvoker eventInvoker = AbstractAdProvider.eventInvoker;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v3+24]");
		string providerID = default;
		((AdController.EventHandler)(object)eventInvoker).HandleFail(providerID, (string)0);
	}

	public bool ReachedLimit(IAdSettingsProvider settings)
	{
		//IL_001a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.InterstitialStats)+38]");
		return ((List<string>)0).Contains((string)(object)settings);
	}

	public bool ReachedHourlyLimit(IAdSettingsProvider settings)
	{
		if (ReachedDailyLimit(settings))
		{
			return true;
		}
		return ((PriorityList)this)._003CChangeToNextProvider_003Eb__35_0((AdProviderInfo)settings);
	}

	public bool ReachedDailyLimit(IAdSettingsProvider settings)
	{
		IncrementShowCount();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		return seenThisHour__BackingField >= (nint)obj;
	}

	public bool HasVersionChangedForList(string waterfallID, string newVersion)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 20;
		obj2 = waterfallID;
		object obj3 = (flag ? 1 : 0) + 24;
		obj3 = newVersion;
		return flag;
	}

	private void CheckTime()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
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
		object obj6 = this + 28;
		object obj7 = default;
		obj6 = obj7;
	}

	public void IncrementShowCount()
	{
		//IL_0055: Expected I4, but got Obj
		string currentProvider = ((PriorityList)null).currentProvider;
		if (currentDay__BackingField != (nint)currentProvider)
		{
			seenThisDay__BackingField = 1;
			string currentProvider2 = ((PriorityList)null).currentProvider;
			currentDay__BackingField = (int)currentProvider2;
		}
		int num = ((InterstitialStats)null).actualCurrentDay;
		if (currentHour__BackingField != num)
		{
			seenThisHour__BackingField = 1;
			int num2 = ((InterstitialStats)null).actualCurrentDay;
			currentHour__BackingField = num2;
		}
	}
}
