namespace UnityEngine;

public class Component : Object
{

	public GameObject gameObject
	{
		 get { } //Length: 49
	}

	public string tag
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public Transform transform
	{
		 get { } //Length: 49
	}

	public Component() { }

	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	public void BroadcastMessage(string methodName) { }

	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	public bool CompareTag(string tag) { }

	public GameObject get_gameObject() { }

	public string get_tag() { }

	public Transform get_transform() { }

	public T GetComponent() { }

	public Component GetComponent(Type type) { }

	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	public T GetComponentInChildren() { }

	public Component GetComponentInParent(Type t) { }

	public T GetComponentInParent() { }

	public T[] GetComponents() { }

	public void GetComponents(List<T> results) { }

	public void GetComponents(Type type, List<Component> results) { }

	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	public void GetComponentsInChildren(List<T> results) { }

	public T[] GetComponentsInChildren() { }

	public void GetComponentsInChildren(bool includeInactive, List<T> result) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public T[] GetComponentsInParent() { }

	public void SendMessage(string methodName, object value) { }

	public void SendMessage(string methodName) { }

	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	public void SendMessage(string methodName, SendMessageOptions options) { }

	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	public void set_tag(string value) { }

}

