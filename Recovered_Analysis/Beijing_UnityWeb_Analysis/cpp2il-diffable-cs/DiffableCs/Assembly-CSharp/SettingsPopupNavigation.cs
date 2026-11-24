//Type is in global namespace

public class SettingsPopupNavigation : MonoBehaviour
{
	private sealed class <WaitAndCall>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Action callback; //Field offset: 0x10
		public SettingsPopupNavigation <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 92
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <WaitAndCall>d__7(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private List<UIButtonOverlayOff> _buttons; //Field offset: 0xC
	private List<UITexture> _buttonHighlight; //Field offset: 0x10
	private int _selectedButton; //Field offset: 0x14
	private IEnumerator _enumerator; //Field offset: 0x18

	public SettingsPopupNavigation() { }

	private void DelayedInit() { }

	private void Init() { }

	private void OnEnable() { }

	private void ResetHighlights() { }

	private void Start() { }

	private void Update() { }

	private IEnumerator WaitAndCall(Action callback) { }

}

