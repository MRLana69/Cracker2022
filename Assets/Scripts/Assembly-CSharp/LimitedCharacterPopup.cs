using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI;
using UI.Screens;
using UnityEngine;

public class LimitedCharacterPopup : UIScreen
{
	private GameObject _characterSelectButtonPrefab;

	private GameObject _centerAnchor;

	private GameObject _characterAnchor;

	private UIWidget _coinBoxAnchor;

	private UILabel _nameTitle;

	private UILabel _nameSubTitle;

	private UICharacterThemeShifter _characterThemeShifter;

	private CharacterSelectButton _characterSelectButton;

	private List<string> _boughtThemeNames;

	private bool _characterWasBought;

	public override void Init()
	{
		//IL_0040: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<LimitedCharacterPopup>)+104] (should have been resolved before IL gen)");
		UIModelController instance = UIModelController.Instance;
		if (instance.limitedCharacterPopupAnchor__BackingField == null)
		{
			UIModelController instance2 = UIModelController.Instance;
			instance2.limitedCharacterPopupAnchor__BackingField = _characterAnchor;
		}
		InitializeSelectButton();
	}

	public override void Show()
	{
		base.Show();
		LimitedCharacterPopupManager instance = LimitedCharacterPopupManager.Instance;
		instance._currentThemeIndex = 0;
		UIModelController instance2 = UIModelController.Instance;
		LimitedCharacterPopupManager instance3 = LimitedCharacterPopupManager.Instance;
		Characters.CharacterType currentCharacter = ((LimitedCharacterPopupManager)(object)this).currentCharacter;
		LimitedCharacterPopupManager instance4 = LimitedCharacterPopupManager.Instance;
		GameObject gameObject = instance2.ShowMenuModel(currentCharacter, instance4._currentThemeIndex, UIModelController.ModelScreen.LimitedCharacterPopup);
		UpdateUIElements();
		throw new ArgumentException();
	}

	public override void Hide()
	{
		base.Hide();
		throw new ArgumentException();
	}

	public override void GainFocus()
	{
		UIModelController instance = UIModelController.Instance;
		LimitedCharacterPopupManager instance2 = LimitedCharacterPopupManager.Instance;
		Characters.CharacterType currentCharacter = ((LimitedCharacterPopupManager)(object)instance).currentCharacter;
		LimitedCharacterPopupManager instance3 = LimitedCharacterPopupManager.Instance;
		GameObject gameObject = instance.ShowMenuModel(currentCharacter, instance3._currentThemeIndex, UIModelController.ModelScreen.LimitedCharacterPopup);
	}

	public override void LoseFocus()
	{
		UIModelController instance = UIModelController.Instance;
		instance.ClearModels();
	}

	private void LogFlurryEvent()
	{
		//IL_008f: Expected Obj, but got I4
		//IL_0242: Expected I, but got Obj
		//IL_0254: Expected I, but got Obj
		//IL_010c: Expected I4, but got Obj
		LimitedCharacterPopupManager instance = LimitedCharacterPopupManager.Instance;
		Characters.CharacterType currentCharacter = ((LimitedCharacterPopupManager)null).currentCharacter;
		Characters.Model model = Characters.characterData.get_Item(currentCharacter);
		string text = Strings.Get(model.name);
		string text2 = text.ToLower();
		string value = "Character " + text2 + " bought";
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(value);
		StringBuilder stringBuilder2 = stringBuilder.Append(";");
		string stateString = ((LimitedCharacterPopup)currentCharacter).GetStateString(_characterWasBought);
		StringBuilder stringBuilder3 = default;
		stringBuilder3._002Ector(stateString);
		StringBuilder stringBuilder4 = stringBuilder3.Append(";");
		List<CharacterTheme> list = CharacterThemes.TryGetCustomThemesForChar(currentCharacter);
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			LimitedCharacterPopup limitedCharacterPopup = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v53+C]");
			if ((nint)limitedCharacterPopup < 0)
			{
				CharacterTheme theme = list.get_Item((int)limitedCharacterPopup);
				string themeName = limitedCharacterPopup.GetThemeName(theme);
				throw new ArrayTypeMismatchException();
			}
		}
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ S1_v18 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		nint num2 = (nint)stringBuilder3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ S1_v21 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
	}

	private string GetThemeName(CharacterTheme theme)
	{
		return Strings.Get(theme.title);
	}

	private string GetStateString(bool state)
	{
		object result = "yes";
		if (!state)
		{
			result = "no";
		}
		return (string)result;
	}

	private void OnThemeButtonClicked(int index)
	{
		//IL_006e: Expected Obj, but got I4
		LimitedCharacterPopupManager instance = LimitedCharacterPopupManager.Instance;
		if (index != instance._currentThemeIndex)
		{
			LimitedCharacterPopupManager instance2 = LimitedCharacterPopupManager.Instance;
			instance2._currentThemeIndex = index;
			UIModelController instance3 = UIModelController.Instance;
			LimitedCharacterPopupManager instance4 = LimitedCharacterPopupManager.Instance;
			Characters.CharacterType currentCharacter = ((LimitedCharacterPopupManager)index).currentCharacter;
			GameObject gameObject = instance3.ShowMenuModel(currentCharacter, index, UIModelController.ModelScreen.LimitedCharacterPopup);
			UpdateUIElements();
		}
	}

	private void HidePopupIfNeeded()
	{
		LimitedCharacterPopupManager instance = LimitedCharacterPopupManager.Instance;
		if (!((LimitedCharacterPopupManager)null).IsCharacterAvailable())
		{
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.CloseActivePopups("LimitedCharacterPopup");
		}
	}

	private unsafe void InitializeSelectButton()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0039: Expected native int or pointer, but got VT
		//IL_0051: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		GameObject gameObject = NGUITools.AddChild(_centerAnchor, _characterSelectButtonPrefab);
		CharacterSelectButton component = gameObject.GetComponent<CharacterSelectButton>();
		_characterSelectButton = component;
		Transform transform = gameObject.transform;
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		_ = -4456311830167945216L;
		((Vector3*)(nint)vector)->x = 62f;
		transform.localPosition = vector;
		UICharacterThemeShifter characterThemeShifter = _characterThemeShifter;
		LimitedCharacterPopupManager instance = LimitedCharacterPopupManager.Instance;
		Characters.CharacterType currentCharacter = ((LimitedCharacterPopupManager)(object)this).currentCharacter;
		LimitedCharacterPopupManager instance2 = LimitedCharacterPopupManager.Instance;
		characterThemeShifter._activeTheme = instance2._currentThemeIndex;
		characterThemeShifter._cachedCharacter = currentCharacter;
		_characterSelectButton.InitButton(CharacterSelectButton.ButtonContext.limitedCharacterPopup);
	}

	private unsafe void ChangePositionOnYAxis(Transform objectTransform, float newYPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003d: Expected F4, but got I
		//IL_0038: Expected native int or pointer, but got VT
		//IL_0064: Expected F4, but got I
		//IL_005f: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Vector3 localPosition = objectTransform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		objectTransform.localPosition = vector;
	}

	private void UpdateThemeShifter(Characters.CharacterType charType, int index)
	{
		//IL_0074: Expected Obj, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009a: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Collections.Generic.List`1<CharacterTheme>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		bool flag = (byte)(obj2 >> 31) != 0;
		GameObject gameObject = _characterThemeShifter.gameObject;
		gameObject.SetActive(flag);
		if (flag)
		{
			List<CharacterTheme> themes = CharacterThemes.TryGetCustomThemesForChar(charType);
			_characterThemeShifter.MakeCustomThemesAvailable(themes);
			_characterThemeShifter.UpdateUIForCharacter(charType, index);
		}
	}

	public void UpdateUIElements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_01a7: Expected Obj, but got I4
		//IL_018b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		UIModelController instance = UIModelController.Instance;
		Characters.Model model = Characters.characterData.get_Item(instance._currentlyShownModel);
		PlayerInfo instance2 = PlayerInfo.Instance;
		bool flag = instance2.IsCharacterOwned(instance._currentlyShownModel);
		LimitedCharacterPopupManager instance3 = LimitedCharacterPopupManager.Instance;
		CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(instance._currentlyShownModel, instance3._currentThemeIndex);
		if (!flag && ~(model.hasOnlineSettings ? 1u : 0u) == 0 && themeForCharacter == null)
		{
			PlayerInfo instance4 = PlayerInfo.Instance;
			TimeSpan timeSpan = instance4.CharacterExpirationTimespan(instance._currentlyShownModel);
		}
		string text = Strings.Get(model.name);
		_nameTitle.text = text;
		string text2 = Strings.Get(model.characterLimitedDescription);
		object obj3;
		if (text2 != null)
		{
			obj3 = 0;
			if (text2._stringLength != 0)
			{
				goto IL_0299;
			}
		}
		obj3 = 1;
		goto IL_0299;
		IL_02ed:
		object obj4;
		string text3;
		if (obj4 == null)
		{
			_nameSubTitle.text = text3;
		}
		goto IL_01c0;
		IL_01c0:
		LimitedCharacterPopupManager instance5 = LimitedCharacterPopupManager.Instance;
		Characters.CharacterType currentCharacter = ((LimitedCharacterPopupManager)(object)this).currentCharacter;
		LimitedCharacterPopupManager instance6 = LimitedCharacterPopupManager.Instance;
		UpdateThemeShifter(currentCharacter, instance6._currentThemeIndex);
		LimitedCharacterPopupManager instance7 = LimitedCharacterPopupManager.Instance;
		Characters.CharacterType currentCharacter2 = ((LimitedCharacterPopupManager)(object)this).currentCharacter;
		LimitedCharacterPopupManager instance8 = LimitedCharacterPopupManager.Instance;
		UpdateCharacterSticker(currentCharacter2, instance8._currentThemeIndex);
		_characterSelectButton.ReloadButton();
		return;
		IL_0299:
		string text4 = ((obj3 != null) ? string.Empty : Strings.Get(model.characterLimitedDescription));
		_nameSubTitle.text = text4;
		if (themeForCharacter == null)
		{
			goto IL_01c0;
		}
		text3 = Strings.Get(themeForCharacter.title);
		if (text3 != null)
		{
			obj4 = 0;
			if (text3._stringLength != 0)
			{
				goto IL_02ed;
			}
		}
		obj4 = 1;
		goto IL_02ed;
	}

	public void UpdateSelectedCharacter()
	{
		UIModelController instance = UIModelController.Instance;
		UIModelController instance2 = UIModelController.Instance;
		PlayerInfo instance3 = PlayerInfo.Instance;
		bool flag = instance3.IsCharacterOwned(instance._currentlyShownModel);
		PlayerInfo instance4 = PlayerInfo.Instance;
		bool flag2 = instance4.IsThemeUnlockedForCharacter(instance._currentlyShownModel, instance2._currentlyShownThemeIndex);
		if (flag && flag2)
		{
			PlayerInfo instance5 = PlayerInfo.Instance;
			instance5.SetLastSelectedTheme(instance._currentlyShownModel, instance2._currentlyShownThemeIndex);
			_characterThemeShifter.UpdateUIForCharacter(instance._currentlyShownModel, instance2._currentlyShownThemeIndex);
			_characterSelectButton.ReloadButton();
		}
	}

	public void UpdateCharacterSticker(Characters.CharacterType charType, int index)
	{
		//IL_00c3: Expected Obj, but got I4
		Characters.Model model = Characters.characterData.get_Item(charType);
		CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(charType, index);
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = instance.IsCharacterOwned(charType);
		bool flag2 = themeForCharacter == null;
		bool flag3 = true;
		if (!flag2)
		{
			flag3 = true;
			if (themeForCharacter.price == 0)
			{
				bool flag4 = CharacterStickerManager.IsThemeUnlockedForCharacter(charType, index);
				flag3 = flag4;
			}
		}
		LimitedCharacterPopupManager instance2 = LimitedCharacterPopupManager.Instance;
		bool flag5 = ((LimitedCharacterPopupManager)charType).CurrentlyShownCharacterMatchesEventItem();
		if (flag3)
		{
		}
	}

	private void OnCharacterUnlocked(Characters.CharacterType charType, int version)
	{
		LimitedCharacterPopupManager instance = LimitedCharacterPopupManager.Instance;
		instance._currentThemeIndex = version;
		UpdateSelectedCharacter();
		UpdateUIElements();
		_characterWasBought = true;
		if (version >= 1)
		{
			CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(charType, version);
			if (themeForCharacter != null)
			{
				string themeName = GetThemeName(themeForCharacter);
				_boughtThemeNames.Add(themeName);
			}
		}
	}

	public LimitedCharacterPopup()
	{
		List<string> list = default;
		list._002Ector();
		_boughtThemeNames = list;
		base._002Ector();
	}
}
