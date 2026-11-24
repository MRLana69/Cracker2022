namespace SYBO.Components.Utilities;

public class SpawnPoolsDict : IDictionary<string, SpawnPool>, ICollection<KeyValuePair<string, SpawnPool>>, IEnumerable<KeyValuePair<string, SpawnPool>>, IEnumerable
{
	private Dictionary<string, SpawnPool> _pools; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 141
	}

	private bool IsReadOnly
	{
		 get { } //Length: 81
	}

	public SpawnPool Item
	{
		 get { } //Length: 81
		 set { } //Length: 79
	}

	public ICollection<string> Keys
	{
		 get { } //Length: 60
	}

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,SYBO.Components.Utilities.SpawnPool>>.IsReadOnly
	{
		 get { } //Length: 3
	}

	public ICollection<SpawnPool> Values
	{
		 get { } //Length: 81
	}

	public SpawnPoolsDict() { }

	public void Add(KeyValuePair<string, SpawnPool> item) { }

	public void Add(string key, SpawnPool value) { }

	internal void Add(SpawnPool spawnPool) { }

	private bool assertValidPoolName(string poolName) { }

	public void Clear() { }

	public bool Contains(KeyValuePair<string, SpawnPool> item) { }

	public bool ContainsKey(string poolName) { }

	private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex) { }

	public SpawnPool Create(string poolName) { }

	public SpawnPool Create(string poolName, GameObject owner) { }

	public bool Destroy(string poolName) { }

	public void DestroyAll() { }

	public int get_Count() { }

	private bool get_IsReadOnly() { }

	public SpawnPool get_Item(string key) { }

	public ICollection<string> get_Keys() { }

	public ICollection<SpawnPool> get_Values() { }

	public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator() { }

	public bool Remove(string poolName) { }

	internal bool Remove(SpawnPool spawnPool) { }

	public bool Remove(KeyValuePair<string, SpawnPool> item) { }

	public void set_Item(string key, SpawnPool value) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,SYBO.Components.Utilities.SpawnPool>>.CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex) { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,SYBO.Components.Utilities.SpawnPool>>.get_IsReadOnly() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override string ToString() { }

	public bool TryGetValue(string poolName, out SpawnPool spawnPool) { }

}

