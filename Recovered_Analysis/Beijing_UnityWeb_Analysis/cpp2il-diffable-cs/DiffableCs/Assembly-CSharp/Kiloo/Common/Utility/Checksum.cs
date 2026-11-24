namespace Kiloo.Common.Utility;

public static class Checksum
{

	public static int ComputeCrc32(byte[] data) { }

	public static int ComputeCrc32(byte[] data, int offset, int length) { }

	public static int ComputeCrc32(Stream stream) { }

	public static byte[] ComputeMD5(byte[] data) { }

	public static byte[] ComputeMD5(string data, Encoding encoding = null) { }

	public static byte[] ComputeSHA1(byte[] data) { }

	public static byte[] ComputeSHA1(string data, Encoding encoding = null) { }

	public static byte[] ComputeSHA256(byte[] data) { }

	public static byte[] ComputeSHA256(string data, Encoding encoding = null) { }

}

