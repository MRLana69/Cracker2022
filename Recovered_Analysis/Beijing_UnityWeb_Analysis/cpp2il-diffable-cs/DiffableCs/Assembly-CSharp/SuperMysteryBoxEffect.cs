//Type is in global namespace

public class SuperMysteryBoxEffect : MonoBehaviour
{
	private const string GLOW_MATERIAL_COLOR_NAME = "_TintColor"; //Field offset: 0x0
	private const float GLOW_ANI_SPEED = 0.5; //Field offset: 0x0
	public ParticleSystem[] particleSystems; //Field offset: 0xC
	public Renderer[] glowRenderers; //Field offset: 0x10
	private float _glowAniFactor; //Field offset: 0x14
	private bool _glowShouldBeOn; //Field offset: 0x18
	private Color[] _glowBaseColors; //Field offset: 0x1C
	private Material[] _glowMaterials; //Field offset: 0x20
	private bool <isRendering>k__BackingField; //Field offset: 0x24

	public bool isRendering
	{
		 get { } //Length: 58
		 set { } //Length: 419
	}

	public SuperMysteryBoxEffect() { }

	private void ApplyGlowAniFactor() { }

	private void Awake() { }

	public void FastForwardEffect(int time) { }

	public bool get_isRendering() { }

	public void set_isRendering(bool value) { }

	public void SetVisible(bool visible) { }

	private void Start() { }

	public void StartEffect() { }

	public void StopEffect() { }

	private void Update() { }

}

