namespace UnityEngine;

public sealed class Camera : Behaviour
{
	public delegate CameraCallback
	{

		public CameraCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Camera cam) { }

	}

	public enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2,
	}

	public static CameraCallback onPreCull; //Field offset: 0x0
	public static CameraCallback onPreRender; //Field offset: 0x4
	public static CameraCallback onPostRender; //Field offset: 0x8

	public static Camera[] allCameras
	{
		 get { } //Length: 7
	}

	public static int allCamerasCount
	{
		 get { } //Length: 47
	}

	public float aspect
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public Color backgroundColor
	{
		 get { } //Length: 101
		 set { } //Length: 60
	}

	public CameraClearFlags clearFlags
	{
		 get { } //Length: 49
		 set { } //Length: 11
	}

	public int cullingMask
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public static Camera current
	{
		 get { } //Length: 47
	}

	public float depth
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public int eventMask
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public float farClipPlane
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public float fieldOfView
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public float[] layerCullDistances
	{
		 set { } //Length: 53
	}

	public static Camera main
	{
		 get { } //Length: 47
	}

	public float nearClipPlane
	{
		 get { } //Length: 9
		 set { } //Length: 7
	}

	public bool orthographic
	{
		 get { } //Length: 7
		 set { } //Length: 2
	}

	public float orthographicSize
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public int pixelHeight
	{
		 get { } //Length: 49
	}

	public Rect pixelRect
	{
		 get { } //Length: 11
	}

	public int pixelWidth
	{
		 get { } //Length: 49
	}

	public Matrix4x4 projectionMatrix
	{
		 get { } //Length: 11
		 set { } //Length: 162
	}

	public Rect rect
	{
		 get { } //Length: 53
		 set { } //Length: 60
	}

	public int targetDisplay
	{
		 get { } //Length: 49
	}

	public RenderTexture targetTexture
	{
		 get { } //Length: 49
		 set { } //Length: 60
	}

	public TransparencySortMode transparencySortMode
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public Matrix4x4 worldToCameraMatrix
	{
		 get { } //Length: 53
		 set { } //Length: 162
	}

	public Camera() { }

	private static void FireOnPostRender(Camera cam) { }

	private static void FireOnPreCull(Camera cam) { }

	private static void FireOnPreRender(Camera cam) { }

	public static Camera[] get_allCameras() { }

	public static int get_allCamerasCount() { }

	public float get_aspect() { }

	public Color get_backgroundColor() { }

	private void get_backgroundColor_Injected(out Color ret) { }

	public CameraClearFlags get_clearFlags() { }

	public int get_cullingMask() { }

	public static Camera get_current() { }

	public float get_depth() { }

	public int get_eventMask() { }

	public float get_farClipPlane() { }

	public float get_fieldOfView() { }

	public static Camera get_main() { }

	public float get_nearClipPlane() { }

	public bool get_orthographic() { }

	public float get_orthographicSize() { }

	public int get_pixelHeight() { }

	public Rect get_pixelRect() { }

	private void get_pixelRect_Injected(out Rect ret) { }

	public int get_pixelWidth() { }

	public Matrix4x4 get_projectionMatrix() { }

	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	public Rect get_rect() { }

	private void get_rect_Injected(out Rect ret) { }

	public int get_targetDisplay() { }

	public RenderTexture get_targetTexture() { }

	public TransparencySortMode get_transparencySortMode() { }

	public Matrix4x4 get_worldToCameraMatrix() { }

	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	public static int GetAllCameras(Camera[] cameras) { }

	private static int GetAllCamerasCount() { }

	private static int GetAllCamerasImpl(out Camera[] cam) { }

	public void Render() { }

	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	public void ResetProjectionMatrix() { }

	public void ResetReplacementShader() { }

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	public Ray ScreenPointToRay(Vector3 pos) { }

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	private void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public void set_aspect(float value) { }

	public void set_backgroundColor(Color value) { }

	private void set_backgroundColor_Injected(ref Color value) { }

	public void set_clearFlags(CameraClearFlags value) { }

	public void set_cullingMask(int value) { }

	public void set_depth(float value) { }

	public void set_eventMask(int value) { }

	public void set_farClipPlane(float value) { }

	public void set_fieldOfView(float value) { }

	public void set_layerCullDistances(float[] value) { }

	public void set_nearClipPlane(float value) { }

	public void set_orthographic(bool value) { }

	public void set_orthographicSize(float value) { }

	public void set_projectionMatrix(Matrix4x4 value) { }

	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	public void set_rect(Rect value) { }

	private void set_rect_Injected(ref Rect value) { }

	public void set_targetTexture(RenderTexture value) { }

	public void set_transparencySortMode(TransparencySortMode value) { }

	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	private void SetLayerCullDistances(float[] d) { }

	public void SetReplacementShader(Shader shader, string replacementTag) { }

	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void ViewportToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 WorldToScreenPoint(Vector3 position) { }

	private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 WorldToViewportPoint(Vector3 position) { }

	private void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}

