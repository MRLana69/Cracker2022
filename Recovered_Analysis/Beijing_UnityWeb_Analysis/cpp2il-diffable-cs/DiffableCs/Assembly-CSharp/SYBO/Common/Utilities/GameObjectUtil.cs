namespace SYBO.Common.Utilities;

public static class GameObjectUtil
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<HierarchyDepthContainer> <>9__43_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <GetComponentsInChildrenBFS>b__43_0(HierarchyDepthContainer x, HierarchyDepthContainer y) { }

	}

	private struct HierarchyDepthContainer
	{
		public Component Component; //Field offset: 0x0
		public int HierarchyCount; //Field offset: 0x4
		public int Index; //Field offset: 0x8

		public HierarchyDepthContainer(Component component, int index) { }

	}


	public static T AddComponentIfMissing(Component comp) { }

	public static T AddComponentIfMissing(GameObject go) { }

	public static Component AddComponentIfMissing(Component comp, Type type) { }

	public static Component AddComponentIfMissing(GameObject go, Type type) { }

	public static int ComparePositionZ(Vector3 lhs, Vector3 rhs) { }

	public static void GetComponentsInChildrenBFS(Component c, bool includeInactive, List<T> result, bool includeSelf) { }

	public static T[] GetComponentsInChildrenBFS(Component c, bool includeInactive) { }

	public static T[] GetComponentsInChildrenBFS(Component c, bool includeInactive, bool includeSelf) { }

	public static T[] GetComponentsInChildrenBFS(Component c, bool includeInactive, bool includeSelf, int searchDepth) { }

	public static T[] GetComponentsInChildrenBFS(GameObject go, bool includeInactive, bool includeSelf) { }

	public static T[] GetComponentsInChildrenBFS(GameObject go, bool includeInactive, bool includeSelf, int searchDepth) { }

	public static void GetComponentsInChildrenBFS(GameObject go, bool includeInactive, List<T> result) { }

	public static void GetComponentsInChildrenBFS(GameObject go, bool includeInactive, List<T> result, bool includeSelf) { }

	public static Component[] GetComponentsInChildrenBFS(Component c, Type type) { }

	public static T[] GetComponentsInChildrenBFS(Component c) { }

	public static Component[] GetComponentsInChildrenBFS(Component c, Type type, bool includeInactive) { }

	public static Component[] GetComponentsInChildrenBFS(Component c, Type type, bool includeInactive, bool includeSelf) { }

	public static Component[] GetComponentsInChildrenBFS(Component c, Type type, bool includeInactive, bool includeSelf, int searchDepth) { }

	public static Component[] GetComponentsInChildrenBFS(GameObject go, Type type) { }

	public static Component[] GetComponentsInChildrenBFS(GameObject go, Type type, bool includeInactive) { }

	public static Component[] GetComponentsInChildrenBFS(GameObject go, Type type, bool includeInactive, bool includeSelf) { }

	public static void GetComponentsInChildrenBFS(GameObject go, bool includeInactive, List<T> result, bool includeSelf, int searchDepth) { }

	public static T[] GetComponentsInChildrenBFS(GameObject go, bool includeInactive) { }

	public static void GetComponentsInChildrenBFS(GameObject go, Type type, bool includeInactive, List<Component> result, bool includeSelf, int searchDepth) { }

	public static void GetComponentsInChildrenBFS(Component c, bool includeInactive, List<T> result, bool includeSelf, int searchDepth) { }

	public static Component[] GetComponentsInChildrenBFS(GameObject go, Type type, bool includeInactive, bool includeSelf, int searchDepth) { }

	public static void GetComponentsInChildrenBFS(Component c, bool includeInactive, List<T> result) { }

	public static T[] GetComponentsInChildrenBFS(GameObject go) { }

	public static string GetLongName(GameObject obj) { }

	public static string GetLongName(Component comp) { }

	public static GameObject Instantiate(Transform transform) { }

	public static GameObject Instantiate(GameObject go) { }

	public static Transform InstantiateTransform(Transform transform) { }

	public static Transform InstantiateTransform(GameObject go) { }

	public static bool IsDestroyed(GameObject gameObject) { }

	public static bool IsPrefab(GameObject go) { }

	public static void ResetLocal(Transform transform) { }

	public static void ResetLocalPosition(Transform transform) { }

	public static void ResetLocalRotation(Transform transform) { }

	public static void ResetLocalScale(Transform transform) { }

	public static void SortTransformChildren(Transform parentTransform, Comparison<Transform> cmp) { }

	public static void UnparentAndDestroy(GameObject go) { }

	public static void UnparentAndDestroy(Transform transform) { }

}

