//Type is in global namespace

public class BragCelebrationHandler : MonoBehaviour
{
	private sealed class <AnimateWidgetAlpha>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIWidget label; //Field offset: 0x10
		public float duration; //Field offset: 0x14
		public float toAlpha; //Field offset: 0x18
		private float <fromAlpha>5__2; //Field offset: 0x1C
		private float <factor>5__3; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 283
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateWidgetAlpha>d__30(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <UpdateUI>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public BragCelebrationHandler <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 821
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UpdateUI>d__26(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum State
	{
		NotCalculated = 0,
		BeatenOnlySelf = 1,
		BeatenFriendsOnlyGcOnline = 2,
		BeatenFriendsOnlineAll = 3,
	}

	private GameObject _noFriendsStateGo; //Field offset: 0xC
	private GameObject _gcFriendsStateGo; //Field offset: 0x10
	private GameObject _allFriendsStateGo; //Field offset: 0x14
	private GameObject _friendPicture; //Field offset: 0x18
	private UILabel _newHighScoreTopTitle; //Field offset: 0x1C
	private UILabel _highScoreLabel; //Field offset: 0x20
	private UILabel _justBeatLabel; //Field offset: 0x24
	private UILabel _firstBeatenFriendLabel; //Field offset: 0x28
	private UILabel _beatenFriendsLeftLabel; //Field offset: 0x2C
	private UILabel _bragButtonTitle; //Field offset: 0x30
	private UILabel _competeWithFriendsButtonTitle; //Field offset: 0x34
	private UITexture _friendPictureTexture; //Field offset: 0x38
	private GameObject _bragGo; //Field offset: 0x3C
	private Friend __bestSurpassedFriend; //Field offset: 0x40
	private List<Friend> __surpassedFriends; //Field offset: 0x44
	private State _socialState; //Field offset: 0x48

	private Friend _bestSurpassedFriend
	{
		 get { } //Length: 66
	}

	private List<Friend> _surpassedFriends
	{
		 get { } //Length: 488
	}

	public State state
	{
		 get { } //Length: 244
	}

	public BragCelebrationHandler() { }

	private void AnimateUIGameObjectAlpha(GameObject go, float duration, float toAlpha) { }

	private IEnumerator AnimateWidgetAlpha(UIWidget label, float duration, float toAlpha) { }

	private void Awake() { }

	private void BragBtnClicked() { }

	private void CalculateState() { }

	private Friend get__bestSurpassedFriend() { }

	private List<Friend> get__surpassedFriends() { }

	public State get_state() { }

	private void LoginToFacebookBtnClicked() { }

	private void OnLargePictureDownloaded(Friend friend, Texture2D picture) { }

	private void OnValidate() { }

	private void SetStateGameObjectActive(GameObject go) { }

	private void Setup() { }

	private IEnumerator UpdateUI() { }

}

