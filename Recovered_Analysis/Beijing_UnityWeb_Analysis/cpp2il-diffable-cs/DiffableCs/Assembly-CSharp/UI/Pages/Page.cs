namespace UI.Pages;

public abstract class Page : MonoBehaviour
{
	protected UIWidget topContainer; //Field offset: 0xC

	protected Page() { }

	public abstract FooterPayload GetButtonPayload() { }

	public abstract void Hide() { }

	public abstract void Init(UIWidget pageGuideWidget) { }

	public abstract void Show() { }

	protected void TopAlign(UIWidget pageGuideWidget) { }

}

