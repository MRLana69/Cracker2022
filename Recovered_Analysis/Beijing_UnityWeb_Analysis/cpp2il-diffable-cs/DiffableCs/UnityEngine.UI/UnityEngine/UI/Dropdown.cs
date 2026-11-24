namespace UnityEngine.UI;

public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
{
	private sealed class <>c__DisplayClass62_0
	{
		public DropdownItem item; //Field offset: 0x8
		public Dropdown <>4__this; //Field offset: 0xC

		public <>c__DisplayClass62_0() { }

		internal void <Show>b__0(bool x) { }

	}

	private sealed class <DelayedDestroyDropdownList>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float delay; //Field offset: 0x10
		public Dropdown <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 151
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DelayedDestroyDropdownList>d__74(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class DropdownEvent
	{

		public DropdownEvent() { }

	}

	protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
	{
		private Text m_Text; //Field offset: 0xC
		private Image m_Image; //Field offset: 0x10
		private RectTransform m_RectTransform; //Field offset: 0x14
		private Toggle m_Toggle; //Field offset: 0x18

		public Image image
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public RectTransform rectTransform
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public Text text
		{
			 get { } //Length: 6
			 set { } //Length: 8
		}

		public Toggle toggle
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public DropdownItem() { }

		public Image get_image() { }

		public RectTransform get_rectTransform() { }

		public Text get_text() { }

		public Toggle get_toggle() { }

		public virtual void OnCancel(BaseEventData eventData) { }

		public virtual void OnPointerEnter(PointerEventData eventData) { }

		public void set_image(Image value) { }

		public void set_rectTransform(RectTransform value) { }

		public void set_text(Text value) { }

		public void set_toggle(Toggle value) { }

	}

	public class OptionData
	{
		private string m_Text; //Field offset: 0x8
		private Sprite m_Image; //Field offset: 0xC

		public Sprite image
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public string text
		{
			 get { } //Length: 6
			 set { } //Length: 106
		}

		public OptionData() { }

		public OptionData(string text) { }

		public OptionData(Sprite image) { }

		public OptionData(string text, Sprite image) { }

		public Sprite get_image() { }

		public string get_text() { }

		public void set_image(Sprite value) { }

		public void set_text(string value) { }

	}

	public class OptionDataList
	{
		private List<OptionData> m_Options; //Field offset: 0x8

		public List<OptionData> options
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public OptionDataList() { }

		public List<OptionData> get_options() { }

		public void set_options(List<OptionData> value) { }

	}

	private static OptionData s_NoOptionData; //Field offset: 0x0
	private RectTransform m_Template; //Field offset: 0xA4
	private Text m_CaptionText; //Field offset: 0xA8
	private Image m_CaptionImage; //Field offset: 0xAC
	private Text m_ItemText; //Field offset: 0xB0
	private Image m_ItemImage; //Field offset: 0xB4
	private int m_Value; //Field offset: 0xB8
	private OptionDataList m_Options; //Field offset: 0xBC
	private DropdownEvent m_OnValueChanged; //Field offset: 0xC0
	private float m_AlphaFadeSpeed; //Field offset: 0xC4
	private GameObject m_Dropdown; //Field offset: 0xC8
	private GameObject m_Blocker; //Field offset: 0xCC
	private List<DropdownItem> m_Items; //Field offset: 0xD0
	private TweenRunner<FloatTween> m_AlphaTweenRunner; //Field offset: 0xD4
	private bool validTemplate; //Field offset: 0xD8

	public float alphaFadeSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Image captionImage
	{
		 get { } //Length: 7
		 set { } //Length: 20
	}

	public Text captionText
	{
		 get { } //Length: 7
		 set { } //Length: 20
	}

	public Image itemImage
	{
		 get { } //Length: 7
		 set { } //Length: 20
	}

	public Text itemText
	{
		 get { } //Length: 7
		 set { } //Length: 20
	}

	public DropdownEvent onValueChanged
	{
		 get { } //Length: 10
		 set { } //Length: 23
	}

	public List<OptionData> options
	{
		 get { } //Length: 7
		 set { } //Length: 20
	}

	public RectTransform template
	{
		 get { } //Length: 1902
		 set { } //Length: 145
	}

	public int value
	{
		 get { } //Length: 7
		 set { } //Length: 12
	}

	private static Dropdown() { }

	protected Dropdown() { }

	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) { }

	public void AddOptions(List<Sprite> options) { }

	public void AddOptions(List<string> options) { }

	public void AddOptions(List<OptionData> options) { }

	private void AlphaFadeList(float duration, float start, float end) { }

	private void AlphaFadeList(float duration, float alpha) { }

	protected override void Awake() { }

	public void ClearOptions() { }

	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	protected virtual GameObject CreateDropdownList(GameObject template) { }

	protected virtual DropdownItem CreateItem(DropdownItem itemTemplate) { }

	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	protected virtual void DestroyBlocker(GameObject blocker) { }

	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	protected virtual void DestroyItem(DropdownItem item) { }

	public float get_alphaFadeSpeed() { }

	public Image get_captionImage() { }

	public Text get_captionText() { }

	public Image get_itemImage() { }

	public Text get_itemText() { }

	public DropdownEvent get_onValueChanged() { }

	public List<OptionData> get_options() { }

	public RectTransform get_template() { }

	public int get_value() { }

	private static T GetOrAddComponent(GameObject go) { }

	public void Hide() { }

	private void ImmediateDestroyDropdownList() { }

	public virtual void OnCancel(BaseEventData eventData) { }

	protected override void OnDisable() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	private void OnSelectItem(Toggle toggle) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	public void RefreshShownValue() { }

	private void Set(int value, bool sendCallback = true) { }

	public void set_alphaFadeSpeed(float value) { }

	public void set_captionImage(Image value) { }

	public void set_captionText(Text value) { }

	public void set_itemImage(Image value) { }

	public void set_itemText(Text value) { }

	public void set_onValueChanged(DropdownEvent value) { }

	public void set_options(List<OptionData> value) { }

	public void set_template(RectTransform value) { }

	public void set_value(int value) { }

	private void SetAlpha(float alpha) { }

	private void SetupTemplate() { }

	public void SetValueWithoutNotify(int input) { }

	public void Show() { }

	protected override void Start() { }

}

