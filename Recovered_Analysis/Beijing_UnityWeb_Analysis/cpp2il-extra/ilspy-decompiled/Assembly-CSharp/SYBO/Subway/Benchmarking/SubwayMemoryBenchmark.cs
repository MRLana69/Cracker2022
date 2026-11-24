using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Backend;
using SYBO.Common.Automation;
using SYBO.Common.Automation.Steps;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Benchmarking;

public class SubwayMemoryBenchmark : SubwayBenchmark
{
	private const int CycleCount = 3;

	private const int UIRepeatCount = 10;

	private const float DurationSeconds = 180f;

	private const float SampleInterval = 6f;

	private static string[] _popups;

	private static string[] _screens;

	private bool _forceAllCharacters;

	private bool _forceAllBoards;

	public override bool RequiresConfirmation
	{
		get
		{
			//IL_0065: Expected I, but got Obj
			//IL_007b: Expected Obj, but got I
			//IL_00c2: Expected I4, but got Obj
			//IL_0057: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SubwayBenchmarkContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CompoundAutomationStep kind = GenerateSingleUICompoundStep();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			EnvironmentBackground environmentBackground = default;
			environmentBackground.RouteChunk_OnEnvironmentSegmentSpawned((EnvironmentKind)(object)kind, (int)"1HIlWcwxXV0dVjsf0gLpgFE0B0bei1vdn2xJNTAIxFv4", (Route)(object)"https://script.google.com/macros/s/AKfycbzysbyZuNXvOTJh5llqjN4N2dP4PAXusuwfaHjvTD3ESkx5Sas/exec");
			return (byte)(int)environmentBackground != 0;
		}
	}

	public override string ConfirmationMessage
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (string)1;
		}
	}

	public SubwayMemoryBenchmark(bool forceAllCharacters, bool forceAllBoards)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0036: Expected Obj, but got I4
		object obj = this + 16;
		obj = string.Empty;
		((AutomationStepExecutor)this)._currentStepIndex = (forceAllCharacters ? 1 : 0);
		object obj2 = this + 16;
		obj2 = forceAllBoards;
	}

	public override void Initialize()
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00dd: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		nint num = (nint)typeof(SubwayBenchmarkContainer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v42 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<SubwayBenchmarkContainer.BenchmarkWrapper> benchmarks = SubwayBenchmarkContainer.Benchmarks;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = obj2;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S4_v3+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S4_v4+78]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v74 @ S5_v4 (should have been resolved before IL gen)");
		nint num5 = (nint)typeof(SubwayBenchmarkContainer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v29 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = default;
		if ((nint)obj12 <= 0)
		{
			obj12 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8695");
	}

	private static void CachePopupsAndScreens()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SubwayBenchmarkContainer.BenchmarkWrapper benchmarkWrapper = default;
		object obj = benchmarkWrapper + 8;
		obj = "Perf. Standard";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EventRemoteLogger eventRemoteLogger = default;
		eventRemoteLogger.Send(600f, 0.5f);
		object obj2 = benchmarkWrapper + 12;
		obj2 = eventRemoteLogger;
		object obj3 = benchmarkWrapper + 16;
		obj3 = "perf";
		List<SubwayBenchmarkContainer.BenchmarkWrapper> list = default;
		list.Add(benchmarkWrapper);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SubwayBenchmarkContainer.BenchmarkWrapper benchmarkWrapper2 = default;
		object obj4 = benchmarkWrapper2 + 8;
		obj4 = "Perf. Long";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EventRemoteLogger eventRemoteLogger2 = default;
		eventRemoteLogger2.Send(7200f, 6f);
		object obj5 = benchmarkWrapper2 + 12;
		obj5 = eventRemoteLogger2;
		object obj6 = benchmarkWrapper2 + 16;
		obj6 = "perf_long";
		list.Add(benchmarkWrapper2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SubwayBenchmarkContainer.BenchmarkWrapper benchmarkWrapper3 = default;
		object obj7 = benchmarkWrapper3 + 8;
		obj7 = "Memory Standard";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EnvironmentBackground environmentBackground = default;
		environmentBackground.PlaceMovingSingleObjects((List<BackgroundObject>)null, (BackgroundLayer)null);
		object obj8 = benchmarkWrapper3 + 12;
		obj8 = environmentBackground;
		object obj9 = benchmarkWrapper3 + 16;
		obj9 = "memory";
		list.Add(benchmarkWrapper3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SubwayBenchmarkContainer.BenchmarkWrapper benchmarkWrapper4 = default;
		object obj10 = benchmarkWrapper4 + 8;
		obj10 = "Memory All Chars";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EnvironmentBackground environmentBackground2 = default;
		environmentBackground2.PlaceMovingSingleObjects((List<BackgroundObject>)1, (BackgroundLayer)1);
		object obj11 = benchmarkWrapper4 + 12;
		obj11 = environmentBackground2;
		object obj12 = benchmarkWrapper4 + 16;
		obj12 = "memory_all";
		list.Add(benchmarkWrapper4);
		SubwayBenchmarkContainer.Benchmarks = list;
	}

	private static IAutomationStep[] GenerateCompleteMemoryTestSteps(int totalRepeatCount, int uiRepeatCount)
	{
		//IL_0015: Expected Obj, but got I
		//IL_002a: Expected VT, but got I4
		//IL_002a: Expected Obj, but got I
		//IL_003c: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_007d: Expected I, but got Obj
		if (uiRepeatCount != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [totalRepeatCount @ L0 (System.Int32)+60]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9+10]");
			CollisionFlags collisionFlags = ((CharacterController)0).Move((Vector3)uiRepeatCount);
			nint num = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = ((ComputeShader)collisionFlags).FindKernel(null);
			return (IAutomationStep[])num3;
		}
		return null;
	}

	private static IAutomationStep GenerateUICompoundSteps(int count)
	{
		return (IAutomationStep)(object)"This benchmark will take around 30 minutes to complete. Please ensure that the device is connected to a charger during this test.";
	}

	private static CompoundAutomationStep GenerateSingleUICompoundStep()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SubwayBenchmarkContainer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @868D");
		int index = default;
		SubwayBenchmarkContainer.BenchmarkWrapper benchmarkWrapper = SubwayBenchmarkContainer.Benchmarks.get_Item(index);
		return (CompoundAutomationStep)(object)benchmarkWrapper.ProcessorSheetNamePostfix;
	}
}
