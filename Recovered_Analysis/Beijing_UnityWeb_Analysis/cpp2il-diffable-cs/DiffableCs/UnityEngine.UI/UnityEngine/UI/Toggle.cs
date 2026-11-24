namespace UnityEngine.UI;

public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
{
	public class ToggleEvent
	{

		public ToggleEvent() { }

	}

	public enum ToggleTransition
	{
		None = 0,
		Fade = 1,
	}

	public ToggleTransition toggleTransition; //Field offset: 0xA4
	public Graphic graphic; //Field offset: 0xA8
	private ToggleGroup m_Group; //Field offset: 0xAC
	public ToggleEvent onValueChanged; //Field offset: 0xB0
	private bool m_IsOn; //Field offset: 0xB4

	public ToggleGroup group
	{
		 get { } //Length: 3
		 set { } //Length: 1680
	}

	public bool isOn
	{
		 get { } //Length: 7
		 set { } //Length: 2
	}

	protected Toggle() { }

	public ToggleGroup get_group() { }

	public bool get_isOn() { }

	public virtual void GraphicUpdateComplete() { }

	private void InternalToggle() { }

	public virtual void LayoutComplete() { }

	protected override void OnDestroy() { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	private void PlayEffect(bool instant) { }

	public virtual void Rebuild(CanvasUpdate executing) { }

	private void Set(bool value, bool sendCallback = true) { }

	public void set_group(ToggleGroup value) { }

	public void set_isOn(bool value) { }

	public void SetIsOnWithoutNotify(bool value) { }

	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	protected override void Start() { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

