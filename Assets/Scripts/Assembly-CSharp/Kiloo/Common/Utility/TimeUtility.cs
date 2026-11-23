using System;
using System.Globalization;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public static class TimeUtility
{
	public static readonly DateTime epoch;

	public unsafe static long ToUnixTime(DateTime time)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected VT, but got Unknown
		//IL_00bb: Expected Ref, but got VT
		//IL_0032: Expected Obj, but got VT
		//IL_0096: Expected F8, but got I8
		//IL_00c9: Expected I8, but got F8
		object obj2 = default;
		object obj = obj2 - 16;
		obj = 0;
		DateTime dateTime = (DateTime)(obj + 8);
		DateTime dateTime2 = ((DateTime*)dateTime)->ToUniversalTime();
		TimeSpan timeSpan = dateTime2 - epoch;
		obj = timeSpan;
		double num = (double)obj * 1E-07;
		double num2 = Math.Abs(num);
		if (!(num2 < 9.223372036854776E+18))
		{
			num = -9.223372036854776E+18;
		}
		return (long)num;
	}

	public unsafe static DateTime FromUnixTime(long unixtime)
	{
		//IL_0018: Expected I, but got Obj
		//IL_002d: Expected F8, but got I8
		nint num = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v10 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+5C]");
		return ((DateTime*)null)->AddSeconds(unixtime);
	}

	public unsafe static string ToJSON(DateTime value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004f: Expected I8, but got I4
		//IL_004a: Expected native int or pointer, but got VT
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected VT, but got Unknown
		//IL_0066: Expected Ref, but got VT
		//IL_0077: Expected I8, but got VT
		//IL_0072: Expected native int or pointer, but got VT
		//IL_0033: Expected Ref, but got VT
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 16);
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		DateTime dateTime2 = dateTime + 8;
		DateTime dateTime3 = ((DateTime*)dateTime2)->ToUniversalTime();
		((DateTime*)(nint)dateTime)->_dateData = (ulong)(long)dateTime3;
		DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
		return ((DateTime*)dateTime)->ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffff'Z'", invariantInfo);
	}

	public unsafe static string ToSortableNumber(DateTime value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004f: Expected I8, but got I4
		//IL_004a: Expected native int or pointer, but got VT
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected VT, but got Unknown
		//IL_0066: Expected Ref, but got VT
		//IL_0077: Expected I8, but got VT
		//IL_0072: Expected native int or pointer, but got VT
		//IL_0033: Expected Ref, but got VT
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 16);
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		DateTime dateTime2 = dateTime + 8;
		DateTime dateTime3 = ((DateTime*)dateTime2)->ToUniversalTime();
		((DateTime*)(nint)dateTime)->_dateData = (ulong)(long)dateTime3;
		DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
		return ((DateTime*)dateTime)->ToString("yyyyMMddHHmmssfffffff", invariantInfo);
	}

	public static bool TryParseSortableNumber(string str, out DateTime result)
	{
		DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
		return DateTime.TryParseExact(str, "yyyyMMddHHmmssfffffff", invariantInfo, (DateTimeStyles)80, out result);
	}

	public unsafe static string ToRFC1123(DateTime value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0057: Expected I8, but got I4
		//IL_0052: Expected native int or pointer, but got VT
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected VT, but got Unknown
		//IL_006e: Expected Ref, but got VT
		//IL_007f: Expected I8, but got VT
		//IL_007a: Expected native int or pointer, but got VT
		//IL_0040: Expected Ref, but got VT
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 16);
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		DateTime dateTime2 = dateTime + 8;
		DateTime dateTime3 = ((DateTime*)dateTime2)->ToUniversalTime();
		((DateTime*)(nint)dateTime)->_dateData = (ulong)(long)dateTime3;
		DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
		string rFC1123Pattern = invariantInfo.RFC1123Pattern;
		return ((DateTime*)dateTime)->ToString(rFC1123Pattern);
	}

	public static bool TryParseRFC1123(string str, out DateTime result)
	{
		DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
		string rFC1123Pattern = invariantInfo.RFC1123Pattern;
		DateTimeFormatInfo invariantInfo2 = DateTimeFormatInfo.InvariantInfo;
		return DateTime.TryParseExact(str, rFC1123Pattern, invariantInfo2, (DateTimeStyles)80, out result);
	}

	public unsafe static long RFC1123StringToUnixTime(string str)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		//IL_0061: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (str != null && TryParseRFC1123(str, out *(DateTime*)(obj + 8)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			return ToUnixTime((DateTime)0);
		}
		long result = default;
		return result;
	}

	public static TimeSpan GetCurrentTimeZoneUTCOffset(DateTime time)
	{
		//IL_0011: Expected I, but got Obj
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		TimeZone currentTimeZone = TimeZone.CurrentTimeZone;
		nint num = (nint)currentTimeZone;
		object obj = currentTimeZone + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S2_v2 (Il2CppClass<System.TimeZone>)+DC] (should have been resolved before IL gen)");
		TimeSpan result = default;
		return result;
	}

	unsafe static TimeUtility()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected VT, but got Unknown
		//IL_0053: Expected native int or pointer, but got VT
		//IL_0069: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		DateTime dateTime = (DateTime)(obj + 8);
		*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		epoch = (DateTime)0;
	}
}
