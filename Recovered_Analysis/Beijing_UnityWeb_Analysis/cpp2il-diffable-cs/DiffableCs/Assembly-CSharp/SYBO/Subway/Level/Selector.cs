namespace SYBO.Subway.Level;

public class Selector : MonoBehaviour
{
	private bool _initialized; //Field offset: 0xC
	protected Transform _transform; //Field offset: 0x10
	private Action<List<Selector>> PerformingSelection; //Field offset: 0x14

	internal event Action<List<Selector>> PerformingSelection
	{
		 add { } //Length: 79
		 remove { } //Length: 111
	}

	public bool Initialized
	{
		 get { } //Length: 6
	}

	public Selector() { }

	internal void add_PerformingSelection(Action<List<Selector>> value) { }

	protected virtual void Awake() { }

	public bool get_Initialized() { }

	protected virtual void Initialize() { }

	protected void InitializeCheck() { }

	private void OnDisable() { }

	public virtual void PerformSelection(List<GameObject> objectsToVisit) { }

	public void PerformSelection(List<GameObject> objectsToVisit, List<Selector> subSelectors) { }

	internal void remove_PerformingSelection(Action<List<Selector>> value) { }

	protected virtual void Start() { }

}

