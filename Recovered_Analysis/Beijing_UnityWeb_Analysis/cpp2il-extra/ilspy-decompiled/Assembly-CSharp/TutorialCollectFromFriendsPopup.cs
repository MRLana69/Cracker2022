using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class TutorialCollectFromFriendsPopup : CharacterPopup
{
	private GameObject _centerAnchor;

	private UILabel _topTitle;

	private UILabel _buttonText;

	private GameObject _tutorialMultiLinesPrefab;

	private TutorialMultilineLabelsHelper _tutorialLinesHelper;

	public override void Init()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_00e6: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got VT
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got VT
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01cc: Expected Obj, but got I4
		//IL_01d5: Expected Obj, but got F4
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0215: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got F4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got F4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_02a7: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got F4
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02f0: Expected Obj, but got I4
		//IL_02f9: Expected Obj, but got F4
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_0339: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 40;
		object obj2 = default;
		obj = obj2;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<GlobalColors>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v92 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 100;
		obj4 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR;
		object obj6 = obj5 + 108;
		obj6 = obj4;
		object obj7 = obj5 + 112;
		obj7 = obj6;
		base._secondaryCharacterModel = (CharacterModel)obj7;
		object obj8 = obj5 + 96;
		obj8 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_CONTENT_COLOR;
		object obj9 = obj5 + 104;
		obj9 = obj8;
		obj7 = obj9;
		uimodelController = (UIModelController)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UISprite> list = default;
		list._002Ector();
		object obj10 = this + 152;
		obj10 = list;
		object obj11 = obj5 - -64;
		obj11 = 0;
		obj11 = 270f;
		_ = 213f;
		object obj12 = obj5 + 88;
		obj12 = obj11;
		obj7 = obj12;
		object obj13 = obj5 + 56;
		obj13 = 0;
		obj13 = 280f;
		_ = 226f;
		object obj14 = obj5 + 80;
		obj14 = obj13;
		obj7 = obj14;
		object obj15 = obj5 + 48;
		obj15 = 0;
		obj15 = 270f;
		_ = 280f;
		object obj16 = obj5 + 72;
		obj16 = obj15;
		obj7 = obj16;
		object obj17 = obj5 + 32;
		obj17 = 0;
		obj17 = 280f;
		_ = 292f;
		object obj18 = obj5 + 40;
		obj18 = obj17;
		obj7 = obj18;
		object obj19 = obj5 + 16;
		obj19 = 0;
		obj19 = 270f;
		_ = 305f;
		object obj20 = obj5 + 24;
		obj20 = obj19;
		obj7 = obj20;
		object obj21 = obj5 + 8;
		obj21 = 0;
		obj21 = 280f;
		_ = 317f;
		obj5 = obj21;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<SSEventCategory> list2 = default;
		list2._002Ector();
		list2.Add(SSEventCategory.None);
		list2.Add(SSEventCategory.Cat1);
		object obj22 = this + 232;
		obj22 = list2;
		((UpgradeScreen)(object)this).Start();
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
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0063: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_01aa: Expected I4, but got Obj
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_00f0: Expected I4, but got Obj
		//IL_00a4: Expected I, but got Obj
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
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v28 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v41 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("POPUP_TUTORIAL_COLLECT_FROM_FRIENDS_TITLE");
		_topTitle.fontSize = (int)text;
		object obj7 = this - -64;
		string text2 = Strings.GetDefault("POPUP_TUTORIAL_COLLECT_FROM_FRIENDS_BUTTON");
		((UILabel)obj7).fontSize = (int)text2;
		((UIGeometry)(object)_tutorialLinesHelper).WriteToBuffers((List<Vector3>)(object)"POPUP_TUTORIAL_COLLECT_FROM_FRIENDS_LINE1BIG", (List<Vector2>)(object)"POPUP_TUTORIAL_COLLECT_FROM_FRIENDS_LINE1SMALL", (List<Color>)(object)"POPUP_TUTORIAL_COLLECT_FROM_FRIENDS_LINE2BIG", (List<Vector3>)(object)"POPUP_TUTORIAL_COLLECT_FROM_FRIENDS_LINE2SMALL", (List<Vector4>)(object)"POPUP_TUTORIAL_COLLECT_FROM_FRIENDS_LINE3BIG", (List<Vector4>)(object)"POPUP_TUTORIAL_COLLECT_FROM_FRIENDS_LINE3SMALL");
	}

	public void CloseClicked()
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
		Flurry.LogClosePressedOnPopup((string)num3);
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

	public TutorialCollectFromFriendsPopup()
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
