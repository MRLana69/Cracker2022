using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.DebugUtil;
using Data.Managers;
using Info;
using SYBO.Subway.Info;
using UI.Generic;
using UI.ModelCamera;
using UI.Popups.LimitedBoardPopupInternal;
using UI.Popups.LimitedCharacterPopupInternal;
using UI.Screens;
using UI.Screens.NotEnoughCurrencyPopupInternal;
using UI.VideoAdPrizes;
using UnityEngine;

namespace UI.Popups;

public class LimitedCharacterPopup : UIScreen
{
	private GameObject _characterAnchor;

	private UIWidget _coinBoxAnchor;

	private UILabel _nameTitle;

	private UILabel _nameSubTitle;

	private UICharacterThemeShifter _characterThemeShifter;

	private TimerHelper _timerPrefab;

	private UIWidget _timerParent;

	private TimerHelper _timer;

	private CharacterSelectButton _characterSelectButtonPrefab;

	private UIWidget _characterSelectButtonParent;

	private CharacterSelectButton _characterSelectButton;

	private List<string> _boughtThemeNames;

	private bool _characterWasBought;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I4
		ShowIfInactive();
		bool isInstanced = UIScreenController.IsInstanced;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (System.Boolean)+38]");
		if ((UnityEngine.Object)0 != null)
		{
			bool isInstanced2 = UIScreenController.IsInstanced;
			object obj2 = (isInstanced2 ? 1 : 0) + 56;
			obj2 = _characterAnchor;
		}
		InitializeSelectButton();
		UpdateUIElements();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
	}

	public unsafe override void Hide()
	{
		//IL_0446: Expected I, but got Obj
		//IL_045c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_04c1: Expected Obj, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_0145: Expected I, but got Obj
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0294: Expected I, but got Obj
		//IL_02aa: Expected Obj, but got I
		//IL_0208: Expected I, but got Obj
		//IL_02d5: Expected I, but got Obj
		//IL_0353: Expected I, but got Obj
		//IL_0369: Expected Obj, but got I
		//IL_0554: Expected I, but got Obj
		//IL_056a: Expected Obj, but got I
		//IL_0590: Expected Obj, but got I4
		//IL_0394: Expected I, but got Obj
		//IL_03e1: Expected I, but got Obj
		base.Hide();
		nint num = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v86 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
		instance._overwrittenBoardForNextShowing = false;
		bool isInstanced = UIScreenController.IsInstanced;
		LimitedBoardPopupManager instance2 = LimitedBoardPopupManager.instance;
		int currentThemeIndex = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		LimitedBoardPopupManager instance3 = LimitedBoardPopupManager.instance;
		((UIModelController)isInstanced).SetupModelScreen((UIModelController.ModelScreen)currentThemeIndex, (ModelScreenSetup)instance3._overwrittenBoardForNextShowing, (ModelScreenData)10);
		UpdateSelectedCharacter();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<int> action = default;
		object obj2 = action + 16;
		obj2 = this;
		_characterThemeShifter.OnThemeButtonPressed -= action;
		string text = _characterThemeShifter.tag;
		LimitedBoardPopupManager instance4 = LimitedBoardPopupManager.instance;
		int currentThemeIndex2 = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		nint num4 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v14 (Il2CppClass<Info.Outfits>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v22 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int themeCount = Outfits.GetThemeCount((Characters.CharacterId)currentThemeIndex2);
		((GameObject)(object)text).tag = (string)themeCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(LimitedCharacterPopup.UpdateSelectedCharacter);
		object obj4 = action2 + 16;
		obj4 = this;
		nint num6 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v82 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreenManager.onCharacterSelected -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<Characters.CharacterId, int> action3 = default;
		object obj6 = action3 + 16;
		obj6 = this;
		CharacterScreenManager.characterUnlocked -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr2;
		((Delegate)action4).method = (nint)__ldftn(LimitedCharacterPopup.HidePopupIfNeeded);
		object obj7 = action4 + 16;
		obj7 = this;
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v50 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v78 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action4;
		LimitedBoardPopupManager instance5 = LimitedBoardPopupManager.instance;
		int currentThemeIndex3 = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		if (!CharacterStickerManager.IsCharacterUnlocked((Characters.CharacterId)currentThemeIndex3))
		{
			nint num11 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v66 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num12 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v74 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			LimitedBoardPopupManager instance6 = LimitedBoardPopupManager.instance;
			int currentThemeIndex4 = ((LimitedCharacterPopupManager)null).currentThemeIndex;
			nint num13 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v58 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num14 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S1_v63 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveGameDebug.lastLoadedSave = (string)currentThemeIndex4;
		}
		_characterWasBought = false;
		throw new IndexOutOfRangeException();
	}

	public unsafe override void GainFocus()
	{
		//IL_01b5: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I4
		//IL_014c: Expected I, but got Obj
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		List<Outfit> list = default;
		list._items = (Outfit[])num;
		list._syncRoot = 0;
		object obj = list + 16;
		obj = this;
		_characterThemeShifter.MakeCustomThemesAvailable(list);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(LimitedCharacterPopup.UpdateSelectedCharacter);
		object obj2 = action + 16;
		obj2 = this;
		nint num2 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v15 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v49 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreenManager.onFacebookStatusChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(LimitedCharacterPopup.OnCharacterUnlocked);
		object obj4 = action2 + 16;
		obj4 = this;
		CharacterScreenManager.characterUnlockedFailure += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj5 = action3 + 16;
		obj5 = this;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v37 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v45 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action3;
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.LimitedCharacterPopup);
		HidePopupIfNeeded();
	}

	public override void LoseFocus()
	{
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		bool isInstanced = UIScreenController.IsInstanced;
		nint num = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v11 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
		int currentThemeIndex = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		LimitedBoardPopupManager instance2 = LimitedBoardPopupManager.instance;
		((UIModelController)isInstanced).SetupModelScreen((UIModelController.ModelScreen)currentThemeIndex, (ModelScreenSetup)instance2._overwrittenBoardForNextShowing, (ModelScreenData)10);
	}

	private void LogFlurryEvent()
	{
		//IL_0017: Expected Obj, but got I4
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.LimitedCharacterPopup);
	}

	private string GetThemeNameForAnalytics(Outfit theme)
	{
		if (theme != null)
		{
			return "yes";
		}
		return "no";
	}

	private string GetStateString(bool state)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L1 (System.Boolean)+20]");
		return Strings.GetLegal((string)0);
	}

	private void OnThemeButtonClicked(int index)
	{
	}

	private void HidePopupIfNeeded()
	{
		//IL_03b8: Expected I, but got Obj
		//IL_03ce: Expected Obj, but got I
		//IL_0530: Expected I, but got Obj
		//IL_0546: Expected Obj, but got I
		//IL_040b: Expected I, but got Obj
		//IL_0421: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0103: Expected I4, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I4
		//IL_0158: Expected I4, but got Obj
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_04bc: Expected I, but got Obj
		//IL_04d2: Expected Obj, but got I
		//IL_01be: Expected I, but got Obj
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_036b: Expected I, but got Obj
		//IL_0230: Expected Obj, but got I4
		//IL_023e: Expected I4, but got Obj
		nint num = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v97 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
		int currentThemeIndex = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		nint num3 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v91 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)currentThemeIndex);
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v55 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string legal = Strings.GetLegal(model.name);
		string args = legal.ToLowerInvariant();
		string text = $"Character {(object[])(object)args} bought";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		stringBuilder.Length = (int)text;
		StringBuilder stringBuilder2 = stringBuilder.AppendLine(";");
		bool characterWasBought = _characterWasBought;
		string text2 = ((SecretPopup)null).TruncateProviderID((string)characterWasBought);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder3 = default;
		stringBuilder3.Length = (int)text2;
		StringBuilder stringBuilder4 = stringBuilder3.AppendLine(";");
		nint num7 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v42 (Il2CppClass<Info.Outfits>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v87 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Outfits.HasCharacter((Characters.CharacterId)currentThemeIndex);
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj6 = default;
			object obj5 = obj6 + 12;
			int num9 = 0;
			if (num9 < (nint)obj5)
			{
				Outfit outfit = ((List<Outfit>)flag).get_Item(num9);
				string stateString = ((LimitedCharacterPopup)null).GetStateString((byte)(int)outfit != 0);
				throw new ArrayTypeMismatchException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num10 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v54 (Il2CppClass<Flurry>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num11 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v58 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void InitializeTimer()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
		if (((LimitedCharacterPopupManager)null).ShouldButtonBeVisible())
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)"LimitedCharacterPopup");
	}

	private unsafe void InitializeSelectButton()
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0177: Expected Obj, but got VT
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected VT, but got Unknown
		//IL_01a8: Expected F4, but got Obj
		//IL_01a3: Expected native int or pointer, but got VT
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got VT
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_01fd: Expected F4, but got Obj
		//IL_01f8: Expected native int or pointer, but got VT
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected I4, but got Unknown
		//IL_0225: Expected I4, but got Obj
		//IL_023f: Expected F4, but got Obj
		//IL_023a: Expected native int or pointer, but got VT
		//IL_0254: Expected F4, but got I
		//IL_024f: Expected native int or pointer, but got VT
		//IL_0267: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj = this - -64;
		GameObject parent = ((Component)obj).gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 68;
		TimerHelper timerHelper = UnityEngine.Object.Instantiate(_timerPrefab, (Transform)(object)parent);
		obj3 = timerHelper;
		nint num3 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v10 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v34 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = default;
		object obj5 = obj6 + 44;
		obj5 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
		object obj7 = obj6 + 40;
		obj7 = obj5;
		Matrix4x4 matrix4x = (Matrix4x4)(obj6 - -64);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		object obj8 = obj6 + 24;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		object obj9 = obj6 + 20;
		obj9 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
		object obj10 = obj6 + 16;
		obj10 = obj9;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		bool flag = (byte)(obj6 + 48) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj8 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v21+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_timer.AnimateClock(flag, (byte)(int)matrix4x != 0);
	}

	private unsafe void UpdateThemeShifter(Characters.CharacterId charId, int index)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_05aa: Expected Obj, but got I4
		//IL_0457: Expected Obj, but got I4
		//IL_0469: Expected I, but got Obj
		//IL_047f: Expected Obj, but got I
		//IL_0352: Expected I, but got Obj
		//IL_0368: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_064c: Expected Obj, but got I4
		//IL_065e: Expected I, but got Obj
		//IL_0674: Expected Obj, but got I
		//IL_01c4: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0393: Expected I, but got Obj
		//IL_0566: Expected I, but got Obj
		//IL_057c: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_03e0: Expected I, but got Obj
		//IL_04e1: Expected Obj, but got I4
		//IL_04f3: Expected I, but got Obj
		//IL_0509: Expected Obj, but got I
		//IL_01d7: Expected I, but got Obj
		//IL_0545: Expected Obj, but got I4
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected Obj, but got Unknown
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0224: Expected Obj, but got I4
		//IL_022c: Invalid comparison between Ref and Obj
		//IL_025c: Expected I, but got Obj
		//IL_0272: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I4
		//IL_05ca: Expected I, but got Obj
		//IL_05e0: Expected Obj, but got I
		//IL_029d: Expected I, but got Obj
		//IL_02ea: Expected I, but got Obj
		if (index != 0)
		{
			nint num = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v36 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v120 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool themeId = ((NotificationsObserver)charId).DidAppStartFromNotificationAndroid(out *(Notification*)(index - 1));
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v43 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v116 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6;
			if (BoardManager.IsThemeActive((Boards.BoardId)charId, themeId ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none))
			{
				nint num5 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v93 (Il2CppClass<HoverboardThemes>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(HoverboardThemes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v112 (Il2CppClass<HoverboardThemes>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool themeId2 = ((NotificationsObserver)charId).DidAppStartFromNotificationAndroid(out *(Notification*)(index - 1));
				nint num7 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v100 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v108 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = BoardManager.HasThemeBeenSeen((Boards.BoardId)charId, themeId2 ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none);
				object obj5 = (flag ? 1 : 0) ^ 1;
				obj6 = obj5 & 1;
			}
			else
			{
				obj6 = 0;
			}
			nint num9 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v51 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.BoardId boardId = (Boards.BoardId)(index - 1);
			bool themeId3 = obj6 == null;
			BoardManager.SetThemeAcquired(boardId, themeId3 ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none);
			for (ref Notification reference = ref *(Notification*)null; (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) <= (nint)1; reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1))
			{
				object obj8 = index - 1;
				if (System.Runtime.CompilerServices.Unsafe.AreSame(ref System.Runtime.CompilerServices.Unsafe.As<Notification, byte>(ref reference), ref *(byte*)obj8))
				{
					continue;
				}
				nint num11 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v67 (Il2CppClass<HoverboardThemes>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num12 = (nint)typeof(HoverboardThemes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v83 (Il2CppClass<HoverboardThemes>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool themeId4 = ((NotificationsObserver)charId).DidAppStartFromNotificationAndroid(out reference);
				nint num13 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v74 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num14 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v79 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool themeId5 = BoardManager.HasThemeBeenSeen((Boards.BoardId)charId, themeId4 ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none);
				BoardManager.SetThemeAcquired((Boards.BoardId)(int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), themeId5 ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none);
			}
		}
		else
		{
			for (ref Notification reference2 = ref *(Notification*)null; (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) <= (nint)1; reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 1))
			{
				nint num15 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v11 (Il2CppClass<HoverboardThemes>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num16 = (nint)typeof(HoverboardThemes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v29 (Il2CppClass<HoverboardThemes>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool themeId6 = ((NotificationsObserver)charId).DidAppStartFromNotificationAndroid(out reference2);
				nint num17 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v18 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num18 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v25 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool themeId7 = BoardManager.HasThemeBeenSeen((Boards.BoardId)charId, themeId6 ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none);
				BoardManager.SetThemeAcquired((Boards.BoardId)(int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2), themeId7 ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none);
			}
		}
		((NotEnoughCurrencyPopup)this).ActivateUiElement(UiElementType.FirstPurchaseBonusBanner, (GameObject)1, (OnActivatedPrefab)null);
	}

	private void UpdateUIElements()
	{
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01c4: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0250: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		GameObject parent = _characterSelectButtonParent.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 80;
		CharacterSelectButton characterSelectButton = UnityEngine.Object.Instantiate(_characterSelectButtonPrefab, (Transform)(object)parent);
		obj2 = characterSelectButton;
		GameObject gameObject = _characterSelectButton.gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v25 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj4 = default;
		Transform transform = (Transform)(obj4 + 12);
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		UICharacterThemeShifter characterThemeShifter = _characterThemeShifter;
		nint num5 = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v26 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v44 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
		int currentThemeIndex = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		LimitedBoardPopupManager instance2 = LimitedBoardPopupManager.instance;
		characterThemeShifter._cachedCharacter = (Characters.CharacterId)currentThemeIndex;
		characterThemeShifter._activeTheme = (instance2._overwrittenBoardForNextShowing ? 1 : 0);
		_characterSelectButton.ShowLockedTokenContent(true);
		_characterSelectButton.SetSticker(CharacterSelectButton.StickerType.Limited);
	}

	private void UpdateSelectedCharacter()
	{
		//IL_052f: Expected I, but got Obj
		//IL_0545: Expected Obj, but got I
		//IL_058a: Expected I, but got Obj
		//IL_05a0: Expected Obj, but got I
		//IL_05e0: Expected I, but got Obj
		//IL_05f6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_062a: Expected I, but got Obj
		//IL_0640: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_0685: Expected Obj, but got I4
		//IL_0685: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_06b3: Expected I, but got Obj
		//IL_06c9: Expected Obj, but got I
		//IL_00fa: Expected I, but got Obj
		//IL_080d: Expected I4, but got Obj
		//IL_025c: Expected I, but got Obj
		//IL_01b3: Expected I, but got Obj
		//IL_01c9: Expected Obj, but got I
		//IL_06f7: Expected Obj, but got I
		//IL_0718: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got VT
		//IL_01f4: Expected I, but got Obj
		//IL_02fb: Expected I, but got Obj
		//IL_0311: Expected Obj, but got I
		//IL_0750: Expected I4, but got Obj
		//IL_02e8: Expected I4, but got Obj
		//IL_033c: Expected I, but got Obj
		//IL_0763: Expected I, but got Obj
		//IL_0779: Expected Obj, but got I
		//IL_03b1: Expected I, but got Obj
		//IL_03c7: Expected Obj, but got I
		//IL_047a: Expected I, but got Obj
		//IL_07a7: Expected Obj, but got I
		//IL_03f2: Expected I, but got Obj
		//IL_0467: Expected I4, but got Obj
		bool isInstanced = UIScreenController.IsInstanced;
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v120 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Characters.CharacterId, Characters.Model> characterData = Characters.characterData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (System.Boolean)+84]");
		Characters.Model model = characterData.get_Item(Characters.CharacterId.slick);
		nint num3 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v116 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (System.Boolean)+84]");
		bool flag = CharacterManager.IsCollectionComplete(Characters.CharacterId.slick);
		nint num5 = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v28 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v112 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
		nint num7 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v36 (Il2CppClass<Info.Outfits>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v108 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = default;
		object obj5 = obj6 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (System.Boolean)+84]");
		bool flag2 = ((OutfitSet)0).HasOutfitWithName((string)instance._overwrittenBoardForNextShowing);
		if (~(model.hasOnlineSettings ? 1u : 0u) == 0)
		{
			if (!flag)
			{
				_characterSelectButton.ShowLockedTokenContent(true);
				nint num9 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v86 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num10 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v97 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (System.Boolean)+84]");
				DateTime lastModifiedMine = ((CloudSaveConflictResolver)0).lastModifiedMine;
				string text = _timer.tag;
				((GameObject)(object)text).tag = (string)1;
				obj6 = lastModifiedMine;
				obj5 = obj6;
				throw new ArrayTypeMismatchException();
			}
			_timer.HideIcon();
			string text2 = _timer.tag;
			((GameObject)(object)text2).tag = null;
			_characterSelectButton.ShowLockedTokenContent(false);
		}
		nint num11 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v6 (Il2CppClass<Strings>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S2_v37 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault(model.name);
		_nameTitle.fontSize = (int)text3;
		string text4 = Strings.GetDefault(model.characterLimitedDescription);
		int fontSize;
		if (text4 == null || text4.m_stringLength == 0)
		{
			fontSize = (int)"";
		}
		else
		{
			nint num13 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S2_v28 (Il2CppClass<Strings>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num14 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S2_v33 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text5 = Strings.GetDefault(model.characterLimitedDescription);
			fontSize = (int)text5;
		}
		_nameSubTitle.fontSize = fontSize;
		if (flag2)
		{
			nint num15 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v28 (Il2CppClass<Strings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num16 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v34 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v43 (System.Boolean)+20]");
			string text6 = Strings.GetDefault((string)0);
			if (text6 != null && text6.m_stringLength != 0)
			{
				_nameSubTitle.fontSize = (int)text6;
			}
		}
		nint num17 = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v54 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num18 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v67 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance2 = LimitedBoardPopupManager.instance;
		int currentThemeIndex = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		LimitedBoardPopupManager instance3 = LimitedBoardPopupManager.instance;
		UpdateCharacterSticker((Characters.CharacterId)currentThemeIndex, instance3._overwrittenBoardForNextShowing ? 1 : 0);
		LimitedBoardPopupManager instance4 = LimitedBoardPopupManager.instance;
		int currentThemeIndex2 = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		LimitedBoardPopupManager instance5 = LimitedBoardPopupManager.instance;
		OnCharacterUnlocked((Characters.CharacterId)currentThemeIndex2, instance5._overwrittenBoardForNextShowing ? 1 : 0);
		((DiscountButton)(object)_characterSelectButton).ShowOnSale((string)null, (string)null);
	}

	private void UpdateCharacterSticker(Characters.CharacterId charId, int index)
	{
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_019c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I4
		//IL_00be: Expected I, but got Obj
		nint num = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Outfits>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int themeCount = Outfits.GetThemeCount(charId);
		string text = _characterThemeShifter.tag;
		((GameObject)(object)text).tag = (string)themeCount;
		if (themeCount == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (Il2CppClass<Info.Outfits>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v28 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool index2 = Outfits.HasCharacter(charId);
		_characterThemeShifter.SelectButton(index2 ? 1 : 0);
		((UIMessageHelper)(object)_characterThemeShifter).ShowMessage((string)charId, (byte)index != 0);
	}

	private void OnCharacterUnlocked(Characters.CharacterId charId, int version)
	{
		//IL_025c: Expected I, but got Obj
		//IL_0272: Expected Obj, but got I
		//IL_0389: Expected I, but got Obj
		//IL_039f: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I4
		//IL_029c: Expected Obj, but got I4
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_03ca: Expected I, but got Obj
		//IL_03e0: Expected Obj, but got I
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_012c: Expected Obj, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0191: Expected I, but got Obj
		//IL_0318: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v76 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item(charId);
		nint num3 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15 (Il2CppClass<Info.Outfits>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v72 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((OutfitSet)charId).HasOutfitWithName((string)version);
		nint num5 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v68 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = CharacterManager.IsCollectionComplete(charId);
		object obj5;
		object obj6;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20 (System.Boolean)+1C]");
			object obj4;
			if ((nint)0 != 0)
			{
				obj4 = 0;
			}
			else
			{
				string titleForVideoAdPrize = ((CoinEarnerVideoAds)charId).GetTitleForVideoAdPrize((VideoAdPrizeType)version);
				obj4 = titleForVideoAdPrize ^ 1;
			}
			obj5 = obj4;
			obj6 = 0;
		}
		else
		{
			bool hasOnlineSettings = model.hasOnlineSettings;
			object obj7 = (flag2 ? 1 : 0) ^ 1;
			obj6 = hasOnlineSettings & obj7;
			obj5 = 0;
		}
		nint num7 = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v31 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v51 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
		Boards.BoardId currentBoardId = ((LimitedBoardPopupManager)null).currentBoardId;
		object obj9 = obj5 & 1;
		object obj10 = obj6 | obj9;
		if (obj10 != null)
		{
			if (obj5 != null)
			{
				_characterSelectButton.ShowLockedTokenContent(true);
			}
			else if (currentBoardId != Boards.BoardId.normal)
			{
				_characterSelectButton.ShowLockedTokenContent(true);
			}
		}
		else
		{
			_characterSelectButton.ShowLockedTokenContent(false);
		}
	}

	public LimitedCharacterPopup()
	{
		//IL_012b: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_00cb: Expected I, but got Obj
		bool isInstanced = UIScreenController.IsInstanced;
		bool isInstanced2 = UIScreenController.IsInstanced;
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v12 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v32 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+84]");
		bool flag = CharacterManager.IsCollectionComplete(Characters.CharacterId.slick);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+84]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (System.Boolean)+80]");
		bool flag2 = ((UserData)num3).StrictlyBetterThan((UserData)0);
		((DiscountButton)(object)_characterSelectButton).ShowOnSale((string)null, (string)null);
		object obj2 = flag & flag2;
		if (obj2 == null)
		{
			return;
		}
		nint num4 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v21 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v28 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+84]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (System.Boolean)+80]");
		CharacterManager.UnlockOutfit((Characters.CharacterId)num6, 0);
		UICharacterThemeShifter characterThemeShifter = _characterThemeShifter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+84]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (System.Boolean)+80]");
		((UIMessageHelper)(object)characterThemeShifter).ShowMessage((string)num7, false);
	}
}
