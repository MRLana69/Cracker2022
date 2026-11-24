namespace UI.Popups;

public class CloudSaveCelebrationPopup : UIScreen
{
	private sealed class <AnimateAlpha>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIWidget widget; //Field offset: 0x10
		public float from; //Field offset: 0x14
		public float duration; //Field offset: 0x18
		public Func<float, float> easing; //Field offset: 0x1C
		public float to; //Field offset: 0x20
		private float <factor>5__2; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 304
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateAlpha>d__14(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateRoutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudSaveCelebrationPopup <>4__this; //Field offset: 0x10
		private Vector3 <originalCloudScale>5__2; //Field offset: 0x14
		private Vector3 <originalCheckmarkScale>5__3; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 2616
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateRoutine>d__13(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateScale>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIWidget widget; //Field offset: 0x10
		public Vector3 from; //Field offset: 0x14
		public float duration; //Field offset: 0x20
		public Func<float, float> easing; //Field offset: 0x24
		public Vector3 to; //Field offset: 0x28
		private float <factor>5__2; //Field offset: 0x34

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 611
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateScale>d__15(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private UILabel _headline; //Field offset: 0x28
	private UILabel _subline; //Field offset: 0x2C
	private UIWidget _skyline; //Field offset: 0x30
	private UIWidget _cloud; //Field offset: 0x34
	private UIWidget _checkmark; //Field offset: 0x38

	public CloudSaveCelebrationPopup() { }

	private void Animate() { }

	private IEnumerator AnimateAlpha(UIWidget widget, float duration, float from, float to, Func<float, float> easing) { }

	private IEnumerator AnimateRoutine() { }

	private IEnumerator AnimateScale(UIWidget widget, float duration, Vector3 from, Vector3 to, Func<float, float> easing) { }

	private void ApplyColors() { }

	public override void Init() { }

	private void Localize() { }

	public void PopupClicked() { }

	private void Reset() { }

	public override void Show() { }

	private void Update() { }

}

