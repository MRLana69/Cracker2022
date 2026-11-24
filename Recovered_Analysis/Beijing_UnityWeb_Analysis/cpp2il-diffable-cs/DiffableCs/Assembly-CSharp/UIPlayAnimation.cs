//Type is in global namespace

public class UIPlayAnimation : MonoBehaviour
{
	public static UIPlayAnimation current; //Field offset: 0x0
	public Animation target; //Field offset: 0xC
	public Animator animator; //Field offset: 0x10
	public string clipName; //Field offset: 0x14
	public Trigger trigger; //Field offset: 0x18
	public Direction playDirection; //Field offset: 0x1C
	public bool resetOnPlay; //Field offset: 0x20
	public bool clearSelection; //Field offset: 0x21
	public EnableCondition ifDisabledOnPlay; //Field offset: 0x24
	public DisableCondition disableWhenFinished; //Field offset: 0x28
	public List<EventDelegate> onFinished; //Field offset: 0x2C
	private GameObject eventReceiver; //Field offset: 0x30
	private string callWhenFinished; //Field offset: 0x34
	private bool mStarted; //Field offset: 0x38
	private bool mActivated; //Field offset: 0x39
	private bool dragHighlight; //Field offset: 0x3A

	private bool dualState
	{
		 get { } //Length: 225
	}

	private static UIPlayAnimation() { }

	public UIPlayAnimation() { }

	private void Awake() { }

	private bool get_dualState() { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnDoubleClick() { }

	private void OnDragOut() { }

	private void OnDragOver() { }

	private void OnDrop(GameObject go) { }

	private void OnEnable() { }

	private void OnFinished() { }

	private void OnHover(bool isOver) { }

	private void OnPress(bool isPressed) { }

	private void OnSelect(bool isSelected) { }

	private void OnToggle() { }

	public void Play(bool forward) { }

	public void Play(bool forward, bool onlyIfDifferent) { }

	public void PlayForward() { }

	public void PlayReverse() { }

	private void Start() { }

}

