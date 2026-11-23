using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;

namespace Kiloo.Common.Extensions;

public static class CollectionExtensions
{
	public static void AddSorted<T>(List<T> list, T item) where T : IComparable<T>
	{
		//IL_001c: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S2_v2 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddSorted>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S2_v3+4] (should have been resolved before IL gen)");
		object obj2 = default;
		bool flag = obj2 == null;
		nint num3 = 0;
		if (!flag)
		{
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v5 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddSorted>)+4]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v6+4] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 - 1;
			nint num6 = 0;
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S3_v9 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddSorted>)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S3_v10+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj7 = default;
			bool flag2 = (nint)obj7 <= 0;
			num3 = 0;
			if (!flag2)
			{
				nint num8 = 0;
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S3_v13 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddSorted>)+C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S3_v14+4] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj9 = default;
				if ((nint)obj9 >= 0)
				{
					nint num10 = 0;
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S4_v8 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddSorted>)+1C]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ S4_v9+4] (should have been resolved before IL gen)");
					return;
				}
				nint num12 = 0;
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v1 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddSorted>)+20]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ S4_v2+4] (should have been resolved before IL gen)");
				object obj13 = default;
				object obj12 = obj13 >> 31;
				object obj14 = obj12 ^ obj13;
				nint num14 = 0;
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S4_v5 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddSorted>)+1C]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ S4_v6+4] (should have been resolved before IL gen)");
				return;
			}
		}
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ L3_v2 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddSorted>)+8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S3_v3+4] (should have been resolved before IL gen)");
	}

	public static T GetRandomElement<T>(IEnumerable<T> sequence)
	{
		//IL_00b2: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj = default;
		bool flag = obj == null;
		bool flag2 = !flag;
		object obj2 = obj;
		if (!flag2)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S3_v8 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::GetRandomElement>)+4]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S3_v9+4] (should have been resolved before IL gen)");
			object obj4 = default;
			obj2 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L2_v2+C]");
		int num3 = KRandom.Range(0, 0);
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S3_v4 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::GetRandomElement>)+8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S3_v5+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static T GetRandomElement<T>(IList<T> list)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int max = default;
		int num = KRandom.Range(0, max);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		T result = default;
		return result;
	}

	public static void Shuffle<T>(IList<T> array)
	{
		//IL_006e: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int num2 = default;
		int num = num2;
		while (num > 1)
		{
			int num3 = KRandom.Range(0, num);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			object obj = num - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			object obj2 = num - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			int num4 = num - 1;
			num = num4;
		}
	}

	public static void SwitchPlaces<T>(IList<T> arr, int i, int j)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		if ((nint)obj > i)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj2 = default;
			if ((nint)obj2 > j)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			}
		}
	}

	public static IList<T> Clone<T>(IList<T> listToClone) where T : ICloneable
	{
		//IL_0029: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v6+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v7+4]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v7+4]");
		object obj2 = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v19+5C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			nint num = 0;
			nint num2 = 0;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::Clone>)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S4_v4+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v28+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			object obj6 = default;
			obj2 = obj6;
		}
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::Clone>)+10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S3_v4+4] (should have been resolved before IL gen)");
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v6 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::Clone>)+14]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S2_v7+4] (should have been resolved before IL gen)");
		IList<T> result = default;
		return result;
	}

	public static Dictionary<T, U> ToDictionary<T, U>(List<KeyValuePair<T, U>> keyvalueList)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_041b: Expected Obj, but got I
		//IL_042b: Expected Obj, but got I
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I
		//IL_022f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v2 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::ToDictionary>)+4]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S2_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v2 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::ToDictionary>)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S3_v3+4] (should have been resolved before IL gen)");
		object obj5 = obj + 8;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S3_v6 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::ToDictionary>)+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S3_v7+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj7 = obj + 60;
		object obj8 = obj + 40;
		obj = obj8;
		_ = 0;
		object obj12 = default;
		object obj18 = default;
		object obj19 = default;
		Dictionary<T, U> dictionary = default;
		Dictionary<T, U> dictionary2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v25+1C]");
			object obj10 = 0;
			_ = 0;
			object obj11 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj12 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v117+1C]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v118+28]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v122+1C]");
							object obj17 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj18 == obj19;
			bool flag2 = !flag;
			Dictionary<T, U> result = dictionary;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = dictionary2;
			}
			_ = 0;
			object obj20 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		object obj21 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8DD6");
		Dictionary<T, U> result2 = default;
		return result2;
	}

	public static List<KeyValuePair<T, U>> ToKeyValueList<T, U>(Dictionary<T, U> dictionary)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_03d2: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0198: Expected Obj, but got I
		//IL_01a8: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v2 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::ToKeyValueList>)+4]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S2_v3+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v2 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::ToKeyValueList>)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S3_v3+4] (should have been resolved before IL gen)");
		object obj6 = obj + 24;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v6 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::ToKeyValueList>)+10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S3_v7+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj8 = obj + 76;
		object obj9 = obj + 48;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj13 = default;
		object obj19 = default;
		object obj20 = default;
		List<KeyValuePair<T, U>> list = default;
		List<KeyValuePair<T, U>> list2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v25+1C]");
			object obj11 = 0;
			_ = 0;
			object obj12 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj13 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v87+1C]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v88+1C]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v93+1C]");
					object obj18 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj19 == obj20;
			bool flag2 = !flag;
			List<KeyValuePair<T, U>> result = list;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = list2;
			}
			_ = 0;
			object obj21 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		object obj22 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8DD5");
		List<KeyValuePair<T, U>> result2 = default;
		return result2;
	}

	public static bool ValidIndex<T>(IList<T> l, int index)
	{
		if (index >= 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			return (nint)obj > index;
		}
		return false;
	}

	public static bool AddDistinct<T>(IList<T> list, T value)
	{
		//IL_003a: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddDistinct>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S4_v2 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddDistinct>)+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S4_v3+4] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	private static bool AddDistinct<T>(IList<T> list, T value, IEqualityComparer<T> comparer)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected I4, but got Unknown
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddDistinct>>)+4] (should have been resolved before IL gen)");
		object obj = default;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
		return (byte)(obj ^ 1) != 0;
	}

	private static bool ContainsValue<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03b5: Expected I4, but got Obj
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02f5: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		IEqualityComparer<TSource> equalityComparer = default;
		if (equalityComparer == null)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v60 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::ContainsValue>>)+4] (should have been resolved before IL gen)");
		}
		if (source == null)
		{
			goto IL_0389;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		ArgumentNullException ex = default;
		ArgumentNullException ex2;
		object obj4 = default;
		object obj5 = default;
		object obj6 = default;
		IntPtr intPtr3 = default;
		IntPtr intPtr4 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = ex == null;
				ex2 = ex;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj4 != null)
								{
									ex2 = ex;
									break;
								}
								continue;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_01e7;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_01e7;
			IL_01e7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj5 == obj6;
			bool flag3 = !flag2;
			IntPtr intPtr2 = intPtr3;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				ex2 = null;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				intPtr2 = intPtr4;
			}
			goto IL_02a7;
		}
		goto IL_0398;
		IL_0389:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ArgumentNullException ex3 = default;
		ex3._002Ector("source");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		ex2 = ex3;
		goto IL_03fb;
		IL_03fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0398;
		IL_02a7:
		_ = 0;
		object obj7 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag5 = (nint)0 != 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		ex2 = (ArgumentNullException)0;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			goto IL_0389;
		}
		goto IL_03fb;
		IL_0398:
		object obj8 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return (byte)(int)ex2 != 0;
	}

	public static bool AddRangeDistinct<T>(IList<T> list, IEnumerable<T> values)
	{
		//IL_003a: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddRangeDistinct>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S4_v2 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddRangeDistinct>)+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S4_v3+4] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public static bool AddRangeDistinct<T>(IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected I4, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = 1;
		object obj5 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		bool flag3 = default;
		bool flag4 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v83 (Il2CppMethodRgctx<Kiloo.Common.Extensions.CollectionExtensions::AddRangeDistinct>)+10]");
						object obj6 = 0;
						nint num2 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj7 = obj4 & obj8;
							obj4 = obj7;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_0144;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0144;
			IL_0144:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj9 == obj10;
			bool flag2 = !flag;
			bool result = flag3;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag4;
			}
			_ = 0;
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		object obj12 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return (byte)(obj4 & 1) != 0;
	}
}
