namespace SYBO.Common.Visuals;

public class MeshMorpher : MonoBehaviour
{
	private enum AnimationType
	{
		Auto = 0,
		Manual = 1,
	}

	private MeshFilter _targetMeshFilter; //Field offset: 0xC
	private Mesh[] _morphTargets; //Field offset: 0x10
	private float _loopDuration; //Field offset: 0x14
	private WrapMode _wrapMode; //Field offset: 0x18
	private bool _animate; //Field offset: 0x1C
	private AnimationType _animationType; //Field offset: 0x20
	private float _animTime; //Field offset: 0x24
	private PerformanceLevel _minPerformanceLevel; //Field offset: 0x28
	private Mesh _mesh; //Field offset: 0x2C
	private Vector3[] _vertices; //Field offset: 0x30
	private Vector3[][] _morphTargetsVertices; //Field offset: 0x34

	public bool Animate
	{
		 get { } //Length: 209
		 set { } //Length: 506
	}

	public MeshMorpher() { }

	private void Awake() { }

	private void BuildMesh(int idx1, int idx2, float t) { }

	public bool get_Animate() { }

	private void Initialize() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void Reset() { }

	public void set_Animate(bool value) { }

	private void SetMorph(float t) { }

	private void Update() { }

}

