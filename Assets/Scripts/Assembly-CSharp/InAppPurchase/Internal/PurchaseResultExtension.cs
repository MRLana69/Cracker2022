namespace InAppPurchase.Internal;

public static class PurchaseResultExtension
{
	public static PurchaseResult ToPurchaseResult(InternalPurchaseResult internalPurchaseResult)
	{
		bool flag = internalPurchaseResult < InternalPurchaseResult.Restored;
		PurchaseResult result = (PurchaseResult)internalPurchaseResult;
		if (!flag)
		{
			result = PurchaseResult.Failed;
		}
		return result;
	}
}
