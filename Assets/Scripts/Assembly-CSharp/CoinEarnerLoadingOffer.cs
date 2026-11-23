using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Monetization.Offerwall;
using UnityEngine;

public class CoinEarnerLoadingOffer : MonoBehaviour
{
	public enum OffersState
	{
		Loading,
		NoOffersAvailable,
		Offer
	}

	public enum OfferSourceScreen
	{
		EarnCoins,
		OfferWallPopup
	}

	private sealed class _003CStartLoadingCoroutine_003Ed__36(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CoinEarnerLoadingOffer _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			CoinEarnerLoadingOffer coinEarnerLoadingOffer = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					coinEarnerLoadingOffer._isLodingTimerStarted = false;
					coinEarnerLoadingOffer.SetOffersState(OffersState.NoOffersAvailable);
				}
				return false;
			}
			_003C_003E1__state = -1;
			coinEarnerLoadingOffer._isLodingTimerStarted = true;
			_ = _timeLimit;
			object obj = default;
			_003C_003E2__current = obj;
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

	private GameObject _loadingGameObject;

	private GameObject _noOffersAvailableGameObject;

	private GameObject _offersGameObject;

	private UISprite _fillOverlay;

	private UISprite _backgroundFill;

	private GameObject _coinEarnerPrefab;

	private UISprite _freeSticker;

	private UILabel _priceLabel;

	private UILabel _titleLabel;

	private UILabel _descriptionLabel;

	private UITexture _picture;

	private UILabel _loadingAppOffers;

	private UILabel _couldNotLoad;

	private UILabel _tryAgain;

	private const string BG_SPRITENAME_ACTIVE_DEFAULT = "button_fill_shopItem_main";

	private const string BG_SPRITENAME_OVERLAY_DEFAULT = "button_fill_shopItem_highlight";

	private const string BG_SPRITENAME_INACTIVE = "button_generic_1";

	private UIButtonColor _btColor;

	private OffersState _currentState;

	private static int _timeLimit = 10;

	private bool _isLodingTimerStarted;

	private IDisplayableOffer _offer;

	private Action _onClickHandler;

	private OfferSourceScreen _sourceScreen;

	private int _indexOnScreen;

	public unsafe void Init(IDisplayableOffer offer, Action onClickDelegate, int index, OfferSourceScreen screen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Ref, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (_offer != null)
		{
			return;
		}
		_offer = offer;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CoinEarnerLoadingOffer.OfferImageDownloaded));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		_sourceScreen = screen;
		_indexOnScreen = index;
		if (onClickDelegate != null)
		{
			Delegate obj3 = Delegate.Combine(_onClickHandler, onClickDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			Action onClickHandler = default;
			_onClickHandler = onClickHandler;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string s = default;
		if (int.TryParse(s, out *(int*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 >= (nint)1)
			{
				int num = obj + 12;
				string text = ((int*)num)->ToString();
				_priceLabel.text = text;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string text2 = default;
		_titleLabel.text = text2;
		string text3 = Strings.Get(StringID.TAPJOY_OFFER_DESCRIPTION);
		_descriptionLabel.text = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		UnityEngine.Object obj4 = default;
		if (obj4 != null)
		{
			OfferImageDownloaded();
		}
	}

	private void Awake()
	{
		SetOffersState(OffersState.Loading);
		checkIfNullAndSetTextWhereIsTheCase();
	}

	private unsafe void OnDisable()
	{
		if (_offer != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(CoinEarnerLoadingOffer.OfferImageDownloaded));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public void SetOffersState(OffersState state)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		_currentState = state;
		SetStateGameObjectActive(state switch
		{
			OffersState.Loading => (GameObject)(this + 12), 
			OffersState.NoOffersAvailable => (GameObject)(this + 16), 
			OffersState.Offer => (GameObject)(this + 20), 
			_ => (GameObject)(this + 12), 
		});
	}

	public OffersState getOffersState()
	{
		return _currentState;
	}

	private unsafe void SetStateGameObjectActive(GameObject go)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00e3: Expected Obj, but got VT
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0115: Expected Obj, but got VT
		//IL_013f: Expected F4, but got I
		//IL_013a: Expected native int or pointer, but got VT
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0172: Expected Obj, but got VT
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_01aa: Expected F4, but got I
		//IL_01a5: Expected native int or pointer, but got VT
		//IL_0315: Expected Obj, but got VT
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_0347: Expected Obj, but got VT
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got VT
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected VT, but got Unknown
		object obj = default;
		Color color = (Color)(obj + -64);
		if (_loadingGameObject != null)
		{
			_loadingGameObject.SetActive(value: false);
		}
		if (_noOffersAvailableGameObject != null)
		{
			_noOffersAvailableGameObject.SetActive(value: false);
		}
		if (_offersGameObject != null)
		{
			_offersGameObject.SetActive(value: false);
		}
		if (!(go != null))
		{
			return;
		}
		if (go == _noOffersAvailableGameObject || go == _offersGameObject)
		{
			_backgroundFill.spriteName = "button_fill_shopItem_main";
			object obj2 = GlobalColors.COLOR_WHITE >> 16;
			object obj3 = obj2 & 0xFF;
			float num = (float)obj3 / 255f;
			object obj4 = GlobalColors.COLOR_WHITE >> 24;
			float num2 = (float)obj4 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
			((Color*)(nint)color)->b = 0f;
			object obj5 = GlobalColors.COLOR_WHITE & 0xFF;
			float num3 = (float)obj5 / 255f;
			object obj6 = GlobalColors.COLOR_WHITE >> 8;
			object obj7 = obj6 & 0xFF;
			float num4 = (float)obj7 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
			((Color*)(nint)color)->r = 0f;
			_backgroundFill.color = color;
			_fillOverlay.spriteName = "button_fill_shopItem_highlight";
			GameObject gameObject = _fillOverlay.gameObject;
			gameObject.SetActive(value: true);
			AddButtonColor(_backgroundFill);
			Collider component = _coinEarnerPrefab.GetComponent<Collider>();
			component.enabled = true;
			StopCoroutine("StartLoadingCoroutine");
			_isLodingTimerStarted = false;
		}
		else if (go == _loadingGameObject)
		{
			if (_btColor != null)
			{
				UnityEngine.Object.Destroy(_btColor);
			}
			GameObject gameObject2 = _fillOverlay.gameObject;
			gameObject2.SetActive(value: false);
			Collider component2 = _coinEarnerPrefab.GetComponent<Collider>();
			component2.enabled = false;
			_backgroundFill.spriteName = "button_generic_1";
			object obj8 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE >> 16;
			object obj9 = obj8 & 0xFF;
			float num5 = (float)obj9 / 255f;
			object obj10 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE >> 24;
			float num6 = (float)obj10 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
			_ = 0;
			object obj11 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE & 0xFF;
			float num7 = (float)obj11 / 255f;
			object obj12 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE >> 8;
			object obj13 = obj12 & 0xFF;
			float num8 = (float)obj13 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
			_ = 0;
			Color color2 = color + 16;
			_backgroundFill.color = color2;
			if (!_isLodingTimerStarted)
			{
				Coroutine coroutine = StartCoroutine("StartLoadingCoroutine");
			}
		}
		go.SetActive(value: true);
	}

	private void OnClick()
	{
		if (_noOffersAvailableGameObject.activeInHierarchy)
		{
			OfferWallManager instance = OfferWallManager.Instance;
			instance.RefreshOffers();
			SetOffersState(OffersState.Loading);
		}
		if (_offersGameObject.activeInHierarchy)
		{
			OfferWallManager instance2 = OfferWallManager.Instance;
			instance2.OfferClicked(_offer, _sourceScreen, _indexOnScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string url = default;
			Application.OpenURL(url);
			Action onClickHandler = _onClickHandler;
			if (_onClickHandler != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void AddButtonColor(UISprite tweenTarget)
	{
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got VT
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00bc: Expected VT, but got F4
		//IL_00cb: Expected Obj, but got VT
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got VT
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		object obj = this + 68;
		if (_btColor != null)
		{
			UnityEngine.Object.Destroy((UnityEngine.Object)obj);
		}
		GameObject gameObject = base.gameObject;
		UIButtonColor btColor = gameObject.AddComponent<UIButtonColor>();
		_btColor = btColor;
		UIButtonColor btColor2 = _btColor;
		GameObject tweenTarget2 = tweenTarget.gameObject;
		btColor2.tweenTarget = tweenTarget2;
		UIButtonColor btColor3 = _btColor;
		object obj2 = GlobalColors.COLOR_WHITE >> 24;
		float num = (float)obj2 / 255f;
		object obj3 = GlobalColors.COLOR_WHITE & 0xFF;
		float num2 = (float)obj3 / 255f;
		btColor3.hover = (Color)num2;
		object obj4 = GlobalColors.COLOR_WHITE >> 16;
		object obj5 = obj4 & 0xFF;
		float num3 = (float)obj5 / 255f;
		object obj6 = GlobalColors.COLOR_WHITE >> 8;
		object obj7 = obj6 & 0xFF;
		float num4 = (float)obj7 / 255f;
		UIButtonColor btColor4 = _btColor;
		btColor4.duration = 0.05f;
	}

	private void OfferImageDownloaded()
	{
		//IL_0057: Expected I, but got Obj
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		if (_offer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			UnityEngine.Object obj = default;
			if (obj != null)
			{
				UITexture picture = _picture;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				nint num = (nint)picture;
				object obj2 = picture + 216;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S2_v7 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
			}
		}
	}

	private IEnumerator StartLoadingCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void checkIfNullAndSetTextWhereIsTheCase()
	{
		do
		{
			if (!(_loadingAppOffers == null))
			{
				string text = Strings.Get(StringID.OFFERWALL_BUTTON_LOADING);
				_loadingAppOffers.text = text;
			}
			if (!(_couldNotLoad == null))
			{
				string text2 = Strings.Get(StringID.OFFERWALL_BUTTON_COULD_NOT_LOAD);
				_couldNotLoad.text = text2;
			}
			if (!(_tryAgain == null))
			{
				string text3 = Strings.Get(StringID.OFFERWALL_BUTTON_TRY_AGAIN);
				_tryAgain.text = text3;
			}
		}
		while (_freeSticker == null);
		if (_priceLabel == null)
		{
		}
		if (_titleLabel == null)
		{
		}
		if (_descriptionLabel == null)
		{
		}
		if (!(_picture == null))
		{
		}
	}
}
