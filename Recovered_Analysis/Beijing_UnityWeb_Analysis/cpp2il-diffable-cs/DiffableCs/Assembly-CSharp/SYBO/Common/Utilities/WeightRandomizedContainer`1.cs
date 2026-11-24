namespace SYBO.Common.Utilities;

public class WeightRandomizedContainer`1
{
	private class WeightedEntry
	{
		public int AccumulatedWeight; //Field offset: 0x0
		public T WeightedObject; //Field offset: 0x0

		public WeightedEntry(T weightedObject, int accumulatedWeight) { }

	}

	private List<WeightedEntry<T>> _entries; //Field offset: 0x0
	private int _accumulatedWeight; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 37
	}

	public bool IsEmpty
	{
		 get { } //Length: 6
	}

	public WeightRandomizedContainer`1() { }

	public void Add(T prefab, int weight) { }

	public void Clear() { }

	public int get_Count() { }

	public bool get_IsEmpty() { }

	public T GetRandom(SyboRandom random) { }

}

