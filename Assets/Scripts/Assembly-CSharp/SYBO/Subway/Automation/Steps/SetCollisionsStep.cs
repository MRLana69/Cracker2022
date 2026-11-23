using SYBO.Common.Automation.Steps;
using UnityEngine;

namespace SYBO.Subway.Automation.Steps;

public class SetCollisionsStep(bool enable) : AutomationStep
{
	private bool _enable = enable;

	public override void Update(float unscaledDeltaTime)
	{
		Layers instance = Layers.Instance;
		Layers instance2 = Layers.Instance;
		bool ignore = (byte)(~(_enable ? 1u : 0u)) != 0;
		Physics.IgnoreLayerCollision(instance.Character, instance2.Hit, ignore);
		Layers instance3 = Layers.Instance;
		Layers instance4 = Layers.Instance;
		bool ignore2 = (byte)(~(_enable ? 1u : 0u)) != 0;
		Physics.IgnoreLayerCollision(instance3.Character, instance4.Pickup, ignore2);
		base.IsDone__BackingField = true;
	}
}
