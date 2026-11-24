namespace SYBO.Subway.Level;

public abstract class RandomizerHold : Selector
{
	private GameObject[] children; //Field offset: 0x18
	private int _currentRandomizedSectionIndex; //Field offset: 0x1C
	private GameObject _lastSelectedObject; //Field offset: 0x20

	protected RandomizerHold() { }

	protected override void Initialize() { }

	public override void PerformSelection(List<GameObject> objectsToVisit) { }

}

