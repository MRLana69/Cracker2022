using System;
using Cpp2ILInjected;
using Info;
using Missions;
using SYBO.Subway.Info;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CelebrationPopupLabelTemplate : MonoBehaviour
{
	public TMP_Text bigLabel;

	public TMP_Text subLabel;

	private GameObject normalStateGO;

	private GameObject megaJackpotStateGO;

	private GameObject awardStateGO;

	private GameObject topRunStateGO;

	private GameObject characterEventStateGO;

	private GameObject doubleUpEventStateGO;

	private TMP_Text jackpotBigLabel;

	private TMP_Text jackpotSubLabel;

	private TMP_Text awardTopDescriptionLabel;

	private TMP_Text awardBigLabel;

	private TMP_Text awardBottomDescriptionLabel;

	private TMP_Text doubleUpTitleLabel;

	private TMP_Text doubleUpSubLabel;

	public TMP_Text doubleUpItemLabel;

	private TMP_Text doubleUpDescribtionLabel;

	private TMP_Text topRunTopDescriptionLabel;

	private TMP_Text topRunBigLabel;

	private TMP_Text topRunScore;

	private TMP_Text topRunWeekNr;

	private TMP_Text topRunCountry;

	private Image topRunCountryFlag;

	private TMP_Text topRunCheckMarkText;

	private TMP_Text characterEventWordNumber;

	private TMP_Text characterEventWord;

	public float Alpha
	{
		get
		{
			//IL_0017: Expected F4, but got I
			TMP_Text tMP_Text = bigLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (TMPro.TMP_Text)+C4]");
			return 0f;
		}
		set
		{
			float num = Math.Min(value, 1f);
			bool flag = value < 0f;
			float alpha = 0f;
			if (!flag)
			{
				alpha = num;
			}
			bigLabel.alpha = alpha;
		}
	}

	private void OnEnable()
	{
		normalStateGO.SetActive(value: false);
		megaJackpotStateGO.SetActive(value: false);
		awardStateGO.SetActive(value: false);
		topRunStateGO.SetActive(value: false);
		characterEventStateGO.SetActive(value: false);
		doubleUpEventStateGO.SetActive(value: false);
	}

	public void Init(int backgroundDepth)
	{
		GameObject gameObject = base.gameObject;
		UIPanel component = gameObject.GetComponent<UIPanel>();
		int depth = backgroundDepth + 1;
		component.depth = depth;
	}

	public void SetupPowerup(PowerupType powerup, int amount, bool doubled = false)
	{
		//IL_00b2: Expected I, but got Obj
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_0044: Expected I, but got Obj
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		normalStateGO.SetActive(value: true);
		float alpha = 1f;
		if (!doubled)
		{
			alpha = 0f;
		}
		Alpha = alpha;
		TMP_Text tMP_Text = bigLabel;
		string text = _GetPowerupLabel(powerup, amount);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = subLabel;
		Upgrade upgrade = Upgrades.upgrades.get_Item(powerup);
		string text2 = Strings.Get(upgrade.mysteryBoxDescription);
		nint num2 = (nint)tMP_Text2;
		object obj2 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S2_v13 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public void SetupCoins()
	{
		//IL_0032: Expected I, but got Obj
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_005c: Expected I, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		normalStateGO.SetActive(value: true);
		Alpha = 0f;
		TMP_Text tMP_Text = bigLabel;
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S2_v4 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = subLabel;
		nint num2 = (nint)tMP_Text2;
		object obj2 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S2_v8 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public void UpdateCoins(int amount, bool isMegaJackpot = false, bool doubled = false)
	{
		//IL_0166: Expected I, but got Obj
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0190: Expected I, but got Obj
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_003a: Expected I, but got Obj
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0064: Expected I, but got Obj
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_00e0: Expected I, but got Obj
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0118: Expected I, but got Obj
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		if (doubled)
		{
			megaJackpotStateGO.SetActive(value: false);
			TMP_Text tMP_Text = doubleUpItemLabel;
			string text = _GetCoinsLabel(amount);
			nint num = (nint)tMP_Text;
			object obj = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S2_v26 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text2 = subLabel;
			nint num2 = (nint)tMP_Text2;
			object obj2 = tMP_Text2 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S2_v30 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		else if (isMegaJackpot)
		{
			normalStateGO.SetActive(value: false);
			megaJackpotStateGO.SetActive(value: true);
			TMP_Text tMP_Text3 = jackpotBigLabel;
			string text2 = Strings.Get(StringID.CELEBRATION_LABEL_TEMPLATE_MEGA_JACKPOT);
			nint num3 = (nint)tMP_Text3;
			object obj3 = tMP_Text3 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ S2_v15 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text4 = jackpotSubLabel;
			string text3 = _GetCoinsLabel(amount);
			nint num4 = (nint)tMP_Text4;
			object obj4 = tMP_Text4 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ S2_v20 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		else
		{
			normalStateGO.SetActive(value: true);
			TMP_Text tMP_Text5 = bigLabel;
			string text4 = _GetCoinsLabel(amount);
			nint num5 = (nint)tMP_Text5;
			object obj5 = tMP_Text5 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v105 @ S2_v4 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text6 = subLabel;
			nint num6 = (nint)tMP_Text6;
			object obj6 = tMP_Text6 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ S2_v8 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
	}

	public void SetupKeys(int amount, bool doubled = false)
	{
		//IL_0064: Expected I, but got Obj
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_008e: Expected I, but got Obj
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		normalStateGO.SetActive(value: true);
		float alpha = 1f;
		if (!doubled)
		{
			alpha = 0f;
		}
		Alpha = alpha;
		TMP_Text tMP_Text = bigLabel;
		string text = _GetKeysLabel(amount);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = subLabel;
		nint num2 = (nint)tMP_Text2;
		object obj2 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public unsafe void SetupToken(Characters.CharacterType characterType, int amount, int tokensLeft, bool doubled = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected I4, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0183: Expected I, but got Obj
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0128: Expected I, but got Obj
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		normalStateGO.SetActive(value: true);
		float alpha = 1f;
		if (!doubled)
		{
			alpha = 0f;
		}
		Alpha = alpha;
		TMP_Text tMP_Text = bigLabel;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		Characters.Model model = Characters.characterData.get_Item(characterType);
		string text2 = text + "x " + model.tokenName;
		nint num2 = (nint)tMP_Text;
		object obj3 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S2_v9 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Characters.Model model2 = Characters.characterData.get_Item(characterType);
		TMP_Text tMP_Text2 = subLabel;
		if (tokensLeft >= 1)
		{
			string format = Strings.Get(StringID.CELEBRATION_POPUP_COLLECT_MORE_TOKENS);
			object obj4 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			string arg = Strings.Get(model2.name);
			object arg2 = default;
			string text3 = string.Format(format, arg2, arg);
			nint num3 = (nint)tMP_Text2;
			object obj5 = tMP_Text2 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ S2_v27 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		else
		{
			string format2 = Strings.Get(StringID.CELEBRATION_POPUP_YOU_UNLOCKED_TROPHY);
			string arg3 = Strings.Get(model2.name);
			string text4 = string.Format(format2, arg3);
			nint num4 = (nint)tMP_Text2;
			object obj6 = tMP_Text2 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ S2_v20 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
	}

	public void SetupTrophy(Trophies.Trophy trophy)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_004a: Expected I, but got Obj
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		normalStateGO.SetActive(value: true);
		Alpha = 0f;
		TMP_Text tMP_Text = bigLabel;
		string text = _GetTrophyLabel(trophy);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = subLabel;
		string text2 = Strings.Get(StringID.CELEBRATION_POPUP_TROPHY_SUBLABEL_TEXT);
		nint num2 = (nint)tMP_Text2;
		object obj2 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public void SetupMedal()
	{
		//IL_001b: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0045: Expected I, but got Obj
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		normalStateGO.SetActive(value: true);
		Alpha = 0f;
		TMP_Text tMP_Text = bigLabel;
		string text = Strings.Get(StringID.CELEBRATION_POPUP_MEDAL_BIG_LABEL);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = subLabel;
		nint num2 = (nint)tMP_Text2;
		object obj2 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S2_v9 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public void SetupCharacter(string charName)
	{
		//IL_0031: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_005b: Expected I, but got Obj
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		normalStateGO.SetActive(value: true);
		Alpha = 0f;
		TMP_Text tMP_Text = bigLabel;
		string format = Strings.Get(StringID.CELEBRATION_POPUP_CHARACTER_UNLOCK);
		string text = string.Format(format, charName);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = subLabel;
		nint num2 = (nint)tMP_Text2;
		object obj2 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public void SetupSpecialBoard(string boardName)
	{
		//IL_0031: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_005b: Expected I, but got Obj
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		normalStateGO.SetActive(value: true);
		Alpha = 0f;
		TMP_Text tMP_Text = bigLabel;
		string format = Strings.Get(StringID.CELEBRATION_POPUP_BOARD_UNLOCK);
		string text = string.Format(format, boardName);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = subLabel;
		nint num2 = (nint)tMP_Text2;
		object obj2 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public void SetupEventSpecialBoard(string boardName)
	{
		//IL_0031: Expected I, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_005b: Expected I, but got Obj
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		normalStateGO.SetActive(value: true);
		Alpha = 0f;
		TMP_Text tMP_Text = bigLabel;
		string format = Strings.Get(StringID.CELEBRATION_POPUP_EVENT_BOARD_TRYOUT);
		string text = string.Format(format, boardName);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v6 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = subLabel;
		nint num2 = (nint)tMP_Text2;
		object obj2 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public unsafe void SetupAward(string awardTitle, int rewardAmount, AwardTierType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_0067: Expected I, but got Obj
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0091: Expected I, but got Obj
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected I4, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		//IL_00f2: Expected I, but got Obj
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Alpha = 0f;
		object obj3 = type - 1;
		bool flag = (nint)obj3 <= 2;
		bool flag2 = !flag;
		string empty = string.Empty;
		if (!flag2)
		{
			StringID key = (StringID)(obj3 + 1019);
			string text = Strings.Get(key);
			empty = text;
		}
		normalStateGO.SetActive(value: false);
		awardStateGO.SetActive(value: true);
		topRunStateGO.SetActive(value: false);
		doubleUpEventStateGO.SetActive(value: false);
		TMP_Text tMP_Text = awardTopDescriptionLabel;
		nint num = (nint)tMP_Text;
		object obj4 = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = awardBigLabel;
		nint num2 = (nint)tMP_Text2;
		object obj5 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S2_v11 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text3 = awardBottomDescriptionLabel;
		int num3 = obj + 12;
		string text2 = ((int*)num3)->ToString();
		string text3 = "+" + text2 + " Keys!";
		nint num4 = (nint)tMP_Text3;
		object obj6 = tMP_Text3 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ S2_v16 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public void SetupTopRun(int score, int rank, int weekNumber)
	{
		Alpha = 0f;
		normalStateGO.SetActive(value: false);
		megaJackpotStateGO.SetActive(value: false);
		awardStateGO.SetActive(value: false);
		topRunStateGO.SetActive(value: false);
		characterEventStateGO.SetActive(value: false);
		doubleUpEventStateGO.SetActive(value: false);
		doubleUpEventStateGO.SetActive(value: false);
		topRunStateGO.SetActive(value: false);
		Transform transform = topRunCountryFlag.transform;
		GameObject gameObject = transform.gameObject;
		gameObject.SetActive(value: false);
		Transform transform2 = topRunCountry.transform;
		GameObject gameObject2 = transform2.gameObject;
		gameObject2.SetActive(value: false);
	}

	public void SetupDoubleUp(CelebrationReward reward)
	{
		//IL_0081: Expected I, but got Obj
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00be: Expected I, but got Obj
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_018c: Expected I, but got Obj
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_022d: Expected I, but got Obj
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_02ac: Expected I, but got Obj
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_01d8: Expected I, but got Obj
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		Alpha = 0f;
		normalStateGO.SetActive(value: false);
		megaJackpotStateGO.SetActive(value: false);
		topRunStateGO.SetActive(value: false);
		doubleUpEventStateGO.SetActive(value: true);
		GameObject gameObject = doubleUpDescribtionLabel.gameObject;
		gameObject.SetActive(value: false);
		doubleUpTitleLabel.fontSize = 30f;
		TMP_Text tMP_Text = doubleUpTitleLabel;
		string text = Strings.Get(StringID.DOUBLE_UP_CELEBRATION_SCREEN_TITLE);
		nint num = (nint)tMP_Text;
		object obj = tMP_Text + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = doubleUpSubLabel;
		string text2 = Strings.Get(StringID.DOUBLE_UP_CELEBRATION_SCREEN_SUBTITLE);
		nint num2 = (nint)tMP_Text2;
		object obj2 = tMP_Text2 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S2_v15 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		object obj3 = reward.rewardType - 1;
		if (reward.rewardType != CelebrationRewardType.coins)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 != 2 && (nint)obj3 == 3)
				{
					TMP_Text tMP_Text3 = doubleUpItemLabel;
					int amount = reward.amount << 1;
					string text3 = _GetKeysLabel(amount);
					nint num3 = (nint)tMP_Text3;
					object obj4 = tMP_Text3 + 528;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ S2_v43 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				}
			}
			else
			{
				TMP_Text tMP_Text4 = doubleUpItemLabel;
				int amount2 = reward.amount << 1;
				string text4 = _GetPowerupLabel(reward.powerupType, amount2);
				nint num4 = (nint)tMP_Text4;
				object obj5 = tMP_Text4 + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ S2_v28 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				GameObject gameObject2 = doubleUpDescribtionLabel.gameObject;
				gameObject2.SetActive(value: true);
				TMP_Text tMP_Text5 = doubleUpDescribtionLabel;
				Upgrade upgrade = Upgrades.upgrades.get_Item(reward.powerupType);
				string text5 = Strings.Get(upgrade.mysteryBoxDescription);
				nint num5 = (nint)tMP_Text5;
				object obj6 = tMP_Text5 + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ S2_v36 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			}
		}
		else
		{
			TMP_Text tMP_Text6 = doubleUpItemLabel;
			string text6 = _GetCoinsLabel(reward.amount);
			nint num6 = (nint)tMP_Text6;
			object obj7 = tMP_Text6 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S2_v21 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
	}

	public void SetupCharacterWordEvent(int wordNumber, string word)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003c: Expected Obj, but got VT
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got VT
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got VT
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected VT, but got Unknown
		//IL_0133: Expected Obj, but got VT
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0165: Expected Obj, but got VT
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01ba: Expected Obj, but got VT
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected VT, but got Unknown
		//IL_0214: Expected Obj, but got VT
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got VT
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_029b: Expected Obj, but got VT
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected VT, but got Unknown
		//IL_02fa: Expected Obj, but got VT
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_032c: Expected Obj, but got VT
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_0381: Expected Obj, but got VT
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected VT, but got Unknown
		//IL_03d6: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 144;
		_ = 0;
		Alpha = 0f;
		normalStateGO.SetActive(value: false);
		doubleUpEventStateGO.SetActive(value: false);
		characterEventStateGO.SetActive(value: true);
		object obj3 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_BLUE >> 16;
		object obj4 = obj3 & 0xFF;
		float num = (float)obj4 / 255f;
		object obj5 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_BLUE >> 24;
		float num2 = (float)obj5 / 255f;
		object obj6 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
		obj6 = 0;
		object obj7 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_BLUE & 0xFF;
		float num3 = (float)obj7 / 255f;
		object obj8 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_BLUE >> 8;
		object obj9 = obj8 & 0xFF;
		float num4 = (float)obj9 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Color c = (Color)(obj + 56);
		string text = NGUIText.EncodeColor(c);
		object obj10 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITE >> 16;
		object obj11 = obj10 & 0xFF;
		float num5 = (float)obj11 / 255f;
		object obj12 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITE >> 24;
		float num6 = (float)obj12 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		_ = 0;
		object obj13 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITE & 0xFF;
		float num7 = (float)obj13 / 255f;
		object obj14 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITE >> 8;
		object obj15 = obj14 & 0xFF;
		float num8 = (float)obj15 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Color c2 = (Color)(obj + 40);
		string text2 = NGUIText.EncodeColor(c2);
		object obj16 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_BLUESHADOW >> 16;
		object obj17 = obj16 & 0xFF;
		float num9 = (float)obj17 / 255f;
		object obj18 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_BLUESHADOW >> 24;
		float num10 = (float)obj18 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		object obj19 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_BLUESHADOW & 0xFF;
		float num11 = (float)obj19 / 255f;
		object obj20 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_BLUESHADOW >> 8;
		object obj21 = obj20 & 0xFF;
		float num12 = (float)obj21 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Color c3 = (Color)(obj + 24);
		string text3 = NGUIText.EncodeColor(c3);
		object obj22 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITESHADOW >> 16;
		object obj23 = obj22 & 0xFF;
		float num13 = (float)obj23 / 255f;
		object obj24 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITESHADOW >> 24;
		float num14 = (float)obj24 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		object obj25 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITESHADOW & 0xFF;
		float num15 = (float)obj25 / 255f;
		object obj26 = GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITESHADOW >> 8;
		object obj27 = obj26 & 0xFF;
		float num16 = (float)obj27 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Color c4 = (Color)(obj + 8);
		string text4 = NGUIText.EncodeColor(c4);
		string eventLabelPrefix = ((CelebrationPopupLabelTemplate)GlobalColors.CHARACTERWORDEVENT_CELEBRATION_WHITESHADOW).GetEventLabelPrefix();
		TMP_Text tMP_Text = characterEventWordNumber;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private string GetEventLabelPrefix()
	{
		//IL_003d: Expected Obj, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected I4, but got Unknown
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		CharacterNameEventManager characterNameEventManager = default;
		StringID key;
		if (characterNameEventManager != null)
		{
			SSEventCategory eventCategory = characterNameEventManager.GetEventCategory();
			object obj = eventCategory - 1;
			key = (StringID)(obj + 1260);
			if ((nint)obj >= 3)
			{
				key = StringID.CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1;
			}
		}
		else
		{
			key = StringID.CELEBRATION_LABEL_TEMPLATE_CHARACTEREVENT_PART1;
		}
		return Strings.Get(key);
	}

	private unsafe string _GetPowerupLabel(PowerupType type, int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		string text2 = string.Empty + text + "x ";
		Upgrade upgrade = Upgrades.upgrades.get_Item(type);
		StringID key = upgrade.GetName();
		string text3 = Strings.Get(key);
		return text2 + text3;
	}

	private string _GetTrophyLabel(Trophies.Trophy trophy)
	{
		TrophyData trophyData = Trophies.trophyData.get_Item(trophy);
		return Strings.Get(trophyData.name);
	}

	private string _GetCoinsLabel(int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		string format = Strings.Get(StringID.CELEBRATION_POPUP_COINS_AMOUNT);
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg2 = default;
		string arg = $"{arg2:#,###0}";
		return string.Format(format, arg);
	}

	private unsafe string _GetKeysLabel(int amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		bool flag = amount < 2;
		StringID key = StringID.CELEBRATION_POPUP_KEY_AMOUNT;
		if (!flag)
		{
			key = StringID.CELEBRATION_POPUP_KEYS_AMOUNT;
		}
		string format = Strings.Get(key);
		int num = obj + 12;
		string arg = ((int*)num)->ToString();
		return string.Format(format, arg);
	}
}
