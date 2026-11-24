using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Automation;
using SYBO.Common.Benchmarking;
using SYBO.Subway.Level;
using SYBO.Subway.Utilities;
using UnityEngine;

namespace SYBO.Subway.Benchmarking;

public class SubwayRunningBenchmark : SubwayBenchmark
{
	private const float DefaultDurationSeconds = 600f;

	private const float DefaultSampleInterval = 0.5f;

	private float _durationSeconds;

	private float _sampleInterval;

	public override bool RequiresConfirmation
	{
		get
		{
			//IL_009d: Expected Obj, but got I4
			//IL_007d: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj = 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<SubwayRunningBenchmark, UIntPtr>(ref this))
			{
				IBenchmarkMetric[] array = GenerateMetrics();
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			bool flag = default;
			object obj2 = (flag ? 1 : 0) + 8;
			object obj3 = default;
			obj2 = obj3;
			return flag;
		}
	}

	public override string ConfirmationMessage
	{
		get
		{
			//IL_0016: Expected Obj, but got I4
			bool flag = _durationSeconds > 600f;
			return (string)flag;
		}
	}

	public SubwayRunningBenchmark(float durationSeconds = 600f, float sampleInterval = 0.5f)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayRunningBenchmark)+68]");
		if ((nint)0 == 0)
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.SubwayRunningBenchmark)+6C]");
			float orthographicSize = ((Camera)0).orthographicSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj4 = default;
			object obj3 = obj4 + 16;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
			IEnumerator routine = default;
			Coroutine coroutine = ((MonoBehaviour)(object)this).StartCoroutine_Auto(routine);
		}
	}

	private static IAutomationStep[] GenerateSteps(float runLength)
	{
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_01f5: Expected I, but got Obj
		//IL_020b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got VT
		//IL_0195: Expected Obj, but got VT
		//IL_00f5: Expected I, but got Obj
		//IL_018b: Expected VT, but got Obj
		//IL_0084: Expected I, but got Obj
		nint num = (nint)typeof(DebugQueuedEnvironments);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugQueuedEnvironments);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = DebugQueuedEnvironments._nextQueueShiftPosZ > runLength;
		nint num3 = (nint)typeof(DebugQueuedEnvironments);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v5 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag2 = obj2 == null;
		_00210 val;
		if (flag)
		{
			if (!flag2)
			{
				nint num4 = (nint)typeof(DebugQueuedEnvironments);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v43 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EnvironmentKind environmentKind = DebugQueuedEnvironments._environmentQueue.Peek();
			val = (_00210)environmentKind;
		}
		else
		{
			if (!flag2)
			{
				nint num5 = (nint)typeof(DebugQueuedEnvironments);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v30 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_00210 val2 = (_00210)((Queue<T>)(object)DebugQueuedEnvironments._environmentQueue).Peek();
			DebugQueuedEnvironments._environmentQueue.Enqueue((EnvironmentKind)val2);
			float nextQueueShiftPosZ = DebugQueuedEnvironments._nextQueueShiftPosZ + 1080f;
			DebugQueuedEnvironments._nextQueueShiftPosZ = nextQueueShiftPosZ;
			val = val2;
		}
		return (IAutomationStep[])val;
	}

	private static IBenchmarkMetric[] GenerateMetrics()
	{
		//IL_01a5: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_004b: Expected I4, but got Obj
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00f7: Expected I4, but got Obj
		string[] screens = SubwayMemoryBenchmark._screens;
		string[] popups = SubwayMemoryBenchmark._popups;
		object obj = screens.Length + popups.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		string[] popups2 = SubwayMemoryBenchmark._popups;
		object obj2 = default;
		if ((nint)obj2 < popups2.Length)
		{
			object obj3 = SubwayMemoryBenchmark._popups + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SubwayMemoryBenchmark subwayMemoryBenchmark = default;
			subwayMemoryBenchmark._002Ector(forceAllCharacters: false, (byte)(int)obj5 != 0);
			throw new ArrayTypeMismatchException();
		}
		object obj6 = 0;
		string[] screens2 = SubwayMemoryBenchmark._screens;
		if ((nint)obj6 < screens2.Length)
		{
			string[] popups3 = SubwayMemoryBenchmark._popups;
			object obj7 = SubwayMemoryBenchmark._screens + 16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SubwayMemoryBenchmark subwayMemoryBenchmark2 = default;
			subwayMemoryBenchmark2._002Ector(forceAllCharacters: true, (byte)(int)obj9 != 0);
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IBenchmarkMetric[] array = default;
		object obj10 = array + 8;
		object obj11 = default;
		obj10 = obj11;
		return array;
	}
}
