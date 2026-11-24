namespace UI.Popups.SecretPopupInternal;

public class SecretHelper : MonoBehaviour
{
	private UILabel _secretValue; //Field offset: 0xC
	private UILabel _secretInfo; //Field offset: 0x10
	private UILabel _secretTitle; //Field offset: 0x14
	private UILabel _secretInfo2; //Field offset: 0x18
	private UILabel _secretValue2; //Field offset: 0x1C

	public SecretHelper() { }

	public void UpdateInfo(string info, string value) { }

	public void UpdateInfoDouble(string info, string value, string info2, string value2) { }

	public void UpdateTitle(string title) { }

}

