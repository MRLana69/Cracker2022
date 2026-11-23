using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Info;
using UnityEngine;

public class HoverboardThemes
{
	public class HoverboardTheme
	{
		public int price;

		public PurchaseData.UnlockType unlockType;

		public Color32 buttonBgColor;

		public Color32 buttonIconColor;

		public bool isNewInThisUpdate;

		public StringID title;

		public UIOrder uiOrder;

		public Hoverboard.BoardAbility power;

		public ThemeIdentifier identifier;

		public string iconName;
	}

	public enum UIOrder
	{
		First,
		Second
	}

	public enum ThemeIdentifier
	{
		none,
		heroboardTheme01,
		heroboardTheme02,
		starboardTheme01,
		starboardTheme02,
		greatWhiteTheme01,
		greatWhiteTheme02,
		surfboardTheme01,
		surfboardTheme02,
		monsterTheme1,
		monsterTheme2,
		snowboardTheme1,
		snowboardTheme2,
		miamiTheme1,
		miamiTheme2,
		skullfireTheme1,
		romeTheme01,
		skullfireTheme02,
		lumberjackTheme01,
		lumberjackTheme02,
		romeTheme02,
		londonBoard01Theme01,
		londonBoard01Theme02,
		chicky01Theme01,
		chicky01Theme02,
		veniceBoard02Theme01,
		transylvaniaBoard01Theme01,
		sanfranciscoBoard01Theme01,
		arabiaBoard01Theme01,
		bangkokBoard01Theme01
	}

	public static readonly Dictionary<Hoverboards.BoardType, List<HoverboardTheme>> hoverboardCustomThemes;

	public static string GetBoardPowerName(Hoverboards.BoardType board, Hoverboard.BoardAbility power)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03fc: Expected Obj, but got I
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		string result;
		if (obj6 != null)
		{
			object obj7 = obj + 8;
			List<HoverboardTheme> list = hoverboardCustomThemes.get_Item(board);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj8 = obj + 24;
			obj = obj8;
			_ = 0;
			object obj10 = default;
			string text = default;
			object obj13 = default;
			object obj14 = default;
			string text2 = default;
			string text3 = default;
			string result2 = default;
			while (true)
			{
				_ = 0;
				object obj9 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj10 == null)
					{
						goto IL_02b3;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
					object obj11 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v109+24]");
						if ((nint)0 != (nint)power)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
								object obj12 = obj + 8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A71");
								result = text;
								break;
							}
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj13 != obj14;
				result = text2;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_02b3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result = text3;
				}
				_ = 0;
				object obj15 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return result2;
				IL_02b3:
				object obj16 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A71");
				Enum obj17 = (Enum)(obj + 8);
				_ = -1;
				obj17 = (Enum)(object)typeof(Hoverboards.BoardType);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				_ = 0;
				string text4 = obj17.ToString();
				string text5 = "No board theme of type " + text4 + " not found. Returning empty string.";
				result = string.Empty;
				break;
			}
		}
		else
		{
			Enum obj18 = (Enum)(obj + 8);
			_ = -1;
			obj18 = (Enum)(object)typeof(Hoverboards.BoardType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			_ = 0;
			string text6 = obj18.ToString();
			string text7 = "No board themes exist for board type: " + text6 + ". Returning empty string.";
			result = string.Empty;
		}
		return result;
	}

	public static ThemeIdentifier GetThemeIdentifier(Hoverboards.BoardType bType, int tIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_0141: Expected Obj, but got I
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		ThemeIdentifier result = default;
		if (tIndex >= 0)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+54]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 ^ -1;
			object obj6 = obj4 >> 31;
			if (obj6 != null)
			{
				object obj7 = obj + 16;
				List<HoverboardTheme> list = hoverboardCustomThemes.get_Item(bType);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				object obj8 = obj + 32;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj10 = default;
				object obj12 = default;
				object obj13 = default;
				ThemeIdentifier themeIdentifier = default;
				ThemeIdentifier themeIdentifier2 = default;
				ThemeIdentifier result2 = default;
				while (true)
				{
					_ = 0;
					object obj9 = obj + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						if (obj10 == null)
						{
							result = ThemeIdentifier.none;
							break;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj11 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v80+20]");
							if ((nint)0 == tIndex)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v80+28]");
								result = ThemeIdentifier.none;
								break;
							}
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag = obj12 == obj13;
					bool flag2 = !flag;
					result = themeIdentifier;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 != 1;
						result = ThemeIdentifier.none;
						if (flag3)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						result = themeIdentifier2;
					}
					_ = 0;
					object obj14 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return result2;
				}
				object obj15 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A71");
			}
		}
		return result;
	}

	public unsafe static List<HoverboardTheme> TryGetCustomThemesForBoard(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Ref, but got Unknown
		//IL_004a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = hoverboardCustomThemes.TryGetValue(boardType, out *(List<HoverboardTheme>*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (List<HoverboardTheme>)0;
	}

	public static void VerifyData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02f5: Expected Obj, but got I
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_028c: Expected Obj, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		object obj4 = obj + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		object obj5 = obj + 56;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj7 = default;
		object obj8;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj7 == null;
				obj8 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						_ = 0;
						object obj9 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj10 == obj11;
			bool flag3 = !flag2;
			object obj12 = obj13;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj8 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
			}
			_ = 0;
			object obj15 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj8 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj16 = obj8 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1981");
	}

	private static void ValidateUIOrder(KeyValuePair<Hoverboards.BoardType, List<HoverboardTheme>> themeSet)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0492: Expected VT, but got Obj
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I
		//IL_0460: Expected Obj, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(UIOrder));
		Array values = Enum.GetValues(typeFromHandle);
		IEnumerable<UIOrder> source = Enumerable.Cast<UIOrder>(values);
		List<UIOrder> list = Enumerable.ToList(source);
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 32;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		object obj16 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				object obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
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
						if (obj9 != null)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = -1;
								_ = typeof(Hoverboards.BoardType);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
								_ = 0;
								_ = 0;
								object obj10 = obj + 8;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
			bool flag2 = obj11 == obj12;
			bool flag3 = !flag2;
			object obj13 = obj14;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				obj = obj15;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				object obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj13 = obj16;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A71");
	}

	static HoverboardThemes()
	{
		//IL_0017: Expected I4, but got I8
		//IL_0066: Expected I4, but got I8
		//IL_0098: Expected I4, but got I8
		//IL_00b8: Expected I4, but got I8
		//IL_00e6: Expected I4, but got I8
		//IL_011d: Expected Obj, but got I
		//IL_014c: Expected I4, but got I8
		//IL_0196: Expected I4, but got I8
		//IL_01c8: Expected I4, but got I8
		//IL_01e8: Expected I4, but got I8
		//IL_0216: Expected I4, but got I8
		//IL_024d: Expected Obj, but got I
		//IL_027c: Expected I4, but got I8
		//IL_02c6: Expected I4, but got I8
		//IL_02f8: Expected I4, but got I8
		//IL_0318: Expected I4, but got I8
		//IL_0346: Expected I4, but got I8
		//IL_037d: Expected Obj, but got I
		//IL_03ac: Expected I4, but got I8
		//IL_03f6: Expected I4, but got I8
		//IL_0428: Expected I4, but got I8
		//IL_0448: Expected I4, but got I8
		//IL_0476: Expected I4, but got I8
		//IL_04ad: Expected Obj, but got I
		//IL_04dc: Expected I4, but got I8
		//IL_0526: Expected I4, but got I8
		//IL_0558: Expected I4, but got I8
		//IL_0578: Expected I4, but got I8
		//IL_05a6: Expected I4, but got I8
		//IL_05dd: Expected Obj, but got I
		//IL_060c: Expected I4, but got I8
		//IL_0656: Expected I4, but got I8
		//IL_0688: Expected I4, but got I8
		//IL_06a8: Expected I4, but got I8
		//IL_06d6: Expected I4, but got I8
		//IL_070d: Expected Obj, but got I
		//IL_073c: Expected I4, but got I8
		//IL_0786: Expected I4, but got I8
		//IL_07bd: Expected Obj, but got I
		//IL_07ec: Expected I4, but got I8
		//IL_0836: Expected I4, but got I8
		//IL_086d: Expected Obj, but got I
		//IL_089c: Expected I4, but got I8
		//IL_08e6: Expected I4, but got I8
		//IL_091d: Expected Obj, but got I
		//IL_094c: Expected I4, but got I8
		//IL_0996: Expected I4, but got I8
		//IL_09cd: Expected Obj, but got I
		//IL_09fc: Expected I4, but got I8
		//IL_0a46: Expected I4, but got I8
		//IL_0a7d: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>>)+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list = default;
		list._002Ector();
		HoverboardTheme hoverboardTheme = default;
		hoverboardTheme.price = 80;
		hoverboardTheme.buttonBgColor = GlobalColors.HOVERBOARD_THEME_HERO_TELEPORT_FILL;
		hoverboardTheme.title = StringID.HOVERBOARD_THEME_HERO_TELEPORT_TITLE;
		hoverboardTheme.isNewInThisUpdate = false;
		hoverboardTheme.buttonIconColor = GlobalColors.HOVERBOARD_THEME_HERO_TELEPORT_ICON;
		hoverboardTheme.power = Hoverboard.BoardAbility.Teleport;
		hoverboardTheme.iconName = "icon_upgrade_zap_sideways";
		list.Add(hoverboardTheme);
		HoverboardTheme hoverboardTheme2 = default;
		hoverboardTheme2.price = 110;
		hoverboardTheme2.buttonBgColor = GlobalColors.HOVERBOARD_THEME_HERO_SUPER_JUMP_FILL;
		hoverboardTheme2.title = StringID.HOVERBOARD_THEME_HERO_SUPER_JUMP_TITLE;
		hoverboardTheme2.isNewInThisUpdate = false;
		hoverboardTheme2.buttonIconColor = GlobalColors.HOVERBOARD_THEME_HERO_SUPER_JUMP_ICON;
		hoverboardTheme2.power = Hoverboard.BoardAbility.Jumper;
		hoverboardTheme2.iconName = "icon_upgrade_super_jump";
		list.Add(hoverboardTheme2);
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S5_v4+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list2 = default;
		list2._002Ector();
		HoverboardTheme hoverboardTheme3 = default;
		hoverboardTheme3.price = 100;
		hoverboardTheme3.buttonBgColor = GlobalColors.HOVERBOARD_THEME_GREAT_WHITE_SPEEDUP_FILL;
		hoverboardTheme3.title = StringID.HOVERBOARD_THEME_GREAT_WHITE_SPEEDUP_TITLE;
		hoverboardTheme3.isNewInThisUpdate = false;
		hoverboardTheme3.buttonIconColor = GlobalColors.HOVERBOARD_THEME_GREAT_WHITE_SPEEDUP_ICON;
		hoverboardTheme3.power = Hoverboard.BoardAbility.HighSpeed;
		hoverboardTheme3.iconName = "icon_upgrade_speed_up";
		list2.Add(hoverboardTheme3);
		HoverboardTheme hoverboardTheme4 = default;
		hoverboardTheme4.price = 150;
		hoverboardTheme4.buttonBgColor = GlobalColors.HOVERBOARD_THEME_GREAT_WHITE_GLIDER_FILL;
		hoverboardTheme4.title = StringID.HOVERBOARD_THEME_GREAT_WHITE_GLIDER_TITLE;
		hoverboardTheme4.isNewInThisUpdate = false;
		hoverboardTheme4.buttonIconColor = GlobalColors.HOVERBOARD_THEME_GREAT_WHITE_GLIDER_ICON;
		hoverboardTheme4.power = Hoverboard.BoardAbility.Glider;
		hoverboardTheme4.iconName = "icon_upgrade_smooth_drift";
		list2.Add(hoverboardTheme4);
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ S5_v9+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list3 = default;
		list3._002Ector();
		HoverboardTheme hoverboardTheme5 = default;
		hoverboardTheme5.price = 130;
		hoverboardTheme5.buttonBgColor = GlobalColors.HOVERBOARD_THEME_SURF_BOARD_LOWRIDER_FILL;
		hoverboardTheme5.title = StringID.HOVERBOARD_THEME_SURF_BOARD_LOWRIDER_TITLE;
		hoverboardTheme5.isNewInThisUpdate = false;
		hoverboardTheme5.buttonIconColor = GlobalColors.HOVERBOARD_THEME_SURF_BOARD_LOWRIDER_ICON;
		hoverboardTheme5.power = Hoverboard.BoardAbility.Lowrider;
		hoverboardTheme5.iconName = "icon_upgrade_stay_low";
		list3.Add(hoverboardTheme5);
		HoverboardTheme hoverboardTheme6 = default;
		hoverboardTheme6.price = 150;
		hoverboardTheme6.buttonBgColor = GlobalColors.HOVERBOARD_THEME_SURF_BOARD_GLIDER_FILL;
		hoverboardTheme6.title = StringID.HOVERBOARD_THEME_SURF_BOARD_GLIDER_TITLE;
		hoverboardTheme6.isNewInThisUpdate = false;
		hoverboardTheme6.buttonIconColor = GlobalColors.HOVERBOARD_THEME_SURF_BOARD_GLIDER_ICON;
		hoverboardTheme6.power = Hoverboard.BoardAbility.Glider;
		hoverboardTheme6.iconName = "icon_upgrade_smooth_drift";
		list3.Add(hoverboardTheme6);
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v291 @ S5_v14+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list4 = default;
		list4._002Ector();
		HoverboardTheme hoverboardTheme7 = default;
		hoverboardTheme7.price = 80;
		hoverboardTheme7.buttonBgColor = GlobalColors.HOVERBOARD_THEME_ROME_ZAPSIDEWAYS_FILL;
		hoverboardTheme7.title = StringID.HOVERBOARD_THEME_ROME_ZAPSIDEWAYS_TITLE;
		hoverboardTheme7.isNewInThisUpdate = false;
		hoverboardTheme7.buttonIconColor = GlobalColors.HOVERBOARD_THEME_ROME_ZAPSIDEWAYS_ICON;
		hoverboardTheme7.power = Hoverboard.BoardAbility.Teleport;
		hoverboardTheme7.iconName = "icon_upgrade_zap_sideways";
		list4.Add(hoverboardTheme7);
		HoverboardTheme hoverboardTheme8 = default;
		hoverboardTheme8.price = 100;
		hoverboardTheme8.buttonBgColor = GlobalColors.HOVERBOARD_THEME_ROME_SPEEDUP_FILL;
		hoverboardTheme8.title = StringID.HOVERBOARD_THEME_ROME_SPEEDUP_TITLE;
		hoverboardTheme8.isNewInThisUpdate = false;
		hoverboardTheme8.buttonIconColor = GlobalColors.HOVERBOARD_THEME_ROME_SPEEDUP_ICON;
		hoverboardTheme8.power = Hoverboard.BoardAbility.HighSpeed;
		hoverboardTheme8.iconName = "icon_upgrade_speed_up";
		list4.Add(hoverboardTheme8);
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v373 @ S5_v19+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list5 = default;
		list5._002Ector();
		HoverboardTheme hoverboardTheme9 = default;
		hoverboardTheme9.price = 0;
		hoverboardTheme9.buttonBgColor = GlobalColors.HOVERBOARD_THEME_LONDONBOARD01_TRAIL_FILL;
		hoverboardTheme9.title = StringID.HOVERBOARD_THEME_LONDONBOARD01_TRAIL_TITLE;
		hoverboardTheme9.isNewInThisUpdate = false;
		hoverboardTheme9.buttonIconColor = GlobalColors.HOVERBOARD_THEME_LONDONBOARD01_TRAIL_ICON;
		hoverboardTheme9.power = Hoverboard.BoardAbility.Vanity;
		hoverboardTheme9.iconName = "icon_upgrade_snow_trail";
		list5.Add(hoverboardTheme9);
		HoverboardTheme hoverboardTheme10 = default;
		hoverboardTheme10.price = 110;
		hoverboardTheme10.buttonBgColor = GlobalColors.HOVERBOARD_THEME_LONDONBOARD01_SUPER_JUMP_FILL;
		hoverboardTheme10.title = StringID.HOVERBOARD_THEME_LONDONBOARD01_SUPER_JUMP_TITLE;
		hoverboardTheme10.isNewInThisUpdate = false;
		hoverboardTheme10.buttonIconColor = GlobalColors.HOVERBOARD_THEME_LONDONBOARD01_SUPER_JUMP_ICON;
		hoverboardTheme10.power = Hoverboard.BoardAbility.Jumper;
		hoverboardTheme10.iconName = "icon_upgrade_super_jump";
		list5.Add(hoverboardTheme10);
		nint num11 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v455 @ S5_v24+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list6 = default;
		list6._002Ector();
		HoverboardTheme hoverboardTheme11 = default;
		hoverboardTheme11.price = 0;
		hoverboardTheme11.buttonBgColor = GlobalColors.HOVERBOARD_THEME_CHICK_TRAIL_FILL;
		hoverboardTheme11.title = StringID.HOVERBOARD_THEME_CHICKY_TRAIL_TITLE;
		hoverboardTheme11.isNewInThisUpdate = false;
		hoverboardTheme11.buttonIconColor = GlobalColors.HOVERBOARD_THEME_CHICK_TRAIL_ICON;
		hoverboardTheme11.power = Hoverboard.BoardAbility.Vanity;
		hoverboardTheme11.iconName = "icon_feather";
		list6.Add(hoverboardTheme11);
		HoverboardTheme hoverboardTheme12 = default;
		hoverboardTheme12.price = 110;
		hoverboardTheme12.buttonBgColor = GlobalColors.HOVERBOARD_THEME_CHICK_SPEEDUP_FILL;
		hoverboardTheme12.title = StringID.HOVERBOARD_THEME_CHICKY_SPEED_TITLE;
		hoverboardTheme12.isNewInThisUpdate = false;
		hoverboardTheme12.buttonIconColor = GlobalColors.HOVERBOARD_THEME_CHICK_SPEEDUP_ICON;
		hoverboardTheme12.power = Hoverboard.BoardAbility.HighSpeed;
		hoverboardTheme12.iconName = "icon_upgrade_speed_up";
		list6.Add(hoverboardTheme12);
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v537 @ S5_v29+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list7 = default;
		list7._002Ector();
		HoverboardTheme hoverboardTheme13 = default;
		hoverboardTheme13.price = 150;
		hoverboardTheme13.buttonBgColor = GlobalColors.HOVERBOARD_THEME_VENICEBOARD02_GLIDER_FILL;
		hoverboardTheme13.title = StringID.HOVERBOARD_THEME_VENICEBOARD02_GLIDER_TITLE;
		hoverboardTheme13.isNewInThisUpdate = false;
		hoverboardTheme13.buttonIconColor = GlobalColors.HOVERBOARD_THEME_VENICEBOARD02_GLIDER_ICON;
		hoverboardTheme13.power = Hoverboard.BoardAbility.Glider;
		hoverboardTheme13.iconName = "icon_upgrade_smooth_drift";
		list7.Add(hoverboardTheme13);
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ S5_v33 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v589 @ S5_v34+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list8 = default;
		list8._002Ector();
		HoverboardTheme hoverboardTheme14 = default;
		hoverboardTheme14.price = 80;
		hoverboardTheme14.buttonBgColor = GlobalColors.HOVERBOARD_THEME_ROME_ZAPSIDEWAYS_FILL;
		hoverboardTheme14.title = StringID.HOVERBOARD_THEME_ROME_ZAPSIDEWAYS_TITLE;
		hoverboardTheme14.isNewInThisUpdate = false;
		hoverboardTheme14.buttonIconColor = GlobalColors.HOVERBOARD_THEME_ROME_ZAPSIDEWAYS_ICON;
		hoverboardTheme14.power = Hoverboard.BoardAbility.Teleport;
		hoverboardTheme14.iconName = "icon_upgrade_zap_sideways";
		list8.Add(hoverboardTheme14);
		nint num17 = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ S5_v38 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v641 @ S5_v39+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list9 = default;
		list9._002Ector();
		HoverboardTheme hoverboardTheme15 = default;
		hoverboardTheme15.price = 60;
		hoverboardTheme15.buttonBgColor = GlobalColors.HOVERBOARD_THEME_SANFRANCISCOBOARD01_TRAIL_FILL;
		hoverboardTheme15.title = StringID.HOVERBOARD_THEME_FLOWER_TITLE;
		hoverboardTheme15.isNewInThisUpdate = false;
		hoverboardTheme15.buttonIconColor = GlobalColors.HOVERBOARD_THEME_SANFRANCISCOBOARD01_TRAIL_ICON;
		hoverboardTheme15.power = Hoverboard.BoardAbility.Vanity;
		hoverboardTheme15.iconName = "icon_upgrade_flower";
		list9.Add(hoverboardTheme15);
		nint num19 = 0;
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S5_v43 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v693 @ S5_v44+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list10 = default;
		list10._002Ector();
		HoverboardTheme hoverboardTheme16 = default;
		hoverboardTheme16.price = 60;
		hoverboardTheme16.buttonBgColor = GlobalColors.HOVERBOARD_THEME_ARABIABOARD01_TRAIL_FILL;
		hoverboardTheme16.title = StringID.HOVERBOARD_THEME_SMOKE_TRAIL_TITLE;
		hoverboardTheme16.isNewInThisUpdate = false;
		hoverboardTheme16.buttonIconColor = GlobalColors.HOVERBOARD_THEME_ARABIABOARD01_TRAIL_ICON;
		hoverboardTheme16.power = Hoverboard.BoardAbility.Vanity;
		hoverboardTheme16.iconName = "icon_smoke";
		list10.Add(hoverboardTheme16);
		nint num21 = 0;
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ S5_v48 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v745 @ S5_v49+4] (should have been resolved before IL gen)");
		List<HoverboardTheme> list11 = default;
		list11._002Ector();
		HoverboardTheme hoverboardTheme17 = default;
		hoverboardTheme17.price = 60;
		hoverboardTheme17.buttonBgColor = GlobalColors.HOVERBOARD_THEME_BANGKOKBOARD01_TRAIL_FILL;
		hoverboardTheme17.title = StringID.HOVERBOARD_THEME_BANGKOKBOARD01_TURTLE_TITLE;
		hoverboardTheme17.isNewInThisUpdate = false;
		hoverboardTheme17.buttonIconColor = GlobalColors.HOVERBOARD_THEME_BANGKOKBOARD01_TRAIL_ICON;
		hoverboardTheme17.power = Hoverboard.BoardAbility.Vanity;
		hoverboardTheme17.iconName = "icon_upgrade_pink_trail";
		list11.Add(hoverboardTheme17);
		nint num23 = 0;
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S5_v53 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+5C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v797 @ S5_v54+4] (should have been resolved before IL gen)");
		Dictionary<Hoverboards.BoardType, List<HoverboardTheme>> dictionary = default;
		hoverboardCustomThemes = dictionary;
	}
}
