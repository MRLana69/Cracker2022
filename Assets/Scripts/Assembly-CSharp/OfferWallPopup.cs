using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.UI;
using Kiloo.Monetization.Offerwall;
using UI.Screens;
using UnityEngine;

public class OfferWallPopup : UIScreen
{
	public class OfferListAdapter : ListAdapter<OfferWallCell>
	{
		public GameObject offerPrefab;

		public GameObject titlePrefab;

		public Action _onClick;

		private const int OFFER_TITLE_PREFAB = 0;

		private const int OFFER_CELL_PREFAB = 1;

		public OfferListAdapter(List<OfferWallCell> awardList, GameObject offerCell, GameObject titleCell, Action onClick)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v4 (Il2CppClass<Il2CppRgctx<Kiloo.Common.UI.ListAdapter`1<OfferWallCell>>>)+4] (should have been resolved before IL gen)");
			offerPrefab = offerCell;
			titlePrefab = titleCell;
			_onClick = onClick;
		}

		public override int GetModelType(int index)
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<OfferWallPopup+OfferListAdapter>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+8]");
			return ((nint)0 != 0) ? 1 : 0;
		}

		public unsafe override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0211: Expected I, but got Obj
			//IL_01c7: Expected native int or pointer, but got VT
			//IL_01df: Expected native int or pointer, but got VT
			//IL_0202: Expected Obj, but got I
			//IL_0140: Expected Obj, but got I
			//IL_0181: Expected Obj, but got I
			//IL_0181: Expected Obj, but got I
			//IL_0197: Expected Obj, but got I
			object obj = default;
			Color color = (Color)(obj - 32);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S2_v2 (Il2CppClass<OfferWallPopup+OfferListAdapter>)+104] (should have been resolved before IL gen)");
			Container container2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
					if ((nint)0 != 1)
					{
						container2 = null;
						goto IL_0229;
					}
					Container container3 = default;
					container3._002Ector(offerPrefab);
					CoinEarnerLoadingOffer component = container3.model.GetComponent<CoinEarnerLoadingOffer>();
					container2 = container3;
				}
				else
				{
					Container container4 = default;
					container4._002Ector(titlePrefab);
					ListTitleComponentHelper component2 = container4.model.GetComponent<ListTitleComponentHelper>();
					container2 = container4;
				}
				object tag = default;
				container2.tag = tag;
			}
			goto IL_0229;
			IL_0229:
			if (!isMeasurePass)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (OfferWallPopup+OfferListAdapter)+C]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S3_v10+C]");
						int index = (int)(-dataIndex);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v18+8]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+C]");
						((CoinEarnerLoadingOffer)num2).Init((IDisplayableOffer)0, _onClick, index, CoinEarnerLoadingOffer.OfferSourceScreen.OfferWallPopup);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v18+8]");
						((CoinEarnerLoadingOffer)0).SetOffersState(CoinEarnerLoadingOffer.OffersState.Offer);
					}
				}
				else
				{
					string text = Strings.Get(StringID.COIN_SCREEN_EARN_COINS);
					_ = 4575657222465421441L;
					((Color*)(nint)color)->b = 128f / 255f;
					_ = 4509392494575747072L;
					((Color*)(nint)color)->r = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v18+C]");
					((ListTitleComponentHelper)0).Setup(text, color, -150f);
				}
			}
			return container2;
		}
	}

	private GameObject coinEarnerPrefab;

	public Font headerFont;

	private GameObject _contentAnchor;

	private UIWidget _outline;

	private GameObject listTitleComponent;

	private ScrollView _contentListView;

	private UIPanel _scrollPanel;

	private UIPanel _scrollBarPanel;

	private GameObject _noOffersLabel;

	[NonSerialized]
	public int counterForElementsOnDisplay;

	private List<OfferWallCell> _contentList;

	private OfferListAdapter _adapter;

	private int _numberOfOffersAtOpen;

	private int _numberOfOffersClicked;

	private void OnApplicationPause(bool pause)
	{
		if (!pause)
		{
			OfferWallManager instance = OfferWallManager.Instance;
			instance.GetPendingRewards();
			OfferWallManager instance2 = OfferWallManager.Instance;
			instance2.RefreshOffers();
		}
	}

	public unsafe override void Init()
	{
		//IL_0052: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<OfferWallPopup>)+104] (should have been resolved before IL gen)");
		if (_contentList != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(OfferWallPopup.OfferClicked));
			OfferListAdapter offerListAdapter = default;
			offerListAdapter._002Ector(_contentList, coinEarnerPrefab, listTitleComponent, action);
			_adapter = offerListAdapter;
		}
		UpdatePopupList();
	}

	public override void Show()
	{
		base.Show();
		OfferWallManager instance = OfferWallManager.Instance;
		instance.GetPendingRewards();
		OfferWallManager instance2 = OfferWallManager.Instance;
		instance2.RefreshOffers();
		UpdatePopupList();
		OfferWallManager instance3 = OfferWallManager.Instance;
		throw new ArgumentException();
	}

	public override void Hide()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		base.Hide();
		OfferWallManager instance = OfferWallManager.Instance;
		throw new ArgumentException();
	}

	private void RewardsRecieved(int i)
	{
		OfferWallManager instance = OfferWallManager.Instance;
		instance.RefreshOffers();
	}

	private void RewardsNotRecieved()
	{
	}

	private void OffersDownloaded(List<IDisplayableOffer> offers, bool previouslyCached)
	{
		if (offers == null || offers._size <= 0)
		{
			_noOffersLabel.SetActive(value: true);
		}
		else
		{
			UpdatePopupList();
		}
	}

	private void RequestForOffersFailed()
	{
		UpdatePopupList();
	}

	public void UpdatePopupList()
	{
		SetListContent();
		if (_contentListView != null && _adapter != null)
		{
			_contentListView.SetAdapter(_adapter);
		}
		List<OfferWallCell> contentList = _contentList;
		bool active = contentList._size < 2;
		_noOffersLabel.SetActive(active);
	}

	private void OfferClicked()
	{
		int numberOfOffersClicked = _numberOfOffersClicked + 1;
		_numberOfOffersClicked = numberOfOffersClicked;
		OfferWallManager instance = OfferWallManager.Instance;
		instance.RefreshOffers(bypassTimeLimitsEnforcedByOutside: true);
	}

	private void Log(string msg)
	{
	}

	private void SetListContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_0327: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		((List<T>)(object)_contentList).Clear();
		OfferWallCell offerWallCell = default;
		offerWallCell.cellType = OfferWallCellType.TITLE;
		_contentList.Add(offerWallCell);
		object obj3 = obj + 16;
		OfferWallManager instance = OfferWallManager.Instance;
		List<IDisplayableOffer> currentOffers = instance.CurrentOffers;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_01e4;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_01e4;
			IL_01e4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A324");
	}

	public OfferWallPopup()
	{
		List<OfferWallCell> list = default;
		list._002Ector();
		_contentList = list;
		base._002Ector();
	}
}
