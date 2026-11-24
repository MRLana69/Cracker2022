using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Debugging;
using Kiloo.Common.Extensions;
using Kiloo.Common.Timer;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using SYBO.Subway.Placeholders.Lifecycles;
using UI.Breadcrumbs;
using UI.Footer;
using UI.Generic;
using UI.ModelCamera;
using UI.Pages.MissionsPageInternal;
using UI.Pages.WeeklyHuntPageInternal;
using UI.Screens.RewardManagement;
using UnityEngine;
using WeeklyHunt;

namespace UI.Pages;

public class WeeklyHuntPage : Page
{
	private List<WeekCell> _weekCellTabs;

	private PageTop _topPrefab;

	private GameObject _weeklyHuntIconPrefab;

	private TimerHelper _timerPrefab;

	private GameObject _questionmarkReward;

	private UILabel _activeWeekGoalLabel;

	private UILabel _rewardHeader;

	private UILabel _prizeLabel;

	private UISprite _activeWeekBgElement;

	private UISprite _rewardBgElement;

	private UISprite _completedSprite;

	private UISprite _missedUiSprite;

	private GameObject _activeProgressSlider;

	private UISprite _activeProgressBg;

	private UISprite _activeProgressFg;

	private UILabel _activeProgressText;

	private UIWidget _rewardSectionWidget;

	private UIWidget _rewardObjectGuide;

	private UISprite[] _beams;

	private UISprite _glow;

	private GameObject _presentPrefabBlue;

	private GameObject _presentPrefabGreen;

	private GameObject _presentPrefabRed;

	private PageTop _top;

	private TimerHelper _timer;

	private WeeklyHuntData.PrizePeriodId _currentPeriod;

	private GameObject _weeklyHuntRewardPrefab;

	private GameObject _weeklyHuntRewardGameObject;

	private Vector3 _rewardBaseRoationEuler;

	private Vector3 _animatedRewardRotationEuler;

	private float _currentRewardRotationDuration;

	private int _rewardRotationDirection;

	public override void Init(UIWidget pageGuideWidget)
	{
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0242: Expected I, but got Obj
		//IL_0258: Expected Obj, but got I
		//IL_0281: Expected Obj, but got VT
		//IL_00f0: Expected Obj, but got I
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02d9: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got VT
		//IL_013f: Expected I, but got Obj
		//IL_02ad: Expected Obj, but got VT
		//IL_00a1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = pageGuideWidget;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)_rewardBaseRoationEuler).FindKernel(null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)_rewardBaseRoationEuler);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		object obj6 = 0;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = this + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v16+8]");
		GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)0, (Transform)(object)_rewardBgElement, worldPositionStays: false);
		int layer = gameObject.layer;
		obj8 = layer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		string text = default;
		text.m_stringLength = (int)num7;
		_ = 0;
		object obj9 = text + 16;
		obj9 = obj2;
		Timer.Log(text);
		_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)_rewardBaseRoationEuler).GetComponentsInChildren<T>();
		if (((ComputeShader)(object)componentsInChildren).FindKernel((string)null) != 0)
		{
			((PlaceholderLifecycle)(object)componentsInChildren).Despawn();
		}
	}

	public override void Show()
	{
		FooterButton.FooterPayload buttonPayload = GetButtonPayload();
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)buttonPayload);
	}

	public unsafe override void Hide()
	{
		//IL_0236: Expected Obj, but got I4
		//IL_0244: Expected I, but got Obj
		//IL_025a: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c5: Expected I, but got Obj
		//IL_02b7: Expected I, but got Obj
		//IL_02cd: Expected Obj, but got I
		//IL_0132: Expected I, but got Obj
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v54 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool currentPeriod = WeeklyHuntManager.IsAnyPeriodActive();
		_currentPeriod = (currentPeriod ? WeeklyHuntData.PrizePeriodId.PeriodOne : WeeklyHuntData.PrizePeriodId.None);
		if (_currentPeriod == WeeklyHuntData.PrizePeriodId.None || _currentPeriod == WeeklyHuntData.PrizePeriodId.PeriodFour)
		{
			nint num3 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v36 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v45 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(WeeklyHuntData.hideLastPeriod ? 1u : 0u) == 0)
			{
				_currentPeriod = WeeklyHuntData.PrizePeriodId.PeriodThree;
			}
			else
			{
				_currentPeriod = WeeklyHuntData.PrizePeriodId.PeriodFour;
			}
		}
		nint num5 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v18 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v30 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (WeeklyHuntManager.CanSpawnToken())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(WeeklyHuntPage.RefreshTimerState);
			object obj4 = action + 16;
			obj4 = this;
			_timer.onTimerEnded -= action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action2 = default;
			((Delegate)action2).method_ptr = method_ptr2;
			((Delegate)action2).method = (nint)__ldftn(WeeklyHuntPage.RefreshPage);
			object obj5 = action2 + 16;
			obj5 = this;
			_timer.onTimerEnded -= action2;
		}
		Update();
	}

	private void RefreshPage()
	{
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_weeklyHuntRewardGameObject).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(_weeklyHuntRewardGameObject);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = this;
		throw new ArrayTypeMismatchException();
	}

	public override FooterButton.FooterPayload GetButtonPayload()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FooterButton.FooterPayload footerPayload = default;
		footerPayload.clicked = null;
		object obj = footerPayload + 16;
		obj = this;
		return footerPayload;
	}

	private void Update()
	{
		//IL_00c0: Expected Obj, but got I4
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_0076: Expected I, but got Obj
		((Breadcrumb)1)._002Ector();
		UpdateTabs();
		SetupDynamicTexts();
		this._002Ector();
		SetupDynamicColors();
		SetupDynamicSprites();
		RefreshTimerState();
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v20 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hiddenUntilUnlockedForPeriod = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
		bool hiddenUntilUnlockedForPeriod2 = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v11 (System.Boolean)+C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S2_v4 (System.Boolean)+8]");
		((ModelScreenData)(object)this).UpdateCharacterDataIfNeeded((Characters.CharacterId)num3, 0);
	}

	private unsafe void RotateReward(Transform transformToRotate)
	{
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Expected Obj, but got Unknown
		//IL_0bb0: Expected I, but got Obj
		//IL_0bc6: Expected Obj, but got I
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected Obj, but got Unknown
		//IL_0c68: Expected I, but got Obj
		//IL_0c7e: Expected Obj, but got I
		//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected I4, but got Unknown
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected Obj, but got Unknown
		//IL_0ccd: Expected Obj, but got I4
		//IL_00bf: Expected I, but got Obj
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_010c: Expected I, but got Obj
		//IL_0d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Expected Obj, but got Unknown
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d30: Expected Obj, but got Unknown
		//IL_01f8: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I
		//IL_01a3: Expected I, but got Obj
		//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Expected Obj, but got Unknown
		//IL_0d75: Expected Obj, but got I4
		//IL_0db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Expected Obj, but got Unknown
		//IL_0dd5: Expected I, but got Obj
		//IL_0deb: Expected Obj, but got I
		//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e16: Expected Obj, but got Unknown
		//IL_0e1f: Expected Obj, but got VT
		//IL_0e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2d: Expected Obj, but got Unknown
		//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4b: Expected Obj, but got Unknown
		//IL_0e54: Expected VT, but got Obj
		//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e83: Expected Obj, but got Unknown
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea3: Expected Obj, but got Unknown
		//IL_0eac: Expected Obj, but got VT
		//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected Obj, but got Unknown
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed8: Expected Obj, but got Unknown
		//IL_0ee1: Expected VT, but got Obj
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f10: Expected Obj, but got Unknown
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f30: Expected Obj, but got Unknown
		//IL_0f39: Expected Obj, but got VT
		//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Expected Obj, but got Unknown
		//IL_0f60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f65: Expected Obj, but got Unknown
		//IL_0f6e: Expected VT, but got Obj
		//IL_0239: Expected I, but got Obj
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_0286: Expected I, but got Obj
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_034f: Expected I, but got Obj
		//IL_0365: Expected Obj, but got I
		//IL_0382: Expected I, but got Obj
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f85: Expected Obj, but got Unknown
		//IL_0f9b: Expected Obj, but got I
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdb: Expected Obj, but got Unknown
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffb: Expected Obj, but got Unknown
		//IL_1009: Expected I, but got Obj
		//IL_101f: Expected Obj, but got I
		//IL_105a: Unknown result type (might be due to invalid IL or missing references)
		//IL_105f: Expected Obj, but got Unknown
		//IL_107a: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected Obj, but got Unknown
		//IL_108d: Expected I, but got Obj
		//IL_10a3: Expected Obj, but got I
		//IL_10de: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e3: Expected Obj, but got Unknown
		//IL_112c: Expected Obj, but got I
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_113a: Expected Obj, but got Unknown
		//IL_1145: Unknown result type (might be due to invalid IL or missing references)
		//IL_114a: Expected Obj, but got Unknown
		//IL_041c: Expected I, but got Obj
		//IL_0432: Expected Obj, but got I
		//IL_039e: Expected I, but got Obj
		//IL_03ce: Expected I, but got Obj
		//IL_045d: Expected I, but got Obj
		//IL_03f4: Expected I, but got Obj
		//IL_054d: Expected I, but got Obj
		//IL_0563: Expected Obj, but got I
		//IL_11d6: Expected I4, but got Obj
		//IL_11e4: Expected I, but got Obj
		//IL_11fa: Expected Obj, but got I
		//IL_1220: Expected Obj, but got VT
		//IL_1229: Unknown result type (might be due to invalid IL or missing references)
		//IL_122e: Expected Obj, but got Unknown
		//IL_1247: Expected VT, but got Obj
		//IL_1280: Expected I, but got Obj
		//IL_1296: Expected Obj, but got I
		//IL_12a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ac: Expected Obj, but got Unknown
		//IL_12c5: Expected VT, but got Obj
		//IL_058e: Expected I, but got Obj
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected Obj, but got Unknown
		//IL_04f7: Expected Obj, but got I4
		//IL_050d: Expected Obj, but got I4
		//IL_064c: Expected Obj, but got VT
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected Obj, but got Unknown
		//IL_0673: Expected VT, but got Obj
		//IL_05db: Expected I, but got Obj
		//IL_06a8: Expected I4, but got Obj
		//IL_06b1: Expected Obj, but got VT
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_06d8: Expected VT, but got Obj
		//IL_0714: Expected Obj, but got VT
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_073b: Expected VT, but got Obj
		//IL_0770: Expected I4, but got Obj
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected Obj, but got Unknown
		//IL_0787: Expected Obj, but got VT
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected Obj, but got Unknown
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got Unknown
		//IL_07bc: Expected VT, but got Obj
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected Obj, but got Unknown
		//IL_0806: Expected Obj, but got VT
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected Obj, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected Obj, but got Unknown
		//IL_083b: Expected VT, but got Obj
		//IL_0870: Expected I4, but got Obj
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_0887: Expected Obj, but got VT
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected Obj, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected Obj, but got Unknown
		//IL_08bc: Expected VT, but got Obj
		//IL_08fd: Expected I, but got Obj
		//IL_0913: Expected Obj, but got I
		//IL_12d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dc: Expected Obj, but got Unknown
		//IL_12e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ea: Expected Obj, but got Unknown
		//IL_1301: Expected Obj, but got I4
		//IL_1342: Expected I4, but got Obj
		//IL_134b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1350: Expected Obj, but got Unknown
		//IL_1359: Expected Obj, but got VT
		//IL_1362: Unknown result type (might be due to invalid IL or missing references)
		//IL_1367: Expected Obj, but got Unknown
		//IL_1380: Unknown result type (might be due to invalid IL or missing references)
		//IL_1385: Expected Obj, but got Unknown
		//IL_138e: Expected VT, but got Obj
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected Obj, but got Unknown
		//IL_0994: Expected Obj, but got VT
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected Obj, but got Unknown
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected Obj, but got Unknown
		//IL_09c9: Expected VT, but got Obj
		//IL_09da: Expected I4, but got Obj
		//IL_0a17: Expected I4, but got Obj
		//IL_093e: Expected I, but got Obj
		//IL_0a2a: Expected I4, but got VT
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected Obj, but got Unknown
		//IL_0a45: Expected Obj, but got I4
		//IL_0a56: Expected VT, but got Obj
		//IL_0a86: Expected I4, but got Obj
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected Obj, but got Unknown
		//IL_0aa4: Expected Obj, but got I4
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab9: Expected Obj, but got Unknown
		//IL_0ae2: Expected I, but got Obj
		//IL_0af8: Expected Obj, but got I
		//IL_13a5: Expected I4, but got VT
		//IL_13b2: Expected Obj, but got I4
		//IL_13c3: Expected VT, but got Obj
		//IL_13f1: Expected I4, but got Obj
		//IL_13fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ff: Expected Obj, but got Unknown
		//IL_0b23: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(WeeklyHuntPage._003CInit_003Eb__32_0);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v126 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnLastPopupClosed -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		UIScreenController.OnPopupShown -= action2;
		((PageTop)(object)this).Setup((PageTop.EventsPageTopPayload)(object)transformToRotate);
		GameObject parent = topContainer.gameObject;
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v122 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 108;
		PageTop pageTop = UnityEngine.Object.Instantiate(_topPrefab, (Transform)(object)parent);
		obj5 = pageTop;
		GameObject gameObject = _top.gameObject;
		nint num6 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v26 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v356 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = default;
		bool flag = (byte)(obj7 + 376) != 0;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj7 + 400);
		transform = (Transform)((bool*)(flag ? 1 : 0))->m_value;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v31 (System.Boolean)+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PageTop.TopIconPayload topIconPayload = default;
		topIconPayload._002Ector();
		nint num8 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v40 (Il2CppClass<Strings>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v352 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = topIconPayload + 8;
		string text = Strings.GetDefault("WEEKLY_HUNT_TITLE");
		obj9 = text;
		object obj10 = topIconPayload + 12;
		string text2 = Strings.GetDefault("WEEKLY_HUNT_SUBTITLE");
		string text3 = text2.ToUpperInvariant();
		obj10 = text3;
		nint num10 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v49 (Il2CppClass<UI.ColorData>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num11 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v348 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = obj7 + 312;
		bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj13 = (flag2 ? 1 : 0) + 140;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S2_v27+8]");
		_ = 0;
		transform = (Transform)obj12;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v54+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		object obj14 = topIconPayload + 20;
		obj14 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		nint num12 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v62 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num13 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v342 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj16 = obj7 + 288;
		obj16 = GlobalColorsGenerated.WEEKLYHUNT_CITY_NAME;
		object obj17 = obj7 + 392;
		obj17 = obj16;
		transform = (Transform)obj17;
		object obj18 = obj7 + 264;
		Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj18;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S1_v72+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		object obj19 = topIconPayload + 36;
		obj19 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj20 = obj7 + 248;
		obj20 = GlobalColorsGenerated.WEEKLYHUNT_SPLASH;
		object obj21 = obj7 + 372;
		obj21 = obj20;
		transform = (Transform)obj21;
		object obj22 = obj7 + 232;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj22;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v84+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		object obj23 = topIconPayload + 52;
		obj23 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj24 = obj7 + 216;
		obj24 = GlobalColorsGenerated.WEEKLYHUNT_SPLASH_SHADOW;
		object obj25 = obj7 + 368;
		obj25 = obj24;
		transform = (Transform)obj25;
		object obj26 = obj7 + 200;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj26;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S1_v96+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		object obj27 = topIconPayload + 68;
		obj27 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		_top.MakeIcon(topIconPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PageTop._003C_003Ec__DisplayClass32_0 obj28 = default;
		obj28._002Ector();
		object obj29 = obj28 + 8;
		obj29 = _weeklyHuntIconPrefab;
		nint num14 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S1_v109 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		bool flag3 = obj30 == null;
		nint num15 = (nint)typeof(WeeklyHuntManager);
		if (!flag3)
		{
			nint num16 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S1_v336 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			bool flag4 = (nint)0 == 0;
			bool flag5 = !flag4;
			num15 = (nint)typeof(WeeklyHuntManager);
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num15 = (nint)typeof(WeeklyHuntManager);
			}
		}
		object obj31 = obj7 + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ L1_v16 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+5C]");
		object obj32 = (nint)0 + (nint)8;
		obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S2_v112+8]");
		_ = 0;
		transform = (Transform)obj31;
		Transform transform7 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S1_v114+8]");
		((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
		object obj33 = obj28 + 12;
		obj33 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj34 = obj7 + 168;
		nint num17 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S2_v127 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+5C]");
		object obj35 = (nint)0 + (nint)32;
		obj34 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S2_v129+8]");
		_ = 0;
		transform = (Transform)obj34;
		Transform transform8 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S1_v122+8]");
		((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
		object obj36 = obj28 + 36;
		obj36 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj37 = obj7 + 152;
		nint num18 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S2_v144 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+5C]");
		object obj38 = (nint)0 + (nint)20;
		obj37 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S2_v146+8]");
		_ = 0;
		transform = (Transform)obj37;
		Transform transform9 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v130+8]");
		((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
		object obj39 = obj28 + 24;
		obj39 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		((WeeklyHuntPage)(object)_top).Init((UIWidget)(object)obj28);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		UIWidget uIWidget = default;
		((UnityEngine.Object)uIWidget).m_CachedPtr = cachedPtr;
		uIWidget.bottomAnchor = (UIRect.AnchorPoint)0;
		object obj40 = uIWidget + 16;
		obj40 = this;
		object obj41 = this + 112;
		GameObject gameObject2 = ((WeeklyHuntPage)(object)_top)._003CInit_003Eb__32_2(uIWidget);
		TimerHelper component = gameObject2.GetComponent<TimerHelper>();
		obj41 = component;
		nint num19 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S0_v64 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj42 = (nint)0 & (nint)0x200;
		if (obj42 != null)
		{
			nint num20 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ S0_v118 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool currentPeriod = WeeklyHuntManager.IsAnyPeriodActive();
		_currentPeriod = (currentPeriod ? WeeklyHuntData.PrizePeriodId.PeriodOne : WeeklyHuntData.PrizePeriodId.None);
		int num21 = 0;
		object obj44 = default;
		bool flag6 = default;
		while (true)
		{
			List<WeekCell> weekCellTabs = _weekCellTabs;
			if (num21 >= weekCellTabs._size)
			{
				break;
			}
			WeekCell weekCell = _weekCellTabs.get_Item(num21);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num22 = 0;
			_ = 0;
			object obj43 = obj44 + 16;
			obj43 = this;
			object obj45 = (flag6 ? 1 : 0) + 8;
			obj45 = obj44;
			object obj46 = num21 + 1;
			weekCell.SetCellActive(flag6);
			int num23 = num21 + 1;
			num21 = num23;
		}
		nint num24 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S1_v156 (Il2CppClass<Strings>)+BA]");
		object obj47 = (nint)0 & (nint)0x200;
		if (obj47 != null)
		{
			nint num25 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ S1_v314 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text4 = Strings.GetDefault("WEEKLY_HUNT_REWARD_TEXT");
		_rewardHeader.fontSize = (int)text4;
		nint num26 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S1_v164 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj48 = (nint)0 & (nint)0x200;
		if (obj48 != null)
		{
			nint num27 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ S1_v308 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj12 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_BG_GRADIENT_TOP;
		object obj49 = obj7 + 364;
		obj49 = obj12;
		transform = (Transform)obj49;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj16;
		Transform transform10 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v67+8]");
		((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A667");
		nint num28 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S2_v183 (Il2CppClass<GlobalColorsGenerated>)+5C]");
		object obj50 = -(-64);
		obj18 = obj50;
		object obj51 = obj7 + 360;
		obj51 = obj18;
		transform = (Transform)obj51;
		Matrix4x4 matrix4x5 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj20;
		Transform transform11 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v79+8]");
		((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
		_ = _activeWeekBgElement.border;
		obj22 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_GOAL_TEXT;
		object obj52 = obj7 + 356;
		obj52 = obj22;
		transform = (Transform)obj52;
		Matrix4x4 matrix4x6 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj24;
		Transform transform12 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S1_v91+8]");
		((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
		_activeWeekGoalLabel.rawPivot = (UIWidget.Pivot)transform;
		obj26 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_GOAL_TEXT_SHADOW;
		object obj53 = obj7 + 352;
		obj53 = obj26;
		transform = (Transform)obj53;
		Matrix4x4 matrix4x7 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj31;
		Transform transform13 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S1_v114+8]");
		((UnityEngine.Object)transform13).m_CachedPtr = (IntPtr)0;
		Vector2 effectDistance = ((UILabel)(object)transform).effectDistance;
		obj34 = GlobalColorsGenerated.WEEKLYHUNT_REWARD_HEADLINE;
		object obj54 = obj7 + 348;
		obj54 = obj34;
		transform = (Transform)obj54;
		Matrix4x4 matrix4x8 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj37;
		Transform transform14 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v130+8]");
		((UnityEngine.Object)transform14).m_CachedPtr = (IntPtr)0;
		_rewardHeader.rawPivot = (UIWidget.Pivot)transform;
		object obj55 = obj7 + 144;
		obj55 = GlobalColorsGenerated.WEEKLYHUNT_REWARD_HEADLINE_SHADOW;
		object obj56 = obj7 + 344;
		obj56 = obj55;
		transform = (Transform)obj56;
		object obj57 = obj7 + 128;
		Matrix4x4 matrix4x9 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj57;
		Transform transform15 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ S1_v214+8]");
		((UnityEngine.Object)transform15).m_CachedPtr = (IntPtr)0;
		Vector2 effectDistance2 = ((UILabel)(object)transform).effectDistance;
		object obj58 = obj7 + 120;
		obj58 = GlobalColorsGenerated.WEEKLYHUNT_REWARD_AND_AMOUNT_TEXT;
		object obj59 = obj7 + 340;
		obj59 = obj58;
		transform = (Transform)obj59;
		object obj60 = obj7 + 104;
		Matrix4x4 matrix4x10 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj60;
		Transform transform16 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ S1_v224+8]");
		((UnityEngine.Object)transform16).m_CachedPtr = (IntPtr)0;
		_prizeLabel.rawPivot = (UIWidget.Pivot)transform;
		object obj61 = obj7 + 96;
		obj61 = GlobalColorsGenerated.WEEKLYHUNT_REWARD_AND_AMOUNT_TEXT_SHADOW;
		object obj62 = obj7 + 336;
		obj62 = obj61;
		transform = (Transform)obj62;
		object obj63 = obj7 + 80;
		Matrix4x4 matrix4x11 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj63;
		Transform transform17 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ S1_v234+8]");
		((UnityEngine.Object)transform17).m_CachedPtr = (IntPtr)0;
		Vector2 effectDistance3 = ((UILabel)(object)transform).effectDistance;
		nint num29 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ S1_v239 (Il2CppClass<UI.ColorData>)+BA]");
		object obj64 = (nint)0 & (nint)0x200;
		if (obj64 != null)
		{
			nint num30 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ S1_v304 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj65 = obj7 + 280;
		object obj66 = obj7 - -64;
		bool flag7 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj67 = (flag7 ? 1 : 0) + 812;
		obj66 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ S2_v299+8]");
		_ = 0;
		transform = (Transform)obj66;
		Transform transform18 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ S1_v246+8]");
		((UnityEngine.Object)transform18).m_CachedPtr = (IntPtr)0;
		_glow.rawPivot = (UIWidget.Pivot)transform;
		object obj68 = obj7 + 56;
		obj68 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_TEXT;
		object obj69 = obj7 + 332;
		obj69 = obj68;
		transform = (Transform)obj69;
		object obj70 = obj7 + 40;
		Matrix4x4 matrix4x12 = Matrix4x4.Inverse((Matrix4x4)transform);
		object obj71 = obj7 + 32;
		obj71 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_BG;
		object obj72 = obj7 + 328;
		obj72 = obj71;
		transform = (Transform)obj72;
		object obj73 = obj7 + 16;
		Matrix4x4 matrix4x13 = Matrix4x4.Inverse((Matrix4x4)transform);
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj70 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v937 @ S1_v257+8]");
		_ = 0;
		transform = (Transform)obj73;
		Transform transform19 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ S1_v264+8]");
		((UnityEngine.Object)transform19).m_CachedPtr = (IntPtr)0;
		_timer.AnimateClock(flag, (byte)(int)transform != 0);
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)GlobalColorsGenerated.WEEKLYHUNT_REWARD_BG != 0;
		object obj74 = obj7 + 304;
		obj74 = ((bool*)(flag ? 1 : 0))->m_value;
		transform = (Transform)obj74;
		Matrix4x4 matrix4x14 = Matrix4x4.Inverse((Matrix4x4)transform);
		transform = (Transform)obj7;
		Transform transform20 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform20).m_CachedPtr = (IntPtr)0;
		_rewardBgElement.rawPivot = (UIWidget.Pivot)transform;
		object obj75 = _beams + 12;
		object obj76 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj76) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj75))
		{
			object obj77 = _beams + 16;
			object obj78 = obj76 << 2;
			object obj79 = obj77 + obj78;
			nint num31 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ S1_v286 (Il2CppClass<GlobalColors>)+BA]");
			object obj80 = (nint)0 & (nint)0x200;
			if (obj80 != null)
			{
				nint num32 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ S1_v298 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)GlobalColors.WEEKLYHUNT_STRIPE_COLOR != 0;
			obj65 = ((bool*)(flag ? 1 : 0))->m_value;
			transform = (Transform)obj65;
			Matrix4x4 matrix4x15 = Matrix4x4.Inverse((Matrix4x4)transform);
			transform = (Transform)obj12;
			Transform transform21 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v54+8]");
			((UnityEngine.Object)transform21).m_CachedPtr = (IntPtr)0;
			((UIWidget)obj79).rawPivot = (UIWidget.Pivot)transform;
			object obj81 = obj76 + 1;
			obj76 = obj81;
		}
	}

	private void SetupRewardObject()
	{
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_weeklyHuntRewardGameObject).FindKernel((string)null) != 0)
		{
			int layer = _weeklyHuntRewardGameObject.layer;
			SetObjectVisibility((byte)layer != 0);
		}
	}

	private void SetupDynamicTexts()
	{
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_05a0: Expected Obj, but got I4
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05e8: Expected I, but got Obj
		//IL_05fe: Expected Obj, but got I
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_070b: Expected I, but got Obj
		//IL_0721: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected Obj, but got Unknown
		//IL_02ca: Expected F4, but got I
		//IL_02df: Expected F4, but got I
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_02f7: Expected VT, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_0369: Expected Obj, but got I
		//IL_0887: Expected Obj, but got I
		//IL_089c: Expected Obj, but got I
		//IL_08aa: Expected I, but got Obj
		//IL_08c0: Expected Obj, but got I
		//IL_0354: Expected Obj, but got I
		//IL_018a: Expected I, but got Obj
		//IL_0909: Expected F4, but got Obj
		//IL_091b: Expected F4, but got Obj
		//IL_0954: Expected F4, but got Obj
		//IL_0966: Expected F4, but got Obj
		//IL_0978: Expected F4, but got Obj
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01f8: Expected Obj, but got I
		//IL_037c: Expected I, but got Obj
		//IL_020f: Expected I, but got Obj
		//IL_0225: Expected Obj, but got I
		//IL_0993: Expected I, but got Obj
		//IL_09a9: Expected Obj, but got I
		//IL_07e8: Expected F4, but got Obj
		//IL_07fa: Expected F4, but got Obj
		//IL_080c: Expected F4, but got Obj
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected Obj, but got Unknown
		//IL_0a6b: Expected Obj, but got I4
		//IL_0a85: Expected I, but got Obj
		//IL_0a9b: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I4
		//IL_0250: Expected I, but got Obj
		//IL_09d8: Expected Obj, but got I4
		//IL_04aa: Expected I, but got Obj
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_04f7: Expected I, but got Obj
		//IL_0583: Expected Obj, but got I4
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected Obj, but got Unknown
		//IL_0575: Expected Obj, but got I4
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		QuickVideoButtonHelper quickVideoButtonHelper = default;
		object obj = quickVideoButtonHelper + 80;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = default;
		object obj2 = obj3 + 48;
		obj2 = this;
		((UIRect)_rewardObjectGuide).ParentHasChanged();
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v22 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v164 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FPSCounter fPSCounter = (FPSCounter)(quickVideoButtonHelper + 112);
		fPSCounter.ToggleVisible((byte)_currentPeriod != 0);
		obj = fPSCounter;
		_ = ((UnityEngine.Object)fPSCounter).m_CachedPtr;
		_ = fPSCounter.UpdateInterval;
		_ = fPSCounter.accum;
		CelebrationReward rewardForPeriod = WeeklyHuntManager.GetRewardForPeriod(_currentPeriod);
		bool flag;
		if (rewardForPeriod != null)
		{
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v19 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v28 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool hiddenUntilUnlockedForPeriod = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
			bool hiddenUntilUnlockedForPeriod2 = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v156 (System.Boolean)+C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v26 (System.Boolean)+8]");
			flag = num5 != 0;
		}
		else
		{
			flag = false;
		}
		bool flag2 = flag;
		object obj6 = obj3 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num6 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v38 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num7 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v160 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		QuickVideoButtonHelper quickVideoButtonHelper2 = (QuickVideoButtonHelper)(quickVideoButtonHelper + 40);
		WeeklyHuntData.WeeklyHuntPeriodData prizeDataForPeriod = WeeklyHuntManager.GetPrizeDataForPeriod(_currentPeriod);
		int num13;
		if (prizeDataForPeriod == null)
		{
			nint num8 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v124 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num9 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v149 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool hiddenUntilUnlockedForPeriod3 = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
			bool hiddenUntilUnlockedForPeriod4 = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v136 (System.Boolean)+C]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v131 (System.Boolean)+8]");
			if (num10 != 0)
			{
				object obj9 = this + 120;
				obj9 = _questionmarkReward;
				bool isInstanced = UIScreenController.IsInstanced;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v142 (System.Boolean)+24]");
				int layer = ((GameObject)0).layer;
				nint num11 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v146 (Il2CppClass<PrizePositionData>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num12 = (nint)typeof(PrizePositionData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v156 (Il2CppClass<PrizePositionData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				quickVideoButtonHelper2.OnEnable();
				fPSCounter = (FPSCounter)(object)quickVideoButtonHelper2;
				((UnityEngine.Object)fPSCounter).m_CachedPtr = ((UnityEngine.Object)quickVideoButtonHelper2).m_CachedPtr;
				fPSCounter.UpdateInterval = (float)quickVideoButtonHelper2._defaultIconSprite;
				fPSCounter.accum = (float)quickVideoButtonHelper2._defaultRotateGlint;
				fPSCounter.timeleft = (float)quickVideoButtonHelper2._curentVideoAdPrize;
				num13 = layer;
				goto IL_0819;
			}
		}
		Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData> huntData = WeeklyHuntData.GetHuntData();
		fPSCounter = (FPSCounter)obj;
		FPSCounter fPSCounter2 = fPSCounter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)fPSCounter2).m_CachedPtr = (IntPtr)0;
		FPSCounter fPSCounter3 = fPSCounter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		fPSCounter3.UpdateInterval = 0f;
		FPSCounter fPSCounter4 = fPSCounter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		fPSCounter4.accum = 0f;
		object obj11 = this + 120;
		GameObject prefab = ((PrizeIconPrefabReferences)(object)huntData).GetPrefab((WeeklyHuntData.PrizeData)fPSCounter);
		obj11 = prefab;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15+34]");
		bool flag3 = (nint)0 != 0;
		bool isInstanced2 = UIScreenController.IsInstanced;
		GameObject gameObject;
		if (flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v93 (System.Boolean)+1C]");
			gameObject = (GameObject)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v93 (System.Boolean)+24]");
			gameObject = (GameObject)0;
		}
		int layer2 = gameObject.layer;
		quickVideoButtonHelper2 = (QuickVideoButtonHelper)obj;
		QuickVideoButtonHelper quickVideoButtonHelper3 = quickVideoButtonHelper2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)quickVideoButtonHelper3).m_CachedPtr = (IntPtr)0;
		QuickVideoButtonHelper quickVideoButtonHelper4 = quickVideoButtonHelper2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		quickVideoButtonHelper4._defaultIconSprite = (UISprite)0;
		QuickVideoButtonHelper quickVideoButtonHelper5 = quickVideoButtonHelper2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		quickVideoButtonHelper5._defaultRotateGlint = (Transform)0;
		nint num14 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v112 (Il2CppClass<PrizePositionData>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num15 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v126 (Il2CppClass<PrizePositionData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		fPSCounter = (FPSCounter)(object)quickVideoButtonHelper2;
		((UnityEngine.Object)fPSCounter).m_CachedPtr = ((UnityEngine.Object)quickVideoButtonHelper2).m_CachedPtr;
		fPSCounter.UpdateInterval = (float)quickVideoButtonHelper2._defaultIconSprite;
		fPSCounter.accum = (float)quickVideoButtonHelper2._defaultRotateGlint;
		quickVideoButtonHelper.onVideoStarted += (Action)(object)fPSCounter;
		fPSCounter = (FPSCounter)(object)quickVideoButtonHelper;
		((UnityEngine.Object)fPSCounter).m_CachedPtr = ((UnityEngine.Object)quickVideoButtonHelper).m_CachedPtr;
		fPSCounter.UpdateInterval = (float)quickVideoButtonHelper._defaultIconSprite;
		fPSCounter.accum = (float)quickVideoButtonHelper._defaultRotateGlint;
		fPSCounter.timeleft = (float)quickVideoButtonHelper._curentVideoAdPrize;
		num13 = layer2;
		goto IL_0819;
		IL_0819:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8262");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15+34]");
		if ((nint)0 != 0)
		{
			object obj13 = _currentPeriod - 1;
			if (_currentPeriod != WeeklyHuntData.PrizePeriodId.PeriodOne)
			{
				if ((nint)obj13 != 1)
				{
					if ((nint)obj13 == 2)
					{
						object obj14 = this + 24;
						obj14 = _presentPrefabRed;
					}
					else
					{
						SDebug.LogFormat("Hunt Period not available for present!", null);
						object obj15 = this + 24;
						obj15 = _presentPrefabGreen;
					}
				}
				else
				{
					object obj16 = this + 24;
					obj16 = _presentPrefabGreen;
				}
			}
			else
			{
				object obj17 = this + 24;
				obj17 = _presentPrefabBlue;
			}
		}
		nint num16 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S1_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(_weeklyHuntRewardGameObject);
		object obj19 = this + 124;
		GameObject gameObject2 = UnityEngine.Object.Instantiate(_weeklyHuntRewardPrefab, (Transform)num13);
		obj19 = gameObject2;
		nint num18 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v56 (Il2CppClass<UIScreenController>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num19 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v76 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		if (((UIScreenController)flag4).IsPopupQueueEmpty())
		{
			_weeklyHuntRewardGameObject.tag = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15+34]");
		string s = (((nint)0 == 0) ? ((string)31) : ((string)29));
		Color color = MiscExtensions.ToColor(s);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num20 = 0;
		string text = default;
		text.m_stringLength = (int)num20;
		_ = 0;
		object obj21 = text + 16;
		obj21 = obj3;
		Timer.Log(text);
	}

	private void SetupDynamicColors()
	{
		//IL_025a: Expected I, but got Obj
		//IL_0270: Expected Obj, but got I
		//IL_02f6: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ae: Expected I4, but got Obj
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_011c: Expected Obj, but got I
		//IL_0150: Expected I4, but got Obj
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I4
		//IL_0216: Expected I4, but got Obj
		//IL_024b: Expected Obj, but got I4
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v32 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("WEEKLY_HUNT_COLLECT_TEXT");
		nint num3 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v52 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 40;
		bool hiddenUntilUnlockedForPeriod = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S3_v4 (System.Boolean)+8]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = string.Format(format, args);
		_activeWeekGoalLabel.fontSize = (int)text;
		object obj5 = obj4 + 36;
		bool hiddenUntilUnlockedForPeriod2 = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S2_v19 (System.Boolean)+C]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object obj6 = obj4 + 32;
		bool hiddenUntilUnlockedForPeriod3 = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S3_v12 (System.Boolean)+8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text3 = default;
		string text4 = default;
		string text2 = text3 + "/" + text4;
		_activeProgressText.fontSize = (int)text2;
		FPSCounter fPSCounter = (FPSCounter)(obj4 + 4);
		fPSCounter.ToggleVisible((byte)_currentPeriod != 0);
		FPSCounter fPSCounter2 = (FPSCounter)(obj4 + 44);
		fPSCounter2 = fPSCounter;
		((UnityEngine.Object)fPSCounter2).m_CachedPtr = ((UnityEngine.Object)fPSCounter).m_CachedPtr;
		fPSCounter2.UpdateInterval = fPSCounter.UpdateInterval;
		fPSCounter2.accum = fPSCounter.accum;
		bool visible = fPSCounter2.Visible;
		fPSCounter2.ToggleVisible((byte)_currentPeriod != 0);
		obj4 = fPSCounter2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args2 = default;
		string text5 = string.Format((string)visible, args2);
		_prizeLabel.fontSize = (int)text5;
		WeeklyHuntData.WeeklyHuntPeriodData prizeDataForPeriod = WeeklyHuntManager.GetPrizeDataForPeriod(_currentPeriod);
		bool flag = prizeDataForPeriod != null;
		_prizeLabel.tag = (string)flag;
	}

	private unsafe void SetupDynamicSprites()
	{
		//IL_03cc: Expected I, but got Obj
		//IL_03e2: Expected Obj, but got I
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected VT, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected Obj, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected Obj, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected Obj, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected Obj, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Expected Obj, but got Unknown
		//IL_02a6: Expected I, but got Obj
		//IL_02bc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_04f7: Expected Obj, but got VT
		//IL_050c: Expected F4, but got Obj
		//IL_0507: Expected native int or pointer, but got VT
		//IL_0526: Expected F4, but got Obj
		//IL_0521: Expected native int or pointer, but got VT
		//IL_053b: Expected F4, but got I
		//IL_0536: Expected native int or pointer, but got VT
		//IL_054a: Expected I4, but got VT
		//IL_0553: Expected Obj, but got VT
		//IL_0568: Expected F4, but got Obj
		//IL_0563: Expected native int or pointer, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0333: Expected F4, but got Obj
		//IL_032e: Expected native int or pointer, but got VT
		//IL_0348: Expected F4, but got I
		//IL_0343: Expected native int or pointer, but got VT
		//IL_0357: Expected I4, but got VT
		//IL_0360: Expected Obj, but got VT
		//IL_0375: Expected F4, but got Obj
		//IL_0370: Expected native int or pointer, but got VT
		//IL_02e7: Expected I, but got Obj
		//IL_0394: Expected F4, but got Obj
		//IL_038f: Expected native int or pointer, but got VT
		//IL_03a9: Expected F4, but got I
		//IL_03a4: Expected native int or pointer, but got VT
		//IL_03b8: Expected I4, but got VT
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_046b: Expected Obj, but got VT
		//IL_0480: Expected F4, but got Obj
		//IL_047b: Expected native int or pointer, but got VT
		//IL_049a: Expected F4, but got Obj
		//IL_0495: Expected native int or pointer, but got VT
		//IL_04af: Expected F4, but got I
		//IL_04aa: Expected native int or pointer, but got VT
		//IL_04be: Expected I4, but got VT
		//IL_04c7: Expected Obj, but got VT
		//IL_04dc: Expected F4, but got Obj
		//IL_04d7: Expected native int or pointer, but got VT
		//IL_0209: Expected F4, but got Obj
		//IL_0204: Expected native int or pointer, but got VT
		//IL_021e: Expected F4, but got I
		//IL_0219: Expected native int or pointer, but got VT
		//IL_022d: Expected I4, but got VT
		//IL_0236: Expected Obj, but got VT
		//IL_024b: Expected F4, but got Obj
		//IL_0246: Expected native int or pointer, but got VT
		//IL_01bd: Expected I, but got Obj
		//IL_026a: Expected F4, but got Obj
		//IL_0265: Expected native int or pointer, but got VT
		//IL_027f: Expected F4, but got I
		//IL_027a: Expected native int or pointer, but got VT
		//IL_028e: Expected I4, but got VT
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v66 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 96);
		object obj3 = obj2 + 68;
		object obj4 = obj2 + 48;
		object obj5 = obj2 + 88;
		object obj6 = obj2 + 40;
		object obj7 = obj2 + 24;
		object obj8 = obj2 + 84;
		object obj9 = obj2 + 16;
		object obj10 = obj2 + 80;
		object obj11 = obj2 + 76;
		object obj12 = obj2 + 72;
		object obj13 = obj2 - -64;
		WeeklyHuntData.WeeklyHuntPeriodData prizeDataForPeriod = WeeklyHuntManager.GetPrizeDataForPeriod(_currentPeriod);
		if ((nint)prizeDataForPeriod != 1)
		{
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v53 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v102 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WeeklyHuntData.WeeklyHuntPeriodData prizeDataForPeriod2 = WeeklyHuntManager.GetPrizeDataForPeriod(_currentPeriod);
			if (prizeDataForPeriod2 != null)
			{
				nint num5 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v59 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num6 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v98 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				WeeklyHuntData.WeeklyHuntPeriodData prizeDataForPeriod3 = WeeklyHuntManager.GetPrizeDataForPeriod(_currentPeriod);
				if ((nint)prizeDataForPeriod3 != 2)
				{
					return;
				}
				nint num7 = (nint)typeof(GlobalColorsGenerated);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v67 (Il2CppClass<GlobalColorsGenerated>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num8 = (nint)typeof(GlobalColorsGenerated);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v92 (Il2CppClass<GlobalColorsGenerated>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_PROGRESSBAR_BG;
				obj11 = obj3;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_activeProgressBg.rawPivot = (UIWidget.Pivot)matrix4x;
				obj6 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_PROGRESSBAR_FG;
				obj12 = obj6;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
				Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_activeProgressFg.rawPivot = (UIWidget.Pivot)matrix4x;
				obj9 = GlobalColorsGenerated.WEEKLYHUNT_ACTIVE_PROGRESSBAR_TEXT;
				obj13 = obj9;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
				Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				_activeProgressText.rawPivot = (UIWidget.Pivot)matrix4x;
				return;
			}
		}
		nint num9 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v21 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num10 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v46 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_PROGRESSBAR_BG;
		obj5 = obj3;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_activeProgressBg.rawPivot = (UIWidget.Pivot)matrix4x;
		obj6 = GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_PROGRESSBAR_FG;
		obj8 = obj6;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_activeProgressFg.rawPivot = (UIWidget.Pivot)matrix4x;
		obj9 = GlobalColorsGenerated.WEEKLYHUNT_INACTIVE_PROGRESSBAR_TEXT;
		obj10 = obj9;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_activeProgressText.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	public void RefreshProgressBar(int currentItemAmount, int totalItemAmount)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I4
		//IL_01cc: Expected I, but got Obj
		//IL_01e2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = currentItemAmount;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_rewardHeader).FindKernel((string)null) != 0)
		{
			if (totalItemAmount != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				_ = 0;
				object obj6 = default;
				object obj5 = obj6 + 16;
				obj5 = obj2;
				throw new ArrayTypeMismatchException();
			}
			UILabel prizeLabel = _prizeLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			prizeLabel.fontSize = 0;
			UILabel rewardHeader = _rewardHeader;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			rewardHeader.fontSize = 0;
		}
	}

	private unsafe void SetObjectVisibility(bool visible)
	{
		//IL_03ce: Expected I, but got Obj
		//IL_03e4: Expected Obj, but got I
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected Obj, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected Obj, but got Unknown
		//IL_066e: Expected I, but got Obj
		//IL_0684: Expected Obj, but got I
		//IL_0111: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0480: Expected Obj, but got I
		//IL_04a3: Expected I, but got Obj
		//IL_04b9: Expected Obj, but got I
		//IL_0076: Expected I, but got Obj
		//IL_06cb: Expected I, but got Obj
		//IL_06e1: Expected Obj, but got I
		//IL_012d: Expected I, but got Obj
		//IL_015d: Expected I, but got Obj
		//IL_0417: Expected Obj, but got I
		//IL_043a: Expected I, but got Obj
		//IL_0450: Expected Obj, but got I
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected VT, but got Unknown
		//IL_071a: Expected F4, but got Obj
		//IL_0715: Expected native int or pointer, but got VT
		//IL_072f: Expected F4, but got I
		//IL_072a: Expected native int or pointer, but got VT
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected VT, but got Unknown
		//IL_074a: Expected F4, but got Obj
		//IL_0745: Expected native int or pointer, but got VT
		//IL_075f: Expected F4, but got I
		//IL_075a: Expected native int or pointer, but got VT
		//IL_0781: Expected F4, but got Obj
		//IL_077c: Expected native int or pointer, but got VT
		//IL_0796: Expected F4, but got I
		//IL_0791: Expected native int or pointer, but got VT
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected Obj, but got Unknown
		//IL_07ae: Expected Obj, but got F4
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_0806: Expected I, but got Obj
		//IL_081c: Expected Obj, but got I
		//IL_0092: Expected I, but got Obj
		//IL_00c2: Expected I, but got Obj
		//IL_04e0: Expected F4, but got Obj
		//IL_04db: Expected native int or pointer, but got VT
		//IL_04f5: Expected F4, but got I
		//IL_04f0: Expected native int or pointer, but got VT
		//IL_0502: Expected F4, but got Obj
		//IL_04fd: Expected native int or pointer, but got VT
		//IL_0517: Expected F4, but got I
		//IL_0512: Expected native int or pointer, but got VT
		//IL_0536: Expected I, but got Obj
		//IL_054c: Expected Obj, but got I
		//IL_0196: Expected I, but got Obj
		//IL_0183: Expected I, but got Obj
		//IL_0576: Expected F4, but got Obj
		//IL_0571: Expected native int or pointer, but got VT
		//IL_058b: Expected F4, but got I
		//IL_0586: Expected native int or pointer, but got VT
		//IL_0598: Expected Ref, but got VT
		//IL_0598: Expected Ref, but got VT
		//IL_05a5: Expected native int or pointer, but got VT
		//IL_05b7: Expected native int or pointer, but got VT
		//IL_05c5: Expected Obj, but got VT
		//IL_01e3: Expected I, but got Obj
		//IL_00e8: Expected I, but got Obj
		//IL_0298: Expected I, but got Obj
		//IL_02ae: Expected Obj, but got I
		//IL_0230: Expected I, but got Obj
		//IL_02d9: Expected I, but got Obj
		//IL_0340: Expected I, but got Obj
		//IL_0356: Expected Obj, but got I
		//IL_0381: Expected I, but got Obj
		nint num = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<PrizePositionData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v121 (Il2CppClass<PrizePositionData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 24;
		object obj4 = obj3 + 12;
		float p = _currentRewardRotationDuration / PrizePositionData.rewardRotationDuration;
		float t = Easings.CircularEaseIn(p);
		nint num3 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v13 (Il2CppClass<PrizePositionData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		bool flag = obj5 == null;
		if (_rewardRotationDirection < 1)
		{
			bool flag2 = !flag;
			bool flag3 = !flag2;
			nint num4 = (nint)typeof(PrizePositionData);
			if (!flag3)
			{
				nint num5 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v116 (Il2CppClass<PrizePositionData>)+74]");
				bool flag4 = (nint)0 == 0;
				bool flag5 = !flag4;
				num4 = (nint)typeof(PrizePositionData);
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(PrizePositionData);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ L2_v15 (Il2CppClass<PrizePositionData>)+5C]");
			object obj6 = (nint)0 + (nint)520;
			obj2 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v110+8]");
			_ = 0;
			nint num6 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v115 (Il2CppClass<PrizePositionData>)+5C]");
			object obj7 = (nint)0 + (nint)508;
			obj4 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v117+8]");
			_ = 0;
		}
		else
		{
			bool flag6 = !flag;
			bool flag7 = !flag6;
			nint num7 = (nint)typeof(PrizePositionData);
			if (!flag7)
			{
				nint num8 = (nint)typeof(PrizePositionData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v103 (Il2CppClass<PrizePositionData>)+74]");
				bool flag8 = (nint)0 == 0;
				bool flag9 = !flag8;
				num7 = (nint)typeof(PrizePositionData);
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num7 = (nint)typeof(PrizePositionData);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ L2_v11 (Il2CppClass<PrizePositionData>)+5C]");
			object obj8 = (nint)0 + (nint)508;
			obj2 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v97+8]");
			_ = 0;
			nint num9 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v102 (Il2CppClass<PrizePositionData>)+5C]");
			object obj9 = (nint)0 + (nint)520;
			obj4 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v104+8]");
			_ = 0;
		}
		nint num10 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v22 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v92 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj3 + 40);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)(obj3 + 56);
		((Vector3*)(nint)vector3)->x = (float)obj4;
		Vector3 vector4 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Vector3 vector5 = Vector3.LerpUnclamped(vector, vector3, t);
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Vector3 vector6 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		object obj11 = this + 140;
		obj11 = vector3.x;
		_ = vector3.z;
		object obj12 = this + 128;
		obj2 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v41+8]");
		_ = 0;
		object obj13 = this + 140;
		obj4 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v46+8]");
		_ = 0;
		nint num12 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num13 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v88 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v9+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj4;
		Vector3 vector8 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		Vector3 vector9 = vector - vector3;
		nint num14 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v53 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num15 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v84 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Vector3 vector10 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		Quaternion.Inverse_Injected(ref *(Quaternion*)vector, out *(Quaternion*)vector3);
		((Vector3*)(nint)vector3)->x = vector.x;
		((Vector3*)(nint)vector3)->z = vector.z;
		Quaternion localRotation = ((Transform)vector3).localRotation;
		float fixedDeltaTime = Time.fixedDeltaTime;
		float currentRewardRotationDuration = _currentRewardRotationDuration + fixedDeltaTime;
		_currentRewardRotationDuration = currentRewardRotationDuration;
		nint num16 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v75 (Il2CppClass<PrizePositionData>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num17 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S1_v89 (Il2CppClass<PrizePositionData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_currentRewardRotationDuration < PrizePositionData.rewardRotationDuration)
		{
			return;
		}
		int rewardRotationDirection = _rewardRotationDirection * -1;
		_rewardRotationDirection = rewardRotationDirection;
		nint num18 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v73 (Il2CppClass<PrizePositionData>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num19 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v78 (Il2CppClass<PrizePositionData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float currentRewardRotationDuration2 = _currentRewardRotationDuration - PrizePositionData.rewardRotationDuration;
		_currentRewardRotationDuration = currentRewardRotationDuration2;
	}

	private void RefreshTimerState()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_015b: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_00ec: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I4
		string text = _missedUiSprite.tag;
		((GameObject)(object)text).tag = null;
		string text2 = _completedSprite.tag;
		((GameObject)(object)text2).tag = null;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v47 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.WeeklyHuntPeriodData prizeDataForPeriod = WeeklyHuntManager.GetPrizeDataForPeriod(_currentPeriod);
		if ((nint)prizeDataForPeriod == 1)
		{
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v32 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v43 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool hiddenUntilUnlockedForPeriod = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
			bool hiddenUntilUnlockedForPeriod2 = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v27 (System.Boolean)+C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v39 (System.Boolean)+8]");
			if (num5 != 0)
			{
				string text3 = _missedUiSprite.tag;
				((GameObject)(object)text3).tag = (string)1;
			}
		}
		nint num6 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v27 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hiddenUntilUnlockedForPeriod3 = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
		bool hiddenUntilUnlockedForPeriod4 = WeeklyHuntManager.GetHiddenUntilUnlockedForPeriod(_currentPeriod);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v18 (System.Boolean)+C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v22 (System.Boolean)+8]");
		if (num8 == 0)
		{
			string text4 = _completedSprite.tag;
			((GameObject)(object)text4).tag = (string)1;
		}
	}

	private void UpdateTabs()
	{
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got VT
		//IL_014a: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v38 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 8;
		if (WeeklyHuntManager.CanSpawnToken())
		{
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v26 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v34 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime endTimeForActivePeriod = WeeklyHuntManager.GetEndTimeForActivePeriod();
			obj3 = endTimeForActivePeriod;
			obj2 = obj3;
			throw new ArrayTypeMismatchException();
		}
		_timer.HideIcon();
		_timer.ShowIcon();
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v9 (Il2CppClass<Strings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("WEEKLY_HUNT_ENDED_TIMER");
		throw new NullReferenceException();
	}

	private void TabClicked(WeeklyHuntData.PrizePeriodId tabId)
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0061: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_weeklyHuntRewardGameObject).FindKernel((string)null) != 0)
		{
			_weeklyHuntRewardGameObject.tag = (string)tabId;
		}
	}

	public WeeklyHuntPage()
	{
		int num = default;
		int num2 = default;
		while (true)
		{
			List<WeekCell> weekCellTabs = _weekCellTabs;
			if (num >= weekCellTabs._size)
			{
				break;
			}
			WeekCell weekCell = _weekCellTabs.get_Item(num);
			WeekCell weekCell2 = _weekCellTabs.get_Item(num);
			bool hasSkippedMission = weekCell2._periodId == _currentPeriod;
			((MissionCell)(object)weekCell).hasSkippedMission = hasSkippedMission;
			WeekCell weekCell3 = _weekCellTabs.get_Item(num);
			weekCell3.OnClicked();
			num = num2 + 1;
		}
		if (_currentPeriod == WeeklyHuntData.PrizePeriodId.None)
		{
			WeekCell weekCell4 = _weekCellTabs.get_Item(2);
			((MissionCell)(object)weekCell4).hasSkippedMission = true;
		}
	}

	private void _003CInit_003Eb__32_0()
	{
		_rewardRotationDirection = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private void _003CInit_003Eb__32_1(string s)
	{
		//IL_000a: Expected I4, but got Obj
		_currentPeriod = (WeeklyHuntData.PrizePeriodId)s;
		Update();
	}

	private GameObject _003CInit_003Eb__32_2(UIWidget w)
	{
		//IL_010f: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c2: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_topPrefab))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8DFD");
			GameObject result = default;
			return result;
		}
		string exception = "No slot for item" + (string)(object)w;
		nint num3 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v11 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v16 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
		return null;
	}
}
