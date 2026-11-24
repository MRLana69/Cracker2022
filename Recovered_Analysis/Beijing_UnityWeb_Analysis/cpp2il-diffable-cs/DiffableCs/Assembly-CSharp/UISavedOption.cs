//Type is in global namespace

public class UISavedOption : MonoBehaviour
{
	public string keyName; //Field offset: 0xC
	private UIPopupList mList; //Field offset: 0x10
	private UIToggle mCheck; //Field offset: 0x14
	private UIProgressBar mSlider; //Field offset: 0x18

	private string key
	{
		 get { } //Length: 23
	}

	public UISavedOption() { }

	private void Awake() { }

	private string get_key() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void SaveProgress() { }

	public void SaveSelection() { }

	public void SaveState() { }

}

