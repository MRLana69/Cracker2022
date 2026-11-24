//Type is in global namespace

internal class CharacterRenderingEffects : MonoBehaviour
{
	private sealed class <>c__DisplayClass37_0
	{
		public CharacterRenderingEffects <>4__this; //Field offset: 0x8
		public bool active; //Field offset: 0xC

		public <>c__DisplayClass37_0() { }

		internal void <SetRightAndLeftParticlesActive>b__0(float t) { }

	}

	private sealed class <>c__DisplayClass38_0
	{
		public CharacterRenderingEffects <>4__this; //Field offset: 0x8
		public bool active; //Field offset: 0xC

		public <>c__DisplayClass38_0() { }

		internal void <SetPogostickParticlesActive>b__0(float t) { }

	}

	public delegate OnDoubleJumpDelegate
	{

		public OnDoubleJumpDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	private Renderer leftJumpThruster; //Field offset: 0xC
	private Renderer rightJumpThruster; //Field offset: 0x10
	private float thrusterPlayTime; //Field offset: 0x14
	private Transform _scoreBoosterRoot; //Field offset: 0x18
	private Animation _scoreBoostAnimation; //Field offset: 0x1C
	private ParticleSystem _scoreBoostParticle; //Field offset: 0x20
	private GameObject jetpackParticles; //Field offset: 0x24
	private GameObject pogostickParticles; //Field offset: 0x28
	public ParticleFollow pogostickParticleCloud; //Field offset: 0x2C
	public ParticleFollow jetpackParticleCloudL; //Field offset: 0x30
	public ParticleFollow jetpackParticleCloudR; //Field offset: 0x34
	private OnDoubleJumpDelegate OnDoubleJump; //Field offset: 0x38
	private GameObject dustPrefab; //Field offset: 0x3C
	private ParticleSystem dustParticles; //Field offset: 0x40
	private AnimationState leftJumpThrusterState; //Field offset: 0x44
	private AnimationState rightJumpThrusterState; //Field offset: 0x48
	private Vector3 _starsOriginalPosition; //Field offset: 0x4C
	private Character _character; //Field offset: 0x58
	private CharacterModel _characterModel; //Field offset: 0x5C
	private CharacterCamera characterCamera; //Field offset: 0x60
	private Hoverboard _hoverboard; //Field offset: 0x64
	private RoofedCulling _environmentCulling; //Field offset: 0x68

	public event OnDoubleJumpDelegate OnDoubleJump
	{
		 add { } //Length: 916
		 remove { } //Length: 111
	}

	public GameObject JetpackParticles
	{
		 get { } //Length: 6
	}

	public GameObject PogostickParticles
	{
		 get { } //Length: 6
	}

	public CharacterRenderingEffects() { }

	private void <PlayDoubleJumpThruster>b__36_0(float t) { }

	public void add_OnDoubleJump(OnDoubleJumpDelegate value) { }

	private void Awake() { }

	public GameObject get_JetpackParticles() { }

	public GameObject get_PogostickParticles() { }

	public void Initialize(CharacterModel characterModel) { }

	public void InitializeModel(CharacterModel characterModel) { }

	public void PlayDoubleJumpThruster() { }

	public void PlayScoreboostFX(int version) { }

	public void RecreateModel(CharacterModel characterModel) { }

	public void remove_OnDoubleJump(OnDoubleJumpDelegate value) { }

	public void SetPogostickParticlesActive(bool active) { }

	public void SetRightAndLeftParticlesActive(bool active) { }

	private void SetupDoubleJumpThrusters(Transform leftFoot, Transform rightFoot) { }

	private void SetupScoorboosterFX() { }

	public void ToggleDust(bool active) { }

	private void Update() { }

}

