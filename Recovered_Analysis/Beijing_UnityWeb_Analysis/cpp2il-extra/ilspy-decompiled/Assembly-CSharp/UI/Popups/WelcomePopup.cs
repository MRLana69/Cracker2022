using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using Info.VideoRewardCooldowns;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class WelcomePopup : CharacterPopup
{
	private UILabel _calloutLabel;

	private UILabel _buttonText;

	private UISprite _calloutBackgroundSprite;

	private UISprite _calloutBackgroundTriangleSprite;

	private GameObject _centerAnchor;

	private GameObject _tutorialMultiLinesPrefab;

	private TutorialMultilineLabelsHelper _tutorialLinesHelper;

	public override void Init()
	{
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
		object obj4 = this + 80;
		bool flag = ((UIModelController)(object)_centerAnchor).ExistsTransformModelInModelScreen((UIModelController.ModelScreen)_tutorialMultiLinesPrefab, transform);
		obj4 = flag;
	}

	public unsafe override void GainFocus()
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0135: Expected Obj, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I4
		//IL_0161: Expected Obj, but got F4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected VT, but got Unknown
		//IL_017e: Expected VT, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected VT, but got Unknown
		//IL_01a7: Expected F4, but got Obj
		//IL_01a2: Expected native int or pointer, but got VT
		//IL_01af: Expected native int or pointer, but got VT
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got VT
		//IL_0035: Expected F4, but got Obj
		//IL_0030: Expected native int or pointer, but got VT
		//IL_005a: Expected I, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_01e0: Expected I4, but got Obj
		//IL_00e9: Expected I4, but got Obj
		//IL_009b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		_ = 0;
		((UIScreen)this).Hide();
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj3 = 43f;
		_ = 5f;
		Vector2? vector = (Vector2?)(object)(obj2 + 16);
		vector = (Vector2?)(object)0;
		_ = 0;
		obj2 = obj3;
		Vector2 vector2 = (Vector2)(obj2 - -64);
		((Vector2*)(nint)vector2)->x = (float)obj2;
		*(Vector2?*)(nint)vector = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj4 = obj2 + 48;
		obj4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17 (System.Nullable`1<UnityEngine.Vector2>)+8]");
		_ = 0;
		((Vector2*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8B9F");
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v32 (Il2CppClass<Strings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v45 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("POPUP_WELCOME_TITLE_LINE_1");
		_calloutLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("OK");
		_buttonText.fontSize = (int)text2;
		((UIGeometry)(object)_tutorialLinesHelper).WriteToBuffers((List<Vector3>)(object)"POPUP_WELCOME_LINE1BIG", (List<Vector2>)(object)"POPUP_WELCOME_LINE1SMALL", (List<Color>)(object)"POPUP_WELCOME_LINE2BIG", (List<Vector3>)(object)"POPUP_WELCOME_LINE2SMALL", (List<Vector4>)(object)"POPUP_WELCOME_LINE3BIG", (List<Vector4>)(object)"POPUP_WELCOME_LINE3SMALL");
		this._002Ector();
	}

	public override void LoseFocus()
	{
		base.OnDisable();
	}

	public void OkClicked()
	{
		ShowCharacter();
	}

	public void UpdateColors()
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

	public unsafe WelcomePopup()
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected I4, but got Unknown
		//IL_019a: Expected I4, but got Obj
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0082: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00dc: Expected I4, but got Obj
		object obj = this - -64;
		nint num = (nint)typeof(WelcomePopupTheme);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Info.WelcomePopupTheme>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WelcomePopupTheme);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v27 (Il2CppClass<Info.WelcomePopupTheme>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 32;
		CooldownManager instance = CooldownManager.instance;
		object obj5 = instance + 12;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v5+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj4 + 48);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10+8]");
		_ = 0;
		((UIWidget)obj).rawPivot = pivot;
		object obj6 = obj4 + 16;
		CooldownManager instance2 = CooldownManager.instance;
		object obj7 = instance2 + 12;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S2_v18+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v17+8]");
		_ = 0;
		_calloutBackgroundTriangleSprite.rawPivot = pivot;
		CooldownManager instance3 = CooldownManager.instance;
		object obj8 = instance3 + 28;
		obj4 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S2_v29+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_calloutLabel.rawPivot = pivot;
	}
}
