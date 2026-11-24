//Type is in global namespace

public class UIButtonScale : MonoBehaviour
{
	public Transform tweenTarget; //Field offset: 0xC
	public Vector3 hover; //Field offset: 0x10
	public Vector3 pressed; //Field offset: 0x1C
	public float duration; //Field offset: 0x28
	private Vector3 mScale; //Field offset: 0x2C
	private bool mStarted; //Field offset: 0x38

	public UIButtonScale() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnHover(bool isOver) { }

	private void OnPress(bool isPressed) { }

	private void OnSelect(bool isSelected) { }

	private void Start() { }

}

