namespace System;

public static class BitConverter
{
	public static readonly bool IsLittleEndian; //Field offset: 0x0

	private static BitConverter() { }

	private static bool AmILittleEndian() { }

	public static long DoubleToInt64Bits(double value) { }

	public static byte[] GetBytes(short value) { }

	public static byte[] GetBytes(int value) { }

	public static byte[] GetBytes(long value) { }

	public static byte[] GetBytes(ushort value) { }

	public static byte[] GetBytes(uint value) { }

	public static byte[] GetBytes(ulong value) { }

	public static byte[] GetBytes(float value) { }

	public static byte[] GetBytes(double value) { }

	public static byte[] GetBytes(char value) { }

	private static char GetHexValue(int i) { }

	public static double Int64BitsToDouble(long value) { }

	public static char ToChar(byte[] value, int startIndex) { }

	public static double ToDouble(byte[] value, int startIndex) { }

	public static short ToInt16(byte[] value, int startIndex) { }

	public static int ToInt32(byte[] value, int startIndex) { }

	public static long ToInt64(byte[] value, int startIndex) { }

	public static float ToSingle(byte[] value, int startIndex) { }

	public static string ToString(byte[] value, int startIndex, int length) { }

	public static string ToString(byte[] value) { }

	public static ushort ToUInt16(byte[] value, int startIndex) { }

	public static uint ToUInt32(byte[] value, int startIndex) { }

	public static ulong ToUInt64(byte[] value, int startIndex) { }

}

