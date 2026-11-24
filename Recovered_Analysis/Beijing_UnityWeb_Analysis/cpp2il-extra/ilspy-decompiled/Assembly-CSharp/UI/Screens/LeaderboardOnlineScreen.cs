using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.UI;
using Kiloo.Plugins.Facebook;
using SYBO.Components.Crypt;
using UnityEngine;

namespace UI.Screens;

public class LeaderboardOnlineScreen : UIScreen
{
	private class LeaderboardListAdapter : ListAdapter<LeaderboardCell>
	{
		private GameObject _friendPrefab;

		private GameObject _playerPrefab;

		private GameObject _spacePrefab;

		private GameObject _headerPrefab;

		private Action<Transform> _adjustOverlay;

		private const int FRIEND_PREFAB = 0;

		private const int PLAYER_PREFAB = 1;

		private const int SPACE_PREFAB = 2;

		private const int HEADER_PREFAB = 3;

		public LeaderboardListAdapter(List<LeaderboardCell> contentList, GameObject newFriendPrefab, GameObject newPlayerPrefab, GameObject newSpacePrefab, GameObject headerPrefab, Action<Transform> adjustOverlay)
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
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected Obj, but got Unknown
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = this + 20;
			obj6 = newFriendPrefab;
			object obj7 = this + 24;
			obj7 = newPlayerPrefab;
			object obj8 = this + 28;
			obj8 = newSpacePrefab;
			object obj9 = this + 32;
			obj9 = headerPrefab;
			object obj10 = this + 16;
			obj10 = adjustOverlay;
		}

		public override int GetModelType(int index)
		{
			//IL_0020: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			object obj = -2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			if ((nint)0 != 2)
			{
				if ((nint)obj != 1)
				{
					if ((nint)obj == 2)
					{
						return 3;
					}
					return 0;
				}
				return 2;
			}
			return 1;
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
		{
			//IL_03b2: Expected Obj, but got I4
			//IL_03b2: Expected Obj, but got I
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected Obj, but got Unknown
			//IL_03f1: Expected Obj, but got I
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Expected Obj, but got Unknown
			//IL_0441: Expected Obj, but got I4
			//IL_00e6: Expected I4, but got Obj
			//IL_0493: Expected Obj, but got I
			//IL_0493: Expected Obj, but got I
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected Obj, but got Unknown
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected Obj, but got Unknown
			//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04be: Expected Obj, but got Unknown
			//IL_04ce: Expected Obj, but got I
			//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04dc: Expected Obj, but got Unknown
			//IL_0168: Expected Obj, but got I4
			//IL_019b: Expected I4, but got Obj
			//IL_04fe: Expected Obj, but got I
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Expected Obj, but got Unknown
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected Obj, but got Unknown
			//IL_0251: Expected Obj, but got I
			//IL_029a: Expected I4, but got Obj
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected Obj, but got Unknown
			//IL_022f: Expected I4, but got Obj
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Expected Obj, but got Unknown
			//IL_0204: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Container container2 = default;
			object obj2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
						if ((nint)0 == 2)
						{
							goto IL_0241;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
						if ((nint)0 != 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
							if ((nint)0 != 4)
							{
								goto IL_0241;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							Container container3 = default;
							container3.Measure((byte)(int)_headerPrefab != 0);
							container2 = container3;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							Container container4 = default;
							container4.Measure((byte)(int)_spacePrefab != 0);
							container2 = container4;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Container container5 = default;
						container5.Measure((byte)(int)_playerPrefab != 0);
						object obj = obj2 + 12;
						FriendHelperCrew component = container5.model.GetComponent<FriendHelperCrew>();
						obj = component;
						object obj3 = container5 + 84;
						obj3 = obj2;
						container2 = container5;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Container container6 = default;
					container6.Measure((byte)(int)_playerPrefab != 0);
					object obj4 = obj2 + 12;
					FriendHelperCrew component2 = container6.model.GetComponent<FriendHelperCrew>();
					obj4 = component2;
					object obj5 = container6 + 84;
					obj5 = obj2;
					UIDragScrollView component3 = container6.model.GetComponent<UIDragScrollView>();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+15]");
					bool flag = (nint)0 != 0;
					string tag = (string)((flag ? 1 : 0) ^ 1);
					component3.tag = tag;
					container2 = container6;
				}
			}
			goto IL_0565;
			IL_0565:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
			object obj9 = default;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
					if ((nint)0 == 2)
					{
						goto IL_04ee;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
					if ((nint)0 != 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
						if ((nint)0 != 4)
						{
							goto IL_04ee;
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+14]");
					bool backgroundActive = (nint)0 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v15+C]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+10]");
					((FriendHelperCrew)num).InitFriend((Friend)0, backgroundActive);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num2 = 0;
					_ = 0;
					object obj7 = default;
					object obj6 = obj7 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v15+C]");
					obj6 = 0;
					object obj8 = obj9 + 24;
					obj8 = obj7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+14]");
				bool flag2 = (nint)0 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+C]");
				Vector2 vector = ((WeightList)0).WeightForTransform((Transform)flag2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				_ = 0;
				object obj11 = default;
				object obj10 = obj11 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v15+C]");
				obj10 = 0;
				object obj12 = obj9 + 24;
				obj12 = obj11;
				UIDragScrollView component4 = container2.model.GetComponent<UIDragScrollView>();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+15]");
				bool flag3 = (nint)0 != 0;
				string tag2 = (string)((flag3 ? 1 : 0) ^ 1);
				component4.tag = tag2;
			}
			goto IL_052e;
			IL_04ee:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "No cell type match for: " + text;
			SDebug.LogFormat(msg, null);
			goto IL_052e;
			IL_0241:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string msg2 = "No cell type match for: " + text2;
			SDebug.LogFormat(msg2, null);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Container container7 = default;
			container7.Measure((byte)(int)_playerPrefab != 0);
			object obj14 = obj2 + 12;
			FriendHelperCrew component5 = container7.model.GetComponent<FriendHelperCrew>();
			obj14 = component5;
			object obj15 = container7 + 84;
			obj15 = obj2;
			container2 = container7;
			goto IL_0565;
			IL_052e:
			return container2;
		}
	}

	private GameObject _friendPrefab;

	private FacebookLoginPromotion _facebookContent;

	private GameObject _spacePrefab;

	private GameObject _headerPrefab;

	private UIWidget _titleAnchor;

	private UILabel _titleLabel;

	private ScrollView _scrollView;

	private UIPanel _scrollPanel;

	private UIWidget _overlaySizer;

	private GameObject _lockContent;

	private UILabel _noFriendsLabel;

	private UIWidget _topAnchor;

	private UISprite _scrollBarBackground;

	private const int GC_FRIENDS_THRESHOLD = 4;

	private List<LeaderboardCell> _contentList;

	private LeaderboardListAdapter _adapter;

	private bool _hasSetiPhoneXOffsetsIfNecessary;

	private bool _facebookLoginRunning;

	private const int POSITION_OFFSET_IN_LIST = 2;

	private readonly Color32 _facebookHeaderColor;

	private readonly Color32 _gamecenterHeaderColor;

	public override void Init()
	{
		CancelInvoke();
	}

	public override void Show()
	{
		//IL_01d1: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I4
		//IL_0090: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0159: Expected I, but got Obj
		ShowIfInactive();
		SetAgeRestrictedContent();
		if (_contentList != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
			((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector((string)(object)_contentList, (string)(object)_friendPrefab, (string)(object)_friendPrefab, (SearchOption)_spacePrefab, (System.IO.SearchResultHandler<TSource>)(object)_headerPrefab, flag);
			object obj2 = this + 96;
			obj2 = fileSystemEnumerableIterator;
		}
		nint num2 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v11 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v53 (Il2CppClass<IPhoneXSupport>)+74]");
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
		nint num4 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v26 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v47 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int absolute = IPhoneXSupport.OFFSET_BOTTOM + bottomAnchor.absolute;
		bottomAnchor.absolute = absolute;
		UIWidget topAnchor = _topAnchor;
		UIRect.AnchorPoint topAnchor2 = topAnchor.topAnchor;
		int absolute2 = topAnchor2.absolute - IPhoneXSupport.OFFSET_TOP;
		topAnchor2.absolute = absolute2;
		UIWidget topAnchor3 = _topAnchor;
		UIRect.AnchorPoint bottomAnchor2 = topAnchor3.bottomAnchor;
		int absolute3 = bottomAnchor2.absolute - IPhoneXSupport.OFFSET_TOP;
		bottomAnchor2.absolute = absolute3;
		UISprite scrollBarBackground = _scrollBarBackground;
		UIRect.AnchorPoint bottomAnchor3 = scrollBarBackground.bottomAnchor;
		int absolute4 = IPhoneXSupport.OFFSET_BOTTOM + bottomAnchor3.absolute;
		bottomAnchor3.absolute = absolute4;
		_hasSetiPhoneXOffsetsIfNecessary = true;
	}

	private unsafe void ScrollToMyPosition()
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
		((Delegate)action).method = (nint)__ldftn(LeaderboardOnlineScreen.ReloadFriends);
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
		((Delegate)action2).method = (nint)__ldftn(LeaderboardOnlineScreen.ReloadFriends);
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
		string text = Strings.GetDefault("HIGH_SCORES_TITLE");
		_titleLabel.fontSize = (int)text;
	}

	private int GetMyIndexInTheList()
	{
		//IL_002d: Invalid comparison between I4 and F4
		int height = Screen.height;
		int sleepTimeout = Screen.sleepTimeout;
		int num = height / sleepTimeout;
		return ((float)num > 0.6f) ? 1 : 0;
	}

	public override void Hide()
	{
		//IL_0018: Expected VT, but got I4
		//IL_0021: Invalid comparison between VT and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		int dummyPlayerScore = GetDummyPlayerScore();
		Vector3 vector = (Vector3)(dummyPlayerScore - 2);
		if (vector > (object)0)
		{
			object obj = this - -64;
			Container lastVisibleContainerOnScreen = ((ScrollView)obj).GetLastVisibleContainerOnScreen();
			if (lastVisibleContainerOnScreen != null)
			{
				object obj2 = this - -64;
				UIScrollView uiScrollView = ((ScrollView)obj2).uiScrollView;
				object obj3 = uiScrollView + 220;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v12+8]");
				_ = 0;
				object obj5 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
				float num = 0f * 0.5f;
				float num2 = lastVisibleContainerOnScreen.height * 0.5f;
				float strength = num - num2;
				((ScrollView)obj5).SmoothScrollToOffset(vector, (Action)null, strength);
			}
		}
	}

	private void ForceUpdateAnchors()
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

	private void ReloadFriends()
	{
		((UIRect)_titleAnchor).ParentHasChanged();
		((UIRect)_scrollPanel).ParentHasChanged();
	}

	private void ResetFriendList()
	{
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01d8: Expected I, but got Obj
		//IL_01ee: Expected Obj, but got I
		//IL_024f: Expected I, but got Obj
		//IL_0265: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I4
		//IL_02a6: Expected I, but got Obj
		//IL_02bc: Expected Obj, but got I
		//IL_02eb: Expected Obj, but got I4
		//IL_009e: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_00eb: Expected I, but got Obj
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_008b: Expected I4, but got Obj
		//IL_0148: Expected Obj, but got I4
		SetAgeRestrictedContent();
		ReloadFriends();
		object obj = this - -64;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj).FindKernel((string)null) != 0 && _adapter != null)
		{
			object obj3 = this - -64;
			((ScrollView)obj3).CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
		}
		_overlaySizer.ResetAndUpdateAnchors();
		nint num3 = (nint)typeof(LeaderboardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v15 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(LeaderboardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v49 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInitialized = LeaderboardScreenManager.isInitialized;
		int currentSetIndex = ((PauseScreen)isInitialized).GetCurrentSetIndex();
		nint num5 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v23 (Il2CppClass<SocialManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v45 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Friend[] array = ((SocialManager)facebookDialogsSupported).FriendsSortedByCash();
		int num7 = currentSetIndex | 2;
		bool flag = num7 == 3;
		if (currentSetIndex == 2)
		{
			bool flag2 = array.Length > 3;
			object obj6 = flag | flag2;
			if (obj6 == null)
			{
				return;
			}
		}
		else
		{
			bool flag3 = currentSetIndex == 0;
			object obj7 = (flag ? 1 : 0) ^ 1;
			object obj8 = flag3 | obj7;
			if (obj8 != null)
			{
				return;
			}
		}
		Hide();
	}

	private void SetListContent()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
	}

	private void SetAgeRestrictedContent()
	{
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		SetListContent();
		nint num = (nint)typeof(LeaderboardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LeaderboardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v19 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInitialized = LeaderboardScreenManager.isInitialized;
		int currentSetIndex = ((PauseScreen)isInitialized).GetCurrentSetIndex();
		switch (currentSetIndex)
		{
		case 0:
			FacebookClicked();
			break;
		case 1:
		case 2:
		case 3:
			AddSpaceToList((byte)currentSetIndex != 0);
			break;
		case 4:
			SetOfflineContent();
			break;
		default:
			FacebookClicked();
			break;
		}
	}

	private int GetDummyPlayerScore()
	{
		int result;
		if (_contentList != null)
		{
			result = -1;
			int num = default;
			int num2 = default;
			while (true)
			{
				List<LeaderboardCell> contentList = _contentList;
				if (num < contentList._size)
				{
					LeaderboardCell leaderboardCell = _contentList.get_Item(num);
					if (leaderboardCell.cellType == LeaderboardCellType.Player)
					{
						result = num;
					}
					num = num2 + 1;
					continue;
				}
				break;
			}
		}
		else
		{
			result = -1;
		}
		return result;
	}

	private unsafe void AddDummy(int rank, bool below = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		//IL_0165: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I4
		//IL_0195: Expected F4, but got Obj
		//IL_0190: Expected native int or pointer, but got VT
		//IL_01af: Expected F4, but got Obj
		//IL_01aa: Expected native int or pointer, but got VT
		//IL_01c4: Expected F4, but got I
		//IL_01bf: Expected native int or pointer, but got VT
		//IL_01d1: Expected I4, but got VT
		//IL_01d1: Expected Obj, but got I4
		//IL_01df: Expected Obj, but got I4
		//IL_01e8: Expected Obj, but got I4
		//IL_01f1: Expected Obj, but got I4
		//IL_0218: Expected F4, but got Obj
		//IL_0213: Expected native int or pointer, but got VT
		//IL_0092: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00cb: Expected F4, but got Obj
		//IL_00c6: Expected native int or pointer, but got VT
		//IL_00e5: Expected F4, but got Obj
		//IL_00e0: Expected native int or pointer, but got VT
		//IL_00fa: Expected F4, but got I
		//IL_00f5: Expected native int or pointer, but got VT
		//IL_0107: Expected I4, but got VT
		//IL_0107: Expected Obj, but got I4
		//IL_0237: Expected F4, but got Obj
		//IL_0232: Expected native int or pointer, but got VT
		//IL_024c: Expected F4, but got I
		//IL_0247: Expected native int or pointer, but got VT
		//IL_0255: Expected Obj, but got VT
		//IL_0115: Expected Obj, but got I4
		//IL_011e: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_014e: Expected F4, but got Obj
		//IL_0149: Expected native int or pointer, but got VT
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj - -64);
		object obj2 = obj + 40;
		object obj3 = obj + 24;
		object obj4 = obj + 56;
		object obj5 = obj + 16;
		object obj6 = obj + 52;
		object obj7 = obj + 48;
		object obj8 = obj + 44;
		if (below)
		{
			obj2 = 0;
			obj2 = 0;
			obj2 = 28;
			_ = 103;
			_ = -100;
			_ = -1;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)rank).rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = 0;
			obj5 = 0;
			obj5 = -1;
			_ = -1;
			_ = -1;
			_ = -1;
			obj6 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		}
		else
		{
			obj2 = 0;
			obj2 = 0;
			obj2 = -1;
			_ = -1;
			_ = -1;
			_ = -1;
			obj7 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)rank).rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = 0;
			obj5 = 0;
			obj5 = 0;
			_ = 0;
			_ = 0;
			_ = -1;
			obj8 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		}
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector2 effectDistance = ((UILabel)matrix4x).effectDistance;
	}

	private unsafe void SetOfflineContent()
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I4
		//IL_0042: Expected VT, but got I4
		//IL_0042: Expected VT, but got I4
		//IL_0042: Expected VT, but got I4
		int num = default;
		GameObject gameObject = (GameObject)(num + 4);
		gameObject = (GameObject)0;
		((int*)num)->m_value = 1;
		((PauseScreen)this).Add3DModel(num, gameObject, (Vector3)1, (Vector3)0, (Vector3)0);
		AdjustLockOverlay(null);
		FacebookStatusChanged(success: false);
	}

	private void SetOnlineContent(LeaderboardScreenManager.LeaderboardScreenState screenState)
	{
		//IL_0030: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.LeaderboardOnlineScreen)+150]");
		Delegate obj = (Delegate)0;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)screenState);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 336;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private unsafe void SetOnlineContentListForLeaderboard(bool fbConnected, Friend[] friends, bool lockList, ref bool facebookButtonActive)
	{
		//IL_005d: Expected Obj, but got Ref
		//IL_005d: Expected I4, but got Obj
		if (((UnityEngine.Object)this).m_CachedPtr == (IntPtr)0)
		{
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)1;
			showOldFooterSection = fbConnected;
			SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
			((PurchaseHandler)(object)instance).PurchaseHoverboardTheme((Boards.BoardId)friends, lockList ? 1 : 0, (BoardSelectButton)System.Runtime.CompilerServices.Unsafe.AsPointer(ref facebookButtonActive));
		}
	}

	private unsafe void InsertPlayerScoreToLeaderboard(ref int rankCount, ref int nElements, bool isRanked, bool listLocked, bool adjustOverlay)
	{
		//IL_002d: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got Ref
		//IL_009c: Expected Obj, but got I4
		int num = default;
		((int*)num)->m_value = (((bool*)(isRanked ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isRanked @ L3 (System.Boolean)+8]");
		_ = 0;
		byte[] array = (byte[])(num + 12);
		array = (byte[])((bool*)(listLocked ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [listLocked @ L4 (System.Boolean)+8]");
		_ = 0;
		int num2 = num + 24;
		((int*)num2)->m_value = (((bool*)(adjustOverlay ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [adjustOverlay @ L5 (System.Boolean)+8]");
		_ = 0;
		int num3 = ((CounterModeCryptoTransform)null).TransformBlock((byte[])System.Runtime.CompilerServices.Unsafe.AsPointer(ref rankCount), (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements), num, array, num2);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)num3);
	}

	private unsafe void InsertFriendScoreToLeaderboard(Friend newFriend, ref int rankCount, ref int nElements, bool listLocked)
	{
		//IL_0301: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I4
		//IL_0326: Expected Obj, but got Ref
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0022: Expected VT, but got I4
		//IL_0022: Expected VT, but got I4
		//IL_0022: Expected VT, but got I4
		//IL_0077: Expected I4, but got Obj
		//IL_0077: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got Ref
		//IL_021c: Expected VT, but got I4
		//IL_021c: Expected VT, but got Ref
		//IL_021c: Expected VT, but got I4
		//IL_02bf: Expected Obj, but got Ref
		//IL_01a8: Expected VT, but got I4
		//IL_01a8: Expected VT, but got Ref
		//IL_01a8: Expected VT, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I4
		//IL_02e3: Expected I4, but got Obj
		//IL_028b: Expected I4, but got Obj
		//IL_028b: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I4
		//IL_03aa: Expected VT, but got Ref
		//IL_03aa: Expected VT, but got Obj
		//IL_03aa: Expected VT, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_029b: Expected Obj, but got I4
		int num = default;
		GameObject gameObject = (GameObject)(num + 4);
		gameObject = (GameObject)0;
		((int*)num)->m_value = 1;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref rankCount, 3));
		bool flag = (nint)obj > 3;
		object obj2 = newFriend ^ 1;
		object obj3 = flag & obj2;
		bool flag2 = (nint)obj < 4;
		object obj4 = flag2 & obj2;
		if ((nint)obj < 1)
		{
			((PauseScreen)this).Add3DModel(num, gameObject, (Vector3)1, (Vector3)1, (Vector3)1);
			if (newFriend != null)
			{
				AdjustLockOverlay(null);
				FacebookStatusChanged(success: true);
				return;
			}
			((bool*)(listLocked ? 1 : 0))->m_value = true;
			((UpgradeScreen)this).MakeTableElementAlwaysVisible((GameObject)num, (int)gameObject);
			AdjustLockOverlay((Transform)1);
			FacebookStatusChanged(success: false);
			return;
		}
		if (newFriend == null)
		{
			AddFacebookHeaderToList((byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) != 0);
		}
		object obj5 = 0;
		object obj6 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref rankCount, 4));
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			GameObject medalGameObject = (GameObject)obj9;
			object obj10;
			if (obj5 != null)
			{
				obj10 = 1;
			}
			else
			{
				int bragScoreThreshold = PlayerSave.bragScoreThreshold;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v51 (UnityEngine.GameObject)+C]");
				if ((nint)bragScoreThreshold < (nint)0)
				{
					obj10 = 0;
				}
				else
				{
					((PauseScreen)this).Add3DModel(num, gameObject, (Vector3)1, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements), (Vector3)0);
					if (obj3 != null)
					{
						((bool*)(listLocked ? 1 : 0))->m_value = true;
					}
					obj10 = 1;
				}
			}
			((PauseScreen)this).MedalIconPositioning(medalGameObject, (Vector3)num, (Vector3)gameObject, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements));
			object obj11 = obj6 + 1;
			obj5 = obj10;
			obj6 = obj11;
		}
		if (obj5 == null)
		{
			((PauseScreen)this).Add3DModel(num, gameObject, (Vector3)1, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements), (Vector3)0);
			if (obj3 != null)
			{
				((bool*)(listLocked ? 1 : 0))->m_value = true;
			}
		}
		if (obj4 != null)
		{
			((bool*)(listLocked ? 1 : 0))->m_value = true;
			AddGameCenterHeaderToList((byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) != 0);
			AddGameCenterHeaderToList((byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) != 0);
			SetActiveFacebookLoginButton((byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) != 0);
			((UpgradeScreen)this).MakeTableElementAlwaysVisible((GameObject)num, (int)gameObject);
			AdjustLockOverlay((Transform)1);
		}
		else
		{
			AdjustLockOverlay(null);
		}
		AddGameCenterHeaderToList((byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) != 0);
		bool flag3 = Enumerable.Any((IEnumerable<Friend>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref rankCount));
		object obj12 = (flag3 ? 1 : 0) ^ 1;
		bool success = (byte)(obj12 & (object)newFriend) != 0;
		FacebookStatusChanged(success);
	}

	private unsafe void AddSpaceToList(bool listLocked)
	{
		//IL_0453: Expected I, but got Obj
		//IL_0469: Expected Obj, but got I
		//IL_0569: Expected Obj, but got I4
		//IL_00a5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I4
		//IL_0494: Expected I, but got Obj
		//IL_04aa: Expected Obj, but got I
		//IL_05a7: Expected Obj, but got I4
		//IL_0132: Expected I, but got Obj
		//IL_017f: Expected I, but got Obj
		//IL_0195: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I4
		//IL_01c0: Expected I, but got Obj
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0232: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_0273: Expected I, but got Obj
		//IL_060f: Expected I, but got Obj
		//IL_0625: Expected Obj, but got I
		//IL_02c0: Expected I, but got Obj
		//IL_02d6: Expected Obj, but got I
		//IL_035c: Expected I, but got Obj
		//IL_0301: Expected I, but got Obj
		//IL_03a9: Expected I, but got Obj
		//IL_03bf: Expected Obj, but got I
		//IL_03ea: Expected I, but got Obj
		bool flag = default;
		((bool*)(flag ? 1 : 0))->m_value = false;
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v64 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Friend[] array = ((SocialManager)facebookDialogsSupported).FriendsSortedByCash();
		if ((listLocked ? 1 : 0) == 2)
		{
			bool flag2 = array.Length < 4;
			((bool*)(flag ? 1 : 0))->m_value = false;
			InsertFriendScoreToLeaderboard(null, ref *(int*)array, ref *(flag2 ? ((int*)1) : ((int*)null)), flag);
		}
		else
		{
			((bool*)(flag ? 1 : 0))->m_value = false;
			object obj2 = (listLocked ? 1 : 0) - 1;
			if (listLocked || ((nint)obj2 != 1 && (nint)obj2 == 2))
			{
				InsertFriendScoreToLeaderboard((Friend)1, ref *(int*)array, ref *(int*)null, flag);
			}
		}
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v21 (Il2CppClass<SocialManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v51 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
		if (((SocialManager)facebookDialogsSupported2).HasFacebookAccessToken())
		{
			return;
		}
		nint num5 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v32 (Il2CppClass<SocialManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v47 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported3 = SocialManager.facebookDialogsSupported;
		if (!((SocialManager)facebookDialogsSupported3).gamecenterIsLoggedOut)
		{
			return;
		}
		object obj5 = this - -64;
		UIPanel component = ((Component)obj5).GetComponent<UIPanel>();
		UIRect.AnchorPoint bottomAnchor = component.bottomAnchor;
		nint num7 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v17 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v68 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num11;
		if (IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			nint num9 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v55 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v62 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num11 = IPhoneXSupport.OFFSET_BOTTOM;
		}
		else
		{
			num11 = 0;
		}
		int absolute = num11 + 110;
		bottomAnchor.absolute = absolute;
		UISprite scrollBarBackground = _scrollBarBackground;
		UIRect.AnchorPoint bottomAnchor2 = scrollBarBackground.bottomAnchor;
		nint num12 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v26 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num13 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v49 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num16;
		if (IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			nint num14 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v36 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num15 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S1_v43 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num16 = IPhoneXSupport.OFFSET_BOTTOM;
		}
		else
		{
			num16 = 0;
		}
		int absolute2 = num16 + 111;
		bottomAnchor2.absolute = absolute2;
	}

	private void AddGameCenterHeaderToList(bool lockList)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardCell leaderboardCell = default;
		leaderboardCell.cellType = LeaderboardCellType.Space;
		leaderboardCell.lockList = lockList;
		_contentList.Add(leaderboardCell);
	}

	private unsafe void AddFacebookHeaderToList(bool lockList)
	{
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got VT
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected VT, but got Unknown
		//IL_0119: Expected F4, but got Obj
		//IL_0114: Expected native int or pointer, but got VT
		//IL_0133: Expected F4, but got Obj
		//IL_012e: Expected native int or pointer, but got VT
		//IL_0148: Expected F4, but got I
		//IL_0143: Expected native int or pointer, but got VT
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardCell leaderboardCell = default;
		leaderboardCell.cellType = LeaderboardCellType.Header;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v27 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = leaderboardCell + 28;
		string text = Strings.GetDefault("LEADERBOARD_HEADER_GAMECENTER");
		obj2 = text;
		object obj4 = default;
		object obj3 = obj4 + 20;
		obj3 = _gamecenterHeaderColor;
		object obj5 = obj4 + 16;
		obj5 = obj3;
		Matrix4x4 matrix4x = (Matrix4x4)(obj4 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x3 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
		object obj6 = leaderboardCell + 32;
		obj6 = matrix4x.m00;
		_ = matrix4x.m20;
		leaderboardCell.lockList = lockList;
		_contentList.Add(leaderboardCell);
	}

	private unsafe void SetActiveFacebookLoginButton(bool active)
	{
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got VT
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected VT, but got Unknown
		//IL_0160: Expected F4, but got Obj
		//IL_015b: Expected native int or pointer, but got VT
		//IL_017a: Expected F4, but got Obj
		//IL_0175: Expected native int or pointer, but got VT
		//IL_018f: Expected F4, but got I
		//IL_018a: Expected native int or pointer, but got VT
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01aa: Expected Obj, but got F4
		//IL_0062: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardCell leaderboardCell = default;
		leaderboardCell.cellType = LeaderboardCellType.Space;
		leaderboardCell.lockList = active;
		leaderboardCell.adjustOverlay = true;
		_contentList.Add(leaderboardCell);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardCell leaderboardCell2 = default;
		leaderboardCell2.cellType = LeaderboardCellType.Header;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v13 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v33 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = leaderboardCell2 + 28;
		string text = Strings.GetDefault("LEADERBOARD_HEADER_FACEBOOK");
		obj2 = text;
		object obj4 = default;
		object obj3 = obj4 + 20;
		obj3 = _facebookHeaderColor;
		object obj5 = obj4 + 16;
		obj5 = obj3;
		Matrix4x4 matrix4x = (Matrix4x4)(obj4 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x3 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
		object obj6 = leaderboardCell2 + 32;
		obj6 = matrix4x.m00;
		_ = matrix4x.m20;
		leaderboardCell2.lockList = active;
		_contentList.Add(leaderboardCell2);
	}

	private unsafe void AddDummiesToList(ref int rankCount, ref int nElements)
	{
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardCell leaderboardCell = default;
		leaderboardCell.cellType = LeaderboardCellType.DummyFriend;
		nint num = (nint)typeof(LeaderboardDummyData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v6 (Il2CppClass<LeaderboardDummyData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v15 (Il2CppClass<LeaderboardDummyData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = leaderboardCell + 16;
		int index = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref rankCount, 1));
		LeaderboardDummyData.LeaderboardDummy leaderboardDummy = LeaderboardDummyData.dummyData.get_Item(index);
		obj2 = leaderboardDummy;
		object obj3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) & (nint)1;
		int rank = (ref *(byte*)obj3) + (ref System.Runtime.CompilerServices.Unsafe.As<int, byte>(ref rankCount));
		leaderboardCell.rank = rank;
		object obj4 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref rankCount) & (nint)1;
		bool useDarkColour = obj4 == null;
		leaderboardCell.useDarkColour = useDarkColour;
		_contentList.Add(leaderboardCell);
	}

	private void AddOverlayAndLockList(bool enable)
	{
	}

	private void AdjustLockOverlay(Transform obj)
	{
		_lockContent.tag = (string)(object)obj;
	}

	private void SetupNoFriends(bool enable)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		UIWidget overlaySizer = _overlaySizer;
		object obj = overlaySizer.topAnchor + 8;
		obj = enable;
	}

	private unsafe void FacebookClicked()
	{
		//IL_00f9: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_0048: Expected VT, but got I4
		//IL_0048: Expected VT, but got I4
		//IL_0048: Expected VT, but got I4
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I4
		//IL_0172: Invalid comparison between Ref and Obj
		//IL_0076: Expected I, but got Obj
		int num = default;
		GameObject gameObject = (GameObject)(num + 4);
		gameObject = (GameObject)0;
		LeaderboardScreenManager.LeaderboardScreenState leaderboardScreenState = (LeaderboardScreenManager.LeaderboardScreenState)(((int*)num)->m_value = (int)((LeaderboardScreenManager)null).screenState);
		for (ref int reference = ref *(int*)1; (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) < (nint)leaderboardScreenState; reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1))
		{
			AddDummiesToList(ref reference, ref *(int*)null);
		}
		((PauseScreen)this).Add3DModel(num, gameObject, (Vector3)1, (Vector3)1, (Vector3)1);
		ref int reference2 = ref *(int*)(((int*)num)->m_value - 1);
		while (true)
		{
			nint num2 = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v21 (Il2CppClass<LeaderboardDummyData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(LeaderboardDummyData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v34 (Il2CppClass<LeaderboardDummyData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<LeaderboardDummyData.LeaderboardDummy> dummyData = LeaderboardDummyData.dummyData;
			object obj2 = dummyData._size + 1;
			if (!System.Runtime.CompilerServices.Unsafe.IsAddressLessThan(ref System.Runtime.CompilerServices.Unsafe.As<int, byte>(ref reference2), ref *(byte*)obj2))
			{
				break;
			}
			AddDummiesToList(ref reference2, ref *(int*)1);
			reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 1);
		}
		FacebookStatusChanged(success: false);
	}

	private void FacebookStatusChanged(bool success)
	{
		//IL_00d5: Expected Obj, but got I4
		//IL_001c: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_005d: Expected I, but got Obj
		//IL_0132: Expected I4, but got Obj
		string text = _noFriendsLabel.tag;
		((GameObject)(object)text).tag = (string)success;
		if (!success)
		{
			return;
		}
		string dataPath = Application.dataPath;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v8 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S2_v15 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string key = (((nint)dataPath != 8) ? "NO_FRIENDS_ONLY_FB" : "NO_FRIENDS_FB_AND_GC");
		string text2 = Strings.GetDefault(key);
		_noFriendsLabel.fontSize = (int)text2;
	}

	private void OnFacebookLoginResult(bool loggedIn)
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
			((LeaderboardOnlineScreen)null)._003CShow_003Eb__22_0(flag);
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

	public LeaderboardOnlineScreen()
	{
		OnFacebookLoginResult(loggedIn: false);
	}

	private void _003CShow_003Eb__22_0(bool didLoadFriends)
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
