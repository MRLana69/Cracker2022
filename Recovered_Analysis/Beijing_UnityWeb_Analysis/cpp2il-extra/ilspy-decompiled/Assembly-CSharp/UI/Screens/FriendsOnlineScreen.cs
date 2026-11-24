using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.UI;
using Kiloo.Plugins.Facebook;
using SYBO.Common.Visuals;
using TopRun;
using TopRun.UI;
using UnityEngine;

namespace UI.Screens;

public class FriendsOnlineScreen : UIScreen
{
	public class CollectCoinsListAdapter : ListAdapter<CollectCoinsCell>
	{
		public FriendsOnlineScreen friendsScreen;

		public GameObject friendPrefab;

		public GameObject recommendPrefab;

		public GameObject spacePrefab;

		private const int FRIEND_PREFAB = 0;

		private const int FACEBOOK_PREFAB = 1;

		private const int RECOMMEND_PREFAB = 2;

		private const int SPACE_PREFAB = 3;

		public CollectCoinsListAdapter(List<CollectCoinsCell> contentList, GameObject newFriendPrefab, GameObject newRecommendPrefab, GameObject newSpacePrefab, FriendsOnlineScreen screenRef)
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
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected Obj, but got Unknown
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
			obj6 = newRecommendPrefab;
			object obj7 = this + 20;
			obj7 = newFriendPrefab;
			object obj8 = this + 24;
			obj8 = newSpacePrefab;
			object obj9 = this + 28;
			obj9 = screenRef;
		}

		public void SetNewDataList(List<CollectCoinsCell> collectCoinsListT)
		{
		}

		public override int GetModelType(int index)
		{
			//IL_0015: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FriendsOnlineScreen+CollectCoinsListAdapter)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+58]");
			HoverboardThemes.ThemeIdentifier themeIdentifier = ((List<HoverboardThemes.ThemeIdentifier>)0).get_Item(1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+28]");
			return ((nint)themeIdentifier == (nint)0) ? 1 : 0;
		}

		public unsafe override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Expected I4, but got Unknown
			//IL_009c: Expected I4, but got Obj
			//IL_0254: Expected I, but got Obj
			//IL_026a: Expected Obj, but got I
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected Obj, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			//IL_0399: Expected Obj, but got I4
			//IL_03a8: Expected Obj, but got F4
			//IL_03c7: Expected I4, but got Obj
			//IL_03f2: Expected I4, but got Obj
			//IL_03f2: Expected Obj, but got I
			//IL_0105: Expected I4, but got Obj
			//IL_0295: Expected I, but got Obj
			//IL_02f7: Expected I4, but got Obj
			//IL_02f7: Expected Obj, but got I
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected Obj, but got Unknown
			//IL_0132: Expected Obj, but got VT
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected Obj, but got Unknown
			//IL_016e: Expected I4, but got Obj
			//IL_0319: Expected Obj, but got I
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Expected Obj, but got Unknown
			//IL_019b: Expected Obj, but got VT
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected Obj, but got Unknown
			object obj = default;
			int num = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Container container2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+8]");
				object obj3 = default;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+8]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+8]");
						if ((nint)0 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							Container container3 = default;
							container3.Measure((byte)(int)friendsScreen != 0);
							object obj2 = obj3 + 12;
							_0021_00210 componentInChildren = (_0021_00210)container3.model.GetComponentInChildren<T>();
							obj2 = componentInChildren;
							object obj4 = container3 + 84;
							obj4 = obj3;
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
						Container container4 = default;
						container4.Measure((byte)(int)friendPrefab != 0);
						object obj5 = obj3 + 8;
						_0021_00210 componentInChildren2 = (_0021_00210)container4.model.GetComponentInChildren<T>();
						obj5 = componentInChildren2;
						object obj6 = container4 + 84;
						obj6 = obj3;
						container2 = container4;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Container container5 = default;
					container5.Measure((byte)(int)recommendPrefab != 0);
					object obj7 = obj3 + 16;
					ListTitleComponentHelper component = container5.model.GetComponent<ListTitleComponentHelper>();
					obj7 = component;
					object obj8 = container5 + 84;
					obj8 = obj3;
					container2 = container5;
				}
			}
			if (!isMeasurePass)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+8]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+8]");
						if ((nint)0 == 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v22+C]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+C]");
							((BreadCrumbHelper)num2).OnApplicationPause(false);
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v22+8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+C]");
						((BoardSelectButton)num3).UpdateSticker(Boards.BoardId.normal, (int)spacePrefab);
					}
				}
				else
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v10 (Il2CppClass<Strings>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num5 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v17 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text = Strings.GetDefault("AWARDS_TITLE");
					obj = 0;
					_ = 0;
					obj = 0f;
					_ = 74f / 255f;
					_ = 128f / 255f;
					_ = 1f;
					((int*)num)->m_value = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v22+10]");
					((MeshMorpher)0).BuildMesh((int)text, num, -150f);
				}
			}
			return container2;
		}
	}

	private GameObject friendPrefab;

	private FacebookLoginPromotion facebookContentObject;

	private GameObject recommendPrefab;

	private GameObject spacePrefab;

	private UILabel CrewHeader;

	private UIWidget titleAnchor;

	private UILabel NoFriends;

	private List<CollectCoinsCell> _contentList;

	private CollectCoinsListAdapter _adapter;

	public static GameObject fbButtonReference;

	private ScrollView _collectCoinsListView;

	private UIPanel _scrollPanel;

	private UIWidget _overlaySizer;

	private GameObject _lockContent;

	private UISprite _scrollBarBackground;

	private bool _hasSetiPhoneXOffsetsIfNecessary;

	private bool _facebookLoginRunning;

	public override void Init()
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got I4
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (!obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			return;
		}
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FirstPurchaseBonusManager._002Ecctor();
	}

	public override void Show()
	{
		//IL_01ac: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0103: Expected I, but got Obj
		//IL_0119: Expected Obj, but got I
		//IL_0144: Expected I, but got Obj
		ShowIfInactive();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
		SetOfflineContent();
		if (_contentList != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			TopRunOnlineScreen.TopRunListAdapter topRunListAdapter = default;
			topRunListAdapter._002Ector((List<TopRunCell>)(object)_contentList, friendPrefab, recommendPrefab, spacePrefab, (GameObject)(object)this);
			object obj = this + 72;
			obj = topRunListAdapter;
		}
		nint num = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v13 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v55 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice() || ~(_hasSetiPhoneXOffsetsIfNecessary ? 1u : 0u) == 0)
		{
			return;
		}
		UIPanel scrollPanel = _scrollPanel;
		UIRect.AnchorPoint bottomAnchor = scrollPanel.bottomAnchor;
		nint num3 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v28 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v49 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int absolute = IPhoneXSupport.OFFSET_BOTTOM + bottomAnchor.absolute;
		bottomAnchor.absolute = absolute;
		UIWidget uIWidget = titleAnchor;
		UIRect.AnchorPoint topAnchor = uIWidget.topAnchor;
		int absolute2 = topAnchor.absolute - IPhoneXSupport.OFFSET_TOP;
		topAnchor.absolute = absolute2;
		UIWidget uIWidget2 = titleAnchor;
		UIRect.AnchorPoint bottomAnchor2 = uIWidget2.bottomAnchor;
		int absolute3 = bottomAnchor2.absolute - IPhoneXSupport.OFFSET_TOP;
		bottomAnchor2.absolute = absolute3;
		UISprite scrollBarBackground = _scrollBarBackground;
		UIRect.AnchorPoint bottomAnchor3 = scrollBarBackground.bottomAnchor;
		int absolute4 = IPhoneXSupport.OFFSET_BOTTOM + bottomAnchor3.absolute;
		bottomAnchor3.absolute = absolute4;
		_hasSetiPhoneXOffsetsIfNecessary = true;
	}

	private unsafe void ForceUpdateAnchors()
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0252: Expected I, but got Obj
		//IL_0268: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00f6: Expected I, but got Obj
		//IL_010c: Expected Obj, but got I
		//IL_02c3: Expected I4, but got Obj
		//IL_0137: Expected I, but got Obj
		base.Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FriendsOnlineScreen.ReloadFriends);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v39 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SocialManager.friendsChangedHandler -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(FriendsOnlineScreen.ReloadFriends);
		object obj3 = action2 + 16;
		obj3 = this;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v35 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action2;
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		Friend friend = default;
		friend.userid = (int)num5;
		friend.games = 0;
		object obj5 = friend + 16;
		obj5 = this;
		((SocialManager)facebookDialogsSupported).Poke(friend);
		ResetFriendList();
		nint num6 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v31 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v38 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("COLLECT_TITLE");
		CrewHeader.fontSize = (int)text;
	}

	public override void Hide()
	{
		((UIRect)titleAnchor).ParentHasChanged();
		((UIRect)_scrollPanel).ParentHasChanged();
	}

	private void ReloadFriends()
	{
		//IL_015b: Expected Obj, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01f1: Expected I, but got Obj
		//IL_0207: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		SocialManager socialManager = default;
		((UnityEngine.Object)socialManager).m_CachedPtr = cachedPtr;
		socialManager._latestSuccesfullyConsolidatedFacebookIds = (List<string>)0;
		object obj = socialManager + 16;
		obj = this;
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v48 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		socialManager.FriendsDidChange();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action = default;
		object obj3 = action + 16;
		obj3 = this;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v44 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action;
		if (~(_facebookLoginRunning ? 1u : 0u) != 0)
		{
			return;
		}
		nint num6 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v34 (Il2CppClass<HouseKeeper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v40 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
		_facebookLoginRunning = false;
	}

	private void ResetFriendList()
	{
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0082: Expected I4, but got Obj
		SetOfflineContent();
		Hide();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_collectCoinsListView).FindKernel((string)null) != 0 && _adapter != null)
		{
			_collectCoinsListView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
		}
		_overlaySizer.ResetAndUpdateAnchors();
	}

	private void SetListContent()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
	}

	private void SetOfflineContent()
	{
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I4
		SetListContent();
		nint num = (nint)typeof(CollectCoinsScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<CollectCoinsScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CollectCoinsScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v22 (Il2CppClass<CollectCoinsScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInitialized = CollectCoinsScreenManager.isInitialized;
		bool flag = ((DebugSettingsPopup)isInitialized).IsWordyWeekendActive();
		if (flag)
		{
			object obj2 = (flag ? 1 : 0) - 1;
			if ((nint)obj2 > 2)
			{
				AddSpaceToList();
			}
			else
			{
				SetActiveFacebookLoginButton(flag);
			}
		}
		else
		{
			AddSpaceToList();
		}
	}

	private void SetupNoFriends(bool enable)
	{
		throw new InvalidOperationException();
	}

	private void SetOnlineContent(CollectCoinsScreenManager.CollectCoinsScreenState screenState)
	{
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0222: Expected I4, but got Obj
		//IL_0133: Expected I, but got Obj
		//IL_0202: Expected I4, but got Obj
		//IL_00c2: Expected I, but got Obj
		object obj = this - -64;
		string text = ((Component)obj).tag;
		((GameObject)(object)text).tag = (string)screenState;
		object obj2 = this - -64;
		if (screenState != CollectCoinsScreenManager.CollectCoinsScreenState.Offline)
		{
			float num = 1f;
		}
		else
		{
			float num = 0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		if (screenState == CollectCoinsScreenManager.CollectCoinsScreenState.Offline)
		{
			return;
		}
		string dataPath = Application.dataPath;
		bool flag = (nint)dataPath == 8;
		object obj3 = this - -64;
		nint num2 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v14 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag2 = obj4 == null;
		if (flag)
		{
			if (!flag2)
			{
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v27 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("NO_FRIENDS_FB_AND_GC");
			((UILabel)obj3).fontSize = (int)text2;
			return;
		}
		if (!flag2)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v19 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("NO_FRIENDS_ONLY_FB");
		((UILabel)obj3).fontSize = (int)text3;
	}

	private void SetActiveFacebookLoginButton(bool active)
	{
		//IL_0588: Expected Obj, but got I4
		//IL_0596: Expected I, but got Obj
		//IL_05ac: Expected Obj, but got I
		//IL_076c: Expected Obj, but got I4
		//IL_077e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_007b: Expected Obj, but got I4
		//IL_07be: Expected Obj, but got I4
		//IL_07cc: Expected I, but got Obj
		//IL_07e2: Expected Obj, but got I
		//IL_05e8: Expected Obj, but got I4
		//IL_0120: Expected I, but got Obj
		//IL_0450: Expected Obj, but got I4
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected I4, but got Unknown
		//IL_0481: Expected Obj, but got I4
		//IL_0481: Expected I4, but got Obj
		//IL_0481: Expected Obj, but got I4
		//IL_048e: Expected Obj, but got I4
		//IL_016d: Expected I, but got Obj
		//IL_0183: Expected Obj, but got I
		//IL_06c2: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_063b: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I4
		//IL_070b: Expected Obj, but got I4
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected Obj, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected I4, but got Unknown
		//IL_01ae: Expected I, but got Obj
		//IL_04e5: Expected I, but got Obj
		//IL_04fb: Expected Obj, but got I
		//IL_0217: Expected I, but got Obj
		//IL_022d: Expected Obj, but got I
		//IL_0526: Expected I, but got Obj
		//IL_0258: Expected I, but got Obj
		//IL_056f: Expected I4, but got Obj
		//IL_083f: Expected I, but got Obj
		//IL_0855: Expected Obj, but got I
		//IL_02a5: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_0341: Expected I, but got Obj
		//IL_02e6: Expected I, but got Obj
		//IL_038e: Expected I, but got Obj
		//IL_03a4: Expected Obj, but got I
		//IL_03cf: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v106 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		bool gamecenterIsLoggedIn = ((SocialManager)facebookDialogsSupported).gamecenterIsLoggedIn;
		object obj3 = (active ? 1 : 0) | 2;
		bool flag = (nint)obj3 == 3;
		bool flag3;
		bool flag4;
		bool flag5;
		if ((active ? 1 : 0) == 2)
		{
			int num3 = Enumerable.Count((IEnumerable<Friend>)gamecenterIsLoggedIn);
			bool flag2 = num3 > 2;
			object obj4 = flag | flag2;
			if (obj4 != null)
			{
				flag3 = flag2;
				goto IL_00fa;
			}
			flag4 = true;
			flag5 = false;
		}
		else
		{
			if (flag)
			{
				flag3 = false;
				goto IL_00fa;
			}
			flag4 = true;
			flag5 = false;
		}
		flag3 = flag5;
		goto IL_07b5;
		IL_00fa:
		bool flag6 = !active;
		flag4 = flag6;
		goto IL_07b5;
		IL_07b5:
		obj = 0;
		nint num4 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v25 (Il2CppClass<SocialManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v87 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
		if (!((SocialManager)facebookDialogsSupported2).HasFacebookAccessToken())
		{
			nint num6 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v69 (Il2CppClass<SocialManager>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num7 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v83 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported3 = SocialManager.facebookDialogsSupported;
			if (((SocialManager)facebookDialogsSupported3).gamecenterIsLoggedOut)
			{
				UIPanel component = _collectCoinsListView.GetComponent<UIPanel>();
				UIRect.AnchorPoint bottomAnchor = component.bottomAnchor;
				nint num8 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v38 (Il2CppClass<IPhoneXSupport>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num9 = (nint)typeof(IPhoneXSupport);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v89 (Il2CppClass<IPhoneXSupport>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num12;
				if (IPhoneXSupport.CheckIsiPhoneXDevice())
				{
					nint num10 = (nint)typeof(IPhoneXSupport);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v76 (Il2CppClass<IPhoneXSupport>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num11 = (nint)typeof(IPhoneXSupport);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S1_v83 (Il2CppClass<IPhoneXSupport>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					num12 = IPhoneXSupport.OFFSET_BOTTOM;
				}
				else
				{
					num12 = 0;
				}
				int absolute = num12 + 110;
				bottomAnchor.absolute = absolute;
				UISprite scrollBarBackground = _scrollBarBackground;
				UIRect.AnchorPoint bottomAnchor2 = scrollBarBackground.bottomAnchor;
				nint num13 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S1_v47 (Il2CppClass<IPhoneXSupport>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num14 = (nint)typeof(IPhoneXSupport);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S1_v70 (Il2CppClass<IPhoneXSupport>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num17;
				if (IPhoneXSupport.CheckIsiPhoneXDevice())
				{
					nint num15 = (nint)typeof(IPhoneXSupport);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v57 (Il2CppClass<IPhoneXSupport>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num16 = (nint)typeof(IPhoneXSupport);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S1_v64 (Il2CppClass<IPhoneXSupport>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					num17 = IPhoneXSupport.OFFSET_BOTTOM;
				}
				else
				{
					num17 = 0;
				}
				int absolute2 = num17 + 111;
				bottomAnchor2.absolute = absolute2;
			}
		}
		if (flag)
		{
			((FrontScreen)this).TournamentChanged(obj, (TournamentChangedEventArgs)1);
		}
		bool flag7 = flag3;
		object obj11 = (flag ? 1 : 0) ^ 1;
		bool flag8 = (byte)((flag7 & obj11) ? 1 : 0) != 0;
		bool flag9 = flag4;
		((GameOverScreen)this).InAppManager_OnPurchaseSuccess((string)gamecenterIsLoggedIn, (byte)(int)obj != 0, (IPurchaseValidationResult)flag9);
		object obj12 = flag | flag7;
		bool flag10 = obj12 == null;
		bool flag11 = !flag10;
		bool enable = flag8;
		if (!flag11)
		{
			((FrontScreen)this).TournamentChanged(obj, (TournamentChangedEventArgs)null);
			enable = true;
		}
		SetFBReference((UnityEngine.Object)flag9);
		if (flag)
		{
			nint num18 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v54 (Il2CppClass<SocialManager>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num19 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v61 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = SocialManager.GetSaveDataPath();
			if (saveDataPath != null)
			{
				FacebookStatusChanged((byte)(int)obj != 0);
			}
		}
		FacebookClicked();
		bool flag12 = Enumerable.Any((IEnumerable<Friend>)gamecenterIsLoggedIn);
		bool flag13 = (nint)obj == 1;
		object obj14 = (flag12 ? 1 : 0) ^ 1;
		object obj15 = flag13 & obj14;
		CollectCoinsScreenManager.CollectCoinsScreenState onlineContent = ((flag & obj15) ? CollectCoinsScreenManager.CollectCoinsScreenState.Facebook : CollectCoinsScreenManager.CollectCoinsScreenState.Offline);
		SetOnlineContent(onlineContent);
		AddOverlayAndLockList(enable);
	}

	private unsafe void AddDummiesToList(ref int nElements, bool onlyCollectible)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_002c: Expected Obj, but got Ref
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)(((bool*)(onlyCollectible ? 1 : 0))->m_value ? 1 : 0);
		_selectedFooterButton = (onlyCollectible ? 1 : 0);
		object obj = this + 16;
		obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements);
	}

	private unsafe void AddOverlayAndLockList(bool enable)
	{
		//IL_007a: Expected Obj, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		string text = facebookContentObject.tag;
		((GameObject)(object)text).tag = (string)enable;
		if (enable)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(FriendsOnlineScreen.FacebookClicked);
			object obj = action + 16;
			obj = this;
			facebookContentObject.ActivateLoginButton("FriendsUI", action);
		}
	}

	private void AddSpaceToList()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		object sender = 0;
		AddOverlayAndLockList(enable: true);
		((FrontScreen)this).TournamentChanged(sender, (TournamentChangedEventArgs)null);
		SetFBReference((UnityEngine.Object)1);
		SetOnlineContent(CollectCoinsScreenManager.CollectCoinsScreenState.Offline);
	}

	public void SetFBReference(UnityEngine.Object fbRef)
	{
		_lockContent.tag = (string)(object)fbRef;
	}

	private void AddFriendsToList(Friend[] friends, ref int nElement, bool lockList)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FriendsOnlineScreen)+90]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num = (nint)typeof(CoinScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UI.Screens.CoinScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CoinScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<UI.Screens.CoinScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinScreen._shouldRefreshScreen = true;
	}

	private void AddRecommendButtonToList(ref int nElements)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FriendsOnlineScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FriendsOnlineScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FriendsOnlineScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UI.Screens.FriendsOnlineScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		GameObject gameObject = default;
		fbButtonReference = gameObject;
		UIWidget overlaySizer = _overlaySizer;
		object obj2 = overlaySizer.topAnchor + 8;
		int layer = fbButtonReference.layer;
		obj2 = layer;
	}

	public void FacebookClicked()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CollectCoinsCell collectCoinsCell = default;
		collectCoinsCell.cellType = CollectCoinsCellType.SPACE;
		_contentList.Add(collectCoinsCell);
	}

	private unsafe void FacebookStatusChanged(bool success)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CollectCoinsCell collectCoinsCell = default;
		collectCoinsCell.cellType = CollectCoinsCellType.RECOMMEND_BUTTON;
		_contentList.Add(collectCoinsCell);
		bool value = (byte)((((bool*)(success ? 1 : 0))->m_value ? 1u : 0u) + 1u) != 0;
		((bool*)(success ? 1 : 0))->m_value = value;
	}

	public void OnFacebookLoginResult(bool loggedIn)
	{
		//IL_02b5: Expected I, but got Obj
		//IL_02cb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0211: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I
		//IL_01a2: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_02a2: Expected Obj, but got I4
		//IL_0125: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I4
		//IL_00ba: Expected I, but got Obj
		if (loggedIn)
		{
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v22 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v46 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool allAssetBundlesDownloaded = UserSave.allAssetBundlesDownloaded;
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v8 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 != null;
			if (allAssetBundlesDownloaded)
			{
				if (flag)
				{
					nint num4 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v42 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text = default;
				text.m_stringLength = 13;
				_ = 1;
				((UIScreenController)flag2)._QueueMessage(text);
			}
			else
			{
				if (flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag3).QueuePopup("FBPromotionPopup");
			}
			ResetFriendList();
		}
		else if (~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			QueueFacebookFailSlideIn(null);
		}
		nint num6 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v8 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
		_facebookLoginRunning = false;
	}

	private void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		//IL_004f: Expected Obj, but got I4
		if (onFinishCallback == null && ~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			_facebookLoginRunning = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			((FriendsOnlineScreen)null)._003CShow_003Eb__18_0(flag);
		}
	}

	private void OnFailSlideInFinish()
	{
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_01d6: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_024a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I4
		//IL_026a: Expected Obj, but got I4
		//IL_0107: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		nint num2 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v45 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7855");
		_facebookLoginRunning = true;
		nint num4 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<SocialManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v41 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = this;
		if (!SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported, obj6))
		{
			return;
		}
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v31 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v37 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueueMessage((string)1);
	}

	public FriendsOnlineScreen()
	{
		OnFacebookLoginResult(loggedIn: false);
	}

	static FriendsOnlineScreen()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<RefreshType> action = default;
		object obj = action + 16;
		obj = 0;
		AppRefreshHandler.willRefresh -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<RefreshType> action2 = default;
		object obj2 = action2 + 16;
		obj2 = 0;
		AppRefreshHandler.hasRefreshed -= action2;
	}

	private void _003CShow_003Eb__18_0(bool didLoadFriends)
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_00de: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 13;
		_ = 0;
		object obj2 = text + 24;
		obj2 = didLoadFriends;
		((UIScreenController)flag)._QueueMessage(text);
	}
}
