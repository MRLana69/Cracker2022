//Type is in global namespace

public class PickupDefault : MonoBehaviour
{
	public delegate ActivateDelegate
	{

		public ActivateDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public MeshRenderer meshRenderer; //Field offset: 0xC
	public Glow glow; //Field offset: 0x10
	public MeshRenderer[] rings; //Field offset: 0x14
	public bool ShouldSpawnParticles; //Field offset: 0x18
	private Collider parentCollider; //Field offset: 0x1C
	public ActivateDelegate ActivatePickup; //Field offset: 0x20
	private bool <IsActive>k__BackingField; //Field offset: 0x24

	public bool IsActive
	{
		 get { } //Length: 101
		private set { } //Length: 110
	}

	public bool IsVisible
	{
		 get { } //Length: 9
	}

	public PickupDefault() { }

	public void Activate() { }

	private void Awake() { }

	public static PickupType ConvertSubclassInstanceToPickupType(PickupDefault pickupDefault) { }

	public void Deactivate() { }

	private Collider FindParentCollider(Transform current) { }

	public bool get_IsActive() { }

	public bool get_IsVisible() { }

	private void OnActivate() { }

	private void OnDeactivate() { }

	private void OnValidate() { }

	private void set_IsActive(bool value) { }

	private void SetVisible(bool isVisible) { }

}

