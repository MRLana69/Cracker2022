using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public abstract class RandomizerTargetWeightedHold : RandomizerTargetWeighted
{
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
		//IL_0163: Invalid comparison between F8 and I4
		//IL_004c: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(((Selector)this)._initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v24 (Il2CppClass<SYBO.Subway.Level.RandomizerTargetWeightedHold>)+EC] (should have been resolved before IL gen)");
		}
		Vector3 position = _transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num2 = 0f / 2000f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num3 = Math.Abs((double)num2);
		double num4 = ((!(num3 < 2147483648.0)) ? (-2147483648.0) : ((double)num2));
		if (num4 != (double)_currentRandomizedSectionIndex)
		{
			_currentRandomizedSectionIndex = (int)num4;
			base.PerformSelection(objectsToVisit);
			if (objectsToVisit._size != objectsToVisit._size)
			{
				int index = objectsToVisit._size - 1;
				GameObject lastSelectedObject = objectsToVisit.get_Item(index);
				_lastSelectedObject = lastSelectedObject;
			}
		}
		else if (_lastSelectedObject != null)
		{
			objectsToVisit.Add(_lastSelectedObject);
		}
	}
}
