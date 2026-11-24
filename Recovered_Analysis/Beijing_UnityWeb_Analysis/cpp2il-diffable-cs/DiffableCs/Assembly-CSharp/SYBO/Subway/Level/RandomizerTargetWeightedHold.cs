namespace SYBO.Subway.Level;

public abstract class RandomizerTargetWeightedHold : RandomizerTargetWeighted
{
	private int _currentRandomizedSectionIndex; //Field offset: 0x20
	private GameObject _lastSelectedObject; //Field offset: 0x24

	protected RandomizerTargetWeightedHold() { }

	protected override void Initialize() { }

	public override void PerformSelection(List<GameObject> objectsToVisit) { }

}

