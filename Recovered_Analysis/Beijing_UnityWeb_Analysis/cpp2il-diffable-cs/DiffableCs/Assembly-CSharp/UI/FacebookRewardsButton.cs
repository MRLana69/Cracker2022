namespace UI;

public class FacebookRewardsButton : MonoBehaviour
{
	private GameObject activeContent; //Field offset: 0xC
	private GameObject connectingContent; //Field offset: 0x10
	private UILabel _connectingLabel; //Field offset: 0x14
	private UIAnchor contentAnchor; //Field offset: 0x18
	private UILabel titleLabel; //Field offset: 0x1C
	private UILabel _description; //Field offset: 0x20
	private UILabel _priceLabel; //Field offset: 0x24
	private UILabel _getLabel; //Field offset: 0x28
	private Action onFacebookClick; //Field offset: 0x2C

	public event Action onFacebookClick
	{
		 add { } //Length: 338
		 remove { } //Length: 111
	}

	public FacebookRewardsButton() { }

	public void add_onFacebookClick(Action value) { }

	public void GoToActiveState() { }

	public void GoToConnectingState() { }

	private void InitializeButton() { }

	private void OnClick() { }

	private void OnEnable() { }

	public void remove_onFacebookClick(Action value) { }

}

