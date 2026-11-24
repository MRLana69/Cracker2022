namespace UI.Popups.CloudSaveAdvancedComparisonPopupInternal;

public class CloudSaveAdvancedComparisonRow : MonoBehaviour
{
	public class CloudSaveComparisonRowPayload
	{
		public string name; //Field offset: 0x8
		public string localValue; //Field offset: 0xC
		public string onlineValue; //Field offset: 0x10
		public bool showBackground; //Field offset: 0x14
		public bool isLocalImprovement; //Field offset: 0x15
		public bool isOnlineImprovement; //Field offset: 0x16

		public CloudSaveComparisonRowPayload() { }

	}

	private UILabel _name; //Field offset: 0xC
	private UILabel _localValue; //Field offset: 0x10
	private UILabel _onlineValue; //Field offset: 0x14
	private UISprite _background; //Field offset: 0x18

	public CloudSaveAdvancedComparisonRow() { }

	private static void ColorTextField(UILabel label, bool isImprovement) { }

	public void SetupRow(CloudSaveComparisonRowPayload payload) { }

}

