namespace UI.Popups;

public class CloudSaveIntroductionPopup : UIScreen
{
	private sealed class <LoginRoutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudSaveIntroductionPopup <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 688
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoginRoutine>d__19(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum HideAction
	{
		None = 0,
		Closed = 1,
		Saved = 2,
		Refreshed = 3,
	}

	private UILabel _header; //Field offset: 0x28
	private UILabel _speechBubbleText; //Field offset: 0x2C
	private UILabel _bottomText; //Field offset: 0x30
	private UIWidget _skyline; //Field offset: 0x34
	private UIWidget _skylineFiller; //Field offset: 0x38
	private UILabel _buttonText; //Field offset: 0x3C
	private UIButtonOverlayOff _buttonOverlay; //Field offset: 0x40
	private UISprite _spinner; //Field offset: 0x44
	private bool _isLoggedInNative; //Field offset: 0x48
	private HideAction _hideSourceAction; //Field offset: 0x4C

	public CloudSaveIntroductionPopup() { }

	public void CloseClicked() { }

	private void FlurryLogCloudSaveEnabled() { }

	private void FlurryLogPopupShown(string clickType) { }

	public override void Hide() { }

	public override void Init() { }

	private void Localize() { }

	private void LocalizeLoggedIn() { }

	private void LocalizeLoggedOut() { }

	private IEnumerator LoginRoutine() { }

	private void LogLastShownTime() { }

	public void SaveNowClicked() { }

	private void SetupBasic() { }

	public override void Show() { }

}

