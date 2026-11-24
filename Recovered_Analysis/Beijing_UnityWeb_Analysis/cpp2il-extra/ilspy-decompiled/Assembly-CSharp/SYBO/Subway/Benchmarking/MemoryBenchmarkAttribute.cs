using System;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Benchmarking;

public class MemoryBenchmarkAttribute : Attribute
{
	public MemoryBenchmarkAttribute()
	{
		//IL_0207: Expected Obj, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_024e: Expected Obj, but got I8
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_0281: Invalid comparison between I and F4
		//IL_00d6: Expected I, but got Obj
		//IL_0125: Expected F4, but got I
		//IL_014d: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_019b: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got I
		//IL_0318: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+8]");
		long elapsedTicks = ((Stopwatch)0).ElapsedTicks;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+34]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+35]");
			if ((nint)0 != 0)
			{
				_ = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+36]");
				if ((nint)0 != 0)
				{
					object obj = this - -64;
					object obj2 = elapsedTicks - obj;
					float num = (float)obj2 * 0.001f;
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num3 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v47 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+54]");
					if (0f > num)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+54]");
						float num4 = 0f;
					}
					else
					{
						float num4 = num;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+50]");
					float num5 = 0f + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+50]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+38]");
					if (num6 >= 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+4C]");
						object obj4 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+48]");
						object obj5 = (nint)0 + (nint)16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+4C]");
						object obj6 = (nint)0 << 2;
						object obj7 = obj5 + obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+54]");
						obj7 = 0;
						_ = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+48]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+4C]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v32+C]");
						if (num7 >= 0)
						{
							_ = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+50]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+38]");
						object obj9 = num8 - 0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.MemoryBenchmarkAttribute)+C]");
				float num9 = 0f + 1f;
			}
		}
		object obj10 = this - -64;
		obj10 = elapsedTicks;
	}
}
