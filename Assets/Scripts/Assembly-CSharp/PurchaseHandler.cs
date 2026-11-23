using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;
using UI;
using UI.Screens;

public class PurchaseHandler
{
	public class SyboInGameCurrencyPurchaseEventArgs(long purchaseNumber, string itemTitleId, InAppItemModel.ItemType itemType, long itemBalanceAfter, long amountReceived, ObtainableItemSource itemSource, InGameCurrencyType inGameCurrencyType, long currencyBalanceAfter, long price) : EventArgs
	{
		public readonly long PurchaseNumber = purchaseNumber;

		public readonly string ItemTitleId = itemTitleId;

		public readonly InAppItemModel.ItemType ItemType = itemType;

		public readonly long ItemBalanceAfter = itemBalanceAfter;

		public readonly long AmountReceived = amountReceived;

		public readonly ObtainableItemSource ItemSource = itemSource;

		public readonly InGameCurrencyType InGameCurrencyType = inGameCurrencyType;

		public readonly long CurrencyBalanceAfter = currencyBalanceAfter;

		public readonly long Price = price;
	}

	private HoverboardSelectButton btnBuyItemWithInapp;

	private static PurchaseHandler _instance;

	private Action<PowerupType, int> m_onUpgradePurchase;

	private Action<Characters.CharacterType, int> m_characterPurchased;

	private Action m__onFailedToPurchaseEventItemWithInapp;

	private EventHandler<SyboInGameCurrencyPurchaseEventArgs> m_OnIngameCurrencyPurchaseCompleted;

	public static PurchaseHandler Instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			PurchaseHandler result = _instance;
			if (!flag2)
			{
				PurchaseHandler purchaseHandler = default;
				_instance = purchaseHandler;
				result = purchaseHandler;
			}
			return result;
		}
	}

	public event Action<PowerupType, int> onUpgradePurchase
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 12;
			Delegate obj2 = this.m_onUpgradePurchase;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 12;
			Delegate obj2 = this.m_onUpgradePurchase;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<Characters.CharacterType, int> characterPurchased
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_characterPurchased;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_characterPurchased;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private event Action _onFailedToPurchaseEventItemWithInapp
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
			Delegate obj2 = this.m__onFailedToPurchaseEventItemWithInapp;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
			Delegate obj2 = this.m__onFailedToPurchaseEventItemWithInapp;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event EventHandler<SyboInGameCurrencyPurchaseEventArgs> OnIngameCurrencyPurchaseCompleted
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_OnIngameCurrencyPurchaseCompleted;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_OnIngameCurrencyPurchaseCompleted;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public void TriggerOnFailedToPurchaseEventItemWithInapp()
	{
		Action onFailedToPurchaseEventItemWithInapp = this.m__onFailedToPurchaseEventItemWithInapp;
		if (this.m__onFailedToPurchaseEventItemWithInapp != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			this.m__onFailedToPurchaseEventItemWithInapp = null;
		}
	}

	public void ResetOnFailedToPurchaseEventItemWithInapp()
	{
		this.m__onFailedToPurchaseEventItemWithInapp = null;
	}

	public void PurchaseCharacter(Characters.CharacterType characterType, int themeVersion, int priceOverride = -1)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0119: Expected I4, but got Obj
		//IL_04fb: Expected Obj, but got I4
		//IL_03f4: Expected Obj, but got I
		//IL_0454: Expected I8, but got I4
		//IL_0454: Expected I8, but got I4
		//IL_0454: Expected I8, but got I4
		CharacterScreenManager instance = CharacterScreenManager.Instance;
		Characters.Model model = Characters.characterData.get_Item(characterType);
		CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(characterType, themeVersion);
		int num;
		object obj2;
		if (themeForCharacter == null)
		{
			object obj = model + 20;
			bool flag = priceOverride < 1;
			num = model.Price;
			if (!flag)
			{
				num = priceOverride;
			}
			obj2 = obj;
		}
		else
		{
			object obj3 = themeForCharacter + 12;
			num = themeForCharacter.price;
			obj2 = obj3;
		}
		object obj4 = obj2 - 2;
		if ((nint)obj2 == 2 || ((nint)obj4 != 1 && (nint)obj4 != 2 && (nint)obj4 == 3))
		{
			CheckForDebugFreePurchases((PurchaseData.UnlockType)obj2, num);
			PlayerInfo instance2 = PlayerInfo.Instance;
			int amountOfCoins = instance2.amountOfCoins;
			bool flag2 = (nint)obj2 == 5;
			bool flag3 = !flag2;
			int num2 = amountOfCoins;
			InAppItemModel.ItemType type = InAppItemModel.ItemType.Coins;
			if (!flag3)
			{
				PlayerInfo instance3 = PlayerInfo.Instance;
				int amountOfKeys = instance3.amountOfKeys;
				num2 = amountOfKeys;
				type = InAppItemModel.ItemType.Keys;
			}
			if (num <= num2)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 == 5)
					{
						MissionsManager instance4 = MissionsManager.Instance;
						instance4.PlayerDidThis(MissionTarget.SpendKeys, num);
						PlayerInfo instance5 = PlayerInfo.Instance;
						int amountOfKeys2 = instance5.amountOfKeys;
						int amountOfKeys3 = amountOfKeys2 - num;
						instance5.amountOfKeys = amountOfKeys3;
					}
				}
				else
				{
					MissionsManager instance6 = MissionsManager.Instance;
					instance6.PlayerDidThis(MissionTarget.SpendCoin, num);
					PlayerInfo instance7 = PlayerInfo.Instance;
					int amountOfCoins2 = instance7.amountOfCoins;
					int amountOfCoins3 = amountOfCoins2 - num;
					instance7.amountOfCoins = amountOfCoins3;
					Characters.Model model2 = Characters.characterData.get_Item(characterType);
					if (model2.missionTargetKey != MissionTarget.none)
					{
						MissionsManager instance8 = MissionsManager.Instance;
						Characters.Model model3 = Characters.characterData.get_Item(characterType);
						instance8.PlayerDidThis(model3.missionTargetKey);
					}
				}
				PlayerInfo instance9 = PlayerInfo.Instance;
				InAppItemModel.ItemType itemType;
				if (themeForCharacter != null)
				{
					instance9.UnlockTheme(characterType, themeVersion);
					itemType = InAppItemModel.ItemType.CharacterOutfit;
				}
				else
				{
					instance9.CollectToken(characterType, model.Price);
					itemType = InAppItemModel.ItemType.Character;
				}
				((PurchaseHandler)characterType).SyboIncrementLastPurchaseNumberIfAboveZero(num);
				instance.CharacterPurchaseSuccessful(characterType, themeVersion);
				if (this.m_characterPurchased != null)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S4_v8 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v310 @ S4_v9+4] (should have been resolved before IL gen)");
				}
				string itemTitleId = GetItemTitleId(characterType, themeForCharacter);
				bool flag4 = (nint)obj2 == 5;
				InGameCurrencyType inGameCurrencyType = (InGameCurrencyType)((flag4 ? 1u : 0u) << 1);
				bool flag5 = (nint)obj2 == 2;
				InGameCurrencyType inGameCurrencyType2 = InGameCurrencyType.Coins;
				if (!flag5)
				{
					inGameCurrencyType2 = inGameCurrencyType;
				}
				long ingameCurrencyAmount = ((PurchaseHandler)(object)itemTitleId).GetIngameCurrencyAmount(inGameCurrencyType2);
				PlayerInfo instance10 = PlayerInfo.Instance;
				PlayerInfo instance11 = PlayerInfo.Instance;
				RaiseSyboInGameCurrencyPurchaseEvent(instance10._syboLastPurchaseNumber, itemTitleId, itemType, 1L, 1L, ObtainableItemSource.IngameCurrencyPurchase, inGameCurrencyType2, ingameCurrencyAmount, num, instance11._currentMissionSet);
				return;
			}
			InAppManager instance12 = InAppManager.instance;
			string senderName = Strings.Get(model.name);
			instance12.SuggestInAppPopup(num, senderName, type);
		}
		if (~(instance._purchaseInProgress ? 1u : 0u) == 0)
		{
			instance._purchaseInProgress = false;
			instance._characterPurchaseInitiator = CharacterScreenManager.CharacterPurchaseInitiator.none;
		}
	}

	public unsafe void StartPurchaseCharacterWithInapp(Characters.CharacterType characterType)
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(PurchaseHandler.OnPurchaseCharacterWithInappFailed));
		this.m__onFailedToPurchaseEventItemWithInapp = action;
		Characters.Model model = Characters.characterData.get_Item(characterType);
		string inappId = InAppData.ConvertCharacterTypeToDynamicPurchaseId(characterType);
		string characterName = Strings.Get(model.name);
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			InAppData.PrintDynamicIdsForCharacterTypeForAllPlatforms(characterType);
		}
		InAppManager instance = InAppManager.instance;
		instance.BuyExpiredLimitedCharacter(inappId, characterName, this);
	}

	public void OnPurchaseCharacterWithInappSucceded(Characters.CharacterType characterType, string inappId)
	{
		//IL_0021: Expected Obj, but got I
		CharacterScreenManager instance = CharacterScreenManager.Instance;
		instance.CharacterPurchaseSuccessful(characterType, 0);
		if (this.m_characterPurchased != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S4_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S4_v4+4] (should have been resolved before IL gen)");
		}
	}

	public void OnPurchaseCharacterWithInappFailed()
	{
		CharacterScreenManager instance = CharacterScreenManager.Instance;
		if (~(instance._purchaseInProgress ? 1u : 0u) == 0)
		{
			instance._purchaseInProgress = false;
			instance._characterPurchaseInitiator = CharacterScreenManager.CharacterPurchaseInitiator.none;
		}
	}

	private static void CheckForDebugFreePurchases(PurchaseData.UnlockType unlockType, int price)
	{
		//IL_0013: Expected Obj, but got I4
		if (~(Globals.DEBUG_FREE_PURCHASES ? 1u : 0u) != 0)
		{
			return;
		}
		object obj = unlockType - 2;
		if (unlockType != PurchaseData.UnlockType.Coins)
		{
			if ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3)
			{
				PlayerInfo instance = PlayerInfo.Instance;
				int amountOfKeys = instance.amountOfKeys;
				if (amountOfKeys < price)
				{
					PlayerInfo instance2 = PlayerInfo.Instance;
					int amountOfKeys2 = instance2.amountOfKeys;
					int amountOfKeys3 = amountOfKeys2 + price;
					instance2.amountOfKeys = amountOfKeys3;
				}
			}
		}
		else
		{
			PlayerInfo instance3 = PlayerInfo.Instance;
			int amountOfCoins = instance3.amountOfCoins;
			if (amountOfCoins < price)
			{
				PlayerInfo instance4 = PlayerInfo.Instance;
				int amountOfCoins2 = instance4.amountOfCoins;
				int amountOfCoins3 = amountOfCoins2 + price;
				instance4.amountOfCoins = amountOfCoins3;
			}
		}
	}

	public void OnPurchaseBoardWithInappSucceded(string inappId, Hoverboards.BoardType boardType)
	{
		if (btnBuyItemWithInapp != null)
		{
			btnBuyItemWithInapp.PurchaseSuccessful();
		}
	}

	public void OnPurchaseBoardWithInappFailed()
	{
		if (btnBuyItemWithInapp != null)
		{
			HoverboardSelectButton hoverboardSelectButton = btnBuyItemWithInapp;
			hoverboardSelectButton._purchaseInProgress = false;
		}
	}

	public unsafe void StartPurchaseBoardWithInapp(Hoverboards.BoardType boardType, HoverboardSelectButton sender)
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(PurchaseHandler.OnPurchaseBoardWithInappFailed));
		this.m__onFailedToPurchaseEventItemWithInapp = action;
		btnBuyItemWithInapp = sender;
		string inappId = InAppData.ConvertBoardTypeToDynamicPurchaseId(boardType);
		Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType);
		string boardName = Strings.Get(board.name);
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			InAppData.PrintDynamicIdsForBoardTypeForAllPlatforms(boardType);
		}
		InAppManager instance = InAppManager.instance;
		instance.BuyExpiredLimitedBoard(inappId, boardName, this);
	}

	public void PurchaseKeysIfNeeded(int amountToSaveMe)
	{
		InAppManager instance = InAppManager.instance;
		instance.SuggestInAppPopup(amountToSaveMe, "Keys popup", InAppItemModel.ItemType.Keys);
	}

	public void PurchaseHoverboard(Hoverboards.BoardType boardType, HoverboardSelectButton sender)
	{
		//IL_013a: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		//IL_00f0: Expected I8, but got I4
		//IL_00f0: Expected I8, but got I4
		//IL_00f0: Expected I8, but got I4
		Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType);
		if (MakeHoverboardPurchase(boardType, board))
		{
			sender.PurchaseSuccessful();
			bool flag = board.unlockType == PurchaseData.UnlockType.Keys;
			InGameCurrencyType inGameCurrencyType = (InGameCurrencyType)((flag ? 1u : 0u) << 1);
			bool flag2 = board.unlockType == PurchaseData.UnlockType.Coins;
			InGameCurrencyType inGameCurrencyType2 = InGameCurrencyType.Coins;
			if (!flag2)
			{
				inGameCurrencyType2 = inGameCurrencyType;
			}
			long ingameCurrencyAmount = ((PurchaseHandler)boardType).GetIngameCurrencyAmount(inGameCurrencyType2);
			((PurchaseHandler)boardType).SyboIncrementLastPurchaseNumberIfAboveZero(board.price);
			PlayerInfo instance = PlayerInfo.Instance;
			string itemTitleId = GetItemTitleId(boardType);
			PlayerInfo instance2 = PlayerInfo.Instance;
			RaiseSyboInGameCurrencyPurchaseEvent(instance._syboLastPurchaseNumber, itemTitleId, InAppItemModel.ItemType.Board, 1L, 1L, ObtainableItemSource.IngameCurrencyPurchase, inGameCurrencyType2, ingameCurrencyAmount, board.price, instance2._currentMissionSet);
		}
		else
		{
			sender._purchaseInProgress = false;
		}
	}

	private static bool MakeHoverboardPurchase(Hoverboards.BoardType boardType, Hoverboards.Board boardData)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfCoins = instance.amountOfCoins;
		bool flag = boardData.unlockType == PurchaseData.UnlockType.Keys;
		bool flag2 = !flag;
		int num = amountOfCoins;
		MissionTarget myTask = MissionTarget.SpendCoin;
		InAppItemModel.ItemType type = InAppItemModel.ItemType.Coins;
		if (!flag2)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			int amountOfKeys = instance2.amountOfKeys;
			num = amountOfKeys;
			myTask = MissionTarget.SpendKeys;
			type = InAppItemModel.ItemType.Keys;
		}
		if (~(Globals.DEBUG_FREE_PURCHASES ? 1u : 0u) == 0 && num < boardData.price)
		{
			int num2 = num + boardData.price;
			num = num2;
		}
		int num3;
		if (num >= boardData.price)
		{
			MissionsManager instance3 = MissionsManager.Instance;
			instance3.PlayerDidThis(myTask, boardData.price);
			PlayerInfo instance4 = PlayerInfo.Instance;
			instance4.UnlockHoverboard(boardType);
			num3 = num - boardData.price;
		}
		else
		{
			InAppManager instance5 = InAppManager.instance;
			string senderName = Strings.Get(boardData.name);
			instance5.SuggestInAppPopup(boardData.price, senderName, type);
			num3 = num;
		}
		PlayerInfo instance6 = PlayerInfo.Instance;
		if (boardData.unlockType == PurchaseData.UnlockType.Keys)
		{
			instance6.amountOfKeys = num3;
		}
		else
		{
			instance6.amountOfCoins = num3;
		}
		return num >= boardData.price;
	}

	public void PurchaseHoverboardTheme(Hoverboards.BoardType boardType, int themeIndex, HoverboardSelectButton sender)
	{
		//IL_014e: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_0104: Expected I8, but got I4
		//IL_0104: Expected I8, but got I4
		//IL_0104: Expected I8, but got I4
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(boardType);
		HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(themeIndex);
		if (MakeHoverboardThemePurchase(boardType, hoverboardTheme))
		{
			sender.PurchaseSuccessful(isBoardTheme: true, themeIndex);
			bool flag = hoverboardTheme.unlockType == PurchaseData.UnlockType.Keys;
			InGameCurrencyType inGameCurrencyType = (InGameCurrencyType)((flag ? 1u : 0u) << 1);
			bool flag2 = hoverboardTheme.unlockType == PurchaseData.UnlockType.Coins;
			InGameCurrencyType inGameCurrencyType2 = InGameCurrencyType.Coins;
			if (!flag2)
			{
				inGameCurrencyType2 = inGameCurrencyType;
			}
			long ingameCurrencyAmount = ((PurchaseHandler)boardType).GetIngameCurrencyAmount(inGameCurrencyType2);
			((PurchaseHandler)boardType).SyboIncrementLastPurchaseNumberIfAboveZero(hoverboardTheme.price);
			PlayerInfo instance = PlayerInfo.Instance;
			string itemTitleId = GetItemTitleId(boardType, hoverboardTheme);
			PlayerInfo instance2 = PlayerInfo.Instance;
			RaiseSyboInGameCurrencyPurchaseEvent(instance._syboLastPurchaseNumber, itemTitleId, InAppItemModel.ItemType.BoardAbility, 1L, 1L, ObtainableItemSource.IngameCurrencyPurchase, inGameCurrencyType2, ingameCurrencyAmount, hoverboardTheme.price, instance2._currentMissionSet);
		}
		else
		{
			sender._purchaseInProgress = false;
		}
	}

	private static bool MakeHoverboardThemePurchase(Hoverboards.BoardType boardType, HoverboardThemes.HoverboardTheme ht)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfCoins = instance.amountOfCoins;
		bool flag = ht.unlockType == PurchaseData.UnlockType.Keys;
		bool flag2 = !flag;
		int num = amountOfCoins;
		MissionTarget myTask = MissionTarget.SpendCoin;
		InAppItemModel.ItemType type = InAppItemModel.ItemType.Coins;
		if (!flag2)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			int amountOfKeys = instance2.amountOfKeys;
			num = amountOfKeys;
			myTask = MissionTarget.SpendKeys;
			type = InAppItemModel.ItemType.Keys;
		}
		if (~(Globals.DEBUG_FREE_PURCHASES ? 1u : 0u) == 0 && num < ht.price)
		{
			int num2 = num + ht.price;
			num = num2;
		}
		int num3;
		if (num >= ht.price)
		{
			MissionsManager instance3 = MissionsManager.Instance;
			instance3.PlayerDidThis(myTask, ht.price);
			PlayerInfo instance4 = PlayerInfo.Instance;
			instance4._hoverboardCustomizationData.SetThemeAcquired(boardType, ht.identifier);
			PlayerInfo instance5 = PlayerInfo.Instance;
			instance5._hoverboardCustomizationData.SetThemeActive(boardType, ht.identifier, active: true);
			num3 = num - ht.price;
		}
		else
		{
			InAppManager instance6 = InAppManager.instance;
			string senderName = Strings.Get(ht.title);
			instance6.SuggestInAppPopup(ht.price, senderName, type);
			num3 = num;
		}
		PlayerInfo instance7 = PlayerInfo.Instance;
		if (ht.unlockType == PurchaseData.UnlockType.Keys)
		{
			instance7.amountOfKeys = num3;
		}
		else
		{
			instance7.amountOfCoins = num3;
		}
		return num >= ht.price;
	}

	public void PurchaseUpgrade(PowerupType type, IBuyButton sender)
	{
		//IL_0056: Expected I, but got Obj
		//IL_0024: Expected I, but got Obj
		NullReferenceException ex = new NullReferenceException();
		Action action = default;
		action._002Ector(sender, (IntPtr)ex);
		NullReferenceException ex2 = new NullReferenceException();
		Action action2 = default;
		action2._002Ector(sender, (IntPtr)ex2);
		PurchaseUpgrade(type, action, action2);
	}

	public void PurchaseUpgrade(PowerupType powerupType, Action onPurchaseSuccessful, Action onPurchaseFailure)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected Obj, but got Unknown
		//IL_074a: Expected Obj, but got I4
		//IL_0677: Expected I8, but got I4
		//IL_0677: Expected I8, but got I4
		//IL_0677: Expected I8, but got I4
		//IL_0677: Expected I8, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		Upgrade upgrade = Upgrades.upgrades.get_Item(powerupType);
		Upgrade upgrade2 = Upgrades.upgrades.get_Item(powerupType);
		int tier;
		if (upgrade.numberOfTiers != 0)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			int currentTier = instance.GetCurrentTier(powerupType);
			tier = currentTier + 1;
		}
		else
		{
			tier = 0;
		}
		int price = upgrade2.getPrice(tier);
		if (~(Globals.DEBUG_FREE_PURCHASES ? 1u : 0u) == 0)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			int amountOfCoins = instance2.amountOfCoins;
			if (amountOfCoins < price)
			{
				PlayerInfo instance3 = PlayerInfo.Instance;
				int amountOfCoins2 = instance3.amountOfCoins;
				int amountOfCoins3 = amountOfCoins2 + price;
				instance3.amountOfCoins = amountOfCoins3;
			}
		}
		PlayerInfo instance4 = PlayerInfo.Instance;
		int amountOfCoins4 = instance4.amountOfCoins;
		PlayerInfo instance5;
		int num;
		if (amountOfCoins4 >= price)
		{
			instance5 = PlayerInfo.Instance;
			object obj3 = powerupType - 1;
			if (powerupType != PowerupType.hoverboard)
			{
				if ((nint)obj3 == 1)
				{
					goto IL_0557;
				}
				if ((nint)obj3 != 2)
				{
					if ((nint)obj3 != 3)
					{
						if ((nint)obj3 == 4)
						{
							goto IL_0557;
						}
						if ((nint)obj3 != 5 && (nint)obj3 != 6 && (nint)obj3 != 7)
						{
							if ((nint)obj3 == 8)
							{
								goto IL_0557;
							}
							if ((nint)obj3 != 9)
							{
								if ((nint)obj3 != 10)
								{
									if ((nint)obj3 != 11)
									{
										if ((nint)obj3 != 12)
										{
											if ((nint)obj3 != 13 && (nint)obj3 == 14)
											{
												goto IL_0314;
											}
											goto IL_0557;
										}
										MissionsManager instance6 = MissionsManager.Instance;
										instance6.PlayerDidThis(MissionTarget.SpendCoin, price, 2);
										num = 1;
									}
									else
									{
										MissionsManager instance7 = MissionsManager.Instance;
										instance7.PlayerDidThis(MissionTarget.SpendCoin, price, 1);
										num = 1;
									}
								}
								else
								{
									MissionsManager instance8 = MissionsManager.Instance;
									instance8.PlayerDidThis(MissionTarget.SpendCoin, price, 0);
									num = 1;
								}
								goto IL_0722;
							}
						}
						PlayerInfo instance9 = PlayerInfo.Instance;
						instance9.IncreasePowerupTier(powerupType);
						PlayerInfo instance10 = PlayerInfo.Instance;
						int currentTier2 = instance10.GetCurrentTier(powerupType);
						MissionsManager instance11 = MissionsManager.Instance;
						instance11.PlayerDidThis(MissionTarget.SpendCoin, price);
						MissionsManager instance12 = MissionsManager.Instance;
						instance12.PlayerDidThis(MissionTarget.HaveUpgrades);
						num = currentTier2;
					}
					else
					{
						MissionsManager instance13 = MissionsManager.Instance;
						instance13.PlayerDidThis(MissionTarget.SpendCoin, price);
						MissionsManager instance14 = MissionsManager.Instance;
						instance14.PlayerDidThis(MissionTarget.BuyMysterybox);
						num = 1;
					}
					goto IL_0722;
				}
			}
			goto IL_0314;
		}
		InAppManager instance15 = InAppManager.instance;
		Upgrade upgrade3 = Upgrades.upgrades.get_Item(powerupType);
		string senderName = Strings.Get(upgrade3.name);
		instance15.SuggestInAppPopup(price, senderName, InAppItemModel.ItemType.Coins);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: onPurchaseFailure.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		return;
		IL_0557:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj4 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
		IL_0722:
		PlayerInfo instance16 = PlayerInfo.Instance;
		int amountOfCoins5 = instance16.amountOfCoins;
		int amountOfCoins6 = amountOfCoins5 - price;
		instance16.amountOfCoins = amountOfCoins6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: onPurchaseSuccessful.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		Action<PowerupType, int> action = this.m_onUpgradePurchase;
		if (this.m_onUpgradePurchase != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v354 @ S0_v73 (System.Action`2<PowerupType, System.Int32>)+C] (should have been resolved before IL gen)");
		}
		((PurchaseHandler)powerupType).SyboIncrementLastPurchaseNumberIfAboveZero(price);
		PlayerInfo instance17 = PlayerInfo.Instance;
		string itemTitleId = GetItemTitleId(powerupType);
		InAppItemModel.ItemType itemTypeFromPowerup = InAppItemModel.GetItemTypeFromPowerup(powerupType);
		PlayerInfo instance18 = PlayerInfo.Instance;
		int amountOfCoins7 = instance18.amountOfCoins;
		RaiseSyboInGameCurrencyPurchaseEvent(instance17._syboLastPurchaseNumber, itemTitleId, itemTypeFromPowerup, num, 1L, ObtainableItemSource.IngameCurrencyPurchase, InGameCurrencyType.Coins, amountOfCoins7, price, instance5._currentMissionSet);
		return;
		IL_0314:
		PlayerInfo instance19 = PlayerInfo.Instance;
		instance19.IncreaseUpgradeAmount(powerupType);
		PlayerInfo instance20 = PlayerInfo.Instance;
		int upgradeAmount = instance20.GetUpgradeAmount(powerupType);
		MissionsManager instance21 = MissionsManager.Instance;
		instance21.PlayerDidThis(MissionTarget.SpendCoin, price);
		bool flag = powerupType != PowerupType.headstart2000;
		num = upgradeAmount;
		if (!flag)
		{
			MissionsManager instance22 = MissionsManager.Instance;
			instance22.PlayerDidThis(MissionTarget.HaveHeadStartLarge);
			num = upgradeAmount;
		}
		goto IL_0722;
	}

	private void RaiseSyboInGameCurrencyPurchaseEvent(long purchaseNumber, string itemTitleId, InAppItemModel.ItemType itemType, long itemBalanceAfter, long amountReceived, ObtainableItemSource itemSource, InGameCurrencyType inGameCurrencyType, long currencyBalanceAfter, long price, int missionSetBeforePurchase)
	{
		//IL_001c: Expected I8, but got I4
		//IL_00ac: Expected I8, but got I4
		if (this.m_OnIngameCurrencyPurchaseCompleted != null)
		{
			bool flag = itemType == InAppItemModel.ItemType.SkipMission;
			long itemBalanceAfter2 = missionSetBeforePurchase;
			if (!flag)
			{
				itemBalanceAfter2 = itemBalanceAfter;
			}
			bool flag2 = price == 0;
			ObtainableItemSource itemSource2 = ObtainableItemSource.FreeUnlock;
			if (!flag2)
			{
				itemSource2 = itemSource;
			}
			InGameCurrencyType inGameCurrencyType2 = InGameCurrencyType.None;
			if (!flag2)
			{
				inGameCurrencyType2 = inGameCurrencyType;
			}
			long currencyBalanceAfter2 = 0L;
			if (!flag2)
			{
				currencyBalanceAfter2 = currencyBalanceAfter;
			}
			SyboInGameCurrencyPurchaseEventArgs e = default;
			e._002Ector(purchaseNumber, itemTitleId, itemType, itemBalanceAfter2, amountReceived, itemSource2, inGameCurrencyType2, currencyBalanceAfter2, price);
			EventHandler<SyboInGameCurrencyPurchaseEventArgs> onIngameCurrencyPurchaseCompleted = this.m_OnIngameCurrencyPurchaseCompleted;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S0_v12 (System.EventHandler`1<PurchaseHandler+SyboInGameCurrencyPurchaseEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	public static string GetItemTitleId(PowerupType powerupType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		object obj3 = powerupType - 1;
		if ((nint)obj3 <= 14)
		{
			object obj4 = 1 << (int)obj3;
			object obj5 = obj4 & 0;
			if (obj5 != null)
			{
				_ = -1;
				obj = (Enum)(object)typeof(PowerupType);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
				_ = 0;
				string text = obj.ToString();
				return text.ToLowerInvariant();
			}
			if ((nint)obj3 == 2)
			{
				return "headstart";
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		obj = powerupType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	public static string GetItemTitleId(Characters.CharacterType characterType, CharacterTheme characterTheme = null)
	{
		Characters.Model model = Characters.characterData.get_Item(characterType);
		string text = Strings.Get(model.name);
		string text2 = text.ToLowerInvariant();
		if (characterTheme != null)
		{
			string text3 = Strings.Get(characterTheme.title);
			string text4 = text3.ToLowerInvariant();
			text2 = text2 + "_" + text4;
		}
		return text2;
	}

	public static string GetItemTitleId(Hoverboards.BoardType boardType)
	{
		Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType);
		string text = Strings.Get(board.name);
		return text.ToLowerInvariant();
	}

	public static string GetItemTitleId(Hoverboards.BoardType boardType, HoverboardThemes.HoverboardTheme boardTheme)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		Hoverboards.Board board = Hoverboards.boardData.get_Item(boardType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		string text = Strings.Get(board.name);
		string text2 = text.ToLowerInvariant();
		throw new ArrayTypeMismatchException();
	}

	public static string GetItemTitleId(InAppItemModel.ItemType itemType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		object obj3 = itemType - 5;
		bool flag = (nint)obj3 >= 2;
		object obj4 = itemType - 9;
		if ((nint)obj4 <= 2)
		{
			flag = false;
		}
		if (!flag)
		{
			_ = -1;
			obj = (Enum)(object)typeof(InAppItemModel.ItemType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text = obj.ToString();
			return text.ToLowerInvariant();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		obj = itemType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	public unsafe static bool TryGetItemTitleId(InAppItemModel item, out string itemTitleId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0044: Expected VT, but got Obj
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0091: Expected Obj, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_08c1: Expected Obj, but got I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected I4, but got Unknown
		//IL_08a5: Expected Obj, but got I4
		//IL_07f9: Expected Obj, but got I
		//IL_069d: Expected Obj, but got I
		//IL_06c8: Expected Obj, but got I
		//IL_06ed: Expected Obj, but got I
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_ = 0;
		ref string reference = ref *(string*)string.Empty;
		if (item == null || item.ItemId__BackingField == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(InAppItemModel));
			object obj3 = typeFromHandle - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ S2_v5+BC] (should have been resolved before IL gen)");
			throw new ArrayTypeMismatchException();
		}
		object obj4 = item.InAppItemType__BackingField - 1;
		if (item.InAppItemType__BackingField != InAppItemModel.ItemType.Character)
		{
			if ((nint)obj4 != 1)
			{
				if ((nint)obj4 == 2)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj5 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj6 = default;
								reference = ref *(string*)obj6;
								goto IL_0903;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					goto IL_059d;
				}
				if ((nint)obj4 != 3)
				{
					if ((nint)obj4 != 4 && (nint)obj4 != 5 && (nint)obj4 != 6 && (nint)obj4 != 7)
					{
						if ((nint)obj4 != 8 && (nint)obj4 != 9 && (nint)obj4 != 10)
						{
							goto IL_04b2;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_059d;
						}
						object obj7 = default;
						reference = ref *(string*)obj7;
					}
					else
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_059d;
						}
						object obj8 = default;
						reference = ref *(string*)obj8;
					}
					goto IL_0903;
				}
			}
			goto IL_04b2;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			object obj9 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj10 = default;
					reference = ref *(string*)obj10;
					goto IL_0903;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_059d;
		IL_0903:
		string text = itemTitleId.Replace("_", string.Empty);
		reference = ref *(string*)text;
		string text2 = itemTitleId;
		object obj11;
		if (itemTitleId != null)
		{
			obj11 = 0;
			if (text2._stringLength != 0)
			{
				goto IL_095a;
			}
		}
		obj11 = 1;
		goto IL_095a;
		IL_094a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0903;
		IL_04b2:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = item.ItemId__BackingField;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					reference = ref *(string*)string.Empty;
					goto IL_0903;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_059d;
		IL_095a:
		return (byte)(obj11 ^ 1) != 0;
		IL_059d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj12 = default;
		object obj13 = default;
		bool flag = obj12 != obj13;
		object obj15 = default;
		object obj14 = obj15;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj17 = default;
				object obj16 = obj17;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj18 = default;
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj19 = (nint)0 << 2;
						object obj20 = obj + obj19;
						obj20 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj21 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj22 = (nint)0 << 2;
						object obj23 = obj22 + obj;
						object obj24 = obj23 - 4;
						object obj25 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj26 = obj17;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj14 = 0;
					if (flag2)
					{
						goto IL_094a;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj27 = default;
			obj14 = obj27;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj14 = obj27;
			}
		}
		goto IL_094a;
	}

	private InGameCurrencyType GetIngameCurrencyTypeFromUnlockType(PurchaseData.UnlockType unlockType)
	{
		bool flag = unlockType == PurchaseData.UnlockType.Keys;
		InGameCurrencyType inGameCurrencyType = (InGameCurrencyType)((flag ? 1u : 0u) << 1);
		bool flag2 = unlockType == PurchaseData.UnlockType.Coins;
		InGameCurrencyType result = InGameCurrencyType.Coins;
		if (!flag2)
		{
			result = inGameCurrencyType;
		}
		return result;
	}

	private long GetIngameCurrencyAmount(InGameCurrencyType unlockType)
	{
		//IL_0075: Expected Obj, but got I4
		//IL_0042: Expected I8, but got I4
		//IL_0097: Expected I8, but got I4
		object obj = unlockType - 1;
		if (unlockType != InGameCurrencyType.Coins)
		{
			int amountOfKeys = default;
			if ((nint)obj == 1)
			{
				PlayerInfo instance = PlayerInfo.Instance;
				amountOfKeys = instance.amountOfKeys;
			}
			return amountOfKeys;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		return instance2.amountOfCoins;
	}

	private void SyboIncrementLastPurchaseNumberIfAboveZero(int price)
	{
		if (price >= 1)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			long syboLastPurchaseNumber = instance._syboLastPurchaseNumber + 1;
			instance._dirty = true;
			instance._syboLastPurchaseNumber = syboLastPurchaseNumber;
		}
	}
}
