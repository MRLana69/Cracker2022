//Type is in global namespace

public class UIPlayTween : MonoBehaviour
{
	public static UIPlayTween current; //Field offset: 0x0
	public GameObject tweenTarget; //Field offset: 0xC
	public int tweenGroup; //Field offset: 0x10
	public Trigger trigger; //Field offset: 0x14
	public Direction playDirection; //Field offset: 0x18
	public bool resetOnPlay; //Field offset: 0x1C
	public bool resetIfDisabled; //Field offset: 0x1D
	public EnableCondition ifDisabledOnPlay; //Field offset: 0x20
	public DisableCondition disableWhenFinished; //Field offset: 0x24
	public bool includeChildren; //Field offset: 0x28
	public List<EventDelegate> onFinished; //Field offset: 0x2C
	private GameObject eventReceiver; //Field offset: 0x30
	private string callWhenFinished; //Field offset: 0x34
	private UITweener[] mTweens; //Field offset: 0x38
	private bool mStarted; //Field offset: 0x3C
	private int mActive; //Field offset: 0x40
	private bool mActivated; //Field offset: 0x44

	public UIPlayTween() { }

	private void Awake() { }

	private void CustomHoverListener(GameObject go, bool isOver) { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnDoubleClick() { }

	private void OnDragOut() { }

	private void OnDragOver() { }

	private void OnEnable() { }

	private void OnFinished() { }

	private void OnHover(bool isOver) { }

	private void OnPress(bool isPressed) { }

	private void OnSelect(bool isSelected) { }

	private void OnToggle() { }

	public void Play(bool forward) { }

	private void Start() { }

	private void Update() { }

}

