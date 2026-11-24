using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

namespace SYBO.Common.Benchmarking;

public class FPSMetric : BenchmarkMetric<FPSReportEntry>
{
	private int _currentFrames;

	private float _totalFrameTime;

	private float _minFrameTime;

	private float _maxFrameTime;

	public override void Cleanup()
	{
		//IL_0010: Expected I4, but got F4
		_currentFrames = int.MaxValue;
	}

	public override void Update(float unscaledDeltaTime)
	{
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_0113: Invalid comparison between I4 and F4
		//IL_0013: Expected I, but got Obj
		//IL_00cb: Expected I4, but got F4
		//IL_005c: Expected F4, but got I4
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = ((!((float)_currentFrames < unscaledDeltaTime)) ? unscaledDeltaTime : ((float)_currentFrames));
		_currentFrames = (int)num3;
		float totalFrameTime = _totalFrameTime;
		if (!(_totalFrameTime > unscaledDeltaTime))
		{
			totalFrameTime = unscaledDeltaTime;
		}
		_totalFrameTime = totalFrameTime;
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
		_currentFrames = 0;
		_totalFrameTime = 0f;
		_minFrameTime = float.MaxValue;
		_maxFrameTime = 0f;
	}

	public override List<string> Serialize()
	{
		//IL_024d: Expected Obj, but got F4
		//IL_001e: Expected Obj, but got I
		//IL_01a2: Expected I4, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_005d: Expected Obj, but got F4
		//IL_01f1: Expected Obj, but got F4
		//IL_0092: Expected Obj, but got I
		//IL_0224: Expected Obj, but got F4
		//IL_00ed: Expected Obj, but got I
		//IL_00ff: Expected I, but got Obj
		//IL_0115: Expected Obj, but got I
		//IL_00cf: Expected I4, but got Obj
		//IL_02c9: Expected Obj, but got I
		//IL_0140: Expected I, but got Obj
		object obj = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FPSMetric)+8]");
		object obj2 = 0;
		float num = float.MaxValue;
		int num3 = default;
		float num9 = default;
		int num10 = default;
		while (true)
		{
			int num2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v18+C]");
			if ((nint)num2 >= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FPSMetric)+8]");
			float num4 = ((List<float>)0).get_Item(num3);
			float num5 = num4 * 1000f;
			obj = num5;
			OverflowException value = new OverflowException();
			StringBuilder stringBuilder2 = stringBuilder.AppendLine((string)(object)value);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v18+C]");
			object obj3 = -1;
			if (num3 < (nint)obj3)
			{
				CharacterController charactercontroller = Game.Charactercontroller;
				StringBuilder stringBuilder3 = stringBuilder.Append((int)charactercontroller);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FPSMetric)+8]");
			float num6 = ((List<float>)0).get_Item(num3);
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v45 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v61 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(num < num6))
			{
				num = num6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FPSMetric)+8]");
			num9 = ((List<float>)0).get_Item(num3);
			if (num9 > num9)
			{
				num3 = num10 + 1;
			}
		}
		CharacterController charactercontroller2 = Game.Charactercontroller;
		StringBuilder stringBuilder4 = stringBuilder.Append((int)charactercontroller2);
		StringBuilder stringBuilder5 = stringBuilder.Append(48);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item = default;
		list.Add(item);
		float num11 = num * 1000f;
		obj = num11;
		OverflowException item2 = new OverflowException();
		list.Add((string)(object)item2);
		float num12 = num9 * 1000f;
		obj = num12;
		OverflowException item3 = new OverflowException();
		list.Add((string)(object)item3);
		return list;
	}

	public FPSMetric()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		float num = _totalFrameTime / (float)_currentFrames;
		float num2 = 1f / num;
		_ = _minFrameTime;
		_ = _maxFrameTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		_currentFrames = 0;
		_totalFrameTime = 0f;
		_minFrameTime = float.MaxValue;
		_maxFrameTime = 0f;
	}
}
