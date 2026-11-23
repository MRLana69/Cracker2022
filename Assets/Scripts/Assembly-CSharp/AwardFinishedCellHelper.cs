using System;
using Cpp2ILInjected;
using Missions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AwardFinishedCellHelper : MonoBehaviour
{
	private const string AWARD_COMPLETE_DESCRIPTION_HEX_COLOR = "[549133]";

	private const string AWARD_COMPLETE_VALUE_HEX_COLOR = "[015A01]";

	private const string END_COLOR_SYMBOL = "[-]";

	private static readonly Color32 COMPLETED_TITLE_TEXT_COLOR = (Color32)(-16688639);

	private static readonly Color32 COMPLETED_TITLE_TEXT_SHADOW_COLOR = (Color32)(-1771288);

	private static readonly Color32 COMPLETE_SEGMENT_BACKGROUND_COLOR = (Color32)(-1266686062);

	private TMP_Text _missionTitle;

	private TMP_Text _missionTextDescription;

	private GameObject _missionIconsDescriptionParent;

	private Image _cellBackground;

	private AwardCollectibleHelper _mainGoalElementsHelper;

	private Image _mysteryBoxIcon;

	private TMP_Text _inMysteryBoxLabel;

	private AwardCollectibleHelper[] _goalIcons;

	private string[] _mysteryBoxIconNames;

	private const string COMPLETED_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed_small";

	private const string COMPLETED_GOAL_ICON_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed";

	private Award _currentAward;

	public void InitCell(Award award)
	{
		if (award != null)
		{
			_currentAward = award;
		}
		SetupCellStructure();
		SetupCellContent();
	}

	private void SetupCellStructure()
	{
		GameObject gameObject = _missionTextDescription.gameObject;
		Award currentAward = _currentAward;
		AwardStaticData awardStaticData = currentAward._awardStaticData;
		gameObject.SetActive(awardStaticData.hasDescription__BackingField);
		Award currentAward2 = _currentAward;
		AwardStaticData awardStaticData2 = currentAward2._awardStaticData;
		bool active = (byte)(~(awardStaticData2.hasDescription__BackingField ? 1u : 0u)) != 0;
		_missionIconsDescriptionParent.SetActive(active);
	}

	private void SetupCellContent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_043b: Expected I, but got Obj
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0467: Expected I4, but got Obj
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_04b2: Expected Obj, but got I4
		//IL_04d7: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_03b8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		Award currentAward = _currentAward;
		AwardTier awardActiveTier = currentAward._awardActiveTier;
		AwardGoal[] array = ((currentAward._awardActiveTier == null) ? null : awardActiveTier.listGoals__BackingField);
		TMP_Text missionTitle = _missionTitle;
		Award currentAward2 = _currentAward;
		AwardStaticData awardStaticData = currentAward2._awardStaticData;
		string text = Strings.Get(awardStaticData.title__BackingField);
		nint num = (nint)missionTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S2_v3 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		string text2 = ((AwardFinishedCellHelper)(object)_mainGoalElementsHelper).FindBackgroundToUse(true);
		_mainGoalElementsHelper.SetupAwardCollectible((string)(object)_mainGoalElementsHelper, "icon_gold_can", useGlitter: true, isItemCollected: true);
		Award currentAward3 = _currentAward;
		AwardStaticData awardStaticData2 = currentAward3._awardStaticData;
		if (~(awardStaticData2.hasDescription__BackingField ? 1u : 0u) != 0)
		{
			AwardFinishedCellHelper awardFinishedCellHelper = null;
			while (array.Length > (nint)awardFinishedCellHelper)
			{
				object obj3 = (object)awardFinishedCellHelper << 2;
				object obj4 = (object)_goalIcons + obj3;
				string text3 = awardFinishedCellHelper.FindBackgroundToUse(mainGoalIcon: false);
				object obj5 = (object)awardFinishedCellHelper << 2;
				object obj6 = (object)array + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S2_v33+10]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v94+10]");
				nint num2 = 0;
				AwardFinishedCellHelper backgroundToUse = awardFinishedCellHelper;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S2_v34+10]");
				((AwardCollectibleHelper)num2).SetupAwardCollectible((string)(object)backgroundToUse, (string)0, useGlitter: false, isItemCollected: true);
				AwardFinishedCellHelper awardFinishedCellHelper2 = (AwardFinishedCellHelper)(awardFinishedCellHelper + 1);
				awardFinishedCellHelper = awardFinishedCellHelper2;
			}
			Award currentAward4 = _currentAward;
			AwardStaticData awardStaticData3 = currentAward4._awardStaticData;
			bool flag = awardStaticData3.id__BackingField == AwardId.COLLECT_OLD_TROPHY_ITEMS_MB;
			AwardId awardId = awardStaticData3.id__BackingField;
			if (!flag)
			{
				if (awardStaticData3.id__BackingField != AwardId.COLLECT_OLD_TROPHY_ITEMS_SMB)
				{
					goto IL_037c;
				}
				awardId = AwardId.COLLECT_OLD_TROPHY_ITEMS_SMB;
			}
			object obj8 = (int)awardId << 2;
			object obj9 = (object)_mysteryBoxIconNames + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S2_v18+10]");
			string path = "UI/" + (string)0;
			Sprite sprite = Resources.Load<Sprite>(path);
			_mysteryBoxIcon.sprite = sprite;
			goto IL_037c;
		}
		TMP_Text missionTextDescription = _missionTextDescription;
		bool flag2 = (byte)(~(awardStaticData2.hasAnotherDescriptionForOneItemGoal__BackingField ? 1u : 0u)) != 0;
		AwardStaticData awardStaticData4 = awardStaticData2;
		object obj10;
		if (!flag2)
		{
			Award currentAward5 = _currentAward;
			AwardGoal awardGoal = array[0];
			bool flag3 = awardGoal.goal__BackingField != 1;
			awardStaticData4 = currentAward5._awardStaticData;
			if (!flag3)
			{
				obj10 = currentAward5._awardStaticData + 44;
				goto IL_045e;
			}
		}
		obj10 = awardStaticData4 + 20;
		goto IL_045e;
		IL_045e:
		string text4 = Strings.Get((StringID)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
		IL_037c:
		TMP_Text inMysteryBoxLabel = _inMysteryBoxLabel;
		string format = Strings.Get(StringID.AWARD_IN_MYSTERYBOX_TEXT);
		string text5 = string.Format(format, "[549133]", "[-]");
		nint num3 = (nint)inMysteryBoxLabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ S2_v28 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	private string FindBackgroundToUse(bool mainGoalIcon)
	{
		object result = "icon_award_bg_completed";
		if (!mainGoalIcon)
		{
			result = "icon_award_bg_completed_small";
		}
		return (string)result;
	}

	public AwardFinishedCellHelper()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		AwardCollectibleHelper[] goalIcons = default;
		_goalIcons = goalIcons;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	static AwardFinishedCellHelper()
	{
		//IL_000f: Expected VT, but got I4
		//IL_0019: Expected VT, but got I4
		//IL_0023: Expected VT, but got I4
	}
}
