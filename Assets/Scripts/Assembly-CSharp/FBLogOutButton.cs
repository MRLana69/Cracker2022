using Cpp2ILInjected;
using TopRun;
using UI.Screens;
using UnityEngine;

public class FBLogOutButton : MonoBehaviour
{
	private UILabel _description;

	private UILabel _title;

	private GameObject _overlay;

	private UISprite _fill;

	private SettingsPopup settingsPopup;

	private void OnClick()
	{
		SocialManager instance = SocialManager.instance;
		instance.FacebookLogout();
		CachedLeaderboard.RemoveFacebookFriends();
		UIScreenController instance2 = UIScreenController.Instance;
		UIScreenController.SlideIn slideIn = default;
		slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.LoggedOut);
		instance2.QueueSlideIn(slideIn);
		if (TopRunRoot.manager__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		}
	}

	private unsafe void Disable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a6: Expected Obj, but got VT
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got VT
		//IL_0102: Expected F4, but got I
		//IL_00fd: Expected native int or pointer, but got VT
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0135: Expected Obj, but got VT
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_016d: Expected F4, but got I
		//IL_0168: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		_description.text = string.Empty;
		string text = Strings.Get(StringID.SETTINGS_POPUP_FB_LOGGED_OUT);
		_title.text = text;
		_overlay.SetActive(value: false);
		GameObject gameObject = _fill.gameObject;
		TweenColor component = gameObject.GetComponent<TweenColor>();
		if (component != null)
		{
			component.enabled = false;
		}
		object obj2 = GlobalColors.TERTIARY_ACTION_COLOR_UNAVAILABLE >> 16;
		object obj3 = obj2 & 0xFF;
		float num = (float)obj3 / 255f;
		object obj4 = GlobalColors.TERTIARY_ACTION_COLOR_UNAVAILABLE >> 24;
		float num2 = (float)obj4 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
		((Color*)(nint)color)->b = 0f;
		object obj5 = GlobalColors.TERTIARY_ACTION_COLOR_UNAVAILABLE & 0xFF;
		float num3 = (float)obj5 / 255f;
		object obj6 = GlobalColors.TERTIARY_ACTION_COLOR_UNAVAILABLE >> 8;
		object obj7 = obj6 & 0xFF;
		float num4 = (float)obj7 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
		((Color*)(nint)color)->r = 0f;
		_fill.color = color;
		Collider component2 = GetComponent<Collider>();
		component2.enabled = false;
	}

	private unsafe void Enable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0059: Expected Obj, but got VT
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got VT
		//IL_00b5: Expected F4, but got I
		//IL_00b0: Expected native int or pointer, but got VT
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got VT
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0120: Expected F4, but got I
		//IL_011b: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		string text = Strings.Get(StringID.SETTINGS_POPUP_FB_LOG_OUT_DESC);
		_description.text = text;
		string text2 = Strings.Get(StringID.SETTINGS_POPUP_FB_LOG_OUT_TITLE);
		_title.text = text2;
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
		Collider component = GetComponent<Collider>();
		component.enabled = true;
	}

	private void OnEnable()
	{
		Enable();
	}
}
