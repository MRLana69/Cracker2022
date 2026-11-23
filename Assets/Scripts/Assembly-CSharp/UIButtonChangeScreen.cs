using System;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;

public class UIButtonChangeScreen : UIBasicButton
{
	public enum ScreenChangeType
	{
		PushScreen,
		SwitchScreen,
		BackToPrevious,
		QueuePopup,
		ClosePopup,
		PushPopup
	}

	private GameObject target;

	private string functionName = string.Empty;

	public ScreenChangeType screenChangeType;

	private string popupToReturnTo;

	public string ScreenNameToOpen;

	private bool useSend = true;

	public void SetScreenNameAndDoNotUseSendMessage(string sendScreenNameToOpen)
	{
		ScreenNameToOpen = sendScreenNameToOpen;
		useSend = false;
	}

	private void Awake()
	{
		if (~(useSend ? 1u : 0u) != 0)
		{
			return;
		}
		ScreenChangeType screenChangeType;
		if (this.screenChangeType != ScreenChangeType.PushScreen)
		{
			if (this.screenChangeType != ScreenChangeType.SwitchScreen)
			{
				if (this.screenChangeType != ScreenChangeType.BackToPrevious)
				{
					if (this.screenChangeType != ScreenChangeType.QueuePopup)
					{
						bool flag = this.screenChangeType == ScreenChangeType.ClosePopup;
						screenChangeType = this.screenChangeType;
						if (!flag)
						{
							if (this.screenChangeType == ScreenChangeType.PushPopup)
							{
								functionName = "PushPopup";
								goto IL_0171;
							}
							screenChangeType = this.screenChangeType;
						}
						goto IL_0151;
					}
					functionName = "QueuePopup";
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
		goto IL_0171;
		IL_0151:
		if (screenChangeType == ScreenChangeType.ClosePopup)
		{
			functionName = "ClosePopup";
		}
		return;
		IL_0171:
		screenChangeType = this.screenChangeType;
		goto IL_0151;
	}

	protected override void Send()
	{
		//IL_00d4: Expected VT, but got Obj
		//IL_008f: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_0160: Expected VT, but got Obj
		//IL_01ee: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I4
		//IL_03c5: Expected Obj, but got I4
		//IL_02d6: Expected Obj, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		if (~(useSend ? 1u : 0u) != 0)
		{
			return;
		}
		object obj;
		if (ScreenNameToOpen == "CoinsUI_quick")
		{
			UIScreenController instance = UIScreenController.Instance;
			string topScreenName = instance.GetTopScreenName();
			if (topScreenName != null)
			{
				obj = 0;
				if (topScreenName._stringLength != 0)
				{
					goto IL_0335;
				}
			}
			obj = 1;
			goto IL_0335;
		}
		if (ScreenNameToOpen == "PauseUI")
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			_ = 1;
		}
		else if (ScreenNameToOpen == "IngameUI")
		{
			UIScreenController instance2 = UIScreenController.Instance;
			string currentPopupName = instance2.GetCurrentPopupName();
			if (currentPopupName == "ConsumablesPopup")
			{
				_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
				_ = 1;
			}
		}
		goto IL_035d;
		IL_035d:
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
		object obj2;
		if (ScreenNameToOpen != null)
		{
			obj2 = 0;
			if (screenNameToOpen._stringLength != 0)
			{
				goto IL_0381;
			}
		}
		obj2 = 1;
		goto IL_0381;
		IL_0381:
		if (obj2 != null && screenChangeType <= ScreenChangeType.QueuePopup && screenChangeType != ScreenChangeType.BackToPrevious)
		{
			string text = name;
			string text2 = text + " tried to send an empty Change Screen message";
		}
		if (target == null)
		{
			MessageCenter instance3 = MessageCenter.Instance;
			GameObject gameObject2 = instance3.gameObject;
			target = gameObject2;
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ S3_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj3 = 0;
		object obj7 = default;
		while (true)
		{
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v34+C]");
			if ((nint)obj4 < 0)
			{
				object obj5 = obj3 << 2;
				object obj6 = obj7 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v40+10]");
				GameObject gameObject3 = ((Component)0).gameObject;
				GameObject value = base.gameObject;
				gameObject3.SendMessage(functionName, value, SendMessageOptions.DontRequireReceiver);
				object obj8 = obj3 + 1;
				obj3 = obj8;
				continue;
			}
			break;
		}
		return;
		IL_0335:
		if (obj != null)
		{
		}
		goto IL_035d;
	}
}
