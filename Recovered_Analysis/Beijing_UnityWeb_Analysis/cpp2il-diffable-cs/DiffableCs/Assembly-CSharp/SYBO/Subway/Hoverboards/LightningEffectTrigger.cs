namespace SYBO.Subway.Hoverboards;

public class LightningEffectTrigger : MonoBehaviour
{
	private sealed class <DelayedDisable>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LightningEffectTrigger <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 249
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedDisable>d__8(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float InAirThreshold = 0.1; //Field offset: 0x0
	private float _duration; //Field offset: 0xC
	private Vector3 _direction; //Field offset: 0x10
	private CharacterController _characterController; //Field offset: 0x1C
	private float _inAirTime; //Field offset: 0x20
	private GameObject[] _children; //Field offset: 0x24

	public LightningEffectTrigger() { }

	private void Awake() { }

	private IEnumerator DelayedDisable() { }

	private void LateUpdate() { }

}

