namespace System.Collections.Generic;

public interface IReadOnlyList`1 : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
{

	public T Item
	{
		 get { } //Length: 0
	}

	public T get_Item(int index) { }

}

