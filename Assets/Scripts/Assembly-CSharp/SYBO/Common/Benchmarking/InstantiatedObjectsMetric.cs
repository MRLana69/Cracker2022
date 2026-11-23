using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Benchmarking;

public class InstantiatedObjectsMetric : BenchmarkMetric<int>
{
	private int _instantiatedObjectsCount;

	private bool _reportObjectNames;

	private StringBuilder _instantiatedObjectsString;

	private List<string> _stringEntries;

	public InstantiatedObjectsMetric(bool reportObjectNames = false)
	{
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		_instantiatedObjectsString = stringBuilder;
		List<string> list = default;
		list._002Ector();
		_stringEntries = list;
		_reportObjectNames = reportObjectNames;
	}

	public override void Initialize(int initialSampleCount)
	{
		base.Initialize(initialSampleCount);
		throw new ArgumentException();
	}

	public override void Cleanup()
	{
		//IL_0081: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v3 (Il2CppRgctx<SYBO.Common.Benchmarking.BenchmarkMetric`1<System.Int32>>)+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S2_v4+4] (should have been resolved before IL gen)");
		throw new ArgumentException();
	}

	private void PoolManager_OnObjectInstantiated(Transform transform)
	{
		int instantiatedObjectsCount = _instantiatedObjectsCount + 1;
		_instantiatedObjectsCount = instantiatedObjectsCount;
		if (~(_reportObjectNames ? 1u : 0u) == 0)
		{
			string name = transform.name;
			StringBuilder stringBuilder = _instantiatedObjectsString.Append(name);
			StringBuilder stringBuilder2 = _instantiatedObjectsString.Append(',');
		}
	}

	public override void Update(float unscaledDeltaTime)
	{
	}

	public override void Sample()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_017d: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.InstantiatedObjectsMetric)+8]");
		((List<int>)0).Add(_instantiatedObjectsCount);
		_instantiatedObjectsCount = 0;
		if (~(_reportObjectNames ? 1u : 0u) == 0)
		{
			StringBuilder instantiatedObjectsString = _instantiatedObjectsString;
			object obj3 = instantiatedObjectsString.m_ChunkOffset + instantiatedObjectsString.m_ChunkLength;
			if ((nint)obj3 >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
		}
	}

	public override List<string> Serialize()
	{
		//IL_00d0: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I4
		List<string> list = base.Serialize();
		if (~(_reportObjectNames ? 1u : 0u) == 0)
		{
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector();
			List<string> stringEntries = _stringEntries;
			int num = 0;
			while (num < stringEntries._size)
			{
				string value = _stringEntries.get_Item(num);
				StringBuilder stringBuilder2 = stringBuilder.Append(value);
				object obj = stringEntries._size - 1;
				if (num < (nint)obj)
				{
					char separatorCharacter = Benchmark.SeparatorCharacter;
					StringBuilder stringBuilder3 = stringBuilder.Append(separatorCharacter);
				}
				int num2 = num + 1;
				num = num2;
			}
			nint num3 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S2_v4 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			string item = default;
			list.Add(item);
		}
		return list;
	}
}
