using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Automation;
using SYBO.Common.Automation.Steps;
using SYBO.Common.Benchmarking;
using SYBO.Subway.Automation.Steps;
using UI.Screens;

namespace SYBO.Subway.Benchmarking;

public class SubwayMemoryBenchmark : SubwayBenchmark
{
	private static string[] Popups;

	private static string[] Screens;

	private const int CycleCount = 3;

	private const int UIRepeatCount = 10;

	private const float DurationSeconds = 180f;

	private const float SampleInterval = 6f;

	private bool _forceAllCharacters;

	private bool _forceAllBoards;

	public override bool RequiresConfirmation => true;

	public override string ConfirmationMessage => "This benchmark will take around 15 minutes to complete. Please ensure that the device is connected to a charger during this test.";

	public SubwayMemoryBenchmark(bool forceAllCharacters, bool forceAllBoards)
	{
		IAutomationStep[] array = GenerateCompleteMemoryTestSteps(3, 10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		MemoryMetric memoryMetric = default;
		memoryMetric._002Ector();
		throw new ArrayTypeMismatchException();
	}

	public override void Initialize()
	{
		//IL_0059: Expected I4, but got I8
		Globals.DEBUG_DISPLAY_ALL_CHARS = _forceAllCharacters;
		CharacterScreen.forceRefreshOnCharacterScreen = true;
		Globals.DEBUG_DISPLAY_ALL_BOARDS = _forceAllBoards;
		BoardScreenManager instance = BoardScreenManager.Instance;
		instance.forceRefreshOnBoardScreen__BackingField = true;
		if (!Globals.DEBUG_USE_CELEBRATION_TESTER)
		{
			int rewardsToUnlockCount = RewardManager.rewardsToUnlockCount;
			if (rewardsToUnlockCount <= 0)
			{
				CelebrationReward celebrationReward = default;
				celebrationReward._002Ector();
				celebrationReward.amount = 1;
				celebrationReward.CelebrationRewardOrigin = CelebrationRewardOrigin.MysteryBox;
				RewardManager.AddRewardToUnlock(celebrationReward, shouldSaveToDisk: false);
			}
		}
		base.Initialize();
	}

	private static IAutomationStep[] GenerateCompleteMemoryTestSteps(int totalRepeatCount, int uiRepeatCount)
	{
		//IL_0077: Expected Obj, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
		//IL_009a: Expected Obj, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		object obj = uiRepeatCount + 1;
		int capacity = totalRepeatCount * obj;
		List<IAutomationStep> list = default;
		list._002Ector(capacity);
		object obj2 = 0;
		IAutomationStep item2 = default;
		while (totalRepeatCount > (nint)obj2)
		{
			IAutomationStep item = GenerateUICompoundSteps(uiRepeatCount);
			list.Add(item);
			_ = 180f;
			list.Add(item2);
			object obj3 = obj2 + 1;
			obj2 = obj3;
		}
		return list.ToArray();
	}

	private static IAutomationStep GenerateUICompoundSteps(int count)
	{
		//IL_0071: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj = 0;
		if (count > (nint)obj)
		{
			CompoundAutomationStep compoundAutomationStep = GenerateSingleUICompoundStep();
			throw new ArrayTypeMismatchException();
		}
		IAutomationStep result = default;
		return result;
	}

	private static CompoundAutomationStep GenerateSingleUICompoundStep()
	{
		//IL_014c: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		string[] popups = Popups;
		string[] screens = Screens;
		object obj = popups.Length + screens.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		string[] popups2 = Popups;
		object obj2 = default;
		bool flag = popups2.Length > (nint)obj2;
		bool flag2 = !flag;
		object obj3 = 0;
		if (!flag2)
		{
			object obj4 = obj2 << 2;
			object obj5 = (object)Popups + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v59+10]");
			OpenCloseUIElementStep openCloseUIElementStep = default;
			openCloseUIElementStep._002Ector(OpenCloseUIElementStep.UIElementType.Popup, (string)0);
			throw new ArrayTypeMismatchException();
		}
		string[] screens2 = Screens;
		if (screens2.Length > (nint)obj3)
		{
			string[] popups3 = Popups;
			object obj6 = obj3 << 2;
			object obj7 = (object)Screens + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v43+10]");
			OpenCloseUIElementStep openCloseUIElementStep2 = default;
			openCloseUIElementStep2._002Ector(OpenCloseUIElementStep.UIElementType.Screen, (string)0);
			throw new ArrayTypeMismatchException();
		}
		CompoundAutomationStep compoundAutomationStep = default;
		IAutomationStep[] steps = default;
		compoundAutomationStep._steps = steps;
		return compoundAutomationStep;
	}

	static SubwayMemoryBenchmark()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
