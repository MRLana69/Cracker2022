using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class FriendsLoginFBButton : MonoBehaviour
{
	private GameObject _connectingContent;

	private GameObject _normalContentFriends;

	private GameObject _normalContentLeaderboard;

	private GameObject _overlay;

	private UILabel _leaderboardLabel1;

	private UILabel _leaderboardLabel2;

	private Collider _leaderboardCollider;

	private Collider _friendsCollider;

	private UISprite _connectingFill;

	private Action _clickedAction;

	private bool _leaderboardScreen;

	private bool _noFriends;

	public unsafe void Init(Action clickedAction, bool leaderboardScreen = false, bool noFriends = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002d: Expected Obj, but got VT
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got VT
		//IL_0089: Expected F4, but got I
		//IL_0084: Expected native int or pointer, but got VT
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got VT
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00f4: Expected F4, but got I
		//IL_00ef: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		_clickedAction = clickedAction;
		object obj2 = GlobalColors.SOCIAL_GREY >> 16;
		object obj3 = obj2 & 0xFF;
		float num = (float)obj3 / 255f;
		object obj4 = GlobalColors.SOCIAL_GREY >> 24;
		float num2 = (float)obj4 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
		((Color*)(nint)color)->b = 0f;
		object obj5 = GlobalColors.SOCIAL_GREY & 0xFF;
		float num3 = (float)obj5 / 255f;
		object obj6 = GlobalColors.SOCIAL_GREY >> 8;
		object obj7 = obj6 & 0xFF;
		float num4 = (float)obj7 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
		((Color*)(nint)color)->r = 0f;
		_connectingFill.color = color;
		_noFriends = noFriends;
		_leaderboardScreen = leaderboardScreen;
		SetToLogInState(leaderboardScreen, noFriends);
	}

	private void OnClick()
	{
		Action clickedAction = _clickedAction;
		if (_clickedAction != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		SetToConnectingState();
	}

	private void SetToLogInState(bool leaderboardScreen, bool noFriends)
	{
		//IL_00c8: Expected VT, but got I4
		//IL_0056: Expected VT, but got I4
		_overlay.SetActive(value: true);
		_connectingContent.SetActive(value: false);
		bool active = (byte)((leaderboardScreen ? 1u : 0u) ^ 1u) != 0;
		_normalContentFriends.SetActive(active);
		_normalContentLeaderboard.SetActive(leaderboardScreen);
		UIAnchor component = _leaderboardLabel1.GetComponent<UIAnchor>();
		StringID key = StringID.FACEBOOK_BUTTON_LEADERBOARD_TEXT_NO_FRIENDS;
		if (!noFriends)
		{
			key = StringID.FACEBOOK_BUTTON_LEADERBOARD_TEXT;
		}
		string text = Strings.Get(key);
		_leaderboardLabel2.text = text;
		_ = 0;
		Vector2 pixelOffset = (Vector2)1106247680;
		if (!noFriends)
		{
			pixelOffset = (Vector2)1094713344;
		}
		component.pixelOffset = pixelOffset;
		_leaderboardCollider.enabled = true;
		_friendsCollider.enabled = true;
	}

	private void SetToConnectingState()
	{
		_overlay.SetActive(value: false);
		_normalContentFriends.SetActive(value: false);
		_normalContentLeaderboard.SetActive(value: false);
		_connectingContent.SetActive(value: true);
		_leaderboardCollider.enabled = false;
		_friendsCollider.enabled = false;
	}

	private void FBStateChangedHandler()
	{
		SocialManager instance = SocialManager.instance;
		if (instance._fbState == SocialManager.FacebookState.Error)
		{
			SetToLogInState(_leaderboardScreen, _noFriends);
		}
	}

	private unsafe void OnEnable()
	{
		SocialManager instance = SocialManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendsLoginFBButton.FBStateChangedHandler));
		instance.AddFacebookStateChangedHandler(action);
	}

	private unsafe void OnDisable()
	{
		SocialManager instance = SocialManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendsLoginFBButton.FBStateChangedHandler));
		instance.RemoveFacebookStateChangedHandler(action);
	}
}
