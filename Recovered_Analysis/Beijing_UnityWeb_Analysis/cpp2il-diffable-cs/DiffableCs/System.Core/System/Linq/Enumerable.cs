namespace System.Linq;

public static class Enumerable
{
	private sealed class <>c__DisplayClass6_0`1
	{
		public Func<TSource, bool> predicate1; //Field offset: 0x0
		public Func<TSource, bool> predicate2; //Field offset: 0x0

		public <>c__DisplayClass6_0`1() { }

		internal bool <CombinePredicates>b__0(TSource x) { }

	}

	private sealed class <>c__DisplayClass7_0`3
	{
		public Func<TMiddle, TResult> selector2; //Field offset: 0x0
		public Func<TSource, TMiddle> selector1; //Field offset: 0x0

		public <>c__DisplayClass7_0`3() { }

		internal TResult <CombineSelectors>b__0(TSource x) { }

	}

	private sealed class <CastIterator>d__99`1 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			 get { } //Length: 566
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CastIterator>d__99`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DistinctIterator>d__68`1 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEqualityComparer<TSource> comparer; //Field offset: 0x0
		public IEqualityComparer<TSource> <>3__comparer; //Field offset: 0x0
		private IEnumerable<TSource> source; //Field offset: 0x0
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		private Set<TSource> <set>5__1; //Field offset: 0x0
		private IEnumerator<TSource> <>7__wrap1; //Field offset: 0x0

		private TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			 get { } //Length: 33
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DistinctIterator>d__68`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <OfTypeIterator>d__97`1 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			 get { } //Length: 33
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <OfTypeIterator>d__97`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <ReverseIterator>d__79`1 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<TSource> source; //Field offset: 0x0
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		private Buffer<TSource> <buffer>5__1; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			 get { } //Length: 33
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ReverseIterator>d__79`1(int <>1__state) { }

		private bool MoveNext() { }

		private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <TakeIterator>d__25`1 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private int count; //Field offset: 0x0
		public int <>3__count; //Field offset: 0x0
		private IEnumerable<TSource> source; //Field offset: 0x0
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		private IEnumerator<TSource> <>7__wrap1; //Field offset: 0x0

		private TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			 get { } //Length: 322
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TakeIterator>d__25`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private abstract class Iterator`1 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int threadId; //Field offset: 0x0
		internal int state; //Field offset: 0x0
		internal TSource current; //Field offset: 0x0

		public TSource Current
		{
			 get { } //Length: 33
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 60
		}

		public Iterator`1() { }

		public abstract Iterator<TSource> Clone() { }

		public virtual void Dispose() { }

		public TSource get_Current() { }

		public IEnumerator<TSource> GetEnumerator() { }

		public abstract bool MoveNext() { }

		public abstract IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }

	}

	private class WhereArrayIterator`1
	{
		private TSource[] source; //Field offset: 0x0
		private Func<TSource, bool> predicate; //Field offset: 0x0
		private int index; //Field offset: 0x0

		public WhereArrayIterator`1(TSource[] source, Func<TSource, bool> predicate) { }

		public override Iterator<TSource> Clone() { }

		public override bool MoveNext() { }

		public override IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }

	}

	private class WhereEnumerableIterator`1
	{
		private IEnumerable<TSource> source; //Field offset: 0x0
		private Func<TSource, bool> predicate; //Field offset: 0x0
		private IEnumerator<TSource> enumerator; //Field offset: 0x0

		public WhereEnumerableIterator`1(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }

		public override Iterator<TSource> Clone() { }

		public override void Dispose() { }

		public override bool MoveNext() { }

		public override IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }

	}

	private class WhereListIterator`1
	{
		private List<TSource> source; //Field offset: 0x0
		private Func<TSource, bool> predicate; //Field offset: 0x0
		private Enumerator<TSource> enumerator; //Field offset: 0x0

		public WhereListIterator`1(List<TSource> source, Func<TSource, bool> predicate) { }

		public override Iterator<TSource> Clone() { }

		public override bool MoveNext() { }

		public override IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }

	}

	private class WhereSelectArrayIterator`2
	{
		private TSource[] source; //Field offset: 0x0
		private Func<TSource, bool> predicate; //Field offset: 0x0
		private Func<TSource, TResult> selector; //Field offset: 0x0
		private int index; //Field offset: 0x0

		public WhereSelectArrayIterator`2(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }

		public override Iterator<TResult> Clone() { }

		public override bool MoveNext() { }

		public override IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }

	}

	private class WhereSelectEnumerableIterator`2
	{
		private IEnumerable<TSource> source; //Field offset: 0x0
		private Func<TSource, bool> predicate; //Field offset: 0x0
		private Func<TSource, TResult> selector; //Field offset: 0x0
		private IEnumerator<TSource> enumerator; //Field offset: 0x0

		public WhereSelectEnumerableIterator`2(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }

		public override Iterator<TResult> Clone() { }

		public override void Dispose() { }

		public override bool MoveNext() { }

		public override IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }

	}

	private class WhereSelectListIterator`2
	{
		private List<TSource> source; //Field offset: 0x0
		private Func<TSource, bool> predicate; //Field offset: 0x0
		private Func<TSource, TResult> selector; //Field offset: 0x0
		private Enumerator<TSource> enumerator; //Field offset: 0x0

		public WhereSelectListIterator`2(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }

		public override Iterator<TResult> Clone() { }

		public override bool MoveNext() { }

		public override IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }

	}


	public static TAccumulate Aggregate(IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func) { }

	public static bool All(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }

	public static bool Any(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }

	public static bool Any(IEnumerable<TSource> source) { }

	public static IEnumerable<TResult> Cast(IEnumerable source) { }

	private static IEnumerable<TResult> CastIterator(IEnumerable source) { }

	private static Func<TSource, bool> CombinePredicates(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2) { }

	private static Func<TSource, TResult> CombineSelectors(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }

	public static bool Contains(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }

	public static bool Contains(IEnumerable<TSource> source, TSource value) { }

	public static int Count(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }

	public static int Count(IEnumerable<TSource> source) { }

	public static IEnumerable<TSource> Distinct(IEnumerable<TSource> source) { }

	private static IEnumerable<TSource> DistinctIterator(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }

	public static TSource ElementAt(IEnumerable<TSource> source, int index) { }

	public static TSource First(IEnumerable<TSource> source) { }

	public static TSource FirstOrDefault(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }

	public static TSource Last(IEnumerable<TSource> source) { }

	public static int Min(IEnumerable<int> source) { }

	public static IEnumerable<TResult> OfType(IEnumerable source) { }

	private static IEnumerable<TResult> OfTypeIterator(IEnumerable source) { }

	public static IOrderedEnumerable<TSource> OrderBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	public static IOrderedEnumerable<TSource> OrderByDescending(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	public static IEnumerable<TSource> Reverse(IEnumerable<TSource> source) { }

	private static IEnumerable<TSource> ReverseIterator(IEnumerable<TSource> source) { }

	public static IEnumerable<TResult> Select(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }

	public static bool SequenceEqual(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }

	public static bool SequenceEqual(IEnumerable<TSource> first, IEnumerable<TSource> second) { }

	public static TSource SingleOrDefault(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }

	public static float Sum(IEnumerable<float> source) { }

	public static int Sum(IEnumerable<int> source) { }

	public static int Sum(IEnumerable<TSource> source, Func<TSource, int> selector) { }

	public static IEnumerable<TSource> Take(IEnumerable<TSource> source, int count) { }

	private static IEnumerable<TSource> TakeIterator(IEnumerable<TSource> source, int count) { }

	public static TSource[] ToArray(IEnumerable<TSource> source) { }

	public static Dictionary<TKey, TElement> ToDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

	public static Dictionary<TKey, TElement> ToDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }

	public static List<TSource> ToList(IEnumerable<TSource> source) { }

	public static IEnumerable<TSource> Where(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }

}

