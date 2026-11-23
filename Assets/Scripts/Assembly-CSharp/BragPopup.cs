using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class BragPopup : UIScreen
{
	public BragSendHelper SendMessageButton;

	public BragSendHelper FacebookBragButton;

	private FriendHandlerBrag _bragHandler;

	public override void Init()
	{
		//IL_005c: Expected I, but got Obj
		//IL_0014: Expected VT, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<BragPopup>)+104] (should have been resolved before IL gen)");
		UIScreenController instance = UIScreenController.Instance;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(FriendHandlerBrag));
		Component componentInChildren = instance.screenAnchor.GetComponentInChildren(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		FriendHandlerBrag bragHandler = default;
		_bragHandler = bragHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
	}

	public override void Show()
	{
		base.Show();
		SetupNotifyButton();
		SetupFacebookButton();
	}

	private unsafe void SetupNotifyButton()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		GameStats instance = GameStats.Instance;
		GameObject gameObject = SendMessageButton.gameObject;
		if (~(instance.BragNotifyDone ? 1u : 0u) == 0)
		{
			Collider component = gameObject.GetComponent<Collider>();
			if (component != null)
			{
				GameObject gameObject2 = SendMessageButton.gameObject;
				Collider component2 = gameObject2.GetComponent<Collider>();
				UnityEngine.Object.Destroy(component2);
			}
			BragSendHelper sendMessageButton = SendMessageButton;
			string text = Strings.Get(StringID.BRAG_POPUP_SEND_MESSAGE_LINE4);
			sendMessageButton.line1.text = text;
			BragSendHelper sendMessageButton2 = SendMessageButton;
			sendMessageButton2.line2.text = string.Empty;
			BragSendHelper sendMessageButton3 = SendMessageButton;
			sendMessageButton3.line3.text = string.Empty;
		}
		else
		{
			NGUITools.AddWidgetCollider(gameObject);
			BragSendHelper sendMessageButton4 = SendMessageButton;
			string text2 = Strings.Get(StringID.BRAG_POPUP_SEND_MESSAGE_LINE5);
			sendMessageButton4.line1.text = text2;
			BragSendHelper sendMessageButton5 = SendMessageButton;
			string text3 = Strings.Get(StringID.BRAG_POPUP_SEND_MESSAGE_LINE6);
			FriendHandlerBrag bragHandler = _bragHandler;
			List<Friend> bragList = bragHandler._bragList;
			_ = bragList._size;
			int num = obj + 12;
			string text4 = ((int*)num)->ToString();
			string text5 = text3 + " (" + text4 + ")";
			sendMessageButton5.line2.text = text5;
			BragSendHelper sendMessageButton6 = SendMessageButton;
			string text6 = Strings.Get(StringID.BRAG_POPUP_SEND_MESSAGE_LINE7);
			sendMessageButton6.line3.text = text6;
		}
	}

	private void SetupFacebookButton()
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		SocialManager instance = SocialManager.instance;
		StringID key;
		StringID key2;
		object obj2;
		if (instance.facebookIsLoggedIn)
		{
			object obj = this + 56;
			GameStats instance2 = GameStats.Instance;
			GameObject gameObject = FacebookBragButton.gameObject;
			if (~(instance2.BragFacebookDone ? 1u : 0u) == 0)
			{
				Collider component = gameObject.GetComponent<Collider>();
				bool flag = component != null;
				bool flag2 = !flag;
				key = StringID.BRAG_POPUP_FACEBOOK_BRAG_2;
				key2 = StringID.BRAG_POPUP_FACEBOOK_BRAG_1;
				obj2 = obj;
				if (!flag2)
				{
					GameObject gameObject2 = FacebookBragButton.gameObject;
					Collider component2 = gameObject2.GetComponent<Collider>();
					UnityEngine.Object.Destroy(component2);
					key = StringID.BRAG_POPUP_FACEBOOK_BRAG_2;
					key2 = StringID.BRAG_POPUP_FACEBOOK_BRAG_1;
					obj2 = obj;
				}
			}
			else
			{
				NGUITools.AddWidgetCollider(gameObject);
				key = StringID.BRAG_POPUP_FACEBOOK_BRAG_4;
				key2 = StringID.BRAG_POPUP_FACEBOOK_BRAG_3;
				obj2 = obj;
			}
		}
		else
		{
			GameObject go = FacebookBragButton.gameObject;
			NGUITools.AddWidgetCollider(go);
			object obj3 = this + 56;
			key = StringID.BRAG_POPUP_FACEBOOK_BRAG_6;
			key2 = StringID.BRAG_POPUP_FACEBOOK_BRAG_5;
			obj2 = obj3;
		}
		object obj4 = obj2;
		string text = Strings.Get(key2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v10+10]");
		((UILabel)0).text = text;
		object obj5 = obj2;
		string text2 = Strings.Get(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v16+14]");
		((UILabel)0).text = text2;
	}

	private void SendMessageButtonClicked()
	{
		SocialManager instance = SocialManager.instance;
		if (instance != null)
		{
			SocialManager instance2 = SocialManager.instance;
			PlayerInfo instance3 = PlayerInfo.Instance;
			FriendHandlerBrag bragHandler = _bragHandler;
			instance2.BragNotify(instance3._formerHighScore, bragHandler._bragList);
		}
		GameObject gameObject = SendMessageButton.gameObject;
		Collider component = gameObject.GetComponent<Collider>();
		if (component != null)
		{
			GameObject gameObject2 = SendMessageButton.gameObject;
			Collider component2 = gameObject2.GetComponent<Collider>();
			UnityEngine.Object.Destroy(component2);
		}
		BragSendHelper sendMessageButton = SendMessageButton;
		string text = Strings.Get(StringID.BRAG_POPUP_MESSAGE_BUTTON);
		sendMessageButton.line1.text = text;
		GameStats instance4 = GameStats.Instance;
		instance4.BragNotifyDone = true;
		CheckIfCompleted();
	}

	private void FacebookBragButtonClicked()
	{
		SocialManager instance = SocialManager.instance;
		bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
		SocialManager instance2 = SocialManager.instance;
		if (facebookIsLoggedIn)
		{
			FriendHandlerBrag bragHandler = _bragHandler;
			instance2.BragFacebook(bragHandler._bragList);
			GameObject gameObject = FacebookBragButton.gameObject;
			Collider component = gameObject.GetComponent<Collider>();
			if (component != null)
			{
				GameObject gameObject2 = FacebookBragButton.gameObject;
				Collider component2 = gameObject2.GetComponent<Collider>();
				UnityEngine.Object.Destroy(component2);
			}
			GameStats instance3 = GameStats.Instance;
			instance3.BragFacebookDone = true;
			SetupFacebookButton();
			CheckIfCompleted();
			return;
		}
		throw new ArgumentException();
	}

	private void CheckIfCompleted()
	{
		GameStats instance = GameStats.Instance;
		if (~(instance.BragFacebookDone ? 1u : 0u) == 0 && ~(instance.BragNotifyDone ? 1u : 0u) == 0)
		{
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.CloseActivePopups(screenName);
			_bragHandler.CompletedBrag();
		}
	}

	private void FacebookLoggedIn(bool loggedIn)
	{
		if (loggedIn)
		{
			SetupFacebookButton();
		}
	}
}
