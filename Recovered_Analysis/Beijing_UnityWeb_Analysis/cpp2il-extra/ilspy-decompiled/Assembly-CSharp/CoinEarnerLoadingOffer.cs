using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class CoinEarnerLoadingOffer : MonoBehaviour
{
	public enum OffersState
	{
		Loading,
		NoOffersAvailable,
		OfferWall
	}

	private sealed class _003CStartLoadingCoroutine_003Ed__31(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CoinEarnerLoadingOffer _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Expected Obj, but got Unknown
				//IL_0079: Expected Obj, but got I4
				//IL_00a5: Expected Obj, but got I4
				CoinEarnerLoadingOffer coinEarnerLoadingOffer = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						coinEarnerLoadingOffer._isLodingTimerStarted = false;
						coinEarnerLoadingOffer.SetStateGameObjectActive((GameObject)1);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				coinEarnerLoadingOffer._isLodingTimerStarted = true;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 10f;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private GameObject _loadingGameObject;

	private GameObject _noOffersAvailableGameObject;

	private GameObject _offerWallGameObject;

	private UISprite _fillOverlay;

	private UISprite _backgroundFill;

	private GameObject _coinEarnerPrefab;

	private UILabel _titleLabel;

	private UILabel _getLabel;

	private UILabel _descriptionLabel;

	private UILabelLimiter labelLimiter;

	private UILabel _loadingAppOffers;

	private UILabel _couldNotLoad;

	private UILabel _tryAgain;

	private const string BG_SPRITENAME_ACTIVE_DEFAULT = "button_fill_shopItem_special_main";

	private const string BG_SPRITENAME_OVERLAY_DEFAULT = "button_fill_shopItem_special_highlight";

	private const string BG_SPRITENAME_INACTIVE = "button_generic_1";

	private OffersState _currentState;

	private const int LOADING_TIME_LIMIT = 10;

	private bool _isLodingTimerStarted;

	private Action _onClickHandler;

	private int _indexOnScreen;

	public void Init(Action onClickDelegate)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		object obj = this - -64;
		object obj2 = onClickDelegate & 1;
		obj = obj2;
		if (onClickDelegate != null)
		{
			((CoinBoxSizer)this).OnKeysChanged();
		}
	}

	private void Awake()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this - -64;
		obj = 1;
		_ = -1f;
		_ = 2f;
		_ = 25f;
		_ = 13f;
		CancelInvoke();
	}

	private void OnEnable()
	{
		SetStateGameObjectActive(null);
		this._002Ector();
	}

	private unsafe void OnOfferWallReceived()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		AssetBundleManager instance = AssetBundleManager.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CoinEarnerLoadingOffer.OnOfferWallReceived);
		object obj = action + 16;
		obj = this;
		((OfferWallManager)(object)instance).onOfferWallReceived -= action;
	}

	private void OnDisable()
	{
		//IL_000b: Expected Obj, but got I4
		SetStateGameObjectActive((GameObject)2);
	}

	public void SetOffersState(OffersState state)
	{
		//IL_01c2: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_004d: Expected I, but got Obj
		//IL_01a1: Expected I4, but got Obj
		//IL_0139: Expected I4, but got Obj
		//IL_00eb: Expected I, but got Obj
		if (state != OffersState.Loading)
		{
			object obj = this + 72;
			Delegate obj2 = ((Delegate)_onClickHandler).CombineImpl((Delegate)state);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = default;
			obj = obj3;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)labelLimiter).FindKernel((string)null) != 0)
		{
			labelLimiter._002Ector();
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v11 (Il2CppClass<Strings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v21 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("TAPJOY_OFFER_TITLE");
		_titleLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("TAPJOY_OFFER_DESCRIPTION");
		_descriptionLabel.fontSize = (int)text2;
	}

	public OffersState GetOffersState()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		return (obj != null) ? OffersState.NoOffersAvailable : OffersState.Loading;
	}

	private void SetStateGameObjectActive(GameObject go)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		obj = go;
		if ((object)go != null)
		{
			if ((nint)go != 1)
			{
				if ((nint)go == 2)
				{
					LogError((string)(object)_offerWallGameObject);
				}
				else
				{
					LogError((string)(object)_loadingGameObject);
				}
			}
			else
			{
				LogError((string)(object)_noOffersAvailableGameObject);
			}
		}
		else
		{
			LogError((string)(object)_loadingGameObject);
		}
	}

	private void OnClick()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		AssetBundleManager instance = AssetBundleManager.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<int> action = default;
		object obj = action + 16;
		obj = this;
		((OfferWallManager)(object)instance).onPendingRewardsReceived += action;
	}

	private IEnumerator StartLoadingCoroutine()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		return (IEnumerator)(this - -64);
	}

	private void CheckIfNullAndSetTextWhereIsTheCase()
	{
		string text = _noOffersAvailableGameObject.tag;
		if (text != null)
		{
			SetStateGameObjectActive(null);
			AssetBundleManager instance = AssetBundleManager.Instance;
		}
		string text2 = _offerWallGameObject.tag;
		if (text2 != null)
		{
			AssetBundleManager instance2 = AssetBundleManager.Instance;
			if (_onClickHandler != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
		}
	}

	private unsafe void LogError(string message)
	{
		//IL_0607: Expected I, but got Obj
		//IL_061d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_00c2: Expected I, but got Obj
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_0171: Expected I, but got Obj
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected VT, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected Obj, but got Unknown
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_0220: Expected I, but got Obj
		//IL_026d: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I
		//IL_02fb: Expected I, but got Obj
		//IL_0311: Expected Obj, but got I
		//IL_02ae: Expected I, but got Obj
		//IL_050b: Expected I4, but got Obj
		//IL_0519: Expected I, but got Obj
		//IL_052f: Expected Obj, but got I
		//IL_0389: Expected I, but got Obj
		//IL_039f: Expected Obj, but got I
		//IL_033c: Expected I, but got Obj
		//IL_07f3: Expected Obj, but got VT
		//IL_0808: Expected F4, but got Obj
		//IL_0803: Expected native int or pointer, but got VT
		//IL_0822: Expected F4, but got Obj
		//IL_081d: Expected native int or pointer, but got VT
		//IL_0837: Expected F4, but got I
		//IL_0832: Expected native int or pointer, but got VT
		//IL_0846: Expected I4, but got VT
		//IL_0856: Expected I4, but got Obj
		//IL_05b6: Expected Obj, but got I4
		//IL_055a: Expected I, but got Obj
		//IL_03ca: Expected I, but got Obj
		//IL_0896: Expected Obj, but got I4
		//IL_05e8: Expected I4, but got Obj
		//IL_0459: Expected I4, but got Obj
		//IL_0467: Expected I, but got Obj
		//IL_047d: Expected Obj, but got I
		//IL_0773: Expected Obj, but got VT
		//IL_0788: Expected F4, but got Obj
		//IL_0783: Expected native int or pointer, but got VT
		//IL_07a2: Expected F4, but got Obj
		//IL_079d: Expected native int or pointer, but got VT
		//IL_07b7: Expected F4, but got I
		//IL_07b2: Expected native int or pointer, but got VT
		//IL_07c6: Expected I4, but got VT
		//IL_04a8: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v115 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_loadingGameObject).FindKernel((string)null) != 0)
		{
			_loadingGameObject.tag = null;
		}
		else
		{
			((CoinEarnerVideoAds)null).OnFinishedWatchingVideo("Loading Game object not connected in CoinEarnerLoadingOffer");
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v108 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_noOffersAvailableGameObject).FindKernel((string)null) != 0)
		{
			_noOffersAvailableGameObject.tag = null;
		}
		else
		{
			((CoinEarnerVideoAds)null).OnFinishedWatchingVideo("No Offers available Game object not connected in CoinEarnerLoadingOffer");
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v101 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_offerWallGameObject).FindKernel((string)null) != 0)
		{
			_offerWallGameObject.tag = null;
		}
		else
		{
			((CoinEarnerVideoAds)null).OnFinishedWatchingVideo("Offers Game object not connected in CoinEarnerLoadingOffer");
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v109 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj5 + 32);
		object obj6 = obj5 + 16;
		object obj7 = obj5 + 24;
		object obj8 = obj5 + 20;
		if (((ComputeShader)(object)message).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v105 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)message == _noOffersAvailableGameObject)
		{
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v101 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)message == _offerWallGameObject)
			{
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v75 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num14 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v97 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((UnityEngine.Object)(object)message != _loadingGameObject)
				{
					string text = _fillOverlay.tag;
					((GameObject)(object)text).tag = null;
					Collider component = _coinEarnerPrefab.GetComponent<Collider>();
					component.isTrigger = false;
					_backgroundFill.fillCenter = (byte)(int)"button_generic_1" != 0;
					nint num15 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S1_v79 (Il2CppClass<GlobalColors>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num16 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S1_v92 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj6 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE;
					obj8 = obj6;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
					Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					_backgroundFill.rawPivot = (UIWidget.Pivot)matrix4x;
					if (~(_isLodingTimerStarted ? 1u : 0u) != 0)
					{
						Coroutine coroutine = StartCoroutine((IEnumerator)(object)"StartLoadingCoroutine");
					}
				}
				goto IL_0888;
			}
		}
		_backgroundFill.fillCenter = (byte)(int)"button_fill_shopItem_special_main" != 0;
		nint num17 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v39 (Il2CppClass<GlobalColors>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num18 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v60 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj6 = GlobalColors.COLOR_WHITE;
		obj7 = obj6;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_backgroundFill.rawPivot = (UIWidget.Pivot)matrix4x;
		_fillOverlay.fillCenter = (byte)(int)"button_fill_shopItem_special_highlight" != 0;
		string text2 = _fillOverlay.tag;
		((GameObject)(object)text2).tag = (string)1;
		Collider component2 = _coinEarnerPrefab.GetComponent<Collider>();
		component2.isTrigger = true;
		useGUILayout = (byte)(int)"StartLoadingCoroutine" != 0;
		_isLodingTimerStarted = false;
		goto IL_0888;
		IL_0888:
		((GameObject)(object)message).tag = (string)1;
	}

	public CoinEarnerLoadingOffer()
	{
		//IL_05bf: Expected I, but got Obj
		//IL_05d5: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_060f: Expected I4, but got Obj
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		//IL_019c: Expected I, but got Obj
		//IL_01b2: Expected Obj, but got I
		//IL_013f: Expected I, but got Obj
		//IL_065a: Expected I4, but got Obj
		//IL_022a: Expected I, but got Obj
		//IL_0240: Expected Obj, but got I
		//IL_01dd: Expected I, but got Obj
		//IL_02c8: Expected I, but got Obj
		//IL_02de: Expected Obj, but got I
		//IL_026b: Expected I, but got Obj
		//IL_06a5: Expected I4, but got Obj
		//IL_0356: Expected I, but got Obj
		//IL_036c: Expected Obj, but got I
		//IL_0309: Expected I, but got Obj
		//IL_03f4: Expected I, but got Obj
		//IL_040a: Expected Obj, but got I
		//IL_0397: Expected I, but got Obj
		//IL_0492: Expected I, but got Obj
		//IL_04a8: Expected Obj, but got I
		//IL_0435: Expected I, but got Obj
		//IL_0719: Expected I4, but got Obj
		//IL_0520: Expected I, but got Obj
		//IL_0536: Expected Obj, but got I
		//IL_04d3: Expected I, but got Obj
		//IL_0561: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v124 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_loadingAppOffers != null)
		{
			((CoinEarnerVideoAds)null).OnFinishedWatchingVideo("_loadingAppOffers not set in the Coin earner Offer Button Helper prefab");
		}
		else
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v111 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v118 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("OFFERWALL_BUTTON_LOADING");
			_loadingAppOffers.fontSize = (int)text;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v106 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_couldNotLoad != null)
		{
			((CoinEarnerVideoAds)null).OnFinishedWatchingVideo("_couldNotLoad not set in the Coin earner Offer Button Helper prefab");
		}
		else
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v93 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v100 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("OFFERWALL_BUTTON_COULD_NOT_LOAD");
			_couldNotLoad.fontSize = (int)text2;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v88 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_tryAgain != null)
		{
			((CoinEarnerVideoAds)null).OnFinishedWatchingVideo("_couldNotLoad not set in the Coin earner Offer Button Helper prefab");
		}
		else
		{
			nint num11 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v75 (Il2CppClass<Strings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v82 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text3 = Strings.GetDefault("BUTTON_TRY_AGAIN");
			_tryAgain.fontSize = (int)text3;
		}
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_titleLabel != null)
		{
			((CoinEarnerVideoAds)null).OnFinishedWatchingVideo("Title Label not set in the Coin earner Offer Button Helper prefab");
		}
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v64 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_getLabel != null)
		{
			((CoinEarnerVideoAds)null).OnFinishedWatchingVideo("Get Label not set in the Coin earner Offer Button Helper prefab");
		}
		else
		{
			nint num17 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v51 (Il2CppClass<Strings>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num18 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v58 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault("COIN_BUTTON_EARNER_GET");
			_getLabel.fontSize = (int)text4;
		}
		nint num19 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num20 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_descriptionLabel != null)
		{
			((CoinEarnerVideoAds)null).OnFinishedWatchingVideo("Description label not set in the Coin earner Offer Button Helper prefab");
		}
	}
}
