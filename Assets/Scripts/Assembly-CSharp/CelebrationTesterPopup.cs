using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Info;
using Missions;
using SYBO.Subway.Info;
using UI.Screens;
using UnityEngine;

public class CelebrationTesterPopup : UIScreen
{
	private SelectPopupButton _originPopupButton;

	private SelectPopupButton _typePopupButton;

	private SelectPopupButton _powerupPopupButton;

	private SelectPopupButton _charPopupButton;

	private SelectPopupButton _boardPopupButton;

	private SelectPopupButton _trophyPopupButton;

	private SelectPopupButton _awardPopupButton;

	private SelectPopupButton _amountPopupButton;

	private SelectPopupButton _topRunRankPopupButton;

	private UILabel buttonLabel;

	private GameObject charButton;

	private GameObject boardsButton;

	private GameObject powerupButtons;

	private GameObject trrankButton;

	private GameObject awardButton;

	private GameObject trophyButton;

	private UITable buttonTable;

	private static CelebrationReward _currentCelebrationReward;

	private unsafe void Start()
	{
		//IL_002f: Expected VT, but got Obj
		//IL_00b4: Expected VT, but got Obj
		//IL_0139: Expected VT, but got Obj
		//IL_01b9: Expected VT, but got Obj
		//IL_023e: Expected VT, but got Obj
		//IL_02be: Expected VT, but got Obj
		//IL_0343: Expected VT, but got Obj
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		currentCelebrationReward.characterOutfitIndex = 0;
		CelebrationReward currentCelebrationReward2 = _currentCelebrationReward;
		currentCelebrationReward2.awardTitle = "Award Title";
		SelectPopupButton originPopupButton = _originPopupButton;
		EventDelegate.Callback callback = default;
		callback._002Ector(this, (nint)__ldftn(CelebrationTesterPopup.OriginSelected));
		EventDelegate eventDelegate = EventDelegate.Add(originPopupButton.onChange, callback);
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CelebrationRewardOrigin));
		string[] names = Enum.GetNames(typeFromHandle);
		List<string> items = Enumerable.ToList(names);
		_originPopupButton.SetItems(items);
		SelectPopupButton typePopupButton = _typePopupButton;
		EventDelegate.Callback callback2 = default;
		callback2._002Ector(this, (nint)__ldftn(CelebrationTesterPopup.TypeSelected));
		EventDelegate eventDelegate2 = EventDelegate.Add(typePopupButton.onChange, callback2);
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CelebrationRewardType));
		string[] names2 = Enum.GetNames(typeFromHandle2);
		List<string> items2 = Enumerable.ToList(names2);
		_typePopupButton.SetItems(items2);
		SelectPopupButton powerupPopupButton = _powerupPopupButton;
		EventDelegate.Callback callback3 = default;
		callback3._002Ector(this, (nint)__ldftn(CelebrationTesterPopup.PowerupSelected));
		EventDelegate eventDelegate3 = EventDelegate.Add(powerupPopupButton.onChange, callback3);
		Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(PowerupType));
		string[] names3 = Enum.GetNames(typeFromHandle3);
		List<string> items3 = Enumerable.ToList(names3);
		_powerupPopupButton.SetItems(items3);
		SelectPopupButton charPopupButton = _charPopupButton;
		EventDelegate.Callback callback4 = default;
		callback4._002Ector(this, (nint)__ldftn(CelebrationTesterPopup.CharSelected));
		EventDelegate eventDelegate4 = EventDelegate.Add(charPopupButton.onChange, callback4);
		Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Characters.CharacterType));
		string[] names4 = Enum.GetNames(typeFromHandle4);
		List<string> items4 = Enumerable.ToList(names4);
		_charPopupButton.SetItems(items4);
		SelectPopupButton boardPopupButton = _boardPopupButton;
		EventDelegate.Callback callback5 = default;
		callback5._002Ector(this, (nint)__ldftn(CelebrationTesterPopup.BoardSelected));
		EventDelegate eventDelegate5 = EventDelegate.Add(boardPopupButton.onChange, callback5);
		Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Hoverboards.BoardType));
		string[] names5 = Enum.GetNames(typeFromHandle5);
		List<string> items5 = Enumerable.ToList(names5);
		_boardPopupButton.SetItems(items5);
		SelectPopupButton trophyPopupButton = _trophyPopupButton;
		EventDelegate.Callback callback6 = default;
		callback6._002Ector(this, (nint)__ldftn(CelebrationTesterPopup.OldTrophySelected));
		EventDelegate eventDelegate6 = EventDelegate.Add(trophyPopupButton.onChange, callback6);
		Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Trophies.Trophy));
		string[] names6 = Enum.GetNames(typeFromHandle6);
		List<string> items6 = Enumerable.ToList(names6);
		_trophyPopupButton.SetItems(items6);
		SelectPopupButton awardPopupButton = _awardPopupButton;
		EventDelegate.Callback callback7 = default;
		callback7._002Ector(this, (nint)__ldftn(CelebrationTesterPopup.AwardSelected));
		EventDelegate eventDelegate7 = EventDelegate.Add(awardPopupButton.onChange, callback7);
		Type typeFromHandle7 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(AwardTierType));
		string[] names7 = Enum.GetNames(typeFromHandle7);
		List<string> items7 = Enumerable.ToList(names7);
		_awardPopupButton.SetItems(items7);
		SelectPopupButton amountPopupButton = _amountPopupButton;
		EventDelegate.Callback callback8 = default;
		callback8._002Ector(this, (nint)__ldftn(CelebrationTesterPopup.NewAmountSelected));
		EventDelegate eventDelegate8 = EventDelegate.Add(amountPopupButton.onChange, callback8);
		SelectPopupButton topRunRankPopupButton = _topRunRankPopupButton;
		EventDelegate.Callback callback9 = default;
		callback9._002Ector(this, (nint)__ldftn(CelebrationTesterPopup.NewRankSelected));
		EventDelegate eventDelegate9 = EventDelegate.Add(topRunRankPopupButton.onChange, callback9);
		object text = "Disable";
		if (!Globals.DEBUG_USE_CELEBRATION_TESTER)
		{
			text = "Enable";
		}
		buttonLabel.text = (string)text;
	}

	public void OriginSelected()
	{
		//IL_0373: Expected VT, but got Obj
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CelebrationRewardOrigin));
		object obj = Enum.Parse(typeFromHandle, null, ignoreCase: true);
		throw new NullReferenceException();
	}

	public void TypeSelected()
	{
		//IL_0049: Expected VT, but got Obj
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CelebrationRewardType));
		object obj = Enum.Parse(typeFromHandle, null, ignoreCase: true);
		throw new NullReferenceException();
	}

	public void PowerupSelected()
	{
		//IL_0049: Expected VT, but got Obj
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(PowerupType));
		object obj = Enum.Parse(typeFromHandle, null, ignoreCase: true);
		throw new NullReferenceException();
	}

	public void CharSelected()
	{
		//IL_0049: Expected VT, but got Obj
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Characters.CharacterType));
		object obj = Enum.Parse(typeFromHandle, null, ignoreCase: true);
		throw new NullReferenceException();
	}

	public void BoardSelected()
	{
		//IL_0049: Expected VT, but got Obj
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Hoverboards.BoardType));
		object obj = Enum.Parse(typeFromHandle, null, ignoreCase: true);
		throw new NullReferenceException();
	}

	public void OldTrophySelected()
	{
		//IL_0049: Expected VT, but got Obj
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Trophies.Trophy));
		object obj = Enum.Parse(typeFromHandle, null, ignoreCase: true);
		throw new NullReferenceException();
	}

	public void AwardSelected()
	{
		//IL_0049: Expected VT, but got Obj
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(AwardTierType));
		object obj = Enum.Parse(typeFromHandle, null, ignoreCase: true);
		throw new NullReferenceException();
	}

	public void NewAmountSelected()
	{
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		int amount = int.Parse(null);
		currentCelebrationReward.amount = amount;
	}

	public void NewRankSelected()
	{
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		int rank = int.Parse(null);
		currentCelebrationReward.rank = rank;
		CelebrationReward currentCelebrationReward2 = _currentCelebrationReward;
		currentCelebrationReward2.score = 123543510;
		CelebrationReward currentCelebrationReward3 = _currentCelebrationReward;
		currentCelebrationReward3.weekNumber = 12;
	}

	public void ToggleDebugCelebration()
	{
		bool dEBUG_USE_CELEBRATION_TESTER = (byte)((Globals.DEBUG_USE_CELEBRATION_TESTER ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_USE_CELEBRATION_TESTER = dEBUG_USE_CELEBRATION_TESTER;
		object text = "Disable";
		if (!Globals.DEBUG_USE_CELEBRATION_TESTER)
		{
			text = "Enable";
		}
		buttonLabel.text = (string)text;
	}

	public static void RewardDebugCelebrationReward()
	{
		CelebrationReward currentCelebrationReward = _currentCelebrationReward;
		if (currentCelebrationReward.rewardType == CelebrationRewardType.specialBoard)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			CelebrationReward currentCelebrationReward2 = _currentCelebrationReward;
			instance.UnlockHoverboard(currentCelebrationReward2.boardType);
			BoardScreenManager instance2 = BoardScreenManager.Instance;
			instance2.forceRefreshOnBoardScreen__BackingField = true;
		}
		else
		{
			CelebrationReward currentCelebrationReward3 = _currentCelebrationReward;
			if (currentCelebrationReward3.rewardType == CelebrationRewardType.character)
			{
				PlayerInfo instance3 = PlayerInfo.Instance;
				CelebrationReward currentCelebrationReward4 = _currentCelebrationReward;
				CelebrationReward currentCelebrationReward5 = _currentCelebrationReward;
				Characters.Model model = Characters.characterData.get_Item(currentCelebrationReward5.characterType);
				instance3.CollectToken(currentCelebrationReward4.characterType, model.Price);
				CharacterScreen.forceRefreshOnCharacterScreen = true;
			}
		}
		RewardManager.AddRewardToUnlock(_currentCelebrationReward);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<CelebrationTesterPopup>)+104] (should have been resolved before IL gen)");
	}

	public override void Show()
	{
		base.Show();
	}

	public override void Hide()
	{
		base.Hide();
	}

	static CelebrationTesterPopup()
	{
		CelebrationReward celebrationReward = default;
		celebrationReward._002Ector();
		_currentCelebrationReward = celebrationReward;
	}
}
