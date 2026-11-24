using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UnityEngine;

namespace Info;

public static class Boards
{
	public enum BoardId
	{
		normal,
		bouncer,
		lowrider,
		snowboard,
		surfboard,
		theoriginal,
		starboard,
		miami,
		monster,
		skullfire,
		speedboard,
		treehugger,
		rome,
		greatWhiteWakeboard,
		hotrod,
		teleboard,
		gliderboard
	}

	public class Board
	{
		public string name;

		public string boardModelName;

		public int price;

		public PurchaseData.UnlockType unlockType;

		public string tokenSprite2dName;

		public string description;

		public string limitedDescription;

		public bool isNewInThisUpdate;

		public bool hasOnlineTimeLimit;

		public DateTime defaultExpirationTime;

		public DateTime defaultStartDate;

		public bool overrideDynamicIapIdAndroid;

		public bool overrideDynamicIapIdiOS;

		public bool overrideDynamicIapIdKindle;

		public string dynamicIapId;
	}

	public const string ONLINE_SETTINGS_BOARD_PREFIX_EXPIRE = "hoverboard_expiretime_";

	public const string ONLINE_SETTINGS_BOARD_PREFIX_START = "hoverboard_starttime_";

	public static readonly Dictionary<BoardId, Board> boardData;

	public static List<BoardId> boardOrder;

	public static string[] GetAllBoardNames()
	{
		//IL_0347: Expected I, but got Obj
		//IL_035d: Expected Obj, but got I
		//IL_0544: Expected I4, but got Obj
		//IL_0544: Expected I4, but got Obj
		//IL_0556: Expected I, but got Obj
		//IL_056c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0472: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_02b9: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got I
		//IL_01de: Expected I, but got Obj
		//IL_0390: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I
		//IL_03b0: Expected Obj, but got I
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_0528: Expected Obj, but got I4
		//IL_022b: Expected I, but got Obj
		//IL_0241: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_02fa: Expected I, but got Obj
		//IL_04fb: Expected Obj, but got I4
		//IL_0424: Expected I, but got Obj
		//IL_043a: Expected Obj, but got I
		//IL_00d1: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_026c: Expected I, but got Obj
		//IL_05bf: Expected Obj, but got I4
		//IL_016d: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v98 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)"age_restriction_threshold");
		nint num3 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		if (outfitForCharacter != null)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v92 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v13 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v14+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S2_v15+44]");
			object obj5 = 0;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S3_v10 (should have been resolved before IL gen)");
			object obj8 = default;
			int defaultValue;
			if ((nint)obj8 > -1)
			{
				nint num6 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v78 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num7 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v86 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				defaultValue = AgeRestriction.DEFAULT_COUNTRY_CODE_RESTRICTIONS.get_Item(AgeRestriction.CACHED_COUNTRY_CODE);
			}
			else
			{
				defaultValue = 13;
			}
			nint num8 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v65 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v72 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			uint value = ((OnlineSettings)(object)saveDataPath2).GetValue("age_restriction_threshold", (uint)defaultValue);
			return (string[])value;
		}
		if (!flag)
		{
			nint num10 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v49 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v5 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v6+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S2_v7+44]");
		object obj13 = 0;
		object obj14 = obj13 & 0x1FFF;
		object obj15 = obj14 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105 @ S3_v5 (should have been resolved before IL gen)");
		object obj16 = default;
		if ((nint)obj16 > -1)
		{
			nint num12 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v35 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num13 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v43 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num14 = AgeRestriction.DEFAULT_COUNTRY_CODE_RESTRICTIONS.get_Item(AgeRestriction.CACHED_COUNTRY_CODE);
			return (string[])num14;
		}
		nint num15 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v23 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num16 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v30 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath3 = OnlineSettings.GetSaveDataPath();
		uint value2 = ((OnlineSettings)(object)saveDataPath3).GetValue("age_restriction_global_default", 13u);
		return (string[])value2;
	}

	static Boards()
	{
		//IL_01ba: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_0249: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		//IL_016d: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int userAge = AgeRestriction.GetUserAge();
		nint num3 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 != null;
		if (userAge != 0)
		{
			if (flag)
			{
				nint num4 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v40 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TransformExtensions.Reset((Transform)(object)AgeRestriction.restrictionChanged);
			return;
		}
		if (flag)
		{
			nint num5 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v31 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, string> lastShowedProviders = AdsSave.lastShowedProviders;
		if (lastShowedProviders == null)
		{
			return;
		}
		nint num6 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v18 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v25 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)AgeRestriction.restrictionChanged);
	}
}
