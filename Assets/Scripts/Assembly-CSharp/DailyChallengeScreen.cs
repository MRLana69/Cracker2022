using System;
using Cpp2ILInjected;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DailyChallengeScreen : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__11_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CAwake_003Eb__11_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("DailyChallengePopup");
		}
	}

	private DayHelper[] dayHelpers;

	private GameObject[] rewardIcons;

	private TMP_Text coinRewardLabel;

	private GameObject[] challengeActiveWidgets;

	private GameObject[] challengeCompletedWidgets;

	private TMP_Text collectLettersLabel;

	private TMP_Text nextChallengeLabel;

	private TMP_Text comeBackLabel;

	private TMP_Text mysteryBoxRewardLabel;

	private TMP_Text comeBackForMoreLabel;

	private Button CloseButton;

	private UIPopupIn UIPopupIn;

	private unsafe void Awake()
	{
		//IL_0135: Expected I, but got Obj
		//IL_000d: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		//IL_0066: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		TMP_Text tMP_Text = collectLettersLabel;
		string text = Strings.Get(StringID.DAILY_CHALLENGE_COLLECT);
		nint num = (nint)tMP_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v3 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = nextChallengeLabel;
		string text2 = Strings.Get(StringID.DAILY_CHALLENGE_NEXT_CHALLENGE);
		nint num2 = (nint)tMP_Text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text3 = comeBackLabel;
		string text3 = Strings.Get(StringID.DAILY_CHALLENGE_COME_BACK);
		nint num3 = (nint)tMP_Text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S2_v11 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text4 = mysteryBoxRewardLabel;
		string text4 = Strings.Get(StringID.DAILY_CHALLENGE_SUPER_MYSTERY_BOX);
		nint num4 = (nint)tMP_Text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S2_v15 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text5 = comeBackForMoreLabel;
		string text5 = Strings.Get(StringID.DAILY_CHALLENGE_COME_BACK_FOR_MORE);
		nint num5 = (nint)tMP_Text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S2_v19 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Button closeButton = CloseButton;
		bool flag = _003C_003Ec._003C_003E9__11_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__11_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__11_0));
			_003C_003Ec._003C_003E9__11_0 = unityAction;
			call = unityAction;
		}
		closeButton.m_OnClick.AddListener(call);
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(DailyChallengeScreen._003CAwake_003Eb__11_1));
		OutConplete.AddListener(unityAction2);
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<DailyChallengeScreen>)+104] (should have been resolved before IL gen)");
		int num2 = 0;
		while (true)
		{
			DayHelper[] array = dayHelpers;
			if (array.Length > num2)
			{
				int num3 = num2 << 2;
				object obj = array + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v9+10]");
				((DayHelper)0).Init(num2);
				int num4 = num2 + 1;
				num2 = num4;
				continue;
			}
			break;
		}
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
		RefreshDailyChallengeScreen();
	}

	private void GetComponent()
	{
		if (UIPopupIn == null)
		{
			UIPopupIn componentInChildren = GetComponentInChildren<UIPopupIn>();
			UIPopupIn = componentInChildren;
		}
	}

	private void ShowPopUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.IN);
	}

	public void HidePupUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.OUT);
	}

	private unsafe void RefreshDailyChallengeScreen()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03af: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Ref, but got Unknown
		//IL_003f: Expected Obj, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_033b: Expected Obj, but got I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected I4, but got Unknown
		//IL_024d: Expected I, but got Obj
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_0378: Expected Obj, but got I
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = 0;
		while (true)
		{
			DayHelper[] array = dayHelpers;
			if (array.Length <= (nint)obj3)
			{
				break;
			}
			object obj4 = obj3 << 2;
			object obj5 = (object)array + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v116+10]");
			((DayHelper)0).RefreshDay();
			object obj6 = obj3 + 1;
			obj3 = obj6;
		}
		PlayerInfo instance = PlayerInfo.Instance;
		int num = instance.GetDailyWordDaysInARow(out *(bool*)(obj + 47));
		if (num >= 5)
		{
			num = 5;
		}
		bool flag = num > 0;
		int num2 = num;
		if (!flag)
		{
			num2 = 0;
		}
		int num3 = num;
		object obj7 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			GameObject[] array2 = rewardIcons;
			if (array2.Length <= (nint)obj7)
			{
				break;
			}
			object obj8 = obj7 << 2;
			object obj9 = (object)array2 + obj8;
			nint num4 = 0;
			nint num5 = 0;
			IntPtr intPtr = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ S3_v9 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			num3 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v93+C]");
				if ((nint)0 <= (nint)num3)
				{
					break;
				}
				int num6 = num3 << 2;
				object obj10 = obj11 + num6;
				bool flag2 = num2 == (nint)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v101+10]");
				((Behaviour)0).enabled = flag2;
				int num7 = num3 + 1;
				num3 = num7;
			}
			obj7 = obj12 + 1;
		}
		int num8 = num2 << 4;
		object obj13 = DailyWord.REWARDS + num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v38+10]");
		if ((nint)0 == 0)
		{
			GameObject gameObject = coinRewardLabel.gameObject;
			gameObject.SetActive(value: true);
			DailyWord.DailyWordReward rewardForDay = DailyWord.GetRewardForDay(num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			TMP_Text tMP_Text = coinRewardLabel;
			object obj14 = obj + 24;
			int num9 = obj14 | 4;
			string text = ((int*)num9)->ToString();
			nint num10 = (nint)tMP_Text;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v268 @ S2_v26 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		else
		{
			int num11 = num2 << 4;
			object obj15 = DailyWord.REWARDS + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v72+10]");
			if ((nint)0 == 1)
			{
				GameObject gameObject2 = coinRewardLabel.gameObject;
				gameObject2.SetActive(value: false);
			}
		}
		object obj16 = 0;
		while (true)
		{
			GameObject[] array3 = challengeActiveWidgets;
			if (array3.Length <= (nint)obj16)
			{
				break;
			}
			object obj17 = obj16 << 2;
			object obj18 = (object)array3 + obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2F]");
			bool active = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v62+10]");
			((GameObject)0).SetActive(active);
			object obj19 = obj16 + 1;
			obj16 = obj19;
		}
		object obj20 = 0;
		while (true)
		{
			GameObject[] array4 = challengeCompletedWidgets;
			if (array4.Length > (nint)obj20)
			{
				object obj21 = obj20 << 2;
				object obj22 = (object)array4 + obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v57+10]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2F]");
				((GameObject)num12).SetActive(value: false);
				object obj23 = obj20 + 1;
				obj20 = obj23;
				continue;
			}
			break;
		}
	}

	public override void Hide()
	{
		base.Hide();
	}

	public DailyChallengeScreen()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		DayHelper[] array = default;
		dayHelpers = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] array2 = default;
		rewardIcons = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] array3 = default;
		challengeActiveWidgets = array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] array4 = default;
		challengeCompletedWidgets = array4;
		base._002Ector();
	}

	private void _003CAwake_003Eb__11_1()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<DailyChallengeScreen>)+EC] (should have been resolved before IL gen)");
	}
}
