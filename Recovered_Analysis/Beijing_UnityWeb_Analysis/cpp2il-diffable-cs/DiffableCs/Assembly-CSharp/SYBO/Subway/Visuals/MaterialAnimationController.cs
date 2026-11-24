namespace SYBO.Subway.Visuals;

public class MaterialAnimationController : MonoBehaviour
{
	private static MaterialPropertyBlock _propertyBlock; //Field offset: 0x0
	private Shader _targetShader; //Field offset: 0xC
	private string _materialNameSubstring; //Field offset: 0x10
	private bool _searchChildrenForRenderer; //Field offset: 0x14
	private float _colorMultiplier; //Field offset: 0x18
	private List<Renderer> _targetRenderers; //Field offset: 0x1C
	private List<Material> _targetMaterials; //Field offset: 0x20
	private bool _targetSet; //Field offset: 0x24

	public float ColorMultiplier
	{
		 set { } //Length: 8
	}

	private static MaterialAnimationController() { }

	public MaterialAnimationController() { }

	public void set_ColorMultiplier(float value) { }

	private bool SetTargetMaterials() { }

	private void Update() { }

}

