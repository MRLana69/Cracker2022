namespace UnityEngine;

public sealed class GameObject : Object
{

	public bool activeInHierarchy
	{
		 get { } //Length: 49
	}

	public bool activeSelf
	{
		 get { } //Length: 49
	}

	public GameObject gameObject
	{
		 get { } //Length: 49
	}

	public int layer
	{
		 get { } //Length: 49
		 set { } //Length: 81
	}

	public string tag
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public Transform transform
	{
		 get { } //Length: 9
	}

	public GameObject(string name) { }

	public GameObject() { }

	public GameObject(string name, Type[] components) { }

	public T AddComponent() { }

	public Component AddComponent(Type componentType) { }

	public void BroadcastMessage(string methodName) { }

	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	public bool CompareTag(string tag) { }

	public static GameObject Find(string name) { }

	public bool get_activeInHierarchy() { }

	public bool get_activeSelf() { }

	public GameObject get_gameObject() { }

	public int get_layer() { }

	public string get_tag() { }

	public Transform get_transform() { }

	public T GetComponent() { }

	public Component GetComponent(Type type) { }

	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	public T GetComponentInChildren() { }

	public T GetComponentInChildren(bool includeInactive) { }

	public Component GetComponentInParent(Type type) { }

	public T GetComponentInParent() { }

	public T[] GetComponents() { }

	public void GetComponents(List<T> results) { }

	public void GetComponentsInChildren(List<T> results) { }

	public T[] GetComponentsInChildren() { }

	public void GetComponentsInChildren(bool includeInactive, List<T> results) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	private Component Internal_AddComponentWithType(Type componentType) { }

	private static void Internal_CreateGameObject(GameObject self, string name) { }

	public void SendMessage(string methodName, SendMessageOptions options) { }

	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	public void set_layer(int value) { }

	public void set_tag(string value) { }

	public void SetActive(bool value) { }

}

