//Type is in global namespace

public class TutorialEvent : MonoBehaviour
{
	private sealed class <>c__DisplayClass20_0
	{
		public TutorialEvent <>4__this; //Field offset: 0x8
		public Vector3 pos; //Field offset: 0xC

		public <>c__DisplayClass20_0() { }

		internal void <ShowArrow>b__0(float t) { }

	}

	private sealed class <FadeOutArrowsText>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TutorialEvent <>4__this; //Field offset: 0x10
		private float <duration>5__2; //Field offset: 0x14
		private float <fadeTime>5__3; //Field offset: 0x18
		private Vector3 <scaleFrom>5__4; //Field offset: 0x1C
		private Vector3 <scaleTo>5__5; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 719
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <FadeOutArrowsText>d__21(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <ShowArrow>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TutorialEvent <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1206
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ShowArrow>d__20(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum TutorialText
	{
		None = 0,
		FreshMoves = 1,
		DoubleTap = 2,
		YouRock = 3,
	}

	private Game game; //Field offset: 0xC
	private bool displayText; //Field offset: 0x10
	private TutorialText tutorialText; //Field offset: 0x14
	private bool displayMesh; //Field offset: 0x18
	private float direction; //Field offset: 0x1C
	private float time; //Field offset: 0x20
	private bool endTutorial; //Field offset: 0x24
	private bool allowHoverboard; //Field offset: 0x25
	private Hoverboard hoverboard; //Field offset: 0x28
	private Character character; //Field offset: 0x2C
	private bool _initialized; //Field offset: 0x30
	private GameObject _mesh; //Field offset: 0x34
	private GameObject _label; //Field offset: 0x38

	private GameObject label
	{
		 get { } //Length: 9
	}

	private GameObject mesh
	{
		 get { } //Length: 114
	}

	public TutorialEvent() { }

	private void Awake() { }

	private IEnumerator FadeOutArrowsText() { }

	private GameObject get_label() { }

	private GameObject get_mesh() { }

	private string GetStringForTutorial() { }

	private void OnDisable() { }

	private void OnTriggerExit(Collider collider) { }

	private IEnumerator ShowArrow() { }

	private void Start() { }

}

