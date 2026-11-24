//Type is in global namespace

public class ScrollListPopupCellHelper : MonoBehaviour
{
	public UILabel Title; //Field offset: 0xC
	public GameObject OffIcon; //Field offset: 0x10
	public GameObject OnIcon; //Field offset: 0x14
	public string cellID; //Field offset: 0x18
	private bool currentIconState; //Field offset: 0x1C

	public ScrollListPopupCellHelper() { }

	public void SetToggleIcon(bool selected) { }

	public void ToggleIcon() { }

	public void UpdateTitle(string title) { }

}

