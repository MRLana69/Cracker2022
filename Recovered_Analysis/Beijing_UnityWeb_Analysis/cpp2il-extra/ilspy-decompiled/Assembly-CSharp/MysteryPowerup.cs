using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using SYBO.Common.Utilities.Flags;
using SYBO.Subway;
using UnityEngine;

public class MysteryPowerup
{
	private const float randomBoardDuration = 15f;

	private const int randomBoardWeight = 22;

	private const string randomBoardIconName = "icon_random_board";

	private static readonly Dictionary<UpgradeType, CharacterModifier> mysteryPowerupCharacterModifiers;

	private static readonly List<Boards.BoardId> excludedBoards;

	private unsafe static CharacterModifier SelectRandomCharacterModifier()
	{
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected I, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01d6: Expected I, but got Obj
		//IL_01f1: Expected I, but got Obj
		//IL_0207: Expected Obj, but got I
		//IL_0249: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		nint num = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Hoverboard>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		nint num3 = (nint)(obj2 + 4);
		bool flag = (object)Hoverboard.instance == null;
		bool flag2 = !flag;
		CharacterModifier result = Hoverboard.instance;
		if (!flag2)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v49 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = typeof(Hoverboard);
			((IntPtr*)num3)->m_value = (void*)(nint)obj2;
			Type type = Type.internal_from_handle((IntPtr)num3);
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = ((UnityEngine.Object)(object)type).ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			nint num8 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<Hoverboard>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier = default;
			Hoverboard.instance = (Hoverboard)characterModifier;
			result = characterModifier;
		}
		return result;
	}

	public unsafe static string GetRandomBoardIconName()
	{
		//IL_000e: Expected Obj, but got Ref
		//IL_0aae: Expected Obj, but got Ref
		//IL_0ab7: Expected Obj, but got I4
		//IL_0acb: Expected Obj, but got Ref
		//IL_0ae7: Expected I, but got Obj
		//IL_0afd: Expected Obj, but got I
		//IL_0ca6: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_0cd2: Expected Obj, but got I4
		//IL_00c7: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I4
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected Obj, but got Unknown
		//IL_013f: Expected Obj, but got I4
		//IL_0152: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_0b93: Expected Obj, but got I4
		//IL_0193: Expected I, but got Obj
		//IL_03d8: Expected Obj, but got I
		//IL_08c4: Expected Obj, but got I
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Expected I4, but got Unknown
		//IL_0bec: Expected Obj, but got I4
		//IL_0209: Expected I, but got Obj
		//IL_021f: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I4
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Obj, but got Unknown
		//IL_024a: Expected I, but got Obj
		//IL_09dd: Expected F4, but got I4
		//IL_0a0d: Expected Obj, but got I
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected Obj, but got Unknown
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_028d: Expected Obj, but got I4
		//IL_0c12: Invalid comparison between F4 and I4
		//IL_0bbf: Expected Obj, but got I4
		//IL_0a20: Expected I, but got Obj
		//IL_0a36: Expected Obj, but got I
		//IL_031f: Expected I, but got Obj
		//IL_0a61: Expected I, but got Obj
		//IL_0362: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I4
		//IL_03c3: Expected Obj, but got I4
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected Obj, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected Obj, but got Unknown
		//IL_082c: Expected Obj, but got I4
		ref _0021_00210 reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 48));
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 24));
		obj2 = 0;
		_ = 0;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v238 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23 (System.Boolean)+8C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UpgradeType> list = default;
		list._002Ector();
		nint num3 = (nint)typeof(MysteryPowerup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v33 (Il2CppClass<MysteryPowerup>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(MysteryPowerup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v232 (Il2CppClass<MysteryPowerup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
		_0021_00210 flag = default;
		FlagsHelper.Set<T>(ref System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (T)flag);
		obj2 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+8]");
		_ = 0;
		int num5 = 0;
		object obj8 = default;
		object obj10 = default;
		object obj13 = default;
		object obj7;
		int num13 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj7 = 43;
			bool flag2 = obj8 == null;
			obj7 = 46;
			if (flag2)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj7 = 15;
			nint num6 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v139 (Il2CppClass<Info.Upgrades>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(Upgrades);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v222 (Il2CppClass<Info.Upgrades>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj7 = 15;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj7 = 18;
			object obj14;
			if ((nint)obj10 == 1)
			{
				nint num8 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S0_v177 (Il2CppClass<Hoverboard>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num9 = (nint)typeof(Hoverboard);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v214 (Il2CppClass<Hoverboard>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						obj7 = 22;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S0_v183+54]");
				if ((nint)0 != 0)
				{
					continue;
				}
				nint num10 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v188 (Il2CppClass<Hoverboard>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num11 = (nint)typeof(Hoverboard);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ S0_v205 (Il2CppClass<Hoverboard>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						obj7 = 22;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				obj7 = 33;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj13 != null)
				{
					continue;
				}
				obj14 = 22;
				object obj15 = 1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v150+34]");
				obj14 = 0;
				object obj15 = obj10;
			}
			int num12 = obj14 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			num13 = num12;
			obj7 = 41;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			num13 = num12;
			num5 = num12;
		}
		object obj16 = obj7 - 15;
		int max = default;
		if ((nint)obj7 != 15)
		{
			if ((nint)obj16 == 1 || (nint)obj16 == 2)
			{
				goto IL_0cd7;
			}
			if ((nint)obj16 != 3)
			{
				if ((nint)obj16 == 4 || (nint)obj16 == 5 || (nint)obj16 == 6)
				{
					goto IL_0cd7;
				}
				if ((nint)obj16 != 7)
				{
					if ((nint)obj16 == 8 || (nint)obj16 == 9 || (nint)obj16 == 10)
					{
						goto IL_0cd7;
					}
					if ((nint)obj16 != 11)
					{
						if ((nint)obj16 == 12 || (nint)obj16 == 13 || (nint)obj16 == 14 || (nint)obj16 == 15 || (nint)obj16 == 16 || (nint)obj16 == 17)
						{
							goto IL_0cd7;
						}
						if ((nint)obj16 != 18 && (nint)obj16 != 19)
						{
							if ((nint)obj16 == 20 || (nint)obj16 == 21 || (nint)obj16 == 22 || (nint)obj16 == 23 || (nint)obj16 == 24 || (nint)obj16 == 25)
							{
								goto IL_0cd7;
							}
							if ((nint)obj16 != 26)
							{
								if ((nint)obj16 != 27)
								{
									if ((nint)obj16 != 28)
									{
										if ((nint)obj16 != 29 && (nint)obj16 != 30 && (nint)obj16 == 31)
										{
											object obj17 = obj3 + 4;
											object obj18 = obj17 + 1;
											obj17 = obj18;
											object obj19 = obj18 << 2;
											object obj20 = obj3 + obj19;
											obj20 = 159;
											max = num5;
										}
										goto IL_0cd7;
									}
								}
								else
								{
									num5 = num13;
								}
							}
							else
							{
								num5 = num13;
							}
						}
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj21 = default;
		object obj22 = default;
		if (obj21 == obj22)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			max = num5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0cd7;
		IL_0cfc:
		int num14 = UnityEngine.Random.RandomRangeInt(0, max);
		int num15 = 0;
		List<Upgrade> list2 = default;
		float num17 = default;
		while (true)
		{
			if (num15 < list2._size)
			{
				Upgrade upgrade = list2.get_Item(num15);
				UpgradeType upgradeType = list.get_Item(num15);
				float num16 = ((upgradeType != UpgradeType.hoverboard) ? ((float)upgrade.weight) : 22f);
				num17 += num16;
				if (!(num17 < (float)num14))
				{
					break;
				}
				int num18 = num15 + 1;
				num15 = num18;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+1C]");
			return (string)0;
		}
		nint num19 = (nint)typeof(MysteryPowerup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ S0_v76 (Il2CppClass<MysteryPowerup>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num20 = (nint)typeof(MysteryPowerup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ S0_v84 (Il2CppClass<MysteryPowerup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UpgradeType key = list.get_Item(num15);
		return (string)(object)mysteryPowerupCharacterModifiers.get_Item(key);
		IL_0cd7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj24 = (nint)0 << 2;
			object obj25 = obj3 + obj24;
			if ((nint)obj25 == 159)
			{
				object obj26 = obj3 + 4;
				if ((nint)obj26 > -1)
				{
					object obj27 = obj26 + -1;
					obj26 = obj27;
				}
				goto IL_0cfc;
			}
		}
		object obj28 = default;
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0cfc;
	}

	public static CharacterModifier GetRandomModifier()
	{
		return (CharacterModifier)(object)"icon_random_board";
	}

	public static List<Boards.BoardId> GetRandomBoardList()
	{
		//IL_02e5: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0331: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I
		//IL_036d: Expected Obj, but got I
		//IL_037b: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_03c3: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_0298: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v75 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text;
		if (~(Globals.DEBUG_IS_HOVERBOARD_ALWAYS_REWARDED_FOR_MYSERY_POWERUP ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v63 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v71 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v68 (System.Boolean)+8C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v69+14]");
			text = (string)0;
		}
		else
		{
			nint num5 = (nint)typeof(MysteryPowerup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v52 (Il2CppClass<MysteryPowerup>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(MysteryPowerup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v58 (Il2CppClass<MysteryPowerup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			text = GetRandomBoardIconName();
		}
		nint num7 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v15 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v47 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v20 (System.Boolean)+8C]");
		object obj6 = 0;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v21+14]");
		if ((UnityEngine.Object)(object)text2 != (UnityEngine.Object)0)
		{
			nint num11 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v33 (Il2CppClass<Hoverboard>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num12 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v39 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier = SelectRandomCharacterModifier();
			_ = 1;
		}
		return (List<Boards.BoardId>)(object)text;
	}

	public static float GetRandomHoverboardDuration()
	{
		//IL_0044: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L0 (Il2CppMethodInfo)+38]");
		if ((nint)0 == 0)
		{
			return 1f;
		}
		nint num = default;
		object obj = num - -64;
		float num2 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L0 (Il2CppMethodInfo)+38]");
		return num2 / 0f;
	}

	public MysteryPowerup()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		_ = 200f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		VariableBool variableBool = default;
		variableBool.FireOnChange();
		object obj = this + 36;
		obj = variableBool;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
