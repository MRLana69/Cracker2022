using System;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics.Integration;

public class SubwayIngameCurrencyPurchaseEvent : SubwayPurchaseEvent
{
	public readonly string CurrencyType;

	public readonly long CurrencyDelta;

	public readonly long CurrencyBalanceAfter;

	public override string EventName => "ingame_currency_purchase";

	public SubwayIngameCurrencyPurchaseEvent(string itemTitleId, InAppItemModel.ItemType itemType, long purchaseNumber, string menusBefore, int? gameNumberOrNull, InGameCurrencyType currencyType, long currencyDelta, long currencyBalanceAfter)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected VT, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		base._002Ector(itemTitleId, itemType, purchaseNumber, menusBefore, (int?)(object)(obj + 8));
		Enum obj3 = (Enum)(obj + 16);
		_ = -1;
		obj3 = (Enum)(object)typeof(InGameCurrencyType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
		_ = 0;
		string text = obj3.ToString();
		string currencyType2 = text.ToLowerInvariant();
		CurrencyType = currencyType2;
		CurrencyBalanceAfter = currencyBalanceAfter;
		CurrencyDelta = currencyDelta;
	}
}
