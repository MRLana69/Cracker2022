namespace SYBO.Subway.Level;

public class BackgroundObject : MonoBehaviour
{
	private bool _alwaysVisible; //Field offset: 0xC
	private bool _movable; //Field offset: 0xD
	private MoveGameObject _moveGameObject; //Field offset: 0x10
	private Transform _transform; //Field offset: 0x14
	private Renderer[] _renderers; //Field offset: 0x18
	private List<MeshRenderer> _meshRenderers; //Field offset: 0x1C
	private List<ParticleSystemRenderer> _particleSystemRenderers; //Field offset: 0x20
	private List<Material> _materialInstances; //Field offset: 0x24

	public bool AlwaysVisible
	{
		 get { } //Length: 12
	}

	public List<MeshRenderer> MeshRenderers
	{
		 get { } //Length: 6
	}

	public bool Movable
	{
		 get { } //Length: 9
	}

	public List<ParticleSystemRenderer> ParticleSystemRenderers
	{
		 get { } //Length: 6
	}

	public Renderer[] Renderers
	{
		 get { } //Length: 9
	}

	public BackgroundObject() { }

	private void Awake() { }

	public bool get_AlwaysVisible() { }

	public List<MeshRenderer> get_MeshRenderers() { }

	public bool get_Movable() { }

	public List<ParticleSystemRenderer> get_ParticleSystemRenderers() { }

	public Renderer[] get_Renderers() { }

	public void Initialize(BackgroundLayer layer, Transform parent, Vector3 localPosition) { }

	private void OnDestroy() { }

}

