using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlideInMissionSetHelper : UISlideIn
{
	private TMP_Text line1;

	private TMP_Text lineReward;

	private Image superMysteryBox;

	private Image mysteryBox;

	private Image eggHuntIcon;

	private Image background;

	private Transform backgroundDark;

	private Image coinIcon;

	private TMP_Text coinLabel;

	private int _displayedMultiplier;

	private int _queuedMissionSetSlideIns;

	private bool _multiplierIsIncrementing;

	private int _missionsInStoryLineSet;

	private void Awake()
	{
		MissionsManager instance = MissionsManager.Instance;
		int missionSetStoryCount = instance.missionSetStoryCount;
		int missionsInStoryLineSet = missionSetStoryCount + 1;
		_missionsInStoryLineSet = missionsInStoryLineSet;
	}

	private int CalculateTheDisplayedMultiplierNumber(int multiplier)
	{
		//IL_0080: Expected Obj, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected I4, but got Unknown
		int num2;
		if (multiplier < _missionsInStoryLineSet)
		{
			UIScreenController instance = UIScreenController.Instance;
			int num = instance.NumberOfMissionSetSlideIns();
			_multiplierIsIncrementing = true;
			num2 = num;
		}
		else if (_displayedMultiplier == 0)
		{
			num2 = 0;
		}
		else
		{
			object obj = _displayedMultiplier + 1;
			int num3 = _missionsInStoryLineSet - obj;
			num2 = num3;
		}
		_queuedMissionSetSlideIns = num2;
		return multiplier - num2;
	}

	public unsafe void SetupSlideInMissionSet(int multiplier)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected I4, but got Unknown
		//IL_00e0: Expected I, but got Obj
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_01e1: Expected I, but got Obj
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_010f: Expected I, but got Obj
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		if (_displayedMultiplier == _missionsInStoryLineSet)
		{
			_multiplierIsIncrementing = false;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag = instance._missionCompletedSum == 0;
		bool flag2 = !flag;
		int num = instance._missionCompletedSum;
		if (!flag2)
		{
			num = (instance._missionCompletedSum = instance._currentMissionSet + 1);
		}
		object obj;
		if (_missionsInStoryLineSet < num && !_multiplierIsIncrementing)
		{
			superMysteryBox.enabled = true;
			obj = this + 60;
		}
		else
		{
			lineReward.enabled = true;
			int displayedMultiplier = CalculateTheDisplayedMultiplierNumber(multiplier);
			_displayedMultiplier = displayedMultiplier;
			TMP_Text tMP_Text = lineReward;
			int num2 = this + 92;
			string text = ((int*)num2)->ToString();
			string text2 = "x" + text;
			nint num3 = (nint)tMP_Text;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v120 @ S2_v18 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			obj = this - -64;
		}
		((Behaviour)obj).enabled = false;
		TMP_Text tMP_Text2 = line1;
		nint num4 = (nint)tMP_Text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		EnableCoinLabel(enable: false);
		eggHuntIcon.enabled = false;
		mysteryBox.enabled = false;
		nint num5 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ S2_v12 (Il2CppClass<UISlideInMissionSetHelper>)+E4] (should have been resolved before IL gen)");
	}

	public void SetupCoin()
	{
		//IL_005c: Expected I, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0079: Expected I, but got Obj
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		superMysteryBox.enabled = false;
		mysteryBox.enabled = false;
		lineReward.enabled = false;
		eggHuntIcon.enabled = false;
		EnableCoinLabel(enable: true);
		TMP_Text tMP_Text = line1;
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S2_v8 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		object obj2 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S2_v12 (Il2CppClass<UISlideInMissionSetHelper>)+E4] (should have been resolved before IL gen)");
	}

	public void SetupMysteryBox(MysteryBox.Type mysteryBoxType)
	{
		//IL_007b: Expected I, but got Obj
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0098: Expected I, but got Obj
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		lineReward.enabled = false;
		eggHuntIcon.enabled = false;
		EnableCoinLabel(enable: false);
		bool flag = mysteryBoxType == MysteryBox.Type.Super;
		superMysteryBox.enabled = flag;
		bool flag2 = mysteryBoxType != MysteryBox.Type.Super;
		mysteryBox.enabled = flag2;
		TMP_Text tMP_Text = line1;
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		object obj2 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S2_v14 (Il2CppClass<UISlideInMissionSetHelper>)+E4] (should have been resolved before IL gen)");
	}

	public unsafe void SetupEggHunt()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0076: Expected native int or pointer, but got VT
		//IL_008e: Expected native int or pointer, but got VT
		//IL_00b7: Expected I, but got Obj
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d4: Expected I, but got Obj
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		lineReward.enabled = false;
		superMysteryBox.enabled = false;
		mysteryBox.enabled = false;
		EnableCoinLabel(enable: false);
		eggHuntIcon.enabled = true;
		Transform transform = eggHuntIcon.transform;
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		_ = -4469822626901131264L;
		((Vector3*)(nint)vector)->x = -71f;
		transform.localPosition = vector;
		TMP_Text tMP_Text = line1;
		nint num = (nint)tMP_Text;
		object obj2 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S2_v9 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		object obj3 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S2_v13 (Il2CppClass<UISlideInMissionSetHelper>)+E4] (should have been resolved before IL gen)");
	}

	public unsafe void NewCoinAmount(int coinAmount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int num = obj + 12;
		string coinAmount2 = ((int*)num)->ToString();
		NewCoinAmount(coinAmount2);
	}

	public void NewCoinAmount(string coinAmount)
	{
		//IL_002f: Expected I, but got Obj
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		TMP_Text tMP_Text = coinLabel;
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		GameObject gameObject2 = base.gameObject;
		gameObject2.SetActive(value: false);
	}

	public void EnableCoinLabel(bool enable)
	{
		GameObject gameObject = coinIcon.gameObject;
		gameObject.SetActive(enable);
		GameObject gameObject2 = coinLabel.gameObject;
		gameObject2.SetActive(enable);
	}
}
