namespace UI;

public class UICameraScreenClipping : MonoBehaviour
{
	private const float SCREEN_WIDTH = 306; //Field offset: 0x0
	private const float POPUP_WIDTH = 265; //Field offset: 0x0
	private Rect previousRect; //Field offset: 0xC
	private bool _setClippingOnStart; //Field offset: 0x1C

	public UICameraScreenClipping() { }

	public void CalculateClipping(bool popupSizedClip) { }

	public void ResetClipping() { }

	private void Start() { }

}

