namespace UI.Screens;

public class FbPromotionPopup : UIScreen
{
	private sealed class <RunAnimations>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public FbPromotionPopup <>4__this; //Field offset: 0x10
		private float <starAnimationTime>5__2; //Field offset: 0x14
		private int <x>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 826
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RunAnimations>d__40(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const int COIN_REWARD_AMOUNT = 5000; //Field offset: 0x0
	private static Action<FacebookRewardType, int> OnFacebookRewardPaidOut; //Field offset: 0x0
	private static Action<CharacterId, int> OnFacebookCharacterReceived; //Field offset: 0x4
	private UILabel _headlineLabel; //Field offset: 0x28
	private UILabel _sublineLabel; //Field offset: 0x2C
	private UISprite _0BackgroundSprite; //Field offset: 0x30
	private UISprite _1BackgroundSprite; //Field offset: 0x34
	private UISprite _coinSignSprite; //Field offset: 0x38
	private UISprite _coinSignTriangleSprite; //Field offset: 0x3C
	private UISprite _coinSignBGSprite; //Field offset: 0x40
	private UISprite _coinSignTriangleBGSprite; //Field offset: 0x44
	private UILabel _coinSignAmountLabel; //Field offset: 0x48
	private UILabel _coinSignTextLabel; //Field offset: 0x4C
	private Layout _coinSignLayout; //Field offset: 0x50
	private UISprite _dinoSignSprite; //Field offset: 0x54
	private UISprite _dinoSignTriangleSprite; //Field offset: 0x58
	private UISprite _dinoSignBGSprite; //Field offset: 0x5C
	private UISprite _dinoSignTriangleBGSprite; //Field offset: 0x60
	private UILabel _dinoSignTextLabel; //Field offset: 0x64
	private UISprite _coinGlowSprite; //Field offset: 0x68
	private UILabel _buttonLabel; //Field offset: 0x6C
	private GameObject _facebookLogoSprite; //Field offset: 0x70
	private List<GameObject> _starPosition; //Field offset: 0x74
	private GameObject _starPrefab; //Field offset: 0x78
	private float _starCountDown; //Field offset: 0x7C
	private Animation _buttonBounce; //Field offset: 0x80
	private Animation _buttonSlideStar; //Field offset: 0x84
	private FacebookDinoLogoRenderTextureSetup _dinoCharacterRenderTextureSetup; //Field offset: 0x88
	private List<GameObject> _stars; //Field offset: 0x8C
	private bool _runAnimations; //Field offset: 0x90

	public static event Action<CharacterId, int> OnFacebookCharacterReceived
	{
		 add { } //Length: 126
		 remove { } //Length: 129
	}

	public static event Action<FacebookRewardType, int> OnFacebookRewardPaidOut
	{
		 add { } //Length: 9
		 remove { } //Length: 126
	}

	public FbPromotionPopup() { }

	private void ActivateAnimations() { }

	private void ActivateDinoLogoAnimation() { }

	public static void add_OnFacebookCharacterReceived(Action<CharacterId, int> value) { }

	public static void add_OnFacebookRewardPaidOut(Action<FacebookRewardType, int> value) { }

	private void DeactivateDinoLogoAnimation() { }

	private void DeliverRemainingFacebookRewards() { }

	private void Localization() { }

	public void OnBackBtnClicked() { }

	public void OnConnectClicked() { }

	private void OnDinoLogoBecameInactive() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnFacebookLoginResult(bool loggedIn) { }

	public static void remove_OnFacebookCharacterReceived(Action<CharacterId, int> value) { }

	public static void remove_OnFacebookRewardPaidOut(Action<FacebookRewardType, int> value) { }

	private IEnumerator RunAnimations() { }

	private void SetColors() { }

	public override void Show() { }

}

