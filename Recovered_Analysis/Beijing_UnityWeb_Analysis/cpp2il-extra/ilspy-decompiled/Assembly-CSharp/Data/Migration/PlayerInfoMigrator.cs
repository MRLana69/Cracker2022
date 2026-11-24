using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Data.Save.Internal;
using InApp;
using Info;
using Kiloo.Common;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FlurryPlugin;
using Kiloo.Serialization;
using SYBO.Components.Utilities;
using SYBO.Subway.Info;
using UnityEngine;
using UnityEngine.Rendering;

namespace Data.Migration;

public static class PlayerInfoMigrator
{
	private class JsonObjectWrapper
	{
		private JsonObject _jsonObject;

		public static string lastLoadedKey
		{
			get
			{
				if (SpawnPool.PrefabPoolGroup._comparer == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					IComparer<SpawnPool.PrefabPoolGroup> comparer = default;
					SpawnPool.PrefabPoolGroup._comparer = comparer;
				}
				return (string)(object)SpawnPool.PrefabPoolGroup._comparer;
			}
			set
			{
			}
		}

		public JsonObjectWrapper(JsonObject jsonObject)
		{
			JsonObject jsonObject2 = _jsonObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (Kiloo.Common.JsonObject)+10]");
			if ((nint)0 != 0)
			{
				JsonObject jsonObject3 = _jsonObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
			}
		}

		public T Get<T>(string key, T defaultValue)
		{
			//IL_001a: Expected Obj, but got I
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected Obj, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @75EE");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x7FF;
			object obj4 = obj3 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S5_v4 (should have been resolved before IL gen)");
			T result = default;
			return result;
		}
	}

	private const string PLAYER_INFO_SECRET = "we12rtyuiklhgfdjerKJGHfvghyuhnjiokLJHl145rtyfghjvbn";

	private const int VERSION = 1;

	private static Key _lastKeyRead;

	private const string TOPRUN_FILENAME_MANAGER = "toprun_manager";

	private const string TOPRUN_FILENAME_PLAYER_IDS = "toprun_playerids";

	private const string TOPRUN_FILENAME_RANKS = "toprun_ranks";

	private const string TOPRUN_SALT = "GhgtrRFRfPLJhFDsWe#dEdrt5rfg56";

	private const string LAST_SEEN_BUNDLE_VERSION_KEY = "lastSeenBundleVersionKey";

	private const byte SOCIALDATA_VERSION = 2;

	private const string ADSYSTEM_FILE_SECRET = "KilooAdSystemInterstitialStatsSecret";

	private static string _lastInterstitialStatsKey;

	public static PlayerInfoData LoadPlayerInfoData()
	{
		//IL_001b: Expected Obj, but got I
		LocalDebugData localDebug = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1E0]");
		return (PlayerInfoData)0;
	}

	public static void SavePlayerInfoData(PlayerInfoData playerInfoData)
	{
	}

	private unsafe static void LogMigrationFail(string lastKey, Exception exception)
	{
		//IL_0215: Expected I, but got Obj
		//IL_022b: Expected Obj, but got I
		//IL_0284: Expected I4, but got Obj
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I
		//IL_0167: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I
		//IL_01c3: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_0102: Expected I, but got Obj
		ref HashSet<int> value = ref *(HashSet<int>*)null;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v34 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CollectCoinsDummy[] collectCoinsDummyData = UserSave.collectCoinsDummyData;
		if (((Dictionary<Characters.CharacterId, HashSet<int>>)(object)collectCoinsDummyData).TryGetValue((Characters.CharacterId)lastKey, out value))
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v8 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v9+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S2_v10+38]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57 @ S3_v13 (should have been resolved before IL gen)");
			return;
		}
		nint num4 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v20 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num5 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v27 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CollectCoinsDummy[] collectCoinsDummyData2 = UserSave.collectCoinsDummyData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<int> hashSet = default;
		hashSet._002Ector();
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S3_v5 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S3_v6+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S3_v7+38]");
		object obj10 = 0;
		object obj11 = obj10 & 0x1FFF;
		object obj12 = obj11 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v117 @ S4_v5 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S4_v8+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S4_v9+48]");
		object obj15 = 0;
		object obj16 = obj15 & 0x7FF;
		object obj17 = obj16 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70 @ S5_v7 (should have been resolved before IL gen)");
	}

	public static void Migrate()
	{
	}

	private static bool MigrateInventorySave(Dictionary<Key, string> mainPlayerData)
	{
		//IL_01be: Expected I, but got Obj
		//IL_01d4: Expected Obj, but got I
		//IL_003d: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_0216: Expected I4, but got Obj
		//IL_0228: Expected I, but got Obj
		//IL_023e: Expected Obj, but got I
		//IL_00d8: Expected I, but got Obj
		//IL_007e: Expected I, but got Obj
		//IL_0125: Expected I, but got Obj
		bool flag;
		if (mainPlayerData != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mainPlayerData @ L0 (System.Collections.Generic.Dictionary`2<Data.Migration.Key, System.String>)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		Dictionary<Key, string> dictionary;
		if (flag)
		{
			nint num = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v25 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v31 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, Friend.Status> friendStatus = SocialSave.friendStatus;
			dictionary = (Dictionary<Key, string>)(object)friendStatus;
		}
		else
		{
			dictionary = mainPlayerData;
		}
		nint num3 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v9 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v17 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string path = string.ConcatArray((string[])(object)"cloud", (int)dictionary);
		nint num5 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S2_v3 (Il2CppClass<System.IO.Path>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S2_v8 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Path.SameRoot(SaveManager.SAVE_PATH, path);
	}

	private static bool MigratePowerups(Dictionary<PowerupTypeLegacy, int> upgradeAmounts)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Expected Obj, but got Unknown
		//IL_0c40: Expected Obj, but got I4
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected Obj, but got Unknown
		//IL_0c57: Expected Obj, but got I4
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Expected Obj, but got Unknown
		//IL_0c6e: Expected Obj, but got I4
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Expected Obj, but got Unknown
		//IL_0c85: Expected Obj, but got I4
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected Obj, but got Unknown
		//IL_0c9c: Expected Obj, but got I4
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected Obj, but got Unknown
		//IL_0cb3: Expected Obj, but got I4
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Expected Obj, but got Unknown
		//IL_0cca: Expected Obj, but got I4
		//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected Obj, but got Unknown
		//IL_0ce1: Expected Obj, but got I4
		//IL_0cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfb: Expected Obj, but got Unknown
		//IL_0d04: Expected Obj, but got I4
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d12: Expected Obj, but got Unknown
		//IL_0d2e: Expected I, but got Obj
		//IL_0d44: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0da0: Expected I, but got Obj
		//IL_0db6: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		//IL_0de1: Expected I, but got Obj
		//IL_0df7: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		//IL_0e22: Expected I, but got Obj
		//IL_0e38: Expected Obj, but got I
		//IL_02db: Expected I, but got Obj
		//IL_0fe5: Expected I, but got Obj
		//IL_0ffb: Expected Obj, but got I
		//IL_0383: Expected I, but got Obj
		//IL_0399: Expected Obj, but got I
		//IL_076b: Expected I, but got Obj
		//IL_03c4: Expected I, but got Obj
		//IL_0813: Expected I, but got Obj
		//IL_0829: Expected Obj, but got I
		//IL_0854: Expected I, but got Obj
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05c8: Expected Obj, but got I4
		//IL_05d1: Expected Obj, but got I4
		//IL_06b1: Expected Obj, but got I
		//IL_04f6: Expected I, but got Obj
		//IL_050c: Expected Obj, but got I
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected Obj, but got Unknown
		//IL_0537: Expected I, but got Obj
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 88;
		obj3 = 0;
		object obj4 = obj2 + 84;
		obj4 = 0;
		object obj5 = obj2 + 80;
		obj5 = 0;
		object obj6 = obj2 + 76;
		obj6 = 0;
		object obj7 = obj2 + 72;
		obj7 = 0;
		object obj8 = obj2 + 68;
		obj8 = 0;
		object obj9 = obj2 - -64;
		obj9 = 0;
		object obj10 = obj2 + 40;
		obj10 = 0;
		_ = 0;
		_ = 0;
		object obj11 = obj2 + 24;
		obj11 = 0;
		object obj12 = obj2 + 32;
		obj12 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v35 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v503 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj14 = default;
		object obj15;
		object obj16 = default;
		object obj17;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj15 = obj16;
			object obj18 = default;
			obj17 = obj18;
		}
		else
		{
			nint num3 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v47 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num4 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S0_v417 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj20 = default;
			if (obj20 == null)
			{
				nint num5 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v59 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num6 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S0_v385 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj22 = default;
				if (obj22 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				nint num7 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ S0_v68 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num8 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S0_v366 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj24 = default;
				if (obj24 != null)
				{
					nint num9 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ S0_v221 (Il2CppClass<Globals>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num10 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ S0_v353 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj10 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
					_ = 0;
					object obj26 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj26 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						obj11 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						nint num11 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ S0_v332 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
						object obj27 = (nint)0 & (nint)0x200;
						if (obj27 != null)
						{
							nint num12 = (nint)typeof(CharacterManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ S0_v341 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					}
					object obj28 = obj12 + 4;
					object obj29 = obj28 + 1;
					obj28 = obj29;
					object obj30 = obj29 << 2;
					object obj31 = obj12 + obj30;
					obj31 = 155;
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v32+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v32+4]");
						object obj33 = (nint)0 << 2;
						object obj34 = obj12 + obj33;
						if ((nint)obj34 == 155)
						{
							object obj35 = obj12 + 4;
							if ((nint)obj35 > -1)
							{
								object obj36 = obj35 + -1;
								obj35 = obj36;
							}
							goto IL_0fd7;
						}
					}
					if (obj32 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj15 = obj16;
						object obj37 = default;
						obj17 = obj37;
						goto IL_0d61;
					}
				}
				goto IL_0fd7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj15 = obj16;
			object obj38 = default;
			obj17 = obj38;
		}
		goto IL_0d61;
		IL_0d61:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj39 = default;
		if (obj15 == obj39)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj41 = default;
			object obj40 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj43 = default;
			object obj42 = obj43;
		}
		else
		{
			object obj42 = obj17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		bool result = default;
		return result;
		IL_0fd7:
		nint num13 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ S0_v80 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj44 = (nint)0 & (nint)0x200;
		if (obj44 != null)
		{
			nint num14 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ S0_v208 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj45 = default;
		if (obj45 != null)
		{
			nint num15 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ S0_v174 (Il2CppClass<Globals>)+BA]");
			object obj46 = (nint)0 & (nint)0x200;
			if (obj46 != null)
			{
				nint num16 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ S0_v195 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj15 = obj16;
			object obj47 = default;
			obj17 = obj47;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj15 = obj16;
			object obj48 = default;
			obj17 = obj48;
		}
		goto IL_0d61;
	}

	private static bool MigrateUpgrades(Dictionary<PowerupTypeLegacy, int> upgradeTiers)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023e: Expected I, but got Obj
		//IL_0254: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v87 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj5 = default;
		object obj4 = obj5;
		object obj7 = default;
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj8 = default;
		if (obj6 == obj8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj10 = default;
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj12 = default;
			object obj11 = obj12;
		}
		else
		{
			object obj11 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		return true;
	}

	private static bool MigratePlayerSave(Dictionary<Key, string> mainPlayerData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected Obj, but got Unknown
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Expected Obj, but got Unknown
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5c: Expected Obj, but got Unknown
		//IL_0b65: Expected Obj, but got I4
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got Unknown
		//IL_0b88: Expected Obj, but got I4
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I4
		//IL_0139: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_017a: Expected I, but got Obj
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_0249: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_0897: Expected Obj, but got I
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected Obj, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected Obj, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected Obj, but got Unknown
		//IL_07dc: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 56;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 32;
		obj5 = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj2 + 8;
		obj6 = 0;
		object obj7 = obj2 + 24;
		obj7 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		object obj8 = default;
		object obj10 = default;
		object obj12 = default;
		object obj15 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S0_v227 (Il2CppClass<System.Type>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S0_v296 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj4 = typeof(UpgradeType);
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj3 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ S0_v247 (Il2CppClass<System.Enum>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num4 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ S0_v286 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj12 != null)
			{
				object obj13 = obj10;
				object obj14 = obj10;
			}
			else
			{
				object obj13 = 0;
				object obj14 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
		}
		object obj16 = 42;
		object obj17 = obj16 - 16;
		object obj18;
		object obj20;
		object obj21 = default;
		if ((nint)obj16 != 16)
		{
			if ((nint)obj17 != 1)
			{
				if ((nint)obj17 != 2)
				{
					if ((nint)obj17 != 3 && (nint)obj17 != 4 && (nint)obj17 != 5 && (nint)obj17 != 6 && (nint)obj17 != 7)
					{
						if ((nint)obj17 == 8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj19 = default;
							obj18 = obj19;
							obj20 = obj21;
							goto IL_0c31;
						}
						if ((nint)obj17 == 9)
						{
							goto IL_07e1;
						}
						if ((nint)obj17 != 10 && (nint)obj17 != 11)
						{
							if ((nint)obj17 == 12)
							{
								goto IL_07e1;
							}
							if ((nint)obj17 != 13 && (nint)obj17 != 14 && (nint)obj17 != 15)
							{
								if ((nint)obj17 != 16)
								{
									if ((nint)obj17 == 17 || (nint)obj17 == 18 || (nint)obj17 == 19 || (nint)obj17 == 20 || (nint)obj17 == 21 || (nint)obj17 == 22)
									{
										goto IL_0cb3;
									}
									if ((nint)obj17 != 23)
									{
										if ((nint)obj17 != 24)
										{
											if ((nint)obj17 != 25)
											{
												if ((nint)obj17 == 26)
												{
													object obj22 = obj7 + 4;
													object obj23 = obj22 + 1;
													obj22 = obj23;
													object obj24 = obj23 << 2;
													object obj25 = obj7 + obj24;
													obj25 = 119;
												}
												goto IL_0cb3;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj26 = default;
											obj18 = obj26;
											obj20 = obj21;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj27 = default;
											obj18 = obj27;
											obj20 = obj21;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj28 = default;
										obj18 = obj28;
										obj20 = obj21;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj29 = default;
									obj18 = obj29;
									obj20 = obj21;
								}
								goto IL_0c31;
							}
						}
					}
					goto IL_0cb3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj30 = default;
				obj18 = obj30;
				obj20 = obj21;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj31 = default;
				obj18 = obj31;
				obj20 = obj21;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj32 = default;
			obj18 = obj32;
			obj20 = obj21;
		}
		goto IL_0c31;
		IL_0bb3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj33;
		object obj34 = default;
		if (obj33 == obj34)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj36 = default;
			object obj35 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj38 = default;
			object obj37 = obj38;
		}
		else
		{
			object obj37 = obj18;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		goto IL_0b2c;
		IL_0b2c:
		return true;
		IL_0cc2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		goto IL_0b2c;
		IL_0c31:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj39 = default;
		bool flag = obj20 != obj39;
		obj33 = obj20;
		if (flag)
		{
			goto IL_0bb3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
		goto IL_0cb3;
		IL_0cb3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22+4]");
			object obj40 = (nint)0 << 2;
			object obj41 = obj7 + obj40;
			if ((nint)obj41 == 119)
			{
				object obj42 = obj7 + 4;
				if ((nint)obj42 > -1)
				{
					object obj43 = obj42 + -1;
					obj42 = obj43;
				}
				goto IL_0cc2;
			}
		}
		object obj44 = default;
		if (obj44 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj45 = default;
			obj18 = obj45;
			obj33 = obj21;
			goto IL_0bb3;
		}
		goto IL_0cc2;
		IL_07e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj46 = default;
		obj18 = obj46;
		obj20 = obj21;
		goto IL_0c31;
	}

	private static void MigrateStatistics(string s)
	{
		//IL_01a7: Expected Obj, but got I4
		//IL_0012: Expected I4, but got Obj
		//IL_0033: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0111: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream._002Ector((byte[])8192);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryWriter binaryWriter = default;
		binaryWriter.Dispose((byte)(int)memoryStream != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		FileUtil.WriteEnumIntDictionary<E>(binaryWriter, (IDictionary<E, int>)s.m_stringLength);
		FileUtil.WriteEnumIntDictionary(binaryWriter, (IDictionary<PowerupTypeLegacy, int>)s.m_firstChar);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+10]");
		FileUtil.WriteEnumIntDictionary(binaryWriter, (IDictionary<PowerupTypeLegacy, int>)0);
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v16 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v33 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = PlayerPrefsMigrator.CanMigrate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
		List<DebugSettingsCell> contentList = default;
		GameObject debugSettingsSubTogglePrefab = default;
		((DebugSettingsPopup.DebugSettingsListAdapter)flag)._002Ector(contentList, (GameObject)(object)"we12rtyuiklhgfdjerKJGHfvghyuhnjiokLJHl145rtyfghjvbn", null, debugSettingsSubTogglePrefab, (GameObject)1, (GameObject)5, null, null, null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+14]");
		WriteSocialData((Stream)(object)"toprun_manager", (Dictionary<string, Friend.Status>)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+18]");
		WriteSocialData((Stream)(object)"toprun_playerids", (Dictionary<string, Friend.Status>)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+1C]");
		WriteSocialData((Stream)(object)"toprun_ranks", (Dictionary<string, Friend.Status>)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+20]");
		SaveAdSystemDataFile((IDictionary<string, object>)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+24]");
		((PlayerPrefsMigrator)0)._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	private static void MigrateTopRunSave(Dictionary<Key, string> mainPlayerData, IDictionary manager, IDictionary playerIds, IDictionary ranks)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_0260: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0280: Expected Obj, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 4;
		obj = mainPlayerData;
		obj2 = manager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v3+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S4_v7+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S4_v8+48]");
		object obj10 = 0;
		object obj11 = obj10 & 0x7FF;
		object obj12 = obj11 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v65 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private static object LoadTopRunJsonFile(string file)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_14bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c0: Expected Obj, but got Unknown
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ce: Expected Obj, but got Unknown
		//IL_14d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dc: Expected Obj, but got Unknown
		//IL_14e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ea: Expected Obj, but got Unknown
		//IL_14f3: Expected Obj, but got I4
		//IL_14fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1501: Expected Obj, but got Unknown
		//IL_150a: Expected Obj, but got I4
		//IL_1513: Unknown result type (might be due to invalid IL or missing references)
		//IL_1518: Expected Obj, but got Unknown
		//IL_1521: Expected Obj, but got I4
		//IL_152a: Unknown result type (might be due to invalid IL or missing references)
		//IL_152f: Expected Obj, but got Unknown
		//IL_1538: Expected Obj, but got I4
		//IL_1541: Unknown result type (might be due to invalid IL or missing references)
		//IL_1546: Expected Obj, but got Unknown
		//IL_154f: Expected Obj, but got I4
		//IL_1558: Unknown result type (might be due to invalid IL or missing references)
		//IL_155d: Expected Obj, but got Unknown
		//IL_1566: Expected Obj, but got I4
		//IL_156f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1574: Expected Obj, but got Unknown
		//IL_157d: Expected Obj, but got I4
		//IL_1586: Unknown result type (might be due to invalid IL or missing references)
		//IL_158b: Expected Obj, but got Unknown
		//IL_1594: Expected Obj, but got I4
		//IL_159d: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a2: Expected Obj, but got Unknown
		//IL_15ab: Expected Obj, but got I4
		//IL_15b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b9: Expected Obj, but got Unknown
		//IL_15c2: Expected Obj, but got I4
		//IL_15cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d0: Expected Obj, but got Unknown
		//IL_15d9: Expected Obj, but got I4
		//IL_15e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e7: Expected Obj, but got Unknown
		//IL_15f0: Expected Obj, but got I4
		//IL_15f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fe: Expected Obj, but got Unknown
		//IL_1607: Expected Obj, but got I4
		//IL_1610: Unknown result type (might be due to invalid IL or missing references)
		//IL_1615: Expected Obj, but got Unknown
		//IL_161e: Expected Obj, but got I4
		//IL_1627: Unknown result type (might be due to invalid IL or missing references)
		//IL_162c: Expected Obj, but got Unknown
		//IL_1635: Expected Obj, but got I4
		//IL_163e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1643: Expected Obj, but got Unknown
		//IL_164c: Expected Obj, but got I4
		//IL_1655: Unknown result type (might be due to invalid IL or missing references)
		//IL_165a: Expected Obj, but got Unknown
		//IL_1663: Expected Obj, but got I4
		//IL_166c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1671: Expected Obj, but got Unknown
		//IL_167a: Expected Obj, but got I4
		//IL_1683: Unknown result type (might be due to invalid IL or missing references)
		//IL_1688: Expected Obj, but got Unknown
		//IL_1691: Expected Obj, but got I4
		//IL_169a: Unknown result type (might be due to invalid IL or missing references)
		//IL_169f: Expected Obj, but got Unknown
		//IL_16a8: Expected Obj, but got I4
		//IL_16b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b6: Expected Obj, but got Unknown
		//IL_16bf: Expected Obj, but got I4
		//IL_16c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cd: Expected Obj, but got Unknown
		//IL_16d6: Expected Obj, but got I4
		//IL_16df: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e4: Expected Obj, but got Unknown
		//IL_1700: Expected I, but got Obj
		//IL_1716: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_1772: Expected I, but got Obj
		//IL_1788: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_17b3: Expected I, but got Obj
		//IL_17c9: Expected Obj, but got I
		//IL_01f1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 144;
		object obj3 = obj2 + 48;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 16;
		object obj6 = obj2 + 130;
		obj6 = 0;
		object obj7 = obj2 + 129;
		obj7 = 0;
		object obj8 = obj2 + 128;
		obj8 = 0;
		object obj9 = obj2 + 124;
		obj9 = 0;
		object obj10 = obj2 + 120;
		obj10 = 0;
		object obj11 = obj2 + 116;
		obj11 = 0;
		object obj12 = obj2 + 112;
		obj12 = 0;
		object obj13 = obj2 + 108;
		obj13 = 0;
		object obj14 = obj2 + 40;
		obj14 = 0;
		object obj15 = obj2 + 104;
		obj15 = 0;
		object obj16 = obj2 + 100;
		obj16 = 0;
		object obj17 = obj2 + 32;
		obj17 = 0;
		object obj18 = obj2 + 96;
		obj18 = 0;
		object obj19 = obj2 + 92;
		obj19 = 0;
		object obj20 = obj2 + 88;
		obj20 = 0;
		object obj21 = obj2 + 84;
		obj21 = 0;
		object obj22 = obj2 + 80;
		obj22 = 0;
		object obj23 = obj2 + 76;
		obj23 = 0;
		object obj24 = obj2 + 72;
		obj24 = 0;
		object obj25 = obj2 + 68;
		obj25 = 0;
		object obj26 = obj2 - -64;
		obj26 = 0;
		object obj27 = obj2 + 24;
		obj27 = 0;
		object obj28 = obj2 + 56;
		obj28 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v65 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v972 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj30 = default;
		if (obj30 != null)
		{
			bool flag = obj6 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		nint num3 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v74 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num4 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ S0_v898 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj32 = default;
		if (obj32 != null)
		{
			bool flag2 = obj7 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		nint num5 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ S0_v83 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num6 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ S0_v877 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj34 = default;
		if (obj34 != null)
		{
			bool flag3 = obj8 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj36 = default;
		object obj35 = obj36;
		object obj38 = default;
		object obj37 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj39 = default;
		if (obj37 == obj39)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj41 = default;
			object obj40 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj43 = default;
			object obj42 = obj43;
		}
		else
		{
			object obj42 = obj35;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		object result = default;
		return result;
	}

	private unsafe static void SaveTopRunJsonFile(string file, object json)
	{
		//IL_001d: Expected I4, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got I
		//IL_0200: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I
		//IL_026c: Expected Obj, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_02a8: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I
		//IL_02c8: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_003a: Expected I4, but got Obj
		//IL_003a: Expected I4, but got Obj
		//IL_0100: Expected I, but got Obj
		string msg = string.Format((IFormatProvider)(object)"Exception while migrating, lastKey: '{0}'\n{1}", file, json);
		SDebug.LogFormat(msg, null);
		int hashCode = ((LODParameters*)"lastSeenBundleVersionKey")->GetHashCode();
		bool flag = hashCode == 0;
		int num = (int)"";
		if (!flag)
		{
			int num2 = UnityEngine.Random.Range((int)"lastSeenBundleVersionKey", (int)"");
			num = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S3_v4+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v79 @ S5_v6 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v97 @ S5_v10 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S4_v17+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S4_v18+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115 @ S5_v14 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S4_v22+60]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S4_v23+48]");
		object obj23 = 0;
		object obj24 = obj23 & 0x7FF;
		object obj25 = obj24 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v135 @ S5_v18 (should have been resolved before IL gen)");
		nint num8 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v28 (Il2CppClass<Flurry>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num9 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v32 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private static void MigrateSocialSave(Dictionary<string, Friend.Status> socialData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_018d: Expected I, but got Obj
		//IL_01a3: Expected Obj, but got I
		//IL_0102: Expected I, but got Obj
		//IL_025a: Expected Obj, but got I4
		//IL_01ce: Expected I, but got Obj
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		if ((nint)socialData.buckets <= 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj5 = num + 16;
		obj5 = 59;
		string text = ((string)(object)socialData).Substring(num);
		object obj6 = text + 12;
		object obj7 = default;
		object obj15 = default;
		object obj17 = default;
		object obj18 = default;
		object obj20 = default;
		object obj21 = default;
		object obj22 = default;
		object obj25 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				return;
			}
			object obj8 = text + 16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			int num2 = ((string)obj10).IndexOfAny((char[])61);
			string text2 = ((string)obj10).InternalSubString(0, num2);
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v41 (Il2CppClass<System.Type>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v145 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj2 = typeof(Stat);
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v84 (Il2CppClass<System.Enum>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num6 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v129 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj13 = num2 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj14 = obj15;
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj24;
			if (obj16 == obj18)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj19 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj21 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					obj7 = obj22 + 1;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
				object obj23 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				obj24 = obj25;
				break;
			}
			obj24 = obj14;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private static string GetSocialDataSavePath()
	{
		//IL_02b0: Expected Obj, but got I4
		//IL_02be: Expected I, but got Obj
		//IL_02d4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		//IL_00d2: Expected I4, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_015c: Expected I, but got Obj
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0298: Expected Obj, but got I4
		Dictionary<Key, string> dictionary = (Dictionary<Key, string>)0;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v85 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!MigrateUserSave(dictionary))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Exception ex = default;
			ex.SetErrorCode((int)"File path invalid");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		bool disposing = Kiloo.Common.Utility.StringUtility.Match((string)(object)dictionary, "we12rtyuiklhgfdjerKJGHfvghyuhnjiokLJHl145rtyfghjvbn", Kiloo.Common.Utility.StringUtility.MatchType.Is, ignoreCase: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.Dispose(disposing);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryReader binaryReader = default;
		binaryReader.Dispose((byte)(int)memoryStream != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Dictionary<_0021_00210, int> dictionary2 = (Dictionary<_0021_00210, int>)(object)FileUtil.ReadEnumIntDictionary<E>(binaryReader);
		Dictionary<PowerupTypeLegacy, int> dictionary3 = FileUtil.ReadEnumIntDictionary<PowerupTypeLegacy>(binaryReader);
		Dictionary<PowerupTypeLegacy, int> dictionary4 = FileUtil.ReadEnumIntDictionary<PowerupTypeLegacy>(binaryReader);
		nint num3 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v36 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v77 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, Friend.Status> dictionary5 = ReadSocialData((Stream)(object)"toprun_manager");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		Dictionary<string, Friend.Status> dictionary6 = ReadSocialData((Stream)(object)"toprun_playerids");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		Dictionary<string, Friend.Status> dictionary7 = ReadSocialData((Stream)(object)"toprun_ranks");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		string adSystemFolderPath = GetAdSystemFolderPath();
		bool flag = CanMigrate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		object obj3 = text + 8;
		obj3 = dictionary2;
		object obj4 = text + 12;
		obj4 = dictionary3;
		object obj5 = text + 16;
		obj5 = dictionary4;
		object obj6 = text + 20;
		object obj7 = default;
		obj6 = obj7;
		object obj8 = text + 24;
		object obj9 = default;
		obj8 = obj9;
		object obj10 = text + 28;
		object obj11 = default;
		obj10 = obj11;
		object obj12 = text + 32;
		obj12 = adSystemFolderPath;
		object obj13 = text + 36;
		obj13 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		return text;
	}

	private static Dictionary<string, Friend.Status> LoadSocialDataFile()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		return (Dictionary<string, Friend.Status>)(object)string.ConcatArray((string[])(object)cachePath, (int)"/socialdata");
	}

	private static Dictionary<string, Friend.Status> ReadSocialData(Stream stream)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_029f: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v117 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v24 (Il2CppClass<System.IO.Path>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Dictionary<string, Friend.Status> result = default;
		return result;
	}

	private static void SaveSocialDataFile(Dictionary<string, Friend.Status> friendStatus)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (friendStatus != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj3 = default;
			object obj4 = default;
			if (obj3 == obj4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj6 = default;
				object obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj8 = default;
				object obj7 = obj8;
			}
			else
			{
				object obj9 = default;
				object obj7 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}

	private static void WriteSocialData(Stream stream, Dictionary<string, Friend.Status> friendStatus)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0294: Expected I, but got Obj
		//IL_02aa: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v110 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v24 (Il2CppClass<System.IO.Path>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v61 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		if (friendStatus == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @32");
	}

	private static string GetAdSystemFolderPath()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_024c: Expected I, but got Obj
		//IL_0262: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v123 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj5 = default;
		object obj4 = obj5;
		object obj7 = default;
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj8 = default;
		if (obj6 == obj8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj10 = default;
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj12 = default;
			object obj11 = obj12;
		}
		else
		{
			object obj11 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		string result = default;
		return result;
	}

	private static string GetAdSystemFilePath(string folderPath)
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0355: Expected I4, but got Obj
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_038e: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03d5: Expected Obj, but got I4
		//IL_03de: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_03fc: Expected I4, but got Obj
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Obj, but got Unknown
		//IL_029d: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got Unknown
		//IL_052f: Expected Obj, but got VT
		//IL_0544: Expected I4, but got Obj
		//IL_055a: Expected Obj, but got I
		//IL_056a: Expected Obj, but got I
		//IL_057a: Expected Obj, but got I
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected Obj, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_05aa: Expected Obj, but got I4
		//IL_02de: Expected I, but got Obj
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_0444: Expected Obj, but got VT
		//IL_0459: Expected I4, but got Obj
		//IL_0479: Expected Obj, but got I
		//IL_0489: Expected Obj, but got I
		//IL_0499: Expected Obj, but got I
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected Obj, but got Unknown
		//IL_04ca: Expected Obj, but got I4
		//IL_01c9: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryReader binaryReader = default;
		binaryReader.Dispose((byte)(int)folderPath != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj5 = default;
		object obj4 = obj5 << 24;
		object obj6 = obj4 >> 24;
		object obj7 = obj6 - 1;
		string result = default;
		if ((nint)obj6 != 1)
		{
			if ((nint)obj7 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S3_v11 (Il2CppMethodInfo)+C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S3_v12+60]");
				object obj9 = 0;
				object obj10 = obj9;
				object obj11 = obj10 & 0x1FFF;
				object obj12 = obj11 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v152 @ S4_v18 (should have been resolved before IL gen)");
				object obj13 = 113696;
				object obj14 = 0;
				object obj15 = default;
				string text = default;
				object obj16 = default;
				SocialManager.FacebookPermissionCheck facebookPermissionCheck = default;
				long dateData = default;
				while (true)
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15);
					result = text;
					if (flag)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					bool flag2;
					if (obj16 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v73+8]");
						flag2 = (nint)0 == 0;
					}
					else
					{
						flag2 = true;
					}
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						facebookPermissionCheck._002Ector();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
						nint num2 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v86 (Il2CppClass<System.DateTime>)+BA]");
						object obj17 = (nint)0 & (nint)0x200;
						if (obj17 != null)
						{
							nint num3 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v97 (Il2CppClass<System.DateTime>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						DateTime dateTime = DateTime.FromBinaryRaw(dateData);
						obj3 = dateTime;
						obj = obj3;
						facebookPermissionCheck.state = (SocialManager.FacebookPermissionCheckState)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S4_v20 (Il2CppMethodInfo)+C]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S4_v21+60]");
						object obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S4_v22+48]");
						obj12 = 0;
						object obj20 = obj12 & 0x7FF;
						obj13 = obj20 + 39195;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v150 @ S5_v13 (should have been resolved before IL gen)");
						obj10 = 1;
					}
					object obj21 = obj14 + 1;
					obj14 = obj21;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				MemoryStream memoryStream = default;
				memoryStream._002Ector((int)"Unsupported playerdata file version");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S3_v3+60]");
			object obj23 = 0;
			object obj24 = obj23;
			object obj25 = obj24 & 0x1FFF;
			object obj26 = obj25 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115 @ S4_v6 (should have been resolved before IL gen)");
			object obj27 = 113696;
			object obj28 = 0;
			object obj29 = default;
			string text2 = default;
			object obj30 = default;
			SocialManager.FacebookPermissionCheck facebookPermissionCheck2 = default;
			long dateData2 = default;
			while (true)
			{
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29);
				result = text2;
				if (flag3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				bool flag4;
				if (obj30 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v30+8]");
					flag4 = (nint)0 == 0;
				}
				else
				{
					flag4 = true;
				}
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					facebookPermissionCheck2._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
					nint num6 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v43 (Il2CppClass<System.DateTime>)+BA]");
					object obj31 = (nint)0 & (nint)0x200;
					if (obj31 != null)
					{
						nint num7 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v52 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					DateTime dateTime2 = DateTime.FromBinaryRaw(dateData2);
					obj2 = dateTime2;
					obj = obj2;
					facebookPermissionCheck2.state = (SocialManager.FacebookPermissionCheckState)obj;
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S4_v8 (Il2CppMethodInfo)+C]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S4_v9+60]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S4_v10+48]");
					obj26 = 0;
					object obj34 = obj26 & 0x7FF;
					obj27 = obj34 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v113 @ S5_v4 (should have been resolved before IL gen)");
					obj24 = 1;
				}
				object obj35 = obj28 + 1;
				obj28 = obj35;
			}
		}
		return result;
	}

	private static void SaveAdSystemDataFile(IDictionary<string, object> adSystemData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v89 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v145 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj5 = default;
		object obj4 = obj5;
		object obj7 = default;
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj8 = default;
		if (obj6 == obj8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj10 = default;
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj12 = default;
			object obj11 = obj12;
		}
		else
		{
			object obj11 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private static IDictionary<string, object> LoadAdSystemDataFile()
	{
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0087: Expected I4, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v26 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		bool flag = cachePath == null || cachePath.m_stringLength == 0;
		bool flag2 = !flag;
		bool flag3 = !flag2;
		string result = string.Empty;
		if (!flag3)
		{
			string text = string.ConcatArray((string[])(object)cachePath, (int)"/AdSystem");
			result = text;
		}
		return (IDictionary<string, object>)(object)result;
	}

	private static bool MigrateSyboAnalyticsSave(Dictionary<Key, string> mainPlayerData)
	{
		//IL_0013: Expected I4, but got Obj
		//IL_0017: Expected I4, but got Obj
		return (byte)(int)string.ConcatArray((string[])(object)mainPlayerData, (int)"/showlimits") != 0;
	}

	private static bool MigrateEventsSave(Dictionary<Key, string> mainPlayerData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Expected Obj, but got Unknown
		//IL_0eb7: Expected Obj, but got I4
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Expected Obj, but got Unknown
		//IL_0ece: Expected Obj, but got I4
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edc: Expected Obj, but got Unknown
		//IL_0ee5: Expected Obj, but got I4
		//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef3: Expected Obj, but got Unknown
		//IL_0efc: Expected Obj, but got I4
		//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0a: Expected Obj, but got Unknown
		//IL_0f13: Expected Obj, but got I4
		//IL_0f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f21: Expected Obj, but got Unknown
		//IL_0f2a: Expected Obj, but got I4
		//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Expected Obj, but got Unknown
		//IL_0f41: Expected Obj, but got I4
		//IL_0f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4f: Expected Obj, but got Unknown
		//IL_0f58: Expected Obj, but got I4
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected Obj, but got Unknown
		//IL_0f6f: Expected Obj, but got I4
		//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7d: Expected Obj, but got Unknown
		//IL_0f86: Expected Obj, but got I4
		//IL_0f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f94: Expected Obj, but got Unknown
		//IL_0f9d: Expected Obj, but got I4
		//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fab: Expected Obj, but got Unknown
		//IL_0fb4: Expected Obj, but got I4
		//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Expected Obj, but got Unknown
		//IL_0fcb: Expected Obj, but got I4
		//IL_0fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd9: Expected Obj, but got Unknown
		//IL_0fe2: Expected Obj, but got I4
		//IL_0feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff0: Expected Obj, but got Unknown
		//IL_0ff9: Expected Obj, but got I4
		//IL_1015: Expected I, but got Obj
		//IL_102b: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_1087: Expected I, but got Obj
		//IL_109d: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_10c8: Expected I, but got Obj
		//IL_10de: Expected Obj, but got I
		//IL_01df: Expected I, but got Obj
		//IL_1109: Expected I, but got Obj
		//IL_111f: Expected Obj, but got I
		//IL_02b5: Expected I, but got Obj
		//IL_114a: Expected I, but got Obj
		//IL_1160: Expected Obj, but got I
		//IL_038b: Expected I, but got Obj
		//IL_118b: Expected I, but got Obj
		//IL_11a1: Expected Obj, but got I
		//IL_0461: Expected I, but got Obj
		//IL_11db: Expected I, but got Obj
		//IL_11f1: Expected Obj, but got I
		//IL_0537: Expected I, but got Obj
		//IL_122b: Expected I, but got Obj
		//IL_1241: Expected Obj, but got I
		//IL_05f3: Expected I, but got Obj
		//IL_127b: Expected I, but got Obj
		//IL_1291: Expected Obj, but got I
		//IL_06af: Expected I, but got Obj
		//IL_12cb: Expected I, but got Obj
		//IL_12e1: Expected Obj, but got I
		//IL_076b: Expected I, but got Obj
		//IL_131b: Expected I, but got Obj
		//IL_1331: Expected Obj, but got I
		//IL_0827: Expected I, but got Obj
		//IL_136b: Expected I, but got Obj
		//IL_1381: Expected Obj, but got I
		//IL_08e3: Expected I, but got Obj
		//IL_13ca: Expected I, but got Obj
		//IL_13e0: Expected Obj, but got I
		//IL_0971: Expected I, but got Obj
		//IL_0987: Expected Obj, but got I
		//IL_0a32: Expected I, but got Obj
		//IL_1429: Expected I, but got Obj
		//IL_143f: Expected Obj, but got I
		//IL_09b2: Expected I, but got Obj
		//IL_0ac0: Expected I, but got Obj
		//IL_0ad6: Expected Obj, but got I
		//IL_0b81: Expected I, but got Obj
		//IL_1479: Expected I, but got Obj
		//IL_148f: Expected Obj, but got I
		//IL_0b01: Expected I, but got Obj
		//IL_0c3d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 - -64;
		obj3 = 0;
		object obj4 = obj2 + 60;
		obj4 = 0;
		object obj5 = obj2 + 56;
		obj5 = 0;
		object obj6 = obj2 + 52;
		obj6 = 0;
		object obj7 = obj2 + 48;
		obj7 = 0;
		object obj8 = obj2 + 44;
		obj8 = 0;
		object obj9 = obj2 + 40;
		obj9 = 0;
		object obj10 = obj2 + 36;
		obj10 = 0;
		object obj11 = obj2 + 32;
		obj11 = 0;
		object obj12 = obj2 + 28;
		obj12 = 0;
		object obj13 = obj2 + 24;
		obj13 = 0;
		object obj14 = obj2 + 20;
		obj14 = 0;
		object obj15 = obj2 + 16;
		obj15 = 0;
		object obj16 = obj2 + 12;
		obj16 = 0;
		object obj17 = obj2 + 8;
		obj17 = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v44 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v628 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj19 = default;
		if (obj19 != null)
		{
			bool flag = obj3 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num3 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v53 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num4 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v554 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num5 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ S0_v62 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num6 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ S0_v534 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num7 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ S0_v71 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num8 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ S0_v514 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num9 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ S0_v80 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num10 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S0_v494 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num11 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ S0_v89 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num12 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ S0_v473 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj29 = default;
		if (obj29 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num13 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ S0_v101 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num14 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ S0_v450 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj31 = default;
		if (obj31 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num15 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ S0_v113 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num16 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ S0_v427 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj33 = default;
		if (obj33 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num17 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ S0_v125 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num18 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ S0_v404 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj35 = default;
		if (obj35 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num19 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ S0_v139 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num20 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ S0_v381 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj37 = default;
		if (obj37 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num21 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ S0_v151 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj38 = (nint)0 & (nint)0x200;
		if (obj38 != null)
		{
			nint num22 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ S0_v358 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj39 = default;
		if (obj39 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num23 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1158 @ S0_v163 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj40 = (nint)0 & (nint)0x200;
		if (obj40 != null)
		{
			nint num24 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ S0_v335 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj41 = default;
		object obj43;
		object obj45;
		object obj46 = default;
		if (obj41 != null)
		{
			nint num25 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ S0_v303 (Il2CppClass<Globals>)+BA]");
			object obj42 = (nint)0 & (nint)0x200;
			if (obj42 != null)
			{
				nint num26 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1215 @ S0_v322 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj44 = default;
			obj43 = obj44;
			obj45 = obj46;
		}
		else
		{
			nint num27 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ S0_v175 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj47 = (nint)0 & (nint)0x200;
			if (obj47 != null)
			{
				nint num28 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ S0_v290 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj48 = default;
			if (obj48 != null)
			{
				nint num29 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ S0_v258 (Il2CppClass<Globals>)+BA]");
				object obj49 = (nint)0 & (nint)0x200;
				if (obj49 != null)
				{
					nint num30 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1300 @ S0_v277 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj50 = default;
				obj43 = obj50;
				obj45 = obj46;
			}
			else
			{
				nint num31 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1296 @ S0_v187 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj51 = (nint)0 & (nint)0x200;
				if (obj51 != null)
				{
					nint num32 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1312 @ S0_v245 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj52 = default;
				if (obj52 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				nint num33 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1378 @ S0_v201 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj53 = (nint)0 & (nint)0x200;
				if (obj53 != null)
				{
					nint num34 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ S0_v222 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj54 = default;
				if (obj54 == null)
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj55 = default;
				obj43 = obj55;
				obj45 = obj46;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj56 = default;
		if (obj45 == obj56)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj58 = default;
			object obj57 = obj58;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj60 = default;
			object obj59 = obj60;
		}
		else
		{
			object obj59 = obj43;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		bool result = default;
		return result;
	}

	private unsafe static bool InterstitialStatsTryGetValueNotNull(IDictionary<string, object> dict, string key, out object obj)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00d9: Expected I, but got Obj
		//IL_00ef: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_02fe: Expected I, but got Obj
		//IL_0314: Expected Obj, but got I
		//IL_011a: Expected I, but got Obj
		//IL_02af: Expected I, but got Obj
		//IL_02c5: Expected Obj, but got I
		//IL_0167: Expected I, but got Obj
		//IL_01f8: Expected I, but got Obj
		ref object reference = default;
		string ignoredInAppOnlineSettingsId = default;
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) == null)
		{
			nint num = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v45 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v55 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(key);
			ignoredInAppOnlineSettingsId = InAppData.GetIgnoredInAppOnlineSettingsId(inAppItemModel.normalOfferId);
		}
		bool flag;
		if (ignoredInAppOnlineSettingsId != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v54 (System.String)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		bool flag2;
		if (flag)
		{
			flag2 = false;
		}
		else
		{
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v13 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v35 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag2 = InAppManager.TryAddTransactionToHistory(ignoredInAppOnlineSettingsId, null);
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v31 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((flag2 ? 1 : 0) < (false ? 1 : 0))
			{
				flag2 = false;
			}
			else if ((flag2 ? 1 : 0) > int.MaxValue)
			{
				flag2 = true;
			}
		}
		nint num7 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v5 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v14 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item(key);
		return (byte)((flag2 ? 1u : 0u) + (uint)inAppItemModel2.payoutAmount) != 0;
	}

	private unsafe static bool MigrateAdsSave(Dictionary<Key, string> mainPlayerData, IDictionary<string, object> adSystemData)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0106: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I4, but got Obj
		ref HashSet<int> reference = ref *(HashSet<int>*)null;
		if (adSystemData != null)
		{
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v13 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v25 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CollectCoinsDummy[] collectCoinsDummyData = UserSave.collectCoinsDummyData;
			if (((Dictionary<Characters.CharacterId, HashSet<int>>)(object)collectCoinsDummyData).TryGetValue((Characters.CharacterId)mainPlayerData, out reference))
			{
				return reference.Contains((int)adSystemData);
			}
			return false;
		}
		return false;
	}

	private static bool MigratePreferencesSave(Dictionary<Key, string> mainPlayerData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e03: Expected Obj, but got Unknown
		//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e11: Expected Obj, but got Unknown
		//IL_1e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1f: Expected Obj, but got Unknown
		//IL_1e28: Expected Obj, but got I4
		//IL_1e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e36: Expected Obj, but got Unknown
		//IL_1e3f: Expected Obj, but got I4
		//IL_1e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4d: Expected Obj, but got Unknown
		//IL_1e56: Expected Obj, but got I4
		//IL_1e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e64: Expected Obj, but got Unknown
		//IL_1e6d: Expected Obj, but got I4
		//IL_1e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7b: Expected Obj, but got Unknown
		//IL_1e84: Expected Obj, but got I4
		//IL_1e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e92: Expected I, but got Unknown
		//IL_1ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea9: Expected Obj, but got Unknown
		//IL_1eb2: Expected Obj, but got I4
		//IL_1ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec0: Expected Obj, but got Unknown
		//IL_1ec9: Expected Obj, but got I4
		//IL_1ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed7: Expected Obj, but got Unknown
		//IL_1ee0: Expected Obj, but got I4
		//IL_1ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eee: Expected Obj, but got Unknown
		//IL_1ef7: Expected Obj, but got I4
		//IL_1f00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f05: Expected Obj, but got Unknown
		//IL_1f0e: Expected Obj, but got I4
		//IL_1f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1c: Expected Obj, but got Unknown
		//IL_1f25: Expected Obj, but got I4
		//IL_1f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f33: Expected Obj, but got Unknown
		//IL_1f3c: Expected Obj, but got I4
		//IL_1f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4a: Expected Obj, but got Unknown
		//IL_1f53: Expected Obj, but got I4
		//IL_1f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f61: Expected Obj, but got Unknown
		//IL_1f6a: Expected Obj, but got I4
		//IL_1f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f78: Expected Obj, but got Unknown
		//IL_1f81: Expected Obj, but got I4
		//IL_1f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8f: Expected Obj, but got Unknown
		//IL_1f98: Expected Obj, but got I4
		//IL_1fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa6: Expected Obj, but got Unknown
		//IL_1faf: Expected Obj, but got I4
		//IL_1fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbd: Expected Obj, but got Unknown
		//IL_1fc6: Expected Obj, but got I4
		//IL_1fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd4: Expected Obj, but got Unknown
		//IL_1fdd: Expected Obj, but got I4
		//IL_1fe6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1feb: Expected Obj, but got Unknown
		//IL_1ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff9: Expected Obj, but got Unknown
		//IL_2015: Expected I, but got Obj
		//IL_202b: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_01f7: Expected I, but got Obj
		//IL_20a5: Expected I, but got Obj
		//IL_20bb: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_029f: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got I
		//IL_038c: Expected I, but got Obj
		//IL_20f5: Expected I, but got Obj
		//IL_210b: Expected Obj, but got I
		//IL_02e0: Expected I, but got Obj
		//IL_0434: Expected I, but got Obj
		//IL_044a: Expected Obj, but got I
		//IL_0521: Expected I, but got Obj
		//IL_2145: Expected I, but got Obj
		//IL_215b: Expected Obj, but got I
		//IL_0475: Expected I, but got Obj
		//IL_05c9: Expected I, but got Obj
		//IL_05df: Expected Obj, but got I
		//IL_06b6: Expected I, but got Obj
		//IL_2195: Expected I, but got Obj
		//IL_21ab: Expected Obj, but got I
		//IL_060a: Expected I, but got Obj
		//IL_21db: Expected I4, but got Obj
		//IL_21db: Expected Obj, but got I4
		//IL_075e: Expected I, but got Obj
		//IL_0774: Expected Obj, but got I
		//IL_0805: Expected I, but got Obj
		//IL_26f9: Expected I, but got Obj
		//IL_270f: Expected Obj, but got I
		//IL_079f: Expected I, but got Obj
		//IL_0bb0: Expected I, but got Obj
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected Obj, but got Unknown
		//IL_08ca: Expected Obj, but got I4
		//IL_2264: Expected I, but got Obj
		//IL_227a: Expected Obj, but got I
		//IL_0c3e: Expected I, but got Obj
		//IL_0c54: Expected Obj, but got I
		//IL_0ce5: Expected I, but got Obj
		//IL_21f9: Expected Obj, but got I4
		//IL_22b4: Expected I, but got Obj
		//IL_22ca: Expected Obj, but got I
		//IL_0c7f: Expected I, but got Obj
		//IL_0951: Expected I, but got Obj
		//IL_0967: Expected Obj, but got I
		//IL_0d85: Expected I, but got Obj
		//IL_0d9b: Expected Obj, but got I
		//IL_0e2c: Expected I, but got Obj
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected Obj, but got Unknown
		//IL_0992: Expected I, but got Obj
		//IL_2304: Expected I, but got Obj
		//IL_231a: Expected Obj, but got I
		//IL_0dc6: Expected I, but got Obj
		//IL_0eb5: Expected Obj, but got I4
		//IL_0ecb: Expected I, but got Obj
		//IL_0ee1: Expected Obj, but got I
		//IL_2207: Unknown result type (might be due to invalid IL or missing references)
		//IL_220c: Expected Obj, but got Unknown
		//IL_0f82: Expected I, but got Obj
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Expected Obj, but got Unknown
		//IL_2354: Expected I, but got Obj
		//IL_236a: Expected Obj, but got I
		//IL_0f0c: Expected I, but got Obj
		//IL_1010: Expected I, but got Obj
		//IL_1026: Expected Obj, but got I
		//IL_10c7: Expected I, but got Obj
		//IL_0aa1: Expected I, but got Obj
		//IL_0ab7: Expected Obj, but got I
		//IL_23a4: Expected I, but got Obj
		//IL_23ba: Expected Obj, but got I
		//IL_1051: Expected I, but got Obj
		//IL_1155: Expected I, but got Obj
		//IL_116b: Expected Obj, but got I
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected Obj, but got Unknown
		//IL_0ae2: Expected I, but got Obj
		//IL_11fc: Expected I, but got Obj
		//IL_23f4: Expected I, but got Obj
		//IL_240a: Expected Obj, but got I
		//IL_1196: Expected I, but got Obj
		//IL_128a: Expected I, but got Obj
		//IL_12a0: Expected Obj, but got I
		//IL_1331: Expected I, but got Obj
		//IL_2481: Expected I, but got Obj
		//IL_2497: Expected Obj, but got I
		//IL_12cb: Expected I, but got Obj
		//IL_13bf: Expected I, but got Obj
		//IL_13d5: Expected Obj, but got I
		//IL_14c6: Expected I, but got Obj
		//IL_24d1: Expected I, but got Obj
		//IL_24e7: Expected Obj, but got I
		//IL_1400: Expected I, but got Obj
		//IL_1554: Expected I, but got Obj
		//IL_156a: Expected Obj, but got I
		//IL_1609: Expected I, but got Obj
		//IL_2521: Expected I, but got Obj
		//IL_2537: Expected Obj, but got I
		//IL_1595: Expected I, but got Obj
		//IL_1697: Expected I, but got Obj
		//IL_16ad: Expected Obj, but got I
		//IL_174c: Expected I, but got Obj
		//IL_2571: Expected I, but got Obj
		//IL_2587: Expected Obj, but got I
		//IL_16d8: Expected I, but got Obj
		//IL_17da: Expected I, but got Obj
		//IL_17f0: Expected Obj, but got I
		//IL_188f: Expected I, but got Obj
		//IL_25c1: Expected I, but got Obj
		//IL_25d7: Expected Obj, but got I
		//IL_181b: Expected I, but got Obj
		//IL_191d: Expected I, but got Obj
		//IL_1933: Expected Obj, but got I
		//IL_19d2: Expected I, but got Obj
		//IL_2611: Expected I, but got Obj
		//IL_2627: Expected Obj, but got I
		//IL_195e: Expected I, but got Obj
		//IL_1a60: Expected I, but got Obj
		//IL_1a76: Expected Obj, but got I
		//IL_1b07: Expected I, but got Obj
		//IL_1bc0: Expected I, but got Obj
		//IL_1bd6: Expected Obj, but got I
		//IL_1aa1: Expected I, but got Obj
		//IL_1c01: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 128;
		object obj3 = obj2 + 48;
		object obj4 = obj2 + 56;
		object obj5 = obj2 + 113;
		obj5 = 0;
		object obj6 = obj2 + 112;
		obj6 = 0;
		object obj7 = obj2 + 111;
		obj7 = 0;
		object obj8 = obj2 + 110;
		obj8 = 0;
		object obj9 = obj2 + 104;
		obj9 = 0;
		nint num = (nint)(obj2 + 100);
		num = 0;
		object obj10 = obj2 + 96;
		obj10 = 0;
		object obj11 = obj2 + 109;
		obj11 = 0;
		object obj12 = obj2 + 92;
		obj12 = 0;
		object obj13 = obj2 + 40;
		obj13 = 0;
		object obj14 = obj2 + 88;
		obj14 = 0;
		object obj15 = obj2 + 84;
		obj15 = 0;
		object obj16 = obj2 + 80;
		obj16 = 0;
		object obj17 = obj2 + 32;
		obj17 = 0;
		object obj18 = obj2 + 24;
		obj18 = 0;
		object obj19 = obj2 + 16;
		obj19 = 0;
		object obj20 = obj2 + 8;
		obj20 = 0;
		object obj21 = obj2 + 76;
		obj21 = 0;
		object obj22 = obj2 + 108;
		obj22 = 0;
		object obj23 = obj2 + 72;
		obj23 = 0;
		object obj24 = obj + 16;
		object obj25 = obj2 - -64;
		obj25 = obj;
		_ = -1;
		nint num2 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v59 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num3 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v1188 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj27 = default;
		if (obj27 != null)
		{
			nint num4 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v1100 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num5 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ S0_v1125 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			bool flag = obj5 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		nint num6 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v76 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num7 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ S0_v1089 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj30 = default;
		if (obj30 != null)
		{
			nint num8 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ S0_v1057 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj31 = (nint)0 & (nint)0x200;
			if (obj31 != null)
			{
				nint num9 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ S0_v1081 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			bool flag2 = obj6 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		nint num10 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ S0_v85 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num11 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ S0_v1046 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj33 = default;
		if (obj33 != null)
		{
			nint num12 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ S0_v1014 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num13 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ S0_v1038 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			bool flag3 = obj7 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		nint num14 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ S0_v94 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num15 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ S0_v1003 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj36 = default;
		if (obj36 != null)
		{
			nint num16 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ S0_v971 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num17 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ S0_v995 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			bool flag4 = obj8 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		nint num18 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ S0_v103 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj38 = (nint)0 & (nint)0x200;
		if (obj38 != null)
		{
			nint num19 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ S0_v960 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj39 = default;
		if (obj39 != null)
		{
			nint num20 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ S0_v936 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj40 = (nint)0 & (nint)0x200;
			if (obj40 != null)
			{
				nint num21 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ S0_v950 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num22 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1349 @ S0_v115 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		if (obj41 != null)
		{
			nint num23 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1367 @ S0_v923 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		((List<int>)309).set_Item((int)mainPlayerData, 64);
		object obj42 = default;
		if (obj42 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj44 = default;
			object obj43 = obj44 + 16;
			obj43 = 44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj45 = default;
			object obj48 = default;
			if (obj45 != null)
			{
				nint num24 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1552 @ S0_v882 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj46 = (nint)0 & (nint)0x200;
				if (obj46 != null)
				{
					nint num25 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1578 @ S0_v905 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				object obj47 = obj48 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			object obj49 = 1;
			object obj50 = default;
			object obj54 = default;
			while ((nint)obj49 <= 4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj50 != null)
				{
					object obj51 = obj48 + 16;
					object obj52 = obj49 << 2;
					object obj53 = obj51 + obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj54 != null)
					{
						nint num26 = (nint)typeof(EventsSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1817 @ S0_v850 (Il2CppClass<Data.Save.EventsSave>)+BA]");
						object obj55 = (nint)0 & (nint)0x200;
						if (obj55 != null)
						{
							nint num27 = (nint)typeof(EventsSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1833 @ S0_v872 (Il2CppClass<Data.Save.EventsSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						object obj56 = obj49 - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					}
				}
				object obj57 = obj49 + 1;
				obj49 = obj57;
			}
		}
		nint num28 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1429 @ S0_v127 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj58 = (nint)0 & (nint)0x200;
		if (obj58 != null)
		{
			nint num29 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1436 @ S0_v785 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj59 = default;
		if (obj59 != null)
		{
			nint num30 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1489 @ S0_v761 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj60 = (nint)0 & (nint)0x200;
			if (obj60 != null)
			{
				nint num31 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1510 @ S0_v775 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num32 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1503 @ S0_v139 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj61 = (nint)0 & (nint)0x200;
		if (obj61 != null)
		{
			nint num33 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1522 @ S0_v748 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj62 = default;
		if (obj62 != null)
		{
			bool flag5 = obj11 != null;
			nint num34 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1609 @ S0_v724 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj63 = (nint)0 & (nint)0x200;
			if (obj63 != null)
			{
				nint num35 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1642 @ S0_v738 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num36 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ S0_v151 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj64 = (nint)0 & (nint)0x200;
		if (obj64 != null)
		{
			nint num37 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ S0_v710 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj65 = default;
		if (obj65 != null)
		{
			obj24 = 0;
			obj24 = obj12;
			nint num38 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1752 @ S0_v684 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj66 = (nint)0 & (nint)0x200;
			if (obj66 != null)
			{
				nint num39 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1772 @ S0_v700 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj4 = obj24;
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num40 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1766 @ S0_v163 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj67 = (nint)0 & (nint)0x200;
		if (obj67 != null)
		{
			nint num41 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1789 @ S0_v663 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj68 = default;
		if (obj68 != null)
		{
			nint num42 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1849 @ S0_v637 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj69 = (nint)0 & (nint)0x200;
			if (obj69 != null)
			{
				nint num43 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1873 @ S0_v653 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj2 = obj13;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num44 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1863 @ S0_v175 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj70 = (nint)0 & (nint)0x200;
		if (obj70 != null)
		{
			nint num45 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1890 @ S0_v624 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj71 = default;
		if (obj71 != null)
		{
			nint num46 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1953 @ S0_v600 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj72 = (nint)0 & (nint)0x200;
			if (obj72 != null)
			{
				nint num47 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1971 @ S0_v614 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num48 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1967 @ S0_v187 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj73 = (nint)0 & (nint)0x200;
		if (obj73 != null)
		{
			nint num49 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1983 @ S0_v587 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj74 = default;
		if (obj74 != null)
		{
			nint num50 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2025 @ S0_v563 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj75 = (nint)0 & (nint)0x200;
			if (obj75 != null)
			{
				nint num51 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2043 @ S0_v577 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num52 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2039 @ S0_v199 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj76 = (nint)0 & (nint)0x200;
		if (obj76 != null)
		{
			nint num53 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2055 @ S0_v550 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj77 = default;
		object obj79;
		object obj81;
		object obj82 = default;
		if (obj77 != null)
		{
			nint num54 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2098 @ S0_v505 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj78 = (nint)0 & (nint)0x200;
			if (obj78 != null)
			{
				nint num55 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2118 @ S0_v537 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj80 = default;
			obj79 = obj80;
			obj81 = obj82;
		}
		else
		{
			nint num56 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2114 @ S0_v211 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj83 = (nint)0 & (nint)0x200;
			if (obj83 != null)
			{
				nint num57 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2130 @ S0_v492 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj84 = default;
			if (obj84 != null)
			{
				nint num58 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2197 @ S0_v468 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj85 = (nint)0 & (nint)0x200;
				if (obj85 != null)
				{
					nint num59 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2223 @ S0_v482 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				object obj86 = obj17 >> 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1EF");
			}
			nint num60 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2212 @ S0_v223 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj87 = (nint)0 & (nint)0x200;
			if (obj87 != null)
			{
				nint num61 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2237 @ S0_v455 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj88 = default;
			if (obj88 != null)
			{
				nint num62 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2281 @ S0_v431 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj89 = (nint)0 & (nint)0x200;
				if (obj89 != null)
				{
					nint num63 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2300 @ S0_v445 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				object obj90 = obj18 >> 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1EF");
			}
			nint num64 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2296 @ S0_v235 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj91 = (nint)0 & (nint)0x200;
			if (obj91 != null)
			{
				nint num65 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2314 @ S0_v418 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj92 = default;
			if (obj92 != null)
			{
				nint num66 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2356 @ S0_v394 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj93 = (nint)0 & (nint)0x200;
				if (obj93 != null)
				{
					nint num67 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2375 @ S0_v408 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				object obj94 = obj19 >> 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1EF");
			}
			nint num68 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2371 @ S0_v247 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj95 = (nint)0 & (nint)0x200;
			if (obj95 != null)
			{
				nint num69 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2389 @ S0_v381 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj96 = default;
			if (obj96 != null)
			{
				nint num70 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2431 @ S0_v357 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj97 = (nint)0 & (nint)0x200;
				if (obj97 != null)
				{
					nint num71 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2450 @ S0_v371 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				object obj98 = obj20 >> 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1EF");
			}
			nint num72 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2446 @ S0_v259 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj99 = (nint)0 & (nint)0x200;
			if (obj99 != null)
			{
				nint num73 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2464 @ S0_v344 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj100 = default;
			if (obj100 != null)
			{
				nint num74 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2506 @ S0_v320 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj101 = (nint)0 & (nint)0x200;
				if (obj101 != null)
				{
					nint num75 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2524 @ S0_v334 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num76 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2520 @ S0_v271 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj102 = (nint)0 & (nint)0x200;
			if (obj102 != null)
			{
				nint num77 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2536 @ S0_v307 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj103 = default;
			if (obj103 == null)
			{
				return true;
			}
			bool flag6 = obj22 != null;
			nint num78 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2580 @ S0_v283 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj104 = (nint)0 & (nint)0x200;
			if (obj104 != null)
			{
				nint num79 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2585 @ S0_v298 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj105 = default;
			obj79 = obj105;
			obj81 = obj82;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj106 = default;
		if (obj81 == obj106)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj108 = default;
			object obj107 = obj108;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj110 = default;
			object obj109 = obj110;
		}
		else
		{
			object obj109 = obj79;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		bool result = default;
		return result;
	}

	private static bool MigrateAnalyticsSave(Dictionary<Key, string> mainPlayerData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0375: Expected Obj, but got I4
		//IL_0391: Expected I, but got Obj
		//IL_03a7: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 12;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v113 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj6 = default;
		if (obj6 != null)
		{
			bool flag = obj3 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num3 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v27 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v43 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			return true;
		}
		return true;
	}

	private static bool MigrateOnboardingSave(Dictionary<Key, string> mainPlayerData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Expected Obj, but got Unknown
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Expected Obj, but got Unknown
		//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Expected Obj, but got Unknown
		//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected Obj, but got Unknown
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Expected Obj, but got Unknown
		//IL_0b22: Expected Obj, but got I4
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Expected Obj, but got Unknown
		//IL_0b39: Expected Obj, but got I4
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected Obj, but got Unknown
		//IL_0b50: Expected Obj, but got I4
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Expected Obj, but got Unknown
		//IL_0b67: Expected Obj, but got F4
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected Obj, but got Unknown
		//IL_0b7e: Expected Obj, but got I4
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected Obj, but got Unknown
		//IL_0b95: Expected Obj, but got I4
		//IL_0b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Expected Obj, but got Unknown
		//IL_0bac: Expected Obj, but got I4
		//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bba: Expected Obj, but got Unknown
		//IL_0bc3: Expected Obj, but got I4
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Expected Obj, but got Unknown
		//IL_0bed: Expected I, but got Obj
		//IL_0c03: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0c5f: Expected I, but got Obj
		//IL_0c75: Expected Obj, but got I
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0170: Expected I, but got Obj
		//IL_0ca0: Expected I, but got Obj
		//IL_0cb6: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_0258: Expected I, but got Obj
		//IL_0d22: Expected I, but got Obj
		//IL_0d38: Expected Obj, but got I
		//IL_0300: Expected I, but got Obj
		//IL_0316: Expected Obj, but got I
		//IL_04a8: Expected I, but got Obj
		//IL_0ce1: Expected I, but got Obj
		//IL_0cf7: Expected Obj, but got I
		//IL_0d63: Expected I, but got Obj
		//IL_0d79: Expected Obj, but got I
		//IL_0f25: Expected Obj, but got VT
		//IL_0341: Expected I, but got Obj
		//IL_03ad: Expected I, but got Obj
		//IL_057e: Expected I, but got Obj
		//IL_0e20: Expected I, but got Obj
		//IL_0e36: Expected Obj, but got I
		//IL_0626: Expected I, but got Obj
		//IL_063c: Expected Obj, but got I
		//IL_079a: Expected I, but got Obj
		//IL_0da4: Expected I, but got Obj
		//IL_0dba: Expected Obj, but got I
		//IL_0e70: Expected I, but got Obj
		//IL_0e86: Expected Obj, but got I
		//IL_0de0: Expected Obj, but got VT
		//IL_0667: Expected I, but got Obj
		//IL_06b9: Expected I, but got Obj
		//IL_0870: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 32;
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 8;
		object obj7 = obj2 + 76;
		obj7 = 0;
		object obj8 = obj2 + 80;
		obj8 = 0;
		object obj9 = obj2 + 72;
		obj9 = 0;
		object obj10 = obj2 + 68;
		obj10 = 0f;
		object obj11 = obj2 - -64;
		obj11 = 0;
		object obj12 = obj2 + 60;
		obj12 = 0;
		object obj13 = obj2 + 56;
		obj13 = 0;
		object obj14 = obj2 + 16;
		obj14 = 0;
		object obj15 = obj2 + 48;
		obj15 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v39 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v440 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj17 = default;
		if (obj17 != null)
		{
			nint num3 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v363 (Il2CppClass<Flurry>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num4 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v377 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num5 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v51 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num6 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v350 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj20 = default;
		if (obj20 != null)
		{
			bool flag = obj8 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num7 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S0_v60 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num8 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v329 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj22 = default;
		object obj26 = default;
		object obj32;
		object obj34;
		if (obj22 != null)
		{
			nint num9 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S0_v262 (Il2CppClass<System.DateTime>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num10 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ S0_v314 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			nint num11 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S0_v270 (Il2CppClass<Utils>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num12 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ S0_v304 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj4 = DateTime.MinValue;
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
			object obj25 = obj26 << 32;
			object obj28 = default;
			object obj27 = obj28 | obj25;
			obj14 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
			object obj29 = obj26 << 32;
			object obj31 = default;
			object obj30 = obj31 | obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj33 = default;
			obj32 = obj33;
			obj34 = obj26;
		}
		else
		{
			nint num13 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ S0_v72 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num14 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S0_v249 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj36 = default;
			if (obj36 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E");
			}
			nint num15 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ S0_v81 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num16 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S0_v229 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj38 = default;
			if (obj38 != null)
			{
				nint num17 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ S0_v163 (Il2CppClass<System.DateTime>)+BA]");
				object obj39 = (nint)0 & (nint)0x200;
				if (obj39 != null)
				{
					nint num18 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ S0_v215 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				nint num19 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ S0_v171 (Il2CppClass<Utils>)+BA]");
				object obj40 = (nint)0 & (nint)0x200;
				if (obj40 != null)
				{
					nint num20 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ S0_v205 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj6 = DateTime.MinValue;
				obj3 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
				object obj41 = obj26 << 32;
				object obj43 = default;
				object obj42 = obj43 | obj41;
				obj14 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
				object obj44 = obj26 << 32;
				object obj46 = default;
				object obj45 = obj46 | obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj47 = default;
				obj32 = obj47;
				obj34 = obj26;
			}
			else
			{
				nint num21 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S0_v93 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj48 = (nint)0 & (nint)0x200;
				if (obj48 != null)
				{
					nint num22 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ S0_v149 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj49 = default;
				if (obj49 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				nint num23 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ S0_v105 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj50 = (nint)0 & (nint)0x200;
				if (obj50 != null)
				{
					nint num24 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ S0_v126 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj51 = default;
				if (obj51 == null)
				{
					return true;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj52 = default;
				obj32 = obj52;
				obj34 = obj26;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj53 = default;
		if (obj34 == obj53)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj55 = default;
			object obj54 = obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj57 = default;
			object obj56 = obj57;
		}
		else
		{
			object obj56 = obj32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		bool result = default;
		return result;
	}

	public static bool CanMigrate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0218: Expected I, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v90 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IDictionary<string, object> mainPlayerData = LoadAdSystemDataFile();
		bool flag = MigrateSyboAnalyticsSave((Dictionary<Key, string>)mainPlayerData);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj4 = default;
		string text = KilooJson.Serialize(obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		bool result = default;
		return result;
	}

	private static bool TryGetLoadPaths(out string path)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2e: Expected Obj, but got Unknown
		//IL_0f37: Expected Obj, but got I4
		//IL_0f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f45: Expected Obj, but got Unknown
		//IL_0f4e: Expected Obj, but got I4
		//IL_0f57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5c: Expected Obj, but got Unknown
		//IL_0f65: Expected Obj, but got I4
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Expected Obj, but got Unknown
		//IL_0f7c: Expected Obj, but got I4
		//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8a: Expected Obj, but got Unknown
		//IL_0f93: Expected Obj, but got I4
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa1: Expected Obj, but got Unknown
		//IL_0faa: Expected Obj, but got I4
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb8: Expected Obj, but got Unknown
		//IL_0fc1: Expected Obj, but got I4
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Expected Obj, but got Unknown
		//IL_0fd8: Expected Obj, but got I4
		//IL_0fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe6: Expected Obj, but got Unknown
		//IL_0fef: Expected Obj, but got I4
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffd: Expected Obj, but got Unknown
		//IL_1006: Expected Obj, but got I4
		//IL_100f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1014: Expected Obj, but got Unknown
		//IL_101d: Expected Obj, but got I4
		//IL_1026: Unknown result type (might be due to invalid IL or missing references)
		//IL_102b: Expected Obj, but got Unknown
		//IL_1034: Expected Obj, but got I4
		//IL_103d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Expected Obj, but got Unknown
		//IL_104b: Expected Obj, but got I4
		//IL_1054: Unknown result type (might be due to invalid IL or missing references)
		//IL_1059: Expected Obj, but got Unknown
		//IL_1062: Expected Obj, but got I4
		//IL_106b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1070: Expected Obj, but got Unknown
		//IL_1079: Expected Obj, but got I4
		//IL_1082: Unknown result type (might be due to invalid IL or missing references)
		//IL_1087: Expected Obj, but got Unknown
		//IL_1090: Expected Obj, but got I4
		//IL_10ac: Expected I, but got Obj
		//IL_10c2: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_111e: Expected I, but got Obj
		//IL_1134: Expected Obj, but got I
		//IL_00f7: Expected I, but got Obj
		//IL_115f: Expected I, but got Obj
		//IL_1175: Expected Obj, but got I
		//IL_01cd: Expected I, but got Obj
		//IL_11a0: Expected I, but got Obj
		//IL_11b6: Expected Obj, but got I
		//IL_02b5: Expected I, but got Obj
		//IL_11e1: Expected I, but got Obj
		//IL_11f7: Expected Obj, but got I
		//IL_039d: Expected I, but got Obj
		//IL_1222: Expected I, but got Obj
		//IL_1238: Expected Obj, but got I
		//IL_0485: Expected I, but got Obj
		//IL_1272: Expected I, but got Obj
		//IL_1288: Expected Obj, but got I
		//IL_056d: Expected I, but got Obj
		//IL_12c2: Expected I, but got Obj
		//IL_12d8: Expected Obj, but got I
		//IL_063b: Expected I, but got Obj
		//IL_1312: Expected I, but got Obj
		//IL_1328: Expected Obj, but got I
		//IL_0709: Expected I, but got Obj
		//IL_1362: Expected I, but got Obj
		//IL_1378: Expected Obj, but got I
		//IL_07d7: Expected I, but got Obj
		//IL_13b2: Expected I, but got Obj
		//IL_13c8: Expected Obj, but got I
		//IL_08a5: Expected I, but got Obj
		//IL_1402: Expected I, but got Obj
		//IL_1418: Expected Obj, but got I
		//IL_0973: Expected I, but got Obj
		//IL_1452: Expected I, but got Obj
		//IL_1468: Expected Obj, but got I
		//IL_0a41: Expected I, but got Obj
		//IL_14a2: Expected I, but got Obj
		//IL_14b8: Expected Obj, but got I
		//IL_0b0f: Expected I, but got Obj
		//IL_14f2: Expected I, but got Obj
		//IL_1508: Expected Obj, but got I
		//IL_0bdd: Expected I, but got Obj
		//IL_1542: Expected I, but got Obj
		//IL_1558: Expected Obj, but got I
		//IL_0cab: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 12;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = 0;
		object obj5 = obj2 + 29;
		obj5 = 0;
		object obj6 = obj2 + 28;
		obj6 = 0;
		object obj7 = obj2 + 27;
		obj7 = 0;
		object obj8 = obj2 + 26;
		obj8 = 0;
		object obj9 = obj2 + 25;
		obj9 = 0;
		object obj10 = obj2 + 24;
		obj10 = 0;
		object obj11 = obj2 + 23;
		obj11 = 0;
		object obj12 = obj2 + 22;
		obj12 = 0;
		object obj13 = obj2 + 21;
		obj13 = 0;
		object obj14 = obj2 + 20;
		obj14 = 0;
		object obj15 = obj2 + 19;
		obj15 = 0;
		object obj16 = obj2 + 18;
		obj16 = 0;
		object obj17 = obj2 + 17;
		obj17 = 0;
		object obj18 = obj2 + 16;
		obj18 = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v46 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v630 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num3 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v55 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num4 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ S0_v557 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj22 = default;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num5 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ S0_v64 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num6 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ S0_v537 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj24 = default;
		if (obj24 != null)
		{
			bool flag = obj5 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num7 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ S0_v73 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num8 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ S0_v516 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj26 = default;
		if (obj26 != null)
		{
			bool flag2 = obj6 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num9 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ S0_v82 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num10 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ S0_v495 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj28 = default;
		if (obj28 != null)
		{
			bool flag3 = obj7 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num11 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ S0_v91 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num12 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ S0_v473 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj30 = default;
		if (obj30 != null)
		{
			bool flag4 = obj8 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num13 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ S0_v103 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num14 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ S0_v449 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj32 = default;
		if (obj32 != null)
		{
			bool flag5 = obj9 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num15 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ S0_v115 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num16 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ S0_v425 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj34 = default;
		if (obj34 != null)
		{
			bool flag6 = obj10 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num17 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ S0_v127 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num18 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ S0_v401 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj36 = default;
		if (obj36 != null)
		{
			bool flag7 = obj11 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num19 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1084 @ S0_v139 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj37 = (nint)0 & (nint)0x200;
		if (obj37 != null)
		{
			nint num20 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ S0_v377 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj38 = default;
		if (obj38 != null)
		{
			bool flag8 = obj12 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num21 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1133 @ S0_v151 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj39 = (nint)0 & (nint)0x200;
		if (obj39 != null)
		{
			nint num22 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ S0_v353 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj40 = default;
		if (obj40 != null)
		{
			bool flag9 = obj13 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num23 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ S0_v163 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		if (obj41 != null)
		{
			nint num24 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1189 @ S0_v329 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj42 = default;
		if (obj42 != null)
		{
			bool flag10 = obj14 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num25 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ S0_v175 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj43 = (nint)0 & (nint)0x200;
		if (obj43 != null)
		{
			nint num26 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ S0_v305 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj44 = default;
		if (obj44 != null)
		{
			bool flag11 = obj15 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num27 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1280 @ S0_v187 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj45 = (nint)0 & (nint)0x200;
		if (obj45 != null)
		{
			nint num28 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ S0_v281 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj46 = default;
		if (obj46 != null)
		{
			bool flag12 = obj16 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num29 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ S0_v199 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj47 = (nint)0 & (nint)0x200;
		if (obj47 != null)
		{
			nint num30 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1336 @ S0_v257 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj48 = default;
		if (obj48 != null)
		{
			bool flag13 = obj17 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num31 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1378 @ S0_v211 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj49 = (nint)0 & (nint)0x200;
		if (obj49 != null)
		{
			nint num32 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ S0_v233 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj50 = default;
		if (obj50 == null)
		{
			return true;
		}
		bool flag14 = obj18 != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj52 = default;
		object obj51 = obj52;
		object obj54 = default;
		object obj53 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj55 = default;
		if (obj53 == obj55)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj57 = default;
			object obj56 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj59 = default;
			object obj58 = obj59;
		}
		else
		{
			object obj58 = obj51;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		bool result = default;
		return result;
	}

	private static string GetSavePath()
	{
		//IL_015d: Expected Obj, but got I4
		//IL_016b: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I4
		Dictionary<Key, string> dictionary = (Dictionary<Key, string>)0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v38 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UserSave.migratedPlayerPrefsVersion != 0)
		{
			return null;
		}
		nint num3 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v33 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (MigrateUserSave(dictionary))
		{
			if (FileUtil.GetMostRecentSlot((string)(object)dictionary, false) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v27 (System.Int32)+C]");
				bool flag = (nint)0 != 0;
				return (string)flag;
			}
			return null;
		}
		return null;
	}

	private static bool MigrateUserSave(Dictionary<Key, string> mainPlayerData)
	{
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009e: Expected I4, but got Obj
		//IL_0082: Expected Obj, but got I4
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		Dictionary<Key, string> dictionary;
		if (cachePath == null || cachePath.m_stringLength == 0)
		{
			dictionary = (Dictionary<Key, string>)0;
			return false;
		}
		string text = string.ConcatArray((string[])(object)cachePath, (int)"/playerdata");
		dictionary = (Dictionary<Key, string>)(object)text;
		return true;
	}

	private static bool TryLoadString(Dictionary<Key, string> dict, Key key, out string stringToSet)
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_00ec: Expected VT, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(PlayerInfoMigrator);
		if (!flag)
		{
			nint num3 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(PlayerInfoMigrator);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(PlayerInfoMigrator);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L3_v2 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = key;
		return Kiloo.Common.Extensions.CollectionExtensions.TryGetValueNotNullOrEmpty<T>((IDictionary<T, string>)dict, (T)key, out stringToSet);
	}

	private unsafe static bool TryLoadInt(Dictionary<Key, string> dict, Key key, out int intToSet)
	{
		//IL_0097: Expected I, but got Obj
		//IL_00ad: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		ref string reference = ref *(string*)null;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v23 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_lastKeyRead = key;
		ref int reference2;
		if (dict.TryGetValue(key, out reference))
		{
			reference2 = ref *(int*)reference;
			return true;
		}
		reference2 = ref *(int*)null;
		return false;
	}

	private unsafe static bool TryLoadFloat(Dictionary<Key, string> dict, Key key, out float floatToSet)
	{
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I8
		//IL_00a1: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I4
		ref long reference2 = default;
		ref string reference = ref System.Runtime.CompilerServices.Unsafe.As<long, string>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 4));
		reference = ref *(string*)null;
		reference2 = ref *(long*)null;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v35 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_lastKeyRead = key;
		object obj3;
		bool result;
		if (dict.TryGetValue(key, out reference))
		{
			nint num3 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v12 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v17 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			bool flag = long.TryParse(reference, NumberStyles.Integer, currentCulture, out reference2);
			bool flag2 = !flag;
			bool flag3 = !flag2;
			obj3 = reference2;
			if (!flag3)
			{
				obj3 = 0;
			}
			result = flag;
		}
		else
		{
			obj3 = 0;
			result = false;
		}
		ref float reference3 = ref *(float*)obj3;
		return result;
	}

	private unsafe static bool TryLoadLong(Dictionary<Key, string> dict, Key key, out long longToSet)
	{
		//IL_0132: Expected Ref, but got F4
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_0104: Expected Ref, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ed: Expected Ref, but got F4
		ref float reference2 = default;
		ref string reference = ref System.Runtime.CompilerServices.Unsafe.As<float, string>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference2, 1));
		reference = ref *(string*)null;
		reference2 = ref *(float*)0f;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v31 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_lastKeyRead = key;
		ref long reference3;
		if (dict.TryGetValue(key, out reference))
		{
			nint num3 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v14 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v21 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			if (float.TryParse(reference, NumberStyles.Float, (NumberFormatInfo)(object)currentCulture, out reference2))
			{
				reference3 = ref *(long*)reference2;
				return true;
			}
		}
		reference3 = ref *(long*)0f;
		return false;
	}

	private unsafe static bool TryLoadBool(Dictionary<Key, string> dict, Key key, out bool boolToSet)
	{
		//IL_012a: Expected I, but got Obj
		//IL_0140: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a4: Expected Obj, but got F8
		//IL_00a1: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I4
		ref double reference2 = default;
		ref string reference = ref System.Runtime.CompilerServices.Unsafe.As<double, string>(ref System.Runtime.CompilerServices.Unsafe.Add(ref reference2, 1));
		reference = ref *(string*)null;
		reference2 = ref *(double*)null;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v34 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_lastKeyRead = key;
		object obj3 = default;
		bool result;
		if (dict.TryGetValue(key, out reference))
		{
			nint num3 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v12 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v17 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			bool flag = System.Number.TryParseDouble(reference, NumberStyles.Integer, (NumberFormatInfo)(object)currentCulture, out reference2);
			bool flag2 = !flag;
			bool flag3 = !flag2;
			obj3 = reference2;
			if (!flag3)
			{
				obj3 = 0;
			}
			result = flag;
		}
		else
		{
			result = false;
		}
		ref bool reference3 = ref *(bool*)obj3;
		return result;
	}

	private unsafe static bool TryLoadDateTime(Dictionary<Key, string> dict, Key key, out DateTime valueToSet)
	{
		//IL_0114: Expected Obj, but got Ref
		//IL_011d: Expected Obj, but got I4
		//IL_012b: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_00ef: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_018e: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00e5: Expected I, but got Obj
		ref string reference = ref *(string*)null;
		IFormatProvider formatProvider = (IFormatProvider)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 4));
		formatProvider = (IFormatProvider)0;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v35 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_lastKeyRead = key;
		nint num5;
		bool result;
		if (dict.TryGetValue(key, out reference))
		{
			nint num3 = (nint)typeof(bool);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v12 (Il2CppClass<System.Boolean>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(bool);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v17 (Il2CppClass<System.Boolean>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = ((bool*)reference)->System_002EIConvertible_002EToBoolean(formatProvider);
			bool flag2 = !flag;
			bool flag3 = !flag2;
			num5 = (nint)formatProvider;
			if (!flag3)
			{
				num5 = unchecked((nint)null);
			}
			result = flag;
		}
		else
		{
			num5 = unchecked((nint)null);
			result = false;
		}
		ref DateTime reference2 = ref *(DateTime*)num5;
		return result;
	}

	private unsafe static bool TryLoadEnum<T>(Dictionary<Key, string> dict, Key key, out T enumToSet)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S2_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S2_v3+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dict @ L0 (System.Collections.Generic.Dictionary`2<Data.Migration.Key, System.String>)+C]");
		object obj7 = (nint)0 + (nint)16;
		object obj8 = obj6 << 4;
		object obj9 = obj7 + obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v7+C]");
		ref T reference = ref *(T*)null;
		return true;
	}

	private unsafe static int[] LoadIntArray(Dictionary<Key, string> dict, Key key, int[] defaultValue)
	{
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Ref, but got Unknown
		//IL_01da: Expected Obj, but got I4
		//IL_01e8: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0232: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_02a7: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I
		//IL_013e: Expected Obj, but got I4
		//IL_015b: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I4
		CultureInfo cultureInfo = default;
		ref string reference = ref *(string*)(cultureInfo + 8);
		reference = ref *(string*)null;
		cultureInfo = (CultureInfo)0;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v38 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_lastKeyRead = key;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		int[] result;
		if (dict.TryGetValue(key, out reference))
		{
			nint num3 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v12 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v34 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S2_v5 (Il2CppClass<System.DateTime>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S2_v12 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = ((System.DefaultBinder)(object)reference).ChangeType((object)currentCulture, (Type)null, cultureInfo);
			int[] array2;
			if (obj4 != null)
			{
				int[] array = (int[])(object)cultureInfo;
				array2 = (int[])1;
			}
			else
			{
				array2 = null;
			}
			nint num7 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v20 (Il2CppClass<System.DateTime>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v28 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFC");
			object obj6 = default;
			bool flag = obj6 == null;
			result = array2;
			if (!flag)
			{
				int[] array = (int[])(object)cultureInfo;
				result = (int[])1;
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	private unsafe static bool[] LoadBoolArray(Dictionary<Key, string> dict, Key key, bool[] defaultValue)
	{
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I4
		//IL_00e6: Expected I, but got Obj
		//IL_00fc: Expected Obj, but got I
		//IL_0127: Expected I, but got Obj
		ref string reference = ref *(string*)null;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v33 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_lastKeyRead = key;
		if (dict.TryGetValue(key, out reference))
		{
			string text = reference;
			if (reference != null && text.m_stringLength != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				int num3 = default;
				object obj2 = num3 + 16;
				obj2 = 44;
				string array = reference.Substring(num3);
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v14 (Il2CppClass<Globals>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v19 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return Globals.convertAllStringToBool((string[])(object)array);
			}
		}
		bool[] result = default;
		return result;
	}

	private static CharacterNameEventData DeserializeCharacterEventDataFromJson(string characterNameData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_31de: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e3: Expected Obj, but got Unknown
		//IL_31ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_31f1: Expected Obj, but got Unknown
		//IL_31fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ff: Expected Obj, but got Unknown
		//IL_3208: Unknown result type (might be due to invalid IL or missing references)
		//IL_320d: Expected Obj, but got Unknown
		//IL_3216: Unknown result type (might be due to invalid IL or missing references)
		//IL_321b: Expected Obj, but got Unknown
		//IL_3224: Unknown result type (might be due to invalid IL or missing references)
		//IL_3229: Expected Obj, but got Unknown
		//IL_3232: Unknown result type (might be due to invalid IL or missing references)
		//IL_3237: Expected Obj, but got Unknown
		//IL_3240: Unknown result type (might be due to invalid IL or missing references)
		//IL_3245: Expected Obj, but got Unknown
		//IL_324e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3253: Expected Obj, but got Unknown
		//IL_325c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3261: Expected Obj, but got Unknown
		//IL_326a: Unknown result type (might be due to invalid IL or missing references)
		//IL_326f: Expected Obj, but got Unknown
		//IL_3278: Expected Obj, but got I4
		//IL_3281: Unknown result type (might be due to invalid IL or missing references)
		//IL_3286: Expected Obj, but got Unknown
		//IL_328f: Expected Obj, but got I4
		//IL_3298: Unknown result type (might be due to invalid IL or missing references)
		//IL_329d: Expected Obj, but got Unknown
		//IL_32a6: Expected Obj, but got I4
		//IL_32af: Unknown result type (might be due to invalid IL or missing references)
		//IL_32b4: Expected Obj, but got Unknown
		//IL_32bd: Expected Obj, but got I4
		//IL_32c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_32cb: Expected Obj, but got Unknown
		//IL_32d4: Expected Obj, but got I4
		//IL_32dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e2: Expected Obj, but got Unknown
		//IL_32eb: Expected Obj, but got I4
		//IL_32f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_32f9: Expected Obj, but got Unknown
		//IL_3302: Expected Obj, but got I4
		//IL_330b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3310: Expected Obj, but got Unknown
		//IL_3319: Expected Obj, but got I4
		//IL_3322: Unknown result type (might be due to invalid IL or missing references)
		//IL_3327: Expected Obj, but got Unknown
		//IL_3330: Expected Obj, but got I4
		//IL_3339: Unknown result type (might be due to invalid IL or missing references)
		//IL_333e: Expected Obj, but got Unknown
		//IL_3347: Expected Obj, but got I4
		//IL_3350: Unknown result type (might be due to invalid IL or missing references)
		//IL_3355: Expected Obj, but got Unknown
		//IL_335e: Expected Obj, but got I4
		//IL_3367: Unknown result type (might be due to invalid IL or missing references)
		//IL_336c: Expected Obj, but got Unknown
		//IL_3375: Expected Obj, but got I4
		//IL_337e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3383: Expected Obj, but got Unknown
		//IL_338c: Expected Obj, but got I4
		//IL_3395: Unknown result type (might be due to invalid IL or missing references)
		//IL_339a: Expected Obj, but got Unknown
		//IL_33a3: Expected Obj, but got I4
		//IL_33ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_33b1: Expected Obj, but got Unknown
		//IL_33ba: Expected Obj, but got I4
		//IL_33c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c8: Expected Obj, but got Unknown
		//IL_33d1: Expected Obj, but got I4
		//IL_33da: Unknown result type (might be due to invalid IL or missing references)
		//IL_33df: Expected Obj, but got Unknown
		//IL_33e8: Expected Obj, but got I4
		//IL_33f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f6: Expected Obj, but got Unknown
		//IL_33ff: Expected Obj, but got I4
		//IL_3408: Unknown result type (might be due to invalid IL or missing references)
		//IL_340d: Expected Obj, but got Unknown
		//IL_3416: Expected Obj, but got I4
		//IL_341f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3424: Expected Obj, but got Unknown
		//IL_342d: Expected Obj, but got I4
		//IL_3436: Unknown result type (might be due to invalid IL or missing references)
		//IL_343b: Expected Obj, but got Unknown
		//IL_3444: Expected Obj, but got I4
		//IL_344d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3452: Expected Obj, but got Unknown
		//IL_345b: Expected Obj, but got I4
		//IL_3464: Unknown result type (might be due to invalid IL or missing references)
		//IL_3469: Expected Obj, but got Unknown
		//IL_3472: Expected Obj, but got I4
		//IL_347b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3480: Expected Obj, but got Unknown
		//IL_3489: Expected Obj, but got I4
		//IL_3492: Unknown result type (might be due to invalid IL or missing references)
		//IL_3497: Expected Obj, but got Unknown
		//IL_34a0: Expected Obj, but got I4
		//IL_34a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ae: Expected Obj, but got Unknown
		//IL_34b7: Expected Obj, but got I4
		//IL_34c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_34c5: Expected Obj, but got Unknown
		//IL_34ce: Expected Obj, but got I4
		//IL_34d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_34dc: Expected Obj, but got Unknown
		//IL_34e5: Expected Obj, but got I4
		//IL_34ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f3: Expected Obj, but got Unknown
		//IL_34fc: Expected Obj, but got I4
		//IL_3505: Unknown result type (might be due to invalid IL or missing references)
		//IL_350a: Expected Obj, but got Unknown
		//IL_3513: Expected Obj, but got I4
		//IL_351c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3521: Expected Obj, but got Unknown
		//IL_352a: Expected Obj, but got I4
		//IL_3533: Unknown result type (might be due to invalid IL or missing references)
		//IL_3538: Expected Obj, but got Unknown
		//IL_3541: Expected Obj, but got I4
		//IL_354a: Unknown result type (might be due to invalid IL or missing references)
		//IL_354f: Expected Obj, but got Unknown
		//IL_3558: Expected Obj, but got I4
		//IL_3561: Unknown result type (might be due to invalid IL or missing references)
		//IL_3566: Expected Obj, but got Unknown
		//IL_356f: Expected Obj, but got I4
		//IL_3578: Unknown result type (might be due to invalid IL or missing references)
		//IL_357d: Expected Obj, but got Unknown
		//IL_3586: Expected Obj, but got I4
		//IL_358f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3594: Expected Obj, but got Unknown
		//IL_359d: Expected Obj, but got I4
		//IL_35b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_35b7: Expected Obj, but got Unknown
		//IL_35c0: Expected Obj, but got I4
		//IL_35c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ce: Expected Obj, but got Unknown
		//IL_35ea: Expected I, but got Obj
		//IL_3600: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_365c: Expected I, but got Obj
		//IL_3672: Expected Obj, but got I
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0170: Expected I, but got Obj
		//IL_369d: Expected I, but got Obj
		//IL_36b3: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_0218: Expected I, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_02bf: Expected I, but got Obj
		//IL_36de: Expected I, but got Obj
		//IL_36f4: Expected Obj, but got I
		//IL_0259: Expected I, but got Obj
		//IL_0367: Expected I, but got Obj
		//IL_037d: Expected Obj, but got I
		//IL_040e: Expected I, but got Obj
		//IL_371f: Expected I, but got Obj
		//IL_3735: Expected Obj, but got I
		//IL_03a8: Expected I, but got Obj
		//IL_04b6: Expected I, but got Obj
		//IL_04cc: Expected Obj, but got I
		//IL_055d: Expected I, but got Obj
		//IL_379d: Expected I, but got Obj
		//IL_37b3: Expected Obj, but got I
		//IL_04f7: Expected I, but got Obj
		//IL_0605: Expected I, but got Obj
		//IL_061b: Expected Obj, but got I
		//IL_070c: Expected I, but got Obj
		//IL_37ed: Expected I, but got Obj
		//IL_3803: Expected Obj, but got I
		//IL_0646: Expected I, but got Obj
		//IL_07c6: Expected I, but got Obj
		//IL_07dc: Expected Obj, but got I
		//IL_086d: Expected I, but got Obj
		//IL_384c: Expected I, but got Obj
		//IL_3862: Expected Obj, but got I
		//IL_0807: Expected I, but got Obj
		//IL_08fb: Expected I, but got Obj
		//IL_0911: Expected Obj, but got I
		//IL_0a81: Expected I, but got Obj
		//IL_38ab: Expected I, but got Obj
		//IL_38c1: Expected Obj, but got I
		//IL_093c: Expected I, but got Obj
		//IL_0b0f: Expected I, but got Obj
		//IL_0b25: Expected Obj, but got I
		//IL_0c95: Expected I, but got Obj
		//IL_09ca: Expected I, but got Obj
		//IL_09e0: Expected Obj, but got I
		//IL_390a: Expected I, but got Obj
		//IL_3920: Expected Obj, but got I
		//IL_0b50: Expected I, but got Obj
		//IL_0d23: Expected I, but got Obj
		//IL_0d39: Expected Obj, but got I
		//IL_0a0b: Expected I, but got Obj
		//IL_0ea9: Expected I, but got Obj
		//IL_0bde: Expected I, but got Obj
		//IL_0bf4: Expected Obj, but got I
		//IL_395a: Expected I, but got Obj
		//IL_3970: Expected Obj, but got I
		//IL_0d64: Expected I, but got Obj
		//IL_0f37: Expected I, but got Obj
		//IL_0f4d: Expected Obj, but got I
		//IL_0c1f: Expected I, but got Obj
		//IL_0fde: Expected I, but got Obj
		//IL_0df2: Expected I, but got Obj
		//IL_0e08: Expected Obj, but got I
		//IL_39aa: Expected I, but got Obj
		//IL_39c0: Expected Obj, but got I
		//IL_0f78: Expected I, but got Obj
		//IL_106c: Expected I, but got Obj
		//IL_1082: Expected Obj, but got I
		//IL_0e33: Expected I, but got Obj
		//IL_1113: Expected I, but got Obj
		//IL_39fa: Expected I, but got Obj
		//IL_3a10: Expected Obj, but got I
		//IL_10ad: Expected I, but got Obj
		//IL_11b3: Expected I, but got Obj
		//IL_11c9: Expected Obj, but got I
		//IL_125a: Expected I, but got Obj
		//IL_3abd: Expected I, but got Obj
		//IL_3ad3: Expected Obj, but got I
		//IL_11f4: Expected I, but got Obj
		//IL_12e8: Expected I, but got Obj
		//IL_12fe: Expected Obj, but got I
		//IL_1771: Expected I, but got Obj
		//IL_3b0d: Expected I, but got Obj
		//IL_3b23: Expected Obj, but got I
		//IL_1329: Expected I, but got Obj
		//IL_18f1: Expected I, but got Obj
		//IL_3b5d: Expected I, but got Obj
		//IL_3b73: Expected Obj, but got I
		//IL_1991: Expected I, but got Obj
		//IL_19a7: Expected Obj, but got I
		//IL_184a: Expected I, but got Obj
		//IL_1860: Expected Obj, but got I
		//IL_1a38: Expected I, but got Obj
		//IL_3bad: Expected I, but got Obj
		//IL_3bc3: Expected Obj, but got I
		//IL_19d2: Expected I, but got Obj
		//IL_188b: Expected I, but got Obj
		//IL_1ad8: Expected I, but got Obj
		//IL_1aee: Expected Obj, but got I
		//IL_1b7f: Expected I, but got Obj
		//IL_3bfd: Expected I, but got Obj
		//IL_3c13: Expected Obj, but got I
		//IL_1b19: Expected I, but got Obj
		//IL_1c0d: Expected I, but got Obj
		//IL_1c23: Expected Obj, but got I
		//IL_1cb4: Expected I, but got Obj
		//IL_3c8b: Expected I, but got Obj
		//IL_3ca1: Expected Obj, but got I
		//IL_1c4e: Expected I, but got Obj
		//IL_1de0: Expected I, but got Obj
		//IL_3cdb: Expected I, but got Obj
		//IL_3cf1: Expected Obj, but got I
		//IL_1e80: Expected I, but got Obj
		//IL_1e96: Expected Obj, but got I
		//IL_1f27: Expected I, but got Obj
		//IL_3d2b: Expected I, but got Obj
		//IL_3d41: Expected Obj, but got I
		//IL_1ec1: Expected I, but got Obj
		//IL_1fc7: Expected I, but got Obj
		//IL_1fdd: Expected Obj, but got I
		//IL_206e: Expected I, but got Obj
		//IL_3db8: Expected I, but got Obj
		//IL_3dce: Expected Obj, but got I
		//IL_2008: Expected I, but got Obj
		//IL_20fc: Expected I, but got Obj
		//IL_2112: Expected Obj, but got I
		//IL_2203: Expected I, but got Obj
		//IL_3e45: Expected I, but got Obj
		//IL_3e5b: Expected Obj, but got I
		//IL_213d: Expected I, but got Obj
		//IL_2291: Expected I, but got Obj
		//IL_22a7: Expected Obj, but got I
		//IL_2398: Expected I, but got Obj
		//IL_3ec3: Expected I, but got Obj
		//IL_3ed9: Expected Obj, but got I
		//IL_22d2: Expected I, but got Obj
		//IL_24a9: Expected I, but got Obj
		//IL_3f13: Expected I, but got Obj
		//IL_3f29: Expected Obj, but got I
		//IL_2537: Expected I, but got Obj
		//IL_254d: Expected Obj, but got I
		//IL_25de: Expected I, but got Obj
		//IL_3fdb: Expected I, but got Obj
		//IL_3ff1: Expected Obj, but got I
		//IL_2578: Expected I, but got Obj
		//IL_266c: Expected I, but got Obj
		//IL_2682: Expected Obj, but got I
		//IL_2773: Expected I, but got Obj
		//IL_40a3: Expected I, but got Obj
		//IL_40b9: Expected Obj, but got I
		//IL_26ad: Expected I, but got Obj
		//IL_2801: Expected I, but got Obj
		//IL_2817: Expected Obj, but got I
		//IL_2908: Expected I, but got Obj
		//IL_4131: Expected I, but got Obj
		//IL_4147: Expected Obj, but got I
		//IL_2842: Expected I, but got Obj
		//IL_2a34: Expected I, but got Obj
		//IL_4181: Expected I, but got Obj
		//IL_4197: Expected Obj, but got I
		//IL_2ac2: Expected I, but got Obj
		//IL_2ad8: Expected Obj, but got I
		//IL_2b69: Expected I, but got Obj
		//IL_41d1: Expected I, but got Obj
		//IL_41e7: Expected Obj, but got I
		//IL_2b03: Expected I, but got Obj
		//IL_2bf7: Expected I, but got Obj
		//IL_2c0d: Expected Obj, but got I
		//IL_2c9e: Expected I, but got Obj
		//IL_4221: Expected I, but got Obj
		//IL_4237: Expected Obj, but got I
		//IL_2c38: Expected I, but got Obj
		//IL_2d2c: Expected I, but got Obj
		//IL_2d42: Expected Obj, but got I
		//IL_2dd3: Expected I, but got Obj
		//IL_4271: Expected I, but got Obj
		//IL_4287: Expected Obj, but got I
		//IL_2d6d: Expected I, but got Obj
		//IL_2e61: Expected I, but got Obj
		//IL_2e77: Expected Obj, but got I
		//IL_2f08: Expected I, but got Obj
		//IL_2faf: Expected I, but got Obj
		//IL_2fc5: Expected Obj, but got I
		//IL_2ea2: Expected I, but got Obj
		//IL_2f9c: Expected Obj, but got I4
		//IL_2ff0: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 304;
		object obj3 = obj2 + 152;
		object obj4 = obj2 + 112;
		object obj5 = obj2 + 104;
		object obj6 = obj2 + 88;
		object obj7 = obj2 + 80;
		object obj8 = obj2 - -64;
		object obj9 = obj2 + 40;
		object obj10 = obj2 + 32;
		object obj11 = obj2 + 24;
		object obj12 = obj2 + 8;
		object obj13 = obj2 + 288;
		obj13 = 0;
		object obj14 = obj2 + 284;
		obj14 = 0;
		object obj15 = obj2 + 280;
		obj15 = 0;
		object obj16 = obj2 + 276;
		obj16 = 0;
		object obj17 = obj2 + 272;
		obj17 = 0;
		object obj18 = obj2 + 297;
		obj18 = 0;
		object obj19 = obj2 + 268;
		obj19 = 0;
		object obj20 = obj2 + 264;
		obj20 = 0;
		object obj21 = obj2 + 260;
		obj21 = 0;
		object obj22 = obj2 + 256;
		obj22 = 0;
		object obj23 = obj2 + 252;
		obj23 = 0;
		object obj24 = obj2 + 296;
		obj24 = 0;
		object obj25 = obj2 + 248;
		obj25 = 0;
		object obj26 = obj2 + 244;
		obj26 = 0;
		object obj27 = obj2 + 295;
		obj27 = 0;
		object obj28 = obj2 + 294;
		obj28 = 0;
		object obj29 = obj2 + 240;
		obj29 = 0;
		object obj30 = obj2 + 144;
		obj30 = 0;
		object obj31 = obj2 + 293;
		obj31 = 0;
		object obj32 = obj2 + 292;
		obj32 = 0;
		object obj33 = obj2 + 236;
		obj33 = 0;
		object obj34 = obj2 + 232;
		obj34 = 0;
		object obj35 = obj2 + 228;
		obj35 = 0;
		object obj36 = obj2 + 224;
		obj36 = 0;
		object obj37 = obj2 + 136;
		obj37 = 0;
		object obj38 = obj2 + 128;
		obj38 = 0;
		object obj39 = obj2 + 120;
		obj39 = 0;
		object obj40 = obj2 + 220;
		obj40 = 0;
		object obj41 = obj2 + 216;
		obj41 = 0;
		object obj42 = obj2 + 212;
		obj42 = 0;
		object obj43 = obj2 + 208;
		obj43 = 0;
		object obj44 = obj2 + 96;
		obj44 = 0;
		object obj45 = obj2 + 72;
		obj45 = 0;
		object obj46 = obj2 + 56;
		obj46 = 0;
		object obj47 = obj2 + 48;
		obj47 = 0;
		object obj48 = obj2 + 184;
		obj48 = 0;
		_ = 0;
		_ = 0;
		object obj49 = obj2 + 16;
		obj49 = 0;
		object obj50 = obj2 + 176;
		obj50 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v111 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj51 = (nint)0 & (nint)0x200;
		if (obj51 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v2125 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj52 = default;
		if (obj52 != null)
		{
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v2047 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj53 = (nint)0 & (nint)0x200;
			if (obj53 != null)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ S0_v2061 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num5 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v123 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj54 = (nint)0 & (nint)0x200;
		if (obj54 != null)
		{
			nint num6 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1272 @ S0_v2034 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj55 = default;
		if (obj55 != null)
		{
			nint num7 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1360 @ S0_v2010 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj56 = (nint)0 & (nint)0x200;
			if (obj56 != null)
			{
				nint num8 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ S0_v2024 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num9 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ S0_v135 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj57 = (nint)0 & (nint)0x200;
		if (obj57 != null)
		{
			nint num10 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1442 @ S0_v1997 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj58 = default;
		if (obj58 != null)
		{
			nint num11 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1523 @ S0_v1973 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj59 = (nint)0 & (nint)0x200;
			if (obj59 != null)
			{
				nint num12 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1563 @ S0_v1987 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num13 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ S0_v147 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj60 = (nint)0 & (nint)0x200;
		if (obj60 != null)
		{
			nint num14 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1575 @ S0_v1960 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj61 = default;
		if (obj61 != null)
		{
			nint num15 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1631 @ S0_v1936 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj62 = (nint)0 & (nint)0x200;
			if (obj62 != null)
			{
				nint num16 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1653 @ S0_v1950 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		nint num17 = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ S0_v159 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj63 = (nint)0 & (nint)0x200;
		if (obj63 != null)
		{
			nint num18 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ S0_v1923 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj64 = default;
		object obj66;
		object obj67 = default;
		object obj68;
		if (obj64 != null)
		{
			nint num19 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1712 @ S0_v1878 (Il2CppClass<Globals>)+BA]");
			object obj65 = (nint)0 & (nint)0x200;
			if (obj65 != null)
			{
				nint num20 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1737 @ S0_v1910 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj66 = obj67;
			object obj69 = default;
			obj68 = obj69;
		}
		else
		{
			nint num21 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1731 @ S0_v171 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj70 = (nint)0 & (nint)0x200;
			if (obj70 != null)
			{
				nint num22 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1749 @ S0_v1864 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj71 = default;
			if (obj71 != null)
			{
				bool flag = obj18 != null;
				nint num23 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1823 @ S0_v1840 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj72 = (nint)0 & (nint)0x200;
				if (obj72 != null)
				{
					nint num24 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1851 @ S0_v1854 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num25 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ S0_v183 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj73 = (nint)0 & (nint)0x200;
			if (obj73 != null)
			{
				nint num26 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1863 @ S0_v1826 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj74 = default;
			if (obj74 != null)
			{
				nint num27 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1910 @ S0_v1779 (Il2CppClass<System.DateTime>)+BA]");
				object obj75 = (nint)0 & (nint)0x200;
				if (obj75 != null)
				{
					nint num28 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1934 @ S0_v1813 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj76 = default;
				if (obj76 != null)
				{
					nint num29 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1987 @ S0_v1790 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj77 = (nint)0 & (nint)0x200;
					if (obj77 != null)
					{
						nint num30 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2022 @ S0_v1806 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					obj4 = obj45;
					obj3 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
			}
			nint num31 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1929 @ S0_v195 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj78 = (nint)0 & (nint)0x200;
			if (obj78 != null)
			{
				nint num32 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1945 @ S0_v1766 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj79 = default;
			if (obj79 != null)
			{
				nint num33 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1998 @ S0_v1719 (Il2CppClass<System.DateTime>)+BA]");
				object obj80 = (nint)0 & (nint)0x200;
				if (obj80 != null)
				{
					nint num34 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2039 @ S0_v1753 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj81 = default;
				if (obj81 != null)
				{
					nint num35 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2105 @ S0_v1730 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj82 = (nint)0 & (nint)0x200;
					if (obj82 != null)
					{
						nint num36 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2140 @ S0_v1746 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					obj5 = obj46;
					obj3 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
			}
			nint num37 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2017 @ S0_v207 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj83 = (nint)0 & (nint)0x200;
			if (obj83 != null)
			{
				nint num38 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2050 @ S0_v1706 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj84 = default;
			if (obj84 != null)
			{
				nint num39 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2116 @ S0_v1659 (Il2CppClass<System.DateTime>)+BA]");
				object obj85 = (nint)0 & (nint)0x200;
				if (obj85 != null)
				{
					nint num40 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2157 @ S0_v1693 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj86 = default;
				if (obj86 != null)
				{
					nint num41 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2225 @ S0_v1670 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj87 = (nint)0 & (nint)0x200;
					if (obj87 != null)
					{
						nint num42 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2257 @ S0_v1686 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					obj6 = obj47;
					obj3 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
			}
			nint num43 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2135 @ S0_v219 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj88 = (nint)0 & (nint)0x200;
			if (obj88 != null)
			{
				nint num44 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2168 @ S0_v1646 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj89 = default;
			if (obj89 != null)
			{
				nint num45 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2236 @ S0_v1622 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj90 = (nint)0 & (nint)0x200;
				if (obj90 != null)
				{
					nint num46 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2274 @ S0_v1636 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num47 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2252 @ S0_v233 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj91 = (nint)0 & (nint)0x200;
			if (obj91 != null)
			{
				nint num48 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2286 @ S0_v1609 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj92 = default;
			if (obj92 != null)
			{
				nint num49 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2343 @ S0_v1585 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj93 = (nint)0 & (nint)0x200;
				if (obj93 != null)
				{
					nint num50 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2364 @ S0_v1599 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num51 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2359 @ S0_v245 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj94 = (nint)0 & (nint)0x200;
			if (obj94 != null)
			{
				nint num52 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2376 @ S0_v1572 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj95 = default;
			if (obj95 != null)
			{
				bool flag2 = obj24 != null;
				nint num53 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2422 @ S0_v1548 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj96 = (nint)0 & (nint)0x200;
				if (obj96 != null)
				{
					nint num54 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2443 @ S0_v1562 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			nint num55 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2438 @ S0_v257 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
			object obj97 = (nint)0 & (nint)0x200;
			if (obj97 != null)
			{
				nint num56 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2455 @ S0_v1534 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj98 = default;
			if (obj98 != null)
			{
				nint num57 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2500 @ S0_v1332 (Il2CppClass<Globals>)+BA]");
				object obj99 = (nint)0 & (nint)0x200;
				if (obj99 != null)
				{
					nint num58 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2523 @ S0_v1521 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				obj66 = obj67;
				object obj100 = default;
				obj68 = obj100;
			}
			else
			{
				nint num59 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2518 @ S0_v269 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj101 = (nint)0 & (nint)0x200;
				if (obj101 != null)
				{
					nint num60 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2537 @ S0_v1319 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj102 = default;
				if (obj102 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj103 = default;
					if (obj103 != null)
					{
						nint num61 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2678 @ S0_v1292 (Il2CppClass<Data.Save.UserSave>)+BA]");
						object obj104 = (nint)0 & (nint)0x200;
						if (obj104 != null)
						{
							nint num62 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2691 @ S0_v1306 (Il2CppClass<Data.Save.UserSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					}
				}
				nint num63 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2613 @ S0_v281 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj105 = (nint)0 & (nint)0x200;
				if (obj105 != null)
				{
					nint num64 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2631 @ S0_v1272 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj106 = default;
				if (obj106 != null)
				{
					bool flag3 = obj27 != null;
					nint num65 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2711 @ S0_v1248 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj107 = (nint)0 & (nint)0x200;
					if (obj107 != null)
					{
						nint num66 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2746 @ S0_v1262 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				nint num67 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2727 @ S0_v293 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj108 = (nint)0 & (nint)0x200;
				if (obj108 != null)
				{
					nint num68 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2758 @ S0_v1234 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj109 = default;
				if (obj109 != null)
				{
					bool flag4 = obj28 != null;
					nint num69 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2853 @ S0_v1210 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj110 = (nint)0 & (nint)0x200;
					if (obj110 != null)
					{
						nint num70 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2879 @ S0_v1224 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				nint num71 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2869 @ S0_v305 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj111 = (nint)0 & (nint)0x200;
				if (obj111 != null)
				{
					nint num72 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2891 @ S0_v1196 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj112 = default;
				if (obj112 != null)
				{
					nint num73 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3001 @ S0_v1172 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj113 = (nint)0 & (nint)0x200;
					if (obj113 != null)
					{
						nint num74 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3059 @ S0_v1186 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				nint num75 = (nint)typeof(PlayerInfoMigrator);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3017 @ S0_v317 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
				object obj114 = (nint)0 & (nint)0x200;
				if (obj114 != null)
				{
					nint num76 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3071 @ S0_v1159 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj115 = default;
				if (obj115 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
					object obj116 = obj67 << 32;
					object obj118 = default;
					object obj117 = obj118 | obj116;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					obj66 = obj67;
					object obj119 = default;
					obj68 = obj119;
				}
				else
				{
					nint num77 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3196 @ S0_v329 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
					object obj120 = (nint)0 & (nint)0x200;
					if (obj120 != null)
					{
						nint num78 = (nint)typeof(PlayerInfoMigrator);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3242 @ S0_v1115 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					object obj121 = default;
					if (obj121 != null)
					{
						bool flag5 = obj31 != null;
						nint num79 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3331 @ S0_v1091 (Il2CppClass<Data.Save.UserSave>)+BA]");
						object obj122 = (nint)0 & (nint)0x200;
						if (obj122 != null)
						{
							nint num80 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3360 @ S0_v1105 (Il2CppClass<Data.Save.UserSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					}
					nint num81 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3347 @ S0_v341 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
					object obj123 = (nint)0 & (nint)0x200;
					if (obj123 != null)
					{
						nint num82 = (nint)typeof(PlayerInfoMigrator);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3372 @ S0_v1077 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					object obj124 = default;
					if (obj124 != null)
					{
						bool flag6 = obj32 != null;
						nint num83 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3421 @ S0_v1053 (Il2CppClass<Data.Save.UserSave>)+BA]");
						object obj125 = (nint)0 & (nint)0x200;
						if (obj125 != null)
						{
							nint num84 = (nint)typeof(UserSave);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3442 @ S0_v1067 (Il2CppClass<Data.Save.UserSave>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					}
					nint num85 = (nint)typeof(PlayerInfoMigrator);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3437 @ S0_v353 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
					object obj126 = (nint)0 & (nint)0x200;
					if (obj126 != null)
					{
						nint num86 = (nint)typeof(PlayerInfoMigrator);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3454 @ S0_v1039 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					object obj127 = default;
					if (obj127 != null)
					{
						nint num87 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3499 @ S0_v992 (Il2CppClass<Globals>)+BA]");
						object obj128 = (nint)0 & (nint)0x200;
						if (obj128 != null)
						{
							nint num88 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3523 @ S0_v1026 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj66 = obj67;
						object obj129 = default;
						obj68 = obj129;
					}
					else
					{
						nint num89 = (nint)typeof(PlayerInfoMigrator);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3518 @ S0_v365 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
						object obj130 = (nint)0 & (nint)0x200;
						if (obj130 != null)
						{
							nint num90 = (nint)typeof(PlayerInfoMigrator);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3538 @ S0_v979 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
						object obj131 = default;
						if (obj131 != null)
						{
							nint num91 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3609 @ S0_v932 (Il2CppClass<Globals>)+BA]");
							object obj132 = (nint)0 & (nint)0x200;
							if (obj132 != null)
							{
								nint num92 = (nint)typeof(Globals);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3640 @ S0_v966 (Il2CppClass<Globals>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							obj66 = obj67;
							object obj133 = default;
							obj68 = obj133;
						}
						else
						{
							nint num93 = (nint)typeof(PlayerInfoMigrator);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3628 @ S0_v377 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
							object obj134 = (nint)0 & (nint)0x200;
							if (obj134 != null)
							{
								nint num94 = (nint)typeof(PlayerInfoMigrator);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3655 @ S0_v919 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
							object obj135 = default;
							if (obj135 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj66 = obj67;
								object obj136 = default;
								obj68 = obj136;
							}
							else
							{
								nint num95 = (nint)typeof(PlayerInfoMigrator);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3747 @ S0_v389 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
								object obj137 = (nint)0 & (nint)0x200;
								if (obj137 != null)
								{
									nint num96 = (nint)typeof(PlayerInfoMigrator);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3768 @ S0_v876 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
								object obj138 = default;
								if (obj138 != null)
								{
									nint num97 = (nint)typeof(UserSave);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3829 @ S0_v852 (Il2CppClass<Data.Save.UserSave>)+BA]");
									object obj139 = (nint)0 & (nint)0x200;
									if (obj139 != null)
									{
										nint num98 = (nint)typeof(UserSave);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3852 @ S0_v866 (Il2CppClass<Data.Save.UserSave>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
								}
								nint num99 = (nint)typeof(PlayerInfoMigrator);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3845 @ S0_v401 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
								object obj140 = (nint)0 & (nint)0x200;
								if (obj140 != null)
								{
									nint num100 = (nint)typeof(PlayerInfoMigrator);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3864 @ S0_v839 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
								object obj141 = default;
								if (obj141 != null)
								{
									nint num101 = (nint)typeof(DateTime);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3908 @ S0_v789 (Il2CppClass<System.DateTime>)+BA]");
									object obj142 = (nint)0 & (nint)0x200;
									if (obj142 != null)
									{
										nint num102 = (nint)typeof(DateTime);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3930 @ S0_v826 (Il2CppClass<System.DateTime>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
										}
									}
									obj8 = obj37;
									obj3 = obj8;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
									object obj143 = obj67 << 32;
									object obj145 = default;
									object obj144 = obj145 | obj143;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									obj66 = obj67;
									object obj146 = default;
									obj68 = obj146;
								}
								else
								{
									nint num103 = (nint)typeof(PlayerInfoMigrator);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3925 @ S0_v413 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
									object obj147 = (nint)0 & (nint)0x200;
									if (obj147 != null)
									{
										nint num104 = (nint)typeof(PlayerInfoMigrator);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3947 @ S0_v776 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
									object obj148 = default;
									if (obj148 != null)
									{
										nint num105 = (nint)typeof(DateTime);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4026 @ S0_v726 (Il2CppClass<System.DateTime>)+BA]");
										object obj149 = (nint)0 & (nint)0x200;
										if (obj149 != null)
										{
											nint num106 = (nint)typeof(DateTime);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4055 @ S0_v763 (Il2CppClass<System.DateTime>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
											}
										}
										obj10 = obj38;
										obj3 = obj10;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
										object obj150 = obj67 << 32;
										object obj152 = default;
										object obj151 = obj152 | obj150;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										obj66 = obj67;
										object obj153 = default;
										obj68 = obj153;
									}
									else
									{
										nint num107 = (nint)typeof(PlayerInfoMigrator);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4043 @ S0_v425 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
										object obj154 = (nint)0 & (nint)0x200;
										if (obj154 != null)
										{
											nint num108 = (nint)typeof(PlayerInfoMigrator);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4072 @ S0_v713 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
										object obj155 = default;
										if (obj155 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
											object obj156 = obj67 << 32;
											object obj158 = default;
											object obj157 = obj158 | obj156;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											obj66 = obj67;
											object obj159 = default;
											obj68 = obj159;
										}
										else
										{
											nint num109 = (nint)typeof(PlayerInfoMigrator);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4168 @ S0_v437 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
											object obj160 = (nint)0 & (nint)0x200;
											if (obj160 != null)
											{
												nint num110 = (nint)typeof(PlayerInfoMigrator);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4193 @ S0_v669 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
											object obj161 = default;
											if (obj161 != null)
											{
												nint num111 = (nint)typeof(UserSave);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4259 @ S0_v645 (Il2CppClass<Data.Save.UserSave>)+BA]");
												object obj162 = (nint)0 & (nint)0x200;
												if (obj162 != null)
												{
													nint num112 = (nint)typeof(UserSave);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4282 @ S0_v659 (Il2CppClass<Data.Save.UserSave>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
											}
											nint num113 = (nint)typeof(PlayerInfoMigrator);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4275 @ S0_v449 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
											object obj163 = (nint)0 & (nint)0x200;
											if (obj163 != null)
											{
												nint num114 = (nint)typeof(PlayerInfoMigrator);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4294 @ S0_v632 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
											object obj164 = default;
											if (obj164 != null)
											{
												nint num115 = (nint)typeof(UserSave);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4338 @ S0_v608 (Il2CppClass<Data.Save.UserSave>)+BA]");
												object obj165 = (nint)0 & (nint)0x200;
												if (obj165 != null)
												{
													nint num116 = (nint)typeof(UserSave);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4359 @ S0_v622 (Il2CppClass<Data.Save.UserSave>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
											}
											nint num117 = (nint)typeof(PlayerInfoMigrator);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4354 @ S0_v461 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
											object obj166 = (nint)0 & (nint)0x200;
											if (obj166 != null)
											{
												nint num118 = (nint)typeof(PlayerInfoMigrator);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4371 @ S0_v595 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
											object obj167 = default;
											if (obj167 != null)
											{
												nint num119 = (nint)typeof(UserSave);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4415 @ S0_v571 (Il2CppClass<Data.Save.UserSave>)+BA]");
												object obj168 = (nint)0 & (nint)0x200;
												if (obj168 != null)
												{
													nint num120 = (nint)typeof(UserSave);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4436 @ S0_v585 (Il2CppClass<Data.Save.UserSave>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
											}
											nint num121 = (nint)typeof(PlayerInfoMigrator);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4431 @ S0_v473 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
											object obj169 = (nint)0 & (nint)0x200;
											if (obj169 != null)
											{
												nint num122 = (nint)typeof(PlayerInfoMigrator);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4448 @ S0_v558 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
											object obj170 = default;
											if (obj170 != null)
											{
												nint num123 = (nint)typeof(UserSave);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4492 @ S0_v534 (Il2CppClass<Data.Save.UserSave>)+BA]");
												object obj171 = (nint)0 & (nint)0x200;
												if (obj171 != null)
												{
													nint num124 = (nint)typeof(UserSave);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4511 @ S0_v548 (Il2CppClass<Data.Save.UserSave>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
											}
											nint num125 = (nint)typeof(PlayerInfoMigrator);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4507 @ S0_v485 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
											object obj172 = (nint)0 & (nint)0x200;
											if (obj172 != null)
											{
												nint num126 = (nint)typeof(PlayerInfoMigrator);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4523 @ S0_v521 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
											object obj173 = default;
											if (obj173 == null)
											{
												return (CharacterNameEventData)1;
											}
											nint num127 = (nint)typeof(UserSave);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4564 @ S0_v496 (Il2CppClass<Data.Save.UserSave>)+BA]");
											object obj174 = (nint)0 & (nint)0x200;
											if (obj174 != null)
											{
												nint num128 = (nint)typeof(UserSave);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4569 @ S0_v513 (Il2CppClass<Data.Save.UserSave>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
												}
											}
											obj2 = obj44;
											obj3 = obj2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											obj66 = obj67;
											object obj175 = default;
											obj68 = obj175;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj176 = default;
		if (obj66 == obj176)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj178 = default;
			object obj177 = obj178;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj180 = default;
			object obj179 = obj180;
		}
		else
		{
			object obj179 = obj68;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		CharacterNameEventData result = default;
		return result;
	}

	private unsafe static Dictionary<UpgradeType, int> ConvertLegacyPowerupsToUpgrades(Dictionary<PowerupTypeLegacy, int> legacyPowerups)
	{
		//IL_0b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Expected I, but got Unknown
		//IL_002e: Invalid comparison between VT and I4
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efe: Expected Obj, but got Unknown
		//IL_0248: Expected I, but got Obj
		//IL_025e: Expected Obj, but got I
		//IL_0289: Expected I, but got Obj
		//IL_05cd: Expected I, but got Obj
		//IL_05e3: Expected Obj, but got I
		//IL_0386: Expected Obj, but got I4
		//IL_0c95: Expected I, but got Obj
		//IL_0cab: Expected Obj, but got I
		//IL_0ce3: Expected I, but got Obj
		//IL_0d15: Expected I, but got Obj
		//IL_0d2b: Expected Obj, but got I
		//IL_060e: Expected I, but got Obj
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0782: Expected I, but got Obj
		//IL_0798: Expected Obj, but got I
		//IL_065b: Expected I, but got Obj
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_0b63: Expected I4, but got Obj
		//IL_0841: Expected I, but got Obj
		//IL_0857: Expected Obj, but got I
		//IL_06a8: Expected I, but got Obj
		//IL_03c2: Expected I, but got Obj
		//IL_03d8: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0900: Expected I, but got Obj
		//IL_0916: Expected Obj, but got I
		//IL_07c3: Expected I, but got Obj
		//IL_09bf: Expected I, but got Obj
		//IL_09d5: Expected Obj, but got I
		//IL_0e65: Expected I8, but got I4
		//IL_0882: Expected I, but got Obj
		//IL_0403: Expected I, but got Obj
		//IL_0a7e: Expected I, but got Obj
		//IL_0a94: Expected Obj, but got I
		//IL_0941: Expected I, but got Obj
		//IL_0482: Expected Obj, but got I
		//IL_0498: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I
		//IL_04b8: Expected Obj, but got I
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_04f1: Expected Obj, but got I4
		//IL_0a00: Expected I, but got Obj
		//IL_0abf: Expected I, but got Obj
		//IL_0523: Expected Obj, but got I4
		object obj = default;
		nint num = (nint)(obj + 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ExpiredLimitedBoardEventManager expiredLimitedBoardEventManager = default;
		expiredLimitedBoardEventManager.SaveProgress();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		_0021_00210 val = (_0021_00210)((KilooSerializer)(object)text).FromBson<T>((byte[])(object)legacyPowerups);
		if (val != (_0021_00210)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj3 = default;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
					List<object> list = default;
					if (list != null && list._size >= 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						List<Characters.CharacterId> list2 = default;
						list2._002Ector();
						int num2 = 0;
						while (num2 < list._size)
						{
							object obj4 = list.get_Item(num2);
							nint num3 = (nint)typeof(Convert);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v214 (Il2CppClass<System.Convert>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num4 = (nint)typeof(Convert);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v221 (Il2CppClass<System.Convert>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int item = Convert.ToInt32((byte)(int)obj4 != 0);
							list2.Add((Characters.CharacterId)item);
							int num5 = num2 + 1;
							num2 = num5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v197 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
						if ((nint)0 >= (nint)1)
						{
							object obj6 = expiredLimitedBoardEventManager + 28;
							obj6 = list2;
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj7 = default;
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj8 = default;
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					nint num6 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v176 (Il2CppClass<System.Convert>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num7 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v181 (Il2CppClass<System.Convert>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool value = default;
					int eventType = Convert.ToInt32(value);
					expiredLimitedBoardEventManager._eventType = (SSEventType)eventType;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list3 = default;
			list3._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj10 = default;
			bool flag;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj11 = default;
				if (obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
					List<object> list4 = default;
					if (list4 != null)
					{
						if (list4._size < 1)
						{
							flag = false;
						}
						else
						{
							object obj12 = 0;
							int num8 = 0;
							string text2 = default;
							object obj22 = default;
							while (num8 < list4._size)
							{
								object obj13 = list4.get_Item(num8);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
								nint num9 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v147 (Il2CppClass<Strings>)+BA]");
								object obj14 = (nint)0 & (nint)0x200;
								if (obj14 != null)
								{
									nint num10 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S0_v166 (Il2CppClass<Strings>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Dictionary<string, string> dictionary = Strings.DeserializeObject(text2);
								if (dictionary != null)
								{
									list3.Add(text2);
								}
								else
								{
									SDebug.LogFormat("Invalid CharacterNameEvent progress StringID, using character name instead", null);
									list3.Add("");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (ExpiredLimitedBoardEventManager)+1C]");
									object obj15 = 0;
									nint num11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S4_v18 (Il2CppMethodInfo)+C]");
									object obj16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ S4_v19+60]");
									object obj17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S4_v20+8C]");
									object obj18 = 0;
									object obj19 = obj18 & 0x7FF;
									object obj20 = obj19 + 39195;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v404 @ S5_v7 (should have been resolved before IL gen)");
									object obj21 = list3._size - 1;
									if (obj22 == obj21)
									{
										obj12 = 1;
									}
								}
								int num12 = num8 + 1;
								num8 = num12;
							}
							object obj23 = obj12 & 1;
							flag = obj23 != null;
						}
					}
					else
					{
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
			else
			{
				flag = false;
			}
			object obj24 = expiredLimitedBoardEventManager + 32;
			List<string> list5 = ((list3._size <= 0) ? null : list3);
			obj24 = list5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj25 = default;
			if (obj25 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj26 = default;
				if (obj26 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					nint num13 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S2_v53 (Il2CppClass<System.Convert>)+BA]");
					object obj27 = (nint)0 & (nint)0x200;
					if (obj27 != null)
					{
						nint num14 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S2_v67 (Il2CppClass<System.Convert>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool value2 = default;
					int num15 = Convert.ToInt32(value2);
					nint num16 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S1_v87 (Il2CppClass<System.Type>)+BA]");
					object obj28 = (nint)0 & (nint)0x200;
					if (obj28 != null)
					{
						nint num17 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S1_v99 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj = typeof(SSEventCategory);
					((IntPtr*)num)->m_value = (void*)(nint)obj;
					Type type = Type.internal_from_handle((IntPtr)num);
					((IntPtr*)num)->m_value = (void*)num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					nint num18 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ S3_v55 (Il2CppClass<System.Enum>)+BA]");
					object obj29 = (nint)0 & (nint)0x200;
					if (obj29 != null)
					{
						nint num19 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S3_v60 (Il2CppClass<System.Enum>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Enum flags = default;
					bool flag2 = ((Enum)(object)type).InternalHasFlag(flags);
					bool flag3 = !flag2;
					bool flag4 = !flag3;
					int num20 = num15;
					if (!flag4)
					{
						num20 = 0;
					}
				}
				else
				{
					int num20 = 0;
				}
			}
			else
			{
				int num20 = 0;
			}
			if (flag)
			{
				_ = -1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj30 = default;
				if (obj30 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					object obj31 = default;
					if (obj31 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
						nint num21 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S0_v108 (Il2CppClass<System.Convert>)+BA]");
						object obj32 = (nint)0 & (nint)0x200;
						if (obj32 != null)
						{
							nint num22 = (nint)typeof(Convert);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S0_v113 (Il2CppClass<System.Convert>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool value3 = default;
						int num23 = Convert.ToInt32(value3);
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj33 = default;
			if (obj33 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj34 = default;
				if (obj34 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					nint num24 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ S0_v92 (Il2CppClass<System.Convert>)+BA]");
					object obj35 = (nint)0 & (nint)0x200;
					if (obj35 != null)
					{
						nint num25 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ S0_v97 (Il2CppClass<System.Convert>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool value4 = default;
					int num26 = Convert.ToInt32(value4);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj36 = default;
			if (obj36 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj37 = default;
				if (obj37 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					nint num27 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ S0_v78 (Il2CppClass<System.Convert>)+BA]");
					object obj38 = (nint)0 & (nint)0x200;
					if (obj38 != null)
					{
						nint num28 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S0_v83 (Il2CppClass<System.Convert>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool value5 = default;
					int num29 = Convert.ToInt32(value5);
					expiredLimitedBoardEventManager._eventID = num29;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj39 = default;
			if (obj39 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj40 = default;
				if (obj40 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					nint num30 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ S0_v64 (Il2CppClass<System.Convert>)+BA]");
					object obj41 = (nint)0 & (nint)0x200;
					if (obj41 != null)
					{
						nint num31 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S0_v69 (Il2CppClass<System.Convert>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					sbyte value6 = default;
					bool flag5 = Convert.ToBoolean(value6);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj42 = default;
			if (obj42 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj43 = default;
				if (obj43 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					nint num32 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ S0_v50 (Il2CppClass<System.Convert>)+BA]");
					object obj44 = (nint)0 & (nint)0x200;
					if (obj44 != null)
					{
						nint num33 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S0_v55 (Il2CppClass<System.Convert>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool value7 = default;
					long num34 = Convert.ToInt64(value7);
				}
			}
		}
		return (Dictionary<UpgradeType, int>)(object)expiredLimitedBoardEventManager;
	}

	static PlayerInfoMigrator()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0454: Expected I, but got Obj
		//IL_046a: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_01d0: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got I
		//IL_049f: Expected I, but got Obj
		//IL_04b5: Expected Obj, but got I
		//IL_0211: Expected I, but got Obj
		//IL_0244: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v116 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		object obj5 = default;
		object obj6 = default;
		object obj4 = obj5 & obj6;
		object obj8 = default;
		object obj7 = obj4 & obj8;
		object obj10 = default;
		object obj9 = obj7 & obj10;
		object obj12 = default;
		object obj11 = obj9 & obj12;
		object obj14 = default;
		object obj13 = obj11 & obj14;
		object obj16 = default;
		object obj15 = obj13 & obj16;
		object obj18 = default;
		object obj17 = obj15 & obj18;
		object obj20 = default;
		object obj19 = obj17 & obj20;
		object obj22 = default;
		object obj21 = obj19 & obj22;
		object obj24 = default;
		object obj23 = obj21 & obj24;
		if (obj23 == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S0_v44 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S0_v58 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UserSave.migratedPlayerPrefsVersion = 1;
		nint num5 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S0_v50 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num6 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v55 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
	}
}
