namespace UnityEngine.UI;

public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	protected enum SelectionState
	{
		Normal = 0,
		Highlighted = 1,
		Pressed = 2,
		Selected = 3,
		Disabled = 4,
	}

	public enum Transition
	{
		None = 0,
		ColorTint = 1,
		SpriteSwap = 2,
		Animation = 3,
	}

	private static Selectable[] s_Selectables; //Field offset: 0x0
	private static int s_SelectableCount; //Field offset: 0x4
	private static bool s_IsDirty; //Field offset: 0x8
	private Navigation m_Navigation; //Field offset: 0xC
	private Transition m_Transition; //Field offset: 0x20
	private ColorBlock m_Colors; //Field offset: 0x24
	private SpriteState m_SpriteState; //Field offset: 0x7C
	private AnimationTriggers m_AnimationTriggers; //Field offset: 0x8C
	private bool m_Interactable; //Field offset: 0x90
	private Graphic m_TargetGraphic; //Field offset: 0x94
	private bool m_GroupsAllowInteraction; //Field offset: 0x98
	private bool m_WillRemove; //Field offset: 0x99
	private bool <isPointerInside>k__BackingField; //Field offset: 0x9A
	private bool <isPointerDown>k__BackingField; //Field offset: 0x9B
	private bool <hasSelection>k__BackingField; //Field offset: 0x9C
	private readonly List<CanvasGroup> m_CanvasGroupCache; //Field offset: 0xA0

	public static int allSelectableCount
	{
		 get { } //Length: 240
	}

	public static List<Selectable> allSelectables
	{
		 get { } //Length: 89
	}

	public static Selectable[] allSelectablesArray
	{
		 get { } //Length: 7
	}

	public AnimationTriggers animationTriggers
	{
		 get { } //Length: 6
		 set { } //Length: 105
	}

	public Animator animator
	{
		 get { } //Length: 53
	}

	public ColorBlock colors
	{
		 get { } //Length: 65
		 set { } //Length: 9
	}

	protected SelectionState currentSelectionState
	{
		 get { } //Length: 22
	}

	private bool hasSelection
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	public Image image
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	public bool interactable
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	private bool isPointerDown
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	private bool isPointerInside
	{
		 get { } //Length: 10
		 set { } //Length: 313
	}

	public Navigation navigation
	{
		 get { } //Length: 358
		 set { } //Length: 36
	}

	public SpriteState spriteState
	{
		 get { } //Length: 201
		 set { } //Length: 27
	}

	public Graphic targetGraphic
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	public Transition transition
	{
		 get { } //Length: 321
		 set { } //Length: 114
	}

	private static Selectable() { }

	protected Selectable() { }

	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	protected override void Awake() { }

	private void DoSpriteSwap(Sprite newSprite) { }

	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	private void EvaluateAndTransitionToSelectionState() { }

	public Selectable FindSelectable(Vector3 dir) { }

	public virtual Selectable FindSelectableOnDown() { }

	public virtual Selectable FindSelectableOnLeft() { }

	public virtual Selectable FindSelectableOnRight() { }

	public virtual Selectable FindSelectableOnUp() { }

	public static int get_allSelectableCount() { }

	public static List<Selectable> get_allSelectables() { }

	public static Selectable[] get_allSelectablesArray() { }

	public AnimationTriggers get_animationTriggers() { }

	public Animator get_animator() { }

	public ColorBlock get_colors() { }

	protected SelectionState get_currentSelectionState() { }

	private bool get_hasSelection() { }

	public Image get_image() { }

	public bool get_interactable() { }

	private bool get_isPointerDown() { }

	private bool get_isPointerInside() { }

	public Navigation get_navigation() { }

	public SpriteState get_spriteState() { }

	public Graphic get_targetGraphic() { }

	public Transition get_transition() { }

	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	protected virtual void InstantClearState() { }

	protected bool IsHighlighted() { }

	public virtual bool IsInteractable() { }

	protected bool IsPressed() { }

	private void Navigate(AxisEventData eventData, Selectable sel) { }

	protected override void OnCanvasGroupChanged() { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	protected override void OnDidApplyAnimationProperties() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public virtual void OnMove(AxisEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	private void OnSetProperty() { }

	protected override void OnTransformParentChanged() { }

	private static void RemoveInvalidSelectables() { }

	public virtual void Select() { }

	public void set_animationTriggers(AnimationTriggers value) { }

	public void set_colors(ColorBlock value) { }

	private void set_hasSelection(bool value) { }

	public void set_image(Image value) { }

	public void set_interactable(bool value) { }

	private void set_isPointerDown(bool value) { }

	private void set_isPointerInside(bool value) { }

	public void set_navigation(Navigation value) { }

	public void set_spriteState(SpriteState value) { }

	public void set_targetGraphic(Graphic value) { }

	public void set_transition(Transition value) { }

	private void StartColorTween(Color targetColor, bool instant) { }

	private void TriggerAnimation(string triggername) { }

}

