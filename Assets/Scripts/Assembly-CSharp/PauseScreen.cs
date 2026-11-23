using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Characters;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PauseScreen : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__43_0;

		public static UnityAction _003C_003E9__43_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CAwake_003Eb__43_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.QueuePopup("HomeConfirmationPopup");
		}

		internal void _003CAwake_003Eb__43_1()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.PushPopup("SettingsPopup");
		}
	}

	private Button ResumeButton;

	private Button HomeButton;

	private Button SettingButton;

	private GameObject[] rewardIcons;

	private TMP_Text coinRewardLabel;

	private Image coinRewardSprite;

	private GameObject[] challengeActiveWidgets;

	private GameObject[] challengeCompletedWidgets;

	private GameObject dailyWordActiveGameObject;

	private GameObject dailyWordCompletedGameObject;

	private GameObject dailyWordRewardsGameObject;

	private ResumeButtonHelper resumeBtnHelper;

	private Image resumeButtonFill;

	private TMP_Text collectLettersLabel;

	private TMP_Text nextChallengeLable;

	private TMP_Text comeBackLabel;

	private GameObject _dailyBubbleSprite;

	public static bool PauseScreenIsShown;

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

	private Image MissionGoalSprite;

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
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Expected Obj, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected Obj, but got Unknown
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Expected Obj, but got Unknown
			//IL_0326: Unknown result type (might be due to invalid IL or missing references)
			//IL_032b: Expected Obj, but got Unknown
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Expected Obj, but got Unknown
			//IL_02c4: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			_ = 0;
			object obj3 = obj + 16;
			GameStats instance = GameStats.Instance;
			Dictionary<PowerupType, bool>.KeyCollection keys = instance._missionEachPowerupPickupStatus.Keys;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = default;
			object obj7;
			object obj8 = default;
			int result = default;
			int num = default;
			object obj9 = default;
			object obj10 = default;
			int num2 = default;
			int num3 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					bool flag = obj6 == null;
					obj7 = obj;
					if (flag)
					{
						break;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj8 == null)
								{
									result = num + 1;
								}
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj9 == obj10;
				bool flag3 = !flag2;
				int result2 = num2;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 != 1;
					obj7 = obj;
					if (flag4)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result2 = num3;
				}
				_ = 0;
				object obj11 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj7 = 0;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result2;
			}
			object obj12 = obj7 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A31C");
			return result;
		}
	}

	private unsafe void Awake()
	{
		//IL_0132: Expected I, but got Obj
		//IL_000d: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		TMP_Text tMP_Text = collectLettersLabel;
		string text = Strings.Get(StringID.PAUSE_UI_COLLECT_LETTERS);
		nint num = (nint)tMP_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v3 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text2 = nextChallengeLable;
		string text2 = Strings.Get(StringID.PAUSE_UI_NEXT_CHALLENGE);
		nint num2 = (nint)tMP_Text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S2_v7 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text3 = comeBackLabel;
		string text3 = Strings.Get(StringID.PAUSE_UI_COME_BACK);
		nint num3 = (nint)tMP_Text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S2_v11 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Button homeButton = HomeButton;
		bool flag = _003C_003Ec._003C_003E9__43_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__43_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__43_0));
			_003C_003Ec._003C_003E9__43_0 = unityAction;
			call = unityAction;
		}
		homeButton.m_OnClick.AddListener(call);
		Button settingButton = SettingButton;
		bool flag3 = _003C_003Ec._003C_003E9__43_1 == null;
		bool flag4 = !flag3;
		UnityAction call2 = _003C_003Ec._003C_003E9__43_1;
		if (!flag4)
		{
			UnityAction unityAction2 = default;
			unityAction2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__43_1));
			_003C_003Ec._003C_003E9__43_1 = unityAction2;
			call2 = unityAction2;
		}
		settingButton.m_OnClick.AddListener(call2);
		Button resumeButton = ResumeButton;
		UnityAction unityAction3 = default;
		unityAction3._002Ector(this, (nint)__ldftn(PauseScreen._003CAwake_003Eb__43_2));
		resumeButton.m_OnClick.AddListener(unityAction3);
		UnityAction unityAction4 = default;
		unityAction4._002Ector(this, (nint)__ldftn(PauseScreen._003CAwake_003Eb__43_3));
		OutConplete.AddListener(unityAction4);
	}

	public override void Show()
	{
		//IL_00cd: Expected F8, but got I4
		//IL_00e9: Expected I4, but got F8
		base.Show();
		ShowPopUp();
		Game instance = Game.Instance;
		if (instance != null)
		{
			Game instance2 = Game.Instance;
			instance2.TriggerPause(pauseGame: true);
			float time = Time.time;
			Character instance3 = Character.Instance;
			double num = (double)time - (double)instance3.sameLaneTimeStamp;
			double num2 = Math.Abs(num);
			if (!(num2 < 2147483648.0))
			{
				num = -2147483648.0;
			}
			Character instance4 = Character.Instance;
			float time2 = Time.time;
			instance4.sameLaneTimeStamp = time2;
			MissionsManager instance5 = MissionsManager.Instance;
			instance5.PlayerDidThis(MissionTarget.StayInOneLane, (int)num);
		}
		RefreshDailyChallenge();
		_UpdateMissions();
		if (resumeBtnHelper != null)
		{
			resumeBtnHelper.EnableButton();
		}
		PauseScreenIsShown = true;
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
		PauseScreenIsShown = false;
	}

	private void Update()
	{
		//IL_006b: Expected I, but got Obj
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			UIScreenController instance = UIScreenController.Instance;
			if (instance.CurrenScreen == SCREEN.Pause)
			{
				UIScreenController instance2 = UIScreenController.Instance;
				instance2.PushScreen("IngameUI");
				UIButtonMessageCenter componentInChildren = GetComponentInChildren<UIButtonMessageCenter>();
				nint num = (nint)componentInChildren;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S1_v10 (Il2CppClass<UIButtonMessageCenter>)+F4] (should have been resolved before IL gen)");
			}
		}
	}

	public override void AdjustToResolution()
	{
		UIScreenController instance = UIScreenController.Instance;
		bool flag = instance.root == null;
	}

	private unsafe void RefreshDailyChallenge()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Ref, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0314: Expected Obj, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected I4, but got Unknown
		//IL_0209: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_02d6: Expected Obj, but got I
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_0349: Expected Obj, but got I
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		dailyWordActiveGameObject.SetActive(value: true);
		dailyWordCompletedGameObject.SetActive(value: true);
		dailyWordRewardsGameObject.SetActive(value: true);
		PlayerInfo instance = PlayerInfo.Instance;
		int num = instance.GetDailyWordDaysInARow(out *(bool*)(obj + 47));
		if (num >= 5)
		{
			num = 5;
		}
		if (num <= 0)
		{
			num = 0;
		}
		object obj3 = default;
		object obj9 = default;
		object obj11 = default;
		while (true)
		{
			GameObject[] array = rewardIcons;
			if (array.Length <= (nint)obj3)
			{
				break;
			}
			object obj4 = obj3 << 2;
			object obj5 = (object)array + obj4;
			nint num2 = 0;
			nint num3 = 0;
			IntPtr intPtr = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v124 @ S3_v9 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			object obj6 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v103+C]");
				if (0 <= (nint)obj6)
				{
					break;
				}
				object obj7 = obj6 << 2;
				object obj8 = obj9 + obj7;
				bool flag = num == (nint)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v111+10]");
				((Behaviour)0).enabled = flag;
				object obj10 = obj6 + 1;
				obj6 = obj10;
			}
			obj3 = obj11 + 1;
		}
		int num4 = num << 4;
		object obj12 = DailyWord.REWARDS + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v38+10]");
		if ((nint)0 == 0)
		{
			coinRewardLabel.enabled = true;
			coinRewardSprite.enabled = true;
			TMP_Text tMP_Text = coinRewardLabel;
			DailyWord.DailyWordReward rewardForDay = DailyWord.GetRewardForDay(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj13 = obj + 24;
			int num5 = obj13 | 4;
			string text = ((int*)num5)->ToString();
			nint num6 = (nint)tMP_Text;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v264 @ S2_v31 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		else
		{
			int num7 = num << 4;
			object obj14 = DailyWord.REWARDS + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v79+10]");
			if ((nint)0 == 1)
			{
				coinRewardLabel.enabled = false;
				coinRewardSprite.enabled = false;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2F]");
		bool active = (nint)0 == 0;
		object obj15 = 0;
		while (true)
		{
			GameObject[] array2 = challengeActiveWidgets;
			if (array2.Length <= (nint)obj15)
			{
				break;
			}
			object obj16 = obj15 << 2;
			object obj17 = (object)array2 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v69+10]");
			((GameObject)0).SetActive(active);
			object obj18 = obj15 + 1;
			obj15 = obj18;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2F]");
		bool active2 = (nint)0 != 0;
		object obj19 = 0;
		while (true)
		{
			GameObject[] array3 = challengeCompletedWidgets;
			if (array3.Length <= (nint)obj19)
			{
				break;
			}
			object obj20 = obj19 << 2;
			object obj21 = (object)array3 + obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v64+10]");
			((GameObject)0).SetActive(active2);
			object obj22 = obj19 + 1;
			obj19 = obj22;
		}
		_dailyBubbleSprite.SetActive(value: true);
	}

	private void DisableDailyChallenge()
	{
		dailyWordActiveGameObject.SetActive(value: false);
		dailyWordCompletedGameObject.SetActive(value: false);
		dailyWordRewardsGameObject.SetActive(value: false);
	}

	private unsafe void ResetTransform(Transform trans, Vector3 newPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected VT, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected VT, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected VT, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_01cb: Expected native int or pointer, but got VT
		//IL_01dd: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		_ = newPosition.z;
		_ = newPosition.x;
		Vector3 position = vector - -64;
		trans.position = position;
		Vector3 localPosition = trans.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		float num = 0f + positionOffset.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
		float num2 = 0f + positionOffset.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		float num3 = 0f + positionOffset.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Vector3 localPosition2 = vector + 48;
		trans.localPosition = localPosition2;
		float num4 = newRotation.x * ((float)Math.PI / 180f);
		float num5 = newRotation.y * ((float)Math.PI / 180f);
		float num6 = newRotation.z * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 euler = vector + 32;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		trans.localRotation = localRotation;
		((Vector3*)(nint)vector)->z = newScale.z;
		((Vector3*)(nint)vector)->x = newScale.x;
		trans.localScale = vector;
	}

	public void FetchingTopRunDataTimedOut()
	{
		RefreshDailyChallenge();
	}

	private unsafe void _UpdateMissions()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01ca: Expected F4, but got I
		//IL_01ca: Expected F4, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_029c: Expected I, but got Obj
		//IL_02e4: Expected F4, but got I
		//IL_02e4: Expected F4, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0372: Expected Obj, but got I
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_03b1: Expected I, but got Obj
		//IL_03f9: Expected F4, but got I
		//IL_03f9: Expected F4, but got I
		//IL_0141: Expected Obj, but got I4
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Obj, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected Obj, but got Unknown
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected Obj, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected Obj, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_060a: Expected Obj, but got I4
		//IL_0613: Expected Obj, but got I4
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected Obj, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected Obj, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected Obj, but got Unknown
		//IL_06f2: Expected I, but got Obj
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected Obj, but got Unknown
		//IL_071d: Expected Obj, but got I4
		//IL_0743: Expected Obj, but got I4
		//IL_0751: Expected Obj, but got I4
		//IL_0785: Expected Obj, but got I4
		//IL_07c6: Expected I, but got Obj
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected Obj, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected I4, but got Unknown
		//IL_07ab: Expected Obj, but got I4
		//IL_07b9: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 256;
		_ = 0;
		MissionsManager instance = MissionsManager.Instance;
		MissionInfo[] missionInfo = instance.GetMissionInfo();
		_currentMissions = missionInfo;
		if (~(hasCached ? 1u : 0u) == 0)
		{
			object obj3 = 1;
			object obj4 = default;
			object obj15 = default;
			for (; (nint)obj4 < 3; obj4 = obj15 + 1)
			{
				object obj5 = obj4 * 40;
				object obj6 = (object)_cachedMissionInfo + obj5;
				object obj7 = obj4 * 40;
				object obj8 = (object)_currentMissions + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v132+30]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v133+30]");
				if (num == 0)
				{
					object obj9 = obj4 * 40;
					object obj10 = (object)_cachedMissionInfo + obj9;
					object obj11 = obj4 * 40;
					object obj12 = (object)_currentMissions + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v142+34]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v142+34]");
					if (num2 == 0)
					{
						object obj13 = obj4 * 40;
						object obj14 = (object)_currentMissions + obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v147+10]");
						if ((nint)0 != 80)
						{
							continue;
						}
					}
				}
				obj3 = 0;
			}
			MissionsManager instance2 = MissionsManager.Instance;
			PlayerInfo playerinfo = instance2.playerinfo;
			bool flag = _cachedMissionSet == playerinfo._currentMissionSet;
			object obj16 = obj3 & flag;
			if (obj16 != null)
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
		((PauseScreen)null).MissionProgress(missionProgress, progressText, (float)num3, 0f);
		TMP_Text missionLabel = MissionLabel2;
		MissionInfo[] currentMissions3 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v20 (MissionInfo[])+40]");
		string format = Strings.Get(StringID.NULL);
		MissionInfo[] currentMissions4 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v14 (MissionInfo[])+3C]");
		_ = 0;
		object obj17 = obj + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		MissionInfo[] currentMissions5 = _currentMissions;
		MissionInfo[] currentMissions6 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v19 (MissionInfo[])+3C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S2_v8 (MissionInfo[])+58]");
		object obj18 = num4 - 0;
		object obj19 = obj + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		string text = string.Format(format, arg, arg2);
		nint num5 = (nint)missionLabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ S2_v12 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		MissionInfo[] currentMissions7 = _currentMissions;
		MissionInfo[] currentMissions8 = _currentMissions;
		Slider missionProgress2 = MissionProgress2;
		TMP_Text progressText2 = ProgressText2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S3_v12 (MissionInfo[])+3C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S4_v9 (MissionInfo[])+58]");
		((PauseScreen)null).MissionProgress(missionProgress2, progressText2, (float)num6, 0f);
		TMP_Text missionLabel2 = MissionLabel3;
		MissionInfo[] currentMissions9 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v36 (MissionInfo[])+68]");
		string format2 = Strings.Get(StringID.NULL);
		MissionInfo[] currentMissions10 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v28 (MissionInfo[])+64]");
		_ = 0;
		object obj20 = obj + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		MissionInfo[] currentMissions11 = _currentMissions;
		MissionInfo[] currentMissions12 = _currentMissions;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v33 (MissionInfo[])+64]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S2_v18 (MissionInfo[])+80]");
		object obj21 = num7 - 0;
		object obj22 = obj + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg3 = default;
		object arg4 = default;
		string text2 = string.Format(format2, arg3, arg4);
		nint num8 = (nint)missionLabel2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v266 @ S2_v22 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		MissionInfo[] currentMissions13 = _currentMissions;
		MissionInfo[] currentMissions14 = _currentMissions;
		Slider missionProgress3 = MissionProgress3;
		TMP_Text progressText3 = ProgressText3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S3_v20 (MissionInfo[])+64]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S4_v15 (MissionInfo[])+80]");
		((PauseScreen)null).MissionProgress(missionProgress3, progressText3, (float)num9, 0f);
		MissionInfo[] currentMissions15 = _currentMissions;
		Image missionCheckBox = MissionCheckBox1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S1_v41 (MissionInfo[])+34]");
		missionCheckBox.enabled = false;
		MissionInfo[] currentMissions16 = _currentMissions;
		Image missionCheckBox2 = MissionCheckBox2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v44 (MissionInfo[])+5C]");
		missionCheckBox2.enabled = false;
		MissionInfo[] currentMissions17 = _currentMissions;
		Image missionCheckBox3 = MissionCheckBox3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S1_v47 (MissionInfo[])+84]");
		missionCheckBox3.enabled = false;
		hasCached = true;
		LabelAndNumberUpdate(0, MissionLabel1, null);
		LabelAndNumberUpdate(1, MissionLabel2, null);
		LabelAndNumberUpdate(2, MissionLabel3, null);
		MissionInfo[] currentMissions18 = _currentMissions;
		float alpha = 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S3_v26 (MissionInfo[])+34]");
		if ((nint)0 == 0)
		{
			alpha = 1f;
		}
		MissionLabel1.alpha = alpha;
		MissionInfo[] currentMissions19 = _currentMissions;
		float alpha2 = 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S3_v29 (MissionInfo[])+5C]");
		if ((nint)0 == 0)
		{
			alpha2 = 1f;
		}
		MissionLabel2.alpha = alpha2;
		MissionInfo[] currentMissions20 = _currentMissions;
		float alpha3 = 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S3_v32 (MissionInfo[])+84]");
		if ((nint)0 == 0)
		{
			alpha3 = 1f;
		}
		MissionLabel3.alpha = alpha3;
		object obj23 = obj + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE9");
		object obj24 = obj + 88;
		object obj25 = obj + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		object obj26 = obj + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1238");
		object obj27 = obj + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE9");
		object obj28 = obj + 48;
		object obj29 = obj + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		object obj30 = obj + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1238");
		object obj31 = obj + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE9");
		object obj32 = obj + 8;
		object obj33 = obj + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		object obj34 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1238");
		MissionsManager instance3 = MissionsManager.Instance;
		PlayerInfo playerinfo2 = instance3.playerinfo;
		_cachedMissionSet = playerinfo2._currentMissionSet;
		object obj35 = 0;
		object obj36 = 0;
		while ((nint)obj35 < 3)
		{
			object obj37 = obj36 + 1;
			object obj38 = obj35 * 40;
			object obj39 = (object)_currentMissions + obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S2_v90+34]");
			if ((nint)0 == 0)
			{
				obj37 = obj36;
			}
			object obj40 = obj35 + 1;
			obj35 = obj40;
			obj36 = obj37;
		}
		float value = (float)obj36 / 3f;
		missionProgressSlider.value = value;
		TMP_Text tMP_Text = progressLabel;
		object obj41 = obj + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = 1077936128;
		object obj42 = obj + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg5 = default;
		object arg6 = default;
		string text3 = $"{arg5}/{arg6}";
		nint num10 = (nint)tMP_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v490 @ S2_v63 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		PlayerInfo instance4 = PlayerInfo.Instance;
		object obj43 = instance4._currentMissionSet + 1;
		if ((nint)obj43 >= 30)
		{
			obj43 = 30;
		}
		if ((nint)obj43 <= 1)
		{
			obj43 = 1;
		}
		TMP_Text tMP_Text2 = missionGoalLabel;
		if ((nint)obj43 == 30)
		{
			string empty = string.Empty;
		}
		else
		{
			PlayerInfo instance5 = PlayerInfo.Instance;
			object obj44 = instance5._currentMissionSet + 1;
			if ((nint)obj44 >= 30)
			{
				obj44 = 30;
			}
			if ((nint)obj44 <= 1)
			{
				obj44 = 1;
			}
			object obj45 = obj44 + 1;
			int num11 = obj + 252;
			string text4 = ((int*)num11)->ToString();
			string empty = "x" + text4;
		}
		nint num12 = (nint)tMP_Text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v539 @ S2_v72 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		bool flag2 = (nint)obj43 == 30;
		MissionGoalSprite.enabled = flag2;
	}

	private void LabelAndNumberUpdate(int missionArrayNr, TMP_Text sendMissionLabel, TMP_Text sendMissionNumber)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0462: Expected Obj, but got I4
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_048d: Expected Obj, but got I4
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_04b8: Expected Obj, but got I4
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		//IL_0580: Expected I4, but got Obj
		//IL_0592: Expected Obj, but got I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0288: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got I4
		//IL_0510: Expected I4, but got Obj
		//IL_0522: Expected Obj, but got I4
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_0393: Expected Obj, but got I4
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_03be: Expected Obj, but got I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03f8: Expected Obj, but got I
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0068: Expected I, but got Obj
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got I4
		//IL_0437: Expected I, but got Obj
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0343: Expected I, but got Obj
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0232: Expected I, but got Obj
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_01c8: Expected F8, but got I4
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_0611: Expected I, but got Obj
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = missionArrayNr * 40;
		object obj4 = (object)_currentMissions + obj3;
		object obj5 = obj4 + 16;
		object obj6 = missionArrayNr * 40;
		object obj7 = (object)_currentMissions + obj6;
		object obj8 = obj7 + 16;
		object obj9 = missionArrayNr * 40;
		object obj10 = (object)_currentMissions + obj9;
		object obj11 = obj10 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19+24]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v10+4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v79+4]");
			_ = 0;
			object obj17 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			string text = string.Format(format, arg);
			nint num = (nint)sendMissionLabel;
			object obj18 = sendMissionLabel + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ S2_v54 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v10+4]");
		bool flag2 = (nint)0 == 1;
		object obj19 = 12;
		if (!flag2)
		{
			obj19 = 8;
		}
		object obj20 = obj8 + obj19;
		string format2 = Strings.Get((StringID)obj20);
		object obj21 = missionArrayNr * 40;
		object obj22 = (object)_currentMissions + obj21;
		object obj23 = obj22 + 16;
		if ((nint)obj23 == 39)
		{
			UIScreenController instance = UIScreenController.Instance;
			string topScreenName = instance.GetTopScreenName();
			bool flag3 = topScreenName == "PauseUI";
			object obj24 = missionArrayNr * 40;
			object obj25 = (object)_currentMissions + obj24;
			object obj26 = obj25 + 16;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v66+4]");
				_ = 0;
				object obj27 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Game instance2 = Game.Instance;
				double num2 = instance2._elapsedGameDuration;
				double num3 = Math.Abs((double)instance2._elapsedGameDuration);
				if (!(num3 < 2147483648.0))
				{
					num2 = -2147483648.0;
				}
				object obj28 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg2 = default;
				object arg3 = default;
				string text2 = string.Format(format2, arg2, arg3);
				nint num4 = (nint)sendMissionLabel;
				object obj29 = sendMissionLabel + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v343 @ S2_v43 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				hasCached = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v66+4]");
				_ = 0;
				object obj30 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				_ = 0;
				object obj31 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg4 = default;
				object arg5 = default;
				string text3 = string.Format(format2, arg4, arg5);
				nint num5 = (nint)sendMissionLabel;
				object obj32 = sendMissionLabel + 528;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v324 @ S2_v36 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			}
			return;
		}
		object obj33 = missionArrayNr * 40;
		object obj34 = (object)_currentMissions + obj33;
		object obj35 = obj34 + 16;
		object obj36 = missionArrayNr * 40;
		object obj37 = (object)_currentMissions + obj36;
		object obj38 = obj37 + 16;
		if ((nint)obj38 == 80)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v40+4]");
			_ = 0;
			object obj39 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			PauseScreen pauseScreen = default;
			int num6 = pauseScreen.oneOfEach;
			object obj40 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg6 = default;
			string text4 = string.Format(format2, pauseScreen, arg6);
			nint num7 = (nint)sendMissionLabel;
			object obj41 = sendMissionLabel + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v301 @ S2_v28 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v40+4]");
			_ = 0;
			object obj42 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj43 = missionArrayNr * 40;
			object obj44 = (object)_currentMissions + obj43;
			object obj45 = obj44 + 16;
			object obj46 = missionArrayNr * 40;
			object obj47 = (object)_currentMissions + obj46;
			object obj48 = obj47 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v34+4]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S2_v16+20]");
			object obj49 = num8 - 0;
			object obj50 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg7 = default;
			object arg8 = default;
			string text5 = string.Format(format2, arg7, arg8);
			nint num9 = (nint)sendMissionLabel;
			object obj51 = sendMissionLabel + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ S2_v20 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
	}

	private void OnApplicationPause(bool paused)
	{
		if (!paused)
		{
			RefreshDailyChallenge();
		}
	}

	public bool IsWaiting()
	{
		bool flag = resumeBtnHelper == null;
		ResumeButtonHelper resumeButtonHelper = resumeBtnHelper;
		return (byte)(~(resumeButtonHelper.buttonEnabled ? 1u : 0u)) != 0;
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

	public PauseScreen()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] array = default;
		rewardIcons = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] array2 = default;
		challengeActiveWidgets = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] array3 = default;
		challengeCompletedWidgets = array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		MissionInfo[] cachedMissionInfo = default;
		_cachedMissionInfo = cachedMissionInfo;
		base._002Ector();
	}

	private void _003CAwake_003Eb__43_2()
	{
		//IL_0017: Expected I, but got Obj
		UIScreenController instance = UIScreenController.Instance;
		instance.PushScreen("IngameUI");
		UIButtonMessageCenter componentInChildren = GetComponentInChildren<UIButtonMessageCenter>();
		nint num = (nint)componentInChildren;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v7 (Il2CppClass<UIButtonMessageCenter>)+F4] (should have been resolved before IL gen)");
	}

	private void _003CAwake_003Eb__43_3()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<PauseScreen>)+EC] (should have been resolved before IL gen)");
	}
}
