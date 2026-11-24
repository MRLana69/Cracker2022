namespace NaughtyAttributes;

public class DropdownList`1 : IDropdownList, IEnumerable<KeyValuePair<string, object>>, IEnumerable
{
	private List<KeyValuePair<string, object>> values; //Field offset: 0x0

	public DropdownList`1() { }

	public void Add(string displayName, T value) { }

	public IEnumerator<KeyValuePair<string, object>> GetEnumerator() { }

	public static DropdownList<object> op_Explicit(DropdownList<T> target) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

