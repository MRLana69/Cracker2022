namespace UI.Generic;

public class UIScaleAnimation : MonoBehaviour
{
	private sealed class <WaitForSecondsAndRestart>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float restPeriod; //Field offset: 0x10
		public UIScaleAnimation <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 139
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <WaitForSecondsAndRestart>d__19(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float COMPLETION_THRESHOLD = 0.01; //Field offset: 0x0
	private float _duration; //Field offset: 0xC
	private Vector2 _scaleRange; //Field offset: 0x10
	private float _fadeFrom; //Field offset: 0x18
	private float _fadeTo; //Field offset: 0x1C
	private float _restPeriod; //Field offset: 0x20
	private float _spawnRate; //Field offset: 0x24
	private int _spawnAmount; //Field offset: 0x28
	private UISprite _originalSprite; //Field offset: 0x2C
	private UISprite[] _sprites; //Field offset: 0x30
	private float[] _spawnTimes; //Field offset: 0x34
	private float _timer; //Field offset: 0x38
	private Vector3 _startScale; //Field offset: 0x3C
	private Vector3 _endScale; //Field offset: 0x48

	public UIScaleAnimation() { }

	private void Awake() { }

	private void OnEnable() { }

	private void ResetAllSprites() { }

	private void RestartAnimation() { }

	private void Update() { }

	private IEnumerator WaitForSecondsAndRestart(float restPeriod) { }

}

