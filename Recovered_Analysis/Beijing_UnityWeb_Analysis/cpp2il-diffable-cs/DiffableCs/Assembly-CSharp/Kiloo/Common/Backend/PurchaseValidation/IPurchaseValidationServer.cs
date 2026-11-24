namespace Kiloo.Common.Backend.PurchaseValidation;

public interface IPurchaseValidationServer
{

	public Coroutine ValidatePurchase(PurchaseValidationRequest purchaseValidationRequest, Action<PurchaseValidationRequest> completeHandler = null) { }

}

