using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class RandomizerTargetWeighted : Selector
{
	private List<TargetWeightPair> _targetWeights;

	private float _weightSum;

	protected override void Initialize()
	{
		base.Initialize();
		int num = 0;
		while (true)
		{
			List<TargetWeightPair> targetWeights = _targetWeights;
			if (num < targetWeights._size)
			{
				TargetWeightPair targetWeightPair = _targetWeights.get_Item(num);
				float weightSum = _weightSum + targetWeightPair._weight;
				_weightSum = weightSum;
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	public override void PerformSelection(List<GameObject> objectsToVisit)
	{
		//IL_000a: Expected I, but got Obj
		if (~(base._initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v20 (Il2CppClass<SYBO.Subway.Level.RandomizerTargetWeighted>)+EC] (should have been resolved before IL gen)");
		}
		List<TargetWeightPair> targetWeights = _targetWeights;
		if (targetWeights._size == 0)
		{
			return;
		}
		float num2 = Random.Range(0f, _weightSum);
		int num3 = 0;
		while (true)
		{
			List<TargetWeightPair> targetWeights2 = _targetWeights;
			if (num3 < targetWeights2._size)
			{
				TargetWeightPair targetWeightPair = _targetWeights.get_Item(num3);
				targetWeightPair._target.SetActive(value: false);
				int num4 = num3 + 1;
				num3 = num4;
				continue;
			}
			break;
		}
	}

	public RandomizerTargetWeighted()
	{
		List<TargetWeightPair> list = default;
		list._002Ector();
		_targetWeights = list;
		base._002Ector();
	}
}
