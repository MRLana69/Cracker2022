namespace UnityEngine.EventSystems;

public struct RaycastResult
{
	private GameObject m_GameObject; //Field offset: 0x0
	public BaseRaycaster module; //Field offset: 0x4
	public float distance; //Field offset: 0x8
	public float index; //Field offset: 0xC
	public int depth; //Field offset: 0x10
	public int sortingLayer; //Field offset: 0x14
	public int sortingOrder; //Field offset: 0x18
	public Vector3 worldPosition; //Field offset: 0x1C
	public Vector3 worldNormal; //Field offset: 0x28
	public Vector2 screenPosition; //Field offset: 0x34

	public GameObject gameObject
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool isValid
	{
		 get { } //Length: 9
	}

	public void Clear() { }

	public GameObject get_gameObject() { }

	public bool get_isValid() { }

	public void set_gameObject(GameObject value) { }

	public override string ToString() { }

}

