//Type is in global namespace

public class GameOverOfflineHelper : MonoBehaviour
{
	private sealed class <AnimateAlpha>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UISprite sprite1; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public float toAlpha; //Field offset: 0x18
		public UISprite sprite2; //Field offset: 0x1C
		public GameOverOfflineHelper <>4__this; //Field offset: 0x20
		private float <fromAlpha>5__2; //Field offset: 0x24
		private float <factor>5__3; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 366
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateAlpha>d__7(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public GameObject FacebookLoginButton; //Field offset: 0xC
	public GameObject GameCenterLoginButton; //Field offset: 0x10
	public UISprite FacebookIcon; //Field offset: 0x14
	public UISprite GameCenterIcon; //Field offset: 0x18

	public GameOverOfflineHelper() { }

	private IEnumerator AnimateAlpha(UISprite sprite1, UISprite sprite2, float duration, float toAlpha) { }

	public void DisableButtons() { }

	public void EnableButtons() { }

	private void HandleColliders(bool AddNow) { }

	private void Start() { }

}

