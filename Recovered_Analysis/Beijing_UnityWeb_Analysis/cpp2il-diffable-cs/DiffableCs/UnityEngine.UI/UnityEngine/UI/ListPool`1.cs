namespace UnityEngine.UI;

internal static class ListPool`1
{
	private static readonly ObjectPool<List<T>> s_ListPool; //Field offset: 0x0

	private static ListPool`1() { }

	private static void Clear(List<T> l) { }

	public static List<T> Get() { }

	public static void Release(List<T> toRelease) { }

}

