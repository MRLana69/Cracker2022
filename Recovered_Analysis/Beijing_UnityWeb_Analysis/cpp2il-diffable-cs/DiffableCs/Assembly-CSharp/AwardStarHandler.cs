//Type is in global namespace

public class AwardStarHandler : MonoBehaviour
{
	private sealed class <AnimateStar>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AwardStarHandler <>4__this; //Field offset: 0x10
		public Animation starAnimation; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 230
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateStar>d__5(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private Animation[] _stars; //Field offset: 0xC
	private float minSecondsToNextAnim; //Field offset: 0x10
	private float maxSecondsToNextAnim; //Field offset: 0x14
	public bool animeStars; //Field offset: 0x18

	public AwardStarHandler() { }

	public void ActivateStars() { }

	private IEnumerator AnimateStar(Animation starAnimation) { }

}

