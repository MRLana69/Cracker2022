namespace UI.Helpers;

public class LocalizationTitleHelper : MonoBehaviour
{
	private UILabel _title; //Field offset: 0xC
	private UILabel _subTitle; //Field offset: 0x10
	private string _titleStringId; //Field offset: 0x14
	private string _subTitleStringId; //Field offset: 0x18
	private int _titleStringIdIndex; //Field offset: 0x1C
	private int _subTitleStringIdIndex; //Field offset: 0x20

	public LocalizationTitleHelper() { }

	private void OnEnable() { }

}

