using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;

namespace SYBO.Common.Benchmarking;

public class MemoryMetric : BenchmarkMetric<int>
{
	public override void Sample()
	{
		//IL_0023: Expected Obj, but got I
		int currentMemoryUsage = DeviceUtility.GetCurrentMemoryUsage();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+8]");
		((List<int>)0).Add(currentMemoryUsage);
	}

	public override void Update(float unscaledDeltaTime)
	{
	}

	public unsafe override List<string> Serialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected I4, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected I4, but got Unknown
		//IL_0028: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		List<string> list = base.Serialize();
		int num = int.MaxValue;
		int num3 = default;
		int num7 = default;
		int num8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+8]");
			object obj3 = 0;
			int num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v7+C]");
			if ((nint)num2 >= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+8]");
			int num4 = ((List<int>)0).get_Item(num3);
			bool flag = num < num4;
			int num5 = num;
			if (!flag)
			{
				num5 = num4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.MemoryMetric)+8]");
			int num6 = ((List<int>)0).get_Item(num3);
			bool flag2 = num6 < num7;
			num7 = num7;
			if (!flag2)
			{
				num7 = num6;
			}
			num3 = num8 + 1;
			num = num5;
		}
		int num9 = obj + 12;
		string item = ((int*)num9)->ToString();
		list.Add(item);
		int num10 = obj + 8;
		string item2 = ((int*)num10)->ToString();
		list.Add(item2);
		return list;
	}
}
