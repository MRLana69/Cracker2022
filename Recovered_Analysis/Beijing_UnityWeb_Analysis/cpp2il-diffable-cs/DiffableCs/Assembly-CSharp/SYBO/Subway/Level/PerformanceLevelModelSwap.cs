namespace SYBO.Subway.Level;

public class PerformanceLevelModelSwap : MonoBehaviour
{
	public PerformanceLevelModelInfo performanceLevelModel; //Field offset: 0xC
	private bool _initialized; //Field offset: 0x18
	private bool _swapEvaluated; //Field offset: 0x19
	private MeshFilter _meshFilter; //Field offset: 0x1C
	private Renderer _renderer; //Field offset: 0x20
	private ThemeManager _themeManager; //Field offset: 0x24

	public PerformanceLevelModelSwap() { }

	private void InitializeCheck() { }

	private void Start() { }

	public void SwapMaterials() { }

	private bool SwapMaterials(PerformanceLevel perfLevel) { }

	private bool UpdateModel(ModelInfo meshInfo) { }

}

