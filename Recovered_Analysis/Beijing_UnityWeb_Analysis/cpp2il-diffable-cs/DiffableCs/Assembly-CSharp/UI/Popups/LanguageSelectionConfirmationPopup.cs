namespace UI.Popups;

public class LanguageSelectionConfirmationPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__9_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <YesClicked>b__9_0() { }

	}

	public static Locale requestedLocale; //Field offset: 0x0
	private const string COLOR_START = "[c][0374A5]"; //Field offset: 0x0
	private const string COLOR_END = "[-][/c]"; //Field offset: 0x0
	private UILabel _title; //Field offset: 0x28
	private UILabel _description; //Field offset: 0x2C
	private UILabel _yesLabel; //Field offset: 0x30
	private UILabel _noLabel; //Field offset: 0x34

	private static LanguageSelectionConfirmationPopup() { }

	public LanguageSelectionConfirmationPopup() { }

	public override void Init() { }

	public override void Show() { }

	public void YesClicked() { }

}

