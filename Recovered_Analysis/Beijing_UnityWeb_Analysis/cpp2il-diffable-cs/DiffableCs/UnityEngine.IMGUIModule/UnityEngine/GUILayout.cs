namespace UnityEngine;

public class GUILayout
{
	private sealed class LayoutedWindow
	{
		private readonly WindowFunction m_Func; //Field offset: 0x8
		private readonly Rect m_ScreenRect; //Field offset: 0xC
		private readonly GUILayoutOption[] m_Options; //Field offset: 0x1C
		private readonly GUIStyle m_Style; //Field offset: 0x20

		internal LayoutedWindow(WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style) { }

		public void DoWindow(int windowID) { }

	}


	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	public static void BeginArea(Rect screenRect, string text, GUIStyle style) { }

	public static void BeginArea(Rect screenRect, string text) { }

	public static void BeginArea(Rect screenRect) { }

	public static void BeginHorizontal(GUILayoutOption[] options) { }

	public static void BeginHorizontal(GUIStyle style, GUILayoutOption[] options) { }

	public static void BeginHorizontal(string text, GUIStyle style, GUILayoutOption[] options) { }

	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUILayoutOption[] options) { }

	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, GUILayoutOption[] options) { }

	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static void BeginVertical(string text, GUIStyle style, GUILayoutOption[] options) { }

	public static void BeginVertical(GUIStyle style, GUILayoutOption[] options) { }

	public static void BeginVertical(GUILayoutOption[] options) { }

	public static bool Button(GUIContent content, GUILayoutOption[] options) { }

	public static bool Button(string text, GUILayoutOption[] options) { }

	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static Rect DoWindow(int id, Rect screenRect, WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	public static void EndArea() { }

	public static void EndHorizontal() { }

	public static void EndScrollView() { }

	internal static void EndScrollView(bool handleScrollWheel) { }

	public static void EndVertical() { }

	public static GUILayoutOption ExpandWidth(bool expand) { }

	public static GUILayoutOption Height(float height) { }

	public static void Label(string text, GUILayoutOption[] options) { }

	public static GUILayoutOption MinHeight(float minHeight) { }

	public static bool Toggle(bool value, GUIContent content, GUILayoutOption[] options) { }

	public static GUILayoutOption Width(float width) { }

	public static Rect Window(int id, Rect screenRect, WindowFunction func, string text, GUILayoutOption[] options) { }

}

