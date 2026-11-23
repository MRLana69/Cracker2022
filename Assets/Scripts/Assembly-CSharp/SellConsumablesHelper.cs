using System;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

public class SellConsumablesHelper
{
	private static SellConsumablesHelper _instance;

	private const string ONLINESETTINGS_SELL_CONSUMABLES_DURING_RUN_KEY = "consumables_sell_during_run";

	private const bool ONLINESETTINGS_SELL_CONSUMABLES_DURING_RUN_DEFAULT = true;

	private int _purchaseCount;

	private bool _purchaseInProgress;

	private UIScreenController _screenController;

	private SellableConsumable _activeConsumable;

	private Action<PowerupType, int> m_PurchaseEnded;

	public static SellConsumablesHelper instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			SellConsumablesHelper result = _instance;
			if (!flag2)
			{
				SellConsumablesHelper sellConsumablesHelper = default;
				sellConsumablesHelper._002Ector();
				_instance = sellConsumablesHelper;
				result = sellConsumablesHelper;
			}
			return result;
		}
	}

	public static bool allowSellConsumablesDuringRun
	{
		get
		{
			OnlineSettings onlineSettings = OnlineSettings.instance;
			return onlineSettings.GetValue("consumables_sell_during_run", defaultValue: true);
		}
	}

	public SellableConsumable activeConsumable => _activeConsumable;

	public event Action<PowerupType, int> PurchaseEnded
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_PurchaseEnded;
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
			Delegate obj2 = this.m_PurchaseEnded;
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

	private SellConsumablesHelper()
	{
		UIScreenController screenController = UIScreenController.Instance;
		_screenController = screenController;
	}

	public void Sell(SellableConsumable consumable)
	{
		_activeConsumable = consumable;
		UIScreenController uIScreenController = UIScreenController.Instance;
		uIScreenController.QueuePopup("ConsumablesPopup");
	}

	public void DidShowConsuamblesPopup()
	{
		//IL_0037: Expected I, but got Obj
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		Game game = Game.Instance;
		game.TriggerPause(pauseGame: true);
		IngameScreen ingameScreen = IngameScreen.instance__BackingField;
		nint num = (nint)ingameScreen;
		object obj = ingameScreen + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S1_v5 (Il2CppClass<IngameScreen>)+EC] (should have been resolved before IL gen)");
		_purchaseCount = 0;
	}

	public void DidHideConsumablesPopup()
	{
		//IL_0021: Expected Obj, but got I
		_screenController.PushScreen("IngameUI");
		LogPurchases();
		SellableConsumable sellableConsumable = _activeConsumable;
		if (this.m_PurchaseEnded != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S4_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S4_v4+4] (should have been resolved before IL gen)");
		}
	}

	public unsafe void MakePurchase()
	{
		if (~(_purchaseInProgress ? 1u : 0u) != 0)
		{
			_purchaseInProgress = true;
			PurchaseHandler purchaseHandler = PurchaseHandler.Instance;
			SellableConsumable sellableConsumable = _activeConsumable;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(SellConsumablesHelper.OnPurchaseSuccessful));
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(SellConsumablesHelper.OnPurchaseFailure));
			purchaseHandler.PurchaseUpgrade(sellableConsumable.powerupType__BackingField, action, action2);
		}
	}

	private void OnPurchaseSuccessful()
	{
		_purchaseInProgress = false;
		int purchaseCount = _purchaseCount + 1;
		_purchaseCount = purchaseCount;
	}

	private void OnPurchaseFailure()
	{
		_purchaseInProgress = false;
	}

	private unsafe void LogPurchases()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected I4, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		SellableConsumable sellableConsumable = _activeConsumable;
		_ = sellableConsumable.powerupType__BackingField;
		Enum obj3 = (Enum)(obj + 8);
		_ = -1;
		obj3 = (Enum)(object)typeof(PowerupType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		_ = 0;
		string text = obj3.ToString();
		string text2 = text + ";Revive";
		int num = this + 8;
		string text3 = ((int*)num)->ToString();
		IngameScreen ingameScreen = IngameScreen.instance__BackingField;
		_ = ingameScreen.reviveCount__BackingField;
		int num2 = obj + 24;
		string text4 = ((int*)num2)->ToString();
		string text5 = text3 + ";" + text4;
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "[SellConsumablesHelper] " + msg;
	}
}
