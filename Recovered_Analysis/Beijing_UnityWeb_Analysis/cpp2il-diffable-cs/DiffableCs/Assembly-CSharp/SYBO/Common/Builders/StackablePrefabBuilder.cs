namespace SYBO.Common.Builders;

public class StackablePrefabBuilder
{
	private static string _STACKABLE_PREFAB_BUILDER_NAME; //Field offset: 0x0
	private StackablePrefabData _stackablePrefabData; //Field offset: 0x8

	public StackablePrefabData StackablePrefabData
	{
		 get { } //Length: 9
	}

	private static StackablePrefabBuilder() { }

	public StackablePrefabBuilder(StackablePrefabData stackablePrefabData) { }

	public GameObject BuildAndAttach(GameObject parentGameObject, Vector3 startWorldPosition, Vector3 endWorldPosition) { }

	private void BuildYDirection(GameObject stackablePrefabBuilder, Vector3 startWorldPosition, Vector3 endWorldPosition, GameObject startPrefab, GameObject midPrefab, GameObject endPrefab) { }

	private void BuildZDirection(GameObject stackablePrefabBuilder, Vector3 startWorldPosition, Vector3 endWorldPosition, GameObject startPrefab, GameObject midPrefab, GameObject endPrefab) { }

	public StackablePrefabData get_StackablePrefabData() { }

}

