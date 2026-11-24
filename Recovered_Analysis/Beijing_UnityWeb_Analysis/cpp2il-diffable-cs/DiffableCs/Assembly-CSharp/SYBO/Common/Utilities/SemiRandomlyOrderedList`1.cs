namespace SYBO.Common.Utilities;

public class SemiRandomlyOrderedList`1
{
	private List<T> _readyEntries; //Field offset: 0x0
	private List<T> _usedEntries; //Field offset: 0x0
	private List<T> _allEntries; //Field offset: 0x0
	private HashSet<T> _evaluatedEntries; //Field offset: 0x0

	public List<T> AllEntries
	{
		 get { } //Length: 6
	}

	public bool IsEmpty
	{
		 get { } //Length: 280
	}

	public List<T> ReadyEntries
	{
		 get { } //Length: 81
	}

	public int TotalEntries
	{
		 get { } //Length: 83
	}

	public List<T> UsedEntries
	{
		 get { } //Length: 6
	}

	public SemiRandomlyOrderedList`1() { }

	public void Add(T entry) { }

	public void Build(IEnumerable<T> sourceList, SyboRandom random) { }

	public void Clear() { }

	public void Consume(T entry, SyboRandom random) { }

	public List<T> get_AllEntries() { }

	public bool get_IsEmpty() { }

	public List<T> get_ReadyEntries() { }

	public int get_TotalEntries() { }

	public List<T> get_UsedEntries() { }

	public T GetNext(SyboRandom random) { }

	public T GetNextMatching(SyboRandom random, Func<T, bool> matchSelector) { }

	private void Regenerate(SyboRandom random) { }

	private void RegenerateIfNeeded(SyboRandom random) { }

	public void Reset(SyboRandom random) { }

	public static void TestUniformity() { }

}

