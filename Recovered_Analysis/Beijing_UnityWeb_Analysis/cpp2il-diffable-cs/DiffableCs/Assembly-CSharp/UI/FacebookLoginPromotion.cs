namespace UI;

public class FacebookLoginPromotion : MonoBehaviour
{
	private sealed class <ActivateStars>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public FacebookLoginPromotion <>4__this; //Field offset: 0x10
		private Enumerator<GameObject> <>7__wrap1; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 2040
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ActivateStars>d__16(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private UILabel _tilte; //Field offset: 0xC
	private UILabel _subtitle; //Field offset: 0x10
	private UISprite _backgroundSprite; //Field offset: 0x14
	private GameObject _loginButton; //Field offset: 0x18
	private GameObject _dinoLogoPrefab; //Field offset: 0x1C
	private float _starAnimationPause; //Field offset: 0x20
	private float _starCountDown; //Field offset: 0x24
	private List<GameObject> _starPosition; //Field offset: 0x28
	private GameObject _starPrefab; //Field offset: 0x2C
	private GameObject _reconnectContent; //Field offset: 0x30
	private List<GameObject> _stars; //Field offset: 0x34
	private GameObject _dino; //Field offset: 0x38
	private bool _runAnimations; //Field offset: 0x3C
	private Action _clickedAction; //Field offset: 0x40

	public FacebookLoginPromotion() { }

	private void ActivateLoginButton(string screen, Action clickedAction = null) { }

	private void ActivateReconnectBar() { }

	private IEnumerator ActivateStars() { }

	private void AddColors() { }

	private void CreateDinoLogo() { }

	public void Init(string screen, Action clickedAction = null) { }

	private void OnDisable() { }

}

