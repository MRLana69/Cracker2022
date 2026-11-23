using System;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Extensions;

public static class MiscExtensions
{
	public static void Destroy(UnityEngine.Object obj)
	{
		if (!(obj == null))
		{
			if (Application.isPlaying)
			{
				UnityEngine.Object.Destroy(obj);
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(obj);
			}
		}
	}

	public unsafe static bool TryParseHexToColor(string hexString, out Color color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_038c: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I
		//IL_03f3: Expected Obj, but got I
		//IL_0215: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
									_ = 1065353216;
									object obj4 = default;
									float num = (float)obj4 / 255f;
									object obj5 = default;
									float num2 = (float)obj5 / 255f;
									object obj6 = default;
									float num3 = (float)obj6 / 255f;
									ref Color reference = ref *(Color*)num3;
									result = true;
									goto IL_0500;
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
		object obj7 = default;
		object obj8 = default;
		bool flag = obj7 != obj8;
		bool flag2 = default;
		result = flag2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj10 = default;
				object obj9 = obj10;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj11 = default;
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
						object obj12 = (nint)0 << 2;
						object obj13 = obj3 + obj12;
						obj13 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
						object obj14 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						_ = 4575657222473777152L;
						ref Color reference = ref *(Color*)4575657222473777152L;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
						object obj15 = -1;
						result = false;
						goto IL_0500;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj16 = obj10;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result = false;
					if (flag3)
					{
						goto IL_0505;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			bool flag5 = default;
			result = flag5;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				result = flag5;
			}
		}
		goto IL_0505;
		IL_0505:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0500;
		IL_0500:
		return result;
	}

	public static string ToHex(Color color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		float num = Math.Min(color.r, 1f);
		bool flag = color.r < 0f;
		float num2 = 0f;
		if (!flag)
		{
			num2 = num;
		}
		float num3 = num2 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num4 = Math.Min(color.g, 1f);
		bool flag2 = color.g < 0f;
		float num5 = 0f;
		if (!flag2)
		{
			num5 = num4;
		}
		float num6 = num5 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num7 = Math.Min(color.b, 1f);
		bool flag3 = color.b < 0f;
		float num8 = 0f;
		if (!flag3)
		{
			num8 = num7;
		}
		float num9 = num8 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num10 = Math.Min(color.a, 1f);
		bool flag4 = color.a < 0f;
		float num11 = 0f;
		if (!flag4)
		{
			num11 = num10;
		}
		float num12 = num11 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj4 = default;
		object obj3 = obj4 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj6 = default;
		object obj5 = obj6 << 8;
		object obj7 = obj5 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj9 = default;
		object obj8 = obj9 << 16;
		object obj10 = obj8 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj12 = default;
		object obj11 = obj12 << 24;
		object obj13 = obj10 | obj11;
		object obj14 = obj7 | obj13;
		object obj15 = obj3 | obj14;
		Color32 color2 = (Color32)(obj + 4);
		return ToHex(color2);
	}

	public static string ToHex(Color32 color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00dc: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector("#");
		_ = color.rgba;
		object obj3 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string value = $"{arg:X2}";
		StringBuilder stringBuilder2 = stringBuilder.Append(value);
		_ = color.g;
		object obj4 = obj + 14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg2 = default;
		string value2 = $"{arg2:X2}";
		StringBuilder stringBuilder3 = stringBuilder2.Append(value2);
		_ = color.b;
		object obj5 = obj + 13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg3 = default;
		string value3 = $"{arg3:X2}";
		StringBuilder stringBuilder4 = stringBuilder3.Append(value3);
		nint num = (nint)stringBuilder4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S1_v27 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public static TEnum ToEnum<TEnum>(string strEnumValue, TEnum defaultValue)
	{
		//IL_0014: Expected VT, but got I
		//IL_005b: Expected VT, but got I
		if (strEnumValue != null)
		{
			nint num = 0;
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
			if (Enum.IsDefined(typeFromHandle, strEnumValue))
			{
				nint num2 = 0;
				Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)num2);
				object obj = Enum.Parse(typeFromHandle2, strEnumValue);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			}
		}
		TEnum result = default;
		return result;
	}

	public static T SafeInvoke<T>(Func<T> f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0084: Expected VT, but got I
		//IL_004d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (f != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S2_v4+4] (should have been resolved before IL gen)");
			T result = default;
			return result;
		}
		object obj4 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (T)0;
	}

	public static void SafeInvoke(Action action)
	{
		if (action != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: action.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public static void SafeInvoke<T>(Action<T> action, T argument)
	{
		//IL_0039: Expected Obj, but got I
		if (action != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	public static void SafeInvoke<T1, T2>(Action<T1, T2> action, T1 argument1, T2 argument2)
	{
		//IL_0039: Expected Obj, but got I
		if (action != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S4_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S4_v4+4] (should have been resolved before IL gen)");
		}
	}

	public static void SafeInvoke<T1, T2, T3>(Action<T1, T2, T3> action, T1 argument1, T2 argument2, T3 argument3)
	{
		//IL_0039: Expected Obj, but got I
		if (action != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S5_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S5_v4+4] (should have been resolved before IL gen)");
		}
	}

	public static void SafeInvoke<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 argument1, T2 argument2, T3 argument3, T4 argument4)
	{
		//IL_0039: Expected Obj, but got I
		if (action != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S6_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S6_v4+4] (should have been resolved before IL gen)");
		}
	}

	public static string NicifyTimeString(TimeSpan ts)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I8
		//IL_0127: Expected Obj, but got I8
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I8
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I8
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I8
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01f1: Expected Obj, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected Obj, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_032c: Expected Obj, but got I
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_046e: Expected I, but got Obj
		//IL_03e9: Expected Obj, but got I
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = 0 / 864000000000L;
		if ((nint)obj3 >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj4 = 0 / 864000000000L;
			object obj5 = obj + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj6 = 0 / 36000000000L;
			object obj7 = obj6 / 24;
			object obj8 = obj7 * 24;
			object obj9 = obj6 - obj8;
			obj = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			object arg2 = default;
			StringBuilder stringBuilder2 = stringBuilder.AppendFormat("{0}d {1}h", arg, arg2);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj10 = 0 / 36000000000L;
			object obj11 = obj10 / 24;
			object obj12 = obj11 * 24;
			object obj13 = obj10 - obj12;
			if ((nint)obj13 >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				object obj14 = 0 / 36000000000L;
				object obj15 = obj14 / 24;
				object obj16 = obj15 * 24;
				object obj17 = obj14 - obj16;
				object obj18 = obj + 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				object obj19 = (nint)0 / (nint)600000000;
				object obj20 = obj19 / 60;
				object obj21 = obj20 * 60;
				object obj22 = obj19 - obj21;
				obj = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg3 = default;
				object arg4 = default;
				StringBuilder stringBuilder3 = stringBuilder.AppendFormat("{0}h {1}m", arg3, arg4);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				object obj23 = (nint)0 / (nint)600000000;
				object obj24 = obj23 / 60;
				object obj25 = obj24 * 60;
				object obj26 = obj23 - obj25;
				if ((nint)obj26 >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					object obj27 = (nint)0 / (nint)600000000;
					object obj28 = obj27 / 60;
					object obj29 = obj28 * 60;
					object obj30 = obj27 - obj29;
					object obj31 = obj + 4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					object obj32 = (nint)0 / (nint)10000000;
					object obj33 = obj32 / 60;
					object obj34 = obj33 * 60;
					object obj35 = obj32 - obj34;
					obj = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object arg5 = default;
					object arg6 = default;
					StringBuilder stringBuilder4 = stringBuilder.AppendFormat("{0}m {1}s", arg5, arg6);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					double num = 0.0 * 1E-07;
					if (num > 0.0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						object obj36 = (nint)0 / (nint)10000000;
						object obj37 = obj36 / 60;
						object obj38 = obj37 * 60;
						object obj39 = obj36 - obj38;
						object obj40 = obj + 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object arg7 = default;
						StringBuilder stringBuilder5 = stringBuilder.AppendFormat("{0}s", arg7);
					}
					else
					{
						StringBuilder stringBuilder6 = stringBuilder.Append("0s");
					}
				}
			}
		}
		nint num2 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ S1_v9 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}
}
