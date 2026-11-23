using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.UI;
using UnityEngine;

namespace UI.Screens;

public class FriendsOnlineScreen : UIScreen
{
	public class CollectCoinsListAdapter : ListAdapter<CollectCoinsCell>
	{
		public FriendsOnlineScreen friendsScreen;

		public GameObject friendPrefab;

		public GameObject facebookPrefab;

		public GameObject recommendPrefab;

		public GameObject spacePrefab;

		private const int FRIEND_PREFAB = 0;

		private const int FACEBOOK_PREFAB = 1;

		private const int RECOMMEND_PREFAB = 2;

		private const int SPACE_PREFAB = 3;

		public CollectCoinsListAdapter(List<CollectCoinsCell> contentList, GameObject newFriendPrefab, GameObject newFacebookPrefab, GameObject newRecommendPrefab, GameObject newSpacePrefab, FriendsOnlineScreen screenRef)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v4 (Il2CppClass<Il2CppRgctx<Kiloo.Common.UI.ListAdapter`1<CollectCoinsCell>>>)+4] (should have been resolved before IL gen)");
			friendPrefab = newFriendPrefab;
			facebookPrefab = newFacebookPrefab;
			recommendPrefab = newRecommendPrefab;
			spacePrefab = newSpacePrefab;
			friendsScreen = screenRef;
		}

		public void SetNewDataList(List<CollectCoinsCell> collectCoinsListT)
		{
			//IL_0029: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FriendsOnlineScreen+CollectCoinsListAdapter)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FriendsOnlineScreen+CollectCoinsListAdapter)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S0_v9+C] (should have been resolved before IL gen)");
			}
		}

		public override int GetModelType(int index)
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0030: Expected Obj, but got I
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<UI.Screens.FriendsOnlineScreen+CollectCoinsListAdapter>)+104] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+8]");
			object obj2 = -2;
			if ((nint)obj2 <= 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+8]");
				return (int)(-1);
			}
			return 0;
		}

		public unsafe override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0469: Expected I, but got Obj
			//IL_0369: Expected Obj, but got I
			//IL_0369: Expected Obj, but got I
			//IL_0389: Expected Obj, but got I
			//IL_03f7: Expected Obj, but got I
			//IL_03f7: Expected Obj, but got I
			//IL_0417: Expected Obj, but got I
			//IL_045a: Expected Obj, but got I
			object obj2 = default;
			Enum obj = (Enum)(obj2 - 16);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S2_v2 (Il2CppClass<UI.Screens.FriendsOnlineScreen+CollectCoinsListAdapter>)+104] (should have been resolved before IL gen)");
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
							if ((nint)0 != 3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
								if ((nint)0 == 4)
								{
									Container container3 = default;
									container3._002Ector(spacePrefab);
									container2 = container3;
								}
								else
								{
									_ = -1;
									obj = (Enum)(object)typeof(CollectCoinsCellType);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+8]");
									_ = 0;
									string text = obj.ToString();
									string text2 = "No cell type match for: " + text;
									Container container4 = default;
									container4._002Ector(friendPrefab);
									FriendHelperCrew component = container4.model.GetComponent<FriendHelperCrew>();
									container4.tag = tag;
									container2 = container4;
								}
							}
							else
							{
								Container container5 = default;
								container5._002Ector(recommendPrefab);
								container2 = container5;
							}
						}
						else
						{
							Container container6 = default;
							container6._002Ector(facebookPrefab);
							FriendsLoginFBButton component2 = container6.model.GetComponent<FriendsLoginFBButton>();
							container6.tag = tag;
							Transform transform = container6.model.transform;
							Transform transform2 = transform.Find("Outline");
							GameObject gameObject = transform2.gameObject;
							friendsScreen.SetFBReference(gameObject);
							container2 = container6;
						}
					}
					else
					{
						Container container7 = default;
						container7._002Ector(friendPrefab);
						FriendHelperCrew component3 = container7.model.GetComponent<FriendHelperCrew>();
						container7.tag = tag;
						container2 = container7;
					}
				}
				else
				{
					Container container8 = default;
					container8._002Ector(friendPrefab);
					FriendHelperCrew component4 = container8.model.GetComponent<FriendHelperCrew>();
					container8.tag = tag;
					UIDragScrollView component5 = container8.model.GetComponent<UIDragScrollView>();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+15]");
					bool enabled = (nint)0 == 0;
					component5.enabled = enabled;
					container2 = container8;
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
					if ((nint)0 == 2)
					{
						Action action = default;
						action._002Ector(friendsScreen, (nint)__ldftn(FriendsOnlineScreen.FacebookClicked));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v13+8]");
						((FriendsLoginFBButton)0).Init(action);
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v13+C]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+10]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+14]");
					((FriendHelperCrew)num2).InitDummyFriend((CollectCoinsDummyData.CollectCoinsDummy)num3, backgroundActive: false);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v13+C]");
					Action action2 = default;
					action2._002Ector(0, (nint)__ldftn(FriendHelperCrew.Refresh));
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v13+C]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+C]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+14]");
				((FriendHelperCrew)num4).InitFriend((Friend)num5, backgroundActive: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v13+C]");
				Action action3 = default;
				action3._002Ector(0, (nint)__ldftn(FriendHelperCrew.Refresh));
				UIDragScrollView component6 = container2.model.GetComponent<UIDragScrollView>();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v8+15]");
				bool enabled2 = (nint)0 == 0;
				component6.enabled = enabled2;
			}
			return container2;
		}
	}

	private GameObject friendPrefab;

	private GameObject facebookPrefab;

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

	private UISprite _scrollBarSprite;

	private UIPanel _scrollBarPanel;

	private UIWidget _overlaySizer;

	private GameObject _lockContent;

	private bool _facebookLoginRunning;

	public override void Init()
	{
		//IL_0046: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Screens.FriendsOnlineScreen>)+104] (should have been resolved before IL gen)");
		SetListContent();
		if (_contentList != null)
		{
			CollectCoinsListAdapter collectCoinsListAdapter = default;
			collectCoinsListAdapter._002Ector(_contentList, friendPrefab, facebookPrefab, recommendPrefab, spacePrefab, this);
			_adapter = collectCoinsListAdapter;
		}
	}

	public unsafe override void Show()
	{
		base.Show();
		SocialManager instance = SocialManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendsOnlineScreen.ReloadFriends));
		instance.AddFriendsChangedHandler(action);
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(FriendsOnlineScreen.ReloadFriends));
		UIScreenController.OnApplicationResumed += action2;
		SocialManager instance2 = SocialManager.instance;
		throw new ArgumentException();
	}

	private void ForceUpdateAnchors()
	{
		titleAnchor.ResetAndUpdateAnchors();
		_scrollPanel.ResetAndUpdateAnchors();
	}

	public unsafe override void Hide()
	{
		base.Hide();
		SocialManager instance = SocialManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendsOnlineScreen.ReloadFriends));
		instance.RemoveFriendsChangedHandler(action);
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(FriendsOnlineScreen.ReloadFriends));
		UIScreenController.OnApplicationResumed -= action2;
	}

	private void ReloadFriends()
	{
		SetListContent();
		ForceUpdateAnchors();
		if (_collectCoinsListView != null && _adapter != null)
		{
			_collectCoinsListView.SetAdapter(_adapter);
		}
		_overlaySizer.ResetAnchors();
	}

	private void ResetFriendList()
	{
		((List<T>)(object)_contentList).Clear();
	}

	private void SetListContent()
	{
		//IL_004c: Expected Obj, but got I4
		ResetFriendList();
		CollectCoinsScreenManager instance = CollectCoinsScreenManager.Instance;
		CollectCoinsScreenManager.CollectCoinsScreenState screenState = instance.screenState;
		if (screenState != CollectCoinsScreenManager.CollectCoinsScreenState.Offline)
		{
			object obj = screenState - 1;
			if ((nint)obj <= 2)
			{
				SetOnlineContent(screenState);
			}
			else
			{
				SetOfflineContent();
			}
		}
		else
		{
			SetOfflineContent();
		}
	}

	private unsafe void SetOfflineContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Ref, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		AddFacebookButtonToList(ref *(int*)(obj + 12));
		AddDummiesToList(ref *(int*)(obj + 12), onlyCollectible: false);
		AddOverlayAndLockList(enable: true);
		SetupNoFriends(enable: false);
		CrewHeader.text = "Collect";
	}

	private void SetupNoFriends(bool enable)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		GameObject gameObject = NoFriends.gameObject;
		gameObject.SetActive(enable);
		UILabel noFriends = NoFriends;
		float num = 1f;
		if (!enable)
		{
			num = 0f;
		}
		object obj = noFriends - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S2_v5+BC] (should have been resolved before IL gen)");
		if (enable)
		{
			RuntimePlatform platform = Application.platform;
			bool flag = platform == RuntimePlatform.IPhonePlayer;
			StringID key = StringID.NO_FRIENDS_FB_AND_GC;
			if (!flag)
			{
				key = StringID.NO_FRIENDS_ONLY_FB;
			}
			string text = Strings.Get(key);
			NoFriends.text = text;
		}
	}

	private unsafe void SetOnlineContent(CollectCoinsScreenManager.CollectCoinsScreenState screenState)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Ref, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Ref, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Ref, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Ref, but got Unknown
		//IL_0221: Expected Obj, but got I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected I4, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Ref, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = screenState & (CollectCoinsScreenManager.CollectCoinsScreenState)(-3);
		SocialManager instance = SocialManager.instance;
		Friend[] array = instance.FriendsSortedByCash();
		ref int nElement = ref *(int*)(obj + 12);
		bool flag3;
		bool flag4;
		if (screenState == CollectCoinsScreenManager.CollectCoinsScreenState.GameCenter)
		{
			bool flag = (nint)obj3 != 1;
			int num = Enumerable.Count(array);
			if (num > 2)
			{
				flag = false;
			}
			if (flag)
			{
				goto IL_00c5;
			}
			_ = 0;
			if (num <= 2)
			{
				bool flag2 = (nint)obj3 == 1;
				flag3 = flag2;
				flag4 = false;
			}
			else
			{
				AddFacebookButtonToList(ref *(int*)(obj + 12));
				flag3 = true;
				flag4 = false;
			}
		}
		else
		{
			bool flag5 = (nint)obj3 == 1;
			if (!flag5)
			{
				goto IL_00c5;
			}
			_ = 0;
			AddDummiesToList(ref *(int*)(obj + 12), onlyCollectible: true);
			flag3 = flag5;
			flag4 = false;
		}
		goto IL_02fb;
		IL_00c5:
		_ = 0;
		bool flag6 = (nint)obj3 == 1;
		flag3 = flag6;
		flag4 = true;
		goto IL_02fb;
		IL_02fb:
		AddFriendsToList(array, ref nElement, flag4);
		if (!flag3)
		{
			AddFacebookButtonToList(ref *(int*)(obj + 12));
			AddDummiesToList(ref *(int*)(obj + 12), onlyCollectible: false);
		}
		AddOverlayAndLockList(flag4);
		if ((nint)obj3 == 1 && SocialManager.facebookDialogsSupported)
		{
			AddRecommendButtonToList(ref *(int*)(obj + 12));
		}
		AddSpaceToList();
		bool flag7 = Enumerable.Any(array);
		object obj4 = (flag7 ? 1 : 0) ^ -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		bool flag8 = (nint)0 == 1;
		object obj5 = obj4 & flag8;
		bool flag9 = (nint)obj3 == 1;
		bool enable = (byte)((obj5 & flag9) ? 1 : 0) != 0;
		SetupNoFriends(enable);
		string text = Strings.Get(StringID.FRIENDS_SCREEN_TITLE);
		CrewHeader.text = text;
	}

	private unsafe void AddDummiesToList(ref int nElements, bool onlyCollectible)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected Obj, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_036d: Expected Obj, but got I4
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_03ce: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Dictionary<int, CollectCoinsDummyData.CollectCoinsDummy> dummyData = CollectCoinsDummyData.GetDummyData();
		if (dummyData == null)
		{
			return;
		}
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj12 = default;
		object obj13 = default;
		object obj15 = default;
		object obj16 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_04e2;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (!onlyCollectible)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
						object obj7 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v145+10]");
							if ((nint)0 != 0)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
								object obj8 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_0453;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v175+14]");
								if ((nint)0 > (nint)0)
								{
									goto IL_02aa;
								}
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
							object obj9 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v160+10]");
								if ((nint)0 != 0)
								{
									continue;
								}
								goto IL_02aa;
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
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
						object obj10 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v133+10]");
							if ((nint)0 != 0)
							{
								continue;
							}
							goto IL_02aa;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
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
			goto IL_0453;
			IL_04e2:
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C3F");
			return;
			IL_0453:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj12 != obj13;
			object obj14 = obj15;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_04e2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj14 = obj16;
			break;
			IL_02aa:
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
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
						_ = 0;
						object obj17 = nElements ^ -1;
						object obj18 = obj17 & 1;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj19 = nElements + 1;
							ref int reference = ref *(int*)obj19;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					goto IL_0453;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0453;
		}
		_ = 0;
		object obj20 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private void AddOverlayAndLockList(bool enable)
	{
		_lockContent.SetActive(enable);
	}

	private void AddSpaceToList()
	{
		CollectCoinsCell collectCoinsCell = default;
		collectCoinsCell.cellType = CollectCoinsCellType.SPACE;
		_contentList.Add(collectCoinsCell);
	}

	public void SetFBReference(UnityEngine.Object fbRef)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		GameObject gameObject = default;
		fbButtonReference = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		UIWidget overlaySizer = _overlaySizer;
		UIRect.AnchorPoint topAnchor = overlaySizer.topAnchor;
		Transform target = fbButtonReference.transform;
		topAnchor.target = target;
	}

	private unsafe void AddFacebookButtonToList(ref int nElements)
	{
		//IL_0035: Expected Obj, but got I4
		CollectCoinsCell collectCoinsCell = default;
		collectCoinsCell.cellType = CollectCoinsCellType.FACEBOOK_BUTTON;
		_contentList.Add(collectCoinsCell);
		object obj = nElements + 1;
		ref int reference = ref *(int*)obj;
	}

	private unsafe void AddFriendsToList(Friend[] friends, ref int nElement, bool lockList)
	{
		//IL_0043: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected I4, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		object obj = default;
		CollectCoinsCell collectCoinsCell = default;
		object obj6 = default;
		while (friends.Length > (nint)obj)
		{
			collectCoinsCell.cellType = CollectCoinsCellType.FRIEND;
			object obj2 = obj << 2;
			object obj3 = (object)friends + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v5+10]");
			collectCoinsCell.friend = (Friend)0;
			collectCoinsCell.disableScrolling = lockList;
			object obj4 = nElement ^ -1;
			bool useDarkColour = (byte)(obj4 & 1) != 0;
			collectCoinsCell.useDarkColour = useDarkColour;
			_contentList.Add(collectCoinsCell);
			object obj5 = nElement + 1;
			ref int reference = ref *(int*)obj5;
			obj = obj6 + 1;
		}
	}

	private unsafe void AddRecommendButtonToList(ref int nElements)
	{
		//IL_0035: Expected Obj, but got I4
		CollectCoinsCell collectCoinsCell = default;
		collectCoinsCell.cellType = CollectCoinsCellType.RECOMMEND_BUTTON;
		_contentList.Add(collectCoinsCell);
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
			ReloadFriends();
		}
		else if (~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			OnFacebookLoginResult(loggedIn: false);
		}
		HouseKeeper.SetFacebookPayoutActionToDefault();
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

	public unsafe void OnFacebookLoginResult(bool loggedIn)
	{
		if (!loggedIn && ~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			_facebookLoginRunning = false;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(FriendsOnlineScreen.OnFailSlideInFinish));
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

	public FriendsOnlineScreen()
	{
		List<CollectCoinsCell> list = default;
		list._002Ector();
		_contentList = list;
		base._002Ector();
	}

	private void _003CShow_003Eb__19_0(bool _003Cp0_003E)
	{
		ReloadFriends();
	}
}
