namespace SYBO.Common.Utilities;

public class WeightRandomizedOrderedContainter`2 : IEnumerable<TWeighted>, IEnumerable
{
	private sealed class <>c
	{
		public static readonly <>c<TWeighted, T> <>9; //Field offset: 0x0
		public static Func<T, bool> <>9__26_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__26_0(T p) { }

	}

	private sealed class <Enumerator>d__14 : IEnumerator<TWeighted>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private TWeighted <>2__current; //Field offset: 0x0
		public WeightRandomizedOrderedContainter<TWeighted, T> <>4__this; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private TWeighted System.Collections.Generic.IEnumerator<TWeighted>.Current
		{
			 get { } //Length: 163
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Enumerator>d__14(int <>1__state) { }

		private bool MoveNext() { }

		private TWeighted System.Collections.Generic.IEnumerator<TWeighted>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private List<TWeighted> _weightedObjects; //Field offset: 0x0
	private WeightRandomizedContainer<T> _weightedRandomizedObjects; //Field offset: 0x0
	private SemiRandomlyOrderedList<T> _randomlyOrderedObjects; //Field offset: 0x0
	private Func<T, bool> _pickEvaluator; //Field offset: 0x0
	private string <Name>k__BackingField; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 6
	}

	public bool IsEmpty
	{
		 get { } //Length: 6
	}

	public TWeighted Item
	{
		 get { } //Length: 215
		 set { } //Length: 25
	}

	public string Name
	{
		 get { } //Length: 113
		 set { } //Length: 164
	}

	public WeightRandomizedOrderedContainter`2() { }

	public void Add(TWeighted item) { }

	private void BuildRandomlyOrderedList(SyboRandom random) { }

	public void Clear() { }

	private IEnumerator<TWeighted> Enumerator() { }

	public TWeighted Find(Predicate<TWeighted> predicate) { }

	public int get_Count() { }

	public bool get_IsEmpty() { }

	public TWeighted get_Item(int index) { }

	public string get_Name() { }

	public IEnumerator<TWeighted> GetEnumerator() { }

	public T PickRandomPrefab(SyboRandom random) { }

	public T PickSemiRandomlyOrdered(SyboRandom random) { }

	public void set_Item(int index, TWeighted value) { }

	public void set_Name(string value) { }

	public void SetPickEvaluator(Func<T, bool> evaluator) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override string ToString() { }

}

