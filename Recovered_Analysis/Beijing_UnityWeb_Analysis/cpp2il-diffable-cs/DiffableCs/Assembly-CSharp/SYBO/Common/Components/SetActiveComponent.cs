namespace SYBO.Common.Components;

public class SetActiveComponent : MonoBehaviour
{
	private bool _toggleActiveValue; //Field offset: 0xC
	private Timing _toggleActiveTiming; //Field offset: 0x10

	public SetActiveComponent() { }

	protected void Awake() { }

	protected void CheckTiming(Timing currentUnityTiming) { }

	protected void Start() { }

}

