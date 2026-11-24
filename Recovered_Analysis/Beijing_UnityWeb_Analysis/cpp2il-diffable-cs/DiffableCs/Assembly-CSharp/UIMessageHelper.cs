//Type is in global namespace

public class UIMessageHelper : MonoBehaviour
{
	private sealed class <FadeOut>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIMessageHelper <>4__this; //Field offset: 0x10
		private float <duration>5__2; //Field offset: 0x14
		private float <fadeTime>5__3; //Field offset: 0x18
		private Vector3 <scaleFrom>5__4; //Field offset: 0x1C
		private Vector3 <scaleTo>5__5; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 821
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <FadeOut>d__5(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public Color shownColor; //Field offset: 0xC
	private UILabel _label; //Field offset: 0x1C
	private bool _wasPermanentlyHidden; //Field offset: 0x20

	public UIMessageHelper() { }

	private void Awake() { }

	public void DisableShowLabel() { }

	private IEnumerator FadeOut() { }

	public void SetTemporaryHidden(bool hidden) { }

	public void ShowMessage(string message, bool bigText = false) { }

}

