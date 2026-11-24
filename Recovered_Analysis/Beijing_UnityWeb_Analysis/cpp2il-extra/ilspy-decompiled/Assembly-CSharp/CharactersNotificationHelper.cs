using System.Collections;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class CharactersNotificationHelper : MonoBehaviour
{
	private UISprite notificationIcon;

	private UILabel notificationLabel;

	private UISprite exclamationMark;

	private bool _hasGoneToZero;

	private const float UPDATE_INTERVAL = 0.1f;

	private float _currentInterval;

	private void OnEnable()
	{
		((UpgradeScreen)this).Start();
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
		if (((string)(object)enumerator).get_Chars((int)"CharacterScreen") == '\0')
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

	public CharactersNotificationHelper()
	{
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		CoinsForVideoManager instance = CoinsForVideoManager.instance;
		object obj = instance;
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v35 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((nint)instance < 1)
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
