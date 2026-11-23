using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.Screens;

public class MeScreen : UIScreen
{
	private enum Screen
	{
		Character,
		Board,
		Award,
		None
	}

	private Button CharacterButton;

	private Button BoardButton;

	private Button AwardButton;

	private CharacterScreen CharacterScreen;

	private CharacterScreen _CharacterScreen;

	private BoardScreen BoardScreen;

	private BoardScreen _BoardScreen;

	private AwardsScreen AwardsScreen;

	private AwardsScreen _AwardsScreen;

	private Screen screen;

	private Screen CurrentScreen;

	private Transform parent;

	public GameObject overlayParent;

	public GameObject characterScrollAnchor;

	public GameObject BoardsScrollAnchor;

	public GameObject RewardScrollAnchor;

	public GameObject boardContent;

	public GameObject toObject;

	private UIClickable character;

	private UIClickable board;

	private UIClickable award;

	public Transform center;

	private UIPopupIn UIPopupIn;

	public unsafe override void Init()
	{
		//IL_00a3: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Screens.MeScreen>)+104] (should have been resolved before IL gen)");
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		screen = Screen.None;
		ShowScreen(CurrentScreen);
		Button characterButton = CharacterButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(MeScreen._003CInit_003Eb__23_0));
		characterButton.m_OnClick.AddListener(unityAction);
		Button boardButton = BoardButton;
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(MeScreen._003CInit_003Eb__23_1));
		boardButton.m_OnClick.AddListener(unityAction2);
		Button awardButton = AwardButton;
		UnityAction unityAction3 = default;
		unityAction3._002Ector(this, (nint)__ldftn(MeScreen._003CInit_003Eb__23_2));
		awardButton.m_OnClick.AddListener(unityAction3);
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
	}

	public override void Hide()
	{
		HidePopup();
		base.Hide();
	}

	private void GetObj(Screen screen)
	{
		switch (screen)
		{
		case Screen.Character:
			toObject = characterScrollAnchor;
			break;
		case Screen.Board:
			toObject = BoardsScrollAnchor;
			break;
		case Screen.Award:
			toObject = RewardScrollAnchor;
			break;
		}
	}

	private void ShowScreen(Screen screen)
	{
		//IL_0131: Expected I, but got Obj
		//IL_014d: Expected I, but got Obj
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_01b1: Expected I, but got Obj
		//IL_01cd: Expected I, but got Obj
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_021d: Expected I, but got Obj
		//IL_0239: Expected I, but got Obj
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		if (this.screen != screen)
		{
			CurrentScreen = screen;
			switch (screen)
			{
			case Screen.Character:
				toObject = characterScrollAnchor;
				break;
			case Screen.Board:
				toObject = BoardsScrollAnchor;
				break;
			case Screen.Award:
				toObject = RewardScrollAnchor;
				break;
			}
			HidePopup();
			this.screen = screen;
			object obj;
			switch (screen)
			{
			default:
				return;
			case Screen.Character:
			{
				CharacterScreen characterScreen = Object.Instantiate(CharacterScreen, parent);
				_CharacterScreen = characterScreen;
				CharacterScreen.forceCenterOnEventCharacter = true;
				CharacterScreen characterScreen2 = _CharacterScreen;
				characterScreen2.MeScreen = this;
				CharacterScreen characterScreen3 = _CharacterScreen;
				nint num5 = (nint)characterScreen3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S1_v15 (Il2CppClass<UI.Screens.CharacterScreen>)+DC] (should have been resolved before IL gen)");
				CharacterScreen characterScreen4 = _CharacterScreen;
				nint num6 = (nint)characterScreen4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ S1_v18 (Il2CppClass<UI.Screens.CharacterScreen>)+E4] (should have been resolved before IL gen)");
				obj = this + 124;
				break;
			}
			case Screen.Board:
			{
				BoardScreen boardScreen = Object.Instantiate(BoardScreen, parent);
				_BoardScreen = boardScreen;
				BoardScreen boardScreen2 = _BoardScreen;
				boardScreen2.MeScreen = this;
				BoardScreen boardScreen3 = _BoardScreen;
				nint num3 = (nint)boardScreen3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ S1_v25 (Il2CppClass<BoardScreen>)+DC] (should have been resolved before IL gen)");
				BoardScreen boardScreen4 = _BoardScreen;
				nint num4 = (nint)boardScreen4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ S1_v28 (Il2CppClass<BoardScreen>)+E4] (should have been resolved before IL gen)");
				obj = this + 128;
				break;
			}
			case Screen.Award:
			{
				AwardsScreen awardsScreen = Object.Instantiate(AwardsScreen, parent);
				_AwardsScreen = awardsScreen;
				AwardsScreen awardsScreen2 = _AwardsScreen;
				nint num = (nint)awardsScreen2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ S1_v34 (Il2CppClass<UI.Screens.AwardsScreen>)+DC] (should have been resolved before IL gen)");
				AwardsScreen awardsScreen3 = _AwardsScreen;
				nint num2 = (nint)awardsScreen3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ S1_v37 (Il2CppClass<UI.Screens.AwardsScreen>)+E4] (should have been resolved before IL gen)");
				obj = this + 132;
				break;
			}
			}
			((UIClickable)obj).SetUp(true);
		}
	}

	private void HidePopup()
	{
		//IL_0017: Expected I, but got Obj
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0091: Expected I, but got Obj
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_010b: Expected I, but got Obj
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		if (_CharacterScreen != null)
		{
			CharacterScreen characterScreen = _CharacterScreen;
			nint num = (nint)characterScreen;
			object obj = characterScreen + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S1_v30 (Il2CppClass<UI.Screens.CharacterScreen>)+EC] (should have been resolved before IL gen)");
			GameObject obj2 = _CharacterScreen.gameObject;
			Object.Destroy(obj2);
		}
		if (_BoardScreen != null)
		{
			BoardScreen boardScreen = _BoardScreen;
			nint num2 = (nint)boardScreen;
			object obj3 = boardScreen + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S1_v24 (Il2CppClass<BoardScreen>)+EC] (should have been resolved before IL gen)");
			GameObject obj4 = _BoardScreen.gameObject;
			Object.Destroy(obj4);
		}
		if (_AwardsScreen != null)
		{
			AwardsScreen awardsScreen = _AwardsScreen;
			nint num3 = (nint)awardsScreen;
			object obj5 = awardsScreen + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S1_v18 (Il2CppClass<UI.Screens.AwardsScreen>)+EC] (should have been resolved before IL gen)");
			GameObject obj6 = _AwardsScreen.gameObject;
			Object.Destroy(obj6);
		}
		GameObject gameObject = CharacterScreen.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = BoardScreen.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = AwardsScreen.gameObject;
		gameObject3.SetActive(value: false);
		character.SetUp(main: false);
		board.SetUp(main: false);
		award.SetUp(main: false);
	}

	private void GetComponent()
	{
		if (UIPopupIn == null)
		{
			UIPopupIn componentInChildren = GetComponentInChildren<UIPopupIn>();
			UIPopupIn = componentInChildren;
		}
	}

	private void ShowPopUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.IN);
	}

	public void HidePupUp()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Screens.MeScreen>)+EC] (should have been resolved before IL gen)");
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.OUT_IMPORTANT);
	}

	private void _003CInit_003Eb__23_0()
	{
		ShowScreen(Screen.Character);
	}

	private void _003CInit_003Eb__23_1()
	{
		ShowScreen(Screen.Board);
	}

	private void _003CInit_003Eb__23_2()
	{
		ShowScreen(Screen.Award);
	}
}
