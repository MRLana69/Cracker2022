namespace System.Text.RegularExpressions;

public class GroupCollection : ICollection, IEnumerable
{
	internal Match _match; //Field offset: 0x8
	internal Hashtable _captureMap; //Field offset: 0xC
	internal Group[] _groups; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 9
	}

	public Group Item
	{
		 get { } //Length: 33
	}

	internal GroupCollection(Match match, Hashtable caps) { }

	internal GroupCollection() { }

	public void CopyTo(Array array, int arrayIndex) { }

	public int get_Count() { }

	public Group get_Item(int groupnum) { }

	public IEnumerator GetEnumerator() { }

	internal Group GetGroup(int groupnum) { }

	internal Group GetGroupImpl(int groupnum) { }

}

