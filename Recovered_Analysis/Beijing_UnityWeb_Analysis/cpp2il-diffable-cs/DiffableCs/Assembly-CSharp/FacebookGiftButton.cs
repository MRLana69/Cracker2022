//Type is in global namespace

public class FacebookGiftButton : MonoBehaviour
{
	private UILabel title; //Field offset: 0xC
	private UILabel description; //Field offset: 0x10
	private UILabel _getLabel; //Field offset: 0x14
	private GameObject _breadCrumb; //Field offset: 0x18
	private int earnCurrencyProfileIndex; //Field offset: 0x1C
	private Action _onClickDelegate; //Field offset: 0x20
	private bool _didEnableBreadCrumb; //Field offset: 0x24

	public FacebookGiftButton() { }

	private void <LateUpdate>b__9_0() { }

	public void Init(int earnCurrencyProfileIndex, string earnerTitle, string earnerDesc, Action onClickDelegate, UIScrollView _panel) { }

	public void LateUpdate() { }

	private void OnClick() { }

}

