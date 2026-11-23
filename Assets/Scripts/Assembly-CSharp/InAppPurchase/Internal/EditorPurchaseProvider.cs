using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;

namespace InAppPurchase.Internal;

public class EditorPurchaseProvider : IPurchaseProvider
{
	private sealed class _003CProductRequestCoroutine_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string[] productIds;

		public EditorPurchaseProvider _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00b8: Expected Obj, but got I4
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected Obj, but got Unknown
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected Obj, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected Obj, but got Unknown
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					EditorPurchaseProvider editorPurchaseProvider = _003C_003E4__this;
					_003C_003E1__state = -1;
					float value = UnityEngine.Random.value;
					if (value > 0f)
					{
						string[] array = productIds;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						object obj = 0;
						object obj4 = default;
						while (true)
						{
							object obj2 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v33+C]");
							bool flag = (nint)obj2 >= 0;
							object obj3 = obj4;
							if (flag)
							{
								break;
							}
							object obj5 = obj << 2;
							object obj6 = (object)productIds + obj5;
							string[] dUMMY_PRICES_LOCALIZED = DUMMY_PRICES_LOCALIZED;
							object obj7 = obj / dUMMY_PRICES_LOCALIZED.Length;
							object obj8 = obj7 * dUMMY_PRICES_LOCALIZED.Length;
							object obj9 = obj - obj8;
							object obj10 = obj9 << 2;
							object obj11 = (object)DUMMY_PRICES_LOCALIZED + obj10;
							object obj12 = obj << 4;
							object obj13 = obj4 + obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v40+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v48+10]");
							_ = 0;
							object obj14 = obj + 1;
							obj = obj14;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						object obj15 = default;
						object obj3 = obj15;
					}
					ProductInfoRequestDelegate productRequestDelegate = editorPurchaseProvider._productRequestDelegate;
					if (editorPurchaseProvider._productRequestDelegate != null)
					{
						bool flag2 = value > 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v148.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 0f;
			object obj16 = default;
			_003C_003E2__current = obj16;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public IPurchaseValidationResult validationResult;

		internal void _003CPurchaseCoroutine_003Eb__0(IPurchaseValidationResult purchaseValidationResult)
		{
			validationResult = purchaseValidationResult;
		}
	}

	private sealed class _003CPurchaseCoroutine_003Ed__23(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass23_0 _003C_003E8__1;

		public EditorPurchaseProvider _003C_003E4__this;

		public string productId;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_01d2: Expected Obj, but got I4
			//IL_0167: Expected Obj, but got I4
			EditorPurchaseProvider editorPurchaseProvider = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						goto IL_0195;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass23_0 obj = _003C_003E8__1;
					obj.validationResult = null;
					if (editorPurchaseProvider._purchaseValidationServer != null)
					{
						throw new ArgumentException();
					}
				}
				float value = UnityEngine.Random.value;
				bool flag = value < 0f;
				bool flag2 = !flag;
				bool flag3 = !flag2;
				object obj2 = 1;
				if (!flag3)
				{
					string key = "restore" + productId;
					PlayerPrefs.SetString(key, productId);
					PlayerPrefs.Save();
					obj2 = 0;
				}
				PurchaseDelegate purchaseDelegate = editorPurchaseProvider._purchaseDelegate;
				_003C_003Ec__DisplayClass23_0 obj3 = _003C_003E8__1;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v163.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				goto IL_0195;
			}
			_003C_003E1__state = -1;
			_003C_003Ec__DisplayClass23_0 obj4 = default;
			_003C_003E8__1 = obj4;
			_ = 0f;
			object obj5 = default;
			_003C_003E2__current = obj5;
			_003C_003E1__state = 1;
			return true;
			IL_0195:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CRestoreCoroutine_003Ed__24(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string[] productIds;

		public EditorPurchaseProvider _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a1: Expected Obj, but got I4
			//IL_00aa: Expected Obj, but got I4
			//IL_01a0: Expected Obj, but got I4
			//IL_011e: Expected Obj, but got I
			//IL_01b7: Expected Obj, but got I4
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Expected Obj, but got Unknown
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected Obj, but got Unknown
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					EditorPurchaseProvider editorPurchaseProvider = _003C_003E4__this;
					_003C_003E1__state = -1;
					float value = UnityEngine.Random.value;
					bool flag = value < 0f;
					bool flag2 = !flag;
					bool flag3 = !flag2;
					object obj = 0;
					object obj2 = 0;
					if (!flag3)
					{
						object obj7 = default;
						object obj8 = default;
						while (true)
						{
							string[] array = productIds;
							if (array.Length <= (nint)obj)
							{
								break;
							}
							object obj3 = obj << 2;
							object obj4 = (object)productIds + obj3;
							List<string> lIST_OF_IDS_TO_RESTORE = LIST_OF_IDS_TO_RESTORE;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v16+10]");
							if (lIST_OF_IDS_TO_RESTORE.Contains((string)0))
							{
								ItemRestoredDelegate itemRestoredDelegate = editorPurchaseProvider._itemRestoredDelegate;
								object obj5 = obj << 2;
								object obj6 = (object)productIds + obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v160.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
								obj7 = obj8 + 1;
							}
							object obj9 = obj + 1;
							obj = obj9;
						}
						bool flag4 = (nint)obj7 < 1;
						object obj10 = 1;
						if (!flag4)
						{
							obj10 = 2;
						}
						obj2 = obj10;
					}
					RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = editorPurchaseProvider._restorePurchaseFinishedDelegate;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v137.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 0f;
			object obj11 = default;
			_003C_003E2__current = obj11;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private const float INITIALIZE_FAIL_CHANCE = 0f;

	private const float PRODUCTREQUEST_FAIL_CHANCE = 0f;

	private const float PRODUCTREQUEST_DELAY = 0f;

	private const float PRODUCTREQUEST_INVALID_CHANCE = 0f;

	private const float PURCHASE_DELAY = 0f;

	private const float PURCHASE_FAIL_CHANCE = 0f;

	private static readonly string[] DUMMY_PRICES_LOCALIZED;

	private PurchaseDelegate _purchaseDelegate;

	private ProductInfoRequestDelegate _productRequestDelegate;

	private ItemRestoredDelegate _itemRestoredDelegate;

	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate;

	private IPurchaseValidationServer _purchaseValidationServer;

	private IInAppManager _inAppManager;

	private MonoBehaviour _coroutineBehaviour;

	public static readonly List<string> LIST_OF_IDS_TO_RESTORE;

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer)
	{
		//IL_0122: Expected I, but got Obj
		//IL_002e: Expected I, but got Obj
		//IL_0057: Expected I, but got Obj
		//IL_0085: Expected I, but got Obj
		_inAppManager = inAppManager;
		NullReferenceException ex = new NullReferenceException();
		PurchaseDelegate purchaseDelegate = default;
		purchaseDelegate._002Ector(inAppManager, (IntPtr)ex);
		_purchaseDelegate = purchaseDelegate;
		NullReferenceException ex2 = new NullReferenceException();
		ProductInfoRequestDelegate productInfoRequestDelegate = default;
		productInfoRequestDelegate._002Ector(inAppManager, (IntPtr)ex2);
		_productRequestDelegate = productInfoRequestDelegate;
		NullReferenceException ex3 = new NullReferenceException();
		ItemRestoredDelegate itemRestoredDelegate = default;
		itemRestoredDelegate._002Ector(inAppManager, (IntPtr)ex3);
		_itemRestoredDelegate = itemRestoredDelegate;
		NullReferenceException ex4 = new NullReferenceException();
		RestorePurchaseFinishedDelegate restorePurchaseFinishedDelegate = default;
		restorePurchaseFinishedDelegate._002Ector(inAppManager, (IntPtr)ex4);
		_restorePurchaseFinishedDelegate = restorePurchaseFinishedDelegate;
		_purchaseValidationServer = purchaseValidationServer;
		GameObject gameObject = default;
		gameObject._002Ector("EditorPurchaseProviderCoroutines_autogenerated");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		NewMonoBehaviour coroutineBehaviour = gameObject.AddComponent<NewMonoBehaviour>();
		_coroutineBehaviour = coroutineBehaviour;
		float value = UnityEngine.Random.value;
		bool flag = value > 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
	}

	public bool CanMakePurchases()
	{
		return true;
	}

	public void RequestProductInfo(string[] productIds)
	{
		IEnumerator routine = ProductRequestCoroutine(productIds);
		Coroutine coroutine = _coroutineBehaviour.StartCoroutine(routine);
	}

	public bool StartPurchase(string productId)
	{
		return StartPurchase(productId, (string)(object)this);
	}

	public bool StartPurchase(string productId, string cookie)
	{
		if (_purchaseDelegate != null)
		{
			IEnumerator routine = PurchaseCoroutine(productId);
			Coroutine coroutine = _coroutineBehaviour.StartCoroutine(routine);
		}
		return _purchaseDelegate != null;
	}

	public void FinishPurchase(string productId, string transactionId, string purchaseToken)
	{
	}

	public bool RestoreNonConsumablePurchases(string[] productIds)
	{
		IEnumerator routine = RestoreCoroutine(productIds);
		Coroutine coroutine = _coroutineBehaviour.StartCoroutine(routine);
		return true;
	}

	private IEnumerator ProductRequestCoroutine(string[] productIds)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator PurchaseCoroutine(string productId)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator RestoreCoroutine(string[] productIds)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	static EditorPurchaseProvider()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
