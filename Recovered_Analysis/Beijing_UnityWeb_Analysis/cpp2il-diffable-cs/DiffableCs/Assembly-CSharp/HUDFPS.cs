//Type is in global namespace

public class HUDFPS : MonoBehaviour
{
	private sealed class <FPS>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public HUDFPS <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1158
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <FPS>d__26(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public Rect windowRect; //Field offset: 0xC
	public bool updateColor; //Field offset: 0x1C
	public bool allowDrag; //Field offset: 0x1D
	public float frequency; //Field offset: 0x20
	public int nbDecimal; //Field offset: 0x24
	private float accum; //Field offset: 0x28
	private int frames; //Field offset: 0x2C
	private float accumTotal; //Field offset: 0x30
	private int framesTotal; //Field offset: 0x34
	private Color color; //Field offset: 0x38
	private Color minColor; //Field offset: 0x48
	private Color avgColor; //Field offset: 0x58
	private float minFpsMin; //Field offset: 0x68
	private float minFpsMax; //Field offset: 0x6C
	private float fpsMin; //Field offset: 0x70
	private float fpsMax; //Field offset: 0x74
	private Rect windowRectPrev; //Field offset: 0x78
	private string sFPS; //Field offset: 0x88
	private string sMinFPS; //Field offset: 0x8C
	private string sAvgFPS; //Field offset: 0x90
	private GUIStyle style; //Field offset: 0x94
	private float timeMaxFrame; //Field offset: 0x98

	public HUDFPS() { }

	private void DoMyWindow(int windowID) { }

	private IEnumerator FPS() { }

	private void OnGUI() { }

	private void Reset() { }

	private void Start() { }

	public void StartFpsCounter() { }

	private void Update() { }

}

