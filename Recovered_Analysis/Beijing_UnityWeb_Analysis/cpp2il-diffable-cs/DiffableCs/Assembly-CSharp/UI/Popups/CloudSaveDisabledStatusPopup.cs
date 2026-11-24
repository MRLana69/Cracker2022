namespace UI.Popups;

public class CloudSaveDisabledStatusPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <ButtonClicked_Routine>b__17_0() { }

	}

	private sealed class <ButtonClicked_Routine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudSaveDisabledStatusPopup <>4__this; //Field offset: 0x10
		private bool <loggedIntoNative>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 948
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ButtonClicked_Routine>d__17(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private UILabel _headline; //Field offset: 0x28
	private UILabel _message1; //Field offset: 0x2C
	private UILabel _message2; //Field offset: 0x30
	private UILabel _buttonLabel; //Field offset: 0x34
	private UISprite _background; //Field offset: 0x38
	private UIWidget _skyline; //Field offset: 0x3C
	private Layout _horizontalLayout; //Field offset: 0x40
	private Layout _verticalLayout; //Field offset: 0x44
	private UIButtonOverlayOff _buttonOverlay; //Field offset: 0x48
	private UISprite _spinner; //Field offset: 0x4C
	private UISprite _glow; //Field offset: 0x50
	private bool _authRoutineRunning; //Field offset: 0x54

	public CloudSaveDisabledStatusPopup() { }

	public void ButtonClicked() { }

	private IEnumerator ButtonClicked_Routine() { }

	public override void Init() { }

	private void ResetPopup() { }

	private void SetupBasic() { }

	public override void Show() { }

}

