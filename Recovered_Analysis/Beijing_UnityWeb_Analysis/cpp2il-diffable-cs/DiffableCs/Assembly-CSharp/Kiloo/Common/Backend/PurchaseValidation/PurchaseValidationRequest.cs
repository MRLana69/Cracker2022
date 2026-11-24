namespace Kiloo.Common.Backend.PurchaseValidation;

public class PurchaseValidationRequest
{
	public string productId; //Field offset: 0x8
	public string receipt; //Field offset: 0xC
	public IPurchaseValidationResult result; //Field offset: 0x10

	public PurchaseValidationRequest() { }

}

