using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class TutorialMissionPopup : CharacterPopup
{
	private GameObject _centerAnchor;

	private GameObject _tutorialMultiLinesPrefab;

	private UILabel _calloutLabel;

	private UILabel _buttonText;

	private TutorialMultilineLabelsHelper _tutorialLinesHelper;

	public override void Init()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 84;
		obj = "";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72D5");
	}

	public override void Show()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0120: Expected I4, but got Obj
		//IL_012c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		_ = 0;
		base.Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num = (nint)typeof(TutorialMultilineLabelsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (Il2CppClass<TutorialMultilineLabelsHelper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(TutorialMultilineLabelsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v30 (Il2CppClass<TutorialMultilineLabelsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 32);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		object obj4 = this + 72;
		bool flag = ((UIModelController)(object)_centerAnchor).ExistsTransformModelInModelScreen((UIModelController.ModelScreen)_tutorialMultiLinesPrefab, transform);
		obj4 = flag;
	}

	public void OkClicked()
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0145: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_019a: Expected I4, but got Obj
		//IL_010b: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v41 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("POPUP_TUTORIAL_MISSIONS_TITLE_1");
		((UILabel)obj6).fontSize = (int)text;
		((UIGeometry)(object)_tutorialLinesHelper).WriteToBuffers((List<Vector3>)(object)"POPUP_TUTORIAL_MISSIONS_LINE1BIG", (List<Vector2>)(object)"POPUP_TUTORIAL_MISSIONS_LINE1SMALL", (List<Color>)(object)"POPUP_TUTORIAL_MISSIONS_LINE2BIG", (List<Vector3>)(object)"POPUP_TUTORIAL_MISSIONS_LINE2SMALL", (List<Vector4>)(object)"POPUP_TUTORIAL_MISSIONS_LINE3BIG", (List<Vector4>)(object)"POPUP_TUTORIAL_MISSIONS_LINE3SMALL");
		string text2 = Strings.GetDefault("POPUP_TUTORIAL_MISSIONS_BUTTON");
		_buttonText.fontSize = (int)text2;
	}

	public void CloseClicked()
	{
		//IL_0196: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_027b: Expected I, but got Obj
		//IL_0291: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_01f8: Expected I4, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I4
		//IL_025e: Expected Obj, but got I4
		//IL_00fb: Expected I, but got Obj
		//IL_0148: Expected I, but got Obj
		nint num = (nint)typeof(ChallengesScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.ChallengesScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ChallengesScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<UI.Screens.ChallengesScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8813");
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v24 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).SwitchScreen("ChallengesScreen");
		string original = tag;
		UnityEngine.Object obj3 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		nint num5 = (nint)typeof(UIScreens);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v10 (Il2CppClass<UIScreens>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v27 (Il2CppClass<UIScreens>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num7 = Utility.NumberOfDigits((int)obj3);
		nint num8 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v16 (Il2CppClass<Flurry>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num9 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v23 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry.LogClosePressedOnPopup((string)num7);
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).ClosePopup((GameObject)(object)screenName);
	}

	public TutorialMissionPopup()
	{
		//IL_0111: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_014d: Expected I4, but got Obj
		//IL_015f: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I4
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		string original = tag;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		nint num = (nint)typeof(UIScreens);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<UIScreens>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v23 (Il2CppClass<UIScreens>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Utility.NumberOfDigits((int)obj);
		nint num4 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v11 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v19 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry.StartSession((string)num3);
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v10 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v16 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
	}
}
