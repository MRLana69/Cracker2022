namespace System;

public static class Buffer
{

	private static int _ByteLength(Array array) { }

	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	public static int ByteLength(Array array) { }

	internal static int IndexOfByte(byte* src, byte value, int index, int count) { }

	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	internal static void Memcpy(byte[] dest, int destIndex, byte* src, int srcIndex, int len) { }

	internal static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) { }

	internal static void Memcpy(byte* dest, byte* src, int size) { }

	private static void memcpy1(byte* dest, byte* src, int size) { }

	internal static void memcpy2(byte* dest, byte* src, int size) { }

	internal static void memcpy4(byte* dest, byte* src, int size) { }

	internal static void ZeroMemory(byte* src, long len) { }

}

