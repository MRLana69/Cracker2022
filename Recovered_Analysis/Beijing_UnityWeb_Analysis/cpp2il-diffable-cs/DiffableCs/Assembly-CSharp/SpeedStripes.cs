//Type is in global namespace

public class SpeedStripes : MonoBehaviour, IRouteEffectGUIListener
{
	private sealed class <>c__DisplayClass28_0
	{
		public SpeedStripes <>4__this; //Field offset: 0x8
		public Color currentColor; //Field offset: 0xC
		public Color colorTargetColor; //Field offset: 0x1C

		public <>c__DisplayClass28_0() { }

		internal void <Activate>b__0(float t) { }

	}

	private sealed class <>c__DisplayClass29_0
	{
		public SpeedStripes <>4__this; //Field offset: 0x8
		public Color currentColor; //Field offset: 0xC
		public Color colorTarget; //Field offset: 0x1C

		public <>c__DisplayClass29_0() { }

		internal void <Deactivate>b__0(float t) { }

	}

	private float _fadeInTime; //Field offset: 0xC
	private Color _originalColor; //Field offset: 0x10
	private Renderer[] _renderers; //Field offset: 0x20
	private Material _OriginalMaterial; //Field offset: 0x24
	private Material _material; //Field offset: 0x28
	private IRouteEffectGUISubject _subject; //Field offset: 0x2C
	private Color[] _colorSteps; //Field offset: 0x30
	private int _gearActivationThreshold; //Field offset: 0x34
	private int _gearSteps; //Field offset: 0x38
	private Animator _animator; //Field offset: 0x3C
	private readonly int id_Active; //Field offset: 0x40
	private bool _isActive; //Field offset: 0x44
	private Vector3 _originalScale; //Field offset: 0x48
	private GameObject _scalingParent; //Field offset: 0x54

	public SpeedStripes() { }

	private void Activate(float time, Color currentColor, Color colorTargetColor) { }

	private void Awake() { }

	private void Deactivate(float time, Color colorTarget) { }

	public virtual void DeInitialize() { }

	private void HandleOnEnteredSkatePark() { }

	private void HandleOnEnteredTallyScreen() { }

	private void HandleOnGearChanged(int gear) { }

	public virtual void Initialize(IRouteEffectGUISubject subject) { }

	private void LateUpdate() { }

	private void OnPogoStart() { }

	private void OnPogoStop() { }

	private void OnSpeederBoardStart() { }

	private void OnSpeederBoardStop() { }

	private void OnStartHeadstart() { }

	private void OnStartJetpack() { }

	private void OnStopHeadstart() { }

	private void Reset() { }

}

