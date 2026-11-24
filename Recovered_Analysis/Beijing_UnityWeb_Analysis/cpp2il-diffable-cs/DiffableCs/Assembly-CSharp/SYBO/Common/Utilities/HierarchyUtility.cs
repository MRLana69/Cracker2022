namespace SYBO.Common.Utilities;

public class HierarchyUtility : MonoBehaviour
{

	private static T _GetComponentOrAddComponent(GameObject go) { }

	private static GameObject _GetGameObjectByHierarchyPathString(string hierarchyPathString) { }

	private static bool _HasGameObjectByHierarchyPathString(string hierarchyPathString) { }

	public HierarchyUtility() { }

	public static Bounds GetBounds(GameObject gameObject) { }

	public static GameObject GetGameObjectByHierarchyPathType(HierarchyPathType hierarchyPathType) { }

	public static bool HasBounds(GameObject gameObject) { }

	public static void InstantiatePrefabList(List<GameObject> prefabGOs, Transform parentTransform, Vector3 paddingBetweenVector3) { }

	public static void Reparent(Transform childTransform, Transform parentTransform, bool worldPositionStays = false) { }

	public static void Reparent(Transform childTransform, Transform parentTransform, Vector3 newLocalPosition) { }

	public static void ReparentByHierarchyPathType(Transform childTransform, HierarchyPathType hierarchyPathType, bool worldPositionStays = false) { }

	public static void ReparentByHierarchyPathType(Transform childTransform, HierarchyPathType hierarchyPathType, Vector3 newWorldPosition) { }

	public static void SetAsLastSibling(Transform transform) { }

}

