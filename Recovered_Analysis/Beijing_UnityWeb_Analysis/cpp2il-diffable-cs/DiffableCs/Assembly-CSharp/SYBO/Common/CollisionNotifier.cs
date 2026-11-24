namespace SYBO.Common;

public class CollisionNotifier : MonoBehaviour
{
	private bool _initialized; //Field offset: 0xC
	private Collider _collider; //Field offset: 0x10
	private Action<Collider> TriggerEnter; //Field offset: 0x14
	private Action<Collider> TriggerExit; //Field offset: 0x18
	public List<Collider> CollisionsEnterThisFrame; //Field offset: 0x1C
	public List<Collider> CollisionsExitThisFrame; //Field offset: 0x20

	public event Action<Collider> TriggerEnter
	{
		 add { } //Length: 23
		 remove { } //Length: 111
	}

	public event Action<Collider> TriggerExit
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public Collider Collider
	{
		 get { } //Length: 17
	}

	public CollisionNotifier() { }

	public void add_TriggerEnter(Action<Collider> value) { }

	public void add_TriggerExit(Action<Collider> value) { }

	private void Awake() { }

	public void ClearFrame() { }

	public Collider get_Collider() { }

	private void Initialize() { }

	private void OnTriggerEnter(Collider other) { }

	private void OnTriggerExit(Collider other) { }

	public void remove_TriggerEnter(Action<Collider> value) { }

	public void remove_TriggerExit(Action<Collider> value) { }

}

