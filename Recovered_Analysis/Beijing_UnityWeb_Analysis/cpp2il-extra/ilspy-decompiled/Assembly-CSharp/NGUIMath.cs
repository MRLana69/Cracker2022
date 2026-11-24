using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using InApp;
using Info;
using SYBO.Common.Math;
using SYBO.Components.Analytics.Integration;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.UI;

public static class NGUIMath
{
	public static float Lerp(float from, float to, float factor)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public static int ClampIndex(int val, int max)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		//IL_00b2: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Localization.Format((string)val, null);
		return (int)(text + max);
	}

	public static int RepeatIndex(int val, int max)
	{
		if (val > -1)
		{
			if (val < max)
			{
				return val;
			}
			return max - 1;
		}
		return 0;
	}

	public static float WrapAngle(float angle)
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Mathf.RoundToInt(angle);
		float num4 = angle - (float)num3;
		if (num4 < 0.5f)
		{
			return 0f;
		}
		return 1f;
	}

	public static float Wrap01(float val)
	{
		float num = default;
		while (num > 180f)
		{
			float num2 = num - 360f;
			num = num2;
		}
		while (num < -180f)
		{
			float num3 = num + 360f;
			num = num3;
		}
		return num;
	}

	public static int HexToDecimal(char ch)
	{
		//IL_022b: Expected I, but got Obj
		//IL_0241: Expected Obj, but got I
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0282: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_0061: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_019d: Expected I, but got Obj
		//IL_01b3: Expected Obj, but got I
		//IL_0142: Expected I, but got Obj
		//IL_0267: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I
		//IL_032b: Expected Obj, but got I
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
		//IL_00b4: Expected I, but got Obj
		//IL_01de: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v52 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Localization.localizationHasBeenSet ? 1u : 0u) != 0)
		{
			int num3 = UnityEngine.Random.Range((int)"Language", (int)"English");
			nint num4 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v14 (Il2CppClass<Localization>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v19 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Localization.Load((TextAsset)num3);
		}
		nint num6 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v16 (Il2CppClass<Localization>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v43 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v3 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v4+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S2_v5+44]");
		object obj6 = 0;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v87 @ S3_v4 (should have been resolved before IL gen)");
		object obj9 = default;
		if ((nint)obj9 > -1)
		{
			return 1;
		}
		nint num9 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v27 (Il2CppClass<Localization>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num10 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v36 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S2_v9 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S2_v10+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S2_v11+44]");
		object obj13 = 0;
		object obj14 = obj13 & 0x1FFF;
		object obj15 = obj14 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v113 @ S3_v9 (should have been resolved before IL gen)");
		object obj16 = default;
		return ((nint)obj16 > -1) ? 1 : 0;
	}

	public static char DecimalToHexChar(int num)
	{
		//IL_0330: Expected Obj, but got I4
		int num2 = num & 0xFFFF;
		char c = (char)(num2 - 48);
		if (num2 != 48 && c != '\u0001' && c != '\u0002' && c != '\u0003' && c != '\u0004' && c != '\u0005' && c != '\u0006' && c != '\a' && c != '\b' && c != '\t')
		{
			switch (c)
			{
			case '\n':
			case '\v':
			case '\f':
			case '\r':
			case '\u000e':
			case '\u000f':
			case '\u0010':
				return '\u000f';
			case '\u0011':
				return '\n';
			case '\u0012':
				return '\v';
			case '\u0013':
				return '\f';
			case '\u0014':
				return '\r';
			case '\u0015':
				return '\u000e';
			default:
			{
				object obj = num2 - 97;
				if (num2 != 97)
				{
					if ((nint)obj != 1)
					{
						if ((nint)obj != 2)
						{
							if ((nint)obj != 3)
							{
								if ((nint)obj != 4)
								{
									if ((nint)obj == 5)
									{
										break;
									}
									return '\u000f';
								}
								return '\u000e';
							}
							return '\r';
						}
						return '\f';
					}
					return '\v';
				}
				return '\n';
			}
			case '\u0016':
				break;
			}
			return '\u000f';
		}
		return c;
	}

	public static string DecimalToHex8(int num)
	{
		//IL_008d: Expected Obj, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_0031: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		if (num > 15)
		{
			return (string)70;
		}
		if (num < 10)
		{
			object obj = num + 48;
			return (string)(obj & 0xFFFF);
		}
		object obj2 = num + 55;
		return (string)(obj2 & 0xFFFF);
	}

	public static string DecimalToHex24(int num)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0023: Expected Obj, but got I4
		object obj = num;
		int num2 = num & 0xFF;
		obj = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63D");
		string result = default;
		return result;
	}

	public static string DecimalToHex32(int num)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0023: Expected Obj, but got I4
		object obj = num;
		int num2 = num & 0xFFFFFF;
		obj = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63D");
		string result = default;
		return result;
	}

	public static int ColorToInt(Color c)
	{
		//IL_0008: Expected Obj, but got VT
		object obj = c;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63D");
		int result = default;
		return result;
	}

	public static Color IntToColor(int val)
	{
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_02b4: Expected I, but got Obj
		//IL_02ca: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_0203: Expected VT, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_00df: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I
		//IL_0195: Expected VT, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_0079: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		bool flag = (nint)obj7 > -1;
		nint num4 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v6 (Il2CppClass<Localization>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		bool flag2 = obj8 != null;
		if (flag)
		{
			if (flag2)
			{
				nint num5 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v34 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S4_v10 (Il2CppMethodInfo)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S4_v11+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v12+48]");
			Color result = (Color)0;
			object obj11 = result.r & 0x7FF;
			object obj12 = obj11 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S5_v9 (should have been resolved before IL gen)");
			return result;
		}
		if (flag2)
		{
			nint num7 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v22 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S4_v5 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S4_v6+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S4_v7+48]");
		Color result2 = (Color)0;
		object obj15 = result2.r & 0x7FF;
		object obj16 = obj15 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v118 @ S5_v5 (should have been resolved before IL gen)");
		return result2;
	}

	public static string IntToBinary(int val, int bits)
	{
		//IL_00ba: Expected Obj, but got I4
		string result;
		if (bits < 1)
		{
			result = null;
		}
		else
		{
			int num = default;
			while (num <= -1)
			{
				int num2 = bits + num;
				num = num2;
			}
			while (true)
			{
				bool flag = num >= bits;
				bool flag2 = !flag;
				result = (string)num;
				if (flag2)
				{
					break;
				}
				int num3 = num - bits;
				num = num3;
			}
		}
		return result;
	}

	public unsafe static Color HexToColor(uint val)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got F4
		//IL_00f3: Expected F4, but got Obj
		//IL_00ee: Expected native int or pointer, but got VT
		//IL_0108: Expected F4, but got I
		//IL_0103: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		_ = 0;
		Color yellow = Color.yellow;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		int num = (int)val >> 24;
		float num2 = 1f / 255f * (float)num;
		obj = num2;
		int num3 = (int)val >> 16;
		int num4 = num3 & 0xFF;
		float num5 = 1f / 255f * (float)num4;
		int num6 = (int)val >> 8;
		int num7 = num6 & 0xFF;
		float num8 = 1f / 255f * (float)num7;
		int num9 = (int)(val & 0xFF);
		float num10 = 1f / 255f * (float)num9;
		Color color = default;
		((Color*)(nint)color)->r = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		((Color*)(nint)color)->b = 0f;
		return color;
	}

	public static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
		//IL_001f: Expected Obj, but got VT
		//IL_001f: Expected Obj, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_003a: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+3C]");
		((List<string>)0).Add((string)rect);
		Rect rect2 = default;
		object obj = rect2 - -64;
		((List<object>)obj).Add((object)width);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+44]");
		((List<Action>)0).Add((Action)height);
		return rect2;
	}

	public unsafe static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		//IL_0039: Expected Obj, but got I
		//IL_0046: Invalid comparison between F4 and VT
		//IL_01f9: Invalid comparison between F4 and I4
		//IL_0095: Expected native int or pointer, but got VT
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+14]");
		Rect rect2 = default;
		float num = 0f + rect2.m_Height;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+10]");
		object obj = num2 + 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)rect2.m_Height) < System.Runtime.CompilerServices.Unsafe.As<Rect, UIntPtr>(ref rect))
		{
			float num3 = (float)rect - rect2.m_Height;
			float height2 = num3 + rect2.m_Height;
			((Rect*)(nint)rect2)->m_Height = height2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+14]");
			float num4 = 0f - num3;
			float num5 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+1C]");
			float num6 = num5 + 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+10]");
		if ((nint)0 < (nint)width)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+10]");
			object obj2 = (nint)width - (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+10]");
			object obj3 = obj2 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+18]");
			object obj4 = 0 - obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+20]");
			object obj5 = obj2 + 0;
		}
		if (num > (float)height)
		{
			float num7 = num - (float)height;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+14]");
			float num8 = 0f - num7;
		}
		if ((nint)obj > (round ? 1 : 0))
		{
			object obj6 = obj - round;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Rect)+18]");
			object obj7 = 0 - obj6;
		}
		return rect2;
	}

	public static Rect MakePixelPerfect(Rect rect)
	{
		//IL_0009: Expected I4, but got VT
		Color color = HexToColor((uint)(int)rect);
		Rect result = default;
		return result;
	}

	public unsafe static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		//IL_000d: Expected Obj, but got F4
		//IL_018c: Expected F4, but got Obj
		//IL_0187: Expected native int or pointer, but got VT
		//IL_01a1: Expected F4, but got I
		//IL_019c: Expected native int or pointer, but got VT
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected I4, but got Unknown
		//IL_0080: Expected Obj, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected I4, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got I
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected I4, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected I4, but got Unknown
		object obj = rect.m_XMin;
		_ = rect.m_Width;
		if (width != 0 && height != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			object obj2 = 0 + obj;
			int num = (int)(rect.m_XMin / width);
			obj = num;
			object obj3 = obj2 - obj;
			float num2 = rect.m_Width + rect.m_XMin;
			int num3 = (int)(num2 / width);
			object obj4 = num3 - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj5 = num4 + 0;
			float num5 = rect.m_Height + rect.m_YMin;
			int num6 = (int)(num5 / height);
			float num7 = 1f - (float)num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj6 = obj5 - 0;
			int num8 = (int)(rect.m_YMin / height);
			float num9 = 1f - (float)num8;
			float num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num11 = num10 - 0f;
		}
		Rect rect2 = default;
		((Rect*)(nint)rect2)->m_XMin = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Rect*)(nint)rect2)->m_Width = 0f;
		return rect2;
	}

	public unsafe static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		//IL_026a: Expected Obj, but got F4
		//IL_0280: Invalid comparison between VT and I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got F4
		//IL_01be: Expected Obj, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0388: Expected F4, but got Obj
		//IL_0383: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		object obj = minRect.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minRect @ L1 (UnityEngine.Vector2)+8]");
		_ = 0;
		if (maxArea != (Vector2)(object)0)
		{
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v53 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float width = minRect.x * (float)maxRect;
			GUILayoutOption gUILayoutOption = GUILayout.Width(width);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			object obj3 = 0 + obj;
			obj = gUILayoutOption;
			object obj4 = obj3 - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minRect @ L1 (UnityEngine.Vector2)+8]");
			float num3 = 0f + minRect.x;
			float width2 = num3 * (float)maxRect;
			GUILayoutOption gUILayoutOption2 = GUILayout.Width(width2);
			object obj5 = (object)gUILayoutOption2 - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minRect @ L1 (UnityEngine.Vector2)+C]");
			float num4 = 0f + minRect.y;
			float num5 = 1f - num4;
			float width3 = num5 * (float)minArea;
			GUILayoutOption gUILayoutOption3 = GUILayout.Width(width3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj6 = num6 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj7 = obj6 - 0;
			float num7 = 1f - minRect.y;
			float width4 = num7 * (float)minArea;
			GUILayoutOption gUILayoutOption4 = GUILayout.Width(width4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj8 = gUILayoutOption4 - 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			object obj9 = 0 + obj;
			float num8 = minRect.x * (float)maxRect;
			obj = num8;
			object obj10 = obj9 - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minRect @ L1 (UnityEngine.Vector2)+8]");
			float num9 = 0f + minRect.x;
			float num10 = num9 * (float)maxRect;
			float num11 = num10 - (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj11 = num12 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [minRect @ L1 (UnityEngine.Vector2)+C]");
			float num13 = 0f + minRect.y;
			float num14 = 1f - num13;
			float num15 = num14 * (float)minArea;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj12 = obj11 - 0;
			float num16 = 1f - minRect.y;
			float num17 = num16 * (float)minArea;
			float num18 = num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			float num19 = num18 - 0f;
		}
		Vector2 vector = default;
		((Vector2*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return vector;
	}

	public unsafe static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
		//IL_00dc: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_0118: Expected F4, but got Obj
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0143: Expected I, but got Obj
		//IL_0161: Expected F4, but got I
		//IL_0182: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_005f: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00bf: Expected VT, but got Obj
		//IL_00ba: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v33 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width((float)trans);
		object obj2 = (nint)((UnityEngine.Object)trans).m_CachedPtr + trans;
		Transform transform = (Transform)(object)gUILayoutOption;
		nint cachedPtr = obj2 - (object)trans;
		((UnityEngine.Object)trans).m_CachedPtr = cachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L1 (UnityEngine.Transform)+4]");
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L1 (UnityEngine.Transform)+C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L1 (UnityEngine.Transform)+4]");
		object obj3 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L1 (UnityEngine.Transform)+4]");
		object obj4 = obj3 - 0;
		float width = (float)(nint)((UnityEngine.Object)trans).m_CachedPtr + (float)trans;
		GUILayoutOption gUILayoutOption3 = GUILayout.Width(width);
		nint cachedPtr2 = (object)gUILayoutOption3 - (object)trans;
		((UnityEngine.Object)trans).m_CachedPtr = cachedPtr2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L1 (UnityEngine.Transform)+C]");
		float num4 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L1 (UnityEngine.Transform)+4]");
		float width2 = num4 + 0f;
		GUILayoutOption gUILayoutOption4 = GUILayout.Width(width2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trans @ L1 (UnityEngine.Transform)+4]");
		object obj5 = gUILayoutOption4 - 0;
		Bounds bounds = default;
		((Bounds*)(nint)bounds)->m_Center = (Vector3)trans;
		_ = ((UnityEngine.Object)trans).m_CachedPtr;
		return bounds;
	}

	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_050e: Expected Obj, but got I4
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_052b: Expected Obj, but got I4
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0548: Expected Obj, but got I4
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_0565: Expected Obj, but got I4
		//IL_057f: Expected I, but got Obj
		//IL_0595: Expected Obj, but got I
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected Obj, but got Unknown
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected Obj, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected Obj, but got Unknown
		//IL_0477: Expected I, but got Obj
		//IL_048d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_07d9: Expected VT, but got I4
		//IL_07d4: Expected native int or pointer, but got VT
		//IL_0068: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_04b8: Expected I, but got Obj
		//IL_0170: Expected Obj, but got F4
		//IL_0185: Expected Obj, but got F4
		//IL_019a: Expected Obj, but got I4
		//IL_00d9: Expected VT, but got Obj
		//IL_00e7: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_03bd: Expected I, but got Obj
		//IL_03d3: Expected Obj, but got I
		//IL_05c9: Expected VT, but got I4
		//IL_05c4: Expected native int or pointer, but got VT
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_0128: Expected I, but got Obj
		//IL_044a: Expected VT, but got Obj
		//IL_0445: Expected native int or pointer, but got VT
		//IL_03fe: Expected I, but got Obj
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_0970: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 60;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v188 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 96;
		object obj8 = obj2 + 84;
		Transform transform = (Transform)(obj2 + 12);
		Bounds bounds = default;
		if (((ComputeShader)(object)trans).FindKernel((string)null) != 0)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v5 (Il2CppMethodInfo)+18]");
			object obj9 = 0;
			object obj10 = obj9;
			object obj11 = obj10 & 0x1FFF;
			object obj12 = obj11 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v289 @ S3_v10 (should have been resolved before IL gen)");
			object obj14 = default;
			object obj13 = obj14 + 12;
			if (obj13 == null)
			{
				transform.position = (Vector3)trans;
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v171 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num5 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v184 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 one = Vector3.one;
				((Bounds*)(nint)bounds)->m_Center = (Vector3)0;
				_ = 0;
				_ = 0;
				obj8 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
			}
			else
			{
				obj = float.MaxValue;
				_ = float.MaxValue;
				_ = float.MaxValue;
				obj3 = float.MinValue;
				_ = float.MinValue;
				_ = float.MinValue;
				object obj16 = 0;
				object obj22 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
				{
					object obj17 = obj14 + 16;
					object obj18 = obj16 << 2;
					object obj19 = obj17 + obj18;
					if (((Behaviour)obj19).isActiveAndEnabled)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj20 = 0;
						while ((nint)obj20 <= 3)
						{
							object obj21 = obj22 + 16;
							object obj23 = obj20 * 12;
							object obj24 = obj21 + obj23;
							obj7 = obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S1_v84+8]");
							_ = 0;
							obj4 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+8]");
							_ = 0;
							obj8 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+8]");
							_ = 0;
							transform = (Transform)obj3;
							Transform transform2 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
							((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) > System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform))
							{
								obj7 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
								_ = 0;
								obj3 = obj7;
							}
							obj7 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
							_ = 0;
							obj8 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+4]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v29+4]");
							if (num6 > 0)
							{
								obj7 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+4]");
								_ = 0;
							}
							obj7 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
							_ = 0;
							obj8 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+8]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v29+8]");
							if (num7 > 0)
							{
								obj7 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+8]");
								_ = 0;
							}
							obj7 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
							_ = 0;
							obj8 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
							_ = 0;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
							{
								obj7 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
								_ = 0;
								obj = obj7;
							}
							obj7 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
							_ = 0;
							obj8 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+4]");
							nint num8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v29+4]");
							if (num8 < 0)
							{
								obj7 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+4]");
								_ = 0;
							}
							obj7 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
							_ = 0;
							obj8 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+8]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v29+8]");
							if (num9 < 0)
							{
								obj7 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+8]");
								_ = 0;
							}
							object obj25 = obj20 + 1;
							obj12 = 12;
							obj20 = obj25;
						}
					}
					object obj26 = obj16 + 1;
					obj16 = obj26;
				}
				transform = (Transform)obj;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				nint num10 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v75 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				if (obj27 != null)
				{
					nint num11 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v91 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 one2 = Vector3.one;
				obj8 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
				obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
				((Bounds*)(nint)bounds)->m_Center = (Vector3)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+10]");
				_ = 0;
			}
		}
		else
		{
			nint num12 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num13 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v51 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one3 = Vector3.one;
			Vector3 one4 = Vector3.one;
			((Bounds*)(nint)bounds)->m_Center = (Vector3)0;
			_ = 0;
			_ = 0;
			obj8 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
		}
		return bounds;
	}

	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected Ref, but got Unknown
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected Ref, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected Obj, but got Unknown
		//IL_0737: Expected Obj, but got I4
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_075a: Expected Obj, but got I4
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got Unknown
		//IL_0771: Expected Obj, but got I4
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_079b: Expected I, but got Obj
		//IL_07b1: Expected Obj, but got I
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected Obj, but got Unknown
		//IL_07e5: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_02a1: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I
		//IL_094c: Expected I, but got Obj
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_02e2: Expected I, but got Obj
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_0824: Expected I, but got Obj
		//IL_083a: Expected Obj, but got I
		//IL_01b4: Expected I, but got Obj
		//IL_0213: Expected I, but got Obj
		//IL_0229: Expected Obj, but got I
		//IL_08d1: Expected Obj, but got I
		//IL_08e1: Expected Obj, but got I
		//IL_08f1: Expected Obj, but got I
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Obj, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected Obj, but got Unknown
		//IL_0254: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 80;
		ref string[] reference = ref *(string[]*)(obj2 + 76);
		reference = ref *(string[]*)null;
		ref string[] reference2 = ref *(string[]*)(obj2 + 72);
		reference2 = ref *(string[]*)null;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 40;
		obj5 = 0;
		object obj6 = obj2 + 32;
		obj6 = obj;
		_ = -1;
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (Il2CppClass<Localization>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v288 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string language = Localization.language;
		bool flag = language == null;
		bool flag2 = !flag;
		string text = language;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		object obj8 = text + 12;
		object obj9 = 0;
		string text2 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
			{
				object obj10 = text + 16;
				object obj11 = obj9 << 2;
				object obj12 = obj10 + obj11;
				if (!((string)obj12 == text2))
				{
					break;
				}
				object obj13 = obj9 + 1;
				obj9 = obj13;
				continue;
			}
			nint num3 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v45 (Il2CppClass<Localization>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num4 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v210 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v50 (Il2CppClass<Localization>)+5C]");
			ref string[] array = ref *(string[]*)((nint)0 + (nint)12);
			string[] mLanguages = Localization.mLanguages;
			int newSize = mLanguages.Length + 1;
			Array.Resize(ref array, newSize);
			throw new ArrayTypeMismatchException();
		}
		nint num6 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v222 (Il2CppClass<Localization>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num7 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v257 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!Localization.mDictionary.TryGetValue((string)(object)trans, out reference2))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj16 = default;
			reference2 = ref *(string[]*)obj16;
			nint num8 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v239 (Il2CppClass<Localization>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num9 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v251 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S4_v19 (Il2CppMethodInfo)+C]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S4_v20+60]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S4_v21+48]");
			object obj20 = 0;
			object obj21 = obj20 & 0x7FF;
			object obj22 = obj21 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v265 @ S5_v13 (should have been resolved before IL gen)");
			throw new ArrayTypeMismatchException();
		}
		throw new ArrayTypeMismatchException();
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content)
	{
		//IL_0016: Expected Obj, but got I4
		//IL_0016: Expected VT, but got Obj
		Vector3 vector = WorldToLocalPoint((Vector3)relativeTo, (Camera)(object)relativeTo, (Camera)(object)content, (Transform)1);
		Bounds result = default;
		return result;
	}

	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerChildren = true)
	{
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_023d: Expected Obj, but got I4
		//IL_024b: Expected I, but got Obj
		//IL_0261: Expected Obj, but got I
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_03b8: Expected Obj, but got I
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03d3: Expected Obj, but got I4
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_03ee: Expected Obj, but got I4
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_0416: Expected Obj, but got I4
		//IL_0423: Expected Obj, but got I4
		//IL_0440: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_047c: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected I4, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected I4, but got Unknown
		//IL_02ba: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_04b8: Expected Obj, but got I4
		//IL_0107: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I4
		//IL_014b: Expected Obj, but got I4
		//IL_04fc: Expected VT, but got Obj
		//IL_04f7: Expected native int or pointer, but got VT
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01ef: Expected Obj, but got I4
		//IL_020c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - -64;
		obj = 0;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v100 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		object obj4 = obj2 + 56;
		obj4 = content;
		object obj5 = obj2 + 48;
		obj5 = relativeTo;
		object obj6 = obj4 - obj5;
		object obj7 = obj2 + 40;
		obj7 = content;
		object obj8 = obj2 + 32;
		obj8 = relativeTo;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v22+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v17+4]");
		object obj9 = num3 - 0;
		object obj10 = obj2 + 24;
		obj10 = ((bool*)(considerChildren ? 1 : 0))->m_value;
		object obj11 = obj2 + 16;
		obj11 = ((bool*)(considerInactive ? 1 : 0))->m_value;
		object obj12 = obj10 - obj11;
		object obj13 = obj2 + 8;
		obj13 = ((bool*)(considerChildren ? 1 : 0))->m_value;
		obj2 = ((bool*)(considerInactive ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v32+4]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		object obj14 = num4 - 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
		{
			object obj15 = obj6 - obj12;
			bool value = (byte)(((bool*)(considerInactive ? 1 : 0))->m_value - obj15) != 0;
			((bool*)(considerInactive ? 1 : 0))->m_value = value;
			bool value2 = (byte)(int)(((bool*)(considerChildren ? 1 : 0))->m_value + obj15) != 0;
			((bool*)(considerChildren ? 1 : 0))->m_value = value2;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
		{
			object obj16 = (considerInactive ? 1 : 0) + 4;
			object obj17 = obj9 - obj14;
			object obj18 = obj16 - obj17;
			obj16 = obj18;
			object obj19 = (considerChildren ? 1 : 0) + 4;
			object obj20 = obj19 + obj17;
			obj19 = obj20;
		}
		obj4 = relativeTo;
		obj5 = ((bool*)(considerInactive ? 1 : 0))->m_value;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			obj4 = ((bool*)(considerInactive ? 1 : 0))->m_value;
			obj5 = relativeTo;
			object obj21 = obj4 - obj5;
			object obj22 = obj + obj21;
			obj = obj22;
		}
		obj4 = content;
		obj5 = ((bool*)(considerChildren ? 1 : 0))->m_value;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			obj4 = content;
			obj5 = ((bool*)(considerChildren ? 1 : 0))->m_value;
			object obj23 = obj4 - obj5;
			object obj24 = obj - obj23;
			obj = obj24;
		}
		obj4 = relativeTo;
		obj5 = ((bool*)(considerInactive ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17+4]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11+4]");
		if (num5 < 0)
		{
			object obj25 = obj + 4;
			obj4 = ((bool*)(considerInactive ? 1 : 0))->m_value;
			obj5 = relativeTo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17+4]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11+4]");
			object obj26 = num6 - 0;
			object obj27 = obj25 + obj26;
			obj25 = obj27;
		}
		obj4 = content;
		obj5 = ((bool*)(considerChildren ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17+4]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11+4]");
		if (num7 > 0)
		{
			object obj28 = obj + 4;
			obj4 = content;
			obj5 = ((bool*)(considerChildren ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17+4]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11+4]");
			object obj29 = num8 - 0;
			object obj30 = obj28 - obj29;
			obj28 = obj30;
		}
		Bounds bounds = default;
		((Bounds*)(nint)bounds)->m_Center = (Vector3)obj;
		return bounds;
	}

	private unsafe static void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerChildren)
	{
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I4
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02dd: Expected Obj, but got I4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_02fa: Expected Obj, but got I4
		//IL_030e: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected VT, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected VT, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Ref, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Ref, but got Unknown
		//IL_04ec: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got VT
		//IL_0094: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I
		//IL_034e: Expected F4, but got Obj
		//IL_0349: Expected native int or pointer, but got VT
		//IL_0363: Expected F4, but got I
		//IL_035e: Expected native int or pointer, but got VT
		//IL_0370: Expected F4, but got Obj
		//IL_036b: Expected native int or pointer, but got VT
		//IL_0385: Expected F4, but got I
		//IL_0380: Expected native int or pointer, but got VT
		//IL_03a4: Expected I, but got Obj
		//IL_03ba: Expected Obj, but got I
		//IL_03e4: Expected F4, but got Obj
		//IL_03df: Expected native int or pointer, but got VT
		//IL_03f9: Expected F4, but got I
		//IL_03f4: Expected native int or pointer, but got VT
		//IL_0406: Expected Ref, but got VT
		//IL_0413: Expected Obj, but got VT
		//IL_0432: Expected F4, but got I4
		//IL_042d: Expected native int or pointer, but got VT
		//IL_0447: Expected F4, but got I
		//IL_0442: Expected native int or pointer, but got VT
		//IL_0454: Expected Ref, but got VT
		//IL_0461: Expected Obj, but got VT
		//IL_0477: Expected Obj, but got I4
		//IL_00d5: Expected I, but got Obj
		//IL_016e: Expected F4, but got Obj
		//IL_0169: Expected native int or pointer, but got VT
		//IL_0183: Expected F4, but got I
		//IL_017e: Expected native int or pointer, but got VT
		//IL_018c: Expected Obj, but got VT
		//IL_019d: Expected F4, but got Obj
		//IL_0198: Expected native int or pointer, but got VT
		//IL_01b2: Expected F4, but got I
		//IL_01ad: Expected native int or pointer, but got VT
		//IL_01cf: Expected I4, but got VT
		//IL_01cf: Expected Obj, but got I
		//IL_0122: Expected I, but got Obj
		//IL_01e1: Expected Obj, but got VT
		//IL_0200: Expected F4, but got VT
		//IL_01fb: Expected native int or pointer, but got VT
		//IL_0215: Expected F4, but got I
		//IL_0210: Expected native int or pointer, but got VT
		//IL_0227: Expected F4, but got VT
		//IL_0222: Expected native int or pointer, but got VT
		//IL_023c: Expected F4, but got I
		//IL_0237: Expected native int or pointer, but got VT
		//IL_026b: Expected Obj, but got I4
		//IL_0281: Expected F4, but got Obj
		//IL_027c: Expected native int or pointer, but got VT
		//IL_0296: Expected F4, but got I
		//IL_0291: Expected native int or pointer, but got VT
		//IL_029f: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 112;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 96;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 84;
		obj4 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 144);
		Vector3 vector2 = (Vector3)(obj2 + 128);
		object obj6 = obj2 + 72;
		object obj7 = obj2 + 60;
		object obj8 = obj2 + 48;
		ref Quaternion reference = ref *(Quaternion*)(obj2 + 32);
		ref Quaternion reference2 = ref *(Quaternion*)(obj2 + 16);
		if (((ComputeShader)considerInactive).FindKernel(null) == 0)
		{
			return;
		}
		obj6 = ((bool*)(isRoot ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isRoot @ L2 (System.Boolean)+8]");
		_ = 0;
		obj7 = vMax;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vMax @ L5 (UnityEngine.Vector3&)+8]");
		_ = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v45 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v88 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v29+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector3 = vector2 - vector;
		nint num5 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v55 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v84 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v31+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector);
		obj = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (((bool*)(isRoot ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isRoot @ L2 (System.Boolean)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion.Inverse_Injected(ref reference2, out *(Quaternion*)vector);
		obj3 = reference2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		int layer = ((GameObject)considerInactive).layer;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 localScale = ((Transform)vector).localScale;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [content @ L0 (UnityEngine.Transform)+48]");
		((CoinBoxSizer)0).EnableElements((byte)(int)vector != 0, (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref isSet) != 0, considerChildren);
		obj4 = toLocal;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [toLocal @ L3 (UnityEngine.Matrix4x4&)+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)toLocal;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [toLocal @ L3 (UnityEngine.Matrix4x4&)+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)vMin;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vMin @ L4 (UnityEngine.Vector3&)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector4 = vector2 - vector;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		int layer2 = ((GameObject)considerInactive).layer;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
	}

	public unsafe static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		//IL_01b4: Expected I, but got Obj
		//IL_01ca: Expected Obj, but got I
		//IL_023e: Expected Obj, but got Ref
		//IL_025f: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got Ref
		//IL_0087: Expected VT, but got Obj
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_021e: Expected Obj, but got Ref
		//IL_022b: Expected Obj, but got Ref
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected I4, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected I4, but got Unknown
		//IL_00e4: Expected VT, but got Obj
		//IL_0193: Expected Obj, but got Ref
		//IL_01a1: Expected VT, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((ComputeShader)System.Runtime.CompilerServices.Unsafe.AsPointer(ref velocity)).FindKernel(null);
		bool flag = num3 == 0;
		Vector3 result = (Vector3)typeof(UnityEngine.Object);
		if (!flag)
		{
			TransparencySortMode transparencySortMode = ((Camera)System.Runtime.CompilerServices.Unsafe.AsPointer(ref velocity)).transparencySortMode;
			bool flag2 = transparencySortMode == TransparencySortMode.Default;
			bool flag3 = !flag2;
			result = (Vector3)typeof(UnityEngine.Object);
			if (!flag3)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					Vector3 vector = (Vector3)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v29 (UnityEngine.Vector3)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num5 = strength * 0.5f;
				float num6 = num5 / deltaTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122EE");
				int pixelHeight = ((Camera)System.Runtime.CompilerServices.Unsafe.AsPointer(ref velocity)).pixelHeight;
				RenderTexture targetTexture = ((Camera)System.Runtime.CompilerServices.Unsafe.AsPointer(ref velocity)).targetTexture;
				int num7 = pixelHeight / targetTexture;
				object obj3 = default;
				float num8 = (float)obj3 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E9");
				object obj4 = default;
				int num9 = obj4 / num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122EE");
				object obj5 = default;
				float num10 = (float)obj5 * 2f;
				float orthographicSize = num10 * 57.29578f;
				((Camera)System.Runtime.CompilerServices.Unsafe.AsPointer(ref velocity)).orthographicSize = orthographicSize;
				result = (Vector3)typeof(Mathf);
			}
		}
		return result;
	}

	public unsafe static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected VT, but got Unknown
		//IL_0161: Expected F4, but got Obj
		//IL_015c: Expected native int or pointer, but got VT
		//IL_0176: Expected F4, but got I
		//IL_0171: Expected native int or pointer, but got VT
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_01c6: Expected F4, but got VT
		//IL_01c1: Expected native int or pointer, but got VT
		//IL_01db: Expected F4, but got I
		//IL_01d6: Expected native int or pointer, but got VT
		//IL_020e: Expected F4, but got Obj
		//IL_0209: Expected native int or pointer, but got VT
		//IL_0223: Expected F4, but got I
		//IL_021e: Expected native int or pointer, but got VT
		//IL_00a1: Expected I, but got Obj
		float num = strength * 0.001f;
		float num2 = 1f - num;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v45 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float width = deltaTime * 1000f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122F6");
		object obj3 = default;
		object obj2 = obj3 + 24;
		obj2 = velocity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [velocity @ L1 (UnityEngine.Vector2&)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122F4");
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj3 + 36);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v18+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj5 = obj3 + 12;
		float num8 = default;
		float num7 = num8 - 1f;
		object obj6 = default;
		float num9 = num7 / (float)obj6;
		Vector3 vector2 = vector / num9;
		((Vector3*)(nint)vector)->x = (float)velocity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [velocity @ L1 (UnityEngine.Vector2&)+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector3 = vector / num8;
		ref Vector2 reference = ref *(Vector2*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v31+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector4 = vector / 0.06f;
		Vector2 result = default;
		return result;
	}

	public static float SpringLerp(float strength, float deltaTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Vector2 result = default;
		return result;
	}

	public unsafe static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bf: Expected Obj, but got F4
		//IL_00cc: Expected Obj, but got F4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected I4, but got Unknown
		//IL_00fd: Expected I4, but got Obj
		//IL_0112: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		float pos = MathUtil.SnapValueStep(strength, deltaTime);
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v28 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = from.x;
		obj3 = to.x;
		RectTransform rectTransform = (RectTransform)(obj3 + 16);
		rectTransform = (RectTransform)obj2;
		int num3 = obj3 + 24;
		((int*)num3)->m_value = (int)obj3;
		Vector3 vector = default;
		((LayoutGroup)vector).SetChildAlongAxis(rectTransform, num3, pos);
		return vector;
	}

	public unsafe static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got F4
		//IL_0084: Expected Obj, but got F4
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected VT, but got Unknown
		//IL_00fb: Expected F4, but got Obj
		//IL_00f6: Expected native int or pointer, but got VT
		//IL_0110: Expected F4, but got I
		//IL_010b: Expected native int or pointer, but got VT
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected VT, but got Unknown
		//IL_012b: Expected F4, but got Obj
		//IL_0126: Expected native int or pointer, but got VT
		//IL_0140: Expected F4, but got I
		//IL_013b: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = from.x;
		_ = from.z;
		obj2 = to.x;
		_ = to.z;
		float t = MathUtil.SnapValueStep(strength, deltaTime);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 24);
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 36);
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = Vector3.LerpUnclamped(vector, vector2, t);
		Quaternion result = default;
		return result;
	}

	public static float RotateTowards(float from, float to, float maxAngle)
	{
		float num = 1f - maxAngle;
		float num2 = from * num;
		float num3 = to * maxAngle;
		return num2 + num3;
	}

	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00c5: Expected I4, but got VT
		//IL_00c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float f = (float)a / 2f;
		int num3 = Mathf.RoundToInt(f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [point @ L0 (UnityEngine.Vector2)+18]");
		UIPowerupHelper uIPowerupHelper = ((List<UIPowerupHelper>)0).get_Item((int)b);
		UISprite iconBG = uIPowerupHelper.iconBG;
		return (float)num3 * (float)((UIWidget)iconBG).mHeight;
	}

	public unsafe static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
	{
		//IL_04a1: Expected I, but got Obj
		//IL_04b7: Expected Obj, but got I
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected VT, but got Unknown
		//IL_06f2: Expected Obj, but got Ref
		//IL_0470: Expected Obj, but got F4
		//IL_047d: Expected F4, but got Obj
		//IL_0478: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_04e5: Invalid comparison between I and F4
		//IL_00ff: Invalid comparison between I and F4
		//IL_00a1: Expected I, but got Obj
		//IL_013c: Expected F4, but got I
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_0303: Expected I, but got Obj
		//IL_0319: Expected Obj, but got I
		//IL_063b: Expected F4, but got I
		//IL_063b: Expected F4, but got I
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Unknown
		//IL_067c: Expected F4, but got I
		//IL_067c: Expected F4, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0187: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_0344: Expected I, but got Obj
		//IL_058b: Expected F4, but got Obj
		//IL_058b: Expected F4, but got Obj
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected Obj, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_05bc: Expected F4, but got Obj
		//IL_05bc: Expected F4, but got Obj
		//IL_01c8: Expected I, but got Obj
		//IL_0436: Expected native int or pointer, but got VT
		//IL_03fc: Expected native int or pointer, but got VT
		//IL_02ba: Expected native int or pointer, but got VT
		//IL_0280: Expected native int or pointer, but got VT
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v105 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Vector2 vector = (Vector2)(obj2 + 8);
		if (((ComputeShader)System.Runtime.CompilerServices.Unsafe.AsPointer(ref screenPoints[1])).FindKernel(null) != 0)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v101 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenPoints @ L0 (UnityEngine.Vector2[])+50]");
			float num5;
			if (0f < 0f)
			{
				num5 = 0f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenPoints @ L0 (UnityEngine.Vector2[])+50]");
				if (0f > 1f)
				{
					num5 = 1f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenPoints @ L0 (UnityEngine.Vector2[])+50]");
					num5 = 0f;
				}
			}
			float num6 = num5 * 0.5f;
			float t = 1f - num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj5 = default;
			object obj4 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenPoints @ L0 (UnityEngine.Vector2[])+20]");
			bool flag;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenPoints @ L0 (UnityEngine.Vector2[])+20]");
				flag = (nint)0 == 1;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				object obj6 = obj5 + 40;
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S2_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S2_v30 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num9 = Mathf.LerpUnclamped((float)obj4, (float)obj6, num6);
				object obj8 = obj5 + 16;
				object obj9 = obj5 + 40;
				float num10 = Mathf.LerpUnclamped((float)obj8, (float)obj9, t);
				float num11 = num10 - num9;
				if (num11 == 0f)
				{
					return ((UIProgressBar)(object)screenPoints).alpha;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenPoints @ L0 (UnityEngine.Vector2[])+20]");
				bool flag2;
				if ((nint)0 == 1)
				{
					flag2 = true;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenPoints @ L0 (UnityEngine.Vector2[])+20]");
					flag2 = (nint)0 == 3;
				}
				if (flag2)
				{
					((Vector2*)(nint)vector)->x = mousePos.x;
					float num12 = num10 - vector.x;
					return num12 / num11;
				}
				((Vector2*)(nint)vector)->x = mousePos.x;
				float num13 = vector.x - num9;
				return num13 / num11;
			}
			object obj10 = obj5 + 28;
			nint num14 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S2_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num15 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S2_v17 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v35+4]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v24+4]");
			float num17 = Mathf.LerpUnclamped(num16, 0f, num6);
			object obj12 = obj5 + 52;
			object obj13 = obj5 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v44+4]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v28+4]");
			float num19 = Mathf.LerpUnclamped(num18, 0f, t);
			float num20 = num19 - num17;
			if (num20 == 0f)
			{
				return ((UIProgressBar)(object)screenPoints).alpha;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenPoints @ L0 (UnityEngine.Vector2[])+20]");
			bool flag3;
			if ((nint)0 == 1)
			{
				flag3 = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenPoints @ L0 (UnityEngine.Vector2[])+20]");
				flag3 = (nint)0 == 3;
			}
			if (flag3)
			{
				((Vector2*)(nint)vector)->x = mousePos.x;
				float num21 = num19 - vector.y;
				return num21 / num20;
			}
			((Vector2*)(nint)vector)->x = mousePos.x;
			float num22 = vector.y - num17;
			return num22 / num20;
		}
		obj2 = mousePos.x;
		((Vector2*)(nint)vector)->x = (float)obj2;
		return ((UIScrollBar)(object)screenPoints).LocalToValue(vector);
	}

	public unsafe static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
	{
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0342: Expected Obj, but got I4
		//IL_0350: Expected I, but got Obj
		//IL_0366: Expected Obj, but got I
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Obj, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected Obj, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected Obj, but got Unknown
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected Obj, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected Obj, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected Obj, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Obj, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Obj, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected Obj, but got Unknown
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected Obj, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected Obj, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected Obj, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected Obj, but got Unknown
		//IL_072d: Expected Obj, but got F4
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected VT, but got Unknown
		//IL_0748: Expected F4, but got Obj
		//IL_0743: Expected native int or pointer, but got VT
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected VT, but got Unknown
		//IL_0763: Expected F4, but got Obj
		//IL_075e: Expected native int or pointer, but got VT
		//IL_0782: Expected I, but got Obj
		//IL_0798: Expected Obj, but got I
		//IL_07d1: Expected Obj, but got I
		//IL_07e7: Invalid comparison between Obj and F4
		//IL_0013: Expected I, but got Obj
		//IL_03cc: Expected Obj, but got F4
		//IL_03d9: Expected F4, but got Obj
		//IL_03d4: Expected native int or pointer, but got VT
		//IL_03e6: Expected F4, but got Obj
		//IL_03e1: Expected native int or pointer, but got VT
		//IL_040c: Expected Obj, but got F4
		//IL_0419: Expected F4, but got Obj
		//IL_0414: Expected native int or pointer, but got VT
		//IL_0426: Expected F4, but got Obj
		//IL_0421: Expected native int or pointer, but got VT
		//IL_044c: Expected F4, but got Obj
		//IL_0447: Expected native int or pointer, but got VT
		//IL_0459: Expected F4, but got Obj
		//IL_0454: Expected native int or pointer, but got VT
		//IL_01d0: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_0398: Expected Obj, but got F4
		//IL_03a5: Expected F4, but got Obj
		//IL_03a0: Expected native int or pointer, but got VT
		//IL_03b2: Expected F4, but got Obj
		//IL_03ad: Expected native int or pointer, but got VT
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_056c: Expected Obj, but got F4
		//IL_0579: Expected F4, but got Obj
		//IL_0574: Expected native int or pointer, but got VT
		//IL_0586: Expected F4, but got Obj
		//IL_0581: Expected native int or pointer, but got VT
		//IL_05a4: Expected F4, but got Obj
		//IL_059f: Expected native int or pointer, but got VT
		//IL_05b5: Expected I4, but got VT
		//IL_05c2: Expected Obj, but got F4
		//IL_05cf: Expected F4, but got Obj
		//IL_05ca: Expected native int or pointer, but got VT
		//IL_05dc: Expected F4, but got Obj
		//IL_05d7: Expected native int or pointer, but got VT
		//IL_04e6: Expected Obj, but got F4
		//IL_04f3: Expected F4, but got Obj
		//IL_04ee: Expected native int or pointer, but got VT
		//IL_0500: Expected F4, but got Obj
		//IL_04fb: Expected native int or pointer, but got VT
		//IL_0314: Expected F4, but got Obj
		//IL_030f: Expected native int or pointer, but got VT
		//IL_0321: Expected F4, but got Obj
		//IL_031c: Expected native int or pointer, but got VT
		//IL_02c0: Expected I, but got Obj
		//IL_0545: Expected F4, but got Obj
		//IL_0540: Expected native int or pointer, but got VT
		//IL_0552: Expected F4, but got Obj
		//IL_054d: Expected native int or pointer, but got VT
		//IL_0183: Expected I, but got Obj
		//IL_024f: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v177 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 160;
		object obj6 = obj2 + 152;
		object obj7 = obj2 + 144;
		object obj8 = obj2 + 136;
		object obj9 = obj2 + 128;
		object obj10 = obj2 + 120;
		object obj11 = obj2 + 112;
		object obj12 = obj2 + 104;
		object obj13 = obj2 + 96;
		object obj14 = obj2 + 88;
		object obj15 = obj2 + 80;
		object obj16 = obj2 + 72;
		object obj17 = obj2 - -64;
		object obj18 = obj2 + 56;
		object obj19 = obj2 + 48;
		object obj20 = obj2 + 32;
		Scrollbar scrollbar = (Scrollbar)(obj2 + 16);
		object obj21 = obj2 + 8;
		object obj22 = obj2 + 176;
		obj22 = cam;
		object obj23 = obj2 + 168;
		obj23 = mousePos.x;
		Vector2 vector = (Vector2)(obj2 + 184);
		((Vector2*)(nint)vector)->x = (float)obj22;
		Vector2 vector2 = (Vector2)(obj2 + 192);
		((Vector2*)(nint)vector2)->x = (float)obj23;
		Vector2 vector3 = vector * vector2;
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v69 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		bool flag = obj24 == null;
		object obj25 = obj * obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		object obj26 = num4 * 0;
		object obj27 = obj25 + obj26;
		if (obj27 == (object)0f)
		{
			if (!flag)
			{
				nint num5 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v173 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = worldPoints;
			obj6 = mousePos.x;
			((Vector2*)(nint)vector)->x = (float)obj5;
			((Vector2*)(nint)vector2)->x = (float)obj6;
		}
		else
		{
			if (!flag)
			{
				nint num6 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v162 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj7 = worldPoints;
			obj8 = mousePos.x;
			((Vector2*)(nint)vector)->x = (float)obj7;
			((Vector2*)(nint)vector2)->x = (float)obj8;
			Vector2 vector4 = vector * vector2;
			obj9 = cam;
			obj10 = mousePos.x;
			((Vector2*)(nint)vector)->x = (float)obj9;
			((Vector2*)(nint)vector2)->x = (float)obj10;
			Vector2 vector5 = vector * vector2;
			obj11 = obj4;
			((Vector2*)(nint)vector)->x = (float)obj11;
			((Vector2*)(nint)vector2)->x = (float)obj12;
			float num7 = vector.x * vector2.x;
			float num8 = vector.y * vector2.y;
			float num9 = num7 + num8;
			float num10 = num9 / (float)obj27;
			if (num10 < 0f)
			{
				nint num11 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v146 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num12 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v158 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj13 = worldPoints;
				obj14 = mousePos.x;
				((Vector2*)(nint)vector)->x = (float)obj13;
				((Vector2*)(nint)vector2)->x = (float)obj14;
				Vector2 vector6 = vector * vector2;
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1143A");
				goto IL_0326;
			}
			nint num13 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v107 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			bool flag2 = obj29 == null;
			if (num10 > 1f)
			{
				if (!flag2)
				{
					nint num14 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v141 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj15 = worldPoints;
				obj16 = cam;
				((Vector2*)(nint)vector)->x = (float)obj15;
				((Vector2*)(nint)vector2)->x = (float)obj16;
			}
			else
			{
				if (!flag2)
				{
					nint num15 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v130 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj17 = cam;
				obj18 = mousePos.x;
				((Vector2*)(nint)vector)->x = (float)obj17;
				((Vector2*)(nint)vector2)->x = (float)obj18;
				Vector2 vector7 = vector * vector2;
				((Vector2*)(nint)vector2)->x = (float)obj19;
				scrollbar.Set(num10, (byte)(int)vector2 != 0);
				obj20 = mousePos.x;
				((Vector2*)(nint)vector)->x = (float)obj20;
				((Vector2*)(nint)vector2)->x = (float)scrollbar;
				Vector2 vector8 = vector - vector2;
				obj21 = worldPoints;
				((Vector2*)(nint)vector)->x = (float)obj21;
				((Vector2*)(nint)vector2)->x = (float)obj2;
			}
		}
		Vector2 vector9 = vector * vector2;
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1143A");
		goto IL_0326;
		IL_0326:
		float result = default;
		return result;
	}

	public static Vector2 GetPivotOffset(UIWidget.Pivot pv)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_0043: Expected VT, but got I4
		string tag = ((Component)pv).tag;
		bool activeInHierarchy = ((GameObject)(object)tag).activeInHierarchy;
		Camera uiCam = (Camera)((activeInHierarchy ? 1 : 0) ^ 1);
		Vector3 vector = WorldToLocalPoint((Vector3)pv, (Camera)pv, uiCam, (Transform)1);
		Vector2 result = default;
		return result;
	}

	public static UIWidget.Pivot GetPivot(Vector2 offset)
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got F4
		//IL_011d: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got F4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got F4
		//IL_005f: Expected Obj, but got F4
		//IL_00e2: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		obj = offset.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [offset @ L0 (UnityEngine.Vector2)+8]");
		_ = 0;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v41 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float width = (float)obj * 255f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		object obj4 = obj2 + 32;
		obj4 = offset.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [offset @ L0 (UnityEngine.Vector2)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v16+4]");
		float width2 = 0f * 255f;
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(width2);
		object obj5 = obj2 + 16;
		obj5 = offset.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [offset @ L0 (UnityEngine.Vector2)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v23+8]");
		float width3 = 0f * 255f;
		GUILayoutOption gUILayoutOption3 = GUILayout.Width(width3);
		obj2 = offset.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [offset @ L0 (UnityEngine.Vector2)+8]");
		_ = 0;
		object obj6 = (object)gUILayoutOption2 << 16;
		object obj7 = (object)gUILayoutOption << 24;
		object obj8 = obj6 | obj7;
		object obj9 = (object)gUILayoutOption3 << 8;
		object obj10 = obj8 | obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
		float width4 = 0f * 255f;
		GUILayoutOption gUILayoutOption4 = GUILayout.Width(width4);
		return (UIWidget.Pivot)(obj10 | (object)gUILayoutOption4);
	}

	public static void MoveWidget(UIRect w, float x, float y)
	{
		//IL_000d: Expected I, but got F4
		//IL_001a: Expected Obj, but got F4
		((UnityEngine.Object)w).m_CachedPtr = (IntPtr)x;
		w.leftAnchor = (UIRect.AnchorPoint)y;
	}

	public static void MoveRect(UIRect rect, float x, float y)
	{
		Color color = UIColorPicker.Sample(x, y);
	}

	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static int AdjustByDPI(float height)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0;
	}

	public static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo)
	{
		//IL_002d: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		string tag = relativeTo.tag;
		bool activeInHierarchy = ((GameObject)(object)tag).activeInHierarchy;
		Camera uiCam = (Camera)((activeInHierarchy ? 1 : 0) ^ 1);
		Vector3 vector = WorldToLocalPoint(pos, (Camera)(object)relativeTo, uiCam, (Transform)1);
		Vector2 result = default;
		return result;
	}

	public unsafe static Vector2 ScreenToParentPixels(Vector2 pos, Transform relativeTo)
	{
		//IL_0247: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I
		//IL_0283: Expected Obj, but got I4
		//IL_0295: Expected I, but got Obj
		//IL_02ab: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected VT, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0169: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0354: Expected Obj, but got F4
		//IL_0361: Expected F4, but got Obj
		//IL_035c: Expected native int or pointer, but got VT
		//IL_037b: Expected F4, but got Obj
		//IL_0376: Expected native int or pointer, but got VT
		//IL_0390: Expected F4, but got I
		//IL_038b: Expected native int or pointer, but got VT
		//IL_03ae: Expected F4, but got Obj
		//IL_03a9: Expected native int or pointer, but got VT
		//IL_03c3: Expected F4, but got I
		//IL_03be: Expected native int or pointer, but got VT
		//IL_03d4: Expected Ref, but got VT
		//IL_00ac: Expected F4, but got I4
		//IL_00a7: Expected native int or pointer, but got VT
		//IL_01f6: Expected F4, but got Obj
		//IL_01f1: Expected native int or pointer, but got VT
		//IL_0208: Expected F4, but got I
		//IL_0203: Expected native int or pointer, but got VT
		//IL_01aa: Expected I, but got Obj
		//IL_00db: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_033d: Expected native int or pointer, but got VT
		//IL_011c: Expected I, but got Obj
		string tag = relativeTo.tag;
		bool activeSelf = ((GameObject)(object)tag).activeSelf;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v70 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		Vector4 vector = (Vector4)(obj3 + 44);
		object obj4 = obj3 + 32;
		object obj5 = obj3 + 20;
		Transform transform = (Transform)(obj3 + 8);
		Vector2 vector2 = default;
		if ((UnityEngine.Object)(object)typeName != null)
		{
			((Vector4*)(nint)vector)->x = (activeSelf ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string message = "No camera found for layer " + text;
			nint num5 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v38 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v45 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogAssertion(message);
			((Vector2*)(nint)vector2)->x = pos.x;
		}
		else
		{
			nint num7 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v38 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v54 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = pos.x;
			((Vector4*)(nint)vector)->x = (float)obj3;
			Vector3 vector3 = vector;
			((Vector4*)(nint)vector)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v26+8]");
			((Vector4*)(nint)vector)->z = 0f;
			Vector3 vector4 = ((Camera)(object)typeName).ScreenToViewportPoint((Vector3)vector);
			((Vector4*)(nint)vector)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v28+8]");
			((Vector4*)(nint)vector)->z = 0f;
			transform.Internal_LookAt_Injected(ref *(Vector3*)relativeTo, ref *(Vector3*)vector);
			((Vector4*)(nint)vector)->x = (float)transform;
			((Vector4*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			Vector3 vector5 = (Vector2)vector;
		}
		return vector2;
	}

	public unsafe static Vector3 WorldToLocalPoint(Vector3 worldPos, Camera worldCam, Camera uiCam, Transform relativeTo)
	{
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Ref, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Ref, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Ref, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Ref, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e4: Expected Obj, but got I4
		//IL_03fe: Expected I, but got Obj
		//IL_0414: Expected Obj, but got I
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_02b6: Expected I, but got Obj
		//IL_02cc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_04dd: Expected native int or pointer, but got VT
		//IL_04eb: Expected native int or pointer, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02f7: Expected I, but got Obj
		//IL_043b: Expected Obj, but got VT
		//IL_00a1: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got VT
		//IL_0162: Expected Ref, but got F4
		//IL_0177: Expected Ref, but got F4
		//IL_01f4: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_04a6: Expected Obj, but got I4
		//IL_0281: Expected F4, but got Obj
		//IL_027c: Expected native int or pointer, but got VT
		//IL_0296: Expected F4, but got I
		//IL_0291: Expected native int or pointer, but got VT
		//IL_0235: Expected I, but got Obj
		object obj = default;
		ref long reference = ref *(long*)(obj + 216);
		reference = ref *(long*)null;
		ref string reference2 = ref *(string*)(obj + 72);
		reference2 = ref *(string*)null;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		ref string reference3 = ref *(string*)(obj + 60);
		reference3 = ref *(string*)null;
		_ = 0;
		ref InAppItemModel.ItemType reference4 = ref *(InAppItemModel.ItemType*)(obj + 48);
		reference4 = ref *(InAppItemModel.ItemType*)null;
		_ = 0;
		object obj2 = obj + 24;
		obj2 = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v120 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj + 152;
		object obj5 = obj + 136;
		object obj6 = obj + 12;
		Vector3 vector = default;
		if (((ComputeShader)(object)worldCam).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v116 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)worldPos).FindKernel(null) != 0)
			{
				reference = ref *(long*)null;
				Matrix4x4 localToWorldMatrix = ((Transform)worldPos).localToWorldMatrix;
				reference2 = ref *(string*)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v35+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v35+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v35+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v35+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v35+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v35+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v35+38]");
				_ = 0;
				reference3 = ref *(string*)float.MaxValue;
				_ = float.MaxValue;
				_ = float.MaxValue;
				reference4 = ref *(InAppItemModel.ItemType*)float.MinValue;
				_ = float.MinValue;
				_ = float.MinValue;
				AnalyticsHelper.ConvertRewardToItemAddedParameters((CelebrationReward)(object)worldCam, out *(ObtainableItemSource*)uiCam, out *(long*)1, out reference2, out reference3, out reference4, out reference, out *(long*)relativeTo);
				if (reference != 0)
				{
					obj6 = reference3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (System.String&)+8]");
					_ = 0;
					nint num5 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num6 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v112 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 one = Vector3.one;
					obj5 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v39+8]");
					_ = 0;
					obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
					obj4 = reference4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (ItemType&)+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
					((Vector3*)(nint)vector)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+10]");
					_ = 0;
					goto IL_0336;
				}
			}
		}
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v47 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one2 = Vector3.one;
		Vector3 one3 = Vector3.one;
		((Vector3*)(nint)vector)->x = 0f;
		((Vector3*)(nint)vector)->z = 0f;
		_ = 0;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v39+8]");
		_ = 0;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
		goto IL_0336;
		IL_0336:
		return vector;
	}

	public unsafe static void OverlayPosition(Transform trans, Vector3 worldPos, Camera worldCam, Camera myCam)
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		//IL_0107: Expected native int or pointer, but got VT
		//IL_012c: Expected VT, but got I4
		//IL_012c: Expected VT, but got Obj
		//IL_012c: Expected VT, but got Obj
		//IL_013d: Expected F4, but got Obj
		//IL_0138: Expected native int or pointer, but got VT
		//IL_0152: Expected F4, but got I
		//IL_014d: Expected native int or pointer, but got VT
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_01cb: Expected F4, but got Obj
		//IL_01c6: Expected native int or pointer, but got VT
		//IL_01e7: Expected native int or pointer, but got VT
		//IL_0227: Expected F4, but got Obj
		//IL_0222: Expected native int or pointer, but got VT
		//IL_006e: Expected native int or pointer, but got VT
		//IL_00c2: Expected native int or pointer, but got VT
		//IL_00e2: Expected I4, but got Obj
		//IL_00e2: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj = default;
		Vector2 vector = (Vector2)(obj + 16);
		((Vector2*)(nint)vector)->x = worldPos.x;
		_ = worldPos.z;
		Vector2 vector2 = ConstrainRect(vector, (Vector2)worldCam, (Vector2)myCam, (Vector2)1);
		((Vector3*)(nint)worldPos)->x = (float)obj;
		Vector3 vector3 = worldPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v14 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v45 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width(worldPos.x);
		float num3 = worldPos.z + worldPos.x;
		((Vector3*)(nint)worldPos)->x = (float)gUILayoutOption;
		float z = num3 - worldPos.x;
		((Vector3*)(nint)worldPos)->z = z;
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(worldPos.y);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [worldPos @ L1 (UnityEngine.Vector3)+C]");
		float num4 = 0f + worldPos.y;
		((Vector3*)(nint)worldPos)->y = (float)gUILayoutOption2;
		float num5 = num4 - worldPos.y;
		float width = worldPos.z + worldPos.x;
		GUILayoutOption gUILayoutOption3 = GUILayout.Width(width);
		float z2 = (float)gUILayoutOption3 - worldPos.x;
		((Vector3*)(nint)worldPos)->z = z2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [worldPos @ L1 (UnityEngine.Vector3)+C]");
		float width2 = 0f + worldPos.y;
		GUILayoutOption gUILayoutOption4 = GUILayout.Width(width2);
		float num6 = (float)gUILayoutOption4 - worldPos.y;
		((Vector2*)(nint)vector)->x = worldPos.x;
		_ = worldPos.z;
		Rect rect = MakePixelPerfect((Rect)vector, (int)worldCam, (int)myCam);
	}

	public unsafe static void OverlayPosition(Transform trans, Vector3 worldPos, Camera worldCam)
	{
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03a7: Expected Obj, but got I4
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_03c4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0437: Expected I, but got Obj
		//IL_044d: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_05f8: Expected Obj, but got I4
		//IL_060a: Expected I, but got Obj
		//IL_0620: Expected Obj, but got I
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected VT, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_00bb: Expected I, but got Obj
		//IL_0211: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I
		//IL_0108: Expected I, but got Obj
		//IL_04e3: Expected Obj, but got F4
		//IL_04f0: Expected F4, but got Obj
		//IL_04eb: Expected native int or pointer, but got VT
		//IL_050a: Expected F4, but got Obj
		//IL_0505: Expected native int or pointer, but got VT
		//IL_051c: Expected F4, but got I
		//IL_0517: Expected native int or pointer, but got VT
		//IL_0550: Expected I, but got Obj
		//IL_0566: Expected Obj, but got I
		//IL_0154: Expected F4, but got I4
		//IL_014f: Expected native int or pointer, but got VT
		//IL_0252: Expected I, but got Obj
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_029f: Expected I, but got Obj
		//IL_04d1: Expected Obj, but got F4
		//IL_05bc: Expected I, but got Obj
		//IL_05d2: Expected Obj, but got I
		//IL_02eb: Expected F4, but got Obj
		//IL_02e6: Expected native int or pointer, but got VT
		//IL_0300: Expected F4, but got I
		//IL_02fb: Expected native int or pointer, but got VT
		//IL_0311: Expected Ref, but got VT
		//IL_01c4: Expected I, but got Obj
		//IL_064a: Expected F4, but got Obj
		//IL_0645: Expected native int or pointer, but got VT
		//IL_065f: Expected F4, but got I
		//IL_065a: Expected native int or pointer, but got VT
		//IL_0350: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 44;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = 0;
		_ = 0;
		string tag = worldCam.tag;
		bool activeSelf = ((GameObject)(object)tag).activeSelf;
		Transform parentInternal = ((Transform)(object)worldCam).parentInternal;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((ComputeShader)(object)parentInternal).FindKernel((string)null);
		bool flag = num3 == 0;
		Transform transform = (Transform)(object)worldCam;
		if (!flag)
		{
			Transform parentInternal2 = ((Transform)(object)worldCam).parentInternal;
			transform = parentInternal2;
		}
		nint num4 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v22 (Il2CppClass<NGUITools>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v105 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v101 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector4 vector = (Vector4)(obj2 + 56);
		Transform transform2 = (Transform)(obj2 + 20);
		object obj7 = obj2 + 8;
		if ((UnityEngine.Object)(object)typeName != null)
		{
			((Vector4*)(nint)vector)->x = (activeSelf ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string message = "No camera found for layer " + text;
			nint num8 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v67 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num9 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S1_v74 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogAssertion(message);
			Transform transform3 = (Transform)worldPos.x;
			return;
		}
		nint num10 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v46 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num11 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v89 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = worldPos.x;
		((Vector4*)(nint)vector)->x = (float)obj2;
		Vector3 vector2 = vector;
		((Vector4*)(nint)vector)->x = (float)transform2;
		((Vector4*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		Vector3 vector3 = ((Camera)(object)typeName).ScreenToViewportPoint((Vector3)vector);
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v38+8]");
		_ = 0;
		nint num12 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v85 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)transform).FindKernel((string)null) != 0)
		{
			((Vector4*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector4*)(nint)vector)->z = 0f;
			transform2.Internal_LookAt_Injected(ref *(Vector3*)transform, ref *(Vector3*)vector);
			obj3 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		}
		else
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
		}
		nint num14 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v67 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num15 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v74 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector4*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector4*)(nint)vector)->z = 0f;
		Vector3 vector4 = (Vector2)vector;
	}

	public static void OverlayPosition(Transform trans, Transform target)
	{
		//IL_020c: Expected Obj, but got I4
		//IL_021a: Expected I, but got Obj
		//IL_0230: Expected Obj, but got I
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_012b: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_0139: Expected Obj, but got F4
		//IL_0147: Expected Obj, but got F4
		object obj = 0;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v28 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		object obj3 = target - 1;
		if ((nint)target == 1)
		{
			goto IL_0122;
		}
		if ((nint)obj3 == 1)
		{
			goto IL_0130;
		}
		if ((nint)obj3 != 2)
		{
			if ((nint)obj3 == 3)
			{
				goto IL_0122;
			}
			if ((nint)obj3 == 4)
			{
				goto IL_0130;
			}
			if ((nint)obj3 != 5)
			{
				if ((nint)obj3 == 6)
				{
					goto IL_0122;
				}
				if ((nint)obj3 == 7)
				{
					goto IL_0130;
				}
			}
		}
		obj = 0f;
		goto IL_024d;
		IL_0130:
		obj = 1f;
		goto IL_024d;
		IL_0122:
		obj = 0.5f;
		goto IL_024d;
		IL_024d:
		if ((object)target != null && (nint)target != 1 && (nint)target != 2)
		{
			if ((nint)target == 3 || (nint)target == 4 || (nint)target == 5)
			{
				_ = 0.5f;
			}
			else
			{
				_ = 0f;
			}
		}
		else
		{
			_ = 1f;
		}
		Transform transform = (Transform)obj;
	}
}
