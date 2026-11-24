namespace UI.ButtonHelpers;

public class OkButtonHelper : MonoBehaviour
{
	private UILabel _okButtonLabel; //Field offset: 0xC
	private Action OkButtonClicked; //Field offset: 0x10

	public event Action OkButtonClicked
	{
		 add { } //Length: 80
		 remove { } //Length: 111
	}

	public OkButtonHelper() { }

	public void add_OkButtonClicked(Action value) { }

	private void OnClick() { }

	private void OnEnable() { }

	public void remove_OkButtonClicked(Action value) { }

}

