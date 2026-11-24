namespace Kiloo.Common.Extensions;

public static class CollectionExtensions
{
	private sealed class <>c__6`1
	{
		public static readonly <>c__6<T> <>9; //Field offset: 0x0
		public static Func<T, T> <>9__6_0; //Field offset: 0x0

		private static <>c__6`1() { }

		public <>c__6`1() { }

		internal T <Clone>b__6_0(T item) { }

	}


	private static bool AddDistinct(IList<T> list, T value, IEqualityComparer<T> comparer) { }

	public static bool AddDistinct(IList<T> list, T value) { }

	public static void AddOrSet(Dictionary<TKey, TValue> dict, TKey key, TValue value) { }

	public static bool AddRangeDistinct(IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer) { }

	public static bool AddRangeDistinct(IList<T> list, IEnumerable<T> values) { }

	public static void AddSorted(List<T> list, T item) { }

	public static IList<T> Clone(IList<T> listToClone) { }

	private static bool ContainsValue(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }

	public static T GetRandomElement(IList<T> list) { }

	public static T GetRandomElement(IEnumerable<T> sequence) { }

	public static void Shuffle(IList<T> list, int seed) { }

	public static void Shuffle(IList<T> list) { }

	public static void SwitchPlaces(IList<T> arr, int i, int j) { }

	public static Dictionary<T, U> ToDictionary(List<KeyValuePair<T, U>> keyvalueList) { }

	public static List<KeyValuePair<T, U>> ToKeyValueList(Dictionary<T, U> dictionary) { }

	public static bool TryGetValueNotNull(IDictionary<T, U> dict, T key, out U obj) { }

	public static bool TryGetValueNotNullOrEmpty(IDictionary<T, string> dict, T key, out string obj) { }

	public static bool ValidIndex(IList<T> l, int index) { }

}

