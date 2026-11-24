using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Kiloo.Common.UI;
using Kiloo.Plugins.Facebook;
using UI.FreeStuff;
using UI.Screens;
using UI.ScrollListSelectPopup;
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
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected Obj, but got Unknown
			//IL_0149: Expected Obj, but got I4
			//IL_0621: Expected Obj, but got I
			//IL_062a: Unknown result type (might be due to invalid IL or missing references)
			//IL_062f: Expected Obj, but got Unknown
			//IL_01d1: Expected Obj, but got I
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Expected Obj, but got Unknown
			//IL_0674: Unknown result type (might be due to invalid IL or missing references)
			//IL_0679: Expected Obj, but got Unknown
			//IL_05bc: Expected Obj, but got I
			//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ca: Expected Obj, but got Unknown
			//IL_05dd: Expected Obj, but got I4
			//IL_0195: Expected Obj, but got I
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected Obj, but got Unknown
			//IL_01b6: Expected Obj, but got I4
			//IL_03ff: Expected Obj, but got I
			//IL_028e: Expected Obj, but got I
			//IL_04cb: Expected Obj, but got I
			//IL_02ee: Expected Obj, but got I
			//IL_048f: Expected Obj, but got I
			//IL_0498: Unknown result type (might be due to invalid IL or missing references)
			//IL_049d: Expected Obj, but got Unknown
			//IL_04b0: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler+LeaderboardListAdapter)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler+LeaderboardListAdapter)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler+LeaderboardListAdapter)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj25 = default;
			object obj17 = default;
			object obj23 = default;
			for (; obj5 != obj3; obj5 = obj25 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+14]");
				GameOverLeaderboardHandler gameOverLeaderboardHandler = (GameOverLeaderboardHandler)0;
				if ((gameOverLeaderboardHandler._facebookLoginRunning ? 1 : 0) == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v19 (UI.GameOverLeaderboardHandler)+2A]");
				bool flag = (nint)0 == 6;
				object obj10 = gameOverLeaderboardHandler._adapter & 0x10;
				bool flag2 = obj10 == null;
				object obj11 = (flag2 ? 1 : 0) ^ 1;
				GameOverLeaderboardHandler gameOverLeaderboardHandler3;
				GameOverLeaderboardHandler gameOverLeaderboardHandler2;
				if (obj11 != null)
				{
					if (flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+8]");
						object obj12 = (nint)0 & (nint)0xFF;
						gameOverLeaderboardHandler2 = (GameOverLeaderboardHandler)(obj12 + 125020);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v224 @ S7_v16 (UI.GameOverLeaderboardHandler) (should have been resolved before IL gen)");
						gameOverLeaderboardHandler3 = (GameOverLeaderboardHandler)125020;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x7F;
						gameOverLeaderboardHandler3 = (GameOverLeaderboardHandler)(obj13 + 125278);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v222 @ S8_v6 (UI.GameOverLeaderboardHandler) (should have been resolved before IL gen)");
						gameOverLeaderboardHandler2 = gameOverLeaderboardHandler;
					}
					continue;
				}
				bool flag3 = (gameOverLeaderboardHandler._facebookLoginRunning ? 1 : 0) != -1;
				if (!flag)
				{
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+10]");
						bool flag4;
						if ((nint)0 != 0)
						{
							object obj14 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v94+9C]");
							object obj15 = (nint)0 & (nint)0x100;
							flag4 = obj15 != null;
						}
						else
						{
							flag4 = false;
						}
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler+LeaderboardListAdapter)+C]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v19 (UI.GameOverLeaderboardHandler)+2B]");
								object obj16 = (nint)0 & (nint)3;
								bool flag5 = (nint)obj16 == 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
								if (flag5)
								{
									if (obj17 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8941");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8942");
									}
								}
								else if (obj17 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8943");
									gameOverLeaderboardHandler2 = screenReference;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8944");
								}
								continue;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+8]");
					object obj18 = (nint)0 & (nint)0xFF;
					gameOverLeaderboardHandler2 = (GameOverLeaderboardHandler)(obj18 + 125020);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v224 @ S7_v16 (UI.GameOverLeaderboardHandler) (should have been resolved before IL gen)");
					gameOverLeaderboardHandler3 = (GameOverLeaderboardHandler)125020;
					continue;
				}
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+10]");
					bool flag6;
					if ((nint)0 != 0)
					{
						object obj19 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v66+9C]");
						object obj20 = (nint)0 & (nint)0x100;
						flag6 = obj20 != null;
					}
					else
					{
						flag6 = false;
					}
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler+LeaderboardListAdapter)+C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+10]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+8]");
								object obj21 = (nint)0 & (nint)0xFF;
								gameOverLeaderboardHandler2 = (GameOverLeaderboardHandler)(obj21 + 125020);
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v224 @ S7_v16 (UI.GameOverLeaderboardHandler) (should have been resolved before IL gen)");
								gameOverLeaderboardHandler3 = (GameOverLeaderboardHandler)125020;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v19 (UI.GameOverLeaderboardHandler)+2B]");
							object obj22 = (nint)0 & (nint)3;
							bool flag7 = (nint)obj22 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag7)
							{
								if (obj23 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8945");
									gameOverLeaderboardHandler2 = screenReference;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8946");
									gameOverLeaderboardHandler2 = screenReference;
								}
							}
							else if (obj23 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8947");
								gameOverLeaderboardHandler3 = screenReference;
								gameOverLeaderboardHandler2 = (GameOverLeaderboardHandler)(object)newSpacePrefab;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8948");
								gameOverLeaderboardHandler2 = screenReference;
							}
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v14+8]");
				object obj24 = (nint)0 & (nint)0x7F;
				gameOverLeaderboardHandler3 = (GameOverLeaderboardHandler)(obj24 + 125278);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v222 @ S8_v6 (UI.GameOverLeaderboardHandler) (should have been resolved before IL gen)");
				gameOverLeaderboardHandler2 = gameOverLeaderboardHandler;
			}
		}

		public void SetNewDataList(List<LeaderboardGameoverCell> leaderboardListT)
		{
		}

		public override int GetModelType(int index)
		{
			InvalidOperationException ex = new InvalidOperationException();
			throw new NullReferenceException();
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 8;
			obj = container;
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
			Container result = default;
			return result;
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

	private const int POSITION_OFFSET_IN_LIST = 1;

	private bool _facebookLoginRunning;

	private void Start()
	{
		CancelInvoke();
	}

	private void OnDisable()
	{
		//IL_0125: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		if (_contentList != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LeaderboardOnlineScreen.LeaderboardListAdapter leaderboardListAdapter = default;
			leaderboardListAdapter._002Ector((List<LeaderboardCell>)(object)_contentList, FriendPrefab, FacebookLoginPrefab, FriendPrefab, SpacePrefab, (Action<Transform>)(object)this);
			object obj = this + 36;
			obj = leaderboardListAdapter;
		}
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v9 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v15 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Friend friend = default;
		friend.userid = (int)num3;
		friend.games = 0;
		object obj3 = friend + 16;
		obj3 = this;
		((SocialManager)facebookDialogsSupported).Poke(friend);
	}

	public void ReloadFriends()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (~(_facebookLoginRunning ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
		_facebookLoginRunning = false;
	}

	private void ScrollToMyPosition()
	{
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I4
		//IL_01b9: Expected Obj, but got I4
		//IL_0095: Expected I, but got Obj
		//IL_0082: Expected I4, but got Obj
		ResetFriendList();
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
		if (((ComputeShader)(object)_scrollView).FindKernel((string)null) != 0 && _adapter != null)
		{
			_scrollView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
		}
		nint num3 = (nint)typeof(LeaderboardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v11 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(LeaderboardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInitialized = LeaderboardScreenManager.isInitialized;
		int currentSetIndex = ((PauseScreen)isInitialized).GetCurrentSetIndex();
		object obj3 = currentSetIndex + -1;
		if ((nint)obj3 < 3)
		{
			SetListContent();
		}
	}

	private int GetMyIndexInTheList()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = this;
		return num;
	}

	private void SetListContent()
	{
		//IL_0018: Expected VT, but got I4
		//IL_0021: Invalid comparison between VT and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		int dummyPlayerScore = GetDummyPlayerScore();
		Vector3 vector = (Vector3)(dummyPlayerScore - 1);
		if (vector > (object)(-1))
		{
			Container lastVisibleContainerOnScreen = _scrollView.GetLastVisibleContainerOnScreen();
			if (lastVisibleContainerOnScreen != null)
			{
				UIScrollView uiScrollView = _scrollView.uiScrollView;
				object obj = uiScrollView + 220;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v10+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
				float num = 0f * 0.5f;
				float num2 = lastVisibleContainerOnScreen.height * 0.5f;
				float strength = num - num2;
				_scrollView.SmoothScrollToOffset(vector, (Action)null, strength);
			}
		}
	}

	private unsafe void ResetFriendList()
	{
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		SetAgeRestrictedContent();
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
			AddSpaceToList();
			break;
		case 1:
		case 2:
		case 3:
			InsertFacebookLoginButton(ref *(int*)currentSetIndex);
			break;
		case 4:
			SetOfflineContent();
			break;
		default:
			AddSpaceToList();
			break;
		}
	}

	private void SetAgeRestrictedContent()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
	}

	private unsafe void SetOfflineContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Ref, but got Unknown
		//IL_0020: Expected Obj, but got I4
		Friend friend = default;
		ref int reference = ref *(int*)(friend + 4);
		reference = ref *(int*)null;
		friend = (Friend)1;
		InsertFriendScoreToLeaderboard(friend, ref reference, ref *(int*)null, listLocked: true);
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
				List<LeaderboardGameoverCell> contentList = _contentList;
				if (num < contentList._size)
				{
					LeaderboardGameoverCell leaderboardGameoverCell = _contentList.get_Item(num);
					if (leaderboardGameoverCell.cellType == LeaderboardGameoverCellType.PLAYER)
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

	private void AddDummy(int rank, bool below = false)
	{
		//IL_0325: Expected Obj, but got I4
		//IL_01c3: Expected I4, but got Obj
		//IL_01c3: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I4
		//IL_01d9: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_01f9: Expected I4, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_020f: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I
		//IL_022f: Expected I4, but got Obj
		//IL_022f: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I4
		//IL_0245: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I4
		//IL_014c: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I
		//IL_0265: Expected I4, but got Obj
		//IL_0265: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I4
		//IL_027b: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I
		//IL_02c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		bool flag = (nint)obj > 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		CountryManager countryManager = default;
		char c = countryManager.GetDefaultCountryCodeFromDevice()?.m_firstChar ?? '\0';
		bool flag2;
		if (c != '\0')
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v8 (System.Char)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		object obj2 = flag | flag2;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+4C]");
			((UISprite)0).fillCenter = (byte)c != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string text2 = default;
			string text = text2.ToLowerInvariant();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string text4 = default;
			string text3 = text4.ToLowerInvariant();
			if (text == text3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+4C]");
				((Component)0).tag = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+48]");
				((Component)0).tag = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+4C]");
				((Component)0).tag = (string)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+48]");
				((Component)0).tag = (string)1;
			}
		}
		if (obj != null)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+44]");
						((UISprite)0).fillCenter = (byte)(int)"icon_bronze_medal" != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+44]");
						((Component)0).tag = (string)1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+44]");
						((Component)0).tag = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+4C]");
						((Component)0).tag = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+48]");
						((Component)0).tag = null;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+44]");
					((UISprite)0).fillCenter = (byte)(int)"icon_silver_medal" != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+44]");
					((Component)0).tag = (string)1;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+44]");
				((UISprite)0).fillCenter = (byte)(int)"icon_gold_medal" != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+44]");
				((Component)0).tag = (string)1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+44]");
			((UISprite)0).fillCenter = (byte)(int)"icon_diamond_medal" != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+44]");
			((Component)0).tag = (string)1;
		}
	}

	private void SetOnlineContent(LeaderboardScreenManager.LeaderboardScreenState screenState)
	{
		((FrontHighscoreLabel)this).UpdateHighScore();
		((FrontHighscoreLabel)this)._002Ector();
	}

	private void SetOnlineContentListForLeaderboard(bool fbConnected, Friend[] friends, bool lockList)
	{
		//IL_02a6: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I4
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_036c: Expected I4, but got Obj
		//IL_02fa: Expected Obj, but got I
		//IL_0257: Expected I, but got Obj
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_034a: Expected I4, but got Obj
		//IL_02e3: Expected I4, but got Obj
		//IL_01c4: Expected I, but got Obj
		//IL_0328: Expected I4, but got Obj
		//IL_008a: Expected I, but got Obj
		//IL_0153: Expected I, but got Obj
		SpacePrefab.tag = (string)1;
		FriendPrefab.tag = null;
		FacebookLoginPrefab.tag = (string)fbConnected;
		if (friends != null)
		{
			if (lockList)
			{
				nint num = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v29 (Il2CppClass<Strings>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v36 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("FACEBOO_PROMOTION_TOPRUN_TITEL");
				((UILabel)(object)_scrollView).fontSize = (int)text;
			}
			else
			{
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23 (Il2CppClass<Strings>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag = obj2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+34]");
				if ((nint)0 != 0)
				{
					if (!flag)
					{
						nint num4 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v42 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text2 = Strings.GetDefault("FACEBOOK_BUTTON_CONNECT");
					((UILabel)(object)_scrollView).fontSize = (int)text2;
				}
				else
				{
					if (!flag)
					{
						nint num5 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v34 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text3 = Strings.GetDefault("FACEBOOK_BUTTON_RECONNECT");
					((UILabel)(object)_scrollView).fontSize = (int)text3;
				}
			}
		}
		else
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v9 (Il2CppClass<Strings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v16 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault("FACEBOOK_BUTTON_LEADERBOARD_TEXT");
			((UILabel)(object)_scrollView).fontSize = (int)text4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+2C]");
		((RewardForVideoButton)0).Init(null);
		((Collider)(object)_scrollPanel).isTrigger = true;
	}

	private unsafe void InsertPlayerScoreToLeaderboard(ref int rankCount, ref int nElements, bool isRanked, bool listLocked)
	{
		//IL_0b6d: Expected I, but got Obj
		//IL_0b83: Expected Obj, but got I
		//IL_11db: Expected Obj, but got Ref
		//IL_1201: Expected I4, but got Obj
		//IL_1201: Expected Obj, but got I
		//IL_0060: Expected Obj, but got Ref
		//IL_007e: Expected I4, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_0d00: Expected Obj, but got Ref
		//IL_0d12: Expected I, but got Obj
		//IL_0d28: Expected Obj, but got I
		//IL_0d6c: Expected I4, but got Obj
		//IL_0d6c: Expected Obj, but got I
		//IL_0d7a: Expected I, but got Obj
		//IL_0d90: Expected Obj, but got I
		//IL_02a7: Expected I, but got Obj
		//IL_0bae: Expected Obj, but got Ref
		//IL_0bc0: Expected I, but got Obj
		//IL_0bd6: Expected Obj, but got I
		//IL_02f4: Expected I, but got Obj
		//IL_0c1a: Expected I4, but got Obj
		//IL_0c1a: Expected Obj, but got I
		//IL_0c28: Expected Obj, but got Ref
		//IL_0110: Expected I, but got Obj
		//IL_0437: Expected I, but got Obj
		//IL_044d: Expected Obj, but got I
		//IL_0341: Expected I, but got Obj
		//IL_015d: Expected I, but got Obj
		//IL_0e22: Expected Obj, but got Ref
		//IL_038e: Expected I, but got Obj
		//IL_03a4: Expected Obj, but got I
		//IL_0c47: Expected I4, but got Obj
		//IL_0c47: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I
		//IL_0478: Expected I, but got Obj
		//IL_0e0f: Expected Obj, but got I
		//IL_0c9c: Expected Obj, but got I4
		//IL_0cb1: Expected Obj, but got I
		//IL_0cbf: Expected I, but got Obj
		//IL_0cd5: Expected Obj, but got I
		//IL_01da: Expected I, but got Obj
		//IL_01f0: Expected Obj, but got I
		//IL_04d4: Expected Obj, but got I
		//IL_0424: Expected I4, but got Obj
		//IL_0424: Expected Obj, but got I
		//IL_03cf: Expected I, but got Obj
		//IL_0e61: Expected Obj, but got Ref
		//IL_0e73: Expected I, but got Obj
		//IL_0e89: Expected Obj, but got I
		//IL_0c5a: Expected Obj, but got Ref
		//IL_0ec6: Expected I, but got Obj
		//IL_0edc: Expected Obj, but got I
		//IL_0509: Expected I, but got Obj
		//IL_021b: Expected I, but got Obj
		//IL_0f1a: Expected Obj, but got I
		//IL_0556: Expected I, but got Obj
		//IL_0270: Expected I4, but got Obj
		//IL_0270: Expected Obj, but got I
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected I4, but got Unknown
		//IL_0f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f57: Expected Obj, but got Unknown
		//IL_0f60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f65: Expected Obj, but got Unknown
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Expected Obj, but got Unknown
		//IL_0f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f81: Expected Obj, but got Unknown
		//IL_0f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8f: Expected Obj, but got Unknown
		//IL_05a3: Expected I, but got Obj
		//IL_05f0: Expected I, but got Obj
		//IL_0606: Expected Obj, but got I
		//IL_0fbe: Expected Obj, but got I
		//IL_077e: Expected I, but got Obj
		//IL_0794: Expected Obj, but got I
		//IL_0631: Expected I, but got Obj
		//IL_0737: Expected I4, but got Obj
		//IL_1040: Expected Obj, but got Ref
		//IL_1052: Expected I, but got Obj
		//IL_1068: Expected Obj, but got I
		//IL_0685: Expected Obj, but got I4
		//IL_0685: Expected Obj, but got I
		//IL_069a: Expected Obj, but got I4
		//IL_069a: Expected Obj, but got I
		//IL_100e: Expected Obj, but got I
		//IL_1024: Expected I4, but got Obj
		//IL_1024: Expected Obj, but got I
		//IL_10ac: Expected I4, but got Obj
		//IL_10ac: Expected Obj, but got I
		//IL_07bf: Expected I, but got Obj
		//IL_08a1: Expected Obj, but got I
		//IL_08b6: Expected Obj, but got I
		//IL_0749: Expected I4, but got Obj
		//IL_076b: Expected Obj, but got I
		//IL_080c: Expected I, but got Obj
		//IL_08c9: Expected I, but got Obj
		//IL_08df: Expected Obj, but got I
		//IL_110e: Expected Obj, but got I
		//IL_0887: Expected I4, but got Obj
		//IL_090a: Expected I, but got Obj
		//IL_10f7: Expected Obj, but got I
		//IL_0957: Expected I, but got Obj
		//IL_096d: Expected Obj, but got I
		//IL_1141: Expected Obj, but got I
		//IL_0998: Expected I, but got Obj
		//IL_09e7: Expected Obj, but got I
		//IL_09fc: Expected I4, but got Obj
		//IL_0a05: Expected VT, but got I4
		//IL_0a16: Expected I4, but got Obj
		//IL_0a38: Expected Obj, but got I
		//IL_0a4d: Expected Obj, but got I
		//IL_0a62: Expected I4, but got Obj
		//IL_0a6b: Expected VT, but got I4
		//IL_0a7c: Expected I4, but got Obj
		//IL_0a9e: Expected Obj, but got I
		//IL_0ab1: Expected I, but got Obj
		//IL_0ac7: Expected Obj, but got I
		//IL_0b51: Expected I4, but got Obj
		//IL_0b5a: Expected I4, but got Obj
		//IL_0af2: Expected I, but got Obj
		//IL_11b3: Expected Obj, but got I
		//IL_11c8: Expected Obj, but got I
		//IL_0b3a: Expected I4, but got Obj
		//IL_0b43: Expected I4, but got Obj
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v198 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel objectToClone = InAppData.inAppData.get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements));
		InAppItemModel inAppItemModel = InAppItemModel.Clone(objectToClone);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+124]");
		((UILabel)0).fontSize = (int)inAppItemModel;
		InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+10C]");
		((UISprite)0).fillCenter = (byte)(int)inAppItemModel2.icon != 0;
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v15 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		bool flag2 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref rankCount) == null;
		if (flag2)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v218 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppItemModel inAppItemModel3 = InAppData.inAppData.get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements));
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v180 (Il2CppClass<Strings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v214 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault(inAppItemModel3.displayName);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+110]");
			((UILabel)0).fontSize = (int)text;
			InAppItemModel inAppItemModel4 = InAppData.inAppData.get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements));
			if (inAppItemModel4.itemType != InAppItemModel.ItemType.Coins)
			{
				nint num7 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v196 (Il2CppClass<InApp.InAppData>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v208 (Il2CppClass<InApp.InAppData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				InAppItemModel inAppItemModel5 = InAppData.inAppData.get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements));
				if (inAppItemModel5.itemType != InAppItemModel.ItemType.DoubleCoins)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+108]");
					((UISprite)0).fillCenter = (byte)(int)"icon_background_keys" != 0;
					goto IL_0c8e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+108]");
			((UISprite)0).fillCenter = (byte)(int)"icon_background_normal" != 0;
		}
		else
		{
			if (!flag)
			{
				nint num9 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v165 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppItemModel inAppItemModel6 = InAppData.inAppData.get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements));
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v121 (Il2CppClass<Strings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num11 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v161 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault(inAppItemModel6.displayName);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+110]");
			((UILabel)0).fontSize = (int)text2;
			nint num12 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v127 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num13 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v157 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!InAppManager.IsWinterHolidaySpecialSaleActive)
			{
				nint num14 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v168 (Il2CppClass<Strings>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num15 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S1_v180 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text3 = Strings.GetDefault("DISCOUNT_BUTTON_COOL_SPACIAL_DEAL");
				bool fontSize = Strings.TryGetLocalizedOnlineSettings("discount_deal_name", out *(string*)text3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+110]");
				((UILabel)0).fontSize = (fontSize ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+108]");
				((UISprite)0).fillCenter = (byte)(int)"icon_background_theme" != 0;
			}
			else
			{
				nint num16 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v135 (Il2CppClass<InApp.InAppData>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num17 = (nint)typeof(InAppData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v147 (Il2CppClass<InApp.InAppData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				InAppItemModel inAppItemModel7 = InAppData.inAppData.get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements));
				if (inAppItemModel7.itemType == InAppItemModel.ItemType.Coins)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+108]");
					nint num18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+54]");
					((UISprite)num18).fillCenter = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+108]");
					nint num19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+58]");
					((UISprite)num19).fillCenter = false;
				}
			}
		}
		goto IL_0c8e;
		IL_0c8e:
		string text4 = (string)((flag2 ? 1 : 0) ^ 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+118]");
		((Component)0).tag = text4;
		nint num20 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v25 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num21 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v106 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel inAppItemModel8 = InAppData.inAppData.get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements));
		nint num22 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S1_v26 (Il2CppClass<Strings>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num23 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S1_v149 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text5 = Strings.GetDefault(inAppItemModel8.displayText);
		nint num24 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num25 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S1_v145 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref rankCount) == (void*)2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+11C]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			nint num26 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S1_v134 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num27 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S1_v141 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+120]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+11C]");
				((Component)0).tag = (string)flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+120]");
				((Component)0).tag = (string)flag3;
			}
		}
		object obj13 = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj13 + 72);
		object obj14 = obj13 + 48;
		object obj15 = obj13 + 24;
		object obj16 = obj13 - -64;
		object obj17 = obj13 + 16;
		object obj18 = obj13 + 40;
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref rankCount) != null)
		{
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref rankCount) != (void*)1)
			{
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref rankCount) != (void*)2)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+114]");
				((UILabel)0).fontSize = (isRanked ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+118]");
				((UILabel)0).fontSize = (listLocked ? 1 : 0);
				nint num28 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ S1_v93 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num29 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ S1_v129 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+11C]");
				if (((ComputeShader)0).FindKernel(null) == 0)
				{
					return;
				}
				nint num30 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ S1_v99 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num31 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ S1_v125 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+120]");
				if (((ComputeShader)0).FindKernel(null) == 0)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+44]");
				obj14 = 0;
				obj16 = obj14;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj16;
				Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)pivot);
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v44+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+11C]");
				((UIWidget)0).rawPivot = pivot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+48]");
				obj17 = 0;
				obj18 = obj17;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj18;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)pivot);
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+120]");
				((UIWidget)0).rawPivot = pivot;
				nint num32 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ S0_v79 (Il2CppClass<DeviceInfo>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num33 = (nint)typeof(DeviceInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ S0_v95 (Il2CppClass<DeviceInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ S0_v84 (System.Int32)+18]");
				bool fillCenter;
				bool fillCenter2;
				if ((nint)0 != 0)
				{
					fillCenter = (byte)(int)"sale_strikeover_hi" != 0;
					fillCenter2 = (byte)(int)"sale_strikeover_hi" != 0;
				}
				else
				{
					fillCenter = (byte)(int)"sale_strikeover_lo" != 0;
					fillCenter2 = (byte)(int)"sale_strikeover_lo" != 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+11C]");
				((UISprite)0).fillCenter = fillCenter2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+120]");
				((UISprite)0).fillCenter = fillCenter;
				return;
			}
			nint num34 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S1_v65 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num35 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S1_v84 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppItemModel inAppItemModel9 = InAppData.inAppData.get_Item((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements));
			nint num36 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S2_v29 (Il2CppClass<Strings>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num37 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S2_v36 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text6 = Strings.GetDefault(inAppItemModel9.displayName);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+114]");
			((UILabel)0).fontSize = (int)text6;
			bool flag4 = text5 == null || text5.m_stringLength == 0;
			int fontSize2 = ((!flag4) ? ((int)text5) : (isRanked ? 1 : 0));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+118]");
			((UILabel)0).fontSize = fontSize2;
		}
		else
		{
			bool flag5 = text5 == null || text5.m_stringLength == 0;
			int fontSize3 = ((!flag5) ? ((int)text5) : (isRanked ? 1 : 0));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+114]");
			((UILabel)0).fontSize = fontSize3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+118]");
			((UILabel)0).fontSize = (int)string.Empty;
			Color black = Color.black;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v42+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.GameOverLeaderboardHandler)+114]");
			((UIWidget)0).rawPivot = pivot;
		}
	}

	private unsafe void InsertFriendScoreToLeaderboard(Friend newFriend, ref int rankCount, ref int nElements, bool listLocked)
	{
		//IL_0045: Expected I4, but got Obj
		//IL_0058: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.PLAYER;
		leaderboardGameoverCell.rank = (int)newFriend;
		object obj = rankCount & 1;
		bool useDarkColour = obj == null;
		leaderboardGameoverCell.useDarkColour = useDarkColour;
		bool isPlayerRanked = (byte)((nuint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) & (nuint)1u) != 0;
		leaderboardGameoverCell.isPlayerRanked = isPlayerRanked;
		leaderboardGameoverCell.lockList = listLocked;
		_contentList.Add(leaderboardGameoverCell);
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) != null)
		{
			object obj2 = newFriend + 1;
			Friend friend = (Friend)obj2;
		}
		object obj3 = rankCount + 1;
		ref int reference = ref *(int*)obj3;
	}

	private unsafe void AddSpaceToList()
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Ref, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0108: Expected Obj, but got I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I4
		//IL_006c: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		Friend friend = default;
		ref int reference = ref *(int*)(friend + 4);
		reference = ref *(int*)null;
		int layer = ((CameraSettings)null).layer;
		friend = (Friend)layer;
		Camera camera = (Camera)1;
		while ((nint)camera < layer)
		{
			((CameraSettings)(object)this).ApplySettingsToCamera(camera, (CameraSettings)null);
			Camera camera2 = (Camera)(camera + 1);
			camera = camera2;
		}
		InsertFriendScoreToLeaderboard(friend, ref reference, ref *(int*)1, listLocked: false);
		Camera camera3 = (Camera)(friend - 1);
		Camera camera4 = camera3;
		while (true)
		{
			nint num = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v21 (Il2CppClass<LeaderboardDummyData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LeaderboardDummyData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v33 (Il2CppClass<LeaderboardDummyData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<LeaderboardDummyData.LeaderboardDummy> dummyData = LeaderboardDummyData.dummyData;
			object obj2 = dummyData._size + 1;
			if (System.Runtime.CompilerServices.Unsafe.As<Camera, UIntPtr>(ref camera4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				((CameraSettings)(object)this).ApplySettingsToCamera(camera4, (CameraSettings)1);
				Camera camera5 = (Camera)(camera4 + 1);
				camera4 = camera5;
				continue;
			}
			break;
		}
	}

	private unsafe void InsertFacebookLoginButton(ref int nElements)
	{
		//IL_00ed: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got Ref
		//IL_00da: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00bc: Expected I4, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Friend[] array = ((SocialManager)facebookDialogsSupported).FriendsSortedByCash();
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref nElements, 1));
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) != (void*)1)
		{
			if ((nint)obj2 == 1)
			{
				int num3 = Enumerable.Count(array);
				bool lockList = num3 < 4;
				AddFacebookButtonToList(ref *(int*)null, (byte)(int)array != 0, lockList);
				return;
			}
			if ((nint)obj2 != 2)
			{
				return;
			}
		}
		AddFacebookButtonToList(ref *(int*)1, (byte)(int)array != 0);
	}

	private unsafe void AddFacebookButtonToList(ref int nElements, bool noFriends = false, bool lockList = false)
	{
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Ref, but got Unknown
		//IL_026b: Expected Obj, but got I4
		//IL_0274: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got Ref
		//IL_0119: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_02cb: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got Ref
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		Friend friend = default;
		ref int reference = ref *(int*)(friend + 4);
		reference = ref *(int*)null;
		friend = (Friend)1;
		int num = Enumerable.Count((IEnumerable<Friend>)noFriends);
		bool flag;
		bool flag2 = default;
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) != null)
		{
			flag = false;
		}
		else
		{
			int num2 = Enumerable.Count((IEnumerable<Friend>)noFriends);
			flag2 = num2 > 3;
			int num3 = Enumerable.Count((IEnumerable<Friend>)noFriends);
			flag = num3 < 4;
		}
		if (num < 1)
		{
			InsertFriendScoreToLeaderboard(friend, ref reference, ref *(int*)1, listLocked: true);
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref nElements) == null)
			{
				((SaleNotificationHelper)this).Init((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), (string)1, (string)lockList);
			}
			return;
		}
		object obj = (noFriends ? 1 : 0) + 12;
		object obj2 = 0;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj4;
			if (obj2 != null)
			{
				obj4 = 1;
			}
			else
			{
				int bragScoreThreshold = PlayerSave.bragScoreThreshold;
				object obj5 = (noFriends ? 1 : 0) + 16;
				object obj6 = obj3 << 2;
				object obj7 = obj5 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v31+C]");
				if ((nint)bragScoreThreshold < (nint)0)
				{
					obj4 = 0;
				}
				else
				{
					InsertFriendScoreToLeaderboard(friend, ref reference, ref *(int*)1, lockList);
					if (flag2)
					{
						FacebookStatusChanged(success: false);
					}
					obj4 = 1;
				}
			}
			object obj9 = (noFriends ? 1 : 0) + 16;
			object obj10 = obj3 << 2;
			object items = obj9 + obj10;
			((UI.ScrollListSelectPopup.ScrollListSelectPopup)this).Initialize((Dictionary<string, string>)items, (Action<Dictionary<string, string>>)(object)friend, (List<string>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), lockList);
			object obj11 = obj3 + 1;
			obj2 = obj4;
			obj3 = obj11;
		}
		if (obj2 == null)
		{
			InsertFriendScoreToLeaderboard(friend, ref reference, ref *(int*)1, lockList);
			if (flag2)
			{
				FacebookStatusChanged(success: false);
			}
		}
		if (flag)
		{
			FacebookStatusChanged(success: false);
		}
		FacebookClicked();
	}

	public void FacebookClicked()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.SPACE;
		_contentList.Add(leaderboardGameoverCell);
	}

	private void FacebookStatusChanged(bool success)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardGameoverCell leaderboardGameoverCell = default;
		leaderboardGameoverCell.cellType = LeaderboardGameoverCellType.FACEBOOK_BUTTON;
		_contentList.Add(leaderboardGameoverCell);
	}

	public void OnFacebookLoginResult(bool loggedIn)
	{
		//IL_02af: Expected I, but got Obj
		//IL_02c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_020b: Expected I, but got Obj
		//IL_0221: Expected Obj, but got I
		//IL_019c: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_029c: Expected Obj, but got I4
		//IL_0125: Expected I, but got Obj
		//IL_0280: Expected Obj, but got I4
		//IL_00ba: Expected I, but got Obj
		if (loggedIn)
		{
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v22 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v45 (Il2CppClass<Data.Save.UserSave>)+74]");
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v33 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag3).QueuePopup("FBPromotionPopup");
			}
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
			((GameOverLeaderboardHandler)null)._003CStart_003Eb__10_0(flag);
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

	public GameOverLeaderboardHandler()
	{
		OnFacebookLoginResult(loggedIn: false);
	}

	private void _003CStart_003Eb__10_0(bool didLoadFriends)
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
