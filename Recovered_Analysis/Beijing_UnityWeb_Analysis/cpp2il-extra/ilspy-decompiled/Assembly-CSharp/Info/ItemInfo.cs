using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Kiloo;
using SYBO.Subway.Info;
using UI.SlideIns;
using UnityEngine;

namespace Info;

public static class ItemInfo
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public HoverboardThemes.ThemeIdentifier themeIdentifier;

		public _003C_003Ec__DisplayClass10_0()
		{
			//IL_0017: Expected Obj, but got I4
			SlideInData instance = SlideInData.instance;
			((UISlideIn)(object)instance).onDidShowCallback += (Action)3;
		}

		internal bool _003CGetItemTitleId_003Eb__0(HoverboardThemes.HoverboardTheme x)
		{
			//IL_0014: Expected Obj, but got I4
			//IL_0026: Expected I, but got Obj
			//IL_003c: Expected Obj, but got I
			//IL_0067: Expected I, but got Obj
			int num = 0;
			bool result;
			while (true)
			{
				HoverboardThemes.ThemeIdentifier themeIdentifier = this.themeIdentifier;
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v3 (HoverboardThemes+ThemeIdentifier)+C]");
				bool flag = (nint)num2 >= (nint)0;
				result = false;
				if (flag)
				{
					break;
				}
				Transform transform = ((List<Transform>)this.themeIdentifier).get_Item(num);
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (transform != (UnityEngine.Object)(object)x)
				{
					result = true;
					break;
				}
				int num5 = num + 1;
				num = num5;
			}
			return result;
		}
	}

	public const int ItemAmountReceiveDefault = 1;

	private const string ItemTitleIdHoverboard = "hoverboard";

	private const string ItemTitleIdHeadstart = "headstart";

	private const string ItemTitleIdScorebooster = "scorebooster";

	private static readonly string[] SKIP_MISSION_IDS;

	public unsafe static string GetItemTitleId(UpgradeType upgradeType)
	{
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_052e: Expected Obj, but got I4
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_0545: Expected Obj, but got I4
		//IL_0553: Expected I, but got Obj
		//IL_0569: Expected Obj, but got I
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected Obj, but got Unknown
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected VT, but got Unknown
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected Obj, but got Unknown
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected Obj, but got Unknown
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected Obj, but got Unknown
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0599: Expected I, but got Obj
		//IL_05af: Expected Obj, but got I
		//IL_07ab: Expected Obj, but got VT
		//IL_07b4: Expected Obj, but got VT
		//IL_07c1: Expected I8, but got Obj
		//IL_07bc: Expected native int or pointer, but got VT
		//IL_07d6: Expected Ref, but got VT
		//IL_07e2: Expected Obj, but got I8
		//IL_07f3: Expected Obj, but got VT
		//IL_07fc: Expected Obj, but got VT
		//IL_0809: Expected I8, but got Obj
		//IL_0804: Expected native int or pointer, but got VT
		//IL_081e: Expected Ref, but got VT
		//IL_00b4: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I8
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_0101: Expected I, but got Obj
		//IL_01fb: Expected I, but got Obj
		//IL_0211: Expected Obj, but got I
		//IL_0197: Expected I, but got Obj
		//IL_02a7: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I
		//IL_023c: Expected I, but got Obj
		//IL_02e8: Expected I, but got Obj
		//IL_0330: Expected F8, but got I4
		//IL_036d: Expected F8, but got I4
		//IL_065f: Invalid comparison between F8 and I4
		//IL_03aa: Expected F8, but got I4
		//IL_0686: Invalid comparison between F8 and I4
		//IL_03f5: Expected I, but got Obj
		//IL_040b: Expected Obj, but got I
		//IL_0436: Expected I, but got Obj
		//IL_047e: Expected F8, but got I4
		//IL_04bb: Expected F8, but got I4
		//IL_06f9: Invalid comparison between F8 and I4
		//IL_04f8: Expected F8, but got I4
		//IL_0720: Invalid comparison between F8 and I4
		//IL_0736: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v135 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 56);
		DateTime dateTime = (DateTime)(obj2 + 48);
		object obj5 = obj2 + 32;
		object obj6 = obj2 + 24;
		object obj7 = obj2 + 8;
		if (AgeRestriction.waitForAgeRestriction)
		{
			return null;
		}
		DateTime utcNow = CDateTime.UtcNow;
		nint num3 = (nint)typeof(FacebookRewardsInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v33 (Il2CppClass<Info.FacebookRewardsInfo>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(FacebookRewardsInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v128 (Il2CppClass<Info.FacebookRewardsInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v41 (Il2CppClass<System.DateTime>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v124 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj5 = utcNow;
		obj6 = FacebookRewardsInfo.connectPopupLastShownOnGameOver;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		formatProvider = (IFormatProvider)obj6;
		long num7 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num7;
		DateTime utcNow2 = CDateTime.UtcNow;
		obj7 = utcNow2;
		obj2 = FacebookRewardsInfo.connectPopupLastShownOnFriendsScreen;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj7;
		formatProvider = (IFormatProvider)obj2;
		long num8 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj3 = num8;
		nint num9 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v62 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num10 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v120 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue(FacebookRewardsInfo.FACEBOOK_REWARD_TIME_LIMIT_KEY, (uint)FacebookRewardsInfo.POPUP_DISPLAY_TIME_LIMIT);
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		uint value2 = ((OnlineSettings)(object)saveDataPath2).GetValue(FacebookRewardsInfo.FACEBOOK_REWARD_RUN_LIMIT_KEY, (uint)FacebookRewardsInfo.POPUP_DISPLAY_RUN_LIMIT);
		nint num11 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v73 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v116 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UserSave.allAssetBundlesDownloaded)
		{
			return null;
		}
		double num13 = (double)obj * 1E-07;
		nint num14 = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v83 (Il2CppClass<System.Math>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num15 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v111 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		double num16;
		if (num13 != num13)
		{
			num16 = -2147483648.0;
		}
		else if (num13 < 2147483648.0)
		{
			num16 = ((num13 > -2147483649.0) ? num13 : (-2147483648.0));
		}
		else
		{
			num16 = -2147483648.0;
		}
		double num17 = 0.0 - num16;
		if (num16 > -1.0)
		{
			num17 = num16;
		}
		if (num17 < (double)(int)value)
		{
			return null;
		}
		double num18 = (double)obj3 * 1E-07;
		nint num19 = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v97 (Il2CppClass<System.Math>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num20 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v104 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (int)value2 <= (int)upgradeType;
		double num21;
		if (num18 != num18)
		{
			num21 = -2147483648.0;
		}
		else if (num18 < 2147483648.0)
		{
			num21 = ((num18 > -2147483649.0) ? num18 : (-2147483648.0));
		}
		else
		{
			num21 = -2147483648.0;
		}
		double num22 = 0.0 - num21;
		if (num21 > -1.0)
		{
			num22 = num21;
		}
		bool flag2 = !(num22 < (double)(int)value);
		return (string)(flag & flag2);
	}

	public static string GetSkipMissionItemTitleId(int missionIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_028a: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = missionIndex;
		object obj3 = missionIndex - 1;
		if (missionIndex != 1)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 == 2)
				{
					return "headstart";
				}
				if ((nint)obj3 == 3)
				{
					goto IL_01e0;
				}
				if ((nint)obj3 != 4)
				{
					if ((nint)obj3 == 5 || (nint)obj3 == 6 || (nint)obj3 == 7)
					{
						goto IL_01e0;
					}
					if ((nint)obj3 != 8)
					{
						if ((nint)obj3 == 9)
						{
							goto IL_01e0;
						}
						if ((nint)obj3 != 10 && (nint)obj3 != 11 && (nint)obj3 != 12 && (nint)obj3 != 13 && (nint)obj3 == 14)
						{
							return "scorebooster";
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			obj2 = missionIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
		return "hoverboard";
		IL_01e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public static string GetItemTitleId(MysteryBox.Type boxType)
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(ItemInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.ItemInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<Info.ItemInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string[] sKIP_MISSION_IDS = SKIP_MISSION_IDS;
		if (sKIP_MISSION_IDS.Length > (int)boxType)
		{
			nint num3 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v21 (Il2CppClass<Info.ItemInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(ItemInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v31 (Il2CppClass<Info.ItemInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = SKIP_MISSION_IDS + 16;
			object obj4 = (int)boxType << 2;
			return obj3 + obj4;
		}
		return string.Empty;
	}

	public static string GetItemTitleId(Characters.CharacterId characterId, Outfit outfit = null)
	{
		//IL_00aa: Expected Obj, but got I
		//IL_002a: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		string text = null;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterId @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
			object obj = 0;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v3+C]");
			if ((nint)text2 >= 0)
			{
				text = null;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [characterId @ L0 (SYBO.Subway.Info.Characters+CharacterId)+14]");
			object obj2 = (nint)0 + (nint)16;
			object obj3 = (object)text << 2;
			object obj4 = obj2 + obj3;
			if (((_003C_003Ec__DisplayClass10_0)obj4)._003CGetItemTitleId_003Eb__0((HoverboardThemes.HoverboardTheme)(object)outfit))
			{
				break;
			}
			string text3 = text + 1;
			text = text3;
		}
		return text;
	}

	public static string GetItemTitleId(Boards.BoardId boardId)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		object obj3 = obj2 + 8;
		obj3 = 0;
		if (boardId != Boards.BoardId.normal)
		{
			object obj4 = boardId - 1;
			if ((nint)obj4 > 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				obj = boardId;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				throw new ArrayTypeMismatchException();
			}
			obj = 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = boardId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			string text = string.Format((IFormatProvider)(object)"{0}_{1}", format, arg);
			string text2 = text;
			return text2.ToUpper();
		}
		obj3 = 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public static string GetItemTitleId(Boards.BoardId boardId, HoverboardThemes.ThemeIdentifier themeIdentifier)
	{
		//IL_01c1: Expected I, but got Obj
		//IL_01d7: Expected Obj, but got I
		//IL_02af: Expected I, but got Obj
		//IL_02c5: Expected Obj, but got I
		//IL_0122: Expected I, but got Obj
		//IL_0223: Expected I, but got Obj
		//IL_0239: Expected Obj, but got I
		//IL_016f: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I
		//IL_0037: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		if (themeIdentifier != HoverboardThemes.ThemeIdentifier.none)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v45 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)boardId);
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v18 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v27 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string legal = Strings.GetLegal(model.name);
			string format = legal.ToUpper();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [themeIdentifier @ L1 (HoverboardThemes+ThemeIdentifier)+20]");
			string legal2 = Strings.GetLegal((string)0);
			string arg = legal2.ToUpper();
			return string.Format((IFormatProvider)(object)"{0}_{1}", format, arg);
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model2 = Characters.characterData.get_Item((Characters.CharacterId)boardId);
		nint num6 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v6 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v12 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string legal3 = Strings.GetLegal(model2.name);
		return legal3.ToUpper();
	}

	public unsafe static string GetItemTitleId(Boards.BoardId boardId, HoverboardThemes.HoverboardTheme boardTheme)
	{
		//IL_00fd: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_018b: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v29 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(boardId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj3 = default;
		object obj2 = obj3 + 16;
		object obj4 = default;
		obj2 = obj4;
		NullReferenceException ex = new NullReferenceException();
		nint num4 = (nint)typeof(ItemInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v19 (Il2CppClass<Info.ItemInfo>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v25 (Il2CppClass<Info.ItemInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)TryGetItemTitleId((InAppItemModel)boardId, out *(string*)ex);
	}

	public static string GetItemTitleId(InAppItemModel.ItemType itemType)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0124: Expected I, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)itemType);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v11 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string legal = Strings.GetLegal(board.name);
		return legal.ToUpper();
	}

	public static string GetItemTitleId(InAppItemModel.BundleItem bundleItem)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 4;
		obj = bundleItem;
		object obj3 = bundleItem - 5;
		if ((nint)bundleItem != 5 && (nint)obj3 != 1)
		{
			if ((nint)obj3 == 2)
			{
				goto IL_0162;
			}
			if ((nint)obj3 != 3)
			{
				if ((nint)obj3 == 4)
				{
					return "hoverboard";
				}
				if ((nint)obj3 == 5)
				{
					return "headstart";
				}
				if ((nint)obj3 == 6)
				{
					return "scorebooster";
				}
				if ((nint)bundleItem != 21)
				{
					goto IL_0162;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
		IL_0162:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj2 = bundleItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	public unsafe static bool TryGetItemTitleId(InAppItemModel item, out string itemTitleId)
	{
		//IL_0122: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_019f: Expected I4, but got Obj
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_0182: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)item);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v19 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string legal = Strings.GetLegal(board.name);
		string text = legal.ToUpper();
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref itemTitleId, 36));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	static ItemInfo()
	{
		//IL_013e: Expected I, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_016b: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got VT
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01f2: Expected VT, but got Obj
		//IL_000d: Expected Obj, but got VT
		//IL_0030: Expected VT, but got Obj
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00fd: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		FacebookRewardsInfo.POPUP_DISPLAY_TIME_LIMIT = 300;
		FacebookRewardsInfo.POPUP_DISPLAY_RUN_LIMIT = 6;
		nint num = (nint)typeof(FacebookRewardsInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v15 (Il2CppClass<Info.FacebookRewardsInfo>)+5C]");
		object obj = (nint)0 + (nint)8;
		obj = "facebook_reward_run_limit";
		nint num2 = (nint)typeof(FacebookRewardsInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v19 (Il2CppClass<Info.FacebookRewardsInfo>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		obj2 = "facebook_reward_time_limit";
		FacebookRewardsInfo.characterTheme = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		DateTime utcNow = CDateTime.UtcNow;
		obj3 = utcNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		object obj5 = obj4 + 8;
		object obj6 = default;
		obj5 = obj6;
		object obj7 = obj4 + 24;
		obj7 = obj5;
		FacebookRewardsInfo.connectPopupLastShownOnGameOver = (DateTime)obj7;
		DateTime utcNow2 = CDateTime.UtcNow;
		obj3 = utcNow2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		object obj8 = default;
		obj4 = obj8;
		obj7 = obj4;
		FacebookRewardsInfo.connectPopupLastShownOnFriendsScreen = (DateTime)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S3_v3+60]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj11 & 0x1FFF;
		object obj13 = obj12 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105 @ S4_v4 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S4_v7+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S4_v8+48]");
		object obj16 = 0;
		object obj17 = obj16 & 0x7FF;
		object obj18 = obj17 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v122 @ S5_v6 (should have been resolved before IL gen)");
		nint num5 = (nint)typeof(FacebookRewardsInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v44 (Il2CppClass<Info.FacebookRewardsInfo>)+5C]");
		object obj19 = (nint)0 + (nint)40;
		object obj20 = default;
		obj19 = obj20;
	}
}
