using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using Kiloo.Common.UI;
using UI.FreeStuff;
using UI.Generic;
using UI.Popups;
using UI.Screens;
using UI.SlideIns;
using UnityEngine;

namespace UI.ScrollListSelectPopup;

public class ScrollListSelectPopup : UIScreen
{
	private class ScrollListSelectAdapter : ListAdapter<ScrollListPopupCell>
	{
		private ScrollListSelectPopup _scrollListSettingsPopup;

		private GameObject _scrollListTogglePrefab;

		private GameObject _scrollListSpacePrefab;

		private const int DEBUGSETTINGS_TOGGLE_PREFAB = 0;

		private const int DEBUGSETTINGS_BUTTON_PREFAB = 1;

		private const int DEBUGSETTINGS_SPACE_PREFAB = 2;

		public ScrollListSelectAdapter(List<ScrollListPopupCell> contentList, GameObject scrollListTogglePrefab, GameObject scrollListSpacePrefab, ScrollListSelectPopup screenReference)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = this + 16;
			obj6 = scrollListTogglePrefab;
			object obj7 = this + 20;
			obj7 = scrollListSpacePrefab;
			object obj8 = this + 24;
			obj8 = screenReference;
		}

		public override int GetModelType(int index)
		{
			//IL_0008: Expected Obj, but got I4
			object obj = index;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
			int result = default;
			return result;
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_04dd: Expected Obj, but got I
			//IL_04dd: Expected Obj, but got I
			//IL_0503: Unknown result type (might be due to invalid IL or missing references)
			//IL_0508: Expected Obj, but got Unknown
			//IL_0518: Expected Obj, but got I
			//IL_0521: Unknown result type (might be due to invalid IL or missing references)
			//IL_0526: Expected Obj, but got Unknown
			//IL_00e6: Expected I4, but got Obj
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected Obj, but got Unknown
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected Obj, but got Unknown
			//IL_0168: Expected Obj, but got I4
			//IL_0578: Expected Obj, but got I
			//IL_0578: Expected Obj, but got I
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Expected Obj, but got Unknown
			//IL_05b3: Expected Obj, but got I
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c1: Expected Obj, but got Unknown
			//IL_0615: Expected Obj, but got I
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected Obj, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected Obj, but got Unknown
			//IL_063b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0640: Expected Obj, but got Unknown
			//IL_0650: Expected Obj, but got I
			//IL_0659: Unknown result type (might be due to invalid IL or missing references)
			//IL_065e: Expected Obj, but got Unknown
			//IL_0254: Expected Obj, but got I4
			//IL_0287: Expected I4, but got Obj
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Expected Obj, but got Unknown
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Expected Obj, but got Unknown
			//IL_0309: Expected Obj, but got I4
			//IL_067b: Expected Obj, but got I
			//IL_0364: Expected Obj, but got I
			//IL_03ad: Expected I4, but got Obj
			//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bb: Expected Obj, but got Unknown
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Container container2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
				object obj3 = default;
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
								if ((nint)0 == 4)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ScrollListSelectPopup.ScrollListSelectPopup+ScrollListSelectAdapter)+20]");
									Container container3 = default;
									container3.Measure(includeInactive: false);
									container2 = container3;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
									object obj = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
									string text = default;
									string msg = "No cell type match for: " + text;
									SDebug.LogFormat(msg, null);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									Container container4 = default;
									container4.Measure((byte)(int)_scrollListTogglePrefab != 0);
									object obj2 = obj3 + 12;
									FriendHelperHighScore component = container4.model.GetComponent<FriendHelperHighScore>();
									obj2 = component;
									object obj4 = container4 + 84;
									obj4 = obj3;
									container2 = container4;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								Container container5 = default;
								container5.Measure((byte)(int)_scrollListTogglePrefab != 0);
								object obj5 = obj3 + 12;
								FriendHelperHighScore component2 = container5.model.GetComponent<FriendHelperHighScore>();
								obj5 = component2;
								object obj6 = container5 + 84;
								obj6 = obj3;
								UIDragScrollView component3 = container5.model.GetComponent<UIDragScrollView>();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+1A]");
								bool flag = (nint)0 != 0;
								string tag = (string)((flag ? 1 : 0) ^ 1);
								component3.tag = tag;
								container2 = container5;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ScrollListSelectPopup.ScrollListSelectPopup+ScrollListSelectAdapter)+1C]");
							Container container6 = default;
							container6.Measure(includeInactive: false);
							object obj7 = obj3 + 12;
							FriendHelperHighScore component4 = container6.model.GetComponent<FriendHelperHighScore>();
							obj7 = component4;
							object obj8 = container6 + 84;
							obj8 = obj3;
							UIDragScrollView component5 = container6.model.GetComponent<UIDragScrollView>();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+1A]");
							bool flag2 = (nint)0 != 0;
							string tag2 = (string)((flag2 ? 1 : 0) ^ 1);
							component5.tag = tag2;
							container2 = container6;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ScrollListSelectPopup.ScrollListSelectPopup+ScrollListSelectAdapter)+20]");
						Container container7 = default;
						container7.Measure(includeInactive: false);
						container2 = container7;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Container container8 = default;
					container8.Measure((byte)(int)_scrollListTogglePrefab != 0);
					object obj9 = obj3 + 12;
					FriendHelperHighScore component6 = container8.model.GetComponent<FriendHelperHighScore>();
					obj9 = component6;
					object obj10 = container8 + 84;
					obj10 = obj3;
					UIDragScrollView component7 = container8.model.GetComponent<UIDragScrollView>();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+1A]");
					bool flag3 = (nint)0 != 0;
					string tag3 = (string)((flag3 ? 1 : 0) ^ 1);
					component7.tag = tag3;
					container2 = container8;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
			object obj14 = default;
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
								object obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
								string text2 = default;
								string msg2 = "No cell type match for: " + text2;
								SDebug.LogFormat(msg2, null);
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+19]");
							bool isGameOverScreen = (nint)0 != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v15+C]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+10]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+14]");
							((FriendsLoginFBButton)num).SetToLogInState((byte)num2 != 0, false, isGameOverScreen);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num3 = 0;
							_ = 0;
							object obj12 = default;
							object obj11 = obj12 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v15+C]");
							obj11 = 0;
							object obj13 = obj14 + 28;
							obj13 = obj12;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+18]");
						bool backgroundActive = (nint)0 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v15+C]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+14]");
						((FriendHelperHighScore)num4).InitFriend((Friend)0, 0, backgroundActive);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num5 = 0;
						_ = 0;
						object obj16 = default;
						object obj15 = obj16 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v15+C]");
						obj15 = 0;
						object obj17 = obj14 + 28;
						obj17 = obj16;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+19]");
				bool backgroundActive2 = (nint)0 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v15+C]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+C]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+14]");
				((FriendHelperHighScore)num6).InitDummy((LeaderboardDummyData.LeaderboardDummy)num7, 0, backgroundActive2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num8 = 0;
				_ = 0;
				object obj19 = default;
				object obj18 = obj19 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v15+C]");
				obj18 = 0;
				object obj20 = obj14 + 28;
				obj20 = obj19;
			}
			return container2;
		}
	}

	private GameObject ScrollListTogglePrefab;

	private GameObject ScrollListSpacePrefab;

	private UISprite _popupBackground;

	private UISprite _popupFrame;

	private const int POPUP_MINIMUM_HEIGHT = 58;

	private const int POPUP_MAXIMUM_HEIGHT = 400;

	private const int CELL_HEIGHT_WITH_SPACE = 34;

	private const int FRAME_OFFSET = 13;

	private List<ScrollListPopupCell> _contentList;

	private ScrollListSelectAdapter _adapter;

	private ScrollView _scrollView;

	private Dictionary<string, string> items;

	private Dictionary<string, bool> indicators;

	private bool multiSelect;

	private Action<Dictionary<string, string>> callBack;

	private static ScrollListSelectPopup _instance;

	public static ScrollListSelectPopup instance
	{
		get
		{
			//IL_0196: Expected I, but got Obj
			//IL_01ac: Expected Obj, but got I
			//IL_0226: Expected I, but got Obj
			//IL_023c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01d7: Expected I, but got Obj
			//IL_01ed: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_00bb: Expected I, but got Obj
			//IL_00d1: Expected Obj, but got I
			//IL_0149: Expected I, but got Obj
			//IL_00fc: Expected I, but got Obj
			nint num = (nint)typeof(SlideInData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.SlideIns.SlideInData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SlideInData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<UI.SlideIns.SlideInData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (SlideInData._instance != null)
			{
				_0021_00210[] array = (_0021_00210[])(object)Resources.LoadAll<T>("Info/SlideInData");
				nint num5 = (nint)typeof(SlideInData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppClass<UI.SlideIns.SlideInData>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(SlideInData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v39 (Il2CppClass<UI.SlideIns.SlideInData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				SlideInData._instance = (SlideInData)(object)array;
			}
			nint num7 = (nint)typeof(SlideInData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v16 (Il2CppClass<UI.SlideIns.SlideInData>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(SlideInData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v23 (Il2CppClass<UI.SlideIns.SlideInData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (ScrollListSelectPopup)(object)SlideInData._instance;
		}
	}

	public override void Init()
	{
		((UISlideInAdsRemoved)(object)this)._002Ector();
	}

	public List<string> getSelected()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._items = null;
		object obj = list + 16;
		obj = this;
		return list;
	}

	public override void Show()
	{
		//IL_002b: Expected I4, but got Obj
		//IL_002b: Expected I4, but got Obj
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		ShowIfInactive();
		_instance = this;
		if (_contentList != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AbstractAdProvider.EventListenerInvoker eventListenerInvoker = default;
			eventListenerInvoker.CachedAd((AdType)_contentList, (string)(object)ScrollListTogglePrefab, (string)(object)ScrollListSpacePrefab, (byte)(int)this != 0);
			object obj = this + 60;
			obj = eventListenerInvoker;
		}
		OnClickContainer(null);
	}

	public void Initialize(Dictionary<string, string> items, Action<Dictionary<string, string>> callback, List<string> selectedItems = null, bool multiSelect = false)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_006a: Expected I4, but got Obj
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.FRIEND;
		object obj = leaderboardGameoverCell + 12;
		obj = items;
		object obj2 = selectedItems & 1;
		bool useDarkColour = obj2 == null;
		leaderboardGameoverCell.useDarkColour = useDarkColour;
		leaderboardGameoverCell.rank = (int)callback;
		leaderboardGameoverCell.lockList = multiSelect;
		((List<LeaderboardGameoverCell>)(object)screenName).Add(leaderboardGameoverCell);
		object obj3 = callback + 1;
		Action<Dictionary<string, string>> action = (Action<Dictionary<string, string>>)obj3;
		object obj4 = selectedItems + 1;
		List<string> list = (List<string>)obj4;
	}

	public override void Hide()
	{
		base.Hide();
		this._002Ector();
	}

	private void SendCallBack()
	{
		base.LoseFocus();
		InsertSpace();
		AdjustPopupSize();
	}

	private void SetContentList(Dictionary<string, string> items)
	{
		//IL_00f7: Expected Obj, but got I4
		//IL_0105: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I
		//IL_0155: Expected I4, but got Obj
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I4
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v24 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("SLIDE_IN_PAYOUT_RECEIVED");
		((UILabel)(object)_adapter).fontSize = (int)text2;
		object obj2 = this - -64;
		object obj3 = items + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		((UILabel)obj2).fontSize = fontSize;
		if (items.values != null)
		{
			Dictionary<string, string>.ValueCollection values = items.values;
			bool flag = multiSelect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v22 (System.Collections.Generic.Dictionary`2<System.String, System.String>+ValueCollection<System.String, System.String>)+10]");
			((UISprite)flag).fillCenter = false;
		}
		((FitSpriteToWidget)(object)callBack).FitStretch();
		((RewardForVideoButton)(object)this.items).Init((VideoButtonPayload)null);
		((RewardForVideoButton)(object)indicators).Init((VideoButtonPayload)null);
		((UISlideInAdsRemoved)(object)this).SetupSlideIn((SlideIn)null);
	}

	private void InsertToggle(string title, string id)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_0077: Expected I4, but got Obj
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_0225: Expected Obj, but got I4
		//IL_024d: Expected I4, but got Obj
		//IL_025f: Expected Obj, but got I4
		//IL_0287: Expected I4, but got Obj
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder2 = default;
		System.Text.StringBuilderCache.Release(stringBuilder2);
		object obj = title + 1;
		bool flag = string.IsNullOrEmpty(id);
		object obj2 = 0;
		object obj3 = obj;
		while (true)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (System.Boolean)+C]");
			if ((nint)obj4 >= 0)
			{
				break;
			}
			object obj5 = (flag ? 1 : 0) + 16;
			object obj6 = obj2 << 1;
			object obj7 = obj5 + obj6;
			string stateString = ((LimitedBoardPopup)null).GetStateString((byte)(int)obj7 != 0);
			if (stateString != null)
			{
				object obj8 = obj3 + 1;
				obj3 = obj8;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				StringBuilder stringBuilder3 = stringBuilder.AppendLine((string)(object)indicators);
				StringBuilder stringBuilder4 = stringBuilder2.AppendLine((string)(object)callBack);
			}
			else
			{
				StringBuilder stringBuilder5 = stringBuilder.AppendLine((string)multiSelect);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.ScrollListSelectPopup.ScrollListSelectPopup)+54]");
				StringBuilder stringBuilder6 = stringBuilder2.AppendLine((string)0);
			}
			object obj9 = (flag ? 1 : 0) + 16;
			object obj10 = obj2 << 1;
			object obj11 = obj9 + obj10;
			StringBuilder stringBuilder7 = stringBuilder.Append((int)obj11);
			object obj12 = (flag ? 1 : 0) + 16;
			object obj13 = obj2 << 1;
			object obj14 = obj12 + obj13;
			StringBuilder stringBuilder8 = stringBuilder2.Append((int)obj14);
			object obj15 = obj2 + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (System.Boolean)+C]");
			if ((nint)obj15 < 0)
			{
				StringBuilder stringBuilder9 = stringBuilder.AppendLine(" ");
				StringBuilder stringBuilder10 = stringBuilder2.AppendLine(" ");
			}
			object obj16 = obj2 + 1;
			obj2 = obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (System.Boolean)+C]");
		if ((nint)0 > (nint)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			int fontSize = default;
			((UILabel)(object)_adapter).fontSize = fontSize;
			object obj17 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			int fontSize2 = default;
			((UILabel)obj17).fontSize = fontSize2;
		}
	}

	private void InsertSpace()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0289: Expected Obj, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected I, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0161: Expected Obj, but got I4
		//IL_01c8: Expected Obj, but got I
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		nint num2 = (nint)(obj9 + 113696);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v92 @ S4_v8 (Il2CppMethodInfo) (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				num2 = 0;
			}
		}
		object obj12 = obj5 + 4;
		object obj13 = obj12 + 1;
		obj12 = obj13;
		object obj14 = obj13 << 2;
		object obj15 = obj5 + obj14;
		obj15 = 93;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj5 + obj16;
			if ((nint)obj17 == 93)
			{
				object obj18 = obj5 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_03e0;
			}
		}
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03e0;
		IL_03e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
	}

	private void ResetList()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ScrollListPopupCell scrollListPopupCell = default;
		scrollListPopupCell.cellType = ScrollListPopupCellType.Space;
		_contentList.Add(scrollListPopupCell);
	}

	private void OnClickContainer(GameObject go)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02e1: Expected Obj, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03fa: Expected I, but got Obj
		//IL_0410: Expected Obj, but got I
		//IL_022a: Expected I, but got Obj
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02a2: Expected I4, but got Obj
		//IL_0187: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		AdjustPopupSize();
		if ((object)go != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			object obj7 = obj5 + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj5 + obj9;
			obj10 = 77;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj5 + obj11;
				if ((nint)obj12 == 77)
				{
					object obj13 = obj5 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					goto IL_03e1;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_03e1;
		IL_03e1:
		object obj16 = this - -64;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj16).FindKernel((string)null) != 0 && _adapter != null)
		{
			object obj18 = this - -64;
			((ScrollView)obj18).CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
		}
	}

	private void SelectItem(string key)
	{
		//IL_0015: Expected Obj, but got I
		UIEventListener component = ((GameObject)(object)key).GetComponent<UIEventListener>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v7+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v8+18]");
		((AgeRestrictionPopup)this).SetAcceptButtonActive(false);
		this._002Ector();
	}

	private void AdjustPopupSize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
	}

	private void RefreshScrollList()
	{
		//IL_006c: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_000f: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I4
		Dictionary<string, string> dictionary = items;
		object obj = dictionary.count - dictionary.freeCount;
		object obj2 = obj * 34;
		UIWidget uIWidget = (UIWidget)(obj2 + 71);
		Dictionary<string, string> dictionary2 = items;
		object obj3 = dictionary2.count - dictionary2.freeCount;
		object obj4 = obj3 * 34;
		UIWidget uIWidget2 = (UIWidget)(obj4 + 58);
		if ((nint)uIWidget2 > 399)
		{
			Color color = ((UIWidget)400).color;
			Color color2 = ((UIWidget)413).color;
		}
		else
		{
			Color color3 = uIWidget2.color;
			Color color4 = uIWidget.color;
		}
	}

	public ScrollListSelectPopup()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0078: Expected VT, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006a: Expected VT, but got Obj
		if (items != null)
		{
			object obj = this - -64;
			Container lastVisibleContainerOnScreen = ((ScrollView)obj).GetLastVisibleContainerOnScreen();
			Vector3 localOffset;
			if (lastVisibleContainerOnScreen != null)
			{
				object obj2 = lastVisibleContainerOnScreen - -64;
				localOffset = (Vector3)obj2;
			}
			else
			{
				localOffset = (Vector3)0;
			}
			OnClickContainer((GameObject)(object)items);
			object obj3 = this - -64;
			((ScrollView)obj3).SmoothScrollToOffset(localOffset, (Action)null, 0f);
			RefreshScrollList();
		}
	}
}
