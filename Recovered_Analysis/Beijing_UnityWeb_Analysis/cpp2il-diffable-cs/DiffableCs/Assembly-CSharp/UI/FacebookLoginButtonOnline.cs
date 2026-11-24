namespace UI;

public class FacebookLoginButtonOnline : MonoBehaviour
{
	private sealed class <UserFeedback>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public FacebookLoginButtonOnline <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 147
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UserFeedback>d__24(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum LoginButtonState
	{
		Simple = 0,
		CouldNotConnectTryAgain = 1,
		Connecting = 2,
	}

	private GameObject _simpleContent; //Field offset: 0xC
	private UILabel _simpleLabel; //Field offset: 0x10
	private Layout _simpleLayout; //Field offset: 0x14
	private GameObject _connectingToGameObject; //Field offset: 0x18
	private Layout _connectingLayout; //Field offset: 0x1C
	private UILabel _connectingLabel; //Field offset: 0x20
	private GameObject _couldNotConnectTryAgainGameObject; //Field offset: 0x24
	private Layout _tryAgainLayout; //Field offset: 0x28
	private UILabel _tryAgain1; //Field offset: 0x2C
	private UILabel _tryAgain2; //Field offset: 0x30
	private UIButtonOverlayOff _btnOverlayOffDefault; //Field offset: 0x34
	private UIButtonOverlayOff _btnOverlayOffTryAgain; //Field offset: 0x38
	private bool _isGameOverScreen; //Field offset: 0x3C
	private bool _shouldDisplayAwardsSpecific; //Field offset: 0x3D
	private bool _shouldDisplayTopRunSpecific; //Field offset: 0x3E
	private LoginButtonState _loginButtonState; //Field offset: 0x40
	private bool _enabled; //Field offset: 0x44

	public FacebookLoginButtonOnline() { }

	private void EnableTouch(bool enable) { }

	private void FacebookLoggedIn(bool success) { }

	private void FacebookStateChanged() { }

	private void FriendsConsolidated(bool success) { }

	public void Init(bool isLoggedIntoFacebook, bool isAwardsSpecific = false, bool isLoggedIntoGC = false, bool isTopRunSpecific = false, bool noGCFriends = false, bool isGameOverScreen = false) { }

	private void OnClick() { }

	private void OnDestroy() { }

	private void OnPress(bool pressed) { }

	private void QueueSlideIn(bool success) { }

	private void SetState(LoginButtonState newState) { }

	private IEnumerator UserFeedback() { }

}

