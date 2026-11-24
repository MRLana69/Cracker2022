using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cloud;
using Cpp2ILInjected;
using Data.DebugUtil;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo.Common.Ads;
using Kiloo.Common.Backend.Cloud;
using Missions;
using SYBO.Subway.Info;
using UI;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;

public class PurchaseHandler
{
	public class SyboInGameCurrencyPurchaseEventArgs : EventArgs
	{
		public readonly long PurchaseId;

		public readonly string ItemTitleId;

		public readonly InAppItemModel.ItemType ItemType;

		public readonly long ItemBalanceAfter;

		public readonly long AmountReceived;

		public readonly ObtainableItemSource ItemSource;

		public readonly InGameCurrencyType InGameCurrencyType;

		public readonly long CurrencyBalanceAfter;

		public readonly long Price;

		public readonly long InstanceId;

		public SyboInGameCurrencyPurchaseEventArgs(long purchaseId, string itemTitleId, InAppItemModel.ItemType itemType, long itemBalanceAfter, long amountReceived, ObtainableItemSource itemSource, InGameCurrencyType inGameCurrencyType, long currencyBalanceAfter, long price, long instanceId)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	private Action<UpgradeType, int> m_onUpgradePurchase;

	private Action<Characters.CharacterId, int> m_characterPurchased;

	private Action m_onFailedToPurchaseEventItemWithInapp;

	private EventHandler<SyboInGameCurrencyPurchaseEventArgs> m_OnIngameCurrencyPurchaseCompleted;

	private BoardSelectButton _btnBuyItemWithInapp;

	private static PurchaseHandler _instance;

	public static PurchaseHandler Instance
	{
		get
		{
			//IL_001b: Expected Obj, but got I
			Dictionary<Boards.BoardId, Dictionary<HoverboardThemes.ThemeIdentifier, BoardThemeData>> boardThemeData = InventorySave.boardThemeData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Collections.Generic.Dictionary`2<Info.Boards+BoardId, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, Info.BoardThemeData>>)+C]");
			return (PurchaseHandler)0;
		}
	}

	public event Action<UpgradeType, int> onUpgradePurchase
	{
		add
		{
			//IL_004f: Expected Obj, but got I
			//IL_005d: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Action`2<Info.UpgradeType, System.Int32>)+30]");
			if ((nint)0 == 0)
			{
				((ScrollViewHeightResizer)(object)value).AddColliders();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Action`2<Info.UpgradeType, System.Int32>)+14]");
			GameObject gameObject = ((Component)0).gameObject;
			((Transform)this).localPosition = (Vector3)gameObject;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onUpgradePurchase;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action<Characters.CharacterId, int> characterPurchased
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onUpgradePurchase;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_characterPurchased;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private event Action onFailedToPurchaseEventItemWithInapp
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_characterPurchased;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onFailedToPurchaseEventItemWithInapp;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event EventHandler<SyboInGameCurrencyPurchaseEventArgs> OnIngameCurrencyPurchaseCompleted
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onFailedToPurchaseEventItemWithInapp;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnIngameCurrencyPurchaseCompleted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public void TriggerOnFailedToPurchaseEventItemWithInapp()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void ResetOnFailedToPurchaseEventItemWithInapp()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		if (this.m_onFailedToPurchaseEventItemWithInapp != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			object obj = this + 16;
			obj = 0;
		}
	}

	public unsafe void PurchaseCharacter(Characters.CharacterId characterId, int outfit, int priceOverride = -1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected I4, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02fc: Expected I, but got Obj
		//IL_0312: Expected Obj, but got I
		//IL_0399: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_0093: Expected Obj, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I4
		//IL_01c5: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 48;
		bool flag = (byte)(obj2 + 36) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v116 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		PurchaseHandler purchaseHandler;
		if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])outfit, flag))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num3 = default;
			object obj6 = num3 + 16;
			obj6 = 44;
			string text = ((string)((bool*)(flag ? 1 : 0))->m_value).Substring(num3);
			if (text.m_firstChar == '\u0003')
			{
				object obj7 = text + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				object obj8 = text + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				object obj9 = text + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				obj2 = 0;
				_ = 0;
				object obj10 = default;
				obj2 = obj10;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				purchaseHandler = (PurchaseHandler)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11+8]");
				this.m_onUpgradePurchase = (Action<UpgradeType, int>)0;
				return;
			}
		}
		purchaseHandler = (PurchaseHandler)((int*)priceOverride)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [priceOverride @ L3 (System.Int32)+8]");
		this.m_onUpgradePurchase = (Action<UpgradeType, int>)0;
	}

	public void StartPurchaseCharacterWithInapp(Characters.CharacterId characterId)
	{
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnIngameCurrencyPurchaseCompleted;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)characterId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 20;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public void OnPurchaseCharacterWithInappSucceded(Characters.CharacterId characterId, string inappId)
	{
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I4
		//IL_020d: Expected I, but got Obj
		//IL_0223: Expected Obj, but got I
		//IL_040a: Expected I, but got Obj
		//IL_0420: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got I
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01d5: Expected I4, but got Obj
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0317: Expected I, but got Obj
		//IL_032d: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		_ = 0;
		object obj = this + 12;
		obj = characterId;
		nint num = (nint)typeof(SelectPopupButton._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<SelectPopupButton+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SelectPopupButton._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v99 (Il2CppClass<SelectPopupButton+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = SelectPopupButton._003C_003Ec._003C_003E9__21_0 == null;
		bool flag2 = !flag;
		Func<string, string> func = SelectPopupButton._003C_003Ec._003C_003E9__21_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(SelectPopupButton._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v73 (Il2CppClass<SelectPopupButton+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(SelectPopupButton._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v93 (Il2CppClass<SelectPopupButton+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<string, string> func2 = default;
			object obj4 = func2 + 16;
			obj4 = SelectPopupButton._003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(SelectPopupButton._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v90 (Il2CppClass<SelectPopupButton+<>c>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			obj5 = func2;
			func = func2;
		}
		nint num7 = (nint)typeof(SelectPopupButton._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21 (Il2CppClass<SelectPopupButton+<>c>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(SelectPopupButton._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v66 (Il2CppClass<SelectPopupButton+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = SelectPopupButton._003C_003Ec._003C_003E9__21_1 == null;
		bool flag4 = !flag3;
		Func<string, string> func3 = SelectPopupButton._003C_003Ec._003C_003E9__21_1;
		if (!flag4)
		{
			nint num9 = (nint)typeof(SelectPopupButton._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v40 (Il2CppClass<SelectPopupButton+<>c>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(SelectPopupButton._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v60 (Il2CppClass<SelectPopupButton+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num11 = 0;
			_ = 0;
			Func<string, string> func4 = default;
			object obj8 = func4 + 16;
			obj8 = SelectPopupButton._003C_003Ec._003C_003E9;
			nint num12 = (nint)typeof(SelectPopupButton._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v57 (Il2CppClass<SelectPopupButton+<>c>)+5C]");
			object obj9 = (nint)0 + (nint)8;
			obj9 = func4;
			func3 = func4;
		}
		object obj10 = this + 16;
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S5_v2 (Il2CppMethodInfo)+18]");
		object obj11 = 0;
		object obj12 = obj11;
		object obj13 = obj12 & 0x7FF;
		object obj14 = obj13 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v162 @ S6_v4 (should have been resolved before IL gen)");
		object obj15 = default;
		obj10 = obj15;
		if (this.m_OnIngameCurrencyPurchaseCompleted == null)
		{
			object obj16 = this + 36;
			string text = ((List<string>)(object)this.m_characterPurchased).get_Item((int)inappId);
			obj16 = text;
		}
		((ScrollPanelPixelPerfect)this).Start();
	}

	public void OnPurchaseCharacterWithInappFailed()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this + 16;
		obj = 0;
	}

	private static void CheckForDebugFreePurchases(PurchaseData.UnlockType unlockType, int price)
	{
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0283: Expected Obj, but got I4
		//IL_0291: Expected Obj, but got I4
		//IL_02a7: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I
		//IL_02fa: Expected I, but got Obj
		//IL_0310: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I4
		//IL_0348: Expected I, but got Obj
		//IL_035e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_039b: Expected I, but got Obj
		//IL_03b1: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_00fa: Expected I, but got Obj
		//IL_0147: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		//IL_0188: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = unlockType;
		object obj3 = unlockType + 16;
		obj3 = obj2;
		nint num2 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v60 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)price);
		nint num4 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v13 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v35 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool cost = InAppData.IsUsingCustomIapIdForCharacter((Characters.Model)price);
		nint num6 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v20 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v31 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string senderName = Strings.GetDefault(model.name);
		nint num8 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v25 (Il2CppClass<Globals>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v54 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			nint num10 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v45 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num11 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v50 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppData.PrintDynamicIdsForBoardTypeForAllPlatforms((Boards.BoardId)price);
		}
		nint num12 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v34 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num13 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v40 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		((InAppManager)(object)activeInAppOffers).SuggestInAppPopup(cost ? 1 : 0, senderName, (InAppItemModel.ItemType)unlockType);
	}

	public void OnPurchaseBoardWithInappSucceded(string inappId, Boards.BoardId boardId)
	{
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00f8: Expected I4, but got Obj
		//IL_00f8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool running = FirstPurchaseBonusManager.running;
		((CharacterScreenManager)running).OnCharacterUnlocked((Characters.CharacterId)inappId, 0);
		if (this.m_characterPurchased != null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v3 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S4_v5 (should have been resolved before IL gen)");
		}
	}

	public void OnPurchaseBoardWithInappFailed()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool running = FirstPurchaseBonusManager.running;
		CharacterScreenManager.characterUnlocked += (Action<Characters.CharacterId, int>)running;
	}

	public void StartPurchaseBoardWithInapp(Boards.BoardId boardId, BoardSelectButton sender)
	{
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_btnBuyItemWithInapp).FindKernel((string)null) != 0)
		{
			((CelebrationPopupLabelTemplate)(object)_btnBuyItemWithInapp).SetupKeys(0, false);
		}
	}

	public void PurchaseKeysIfNeeded(int amountToSaveMe)
	{
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0144: Expected I4, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_FREE_PURCHASES ? 1u : 0u) != 0)
		{
			return;
		}
		object obj2 = this - 2;
		if ((nint)this != 2)
		{
			if ((nint)obj2 != 1 && (nint)obj2 != 2 && (nint)obj2 == 3)
			{
				int coins = InventorySave.coins;
				if (coins < amountToSaveMe)
				{
					InventorySave.IncreaseAmount((UpgradeType)amountToSaveMe, (int)string.Empty);
				}
			}
		}
		else
		{
			int unrewardedCoins = InventorySave.unrewardedCoins;
			if (unrewardedCoins < amountToSaveMe)
			{
				InventorySave.IncreaseKeys(amountToSaveMe, string.Empty);
			}
		}
	}

	public void PurchaseHoverboard(Boards.BoardId boardId, BoardSelectButton sender)
	{
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_021a: Expected I, but got Obj
		//IL_0230: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I4
		//IL_0268: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_02d8: Expected I4, but got Obj
		//IL_02d8: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_02bc: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		object obj3 = this + 16;
		obj3 = obj2;
		object obj4 = this + 24;
		obj4 = sender;
		nint num2 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v58 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = InAppData.IsUsingCustomIapIdForBoard((Boards.Board)boardId);
		nint num4 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<Globals>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v52 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			nint num6 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v43 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num7 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v48 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((InAppHelper)boardId).Start();
		}
		nint num8 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v32 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v38 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		((InAppManager)(object)activeInAppOffers).DeliverBundle((string)flag, (byte)(int)this != 0);
	}

	private static bool MakeHoverboardPurchase(Boards.BoardId boardId, Boards.Board boardData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_009b: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = boardData;
		object obj3 = obj2 + 4;
		if ((nint)boardData > 499)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			bool result = default;
			return result;
		}
		object obj4 = boardData / 10;
		object obj5 = obj4 * 10;
		object obj6 = obj5 + 9;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text3 = default;
		string text = text2 + "-" + text3;
		return (byte)(int)text != 0;
	}

	public void PurchaseHoverboardTheme(Boards.BoardId boardId, int themeIndex, BoardSelectButton sender)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_001e: Expected Obj, but got I4
		//IL_07f6: Expected I, but got Obj
		//IL_080c: Expected Obj, but got I
		//IL_0b75: Expected I, but got Obj
		//IL_0b8b: Expected Obj, but got I
		//IL_0849: Expected I, but got Obj
		//IL_085f: Expected Obj, but got I
		//IL_0031: Expected I, but got Obj
		//IL_0889: Expected Obj, but got I4
		//IL_0889: Expected Obj, but got I4
		//IL_08c9: Expected Obj, but got I4
		//IL_007e: Expected I, but got Obj
		//IL_00cb: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I4
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_01bf: Expected I4, but got Obj
		//IL_0225: Expected Obj, but got I4
		//IL_07e2: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		//IL_0238: Expected I, but got Obj
		//IL_024e: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I4
		//IL_0968: Expected I, but got Obj
		//IL_097e: Expected Obj, but got I
		//IL_05cd: Expected I, but got Obj
		//IL_05e3: Expected Obj, but got I
		//IL_04cb: Expected Obj, but got I4
		//IL_04cb: Expected Obj, but got I4
		//IL_09c2: Expected I4, but got Obj
		//IL_09c2: Expected I4, but got Obj
		//IL_09cb: Expected Obj, but got I4
		//IL_0279: Expected I, but got Obj
		//IL_0ad3: Expected I4, but got Obj
		//IL_053f: Expected I, but got Obj
		//IL_0555: Expected Obj, but got I
		//IL_02c6: Expected I, but got Obj
		//IL_060e: Expected I, but got Obj
		//IL_06b6: Expected I4, but got Obj
		//IL_06b6: Expected I4, but got Obj
		//IL_06b6: Expected Obj, but got I4
		//IL_0580: Expected I, but got Obj
		//IL_0af9: Expected I, but got Obj
		//IL_0b0f: Expected Obj, but got I
		//IL_0bb5: Expected I4, but got Obj
		//IL_06eb: Expected Obj, but got I
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_072c: Expected I, but got Obj
		//IL_07b8: Expected Obj, but got I4
		//IL_0774: Expected Obj, but got I4
		//IL_07aa: Expected Obj, but got I4
		//IL_07d4: Expected Obj, but got I4
		//IL_07c6: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = boardId;
		obj2 = themeIndex;
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v185 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool running = FirstPurchaseBonusManager.running;
		nint num3 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v179 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)boardId);
		nint num5 = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v28 (Il2CppClass<Info.Outfits>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v175 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((OutfitSet)boardId).HasOutfitWithName((string)themeIndex);
		bool flag2 = flag;
		bool flag3 = (nint)sender >= 1;
		bool flag4 = !flag3;
		BoardSelectButton boardSelectButton = (BoardSelectButton)model.Price;
		if (!flag4)
		{
			boardSelectButton = sender;
		}
		BoardSelectButton boardSelectButton2;
		PurchaseHandler purchaseHandler;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v33 (System.Boolean)+1C]");
			boardSelectButton2 = (BoardSelectButton)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v33 (System.Boolean)+10]");
			purchaseHandler = (PurchaseHandler)0;
		}
		else
		{
			purchaseHandler = (PurchaseHandler)model.unlockType;
			boardSelectButton2 = boardSelectButton;
		}
		bool flag5 = (nint)purchaseHandler == 2;
		object obj6 = purchaseHandler - 2;
		if ((nint)purchaseHandler == 2 || ((nint)obj6 != 1 && (nint)obj6 != 2 && (nint)obj6 == 3))
		{
			purchaseHandler.PurchaseKeysIfNeeded((int)boardSelectButton2);
			int unrewardedCoins = InventorySave.unrewardedCoins;
			bool flag6 = (nint)purchaseHandler == 5;
			int num7;
			string secondaryItemId;
			if (flag6)
			{
				int coins = InventorySave.coins;
				num7 = coins;
				secondaryItemId = (string)6;
			}
			else
			{
				num7 = unrewardedCoins;
				secondaryItemId = (string)5;
			}
			if (num7 < (nint)boardSelectButton2)
			{
				nint num8 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v152 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num9 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v159 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v93 (Il2CppClass<Strings>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num11 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v99 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string itemId = Strings.GetDefault(model.name);
				InventorySave.LogSpentEvent((int)activeInAppOffers, (InAppItemModel.ItemType)boardSelectButton2, itemId, secondaryItemId);
				CharacterScreenManager.characterUnlocked += (Action<Characters.CharacterId, int>)running;
				return;
			}
			if (flag5)
			{
				StayInOneLaneMission instance = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)2, (PersistentAwardProgress)(object)boardSelectButton2, (Action<Award>)(-1));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			if (flag6)
			{
				StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)instance2)._002Ector((AwardStaticData)71, (PersistentAwardProgress)(object)boardSelectButton2, (Action<Award>)(-1));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			if (!flag2)
			{
				nint num12 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v88 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num13 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v103 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterManager.LockCharacter((Characters.CharacterId)obj);
				_0021_00210[] array = (_0021_00210[])(object)UnityEngine.Object.FindObjectsOfType<T>();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			nint num14 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v110 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num15 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v115 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveGameDebug.CopySaveFiles((string)obj, (string)obj2);
			((CharacterScreenManager)running).OnCharacterUnlocked((Characters.CharacterId)obj, (int)obj2);
			if (this.m_characterPurchased != null)
			{
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S3_v7 (Il2CppMethodInfo)+18]");
				object obj11 = 0;
				object obj12 = obj11;
				object obj13 = obj12 & 0x1FFF;
				object obj14 = obj13 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v424 @ S4_v9 (should have been resolved before IL gen)");
			}
			nint num17 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S1_v25 (Il2CppClass<Info.ItemInfo>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num18 = (nint)typeof(ItemInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S1_v34 (Il2CppClass<Info.ItemInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string itemTitleId = ItemInfo.GetItemTitleId((Boards.BoardId)obj, flag ? HoverboardThemes.ThemeIdentifier.heroboardTheme01 : HoverboardThemes.ThemeIdentifier.none);
			if ((nint)purchaseHandler == 2)
			{
				object obj16 = 1;
			}
			else if ((nint)purchaseHandler == 5)
			{
				object obj16 = 2;
			}
			else
			{
				object obj16 = 0;
			}
			if (flag2)
			{
				object obj17 = 2;
			}
			else
			{
				object obj17 = 1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D35");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D36");
		}
		else
		{
			CharacterScreenManager.characterUnlocked += (Action<Characters.CharacterId, int>)running;
		}
	}

	private static bool MakeHoverboardThemePurchase(Boards.BoardId boardId, HoverboardThemes.HoverboardTheme ht)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_03c3: Invalid comparison between VT and I4
		//IL_0054: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_03f0: Expected I, but got Obj
		//IL_0406: Expected Obj, but got I
		//IL_001f: Expected VT, but got I4
		//IL_0028: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_0078: Expected I, but got Obj
		//IL_0538: Invalid comparison between I4 and VT
		//IL_00c4: Invalid comparison between I4 and VT
		//IL_020f: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got VT
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected I4, but got Unknown
		//IL_0448: Expected I, but got Obj
		//IL_045e: Expected Obj, but got I
		//IL_0263: Expected I, but got Obj
		//IL_0489: Expected Obj, but got I4
		//IL_04a7: Expected I4, but got VT
		//IL_04a7: Expected I4, but got Obj
		//IL_015f: Expected I, but got Obj
		//IL_04bd: Invalid comparison between VT and I4
		//IL_04d0: Expected Obj, but got I4
		//IL_01ac: Expected I, but got Obj
		object obj = boardId;
		int unrewardedCoins = InventorySave.unrewardedCoins;
		Color32 color;
		AwardStaticData awardData;
		int num;
		string secondaryItemId;
		if (ht.buttonIconColor == (Color32)(object)5)
		{
			int coins = InventorySave.coins;
			color = (Color32)5;
			awardData = (AwardStaticData)71;
			num = coins;
			secondaryItemId = (string)6;
		}
		else
		{
			color = ht.buttonIconColor;
			awardData = (AwardStaticData)2;
			num = unrewardedCoins;
			secondaryItemId = (string)5;
		}
		nint num2 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v16 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v83 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag;
		if (~(Globals.DEBUG_FREE_PURCHASES ? 1u : 0u) == 0)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) < System.Runtime.CompilerServices.Unsafe.As<Color32, UIntPtr>(ref ht.buttonBgColor))
			{
				int num4 = ht.buttonBgColor + num;
				num = num4;
			}
			flag = true;
		}
		else
		{
			flag = false;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) < System.Runtime.CompilerServices.Unsafe.As<Color32, UIntPtr>(ref ht.buttonBgColor))
		{
			nint num5 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v66 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v72 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v44 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v49 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string itemId = Strings.GetDefault((string)ht.price);
			InventorySave.LogSpentEvent((int)activeInAppOffers, (InAppItemModel.ItemType)ht.buttonBgColor, itemId, secondaryItemId);
			bool flag2 = flag;
			bool flag3 = color == (Color32)(object)5;
			object obj5 = flag3 & flag2;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			return flag2;
		}
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)instance)._002Ector(awardData, (PersistentAwardProgress)ht.buttonBgColor, (Action<Award>)(-1));
		nint num9 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v45 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v61 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardManager.LockBoard(boardId);
		_0021_00210[] array = (_0021_00210[])(object)UnityEngine.Object.FindObjectsOfType<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public void PurchaseUpgrade(UpgradeType type, IBuyButton sender)
	{
		//IL_0153: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_019e: Expected I, but got Obj
		//IL_01b4: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I4
		//IL_00f7: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)type);
		if (MakeHoverboardThemePurchase((Boards.BoardId)type, (HoverboardThemes.HoverboardTheme)(object)board))
		{
			((CelebrationPopupLabelTemplate)sender).SetupKeys(0, false);
			if (board.unlockType == PurchaseData.UnlockType.Coins)
			{
				object obj2 = 1;
			}
			else if (board.unlockType == PurchaseData.UnlockType.Keys)
			{
				object obj2 = 2;
			}
			else
			{
				object obj2 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D35");
			nint num3 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v18 (Il2CppClass<Info.ItemInfo>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(ItemInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v23 (Il2CppClass<Info.ItemInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string itemTitleId = ItemInfo.GetItemTitleId((InAppItemModel.ItemType)type);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D36");
		}
		else
		{
			((BoardSelectButton)sender)._002Ector();
		}
	}

	public unsafe void PurchaseUpgrade(UpgradeType upgradeType, Action onPurchaseSuccessful, Action onPurchaseFailure)
	{
		//IL_016f: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_022c: Expected I4, but got Obj
		//IL_023d: Expected I4, but got Obj
		//IL_023d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0081: Expected I4, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_01ba: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I4
		//IL_0113: Expected I, but got Obj
		nint num = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item((Boards.BoardId)upgradeType);
		HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item((int)onPurchaseSuccessful);
		if (((PurchaseHandler)upgradeType).GetIngameCurrencyTypeFromUnlockType((PurchaseData.UnlockType)hoverboardTheme) != InGameCurrencyType.None)
		{
			((CelebrationPopupLabelTemplate)(object)onPurchaseFailure).SetupKeys(1, (byte)(int)onPurchaseSuccessful != 0);
			if (hoverboardTheme.unlockType == PurchaseData.UnlockType.Coins)
			{
				object obj2 = 1;
			}
			else if (hoverboardTheme.unlockType == PurchaseData.UnlockType.Keys)
			{
				object obj2 = 2;
			}
			else
			{
				object obj2 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D35");
			nint num3 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v18 (Il2CppClass<Info.ItemInfo>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(ItemInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v23 (Il2CppClass<Info.ItemInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = ItemInfo.TryGetItemTitleId((InAppItemModel)upgradeType, out *(string*)hoverboardTheme);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D36");
		}
		else
		{
			((BoardSelectButton)(object)onPurchaseFailure)._002Ector();
		}
	}

	public void PurchaseSkipMission(int missionIndex, IBuyButton sender)
	{
		//IL_0076: Expected I, but got Obj
		//IL_0083: Expected I, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0028: Expected I, but got Obj
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		Action action = default;
		((Delegate)action).method_ptr = (IntPtr)ex;
		((Delegate)action).method = (IntPtr)ex;
		object obj = action + 16;
		obj = sender;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex2 = new NullReferenceException();
		Action action2 = default;
		((Delegate)action2).method_ptr = (IntPtr)ex2;
		((Delegate)action2).method = (IntPtr)ex2;
		object obj2 = action2 + 16;
		obj2 = sender;
		PurchaseSkipMission(missionIndex, action, action2);
	}

	public void PurchaseSkipMission(int missionIndex, Action onPurchaseSuccessful, Action onPurchaseFailure)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_0858: Expected I, but got Obj
		//IL_086e: Expected Obj, but got I
		//IL_0a84: Expected I, but got Obj
		//IL_0a9a: Expected Obj, but got I
		//IL_0029: Expected I, but got Obj
		//IL_08df: Expected Obj, but got I4
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected Obj, but got Unknown
		//IL_0139: Expected I, but got Obj
		//IL_0ad0: Expected I, but got Obj
		//IL_0ae6: Expected Obj, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01ae: Expected I4, but got Obj
		//IL_009a: Expected I, but got Obj
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00f4: Expected I4, but got Obj
		//IL_01cf: Expected I, but got Obj
		//IL_026e: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I4
		//IL_0434: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I4
		//IL_0921: Expected I, but got Obj
		//IL_0937: Expected Obj, but got I
		//IL_05a4: Expected Obj, but got I4
		//IL_080b: Expected I, but got Obj
		//IL_04b4: Expected Obj, but got I4
		//IL_04b4: Expected Obj, but got I4
		//IL_04b4: Expected Obj, but got I4
		//IL_04e6: Expected Obj, but got I4
		//IL_04e6: Expected Obj, but got I4
		//IL_04e6: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I4
		//IL_0531: Expected Obj, but got I4
		//IL_055a: Expected Obj, but got I4
		//IL_055a: Expected Obj, but got I4
		//IL_055a: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I4
		//IL_0580: Expected Obj, but got I4
		//IL_058d: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = missionIndex;
		nint num = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v178 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Upgrade upgrade = Upgrades.upgrades.get_Item((UpgradeType)missionIndex);
		bool flag = upgrade.numberOfTiers == 0;
		nint num3 = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v8 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag2 = obj4 == null;
		int num5;
		if (flag)
		{
			if (!flag2)
			{
				nint num4 = (nint)typeof(Upgrades);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v172 (Il2CppClass<Info.Upgrades>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Upgrade upgrade2 = Upgrades.upgrades.get_Item((UpgradeType)missionIndex);
			if (upgrade2.pricesRaw != null)
			{
				object obj5 = upgrade2.pricesRaw + 16;
				num5 = (int)obj5;
			}
			else
			{
				num5 = -1;
			}
		}
		else
		{
			if (!flag2)
			{
				nint num6 = (nint)typeof(Upgrades);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v152 (Il2CppClass<Info.Upgrades>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Upgrade upgrade3 = Upgrades.upgrades.get_Item((UpgradeType)missionIndex);
			CollectCoinsDummy[] array = MigrationSave.ParseDummyData((string)missionIndex);
			object obj6 = array + 1;
			if (upgrade3.pricesRaw != null)
			{
				object obj7 = upgrade3.pricesRaw + 16;
				object obj8 = obj6 << 2;
				object obj9 = obj7 + obj8;
				num5 = (int)obj9;
			}
			else
			{
				num5 = -1;
			}
		}
		nint num7 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v23 (Il2CppClass<Globals>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num8 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v128 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_FREE_PURCHASES ? 1u : 0u) == 0)
		{
			int unrewardedCoins = InventorySave.unrewardedCoins;
			if (unrewardedCoins < num5)
			{
				InventorySave.IncreaseKeys(num5, string.Empty);
			}
		}
		int unrewardedCoins2 = InventorySave.unrewardedCoins;
		if (unrewardedCoins2 < num5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			nint num9 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v36 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num10 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v42 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveManager.Load();
			return;
		}
		object obj12 = missionIndex - 1;
		int num11;
		if (missionIndex != 1)
		{
			if ((nint)obj12 != 1)
			{
				if ((nint)obj12 == 2)
				{
					goto IL_0426;
				}
				if ((nint)obj12 == 3)
				{
					StayInOneLaneMission instance = StayInOneLaneMission.instance;
					((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)2, (PersistentAwardProgress)num5, (Action<Award>)(-1));
					StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
					((OwnBoardsAward)(object)instance2)._002Ector((AwardStaticData)27, (PersistentAwardProgress)1, (Action<Award>)(-1));
					num11 = 1;
					goto IL_0954;
				}
				if ((nint)obj12 != 4)
				{
					if ((nint)obj12 == 5 || (nint)obj12 == 6 || (nint)obj12 == 7)
					{
						goto IL_051f;
					}
					if ((nint)obj12 != 8)
					{
						if ((nint)obj12 == 9)
						{
							goto IL_051f;
						}
						if ((nint)obj12 != 10 && (nint)obj12 != 11 && (nint)obj12 != 12 && (nint)obj12 != 13 && (nint)obj12 == 14)
						{
							goto IL_0426;
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			obj2 = missionIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
		goto IL_0426;
		IL_0426:
		InventorySave.AddPendingReward((CelebrationReward)missionIndex, (Func<CelebrationRewardOrigin, int>)1);
		int tier = InventorySave.GetTier((UpgradeType)missionIndex);
		StayInOneLaneMission instance3 = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)instance3)._002Ector((AwardStaticData)2, (PersistentAwardProgress)num5, (Action<Award>)(-1));
		if (missionIndex == 3)
		{
			StayInOneLaneMission instance4 = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)instance4)._002Ector((AwardStaticData)42, (PersistentAwardProgress)1, (Action<Award>)(-1));
		}
		num11 = tier;
		goto IL_0954;
		IL_051f:
		InventorySave.ResetTier((UpgradeType)missionIndex);
		CollectCoinsDummy[] array2 = MigrationSave.ParseDummyData((string)missionIndex);
		StayInOneLaneMission instance5 = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)instance5)._002Ector((AwardStaticData)2, (PersistentAwardProgress)num5, (Action<Award>)(-1));
		StayInOneLaneMission instance6 = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)instance6)._002Ector((AwardStaticData)41, (PersistentAwardProgress)1, (Action<Award>)(-1));
		num11 = (int)array2;
		goto IL_0954;
		IL_0954:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private void RaiseSyboInGameCurrencyPurchaseEvent(string itemTitleId, InAppItemModel.ItemType itemType, long itemBalanceAfter, long amountReceived, ObtainableItemSource itemSource, InGameCurrencyType inGameCurrencyType, long currencyBalanceAfter, long price)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private void RaiseSyboInGameCurrencyPurchaseEvent(string itemTitleId, InAppItemModel.ItemType itemType, long itemBalanceAfter, long amountReceived, ObtainableItemSource itemSource, InGameCurrencyType inGameCurrencyType, long currencyBalanceAfter, long price, long instanceId)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private InGameCurrencyType GetIngameCurrencyTypeFromUnlockType(PurchaseData.UnlockType unlockType)
	{
		//IL_004b: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_03bd: Expected I, but got Obj
		//IL_03d3: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_0078: Expected I, but got Obj
		//IL_0218: Expected Obj, but got I4
		//IL_0218: Expected Obj, but got I
		//IL_022b: Expected I, but got Obj
		//IL_0241: Expected Obj, but got I
		//IL_0124: Expected I, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_04d2: Expected I4, but got Obj
		//IL_04e9: Expected Obj, but got I4
		//IL_04e9: Expected Obj, but got I
		//IL_0415: Expected I, but got Obj
		//IL_042b: Expected Obj, but got I
		//IL_04a3: Expected Obj, but got I4
		//IL_026c: Expected I, but got Obj
		//IL_0459: Expected Obj, but got I
		//IL_047a: Expected I4, but got Obj
		//IL_0165: Expected I, but got Obj
		//IL_01b2: Expected I, but got Obj
		int unrewardedCoins = InventorySave.unrewardedCoins;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [unlockType @ L1 (Info.PurchaseData+UnlockType)+C]");
		object obj;
		string secondaryItemId;
		int num;
		AwardStaticData awardStaticData;
		if ((nint)0 == 5)
		{
			int coins = InventorySave.coins;
			obj = 5;
			secondaryItemId = (string)6;
			num = coins;
			awardStaticData = (AwardStaticData)71;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [unlockType @ L1 (Info.PurchaseData+UnlockType)+C]");
			obj = 0;
			secondaryItemId = (string)5;
			num = unrewardedCoins;
			awardStaticData = (AwardStaticData)2;
		}
		nint num2 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v16 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v76 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InGameCurrencyType inGameCurrencyType;
		if (~(Globals.DEBUG_FREE_PURCHASES ? 1u : 0u) == 0)
		{
			int num4 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [unlockType @ L1 (Info.PurchaseData+UnlockType)+8]");
			if ((nint)num4 < (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [unlockType @ L1 (Info.PurchaseData+UnlockType)+8]");
				int num5 = (int)((nint)0 + (nint)num);
				num = num5;
			}
			inGameCurrencyType = InGameCurrencyType.Coins;
		}
		else
		{
			inGameCurrencyType = InGameCurrencyType.None;
		}
		int num6 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [unlockType @ L1 (Info.PurchaseData+UnlockType)+8]");
		InGameCurrencyType inGameCurrencyType2;
		if ((nint)num6 < (nint)0)
		{
			nint num7 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v59 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num8 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v65 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v36 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v41 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [unlockType @ L1 (Info.PurchaseData+UnlockType)+1C]");
			string itemId = Strings.GetDefault((string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [unlockType @ L1 (Info.PurchaseData+UnlockType)+8]");
			InventorySave.LogSpentEvent((int)activeInAppOffers, InAppItemModel.ItemType.Undefined, itemId, secondaryItemId);
			inGameCurrencyType2 = inGameCurrencyType;
		}
		else
		{
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			AwardStaticData awardData = awardStaticData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [unlockType @ L1 (Info.PurchaseData+UnlockType)+8]");
			((OwnBoardsAward)(object)instance)._002Ector(awardData, (PersistentAwardProgress)0, (Action<Award>)(-1));
			nint num11 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v47 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num12 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v54 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [unlockType @ L1 (Info.PurchaseData+UnlockType)+28]");
			BoardManager.SetThemeSeen((Boards.BoardId)this, HoverboardThemes.ThemeIdentifier.none);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [unlockType @ L1 (Info.PurchaseData+UnlockType)+28]");
			CloudSave.SetUserDataIfChanged((CloudWorkingCopy)(object)this, (string)0, (ICloudUserData)1);
			inGameCurrencyType2 = InGameCurrencyType.Coins;
		}
		bool flag = (nint)obj == 5;
		object obj6 = (flag ? 1 : 0) & (int)inGameCurrencyType2;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		if (inGameCurrencyType2 != InGameCurrencyType.None)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		return inGameCurrencyType2;
	}

	private long GetIngameCurrencyAmount(InGameCurrencyType unlockType)
	{
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_02df: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got I
		//IL_0076: Expected I, but got Obj
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_00c3: Expected I, but got Obj
		//IL_032f: Expected I8, but got VT
		//IL_0151: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I4
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_034b: Expected I, but got Obj
		//IL_0361: Expected Obj, but got I
		//IL_0387: Expected I8, but got VT
		//IL_0208: Expected I, but got Obj
		//IL_0255: Expected I, but got Obj
		switch (unlockType)
		{
		case InGameCurrencyType.None:
		{
			nint num7 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v19 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			uint value = ((OnlineSettings)(object)saveDataPath).GetValue("global_time_between_interstitials", 10u);
			nint num9 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v9 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v14 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
			long result = default;
			return result;
		}
		case InGameCurrencyType.Coins:
		{
			nint num5 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v24 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v31 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (long)TimeSpan.Zero;
		}
		default:
		{
			object obj = unlockType;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string text = "AdSettingsProvider.cs The minimum show interval has not been set for the adType: " + text2;
			nint num = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v23 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v29 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)(object)text).Awake();
			nint num3 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v45 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v52 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (long)TimeSpan.Zero;
		}
		}
	}

	public PurchaseHandler()
	{
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_btnBuyItemWithInapp).FindKernel((string)null) != 0)
		{
			_btnBuyItemWithInapp._002Ector();
		}
	}
}
