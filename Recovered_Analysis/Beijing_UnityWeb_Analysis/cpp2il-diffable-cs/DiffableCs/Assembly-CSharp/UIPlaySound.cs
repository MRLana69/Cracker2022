//Type is in global namespace

public class UIPlaySound : MonoBehaviour
{
	public enum Trigger
	{
		OnClick = 0,
		OnMouseOver = 1,
		OnMouseOut = 2,
		OnPress = 3,
		OnRelease = 4,
		Custom = 5,
		OnEnable = 6,
		OnDisable = 7,
	}

	public AudioClip audioClip; //Field offset: 0xC
	public Trigger trigger; //Field offset: 0x10
	public float volume; //Field offset: 0x14
	public float pitch; //Field offset: 0x18
	private bool mIsOver; //Field offset: 0x1C

	private bool canPlay
	{
		 get { } //Length: 23
	}

	public UIPlaySound() { }

	private bool get_canPlay() { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnHover(bool isOver) { }

	private void OnPress(bool isPressed) { }

	private void OnSelect(bool isSelected) { }

	public void Play() { }

}

