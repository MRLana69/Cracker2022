using Cpp2ILInjected;
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
		CancelInvoke();
	}

	private void Enable()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		((SocialManager)facebookDialogsSupported).RecommendAppFacebook();
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v25 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 13;
		_ = 2;
		((UIScreenController)flag)._QueueMessage(text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj3 = default;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		settingsPopup.ConnectedToFacebook();
	}

	private unsafe void OnEnable()
	{
		//IL_0121: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I
		//IL_0206: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0071: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got VT
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected VT, but got Unknown
		//IL_019c: Expected F4, but got Obj
		//IL_0197: Expected native int or pointer, but got VT
		//IL_01b6: Expected F4, but got Obj
		//IL_01b1: Expected native int or pointer, but got VT
		//IL_01cb: Expected F4, but got I
		//IL_01c6: Expected native int or pointer, but got VT
		//IL_01da: Expected I4, but got VT
		//IL_00c5: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v39 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SETTINGS_POPUP_FB_LOG_OUT_DESC");
		_description.fontSize = (int)text;
		string text2 = Strings.GetDefault("SETTINGS_POPUP_FB_TITLE");
		_title.fontSize = (int)text2;
		_overlay.tag = (string)1;
		nint num3 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (Il2CppClass<GlobalColors>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v33 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 20;
		obj3 = GlobalColors.TERTIARY_ACTION_COLOR;
		object obj5 = obj4 + 16;
		obj5 = obj3;
		Matrix4x4 matrix4x = (Matrix4x4)(obj4 + 24);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_fill.rawPivot = (UIWidget.Pivot)matrix4x;
		Collider component = GetComponent<Collider>();
		component.isTrigger = true;
	}

	public FBLogOutButton()
	{
		OnEnable();
	}
}
