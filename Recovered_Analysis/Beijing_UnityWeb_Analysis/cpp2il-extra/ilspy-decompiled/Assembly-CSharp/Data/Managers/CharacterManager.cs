using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Migration;
using Data.Save;
using InApp;
using Info;
using Kiloo;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace Data.Managers;

public static class CharacterManager
{
	private static readonly CultureInfo DATETIME_CULTUREINFO;

	private static List<KeyValuePair<Characters.CharacterId, Characters.Model>> _characterList;

	private static Action<Characters.CharacterId> m_characterUnlocked;

	private static Action<Characters.CharacterId> m_characterTokenCollected;

	private static Action<Characters.CharacterId> m_outfitUnlocked;

	public static event Action<Characters.CharacterId> characterUnlocked
	{
		add
		{
			Dictionary<UpgradeType, int> upgrades = InventorySave.upgrades;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterManager.m_characterUnlocked;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.CharacterManager>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<Characters.CharacterId> characterTokenCollected
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterManager.m_characterUnlocked;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.CharacterManager>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterManager.m_characterTokenCollected;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.CharacterManager>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<Characters.CharacterId> outfitUnlocked
	{
		add
		{
			Dictionary<Characters.CharacterId, int> collectedCharacterTokens = InventorySave.collectedCharacterTokens;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = CharacterManager.m_outfitUnlocked;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(CharacterManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(CharacterManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(CharacterManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.CharacterManager>)+5C]");
				object obj5 = (nint)0 + (nint)16;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public unsafe static bool IsTokenUseful(Characters.CharacterId characterId, CelebrationReward currentReward = null, bool isDoubling = false)
	{
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01f4: Expected I4, but got Obj
		//IL_0205: Expected I4, but got Obj
		//IL_0205: Expected Obj, but got I4
		//IL_01b5: Expected I4, but got Obj
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
		PlayerInfoMigrator._lastKeyRead = (Key)currentReward;
		string[] array2 = default;
		if (((Dictionary<Key, string>)characterId).TryGetValue((Key)currentReward, out reference))
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
				array2 = Globals.convertAllIntToString((int[])(object)array);
			}
		}
		return (byte)(int)array2 != 0;
	}

	public static void UnlockCharacter(Characters.CharacterId characterId)
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01b0: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = CharacterManager.m_characterTokenCollected;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)characterId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(CharacterManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(CharacterManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(CharacterManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.CharacterManager>)+5C]");
			object obj5 = (nint)0 + (nint)12;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	public static void LockCharacter(Characters.CharacterId characterId)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0219: Expected I, but got Obj
		//IL_022f: Expected Obj, but got I
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_02ba: Expected I, but got Obj
		//IL_02d0: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		Dictionary<Characters.CharacterId, int> collectedCharacterTokens = InventorySave.collectedCharacterTokens;
		bool flag = Kiloo.Common.Extensions.CollectionExtensions.AddDistinct((IList<Characters.CharacterId>)collectedCharacterTokens, characterId);
		bool isInitialized = AdSystemManager.isInitialized;
		((ScoreCounterSoundPlayer)isInitialized).PlayCoinSound(1f);
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v49 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(characterId);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault(model.name);
		string text2 = text.ToLowerInvariant();
		nint num5 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v23 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v45 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num7 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v39 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (CharacterManager.m_characterUnlocked != null)
		{
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S2_v8 (Il2CppMethodInfo)+18]");
			object obj5 = 0;
			object obj6 = obj5;
			object obj7 = obj6 & 0x3FFF;
			object obj8 = obj7 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v116 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	public static void CollectToken(Characters.CharacterId characterId, int amount)
	{
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_03ad: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_034c: Expected Obj, but got I
		//IL_035c: Expected Obj, but got I
		//IL_036c: Expected Obj, but got I
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		if (amount != 0)
		{
			CelebrationReward lastAddedReward = InventorySave.lastAddedReward;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v4 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v5+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v6+44]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S3_v5 (should have been resolved before IL gen)");
			object obj6 = default;
			if ((nint)obj6 <= -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S3_v14 (Il2CppMethodInfo)+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S3_v15+60]");
				object obj8 = 0;
				object obj9 = obj8;
				object obj10 = obj9 & 0x1FFF;
				object obj11 = obj10 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S4_v20 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0;
				_ = 1;
				_ = 0;
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S4_v22 (Il2CppMethodInfo)+C]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S4_v23+60]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v24+48]");
				object obj14 = 0;
				object obj15 = obj14 & 0x7FF;
				object obj16 = obj15 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v136 @ S5_v15 (should have been resolved before IL gen)");
				CelebrationReward lastAddedReward2 = InventorySave.lastAddedReward;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v27 (Il2CppMethodInfo)+C]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S4_v28+60]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S4_v29+48]");
				object obj19 = 0;
				object obj20 = obj19 & 0x7FF;
				object obj21 = obj20 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S5_v19 (should have been resolved before IL gen)");
				return;
			}
			CelebrationReward lastAddedReward3 = InventorySave.lastAddedReward;
			Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward3).get_Item((Boards.BoardId)characterId);
			if (dictionary != null)
			{
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S2_v15 (Il2CppMethodInfo)+C]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S2_v16+60]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v17+44]");
				object obj24 = 0;
				object obj25 = obj24 & 0x1FFF;
				object obj26 = obj25 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v163 @ S3_v11 (should have been resolved before IL gen)");
				object obj27 = default;
				if ((nint)obj27 > -1)
				{
					CelebrationReward lastAddedReward4 = InventorySave.lastAddedReward;
					Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary2 = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward4).get_Item((Boards.BoardId)characterId);
					BoardThemeData boardThemeData = dictionary2.get_Item((HoverboardThemes.ThemeIdentifier)amount);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					bool isOwned = boardThemeData.isOwned;
					bool isActive = boardThemeData.isActive;
					_ = 1;
					CelebrationReward lastAddedReward5 = InventorySave.lastAddedReward;
					Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary3 = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward5).get_Item((Boards.BoardId)characterId);
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S4_v13 (Il2CppMethodInfo)+C]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S4_v14+60]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S4_v15+48]");
					object obj30 = 0;
					object obj31 = obj30 & 0x7FF;
					object obj32 = obj31 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S5_v9 (should have been resolved before IL gen)");
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			_ = 1;
			_ = 0;
			CelebrationReward lastAddedReward6 = InventorySave.lastAddedReward;
			Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary4 = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward6).get_Item((Boards.BoardId)characterId);
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S4_v6 (Il2CppMethodInfo)+C]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S4_v7+60]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S4_v8+48]");
			object obj35 = 0;
			object obj36 = obj35 & 0x7FF;
			object obj37 = obj36 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v56 @ S5_v5 (should have been resolved before IL gen)");
		}
		else
		{
			SDebug.LogFormat("Trying to set an invalid theme as seen.", null);
		}
	}

	public unsafe static bool IsCharacterOwned(Characters.CharacterId characterId)
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected I4, but got Unknown
		//IL_0150: Expected Obj, but got I4
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01c3: Expected I4, but got Obj
		//IL_01c3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I4
		object obj = default;
		bool flag = (byte)(obj + 4) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		obj = characterId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "hoverboard_expiretime_" + text2;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v47 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)text);
		if (outfitForCharacter != null)
		{
			nint num3 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v30 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v43 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath2).RestoreNonConsumablePurchases((string[])(object)text, flag) && (string)((bool*)(flag ? 1 : 0))->m_value != "disabled")
			{
				return true;
			}
		}
		return false;
	}

	private static bool IsCollectionComplete(Characters.CharacterId characterId)
	{
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v35 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ALL_CHARS ? 1u : 0u) == 0)
		{
			return true;
		}
		nint num3 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v28 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(characterId);
		if (model.unlockType != PurchaseData.UnlockType.AlwaysUnlocked)
		{
			Dictionary<Characters.CharacterId, int> collectedCharacterTokens = InventorySave.collectedCharacterTokens;
			return ((List<Characters.CharacterId>)(object)collectedCharacterTokens).Contains(characterId);
		}
		return true;
	}

	public unsafe static int GetCollectedTokens(Characters.CharacterId characterId)
	{
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		ref int reference = ref *(int*)null;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v44 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ALL_CHARS ? 1u : 0u) == 0)
		{
			return 1;
		}
		nint num3 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v37 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(characterId);
		if (model.unlockType != PurchaseData.UnlockType.AlwaysUnlocked)
		{
			List<Boards.BoardId> unlockedBoards = InventorySave.unlockedBoards;
			if (((Dictionary<Characters.CharacterId, int>)(object)unlockedBoards).TryGetValue(characterId, out reference))
			{
				return (reference >= model.Price) ? 1 : 0;
			}
			return 0;
		}
		return 1;
	}

	public unsafe static int GetOutfitIndex(Characters.CharacterId characterId)
	{
		ref int reference = ref *(int*)null;
		List<Boards.BoardId> unlockedBoards = InventorySave.unlockedBoards;
		if (((Dictionary<Characters.CharacterId, int>)(object)unlockedBoards).TryGetValue(characterId, out reference))
		{
			return reference;
		}
		return 0;
	}

	public static void SetOutfitSelectionIndex(Characters.CharacterId character, int outfitIndex)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_030e: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_00fb: Expected I, but got Obj
		//IL_0150: Expected Obj, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0191: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I
		//IL_01d2: Expected I, but got Obj
		object obj = character;
		List<Boards.BoardId> unlockedBoards = InventorySave.unlockedBoards;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		bool flag = (nint)obj7 > -1;
		List<Boards.BoardId> unlockedBoards2 = InventorySave.unlockedBoards;
		if (flag)
		{
			int num2 = ((Dictionary<Characters.CharacterId, int>)(object)unlockedBoards2).get_Item(character);
			object obj8 = outfitIndex + num2;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S4_v16 (Il2CppMethodInfo)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v17+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v18+48]");
			object obj11 = 0;
			object obj12 = obj11 & 0x7FF;
			object obj13 = obj12 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v81 @ S5_v11 (should have been resolved before IL gen)");
		}
		else
		{
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S4_v10 (Il2CppMethodInfo)+C]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S4_v11+60]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S4_v12+48]");
			object obj16 = 0;
			object obj17 = obj16 & 0x7FF;
			object obj18 = obj17 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v66 @ S5_v5 (should have been resolved before IL gen)");
		}
		nint num5 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v15 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num6 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v50 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (CharacterManager.m_characterTokenCollected != null)
		{
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S2_v12 (Il2CppMethodInfo)+18]");
			object obj20 = 0;
			object obj21 = obj20;
			object obj22 = obj21 & 0x3FFF;
			object obj23 = obj22 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v127 @ S3_v12 (should have been resolved before IL gen)");
		}
		if (GetCollectedTokens(character) == 0)
		{
			return;
		}
		nint num8 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v30 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num9 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v45 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LockCharacter(character);
		_0021_00210[] array = (_0021_00210[])(object)UnityEngine.Object.FindObjectsOfType<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public static void UnlockOutfit(Characters.CharacterId character, int outfitIndex)
	{
		//IL_00d5: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		Dictionary<Characters.CharacterId, List<int>> unlockedOutfits = InventorySave.unlockedOutfits;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			Dictionary<Characters.CharacterId, List<int>> unlockedOutfits2 = InventorySave.unlockedOutfits;
			bool flag = ((Dictionary<Characters.CharacterId, int>)(object)unlockedOutfits2).Remove(character);
		}
		if (outfitIndex > 0)
		{
			Dictionary<Characters.CharacterId, List<int>> unlockedOutfits3 = InventorySave.unlockedOutfits;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S5_v5 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S5_v6+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S5_v7+48]");
			object obj9 = 0;
			object obj10 = obj9 & 0x7FF;
			object obj11 = obj10 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v56 @ S6_v5 (should have been resolved before IL gen)");
		}
	}

	public static bool IsOutfitUnlocked(Characters.CharacterId character, int outfitIndex)
	{
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		if (outfitIndex != 0)
		{
			CelebrationReward lastAddedReward = InventorySave.lastAddedReward;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v3 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v5+44]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S3_v5 (should have been resolved before IL gen)");
			object obj6 = default;
			if ((nint)obj6 > -1)
			{
				CelebrationReward lastAddedReward2 = InventorySave.lastAddedReward;
				Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData> dictionary = ((Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>>)(object)lastAddedReward2).get_Item((Boards.BoardId)character);
				if (dictionary != null)
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v12 (Il2CppMethodInfo)+C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S2_v13+60]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S2_v14+44]");
					object obj9 = 0;
					object obj10 = obj9 & 0x1FFF;
					object obj11 = obj10 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v84 @ S3_v11 (should have been resolved before IL gen)");
					object obj12 = default;
					if ((nint)obj12 > -1)
					{
						BoardThemeData boardThemeData = dictionary.get_Item((HoverboardThemes.ThemeIdentifier)outfitIndex);
						return boardThemeData.hasBeenSeen;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public unsafe static bool HasCharacterBeenSeen(Characters.CharacterId characterId)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		ref int reference = ref *(int*)null;
		Dictionary<Characters.CharacterId, List<int>> unlockedOutfits = InventorySave.unlockedOutfits;
		bool result;
		if (((Dictionary<Characters.CharacterId, int>)(object)unlockedOutfits).TryGetValue(characterId, out reference))
		{
			nint num = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v17 (Il2CppClass<Info.Outfits>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Outfits);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v32 (Il2CppClass<Info.Outfits>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (Outfits.HasCharacter(characterId))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22 (System.Boolean)+C]");
				bool flag = (nint)0 < (nint)reference;
				bool flag2 = !flag;
				result = (byte)reference != 0;
				if (!flag2)
				{
					result = false;
				}
			}
			else
			{
				result = false;
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	public static void MarkCharacterAsSeen(Characters.CharacterId characterId)
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01b0: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = CharacterManager.m_outfitUnlocked;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)characterId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(CharacterManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(CharacterManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(CharacterManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Data.Managers.CharacterManager>)+5C]");
			object obj5 = (nint)0 + (nint)16;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	private unsafe static DateTime DefaultExpirationDateForCharacter(Characters.CharacterId cId)
	{
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected I4, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_04ce: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected VT, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_0538: Expected I4, but got Obj
		//IL_0538: Expected I4, but got Obj
		//IL_0203: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0618: Expected I, but got Obj
		//IL_062e: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0658: Expected Obj, but got VT
		//IL_0661: Expected Obj, but got VT
		//IL_066e: Expected I8, but got Obj
		//IL_0669: Expected native int or pointer, but got VT
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_0244: Expected I, but got Obj
		//IL_036c: Expected I, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_0291: Expected I, but got Obj
		//IL_00e2: Expected I, but got Obj
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_05ab: Expected I, but got Obj
		//IL_05c1: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_03ad: Expected I, but got Obj
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected Obj, but got Unknown
		//IL_0767: Expected Obj, but got VT
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected Obj, but got Unknown
		//IL_077e: Expected Obj, but got VT
		//IL_078b: Expected I8, but got Obj
		//IL_0786: Expected native int or pointer, but got VT
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got Unknown
		//IL_0175: Expected I, but got Obj
		//IL_018b: Expected Obj, but got I
		//IL_031f: Expected I, but got Obj
		//IL_07fa: Expected I, but got Obj
		//IL_0810: Expected Obj, but got I
		//IL_03fa: Expected I, but got Obj
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_071e: Expected Obj, but got VT
		//IL_0726: Expected Obj, but got VT
		//IL_0733: Expected I8, but got Obj
		//IL_072e: Expected native int or pointer, but got VT
		//IL_0748: Expected Ref, but got VT
		//IL_074c: Expected VT, but got I8
		//IL_01b6: Expected I, but got Obj
		//IL_045d: Expected I, but got Obj
		object obj = default;
		bool flag = (byte)(obj - -64) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 56);
		formatProvider = (IFormatProvider)cId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "hoverboard_expiretime_" + text2;
		DateTime utcNow = CDateTime.UtcNow;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v178 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime dateTime = (DateTime)(obj + 48);
		object obj3 = obj + 40;
		object obj4 = obj + 32;
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)text);
		DateTime dateTime2;
		if (outfitForCharacter != null)
		{
			nint num3 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v150 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v174 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			bool flag2 = ((InAppManager)(object)saveDataPath2).RestoreNonConsumablePurchases((string[])(object)text, flag);
			bool flag3 = !flag2;
			dateTime2 = utcNow;
			if (!flag3)
			{
				if ((string)((bool*)(flag ? 1 : 0))->m_value != "disabled")
				{
					DateTime utcNow2 = CDateTime.UtcNow;
					dateTime2 = utcNow2;
				}
				else
				{
					nint num5 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v162 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num6 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v168 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					DateTime dateTime3 = BoardManager.BoardStartAvailabilityDate((Boards.BoardId)cId);
					dateTime2 = dateTime3;
				}
			}
		}
		else
		{
			nint num7 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v81 (Il2CppClass<Info.Boards>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v143 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)cId);
			nint num9 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v91 (Il2CppClass<System.DateTime>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num10 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v137 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = board.defaultExpirationTime;
			obj4 = DateTime.MinValue;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj3;
			formatProvider = (IFormatProvider)obj4;
			long num11 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
			object obj9 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
			DateTime dateTime4;
			if (num11 != (long)obj9)
			{
				nint num12 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v122 (Il2CppClass<Info.Boards>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num13 = (nint)typeof(Boards);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v131 (Il2CppClass<Info.Boards>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Boards.Board board2 = Boards.boardData.get_Item((Boards.BoardId)cId);
				dateTime4 = board2.defaultExpirationTime;
			}
			else
			{
				nint num14 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v108 (Il2CppClass<System.DateTime>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num15 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v115 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				dateTime4 = DateTime.MaxValue;
			}
			dateTime2 = dateTime4;
		}
		nint num16 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v36 (Il2CppClass<System.DateTime>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num17 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v74 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj13 = obj + 24;
		obj13 = dateTime2;
		object obj14 = obj + 16;
		obj14 = DateTime.MinValue;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj13;
		formatProvider = (IFormatProvider)obj14;
		long num18 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
		object obj15 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
		if (num18 == (long)obj15)
		{
			DateTime utcNow3 = CDateTime.UtcNow;
			dateTime2 = utcNow3;
		}
		DateTime utcNow4 = CDateTime.UtcNow;
		nint num19 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v57 (Il2CppClass<System.DateTime>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num20 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v68 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj17 = obj + 8;
		obj17 = dateTime2;
		obj = utcNow4;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj17;
		formatProvider = (IFormatProvider)obj;
		return (DateTime)((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
	}

	public static DateTime CharacterExpirationDate(Characters.CharacterId characterId)
	{
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_0251: Expected I, but got Obj
		//IL_0267: Expected Obj, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_019b: Expected Obj, but got VT
		//IL_01a4: Expected Obj, but got VT
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0100: Expected I, but got Obj
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v60 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(characterId);
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<System.DateTime>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v54 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 8;
		obj3 = model.defaultExpirationDate;
		obj4 = DateTime.MinValue;
		object obj5 = obj4 + 16;
		obj5 = obj3;
		object obj6 = obj4 + 24;
		obj6 = obj4;
		object obj7 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		object obj8 = obj6 & 0x3FFFFFFFFFFFFFFFL;
		if (obj7 != obj8)
		{
			return model.defaultExpirationDate;
		}
		nint num5 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v39 (Il2CppClass<System.DateTime>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v46 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return DateTime.MaxValue;
	}

	public unsafe static DateTime CharacterStartAvailabilityDate(Characters.CharacterId characterId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected I4, but got Unknown
		//IL_0576: Expected I, but got Obj
		//IL_058c: Expected Obj, but got I
		//IL_06fd: Expected I4, but got Obj
		//IL_070f: Expected I, but got Obj
		//IL_0725: Expected Obj, but got I
		//IL_05b7: Expected I, but got Obj
		//IL_05cd: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0758: Expected I4, but got Obj
		//IL_0758: Expected I4, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_04be: Expected I, but got Obj
		//IL_04d4: Expected Obj, but got I
		//IL_00bb: Expected I, but got Obj
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_04ff: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_019b: Expected I4, but got Obj
		//IL_019b: Expected Obj, but got I4
		//IL_01ca: Expected I, but got Obj
		//IL_01e0: Expected Obj, but got I
		//IL_0285: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_020b: Expected I, but got Obj
		//IL_0677: Expected VT, but got Obj
		//IL_02c6: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		bool flag = (byte)(obj2 + 8) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v182 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(characterId);
		string text = string.ConcatArray((string[])(object)"character_expiretime_", (int)model.modelName);
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v29 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v176 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v37 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v172 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)text);
		if (outfitForCharacter != null)
		{
			nint num7 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v59 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v168 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath2).RestoreNonConsumablePurchases((string[])(object)text, flag))
			{
				if (((string)((bool*)(flag ? 1 : 0))->m_value).get_Chars((int)"disabled") != '\0')
				{
					nint num9 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v76 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num10 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v157 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					nint num11 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v132 (Il2CppClass<System.DateTime>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num12 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v147 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
					object obj10 = default;
					object obj9 = obj10 << 32;
					object obj11 = default;
					DateTime dateTime = (DateTime)(obj11 | obj9);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj13 = default;
					object obj12 = obj13;
					object obj14 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj15 = default;
					if (obj14 == obj15)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj17 = default;
						object obj16 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj19 = default;
						object obj18 = obj19;
					}
					else
					{
						object obj18 = obj12;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					DateTime result = default;
					return result;
				}
				return DateTime.MinValue;
			}
			return DateTime.MinValue;
		}
		nint num13 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v48 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num14 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v54 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return CharacterExpirationDate(characterId);
	}

	public static bool IsCharacterAvailable(Characters.CharacterId characterId)
	{
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v44 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(characterId);
		if (~(model.isNewInThisUpdate ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v40 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Boards.BoardId, bool> hasBoardBeenSeen = UserSave.hasBoardBeenSeen;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v5 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v6+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S2_v7+44]");
			object obj5 = 0;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v61 @ S3_v5 (should have been resolved before IL gen)");
			object obj8 = default;
			if ((nint)obj8 > -1)
			{
				nint num6 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v29 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num7 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v36 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<Boards.BoardId, bool> hasBoardBeenSeen2 = UserSave.hasBoardBeenSeen;
				return ((Dictionary<Characters.CharacterId, bool>)(object)hasBoardBeenSeen2).get_Item(characterId);
			}
			return false;
		}
		return true;
	}

	public unsafe static TimeSpan CharacterExpirationTimespan(Characters.CharacterId characterId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected I4, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_0594: Expected I, but got Obj
		//IL_05aa: Expected Obj, but got I
		//IL_0769: Expected I4, but got Obj
		//IL_077b: Expected I, but got Obj
		//IL_0791: Expected Obj, but got I
		//IL_05d5: Expected I, but got Obj
		//IL_05eb: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected Obj, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Expected Obj, but got Unknown
		//IL_07ee: Expected I4, but got Obj
		//IL_07ee: Expected I4, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_042e: Expected I, but got Obj
		//IL_0444: Expected Obj, but got I
		//IL_00bb: Expected I, but got Obj
		//IL_06cf: Expected Obj, but got VT
		//IL_06d8: Expected Obj, but got VT
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected Obj, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected Obj, but got Unknown
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_04ce: Expected I, but got Obj
		//IL_04e4: Expected Obj, but got I
		//IL_046f: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_050f: Expected I, but got Obj
		//IL_019b: Expected I4, but got Obj
		//IL_019b: Expected Obj, but got I4
		//IL_01ca: Expected I, but got Obj
		//IL_01e0: Expected Obj, but got I
		//IL_0285: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_020b: Expected I, but got Obj
		//IL_0695: Expected VT, but got Obj
		//IL_02c6: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		bool flag = (byte)(obj2 + 40) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		object obj3 = obj2 + 32;
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v205 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(characterId);
		string text = string.ConcatArray((string[])(object)"character_starttime_", (int)model.modelName);
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v30 (Il2CppClass<System.DateTime>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v199 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v38 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v195 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 24;
		object obj8 = obj2 + 16;
		object obj9 = obj2 + 8;
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)text);
		if (outfitForCharacter != null)
		{
			nint num7 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v95 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num8 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v191 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath2).RestoreNonConsumablePurchases((string[])(object)text, flag))
			{
				if (((string)((bool*)(flag ? 1 : 0))->m_value).get_Chars((int)"disabled") != '\0')
				{
					nint num9 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v112 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num10 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v180 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					nint num11 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v155 (Il2CppClass<System.DateTime>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num12 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v170 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
					object obj14 = default;
					object obj13 = obj14 << 32;
					object obj15 = default;
					TimeSpan timeSpan = (TimeSpan)(obj15 | obj13);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj17 = default;
					object obj16 = obj17;
					object obj18 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj19 = default;
					if (obj18 == obj19)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj21 = default;
						object obj20 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj23 = default;
						object obj22 = obj23;
					}
					else
					{
						object obj22 = obj16;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					TimeSpan result = default;
					return result;
				}
				return (TimeSpan)DateTime.MinValue;
			}
			return (TimeSpan)DateTime.MinValue;
		}
		nint num13 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v57 (Il2CppClass<System.DateTime>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num14 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v88 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj9 = model.defaultStartDate;
		obj2 = DateTime.MinValue;
		obj8 = obj9;
		obj7 = obj2;
		object obj25 = obj8 & 0x3FFFFFFFFFFFFFFFL;
		object obj26 = obj7 & 0x3FFFFFFFFFFFFFFFL;
		if (obj25 != obj26)
		{
			return (TimeSpan)model.defaultStartDate;
		}
		nint num15 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v73 (Il2CppClass<System.DateTime>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num16 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v80 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (TimeSpan)DateTime.MinValue;
	}

	public unsafe static List<KeyValuePair<Characters.CharacterId, Characters.Model>> GetAvailableCharacters(bool forceRefresh = false)
	{
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected I4, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected Obj, but got Unknown
		//IL_065b: Expected Obj, but got I4
		//IL_0669: Expected I, but got Obj
		//IL_067f: Expected Obj, but got I
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected Obj, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected Obj, but got Unknown
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected Obj, but got Unknown
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected Obj, but got Unknown
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I4
		//IL_0623: Expected Obj, but got I4
		//IL_014b: Expected I, but got Obj
		//IL_019d: Expected I4, but got Obj
		//IL_01af: Expected I, but got Obj
		//IL_01c5: Expected Obj, but got I
		//IL_06f8: Expected I4, but got Obj
		//IL_06f8: Expected I4, but got Obj
		//IL_0727: Expected I, but got Obj
		//IL_073d: Expected Obj, but got I
		//IL_01f0: Expected I, but got Obj
		//IL_023d: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I
		//IL_07a4: Expected I, but got Obj
		//IL_07ba: Expected Obj, but got I
		//IL_02f5: Expected I, but got Obj
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_027e: Expected I, but got Obj
		//IL_047f: Expected I, but got Obj
		//IL_0495: Expected Obj, but got I
		//IL_0432: Expected I, but got Obj
		//IL_02d0: Expected Obj, but got I4
		//IL_07df: Expected Obj, but got VT
		//IL_07e7: Expected Obj, but got VT
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected Obj, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected Obj, but got Unknown
		//IL_03f5: Expected Obj, but got I4
		//IL_0416: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got I4
		//IL_04c0: Expected I, but got Obj
		//IL_0508: Expected Obj, but got I4
		//IL_0553: Expected I, but got Obj
		//IL_0569: Expected Obj, but got I
		//IL_0875: Expected Obj, but got VT
		//IL_087d: Expected Obj, but got VT
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_05fd: Expected Obj, but got I4
		//IL_0594: Expected I, but got Obj
		//IL_08f3: Expected Obj, but got I4
		//IL_05dc: Expected Obj, but got I4
		object obj = default;
		bool flag = (byte)(obj + 48) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		object obj2 = obj + 52;
		obj2 = 0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v168 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj + 40;
		object obj5 = obj + 32;
		object obj6 = obj + 24;
		object obj7 = obj + 16;
		object obj8 = obj + 8;
		List<KeyValuePair<Characters.CharacterId, Characters.Model>> result;
		if (~(Globals.DEBUG_ALL_CHARS ? 1u : 0u) == 0)
		{
			result = (List<KeyValuePair<Characters.CharacterId, Characters.Model>>)1;
		}
		else
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v32 (Il2CppClass<Globals>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v161 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_DISPLAY_ALL_CHARS ? 1u : 0u) == 0)
			{
				result = (List<KeyValuePair<Characters.CharacterId, Characters.Model>>)1;
			}
			else
			{
				nint num5 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v40 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num6 = (nint)typeof(Characters);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v154 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Characters.Model model = Characters.characterData.get_Item(forceRefresh ? Characters.CharacterId.tricky : Characters.CharacterId.slick);
				if (~(model.hasOnlineSettings ? 1u : 0u) == 0)
				{
					string text = string.ConcatArray((string[])(object)"character_expiretime_", (int)model.modelName);
					nint num7 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v54 (Il2CppClass<Info.OnlineSettings>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num8 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v150 (Il2CppClass<Info.OnlineSettings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string saveDataPath = OnlineSettings.GetSaveDataPath();
					Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)text);
					if (outfitForCharacter != null)
					{
						nint num9 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v138 (Il2CppClass<Info.OnlineSettings>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 != null)
						{
							nint num10 = (nint)typeof(OnlineSettings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v146 (Il2CppClass<Info.OnlineSettings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string saveDataPath2 = OnlineSettings.GetSaveDataPath();
						if (((InAppManager)(object)saveDataPath2).RestoreNonConsumablePurchases((string[])(object)text, flag))
						{
							bool flag2 = (string)((bool*)(flag ? 1 : 0))->m_value == "disabled";
							result = null;
							if (!flag2)
							{
								goto IL_0791;
							}
						}
					}
					nint num11 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v63 (Il2CppClass<SSEventsManagerController>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num12 = (nint)typeof(SSEventsManagerController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v133 (Il2CppClass<SSEventsManagerController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string flurryUserId = Flurry.flurryUserId;
					if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj15 = default;
						object obj14 = obj15 - 3;
						if ((nint)obj15 == 3 || ((nint)obj14 != 1 && (nint)obj14 != 2 && (nint)obj14 != 3 && (nint)obj14 == 4))
						{
							obj2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
							object obj16 = default;
							bool flag3 = (nint)obj16 == (forceRefresh ? 1 : 0);
							result = (List<KeyValuePair<Characters.CharacterId, Characters.Model>>)1;
							if (flag3)
							{
								goto IL_0791;
							}
						}
					}
					nint num13 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v72 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num14 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v124 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					TimeSpan timeSpan = CharacterExpirationTimespan(forceRefresh ? Characters.CharacterId.tricky : Characters.CharacterId.slick);
					DateTime dateTime = CharacterStartAvailabilityDate(forceRefresh ? Characters.CharacterId.tricky : Characters.CharacterId.slick);
					DateTime utcNow = CDateTime.UtcNow;
					nint num15 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v83 (Il2CppClass<System.DateTime>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					if (obj18 != null)
					{
						nint num16 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v120 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj6 = dateTime;
					obj7 = utcNow;
					obj5 = obj6;
					obj4 = obj7;
					object obj19 = obj5 & 0x3FFFFFFFFFFFFFFFL;
					object obj20 = obj4 & 0x3FFFFFFFFFFFFFFFL;
					object obj21;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
					{
						obj21 = 1;
					}
					else
					{
						bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
						object obj22 = (flag4 ? 1u : 0u) << 31;
						obj21 = obj22 >> 31;
					}
					if ((nint)obj21 >= 1)
					{
						DateTime utcNow2 = CDateTime.UtcNow;
						nint num17 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S0_v102 (Il2CppClass<System.DateTime>)+BA]");
						object obj23 = (nint)0 & (nint)0x200;
						if (obj23 != null)
						{
							nint num18 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v111 (Il2CppClass<System.DateTime>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj8 = timeSpan;
						obj = utcNow2;
						obj5 = obj8;
						obj4 = obj;
						object obj24 = obj5 & 0x3FFFFFFFFFFFFFFFL;
						object obj25 = obj4 & 0x3FFFFFFFFFFFFFFFL;
						object obj26;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25))
						{
							obj26 = 1;
						}
						else
						{
							bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25);
							object obj27 = (flag5 ? 1u : 0u) << 31;
							obj26 = obj27 >> 31;
						}
						bool flag6 = (nint)obj26 <= -1;
						result = (List<KeyValuePair<Characters.CharacterId, Characters.Model>>)1;
						if (flag6)
						{
							goto IL_0791;
						}
					}
					result = null;
				}
				else
				{
					result = (List<KeyValuePair<Characters.CharacterId, Characters.Model>>)1;
				}
			}
		}
		goto IL_0791;
		IL_0791:
		return result;
	}

	private unsafe static List<KeyValuePair<Characters.CharacterId, Characters.Model>> GenerateAvailableCharacters()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04b1: Expected Obj, but got I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_04d4: Expected Obj, but got I4
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_04eb: Expected Obj, but got I4
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_050e: Expected Obj, but got I4
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_035b: Expected Obj, but got I4
		//IL_03e2: Expected Obj, but got I
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected Obj, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0179: Expected Obj, but got I4
		//IL_020d: Expected Obj, but got I
		//IL_02a2: Expected Obj, but got I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4573E9]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 96;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 32;
		obj5 = 0;
		object obj6 = obj2 + 72;
		obj6 = 0;
		_ = 0;
		_ = 0;
		object obj7 = obj2 + 24;
		obj7 = 0;
		object obj8 = obj2 - -64;
		obj8 = obj;
		_ = -1;
		CelebrationReward lastAddedReward = InventorySave.lastAddedReward;
		KeyValuePair<_00210, _00211> current = (KeyValuePair<_00210, _00211>)((Dictionary<TKey, TValue>.Enumerator*)lastAddedReward)->Current;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		List<KeyValuePair<Characters.CharacterId, Characters.Model>> list = null;
		object obj9 = default;
		object obj10 = default;
		object obj19 = default;
		object obj21 = default;
		object obj23 = default;
		object obj24 = default;
		List<KeyValuePair<Characters.CharacterId, Characters.Model>> result = default;
		object obj25 = default;
		object obj26 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
				_ = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj10 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v190+8]");
					if ((nint)0 != 0)
					{
						List<KeyValuePair<Characters.CharacterId, Characters.Model>> list2 = (List<KeyValuePair<Characters.CharacterId, Characters.Model>>)(list + 1);
						list = list2;
					}
				}
				object obj11 = obj8 + 4;
				object obj12 = obj11 + 1;
				obj11 = obj12;
				object obj13 = obj12 << 2;
				object obj14 = obj8 + obj13;
				obj14 = 90;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+4]");
					object obj15 = (nint)0 << 2;
					object obj16 = obj8 + obj15;
					if ((nint)obj16 == 90)
					{
						object obj17 = obj8 + 4;
						if ((nint)obj17 > -1)
						{
							object obj18 = obj17 + -1;
							obj17 = obj18;
						}
						continue;
					}
				}
				if (obj19 == null)
				{
					obj19 = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj20 = obj21;
				object obj22 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj20 == obj24)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					result = list;
					obj25 = obj26;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				break;
			}
			object obj27 = obj8 + 4;
			object obj28 = obj27 + 1;
			obj27 = obj28;
			object obj29 = obj28 << 2;
			object obj30 = obj8 + obj29;
			obj30 = 115;
			result = list;
			obj25 = obj19;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+4]");
			object obj31 = (nint)0 << 2;
			object obj32 = obj8 + obj31;
			if ((nint)obj32 == 115)
			{
				object obj33 = obj8 + 4;
				if ((nint)obj33 > -1)
				{
					object obj34 = obj33 + -1;
					obj33 = obj34;
				}
				goto IL_065e;
			}
		}
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_065e;
		IL_065e:
		return result;
	}

	static CharacterManager()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_003f: Expected I, but got Obj
		//IL_0055: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = default;
		CultureInfo.CheckDomainSafetyObject(obj, (object)"da-DK");
		BoardManager.ONLINESETTINGS_DATETIME_CULTUREINFO = (CultureInfo)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v15 (Il2CppClass<Data.Managers.BoardManager>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		object obj3 = default;
		obj2 = obj3;
		nint num2 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v19 (Il2CppClass<Data.Managers.BoardManager>)+5C]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = 0;
		nint num3 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v23 (Il2CppClass<Data.Managers.BoardManager>)+5C]");
		object obj5 = (nint)0 + (nint)12;
		obj5 = 0;
		Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
		Boards.BoardId? eventBoardType = BoardManager.GetEventBoardType();
	}
}
