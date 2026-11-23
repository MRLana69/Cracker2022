using UnityEngine;

namespace SYBO.Components.Utilities;

public class MinMaxSliderAttribute(float min, float max) : PropertyAttribute
{
	public readonly float max = max;

	public readonly float min = min;
}
