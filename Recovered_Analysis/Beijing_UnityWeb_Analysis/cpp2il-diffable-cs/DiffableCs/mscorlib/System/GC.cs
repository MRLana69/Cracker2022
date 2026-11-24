namespace System;

public static class GC
{
	internal static readonly object EPHEMERON_TOMBSTONE; //Field offset: 0x0

	private static void _ReRegisterForFinalize(object o) { }

	private static void _SuppressFinalize(object o) { }

	private static GC() { }

	public static int CollectionCount(int generation) { }

	private static object get_ephemeron_tombstone() { }

	private static int GetCollectionCount(int generation) { }

	public static void KeepAlive(object obj) { }

	internal static void register_ephemeron_array(Ephemeron[] array) { }

	public static void ReRegisterForFinalize(object obj) { }

	public static void SuppressFinalize(object obj) { }

}

