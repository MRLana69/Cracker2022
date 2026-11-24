namespace SYBO.Common.Components;

public class InstantiatePrefabComponent : MonoBehaviour
{
	private GameObject _parent; //Field offset: 0xC
	private GameObject _prefab; //Field offset: 0x10
	private Vector3 _prefabLocalPosition; //Field offset: 0x14
	private bool _willInstantiateOnAwake; //Field offset: 0x20
	private GameObject _prefabInstance; //Field offset: 0x24

	public InstantiatePrefabComponent() { }

	protected void Awake() { }

	public virtual GameObject InstantiatePrefab() { }

}

