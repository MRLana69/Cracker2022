using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;

namespace SYBO.Common.Benchmarking;

public class DeltaFrameTimeMetric : BenchmarkMetric<float>
{
	private float _minFrameTime = float.MaxValue;

	private float _maxFrameTime;

	public override void Cleanup()
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v3 (Il2CppRgctx<SYBO.Common.Benchmarking.BenchmarkMetric`1<System.Single>>)+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S2_v4+4] (should have been resolved before IL gen)");
		_maxFrameTime = 0f;
		_minFrameTime = float.MaxValue;
	}

	public override void Update(float unscaledDeltaTime)
	{
		float minFrameTime = _minFrameTime;
		if (!(unscaledDeltaTime > _minFrameTime))
		{
			minFrameTime = unscaledDeltaTime;
		}
		_minFrameTime = minFrameTime;
		float maxFrameTime = _maxFrameTime;
		if (!(unscaledDeltaTime < _maxFrameTime))
		{
			maxFrameTime = unscaledDeltaTime;
		}
		_maxFrameTime = maxFrameTime;
	}

	public override void Sample()
	{
		//IL_002d: Expected Obj, but got I
		float item = _maxFrameTime - _minFrameTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+8]");
		((List<float>)0).Add(item);
		_maxFrameTime = 0f;
		_minFrameTime = float.MaxValue;
	}

	public unsafe override List<string> Serialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002c: Expected Obj, but got I
		//IL_018c: Expected I, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_0086: Expected Ref, but got F4
		//IL_01db: Expected Ref, but got F4
		//IL_00b6: Expected Obj, but got I
		//IL_0224: Expected Ref, but got F4
		//IL_0111: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		List<string> list = default;
		list._002Ector();
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+8]");
		object obj3 = 0;
		float num = float.MaxValue;
		int num3 = default;
		float num10 = default;
		int num11 = default;
		while (true)
		{
			int num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+C]");
			if ((nint)num2 >= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+8]");
			float num4 = ((List<float>)0).get_Item(num3);
			float num5 = num4 * 1000f;
			float num6 = (float)obj + 12f;
			string value = ((float*)num6)->ToString("0.0");
			StringBuilder stringBuilder2 = stringBuilder.Append(value);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+C]");
			object obj4 = -1;
			if (num3 < (nint)obj4)
			{
				char separatorCharacter = Benchmark.SeparatorCharacter;
				StringBuilder stringBuilder3 = stringBuilder.Append(separatorCharacter);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+8]");
			float num7 = ((List<float>)0).get_Item(num3);
			bool flag = num < num7;
			float num8 = num;
			if (!flag)
			{
				num8 = num7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+8]");
			float num9 = ((List<float>)0).get_Item(num3);
			bool flag2 = num9 < num10;
			num10 = num10;
			if (!flag2)
			{
				num10 = num9;
			}
			num3 = num11 + 1;
			num = num8;
		}
		char separatorCharacter2 = Benchmark.SeparatorCharacter;
		StringBuilder stringBuilder4 = stringBuilder.Append(separatorCharacter2);
		StringBuilder stringBuilder5 = stringBuilder.Append('0');
		nint num12 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v106 @ S2_v5 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string item = default;
		list.Add(item);
		float num13 = num * 1000f;
		float num14 = (float)obj + 12f;
		string item2 = ((float*)num14)->ToString("0.0");
		list.Add(item2);
		float num15 = num10 * 1000f;
		float num16 = (float)obj + 12f;
		string item3 = ((float*)num16)->ToString("0.0");
		list.Add(item3);
		return list;
	}
}
