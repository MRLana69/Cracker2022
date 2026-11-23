using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public abstract class RandomizerHold : Selector
{
	private GameObject[] children;

	private int _currentRandomizedSectionIndex = -1;

	private GameObject _lastSelectedObject;

	protected override void Initialize()
	{
		base.Initialize();
	}

	public override void PerformSelection(List<GameObject> objectsToVisit)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0018: Expected I, but got Obj
		//IL_003d: Expected F8, but got I4
		//IL_0159: Invalid comparison between F8 and I4
		//IL_004c: Expected I4, but got F8
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(base._initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v34 (Il2CppClass<SYBO.Subway.Level.RandomizerHold>)+EC] (should have been resolved before IL gen)");
		}
		Vector3 position = _transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num2 = 0f / 2000f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num3 = Math.Abs((double)num2);
		double num4 = ((!(num3 < 2147483648.0)) ? (-2147483648.0) : ((double)num2));
		object item;
		if (num4 != (double)_currentRandomizedSectionIndex)
		{
			_currentRandomizedSectionIndex = (int)num4;
			GameObject[] array = children;
			int num5 = UnityEngine.Random.Range(0, array.Length);
			int num6 = num5 << 2;
			object obj3 = num6 + children;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S2_v16+10]");
			_lastSelectedObject = (GameObject)0;
			item = this + 32;
		}
		else
		{
			if (!(_lastSelectedObject != null))
			{
				return;
			}
			item = this + 32;
		}
		objectsToVisit.Add((GameObject)item);
	}
}
