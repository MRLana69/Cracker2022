//Type is in global namespace

public class BatTeleboardEffect : ATeleboardEffect
{
	private sealed class <ResetCharacterTeleportFX>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public BatTeleboardEffect <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 573
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ResetCharacterTeleportFX>d__13(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private Animation _animation; //Field offset: 0xC
	private string _leftAnimationName; //Field offset: 0x10
	private string _rightAnimationName; //Field offset: 0x14
	private Transform _endPoof; //Field offset: 0x18
	private Vector3 _offset; //Field offset: 0x1C
	private float _reappearDelay; //Field offset: 0x28
	private bool _overrideEnd; //Field offset: 0x2C
	private Vector3 pos; //Field offset: 0x30
	private bool _correctEndYPos; //Field offset: 0x3C

	public BatTeleboardEffect() { }

	private void LateUpdate() { }

	private IEnumerator ResetCharacterTeleportFX() { }

	public override void ResetTeleboardEffect() { }

	public override void StartTeleBoardEffect() { }

	private void Update() { }

}

