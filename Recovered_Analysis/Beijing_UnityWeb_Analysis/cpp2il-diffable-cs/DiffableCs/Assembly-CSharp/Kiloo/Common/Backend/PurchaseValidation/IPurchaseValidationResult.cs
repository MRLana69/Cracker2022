namespace Kiloo.Common.Backend.PurchaseValidation;

public interface IPurchaseValidationResult
{

	public Error error
	{
		 get { } //Length: 0
	}

	public string purchaseToken
	{
		 get { } //Length: 0
	}

	public ReceiptStatus receiptStatus
	{
		 get { } //Length: 0
	}

	public Error get_error() { }

	public string get_purchaseToken() { }

	public ReceiptStatus get_receiptStatus() { }

}

