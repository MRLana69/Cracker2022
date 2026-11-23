using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Analytics;
using Kiloo.Plugins.DeviceUtility;

namespace Info;

public static class AgeRestriction
{
	private const string ONLINESETTINGS_AGE_RESTRICTION_THRESHOLD_KEY = "age_restriction_threshold";

	private const string ONLINESETTINGS_AGE_RESTRICTION_VERSION_KEY = "age_restriction_version";

	private const int AGE_RESTRICTION_THRESHOLD_DEFAULT = 0;

	private const int AGE_RESTRICTION_VERSION_DEFAULT = 0;

	private static readonly bool _countryCodeRestricted;

	private static readonly string _cachedCountryCode;

	private static bool _userAgeRegistered;

	private static readonly Dictionary<string, int> _defaultCountryCodeRestrictions;

	private static Action _003C_003Ef__mg_0024cache0;

	private static Action m_restrictionChanged;

	public static bool isRestricted
	{
		get
		{
			if (~(_countryCodeRestricted ? 1u : 0u) == 0)
			{
				return IsAgeRestricted();
			}
			return false;
		}
	}

	public static bool waitForAgeRestriction
	{
		get
		{
			if (~(_countryCodeRestricted ? 1u : 0u) == 0)
			{
				return (byte)(~(_userAgeRegistered ? 1u : 0u)) != 0;
			}
			return false;
		}
	}

	public static bool shouldDisplayPopup
	{
		get
		{
			if (~(_countryCodeRestricted ? 1u : 0u) == 0)
			{
				return (byte)(~(_userAgeRegistered ? 1u : 0u)) != 0;
			}
			return false;
		}
	}

	public static bool countryCodeRestricted => _countryCodeRestricted;

	public static event Action restrictionChanged
	{
		add
		{
			Delegate obj = AgeRestriction.m_restrictionChanged;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AgeRestriction.m_restrictionChanged;
				Action action = action2;
				if (!flag)
				{
					action = AgeRestriction.m_restrictionChanged;
				}
				AgeRestriction.m_restrictionChanged = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AgeRestriction.m_restrictionChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = AgeRestriction.m_restrictionChanged;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == AgeRestriction.m_restrictionChanged;
				Action action = action2;
				if (!flag)
				{
					action = AgeRestriction.m_restrictionChanged;
				}
				AgeRestriction.m_restrictionChanged = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = AgeRestriction.m_restrictionChanged;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	unsafe static AgeRestriction()
	{
		//IL_00a2: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S5_v4+4] (should have been resolved before IL gen)");
		Dictionary<string, int> defaultCountryCodeRestrictions = default;
		_defaultCountryCodeRestrictions = defaultCountryCodeRestrictions;
		string locale = DeviceUtility.GetLocale();
		string contryCodeFromLocale = Utils.GetContryCodeFromLocale(locale);
		_cachedCountryCode = contryCodeFromLocale;
		bool countryCodeRestriction = GetCountryCodeRestriction();
		_countryCodeRestricted = countryCodeRestriction;
		bool userAgeRegistered = HasValidData();
		_userAgeRegistered = userAgeRegistered;
		Action action = default;
		action._002Ector(null, (nint)(delegate*<void>)(&LogStatistics));
		restrictionChanged += action;
	}

	private static bool GetCountryCodeRestriction()
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	private static bool HasValidData()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		PlayerInfo instance2 = PlayerInfo.Instance;
		bool flag = instance._ageRestrictionInputMonth < 1;
		bool result = false;
		if (!flag)
		{
			bool flag2 = instance2._ageRestrictionInputYear < 1;
			result = false;
			if (!flag2)
			{
				PlayerInfo instance3 = PlayerInfo.Instance;
				OnlineSettings instance4 = OnlineSettings.instance;
				int value = instance4.GetValue("age_restriction_version", 0);
				bool flag3 = value <= instance3._ageRestrictionInputVersion;
				result = flag3;
			}
		}
		return result;
	}

	private unsafe static void LogStatistics()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0028: Expected VT, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected VT, but got Unknown
		//IL_0076: Expected Ref, but got VT
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected VT, but got Unknown
		//IL_014d: Expected Ref, but got VT
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		DateTime userBirthday = GetUserBirthday();
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		if (userBirthday != (DateTime)0)
		{
			Manager.LogEvent(EventType.PlayerBirthdayEntered);
			DateTime dateTime = (DateTime)(obj + 24);
			int month = ((DateTime*)dateTime)->Month;
			bool flag = month < 7;
			object obj4 = "h1";
			if (!flag)
			{
				obj4 = "h2";
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			DateTime dateTime2 = (DateTime)(obj + 24);
			int year = ((DateTime*)dateTime2)->Year;
			object obj5 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
	}

	private static bool IsAgeRestricted()
	{
		if (~(_userAgeRegistered ? 1u : 0u) == 0)
		{
			int userAge = GetUserAge();
			int ageThreshold = GetAgeThreshold();
			return userAge < ageThreshold;
		}
		return false;
	}

	private unsafe static int GetUserAge()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_012f: Expected I8, but got I4
		//IL_012a: Expected native int or pointer, but got VT
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected VT, but got Unknown
		//IL_005b: Expected native int or pointer, but got VT
		//IL_007b: Expected I8, but got VT
		//IL_0076: Expected native int or pointer, but got VT
		//IL_0084: Expected Ref, but got VT
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected VT, but got Unknown
		//IL_009f: Expected Ref, but got VT
		//IL_00de: Expected Ref, but got VT
		//IL_00f7: Expected VT, but got I
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 16);
		_ = 0;
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		PlayerInfo instance = PlayerInfo.Instance;
		PlayerInfo instance2 = PlayerInfo.Instance;
		DateTime dateTime2 = dateTime + 8;
		int day = DateTime.DaysInMonth(instance2._ageRestrictionInputYear, instance._ageRestrictionInputMonth);
		*(DateTime*)(nint)dateTime2 = new DateTime(instance2._ageRestrictionInputYear, instance._ageRestrictionInputMonth, day);
		DateTime today = DateTime.Today;
		((DateTime*)(nint)dateTime)->_dateData = (ulong)(long)today;
		int year = ((DateTime*)dateTime)->Year;
		DateTime dateTime3 = dateTime + 8;
		int year2 = ((DateTime*)dateTime3)->Year;
		int num = year - year2;
		int result = num - 1;
		int value = -num;
		DateTime dateTime4 = ((DateTime*)dateTime)->AddYears(value);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+8]");
		if (!((DateTime)0 > dateTime4))
		{
			result = num;
		}
		return result;
	}

	private static int GetAgeThreshold()
	{
		//IL_0064: Expected Obj, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		OnlineSettings instance = OnlineSettings.instance;
		if (instance.HasValue("age_restriction_threshold"))
		{
			OnlineSettings instance2 = OnlineSettings.instance;
			return instance2.GetValue("age_restriction_threshold", 0);
		}
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			return _defaultCountryCodeRestrictions.get_Item(_cachedCountryCode);
		}
		return 0;
	}

	public unsafe static void RegisterUserBirthday(DateTime birthday)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected VT, but got Unknown
		//IL_011e: Expected Ref, but got VT
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected VT, but got Unknown
		//IL_0147: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		bool flag = HasValidData();
		PlayerInfo instance = PlayerInfo.Instance;
		if (instance._ageRestrictionInputVersion != 1)
		{
			instance._dirty = true;
			instance._ageRestrictionInputVersion = 1;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		DateTime dateTime = (DateTime)(obj + 8);
		int month = ((DateTime*)dateTime)->Month;
		if (month != instance2._ageRestrictionInputMonth)
		{
			instance2._dirty = true;
			instance2._ageRestrictionInputMonth = month;
		}
		PlayerInfo instance3 = PlayerInfo.Instance;
		DateTime dateTime2 = (DateTime)(obj + 8);
		int year = ((DateTime*)dateTime2)->Year;
		if (year != instance3._ageRestrictionInputYear)
		{
			instance3._dirty = true;
			instance3._ageRestrictionInputYear = year;
		}
		_userAgeRegistered = true;
		Action action = AgeRestriction.m_restrictionChanged;
		if (AgeRestriction.m_restrictionChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		PlayerInfo instance4 = PlayerInfo.Instance;
		instance4.SaveIfDirty();
	}

	public unsafe static DateTime GetUserBirthday()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009d: Expected Obj, but got I4
		//IL_008f: Expected VT, but got Obj
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected VT, but got Unknown
		//IL_0059: Expected native int or pointer, but got VT
		//IL_0073: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		obj = 0;
		if (HasValidData())
		{
			PlayerInfo instance = PlayerInfo.Instance;
			PlayerInfo instance2 = PlayerInfo.Instance;
			_ = 0;
			DateTime dateTime = (DateTime)(obj + 8);
			*(DateTime*)(nint)dateTime = new DateTime(instance2._ageRestrictionInputYear, instance._ageRestrictionInputMonth, 1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			return (DateTime)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		return (DateTime)obj;
	}
}
