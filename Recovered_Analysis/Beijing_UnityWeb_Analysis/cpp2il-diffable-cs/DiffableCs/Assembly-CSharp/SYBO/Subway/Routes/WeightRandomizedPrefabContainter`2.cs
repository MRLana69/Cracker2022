namespace SYBO.Subway.Routes;

public class WeightRandomizedPrefabContainter`2 : IEnumerable<TWeighted>, IEnumerable
{
	private sealed class <>c
	{
		public static readonly <>c<TWeighted, T> <>9; //Field offset: 0x0
		public static Func<T, bool> <>9__29_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__29_0(T p) { }

	}

	private sealed class <>c__DisplayClass18_0
	{
		public T item; //Field offset: 0x0

		public <>c__DisplayClass18_0() { }

		internal bool <Contains>b__0(TWeighted t) { }

	}

	private sealed class <PrefabIterator>d__15 : IEnumerator<TWeighted>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private TWeighted <>2__current; //Field offset: 0x0
		public WeightRandomizedPrefabContainter<TWeighted, T> <>4__this; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private TWeighted System.Collections.Generic.IEnumerator<TWeighted>.Current
		{
			 get { } //Length: 164
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PrefabIterator>d__15(int <>1__state) { }

		private bool MoveNext() { }

		private TWeighted System.Collections.Generic.IEnumerator<TWeighted>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private List<TWeighted> _weightedPrefabs; //Field offset: 0x0
	private WeightRandomizedContainer<T> _weightedRandomizedPrefabs; //Field offset: 0x0
	private SemiRandomlyOrderedList<T> _randomlyOrderedPrefabs; //Field offset: 0x0
	private Func<T, bool> _pickEvaluator; //Field offset: 0x0
	private string <Name>k__BackingField; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 6
	}

	public bool IsEmpty
	{
		 get { } //Length: 444
	}

	public TWeighted Item
	{
		 get { } //Length: 136
		 set { } //Length: 41
	}

	public string Name
	{
		 get { } //Length: 113
		 set { } //Length: 70
	}

	public WeightRandomizedPrefabContainter`2() { }

	public void Add(TWeighted item) { }

	private void BuildRandomlyOrderedPrefabList(SyboRandom random) { }

	public void Clear() { }

	public bool Contains(TWeighted item) { }

	public bool Contains(T item) { }

	public int get_Count() { }

	public bool get_IsEmpty() { }

	public TWeighted get_Item(int index) { }

	public string get_Name() { }

	public IEnumerator<TWeighted> GetEnumerator() { }

	public int GetTotalWeight() { }

	public T PickRandomPrefab(SyboRandom random) { }

	public T PickSemiRandomlyOrderedPrefab(SyboRandom random) { }

	private IEnumerator<TWeighted> PrefabIterator() { }

	public void RemoveEmptyEntries() { }

	public void set_Item(int index, TWeighted value) { }

	public void set_Name(string value) { }

	public void SetPickEvaluator(Func<T, bool> evaluator) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override string ToString() { }

}

