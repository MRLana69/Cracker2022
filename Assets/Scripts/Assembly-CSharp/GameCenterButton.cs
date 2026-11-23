using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using Kiloo.Plugins.GameCenter;
using UnityEngine;

public class GameCenterButton : MonoBehaviour
{
	private sealed class _003CUserFeedback_003Ed__30(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterButton _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					GameCenterButton gameCenterButton = _003C_003E4__this;
					_003C_003E1__state = -1;
					_003C_003E4__this.SetStateGameObjectActive(gameCenterButton._couldNotConnectTryAgainGameObject);
					_003C_003E4__this.EnableTouch(enable: true);
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 2f;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private GameObject _connectingToGameObject;

	private GameObject _couldNotConnectTryAgainGameObject;

	private GameObject _couldNotConnectGameObject;

	private GameObject _loginToGcWithBonusGameObject;

	private GameObject _loginToGcNoBonusGameObject;

	private GameObject _loginToGcForAwardsGameObject;

	private UIButtonOverlayOff _btnOverlayOffDefault;

	private UIButtonOverlayOff _btnOverlayOffTryAgain;

	private UILabel _connectingTo;

	private UILabel _couldNotConnect1;

	private UILabel _couldNotConnect2;

	private UILabel _tryAgain1;

	private UILabel _tryAgain2;

	private UILabel _loginToGc1;

	private UILabel _loginToGc2;

	private UILabel _loginToGc3;

	private UILabel _loginToGc4;

	private UILabel _loginToGc5;

	private UILabel _loginToGc6;

	private UILabel _loginToGc7;

	private bool _enabled = true;

	private bool _isNoBonus;

	private bool _shouldDisplayAwardsSpecific;

	private void SetupText()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00fc: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		string text = Strings.Get(StringID.SOCIAL_BUTTON_FEEDBACK_CONNECTING);
		TrySetTextToLabel(_connectingTo, text);
		string text2 = Strings.Get(StringID.SOCIAL_BUTTON_FEEDBACK_COULD_NOT_CONNECT_1);
		TrySetTextToLabel(_couldNotConnect1, text2);
		string text3 = Strings.Get(StringID.SOCIAL_BUTTON_FEEDBACK_COULD_NOT_CONNECT_2);
		TrySetTextToLabel(_couldNotConnect2, text3);
		string text4 = Strings.Get(StringID.SOCIAL_BUTTON_FEEDBACK_TRY_AGAIN_1);
		TrySetTextToLabel(_tryAgain1, text4);
		string text5 = Strings.Get(StringID.SOCIAL_BUTTON_FEEDBACK_TRY_AGAIN_2);
		TrySetTextToLabel(_tryAgain2, text5);
		UILabel lbl;
		StringID key;
		if (~(_shouldDisplayAwardsSpecific ? 1u : 0u) == 0)
		{
			string text6 = Strings.Get(StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_1_AWARDS);
			TrySetTextToLabel(_loginToGc6, text6);
			lbl = _loginToGc7;
			key = StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_2_AWARDS;
		}
		else
		{
			object obj3 = 76;
			if (!_isNoBonus)
			{
				obj3 = 64;
			}
			object lbl2 = (object)this + obj3;
			StringID key2 = StringID.GAMECENTER_BUTTON_FEEDBACK_LOGIN_1_NO_BONUS;
			if (!_isNoBonus)
			{
				key2 = StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_1;
			}
			string text7 = Strings.Get(key2);
			TrySetTextToLabel((UILabel)lbl2, text7);
			object obj4 = 76;
			if (!_isNoBonus)
			{
				obj4 = 64;
			}
			object lbl3 = (object)this + obj4;
			StringID key3 = StringID.GAMECENTER_BUTTON_FEEDBACK_LOGIN_1_NO_BONUS;
			if (!_isNoBonus)
			{
				key3 = StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_1;
			}
			string text8 = Strings.Get(key3);
			TrySetTextToLabel((UILabel)lbl3, text8);
			object obj5 = 80;
			if (!_isNoBonus)
			{
				obj5 = 68;
			}
			object obj6 = (object)this + obj5;
			lbl = (UILabel)obj6;
			key = StringID.GAMECENTER_BUTTON_FEEDBACK_LOGIN_2_NO_BONUS;
			if (!_isNoBonus)
			{
				lbl = (UILabel)obj6;
				key = StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_2;
			}
		}
		string text9 = Strings.Get(key);
		TrySetTextToLabel(lbl, text9);
		string format = Strings.Get(StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_3);
		_ = 250;
		object obj7 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text10 = string.Format(format, arg);
		((GameCenterButton)(object)_loginToGc3).TrySetTextToLabel(_loginToGc3, text10);
	}

	private void TrySetTextToLabel(UILabel lbl, string text)
	{
		if (lbl != null)
		{
			lbl.text = text;
		}
	}

	private void OnEnable()
	{
		SocialManager instance = SocialManager.instance;
		throw new ArgumentException();
	}

	private void OnDisable()
	{
		SocialManager instance = SocialManager.instance;
		throw new ArgumentException();
	}

	public void Init(bool isLoggedIntoGameCenter, bool isNoBonus, bool isAwardsSpecific = false, bool isLoggedIntoFB = false)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		_isNoBonus = isNoBonus;
		object obj = (isLoggedIntoFB ? 1 : 0) ^ -1;
		bool shouldDisplayAwardsSpecific = (byte)((obj & isAwardsSpecific) ? 1 : 0) != 0;
		_shouldDisplayAwardsSpecific = shouldDisplayAwardsSpecific;
		SetupText();
		object stateGameObjectActive;
		if (isLoggedIntoGameCenter)
		{
			stateGameObjectActive = this + 16;
		}
		else
		{
			stateGameObjectActive = this + 32;
			object obj2 = this + 28;
			object obj3 = this + 24;
			if (!isNoBonus)
			{
				obj2 = obj3;
			}
			if (!_shouldDisplayAwardsSpecific)
			{
				stateGameObjectActive = obj2;
			}
		}
		SetStateGameObjectActive((GameObject)stateGameObjectActive);
		EnableTouch(enable: true);
	}

	private void OnPress(bool pressed)
	{
		if (~(_enabled ? 1u : 0u) == 0)
		{
			if (_btnOverlayOffDefault != null)
			{
				_btnOverlayOffDefault.ButtonPressed(pressed);
			}
			if (_btnOverlayOffTryAgain != null && _couldNotConnectTryAgainGameObject != null && _couldNotConnectTryAgainGameObject.activeInHierarchy)
			{
				_btnOverlayOffTryAgain.ButtonPressed(pressed);
			}
		}
	}

	private void OnClick()
	{
		if (~(_enabled ? 1u : 0u) != 0)
		{
			return;
		}
		SocialManager instance = SocialManager.instance;
		if (!instance.gamecenterIsLoggedIn)
		{
			if (!GameCenter.hasLoginView)
			{
				string title = Strings.Get(StringID.GAME_CENTER_BUTTON_NATIVE_POPUP_TITILE);
				string message = Strings.Get(StringID.GAME_CENTER_BUTTON_NATIVE_POPUP_MESSAGE);
				string dismissButton = Strings.Get(StringID.GAME_CENTER_BUTTON_NATIVE_POPUP_OK);
				DeviceUtility.ShowNativePopup(title, message, dismissButton);
			}
		}
		else
		{
			SetStateGameObjectActive(_connectingToGameObject);
			EnableTouch(enable: false);
			Coroutine coroutine = StartCoroutine("UserFeedback");
		}
	}

	private IEnumerator UserFeedback()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void GameCenterStateChanged()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		SocialManagerIOS instance = SocialManagerIOS.instance;
		if (instance._gcState != SocialManagerIOS.GCState.LoggedOut)
		{
			if (instance._gcState == SocialManagerIOS.GCState.Authenticating || instance._gcState == SocialManagerIOS.GCState.LoadingFriends)
			{
				SetStateGameObjectActive(_connectingToGameObject);
				EnableTouch(enable: false);
			}
			return;
		}
		object stateGameObjectActive;
		if (~(_shouldDisplayAwardsSpecific ? 1u : 0u) == 0)
		{
			stateGameObjectActive = this + 32;
		}
		else
		{
			stateGameObjectActive = this + 28;
			object obj = this + 24;
			if (!_isNoBonus)
			{
				stateGameObjectActive = obj;
			}
		}
		SetStateGameObjectActive((GameObject)stateGameObjectActive);
		EnableTouch(enable: true);
	}

	private void FriendsConsolidated(bool success)
	{
		SocialManager instance = SocialManager.instance;
		if (instance.gamecenterIsLoggedIn && !AreGamecenterFriendsConsolidated())
		{
			SetStateGameObjectActive(_couldNotConnectGameObject);
			EnableTouch(enable: false);
		}
	}

	private bool AreGamecenterFriendsConsolidated()
	{
		SocialManager instance = SocialManager.instance;
		int num = instance._consolidationState & 2;
		return (byte)(num >> 1) != 0;
	}

	private void SetStateGameObjectActive(GameObject go)
	{
		TrySetGameObjectActive(_connectingToGameObject, active: false);
		TrySetGameObjectActive(_couldNotConnectGameObject, active: false);
		TrySetGameObjectActive(_couldNotConnectTryAgainGameObject, active: false);
		TrySetGameObjectActive(_loginToGcWithBonusGameObject, active: false);
		TrySetGameObjectActive(_loginToGcNoBonusGameObject, active: false);
		TrySetGameObjectActive(_loginToGcForAwardsGameObject, active: false);
		TrySetGameObjectActive(go, active: true);
		if (!(go != null))
		{
			goto IL_010a;
		}
		bool flag = go != _loginToGcWithBonusGameObject;
		UIButtonOverlayOff.ButtonType buttonType = UIButtonOverlayOff.ButtonType.Secondary;
		if (flag)
		{
			bool flag2 = go != _loginToGcNoBonusGameObject;
			buttonType = UIButtonOverlayOff.ButtonType.Secondary;
			if (flag2)
			{
				bool flag3 = go != _loginToGcForAwardsGameObject;
				buttonType = UIButtonOverlayOff.ButtonType.Secondary;
				if (flag3)
				{
					goto IL_010a;
				}
			}
		}
		goto IL_013f;
		IL_013f:
		_btnOverlayOffDefault.SetButtonType(buttonType);
		return;
		IL_010a:
		bool flag4 = go != null;
		bool flag5 = !flag4;
		buttonType = UIButtonOverlayOff.ButtonType.SocialGrey;
		if (!flag5)
		{
			goto IL_013f;
		}
	}

	private void TrySetGameObjectActive(GameObject go, bool active)
	{
		if (go != null)
		{
			go.SetActive(active);
		}
	}

	private void EnableTouch(bool enable)
	{
		_enabled = enable;
		if (_btnOverlayOffDefault != null && _loginToGcWithBonusGameObject != null && _loginToGcNoBonusGameObject != null && _loginToGcForAwardsGameObject != null && _connectingToGameObject != null)
		{
			if (enable)
			{
				_btnOverlayOffDefault.GoToNormalState();
			}
			else
			{
				_btnOverlayOffDefault.GoToNotAvailableState();
			}
		}
	}
}
