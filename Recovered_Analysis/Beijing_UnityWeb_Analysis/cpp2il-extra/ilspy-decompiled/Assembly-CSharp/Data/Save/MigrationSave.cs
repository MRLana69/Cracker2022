using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save.Internal;
using Info;
using Kiloo.Common.Extensions;
using Missions;
using SYBO.Subway.Info;
using UI.Screens.CoinScreenInternal;
using UI.Screens.PauseScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace Data.Save;

public class MigrationSave : DataManager<MigrationSave>
{
	private const char DATA_CHUNK_SEPARATOR = ';';

	private const char DATA_ASSIGNATION_SEPARATOR = '=';

	private const char DATA_VALUE_GROUP_SEPARATOR = ',';

	private const char DATA_VALUE_SEPARATOR = ':';

	private const char DATA_THEME_IDENTIFIER_SEPARATOR = '#';

	public static void MigrateUnlockedOutfits(Dictionary<Characters.CharacterId, int[]> migrateDict)
	{
		((DataManager<>)(object)migrateDict).OnSaveGameChanged();
	}

	public static void MigrateCharacters(int[] characterTokens)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I
		//IL_0286: Expected Obj, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj11 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj11 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj12 = obj5 + 4;
		object obj13 = obj12 + 1;
		obj12 = obj13;
		object obj14 = obj13 << 2;
		object obj15 = obj5 + obj14;
		obj15 = 73;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj5 + obj16;
			if ((nint)obj17 == 73)
			{
				object obj18 = obj5 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_034f;
			}
		}
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_034f;
		IL_034f:
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj21 = localDebugData + 48;
		object obj22 = default;
		obj21 = obj22;
	}

	public unsafe static void MigrateBoards(string unlockedHoverboards)
	{
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected I, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_039c: Expected I, but got Obj
		//IL_03b2: Expected Obj, but got I
		//IL_03fd: Expected I, but got Obj
		//IL_0418: Expected I, but got Obj
		//IL_042e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got I4
		//IL_01ff: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I
		//IL_021f: Expected Obj, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I
		//IL_01ac: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_02c3: Expected Obj, but got I
		object obj = default;
		nint num = (nint)(obj + 4);
		object obj2 = unlockedHoverboards + 12;
		Characters.CharacterId characterId = default;
		Characters.CharacterId characterId2 = default;
		while (true)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v16 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v73 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = typeof(Characters.CharacterId);
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type enumType = Type.internal_from_handle((IntPtr)num);
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v25 (Il2CppClass<System.Enum>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v69 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ulong[] array = Enum.InternalGetValues((System.RuntimeType)enumType);
			int rank = array.Rank;
			if ((int)characterId >= rank)
			{
				break;
			}
			nint num6 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num7 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v63 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Characters.Model model = Characters.characterData.get_Item(characterId);
			if (model.unlockType == PurchaseData.UnlockType.Tokens)
			{
				bool flag = (nint)characterId < (nint)obj2;
				LocalDebugData localDebugData = DataManager<>.localDebug;
				if (flag)
				{
					object obj6 = unlockedHoverboards + 16;
					object obj7 = (int)characterId << 2;
					object obj8 = obj6 + obj7;
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S4_v10 (Il2CppMethodInfo)+C]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S4_v11+60]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S4_v12+48]");
					object obj11 = 0;
					object obj12 = obj11 & 0x7FF;
					object obj13 = obj12 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S5_v2 (should have been resolved before IL gen)");
				}
				else
				{
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S4_v4 (Il2CppMethodInfo)+C]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S4_v5+60]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S4_v6+48]");
					object obj11 = 0;
					object obj16 = obj11 & 0x7FF;
					object obj13 = obj16 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S5_v2 (should have been resolved before IL gen)");
				}
			}
			if ((nint)characterId < (nint)obj2)
			{
				object obj17 = unlockedHoverboards + 16;
				object obj18 = (int)characterId << 2;
				object obj19 = obj17 + obj18;
				if (model.Price <= (nint)obj19)
				{
					LocalDebugData localDebugData2 = DataManager<>.localDebug;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v54 (Data.Save.Internal.LocalDebugData)+24]");
					bool flag2 = Kiloo.Common.Extensions.CollectionExtensions.AddDistinct((IList<Characters.CharacterId>)0, characterId);
				}
			}
			characterId = characterId2 + 1;
		}
	}

	public static CollectCoinsDummy[] ParseDummyData(string rawData)
	{
		//IL_005a: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_001b: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got I4
		bool allowSellHeadstartDuringRun = OnboardingSave.allowSellHeadstartDuringRun;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			bool allowSellHeadstartDuringRun2 = OnboardingSave.allowSellHeadstartDuringRun;
			int num2 = ((Dictionary<UpgradeType, int>)allowSellHeadstartDuringRun2).get_Item((UpgradeType)rawData);
			return (CollectCoinsDummy[])num2;
		}
		return null;
	}

	private static bool TryParseDummy(string rawDummyData, out CollectCoinsDummy dummy)
	{
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_012f: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if (dataPath != null)
		{
			string dataPath2 = Application.dataPath;
			if ((nint)dataPath2 == 7)
			{
				return true;
			}
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v14 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v36 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isFreshInstall = UserSave.isFreshInstall;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v4 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S2_v5+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S2_v6+44]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v61 @ S3_v6 (should have been resolved before IL gen)");
			object obj7 = default;
			if ((nint)obj7 > -1)
			{
				return false;
			}
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v23 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v31 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isFreshInstall2 = UserSave.isFreshInstall;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S4_v6 (Il2CppMethodInfo)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S4_v7+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S4_v8+48]");
			object obj11 = 0;
			object obj12 = obj11 & 0x7FF;
			object obj13 = obj12 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v56 @ S5_v6 (should have been resolved before IL gen)");
			return true;
		}
		return true;
	}

	public static void SetPowerups(Dictionary<UpgradeType, int> powerups)
	{
	}

	public static void SetUpgrades(Dictionary<UpgradeType, int> upgrades)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj = localDebugData + 20;
		obj = upgrades;
	}

	public static void MigratePendingRewards(string rewardsAsString)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj = localDebugData + 24;
		obj = rewardsAsString;
	}

	public static void MigrateBoardThemeData(string data)
	{
		//IL_005c: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00c8: Expected I4, but got Obj
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0134: Expected I4, but got Obj
		if (data == null || data.m_stringLength == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<CelebrationReward> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 59;
		string text = data.Substring(num);
		object obj2 = text + 12;
		object obj3 = 0;
		DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = text + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			int num2 = (int)obj6;
			bool flag;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v30 (System.Int32)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				dailyChallengeRewardHelper.Refresh();
				((CoinContainer)(object)dailyChallengeRewardHelper).counterForElementsOnDisplay = (int)obj6;
				list.Add((CelebrationReward)(object)dailyChallengeRewardHelper);
			}
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj8 = localDebugData + 28;
		obj8 = list;
	}

	private unsafe static Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> GetCustomizationValues(string rawValues)
	{
		//IL_026a: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I
		//IL_03a5: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00ba: Expected I4, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		int num = default;
		((int*)num)->m_value = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36 @ S4_v4 (should have been resolved before IL gen)");
		Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> result;
		if (rawValues != null && rawValues.m_stringLength != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num3 = default;
			object obj6 = num3 + 16;
			obj6 = 59;
			string text = rawValues.Substring(num3);
			object obj7 = text + 12;
			object obj8 = 0;
			Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary = default;
			Dictionary<int, CollectCoinsDummy> dictionary2 = default;
			while (true)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
				{
					object obj9 = text + 16;
					object obj10 = obj8 << 2;
					object obj11 = obj9 + obj10;
					if (UserSave.IsCharacterOutfitSeen((Characters.CharacterId)obj11, num))
					{
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S4_v8 (Il2CppMethodInfo)+C]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S4_v9+60]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S4_v10+48]");
						object obj14 = 0;
						object obj15 = obj14 & 0x7FF;
						object obj16 = obj15 + 39195;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v114 @ S5_v8 (should have been resolved before IL gen)");
						object obj17 = obj8 + 1;
						obj8 = obj17;
						continue;
					}
					result = null;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummy>)+10]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummy>)+1C]");
				object obj18 = num5 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				GameStats gameStats = GameStats.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v31 (System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, Info.BoardThemeData>)+C]");
				bool flag = 0 == (nint)gameStats.OnCoinsChanged;
				int num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummy>)+10]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummy>)+1C]");
				object obj19 = num7 - 0;
				bool flag2 = num6 >= (nint)obj19;
				result = dictionary;
				if (flag2)
				{
					break;
				}
				CollectCoinsDummy collectCoinsDummy = dictionary2.get_Item(num6);
				throw new ArrayTypeMismatchException();
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	public unsafe static Dictionary<EarnCoinsData.Id, string> MigrateEarnCurrencyData(string rawList)
	{
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected I, but got Unknown
		//IL_0386: Expected Obj, but got I
		//IL_0396: Expected Obj, but got I
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0268: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_0208: Expected I, but got Obj
		//IL_0492: Expected I, but got Obj
		//IL_04ad: Expected I, but got Obj
		//IL_04c3: Expected Obj, but got I
		//IL_02a9: Expected I, but got Obj
		//IL_02f6: Expected I4, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3+60]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v125 @ S4_v7 (should have been resolved before IL gen)");
		Dictionary<EarnCoinsData.Id, string> result;
		if (rawList != null && rawList.m_stringLength != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num3 = default;
			object obj7 = num3 + 16;
			obj7 = 44;
			string text = rawList.Substring(num3);
			object obj8 = text.m_firstChar + -1;
			bool flag = (nint)obj8 > 1;
			bool flag2 = !flag;
			object obj9 = 113696;
			if (!flag2)
			{
				SDebug.LogFormat("Incorrect number of themes for a specific board.", null);
				result = null;
			}
			else
			{
				object obj10 = default;
				Dictionary<EarnCoinsData.Id, string> dictionary = default;
				int num4 = default;
				int num5 = default;
				object obj23 = default;
				while (true)
				{
					bool flag3 = (nint)obj10 >= (int)text.m_firstChar;
					result = dictionary;
					if (flag3)
					{
						break;
					}
					object obj11 = text + 16;
					object obj12 = obj10 << 2;
					object obj13 = obj11 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj14 = num4 + 16;
					obj14 = 35;
					string text2 = ((string)obj13).Substring(num4);
					object value = text2 + 16;
					object obj15 = text2 + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj16 = num5 + 16;
					obj16 = 58;
					string text3 = ((string)obj15).Substring(num5);
					if (text3.m_firstChar == '\u0003')
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object value2 = text3 + 16;
						nint num6 = (nint)typeof(bool);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v55 (Il2CppClass<System.Boolean>)+BA]");
						object obj17 = (nint)0 & (nint)0x200;
						if (obj17 != null)
						{
							nint num7 = (nint)typeof(bool);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v88 (Il2CppClass<System.Boolean>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text4 = bool.TrimWhiteSpaceAndNull((string)value2);
						object obj18 = text4 & 1;
						object value3 = text3 + 20;
						string text5 = bool.TrimWhiteSpaceAndNull((string)value3);
						object obj19 = text5 & 1;
						object value4 = text3 + 24;
						string text6 = bool.TrimWhiteSpaceAndNull((string)value4);
						object obj20 = text6 & 1;
						nint num8 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v65 (Il2CppClass<System.Type>)+BA]");
						object obj21 = (nint)0 & (nint)0x200;
						if (obj21 != null)
						{
							nint num9 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v84 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj = typeof(HoverboardThemes.ThemeIdentifier);
						((IntPtr*)num)->m_value = (void*)(nint)obj;
						Type enumType = Type.internal_from_handle((IntPtr)num);
						nint num10 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v74 (Il2CppClass<System.Enum>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						if (obj22 != null)
						{
							int num11 = (int)typeof(Enum);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v80 (System.Int32)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string name = Enum.GetName(enumType, value);
						throw new NullReferenceException();
					}
					SDebug.LogFormat("Incorrect number of values for a specific theme.", null);
					obj10 = obj23 + 1;
				}
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	public static Dictionary<AwardId, PersistentAwardProgress> MigrateAwardProgress(string rawProgress)
	{
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected I, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		object obj = default;
		nint num = (nint)(obj + 8);
		object obj2 = obj + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private static PersistentAwardProgress ParseAwardProgress(string val)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04d6: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected I, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v3+60]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		nint num2 = (nint)(obj8 + 113696);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v95 @ S4_v7 (Il2CppMethodInfo) (should have been resolved before IL gen)");
		if (val != null && val.m_stringLength != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num3 = default;
			object obj9 = num3 + 16;
			obj9 = 59;
			string text = val.Substring(num3);
			object obj10 = text + 12;
			object obj11 = default;
			object obj16 = default;
			object obj18 = default;
			object obj19 = default;
			object obj21 = default;
			object obj22 = default;
			IntPtr intPtr2 = default;
			object obj23 = default;
			object obj26 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
			{
				object obj12 = text + 16;
				object obj13 = obj11 << 2;
				object obj14 = obj12 + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj15 = obj16;
				object obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj17 == obj19)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj20 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj22 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						IntPtr intPtr = intPtr2;
						IntPtr intPtr3 = num2;
						obj11 = obj23 + 1;
						intPtr2 = intPtr;
						num2 = intPtr3;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
					object obj24 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj25 = obj26;
				}
				else
				{
					object obj25 = obj15;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				break;
			}
		}
		PersistentAwardProgress result = default;
		return result;
	}

	public MigrationSave()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected Obj, but got Unknown
		//IL_0494: Expected Obj, but got I
		//IL_04a4: Expected Obj, but got I
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected I, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v3+60]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		nint num2 = (nint)(obj8 + 113696);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v95 @ S4_v7 (Il2CppMethodInfo) (should have been resolved before IL gen)");
		bool flag;
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Data.Save.MigrationSave)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num3 = default;
			object obj9 = num3 + 16;
			obj9 = 59;
			string text = ((string)(object)this).Substring(num3);
			object obj10 = text + 12;
			object obj11 = default;
			object obj16 = default;
			object obj18 = default;
			object obj19 = default;
			object obj21 = default;
			object obj22 = default;
			int totalLength = default;
			object obj23 = default;
			object obj26 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
			{
				object obj12 = text + 16;
				object obj13 = obj11 << 2;
				object obj14 = obj12 + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj15 = obj16;
				object obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj17 == obj19)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj20 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj22 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						string msg = string.ConcatArray((string[])(object)"HoverboardCustomizationData parse failed for item ERROR = ", totalLength);
						SDebug.LogFormat(msg, null);
						IntPtr intPtr = num2;
						obj11 = obj23 + 1;
						num2 = intPtr;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
					object obj24 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj25 = obj26;
				}
				else
				{
					object obj25 = obj15;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				break;
			}
		}
		LocalDebugData localDebugData = DataManager<>.localDebug;
		object obj27 = localDebugData + 32;
		object obj28 = default;
		obj27 = obj28;
	}
}
