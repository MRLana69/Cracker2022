using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Missions;
using UI;
using UI.Screens;
using UnityEngine;
using UnityEngine.UI;

public class BreadCrumbHelper : MonoBehaviour
{
	private enum BreadCrumbStates
	{
		inactive,
		giftCharacter,
		giftBoard,
		boardEventActive,
		expiredLimitedCharacter,
		biggerJackpot,
		earnKeys,
		collectAward,
		expiredLimitedBoard,
		topRun,
		characterDay
	}

	private enum BreadCrumbLocations
	{
		meButton,
		shopButton,
		hoverboardsButton,
		charactersButton,
		upgradesFooter,
		upgradesScroll,
		earnCoinsFooterButton,
		earnCoinsVideoButton,
		mysteryBoxPrizeList,
		awardsButton,
		friendsButton,
		topRunButton,
		topRunTab
	}

	private Image awardIcon;

	private BreadCrumbStates _currentState;

	private BreadCrumbLocations _currentLocation;

	private unsafe void OnEnable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(BreadCrumbHelper.SetupBreadCrumbState));
		SSEventsManagerController.OnSSEventStartedHandler += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(BreadCrumbHelper.setLabelsDisabled));
		SSEventsManagerController.OnSSEventFinishedHandler += action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(BreadCrumbHelper.DisableEventBreadcrumb));
		UIScreenController.OnApplicationResumed += action3;
		SetupBreadCrumbState();
	}

	private unsafe void OnDisable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(BreadCrumbHelper.SetupBreadCrumbState));
		SSEventsManagerController.OnSSEventStartedHandler -= action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(BreadCrumbHelper.setLabelsDisabled));
		SSEventsManagerController.OnSSEventFinishedHandler -= action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(BreadCrumbHelper.DisableEventBreadcrumb));
		UIScreenController.OnApplicationResumed -= action3;
	}

	public void SetupBreadCrumbState()
	{
		//IL_076c: Expected Obj, but got I4
		//IL_0797: Expected Obj, but got I4
		//IL_060a: Expected Obj, but got I4
		_currentState = BreadCrumbStates.inactive;
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		SSEventsManagerController instance2 = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance2.GetActiveEventManager();
		BreadCrumbStates currentState;
		if (_currentLocation != BreadCrumbLocations.meButton)
		{
			bool flag = _currentLocation == BreadCrumbLocations.shopButton;
			BreadCrumbLocations currentLocation = _currentLocation;
			if (!flag)
			{
				if (_currentLocation != BreadCrumbLocations.hoverboardsButton)
				{
					currentLocation = _currentLocation;
				}
				else
				{
					if (!topScreenName.Equals("BoardScreen"))
					{
						SSEventsManagerController instance3 = SSEventsManagerController.instance;
						if (!instance3.HasTheCurrentEventBeenTried())
						{
							if (activeEventManager == null)
							{
								goto IL_02d0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							object obj = default;
							bool flag2 = (nint)obj == 1;
							currentState = BreadCrumbStates.boardEventActive;
							if (!flag2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
								object obj2 = default;
								bool flag3 = (nint)obj2 == 6;
								currentState = BreadCrumbStates.expiredLimitedBoard;
								if (!flag3)
								{
									goto IL_02d0;
								}
							}
							goto IL_06fa;
						}
					}
					currentLocation = _currentLocation;
				}
			}
			if (currentLocation == BreadCrumbLocations.charactersButton)
			{
				if (!topScreenName.Equals("CharacterScreen"))
				{
					if (activeEventManager == null)
					{
						goto IL_042f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj3 = default;
					bool flag4 = (nint)obj3 == 3;
					currentState = BreadCrumbStates.expiredLimitedCharacter;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj4 = default;
						bool flag5 = (nint)obj4 == 7;
						currentState = BreadCrumbStates.characterDay;
						if (!flag5)
						{
							goto IL_042f;
						}
					}
					goto IL_06fa;
				}
				currentLocation = _currentLocation;
			}
			if (currentLocation == BreadCrumbLocations.awardsButton)
			{
				if (!topScreenName.Equals("AwardsScreen"))
				{
					AwardsManager instance4 = AwardsManager.instance;
					List<Award> awardsForState = instance4.GetAwardsForState(AwardState.Collectible);
					bool flag6 = awardsForState._size >= 1;
					currentState = BreadCrumbStates.collectAward;
					if (flag6)
					{
						goto IL_06fa;
					}
					goto IL_0757;
				}
				currentLocation = _currentLocation;
			}
			object obj5 = currentLocation - 1;
			if (currentLocation == BreadCrumbLocations.shopButton || ((nint)obj5 != 1 && (nint)obj5 != 2 && (nint)obj5 == 3))
			{
				if (!topScreenName.Equals("UpgradesUI_shop"))
				{
					goto IL_0556;
				}
				currentLocation = _currentLocation;
			}
			object obj6 = currentLocation - 5;
			if (currentLocation == BreadCrumbLocations.upgradesScroll)
			{
				goto IL_0556;
			}
			if ((nint)obj6 != 1)
			{
				if ((nint)obj6 == 2)
				{
					goto IL_05c8;
				}
				if ((nint)obj6 == 3)
				{
					goto IL_0556;
				}
			}
			else if (!topScreenName.Equals("EarnCoinsScreen"))
			{
				goto IL_05c8;
			}
			goto IL_05fa;
		}
		AwardsManager instance5 = AwardsManager.instance;
		List<Award> awardsForState2 = instance5.GetAwardsForState(AwardState.Collectible);
		bool flag7 = awardsForState2._size > 0;
		currentState = BreadCrumbStates.collectAward;
		if (!flag7)
		{
			if (activeEventManager == null)
			{
				goto IL_01c3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj7 = default;
			bool flag8 = (nint)obj7 == 1;
			currentState = BreadCrumbStates.boardEventActive;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj8 = default;
				bool flag9 = (nint)obj8 == 3;
				currentState = BreadCrumbStates.expiredLimitedCharacter;
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj9 = default;
					bool flag10 = (nint)obj9 == 7;
					currentState = BreadCrumbStates.characterDay;
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj10 = default;
						bool flag11 = (nint)obj10 == 6;
						currentState = BreadCrumbStates.expiredLimitedBoard;
						if (!flag11)
						{
							goto IL_01c3;
						}
					}
				}
			}
		}
		goto IL_06fa;
		IL_02d0:
		bool flag12 = ShouldShowBoardsGiftSticker();
		currentState = BreadCrumbStates.giftBoard;
		if (flag12)
		{
			goto IL_06fa;
		}
		goto IL_0757;
		IL_0556:
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj11 = default;
			bool flag13 = (nint)obj11 == 4;
			currentState = BreadCrumbStates.biggerJackpot;
			if (flag13)
			{
				goto IL_06fa;
			}
		}
		goto IL_0757;
		IL_05fa:
		object obj12 = _currentLocation - 10;
		if ((nint)obj12 <= 2 && TopRunRewardHelper.ShouldShowResults())
		{
			if (topScreenName.Equals("GameoverUI"))
			{
				UIScreenController instance6 = UIScreenController.Instance;
				UIScreen screenFromCache = instance6.GetScreenFromCache(topScreenName);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				UnityEngine.Object obj13 = default;
				bool flag14 = obj13 != null;
				currentState = BreadCrumbStates.topRun;
				if (flag14)
				{
					goto IL_06fa;
				}
			}
			else
			{
				bool flag15 = topScreenName.Equals("TopRunUI");
				currentState = BreadCrumbStates.topRun;
				if (!flag15)
				{
					goto IL_06fa;
				}
			}
		}
		goto IL_0757;
		IL_05c8:
		VideoAdsManager instance7 = VideoAdsManager.instance;
		bool flag16 = instance7.IsVideoForKeysAvailable();
		currentState = BreadCrumbStates.earnKeys;
		if (!flag16)
		{
			goto IL_05fa;
		}
		goto IL_06fa;
		IL_042f:
		bool flag17 = ShouldShowCharactersGiftSticker();
		currentState = BreadCrumbStates.giftCharacter;
		if (flag17)
		{
			goto IL_06fa;
		}
		goto IL_0757;
		IL_06fa:
		_currentState = currentState;
		goto IL_0757;
		IL_01c3:
		bool flag18 = ShouldShowBoardsGiftSticker();
		currentState = BreadCrumbStates.giftBoard;
		if (!flag18)
		{
			bool flag19 = ShouldShowCharactersGiftSticker();
			currentState = BreadCrumbStates.giftCharacter;
			if (!flag19)
			{
				goto IL_0757;
			}
		}
		goto IL_06fa;
		IL_0757:
		SetupBreadCrumb();
	}

	private bool ShouldShowBoardsGiftSticker()
	{
		if (HoverboardStickerManager.ShouldShowHoverboardStickerFlow())
		{
			return HoverboardStickerManager.IsAnyGiftBoard();
		}
		return false;
	}

	private bool ShouldShowCharactersGiftSticker()
	{
		if (CharacterStickerManager.ShouldShowCharacterThemesStickerFlow())
		{
			return CharacterStickerManager.IsAnyCharacterWithFreeTheme();
		}
		return false;
	}

	private void SetupBreadCrumb()
	{
		if (_currentState == BreadCrumbStates.inactive)
		{
			setLabelsDisabled();
		}
		else
		{
			setLabelsEnabled();
		}
	}

	private void setLabelsEnabled()
	{
		if (awardIcon != null)
		{
			GameObject gameObject = awardIcon.gameObject;
			bool active = _currentState == BreadCrumbStates.collectAward;
			gameObject.SetActive(active);
		}
	}

	public void setLabelsDisabled()
	{
		if (awardIcon != null)
		{
			GameObject gameObject = awardIcon.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private void DisableEventBreadcrumb()
	{
		//IL_0092: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy && activeEventManager == null && _currentState <= BreadCrumbStates.characterDay)
		{
			object obj = 1 << (int)_currentState;
			object obj2 = obj & 0x438;
			if (obj2 != null)
			{
				setLabelsDisabled();
			}
		}
	}
}
