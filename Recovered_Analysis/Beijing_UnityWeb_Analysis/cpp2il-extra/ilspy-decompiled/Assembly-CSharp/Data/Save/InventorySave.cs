using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Managers;
using Data.Migration;
using Data.Save.Internal;
using Events;
using InApp;
using Info;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace Data.Save;

public class InventorySave : DataManager<InventorySave>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<CelebrationReward> _003C_003E9__54_1;

		public static Predicate<CelebrationReward> _003C_003E9__54_2;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InAppManager._003C_003Ec obj = default;
			InAppManager._003C_003Ec._003C_003E9 = obj;
		}

		internal bool _003CRemovePendingReward_003Eb__54_1(CelebrationReward reward)
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Data.Save.InventorySave+<>c)+8]");
			object obj = 0;
			long uid = reward.Uid;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+30]");
			return uid == 0;
		}

		internal bool _003CRemovePendingReward_003Eb__54_2(CelebrationReward reward)
		{
			return reward.CelebrationRewardOrigin == CelebrationRewardOrigin.MysteryBox;
		}
	}

	private static Action m_coinsChanged;

	private static Action m_keysChanged;

	private static Action<UpgradeType, int> m_powerupsChanged;

	private static CelebrationReward lastAddedReward__BackingField;

	public static int keys
	{
		get
		{
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+FC]");
			return ((nint)0 != 0) ? 1 : 0;
		}
		private set
		{
			unrewardedCoins = value;
		}
	}

	public static int coins
	{
		get
		{
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00b1: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			LocalDebugData localDebugData = DataManager<>.localDebug;
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v8 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+C]");
			return (int)Utils.GetIntBinaryString(0);
		}
		private set
		{
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			LocalDebugData localDebugData = DataManager<>.localDebug;
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string intBinaryString = Utils.GetIntBinaryString(value);
			TransformExtensions.Reset((Transform)(object)InventorySave.m_keysChanged);
		}
	}

	public static int unrewardedCoins
	{
		get
		{
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00ae: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			LocalDebugData localDebugData = DataManager<>.localDebug;
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v8 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (int)Utils.GetIntBinaryString(localDebugData.overridePerformanceLevel);
		}
		set
		{
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00b6: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			LocalDebugData localDebugData = DataManager<>.localDebug;
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string intBinaryString = Utils.GetIntBinaryString(value);
			localDebugData.overridePerformanceLevel = (int)intBinaryString;
			TransformExtensions.Reset((Transform)(object)InventorySave.m_coinsChanged);
		}
	}

	public static List<CelebrationReward> pendingRewards
	{
		get
		{
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			LocalDebugData localDebugData = DataManager<>.localDebug;
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v8 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+10]");
			return (List<CelebrationReward>)(object)Utils.GetIntBinaryString(0);
		}
	}

	public static Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+1C]");
			return (Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)0;
		}
	}

	public static CelebrationReward lastAddedReward
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+20]");
			return (CelebrationReward)0;
		}
		private set
		{
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00a5: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			LocalDebugData localDebugData = DataManager<>.localDebug;
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v9 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string intBinaryString = Utils.GetIntBinaryString((int)value);
		}
	}

	public static Dictionary<Characters.CharacterId, int> selectedOutfits => (Dictionary<Characters.CharacterId, int>)(object)lastAddedReward__BackingField;

	public static Dictionary<Characters.CharacterId, List<int>> unlockedOutfits
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+2C]");
			return (Dictionary<Characters.CharacterId, List<int>>)0;
		}
	}

	public static List<Characters.CharacterId> unlockedCharacters
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+30]");
			return (List<Characters.CharacterId>)0;
		}
	}

	public static Dictionary<Characters.CharacterId, int> collectedCharacterTokens
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+24]");
			return (Dictionary<Characters.CharacterId, int>)0;
		}
	}

	public static List<Boards.BoardId> unlockedBoards
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+28]");
			return (List<Boards.BoardId>)0;
		}
	}

	public static Dictionary<UpgradeType, int> upgrades
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			LocalDebugData localDebugData = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Data.Save.Internal.LocalDebugData)+34]");
			return (Dictionary<UpgradeType, int>)0;
		}
	}

	public static event Action coinsChanged
	{
		add
		{
			((DataManager<>)(object)value).OnSaveGameChanged();
		}
		remove
		{
			Delegate obj = InventorySave.m_coinsChanged;
			Action action = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)InventorySave.m_coinsChanged == obj)
				{
					InventorySave.m_coinsChanged = action;
				}
				if ((object)InventorySave.m_coinsChanged != obj)
				{
					obj = InventorySave.m_coinsChanged;
					continue;
				}
				break;
			}
		}
	}

	public static event Action keysChanged
	{
		add
		{
			Delegate obj = InventorySave.m_coinsChanged;
			Action action = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)InventorySave.m_coinsChanged == obj)
				{
					InventorySave.m_coinsChanged = action;
				}
				if ((object)InventorySave.m_coinsChanged != obj)
				{
					obj = InventorySave.m_coinsChanged;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = InventorySave.m_keysChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(InventorySave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Data.Save.InventorySave>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<UpgradeType, int> powerupsChanged
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = InventorySave.m_keysChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(InventorySave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Data.Save.InventorySave>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = InventorySave.m_powerupsChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(InventorySave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Data.Save.InventorySave>)+5C]");
				object obj3 = (nint)0 + (nint)8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static void SetKeys(int newAmount)
	{
		//IL_0065: Expected Obj, but got I4
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		Delegate obj = InventorySave.m_powerupsChanged;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)newAmount);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num = (nint)typeof(InventorySave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Data.Save.InventorySave>)+5C]");
			object obj3 = (nint)0 + (nint)8;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public static void SetCoins(int newAmount)
	{
		coins = newAmount;
	}

	public static void IncreaseCoins(int amount, string sourceId)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = amount + 60;
		obj = sourceId;
	}

	public static void DecreaseCoins(int amount, string itemId, string secondaryItemId = "N/A")
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_137c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1381: Expected Obj, but got Unknown
		//IL_138a: Expected Obj, but got I4
		//IL_1399: Unknown result type (might be due to invalid IL or missing references)
		//IL_139e: Expected I, but got Unknown
		//IL_13a6: Expected I, but got Obj
		//IL_13ba: Expected I, but got Obj
		//IL_13d0: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I4
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected Obj, but got Unknown
		//IL_12c9: Expected Obj, but got I
		//IL_12d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d6: Expected Obj, but got Unknown
		//IL_1304: Expected Obj, but got I
		//IL_032e: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_1335: Unknown result type (might be due to invalid IL or missing references)
		//IL_133a: Expected Obj, but got Unknown
		//IL_03f2: Expected I, but got Obj
		//IL_036f: Expected I, but got Obj
		//IL_070e: Expected I, but got Obj
		//IL_0724: Expected Obj, but got I
		//IL_042b: Expected I, but got Obj
		//IL_0441: Expected Obj, but got I
		//IL_079f: Expected I, but got Obj
		//IL_074f: Expected I, but got Obj
		//IL_04ca: Expected I, but got Obj
		//IL_046c: Expected I, but got Obj
		//IL_04e6: Expected I, but got Obj
		//IL_04fc: Expected Obj, but got I
		//IL_07f5: Expected I, but got Obj
		//IL_080b: Expected Obj, but got I
		//IL_0585: Expected I, but got Obj
		//IL_0527: Expected I, but got Obj
		//IL_0836: Expected I, but got Obj
		//IL_05a1: Expected I, but got Obj
		//IL_05b7: Expected Obj, but got I
		//IL_05e2: Expected I, but got Obj
		//IL_1207: Expected Obj, but got I
		//IL_1210: Unknown result type (might be due to invalid IL or missing references)
		//IL_1215: Expected Obj, but got Unknown
		//IL_1233: Unknown result type (might be due to invalid IL or missing references)
		//IL_1238: Expected Obj, but got Unknown
		//IL_1241: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		nint num = (nint)(obj2 + 16);
		num = (nint)obj;
		_ = -1;
		nint num2 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v313 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(itemId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		nint num4 = num;
		object obj5 = default;
		object obj7 = default;
		object obj10 = default;
		IntPtr intPtr = default;
		object obj13 = default;
		IntPtr intPtr2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+8]");
			if ((nint)0 == 5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+C]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+C]");
					num4 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+8]");
			if ((nint)0 == 6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+C]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+C]");
					num4 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+8]");
			if ((nint)0 == 9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+C]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+C]");
					num4 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+8]");
			if ((nint)0 == 11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+C]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+C]");
					num4 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+8]");
			bool flag = (nint)0 == 10;
			bool flag2 = !flag;
			nint num5 = num4;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+C]");
				bool flag3 = (nint)0 >= (nint)1;
				bool flag4 = !flag3;
				num5 = num4;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+C]");
					num5 = 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+8]");
			if ((nint)0 == 3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num6 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S0_v177 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num7 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ S0_v252 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					bool flag5 = obj7 == null;
					bool flag6 = !flag5;
					num5 = (nint)typeof(BoardManager);
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						nint num8 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ S0_v191 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num9 = (nint)typeof(BoardManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S0_v244 (Il2CppClass<Data.Managers.BoardManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						bool flag7 = secondaryItemId == null;
						num5 = (nint)typeof(BoardManager);
						if (!flag7)
						{
							nint num10 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ S0_v202 (Il2CppClass<UIScreenController>)+BA]");
							object obj9 = (nint)0 & (nint)0x200;
							if (obj9 != null)
							{
								nint num11 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ S0_v236 (Il2CppClass<UIScreenController>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							bool flag8 = obj10 == null;
							num5 = (nint)typeof(UIScreenController);
							if (!flag8)
							{
								nint num12 = (nint)typeof(BoardScreenManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ S0_v211 (Il2CppClass<BoardScreenManager>)+BA]");
								object obj11 = (nint)0 & (nint)0x200;
								if (obj11 != null)
								{
									nint num13 = (nint)typeof(BoardScreenManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ S0_v229 (Il2CppClass<BoardScreenManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
								_ = 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								num5 = intPtr;
							}
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+8]");
			bool flag9 = (nint)0 == 4;
			bool flag10 = !flag9;
			num4 = num5;
			if (flag10)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+10]");
			bool flag11 = (nint)0 == 0;
			num4 = num5;
			if (flag11)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v78+11]");
			bool flag12 = (nint)0 == 0;
			num4 = num5;
			if (flag12)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num14 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S0_v124 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num15 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ S0_v160 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			num4 = (nint)typeof(BoardManager);
			if (obj13 != null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num16 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ S0_v142 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num17 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ S0_v151 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			num4 = intPtr2;
		}
		object obj15 = 88;
		object obj16 = obj15 - 9;
		if ((nint)obj15 != 9)
		{
			if ((nint)obj16 != 1 && (nint)obj16 != 2 && (nint)obj16 != 3)
			{
				if ((nint)obj16 == 4)
				{
					goto IL_1246;
				}
				if ((nint)obj16 != 5 && (nint)obj16 != 6 && (nint)obj16 != 7)
				{
					if ((nint)obj16 == 8)
					{
						goto IL_1246;
					}
					if ((nint)obj16 != 9 && (nint)obj16 != 10 && (nint)obj16 != 11)
					{
						if ((nint)obj16 == 12)
						{
							goto IL_1246;
						}
						if ((nint)obj16 != 13 && (nint)obj16 != 14 && (nint)obj16 != 15)
						{
							if ((nint)obj16 == 16)
							{
								goto IL_1246;
							}
							if ((nint)obj16 != 17 && (nint)obj16 != 18 && (nint)obj16 != 19)
							{
								if ((nint)obj16 == 20)
								{
									goto IL_1246;
								}
								if ((nint)obj16 != 21 && (nint)obj16 != 22 && (nint)obj16 != 23 && (nint)obj16 != 24 && (nint)obj16 != 25)
								{
									if ((nint)obj16 == 26)
									{
										goto IL_1246;
									}
									if ((nint)obj16 != 27 && (nint)obj16 != 28)
									{
										if ((nint)obj16 == 29)
										{
											goto IL_1246;
										}
										if ((nint)obj16 != 30 && (nint)obj16 != 31 && (nint)obj16 != 32 && (nint)obj16 != 33)
										{
											if ((nint)obj16 == 34)
											{
												goto IL_1246;
											}
											if ((nint)obj16 != 35 && (nint)obj16 != 36 && (nint)obj16 != 37 && (nint)obj16 != 38 && (nint)obj16 != 39)
											{
												if ((nint)obj16 == 40)
												{
													goto IL_1246;
												}
												if ((nint)obj16 != 41 && (nint)obj16 != 42)
												{
													if ((nint)obj16 == 43)
													{
														goto IL_1246;
													}
													if ((nint)obj16 != 44 && (nint)obj16 != 45 && (nint)obj16 != 46 && (nint)obj16 != 47 && (nint)obj16 != 48 && (nint)obj16 != 49 && (nint)obj16 != 50)
													{
														if ((nint)obj16 == 51 || (nint)obj16 == 52)
														{
															goto IL_1246;
														}
														if ((nint)obj16 != 53 && (nint)obj16 != 54 && (nint)obj16 != 55 && (nint)obj16 != 56 && (nint)obj16 != 57 && (nint)obj16 != 58 && (nint)obj16 != 59)
														{
															if ((nint)obj16 == 60 || (nint)obj16 == 61)
															{
																goto IL_1246;
															}
															if ((nint)obj16 != 62 && (nint)obj16 != 63)
															{
																if ((nint)obj16 == 64)
																{
																	goto IL_1246;
																}
																if ((nint)obj16 != 65 && (nint)obj16 != 66 && (nint)obj16 != 67 && (nint)obj16 != 68 && (nint)obj16 != 69)
																{
																	if ((nint)obj16 == 70 || (nint)obj16 == 71)
																	{
																		goto IL_1246;
																	}
																	if ((nint)obj16 != 72 && (nint)obj16 != 73 && (nint)obj16 != 74 && (nint)obj16 != 75)
																	{
																		if ((nint)obj16 == 76)
																		{
																			goto IL_1246;
																		}
																		if ((nint)obj16 != 77 && (nint)obj16 != 78 && (nint)obj16 == 79)
																		{
																			object obj17 = num + 4;
																			object obj18 = obj17 + 1;
																			obj17 = obj18;
																			object obj19 = obj18 << 2;
																			object obj20 = num + obj19;
																			obj20 = 352;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_157d;
		}
		goto IL_1246;
		IL_1246:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj21 = default;
		object obj22 = default;
		if (obj21 == obj22)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_157d;
		IL_157d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<Data.Managers.BoardManager>)+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<Data.Managers.BoardManager>)+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = num + obj23;
			if ((nint)obj24 == 352)
			{
				object obj25 = num + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				return;
			}
		}
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public static void IncreaseKeys(int amount, string sourceId)
	{
		//IL_0036: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		int num = unrewardedCoins;
		int num2 = amount + num;
		unrewardedCoins = num2;
		((SaveGame)amount)._002Ector((string)5, sourceId);
	}

	public static void DecreaseKeys(int amount, string itemId, string secondaryItemId = "N/A")
	{
		//IL_003a: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		int num = unrewardedCoins;
		int num2 = num - amount;
		unrewardedCoins = num2;
		PlayerInfoMigrator.MigrateTopRunSave((Dictionary<Key, string>)amount, (IDictionary)5, (IDictionary)(object)itemId, (IDictionary)(object)secondaryItemId);
	}

	private static void LogEarnedEvent(int amount, InAppItemModel.ItemType itemType, string sourceId)
	{
		//IL_0016: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		PlayerInfoMigrator.MigrateTopRunSave((Dictionary<Key, string>)amount, (IDictionary)6, (IDictionary)itemType, (IDictionary)(object)sourceId);
		int num = coins;
		int num2 = num - amount;
		coins = num2;
	}

	private static void LogSpentEvent(int amount, InAppItemModel.ItemType itemType, string itemId, string secondaryItemId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1672: Unknown result type (might be due to invalid IL or missing references)
		//IL_1677: Expected Obj, but got Unknown
		//IL_1680: Expected Obj, but got I4
		//IL_1695: Unknown result type (might be due to invalid IL or missing references)
		//IL_169a: Expected Obj, but got Unknown
		//IL_16a3: Expected Obj, but got I4
		//IL_16ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b1: Expected I, but got Unknown
		//IL_16b9: Expected I, but got Obj
		//IL_16cd: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_1b72: Expected Obj, but got I4
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_173b: Expected Obj, but got I4
		//IL_0aff: Expected I, but got Obj
		//IL_0b15: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		//IL_0c6c: Expected I, but got Obj
		//IL_0c82: Expected Obj, but got I
		//IL_0bb5: Expected I, but got Obj
		//IL_0bcb: Expected Obj, but got I
		//IL_1813: Expected Obj, but got I4
		//IL_188d: Expected Obj, but got I4
		//IL_186c: Expected Obj, but got I4
		//IL_1828: Expected Obj, but got I
		//IL_0b40: Expected I, but got Obj
		//IL_0cad: Expected I, but got Obj
		//IL_0bf6: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I4
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_1301: Expected I, but got Obj
		//IL_1317: Expected Obj, but got I
		//IL_1488: Expected I, but got Obj
		//IL_149e: Expected Obj, but got I
		//IL_13c4: Expected I, but got Obj
		//IL_13da: Expected Obj, but got I
		//IL_1081: Expected I, but got Obj
		//IL_1097: Expected Obj, but got I
		//IL_0d3d: Expected I, but got Obj
		//IL_0d53: Expected Obj, but got I
		//IL_1342: Expected I, but got Obj
		//IL_1996: Expected I, but got Obj
		//IL_19ac: Expected Obj, but got I
		//IL_18c3: Expected I, but got Obj
		//IL_18d9: Expected Obj, but got I
		//IL_1a85: Expected I, but got Obj
		//IL_1a9b: Expected Obj, but got I
		//IL_14c9: Expected I, but got Obj
		//IL_1405: Expected I, but got Obj
		//IL_10c2: Expected I, but got Obj
		//IL_0ff3: Expected I, but got Obj
		//IL_1009: Expected Obj, but got I
		//IL_0d7e: Expected I, but got Obj
		//IL_115c: Expected I, but got Obj
		//IL_1172: Expected Obj, but got I
		//IL_110f: Expected I, but got Obj
		//IL_0e18: Expected I, but got Obj
		//IL_0e2e: Expected Obj, but got I
		//IL_0dcb: Expected I, but got Obj
		//IL_0a39: Expected Obj, but got I
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected Obj, but got Unknown
		//IL_1516: Expected I, but got Obj
		//IL_1034: Expected I, but got Obj
		//IL_1568: Unknown result type (might be due to invalid IL or missing references)
		//IL_156d: Expected Obj, but got Unknown
		//IL_157e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1583: Expected Obj, but got Unknown
		//IL_1594: Unknown result type (might be due to invalid IL or missing references)
		//IL_1599: Expected Obj, but got Unknown
		//IL_15b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b5: Expected Obj, but got Unknown
		//IL_15d3: Expected Obj, but got I4
		//IL_15e9: Expected I, but got Obj
		//IL_15ff: Expected Obj, but got I
		//IL_119d: Expected I, but got Obj
		//IL_0e59: Expected I, but got Obj
		//IL_0a7c: Expected Obj, but got I
		//IL_1b1d: Expected Obj, but got I4
		//IL_11ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f4: Expected Obj, but got Unknown
		//IL_1205: Unknown result type (might be due to invalid IL or missing references)
		//IL_120a: Expected Obj, but got Unknown
		//IL_1221: Unknown result type (might be due to invalid IL or missing references)
		//IL_1226: Expected Obj, but got Unknown
		//IL_123f: Expected Obj, but got I4
		//IL_1255: Expected I, but got Obj
		//IL_126b: Expected Obj, but got I
		//IL_0eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb0: Expected Obj, but got Unknown
		//IL_0ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec6: Expected Obj, but got Unknown
		//IL_0edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee2: Expected Obj, but got Unknown
		//IL_0efb: Expected Obj, but got I4
		//IL_0f11: Expected I, but got Obj
		//IL_0f27: Expected Obj, but got I
		//IL_162a: Expected I, but got Obj
		//IL_1a3c: Expected Obj, but got I4
		//IL_196a: Expected Obj, but got I4
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected Obj, but got Unknown
		//IL_1296: Expected I, but got Obj
		//IL_0f52: Expected I, but got Obj
		//IL_0287: Expected I, but got Obj
		//IL_029d: Expected Obj, but got I
		//IL_02c8: Expected I, but got Obj
		//IL_0988: Expected Obj, but got I
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got Unknown
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected Obj, but got Unknown
		//IL_09c2: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		nint num = (nint)(obj2 + 32);
		num = (nint)obj;
		_ = -1;
		object obj5 = amount + 48;
		obj5 = itemId;
		bool flag = (nint)secondaryItemId == 5;
		int num2 = ((!flag) ? coins : unrewardedCoins);
		object obj6 = itemType - num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [amount @ L0 (System.Int32)+38]");
		object obj8;
		string text5 = default;
		if ((nint)0 != 0)
		{
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v285 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v478 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isAnyDiscountAvailable = InAppManager.IsAnyDiscountAvailable;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			obj8 = 0;
			string text = string.Empty;
			object obj9 = default;
			string text2 = default;
			string text3 = default;
			object obj11 = default;
			string text4 = default;
			object obj12 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj9 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v392+34]");
				if ((nint)0 == 0)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v399+28]");
				if (0 != (nint)secondaryItemId)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S0_v406+14]");
				if (0 < (nint)obj6)
				{
					continue;
				}
				if (text != null && text.m_stringLength != 0)
				{
					nint num5 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ S0_v431 (Il2CppClass<InApp.InAppData>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num6 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ S0_v463 (Il2CppClass<InApp.InAppData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v442+14]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S1_v215+14]");
					if (num7 <= 0)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					text2 = text3;
					obj8 = obj11;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					text4 = text3;
					obj8 = obj12;
				}
				text = text3;
			}
			object obj13 = 50;
			object obj14 = obj13 - 15;
			object obj21;
			object obj22 = default;
			if ((nint)obj13 != 15 && (nint)obj14 != 1)
			{
				if ((nint)obj14 == 2 || (nint)obj14 == 3 || (nint)obj14 == 4)
				{
					goto IL_1b31;
				}
				if ((nint)obj14 != 5)
				{
					if ((nint)obj14 == 6 || (nint)obj14 == 7)
					{
						goto IL_1b31;
					}
					if ((nint)obj14 != 8)
					{
						if ((nint)obj14 == 9 || (nint)obj14 == 10 || (nint)obj14 == 11 || (nint)obj14 == 12 || (nint)obj14 == 13)
						{
							goto IL_1b31;
						}
						if ((nint)obj14 != 14)
						{
							if ((nint)obj14 == 15 || (nint)obj14 == 16 || (nint)obj14 == 17)
							{
								goto IL_1b31;
							}
							if ((nint)obj14 != 18)
							{
								if ((nint)obj14 != 19)
								{
									if ((nint)obj14 == 20 || (nint)obj14 == 21)
									{
										goto IL_1b31;
									}
									if ((nint)obj14 != 22)
									{
										if ((nint)obj14 != 23)
										{
											if ((nint)obj14 == 24 || (nint)obj14 == 25 || (nint)obj14 == 26 || (nint)obj14 == 27 || (nint)obj14 == 28 || (nint)obj14 == 29)
											{
												goto IL_1b31;
											}
											if ((nint)obj14 != 30)
											{
												if ((nint)obj14 != 31)
												{
													if ((nint)obj14 != 32)
													{
														if ((nint)obj14 != 33 && (nint)obj14 != 34 && (nint)obj14 == 35)
														{
															object obj15 = num + 4;
															object obj16 = obj15 + 1;
															obj15 = obj16;
															object obj17 = obj16 << 2;
															object obj18 = num + obj17;
															obj18 = 217;
															text5 = text;
														}
														goto IL_1b31;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj20 = default;
													object obj19 = obj20;
													obj21 = obj22;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj23 = default;
													object obj19 = obj23;
													text = text4;
													obj21 = obj22;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj24 = default;
												object obj19 = obj24;
												obj21 = obj22;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj25 = default;
											object obj19 = obj25;
											text = text2;
											obj21 = obj22;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj26 = default;
										object obj19 = obj26;
										obj21 = obj22;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj27 = default;
									object obj19 = obj27;
									obj21 = obj22;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj28 = default;
								object obj19 = obj28;
								obj21 = obj22;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj29 = default;
							object obj19 = obj29;
							obj21 = obj22;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj30 = default;
						object obj19 = obj30;
						obj21 = obj22;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj31 = default;
					object obj19 = obj31;
					obj21 = obj22;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj32 = default;
				object obj19 = obj32;
				obj21 = obj22;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj33 = default;
			if (obj21 == obj33)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				text5 = text;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			goto IL_1b31;
		}
		string text6 = string.Empty;
		goto IL_1b64;
		IL_1b64:
		object obj34 = amount + 52;
		obj34 = text6;
		string text8;
		object obj36;
		if (flag)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v271 (Il2CppClass<Strings>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num9 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v279 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text7 = Strings.GetDefault("NOT_ENOUGH_COINS");
			text8 = text7;
			obj36 = 1;
		}
		else if ((nint)secondaryItemId == 6)
		{
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v258 (Il2CppClass<Strings>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num11 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v266 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text9 = Strings.GetDefault("NOT_ENOUGH_KEYS");
			text8 = text9;
			obj36 = 0;
		}
		else
		{
			obj2 = secondaryItemId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text11 = default;
			string text10 = "No handling implemented for item type: " + text11;
			nint num12 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v131 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num13 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S1_v136 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
			text8 = "";
			obj36 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [amount @ L0 (System.Int32)+34]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [amount @ L0 (System.Int32)+34]");
		bool flag2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v38+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (flag2)
		{
			if (flag)
			{
				nint num14 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S0_v186 (Il2CppClass<UnityEngine.Debug>)+BA]");
				object obj40 = (nint)0 & (nint)0x200;
				if (obj40 != null)
				{
					nint num15 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v239 (Il2CppClass<UnityEngine.Debug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Debug.LogError("coins");
				nint num16 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S0_v193 (Il2CppClass<Strings>)+BA]");
				object obj41 = (nint)0 & (nint)0x200;
				if (obj41 != null)
				{
					nint num17 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ S0_v235 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string format = Strings.GetDefault("NOT_ENOUGH_COINS_POPUP_ADD_ON_COINS");
				obj2 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args = default;
				string text12 = string.Format(format, args);
				nint num18 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ S0_v202 (Il2CppClass<UIScreenController>)+BA]");
				object obj42 = (nint)0 & (nint)0x200;
				if (obj42 != null)
				{
					nint num19 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ S0_v231 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIScreenController uIScreenController = UIScreenController.Instance;
				if ((object)uIScreenController == null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj44 = default;
				object obj43 = obj44 + 8;
				obj43 = text8;
				object obj45 = obj44 + 12;
				obj45 = text12;
				_ = 0;
				object obj46 = obj36 & 1;
				_ = 0;
				object obj47 = amount + 60;
				obj47 = obj44;
				nint num20 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ S0_v221 (Il2CppClass<UIScreenController>)+BA]");
				object obj48 = (nint)0 & (nint)0x200;
				if (obj48 != null)
				{
					nint num21 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ S0_v227 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag3).QueuePopup("NotEnoughCurrencyPopup");
				return;
			}
			if ((nint)secondaryItemId != 6)
			{
				obj2 = secondaryItemId;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text14 = default;
				string text13 = "No handling implemented for item type: " + text14;
				nint num22 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ S1_v95 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj49 = (nint)0 & (nint)0x200;
				if (obj49 != null)
				{
					nint num23 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S1_v100 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
				return;
			}
			nint num24 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v121 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj50 = (nint)0 & (nint)0x200;
			if (obj50 != null)
			{
				nint num25 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S0_v174 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogError("keys");
			nint num26 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ S0_v128 (Il2CppClass<Strings>)+BA]");
			object obj51 = (nint)0 & (nint)0x200;
			if (obj51 != null)
			{
				nint num27 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ S0_v170 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format2 = Strings.GetDefault("NOT_ENOUGH_COINS_POPUP_ADD_ON_KEYS");
			obj2 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args2 = default;
			string text15 = string.Format(format2, args2);
			nint num28 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S0_v137 (Il2CppClass<UIScreenController>)+BA]");
			object obj52 = (nint)0 & (nint)0x200;
			if (obj52 != null)
			{
				nint num29 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ S0_v166 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIScreenController uIScreenController2 = UIScreenController.Instance;
			if ((object)uIScreenController2 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj54 = default;
			object obj53 = obj54 + 8;
			obj53 = text8;
			object obj55 = obj54 + 12;
			obj55 = text15;
			_ = 0;
			object obj56 = obj36 & 1;
			_ = 0;
			object obj57 = amount + 60;
			obj57 = obj54;
			nint num30 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v995 @ S0_v156 (Il2CppClass<UIScreenController>)+BA]");
			object obj58 = (nint)0 & (nint)0x200;
			if (obj58 != null)
			{
				nint num31 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1017 @ S0_v162 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag4).QueuePopup("NotEnoughCurrencyPopup");
			return;
		}
		string text17;
		if (flag)
		{
			nint num32 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v105 (Il2CppClass<Strings>)+BA]");
			object obj59 = (nint)0 & (nint)0x200;
			if (obj59 != null)
			{
				nint num33 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S0_v113 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format3 = Strings.GetDefault("NOT_ENOUGH_COINS_POPUP_ADD_ON_COINS");
			obj2 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args3 = default;
			string text16 = string.Format(format3, args3);
			text17 = text16;
		}
		else if ((nint)secondaryItemId == 6)
		{
			nint num34 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S0_v92 (Il2CppClass<Strings>)+BA]");
			object obj60 = (nint)0 & (nint)0x200;
			if (obj60 != null)
			{
				nint num35 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S0_v100 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format4 = Strings.GetDefault("NOT_ENOUGH_COINS_POPUP_ADD_ON_KEYS");
			obj2 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args4 = default;
			string text18 = string.Format(format4, args4);
			text17 = text18;
		}
		else
		{
			obj2 = secondaryItemId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text20 = default;
			string text19 = "No handling implemented for item type: " + text20;
			nint num36 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ S1_v46 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj61 = (nint)0 & (nint)0x200;
			if (obj61 != null)
			{
				nint num37 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ S1_v51 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
			text17 = "";
		}
		nint num38 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S0_v47 (Il2CppClass<UIScreenController>)+BA]");
		object obj62 = (nint)0 & (nint)0x200;
		if (obj62 != null)
		{
			nint num39 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ S0_v78 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController3 = UIScreenController.Instance;
		if ((object)uIScreenController3 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj64 = default;
		object obj63 = obj64 + 8;
		obj63 = text8;
		object obj65 = obj64 + 12;
		obj65 = text17;
		object obj66 = obj64 + 28;
		object obj67 = default;
		obj66 = obj67;
		_ = 1;
		object obj68 = obj36 & 1;
		_ = 0;
		object obj69 = amount + 60;
		obj69 = obj64;
		nint num40 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ S0_v68 (Il2CppClass<UIScreenController>)+BA]");
		object obj70 = (nint)0 & (nint)0x200;
		if (obj70 != null)
		{
			nint num41 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ S0_v74 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag5).QueuePopup("NotEnoughCurrencyPopup");
		return;
		IL_1b31:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppMethodInfo)+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppMethodInfo)+4]");
			object obj71 = (nint)0 << 2;
			object obj72 = num + obj71;
			if ((nint)obj72 == 217)
			{
				object obj73 = num + 4;
				if ((nint)obj73 > -1)
				{
					object obj74 = obj73 + -1;
					obj73 = obj74;
				}
				text6 = text5;
				obj67 = obj8;
				goto IL_1b64;
			}
		}
		object obj75 = default;
		if (obj75 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			text6 = text5;
			obj67 = obj8;
		}
		goto IL_1b64;
	}

	public static void RewardUnrewardedCoins()
	{
	}

	public static void Use(UpgradeType type)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I4
		nint num = (nint)typeof(InventorySave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.InventorySave>)+5C]");
		object obj = (nint)0 + (nint)12;
		obj = type;
	}

	public static int GetAmount(UpgradeType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_063f: Expected Obj, but got I4
		//IL_0656: Expected Obj, but got I4
		//IL_0664: Expected I, but got Obj
		//IL_067a: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0628: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		obj3 = 0;
		nint num = (nint)typeof(EventManagerUtils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<Events.EventManagerUtils>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(EventManagerUtils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v271 (Il2CppClass<Events.EventManagerUtils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		object obj5 = default;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj7 = default;
			object obj6 = obj7;
			object obj9 = default;
			object obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj10 = default;
			if (obj6 == obj10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj12 = default;
				object obj11 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj14 = default;
				object obj13 = obj14;
			}
			else
			{
				object obj13 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		return (int)obj3;
	}

	public static int GetTier(UpgradeType type)
	{
		//IL_005e: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I
		LocalDebugData localDebugData = DataManager<>.localDebug;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			LocalDebugData localDebugData2 = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15 (Data.Save.Internal.LocalDebugData)+14]");
			return ((Dictionary<UpgradeType, int>)0).get_Item(type);
		}
		return 0;
	}

	public static void IncreaseAmount(UpgradeType type, int amount)
	{
		//IL_0036: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		int num = coins;
		int num2 = (int)(type + num);
		coins = num2;
		((SaveGame)type)._002Ector((string)6, (string)amount);
	}

	public static void IncreaseTier(UpgradeType type)
	{
		//IL_0192: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I
		//IL_0140: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 <= -1)
		{
			return;
		}
		LocalDebugData localDebugData2 = DataManager<>.localDebug;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Data.Save.Internal.LocalDebugData)+14]");
		int num2 = ((Dictionary<UpgradeType, int>)0).get_Item(type);
		if (num2 > 0)
		{
			LocalDebugData localDebugData3 = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v20 (Data.Save.Internal.LocalDebugData)+14]");
			int num3 = ((Dictionary<UpgradeType, int>)0).get_Item(type);
			object obj7 = num3 - 1;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v6+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v7+48]");
			object obj10 = 0;
			object obj11 = obj10 & 0x7FF;
			object obj12 = obj11 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S5_v5 (should have been resolved before IL gen)");
			LocalDebugData localDebugData4 = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v32 (Data.Save.Internal.LocalDebugData)+14]");
			int num5 = ((Dictionary<UpgradeType, int>)0).get_Item(type);
			if (InventorySave.m_powerupsChanged != null)
			{
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S3_v7 (Il2CppMethodInfo)+18]");
				object obj13 = 0;
				object obj14 = obj13;
				object obj15 = obj14 & 0x1FFF;
				object obj16 = obj15 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S4_v12 (should have been resolved before IL gen)");
			}
		}
	}

	public static void ResetTier(UpgradeType type)
	{
		//IL_00b2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
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
			int num2 = ((Dictionary<UpgradeType, int>)allowSellHeadstartDuringRun2).get_Item(type);
			object obj7 = num2 + 1;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S4_v6+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S4_v7+48]");
			object obj10 = 0;
			object obj11 = obj10 & 0x7FF;
			object obj12 = obj11 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	public static void AddPendingReward(CelebrationReward reward, Func<CelebrationRewardOrigin, int> getRewardPriority)
	{
		//IL_0142: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0023: Expected I4, but got Obj
		//IL_0023: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00b3: Expected I4, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		LocalDebugData localDebugData = DataManager<>.localDebug;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			LocalDebugData localDebugData2 = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v7 (Data.Save.Internal.LocalDebugData)+14]");
			int num2 = ((Dictionary<UpgradeType, int>)0).get_Item((UpgradeType)reward);
			object obj7 = getRewardPriority + num2;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S4_v6+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S4_v7+48]");
			object obj10 = 0;
			object obj11 = obj10 & 0x7FF;
			object obj12 = obj11 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50 @ S5_v5 (should have been resolved before IL gen)");
			LocalDebugData localDebugData3 = DataManager<>.localDebug;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v22 (Data.Save.Internal.LocalDebugData)+14]");
			int num4 = ((Dictionary<UpgradeType, int>)0).get_Item((UpgradeType)reward);
			if (InventorySave.m_powerupsChanged != null)
			{
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S3_v9 (Il2CppMethodInfo)+18]");
				object obj13 = 0;
				object obj14 = obj13;
				object obj15 = obj14 & 0x1FFF;
				object obj16 = obj15 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S4_v12 (should have been resolved before IL gen)");
			}
		}
	}

	public static void RemovePendingReward(CelebrationReward rewardToRemove)
	{
		//IL_008e: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
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
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S4_v6+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S4_v7+48]");
			object obj9 = 0;
			object obj10 = obj9 & 0x7FF;
			object obj11 = obj10 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	public InventorySave()
	{
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got I
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_01fc: Expected I, but got Obj
		//IL_0212: Expected Obj, but got I
		//IL_00e0: Expected I, but got Obj
		//IL_023d: Expected I, but got Obj
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_028a: Expected I, but got Obj
		//IL_02a0: Expected Obj, but got I
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Obj, but got Unknown
		//IL_0436: Expected I, but got Obj
		//IL_044c: Expected Obj, but got I
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_04df: Expected I, but got Obj
		//IL_04f5: Expected Obj, but got I
		//IL_016e: Expected I, but got Obj
		//IL_02cb: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> dictionary = boardThemeData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		NullReferenceException ex = new NullReferenceException();
		NullReferenceException ex2 = ex;
		if (ex == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v35+8]");
			if ((nint)0 == 1)
			{
				Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> dictionary2 = boardThemeData;
				nint num2 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v92 (Il2CppClass<Data.Save.InventorySave+<>c>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num3 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v128 (Il2CppClass<Data.Save.InventorySave+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (_003C_003Ec._003C_003E9__54_1 == null)
				{
					nint num4 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v102 (Il2CppClass<Data.Save.InventorySave+<>c>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num5 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v122 (Il2CppClass<Data.Save.InventorySave+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num6 = 0;
					_ = 0;
					object obj9 = default;
					object obj8 = obj9 + 16;
					obj8 = _003C_003Ec._003C_003E9;
					nint num7 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v119 (Il2CppClass<Data.Save.InventorySave+<>c>)+5C]");
					object obj10 = (nint)0 + (nint)4;
					obj10 = obj9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v42+8]");
				if ((nint)0 != 2)
				{
					return;
				}
				Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> dictionary3 = boardThemeData;
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v48 (Il2CppClass<Data.Save.InventorySave+<>c>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num9 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v83 (Il2CppClass<Data.Save.InventorySave+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (_003C_003Ec._003C_003E9__54_2 == null)
				{
					nint num10 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v57 (Il2CppClass<Data.Save.InventorySave+<>c>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num11 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v77 (Il2CppClass<Data.Save.InventorySave+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num12 = 0;
					_ = 0;
					object obj15 = default;
					object obj14 = obj15 + 16;
					obj14 = _003C_003Ec._003C_003E9;
					nint num13 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v74 (Il2CppClass<Data.Save.InventorySave+<>c>)+5C]");
					object obj16 = (nint)0 + (nint)8;
					obj16 = obj15;
				}
			}
			NullReferenceException ex3 = new NullReferenceException();
			ex2 = ex3;
			if (ex3 == null)
			{
				return;
			}
		}
		Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> dictionary4 = boardThemeData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DB3");
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DB3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v30+30]");
			if ((nint)0 == ((Exception)ex2)._HResult)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @925A");
			}
		}
	}
}
