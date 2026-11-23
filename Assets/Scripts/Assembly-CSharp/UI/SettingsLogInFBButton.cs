using System;
using Cpp2ILInjected;
using Info;
using UI.Screens;
using UnityEngine;

namespace UI;

public class SettingsLogInFBButton : MonoBehaviour
{
	private UILabel _description;

	private UILabel _title;

	private UILabel _connecting;

	private UISprite _fbIcon;

	private UISprite _spinner;

	private GameObject _overlay;

	private UISprite _fill;

	private SettingsPopup _settingsPopup;

	private bool _facebookLoginRunning;

	private void OnClick()
	{
		throw new ArgumentException();
	}

	public unsafe void OnFacebookLoginResult(bool loggedIn)
	{
		if (!loggedIn && ~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			_facebookLoginRunning = false;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(SettingsLogInFBButton.OnFailSlideInFinish));
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
		else
		{
			if (~(_facebookLoginRunning ? 1u : 0u) == 0)
			{
				OnFacebookLoginResult(loggedIn: false);
			}
			SetToLogInState();
		}
		HouseKeeper.SetFacebookPayoutActionToDefault();
		_facebookLoginRunning = false;
	}

	private void OnEnable()
	{
		string text = Strings.Get(StringID.SETTINGS_POPUP_FB_LOG_IN_DESC);
		_description.text = text;
		string text2 = Strings.Get(StringID.SETTINGS_POPUP_FB_LOG_IN_TITLE);
		_title.text = text2;
		string text3 = Strings.Get(StringID.SETTINGS_POPUP_FB_LOG_IN_CONNECTING);
		_connecting.text = text3;
		SetToLogInState();
	}

	private void OnDisable()
	{
		if (~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			HouseKeeper.SetFacebookPayoutActionToDefault();
			_facebookLoginRunning = false;
		}
	}

	private unsafe void SetToLogInState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00fa: Expected Obj, but got VT
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_012c: Expected Obj, but got VT
		//IL_0156: Expected F4, but got I
		//IL_0151: Expected native int or pointer, but got VT
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got VT
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01c1: Expected F4, but got I
		//IL_01bc: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		_overlay.SetActive(value: true);
		object obj2 = GlobalColors.TERTIARY_ACTION_COLOR >> 16;
		object obj3 = obj2 & 0xFF;
		float num = (float)obj3 / 255f;
		object obj4 = GlobalColors.TERTIARY_ACTION_COLOR >> 24;
		float num2 = (float)obj4 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
		((Color*)(nint)color)->b = 0f;
		object obj5 = GlobalColors.TERTIARY_ACTION_COLOR & 0xFF;
		float num3 = (float)obj5 / 255f;
		object obj6 = GlobalColors.TERTIARY_ACTION_COLOR >> 8;
		object obj7 = obj6 & 0xFF;
		float num4 = (float)obj7 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
		((Color*)(nint)color)->r = 0f;
		_fill.color = color;
		GameObject gameObject = _title.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = _description.gameObject;
		gameObject2.SetActive(value: true);
		GameObject gameObject3 = _fbIcon.gameObject;
		gameObject3.SetActive(value: true);
		GameObject gameObject4 = _connecting.gameObject;
		gameObject4.SetActive(value: false);
		GameObject gameObject5 = _spinner.gameObject;
		gameObject5.SetActive(value: false);
		Collider component = GetComponent<Collider>();
		component.enabled = true;
	}

	private unsafe void SetToConnectingState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00fa: Expected Obj, but got VT
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_012c: Expected Obj, but got VT
		//IL_0156: Expected F4, but got I
		//IL_0151: Expected native int or pointer, but got VT
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got VT
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01c1: Expected F4, but got I
		//IL_01bc: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		_overlay.SetActive(value: false);
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
		_fill.color = color;
		GameObject gameObject = _title.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = _description.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = _fbIcon.gameObject;
		gameObject3.SetActive(value: false);
		GameObject gameObject4 = _connecting.gameObject;
		gameObject4.SetActive(value: true);
		GameObject gameObject5 = _spinner.gameObject;
		gameObject5.SetActive(value: true);
		Collider component = GetComponent<Collider>();
		component.enabled = false;
	}
}
