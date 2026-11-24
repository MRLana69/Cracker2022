//Type is in global namespace

public class CharacterPassTrigger : TrackEventTrigger
{
	private Transform _transform; //Field offset: 0xC
	private BoxCollider _collider; //Field offset: 0x10
	private EventHandler Triggered; //Field offset: 0x14

	public event EventHandler Triggered
	{
		 add { } //Length: 2
		 remove { } //Length: 111
	}

	public float EndPosition
	{
		 get { } //Length: 7
	}

	public CharacterPassTrigger() { }

	public void add_Triggered(EventHandler value) { }

	private void Awake() { }

	public float get_EndPosition() { }

	protected void OnDrawGizmosSelected() { }

	private void OnTriggerEnter(Collider other) { }

	public void remove_Triggered(EventHandler value) { }

}

