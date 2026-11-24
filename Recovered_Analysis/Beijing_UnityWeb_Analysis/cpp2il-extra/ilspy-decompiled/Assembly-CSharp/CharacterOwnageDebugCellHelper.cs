using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Managers;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;

public class CharacterOwnageDebugCellHelper : MonoBehaviour
{
	private UILabel _title;

	private UILabel _description;

	private GameObject _offIcon;

	private GameObject _onIcon;

	private bool _currentIconState;

	private KeyValuePair<Characters.CharacterId, Characters.Model> _character;

	public void Init(KeyValuePair<Characters.CharacterId, Characters.Model> character)
	{
		//IL_000a: Expected Obj, but got VT
		_title = (UILabel)character;
	}

	public void ToggleActive()
	{
		CancelInvoke();
	}

	public CharacterOwnageDebugCellHelper()
	{
		//IL_0109: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0161: Expected Obj, but got I
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_0069: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected I4, but got Unknown
		//IL_01f1: Expected I4, but got Obj
		//IL_01ff: Expected I, but got Obj
		//IL_0215: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_007c: Expected I, but got Obj
		bool currentIconState = _currentIconState;
		bool currentIconState2 = (byte)((currentIconState ? 1u : 0u) ^ 1u) != 0;
		_currentIconState = currentIconState2;
		bool currentIconState3 = _currentIconState;
		string text = (string)((currentIconState3 ? 1 : 0) ^ 1);
		_offIcon.tag = text;
		bool currentIconState4 = _currentIconState;
		_onIcon.tag = (string)currentIconState4;
		object obj = this + 32;
		object obj2 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v17+4]");
		object obj3 = 0;
		bool currentIconState5 = _currentIconState;
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v11 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v17 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = ((!currentIconState5) ? ((object)(-1)) : ((object)1));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v18+10]");
		int outfitIndex = obj5 * 0;
		CharacterManager.SetOutfitSelectionIndex((Characters.CharacterId)obj, outfitIndex);
		nint num3 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v16 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v22 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreen.forceRefreshOnCharacterScreen = true;
	}
}
