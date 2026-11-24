namespace SYBO.Subway.Coins;

public class Coin : MonoBehaviour
{
	private class CoinMagnetMovement
	{
		private Action OnComplete; //Field offset: 0x8
		private Game _game; //Field offset: 0xC
		private Character _character; //Field offset: 0x10
		private Transform _coinTransform; //Field offset: 0x14
		private bool _usedForSuperSneakers; //Field offset: 0x18
		private bool _active; //Field offset: 0x19
		private Vector3 _startPosition; //Field offset: 0x1C
		private Vector3 _endPositionOffset; //Field offset: 0x28
		private float _startTime; //Field offset: 0x34
		private float _duration; //Field offset: 0x38

		public event Action OnComplete
		{
			 add { } //Length: 8
			 remove { } //Length: 111
		}

		public CoinMagnetMovement(Transform coinTransform, Vector3 endPositionOffset, bool usedForSuperSneakers) { }

		public void Activate(float pullSpeed) { }

		public void add_OnComplete(Action value) { }

		public void remove_OnComplete(Action value) { }

		public void Reset() { }

		public void Update() { }

	}

	public const float QA_X_OFFSET = 5; //Field offset: 0x0
	private const float DEACTIVATION_Z_DISTANCE = 10; //Field offset: 0x0
	private PickupRotate _pickupRotate; //Field offset: 0xC
	private TrackObject _trackObject; //Field offset: 0x10
	private PickupDefault _pickupDefault; //Field offset: 0x14
	private CoinRenderer _coinRenderer; //Field offset: 0x18
	private Collider _collider; //Field offset: 0x1C
	private bool _active; //Field offset: 0x20
	private Character _character; //Field offset: 0x24
	private Transform _transform; //Field offset: 0x28
	private CoinCurve _curve; //Field offset: 0x2C
	private CoinMagnetMovement _coinMagnetMovement; //Field offset: 0x30
	private CoinMagnetMovement _superSneakerMagnetMovement; //Field offset: 0x34
	private bool _isInitialized; //Field offset: 0x38

	public Coin() { }

	public void Activate(bool trackObjectActivated = false) { }

	protected void Awake() { }

	public void Deactivate(bool trackObjectDeactivated = false) { }

	public void Initialize() { }

	private void MagnetMovement_OnComplete() { }

	public void MoveToMagnet(float pullSpeed) { }

	public void MoveToSuperSneakers(float pullSpeed) { }

	public void OnDestroy() { }

	public void Pickup(CharacterPickupParticles pickupParticles) { }

	public void SetCurve(CoinCurve curve) { }

	private void SuperSneakersMagnetMovement_OnComplete() { }

	public void ToggleRenderer(bool enabled) { }

	private void TrackObject_OnActivate() { }

	private void TrackObject_OnDeactivate() { }

	public void UpdateCoin(float time, float characterZ, float characterGamePositionZ, bool lowPerformanceLevel) { }

}

