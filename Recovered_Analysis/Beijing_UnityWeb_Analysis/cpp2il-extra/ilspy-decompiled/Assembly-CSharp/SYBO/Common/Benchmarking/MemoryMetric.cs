using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility;
using SYBO.Subway;
using UnityEngine;

namespace SYBO.Common.Benchmarking;

public class MemoryMetric : BenchmarkMetric<int>
{
	public override void Sample()
	{
		//IL_0187: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_0032: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+C]");
		((List<int>)num).Add(0);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+14]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16+10]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16+14]");
			object obj2 = num2 + 0;
			if ((nint)obj2 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
		}
	}

	public override void Update(float unscaledDeltaTime)
	{
	}

	public override List<string> Serialize()
	{
		//IL_002d: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0080: Expected Obj, but got I
		//IL_00bd: Expected I4, but got Obj
		List<string> list = base.Serialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			System.Text.StringBuilderCache.Release(stringBuilder);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+18]");
			object obj = 0;
			int num = 0;
			while (true)
			{
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v17+C]");
				if ((nint)num2 >= (nint)0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+18]");
				string value = ((List<string>)0).get_Item(num);
				StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v17+C]");
				object obj2 = -1;
				if (num < (nint)obj2)
				{
					CharacterController charactercontroller = Game.Charactercontroller;
					StringBuilder stringBuilder3 = stringBuilder.Append((int)charactercontroller);
				}
				int num3 = num + 1;
				num = num3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string item = default;
			list.Add(item);
		}
		return list;
	}

	public MemoryMetric()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v9 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int peakMemoryUsage = DeviceUtility.GetPeakMemoryUsage();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+8]");
		((List<int>)0).Add(peakMemoryUsage);
	}
}
