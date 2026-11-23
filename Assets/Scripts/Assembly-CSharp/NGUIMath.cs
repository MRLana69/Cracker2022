using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class NGUIMath
{
	public static float Lerp(float from, float to, float factor)
	{
		float num = 1f - factor;
		float num2 = from * num;
		float num3 = to * factor;
		return num2 + num3;
	}

	public static int ClampIndex(int val, int max)
	{
		bool flag = val < 0;
		int result = 0;
		if (!flag)
		{
			bool flag2 = max > val;
			result = val;
			if (!flag2)
			{
				int num = max - 1;
				result = num;
			}
		}
		return result;
	}

	public static int RepeatIndex(int val, int max)
	{
		if (max > 0)
		{
			int num = default;
			while (num < 0)
			{
				int num2 = num + max;
				num = num2;
			}
			while (num >= max)
			{
				int num3 = num - max;
				num = num3;
			}
			return num;
		}
		return 0;
	}

	public static float WrapAngle(float angle)
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

	public static float Wrap01(float val)
	{
		//IL_001b: Expected F8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num = Math.Abs((double)val);
		double num2 = ((!(num < 2147483648.0)) ? (-2147483648.0) : ((double)val));
		return val - (float)num2;
	}

	public static int HexToDecimal(char ch)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_008b: Expected I4, but got Obj
		//IL_0047: Expected Obj, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected I4, but got Unknown
		object obj = ch - 48;
		if ((nint)obj >= 23)
		{
			object obj2 = ch - 97;
			if ((nint)obj2 >= 6)
			{
				return 15;
			}
			return obj2 + 10;
		}
		object obj3 = obj << 2;
		object obj4 = obj3 + 2293220;
		return (int)obj4;
	}

	public static char DecimalToHexChar(int num)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected I4, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		bool flag = num > 15;
		object obj = 70;
		if (!flag)
		{
			obj = num + 48;
			if (num > 9)
			{
				obj = num + 55;
			}
		}
		return (char)(obj & 0xFFFF);
	}

	public unsafe static string DecimalToHex8(int num)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int num2 = num & 0xFF;
		int num3 = obj + 12;
		return ((int*)num3)->ToString("X2");
	}

	public unsafe static string DecimalToHex24(int num)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int num2 = num & 0xFFFFFF;
		int num3 = obj + 12;
		return ((int*)num3)->ToString("X6");
	}

	public unsafe static string DecimalToHex32(int num)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int num2 = obj + 12;
		return ((int*)num2)->ToString("X8");
	}

	public static int ColorToInt(Color c)
	{
		//IL_0054: Expected F8, but got I4
		//IL_0093: Expected F8, but got I4
		//IL_00d2: Expected F8, but got I4
		//IL_0111: Expected F8, but got I4
		//IL_018e: Expected Obj, but got F8
		//IL_019c: Expected Obj, but got F8
		//IL_01b7: Expected Obj, but got F8
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected I4, but got Unknown
		float num = c.r * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num3 = default;
		double num2 = Math.Abs(num3);
		if (!(num2 < 2147483648.0))
		{
			num3 = -2147483648.0;
		}
		float num4 = c.g * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num6 = default;
		double num5 = Math.Abs(num6);
		if (!(num5 < 2147483648.0))
		{
			num6 = -2147483648.0;
		}
		float num7 = c.b * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num9 = default;
		double num8 = Math.Abs(num9);
		if (!(num8 < 2147483648.0))
		{
			num9 = -2147483648.0;
		}
		float num10 = c.a * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num12 = default;
		double num11 = Math.Abs(num12);
		if (!(num11 < 2147483648.0))
		{
			num12 = -2147483648.0;
		}
		object obj = num6 << 16;
		object obj2 = num3 << 24;
		object obj3 = obj | obj2;
		object obj4 = num9 << 8;
		object obj5 = obj3 | obj4;
		return num12 | obj5;
	}

	public unsafe static Color IntToColor(int val)
	{
		//IL_0026: Expected native int or pointer, but got VT
		//IL_005f: Expected native int or pointer, but got VT
		//IL_0098: Expected native int or pointer, but got VT
		//IL_00c3: Expected native int or pointer, but got VT
		int num = val & 0xFF;
		float a = (float)num * (1f / 255f);
		Color color = default;
		((Color*)(nint)color)->a = a;
		int num2 = val >> 8;
		int num3 = num2 & 0xFF;
		float b = (float)num3 * (1f / 255f);
		((Color*)(nint)color)->b = b;
		int num4 = val >> 16;
		int num5 = num4 & 0xFF;
		float g = (float)num5 * (1f / 255f);
		((Color*)(nint)color)->g = g;
		int num6 = val >> 24;
		float r = (float)num6 * (1f / 255f);
		((Color*)(nint)color)->r = r;
		return color;
	}

	public unsafe static string IntToBinary(int val, int bits)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected I4, but got Unknown
		//IL_0091: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string text = string.Empty;
		int num = default;
		while (num > 0)
		{
			if (num <= 24)
			{
				int num2 = 1 << num;
				if ((num2 & 0x1010100) != 0)
				{
					string text2 = text + " ";
					text = text2;
				}
			}
			num--;
			int num3 = val >> num;
			int num4 = num3 & 1;
			object obj3 = 49;
			if (num4 == 0)
			{
				obj3 = 48;
			}
			char c = (char)(obj + 14);
			string text3 = ((char*)(ushort)c)->ToString();
			string text4 = text + text3;
			text = text4;
		}
		return text;
	}

	public static Color HexToColor(uint val)
	{
		Color color = IntToColor((int)val);
		Color result = default;
		return result;
	}

	public unsafe static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got F4
		//IL_0194: Expected F4, but got Obj
		//IL_018f: Expected native int or pointer, but got VT
		//IL_01a9: Expected F4, but got I
		//IL_01a4: Expected native int or pointer, but got VT
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected I4, but got Unknown
		//IL_008e: Expected Obj, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected I4, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected I4, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = rect.m_Width;
		obj = rect.m_XMin;
		if (width != 0 && height != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj3 = 0 + obj;
			int num = (int)(rect.m_XMin / width);
			obj = num;
			object obj4 = obj3 - num;
			float num2 = rect.m_Width + rect.m_XMin;
			int num3 = (int)(num2 / width);
			object obj5 = num3 - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj6 = num4 + 0;
			float num5 = rect.m_Height + rect.m_YMin;
			int num6 = (int)(num5 / height);
			float num7 = 1f - (float)num6;
			float num8 = (float)obj6 - num7;
			int num9 = (int)(rect.m_YMin / height);
			float num10 = 1f - (float)num9;
			float num11 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float num12 = num11 - 0f;
		}
		Rect rect2 = default;
		((Rect*)(nint)rect2)->m_XMin = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		((Rect*)(nint)rect2)->m_Width = 0f;
		return rect2;
	}

	public unsafe static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got F4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got F4
		//IL_01e5: Expected Obj, but got I
		//IL_0413: Expected F4, but got I
		//IL_040e: Expected native int or pointer, but got VT
		//IL_0420: Expected F4, but got Obj
		//IL_041b: Expected native int or pointer, but got VT
		//IL_0091: Expected F8, but got I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0298: Expected Obj, but got F8
		//IL_00d0: Expected F8, but got I4
		//IL_010f: Expected F8, but got I4
		//IL_0347: Expected Obj, but got I
		//IL_0156: Expected F4, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = rect.m_Width;
		obj = rect.m_XMin;
		float num = rect.m_XMin * (float)width;
		float num12;
		if (!round)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj3 = 0 + obj;
			obj = num;
			float num2 = (float)obj3 - num;
			float num3 = rect.m_Width + rect.m_XMin;
			float num4 = num3 * (float)width;
			float num5 = num4 - (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj4 = num6 + 0;
			float num7 = rect.m_Height + rect.m_YMin;
			float num8 = 1f - num7;
			float num9 = num8 * (float)height;
			float num10 = (float)obj4 - num9;
			float num11 = 1f - rect.m_YMin;
			num12 = num11 * (float)height;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num14 = default;
			double num13 = Math.Abs(num14);
			if (!(num13 < 2147483648.0))
			{
				num14 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj5 = 0 + obj;
			obj = num14;
			double num15 = (double)obj5 - num14;
			float num16 = rect.m_Width + rect.m_XMin;
			float num17 = num16 * (float)width;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num19 = default;
			double num18 = Math.Abs(num19);
			if (!(num18 < 2147483648.0))
			{
				num19 = -2147483648.0;
			}
			double num20 = num19 - (double)obj;
			float num21 = rect.m_Height + rect.m_YMin;
			float num22 = 1f - num21;
			float num23 = num22 * (float)height;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num25 = default;
			double num24 = Math.Abs(num25);
			if (!(num24 < 2147483648.0))
			{
				num25 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj6 = num26 + 0;
			double num27 = (double)obj6 - num25;
			float num28 = 1f - rect.m_YMin;
			float num29 = num28 * (float)height;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num31 = default;
			double num30 = Math.Abs(num31);
			num12 = ((!(num30 < 2147483648.0)) ? (-2.1474836E+09f) : ((float)num31));
		}
		float num32 = num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num33 = num32 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Rect rect2 = default;
		((Rect*)(nint)rect2)->m_Width = 0f;
		((Rect*)(nint)rect2)->m_XMin = (float)obj;
		return rect2;
	}

	public unsafe static Rect MakePixelPerfect(Rect rect)
	{
		//IL_003f: Expected F8, but got I4
		//IL_013e: Expected native int or pointer, but got VT
		//IL_015a: Expected native int or pointer, but got VT
		//IL_007e: Expected F8, but got I4
		//IL_0185: Expected native int or pointer, but got VT
		//IL_01a1: Expected native int or pointer, but got VT
		//IL_00bd: Expected F8, but got I4
		//IL_01e0: Expected native int or pointer, but got VT
		//IL_00fc: Expected F8, but got I4
		//IL_021f: Expected native int or pointer, but got VT
		//IL_0231: Expected native int or pointer, but got VT
		//IL_0243: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num2 = default;
		double num = Math.Abs(num2);
		if (!(num < 2147483648.0))
		{
			num2 = -2147483648.0;
		}
		float num3 = rect.m_Width + rect.m_XMin;
		((Rect*)(nint)rect)->m_XMin = (float)num2;
		double num4 = (double)num3 - num2;
		((Rect*)(nint)rect)->m_Width = (float)num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num6 = default;
		double num5 = Math.Abs(num6);
		if (!(num5 < 2147483648.0))
		{
			num6 = -2147483648.0;
		}
		float num7 = rect.m_Height + rect.m_YMin;
		((Rect*)(nint)rect)->m_YMin = (float)num6;
		double num8 = (double)num7 - num6;
		((Rect*)(nint)rect)->m_Height = (float)num8;
		float num9 = rect.m_Width + rect.m_XMin;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num11 = default;
		double num10 = Math.Abs(num11);
		if (!(num10 < 2147483648.0))
		{
			num11 = -2147483648.0;
		}
		double num12 = num11 - (double)rect.m_XMin;
		((Rect*)(nint)rect)->m_Width = (float)num12;
		float num13 = rect.m_Height + rect.m_YMin;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num15 = default;
		double num14 = Math.Abs(num15);
		if (!(num14 < 2147483648.0))
		{
			num15 = -2147483648.0;
		}
		double num16 = num15 - (double)rect.m_YMin;
		((Rect*)(nint)rect)->m_Height = (float)num16;
		Rect rect2 = default;
		((Rect*)(nint)rect2)->m_Width = rect.m_Width;
		((Rect*)(nint)rect2)->m_XMin = rect.m_XMin;
		return rect2;
	}

	public unsafe static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected VT, but got Unknown
		//IL_005f: Expected F4, but got I
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_00b3: Expected F8, but got I4
		//IL_01b2: Expected native int or pointer, but got VT
		//IL_01ce: Expected native int or pointer, but got VT
		//IL_00f2: Expected F8, but got I4
		//IL_01f9: Expected native int or pointer, but got VT
		//IL_0215: Expected native int or pointer, but got VT
		//IL_0131: Expected F8, but got I4
		//IL_0254: Expected native int or pointer, but got VT
		//IL_0170: Expected F8, but got I4
		//IL_0293: Expected native int or pointer, but got VT
		//IL_02a5: Expected native int or pointer, but got VT
		//IL_02b7: Expected native int or pointer, but got VT
		//IL_02e6: Expected F4, but got I
		//IL_02e1: Expected native int or pointer, but got VT
		//IL_02fb: Expected F4, but got I
		//IL_02f6: Expected native int or pointer, but got VT
		object obj = default;
		Rect rect2 = (Rect)(obj + -64);
		_ = rect.m_Width;
		_ = rect.m_XMin;
		Rect rect3 = (Rect)(rect2 + 16);
		Rect rect4 = ConvertToPixels(rect3, width, height, round: true);
		Rect rect5 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
		((Rect*)(nint)rect5)->m_Width = 0f;
		Rect rect6 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
		((Rect*)(nint)rect6)->m_XMin = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num2 = default;
		double num = Math.Abs(num2);
		if (!(num < 2147483648.0))
		{
			num2 = -2147483648.0;
		}
		float num3 = rect.m_Width + rect.m_XMin;
		((Rect*)(nint)rect)->m_XMin = (float)num2;
		double num4 = (double)num3 - num2;
		((Rect*)(nint)rect)->m_Width = (float)num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num6 = default;
		double num5 = Math.Abs(num6);
		if (!(num5 < 2147483648.0))
		{
			num6 = -2147483648.0;
		}
		float num7 = rect.m_Height + rect.m_YMin;
		((Rect*)(nint)rect)->m_YMin = (float)num6;
		double num8 = (double)num7 - num6;
		((Rect*)(nint)rect)->m_Height = (float)num8;
		float num9 = rect.m_Width + rect.m_XMin;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num11 = default;
		double num10 = Math.Abs(num11);
		if (!(num10 < 2147483648.0))
		{
			num11 = -2147483648.0;
		}
		double num12 = num11 - (double)rect.m_XMin;
		((Rect*)(nint)rect)->m_Width = (float)num12;
		float num13 = rect.m_Height + rect.m_YMin;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num15 = default;
		double num14 = Math.Abs(num15);
		if (!(num14 < 2147483648.0))
		{
			num15 = -2147483648.0;
		}
		double num16 = num15 - (double)rect.m_YMin;
		((Rect*)(nint)rect)->m_Height = (float)num16;
		((Rect*)(nint)rect2)->m_Width = rect.m_Width;
		((Rect*)(nint)rect2)->m_XMin = rect.m_XMin;
		Rect rect7 = ConvertToTexCoords(rect2, width, height);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
		Rect rect8 = default;
		((Rect*)(nint)rect8)->m_Width = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
		((Rect*)(nint)rect8)->m_XMin = 0f;
		return rect8;
	}

	public unsafe static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		//IL_011c: Expected I, but got Obj
		//IL_0210: Expected VT, but got F4
		//IL_0030: Expected native int or pointer, but got VT
		//IL_0051: Expected native int or pointer, but got VT
		//IL_0308: Expected VT, but got F4
		//IL_0096: Expected native int or pointer, but got VT
		//IL_00b7: Expected native int or pointer, but got VT
		//IL_0272: Expected native int or pointer, but got VT
		//IL_0284: Expected F4, but got VT
		//IL_027f: Expected native int or pointer, but got VT
		//IL_00fc: Expected F4, but got I
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector2>)+5C]");
		nint num2 = 0;
		float num3 = maxRect.y - minRect.y;
		float num4 = maxArea.y - minArea.y;
		float num5 = maxArea.x - minArea.x;
		float num6 = maxRect.x - minRect.x;
		bool flag = num5 < num6;
		bool flag2 = !flag;
		float num7 = maxArea.x;
		float num8 = minArea.x;
		if (!flag2)
		{
			float num9 = num6 - num5;
			float num10 = (((Vector2*)(nint)minArea)->x = minArea.x - num9);
			num7 = (((Vector2*)(nint)maxArea)->x = maxArea.x + num9);
			num8 = num10;
		}
		bool flag3 = num3 > num4;
		bool flag4 = !flag3;
		float num11 = maxArea.y;
		float num12 = minArea.y;
		if (!flag4)
		{
			float num13 = num3 - num4;
			float num14 = (((Vector2*)(nint)minArea)->y = minArea.y - num13);
			num11 = (((Vector2*)(nint)maxArea)->y = maxArea.y + num13);
			num12 = num14;
		}
		float num15 = num8 - minRect.x;
		float num16 = (float)Vector2.zeroVector + num15;
		bool flag5 = num8 > minRect.x;
		Vector2 vector = (Vector2)num16;
		if (!flag5)
		{
			vector = Vector2.zeroVector;
		}
		float num17 = maxRect.x - num7;
		float num18 = (float)vector - num17;
		bool flag6 = num7 < maxRect.x;
		Vector2 vector2 = (Vector2)num18;
		if (!flag6)
		{
			vector2 = vector;
		}
		float num19 = num12 - minRect.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector2>)+4]");
		float num20 = 0f + num19;
		if (!(num12 > minRect.y))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector2>)+4]");
			num20 = 0f;
		}
		float num21 = maxRect.y - num11;
		float y = num20 - num21;
		if (!(num11 < maxRect.y))
		{
			y = num20;
		}
		Vector2 vector3 = default;
		((Vector2*)(nint)vector3)->y = y;
		((Vector2*)(nint)vector3)->x = (float)vector2;
		return vector3;
	}

	public unsafe static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0509: Expected I, but got Obj
		//IL_0621: Expected I, but got Obj
		//IL_065e: Expected VT, but got I4
		//IL_0659: Expected native int or pointer, but got VT
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected VT, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected VT, but got Unknown
		//IL_06ba: Expected native int or pointer, but got VT
		//IL_024a: Expected I, but got Obj
		//IL_0287: Expected VT, but got I4
		//IL_0282: Expected native int or pointer, but got VT
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected VT, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected VT, but got Unknown
		//IL_02e3: Expected native int or pointer, but got VT
		//IL_03ca: Expected I, but got Obj
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_040a: Expected Obj, but got I
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected VT, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected VT, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected VT, but got Unknown
		//IL_0470: Expected native int or pointer, but got VT
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected VT, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected VT, but got Unknown
		//IL_04c7: Expected Ref, but got VT
		//IL_04f6: Expected VT, but got I
		//IL_04f1: Expected native int or pointer, but got VT
		//IL_00f3: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0129: Expected I, but got Obj
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_0182: Invalid comparison between F4 and I
		//IL_0198: Expected F4, but got I
		//IL_0310: Invalid comparison between F4 and I
		//IL_0326: Expected F4, but got I
		//IL_0570: Invalid comparison between F4 and I
		//IL_0586: Expected F4, but got I
		//IL_0344: Invalid comparison between F4 and I
		//IL_035a: Expected F4, but got I
		//IL_05a4: Invalid comparison between F4 and I
		//IL_05ba: Expected F4, but got I
		//IL_0378: Invalid comparison between F4 and I
		//IL_038e: Expected F4, but got I
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 208;
		_ = 0;
		_ = 0;
		_ = 0;
		Bounds bounds = default;
		Transform transform = default;
		if (transform != null)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S3_v6 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v42+C]");
			if ((nint)0 == 0)
			{
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v104 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v105 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				_ = 0;
				_ = Vector3.zeroVector;
				_ = 0;
				_ = 0;
				((Bounds*)(nint)bounds)->m_Center = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				Vector3 center = (Vector3)(obj + 24);
				Vector3 size = (Vector3)(obj + 8);
				*(Bounds*)(nint)bounds = new Bounds(center, size);
			}
			else
			{
				float num5 = float.MinValue;
				float num6 = float.MinValue;
				float num7 = float.MinValue;
				float num8 = float.MaxValue;
				float num9 = float.MaxValue;
				float num10 = float.MaxValue;
				object obj4 = default;
				object obj7 = default;
				object obj10 = default;
				object obj11 = default;
				while (true)
				{
					object obj3 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v42+C]");
					if ((nint)obj3 >= 0)
					{
						break;
					}
					object obj5 = obj4 << 2;
					object obj6 = obj7 + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v91+10]");
					Behaviour behaviour = (Behaviour)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v91+10]");
					if (((Behaviour)0).enabled)
					{
						nint num11 = (nint)behaviour;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v328 @ S1_v80 (Il2CppClass<UnityEngine.Behaviour>)+10C] (should have been resolved before IL gen)");
						transform = null;
						while ((nint)transform < 4)
						{
							object obj8 = transform * 12;
							object obj9 = obj10 + obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S1_v85+18]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S1_v85+10]");
							_ = 0;
							float num12 = num8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
							bool flag = num12 > 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
							float num13 = 0f;
							if (!flag)
							{
								num13 = num8;
							}
							float num14 = num9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+AC]");
							bool flag2 = num14 > 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+AC]");
							float num15 = 0f;
							if (!flag2)
							{
								num15 = num9;
							}
							float num16 = num10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
							bool flag3 = num16 > 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
							float num17 = 0f;
							if (!flag3)
							{
								num17 = num10;
							}
							float num18 = num5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
							bool flag4 = num18 < 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
							float num19 = 0f;
							if (!flag4)
							{
								num19 = num5;
							}
							float num20 = num6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+AC]");
							bool flag5 = num20 < 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+AC]");
							float num21 = 0f;
							if (!flag5)
							{
								num21 = num6;
							}
							float num22 = num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
							bool flag6 = num22 < 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
							float num23 = 0f;
							if (!flag6)
							{
								num23 = num7;
							}
							Transform transform2 = (Transform)(transform + 1);
							transform = transform2;
							num5 = num19;
							num6 = num21;
							num7 = num23;
							num8 = num13;
							num9 = num15;
							num10 = num17;
						}
					}
					obj4 = obj11 + 1;
				}
				nint num24 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v62 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				_ = 0;
				object obj12 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v62 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				_ = 0;
				_ = Vector3.zeroVector;
				_ = Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Bounds bounds2 = (Bounds)(obj + 184);
				Vector3 center2 = (Vector3)(obj + 72);
				Vector3 size2 = (Vector3)(obj + 56);
				*(Bounds*)(nint)bounds2 = new Bounds(center2, size2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Bounds bounds3 = (Bounds)(obj + 184);
				Vector3 point = (Vector3)(obj + 40);
				((Bounds*)bounds3)->Encapsulate(point);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
				((Bounds*)(nint)bounds)->m_Center = (Vector3)0;
			}
		}
		else
		{
			nint num26 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v11 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v12 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			_ = Vector3.zeroVector;
			nint num28 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v18 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			_ = Vector3.zeroVector;
			_ = 0;
			_ = 0;
			((Bounds*)(nint)bounds)->m_Center = (Vector3)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
			_ = 0;
			Vector3 center3 = (Vector3)(obj + 104);
			Vector3 size3 = (Vector3)(obj + 88);
			*(Bounds*)(nint)bounds = new Bounds(center3, size3);
		}
		return bounds;
	}

	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0058: Expected VT, but got I
		//IL_0053: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		Bounds bounds = CalculateRelativeWidgetBounds(trans, trans, considerInactive: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Bounds bounds2 = default;
		((Bounds*)(nint)bounds2)->m_Center = (Vector3)0;
		return bounds2;
	}

	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0057: Expected VT, but got I
		//IL_0052: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		Bounds bounds = CalculateRelativeWidgetBounds(trans, trans, considerInactive);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Bounds bounds2 = default;
		((Bounds*)(nint)bounds2)->m_Center = (Vector3)0;
		return bounds2;
	}

	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0058: Expected VT, but got I
		//IL_0053: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		Bounds bounds = CalculateRelativeWidgetBounds(relativeTo, content, considerInactive: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Bounds bounds2 = default;
		((Bounds*)(nint)bounds2)->m_Center = (Vector3)0;
		return bounds2;
	}

	public unsafe static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerChildren = true)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_02ac: Expected I, but got Obj
		//IL_02e2: Expected I, but got Obj
		//IL_031f: Expected VT, but got I4
		//IL_031a: Expected native int or pointer, but got VT
		//IL_0341: Expected F4, but got I
		//IL_033c: Expected native int or pointer, but got VT
		//IL_0363: Expected F4, but got I
		//IL_035e: Expected native int or pointer, but got VT
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected VT, but got Unknown
		//IL_037d: Expected native int or pointer, but got VT
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Ref, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Ref, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Ref, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Ref, but got Unknown
		//IL_01af: Expected I, but got Obj
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected VT, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected VT, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected VT, but got Unknown
		//IL_0222: Expected native int or pointer, but got VT
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected VT, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected VT, but got Unknown
		//IL_026a: Expected Ref, but got VT
		//IL_0299: Expected VT, but got I
		//IL_0294: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 288);
		object obj2 = vector + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Bounds bounds3 = default;
		if (content != null && relativeTo != null)
		{
			_ = 0;
			Matrix4x4 worldToLocalMatrix = relativeTo.worldToLocalMatrix;
			object obj3 = vector + 216;
			object obj4 = vector + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			_ = float.MaxValue;
			_ = float.MaxValue;
			_ = float.MaxValue;
			_ = float.MinValue;
			_ = float.MinValue;
			_ = float.MinValue;
			CalculateRelativeWidgetBounds(content, considerInactive, isRoot: true, ref *(Matrix4x4*)(vector + 216), ref *(Vector3*)(vector + 200), ref *(Vector3*)(vector + 184), ref *(bool*)(vector + 287), considerChildren);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+11F]");
			if ((nint)0 != 0)
			{
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v76 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v77 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				_ = 0;
				_ = Vector3.zeroVector;
				Bounds bounds = (Bounds)(vector + 160);
				Vector3 center = vector - -64;
				Vector3 size = vector + 48;
				*(Bounds*)(nint)bounds = new Bounds(center, size);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				_ = 0;
				Bounds bounds2 = (Bounds)(vector + 160);
				Vector3 point = vector + 32;
				((Bounds*)bounds2)->Encapsulate(point);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				((Bounds*)(nint)bounds3)->m_Center = (Vector3)0;
				goto IL_0147;
			}
		}
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v18 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v19 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v25 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v26 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		_ = 0;
		_ = 0;
		((Bounds*)(nint)bounds3)->m_Center = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector3 center2 = vector + 16;
		*(Bounds*)(nint)bounds3 = new Bounds(center2, vector);
		goto IL_0147;
		IL_0147:
		return bounds3;
	}

	private unsafe static void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerChildren)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_012e: Expected I, but got Obj
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got I4
		//IL_02af: Expected I, but got Obj
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_01d7: Invalid comparison between I and VT
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_031f: Expected F4, but got I
		//IL_031a: Expected native int or pointer, but got VT
		//IL_0334: Expected F4, but got I
		//IL_032f: Expected native int or pointer, but got VT
		//IL_035a: Invalid comparison between I and VT
		//IL_0527: Invalid comparison between VT and I
		//IL_05e9: Invalid comparison between VT and I
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected Obj, but got Unknown
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (!(content != null))
		{
			return;
		}
		if (!considerInactive)
		{
			GameObject gameObject = content.gameObject;
			if (!NGUITools.GetActive(gameObject))
			{
				return;
			}
		}
		bool flag = !isRoot;
		bool flag2 = !flag;
		UIPanel uIPanel = null;
		if (!flag2)
		{
			UIPanel component = content.GetComponent<UIPanel>();
			uIPanel = component;
		}
		if (uIPanel != null && !uIPanel.enabled)
		{
			return;
		}
		if (uIPanel != null && uIPanel.mClipping != UIDrawCall.Clipping.None)
		{
			nint num = (nint)uIPanel;
			object obj2 = uIPanel + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ S1_v61 (Il2CppClass<UIPanel>)+10C] (should have been resolved before IL gen)");
			object obj3 = 0;
			object obj6 = default;
			while ((nint)obj3 < 4)
			{
				object obj4 = obj3 * 12;
				object obj5 = obj6 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v67+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v67+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				_ = 0;
				Vector3 point = vector + 16;
				Vector3 vector2 = toLocal.MultiplyPoint3x4(point);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0) > System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref vMax))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					ref Vector3 reference = ref *(Vector3*)null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vMax @ L5 (UnityEngine.Vector3&)+4]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				if (num2 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					_ = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vMax @ L5 (UnityEngine.Vector3&)+8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				if (num3 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					_ = 0;
				}
				Vector3 vector3 = vMin;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				if (vector3 > (object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					ref Vector3 reference2 = ref *(Vector3*)null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vMin @ L4 (UnityEngine.Vector3&)+4]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				if (num4 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					_ = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vMin @ L4 (UnityEngine.Vector3&)+8]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				if (num5 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					_ = 0;
				}
				ref bool reference3 = ref *(bool*)1;
				object obj7 = obj3 + 1;
				obj3 = obj7;
			}
			return;
		}
		UIWidget component2 = content.GetComponent<UIWidget>();
		if (component2 != null && component2.enabled)
		{
			nint num6 = (nint)component2;
			object obj8 = component2 + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v263 @ S1_v23 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
			object obj9 = 0;
			object obj12 = default;
			while ((nint)obj9 < 4)
			{
				object obj10 = obj9 * 12;
				object obj11 = obj12 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S1_v29+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S1_v29+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				((Vector3*)(nint)vector)->x = 0f;
				Vector3 vector4 = toLocal.MultiplyPoint3x4(vector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0) > System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref vMax))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					ref Vector3 reference = ref *(Vector3*)null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vMax @ L5 (UnityEngine.Vector3&)+4]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				if (num7 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					_ = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vMax @ L5 (UnityEngine.Vector3&)+8]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				if (num8 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					_ = 0;
				}
				Vector3 vector5 = vMin;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				if (vector5 > (object)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					ref Vector3 reference2 = ref *(Vector3*)null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vMin @ L4 (UnityEngine.Vector3&)+4]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				if (num9 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					_ = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [vMin @ L4 (UnityEngine.Vector3&)+8]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				if (num10 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					_ = 0;
				}
				ref bool reference3 = ref *(bool*)1;
				object obj13 = obj9 + 1;
				obj9 = obj13;
			}
			if (!considerChildren)
			{
				return;
			}
		}
		int childCount = content.childCount;
		int num11 = 0;
		while (childCount > num11)
		{
			Transform child = content.GetChild(num11);
			CalculateRelativeWidgetBounds(child, considerInactive, isRoot: false, ref toLocal, ref vMin, ref vMax, ref isSet, considerChildren: true);
			int num12 = num11 + 1;
			num11 = num12;
		}
	}

	public unsafe static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		//IL_0081: Expected F8, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0166: Expected native int or pointer, but got VT
		//IL_019a: Expected native int or pointer, but got VT
		//IL_01b7: Expected native int or pointer, but got VT
		float num = strength * 0.001f;
		float num2 = 1f - num;
		float num3 = Math.Min(deltaTime, 1f);
		float num4 = num3 * 1000f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double value = default;
		double num5 = Math.Abs(value);
		if (!(num5 < 2147483648.0))
		{
			value = -2147483648.0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D4");
		object obj = default;
		float num6 = (float)obj - 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1624");
		object obj2 = default;
		float num7 = num6 / (float)obj2;
		float num8 = (float)velocity * num7;
		object obj3 = velocity * obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [velocity @ L1 (UnityEngine.Vector3&)+4]");
		object obj4 = 0 * obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [velocity @ L1 (UnityEngine.Vector3&)+8]");
		object obj5 = 0 * obj;
		ref Vector3 reference = ref *(Vector3*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [velocity @ L1 (UnityEngine.Vector3&)+8]");
		float num9 = 0f * num7;
		float z = num9 * 0.06f;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [velocity @ L1 (UnityEngine.Vector3&)+4]");
		float num10 = 0f * num7;
		float y = num10 * 0.06f;
		((Vector3*)(nint)vector)->y = y;
		float x = num8 * 0.06f;
		((Vector3*)(nint)vector)->x = x;
		return vector;
	}

	public unsafe static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		//IL_0081: Expected F8, but got I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got F4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected F4, but got Unknown
		//IL_018d: Expected native int or pointer, but got VT
		float num = strength * 0.001f;
		float num2 = 1f - num;
		float num3 = Math.Min(deltaTime, 1f);
		float num4 = num3 * 1000f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double value = default;
		double num5 = Math.Abs(value);
		if (!(num5 < 2147483648.0))
		{
			value = -2147483648.0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D4");
		object obj = default;
		float num6 = (float)obj - 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1624");
		object obj2 = default;
		float num7 = num6 / (float)obj2;
		float num8 = (float)velocity * num7;
		object obj3 = velocity * obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [velocity @ L1 (UnityEngine.Vector2&)+4]");
		object obj4 = 0 * obj;
		object obj5 = obj4 << 32;
		object obj6 = obj3 | obj5;
		ref Vector2 reference = ref *(Vector2*)obj6;
		float num9 = num8 * 0.06f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [velocity @ L1 (UnityEngine.Vector2&)+4]");
		float num10 = 0f * num7;
		float num11 = num10 * 0.06f;
		object obj7 = num11 << 32;
		float x = num9 | obj7;
		Vector2 vector = default;
		((Vector2*)(nint)vector)->x = x;
		return vector;
	}

	public static float SpringLerp(float strength, float deltaTime)
	{
		//IL_0061: Expected F8, but got I4
		//IL_013f: Expected Obj, but got I4
		//IL_014c: Invalid comparison between Obj and F8
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		float num = Math.Min(deltaTime, 1f);
		float num2 = num * 1000f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num4 = default;
		double num3 = Math.Abs(num4);
		if (!(num3 < 2147483648.0))
		{
			num4 = -2147483648.0;
		}
		float num5 = strength * 0.001f;
		float num6 = Math.Min(num5, 1f);
		bool flag = num5 < 0f;
		float num7 = 0f;
		if (!flag)
		{
			num7 = num6;
		}
		float num8 = 0f;
		object obj = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num4))
		{
			float num9 = 1f - num8;
			float num10 = num9 * num7;
			float num11 = num8 + num10;
			object obj2 = obj + 1;
			num8 = num11;
			obj = obj2;
		}
		return num8;
	}

	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		//IL_0061: Expected F8, but got I4
		//IL_012d: Expected Obj, but got I4
		//IL_013a: Invalid comparison between Obj and F8
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		float num = Math.Min(deltaTime, 1f);
		float num2 = num * 1000f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num4 = default;
		double num3 = Math.Abs(num4);
		if (!(num3 < 2147483648.0))
		{
			num4 = -2147483648.0;
		}
		float num5 = strength * 0.001f;
		float num6 = Math.Min(num5, 1f);
		bool flag = num5 < 0f;
		float num7 = 0f;
		if (!flag)
		{
			num7 = num6;
		}
		object obj = 0;
		float num9 = default;
		float result = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num4))
		{
			float num8 = to - num9;
			float num10 = num8 * num7;
			result = num9 + num10;
			object obj2 = obj + 1;
			obj = obj2;
		}
		return result;
	}

	public unsafe static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		//IL_00e1: Expected Obj, but got F4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected F4, but got Unknown
		//IL_00f6: Expected native int or pointer, but got VT
		float num = to.x - from.x;
		float num2 = SpringLerp(strength, deltaTime);
		float num3 = Math.Min(num2, 1f);
		bool flag = num2 < 0f;
		float num4 = 0f;
		if (!flag)
		{
			num4 = num3;
		}
		float num5 = num * num4;
		float num6 = from.x + num5;
		float num7 = to.y - from.y;
		float num8 = num7 * num4;
		float num9 = from.y + num8;
		object obj = num9 << 32;
		float x = num6 | obj;
		Vector2 vector = default;
		((Vector2*)(nint)vector)->x = x;
		return vector;
	}

	public unsafe static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		//IL_00db: Expected native int or pointer, but got VT
		//IL_0124: Expected native int or pointer, but got VT
		//IL_0131: Expected native int or pointer, but got VT
		float num = to.x - from.x;
		float num2 = SpringLerp(strength, deltaTime);
		float num3 = Math.Min(num2, 1f);
		bool flag = num2 < 0f;
		float num4 = 0f;
		if (!flag)
		{
			num4 = num3;
		}
		float num5 = num * num4;
		float x = from.x + num5;
		float num6 = to.z - from.z;
		float num7 = num6 * num4;
		float z = from.z + num7;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = z;
		float num8 = to.y - from.y;
		float num9 = num8 * num4;
		float y = from.y + num9;
		((Vector3*)(nint)vector)->y = y;
		((Vector3*)(nint)vector)->x = x;
		return vector;
	}

	public unsafe static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0040: Expected native int or pointer, but got VT
		//IL_0052: Expected native int or pointer, but got VT
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected VT, but got Unknown
		//IL_0094: Expected F4, but got I
		//IL_008f: Expected native int or pointer, but got VT
		//IL_00a9: Expected F4, but got I
		//IL_00a4: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 48);
		float t = SpringLerp(strength, deltaTime);
		_ = from.z;
		_ = from.x;
		((Quaternion*)(nint)quaternion)->z = to.z;
		((Quaternion*)(nint)quaternion)->x = to.x;
		Quaternion a = (Quaternion)(quaternion + 16);
		Quaternion quaternion2 = Quaternion.Slerp(a, quaternion, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
		Quaternion quaternion3 = default;
		((Quaternion*)(nint)quaternion3)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
		((Quaternion*)(nint)quaternion3)->x = 0f;
		return quaternion3;
	}

	public static float RotateTowards(float from, float to, float maxAngle)
	{
		float angle = to - from;
		float num = WrapAngle(angle);
		float num2 = Math.Abs(num);
		float num4;
		if (maxAngle < num2)
		{
			bool flag = !(num < 0f);
			float num3 = 1f;
			if (!flag)
			{
				num3 = -1f;
			}
			num4 = maxAngle * num3;
		}
		else
		{
			num4 = num;
		}
		return from + num4;
	}

	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		float num = b.x - a.x;
		float num2 = num * num;
		float num3 = b.y - a.y;
		float num4 = num3 * num3;
		float num5 = num2 + num4;
		float num6 = point.x - a.x;
		float num7 = point.y - a.y;
		float result;
		if (num5 != 0f)
		{
			float num8 = b.x - a.x;
			float num9 = num6 * num8;
			float num10 = b.y - a.y;
			float num11 = num7 * num10;
			float num12 = num9 + num11;
			float num13 = num12 / num5;
			if (num13 < 0f)
			{
				float num14 = point.x - a.x;
				float num15 = point.y - a.y;
				float num16 = num14 * num14;
				float num17 = num15 * num15;
				result = num16 + num17;
			}
			else if (num13 > 1f)
			{
				float num18 = point.x - b.x;
				float num19 = point.y - b.y;
				float num20 = num18 * num18;
				float num21 = num19 * num19;
				result = num20 + num21;
			}
			else
			{
				float num22 = b.x - a.x;
				float num23 = num22 * num13;
				float num24 = a.x + num23;
				float num25 = point.x - num24;
				float num26 = b.y - a.y;
				float num27 = num26 * num13;
				float num28 = a.y + num27;
				float num29 = point.y - num28;
				float num30 = num25 * num25;
				float num31 = num29 * num29;
				result = num30 + num31;
			}
		}
		else
		{
			float num32 = num6 * num6;
			float num33 = num7 * num7;
			result = num32 + num33;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		return result;
	}

	public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_01e5: Expected Obj, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00aa: Invalid comparison between F4 and I
		//IL_00c6: Expected Obj, but got I
		//IL_00d3: Invalid comparison between F4 and Obj
		//IL_0112: Expected Obj, but got I
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected I4, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0294: Expected Obj, but got I
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		int val = 4;
		int num = default;
		object obj8 = default;
		object obj9 = default;
		int num13 = default;
		while (num < 5)
		{
			int num2 = RepeatIndex(num, 4);
			int num3 = num2 << 3;
			object obj3 = screenPoints + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v29+10]");
			_ = 0;
			int num4 = RepeatIndex(val, 4);
			int num5 = num4 << 3;
			object obj4 = screenPoints + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v32+10]");
			_ = 0;
			float y = mousePos.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			bool flag = y < 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			object obj5 = (nint)0 >> 32;
			float y2 = mousePos.y;
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)y2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
			if (flag != flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				object obj6 = num6 - 0;
				float num7 = mousePos.y;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				float num8 = num7 - 0f;
				float num9 = (float)obj6 * num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				object obj7 = obj5 - 0;
				float num10 = num9 / (float)obj7;
				float num11 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				float num12 = num11 + 0f;
				if (mousePos.x < num12)
				{
					obj8 = obj9 ^ 1;
				}
			}
			num = num13 + 1;
			val = num;
		}
		object obj10 = obj8 & 1;
		float num14 = 0f;
		if (obj10 == null)
		{
			object obj11 = 0;
			num14 = -1f;
			float num17 = default;
			while ((nint)obj11 < 4)
			{
				object obj12 = obj11 << 3;
				object obj13 = (object)screenPoints + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v10+10]");
				_ = 0;
				int val2 = obj11 + 1;
				int num15 = RepeatIndex(val2, 4);
				int num16 = num15 << 3;
				object obj14 = screenPoints + num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v13+10]");
				_ = 0;
				_ = mousePos.x;
				_ = mousePos.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				obj = 0;
				object obj15 = obj + 16;
				object obj16 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38AE");
				bool flag3 = num14 > num17;
				float num18 = num17;
				if (!flag3)
				{
					num18 = num14;
				}
				if (!(num14 < 0f))
				{
					num17 = num18;
				}
				object obj17 = obj11 + 1;
				obj11 = obj17;
				num14 = num17;
			}
		}
		return num14;
	}

	public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected VT, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected VT, but got Unknown
		//IL_00af: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = default;
		object obj6 = default;
		Vector2[] array = default;
		while ((nint)obj3 < 4)
		{
			object obj4 = obj - -64;
			object obj5 = obj6 * 12;
			object obj7 = (object)worldPoints + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v14+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v14+10]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			Vector3 position = (Vector3)(obj + 8);
			Vector3 vector = cam.WorldToScreenPoint(position);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			obj = 0;
			object obj8 = obj6 << 3;
			object obj9 = (object)array + obj8;
			obj3 = obj6 + 1;
		}
		_ = mousePos.x;
		_ = mousePos.x;
		Vector2 mousePos2 = (Vector2)(obj + 24);
		return DistanceToRectangle(array, mousePos2);
	}

	public unsafe static Vector2 GetPivotOffset(UIWidget.Pivot pv)
	{
		//IL_0084: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_00e7: Expected native int or pointer, but got VT
		//IL_00f9: Expected F4, but got Obj
		//IL_00f4: Expected native int or pointer, but got VT
		//IL_0034: Expected Obj, but got I4
		object obj = pv - 1;
		object obj3 = default;
		if ((nint)obj <= 7)
		{
			object obj2 = obj << 2;
			obj3 = obj2 + 2293312;
		}
		float y;
		if (pv >= UIWidget.Pivot.Left)
		{
			object obj4 = pv - 3;
			bool flag = (nint)obj4 < 3;
			y = 0.5f;
			if (!flag)
			{
				y = 0f;
			}
		}
		else
		{
			y = 1f;
		}
		Vector2 vector = default;
		((Vector2*)(nint)vector)->y = y;
		((Vector2*)(nint)vector)->x = (float)obj3;
		return vector;
	}

	public static UIWidget.Pivot GetPivot(Vector2 offset)
	{
		UIWidget.Pivot result;
		if (offset.x == 0f)
		{
			bool flag = offset.y == 0f;
			result = UIWidget.Pivot.BottomLeft;
			if (!flag)
			{
				bool flag2 = offset.y == 1f;
				result = UIWidget.Pivot.TopLeft;
				if (!flag2)
				{
					return UIWidget.Pivot.Left;
				}
			}
		}
		else if (offset.x == 1f)
		{
			bool flag3 = offset.y == 0f;
			result = UIWidget.Pivot.BottomRight;
			if (!flag3)
			{
				bool flag4 = offset.y == 1f;
				result = UIWidget.Pivot.TopRight;
				if (!flag4)
				{
					return UIWidget.Pivot.Right;
				}
			}
		}
		else
		{
			bool flag5 = offset.y == 0f;
			result = UIWidget.Pivot.Bottom;
			if (!flag5)
			{
				bool flag6 = offset.y == 1f;
				result = UIWidget.Pivot.Top;
				if (!flag6)
				{
					result = UIWidget.Pivot.Center;
				}
			}
		}
		return result;
	}

	public static void MoveWidget(UIRect w, float x, float y)
	{
		MoveRect(w, x, y);
	}

	public unsafe static void MoveRect(UIRect rect, float x, float y)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0029: Expected F8, but got I4
		//IL_0044: Expected F8, but got I4
		//IL_0255: Expected F4, but got I
		//IL_0250: Expected native int or pointer, but got VT
		//IL_0274: Expected F4, but got I
		//IL_026f: Expected native int or pointer, but got VT
		//IL_00b4: Expected I4, but got F8
		//IL_00bd: Expected Obj, but got I4
		//IL_00f0: Expected I4, but got F8
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0139: Expected I4, but got F8
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0182: Expected I4, but got F8
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		float num = x + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num2 = Math.Abs((double)num);
		double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : ((double)num));
		float num4 = y + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num5 = Math.Abs((double)num4);
		double num6 = ((!(num5 < 2147483648.0)) ? (-2147483648.0) : ((double)num4));
		Transform cachedTransform = rect.cachedTransform;
		Vector3 localPosition = cachedTransform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		double num7 = 0.0 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		double num8 = 0.0 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num9 = 0f + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		cachedTransform.localPosition = vector;
		UIRect.AnchorPoint leftAnchor = rect.leftAnchor;
		object obj2 = default;
		if ((bool)leftAnchor.target)
		{
			UIRect.AnchorPoint leftAnchor2 = rect.leftAnchor;
			double num10 = num3 + (double)leftAnchor2.absolute;
			leftAnchor2.absolute = (int)num10;
			obj2 = 1;
		}
		UIRect.AnchorPoint rightAnchor = rect.rightAnchor;
		if ((bool)rightAnchor.target)
		{
			UIRect.AnchorPoint rightAnchor2 = rect.rightAnchor;
			double num11 = num3 + (double)rightAnchor2.absolute;
			rightAnchor2.absolute = (int)num11;
			object obj3 = obj2 + 1;
			obj2 = obj3;
		}
		UIRect.AnchorPoint bottomAnchor = rect.bottomAnchor;
		if ((bool)bottomAnchor.target)
		{
			UIRect.AnchorPoint bottomAnchor2 = rect.bottomAnchor;
			double num12 = num6 + (double)bottomAnchor2.absolute;
			bottomAnchor2.absolute = (int)num12;
			object obj4 = obj2 + 1;
			obj2 = obj4;
		}
		UIRect.AnchorPoint topAnchor = rect.topAnchor;
		object obj5;
		if ((bool)topAnchor.target)
		{
			UIRect.AnchorPoint topAnchor2 = rect.topAnchor;
			double num13 = num6 + (double)topAnchor2.absolute;
			topAnchor2.absolute = (int)num13;
			obj5 = obj2 + 1;
		}
		else
		{
			obj5 = obj2;
		}
		if (obj5 != null)
		{
			rect.UpdateAnchors();
		}
	}

	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight)
	{
		ResizeWidget(w, pivot, x, y, 2, 2, 100000, 100000);
	}

	public unsafe static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected VT, but got Unknown
		//IL_01b9: Expected native int or pointer, but got VT
		//IL_0204: Expected F4, but got I
		//IL_01ff: Expected native int or pointer, but got VT
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected VT, but got Unknown
		//IL_03e6: Expected F4, but got I
		//IL_03e6: Expected F4, but got I
		//IL_0089: Expected F8, but got I4
		//IL_041f: Expected F4, but got I
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected Obj, but got Unknown
		//IL_045f: Expected F4, but got I
		//IL_045f: Expected F4, but got I
		//IL_00c8: Expected F8, but got I4
		//IL_03a6: Expected F4, but got I
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_0576: Expected Obj, but got F8
		//IL_0498: Expected F4, but got I
		//IL_036d: Expected F4, but got I
		//IL_036d: Expected F4, but got I
		//IL_0511: Expected F4, but got I
		//IL_04d8: Expected F4, but got I
		//IL_04d8: Expected F4, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		if (pivot == UIWidget.Pivot.Center)
		{
			float num = x - (float)w.mWidth;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num3 = default;
			double num2 = Math.Abs(num3);
			if (!(num2 < 2147483648.0))
			{
				num3 = -2147483648.0;
			}
			float num4 = y - (float)w.mHeight;
			object obj2 = num3 & 1;
			double num5 = num3 - (double)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num7 = default;
			double num6 = Math.Abs(num7);
			if (!(num6 < 2147483648.0))
			{
				num7 = -2147483648.0;
			}
			object obj3 = num7 & 1;
			double num8 = num7 - (double)obj3;
			object obj4 = num5 | num8;
			if (obj4 != null)
			{
				float num9 = num5 >> 1;
				float left = 0f - num9;
				float num10 = num8 >> 1;
				float bottom = 0f - num10;
				AdjustWidget(w, left, bottom, num9, num10, minWidth, minHeight);
			}
			return;
		}
		Transform cachedTransform = w.cachedTransform;
		Quaternion localRotation = cachedTransform.localRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Quaternion rotation = (Quaternion)(vector + 32);
		Quaternion quaternion = Quaternion.Inverse(rotation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector)->x = 0f;
		Quaternion quaternion2 = (Quaternion)(vector + 16);
		Vector3 vector2 = quaternion2 * vector;
		switch (pivot)
		{
		case UIWidget.Pivot.BottomLeft:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			AdjustWidget(w, num14, 0f, 0f, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		}
		case UIWidget.Pivot.Left:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			AdjustWidget(w, 0f, 0f, 0f, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		case UIWidget.Pivot.TopLeft:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			AdjustWidget(w, num13, 0f, 0f, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		}
		case UIWidget.Pivot.Top:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			AdjustWidget(w, 0f, 0f, 0f, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		case UIWidget.Pivot.TopRight:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			AdjustWidget(w, 0f, 0f, num12, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		}
		case UIWidget.Pivot.Right:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			AdjustWidget(w, 0f, 0f, 0f, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		case UIWidget.Pivot.BottomRight:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			AdjustWidget(w, 0f, num11, 0f, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		}
		case UIWidget.Pivot.Bottom:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			AdjustWidget(w, 0f, 0f, 0f, 0f, minWidth, minHeight, maxWidth, maxHeight);
			break;
		}
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top)
	{
		AdjustWidget(w, left, bottom, right, top, 2, 2, 100000, 100000);
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight)
	{
		AdjustWidget(w, left, bottom, right, top, minWidth, minHeight, 100000, 100000);
	}

	public unsafe static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0058: Expected F8, but got I4
		//IL_0073: Expected F8, but got I4
		//IL_008e: Expected F8, but got I4
		//IL_00a9: Expected F8, but got I4
		//IL_0f46: Invalid comparison between I and F4
		//IL_14d2: Invalid comparison between I and F4
		//IL_0fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd6: Expected VT, but got Unknown
		//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe4: Expected VT, but got Unknown
		//IL_103b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1040: Expected VT, but got Unknown
		//IL_1049: Unknown result type (might be due to invalid IL or missing references)
		//IL_104e: Expected VT, but got Unknown
		//IL_10a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10aa: Expected VT, but got Unknown
		//IL_10b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Expected VT, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected VT, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected VT, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected VT, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected VT, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected VT, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected VT, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected VT, but got Unknown
		//IL_00cd: Expected F8, but got I4
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected VT, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected VT, but got Unknown
		//IL_0122: Expected F8, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected F8, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected F8, but got Unknown
		//IL_10fa: Expected I, but got Obj
		//IL_111b: Invalid comparison between I and F4
		//IL_1132: Invalid comparison between I and F4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected F8, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected F8, but got Unknown
		//IL_1509: Expected F4, but got I
		//IL_1519: Expected F4, but got I
		//IL_114e: Expected I, but got Obj
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_115c: Expected Obj, but got Unknown
		//IL_152f: Expected I, but got Obj
		//IL_1538: Unknown result type (might be due to invalid IL or missing references)
		//IL_153d: Expected Obj, but got Unknown
		//IL_039e: Invalid comparison between I and F4
		//IL_0413: Invalid comparison between I and F4
		//IL_15ae: Expected I, but got Obj
		//IL_15c6: Invalid comparison between F8 and I4
		//IL_15d4: Expected F8, but got I4
		//IL_0488: Invalid comparison between I and F4
		//IL_03ce: Invalid comparison between I and F4
		//IL_03e4: Expected F4, but got I
		//IL_03f4: Expected F4, but got I
		//IL_11a8: Invalid comparison between F8 and I4
		//IL_11b6: Expected F8, but got I4
		//IL_04fd: Invalid comparison between I and F4
		//IL_0443: Invalid comparison between I and F4
		//IL_0459: Expected F4, but got I
		//IL_0469: Expected F4, but got I
		//IL_05ea: Invalid comparison between I and F4
		//IL_04b8: Invalid comparison between I and F4
		//IL_04ce: Expected F4, but got I
		//IL_04de: Expected F4, but got I
		//IL_0a3b: Expected F4, but got I
		//IL_0a50: Invalid comparison between I and F4
		//IL_06d7: Invalid comparison between I and F4
		//IL_0525: Invalid comparison between I and F4
		//IL_1200: Invalid comparison between F8 and I4
		//IL_0a18: Expected F8, but got VT
		//IL_0612: Invalid comparison between I and F4
		//IL_11cc: Invalid comparison between I4 and F8
		//IL_11da: Expected F8, but got I4
		//IL_0897: Invalid comparison between I and F4
		//IL_06ff: Invalid comparison between I and F4
		//IL_0559: Expected Obj, but got I
		//IL_059d: Expected Obj, but got I
		//IL_1611: Invalid comparison between I4 and F8
		//IL_161f: Expected F8, but got I4
		//IL_08e8: Invalid comparison between I and F4
		//IL_08fa: Expected F4, but got VT
		//IL_090a: Expected F4, but got I
		//IL_07d2: Invalid comparison between I and F4
		//IL_0646: Expected Obj, but got I
		//IL_068a: Expected Obj, but got I
		//IL_08c2: Expected F4, but got VT
		//IL_08d2: Expected F4, but got I
		//IL_0733: Expected Obj, but got I
		//IL_0777: Expected Obj, but got I
		//IL_0b6e: Expected F4, but got I
		//IL_0b83: Invalid comparison between I and F4
		//IL_0935: Expected Obj, but got I
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected Obj, but got Unknown
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected Obj, but got Unknown
		//IL_098c: Expected Obj, but got I
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected Obj, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected Obj, but got Unknown
		//IL_0806: Expected Obj, but got I
		//IL_084a: Expected Obj, but got I
		//IL_13b1: Invalid comparison between F8 and I4
		//IL_0b53: Expected F8, but got I
		//IL_1293: Expected Obj, but got I
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ec: Expected VT, but got Unknown
		//IL_12f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fa: Expected VT, but got Unknown
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected Obj, but got Unknown
		//IL_1368: Expected F4, but got I
		//IL_1363: Expected native int or pointer, but got VT
		//IL_1387: Expected F4, but got I
		//IL_1382: Expected native int or pointer, but got VT
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Expected I4, but got Unknown
		//IL_0c81: Invalid comparison between I and F4
		//IL_13ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d3: Expected I4, but got Unknown
		//IL_13e4: Invalid comparison between I and F4
		//IL_0c9d: Expected I4, but got F8
		//IL_0caa: Expected I4, but got F8
		object obj = default;
		Vector3 vector = (Vector3)(obj - 496);
		Vector2 pivotOffset = w.pivotOffset;
		Transform cachedTransform = w.cachedTransform;
		Quaternion localRotation = cachedTransform.localRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
		_ = 0;
		float num = left + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num2 = Math.Abs((double)num);
		double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : ((double)num));
		float num4 = bottom + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num5 = Math.Abs((double)num4);
		double num6 = ((!(num5 < 2147483648.0)) ? (-2147483648.0) : ((double)num4));
		float num7 = right + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num8 = Math.Abs((double)num7);
		double num9 = ((!(num8 < 2147483648.0)) ? (-2147483648.0) : ((double)num7));
		float num10 = top + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num11 = Math.Abs((double)num10);
		double num12 = ((!(num11 < 2147483648.0)) ? (-2147483648.0) : ((double)num10));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		bool flag = 0f != 0.5f;
		double num13 = num3;
		double num14 = num9;
		if (!flag)
		{
			double num15 = num3;
			if ((int)num9 == 0)
			{
				num15 = 0.0;
			}
			num13 = num3;
			num14 = num9;
			if ((int)num15 == 0)
			{
				double num16 = num9 & -2;
				double num17 = num3 & -2;
				num13 = num17;
				num14 = num16;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
		bool flag2 = 0f != 0.5f;
		double num18 = num6;
		double num19 = num12;
		if (!flag2)
		{
			double num20 = num6;
			if ((int)num12 == 0)
			{
				num20 = 0.0;
			}
			num18 = num6;
			num19 = num12;
			if ((int)num20 == 0)
			{
				double num21 = num12 & -2;
				double num22 = num6 & -2;
				num18 = num22;
				num19 = num21;
			}
		}
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1C0]");
		_ = 0;
		Quaternion quaternion = (Quaternion)(vector + 288);
		Vector3 vector2 = vector + 272;
		Vector3 vector3 = quaternion * vector2;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1B0]");
		_ = 0;
		Quaternion quaternion2 = (Quaternion)(vector + 256);
		Vector3 vector4 = vector + 240;
		Vector3 vector5 = quaternion2 * vector4;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
		_ = 0;
		Quaternion quaternion3 = (Quaternion)(vector + 224);
		Vector3 vector6 = vector + 208;
		Vector3 vector7 = quaternion3 * vector6;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+190]");
		_ = 0;
		Quaternion quaternion4 = (Quaternion)(vector + 192);
		Vector3 vector8 = vector + 176;
		Vector3 vector9 = quaternion4 * vector8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+188]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+180]");
		_ = 0;
		Quaternion quaternion5 = (Quaternion)(vector + 160);
		Vector3 vector10 = vector + 144;
		Vector3 vector11 = quaternion5 * vector10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+178]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+170]");
		_ = 0;
		Quaternion quaternion6 = (Quaternion)(vector + 128);
		Vector3 vector12 = vector + 112;
		Vector3 vector13 = quaternion6 * vector12;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+160]");
		_ = 0;
		Quaternion quaternion7 = (Quaternion)(vector + 96);
		Vector3 vector14 = vector + 80;
		Vector3 vector15 = quaternion7 * vector14;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
		_ = 0;
		Quaternion quaternion8 = (Quaternion)(vector - -64);
		Vector3 vector16 = vector + 48;
		Vector3 vector17 = quaternion8 * vector16;
		nint num23 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v178 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		bool flag3 = 0f == 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
		if (0f != 1f)
		{
			flag3 = false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
		float num25 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
		float num26 = 0f;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
			if (0f == 1f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
				bool flag4 = 0f == 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
				num25 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
				num26 = 0f;
				if (flag4)
				{
					goto IL_1146;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
			if (0f == 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
				bool flag5 = 0f == 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
				num25 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
				num26 = 0f;
				if (flag5)
				{
					goto IL_1146;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
			if (0f == 1f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
				bool flag6 = 0f == 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
				num25 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
				num26 = 0f;
				if (flag6)
				{
					goto IL_1146;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
			if (0f == 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
				if (0f == 0.5f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					nint num27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					object obj2 = num27 + 0;
					float num28 = (float)obj2 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					float num29 = 0f + num28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					nint num30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					object obj3 = num30 + 0;
					float num31 = (float)obj3 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					float num32 = 0f + num31;
					num25 = num29;
					num26 = num32;
					goto IL_1146;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
			if (0f == 1f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
				if (0f == 0.5f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					nint num33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					object obj4 = num33 + 0;
					float num34 = (float)obj4 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					float num35 = 0f + num34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					nint num36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					object obj5 = num36 + 0;
					float num37 = (float)obj5 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					float num38 = 0f + num37;
					num25 = num35;
					num26 = num38;
					goto IL_1146;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
			bool flag7 = 0f != 0.5f;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
				if (0f == 1f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					nint num39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					object obj6 = num39 + 0;
					float num40 = (float)obj6 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					float num41 = 0f + num40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					nint num42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					object obj7 = num42 + 0;
					float num43 = (float)obj7 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					float num44 = 0f + num43;
					num25 = num41;
					num26 = num44;
					goto IL_1146;
				}
			}
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
				if (0f == 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					nint num45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					object obj8 = num45 + 0;
					float num46 = (float)obj8 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					float num47 = 0f + num46;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					nint num48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					object obj9 = num48 + 0;
					float num49 = (float)obj9 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					float num50 = 0f + num49;
					num25 = num47;
					num26 = num50;
					goto IL_1146;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
			if (0f != 0.5f)
			{
				num25 = (float)Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v179 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
				num26 = 0f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
				bool flag8 = 0f != 0.5f;
				num25 = (float)Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v179 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
				num26 = 0f;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					nint num51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					object obj10 = num51 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					object obj11 = obj10 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
					object obj12 = obj11 + 0;
					float num52 = (float)obj12 * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					nint num53 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					object obj13 = num53 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					object obj14 = obj13 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
					object obj15 = obj14 + 0;
					float num54 = (float)obj15 * 0.5f;
					num25 = num52;
					num26 = num54;
				}
			}
		}
		goto IL_1146;
		IL_1146:
		nint num55 = (nint)w;
		object obj16 = w + 240;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v556 @ S2_v34 (Il2CppClass<UIWidget>)+1AC] (should have been resolved before IL gen)");
		int num56 = default;
		bool flag9 = minWidth > num56;
		int num57 = minWidth;
		if (!flag9)
		{
			num57 = num56;
		}
		nint num58 = (nint)w;
		object obj17 = w + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v583 @ S1_v139 (Il2CppClass<UIWidget>)+1B4] (should have been resolved before IL gen)");
		int num59 = default;
		bool flag10 = num59 < minHeight;
		double num60 = num14 + (double)w.mWidth;
		double num61 = num60 - num13;
		double num62 = num19 + (double)w.mHeight;
		double num63 = num62 - num18;
		int num64 = minHeight;
		if (!flag10)
		{
			num64 = num59;
		}
		nint num65 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ S0_v207 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num66 = 0;
		bool flag11 = num61 > (double)maxWidth;
		double num67 = maxWidth;
		if (!flag11)
		{
			num67 = num61;
		}
		bool flag12 = num61 < (double)num57;
		double num68 = num57;
		if (!flag12)
		{
			num68 = num67;
		}
		double num70;
		if (num68 == num61)
		{
			double num69 = (double)Vector3.zeroVector;
			num70 = num61;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
			float num71 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
			bool flag13 = 0f < 0f;
			float num72 = 0f;
			if (!flag13)
			{
				num72 = num71;
			}
			double num73 = num68 - num61;
			if (num13 != 0.0)
			{
				float num74 = 0f - (float)num73;
				float num75 = num74 * num72;
				double num76 = num73 + (double)num75;
				double num77 = (double)Vector3.zeroVector - num76;
				double num69 = num77;
				num70 = num68;
			}
			else
			{
				double num78 = num73 - 0.0;
				double num79 = num78 * (double)num72;
				double num80 = num79 + 0.0;
				double num81 = (double)Vector3.zeroVector + num80;
				double num69 = num81;
				num70 = num68;
			}
		}
		bool flag14 = (double)maxHeight < num63;
		double num82 = maxHeight;
		if (!flag14)
		{
			num82 = num63;
		}
		bool flag15 = (double)num64 > num63;
		double num83 = num64;
		if (!flag15)
		{
			num83 = num82;
		}
		double num84;
		if (num83 == num63)
		{
			num84 = num63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v208 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			double num85 = 0.0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
			float num86 = Math.Min(0f, 1f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
			bool flag16 = 0f < 0f;
			float num87 = 0f;
			if (!flag16)
			{
				num87 = num86;
			}
			double num88 = num83 - num63;
			if (num18 != 0.0)
			{
				float num89 = 0f - (float)num88;
				float num90 = num89 * num87;
				double num91 = num88 + (double)num90;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v208 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
				double num92 = 0.0 - num91;
				num84 = num83;
				double num85 = num92;
			}
			else
			{
				double num93 = num88 - 0.0;
				double num94 = num93 * (double)num87;
				double num95 = num94 + 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v208 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
				double num96 = 0.0 + num95;
				num84 = num83;
				double num85 = num96;
			}
		}
		Vector3 localPosition = cachedTransform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
		float num97 = 0f + num25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
		float num98 = 0f + num26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D8]");
		nint num99 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v179 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		object obj18 = num99 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v208 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+140]");
		_ = 0;
		Quaternion quaternion9 = (Quaternion)(vector + 32);
		Vector3 vector18 = vector + 16;
		Vector3 vector19 = quaternion9 * vector18;
		float num100 = num97;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
		float num101 = num100 + 0f;
		float num102 = num98;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D4]");
		float num103 = num102 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D8]");
		object obj19 = obj18 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
		((Vector3*)(nint)vector)->x = 0f;
		cachedTransform.localPosition = vector;
		int num104 = num70 & -2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		if (0f != 0.5f)
		{
			num104 = (int)num70;
		}
		int num105 = num84 & -2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
		if (0f != 0.5f)
		{
			num105 = (int)num84;
		}
		w.SetDimensions(num104, num105);
		if (w.isAnchored)
		{
			Transform parent = cachedTransform.parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
			float num106 = 0f * (float)num104;
			float num107 = num101 - num106;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E4]");
			float num108 = 0f * (float)num105;
			float num109 = num103 - num108;
			UIRect.AnchorPoint leftAnchor = w.leftAnchor;
			if ((bool)leftAnchor.target)
			{
				w.leftAnchor.SetHorizontal(parent, num107);
			}
			UIRect.AnchorPoint rightAnchor = w.rightAnchor;
			if ((bool)rightAnchor.target)
			{
				float localPos = num107 + (float)num104;
				w.rightAnchor.SetHorizontal(parent, localPos);
			}
			UIRect.AnchorPoint bottomAnchor = w.bottomAnchor;
			if ((bool)bottomAnchor.target)
			{
				w.bottomAnchor.SetVertical(parent, num109);
			}
			UIRect.AnchorPoint topAnchor = w.topAnchor;
			if ((bool)topAnchor.target)
			{
				float localPos2 = num109 + (float)num105;
				w.topAnchor.SetVertical(parent, localPos2);
			}
		}
	}

	public static int AdjustByDPI(float height)
	{
		//IL_009f: Expected F8, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_00c9: Expected I4, but got F8
		//IL_00bc: Expected I4, but got F8
		float dpi = Screen.dpi;
		RuntimePlatform platform = Application.platform;
		bool flag = platform == RuntimePlatform.IPhonePlayer;
		float num = 160f;
		if (!flag)
		{
			num = 96f;
		}
		bool flag2 = platform == RuntimePlatform.Android;
		float num2 = 160f;
		if (!flag2)
		{
			num2 = num;
		}
		if (dpi != 0f)
		{
			num2 = dpi;
		}
		float num3 = 96f / num2;
		float num4 = height * num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num6 = default;
		double num5 = Math.Abs(num6);
		if (!(num5 < 2147483648.0))
		{
			num6 = -2147483648.0;
		}
		object obj = num6 & 1;
		if (obj != null)
		{
			double num7 = num6 + 1.0;
			return (int)num7;
		}
		return (int)num6;
	}

	public unsafe static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected VT, but got Unknown
		//IL_00c4: Expected F4, but got I
		//IL_00bf: Expected native int or pointer, but got VT
		//IL_00e6: Expected F4, but got I
		//IL_00e1: Expected native int or pointer, but got VT
		//IL_0111: Expected F4, but got I
		//IL_010c: Expected native int or pointer, but got VT
		//IL_0059: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = 0;
		_ = 0;
		GameObject gameObject = relativeTo.gameObject;
		int layer = gameObject.layer;
		Camera camera = NGUITools.FindCameraForLayer(layer);
		Vector2 vector2 = default;
		if (camera == null)
		{
			((Vector2*)(nint)vector2)->x = pos.x;
		}
		else
		{
			_ = 0;
			_ = 0;
			_ = pos.x;
			_ = pos.x;
			Vector3 position = vector + 16;
			Vector3 vector3 = camera.ScreenToWorldPoint(position);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 vector4 = relativeTo.InverseTransformPoint(vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector2*)(nint)vector2)->x = 0f;
		}
		return vector2;
	}

	public unsafe static Vector2 ScreenToParentPixels(Vector2 pos, Transform relativeTo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected VT, but got Unknown
		//IL_0085: Expected native int or pointer, but got VT
		//IL_0191: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I
		//IL_0204: Expected F4, but got Obj
		//IL_020c: Expected native int or pointer, but got VT
		//IL_011c: Expected F4, but got I
		//IL_0117: Expected native int or pointer, but got VT
		//IL_014b: Expected F4, but got I
		//IL_0146: Expected native int or pointer, but got VT
		//IL_016c: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Transform transform = default;
		GameObject gameObject = transform.gameObject;
		int layer = gameObject.layer;
		Transform parent = transform.parent;
		Transform parent2 = default;
		if (parent != null)
		{
			parent2 = transform.parent;
		}
		Camera camera = NGUITools.FindCameraForLayer(layer);
		Vector2 vector2 = default;
		if (camera == null)
		{
			((Vector2*)(nint)vector2)->x = pos.x;
		}
		else
		{
			_ = 0;
			_ = 0;
			_ = pos.x;
			_ = pos.x;
			Vector3 position = vector + 16;
			Vector3 vector3 = camera.ScreenToWorldPoint(position);
			object obj2;
			object obj3;
			if (parent2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				Vector3 vector4 = parent2.InverseTransformPoint(vector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				obj3 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				obj2 = 0;
			}
			object obj4 = obj3 << 32;
			float x = obj2 | obj4;
			((Vector2*)(nint)vector2)->x = x;
		}
		return vector2;
	}

	public unsafe static Vector3 WorldToLocalPoint(Vector3 worldPos, Camera worldCam, Camera uiCam, Transform relativeTo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected VT, but got Unknown
		//IL_0171: Expected F4, but got I
		//IL_016c: Expected native int or pointer, but got VT
		//IL_0186: Expected F4, but got I
		//IL_0181: Expected native int or pointer, but got VT
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected VT, but got Unknown
		//IL_01ce: Expected F4, but got I
		//IL_01c9: Expected native int or pointer, but got VT
		//IL_01e3: Expected F4, but got I
		//IL_01de: Expected native int or pointer, but got VT
		//IL_0047: Expected native int or pointer, but got VT
		//IL_0059: Expected native int or pointer, but got VT
		//IL_00d2: Expected native int or pointer, but got VT
		//IL_00e4: Expected native int or pointer, but got VT
		//IL_010f: Expected F4, but got I
		//IL_010a: Expected native int or pointer, but got VT
		//IL_0124: Expected F4, but got I
		//IL_011f: Expected native int or pointer, but got VT
		//IL_00a9: Expected native int or pointer, but got VT
		//IL_00bb: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		_ = worldPos.z;
		_ = worldPos.x;
		Vector3 position = vector + 32;
		Vector3 vector2 = worldCam.WorldToViewportPoint(position);
		Vector3 vector3 = worldPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = worldPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector4)->x = 0f;
		_ = worldPos.z;
		_ = worldPos.x;
		Vector3 position2 = vector + 16;
		Vector3 vector5 = uiCam.ViewportToWorldPoint(position2);
		Vector3 vector6 = worldPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector6)->z = 0f;
		Vector3 vector7 = worldPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector7)->x = 0f;
		Vector3 vector8 = default;
		if (relativeTo == null)
		{
			((Vector3*)(nint)vector8)->x = worldPos.x;
			((Vector3*)(nint)vector8)->z = worldPos.z;
		}
		else
		{
			Transform parent = relativeTo.parent;
			if (parent == null)
			{
				((Vector3*)(nint)vector8)->x = worldPos.x;
				((Vector3*)(nint)vector8)->z = worldPos.z;
			}
			else
			{
				((Vector3*)(nint)vector)->z = worldPos.z;
				((Vector3*)(nint)vector)->x = worldPos.x;
				Vector3 vector9 = parent.InverseTransformPoint(vector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				((Vector3*)(nint)vector8)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				((Vector3*)(nint)vector8)->x = 0f;
			}
		}
		return vector8;
	}

	public unsafe static void OverlayPosition(Transform trans, Vector3 worldPos, Camera worldCam, Camera myCam)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected VT, but got Unknown
		//IL_00fe: Expected F4, but got I
		//IL_00f9: Expected native int or pointer, but got VT
		//IL_0113: Expected F4, but got I
		//IL_010e: Expected native int or pointer, but got VT
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected VT, but got Unknown
		//IL_015b: Expected F4, but got I
		//IL_0156: Expected native int or pointer, but got VT
		//IL_0170: Expected F4, but got I
		//IL_016b: Expected native int or pointer, but got VT
		//IL_0197: Expected F4, but got I
		//IL_0192: Expected native int or pointer, but got VT
		//IL_01ac: Expected F4, but got I
		//IL_01a7: Expected native int or pointer, but got VT
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		_ = 0;
		_ = 0;
		_ = worldPos.z;
		_ = worldPos.x;
		Vector3 position = vector + 48;
		Vector3 vector2 = worldCam.WorldToViewportPoint(position);
		Vector3 vector3 = worldPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = worldPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector4)->x = 0f;
		_ = worldPos.z;
		_ = worldPos.x;
		Vector3 position2 = vector + 32;
		Vector3 vector5 = myCam.ViewportToWorldPoint(position2);
		Vector3 vector6 = worldPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector6)->z = 0f;
		Vector3 vector7 = worldPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector7)->x = 0f;
		Transform parent = trans.parent;
		if (parent != null)
		{
			_ = worldPos.z;
			_ = worldPos.x;
			Vector3 position3 = vector + 16;
			Vector3 vector8 = parent.InverseTransformPoint(position3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
		}
		else
		{
			_ = worldPos.z;
			_ = worldPos.x;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		((Vector3*)(nint)vector)->x = 0f;
		trans.localPosition = vector;
	}

	public unsafe static void OverlayPosition(Transform trans, Vector3 worldPos, Camera worldCam)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0059: Expected native int or pointer, but got VT
		//IL_006b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		GameObject gameObject = trans.gameObject;
		int layer = gameObject.layer;
		Camera camera = NGUITools.FindCameraForLayer(layer);
		if (camera != null)
		{
			((Vector3*)(nint)vector)->z = worldPos.z;
			((Vector3*)(nint)vector)->x = worldPos.x;
			OverlayPosition(trans, vector, worldCam, camera);
		}
	}

	public unsafe static void OverlayPosition(Transform trans, Transform target)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00d8: Expected F4, but got I
		//IL_00d3: Expected native int or pointer, but got VT
		//IL_00fa: Expected F4, but got I
		//IL_00f5: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		GameObject gameObject = trans.gameObject;
		int layer = gameObject.layer;
		Camera camera = NGUITools.FindCameraForLayer(layer);
		GameObject gameObject2 = target.gameObject;
		int layer2 = gameObject2.layer;
		Camera camera2 = NGUITools.FindCameraForLayer(layer2);
		if (camera != null && camera2 != null)
		{
			Vector3 position = target.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			OverlayPosition(trans, vector, camera2, camera);
		}
	}
}
