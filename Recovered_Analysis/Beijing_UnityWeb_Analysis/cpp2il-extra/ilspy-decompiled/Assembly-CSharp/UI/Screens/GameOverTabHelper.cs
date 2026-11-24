using System;
using System.Collections;
using Cpp2ILInjected;
using Info;
using UnityEngine;

namespace UI.Screens;

public class GameOverTabHelper : MonoBehaviour
{
	private GameObject _leaderboardTabActive;

	private GameObject _leaderboardTabInactive;

	private UILabel _leaderboardTabLabel;

	private GameObject _toprunTabActive;

	private GameObject _toprunTabInactive;

	private UILabel _toprunTabLabel;

	private UISprite _toprunTabFlag;

	private const int TOPRUN_LABEL_PIXEL_OFFSET_X = 14;

	private const int TOPRUN_LABEL_PIXEL_OFFSET_Y = -2;

	private void Awake()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got VT
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got F4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_016a: Expected Obj, but got F4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got I
		//IL_01e1: Expected Obj, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj = this + 92;
		obj = "E";
		_ = 2;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<System.DateTime>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v52 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = DateTime.MinValue;
		object obj4 = obj3 + 8;
		obj4 = obj3;
		_ = 1;
		object obj5 = obj3 + 40;
		obj5 = 0;
		_ = 0;
		obj5 = 11f / 255f;
		_ = 42f / 255f;
		_ = 83f / 255f;
		_ = 1f;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v22+8]");
		_ = 0;
		object obj6 = this + 284;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+8]");
		_ = 0;
		object obj7 = obj3 + 24;
		obj7 = 0;
		_ = 0;
		obj7 = 1f;
		_ = 223f / 255f;
		_ = 12f / 255f;
		_ = 1f;
		obj4 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v34+8]");
		_ = 0;
		object obj8 = this + 300;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S3_v3+60]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj11 & 0x1FFF;
		object obj13 = obj12 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v134 @ S4_v4 (should have been resolved before IL gen)");
		object obj14 = this + 328;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72D5");
	}

	private void OnEnable()
	{
		TopRunTapped();
	}

	public void RefreshFlag()
	{
		LeaderboardTapped();
	}

	public void LeaderboardTapped()
	{
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01d6: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got F4
		//IL_018e: Expected VT, but got Obj
		//IL_00ef: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got F4
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v43 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 24;
		object obj4 = obj3 + 16;
		object obj5 = obj3 + 8;
		string text = Strings.GetDefault("HIGH_SCORES_TITLE");
		_leaderboardTabLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("TOPRUN_TITLE");
		_toprunTabLabel.fontSize = (int)text2;
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		IEnumerator enumerator = ((CountryPopup)(object)instance).DelayedSelect();
		UISprite toprunTabFlag = _toprunTabFlag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v22 (System.Collections.IEnumerator)+C]");
		toprunTabFlag.fillCenter = false;
		UIAnchor component = _toprunTabLabel.GetComponent<UIAnchor>();
		UISprite toprunTabFlag2 = _toprunTabFlag;
		if (toprunTabFlag2.mSpriteName != "")
		{
			obj4 = 0;
			obj4 = 0f;
			_ = -2f;
			obj5 = obj4;
			obj2 = obj5;
		}
		else
		{
			obj4 = 0;
			obj4 = 14f;
			_ = -2f;
			obj3 = obj4;
			obj2 = obj3;
		}
		component.pixelOffset = (Vector2)obj2;
	}

	public void TopRunTapped()
	{
		//IL_0016: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		LeaderboardTapped();
		_leaderboardTabActive.tag = (string)1;
		_leaderboardTabInactive.tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
		_toprunTabActive.tag = null;
		_toprunTabInactive.tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
	}

	private void SetLabelActive(UILabel label, bool isActive)
	{
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0126: Expected I4, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		//IL_0048: Expected Obj, but got I
		//IL_0058: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_007e: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		object obj = this + 276;
		GameObject gameObject = ((UpgradeScreen)this).MakeBuyable((UpgradeType)label, isActive);
		obj = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.GameOverTabHelper)+104]");
		UIWidget component = ((Component)0).GetComponent<UIWidget>();
		UIWidget uIWidget = default;
		Color color = uIWidget.color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.GameOverTabHelper)+F8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v13+14]");
		object obj3 = 0;
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.GameOverTabHelper)+F8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v16+14]");
		object obj5 = 0;
		_ = -9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.GameOverTabHelper)+FC]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+14]");
		object obj7 = 0;
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.GameOverTabHelper)+FC]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22+14]");
		object obj9 = 0;
		_ = -9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.GameOverTabHelper)+F8]");
		((UIRect)0).ParentHasChanged();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.GameOverTabHelper)+FC]");
		((UIRect)0).ParentHasChanged();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.GameOverTabHelper)+11A]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.GameOverTabHelper)+D8]");
			((GameOverLeaderboardHandler)0).ScrollToMyPosition();
		}
	}

	public GameOverTabHelper()
	{
		//IL_0027: Expected Obj, but got I4
		//IL_0046: Expected Obj, but got I4
		LeaderboardTapped();
		_leaderboardTabActive.tag = null;
		_leaderboardTabInactive.tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
		_toprunTabActive.tag = (string)1;
		_toprunTabInactive.tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
	}
}
