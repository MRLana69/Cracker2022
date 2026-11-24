namespace UI.Popups;

public class CloudSaveStatusPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__28_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <DisconnectClicked>b__28_0() { }

	}

	private sealed class <AuthRoutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudSaveStatusPopup <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 548
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AuthRoutine>d__29(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DelayedGainFocus>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudSaveStatusPopup <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 79
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedGainFocus>d__20(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum Status
	{
		Ok = 0,
		Error = 1,
		Conflict = 2,
	}

	private Status _screenStatus; //Field offset: 0x28
	private UILabel _headline; //Field offset: 0x2C
	private UILabel _subline; //Field offset: 0x30
	private UILabel _bannerTopLabel; //Field offset: 0x34
	private UILabel _bannerBottomLabel; //Field offset: 0x38
	private UILabel _disconnectLabel; //Field offset: 0x3C
	private UILabel _statusLabel; //Field offset: 0x40
	private UILabel _buttonLabel; //Field offset: 0x44
	private UISprite _banner; //Field offset: 0x48
	private UIWidget _skyline; //Field offset: 0x4C
	private UISprite _statusSprite; //Field offset: 0x50
	private UISprite _background; //Field offset: 0x54
	private GameObject _rays; //Field offset: 0x58
	private GameObject _button; //Field offset: 0x5C
	private UIButtonOverlayOff _buttonOverlay; //Field offset: 0x60
	private UISprite _spinner; //Field offset: 0x64

	public CloudSaveStatusPopup() { }

	private void <DisconnectClicked>b__28_1() { }

	private IEnumerator AuthRoutine() { }

	public void ButtonClicked() { }

	private IEnumerator DelayedGainFocus() { }

	public void DisconnectClicked() { }

	public override void GainFocus() { }

	public override void Init() { }

	private void ResetPopup() { }

	private void SetupBasic() { }

	private void SetupConflictStatus() { }

	private void SetupErrorStatus() { }

	private void SetupSavedStatus() { }

	private void SetupStatus() { }

	public override void Show() { }

}

