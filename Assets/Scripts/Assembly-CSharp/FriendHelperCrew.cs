using System;
using Cpp2ILInjected;
using UnityEngine;

public class FriendHelperCrew : MonoBehaviour
{
	public GameObject collectButton;

	public GameObject progress;

	public UILabel friendName;

	public UITexture friendPicture;

	public UISprite friendBackground;

	public FriendCrewPokeHelper pokeHelper;

	public Texture2D dummyImage;

	private Friend _friend;

	private CollectCoinsDummyData.CollectCoinsDummy _dummyFriend;

	private const string PROGRESS_STRING = "{0} / {1} runs";

	private const int RUNS_TO_COLLECT = 50;

	private const int REWARD_MIN = 50;

	private const int REWARD_MAX = 350;

	private Color32 CELL_BACKGROUND_COLOR_CLEAR = (Color32)9209485722538334136L;

	private Color32 CELL_BACKGROUND_COLOR_DARK;

	private bool _isDummyFriend;

	private bool _hasAddedFriendUpdateHandler;

	private const string DUMMY_FRIEND_NAME = "Friend Bonus";

	public Texture2D dummyFriendImage;

	private readonly Vector3 COLLECT_POSITION = (Vector3)(-4490088827371257856L);

	public void InitDummyFriend(CollectCoinsDummyData.CollectCoinsDummy dummyFriend, bool backgroundActive = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_02af: Expected Obj, but got VT
		//IL_02d2: Expected Obj, but got VT
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_0303: Expected Obj, but got VT
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected VT, but got Unknown
		//IL_037b: Expected I, but got Obj
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_dummyFriend = dummyFriend;
		_isDummyFriend = true;
		Color32 color;
		if (!backgroundActive)
		{
			object obj3 = CELL_BACKGROUND_COLOR_CLEAR & 0xFF;
			float num = (float)obj3 / 255f;
			object obj4 = obj - -64;
			color = CELL_BACKGROUND_COLOR_CLEAR;
		}
		else
		{
			object obj5 = CELL_BACKGROUND_COLOR_DARK & 0xFF;
			float num2 = (float)obj5 / 255f;
			object obj4 = obj + 48;
			color = CELL_BACKGROUND_COLOR_DARK;
		}
		object obj6 = color >> 24;
		float num3 = (float)obj6 / 255f;
		object obj7 = color >> 16;
		object obj8 = obj7 & 0xFF;
		float num4 = (float)obj8 / 255f;
		object obj9 = color >> 8;
		object obj10 = obj9 & 0xFF;
		float num5 = (float)obj10 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v13+8]");
		_ = 0;
		Color color2 = (Color)(obj + 24);
		friendBackground.color = color2;
		friendName.text = dummyFriend.name;
		UITexture uITexture = friendPicture;
		nint num6 = (nint)uITexture;
		object obj11 = uITexture + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S2_v14 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		UITexture uITexture2 = friendPicture;
		Shader shader = Shader.Find("Unlit/Transparent Colored (AlphaClip)");
		nint num7 = (nint)uITexture2;
		object obj12 = uITexture2 + 232;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ S2_v19 (Il2CppClass<UITexture>)+1A4] (should have been resolved before IL gen)");
		if (~(dummyFriend.hasBeenCollected ? 1u : 0u) != 0)
		{
			progress.SetActive(value: false);
			collectButton.SetActive(value: true);
			UIButtonMessage component = collectButton.GetComponent<UIButtonMessage>();
			GameObject target = gameObject;
			component.target = target;
			Transform transform = collectButton.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHelperCrew)+48]");
			_ = 0;
			_ = COLLECT_POSITION;
			Vector3 localPosition = (Vector3)(obj + 8);
			transform.localPosition = localPosition;
		}
		else
		{
			progress.SetActive(value: true);
			collectButton.SetActive(value: false);
			FriendProgressHelper component2 = progress.GetComponent<FriendProgressHelper>();
			CollectCoinsDummyData.CollectCoinsDummy dummyFriend2 = _dummyFriend;
			_ = dummyFriend2.fakeProgress;
			object obj13 = obj + 44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			_ = 50;
			object obj14 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			object arg2 = default;
			string text = $"{arg} / {arg2} runs";
			component2.label.text = text;
			CollectCoinsDummyData.CollectCoinsDummy dummyFriend3 = _dummyFriend;
			float value = (float)dummyFriend3.fakeProgress / 50f;
			component2.slider.value = value;
		}
		pokeHelper.DeactivatePoke();
	}

	public unsafe void InitFriend(Friend friend, bool backgroundActive = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_050b: Expected Obj, but got VT
		//IL_052e: Expected Obj, but got VT
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_055f: Expected Obj, but got VT
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected VT, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0748: Expected I, but got Obj
		//IL_0772: Expected I, but got Obj
		//IL_0636: Expected Obj, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_0673: Expected Obj, but got I4
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected VT, but got Unknown
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected Obj, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got Unknown
		//IL_0398: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I4
		//IL_06f8: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		_friend = friend;
		_isDummyFriend = false;
		Color32 color;
		if (!backgroundActive)
		{
			object obj3 = CELL_BACKGROUND_COLOR_CLEAR & 0xFF;
			float num = (float)obj3 / 255f;
			object obj4 = obj - -64;
			color = CELL_BACKGROUND_COLOR_CLEAR;
		}
		else
		{
			object obj5 = CELL_BACKGROUND_COLOR_DARK & 0xFF;
			float num2 = (float)obj5 / 255f;
			object obj4 = obj + 48;
			color = CELL_BACKGROUND_COLOR_DARK;
		}
		object obj6 = color >> 24;
		float num3 = (float)obj6 / 255f;
		object obj7 = color >> 16;
		object obj8 = obj7 & 0xFF;
		float num4 = (float)obj8 / 255f;
		object obj9 = color >> 8;
		object obj10 = obj9 & 0xFF;
		float num5 = (float)obj10 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v13+8]");
		_ = 0;
		Color color2 = (Color)(obj + 24);
		friendBackground.color = color2;
		string text = _friend.name;
		friendName.text = text;
		Friend friend2 = _friend;
		object obj11;
		UnityEngine.Object obj12;
		if (friend2.fbProfile != null)
		{
			obj11 = friend2.fbProfile + 20;
		}
		else
		{
			bool flag = friend2.gcProfile == null;
			obj12 = null;
			if (flag)
			{
				goto IL_05e1;
			}
			obj11 = friend2.gcProfile + 20;
		}
		obj12 = (UnityEngine.Object)obj11;
		goto IL_05e1;
		IL_0740:
		UITexture uITexture;
		nint num6 = (nint)uITexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ S2_v17 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		UITexture uITexture2 = friendPicture;
		Shader shader = Shader.Find("Unlit/Transparent Colored (AlphaClip)");
		nint num7 = (nint)uITexture2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v185 @ S2_v21 (Il2CppClass<UITexture>)+1A4] (should have been resolved before IL gen)");
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendHelperCrew.OnFriendUpdatedHandler));
		_friend.AddUpdatedHandler(action);
		_hasAddedFriendUpdateHandler = true;
		Friend friend3 = _friend;
		Friend.Status status = friend3.status;
		bool flag2 = friend3.games < status.gamesCashedIn;
		bool flag3 = !flag2;
		int num8 = status.gamesCashedIn;
		if (!flag3)
		{
			status.gamesCashedIn = friend3.games;
			num8 = friend3.games;
		}
		object obj13 = friend3.games - num8;
		if ((nint)obj13 >= 50)
		{
			progress.SetActive(value: false);
			collectButton.SetActive(value: true);
			UIButtonMessage component = collectButton.GetComponent<UIButtonMessage>();
			GameObject target = gameObject;
			component.target = target;
			Transform transform = collectButton.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHelperCrew)+48]");
			_ = 0;
			_ = COLLECT_POSITION;
			Vector3 localPosition = (Vector3)(obj + 8);
			transform.localPosition = localPosition;
			pokeHelper.DeactivatePoke();
			return;
		}
		progress.SetActive(value: true);
		collectButton.SetActive(value: false);
		FriendProgressHelper component2 = progress.GetComponent<FriendProgressHelper>();
		Friend friend4 = _friend;
		Friend.Status status2 = friend4.status;
		bool flag4 = friend4.games < status2.gamesCashedIn;
		bool flag5 = !flag4;
		int num9 = status2.gamesCashedIn;
		if (!flag5)
		{
			status2.gamesCashedIn = friend4.games;
			num9 = friend4.games;
		}
		object obj14 = friend4.games - num9;
		if ((nint)obj14 >= 50)
		{
			obj14 = 50;
		}
		if ((nint)obj14 <= 0)
		{
			obj14 = 0;
		}
		object obj15 = obj + 44;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = 50;
		object obj16 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		string text2 = $"{arg} / {arg2} runs";
		component2.label.text = text2;
		Friend friend5 = _friend;
		Friend.Status status3 = friend5.status;
		bool flag6 = friend5.games < status3.gamesCashedIn;
		bool flag7 = !flag6;
		int num10 = status3.gamesCashedIn;
		if (!flag7)
		{
			status3.gamesCashedIn = friend5.games;
			num10 = friend5.games;
		}
		object obj17 = friend5.games - num10;
		float value = (float)obj17 / 50f;
		component2.slider.value = value;
		if (friend.shouldBePoked)
		{
			pokeHelper.ActivatePoke(friend);
			return;
		}
		Friend friend6 = _friend;
		Friend.Status status4 = friend6.status;
		if (status4.lastPokeTime == DateTime.MinValue)
		{
			SocialManager instance = SocialManager.instance;
			instance.SetPokeFirstTime(_friend);
		}
		pokeHelper.DeactivatePoke();
		return;
		IL_05e1:
		bool flag8 = obj12 != null;
		uITexture = friendPicture;
		if (flag8)
		{
			Friend friend7 = _friend;
			object obj18;
			Texture2D texture2D;
			if (friend7.fbProfile != null)
			{
				obj18 = friend7.fbProfile + 20;
			}
			else
			{
				bool flag9 = friend7.gcProfile == null;
				texture2D = null;
				if (flag9)
				{
					goto IL_0740;
				}
				obj18 = friend7.gcProfile + 20;
			}
			texture2D = (Texture2D)obj18;
		}
		else
		{
			Texture2D texture2D = dummyImage;
		}
		goto IL_0740;
	}

	public unsafe void CollectReward()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I4
		//IL_0095: Expected VT, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00bb: Expected VT, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_04d4: Expected VT, but got I4
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_0507: Expected VT, but got I4
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected I4, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected VT, but got Unknown
		//IL_054c: Expected Obj, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected I4, but got Unknown
		//IL_0414: Expected I, but got Obj
		//IL_0432: Expected VT, but got Obj
		object obj = default;
		FriendHelperCrew friendHelperCrew = (FriendHelperCrew)(obj + -64);
		friendHelperCrew.dummyFriendImage = null;
		friendHelperCrew._isDummyFriend = false;
		PlayerInfo instance = PlayerInfo.Instance;
		if (!instance._hasCollectedFromFriends)
		{
			instance._dirty = true;
			instance._hasCollectedFromFriends = true;
		}
		if (~(_isDummyFriend ? 1u : 0u) == 0)
		{
			int num = friendHelperCrew.PayoutAndReturnReward();
			friendHelperCrew.dummyFriendImage = (Texture2D)num;
			progress.SetActive(value: true);
			collectButton.SetActive(value: false);
			FriendProgressHelper component = progress.GetComponent<FriendProgressHelper>();
			friendHelperCrew.CELL_BACKGROUND_COLOR_DARK = (Color32)0;
			object obj2 = friendHelperCrew + 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			friendHelperCrew.CELL_BACKGROUND_COLOR_CLEAR = (Color32)50;
			object obj3 = friendHelperCrew + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			object arg2 = default;
			string text = $"{arg} / {arg2} runs";
			component.label.text = text;
			component.slider.value = 0f;
			UIScreenController instance2 = UIScreenController.Instance;
			Vector3 coinPouchGlobalPosition = component.GetCoinPouchGlobalPosition();
			int num2 = friendHelperCrew + 60;
			string text2 = ((int*)num2)->ToString();
			friendHelperCrew.friendPicture = (UITexture)(object)friendHelperCrew._friend;
			friendHelperCrew.progress = (GameObject)(object)friendHelperCrew.pokeHelper;
			Vector3 startPosition = (Vector3)(friendHelperCrew + 16);
			instance2.SpawnCollectText(startPosition, text2);
			PlayerInfo instance3 = PlayerInfo.Instance;
			CollectCoinsDummyData.CollectCoinsDummy dummyFriend = _dummyFriend;
			instance3._collectCoinsDummyData.DummyCollected(dummyFriend.index);
			PlayerInfo instance4 = PlayerInfo.Instance;
			instance4._dirty = true;
			instance4._dummyFriendCollected = true;
		}
		else if (_friend != null)
		{
			MissionsManager instance5 = MissionsManager.Instance;
			instance5.PlayerDidThis(MissionTarget.CollectCoinPouch);
			SocialManager instance6 = SocialManager.instance;
			Friend friend = _friend;
			Friend.Status status = friend.status;
			status.gamesCashedIn = friend.games;
			instance6._dirty = true;
			int isDummyFriend = friendHelperCrew.PayoutAndReturnReward();
			friendHelperCrew._isDummyFriend = (byte)isDummyFriend != 0;
			progress.SetActive(value: true);
			collectButton.SetActive(value: false);
			FriendProgressHelper component2 = progress.GetComponent<FriendProgressHelper>();
			Friend friend2 = _friend;
			Friend.Status status2 = friend2.status;
			bool flag = friend2.games < status2.gamesCashedIn;
			bool flag2 = !flag;
			int num3 = status2.gamesCashedIn;
			if (!flag2)
			{
				status2.gamesCashedIn = friend2.games;
				num3 = friend2.games;
			}
			Color32 cELL_BACKGROUND_COLOR_DARK = (Color32)(friend2.games - num3);
			friendHelperCrew.CELL_BACKGROUND_COLOR_DARK = cELL_BACKGROUND_COLOR_DARK;
			object obj4 = friendHelperCrew + 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			friendHelperCrew.CELL_BACKGROUND_COLOR_CLEAR = (Color32)50;
			object obj5 = friendHelperCrew + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg3 = default;
			object arg4 = default;
			string text3 = $"{arg3} / {arg4} runs";
			component2.label.text = text3;
			Friend friend3 = _friend;
			Friend.Status status3 = friend3.status;
			bool flag3 = friend3.games < status3.gamesCashedIn;
			bool flag4 = !flag3;
			int num4 = status3.gamesCashedIn;
			if (!flag4)
			{
				status3.gamesCashedIn = friend3.games;
				num4 = friend3.games;
			}
			object obj6 = friend3.games - num4;
			float value = (float)obj6 / 50f;
			component2.slider.value = value;
			UIScreenController instance7 = UIScreenController.Instance;
			Vector3 coinPouchGlobalPosition2 = component2.GetCoinPouchGlobalPosition();
			int num5 = friendHelperCrew + 56;
			string text4 = ((int*)num5)->ToString();
			((UnityEngine.Object)friendHelperCrew).m_CachedPtr = (IntPtr)friendHelperCrew._friend;
			friendHelperCrew = (FriendHelperCrew)(object)friendHelperCrew.pokeHelper;
			instance7.SpawnCollectText((Vector3)friendHelperCrew, text4);
			SocialManager instance8 = SocialManager.instance;
			bool flag5 = instance8.Save();
		}
	}

	private int PayoutAndReturnReward()
	{
		int num = UnityEngine.Random.Range(50, 350);
		PlayerInfo instance = PlayerInfo.Instance;
		int amountOfCoins = instance.amountOfCoins;
		int amountOfCoins2 = amountOfCoins + num;
		instance.amountOfCoins = amountOfCoins2;
		PlayerInfo instance2 = PlayerInfo.Instance;
		Statistics stats = instance2._stats;
		int[] values = stats._values;
		int value = num + values[9];
		stats.set_Item(Stat.CoinsFriends, value);
		return num;
	}

	public void Refresh()
	{
		OnFriendUpdatedHandler();
	}

	private void OnFriendUpdatedHandler()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_0255: Expected I, but got Obj
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		Friend friend = _friend;
		if (_friend == null)
		{
			return;
		}
		object obj;
		UnityEngine.Object obj2;
		if (friend.fbProfile != null)
		{
			obj = friend.fbProfile + 20;
		}
		else
		{
			bool flag = friend.gcProfile == null;
			obj2 = null;
			if (flag)
			{
				goto IL_01ed;
			}
			obj = friend.gcProfile + 20;
		}
		obj2 = (UnityEngine.Object)obj;
		goto IL_01ed;
		IL_01ed:
		if (!(obj2 != null))
		{
			goto IL_0214;
		}
		UITexture uITexture = friendPicture;
		Friend friend2 = _friend;
		object obj3;
		object obj4;
		if (friend2.fbProfile != null)
		{
			obj3 = friend2.fbProfile + 20;
		}
		else
		{
			bool flag2 = friend2.gcProfile == null;
			obj4 = 0;
			if (flag2)
			{
				goto IL_024d;
			}
			obj3 = friend2.gcProfile + 20;
		}
		obj4 = obj3;
		goto IL_024d;
		IL_0214:
		string text = _friend.name;
		if (text == null)
		{
			return;
		}
		string text2 = _friend.name;
		object obj5;
		if (text2 != null)
		{
			obj5 = 0;
			if (text2._stringLength != 0)
			{
				goto IL_0273;
			}
		}
		obj5 = 1;
		goto IL_0273;
		IL_0273:
		if (obj5 == null && friendName != null)
		{
			string text3 = _friend.name;
			friendName.text = text3;
		}
		return;
		IL_024d:
		nint num = (nint)uITexture;
		object obj6 = uITexture + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S2_v9 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		goto IL_0214;
	}

	private unsafe void OnDestroy()
	{
		if (~(_hasAddedFriendUpdateHandler ? 1u : 0u) == 0 && _friend != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(FriendHelperCrew.OnFriendUpdatedHandler));
			_friend.RemoveUpdatedHandler(action);
			_hasAddedFriendUpdateHandler = false;
		}
	}

	public FriendHelperCrew()
	{
		//IL_000f: Expected VT, but got I8
		//IL_001e: Expected VT, but got I8
		_ = 0;
		base._002Ector();
	}
}
