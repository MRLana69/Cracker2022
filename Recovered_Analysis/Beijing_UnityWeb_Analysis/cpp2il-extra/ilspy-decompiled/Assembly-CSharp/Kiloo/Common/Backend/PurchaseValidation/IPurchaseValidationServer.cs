using System;
using UnityEngine;

namespace Kiloo.Common.Backend.PurchaseValidation;

public interface IPurchaseValidationServer
{
	Coroutine ValidatePurchase(PurchaseValidationRequest purchaseValidationRequest, Action<PurchaseValidationRequest> completeHandler = null);
}
