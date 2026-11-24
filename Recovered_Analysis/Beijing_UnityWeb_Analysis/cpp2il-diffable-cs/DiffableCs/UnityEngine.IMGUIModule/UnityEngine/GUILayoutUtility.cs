namespace UnityEngine;

public class GUILayoutUtility
{
	internal sealed class LayoutCache
	{
		internal GUILayoutGroup topLevel; //Field offset: 0x8
		internal GenericStack layoutGroups; //Field offset: 0xC
		internal GUILayoutGroup windows; //Field offset: 0x10

		internal LayoutCache() { }

	}

	private static readonly Dictionary<int, LayoutCache> s_StoredLayouts; //Field offset: 0x0
	private static readonly Dictionary<int, LayoutCache> s_StoredWindows; //Field offset: 0x4
	internal static LayoutCache current; //Field offset: 0x8
	internal static readonly Rect kDummyRect; //Field offset: 0xC

	private static GUILayoutUtility() { }

	internal static void Begin(int instanceID) { }

	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	internal static void EndLayoutGroup() { }

	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	private static Rect Internal_GetWindowRect(int windowID) { }

	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	private static void Internal_MoveWindow(int windowID, Rect r) { }

	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }

	internal static void Layout() { }

	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	internal static void LayoutFromEditorWindow() { }

	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	internal static LayoutCache SelectIDList(int instanceID, bool isWindow) { }

}

