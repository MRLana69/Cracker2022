using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Benchmarking;

public class FrameTimeAboveMetric : BenchmarkMetric<int>
{
	private float _frameTimeThreshold;

	private int _numberOfOccurences;

	public FrameTimeAboveMetric(float frameTimeThreshold)
	{
		//IL_00ab: Expected I4, but got F4
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_0174: Invalid comparison between I and F4
		//IL_0013: Expected I, but got Obj
		//IL_0101: Expected F4, but got I
		//IL_0111: Invalid comparison between I and F4
		//IL_0062: Expected F4, but got I
		//IL_0145: Invalid comparison between I and F4
		float num = (float)_numberOfOccurences + frameTimeThreshold;
		_numberOfOccurences = (int)num;
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v21 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FrameTimeAboveMetric)+14]");
		if (0f < frameTimeThreshold)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FrameTimeAboveMetric)+14]");
			float num4 = 0f;
		}
		else
		{
			float num4 = frameTimeThreshold;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FrameTimeAboveMetric)+18]");
		float num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FrameTimeAboveMetric)+18]");
		if (!(0f > frameTimeThreshold))
		{
			num5 = frameTimeThreshold;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FrameTimeAboveMetric)+18]");
		if (0f < frameTimeThreshold)
		{
		}
		float frameTimeThreshold2 = _frameTimeThreshold + 1f;
		_frameTimeThreshold = frameTimeThreshold2;
	}

	public override void Cleanup()
	{
		_ = float.MaxValue;
	}

	public override void Update(float unscaledDeltaTime)
	{
		_frameTimeThreshold = unscaledDeltaTime;
	}

	public override void Sample()
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5+8]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S2_v4 (should have been resolved before IL gen)");
		_numberOfOccurences = 0;
	}
}
