using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;

public class TutorialHoverboardPopup : CharacterPopup
{
	private UILabel _calloutLabel;

	private UILabel _subtitleLabel;

	private Layout _labelLayout;

	private UILabel _buttonLabel;

	private GameObject _centerAnchor;

	private GameObject _tutorialMultiLinesPrefab;

	private TutorialMultilineLabelsHelper _tutorialLinesHelper;

	private string _hoverboardScreenType;

	private const int NUMBER_OF_FREE_HOVERBOARDS = 3;

	public override void Init()
	{
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
		object obj4 = this + 80;
		bool flag = ((UIModelController)(object)_centerAnchor).ExistsTransformModelInModelScreen((UIModelController.ModelScreen)_tutorialMultiLinesPrefab, transform);
		obj4 = flag;
	}

	public void OkClicked()
	{
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I4
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02d5: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0063: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_032c: Expected I4, but got Obj
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_00a4: Expected I, but got Obj
		//IL_03c4: Expected I4, but got Obj
		//IL_0276: Expected I4, but got Obj
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0228: Expected I, but got Obj
		//IL_0357: Expected I4, but got Obj
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_01cb: Expected I4, but got Obj
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_017d: Expected I, but got Obj
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v66 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("POPUP_TUTORIAL_HOVERBOARD_BUTTON");
		_buttonLabel.fontSize = (int)text;
		CollectCoinsDummy[] defaultDummyList = CollectCoinsDummyData.GetDefaultDummyList();
		int coinsSpawned = ((GameStats)(object)defaultDummyList).CoinsSpawned;
		bool flag = coinsSpawned == 0;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v39 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		bool flag2 = obj7 == null;
		List<Vector3> n;
		List<Color> c;
		if (flag)
		{
			if (!flag2)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v67 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("POPUP_TUTORIAL_HOVERBOARD_NEVER_USED_CALLOUT");
			_calloutLabel.fontSize = (int)text2;
			string text3 = Strings.GetDefault("POPUP_TUTORIAL_HOVERBOARD_NEVER_USED_SUBTITLE");
			_subtitleLabel.fontSize = (int)text3;
			object obj8 = this + 84;
			obj8 = "GuidelineHoverboardNeverUsed";
			n = (List<Vector3>)(object)"POPUP_TUTORIAL_HOVERBOARD_NEVER_USED_LINE2_SMALL";
			c = (List<Color>)(object)"POPUP_TUTORIAL_HOVERBOARD_NEVER_USED_LINE2_BIG";
		}
		else
		{
			if (!flag2)
			{
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v51 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault("POPUP_TUTORIAL_HOVERBOARD_NEVER_BOUGHT_CALLOUT");
			_calloutLabel.fontSize = (int)text4;
			string text5 = Strings.GetDefault("POPUP_TUTORIAL_HOVERBOARD_NEVER_BOUGHT_SUBTITLE");
			_subtitleLabel.fontSize = (int)text5;
			object obj9 = this + 84;
			obj9 = "GuidelineHoverboardNeverBought";
			n = (List<Vector3>)(object)"POPUP_TUTORIAL_HOVERBOARD_NEVER_BOUGHT_LINE2_SMALL";
			c = (List<Color>)(object)"POPUP_TUTORIAL_HOVERBOARD_NEVER_BOUGHT_LINE2_BIG";
		}
		object obj10 = this - -64;
		((RewardForVideoButton)obj10).Init((VideoButtonPayload)null);
		((UIGeometry)(object)_tutorialLinesHelper).WriteToBuffers((List<Vector3>)(object)"POPUP_TUTORIAL_HOVERBOARD_LINE1_BIG", (List<Vector2>)(object)"POPUP_TUTORIAL_HOVERBOARD_LINE1_SMALL", c, n, (List<Vector4>)(object)"POPUP_TUTORIAL_HOVERBOARD_LINE3_BIG", (List<Vector4>)(object)"POPUP_TUTORIAL_HOVERBOARD_LINE3_SMALL");
	}

	public void CloseClicked()
	{
		//IL_00f0: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I4
		//IL_0158: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		InventorySave.AddPendingReward((CelebrationReward)1, (Func<CelebrationRewardOrigin, int>)3);
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v18 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._ActivateNextPopup("ConsumablesPopup");
		string eventName = string.ConcatArray((string[])(object)"POPUP Screen ", (int)_hoverboardScreenType);
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v9 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v16 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry.LogClosePressedOnPopup(eventName);
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).ClosePopup((GameObject)(object)screenName);
	}

	public TutorialHoverboardPopup()
	{
		//IL_00f0: Expected Obj, but got I4
		//IL_00f0: Expected Obj, but got I4
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I4
		//IL_0158: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		InventorySave.AddPendingReward((CelebrationReward)1, (Func<CelebrationRewardOrigin, int>)3);
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v18 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._ActivateNextPopup("ConsumablesPopup");
		string apiKey = string.ConcatArray((string[])(object)"POPUP Screen ", (int)_hoverboardScreenType);
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v9 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v16 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry.StartSession(apiKey);
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).ClosePopup((GameObject)(object)screenName);
	}
}
