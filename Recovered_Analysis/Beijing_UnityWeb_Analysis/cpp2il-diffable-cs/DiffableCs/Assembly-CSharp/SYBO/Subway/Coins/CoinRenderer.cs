namespace SYBO.Subway.Coins;

public class CoinRenderer : MonoBehaviour
{
	private Renderer _renderer; //Field offset: 0xC
	private Glow _glow; //Field offset: 0x10
	private PickupRotate _pickupRotate; //Field offset: 0x14
	private Transform _transform; //Field offset: 0x18
	private bool _actualRendering; //Field offset: 0x1C
	private bool _renderersEnabled; //Field offset: 0x1D

	public CoinRenderer() { }

	private void Awake() { }

	public void ToggleRenderers(bool enabled) { }

	public void UpdateCoinRenderer(float time, float characterZ, bool lowPerformanceLevel) { }

}

