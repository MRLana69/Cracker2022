namespace UI.Popups;

public class CloudSaveReminderPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__10_0; //Field offset: 0x4
		public static Action <>9__10_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <DisableClicked>b__10_0() { }

		internal void <DisableClicked>b__10_1() { }

	}

	private UILabel _headline; //Field offset: 0x28
	private UILabel _subline; //Field offset: 0x2C
	private UILabel _messageLabel; //Field offset: 0x30
	private UILabel _disableLabel; //Field offset: 0x34
	private UILabel _fixLabel; //Field offset: 0x38
	private UIWidget _skyline; //Field offset: 0x3C
	private UISprite _background; //Field offset: 0x40

	public CloudSaveReminderPopup() { }

	public void CloseClicked() { }

	public void DisableClicked() { }

	public void FixClicked() { }

	private void FlurryLogOnButtonClicked(string buttonClicked) { }

	public override void Init() { }

	private void SetupBasic() { }

	public override void Show() { }

}

