namespace SYBO.Subway.Level;

public class RandomizerTargetWeighted : Selector
{
	private List<TargetWeightPair> _targetWeights; //Field offset: 0x18
	private float _weightSum; //Field offset: 0x1C

	public RandomizerTargetWeighted() { }

	protected override void Initialize() { }

	public override void PerformSelection(List<GameObject> objectsToVisit) { }

}

