using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class LimitedBoardPopup : UIScreen
{
	private GameObject _modelAnchor;

	private GameObject _centerAnchor;

	private UILabel _nameLabel;

	private UILabel _staticPowerupLabel;

	private UILabel _descriptionLabel;

	private UISprite _powerIcon;

	private UILabel _themeLimitedLabel;

	private GameObject _themePower;

	private UILabel _themePowerLabel;

	private UIWidget _coinBoxAnchor;

	private UIHoverboardThemeShifter _hoverboardThemeShifter;

	private GameObject _hoverboardSelectButtonPrefab;

	private HoverboardSelectButton _hoverboardSelectButton;

	private const bool ALLOW_SIGNATURE_ANIMATIONS = false;

	public override void Init()
	{
		//IL_0040: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<LimitedBoardPopup>)+104] (should have been resolved before IL gen)");
		UIModelController instance = UIModelController.Instance;
		if (instance.limitedBoardPopupAnchor__BackingField == null)
		{
			UIModelController instance2 = UIModelController.Instance;
			instance2.limitedBoardPopupAnchor__BackingField = _modelAnchor;
		}
		InitializeSelectButton();
		UIHoverboardThemeShifter hoverboardThemeShifter = _hoverboardThemeShifter;
		hoverboardThemeShifter._context = HoverboardManager.ScreenContext.LimitedBoardPopup;
	}

	public override void Show()
	{
		base.Show();
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.Instance;
		instance.currentlyShownThemeIndex__BackingField = 0;
		_hoverboardSelectButton.UpdateCurrentThemeIndex();
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
		GameObject gameObject = instance.ActivateHoverboardModel(UIModelController.ModelScreen.LimitedBoardPopup);
		ShowHoverboardInMenu(willUpdateAnimation: true, willAllowSignatureAnimation: false);
	}

	public override void LoseFocus()
	{
		UIModelController instance = UIModelController.Instance;
		instance.ClearModels();
	}

	private unsafe void InitializeSelectButton()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0039: Expected native int or pointer, but got VT
		//IL_0051: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		GameObject gameObject = NGUITools.AddChild(_centerAnchor, _hoverboardSelectButtonPrefab);
		HoverboardSelectButton component = gameObject.GetComponent<HoverboardSelectButton>();
		_hoverboardSelectButton = component;
		Transform transform = gameObject.transform;
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		_ = -4456311830167945216L;
		((Vector3*)(nint)vector)->x = 62f;
		transform.localPosition = vector;
		_hoverboardSelectButton.InitButton(HoverboardManager.ScreenContext.LimitedBoardPopup);
	}

	private void UpdateUIElements()
	{
		//IL_0144: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected I4, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected I4, but got Unknown
		//IL_0152: Expected Obj, but got I4
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.Instance;
		Hoverboards.BoardType currentBoardType = ((LimitedBoardPopupManager)(object)this).currentBoardType;
		LimitedBoardPopupManager instance2 = LimitedBoardPopupManager.Instance;
		Hoverboards.Board board = Hoverboards.boardData.get_Item(currentBoardType);
		string text = Strings.Get(board.name);
		_nameLabel.text = text;
		Hoverboards.Board board2 = Hoverboards.boardData.get_Item(currentBoardType);
		string text2 = Strings.Get(board2.description);
		_descriptionLabel.text = text2;
		Hoverboards.Board board3 = Hoverboards.boardData.get_Item(currentBoardType);
		string text3 = Strings.Get(board3.limitedDescription);
		_themeLimitedLabel.text = text3;
		string text4 = Strings.Get(StringID.BOARD_SCREEN_SPECIAL_POWER);
		_staticPowerupLabel.text = text4;
		Hoverboards.Board board4 = Hoverboards.boardData.get_Item(currentBoardType);
		string text5 = Strings.Get(board4.limitedDescription);
		object obj;
		if (text5 != null)
		{
			obj = 0;
			if (text5._stringLength != 0)
			{
				goto IL_02c9;
			}
		}
		obj = 1;
		goto IL_02c9;
		IL_030a:
		object obj2;
		bool flag = (byte)(obj2 ^ 1) != 0;
		_powerIcon.enabled = flag;
		_staticPowerupLabel.enabled = flag;
		bool flag2 = (byte)(obj ^ 1) != 0;
		_themeLimitedLabel.enabled = flag2;
		if (instance2.currentlyShownThemeIndex__BackingField == 0)
		{
			_themePower.SetActive(value: false);
			GameObject gameObject = _nameLabel.gameObject;
			gameObject.SetActive(value: true);
		}
		else
		{
			_themePower.SetActive(value: true);
			GameObject gameObject2 = _nameLabel.gameObject;
			gameObject2.SetActive(value: false);
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(currentBoardType);
			int index = instance2.currentlyShownThemeIndex__BackingField - 1;
			HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index);
			string text6 = Strings.Get(hoverboardTheme.title);
			_themePowerLabel.text = text6;
			_themeLimitedLabel.text = string.Empty;
		}
		UpdateThemeShifter();
		_hoverboardSelectButton.UpdateSticker(currentBoardType, instance2.currentlyShownThemeIndex__BackingField);
		return;
		IL_02c9:
		Hoverboards.Board board5 = Hoverboards.boardData.get_Item(currentBoardType);
		string text7 = Strings.Get(board5.description);
		if (text7 != null)
		{
			obj2 = 0;
			if (text7._stringLength != 0)
			{
				goto IL_030a;
			}
		}
		obj2 = 1;
		goto IL_030a;
	}

	private void SetupThemeShifter()
	{
		_hoverboardThemeShifter.ResetThemeSelection();
		UpdateThemeShifter();
	}

	private void UpdateThemeShifter()
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.Instance;
		Hoverboards.BoardType currentBoardType = ((LimitedBoardPopupManager)(object)this).currentBoardType;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			LimitedBoardPopupManager instance2 = LimitedBoardPopupManager.Instance;
			Hoverboards.BoardType currentBoardType2 = ((LimitedBoardPopupManager)(object)_hoverboardThemeShifter).currentBoardType;
			List<HoverboardThemes.HoverboardTheme> themes = HoverboardThemes.hoverboardCustomThemes.get_Item(currentBoardType2);
			_hoverboardThemeShifter.MakeCustomThemesAvailable(themes);
		}
		else
		{
			_hoverboardThemeShifter.DisableThemeShifter();
		}
	}

	private void OnBoardUnlocked(Hoverboards.BoardType boardType)
	{
		BoardScreenManager instance = BoardScreenManager.Instance;
		instance.forceRefreshOnBoardScreen__BackingField = true;
	}

	private void OnThemeActiveStateChanged(Hoverboard.BoardAbility boardAbility)
	{
		ShowHoverboardInMenu(willUpdateAnimation: true, willAllowSignatureAnimation: true, boardAbility);
	}

	private void ThemeButtonClicked(int index)
	{
		//IL_024a: Expected Obj, but got I4
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.Instance;
		Hoverboards.BoardType currentBoardType = ((LimitedBoardPopupManager)index).currentBoardType;
		PlayerInfo instance2 = PlayerInfo.Instance;
		int tIndex = index - 1;
		HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(currentBoardType, tIndex);
		bool flag = instance2._hoverboardCustomizationData.IsThemeOwned(currentBoardType, themeIdentifier);
		LimitedBoardPopupManager instance3 = LimitedBoardPopupManager.Instance;
		if (instance3.currentlyShownThemeIndex__BackingField == index)
		{
			if (flag)
			{
				_hoverboardSelectButton.OnClick();
			}
			else if (index != 0)
			{
				return;
			}
		}
		LimitedBoardPopupManager instance4 = LimitedBoardPopupManager.Instance;
		instance4.currentlyShownThemeIndex__BackingField = index;
		_hoverboardSelectButton.UpdateCurrentThemeIndex();
		UpdateDisplayedModelWithTheme(currentBoardType, index);
		if (flag)
		{
			return;
		}
		UIModelController instance5 = UIModelController.Instance;
		CharacterModel cachedActiveModel = instance5._cachedActiveModel;
		if (!(instance5._cachedActiveModel != null))
		{
			return;
		}
		GameObject hoverboardGameObject = instance5._cachedActiveModel.GetHoverboardGameObject();
		if (hoverboardGameObject != null && cachedActiveModel._characterAnimation != null)
		{
			HoverboardModelPreviewFactory instance6 = HoverboardModelPreviewFactory.Instance;
			Hoverboard.BoardAbility boardAbility;
			if (index >= 1)
			{
				List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(currentBoardType);
				int index2 = index - 1;
				HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index2);
				boardAbility = hoverboardTheme.power;
			}
			else
			{
				boardAbility = Hoverboard.BoardAbility.None;
			}
			instance6.ChangeHoverboard(currentBoardType, hoverboardGameObject, cachedActiveModel._characterAnimation, willUpdateAnimation: true, willAllowSignatureAnimation: true, boardAbility);
		}
	}

	private void UpdateDisplayedModelWithTheme(Hoverboards.BoardType boardType, int themeIndex)
	{
		//IL_01fe: Expected Obj, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = themeIndex == 0;
		int num = 0;
		if (!flag)
		{
			int tIndex = themeIndex - 1;
			HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(boardType, tIndex);
			bool flag2 = instance._hoverboardCustomizationData.IsThemeOwned(boardType, themeIdentifier);
			bool flag3 = !flag2;
			bool flag4 = true;
			if (!flag3)
			{
				int tIndex2 = themeIndex - 1;
				HoverboardThemes.ThemeIdentifier themeIdentifier2 = HoverboardThemes.GetThemeIdentifier(boardType, tIndex2);
				bool flag5 = instance._hoverboardCustomizationData.IsThemeActive(boardType, themeIdentifier2);
				flag4 = flag5;
			}
			HoverboardManager instance2 = HoverboardManager.Instance;
			object obj = themeIndex - 1;
			object obj2 = (object)instance2._displayCustomSets + obj;
			num = 0;
			while (num < 2)
			{
				object obj3 = themeIndex - 1;
				if (num != (nint)obj3)
				{
					HoverboardManager instance3 = HoverboardManager.Instance;
					HoverboardThemes.ThemeIdentifier themeIdentifier3 = HoverboardThemes.GetThemeIdentifier(boardType, num);
					bool flag6 = instance._hoverboardCustomizationData.IsThemeActive(boardType, themeIdentifier3);
					object obj4 = num + instance3._displayCustomSets;
				}
				int num2 = num + 1;
				num = num2;
			}
		}
		else
		{
			while (num < 2)
			{
				HoverboardManager instance4 = HoverboardManager.Instance;
				HoverboardThemes.ThemeIdentifier themeIdentifier4 = HoverboardThemes.GetThemeIdentifier(boardType, num);
				bool flag7 = instance._hoverboardCustomizationData.IsThemeActive(boardType, themeIdentifier4);
				object obj5 = num + instance4._displayCustomSets;
				int num3 = num + 1;
				num = num3;
			}
		}
		ShowHoverboardInMenu(willUpdateAnimation: false, willAllowSignatureAnimation: true);
	}

	private void ShowHoverboardInMenu(bool willUpdateAnimation, bool willAllowSignatureAnimation, Hoverboard.BoardAbility ability = Hoverboard.BoardAbility.None)
	{
		UIModelController instance = UIModelController.Instance;
		LimitedBoardPopupManager instance2 = LimitedBoardPopupManager.Instance;
		Hoverboards.BoardType currentBoardType = ((LimitedBoardPopupManager)(object)this).currentBoardType;
		instance.ShowHoverboardMenuModel(currentBoardType, willUpdateAnimation, willAllowSignatureAnimation, ability);
		UpdateUIElements();
	}

	private void LogFlurryEvent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0251: Expected I, but got Obj
		//IL_0263: Expected I, but got Obj
		//IL_0147: Expected Obj, but got I4
		//IL_0170: Expected I4, but got Obj
		//IL_019f: Expected I4, but got Obj
		object obj = default;
		LimitedBoardPopupManager limitedBoardPopupManager = (LimitedBoardPopupManager)(obj - 16);
		limitedBoardPopupManager._startTimerCoroutine = null;
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.Instance;
		Hoverboards.BoardType currentBoardType = limitedBoardPopupManager.currentBoardType;
		Hoverboards.Board board = Hoverboards.boardData.get_Item(currentBoardType);
		string text = Strings.Get(board.name);
		string text2 = text.ToLower();
		PlayerInfo instance2 = PlayerInfo.Instance;
		bool state = instance2.IsHoverboardUnlocked(currentBoardType);
		string value = "Board " + text2 + " bought";
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(value);
		StringBuilder stringBuilder2 = stringBuilder.Append(";");
		string stateString = ((LimitedBoardPopup)(object)limitedBoardPopupManager).GetStateString(state);
		StringBuilder stringBuilder3 = default;
		stringBuilder3._002Ector(stateString);
		StringBuilder stringBuilder4 = stringBuilder3.Append(";");
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.TryGetCustomThemesForBoard(currentBoardType);
		if (list != null)
		{
			int num = 0;
			while (num < list._size)
			{
				HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(num);
				limitedBoardPopupManager._startTimerCoroutine = (IEnumerator)hoverboardTheme.identifier;
				PlayerInfo instance3 = PlayerInfo.Instance;
				bool state2 = instance3._hoverboardCustomizationData.IsThemeOwned(currentBoardType, (HoverboardThemes.ThemeIdentifier)limitedBoardPopupManager._startTimerCoroutine);
				_ = -1;
				limitedBoardPopupManager = (LimitedBoardPopupManager)(object)typeof(HoverboardThemes.ThemeIdentifier);
				limitedBoardPopupManager._isInitialized = (byte)(int)limitedBoardPopupManager._startTimerCoroutine != 0;
				string arg = ((Enum)(object)limitedBoardPopupManager).ToString();
				StringBuilder stringBuilder5 = stringBuilder.AppendFormat("{0}_{1} bought", text2, arg);
				StringBuilder stringBuilder6 = stringBuilder.Append(";");
				string stateString2 = ((LimitedBoardPopup)(object)limitedBoardPopupManager).GetStateString(state2);
				StringBuilder stringBuilder7 = stringBuilder3.AppendFormat("{0};", stateString2);
				int num2 = num + 1;
				num = num2;
			}
		}
		nint num3 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ S1_v20 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		nint num4 = (nint)stringBuilder3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ S1_v23 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
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

	private void HidePopupIfNeeded()
	{
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.Instance;
		if (!((LimitedBoardPopupManager)null).IsBoardAvailable())
		{
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.CloseActivePopups("LimitedBoardPopup");
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
