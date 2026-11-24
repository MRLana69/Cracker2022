//Type is in global namespace

public class TakeScreenshot : MonoBehaviour
{
	private sealed class <TakeLargeScreenshot>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TakeScreenshot <>4__this; //Field offset: 0x10
		private Camera <cam>5__2; //Field offset: 0x14
		private int <x>5__3; //Field offset: 0x18
		private int <y>5__4; //Field offset: 0x1C
		private int <i>5__5; //Field offset: 0x20
		private int <n>5__6; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1026
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TakeLargeScreenshot>d__17(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public int scale; //Field offset: 0xC
	private bool takeScreenshot; //Field offset: 0x10
	private float left; //Field offset: 0x14
	private float right; //Field offset: 0x18
	private float top; //Field offset: 0x1C
	private float bottom; //Field offset: 0x20
	private float w; //Field offset: 0x24
	private float h; //Field offset: 0x28
	private float timeScaleReset; //Field offset: 0x2C
	private bool _takingScreenshot; //Field offset: 0x30
	private int screenshotCount; //Field offset: 0x34
	private List<Camera> uiCameras; //Field offset: 0x38
	private bool uiCamerasEnabled; //Field offset: 0x3C

	private void _Shoot() { }

	public TakeScreenshot() { }

	private void LimitsFromCameraProjectionMatrix() { }

	private Matrix4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far) { }

	private void Start() { }

	private IEnumerator TakeLargeScreenshot() { }

	private void Update() { }

}

