using System.Collections;
using Cpp2ILInjected;
using UI;
using UnityEngine;

public class BoardsNotificationHelper : MonoBehaviour
{
	private UISprite notificationIcon;

	private UILabel notificationLabel;

	private UISprite exclamationMark;

	private bool _hasGoneToZero;

	private const float UPDATE_INTERVAL = 0.1f;

	private float _currentInterval;

	private void OnEnable()
	{
		CancelInvoke();
	}

	private void Update()
	{
		this._002Ector();
	}

	private void RefreshNotification()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I4
		//IL_0180: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		if (~(_hasGoneToZero ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		if (((string)(object)enumerator).get_Chars((int)"BoardScreen") == '\0')
		{
			if (!(_currentInterval > 0f))
			{
				float currentInterval = _currentInterval + 0.1f;
				_currentInterval = currentInterval;
				this._002Ector();
			}
			else
			{
				float unscaledTime = Time.unscaledTime;
				float currentInterval2 = _currentInterval - unscaledTime;
				_currentInterval = currentInterval2;
			}
		}
	}

	public BoardsNotificationHelper()
	{
		//IL_0082: Expected Obj, but got I4
		//IL_0092: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		string welcomePackInAppID = WelcomePackManager.WelcomePackInAppID;
		object obj = welcomePackInAppID;
		if ((nint)welcomePackInAppID < 1)
		{
			notificationIcon.tag = null;
			notificationLabel.tag = null;
			exclamationMark.tag = null;
			_hasGoneToZero = true;
			return;
		}
		notificationIcon.tag = (string)1;
		notificationLabel.tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		notificationLabel.fontSize = fontSize;
		bool flag = (nint)obj == 1;
		exclamationMark.tag = (string)flag;
		bool flag2 = (nint)obj > 1;
		notificationLabel.tag = (string)flag2;
	}
}
