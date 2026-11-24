//Type is in global namespace

public class RealtimeReflections : MonoBehaviour
{
	public int cubemapSize; //Field offset: 0xC
	public float nearClip; //Field offset: 0x10
	public float farClip; //Field offset: 0x14
	public bool oneFacePerFrame; //Field offset: 0x18
	public Material[] materials; //Field offset: 0x1C
	public ReflectionProbe[] reflectionProbes; //Field offset: 0x20
	public LayerMask layerMask; //Field offset: 0x24
	private Camera cam; //Field offset: 0x28
	private RenderTexture renderTexture; //Field offset: 0x2C

	public RealtimeReflections() { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

	private void UpdateCubemap(int faceMask) { }

}

