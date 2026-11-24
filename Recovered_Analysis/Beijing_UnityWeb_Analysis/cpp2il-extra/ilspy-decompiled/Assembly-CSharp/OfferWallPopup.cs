using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.UI;
using UI.Screens;
using UI.Screens.RewardManagement;
using UI.ScrollListSelectPopup;
using UnityEngine;

public class OfferWallPopup : UIScreen
{
	private class OfferListAdapter : ListAdapter<OfferWallCell>
	{
		private GameObject _offerPrefab;

		private GameObject _titlePrefab;

		private Action _onClick;

		private const int OFFER_TITLE_PREFAB = 0;

		private const int OFFER_CELL_PREFAB = 1;

		public OfferListAdapter(List<OfferWallCell> awardList, GameObject offerCell, GameObject titleCell, Action onClick)
		{
			//IL_00b3: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			bool flag = ((WaterFallReach)(object)this).IsOnMissionTab();
			string text = string.Format((IFormatProvider)(object)"{0}{1};{2}", (string)flag, awardList, titleCell);
			string text2 = string.Format((IFormatProvider)(object)"{0};{1}", (string)(object)offerCell, onClick);
			nint num = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}

		public override int GetModelType(int index)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
					if ((nint)0 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
						return 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
					if ((nint)0 == 3)
					{
						return 1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
					if ((nint)0 == 4)
					{
						return 6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
					if ((nint)0 == 5)
					{
						return 3;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
					if ((nint)0 == 6)
					{
						return 4;
					}
				}
				return 0;
			}
			return 5;
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
		{
			//IL_05e1: Expected Obj, but got I
			//IL_0130: Expected I4, but got Obj
			//IL_0612: Expected Obj, but got I
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected Obj, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected Obj, but got Unknown
			//IL_0634: Expected Obj, but got I
			//IL_064a: Expected Obj, but got I
			//IL_0199: Expected I4, but got Obj
			//IL_067c: Expected Obj, but got I
			//IL_068c: Expected Obj, but got I
			//IL_06b8: Expected Obj, but got I
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			//IL_06d3: Expected Obj, but got I
			//IL_0700: Expected Obj, but got I
			//IL_0710: Expected Obj, but got I
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Expected Obj, but got Unknown
			//IL_0732: Expected Obj, but got I
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Expected Obj, but got Unknown
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected Obj, but got Unknown
			//IL_075e: Expected Obj, but got I
			//IL_0774: Expected Obj, but got I
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected Obj, but got Unknown
			//IL_07a6: Expected Obj, but got I
			//IL_07b6: Expected Obj, but got I
			//IL_07e2: Expected Obj, but got I
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Expected Obj, but got Unknown
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Expected Obj, but got Unknown
			//IL_07fd: Expected Obj, but got I
			//IL_082a: Expected Obj, but got I
			//IL_083a: Expected Obj, but got I
			//IL_0334: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Expected Obj, but got Unknown
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected Obj, but got Unknown
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Expected Obj, but got Unknown
			//IL_03be: Expected Obj, but got I
			//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d4: Expected Obj, but got Unknown
			//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e2: Expected Obj, but got Unknown
			//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0402: Expected Obj, but got Unknown
			//IL_085e: Expected Obj, but got I
			//IL_089a: Expected Obj, but got I
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_0449: Expected Obj, but got Unknown
			//IL_08b4: Expected Obj, but got I
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Expected Obj, but got Unknown
			//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b8: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Container container2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
				object obj2 = default;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
						if ((nint)0 != 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
							if ((nint)0 != 3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
								if ((nint)0 != 4)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
									if ((nint)0 != 5)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
										if ((nint)0 == 6)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (OfferWallPopup+OfferListAdapter)+28]");
											Container container3 = default;
											container3.Measure(includeInactive: false);
											object obj = obj2 + 8;
											DebugSettingsHelper component = container3.model.GetComponent<DebugSettingsHelper>();
											obj = component;
											object obj3 = container3 + 84;
											obj3 = obj2;
											container2 = container3;
										}
										else
										{
											container2 = null;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (OfferWallPopup+OfferListAdapter)+2C]");
										Container container4 = default;
										container4.Measure(includeInactive: false);
										object obj4 = container4 + 84;
										obj4 = obj2;
										container2 = container4;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (OfferWallPopup+OfferListAdapter)+20]");
									Container container5 = default;
									container5.Measure(includeInactive: false);
									object obj5 = obj2 + 8;
									DebugSettingsHelper component2 = container5.model.GetComponent<DebugSettingsHelper>();
									obj5 = component2;
									object obj6 = obj2 + 12;
									nint num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S3_v3 (Il2CppMethodInfo)+18]");
									object obj7 = 0;
									object obj8 = obj7;
									object obj9 = obj8 & 0x1FFF;
									object obj10 = obj9 + 22691;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36 @ S4_v5 (should have been resolved before IL gen)");
									object obj11 = default;
									obj6 = obj11;
									object obj12 = container5 + 84;
									obj12 = obj2;
									container2 = container5;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (OfferWallPopup+OfferListAdapter)+1C]");
								Container container6 = default;
								container6.Measure(includeInactive: false);
								object obj13 = obj2 + 8;
								DebugSettingsHelper component3 = container6.model.GetComponent<DebugSettingsHelper>();
								obj13 = component3;
								object obj14 = obj2 + 12;
								UIButtonMessage component4 = container6.model.GetComponent<UIButtonMessage>();
								obj14 = component4;
								object obj15 = container6 + 84;
								obj15 = obj2;
								container2 = container6;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (OfferWallPopup+OfferListAdapter)+24]");
							Container container7 = default;
							container7.Measure(includeInactive: false);
							object obj16 = obj2 + 8;
							DebugSettingsHelper component5 = container7.model.GetComponent<DebugSettingsHelper>();
							obj16 = component5;
							object obj17 = obj2 + 12;
							UIButtonMessage component6 = container7.model.GetComponent<UIButtonMessage>();
							obj17 = component6;
							object obj18 = container7 + 84;
							obj18 = obj2;
							container2 = container7;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Container container8 = default;
						container8.Measure((byte)(int)_onClick != 0);
						object obj19 = obj2 + 8;
						DebugSettingsHelper component7 = container8.model.GetComponent<DebugSettingsHelper>();
						obj19 = component7;
						object obj20 = obj2 + 12;
						UIButtonMessage component8 = container8.model.GetComponent<UIButtonMessage>();
						obj20 = component8;
						object obj21 = container8 + 84;
						obj21 = obj2;
						container2 = container8;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Container container9 = default;
					container9.Measure((byte)(int)_titlePrefab != 0);
					object obj22 = obj2 + 8;
					DebugSettingsHelper component9 = container9.model.GetComponent<DebugSettingsHelper>();
					obj22 = component9;
					object obj23 = container9 + 84;
					obj23 = obj2;
					container2 = container9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
						if ((nint)0 != 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
							if ((nint)0 != 4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
								if ((nint)0 != 5)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
									if ((nint)0 == 6)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+8]");
										object obj24 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+24]");
										bool flag = (nint)0 != 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+8]");
										nint num2 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+C]");
										((DeviceInfo)num2).formFactor = DeviceInfo.FormFactor.iPhone;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
										object obj25 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
										string text = default;
										string msg = "No cell type match for: " + text;
										SDebug.LogFormat(msg, null);
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+8]");
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+14]");
								((DebugSettingsHelper)num3).SetToggleIcon(DebugSetting.Characters);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+C]");
								object obj26 = (nint)0 + (nint)12;
								string tag = ((Component)(object)_offerPrefab).tag;
								obj26 = tag;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+C]");
								object obj27 = (nint)0 + (nint)16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+18]");
								obj27 = 0;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+8]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+1C]");
							((DebugSettingsHelper)num4).SetExpandableList(DebugSetting.Characters);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+8]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+14]");
							((DebugSettingsHelper)num5).SetToggleIcon(DebugSetting.Characters);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+C]");
							object obj28 = (nint)0 + (nint)12;
							string tag2 = ((Component)(object)_offerPrefab).tag;
							obj28 = tag2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+C]");
							object obj29 = (nint)0 + (nint)16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+18]");
							obj29 = 0;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+8]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+C]");
						((DebugSettingsHelper)num6).SetTesterIcon(ButtonIcon.None);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+C]");
						object obj30 = (nint)0 + (nint)12;
						string tag3 = ((Component)(object)_offerPrefab).tag;
						obj30 = tag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+C]");
						object obj31 = (nint)0 + (nint)16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+18]");
						obj31 = 0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+8]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+14]");
					((DebugSettingsHelper)num7).SetToggleIcon(DebugSetting.Characters);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+8]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+C]");
					((DebugSettingsHelper)num8).SetTesterIcon(ButtonIcon.None);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+C]");
					object obj32 = (nint)0 + (nint)12;
					string tag4 = ((Component)(object)_offerPrefab).tag;
					obj32 = tag4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+C]");
					object obj33 = (nint)0 + (nint)16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+18]");
					obj33 = 0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v15+8]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+14]");
				((DebugSettingsHelper)num9).SetToggleIcon(DebugSetting.Characters);
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

	private List<OfferWallCell> _contentList;

	private OfferListAdapter _adapter;

	private void OnApplicationPause(bool pause)
	{
		//IL_0038: Expected Obj, but got I4
		//IL_0046: Expected I, but got Obj
		//IL_0015: Expected Obj, but got I4
		//IL_0023: Expected I, but got Obj
		bool footerInited = base._footerInited;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (System.Boolean)+C]");
		if ((nint)0 == 2)
		{
			object obj = (base._footerInited ? 1 : 0) + 40;
			nint num = (nint)typeof(UpgradeType);
		}
		else
		{
			object obj = (base._footerInited ? 1 : 0) + 12;
			nint num = (nint)typeof(CelebrationRewardType);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public override void Init()
	{
	}

	public override void Show()
	{
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_016e: Expected I4, but got Obj
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0094: Expected I, but got Obj
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		ShowIfInactive();
		if (_contentList != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			ScrollListSelectPopup scrollListSelectPopup = default;
			((UnityEngine.Object)scrollListSelectPopup).m_CachedPtr = cachedPtr;
			((UIScreen)scrollListSelectPopup)._selectedFooterButton = 0;
			object obj = scrollListSelectPopup + 16;
			obj = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ScrollListSelectPopup.ScrollListSelectAdapter scrollListSelectAdapter = default;
			scrollListSelectAdapter._002Ector((List<ScrollListPopupCell>)(object)_contentList, coinEarnerPrefab, listTitleComponent, scrollListSelectPopup);
			object obj2 = this + 80;
			obj2 = scrollListSelectAdapter;
		}
		UILabel component = _noOffersLabel.GetComponent<UILabel>();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("OFFER_WALL_NO_OFFERS");
		component.fontSize = (int)text;
		OfferClicked();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
	}

	public override void Hide()
	{
		base.Hide();
		OfferClicked();
	}

	private void RewardsRecieved(int i)
	{
	}

	private void RewardsNotRecieved()
	{
		base.LoseFocus();
	}

	private void RequestForOffersFailed()
	{
	}

	public void UpdatePopupList()
	{
		OfferClicked();
	}

	private void OfferClicked()
	{
		//IL_00c2: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I4
		//IL_0082: Expected I4, but got Obj
		this._002Ector();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_contentListView).FindKernel((string)null) != 0 && _adapter != null)
		{
			_contentListView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
		}
		List<OfferWallCell> contentList = _contentList;
		if (contentList._size > 1)
		{
			_noOffersLabel.tag = null;
		}
		else
		{
			_noOffersLabel.tag = (string)1;
		}
	}

	private void Log(string msg)
	{
	}

	private void SetListContent()
	{
	}

	public OfferWallPopup()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
	}
}
