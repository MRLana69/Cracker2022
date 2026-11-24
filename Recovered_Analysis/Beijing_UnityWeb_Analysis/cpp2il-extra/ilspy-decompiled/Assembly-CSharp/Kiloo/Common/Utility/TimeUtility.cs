using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Timer;
using UnityEngine;

namespace Kiloo.Common.Utility;

public static class TimeUtility
{
	public static readonly DateTime epoch;

	public static long ToUnixTime(DateTime time)
	{
		//IL_0010: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0L;
	}

	public static DateTime FromUnixTime(long unixtime)
	{
		//IL_0010: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return (DateTime)0;
	}

	public static string ToJSON(DateTime value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public static string ToSortableNumber(DateTime value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public unsafe static bool TryParseSortableNumber(string str, out DateTime result)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_000e: Expected Obj, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		object obj = ((System.Runtime.CompilerServices.Unsafe.AsPointer(ref result) == null) ? ((object)65) : ((object)97));
		object obj2 = obj - 10;
		object obj3 = str + 12;
		object obj4 = obj3 << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj5 = default;
		object obj14 = default;
		object obj33 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			object obj6 = obj5 << 1;
			object obj7 = str + 16;
			object obj8 = obj7 + obj5;
			object obj9 = obj8 & 0xFF;
			object obj11;
			object obj12;
			if ((nint)obj9 > 159)
			{
				object obj10 = obj5 << 1;
				obj11 = obj10;
				obj12 = obj2;
			}
			else
			{
				obj11 = obj6;
				obj12 = 48;
			}
			object obj13 = obj14 + 16;
			object obj15 = obj11 << 1;
			object obj16 = obj13 + obj15;
			object obj17 = obj8 & 0xFF;
			object obj18 = obj17 >> 4;
			object obj19 = obj12 + obj18;
			obj16 = obj19;
			object obj20 = obj5 << 1;
			object obj21 = obj20 + 1;
			object obj22 = str + 16;
			object obj23 = obj22 + obj5;
			object obj24 = obj23 & 0xF;
			object obj27;
			object obj28;
			if ((nint)obj24 > 9)
			{
				object obj25 = obj5 << 1;
				object obj26 = obj25 + 1;
				obj27 = obj26;
				obj28 = obj2;
			}
			else
			{
				obj27 = obj21;
				obj28 = 48;
			}
			object obj29 = obj14 + 16;
			object obj30 = obj27 << 1;
			object obj31 = obj29 + obj30;
			object obj32 = obj28 + obj24;
			obj31 = obj32;
			obj5 = obj33 + 1;
		}
		return (byte)((StringComparer)null).GetHashCode(obj14) != 0;
	}

	public static string ToRFC1123(DateTime value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public unsafe static bool TryParseRFC1123(string str, out DateTime result)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got Ref
		//IL_00fb: Expected Obj, but got I4
		//IL_00fb: Expected I4, but got Obj
		//IL_00ff: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(DateTimeFormatInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTimeFormatInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTimeFormatInfo currentInfo = DateTimeFormatInfo.CurrentInfo;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<System.DateTime>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v19 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)((System.DefaultBinder)(object)str).BindToField((BindingFlags)"yyyyMMddHHmmssfffffff", (FieldInfo[])(object)currentInfo, (object)80, (CultureInfo)System.Runtime.CompilerServices.Unsafe.AsPointer(ref result)) != 0;
	}

	public unsafe static long RFC1123StringToUnixTime(string str)
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_016f: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_01b0: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got VT
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected VT, but got Unknown
		//IL_0222: Expected I8, but got Obj
		//IL_021d: Expected native int or pointer, but got VT
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0245: Expected Ref, but got VT
		//IL_0251: Expected Obj, but got I8
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_013b: Expected I8, but got F8
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCDB");
		nint num = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v50 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v46 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 8;
		object obj6 = default;
		obj5 = obj6;
		obj2 = epoch;
		DateTime dateTime = (DateTime)(obj2 + 24);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
		formatProvider = (IFormatProvider)obj2;
		long num5 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num5;
		double num6 = (double)obj * 1E-07;
		if (num6 != num6)
		{
			return long.MinValue;
		}
		if (!(num6 < 9.223372036854776E+18))
		{
			return long.MinValue;
		}
		if (!(num6 > -9.223372036854776E+18))
		{
			return long.MinValue;
		}
		return (long)num6;
	}

	public static TimeSpan GetCurrentTimeZoneUTCOffset(DateTime time)
	{
		//IL_009c: Invalid comparison between VT and I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00c7: Expected I8, but got VT
		//IL_0054: Expected I, but got Obj
		DateTime dateTime = default;
		if (dateTime <= (object)(-1))
		{
			nint num = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<System.Math>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<System.Math>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return TimeSpan.FromTicks((long)dateTime);
		}
		TimeSpan result = default;
		return result;
	}

	public static DateTimeOffset Trim(DateTimeOffset time, long ticks)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got VT
		//IL_00ae: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E22F");
		DateTimeOffset dateTimeOffset = default;
		Action callback = default;
		((ThreadPooling)dateTimeOffset).RunAsync((Action<ThreadPooling.ProgressDelegate>)time, callback);
		return dateTimeOffset;
	}

	public unsafe static DateTimeOffset TrimToWholeSeconds(DateTimeOffset time)
	{
		//IL_01dd: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected I, but got Unknown
		//IL_0222: Expected I4, but got VT
		//IL_0222: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0242: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_0175: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		nint num3 = (nint)(obj2 + 4);
		if (ThreadPooling.s_instance != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v52 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = typeof(ThreadPooling);
			((IntPtr*)num3)->m_value = (void*)(nint)obj2;
			Type type = Type.internal_from_handle((IntPtr)num3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			int layer = default;
			gameObject.layer = layer;
			UnityEngine.Object.CheckNullArgument((object)gameObject, (string)61);
			if (Application.platform != RuntimePlatform.OSXEditor)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
			}
			ThreadPooling s_instance = gameObject.AddComponent<ThreadPooling>();
			ThreadPooling.s_instance = s_instance;
		}
		DateTimeOffset dateTimeOffset = default;
		((FrameTimer)(object)ThreadPooling.s_instance)._002Ector((int)dateTimeOffset, (byte)(int)time != 0);
		return dateTimeOffset;
	}

	public static DateTimeOffset TrimToWholeMilliSeconds(DateTimeOffset time)
	{
		//IL_005f: Expected Obj, but got VT
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj = time.m_dateTime;
		_ = time.m_offsetMinutes;
		nint num = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = obj + 16;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D777");
		DateTimeOffset result = default;
		return result;
	}

	public static DateTime Trim(DateTime time, long ticks)
	{
		return default;
	}

	public static DateTime TrimToWholeSeconds(DateTime time)
	{
		//IL_0010: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return (DateTime)0;
	}

	public static DateTime TrimToWholeMilliSeconds(DateTime time)
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = epoch;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
		DateTime result = default;
		return result;
	}

	static TimeUtility()
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)ThreadPooling.s_instance).FindKernel((string)null) == 0)
		{
			return;
		}
		string tag = ThreadPooling.s_instance.tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object)(object)tag);
		ThreadPooling.s_instance = null;
	}
}
