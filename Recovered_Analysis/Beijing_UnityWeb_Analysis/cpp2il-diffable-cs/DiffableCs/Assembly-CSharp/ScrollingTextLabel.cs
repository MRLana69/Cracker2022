//Type is in global namespace

public class ScrollingTextLabel : MonoBehaviour
{
	private sealed class <StartScrollingCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public ScrollingTextLabel <>4__this; //Field offset: 0x10
		public bool destroyWhenDone; //Field offset: 0x14
		public float duration; //Field offset: 0x18
		public float fadeOutDuration; //Field offset: 0x1C
		public string text; //Field offset: 0x20
		public Vector3 startLocalPos; //Field offset: 0x24
		public Vector3 endLocalPos; //Field offset: 0x30
		private float <fadeOutAniFactorStart>5__2; //Field offset: 0x3C
		private float <aniFactor>5__3; //Field offset: 0x40

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 987
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StartScrollingCoroutine>d__8(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private UILabel label; //Field offset: 0xC
	private bool _isScrolling; //Field offset: 0x10
	private Transform _labelTransform; //Field offset: 0x14
	private Color _labelBaseColor; //Field offset: 0x18
	private bool _destroyOnDisable; //Field offset: 0x28

	public ScrollingTextLabel() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void StartScrolling(string text, Vector3 startLocalPos, Vector3 endLocalPos, float duration, float fadeOutDuration, bool destroyWhenDone) { }

	private IEnumerator StartScrollingCoroutine(string text, Vector3 startLocalPos, Vector3 endLocalPos, float duration, float fadeOutDuration, bool destroyWhenDone) { }

}

