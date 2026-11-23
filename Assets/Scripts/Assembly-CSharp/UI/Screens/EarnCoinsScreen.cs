using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using Kiloo.Monetization.Offerwall;
using UnityEngine;

namespace UI.Screens;

public class EarnCoinsScreen : UIScreen
{
	private sealed class _003CDelayingRefreshForUserFeedback_003Ed__39(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public EarnCoinsScreen _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					EarnCoinsScreen earnCoinsScreen = _003C_003E4__this;
					_003C_003E1__state = -1;
					earnCoinsScreen._shouldWaitForUserFeedback = false;
					earnCoinsScreen.RefreshCurrencyEarners();
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 1f;
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

	private sealed class _003CWAIT_003Ed__47(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public EarnCoinsScreen _003C_003E4__this;

		public int numberOfObjects;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					_003C_003E4__this.SetScrollViewCenterOffset(numberOfObjects);
				}
				return false;
			}
			_003C_003E1__state = -1;
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

	public GameObject WatchVideoPrefab;

	public GameObject coinEarnerPrefab;

	public GameObject facebookGiftPrefab;

	public Font headerFont;

	private UITable _table;

	private UIScrollView _dragPanel;

	private GameObject _loadingOffersPrefab;

	private GameObject _listTitleComponent;

	private GameObject _scrollBar;

	private GameObject _noOffersLabelGameObject;

	private CoinEarnerLoadingOffer _coinEarnerLoadingOffer;

	private GameObject _tableItemParent;

	private UIPanel _panel;

	private const int TITLE_FONT_SIZE = 30;

	private const float TABLE_CELL_SPACING = 2f;

	private const int CELL_HEIGHT = 64;

	private static bool _facebookLoginRunning;

	private bool _forceRefreshOfferWall;

	private static bool _shouldRefreshCurrencyEarners;

	private int _onDisplayRowCounter;

	private bool _shouldWaitForUserFeedback;

	private List<IDisplayableOffer> _offers;

	private int offerIndex;

	private static Action<bool> _003C_003Ef__mg_0024cache0;

	private static Action<bool> _003C_003Ef__mg_0024cache1;

	private static Action _003C_003Ef__mg_0024cache2;

	private bool isVideoAddsSupported
	{
		get
		{
			RuntimePlatform platform = Application.platform;
			bool flag = platform == RuntimePlatform.Android;
			bool result = true;
			if (!flag)
			{
				RuntimePlatform platform2 = Application.platform;
				result = true;
			}
			return result;
		}
	}

	private void OnApplicationPause(bool pause)
	{
		if (pause)
		{
			return;
		}
		OfferWallManager instance = OfferWallManager.Instance;
		if (instance.AreOffersAllowedOnDevice())
		{
			OfferWallManager instance2 = OfferWallManager.Instance;
			instance2.RefreshOffers(_forceRefreshOfferWall);
			if (~(_forceRefreshOfferWall ? 1u : 0u) == 0)
			{
				_forceRefreshOfferWall = false;
			}
			else
			{
				RefreshCurrencyEarners();
			}
		}
		else
		{
			RefreshCurrencyEarners();
		}
	}

	public override void Init()
	{
		//IL_0015: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Screens.EarnCoinsScreen>)+104] (should have been resolved before IL gen)");
		Transform transform = _table.transform;
		Transform parent = transform.parent;
		UIPanel component = parent.GetComponent<UIPanel>();
		_panel = component;
	}

	public override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_ = 0;
		base.Show();
		if (_footerHandler != null)
		{
			_footerHandler.HandleStickers();
		}
		_forceRefreshOfferWall = false;
		OfferWallManager instance = OfferWallManager.Instance;
		throw new ArgumentException();
	}

	public override void Hide()
	{
		base.Hide();
		OfferWallManager instance = OfferWallManager.Instance;
		throw new ArgumentException();
	}

	public void RefreshCurrencyEarners()
	{
		FillTable();
	}

	private void Update()
	{
		if (~(_shouldRefreshCurrencyEarners ? 1u : 0u) == 0)
		{
			RefreshCurrencyEarners();
		}
	}

	private unsafe void FillTable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Expected Obj, but got Unknown
		//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Expected Obj, but got Unknown
		//IL_0e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Expected Obj, but got Unknown
		//IL_0e8a: Expected F4, but got I
		//IL_0293: Expected Obj, but got I
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected Obj, but got Unknown
		//IL_062d: Expected Obj, but got I
		//IL_0046: Expected F4, but got I
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_02b2: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected Obj, but got Unknown
		//IL_0694: Expected Obj, but got I
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected Ref, but got Unknown
		//IL_06eb: Expected Obj, but got I
		//IL_06f3: Expected F4, but got I4
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected Obj, but got Unknown
		//IL_0769: Expected Obj, but got I
		//IL_050e: Expected Obj, but got I4
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected VT, but got Unknown
		//IL_0172: Expected F4, but got I4
		//IL_0182: Expected Obj, but got I
		//IL_0d3c: Expected F4, but got I
		//IL_0581: Expected native int or pointer, but got VT
		//IL_0599: Expected native int or pointer, but got VT
		//IL_08f0: Expected Obj, but got F4
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected Obj, but got Unknown
		//IL_0814: Expected Obj, but got I
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected Ref, but got Unknown
		//IL_07c0: Expected Obj, but got I
		//IL_07c8: Expected F4, but got I4
		//IL_01cd: Expected Obj, but got I
		//IL_0dce: Expected Obj, but got I
		//IL_02f8: Expected F4, but got I4
		//IL_0d8a: Expected Obj, but got I
		//IL_0da3: Expected Obj, but got I
		//IL_0218: Expected Obj, but got I
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Ref, but got Unknown
		//IL_09d8: Expected Obj, but got I
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Expected Obj, but got Unknown
		//IL_0a1c: Expected Obj, but got I
		//IL_0a32: Expected Obj, but got I
		//IL_0a65: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Expected Obj, but got Unknown
		//IL_0bd1: Expected Obj, but got I
		//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Expected Ref, but got Unknown
		//IL_0c7f: Expected Obj, but got I
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected Ref, but got Unknown
		//IL_0aa9: Expected Obj, but got I
		//IL_0ab1: Expected Obj, but got I4
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected Ref, but got Unknown
		//IL_09a5: Expected Obj, but got I
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected Ref, but got Unknown
		//IL_08b5: Expected Obj, but got I
		//IL_08bd: Expected F4, but got I4
		//IL_0c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c20: Expected Obj, but got Unknown
		//IL_0c30: Expected Obj, but got I
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Expected Ref, but got Unknown
		//IL_0b85: Expected Obj, but got I
		object obj = default;
		Color color = (Color)(obj - 96);
		_ = 0;
		_ = 0;
		Transform transform = _table.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj2 = color + 84;
		object obj3 = color + 92;
		_ = 0;
		object obj4 = color - -64;
		float num;
		object obj5 = default;
		GameObject gameObject;
		GameObject gameObject2 = default;
		object arg = default;
		object arg2 = default;
		int num2;
		object obj11 = default;
		object obj12 = default;
		int num3 = default;
		int num4 = default;
		EarnCoinsScreen earnCoinsScreen = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+5C]");
			num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_038c;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+5C]");
				num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag = (nint)0 == 1;
						gameObject = gameObject2;
						if (!flag)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag2 = (nint)0 == 1;
							gameObject = gameObject2;
							if (!flag2)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag3 = (nint)0 == 1;
								num = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								gameObject = (GameObject)0;
								if (!flag3)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag4 = (nint)0 == 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									gameObject = (GameObject)0;
									if (!flag4)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag5 = (nint)0 == 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										gameObject = (GameObject)0;
										if (!flag5)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												continue;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											gameObject = (GameObject)0;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									num = 0f;
									goto IL_02fd;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						gameObject = (GameObject)0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					gameObject = (GameObject)0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				gameObject = (GameObject)0;
			}
			goto IL_02fd;
			IL_038c:
			object obj6 = color + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			offerIndex = 0;
			_onDisplayRowCounter = 0;
			GameObject parent = _table.gameObject;
			GameObject tableItemParent = NGUITools.AddChild(parent);
			_tableItemParent = tableItemParent;
			_ = 0;
			object obj7 = color + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			string text = $"{arg:000}";
			_tableItemParent.name = text;
			_noOffersLabelGameObject.SetActive(value: false);
			GameObject parent2 = _table.gameObject;
			GameObject gameObject3 = NGUITools.AddChild(parent2, _listTitleComponent);
			ListTitleComponentHelper component = gameObject3.GetComponent<ListTitleComponentHelper>();
			Transform transform2 = gameObject3.transform;
			Transform parent3 = _tableItemParent.transform;
			transform2.parent = parent3;
			_ = 0;
			object obj8 = color - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			string text2 = $"{arg2:000}";
			gameObject3.name = text2;
			Transform transform3 = gameObject3.transform;
			object obj9 = _onDisplayRowCounter * -67;
			object obj10 = obj9 + 15;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
			_ = 0;
			Vector3 localPosition = (Vector3)(color + 16);
			transform3.localPosition = localPosition;
			string text3 = Strings.Get(StringID.EARN_COINS_TITLE);
			_ = 4575657222465421441L;
			((Color*)(nint)color)->b = 128f / 255f;
			_ = 4509392494575747072L;
			((Color*)(nint)color)->r = 0f;
			component.Setup(text3, color, -142.5f);
			_ = 1;
			num = -142.5f;
			gameObject = gameObject3;
			num2 = 0;
			break;
			IL_02fd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag6 = obj11 != obj12;
			num2 = num3;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_038c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				num2 = num4;
			}
			_ = 0;
			object obj13 = color + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			earnCoinsScreen = (EarnCoinsScreen)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
		}
		while (true)
		{
			EarnCoinsData.EarnCurrencyProfile[] profiles = EarnCoinsData.profiles;
			if (num2 >= profiles.Length)
			{
				break;
			}
			int num5 = num2 << 2;
			object obj14 = EarnCoinsData.profiles + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S0_v223+10]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v224+8]");
			if ((nint)0 == 8)
			{
				ref int numberOfObjects = ref *(int*)(color + 88);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				((EarnCoinsScreen)0).InsertEarner(num2, ref numberOfObjects);
				num = num2;
				break;
			}
			int num6 = num2 + 1;
			num2 = num6;
		}
		bool isRestricted = AgeRestriction.isRestricted;
		int num7 = 0;
		if (!isRestricted)
		{
			while (true)
			{
				EarnCoinsData.EarnCurrencyProfile[] profiles2 = EarnCoinsData.profiles;
				if (num7 >= profiles2.Length)
				{
					break;
				}
				int num8 = num7 << 2;
				object obj16 = EarnCoinsData.profiles + num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S0_v210+10]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S0_v211+8]");
				if ((nint)0 == 10)
				{
					ref int numberOfObjects2 = ref *(int*)(color + 88);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					((EarnCoinsScreen)0).InsertEarner(num7, ref numberOfObjects2);
					num = num7;
					break;
				}
				int num9 = num7 + 1;
				num7 = num9;
			}
			int num10 = 0;
			while (true)
			{
				EarnCoinsData.EarnCurrencyProfile[] profiles3 = EarnCoinsData.profiles;
				if (num10 >= profiles3.Length)
				{
					break;
				}
				int num11 = num10 << 2;
				object obj18 = EarnCoinsData.profiles + num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ S0_v189+10]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ S0_v190+8]");
				if ((nint)0 == 9)
				{
					SocialManager instance = SocialManager.instance;
					if (!instance.facebookIsLoggedIn)
					{
						PlayerInfo instance2 = PlayerInfo.Instance;
						if (!instance2._hasPayedOutFacebook)
						{
							ref int numberOfObjects3 = ref *(int*)(color + 88);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							((EarnCoinsScreen)0).InsertEarner(num10, ref numberOfObjects3);
							num = num10;
						}
					}
					break;
				}
				int num12 = num10 + 1;
				num10 = num12;
			}
			OfferWallManager instance3 = OfferWallManager.Instance;
			bool flag7 = instance3.AreOffersAllowedOnDevice();
			bool flag8 = !flag7;
			IDisplayableOffer displayableOffer = (IDisplayableOffer)num;
			if (!flag8)
			{
				List<IDisplayableOffer> offers = earnCoinsScreen._offers;
				if (earnCoinsScreen._offers != null && offers._size >= 1 && !earnCoinsScreen._shouldWaitForUserFeedback)
				{
					ref int numberOfObjects4 = ref *(int*)(color + 88);
					displayableOffer = earnCoinsScreen._offers.get_Item(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					((EarnCoinsScreen)0).InsertOffer(ref numberOfObjects4, CoinEarnerLoadingOffer.OffersState.Offer, displayableOffer);
				}
				else
				{
					ref int numberOfObjects5 = ref *(int*)(color + 88);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					((EarnCoinsScreen)0).InsertOffer(ref numberOfObjects5, CoinEarnerLoadingOffer.OffersState.Loading, null);
					displayableOffer = null;
				}
			}
			int num13 = 0;
			while (true)
			{
				EarnCoinsData.EarnCurrencyProfile[] profiles4 = EarnCoinsData.profiles;
				if (profiles4.Length <= num13)
				{
					break;
				}
				int num14 = num13 << 2;
				object obj20 = EarnCoinsData.profiles + num14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ S0_v158+10]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S0_v159+8]");
				object obj22 = -2;
				if ((nint)obj22 >= 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S0_v159+8]");
					object obj23 = -8;
					if ((nint)obj23 >= 3)
					{
						ref int numberOfObjects6 = ref *(int*)(color + 88);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						((EarnCoinsScreen)0).InsertEarner(num13, ref numberOfObjects6);
						displayableOffer = (IDisplayableOffer)num13;
					}
				}
				int num15 = num13 + 1;
				num13 = num15;
			}
			List<IDisplayableOffer> offers2 = earnCoinsScreen._offers;
			if (earnCoinsScreen._offers != null && offers2._size >= 2 && !earnCoinsScreen._shouldWaitForUserFeedback)
			{
				int num16 = 1;
				while (true)
				{
					List<IDisplayableOffer> offers3 = earnCoinsScreen._offers;
					if (num16 >= offers3._size)
					{
						break;
					}
					ref int numberOfObjects7 = ref *(int*)(color + 88);
					displayableOffer = earnCoinsScreen._offers.get_Item(num16);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					((EarnCoinsScreen)0).InsertOffer(ref numberOfObjects7, CoinEarnerLoadingOffer.OffersState.Offer, displayableOffer);
					int num17 = num16 + 1;
					num16 = num17;
				}
			}
			int num18 = 0;
			while (true)
			{
				EarnCoinsData.EarnCurrencyProfile[] profiles5 = EarnCoinsData.profiles;
				if (num18 >= profiles5.Length)
				{
					break;
				}
				int num19 = num18 << 2;
				object obj24 = EarnCoinsData.profiles + num19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ S0_v117+10]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ S0_v118+8]");
				if ((nint)0 != 2)
				{
					int num20 = num18 << 2;
					object obj26 = EarnCoinsData.profiles + num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ S0_v132+10]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ S0_v133+8]");
					if ((nint)0 != 3)
					{
						goto IL_0c84;
					}
				}
				ref int numberOfObjects8 = ref *(int*)(color + 88);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				((EarnCoinsScreen)0).InsertEarner(num18, ref numberOfObjects8);
				goto IL_0c84;
				IL_0c84:
				int num21 = num18 + 1;
				num18 = num21;
			}
		}
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.MetroPlayerARM)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+58]");
			if ((nint)0 == 1)
			{
				gameObject.SetActive(value: false);
				earnCoinsScreen._noOffersLabelGameObject.SetActive(value: true);
			}
		}
		if (earnCoinsScreen._panel != null)
		{
			UIPanel panel = earnCoinsScreen._panel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S0_v56 (UIPanel)+D4]");
			float num22 = Math.Abs(0f);
			if (num22 < 1f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				nint num23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+58]");
				IEnumerator routine = ((EarnCoinsScreen)num23).WAIT(0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				Coroutine coroutine = ((MonoBehaviour)0).StartCoroutine(routine);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				nint num24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+58]");
				((EarnCoinsScreen)num24).SetScrollViewCenterOffset(0);
			}
		}
		_shouldRefreshCurrencyEarners = false;
	}

	private unsafe void InsertEarner(int index, ref int numberOfObjects)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_066c: Expected Obj, but got I4
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Obj, but got Unknown
		//IL_06c3: Expected VT, but got Obj
		//IL_06da: Expected Obj, but got I4
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected Obj, but got Unknown
		//IL_01e8: Expected Obj, but got I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0237: Expected I4, but got Obj
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected VT, but got Unknown
		//IL_0412: Expected Obj, but got I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0288: Expected Obj, but got I4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_077d: Expected Obj, but got I4
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_04a3: Expected Obj, but got I4
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_04ee: Expected I4, but got Obj
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected VT, but got Unknown
		//IL_084b: Expected Obj, but got I4
		object obj = default;
		EarnCoinsScreen earnCoinsScreen = (EarnCoinsScreen)(obj - 96);
		EarnCoinsData.EarnCurrencyProfile[] profiles = EarnCoinsData.profiles;
		if (profiles.Length <= index || !EarnCoinsData.ShouldShowInGUI(index))
		{
			return;
		}
		int num = index << 2;
		object obj2 = EarnCoinsData.profiles + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v29+10]");
		EarnCoinsData.EarnCurrencyProfile earnCurrencyProfile = (EarnCoinsData.EarnCurrencyProfile)0;
		object obj3 = earnCurrencyProfile.id - 8;
		if (earnCurrencyProfile.id != EarnCoinsData.Id.VideoAd)
		{
			if ((nint)obj3 != 1 && (nint)obj3 == 2)
			{
				FacebookWeeklyGiftManager instance = FacebookWeeklyGiftManager.Instance;
				if (!instance.IsGiftAvailable())
				{
					return;
				}
				int onDisplayRowCounter = _onDisplayRowCounter + 1;
				_onDisplayRowCounter = onDisplayRowCounter;
				GameObject parent = _table.gameObject;
				GameObject gameObject = NGUITools.AddChild(parent, facebookGiftPrefab);
				earnCoinsScreen._coinEarnerLoadingOffer = (CoinEarnerLoadingOffer)numberOfObjects;
				object obj4 = earnCoinsScreen + 92;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg = default;
				string text = $"{arg:000}";
				gameObject.name = text;
				Transform transform = gameObject.transform;
				Transform parent2 = _tableItemParent.transform;
				transform.parent = parent2;
				Transform transform2 = gameObject.transform;
				object obj5 = _onDisplayRowCounter * -67;
				UITable table = (UITable)(obj5 + 15);
				earnCoinsScreen._dragPanel = null;
				earnCoinsScreen.InComplete = null;
				earnCoinsScreen.headerFont = null;
				earnCoinsScreen._table = table;
				((UIScreen)earnCoinsScreen)._footerInited = (byte)(int)earnCoinsScreen.headerFont != 0;
				Vector3 localPosition = (Vector3)(earnCoinsScreen + 32);
				transform2.localPosition = localPosition;
				FacebookGiftButton component = gameObject.GetComponent<FacebookGiftButton>();
				string earnerTitle = Strings.Get(earnCurrencyProfile.title);
				string earnerDesc = Strings.Get(earnCurrencyProfile.desc);
				component.Init(index, earnerTitle, earnerDesc, null, _dragPanel);
				UIDragScrollView component2 = gameObject.GetComponent<UIDragScrollView>();
				component2.scrollView = _dragPanel;
				NGUITools.AddWidgetCollider(gameObject);
				UIPlaySound component3 = gameObject.GetComponent<UIPlaySound>();
				if (component3 != null)
				{
					component3.enabled = false;
				}
			}
			else
			{
				int onDisplayRowCounter2 = _onDisplayRowCounter + 1;
				_onDisplayRowCounter = onDisplayRowCounter2;
				GameObject parent3 = _table.gameObject;
				GameObject gameObject2 = NGUITools.AddChild(parent3, coinEarnerPrefab);
				Transform transform3 = gameObject2.transform;
				Transform parent4 = _tableItemParent.transform;
				transform3.parent = parent4;
				Transform transform4 = gameObject2.transform;
				object obj6 = _onDisplayRowCounter * -67;
				GameObject watchVideoPrefab = (GameObject)(obj6 + 15);
				earnCoinsScreen.coinEarnerPrefab = null;
				((UnityEngine.Object)earnCoinsScreen).m_CachedPtr = (IntPtr)0;
				((UIScreen)earnCoinsScreen).parentScreen__BackingField = null;
				earnCoinsScreen.WatchVideoPrefab = watchVideoPrefab;
				earnCoinsScreen = (EarnCoinsScreen)(object)((UIScreen)earnCoinsScreen).parentScreen__BackingField;
				transform4.localPosition = (Vector3)earnCoinsScreen;
				earnCoinsScreen._coinEarnerLoadingOffer = (CoinEarnerLoadingOffer)numberOfObjects;
				object obj7 = earnCoinsScreen + 92;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg2 = default;
				string text2 = $"{arg2:000}";
				gameObject2.name = text2;
				RuntimePlatform platform = Application.platform;
				StringID key = ((platform != RuntimePlatform.IPhonePlayer) ? earnCurrencyProfile.desc : earnCurrencyProfile.iOSDesc);
				string format = Strings.Get(key);
				int amountOfCoins = earnCurrencyProfile.GetAmountOfCoins();
				earnCoinsScreen._coinEarnerLoadingOffer = (CoinEarnerLoadingOffer)amountOfCoins;
				object obj8 = earnCoinsScreen + 92;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg3 = default;
				string desc = string.Format(format, arg3);
				CoinEarnerButtonHelper component4 = gameObject2.GetComponent<CoinEarnerButtonHelper>();
				string title = Strings.Get(earnCurrencyProfile.title);
				int amountOfCoins2 = earnCurrencyProfile.GetAmountOfCoins();
				component4.Init(index, title, desc, earnCurrencyProfile.iconName, amountOfCoins2, null);
				UIDragScrollView component5 = gameObject2.GetComponent<UIDragScrollView>();
				component5.scrollView = _dragPanel;
				NGUITools.AddWidgetCollider(gameObject2);
			}
		}
		else
		{
			if (!earnCoinsScreen.isVideoAddsSupported)
			{
				return;
			}
			int onDisplayRowCounter3 = _onDisplayRowCounter + 1;
			_onDisplayRowCounter = onDisplayRowCounter3;
			GameObject parent5 = _table.gameObject;
			GameObject gameObject3 = NGUITools.AddChild(parent5, WatchVideoPrefab);
			earnCoinsScreen._coinEarnerLoadingOffer = (CoinEarnerLoadingOffer)numberOfObjects;
			object obj9 = earnCoinsScreen + 92;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg4 = default;
			string text3 = $"{arg4:000}";
			gameObject3.name = text3;
			Transform transform5 = gameObject3.transform;
			Transform parent6 = _tableItemParent.transform;
			transform5.parent = parent6;
			Transform transform6 = gameObject3.transform;
			object obj10 = _onDisplayRowCounter * -67;
			GameObject scrollBar = (GameObject)(obj10 + 15);
			earnCoinsScreen._noOffersLabelGameObject = null;
			earnCoinsScreen._selectedFooterButton = 0;
			earnCoinsScreen._listTitleComponent = null;
			earnCoinsScreen._scrollBar = scrollBar;
			((UIScreen)earnCoinsScreen).addScreen = (byte)(int)earnCoinsScreen._listTitleComponent != 0;
			Vector3 localPosition2 = (Vector3)(earnCoinsScreen + 16);
			transform6.localPosition = localPosition2;
			string format2 = Strings.Get(earnCurrencyProfile.desc);
			int amountOfCoins3 = earnCurrencyProfile.GetAmountOfCoins();
			earnCoinsScreen._loadingOffersPrefab = (GameObject)amountOfCoins3;
			object obj11 = earnCoinsScreen + 76;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg5 = default;
			string desc2 = string.Format(format2, arg5);
			CoinEarnerVideoAds component6 = gameObject3.GetComponent<CoinEarnerVideoAds>();
			string title2 = Strings.Get(earnCurrencyProfile.title);
			int amountOfCoins4 = earnCurrencyProfile.GetAmountOfCoins();
			component6.Init(index, title2, desc2, earnCurrencyProfile.iconName, amountOfCoins4, null, _dragPanel);
			UIDragScrollView component7 = gameObject3.GetComponent<UIDragScrollView>();
			component7.scrollView = _dragPanel;
			NGUITools.AddWidgetCollider(gameObject3);
			UIPlaySound component8 = gameObject3.GetComponent<UIPlaySound>();
			if (component8 != null)
			{
				component8.enabled = false;
			}
		}
		object obj12 = numberOfObjects + 1;
		ref int reference = ref *(int*)obj12;
	}

	private unsafe void InsertOffer(ref int numberOfObjects, CoinEarnerLoadingOffer.OffersState offerState, IDisplayableOffer offer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0063: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0080: Expected native int or pointer, but got VT
		//IL_00a5: Expected F4, but got I
		//IL_00a0: Expected native int or pointer, but got VT
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		int num = offerIndex + 1;
		offerIndex = num;
		int onDisplayRowCounter = _onDisplayRowCounter + 1;
		_onDisplayRowCounter = onDisplayRowCounter;
		GameObject parent = _table.gameObject;
		GameObject gameObject = NGUITools.AddChild(parent, _loadingOffersPrefab);
		Transform transform = gameObject.transform;
		Transform parent2 = _tableItemParent.transform;
		transform.parent = parent2;
		Transform transform2 = gameObject.transform;
		object obj2 = _onDisplayRowCounter * -67;
		object obj3 = obj2 + 15;
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform2.localPosition = vector;
		_ = numberOfObjects;
		object obj4 = vector + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text = $"{arg:000}";
		gameObject.name = text;
		UIDragScrollView component = gameObject.GetComponent<UIDragScrollView>();
		component.scrollView = _dragPanel;
		CoinEarnerLoadingOffer component2 = gameObject.GetComponent<CoinEarnerLoadingOffer>();
		_coinEarnerLoadingOffer = component2;
		NGUITools.AddWidgetCollider(gameObject);
		object obj5 = numberOfObjects + 1;
		ref int reference = ref *(int*)obj5;
		if (_coinEarnerLoadingOffer != null)
		{
			if (offer != null)
			{
				Action action = default;
				action._002Ector(this, (nint)__ldftn(EarnCoinsScreen.EnableRefreshOfferwall));
				_coinEarnerLoadingOffer.Init(offer, action, offerIndex, CoinEarnerLoadingOffer.OfferSourceScreen.EarnCoins);
			}
			_coinEarnerLoadingOffer.SetOffersState(offerState);
		}
	}

	private void EnableRefreshOfferwall()
	{
		_forceRefreshOfferWall = true;
	}

	private void OffersDownloaded(List<IDisplayableOffer> offers, bool cachedList)
	{
		if (offers == null || offers._size == 0)
		{
			if (_coinEarnerLoadingOffer != null)
			{
				_coinEarnerLoadingOffer.SetOffersState(CoinEarnerLoadingOffer.OffersState.NoOffersAvailable);
			}
			_shouldWaitForUserFeedback = false;
			RefreshCurrencyEarners();
			return;
		}
		_offers = offers;
		bool shouldWaitForUserFeedback = (byte)((cachedList ? 1u : 0u) ^ 1u) != 0;
		_shouldWaitForUserFeedback = shouldWaitForUserFeedback;
		if (cachedList)
		{
			return;
		}
		if (_coinEarnerLoadingOffer != null)
		{
			CoinEarnerLoadingOffer coinEarnerLoadingOffer = _coinEarnerLoadingOffer;
			if (coinEarnerLoadingOffer._currentState != CoinEarnerLoadingOffer.OffersState.Loading)
			{
				RefreshCurrencyEarners();
			}
		}
		IEnumerator routine = DelayingRefreshForUserFeedback();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator DelayingRefreshForUserFeedback()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void RequestForOffersFailed()
	{
		_shouldWaitForUserFeedback = false;
		RefreshCurrencyEarners();
	}

	public static void FacebookLoginClicked()
	{
		throw new ArgumentException();
	}

	public unsafe static void OnFacebookLoginResult(bool loggedIn)
	{
		if (!loggedIn && ~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			_facebookLoginRunning = false;
			Action action = default;
			action._002Ector(null, (nint)(delegate*<void>)(&OnFailSlideInFinish));
			QueueFacebookFailSlideIn(action);
		}
	}

	private static void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		UIScreenController instance = UIScreenController.Instance;
		UIScreenController.SlideIn slideIn = default;
		slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.ConnectFailed, onFinishCallback);
		instance.QueueSlideIn(slideIn);
	}

	private static void OnFailSlideInFinish()
	{
		FacebookStatusChanged(success: false);
	}

	private static void FacebookStatusChanged(bool success)
	{
		if (success)
		{
			bool flag = FacebookRewardsInfo.HasReceivedAllAvailableRewards();
			UIScreenController instance = UIScreenController.Instance;
			if (!flag)
			{
				instance.PushPopup("FacebookRewardsPopup");
			}
			else
			{
				UIScreenController.SlideIn slideIn = default;
				slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.ConnectSucceeded);
				instance.QueueSlideIn(slideIn);
			}
		}
		else if (~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			OnFacebookLoginResult(loggedIn: false);
		}
		HouseKeeper.SetFacebookPayoutActionToDefault();
		_shouldRefreshCurrencyEarners = true;
		_facebookLoginRunning = false;
	}

	private void OnDisable()
	{
		if (~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			HouseKeeper.SetFacebookPayoutActionToDefault();
			_facebookLoginRunning = false;
		}
	}

	private IEnumerator WAIT(int numberOfObjects)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void SetScrollViewCenterOffset(int numberOfObjects)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		bool flag = IsListBiggerThanClip(numberOfObjects);
		if (!flag)
		{
			GameObject go = _table.gameObject;
			UIWidget uIWidget = NGUITools.AddWidget<UIWidget>(go);
			uIWidget.height = 1000;
			_dragPanel.ResetPosition();
		}
		object obj = this + 72;
		((Behaviour)obj).enabled = flag;
		_scrollBar.SetActive(flag);
		UITable table = _table;
		object obj2 = table - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S1_v9+BC] (should have been resolved before IL gen)");
	}

	private bool IsListBiggerThanClip(int nbOfElementsInList)
	{
		//IL_0059: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		int num = nbOfElementsInList << 6;
		object obj = num - 34;
		object obj2 = nbOfElementsInList + nbOfElementsInList;
		if (_panel != null)
		{
			UIPanel panel = _panel;
			object obj3 = obj + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v18 (UIPanel)+D4]");
			return 0 < (nint)obj3;
		}
		return false;
	}

	public EarnCoinsScreen()
	{
		List<IDisplayableOffer> list = default;
		list._002Ector();
		_offers = list;
		base._002Ector();
	}
}
