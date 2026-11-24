using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Plugins.Facebook;
using UI.Screens;
using UnityEngine;

public class TutorialFacebookPopup : CharacterPopup
{
	private UILabel _buttonLabel;

	private UILabel _disclaimerLabel;

	private UILabel _calloutLabel;

	private GameObject _centerAnchor;

	private GameObject _tutorialMultiLinesPrefab;

	private TutorialMultilineLabelsHelper _tutorialLinesHelper;

	public override void Init()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72D5");
	}

	public unsafe override void Show()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected VT, but got Unknown
		//IL_0069: Expected VT, but got I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got F4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00df: Expected VT, but got Obj
		//IL_00da: Expected native int or pointer, but got VT
		//IL_00e7: Expected Obj, but got VT
		//IL_0102: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0172: Expected I4, but got Obj
		//IL_017e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = default;
		Vector3? vector = (Vector3?)(object)(obj + 32);
		vector = (Vector3?)(object)0;
		_ = 0;
		base.Hide();
		object obj2 = obj + 16;
		obj2 = 0;
		_ = 0;
		obj2 = 0f;
		_ = -54f;
		_ = 0f;
		Transform transform = (Transform)(obj + 48);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		*(Vector3?*)(nint)vector = (Vector3)transform;
		obj = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Nullable`1<UnityEngine.Vector3>)+8]");
		_ = 0;
		nint num = (nint)typeof(TutorialMultilineLabelsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v31 (Il2CppClass<TutorialMultilineLabelsHelper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(TutorialMultilineLabelsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v40 (Il2CppClass<TutorialMultilineLabelsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = (Transform)obj;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		object obj4 = this + 76;
		bool flag = ((UIModelController)(object)_centerAnchor).ExistsTransformModelInModelScreen((UIModelController.ModelScreen)_tutorialMultiLinesPrefab, transform);
		obj4 = flag;
	}

	public void OkClicked()
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I4
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_01bc: Expected I4, but got Obj
		//IL_010b: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_012d: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		_ = 0;
		((UIScreen)this).Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj4 = obj2 + 44;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = obj2 + 56;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8B9F");
		object obj6 = this - -64;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v29 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v44 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("POPUP_TUTORIAL_FACEBOOK_CALLOUT");
		((UILabel)obj6).fontSize = (int)text;
		((UIGeometry)(object)_tutorialLinesHelper).WriteToBuffers((List<Vector3>)(object)"POPUP_TUTORIAL_FACEBOOK_LINE1_BIG", (List<Vector2>)(object)"POPUP_TUTORIAL_FACEBOOK_LINE1_SMALL", (List<Color>)(object)"POPUP_TUTORIAL_FACEBOOK_LINE2_BIG", (List<Vector3>)(object)"POPUP_TUTORIAL_FACEBOOK_LINE2_SMALL", (List<Vector4>)(object)"POPUP_TUTORIAL_FACEBOOK_LINE3_BIG", (List<Vector4>)(object)"POPUP_TUTORIAL_FACEBOOK_LINE3_SMALL");
		string text2 = Strings.GetDefault("SOCIAL_BUTTON_JOIN_FRIENDS");
		_buttonLabel.fontSize = (int)text2;
		string text3 = Strings.GetDefault("POPUP_TUTORIAL_FACEBOOK_DISCLAIMER");
		_disclaimerLabel.fontSize = (int)text3;
	}

	public void CloseClicked()
	{
		//IL_021b: Expected I, but got Obj
		//IL_0231: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_013f: Expected I, but got Obj
		//IL_0155: Expected Obj, but got I
		//IL_0278: Expected I4, but got Obj
		//IL_028a: Expected I, but got Obj
		//IL_02a0: Expected Obj, but got I
		//IL_02c6: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		//IL_0180: Expected I, but got Obj
		//IL_01cd: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		_ = 1;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).SwitchScreen("LeaderboardUI");
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v28 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = flag3;
		bool flag4 = SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported, obj4);
		string original = tag;
		UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		nint num6 = (nint)typeof(UIScreens);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v22 (Il2CppClass<UIScreens>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v39 (Il2CppClass<UIScreens>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num8 = Utility.NumberOfDigits((int)obj5);
		nint num9 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v28 (Il2CppClass<Flurry>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v35 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry.LogClosePressedOnPopup((string)num8);
		bool flag5 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag5).ClosePopup((GameObject)(object)screenName);
	}

	public TutorialFacebookPopup()
	{
		//IL_0158: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0194: Expected I4, but got Obj
		//IL_01a6: Expected I, but got Obj
		//IL_01bc: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I4
		//IL_00bd: Expected I, but got Obj
		//IL_010a: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		_ = 1;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).SwitchScreen("LeaderboardUI");
		string original = tag;
		UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		nint num3 = (nint)typeof(UIScreens);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v9 (Il2CppClass<UIScreens>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v26 (Il2CppClass<UIScreens>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = Utility.NumberOfDigits((int)obj2);
		nint num6 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v15 (Il2CppClass<Flurry>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v22 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry.StartSession((string)num5);
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3).ClosePopup((GameObject)(object)screenName);
	}
}
