using System;
using Cpp2ILInjected;
using Data.Save;
using Kiloo;
using UnityEngine;

public class FriendCrewPokeHelper : MonoBehaviour
{
	private GameObject _pokeButtonContainer;

	private BoxCollider _pokeCollider;

	private Friend _friend;

	public void ActivatePoke(Friend friend)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0117: Expected Obj, but got VT
		//IL_008e: Expected I, but got Obj
		object obj = default;
		string text = (string)(obj + 8);
		if ((string)(object)friend == "EventsPopup" && !((string)(object)friend != "CharacterNameEventPopup"))
		{
			return;
		}
		((EventButtonBreadcrumb)this)._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v12 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v22 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @91D0");
		DateTime today = CDateTime.Today;
		obj = today;
		text = (string)obj;
		UserSave.lastSeenBundleVersion = text;
	}

	public void DeactivatePoke()
	{
		CancelInvoke();
	}

	private void OnClick()
	{
		_pokeCollider.isTrigger = false;
		_pokeButtonContainer.tag = null;
	}

	public FriendCrewPokeHelper()
	{
		//IL_0062: Expected Obj, but got I4
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		OnClick();
		((NewMonoBehaviour)26)._002Ector();
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v14 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		((SocialManager)facebookDialogsSupported).SetPokeFirstTime(_friend);
	}
}
