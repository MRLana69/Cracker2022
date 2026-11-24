using System.Collections.Generic;
using SYBO.Subway.Level.TrackEvents;
using UnityEngine;

namespace SYBO.Subway.Level;

public class RandomizerTargetWeighted : Selector
{
	private List<TargetWeightPair> _targetWeights;

	private float _weightSum;

	protected override void Initialize()
	{
	}

	public override void PerformSelection(List<GameObject> objectsToVisit)
	{
		((Activity)(object)this).Prepare((IActivityInitializer)null);
		List<TargetWeightPair> targetWeights = _targetWeights;
		int num = Random.RandomRangeInt(0, targetWeights._size);
		int num2 = 0;
		while (true)
		{
			List<TargetWeightPair> targetWeights2 = _targetWeights;
			if (num2 < targetWeights2._size)
			{
				GameObject gameObject = ((List<GameObject>)(object)_targetWeights).get_Item(num2);
				if (num2 == num)
				{
					objectsToVisit.Add(gameObject);
				}
				else
				{
					gameObject.tag = null;
				}
				int num3 = num2 + 1;
				num2 = num3;
				continue;
			}
			break;
		}
	}

	public RandomizerTargetWeighted()
	{
		InitializeCheck();
		int num = default;
		int num2 = default;
		while (true)
		{
			List<TargetWeightPair> targetWeights = _targetWeights;
			if (num < targetWeights._size)
			{
				TargetWeightPair targetWeightPair = _targetWeights.get_Item(num2);
				float weightSum = _weightSum + targetWeightPair._weight;
				_weightSum = weightSum;
				num = num2 + 1;
				continue;
			}
			break;
		}
	}
}
