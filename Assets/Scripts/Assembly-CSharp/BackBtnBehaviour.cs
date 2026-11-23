using System;
using Cpp2ILInjected;
using Kiloo.Plugins.Facebook;
using SYBO.Subway;
using UnityEngine;

public class BackBtnBehaviour : MonoBehaviour
{
	public enum ScreenChangeType
	{
		PushScreen,
		SwitchScreen,
		BackToPrevious,
		QueuePopup,
		ClosePopup,
		ExitGame,
		SaveMePopup,
		NotEnoughCurrency
	}

	private GameObject target;

	private string functionName = string.Empty;

	public ScreenChangeType screenChangeType;

	public GameObject popupLayerAnchor;

	public string ScreenNameToOpen = string.Empty;

	private static EventHandler m_OnInitiatingQuit;

	public static event EventHandler OnInitiatingQuit
	{
		add
		{
			Delegate obj = BackBtnBehaviour.m_OnInitiatingQuit;
			EventHandler eventHandler = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == BackBtnBehaviour.m_OnInitiatingQuit;
				EventHandler onInitiatingQuit = eventHandler;
				if (!flag)
				{
					onInitiatingQuit = BackBtnBehaviour.m_OnInitiatingQuit;
				}
				BackBtnBehaviour.m_OnInitiatingQuit = onInitiatingQuit;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = BackBtnBehaviour.m_OnInitiatingQuit;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = BackBtnBehaviour.m_OnInitiatingQuit;
			EventHandler eventHandler = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == BackBtnBehaviour.m_OnInitiatingQuit;
				EventHandler onInitiatingQuit = eventHandler;
				if (!flag)
				{
					onInitiatingQuit = BackBtnBehaviour.m_OnInitiatingQuit;
				}
				BackBtnBehaviour.m_OnInitiatingQuit = onInitiatingQuit;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = BackBtnBehaviour.m_OnInitiatingQuit;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Send();
		}
	}

	private void CheckForFunctionToExecute()
	{
		if (screenChangeType != ScreenChangeType.PushScreen)
		{
			if (screenChangeType != ScreenChangeType.SwitchScreen)
			{
				if (screenChangeType != ScreenChangeType.BackToPrevious)
				{
					if (screenChangeType != ScreenChangeType.QueuePopup)
					{
						if (screenChangeType != ScreenChangeType.ClosePopup)
						{
							if (screenChangeType != ScreenChangeType.ExitGame)
							{
								if (screenChangeType != ScreenChangeType.SaveMePopup)
								{
									if (screenChangeType == ScreenChangeType.NotEnoughCurrency)
									{
										functionName = "CloseNotEnoughCurrency";
									}
								}
								else
								{
									functionName = "CloseSaveMe";
								}
							}
							else
							{
								functionName = "ExitGame";
							}
						}
						else
						{
							functionName = "ClosePopup";
						}
					}
					else
					{
						functionName = "QueuePopup";
					}
				}
				else
				{
					functionName = "BackToPrevious";
				}
			}
			else
			{
				functionName = "SwitchScreen";
			}
		}
		else
		{
			functionName = "PushScreen";
		}
	}

	protected void Send()
	{
		//IL_0197: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_04cc: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.MetroPlayerARM && FacebookSession._instance.GetState() == FacebookSession.State.CREATED)
		{
			return;
		}
		UIScreenController instance = UIScreenController.Instance;
		string currentPopupName = instance.GetCurrentPopupName();
		if (!(currentPopupName != "CelebrationPopup"))
		{
			return;
		}
		UIScreenController instance2 = UIScreenController.Instance;
		if (instance2.IsInAppPurchaseOverlayVisible())
		{
			return;
		}
		UIScreenController instance3 = UIScreenController.Instance;
		if (instance3.IsAdsOverlayVisible())
		{
			if (UIScreenController.IsInstanced)
			{
				UIScreenController instance4 = UIScreenController.Instance;
				instance4.HideAdsOverlay();
			}
			return;
		}
		CheckForFunctionToExecute();
		if (!enabled)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeInHierarchy)
		{
			return;
		}
		string screenNameToOpen = ScreenNameToOpen;
		object obj;
		if (ScreenNameToOpen != null)
		{
			obj = 0;
			if (screenNameToOpen._stringLength != 0)
			{
				goto IL_047d;
			}
		}
		obj = 1;
		goto IL_047d;
		IL_047d:
		if (obj != null && screenChangeType <= ScreenChangeType.QueuePopup && screenChangeType != ScreenChangeType.BackToPrevious)
		{
			string text = name;
			string text2 = text + " tried to send an empty Change Screen message";
		}
		if (functionName.Equals("ExitGame"))
		{
			UIScreenController instance5 = UIScreenController.Instance;
			if (instance5.IsPopupQueueEmpty())
			{
				UIScreenController instance6 = UIScreenController.Instance;
				instance6.PushPopup("QuitApplicationPopup");
			}
		}
		else if (functionName.Equals("CloseSaveMe"))
		{
			SaveMeCancelButton.CloseSaveMe();
		}
		else if (functionName.Equals("CloseNotEnoughCurrency"))
		{
			UIScreenController instance7 = UIScreenController.Instance;
			instance7.CloseActivePopups("NotEnoughCurencyPopup");
			Game instance8 = Game.Instance;
			Variable<bool> isInGame = instance8.IsInGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v78 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 != 0)
			{
				Revive instance9 = Revive.Instance;
				instance9.SendSkipRevive();
				SaveMeManager.ResetSaveMeForNewRun();
			}
		}
		else
		{
			if (target == null)
			{
				MessageCenter instance10 = MessageCenter.Instance;
				GameObject gameObject2 = instance10.gameObject;
				target = gameObject2;
			}
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v244 @ S3_v5 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			object obj2 = 0;
			object obj6 = default;
			while (true)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v59+C]");
				if ((nint)obj3 >= 0)
				{
					break;
				}
				object obj4 = obj2 << 2;
				object obj5 = obj6 + obj4;
				GameObject value = base.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v65+10]");
				((Component)0).SendMessage(functionName, value, SendMessageOptions.DontRequireReceiver);
				object obj7 = obj2 + 1;
				obj2 = obj7;
			}
		}
		LogFlurry();
	}

	private void ShowExitGamePopup()
	{
		string text = Strings.Get(StringID.QUIT_NATIVE_POPUP_TITLE);
		string text2 = Strings.Get(StringID.QUIT_NATIVE_POPUP_TEXT);
		string text3 = Strings.Get(StringID.QUIT_NATIVE_POPUP_BTN_RETURN);
		string text4 = Strings.Get(StringID.QUIT_NATIVE_POPUP_BTN_QUIT);
		throw new ArgumentException();
	}

	private void LogFlurry()
	{
		//IL_0047: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		string text;
		do
		{
			UIScreenController instance = UIScreenController.Instance;
			string currentPopupName = instance.GetCurrentPopupName();
			object obj;
			if (currentPopupName != null)
			{
				obj = 0;
				if (currentPopupName._stringLength != 0)
				{
					goto IL_009d;
				}
			}
			obj = 1;
			goto IL_009d;
			IL_009d:
			bool flag = obj == null;
			text = currentPopupName;
			if (!flag)
			{
				UIScreenController instance2 = UIScreenController.Instance;
				string topScreenName = instance2.GetTopScreenName();
				text = topScreenName;
			}
		}
		while (text != null && text._stringLength == 0);
	}

	private void _003CShowExitGamePopup_003Eb__12_0(string buttonPressed)
	{
		string text = Strings.Get(StringID.QUIT_NATIVE_POPUP_BTN_QUIT);
		if (buttonPressed == text)
		{
			PlayerInfo instance = PlayerInfo.Instance;
			instance.SaveIfDirty();
			SocialManager instance2 = SocialManager.instance;
			instance2.SaveIfDirty();
			if (BackBtnBehaviour.m_OnInitiatingQuit != null)
			{
				EventHandler onInitiatingQuit = BackBtnBehaviour.m_OnInitiatingQuit;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			Application.Quit();
		}
	}
}
