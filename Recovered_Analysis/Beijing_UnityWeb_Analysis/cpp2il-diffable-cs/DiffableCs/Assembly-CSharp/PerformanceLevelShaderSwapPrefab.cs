//Type is in global namespace

public class PerformanceLevelShaderSwapPrefab : MonoBehaviour, IPrefabBehaviour
{
	private Renderer _renderer; //Field offset: 0xC
	private Shader _swapShader; //Field offset: 0x10
	private PerformanceLevel _minPerformanceLevelForSwap; //Field offset: 0x14

	public PerformanceLevelShaderSwapPrefab() { }

	public void Initialize() { }

}

