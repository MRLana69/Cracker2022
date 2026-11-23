using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;
using UnityEngine;

public static class MysteryBox
{
	public enum Type
	{
		Normal,
		Super,
		Mini
	}

	private class LootTableEntry
	{
		public CelebrationRewardType itemType;

		public float weight;

		public int min = 1;

		public int max;

		public PowerupType powerupType;

		public LootTableEntry()
		{
			//IL_000f: Expected I4, but got I8
		}
	}

	public static readonly Characters.CharacterType[] tokenRewardTypes;

	public static readonly Dictionary<Characters.CharacterType, int> characterTokenWeight;

	private static readonly LootTableEntry[][] _lootTables;

	public static readonly int mysteryBoxJackpotAmount;

	public static readonly int superMysteryBoxJackpotAmount;

	public const int DEFAULT_MEGA_JACKPOT_MYSTERYBOX = 900000;

	public const int DEFAULT_MEGA_JACKPOT_SUPER_MYSTERYBOX = 1500000;

	private static readonly CelebrationReward MYSTERYBOX_CONSOLATION_REWARD;

	private static readonly CelebrationReward SUPERMYSTERYBOX_CONSOLATION_REWARD;

	static MysteryBox()
	{
		//IL_003f: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00f8: Expected I4, but got I8
		//IL_0121: Expected I4, but got I8
		//IL_0139: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E.CF97ADEEDB59E05BFD73A2B4C2A8885708C4F4F70C84C64B27120E72AB733B72));
		tokenRewardTypes = (Characters.CharacterType[])array;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32>>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S5_v4+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S5_v9+4] (should have been resolved before IL gen)");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S5_v14+4] (should have been resolved before IL gen)");
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Int32>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ S5_v19+4] (should have been resolved before IL gen)");
		Dictionary<Characters.CharacterType, int> dictionary = default;
		characterTokenWeight = dictionary;
		mysteryBoxJackpotAmount = 100000;
		superMysteryBoxJackpotAmount = 300000;
		CelebrationReward celebrationReward = default;
		celebrationReward._002Ector();
		celebrationReward.rewardType = CelebrationRewardType.coins;
		MYSTERYBOX_CONSOLATION_REWARD = celebrationReward;
		CelebrationReward celebrationReward2 = default;
		celebrationReward2._002Ector();
		celebrationReward2.rewardType = CelebrationRewardType.coins;
		SUPERMYSTERYBOX_CONSOLATION_REWARD = celebrationReward2;
		System.Type typeFromHandle = System.Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Type));
		Array values = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		LootTableEntry[][] lootTables = default;
		_lootTables = lootTables;
		LootTableEntry[][] lootTables2 = _lootTables;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 4294967297L;
		_ = 1;
		_ = 4294967297L;
		_ = 4661225614328463362L;
		throw new ArrayTypeMismatchException();
	}

	public static void TestRolls(int numberOfRolls, Type mysteryBoxType = Type.Normal)
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		object obj = 0;
		while (numberOfRolls > (nint)obj)
		{
			CelebrationReward celebrationReward = Roll(mysteryBoxType);
			object obj2 = obj + 1;
			obj = obj2;
		}
	}

	public static CelebrationReward Roll(Type mysteryBoxType)
	{
		//IL_05f3: Expected Obj, but got I4
		//IL_0100: Expected I4, but got I8
		//IL_0125: Expected I4, but got I8
		//IL_01c5: Expected I4, but got I8
		//IL_0637: Expected Obj, but got I4
		//IL_066c: Expected Obj, but got I4
		//IL_02ba: Expected I4, but got I8
		//IL_014f: Expected I4, but got I8
		//IL_02d1: Expected I4, but got I8
		//IL_0585: Expected I4, but got I8
		CelebrationReward celebrationReward = default;
		celebrationReward._002Ector();
		PlayerInfo instance = PlayerInfo.Instance;
		if (mysteryBoxType != Type.Normal)
		{
			if (mysteryBoxType != Type.Super)
			{
				if (mysteryBoxType != Type.Mini)
				{
					goto IL_05c5;
				}
				int num = instance._amountOfMiniMysteryBoxesOpened + 1;
				if (num != instance._amountOfMiniMysteryBoxesOpened)
				{
					instance._dirty = true;
					instance._amountOfMiniMysteryBoxesOpened = num;
				}
				object obj = instance._amountOfMiniMysteryBoxesOpened - 1;
				if (instance._amountOfMiniMysteryBoxesOpened != 1)
				{
					if ((nint)obj != 1)
					{
						goto IL_05c5;
					}
					celebrationReward.rewardType = CelebrationRewardType.keys;
				}
				else
				{
					celebrationReward.powerupType = PowerupType.scorebooster;
					celebrationReward.rewardType = CelebrationRewardType.powerup;
				}
			}
			else
			{
				if (instance._hasReceivedFirstSMBKey)
				{
					int num2 = instance._amountOfSuperMysteryBoxesOpened + 1;
					if (num2 != instance._amountOfSuperMysteryBoxesOpened)
					{
						instance._dirty = true;
						instance._amountOfSuperMysteryBoxesOpened = num2;
					}
					goto IL_05c5;
				}
				celebrationReward.rewardType = CelebrationRewardType.keys;
				if (!instance._hasReceivedFirstSMBKey)
				{
					instance._dirty = true;
					instance._hasReceivedFirstSMBKey = true;
				}
			}
		}
		else
		{
			int num3 = instance._amountOfMysteryBoxesOpened + 1;
			if (num3 != instance._amountOfMysteryBoxesOpened)
			{
				instance._dirty = true;
				instance._amountOfMysteryBoxesOpened = num3;
			}
			object obj2 = instance._amountOfMysteryBoxesOpened - 1;
			if (instance._amountOfMysteryBoxesOpened != 1)
			{
				if ((nint)obj2 == 1)
				{
					celebrationReward.powerupType = PowerupType.hoverboard;
					celebrationReward.rewardType = CelebrationRewardType.powerup;
				}
				else
				{
					if (instance._hasReceivedFirstMBKey)
					{
						goto IL_05c5;
					}
					celebrationReward.rewardType = CelebrationRewardType.keys;
					if (!instance._hasReceivedFirstMBKey)
					{
						instance._dirty = true;
						instance._hasReceivedFirstMBKey = true;
					}
				}
			}
			else
			{
				celebrationReward.rewardType = CelebrationRewardType.coins;
			}
		}
		goto IL_0615;
		IL_068e:
		return celebrationReward;
		IL_058a:
		LootTableEntry lootTableEntry;
		int amount = UnityEngine.Random.Range(lootTableEntry.min, lootTableEntry.max);
		celebrationReward.amount = amount;
		goto IL_0615;
		IL_05c5:
		List<Trophies.Trophy> availableTrophyList = GetAvailableTrophyList(mysteryBoxType);
		List<Characters.CharacterType> availableCharacterTokens = GetAvailableCharacterTokens();
		lootTableEntry = MakeRoll(mysteryBoxType);
		object obj3 = default;
		if (lootTableEntry != null)
		{
			obj3 = lootTableEntry.itemType - 1;
			if (lootTableEntry.itemType == CelebrationRewardType.coins)
			{
				celebrationReward.rewardType = CelebrationRewardType.coins;
				if ((celebrationReward.amount = UnityEngine.Random.Range(lootTableEntry.min, lootTableEntry.max)) >= 5000)
				{
					MissionsManager instance2 = MissionsManager.Instance;
					instance2.PlayerDidThis(MissionTarget.MysteryBoxGrandPrize);
				}
				SSEventsManagerController instance3 = SSEventsManagerController.instance;
				IEventManager activeEventManager = instance3.GetActiveEventManager(SSEventType.BiggerJackpot);
				if (((mysteryBoxType == Type.Normal && celebrationReward.amount == mysteryBoxJackpotAmount) || (celebrationReward.amount == superMysteryBoxJackpotAmount && mysteryBoxType == Type.Super)) && activeEventManager != null)
				{
					int megaJackpotAmount = GetMegaJackpotAmount(mysteryBoxType);
					celebrationReward.amount = megaJackpotAmount;
					goto IL_0615;
				}
				goto IL_068e;
			}
		}
		if ((nint)obj3 != 1)
		{
			if ((nint)obj3 != 2)
			{
				if ((nint)obj3 == 3)
				{
					celebrationReward.rewardType = CelebrationRewardType.keys;
					goto IL_058a;
				}
			}
			else
			{
				celebrationReward.rewardType = CelebrationRewardType.medal;
			}
			goto IL_068e;
		}
		celebrationReward.rewardType = CelebrationRewardType.powerup;
		celebrationReward.powerupType = lootTableEntry.powerupType;
		goto IL_058a;
		IL_0615:
		return celebrationReward;
	}

	public static int GetMegaJackpotAmount(Type mysteryBoxType)
	{
		OnlineSettings instance = OnlineSettings.instance;
		object key = "event_jackpot_supermysterybox_value";
		if (mysteryBoxType == Type.Normal)
		{
			key = "event_jackpot_mysterybox_value";
		}
		int num = 1500000;
		if (mysteryBoxType == Type.Normal)
		{
			num = 900000;
		}
		int value = instance.GetValue((string)key, num);
		if (value <= 0)
		{
			return num;
		}
		return value;
	}

	private static LootTableEntry MakeRoll(Type mysteryBoxType)
	{
		//IL_016c: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_019d: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I
		//IL_0013: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		object obj = 0;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			object obj2 = (int)mysteryBoxType << 2;
			object obj3 = (object)_lootTables + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v14+C]");
			if (0 <= (nint)obj)
			{
				break;
			}
			object obj5 = (int)mysteryBoxType << 2;
			object obj6 = (object)_lootTables + obj5;
			object obj7 = obj << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v24+10]");
			object obj8 = 0 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v26+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v27+C]");
			obj10 = obj11 + 0;
			object obj12 = obj + 1;
			obj = obj12;
		}
		float num = UnityEngine.Random.Range(0f, 1f);
		float num2 = num * (float)obj10;
		object obj13 = 0;
		float num3 = default;
		LootTableEntry result;
		while (true)
		{
			object obj14 = (int)mysteryBoxType << 2;
			object obj15 = (object)_lootTables + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v13+10]");
			object obj16 = 0;
			object obj17 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v14+C]");
			if ((nint)obj17 < 0)
			{
				object obj18 = (int)mysteryBoxType << 2;
				object obj19 = (object)_lootTables + obj18;
				object obj20 = obj13 << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v12+10]");
				object obj21 = 0 + obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S2_v14+10]");
				LootTableEntry lootTableEntry = (LootTableEntry)0;
				num3 += lootTableEntry.weight;
				bool flag = !(num2 > num3);
				result = lootTableEntry;
				if (flag)
				{
					break;
				}
				object obj22 = obj13 + 1;
				obj13 = obj22;
				continue;
			}
			result = null;
			break;
		}
		return result;
	}

	private static Characters.CharacterType GetRandomCharacterTokenTypeUsingWeights(List<Characters.CharacterType> validCharacters)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_010b: Expected Obj, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_02b0: Expected Obj, but got I
		//IL_022a: Expected I, but got Obj
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10;
		object obj11 = default;
		object obj12 = default;
		int num;
		int num2 = default;
		int num3 = default;
		Characters.CharacterType result = default;
		System.Random random = default;
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
				if (obj6 == null)
				{
					goto IL_01fc;
				}
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj7 = obj8 + obj9;
							obj9 = obj7;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj10 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj10 = 0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj10 = 0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj10 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj11 != obj12;
			num = num2;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01fc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				num = num3;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			List<Characters.CharacterType> list = (List<Characters.CharacterType>)0;
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
			return result;
			IL_01fc:
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BA");
			random._002Ector();
			nint num4 = (nint)random;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ S3_v8 (Il2CppClass<System.Random>)+EC] (should have been resolved before IL gen)");
			object obj15 = obj16 + 1;
			obj9 = 0;
			obj10 = obj15;
			num = 0;
			break;
		}
		while (true)
		{
			int num5 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v68 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>)+C]");
			if ((nint)num5 >= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			Characters.CharacterType key = ((List<Characters.CharacterType>)0).get_Item(num);
			int num6 = characterTokenWeight.get_Item(key);
			object obj17 = num6 + obj9;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				return ((List<Characters.CharacterType>)0).get_Item(num);
			}
			int num7 = num + 1;
			obj9 = obj17;
			num = num7;
		}
		return Characters.CharacterType.tricky;
	}

	private unsafe static List<Trophies.Trophy> GetAvailableTrophyList(Type mysteryBoxType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0179: Expected VT, but got Obj
		//IL_0046: Expected Obj, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Ref, but got Unknown
		//IL_0101: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		System.Type typeFromHandle = System.Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Trophies.Trophy));
		Array values = Enum.GetValues(typeFromHandle);
		List<Trophies.Trophy> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj3 = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22+C]");
			if (0 <= (nint)obj3)
			{
				break;
			}
			object obj4 = obj3 << 2;
			object obj5 = obj6 + obj4;
			PlayerInfo instance = PlayerInfo.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v32+10]");
			if (instance.ShouldSpawnTrophy(Trophies.Trophy.diamond))
			{
				ref TrophyData value = ref *(TrophyData*)(obj + 12);
				Dictionary<Trophies.Trophy, TrophyData> trophyData = Trophies.trophyData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v32+10]");
				if (trophyData.TryGetValue(Trophies.Trophy.diamond, out value))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v52+C]");
					if ((nint)0 == (nint)mysteryBoxType)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v32+10]");
						list.Add(Trophies.Trophy.diamond);
					}
				}
			}
			object obj8 = obj3 + 1;
			obj3 = obj8;
		}
		return list;
	}

	private static List<Characters.CharacterType> GetAvailableCharacterTokens()
	{
		//IL_0017: Expected Obj, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		List<Characters.CharacterType> list = default;
		list._002Ector();
		Characters.CharacterType[] array = tokenRewardTypes;
		object obj = 0;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			PlayerInfo instance = PlayerInfo.Instance;
			object obj4 = obj + 1;
			obj = obj4;
		}
		return list;
	}
}
