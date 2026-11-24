namespace SYBO.Common.Utilities;

public struct GameObjectPositionWrapper
{
	public GameObject GameObject; //Field offset: 0x0
	public Vector3 Position; //Field offset: 0x4
	public bool ParentIsSelector; //Field offset: 0x10

	public GameObjectPositionWrapper(GameObject gameObject, bool parentIsSelector = false) { }

	public GameObjectPositionWrapper(Component component, bool parentIsSelector = false) { }

}

