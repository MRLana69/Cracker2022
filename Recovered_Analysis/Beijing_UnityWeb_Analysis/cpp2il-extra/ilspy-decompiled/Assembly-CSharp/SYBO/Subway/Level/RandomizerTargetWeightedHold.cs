using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Level.TrackEvents;
using UnityEngine;
using UnityEngine.UI;

namespace SYBO.Subway.Level;

public abstract class RandomizerTargetWeightedHold : RandomizerTargetWeighted
{
	private int _currentRandomizedSectionIndex;

	private GameObject _lastSelectedObject;

	protected override void Initialize()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 24;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public override void PerformSelection(List<GameObject> objectsToVisit)
	{
		//IL_0022: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		((Activity)(object)this).Prepare((IActivityInitializer)null);
		List<TargetWeightPair> targetWeights = base._targetWeights;
		if (targetWeights._size == 0)
		{
			return;
		}
		float num = ScrollRect.RubberDelta(0f, base._weightSum);
		object obj = 0;
		int num2 = default;
		float num3 = default;
		int num4 = default;
		while (true)
		{
			List<TargetWeightPair> targetWeights2 = base._targetWeights;
			if (num2 >= targetWeights2._size)
			{
				break;
			}
			TargetWeightPair targetWeightPair = base._targetWeights.get_Item(num2);
			if (obj == null)
			{
				num3 += targetWeightPair._weight;
				if (num < num3)
				{
					objectsToVisit.Add(targetWeightPair._target);
					obj = 1;
					goto IL_00b7;
				}
			}
			targetWeightPair._target.tag = null;
			goto IL_00b7;
			IL_00b7:
			num2 = num4 + 1;
		}
	}
}
