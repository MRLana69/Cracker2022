public class InAppPurchaseHandler
{
	public static bool isInitializedForPurchase()
	{
		return false;
	}

	public static bool isInitializedForProductRequest()
	{
		return false;
	}

	public static string parseProductIdFromCallbackString(string transactionAndProductId)
	{
		if (string.IsNullOrEmpty(transactionAndProductId))
		{
			return string.Empty;
		}

		int separator = transactionAndProductId.IndexOf(',');
		return separator >= 0 && separator + 1 < transactionAndProductId.Length
			? transactionAndProductId.Substring(separator + 1)
			: string.Empty;
	}

	public static bool canMakePayments()
	{
		return false;
	}

	public static void initPurchase(string gameobjectName, string onSuccessMethodName, string onFailureMethodName)
	{
	}

	public static void resetForPurchase()
	{
	}

	public static void initProductRequest(string gameobjectName, string onSuccessMethodName, string onFailureMethodName)
	{
	}

	public static void resetForProductRequest()
	{
	}

	public static void startPurchase(string productIdentifier)
	{
	}

	public static void callbackHasBeenHandled(string transactionAndProductIdentifier)
	{
	}

	public static void queryProducts(string productIds)
	{
	}
}
