using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;
using UI;
using UI.Popups;
using UI.Screens;
using UI.Screens.BoardScreenInternal;
using UI.Screens.CharacterScreenInternal;
using UnityEngine;

public class CharacterScreenNavigation : MonoBehaviour
{
	public UITexture highlight;

	public UITexture selectOutfitHighlight;

	private UITexture selectButtonHighlight;

	private CharacterSelectButton selectButton;

	private int _selectedCharacter;

	private CharacterScreen screen;

	private List<CharacterScrollListSlot> indexes;

	private MeFooterNavigation _meFooter;

	private int height;

	private void Start()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}

	private void OnEnable()
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got VT
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		object obj = this + 32;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj = componentInChildren;
		CharacterScreen characterScreen = screen;
		screen.UpdateThemeShifter(characterScreen._initiallyCenteredCharacterId, 0);
		object obj2 = this + 36;
		CharacterScreen characterScreen2 = screen;
		CharacterListManager characterListManager = characterScreen2._characterListManager;
		List<CharacterScrollListSlot> list = Enumerable.ToList(characterListManager._characterSlots);
		obj2 = list;
		object obj3 = this + 24;
		_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)this).GetComponentsInChildren<T>();
		obj3 = componentsInChildren;
		object obj4 = this + 20;
		GameObject gameObject = selectButton.gameObject;
		bool flag = ((Transform)(object)gameObject).IsChildOf((Transform)(object)"High");
		UITexture component = ((Component)flag).GetComponent<UITexture>();
		obj4 = component;
		object obj5 = this + 40;
		MeFooterNavigation componentInChildren2 = GetComponentInChildren<MeFooterNavigation>();
		obj5 = componentInChildren2;
		_meFooter.tag = null;
	}

	private void Update()
	{
		//IL_0010: Expected Obj, but got I4
		highlight.tag = (string)1;
	}

	public CharacterScreenNavigation()
	{
		//IL_07e0: Expected I, but got Obj
		//IL_07f6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I4
		//IL_081d: Expected Obj, but got I4
		//IL_0844: Expected Obj, but got I4
		//IL_086b: Expected Obj, but got I4
		//IL_0892: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_077b: Expected Obj, but got I4
		//IL_057a: Expected Obj, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0699: Expected Obj, but got I4
		//IL_05dc: Expected Obj, but got I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I
		//IL_076c: Expected Obj, but got I4
		//IL_0637: Expected Obj, but got I4
		//IL_04be: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v134 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NotEnoughCurrencyPopup o = UnityEngine.Object.FindObjectOfType<NotEnoughCurrencyPopup>();
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)o))
		{
			return;
		}
		if (Input.GetKeyDown((string)275))
		{
			if (height == 1)
			{
				CharacterScreen characterScreen = screen;
				CharacterScreenManager screenManagerInstance = screen._screenManagerInstance;
				bool flag = ((HoverboardOverlayHelper)(object)characterScreen._characterListManager).BoardHasFreeThemes((Boards.BoardId)screenManagerInstance.currentlyShownCharacter__BackingField);
				object obj2 = screen._characterListManager._characterSlots.Length - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v129 (System.Boolean)+C]");
				if (0 < (nint)obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num3 = 0;
					_ = 0;
					object obj4 = default;
					object obj3 = obj4 + 16;
					obj3 = this;
					throw new NullReferenceException();
				}
			}
			else if (height == 3)
			{
				CharacterScreen characterScreen2 = screen;
				CharacterScreenManager screenManagerInstance2 = screen._screenManagerInstance;
				bool flag2 = ((HoverboardOverlayHelper)(object)characterScreen2._characterListManager).BoardHasFreeThemes((Boards.BoardId)screenManagerInstance2.currentlyShownCharacter__BackingField);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v117 (System.Boolean)+14]");
				if ((nint)0 < (nint)2)
				{
					CharacterScreen characterScreen3 = screen;
					CharacterScreenManager screenManagerInstance3 = screen._screenManagerInstance;
					bool flag3 = ((HoverboardOverlayHelper)(object)characterScreen3._characterListManager).BoardHasFreeThemes((Boards.BoardId)screenManagerInstance3.currentlyShownCharacter__BackingField);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v123 (System.Boolean)+14]");
					object obj5 = (nint)0 + (nint)1;
					CharacterScreenManager screenManagerInstance4 = screen._screenManagerInstance;
					CharacterScreen characterScreen4 = screen;
					CharacterScreenManager screenManagerInstance5 = screen._screenManagerInstance;
					bool flag4 = ((HoverboardOverlayHelper)(object)characterScreen4._characterListManager).BoardHasFreeThemes((Boards.BoardId)screenManagerInstance5.currentlyShownCharacter__BackingField);
					CharacterScreen characterScreen5 = screen;
					Characters.CharacterId charId = screenManagerInstance4.currentlyShownCharacter__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S2_v48 (System.Boolean)+14]");
					characterScreen5.UpdateThemeShifter(charId, 0);
				}
			}
		}
		if (Input.GetKeyDown((string)276))
		{
			if (height == 1)
			{
				CharacterScreen characterScreen6 = screen;
				CharacterScreenManager screenManagerInstance6 = screen._screenManagerInstance;
				bool flag5 = ((HoverboardOverlayHelper)(object)characterScreen6._characterListManager).BoardHasFreeThemes((Boards.BoardId)screenManagerInstance6.currentlyShownCharacter__BackingField);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v103 (System.Boolean)+C]");
				if ((nint)0 > (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num4 = 0;
					_ = 0;
					object obj7 = default;
					object obj6 = obj7 + 16;
					obj6 = this;
					throw new NullReferenceException();
				}
			}
			else if (height == 3)
			{
				CharacterScreen characterScreen7 = screen;
				CharacterScreenManager screenManagerInstance7 = screen._screenManagerInstance;
				bool flag6 = ((HoverboardOverlayHelper)(object)characterScreen7._characterListManager).BoardHasFreeThemes((Boards.BoardId)screenManagerInstance7.currentlyShownCharacter__BackingField);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v91 (System.Boolean)+14]");
				if ((nint)0 > (nint)0)
				{
					CharacterScreen characterScreen8 = screen;
					CharacterScreenManager screenManagerInstance8 = screen._screenManagerInstance;
					bool flag7 = ((HoverboardOverlayHelper)(object)characterScreen8._characterListManager).BoardHasFreeThemes((Boards.BoardId)screenManagerInstance8.currentlyShownCharacter__BackingField);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v97 (System.Boolean)+14]");
					object obj8 = -1;
					CharacterScreenManager screenManagerInstance9 = screen._screenManagerInstance;
					CharacterScreen characterScreen9 = screen;
					CharacterScreenManager screenManagerInstance10 = screen._screenManagerInstance;
					bool flag8 = ((HoverboardOverlayHelper)(object)characterScreen9._characterListManager).BoardHasFreeThemes((Boards.BoardId)screenManagerInstance10.currentlyShownCharacter__BackingField);
					CharacterScreen characterScreen10 = screen;
					Characters.CharacterId charId2 = screenManagerInstance9.currentlyShownCharacter__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S2_v28 (System.Boolean)+14]");
					characterScreen10.UpdateThemeShifter(charId2, 0);
				}
			}
		}
		if (Input.GetKeyDown((string)274))
		{
			if (height == 1)
			{
				_meFooter.tag = (string)1;
				tag = null;
				highlight.tag = null;
			}
			else if (height == 2)
			{
				height = 1;
				highlight.tag = (string)1;
				selectButtonHighlight.tag = null;
			}
			else if (height == 3)
			{
				height = 2;
				selectButtonHighlight.tag = (string)1;
				selectOutfitHighlight.tag = null;
			}
		}
		if (Input.GetKeyDown((string)273))
		{
			if (height == 1)
			{
				height = 2;
				highlight.tag = null;
				selectButtonHighlight.tag = (string)1;
				CharacterScreenManager screenManagerInstance11 = screen._screenManagerInstance;
				CharacterScreen characterScreen11 = screen;
				CharacterScreenManager screenManagerInstance12 = screen._screenManagerInstance;
				bool flag9 = ((HoverboardOverlayHelper)(object)characterScreen11._characterListManager).BoardHasFreeThemes((Boards.BoardId)screenManagerInstance12.currentlyShownCharacter__BackingField);
				CharacterScreen characterScreen12 = screen;
				Characters.CharacterId charId3 = screenManagerInstance11.currentlyShownCharacter__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S2_v13 (System.Boolean)+14]");
				characterScreen12.UpdateThemeShifter(charId3, 0);
			}
			else if (height == 2)
			{
				height = 3;
				selectButtonHighlight.tag = null;
				selectOutfitHighlight.tag = (string)1;
			}
		}
		if ((Input.GetKeyDown((string)13) || Input.GetKeyDown((string)32)) && height == 2)
		{
			selectButton._002Ector();
		}
	}

	private bool _003CUpdate_003Eb__11_0(CharacterScrollListSlot x)
	{
		//IL_000e: Expected I4, but got Obj
		return (byte)(int)Attribute.GetCustomAttribute((Assembly)(object)this, (Type)(object)x) != 0;
	}

	private bool _003CUpdate_003Eb__11_1(CharacterScrollListSlot x)
	{
		//IL_0052: Expected Obj, but got I
		CharacterScreen characterScreen = screen;
		CharacterScreen characterScreen2 = screen;
		CharacterScreenManager screenManagerInstance = characterScreen2._screenManagerInstance;
		bool flag = ((HoverboardOverlayHelper)(object)characterScreen._characterListManager).BoardHasFreeThemes((Boards.BoardId)screenManagerInstance.currentlyShownCharacter__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S1_v4 (System.Boolean)+C]");
		object obj = (nint)0 + (nint)1;
		return x.index == (nint)obj;
	}
}
