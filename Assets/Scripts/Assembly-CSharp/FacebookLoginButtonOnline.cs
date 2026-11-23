using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class FacebookLoginButtonOnline : MonoBehaviour
{
	private sealed class _003CUserFeedback_003Ed__33(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FacebookLoginButtonOnline _003C_003E4__this;

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
					FacebookLoginButtonOnline facebookLoginButtonOnline = _003C_003E4__this;
					_003C_003E1__state = -1;
					_003C_003E4__this.SetStateGameObjectActive(facebookLoginButtonOnline._couldNotConnectTryAgainGameObject);
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

	private GameObject _loginToFbWithBonusGameObject;

	private GameObject _loginToFbNoBonusGameObject;

	private GameObject _loginToFbForAwardsGameObject;

	private GameObject _loginToFbForTopRunGameObject;

	private UIButtonOverlayOff _btnOverlayOffDefault;

	private UIButtonOverlayOff _btnOverlayOffTryAgain;

	private UILabel _connectingTo;

	private UILabel _couldNotConnect1;

	private UILabel _couldNotConnect2;

	private UILabel _tryAgain1;

	private UILabel _tryAgain2;

	private UILabel _loginToFb1;

	private UILabel _loginToFb2;

	private UILabel _loginToFb3;

	private UILabel _loginToFb4;

	private UILabel _loginToFb5;

	private UILabel _loginToFb6;

	private UILabel _loginToFb7;

	private bool _isNoBonus;

	private bool _isGameOverScreen;

	private bool _shouldDisplayAwardsSpecific;

	private bool _shouldDisplayTopRunSpecific;

	private bool _enabled = true;

	public void Init(bool isLoggedIntoFacebook, bool isNoBonus, bool isAwardsSpecific = false, bool isLoggedIntoGC = false, bool isTopRunSpecific = false, bool noGCFriends = false, bool isGameOverScreen = false)
	{
		//IL_0039: Expected Obj, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected I4, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		_isGameOverScreen = isGameOverScreen;
		_isNoBonus = isNoBonus;
		bool shouldDisplayTopRunSpecific = isNoBonus & isTopRunSpecific;
		_shouldDisplayTopRunSpecific = shouldDisplayTopRunSpecific;
		object obj = (isLoggedIntoGC ? 1 : 0) ^ -1;
		bool shouldDisplayAwardsSpecific = (byte)((obj & isAwardsSpecific) ? 1 : 0) != 0;
		_shouldDisplayAwardsSpecific = shouldDisplayAwardsSpecific;
		SetupButton(noGCFriends);
		object stateGameObjectActive = this + 16;
		if (!isLoggedIntoFacebook)
		{
			stateGameObjectActive = this + 36;
			if (!_shouldDisplayTopRunSpecific)
			{
				stateGameObjectActive = this + 32;
				if (!_shouldDisplayAwardsSpecific)
				{
					stateGameObjectActive = this + 28;
					object obj2 = this + 24;
					if (!isNoBonus)
					{
						stateGameObjectActive = obj2;
					}
				}
			}
		}
		SetStateGameObjectActive((GameObject)stateGameObjectActive);
		EnableTouch(enable: true);
	}

	private unsafe void SetupButton(bool noGCFriends)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I4
		//IL_02b8: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_01d1: Expected VT, but got I8
		//IL_01ec: Expected VT, but got I8
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
		if (~(_shouldDisplayAwardsSpecific ? 1u : 0u) == 0)
		{
			string text6 = Strings.Get(StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_1_AWARDS);
			TrySetTextToLabel(_loginToFb6, text6);
			string text7 = Strings.Get(StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_2_AWARDS);
			TrySetTextToLabel(_loginToFb7, text7);
		}
		else
		{
			object obj3 = 80;
			if (!_isNoBonus)
			{
				obj3 = 68;
			}
			object lbl = (object)this + obj3;
			StringID key = StringID.FACEBOOK_BUTTON_FEEDBACK_LOGIN_1_NO_BONUS;
			if (!_isNoBonus)
			{
				key = StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_1;
			}
			string text8 = Strings.Get(key);
			TrySetTextToLabel((UILabel)lbl, text8);
			object obj4 = 84;
			if (!_isNoBonus)
			{
				obj4 = 72;
			}
			object lbl2 = (object)this + obj4;
			StringID key2 = StringID.FACEBOOK_BUTTON_FEEDBACK_LOGIN_2_NO_BONUS_NO_GC_FRIENDS;
			if (!noGCFriends)
			{
				key2 = StringID.FACEBOOK_BUTTON_FEEDBACK_LOGIN_2_NO_BONUS;
			}
			if (!_isNoBonus)
			{
				key2 = StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_2;
			}
			string text9 = Strings.Get(key2);
			TrySetTextToLabel((UILabel)lbl2, text9);
			string format = Strings.Get(StringID.SOCIAL_BUTTON_FEEDBACK_LOGIN_3);
			_ = 5000;
			object obj5 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			string text10 = string.Format(format, arg);
			TrySetTextToLabel(_loginToFb3, text10);
			UIAnchor component = _loginToFb4.GetComponent<UIAnchor>();
			if (component != null)
			{
				Vector2 pixelOffset = (Vector2)(-4647714814340104192L);
				if (!noGCFriends)
				{
					pixelOffset = (Vector2)(-4647714814350589952L);
				}
				component.pixelOffset = pixelOffset;
			}
		}
		SocialManager instance = SocialManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FacebookLoginButtonOnline.FacebookStateChanged));
		instance.AddFacebookStateChangedHandler(action);
		SocialManager instance2 = SocialManager.instance;
		throw new ArgumentException();
	}

	private void TrySetTextToLabel(UILabel lbl, string text)
	{
		if (lbl != null)
		{
			lbl.text = text;
		}
	}

	private unsafe void OnDestroy()
	{
		SocialManager instance = SocialManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FacebookLoginButtonOnline.FacebookStateChanged));
		instance.RemoveFacebookStateChangedHandler(action);
		SocialManager instance2 = SocialManager.instance;
		throw new ArgumentException();
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
		if (~(_enabled ? 1u : 0u) == 0)
		{
			SetStateGameObjectActive(_connectingToGameObject);
			EnableTouch(enable: false);
			SocialManager instance = SocialManager.instance;
			throw new ArgumentException();
		}
	}

	private void FacebookLoggedIn(bool success)
	{
		if ((bool)this)
		{
			if (!success)
			{
				IEnumerator routine = UserFeedback();
				Coroutine coroutine = StartCoroutine(routine);
			}
			else
			{
				UIScreenController instance = UIScreenController.Instance;
				instance.FacebookLogIn(loggedIn: true);
				EnableTouch(enable: false);
			}
		}
		QueueSlideIn(success);
	}

	private IEnumerator UserFeedback()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void QueueSlideIn(bool success)
	{
		UIScreenController instance = UIScreenController.Instance;
		UIScreenController.SlideIn slideIn = default;
		slideIn._002Ector(UIScreenController.SlideInType.Facebook, success ? UISlideInFacebook.FacebookSlideInState.ConnectSucceeded : UISlideInFacebook.FacebookSlideInState.ConnectFailed);
		instance.QueueSlideIn(slideIn);
	}

	private void FacebookStateChanged()
	{
		//IL_001c: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		SocialManager instance = SocialManager.instance;
		object obj = instance._fbState - 1;
		object stateGameObjectActive;
		bool enable;
		if (instance._fbState != SocialManager.FacebookState.Error)
		{
			if ((nint)obj != 1)
			{
				return;
			}
			stateGameObjectActive = this + 12;
			enable = false;
		}
		else
		{
			stateGameObjectActive = this + 16;
			enable = true;
		}
		SetStateGameObjectActive((GameObject)stateGameObjectActive);
		EnableTouch(enable);
	}

	private bool AreFacebookFriendsConsolidated()
	{
		SocialManager instance = SocialManager.instance;
		return (byte)(instance._consolidationState & 1) != 0;
	}

	private void SetStateGameObjectActive(GameObject go)
	{
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		if (_connectingToGameObject != null)
		{
			_connectingToGameObject.SetActive(value: false);
		}
		if (_couldNotConnectGameObject != null)
		{
			_couldNotConnectGameObject.SetActive(value: false);
		}
		if (_couldNotConnectTryAgainGameObject != null)
		{
			_couldNotConnectTryAgainGameObject.SetActive(value: false);
		}
		if (_loginToFbWithBonusGameObject != null)
		{
			_loginToFbWithBonusGameObject.SetActive(value: false);
		}
		if (_loginToFbNoBonusGameObject != null)
		{
			_loginToFbNoBonusGameObject.SetActive(value: false);
		}
		if (_loginToFbForAwardsGameObject != null)
		{
			_loginToFbForAwardsGameObject.SetActive(value: false);
		}
		if (_loginToFbForTopRunGameObject != null)
		{
			_loginToFbForTopRunGameObject.SetActive(value: false);
		}
		if (go != null)
		{
			go.SetActive(value: true);
		}
		object obj;
		UIButtonOverlayOff.ButtonType buttonType;
		if (go != null && (!(go != _loginToFbWithBonusGameObject) || !(go != _loginToFbNoBonusGameObject) || !(go != _loginToFbForAwardsGameObject) || go == _loginToFbForTopRunGameObject))
		{
			_btnOverlayOffDefault.SetButtonType(UIButtonOverlayOff.ButtonType.Secondary);
			if (!(go == _loginToFbForTopRunGameObject) || _isGameOverScreen)
			{
				return;
			}
			obj = this + 40;
			buttonType = UIButtonOverlayOff.ButtonType.Primary;
		}
		else
		{
			if (!(go != null))
			{
				return;
			}
			obj = this + 40;
			buttonType = UIButtonOverlayOff.ButtonType.SocialGrey;
		}
		((UIButtonOverlayOff)obj).SetButtonType(buttonType);
	}

	private void FriendsConsolidated(bool success)
	{
		SocialManager instance = SocialManager.instance;
		if (instance.facebookIsLoggedIn && !AreFacebookFriendsConsolidated())
		{
			SetStateGameObjectActive(_couldNotConnectGameObject);
			EnableTouch(enable: false);
		}
	}

	private void EnableTouch(bool enable)
	{
		_enabled = enable;
		if (_btnOverlayOffDefault != null && _loginToFbWithBonusGameObject != null && _loginToFbNoBonusGameObject != null && _loginToFbForAwardsGameObject != null && _loginToFbForTopRunGameObject != null && _couldNotConnectGameObject != null)
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
