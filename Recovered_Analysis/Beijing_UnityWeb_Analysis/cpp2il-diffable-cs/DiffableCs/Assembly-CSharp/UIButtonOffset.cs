//Type is in global namespace

public class UIButtonOffset : MonoBehaviour
{
	public Transform tweenTarget; //Field offset: 0xC
	public Vector3 hover; //Field offset: 0x10
	public Vector3 pressed; //Field offset: 0x1C
	public float duration; //Field offset: 0x28
	private Vector3 mPos; //Field offset: 0x2C
	private bool mStarted; //Field offset: 0x38
	private bool mPressed; //Field offset: 0x39

	public UIButtonOffset() { }

	private void OnDisable() { }

	private void OnDragOut() { }

	private void OnDragOver() { }

	private void OnEnable() { }

	private void OnHover(bool isOver) { }

	private void OnPress(bool isPressed) { }

	private void OnSelect(bool isSelected) { }

	private void Start() { }

}

