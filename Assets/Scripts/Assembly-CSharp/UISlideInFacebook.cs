using System;
using Cpp2ILInjected;
using UnityEngine;

public class UISlideInFacebook : UISlideIn
{
	public enum FacebookSlideInState
	{
		ConnectFailed,
		ConnectSucceeded,
		LoggedOut
	}

	private UILabel _onlineLabel;

	private UILabel _offlineLabel;

	private GameObject _onlineElements;

	private GameObject _offlineElements;

	public void SetupSlideFacebook(FacebookSlideInState state, Action onDidShowCallback)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_00ed: Expected I, but got Obj
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		object obj;
		bool active;
		StringID key;
		bool active2;
		if (state != FacebookSlideInState.ConnectFailed)
		{
			if (state != FacebookSlideInState.ConnectSucceeded)
			{
				if (state != FacebookSlideInState.LoggedOut)
				{
					goto IL_00e8;
				}
				obj = this + 56;
				active = true;
				key = StringID.FACEBOOK_LOGOUT_SLIDEIN;
				active2 = false;
			}
			else
			{
				obj = this + 56;
				active = true;
				key = StringID.FACEBOOK_ONLINE_SLIDEIN;
				active2 = false;
			}
		}
		else
		{
			obj = this + 60;
			active = false;
			key = StringID.FACEBOOK_OFFLINE_SLIDEIN;
			active2 = true;
		}
		string text = Strings.Get(key);
		((UILabel)obj).text = text;
		_onlineElements.SetActive(active);
		_offlineElements.SetActive(active2);
		goto IL_00e8;
		IL_00e8:
		nint num = (nint)this;
		object obj2 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S2_v8 (Il2CppClass<UISlideInFacebook>)+E4] (should have been resolved before IL gen)");
	}
}
