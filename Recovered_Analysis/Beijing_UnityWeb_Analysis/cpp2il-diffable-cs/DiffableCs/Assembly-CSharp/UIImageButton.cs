//Type is in global namespace

public class UIImageButton : MonoBehaviour
{
	public UISprite target; //Field offset: 0xC
	public string normalSprite; //Field offset: 0x10
	public string hoverSprite; //Field offset: 0x14
	public string pressedSprite; //Field offset: 0x18
	public string disabledSprite; //Field offset: 0x1C
	public bool pixelSnap; //Field offset: 0x20

	public bool isEnabled
	{
		 get { } //Length: 533
		 set { } //Length: 2227
	}

	public UIImageButton() { }

	public bool get_isEnabled() { }

	private void OnEnable() { }

	private void OnHover(bool isOver) { }

	private void OnPress(bool pressed) { }

	private void OnValidate() { }

	public void set_isEnabled(bool value) { }

	private void SetSprite(string sprite) { }

	private void UpdateImage() { }

}

