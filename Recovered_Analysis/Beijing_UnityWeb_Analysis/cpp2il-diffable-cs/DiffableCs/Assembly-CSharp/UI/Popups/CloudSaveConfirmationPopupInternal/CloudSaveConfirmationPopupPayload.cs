namespace UI.Popups.CloudSaveConfirmationPopupInternal;

public class CloudSaveConfirmationPopupPayload
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__19_0() { }

		internal void <.cctor>b__19_1() { }

		internal void <.cctor>b__19_2() { }

		internal void <.cctor>b__19_3() { }

		internal void <.cctor>b__19_4() { }

		internal void <.cctor>b__19_5() { }

		internal void <.cctor>b__19_6() { }

		internal void <.cctor>b__19_7() { }

	}

	public enum ConfirmationState
	{
		Disconnect = 0,
		KeepLocal = 1,
		KeepOnline = 2,
		LoadProgress = 3,
	}

	public static readonly CloudSaveConfirmationPopupPayload DISCONNECT_PAYLOAD; //Field offset: 0x0
	public static readonly CloudSaveConfirmationPopupPayload KEEP_LOCAL_PAYLOAD; //Field offset: 0x4
	public static readonly CloudSaveConfirmationPopupPayload KEEP_ONLINE_PAYLOAD; //Field offset: 0x8
	public static readonly CloudSaveConfirmationPopupPayload LOAD_PROGRESS_PAYLOAD; //Field offset: 0xC
	private static CloudSaveConfirmationPopupPayload <activePayload>k__BackingField; //Field offset: 0x10
	public Action goodButtonClicked; //Field offset: 0x8
	public Action badButtonClicked; //Field offset: 0xC
	public string text; //Field offset: 0x10
	public string badButtonText; //Field offset: 0x14
	public string goodButtonText; //Field offset: 0x18
	public string cornerIcon; //Field offset: 0x1C
	public string cornerAccentIcon; //Field offset: 0x20
	public string flurryParameter; //Field offset: 0x24

	public static CloudSaveConfirmationPopupPayload activePayload
	{
		 get { } //Length: 89
		private set { } //Length: 211
	}

	private static CloudSaveConfirmationPopupPayload() { }

	public CloudSaveConfirmationPopupPayload() { }

	public static CloudSaveConfirmationPopupPayload get_activePayload() { }

	public static void PreparePayload(ConfirmationState state, Action goodButtonClicked, Action badButtonClicked) { }

	private static void set_activePayload(CloudSaveConfirmationPopupPayload value) { }

}

