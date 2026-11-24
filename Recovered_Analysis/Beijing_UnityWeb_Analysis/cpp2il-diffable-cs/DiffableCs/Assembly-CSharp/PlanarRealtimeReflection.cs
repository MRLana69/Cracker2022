//Type is in global namespace

public class PlanarRealtimeReflection : MonoBehaviour
{
	private static bool s_InsideRendering; //Field offset: 0x0
	public bool m_DisablePixelLights; //Field offset: 0xC
	public int m_TextureResolution; //Field offset: 0x10
	public float m_clipPlaneOffset; //Field offset: 0x14
	private float m_finalClipPlaneOffset; //Field offset: 0x18
	public float m_AlphaOverwrite; //Field offset: 0x1C
	public bool m_ColorReflection; //Field offset: 0x20
	public Shader m_RenderCamShader; //Field offset: 0x24
	public bool m_NormalsFromMesh; //Field offset: 0x28
	public bool m_BaseClipOffsetFromMesh; //Field offset: 0x29
	public bool m_BaseClipOffsetFromMeshInverted; //Field offset: 0x2A
	private Vector3 m_calculatedNormal; //Field offset: 0x2C
	public LayerMask m_ReflectLayers; //Field offset: 0x38
	private Hashtable m_ReflectionCameras; //Field offset: 0x3C
	private Camera reflectionCamera; //Field offset: 0x40
	private RenderTexture m_ReflectionTexture; //Field offset: 0x44
	private int m_OldReflectionTextureSize; //Field offset: 0x48

	private static PlanarRealtimeReflection() { }

	public PlanarRealtimeReflection() { }

	private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane) { }

	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane) { }

	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign) { }

	private void CreateSurfaceObjects(Camera currentCamera, out Camera reflectionCamera) { }

	private void OnDisable() { }

	public void OnWillRenderObject() { }

	private static float sgn(float a) { }

	private void UpdateCameraModes(Camera src, Camera dest) { }

}

