using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.UI;
using UI.Screens;
using UnityEngine;

namespace UI;

public class GameOverLeaderboardHandler : MonoBehaviour
{
	public class LeaderboardListAdapter : ListAdapter<LeaderboardGameoverCell>
	{
		public GameOverLeaderboardHandler leaderboardScreen;

		public GameObject friendPrefab;

		public GameObject facebookPrefab;

		public GameObject playerPrefab;

		public GameObject spacePrefab;

		private const int FRIEND_PREFAB = 0;

		private const int FACEBOOK_PREFAB = 1;

		private const int PLAYER_PREFAB = 2;

		private const int SPACE_PREFAB = 3;

		public LeaderboardListAdapter(List<LeaderboardGameoverCell> contentList, GameObject newFriendPrefab, GameObject newFacebookPrefab, GameObject newPlayerPrefab, GameObject newSpacePrefab, GameOverLeaderboardHandler screenReference)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v4 (Il2CppClass<Il2CppRgctx<Kiloo.Common.UI.ListAdapter`1<LeaderboardGameoverCell>>>)+4] (should have been resolved before IL gen)");
			friendPrefab = newFriendPrefab;
			facebookPrefab = newFacebookPrefab;
			playerPrefab = newPlayerPrefab;
			spacePrefab = newSpacePrefab;
			leaderboardScreen = screenReference;
		}

		public void SetNewDataList(List<LeaderboardGameoverCell> leaderboardListT)
		{
			//IL_0029: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler+LeaderboardListAdapter)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler+LeaderboardListAdapter)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S0_v9+C] (should have been resolved before IL gen)");
			}
		}

		public new int GetModelType(int index)
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0040: Expected Obj, but got I
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<UI.GameOverLeaderboardHandler+LeaderboardListAdapter>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+8]");
			int result = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+8]");
			object obj2 = -1;
			if ((nint)obj2 >= 3)
			{
				result = 0;
			}
			return result;
		}

		public new unsafe Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_045b: Expected I, but got Obj
			//IL_0345: Expected Obj, but got I
			//IL_0345: Expected Obj, but got I
			//IL_0365: Expected Obj, but got I
			//IL_03af: Expected Obj, but got I
			//IL_03e2: Expected Obj, but got I
			//IL_0402: Expected Obj, but got I
			object obj2 = default;
			Enum obj = (Enum)(obj2 - 16);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S2_v2 (Il2CppClass<UI.GameOverLeaderboardHandler+LeaderboardListAdapter>)+104] (should have been resolved before IL gen)");
			Container container2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
				object tag = default;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
						if ((nint)0 != 2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
							if ((nint)0 == 3)
							{
								Container container3 = default;
								container3._002Ector(spacePrefab);
								container2 = container3;
							}
							else
							{
								_ = -1;
								obj = (Enum)(object)typeof(LeaderboardGameoverCellType);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
								_ = 0;
								string text = obj.ToString();
								string text2 = "No cell type match for: " + text;
								Container container4 = default;
								container4._002Ector(friendPrefab);
								FriendHelperHighScore component = container4.model.GetComponent<FriendHelperHighScore>();
								container4.tag = tag;
								container2 = container4;
							}
						}
						else
						{
							Container container5 = default;
							container5._002Ector(playerPrefab);
							FriendHelperHighScore component2 = container5.model.GetComponent<FriendHelperHighScore>();
							container5.tag = tag;
							UIDragScrollView component3 = container5.model.GetComponent<UIDragScrollView>();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+1A]");
							bool enabled = (nint)0 == 0;
							component3.enabled = enabled;
							container2 = container5;
						}
					}
					else
					{
						Container container6 = default;
						container6._002Ector(facebookPrefab);
						FriendsLoginFBButton component4 = container6.model.GetComponent<FriendsLoginFBButton>();
						container6.tag = tag;
						container2 = container6;
					}
				}
				else
				{
					Container container7 = default;
					container7._002Ector(friendPrefab);
					FriendHelperHighScore component5 = container7.model.GetComponent<FriendHelperHighScore>();
					container7.tag = tag;
					UIDragScrollView component6 = container7.model.GetComponent<UIDragScrollView>();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+1A]");
					bool enabled2 = (nint)0 == 0;
					component6.enabled = enabled2;
					container2 = container7;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
						if ((nint)0 != 3)
						{
							_ = -1;
							obj = (Enum)(object)typeof(LeaderboardGameoverCellType);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
							_ = 0;
							string text3 = obj.ToString();
							string text4 = "No cell type match for: " + text3;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v13+C]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+14]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+18]");
						((FriendHelperHighScore)num2).InitLocalUser((int)num3, backgroundActive: false, isPlayerRanked: false);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v13+C]");
						Action action = default;
						action._002Ector(0, (nint)__ldftn(FriendHelperHighScore.Refresh));
					}
				}
				else
				{
					Action action2 = default;
					action2._002Ector(leaderboardScreen, (nint)__ldftn(GameOverLeaderboardHandler.FacebookClicked));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v13+8]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+1B]");
					((FriendsLoginFBButton)num4).Init(action2, leaderboardScreen: true, noFriends: false);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v13+C]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+C]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+14]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+19]");
				((FriendHelperHighScore)num5).InitFriend((Friend)num6, (int)num7, backgroundActive: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v13+C]");
				Action action3 = default;
				action3._002Ector(0, (nint)__ldftn(FriendHelperHighScore.Refresh));
			}
			return container2;
		}
	}

	public GameObject FriendPrefab;

	public GameObject FacebookLoginPrefab;

	public GameObject SpacePrefab;

	private ScrollView _scrollView;

	private UIPanel _scrollPanel;

	private List<LeaderboardGameoverCell> _contentList;

	private LeaderboardListAdapter _adapter;

	private const int GC_FRIENDS_THRESHOLD = 4;

	private const int OFFSET_FROM_TOP = -39;

	private const int POSITION_OFFSET_IN_LIST = 2;

	private bool _facebookLoginRunning;

	public static GameObject fbButtonReference;

	public unsafe void Init()
	{
		if (_contentList != null)
		{
			LeaderboardListAdapter leaderboardListAdapter = default;
			leaderboardListAdapter._002Ector(_contentList, FriendPrefab, FacebookLoginPrefab, FriendPrefab, SpacePrefab, this);
			_adapter = leaderboardListAdapter;
		}
		SocialManager instance = SocialManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(GameOverLeaderboardHandler.ReloadFriends));
		instance.AddFriendsChangedHandler(action);
		SocialManager instance2 = SocialManager.instance;
		throw new ArgumentException();
	}

	private unsafe void OnDisable()
	{
		SocialManager instance = SocialManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(GameOverLeaderboardHandler.ReloadFriends));
		instance.RemoveFriendsChangedHandler(action);
		if (~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			HouseKeeper.SetFacebookPayoutActionToDefault();
			_facebookLoginRunning = false;
		}
	}

	private void ReloadFriends()
	{
		//IL_008c: Expected Obj, but got I4
		SetListContent();
		ForceUpdateAnchors();
		if (_scrollView != null && _adapter != null)
		{
			_scrollView.SetAdapter(_adapter);
		}
		LeaderboardScreenManager instance = LeaderboardScreenManager.Instance;
		LeaderboardScreenManager.LeaderboardScreenState screenState = instance.screenState;
		object obj = screenState - 1;
		if ((nint)obj <= 2)
		{
			ScrollToMyPosition();
		}
	}

	private void ScrollToMyPosition()
	{
		int myIndexInTheList = GetMyIndexInTheList();
		int num = myIndexInTheList - 2;
		if (num >= 0)
		{
			UIPanel rootPanel = _scrollView.rootPanel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v8 (UIPanel)+D4]");
			float num2 = 0f * 0.5f;
			Container firstVisibleContainerOnScreen = _scrollView.GetFirstVisibleContainerOnScreen();
			float num3 = firstVisibleContainerOnScreen.height * 0.5f;
			float offset = num2 - num3;
			_scrollView.SetSelection(num, ContainerPivot.Top, offset);
		}
	}

	private int GetMyIndexInTheList()
	{
		bool flag = _contentList == null;
		List<LeaderboardGameoverCell> contentList = _contentList;
		int num = -1;
		int num2 = 0;
		int result = -1;
		if (!flag)
		{
			while (true)
			{
				bool flag2 = num2 >= contentList._size;
				result = num;
				if (flag2)
				{
					break;
				}
				LeaderboardGameoverCell leaderboardGameoverCell = _contentList.get_Item(num2);
				bool flag3 = leaderboardGameoverCell.cellType == LeaderboardGameoverCellType.PLAYER;
				int num3 = num2;
				if (!flag3)
				{
					num3 = num;
				}
				int num4 = num2 + 1;
				contentList = _contentList;
				num = num3;
				num2 = num4;
			}
		}
		return result;
	}

	private void ForceUpdateAnchors()
	{
		UIPanel scrollPanel = _scrollPanel;
		UIRect.AnchorPoint topAnchor = scrollPanel.topAnchor;
		topAnchor.relative = 0f;
		topAnchor.Set(0f, -39f);
		_scrollPanel.ResetAndUpdateAnchors();
		UIPanel scrollPanel2 = _scrollPanel;
		UIRect.AnchorPoint bottomAnchor = scrollPanel2.bottomAnchor;
		bottomAnchor.rect.ForceUpdate();
		UIPanel scrollPanel3 = _scrollPanel;
		UIRect.AnchorPoint leftAnchor = scrollPanel3.leftAnchor;
		leftAnchor.rect.ForceUpdate();
		UIPanel scrollPanel4 = _scrollPanel;
		UIRect.AnchorPoint rightAnchor = scrollPanel4.rightAnchor;
		rightAnchor.rect.ForceUpdate();
	}

	private void SetListContent()
	{
		ResetFriendList();
		LeaderboardScreenManager instance = LeaderboardScreenManager.Instance;
		LeaderboardScreenManager.LeaderboardScreenState screenState = instance.screenState;
		switch (screenState)
		{
		case LeaderboardScreenManager.LeaderboardScreenState.Offline:
			SetOfflineContent();
			break;
		case LeaderboardScreenManager.LeaderboardScreenState.Facebook:
		case LeaderboardScreenManager.LeaderboardScreenState.GameCenter:
		case LeaderboardScreenManager.LeaderboardScreenState.FacebookAndGamecenter:
			SetOnlineContent(screenState);
			break;
		case LeaderboardScreenManager.LeaderboardScreenState.AgeRestricted:
			SetAgeRestrictedContent();
			break;
		default:
			SetOfflineContent();
			break;
		}
	}

	private void ResetFriendList()
	{
		((List<T>)(object)_contentList).Clear();
	}

	private unsafe void SetAgeRestrictedContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Ref, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 1;
		InsertPlayerScoreToLeaderboard(ref *(int*)(obj + 8), ref *(int*)(obj + 12), isRanked: false, listLocked: true);
	}

	private unsafe void SetOfflineContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Ref, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Ref, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 1;
		InsertPlayerScoreToLeaderboard(ref *(int*)(obj + 8), ref *(int*)(obj + 12), isRanked: false, listLocked: true);
		AddFacebookButtonToList(ref *(int*)(obj + 12), noFriends: true, lockList: true);
	}

	private void SetOnlineContent(LeaderboardScreenManager.LeaderboardScreenState screenState)
	{
		//IL_00b8: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		SocialManager instance = SocialManager.instance;
		Friend[] array = instance.FriendsSortedByScore();
		bool flag = screenState == LeaderboardScreenManager.LeaderboardScreenState.GameCenter;
		bool flag2 = !flag;
		bool lockList = false;
		if (!flag2)
		{
			int num = Enumerable.Count(array);
			bool flag3 = num < 4;
			lockList = flag3;
		}
		object obj = screenState - 1;
		if ((nint)obj <= 2)
		{
			object obj2 = obj & 1;
			bool fbConnected = obj2 == null;
			SetOnlineContentListForLeaderboard(fbConnected, array, lockList);
		}
	}

	private unsafe void SetOnlineContentListForLeaderboard(bool fbConnected, Friend[] friends, bool lockList)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Ref, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Ref, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Ref, but got Unknown
		//IL_0081: Expected Obj, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Ref, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Ref, but got Unknown
		//IL_016a: Expected Obj, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Ref, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Ref, but got Unknown
		//IL_01b1: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Ref, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Ref, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 1;
		_ = 0;
		int num = Enumerable.Count(friends);
		bool flag = !fbConnected;
		bool flag2 = !flag;
		bool flag3 = true;
		bool flag4 = true;
		if (!flag2)
		{
			int num2 = Enumerable.Count(friends);
			bool flag5 = num2 < 4;
			int num3 = Enumerable.Count(friends);
			bool flag6 = num3 > 3;
			flag3 = flag6;
			flag4 = flag5;
		}
		if (num >= 1)
		{
			ref int reference = ref *(int*)null;
			object obj3 = 0;
			while ((nint)friends.Length > (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference))
			{
				object obj4 = 1;
				if (obj3 == null)
				{
					PlayerInfo instance = PlayerInfo.Instance;
					object obj5 = (nuint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) << 2;
					object obj6 = (object)friends + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v30+10]");
					object obj7 = 0;
					int highScore = instance._highScore;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v31+C]");
					bool flag7 = (nint)highScore < (nint)0;
					obj4 = 0;
					if (!flag7)
					{
						InsertPlayerScoreToLeaderboard(ref *(int*)(obj + 8), ref *(int*)(obj + 12), isRanked: true, lockList);
						obj4 = 1;
						if (!flag4)
						{
							InsertFacebookLoginButton(ref reference);
							obj4 = 1;
						}
					}
				}
				object obj8 = (nuint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) << 2;
				object obj9 = (object)friends + obj8;
				ref int rankCount = ref *(int*)(obj + 8);
				ref int nElements = ref *(int*)(obj + 12);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v26+10]");
				InsertFriendScoreToLeaderboard((Friend)0, ref rankCount, ref nElements, lockList);
				reference = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 1);
				obj3 = obj4;
			}
			if (obj3 == null)
			{
				InsertPlayerScoreToLeaderboard(ref *(int*)(obj + 8), ref *(int*)(obj + 12), isRanked: true, lockList);
				if (!flag4)
				{
					InsertFacebookLoginButton(ref reference);
				}
			}
			if (!flag3)
			{
				InsertFacebookLoginButton(ref reference);
			}
			AddSpaceToList();
		}
		else
		{
			InsertPlayerScoreToLeaderboard(ref *(int*)(obj + 8), ref *(int*)(obj + 12), isRanked: true, listLocked: true);
			if (!fbConnected)
			{
				AddFacebookButtonToList(ref *(int*)(obj + 12), noFriends: true, lockList);
			}
		}
	}

	private unsafe void InsertPlayerScoreToLeaderboard(ref int rankCount, ref int nElements, bool isRanked, bool listLocked)
	{
		//IL_0072: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected I4, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.PLAYER;
		leaderboardGameoverCell.rank = rankCount;
		leaderboardGameoverCell.lockList = listLocked;
		leaderboardGameoverCell.isPlayerRanked = isRanked;
		object obj = nElements ^ -1;
		bool useDarkColour = (byte)(obj & 1) != 0;
		leaderboardGameoverCell.useDarkColour = useDarkColour;
		_contentList.Add(leaderboardGameoverCell);
		if (isRanked)
		{
			object obj2 = rankCount + 1;
			ref int reference = ref *(int*)obj2;
		}
		object obj3 = nElements + 1;
		ref int reference2 = ref *(int*)obj3;
	}

	private unsafe void InsertFriendScoreToLeaderboard(Friend newFriend, ref int rankCount, ref int nElements, bool listLocked)
	{
		//IL_0033: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected I4, but got Unknown
		//IL_008f: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.friend = newFriend;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.FRIEND;
		object obj = nElements ^ -1;
		bool useDarkColour = (byte)(obj & 1) != 0;
		leaderboardGameoverCell.useDarkColour = useDarkColour;
		leaderboardGameoverCell.lockList = listLocked;
		leaderboardGameoverCell.rank = rankCount;
		_contentList.Add(leaderboardGameoverCell);
		object obj2 = rankCount + 1;
		ref int reference = ref *(int*)obj2;
		object obj3 = nElements + 1;
		ref int reference2 = ref *(int*)obj3;
	}

	private void AddSpaceToList()
	{
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.SPACE;
		_contentList.Add(leaderboardGameoverCell);
	}

	private void InsertFacebookLoginButton(ref int nElements)
	{
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.FACEBOOK_BUTTON;
		_contentList.Add(leaderboardGameoverCell);
	}

	private unsafe void AddFacebookButtonToList(ref int nElements, bool noFriends = false, bool lockList = false)
	{
		//IL_004f: Expected Obj, but got I4
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.noFriends = noFriends;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.FACEBOOK_BUTTON;
		leaderboardGameoverCell.lockList = lockList;
		_contentList.Add(leaderboardGameoverCell);
		object obj = nElements + 1;
		ref int reference = ref *(int*)obj;
	}

	public void FacebookClicked()
	{
		throw new ArgumentException();
	}

	private void FacebookStatusChanged(bool success)
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
		_facebookLoginRunning = false;
	}

	public unsafe void OnFacebookLoginResult(bool loggedIn)
	{
		if (!loggedIn && ~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			_facebookLoginRunning = false;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(GameOverLeaderboardHandler.OnFailSlideInFinish));
			QueueFacebookFailSlideIn(action);
		}
	}

	private void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		UIScreenController instance = UIScreenController.Instance;
		UIScreenController.SlideIn slideIn = default;
		slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.ConnectFailed, onFinishCallback);
		instance.QueueSlideIn(slideIn);
	}

	private void OnFailSlideInFinish()
	{
		FacebookStatusChanged(success: false);
	}

	public GameOverLeaderboardHandler()
	{
		List<LeaderboardGameoverCell> list = default;
		list._002Ector();
		_contentList = list;
		base._002Ector();
	}

	private void _003CInit_003Eb__13_0(bool _003Cp0_003E)
	{
		ReloadFriends();
	}
}
