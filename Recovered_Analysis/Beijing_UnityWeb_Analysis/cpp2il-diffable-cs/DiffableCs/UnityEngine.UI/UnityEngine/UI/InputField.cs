namespace UnityEngine.UI;

public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
{
	private sealed class <CaretBlink>d__159 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public InputField <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 235
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CaretBlink>d__159(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <MouseDragOutsideRect>d__179 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public InputField <>4__this; //Field offset: 0x10
		public PointerEventData eventData; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 648
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <MouseDragOutsideRect>d__179(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum CharacterValidation
	{
		None = 0,
		Integer = 1,
		Decimal = 2,
		Alphanumeric = 3,
		Name = 4,
		EmailAddress = 5,
	}

	public enum ContentType
	{
		Standard = 0,
		Autocorrected = 1,
		IntegerNumber = 2,
		DecimalNumber = 3,
		Alphanumeric = 4,
		Name = 5,
		EmailAddress = 6,
		Password = 7,
		Pin = 8,
		Custom = 9,
	}

	protected enum EditState
	{
		Continue = 0,
		Finish = 1,
	}

	public enum InputType
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2,
	}

	public enum LineType
	{
		SingleLine = 0,
		MultiLineSubmit = 1,
		MultiLineNewline = 2,
	}

	public class OnChangeEvent
	{

		public OnChangeEvent() { }

	}

	public delegate OnValidateInput
	{

		public OnValidateInput(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

		public virtual char EndInvoke(IAsyncResult result) { }

		public virtual char Invoke(string text, int charIndex, char addedChar) { }

	}

	public class SubmitEvent
	{

		public SubmitEvent() { }

	}

	private const int k_MaxTextLength = 16382; //Field offset: 0x0
	private static readonly char[] kSeparators; //Field offset: 0x0
	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~"; //Field offset: 0x0
	private const float kVScrollSpeed = 0.1; //Field offset: 0x0
	private const float kHScrollSpeed = 0.05; //Field offset: 0x0
	protected TouchScreenKeyboard m_Keyboard; //Field offset: 0xA4
	protected Text m_TextComponent; //Field offset: 0xA8
	protected Graphic m_Placeholder; //Field offset: 0xAC
	private ContentType m_ContentType; //Field offset: 0xB0
	private InputType m_InputType; //Field offset: 0xB4
	private char m_AsteriskChar; //Field offset: 0xB8
	private TouchScreenKeyboardType m_KeyboardType; //Field offset: 0xBC
	private LineType m_LineType; //Field offset: 0xC0
	private bool m_HideMobileInput; //Field offset: 0xC4
	private CharacterValidation m_CharacterValidation; //Field offset: 0xC8
	private int m_CharacterLimit; //Field offset: 0xCC
	private SubmitEvent m_OnEndEdit; //Field offset: 0xD0
	private OnChangeEvent m_OnValueChanged; //Field offset: 0xD4
	private OnValidateInput m_OnValidateInput; //Field offset: 0xD8
	private Color m_CaretColor; //Field offset: 0xDC
	private bool m_CustomCaretColor; //Field offset: 0xEC
	private Color m_SelectionColor; //Field offset: 0xF0
	protected string m_Text; //Field offset: 0x100
	private float m_CaretBlinkRate; //Field offset: 0x104
	private int m_CaretWidth; //Field offset: 0x108
	private bool m_ReadOnly; //Field offset: 0x10C
	protected int m_CaretPosition; //Field offset: 0x110
	protected int m_CaretSelectPosition; //Field offset: 0x114
	private RectTransform caretRectTrans; //Field offset: 0x118
	protected UIVertex[] m_CursorVerts; //Field offset: 0x11C
	private TextGenerator m_InputTextCache; //Field offset: 0x120
	private CanvasRenderer m_CachedInputRenderer; //Field offset: 0x124
	private bool m_PreventFontCallback; //Field offset: 0x128
	protected Mesh m_Mesh; //Field offset: 0x12C
	private bool m_AllowInput; //Field offset: 0x130
	private bool m_ShouldActivateNextUpdate; //Field offset: 0x131
	private bool m_UpdateDrag; //Field offset: 0x132
	private bool m_DragPositionOutOfBounds; //Field offset: 0x133
	protected bool m_CaretVisible; //Field offset: 0x134
	private Coroutine m_BlinkCoroutine; //Field offset: 0x138
	private float m_BlinkStartTime; //Field offset: 0x13C
	protected int m_DrawStart; //Field offset: 0x140
	protected int m_DrawEnd; //Field offset: 0x144
	private Coroutine m_DragCoroutine; //Field offset: 0x148
	private string m_OriginalText; //Field offset: 0x14C
	private bool m_WasCanceled; //Field offset: 0x150
	private bool m_HasDoneFocusTransition; //Field offset: 0x151
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; //Field offset: 0x154
	private bool m_TouchKeyboardAllowsInPlaceEditing; //Field offset: 0x158
	private Event m_ProcessingEvent; //Field offset: 0x15C

	public char asteriskChar
	{
		 get { } //Length: 25
		 set { } //Length: 12
	}

	protected TextGenerator cachedInputTextGenerator
	{
		 get { } //Length: 125
	}

	public float caretBlinkRate
	{
		 get { } //Length: 6
		 set { } //Length: 96
	}

	public Color caretColor
	{
		 get { } //Length: 56
		 set { } //Length: 51
	}

	public int caretPosition
	{
		 get { } //Length: 18
		 set { } //Length: 23
	}

	protected int caretPositionInternal
	{
		 get { } //Length: 10
		 set { } //Length: 64
	}

	protected int caretSelectPositionInternal
	{
		 get { } //Length: 23
		 set { } //Length: 23
	}

	public int caretWidth
	{
		 get { } //Length: 10
		 set { } //Length: 13
	}

	public int characterLimit
	{
		 get { } //Length: 7
		 set { } //Length: 56
	}

	public CharacterValidation characterValidation
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	private static string clipboard
	{
		 get { } //Length: 254
		 set { } //Length: 28
	}

	private string compositionString
	{
		 get { } //Length: 269
	}

	public ContentType contentType
	{
		 get { } //Length: 7
		 set { } //Length: 136
	}

	public bool customCaretColor
	{
		 get { } //Length: 7
		 set { } //Length: 61
	}

	public virtual float flexibleHeight
	{
		 get { } //Length: 646
	}

	public virtual float flexibleWidth
	{
		 get { } //Length: 556
	}

	private bool hasSelection
	{
		 get { } //Length: 23
	}

	private BaseInput input
	{
		 get { } //Length: 3
	}

	public InputType inputType
	{
		 get { } //Length: 7
		 set { } //Length: 100
	}

	public bool isFocused
	{
		 get { } //Length: 7
	}

	public TouchScreenKeyboardType keyboardType
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	public virtual int layoutPriority
	{
		 get { } //Length: 73
	}

	public LineType lineType
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	protected Mesh mesh
	{
		 get { } //Length: 111
	}

	public virtual float minHeight
	{
		 get { } //Length: 6
	}

	public virtual float minWidth
	{
		 get { } //Length: 7
	}

	public bool multiLine
	{
		 get { } //Length: 10
	}

	public SubmitEvent onEndEdit
	{
		 get { } //Length: 10
		 set { } //Length: 61
	}

	public OnValidateInput onValidateInput
	{
		 get { } //Length: 7
		 set { } //Length: 56
	}

	public OnChangeEvent onValueChange
	{
		 get { } //Length: 7
		 set { } //Length: 56
	}

	public OnChangeEvent onValueChanged
	{
		 get { } //Length: 7
		 set { } //Length: 11
	}

	public Graphic placeholder
	{
		 get { } //Length: 7
		 set { } //Length: 550
	}

	public virtual float preferredHeight
	{
		 get { } //Length: 6
	}

	public virtual float preferredWidth
	{
		 get { } //Length: 6
	}

	public bool readOnly
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	public int selectionAnchorPosition
	{
		 get { } //Length: 23
		 set { } //Length: 21
	}

	public Color selectionColor
	{
		 get { } //Length: 35
		 set { } //Length: 27
	}

	public int selectionFocusPosition
	{
		 get { } //Length: 23
		 set { } //Length: 38
	}

	private bool shouldActivateOnSelect
	{
		 get { } //Length: 59
	}

	public bool shouldHideMobileInput
	{
		 get { } //Length: 82
		 set { } //Length: 9648
	}

	public string text
	{
		 get { } //Length: 10
		 set { } //Length: 56
	}

	public Text textComponent
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	public TouchScreenKeyboard touchScreenKeyboard
	{
		 get { } //Length: 7
	}

	public bool wasCanceled
	{
		 get { } //Length: 7
	}

	private static InputField() { }

	protected InputField() { }

	public void ActivateInputField() { }

	private void ActivateInputFieldInternal() { }

	protected virtual void Append(string input) { }

	protected virtual void Append(char input) { }

	private void AssignPositioningIfNeeded() { }

	private void Backspace() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	private IEnumerator CaretBlink() { }

	protected void ClampPos(ref int pos) { }

	private void CreateCursorVerts() { }

	public void DeactivateInputField() { }

	private void Delete() { }

	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	protected override void DoStateTransition(SelectionState state, bool instant) { }

	private void EnforceContentType() { }

	private void EnforceTextHOverflow() { }

	private int FindtNextWordBegin() { }

	private int FindtPrevWordBegin() { }

	public void ForceLabelUpdate() { }

	private void ForwardSpace() { }

	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	public char get_asteriskChar() { }

	protected TextGenerator get_cachedInputTextGenerator() { }

	public float get_caretBlinkRate() { }

	public Color get_caretColor() { }

	public int get_caretPosition() { }

	protected int get_caretPositionInternal() { }

	protected int get_caretSelectPositionInternal() { }

	public int get_caretWidth() { }

	public int get_characterLimit() { }

	public CharacterValidation get_characterValidation() { }

	private static string get_clipboard() { }

	private string get_compositionString() { }

	public ContentType get_contentType() { }

	public bool get_customCaretColor() { }

	public virtual float get_flexibleHeight() { }

	public virtual float get_flexibleWidth() { }

	private bool get_hasSelection() { }

	private BaseInput get_input() { }

	public InputType get_inputType() { }

	public bool get_isFocused() { }

	public TouchScreenKeyboardType get_keyboardType() { }

	public virtual int get_layoutPriority() { }

	public LineType get_lineType() { }

	protected Mesh get_mesh() { }

	public virtual float get_minHeight() { }

	public virtual float get_minWidth() { }

	public bool get_multiLine() { }

	public SubmitEvent get_onEndEdit() { }

	public OnValidateInput get_onValidateInput() { }

	public OnChangeEvent get_onValueChange() { }

	public OnChangeEvent get_onValueChanged() { }

	public Graphic get_placeholder() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_preferredWidth() { }

	public bool get_readOnly() { }

	public int get_selectionAnchorPosition() { }

	public Color get_selectionColor() { }

	public int get_selectionFocusPosition() { }

	private bool get_shouldActivateOnSelect() { }

	public bool get_shouldHideMobileInput() { }

	public string get_text() { }

	public Text get_textComponent() { }

	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	public bool get_wasCanceled() { }

	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	private string GetSelectedString() { }

	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	public virtual void GraphicUpdateComplete() { }

	private bool InPlaceEditing() { }

	private void Insert(char c) { }

	private bool IsSelectionVisible() { }

	private bool IsValidChar(char c) { }

	protected EditState KeyPressed(Event evt) { }

	protected virtual void LateUpdate() { }

	public virtual void LayoutComplete() { }

	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	private void MarkGeometryAsDirty() { }

	private bool MayDrag(PointerEventData eventData) { }

	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	private void MoveDown(bool shift, bool goToLastChar) { }

	private void MoveDown(bool shift) { }

	private void MoveLeft(bool shift, bool ctrl) { }

	private void MoveRight(bool shift, bool ctrl) { }

	public void MoveTextEnd(bool shift) { }

	public void MoveTextStart(bool shift) { }

	private void MoveUp(bool shift) { }

	private void MoveUp(bool shift, bool goToFirstChar) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public override void OnDeselect(BaseEventData eventData) { }

	protected override void OnDisable() { }

	public virtual void OnDrag(PointerEventData eventData) { }

	protected override void OnEnable() { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	private void OnFillVBO(Mesh vbo) { }

	protected void OnFocus() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	public void ProcessEvent(Event e) { }

	public virtual void Rebuild(CanvasUpdate update) { }

	public Vector2 ScreenToLocal(Vector2 screen) { }

	protected void SelectAll() { }

	protected void SendOnSubmit() { }

	private void SendOnValueChanged() { }

	private void SendOnValueChangedAndUpdateLabel() { }

	public void set_asteriskChar(char value) { }

	public void set_caretBlinkRate(float value) { }

	public void set_caretColor(Color value) { }

	public void set_caretPosition(int value) { }

	protected void set_caretPositionInternal(int value) { }

	protected void set_caretSelectPositionInternal(int value) { }

	public void set_caretWidth(int value) { }

	public void set_characterLimit(int value) { }

	public void set_characterValidation(CharacterValidation value) { }

	private static void set_clipboard(string value) { }

	public void set_contentType(ContentType value) { }

	public void set_customCaretColor(bool value) { }

	public void set_inputType(InputType value) { }

	public void set_keyboardType(TouchScreenKeyboardType value) { }

	public void set_lineType(LineType value) { }

	public void set_onEndEdit(SubmitEvent value) { }

	public void set_onValidateInput(OnValidateInput value) { }

	public void set_onValueChange(OnChangeEvent value) { }

	public void set_onValueChanged(OnChangeEvent value) { }

	public void set_placeholder(Graphic value) { }

	public void set_readOnly(bool value) { }

	public void set_selectionAnchorPosition(int value) { }

	public void set_selectionColor(Color value) { }

	public void set_selectionFocusPosition(int value) { }

	public void set_shouldHideMobileInput(bool value) { }

	public void set_text(string value) { }

	public void set_textComponent(Text value) { }

	private void SetCaretActive() { }

	private void SetCaretVisible() { }

	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	private void SetText(string value, bool sendCallback = true) { }

	public void SetTextWithoutNotify(string input) { }

	private void SetToCustom() { }

	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	private void UpdateCaretFromKeyboard() { }

	private void UpdateCaretMaterial() { }

	private void UpdateGeometry() { }

	protected void UpdateLabel() { }

	private void UpdateTouchKeyboardFromEditChanges() { }

	protected char Validate(string text, int pos, char ch) { }

}

