namespace System.Collections;

public interface ICollection : IEnumerable
{

	public int Count
	{
		 get { } //Length: 0
	}

	public void CopyTo(Array array, int index) { }

	public int get_Count() { }

}

