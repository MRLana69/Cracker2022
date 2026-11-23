using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MissionPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__39_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CAwake_003Eb__39_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("MissionPopup");
		}
	}

	private sealed class _003C_changeMissionCheckboxes_003Ed__42(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public int delayFrames;

		public MissionPopup _003C_003E4__this;

		private int _003Cnum_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected Obj, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected Obj, but got Unknown
			MissionPopup missionPopup = _003C_003E4__this;
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_011c;
				}
				_003C_003E1__state = -1;
				num = _003Cnum_003E5__2;
			}
			else
			{
				_003Cnum_003E5__2 = 0;
				_003C_003E1__state = -1;
				num = 0;
			}
			if (num >= delayFrames)
			{
				object obj = missionPopup._currentMissions + 16;
				Image missionCheckBox = missionPopup.MissionCheckBox1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v10+24]");
				missionCheckBox.enabled = false;
				object obj2 = missionPopup._currentMissions + 56;
				Image missionCheckBox2 = missionPopup.MissionCheckBox2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v14+24]");
				missionCheckBox2.enabled = false;
				object obj3 = missionPopup._currentMissions + 96;
				Image missionCheckBox3 = missionPopup.MissionCheckBox3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v18+24]");
				missionCheckBox3.enabled = false;
				goto IL_011c;
			}
			_003C_003E2__current = null;
			int num2 = num + 1;
			_003Cnum_003E5__2 = num2;
			_003C_003E1__state = 1;
			return true;
			IL_011c:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private Image MissionCheckBox1;

	private Image MissionCheckBox2;

	private Image MissionCheckBox3;

	private TMP_Text MissionLabel1;

	private TMP_Text MissionLabel2;

	private TMP_Text MissionLabel3;

	private TMP_Text MissionNumber1;

	private TMP_Text MissionNumber2;

	private TMP_Text MissionNumber3;

	private UISlider missionProgressSlider;

	private TMP_Text progressLabel;

	private TMP_Text missionGoalLabel;

	private TMP_Text missionGoalLabelLine2;

	private Image MissionGoalSprite;

	private TMP_Text MissionSetLabel;

	private TMP_Text RewardExplanationLine1;

	private TMP_Text RewardExplanationLine2;

	private TMP_Text missionsDescriptionLabel;

	private TMP_Text rewardLabel;

	private Button CloseButton;

	private Slider MissionProgress1;

	private TMP_Text ProgressText1;

	private Slider MissionProgress2;

	private TMP_Text ProgressText2;

	private Slider MissionProgress3;

	private TMP_Text ProgressText3;

	private MissionInfo[] _cachedMissionInfo;

	private int _cachedMissionSet;

	private bool hasCached;

	private MissionInfo[] _currentMissions;

	private UIPopupIn UIPopupIn;

	private int oneOfEach
	{
		get
		{
			Game instance = Game.Instance;
			Variable<bool> isInGame = instance.IsInGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Variable`1<System.Boolean>)+8]");
			bool flag = (nint)0 == 0;
			int result = 5;
			if (!flag)
			{
				GameStats instance2 = GameStats.Instance;
				int num = 4;
				if (instance2._doubleMultiplierPickupsCollected == 0)
				{
					num = 5;
				}
				int num2 = num - 1;
				GameStats instance3 = GameStats.Instance;
				if (instance3._coinMagnetPickupsCollected == 0)
				{
					num2 = num;
				}
				int num3 = num2 - 1;
				GameStats instance4 = GameStats.Instance;
				if (instance4._superSneakerPickupsCollected == 0)
				{
					num3 = num2;
				}
				int num4 = num3 - 1;
				GameStats instance5 = GameStats.Instance;
				if (instance5._jetpackPickupsCollected == 0)
				{
					num4 = num3;
				}
				GameStats instance6 = GameStats.Instance;
				bool flag2 = instance6._pogoStickPickupsCollected == 0;
				result = num4;
				if (!flag2)
				{
					int num5 = num4 - 1;
					result = num5;
				}
			}
			return result;
		}
	}

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<MissionPopup>)+104] (should have been resolved before IL gen)");
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
		PlayerInfo instance = PlayerInfo.Instance;
		instance.CheckIfWeShouldRemoveProgressForDailyQuestInRow();
		RefreshContents();
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

	public override void Hide()
	{
		base.Hide();
	}

	private unsafe void Awake()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_000d: Expected I, but got Obj
		TMP_Text tMP_Text = missionsDescriptionLabel;
		string text = Strings.Get(StringID.MISSION_POPUP_DESCRIPTION);
		nint num = (nint)tMP_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v3 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = rewardLabel;
		string text2 = Strings.Get(StringID.MISSION_POPUP_REWARD);
		nint num2 = (nint)tMP_Text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Button closeButton = CloseButton;
		bool flag = _003C_003Ec._003C_003E9__39_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__39_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__39_0));
			_003C_003Ec._003C_003E9__39_0 = unityAction;
			call = unityAction;
		}
		closeButton.m_OnClick.AddListener(call);
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(MissionPopup._003CAwake_003Eb__39_1));
		OutConplete.AddListener(unityAction2);
	}

	private void MissionProgress(Slider slider, TMP_Text ProgressText, float max, float value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008f: Expected I, but got Obj
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0053: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		slider.minValue = 0f;
		slider.maxValue = max;
		nint num = (nint)slider;
		object obj3 = slider + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S2_v4 (Il2CppClass<UnityEngine.UI.Slider>)+234] (should have been resolved before IL gen)");
		object obj4 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object obj5 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		string text = $"{arg}/{arg2}";
		nint num2 = (nint)ProgressText;
		object obj6 = ProgressText + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ S2_v11 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	private unsafe void RefreshContents()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_018a: Expected F4, but got I
		//IL_018a: Expected F4, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_021d: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_025c: Expected I, but got Obj
		//IL_02a4: Expected F4, but got I
		//IL_02a4: Expected F4, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0332: Expected Obj, but got I
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0371: Expected I, but got Obj
		//IL_03b9: Expected F4, but got I
		//IL_03b9: Expected F4, but got I
		//IL_0101: Expected Obj, but got I4
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got Unknown
		//IL_05a2: Expected Obj, but got I4
		//IL_05ab: Expected Obj, but got I4
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected Obj, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected Obj, but got Unknown
		//IL_068a: Expected I, but got Obj
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Expected Obj, but got Unknown
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected I4, but got Unknown
		//IL_0940: Expected I, but got Obj
		//IL_0739: Expected Obj, but got I4
		//IL_075f: Expected Obj, but got I4
		//IL_098a: Expected I, but got Obj
		//IL_076d: Expected Obj, but got I4
		//IL_09ca: Expected I, but got Obj
		//IL_07a1: Expected Obj, but got I4
		//IL_07c7: Expected Obj, but got I4
		//IL_07d5: Expected Obj, but got I4
		//IL_082e: Expected Obj, but got I4
		//IL_07e2: Expected I, but got Obj
		//IL_07fe: Expected I, but got Obj
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected I4, but got Unknown
		//IL_0b39: Expected I, but got Obj
		//IL_0854: Expected Obj, but got I4
		//IL_087d: Expected I, but got Obj
		//IL_0862: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 272;
		_ = 0;
		MissionsManager instance = MissionsManager.Instance;
		MissionInfo[] missionInfo = instance.GetMissionInfo();
		_currentMissions = missionInfo;
		if (~(hasCached ? 1u : 0u) == 0)
		{
			object obj3 = 1;
			object obj4 = default;
			object obj13 = default;
			for (; (nint)obj4 < 3; obj4 = obj13 + 1)
			{
				object obj5 = obj4 * 40;
				object obj6 = (object)_cachedMissionInfo + obj5;
				object obj7 = obj4 * 40;
				object obj8 = (object)_currentMissions + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v174+30]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v151+30]");
				if (num == 0)
				{
					object obj9 = obj4 * 40;
					object obj10 = (object)_cachedMissionInfo + obj9;
					object obj11 = obj4 * 40;
					object obj12 = (object)_currentMissions + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v184+34]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v160+34]");
					if (num2 == 0)
					{
						continue;
					}
				}
				obj3 = 0;
			}
			MissionsManager instance2 = MissionsManager.Instance;
			PlayerInfo playerinfo = instance2.playerinfo;
			bool flag = _cachedMissionSet == playerinfo._currentMissionSet;
			object obj14 = obj3 & flag;
			if (obj14 != null)
			{
				return;
			}
		}
		MissionInfo[] currentMissions = _currentMissions;
		MissionInfo[] currentMissions2 = _currentMissions;
		Slider missionProgress = MissionProgress1;
		TMP_Text progressText = ProgressText1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S3_v4 (MissionInfo[])+14]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S4_v3 (MissionInfo[])+30]");
		((MissionPopup)null).MissionProgress(missionProgress, progressText, (float)num3, 0f);
		TMP_Text missionLabel = MissionLabel2;
		MissionInfo[] currentMissions3 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v20 (MissionInfo[])+40]");
		string format = Strings.Get(StringID.NULL);
		MissionInfo[] currentMissions4 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v14 (MissionInfo[])+3C]");
		_ = 0;
		object obj15 = obj + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		MissionInfo[] currentMissions5 = _currentMissions;
		MissionInfo[] currentMissions6 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v19 (MissionInfo[])+3C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S2_v8 (MissionInfo[])+58]");
		object obj16 = num4 - 0;
		object obj17 = obj + 260;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		string text = string.Format(format, arg, arg2);
		nint num5 = (nint)missionLabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ S2_v12 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		MissionInfo[] currentMissions7 = _currentMissions;
		MissionInfo[] currentMissions8 = _currentMissions;
		Slider missionProgress2 = MissionProgress2;
		TMP_Text progressText2 = ProgressText2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S3_v12 (MissionInfo[])+3C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S4_v9 (MissionInfo[])+58]");
		((MissionPopup)null).MissionProgress(missionProgress2, progressText2, (float)num6, 0f);
		TMP_Text missionLabel2 = MissionLabel3;
		MissionInfo[] currentMissions9 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v36 (MissionInfo[])+68]");
		string format2 = Strings.Get(StringID.NULL);
		MissionInfo[] currentMissions10 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v28 (MissionInfo[])+64]");
		_ = 0;
		object obj18 = obj + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		MissionInfo[] currentMissions11 = _currentMissions;
		MissionInfo[] currentMissions12 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v33 (MissionInfo[])+64]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S2_v18 (MissionInfo[])+80]");
		object obj19 = num7 - 0;
		object obj20 = obj + 252;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg3 = default;
		object arg4 = default;
		string text2 = string.Format(format2, arg3, arg4);
		nint num8 = (nint)missionLabel2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v263 @ S2_v22 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		MissionInfo[] currentMissions13 = _currentMissions;
		MissionInfo[] currentMissions14 = _currentMissions;
		Slider missionProgress3 = MissionProgress3;
		TMP_Text progressText3 = ProgressText3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S3_v20 (MissionInfo[])+64]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S4_v15 (MissionInfo[])+80]");
		((MissionPopup)null).MissionProgress(missionProgress3, progressText3, (float)num9, 0f);
		IEnumerator routine = _changeMissionCheckboxes(1);
		Coroutine coroutine = StartCoroutine(routine);
		hasCached = true;
		LabelAndNumberUpdate(MissionProgress1, ProgressText1, 0, MissionLabel1, MissionNumber1);
		LabelAndNumberUpdate(MissionProgress2, ProgressText2, 1, MissionLabel2, MissionNumber2);
		LabelAndNumberUpdate(MissionProgress3, ProgressText3, 2, MissionLabel3, MissionNumber3);
		object obj21 = obj + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE9");
		object obj22 = obj + 88;
		object obj23 = obj + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		object obj24 = obj + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1238");
		object obj25 = obj + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE9");
		object obj26 = obj + 48;
		object obj27 = obj + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		object obj28 = obj + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1238");
		object obj29 = obj + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE9");
		object obj30 = obj + 8;
		object obj31 = obj + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		object obj32 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1238");
		MissionsManager instance3 = MissionsManager.Instance;
		PlayerInfo playerinfo2 = instance3.playerinfo;
		_cachedMissionSet = playerinfo2._currentMissionSet;
		object obj33 = 0;
		object obj34 = 0;
		while ((nint)obj33 < 3)
		{
			object obj35 = obj34 + 1;
			object obj36 = obj33 * 40;
			object obj37 = (object)_currentMissions + obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S2_v106+34]");
			if ((nint)0 == 0)
			{
				obj35 = obj34;
			}
			object obj38 = obj33 + 1;
			obj33 = obj38;
			obj34 = obj35;
		}
		float value = (float)obj34 / 3f;
		missionProgressSlider.value = value;
		TMP_Text tMP_Text = progressLabel;
		object obj39 = obj + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = 1077936128;
		object obj40 = obj + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg5 = default;
		object arg6 = default;
		string text3 = $"{arg5}/{arg6}";
		nint num10 = (nint)tMP_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v459 @ S2_v56 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text missionSetLabel = MissionSetLabel;
		string text4 = Strings.Get(StringID.MISSION_POPUP_MISSION_SET_NUMBER);
		PlayerInfo instance4 = PlayerInfo.Instance;
		bool flag2 = instance4._missionCompletedSum == 0;
		bool flag3 = !flag2;
		int missionCompletedSum = instance4._missionCompletedSum;
		if (!flag3)
		{
			missionCompletedSum = (instance4._missionCompletedSum = instance4._currentMissionSet + 1);
		}
		int num11 = obj + 268;
		string text5 = ((int*)num11)->ToString();
		string text6 = text4 + " " + text5;
		nint num12 = (nint)missionSetLabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v508 @ S2_v62 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		PlayerInfo instance5 = PlayerInfo.Instance;
		object obj41 = instance5._currentMissionSet + 1;
		if ((nint)obj41 >= 30)
		{
			obj41 = 30;
		}
		if ((nint)obj41 <= 1)
		{
			obj41 = 1;
		}
		TMP_Text rewardExplanationLine = RewardExplanationLine1;
		bool flag4 = (nint)obj41 == 30;
		StringID key = StringID.MISSION_POPUP_SUPER;
		if (!flag4)
		{
			key = StringID.MISSION_POPUP_SCORE;
		}
		string text7 = Strings.Get(key);
		nint num13 = (nint)rewardExplanationLine;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v551 @ S2_v71 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text rewardExplanationLine2 = RewardExplanationLine2;
		StringID key2 = StringID.MISSION_POPUP_MYSTERY_BOX;
		if (!flag4)
		{
			key2 = StringID.MISSION_POPUP_MULTIPLIER;
		}
		string text8 = Strings.Get(key2);
		nint num14 = (nint)rewardExplanationLine2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v568 @ S2_v76 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		PlayerInfo instance6 = PlayerInfo.Instance;
		object obj42 = instance6._currentMissionSet + 1;
		if ((nint)obj42 >= 30)
		{
			obj42 = 30;
		}
		if ((nint)obj42 <= 1)
		{
			obj42 = 1;
		}
		TMP_Text tMP_Text2 = missionGoalLabel;
		if ((nint)obj42 == 30)
		{
			nint num15 = (nint)tMP_Text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v607 @ S2_v98 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text3 = missionGoalLabelLine2;
			nint num16 = (nint)tMP_Text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v621 @ S2_v101 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		else
		{
			PlayerInfo instance7 = PlayerInfo.Instance;
			object obj43 = instance7._currentMissionSet + 1;
			if ((nint)obj43 >= 30)
			{
				obj43 = 30;
			}
			if ((nint)obj43 <= 1)
			{
				obj43 = 1;
			}
			object obj44 = obj43 + 1;
			int num17 = obj + 268;
			string text9 = ((int*)num17)->ToString();
			string text10 = "x" + text9;
			nint num18 = (nint)tMP_Text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v676 @ S2_v91 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text4 = missionGoalLabelLine2;
			string text11 = Strings.Get(StringID.MISSION_POPUP_SCORE);
			nint num19 = (nint)tMP_Text4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v690 @ S2_v95 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		bool flag5 = (nint)obj42 == 30;
		MissionGoalSprite.enabled = flag5;
	}

	private IEnumerator _changeMissionCheckboxes(int delayFrames)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void LabelAndNumberUpdate(Slider slider, TMP_Text ProgressText, int missionArrayNr, TMP_Text sendMissionLabel, TMP_Text sendMissionNumber)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0541: Expected Obj, but got I4
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_056c: Expected Obj, but got I4
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_0597: Expected Obj, but got I4
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I4
		//IL_065f: Expected I4, but got Obj
		//IL_0671: Expected Obj, but got I4
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got I4
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_030c: Expected Obj, but got I4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0140: Expected Obj, but got I4
		//IL_05ef: Expected I4, but got Obj
		//IL_0601: Expected Obj, but got I4
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected Obj, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Obj, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0068: Expected I, but got Obj
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_008e: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00ff: Expected F4, but got I
		//IL_00ff: Expected F4, but got I
		//IL_00ff: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_0427: Expected I, but got Obj
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got Unknown
		//IL_044d: Expected Obj, but got I4
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0478: Expected Obj, but got I4
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_04be: Expected F4, but got I
		//IL_04be: Expected F4, but got I
		//IL_04be: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_037f: Expected Obj, but got I4
		//IL_04d1: Expected Obj, but got I4
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected I4, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_0185: Expected Obj, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_0510: Expected I, but got Obj
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected Obj, but got Unknown
		//IL_03c7: Expected I, but got Obj
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected Obj, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_02b6: Expected I, but got Obj
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_024c: Expected F8, but got I4
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected Obj, but got Unknown
		//IL_06f0: Expected I, but got Obj
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = missionArrayNr * 40;
		object obj4 = (object)_currentMissions + obj3;
		object obj5 = obj4 + 16;
		object obj6 = missionArrayNr * 40;
		object obj7 = (object)_currentMissions + obj6;
		object obj8 = obj7 + 16;
		object obj9 = missionArrayNr * 40;
		object obj10 = (object)_currentMissions + obj9;
		object obj11 = obj10 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+24]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+4]");
			bool flag = (nint)0 == 1;
			object obj12 = 20;
			if (!flag)
			{
				obj12 = 16;
			}
			object obj13 = obj8 + obj12;
			string format = Strings.Get((StringID)obj13);
			object obj14 = missionArrayNr * 40;
			object obj15 = (object)_currentMissions + obj14;
			object obj16 = obj15 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v80+4]");
			_ = 0;
			object obj17 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			string text = string.Format(format, arg);
			nint num = (nint)sendMissionLabel;
			object obj18 = sendMissionLabel + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ S2_v59 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			object obj19 = missionArrayNr * 40;
			object obj20 = (object)_currentMissions + obj19;
			object obj21 = obj20 + 16;
			object obj22 = missionArrayNr * 40;
			object obj23 = (object)_currentMissions + obj22;
			object obj24 = obj23 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S3_v50+4]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S4_v30+20]");
			((MissionPopup)missionArrayNr).MissionProgress(slider, ProgressText, num2, 0f);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+4]");
		bool flag2 = (nint)0 == 1;
		object obj25 = 12;
		if (!flag2)
		{
			obj25 = 8;
		}
		object obj26 = obj8 + obj25;
		string format2 = Strings.Get((StringID)obj26);
		object obj27 = missionArrayNr * 40;
		object obj28 = (object)_currentMissions + obj27;
		object obj29 = obj28 + 16;
		if ((nint)obj29 == 39)
		{
			UIScreenController instance = UIScreenController.Instance;
			string topScreenName = instance.GetTopScreenName();
			bool flag3 = topScreenName == "PauseUI";
			object obj30 = missionArrayNr * 40;
			object obj31 = (object)_currentMissions + obj30;
			object obj32 = obj31 + 16;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v70+4]");
				_ = 0;
				object obj33 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Game instance2 = Game.Instance;
				double num3 = instance2._elapsedGameDuration;
				double num4 = Math.Abs((double)instance2._elapsedGameDuration);
				if (!(num4 < 2147483648.0))
				{
					num3 = -2147483648.0;
				}
				object obj34 = obj + 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg2 = default;
				object arg3 = default;
				string text2 = string.Format(format2, arg2, arg3);
				nint num5 = (nint)sendMissionLabel;
				object obj35 = sendMissionLabel + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v410 @ S2_v48 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				hasCached = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v70+4]");
				_ = 0;
				object obj36 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				_ = 0;
				object obj37 = obj + 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg4 = default;
				object arg5 = default;
				string text3 = string.Format(format2, arg4, arg5);
				nint num6 = (nint)sendMissionLabel;
				object obj38 = sendMissionLabel + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v391 @ S2_v41 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			}
		}
		else
		{
			object obj39 = missionArrayNr * 40;
			object obj40 = (object)_currentMissions + obj39;
			object obj41 = obj40 + 16;
			object obj42 = missionArrayNr * 40;
			object obj43 = (object)_currentMissions + obj42;
			object obj44 = obj43 + 16;
			if ((nint)obj44 == 80)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v44+4]");
				_ = 0;
				object obj45 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				int num7 = ((MissionPopup)missionArrayNr).oneOfEach;
				object obj46 = obj + 4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg6 = default;
				object arg7 = default;
				string text4 = string.Format(format2, arg6, arg7);
				nint num8 = (nint)sendMissionLabel;
				object obj47 = sendMissionLabel + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ S2_v33 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v44+4]");
				_ = 0;
				object obj48 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg8 = default;
				string text5 = string.Format(format2, arg8);
				nint num9 = (nint)sendMissionLabel;
				object obj49 = sendMissionLabel + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ S2_v25 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				object obj50 = missionArrayNr * 40;
				object obj51 = (object)_currentMissions + obj50;
				object obj52 = obj51 + 16;
				object obj53 = missionArrayNr * 40;
				object obj54 = (object)_currentMissions + obj53;
				object obj55 = obj54 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S3_v18+4]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S4_v11+20]");
				((MissionPopup)missionArrayNr).MissionProgress(slider, ProgressText, num10, 0f);
			}
		}
		object obj56 = missionArrayNr + 1;
		int num11 = obj + 12;
		string text6 = ((int*)num11)->ToString();
		string text7 = text6 + string.Empty;
		nint num12 = (nint)sendMissionNumber;
		object obj57 = sendMissionNumber + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v381 @ S2_v16 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
	}

	public MissionPopup()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		MissionInfo[] cachedMissionInfo = default;
		_cachedMissionInfo = cachedMissionInfo;
		base._002Ector();
	}

	private void _003CAwake_003Eb__39_1()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<MissionPopup>)+EC] (should have been resolved before IL gen)");
	}
}
