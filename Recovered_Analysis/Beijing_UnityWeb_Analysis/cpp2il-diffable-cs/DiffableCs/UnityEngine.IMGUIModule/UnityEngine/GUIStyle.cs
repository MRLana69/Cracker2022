namespace UnityEngine;

public sealed class GUIStyle
{
	internal static bool showKeyboardFocus; //Field offset: 0x0
	private static GUIStyle s_None; //Field offset: 0x4
	internal nint m_Ptr; //Field offset: 0x8
	private GUIStyleState m_Normal; //Field offset: 0xC
	private GUIStyleState m_Hover; //Field offset: 0x10
	private GUIStyleState m_Active; //Field offset: 0x14
	private GUIStyleState m_Focused; //Field offset: 0x18
	private GUIStyleState m_OnNormal; //Field offset: 0x1C
	private GUIStyleState m_OnHover; //Field offset: 0x20
	private GUIStyleState m_OnActive; //Field offset: 0x24
	private GUIStyleState m_OnFocused; //Field offset: 0x28
	private RectOffset m_Border; //Field offset: 0x2C
	private RectOffset m_Padding; //Field offset: 0x30
	private RectOffset m_Margin; //Field offset: 0x34
	private RectOffset m_Overflow; //Field offset: 0x38

	public TextAnchor alignment
	{
		 set { } //Length: 53
	}

	public Vector2 contentOffset
	{
		 get { } //Length: 53
		 set { } //Length: 43
	}

	public float fixedHeight
	{
		 get { } //Length: 49
	}

	public float fixedWidth
	{
		 get { } //Length: 27
	}

	public Font font
	{
		 get { } //Length: 49
	}

	public int fontSize
	{
		 set { } //Length: 53
	}

	public ImagePosition imagePosition
	{
		 get { } //Length: 49
	}

	internal Vector2 Internal_clipOffset
	{
		 set { } //Length: 53
	}

	public bool isHeightDependantOnWidth
	{
		 get { } //Length: 175
	}

	public float lineHeight
	{
		 get { } //Length: 49
	}

	public RectOffset margin
	{
		 get { } //Length: 46
	}

	public string name
	{
		 get { } //Length: 137
		 set { } //Length: 150
	}

	public static GUIStyle none
	{
		 get { } //Length: 47
	}

	public GUIStyleState normal
	{
		 get { } //Length: 49
	}

	public RectOffset padding
	{
		 get { } //Length: 101
	}

	public bool stretchHeight
	{
		 get { } //Length: 49
		 set { } //Length: 11
	}

	public bool stretchWidth
	{
		 get { } //Length: 49
	}

	public bool wordWrap
	{
		 get { } //Length: 49
	}

	private static GUIStyle() { }

	public GUIStyle() { }

	public GUIStyle(GUIStyle other) { }

	public float CalcHeight(GUIContent content, float width) { }

	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	public Vector2 CalcSize(GUIContent content) { }

	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	protected override void Finalize() { }

	public Vector2 get_contentOffset() { }

	private void get_contentOffset_Injected(out Vector2 ret) { }

	public float get_fixedHeight() { }

	public float get_fixedWidth() { }

	public Font get_font() { }

	public ImagePosition get_imagePosition() { }

	public bool get_isHeightDependantOnWidth() { }

	public float get_lineHeight() { }

	public RectOffset get_margin() { }

	public string get_name() { }

	public static GUIStyle get_none() { }

	public GUIStyleState get_normal() { }

	public RectOffset get_padding() { }

	public bool get_stretchHeight() { }

	public bool get_stretchWidth() { }

	public bool get_wordWrap() { }

	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	private nint GetRectOffsetPtr(int idx) { }

	private nint GetStyleStatePtr(int idx) { }

	private float Internal_CalcHeight(GUIContent content, float width) { }

	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	internal Vector2 Internal_CalcSize(GUIContent content) { }

	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	private static nint Internal_Copy(GUIStyle self, GUIStyle other) { }

	private static nint Internal_Create(GUIStyle self) { }

	private static void Internal_Destroy(nint self) { }

	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	private static float Internal_GetCursorFlashOffset() { }

	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	private static float Internal_GetLineHeight(nint target) { }

	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	public static GUIStyle op_Implicit(string str) { }

	public void set_alignment(TextAnchor value) { }

	public void set_contentOffset(Vector2 value) { }

	private void set_contentOffset_Injected(ref Vector2 value) { }

	public void set_fontSize(int value) { }

	internal void set_Internal_clipOffset(Vector2 value) { }

	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	public void set_name(string value) { }

	public void set_stretchHeight(bool value) { }

	internal static void SetDefaultFont(Font font) { }

	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

	public override string ToString() { }

}

