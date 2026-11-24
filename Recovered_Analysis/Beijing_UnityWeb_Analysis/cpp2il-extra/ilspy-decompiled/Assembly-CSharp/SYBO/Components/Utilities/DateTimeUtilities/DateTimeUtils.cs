using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities.IO;
using SYBO.Components.Utilities.Scriptables;

namespace SYBO.Components.Utilities.DateTimeUtilities;

public static class DateTimeUtils
{
	private enum Months
	{
		Jan = 1,
		Feb,
		Mar,
		Apr,
		May,
		Jun,
		Jul,
		Aug,
		Sep,
		Oct,
		Nov,
		Dec
	}

	private static readonly char[] RFC3339SplitSymbols;

	private static readonly char[] RFC822SplitSymbols;

	public const int TicksPerSecond = 10000000;

	public const int TicksPerMillisecond = 10000;

	public const int NanosecondsPerTicks = 100;

	public static readonly DateTime FallbackDateTime;

	public static double TotalSecondsSinceEpoch()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001e: Expected Obj, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got I
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00a3: Expected F8, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L0 (Il2CppMethodInfo)+8]");
		obj = 0;
		object obj3 = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L0 (Il2CppMethodInfo)+C]");
		obj3 = 0;
		object obj4 = obj2 + 12;
		obj4 = obj;
		object obj5 = obj2 + 16;
		obj5 = obj3;
		nint num = default;
		object obj6 = num + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12C8");
		object obj7 = default;
		obj2 = obj7;
		obj5 = obj2;
		object obj8 = obj5 + 8;
		return (double)obj8;
	}

	public unsafe static bool TryParseRFC3339(string timestamp, out DateTime parsedDateTime)
	{
		//IL_000d: Expected Obj, but got Ref
		//IL_001a: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		bool flag = ((PersistentDataPathUtility)(object)timestamp).DeleteStorageLocation((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref parsedDateTime));
		if (Directory.IsRootDirectory((string)flag))
		{
			Directory.Move((string)flag, (string)1);
			return true;
		}
		return false;
	}

	public static string ToStringRFC3339(DateTime time)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E22C");
		string result = default;
		return result;
	}

	public unsafe static bool TryParseRFC822(string timestamp, out DateTime parsedDateTime)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_064c: Expected Obj, but got I4
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_007c: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		//IL_06ac: Expected I, but got Obj
		//IL_06c2: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_008f: Expected I, but got Obj
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_048f: Expected VT, but got Obj
		//IL_036f: Expected Obj, but got I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_01e6: Expected I, but got Obj
		//IL_01fc: Expected Obj, but got I
		//IL_049c: Expected Obj, but got VT
		//IL_045c: Expected VT, but got Obj
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected Obj, but got Unknown
		//IL_063e: Expected Ref, but got VT
		//IL_03e6: Expected Obj, but got I4
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0227: Expected I, but got Obj
		//IL_02e7: Invalid comparison between Obj and F8
		//IL_0324: Invalid comparison between Obj and F8
		//IL_02d5: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got I4
		//IL_034f: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = 0;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		string text = timestamp.ToUpperInvariant();
		bool flag = text.EndsWith(".");
		bool flag2 = text.EndsWith("Z");
		object obj4;
		if (flag2)
		{
			obj4 = 0;
		}
		else
		{
			obj4 = ((!text.EndsWith("+")) ? ((object)1) : ((object)(-1)));
		}
		nint num = (nint)typeof(DateTimeUtils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v22 (Il2CppClass<SYBO.Components.Utilities.DateTimeUtilities.DateTimeUtils>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(DateTimeUtils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v235 (Il2CppClass<SYBO.Components.Utilities.DateTimeUtilities.DateTimeUtils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string[] array = text.Split((string[])(object)RFC3339SplitSymbols, StringSplitOptions.RemoveEmptyEntries);
		object obj6 = array + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj7 = array + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj8 = array + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj9 = array + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj10 = array + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj11 = array + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj12 = default;
		bool flag3 = (nint)obj12 == 60;
		if (flag3)
		{
			object obj13 = 59;
		}
		else
		{
			object obj13 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
		object obj22 = default;
		if (flag)
		{
			object obj14 = array + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S0_v199 (Il2CppClass<System.Math>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num4 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v228 (Il2CppClass<System.Math>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			object obj16 = array + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122F5");
			object obj17 = default;
			double num5 = 10000000.0 / (double)obj17;
			object obj18 = default;
			double num6 = (double)obj18 * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D10");
			object obj19 = default;
			if (obj19 != obj19)
			{
				obj19 = int.MinValue;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2147483648.0))
			{
				obj19 = int.MinValue;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2147483649.0)))
			{
				obj19 = int.MinValue;
			}
			object obj20 = obj19 >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E1");
			object obj21 = obj22 << 32;
			object obj24 = default;
			object obj23 = obj24 | obj21;
			obj2 = obj23;
		}
		if (!flag2)
		{
			object obj25 = (flag ? 1u : 0u) << 2;
			object obj26 = (object)array + obj25;
			object obj27 = obj26 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj29 = default;
			object obj28 = obj4 * obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA");
			object obj30 = obj22 << 32;
			object obj32 = default;
			object obj31 = obj32 | obj30;
			obj2 = obj31;
			object obj33 = (flag ? 1u : 0u) << 2;
			object obj34 = (object)array + obj33;
			object obj35 = obj34 + 44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj37 = default;
			object obj36 = obj4 * obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA");
			object obj38 = obj22 << 32;
			object obj40 = default;
			object obj39 = obj40 | obj38;
			obj2 = obj39;
		}
		DateTime dateTime;
		bool result;
		if (!flag3)
		{
			dateTime = (DateTime)obj2;
			result = true;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA");
			object obj41 = obj22 << 32;
			object obj42 = default;
			DateTime dateTime2 = (DateTime)(obj42 | obj41);
			obj2 = dateTime2;
			dateTime = dateTime2;
			result = true;
		}
		ref DateTime reference = ref *(DateTime*)dateTime;
		return result;
	}

	static DateTimeUtils()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ScriptablesSafeDeleteAttribute scriptablesSafeDeleteAttribute = default;
		scriptablesSafeDeleteAttribute._002Ector();
		ScriptablesAccessor.OnUpdatedFields = (ScriptablesAccessorEvent)(object)scriptablesSafeDeleteAttribute;
	}
}
