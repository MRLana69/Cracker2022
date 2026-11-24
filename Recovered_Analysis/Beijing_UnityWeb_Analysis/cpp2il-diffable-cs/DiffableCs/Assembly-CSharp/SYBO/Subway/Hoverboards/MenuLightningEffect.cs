namespace SYBO.Subway.Hoverboards;

public class MenuLightningEffect : MonoBehaviour
{
	private sealed class <DelayedDisable>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public MenuLightningEffect <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 249
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedDisable>d__7(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private float _duration; //Field offset: 0xC
	private float _minDelay; //Field offset: 0x10
	private float _maxDelay; //Field offset: 0x14
	private float _currentDelay; //Field offset: 0x18
	private GameObject[] _children; //Field offset: 0x1C

	public MenuLightningEffect() { }

	private void Awake() { }

	private IEnumerator DelayedDisable() { }

	private void Update() { }

}

