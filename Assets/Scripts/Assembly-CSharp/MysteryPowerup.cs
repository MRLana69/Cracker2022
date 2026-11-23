using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

public class MysteryPowerup
{
	private const float randomBoardDuration = 15f;

	private const int randomBoardWeight = 22;

	private const string randomBoardIconName = "icon_random_board";

	private static readonly Dictionary<PowerupType, CharacterModifier> mysteryPowerupCharacterModifiers;

	private static readonly List<Hoverboards.BoardType> excludedBoards;

	private static CharacterModifier SelectRandomCharacterModifier()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_0620: Invalid comparison between I4 and F4
		//IL_04b6: Expected F4, but got I4
		//IL_0198: Expected Obj, but got I
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected I4, but got Unknown
		//IL_0266: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		Game instance = Game.Instance;
		CharacterModifierCollection modifiers = instance._modifiers;
		List<Upgrade> list = default;
		list._002Ector();
		List<PowerupType> list2 = default;
		list2._002Ector();
		object obj3 = obj + 16;
		Dictionary<PowerupType, CharacterModifier>.KeyCollection keys = mysteryPowerupCharacterModifiers.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
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
		int num;
		int num2 = default;
		int num3 = default;
		CharacterModifier result = default;
		int num5 = default;
		int num6 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj7;
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_03a0;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v125+40]");
								obj7 = 0;
								goto IL_0578;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v157+50]");
								if ((nint)0 != 0)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v169+51]");
									if ((nint)0 != 0)
									{
										continue;
									}
									obj7 = 22;
									goto IL_0578;
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
						goto IL_0311;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0311;
			IL_0311:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
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
					goto IL_03a0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				num = num3;
			}
			_ = 0;
			object obj10 = obj + 16;
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
			return result;
			IL_0578:
			int num4 = obj7 + num5;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag2 = (nint)0 != 1;
				num5 = num4;
				if (flag2)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				num5 = num4;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				num5 = num4;
			}
			goto IL_0311;
			IL_03a0:
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A2C3");
			num6 = UnityEngine.Random.Range(0, num5);
			num = 0;
			break;
		}
		float num8 = default;
		while (num < list._size)
		{
			Upgrade upgrade = list.get_Item(num);
			PowerupType powerupType = list2.get_Item(num);
			float num7 = ((powerupType == PowerupType.hoverboard) ? 22f : ((float)upgrade.weight));
			num8 += num7;
			if (!((float)num6 > num8))
			{
				PowerupType key = list2.get_Item(num);
				return mysteryPowerupCharacterModifiers.get_Item(key);
			}
			int num9 = num + 1;
			num = num9;
		}
		return modifiers.doubleCoins;
	}

	public static string GetRandomBoardIconName()
	{
		return "icon_random_board";
	}

	public static CharacterModifier GetRandomModifier()
	{
		CharacterModifier characterModifier;
		if (~(Globals.DEBUG_IS_HOVERBOARD_ALWAYS_REWARDED_FOR_MYSERY_POWERUP ? 1u : 0u) == 0)
		{
			Game instance = Game.Instance;
			CharacterModifierCollection modifiers = instance._modifiers;
			characterModifier = modifiers.hoverboard;
		}
		else
		{
			characterModifier = SelectRandomCharacterModifier();
		}
		Game instance2 = Game.Instance;
		CharacterModifierCollection modifiers2 = instance2._modifiers;
		bool flag = characterModifier == modifiers2.hoverboard;
		return characterModifier;
	}

	public static List<Hoverboards.BoardType> GetRandomBoardList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected Obj, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected Obj, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0630: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<Hoverboards.BoardType> list = default;
		list._002Ector();
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
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
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
				obj7 = obj;
				if (flag)
				{
					break;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
								if (obj8 != null)
								{
									goto IL_0288;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_0446;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
										if (obj9 == null)
										{
											continue;
										}
										goto IL_0288;
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
						goto IL_0455;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0455;
			IL_0446:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0455;
			IL_0288:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0446;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj10 != null)
				{
					continue;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					goto IL_0446;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v144+FC]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					if (num == 0)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0455;
			IL_0455:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj11 == obj12;
			bool flag3 = !flag2;
			object obj13 = obj14;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj13 = obj15;
			}
			_ = 0;
			object obj16 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj7 = 0;
			break;
		}
		object obj17 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDC");
		return list;
	}

	public static float GetRandomHoverboardDuration()
	{
		return 15f;
	}

	static MysteryPowerup()
	{
		//IL_002e: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, CharacterModifier>>>)+4] (should have been resolved before IL gen)");
		Game instance = Game.Instance;
		CharacterModifierCollection modifiers = instance._modifiers;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, CharacterModifier>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S5_v4+4] (should have been resolved before IL gen)");
		Game instance2 = Game.Instance;
		CharacterModifierCollection modifiers2 = instance2._modifiers;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, CharacterModifier>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S5_v9+4] (should have been resolved before IL gen)");
		Game instance3 = Game.Instance;
		CharacterModifierCollection modifiers3 = instance3._modifiers;
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, CharacterModifier>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ S5_v14+4] (should have been resolved before IL gen)");
		Game instance4 = Game.Instance;
		CharacterModifierCollection modifiers4 = instance4._modifiers;
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, CharacterModifier>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v109 @ S5_v19+4] (should have been resolved before IL gen)");
		Dictionary<PowerupType, CharacterModifier> dictionary = default;
		mysteryPowerupCharacterModifiers = dictionary;
		List<Hoverboards.BoardType> list = default;
		list._002Ector();
		excludedBoards = list;
	}
}
