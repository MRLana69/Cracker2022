namespace SYBO.Components.Utilities;

public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
{
	private Dictionary<string, Transform> _prefabs; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 141
	}

	private bool IsReadOnly
	{
		 get { } //Length: 52
	}

	public Transform Item
	{
		 get { } //Length: 81
		 set { } //Length: 79
	}

	public ICollection<string> Keys
	{
		 get { } //Length: 60
	}

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.IsReadOnly
	{
		 get { } //Length: 3
	}

	public ICollection<Transform> Values
	{
		 get { } //Length: 52
	}

	internal void _Add(string prefabName, Transform prefab) { }

	internal void _Clear() { }

	internal bool _Remove(string prefabName) { }

	public PrefabsDict() { }

	public void Add(KeyValuePair<string, Transform> item) { }

	public void Add(string key, Transform value) { }

	public void Clear() { }

	public bool Contains(KeyValuePair<string, Transform> item) { }

	public bool ContainsKey(string prefabName) { }

	private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex) { }

	public int get_Count() { }

	private bool get_IsReadOnly() { }

	public Transform get_Item(string key) { }

	public ICollection<string> get_Keys() { }

	public ICollection<Transform> get_Values() { }

	public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator() { }

	public bool Remove(KeyValuePair<string, Transform> item) { }

	public bool Remove(string prefabName) { }

	public void set_Item(string key, Transform value) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex) { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.get_IsReadOnly() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override string ToString() { }

	public bool TryGetValue(string prefabName, out Transform prefab) { }

}

