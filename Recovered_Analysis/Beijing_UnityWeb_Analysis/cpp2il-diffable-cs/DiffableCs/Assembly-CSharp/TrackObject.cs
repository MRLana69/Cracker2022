//Type is in global namespace

public class TrackObject : MonoBehaviour
{
	private bool _debugActivateOnStart; //Field offset: 0xC
	private bool _initialized; //Field offset: 0xD
	private Transform _transform; //Field offset: 0x10
	private bool _active; //Field offset: 0x14
	private TrackObject[] _childTrackObjects; //Field offset: 0x18
	private Action OnActivate; //Field offset: 0x1C
	private Action OnDeactivate; //Field offset: 0x20
	private bool _propagateActivationStateToChildren; //Field offset: 0x24

	public event Action OnActivate
	{
		 add { } //Length: 19
		 remove { } //Length: 111
	}

	public event Action OnDeactivate
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public bool Active
	{
		 get { } //Length: 14
	}

	public bool PropagateActivationStateToChildren
	{
		 get { } //Length: 9
		 set { } //Length: 111
	}

	public Transform Transform
	{
		 get { } //Length: 6
	}

	public TrackObject() { }

	public void Activate() { }

	private void ActivateChildren() { }

	public void add_OnActivate(Action value) { }

	public void add_OnDeactivate(Action value) { }

	private void Awake() { }

	public void Deactivate() { }

	private void DeactivateChildren() { }

	public bool get_Active() { }

	public bool get_PropagateActivationStateToChildren() { }

	public Transform get_Transform() { }

	public void Hack_PropagateActivationStateToChildrenImmediately() { }

	private void InitializeCheck() { }

	public void remove_OnActivate(Action value) { }

	public void remove_OnDeactivate(Action value) { }

	public void set_PropagateActivationStateToChildren(bool value) { }

	private void Start() { }

}

