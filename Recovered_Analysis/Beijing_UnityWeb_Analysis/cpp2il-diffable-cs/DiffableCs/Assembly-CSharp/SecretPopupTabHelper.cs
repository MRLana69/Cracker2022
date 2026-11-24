//Type is in global namespace

public class SecretPopupTabHelper : MonoBehaviour
{
	public enum Tabs
	{
		Tab1 = 0,
		Tab2 = 1,
		Tab3 = 2,
		Tab4 = 3,
	}

	private GameObject _tab1ActiveBG; //Field offset: 0xC
	private GameObject _tab1InactiveBG; //Field offset: 0x10
	private UILabel _tab1Label; //Field offset: 0x14
	private GameObject _tab2ActiveBG; //Field offset: 0x18
	private GameObject _tab2InactiveBG; //Field offset: 0x1C
	private UILabel _tab2Label; //Field offset: 0x20
	private GameObject _tab3ActiveBG; //Field offset: 0x24
	private GameObject _tab3InactiveBG; //Field offset: 0x28
	private UILabel _tab3Label; //Field offset: 0x2C
	private GameObject _tab4ActiveBG; //Field offset: 0x30
	private GameObject _tab4InactiveBG; //Field offset: 0x34
	private UILabel _tab4Label; //Field offset: 0x38

	public SecretPopupTabHelper() { }

	private void Awake() { }

	private void SetLabelActive(UILabel label, bool isActive) { }

	private void SetTabActivation(Tabs tab) { }

	public void Tab1Tapped() { }

	public void Tab2Tapped() { }

	public void Tab3Tapped() { }

	public void Tab4Tapped() { }

}

