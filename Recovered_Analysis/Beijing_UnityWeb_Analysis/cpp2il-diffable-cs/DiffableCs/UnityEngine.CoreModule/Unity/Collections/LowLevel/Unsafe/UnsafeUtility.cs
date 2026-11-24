namespace Unity.Collections.LowLevel.Unsafe;

public static class UnsafeUtility
{

	public static void Free(void* memory, Allocator allocator) { }

	public static T ReadArrayElement(void* source, int index) { }

	public static void WriteArrayElement(void* destination, int index, T value) { }

}

