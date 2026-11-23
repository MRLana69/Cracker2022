using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;

namespace SYBO.Common.Benchmarking;

public class FPSMetric : BenchmarkMetric<FPSReportEntry>
{
	private int _currentFrames;

	private float _totalFrameTime;

	private float _minFrameTime = float.MaxValue;

	private float _maxFrameTime;

	public override void Cleanup()
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v3 (Il2CppRgctx<SYBO.Common.Benchmarking.BenchmarkMetric`1<SYBO.Common.Benchmarking.FPSReportEntry>>)+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S2_v4+4] (should have been resolved before IL gen)");
		_currentFrames = 0;
		_maxFrameTime = 0f;
		_minFrameTime = float.MaxValue;
	}

	public override void Update(float unscaledDeltaTime)
	{
		float totalFrameTime = _totalFrameTime + unscaledDeltaTime;
		_totalFrameTime = totalFrameTime;
		float minFrameTime = _minFrameTime;
		if (!(unscaledDeltaTime > _minFrameTime))
		{
			minFrameTime = unscaledDeltaTime;
		}
		_minFrameTime = minFrameTime;
		float num = _maxFrameTime;
		if (!(unscaledDeltaTime < _maxFrameTime))
		{
			num = unscaledDeltaTime;
		}
		bool flag = unscaledDeltaTime > num;
		float maxFrameTime = unscaledDeltaTime;
		if (!flag)
		{
			maxFrameTime = num;
		}
		_maxFrameTime = maxFrameTime;
		int currentFrames = _currentFrames + 1;
		_currentFrames = currentFrames;
	}

	public override void Sample()
	{
		//IL_0068: Expected Obj, but got I
		FPSReportEntry fPSReportEntry = default;
		fPSReportEntry.MaxFrameTime = _maxFrameTime;
		fPSReportEntry.MinFrameTime = _minFrameTime;
		float num = _totalFrameTime / (float)_currentFrames;
		float avgFPS = 1f / num;
		fPSReportEntry.AvgFPS = avgFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FPSMetric)+8]");
		((List<FPSReportEntry>)0).Add(fPSReportEntry);
		_currentFrames = 0;
		_maxFrameTime = 0f;
		_minFrameTime = float.MaxValue;
	}

	public unsafe override List<string> Serialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a5: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_005e: Expected Ref, but got F4
		//IL_008e: Expected Obj, but got I
		//IL_01a8: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_0209: Expected Ref, but got F4
		//IL_023d: Expected Ref, but got F4
		//IL_0271: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FPSMetric)+8]");
		object obj3 = 0;
		float num = float.MaxValue;
		int num3 = default;
		float num4 = default;
		float num6 = default;
		int num8 = default;
		while (true)
		{
			int num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14+C]");
			if ((nint)num2 >= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FPSMetric)+8]");
			FPSReportEntry fPSReportEntry = ((List<FPSReportEntry>)0).get_Item(num3);
			num4 += fPSReportEntry.AvgFPS;
			float num5 = (float)fPSReportEntry + 8f;
			string value = ((float*)num5)->ToString("0.00");
			StringBuilder stringBuilder2 = stringBuilder.Append(value);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14+C]");
			object obj4 = -1;
			if (num3 < (nint)obj4)
			{
				char separatorCharacter = Benchmark.SeparatorCharacter;
				StringBuilder stringBuilder3 = stringBuilder.Append(separatorCharacter);
			}
			bool flag = fPSReportEntry.AvgFPS < num6;
			num6 = num6;
			if (!flag)
			{
				num6 = fPSReportEntry.AvgFPS;
			}
			bool flag2 = num < fPSReportEntry.AvgFPS;
			float num7 = num;
			if (!flag2)
			{
				num7 = fPSReportEntry.AvgFPS;
			}
			num3 = num8 + 1;
			num = num7;
		}
		char separatorCharacter2 = Benchmark.SeparatorCharacter;
		StringBuilder stringBuilder4 = stringBuilder.Append(separatorCharacter2);
		StringBuilder stringBuilder5 = stringBuilder.Append("0");
		char separatorCharacter3 = Benchmark.SeparatorCharacter;
		StringBuilder stringBuilder6 = stringBuilder.Append(separatorCharacter3);
		StringBuilder stringBuilder7 = stringBuilder.Append("60");
		List<string> list = default;
		list._002Ector();
		nint num9 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ S2_v7 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string item = default;
		list.Add(item);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FPSMetric)+8]");
		object obj5 = 0;
		float num10 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S2_v12+C]");
		float num11 = num10 / 0f;
		float num12 = (float)obj + 4f;
		string item2 = ((float*)num12)->ToString("0.00");
		list.Add(item2);
		float num13 = (float)obj + 12f;
		string item3 = ((float*)num13)->ToString("0.00");
		list.Add(item3);
		float num14 = (float)obj + 8f;
		string item4 = ((float*)num14)->ToString("0.00");
		list.Add(item4);
		return list;
	}
}
