using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using WordHunt;

public class DailyLetterPickupManager : MonoBehaviour
{
	public const char NO_LETTER = '\0';

	private char letter;

	private HashSet<DailyLetterPickup> pickups;

	private static DailyLetterPickupManager instance;

	public char Letter
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			char c = default;
			object obj = c + 16;
			obj = this;
			return c;
		}
	}

	public static DailyLetterPickupManager Instance
	{
		get
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_00a8: Expected Obj, but got I4
			if (CharacterLetterPickup.IsCharacterLetterPickupSpawnable())
			{
				nint num = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v10 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v21 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string flurryUserId = Flurry.flurryUserId;
				CharacterNameEventManager typeOfActiveEventManager = ((SSEventsManagerController)(object)flurryUserId).GetTypeOfActiveEventManager<CharacterNameEventManager>();
				if (typeOfActiveEventManager != null)
				{
					int amountOfCollectedLetters = typeOfActiveEventManager.GetAmountOfCollectedLetters();
					return (DailyLetterPickupManager)amountOfCollectedLetters;
				}
				return null;
			}
			return null;
		}
	}

	private void NotifyPickups()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public void InitializePickup(DailyLetterPickup pickup)
	{
		//IL_0081: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DailyLetterPickupManager)+16]");
		int num = (int)(-65);
		bool flag = num > -1;
		HashSet<DailyLetterPickup> hashSet = pickups;
		bool flag2 = num < (nint)hashSet._slots;
		object obj = flag & flag2;
		if (obj != null)
		{
			Mesh sharedMesh = ((List<Mesh>)(object)pickups).get_Item(num);
			((SkinnedMeshRenderer)letter).sharedMesh = sharedMesh;
		}
	}

	public void UpdateLetter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0242: Expected Obj, but got I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10CBB");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v74 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v88 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 68)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				return;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public DailyLetterPickupManager()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = WordHuntManager.IsDailyWordComplete();
		letter = (flag ? '\u0001' : '\0');
		UpdateLetter();
	}
}
