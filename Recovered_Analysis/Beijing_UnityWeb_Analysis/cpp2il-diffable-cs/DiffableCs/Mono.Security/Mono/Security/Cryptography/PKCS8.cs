namespace Mono.Security.Cryptography;

public sealed class PKCS8
{
	public class EncryptedPrivateKeyInfo
	{
		private string _algorithm; //Field offset: 0x8
		private byte[] _salt; //Field offset: 0xC
		private int _iterations; //Field offset: 0x10
		private byte[] _data; //Field offset: 0x14

		public string Algorithm
		{
			 get { } //Length: 173
		}

		public byte[] EncryptedData
		{
			 get { } //Length: 6
		}

		public int IterationCount
		{
			 get { } //Length: 108
		}

		public byte[] Salt
		{
			 get { } //Length: 67
		}

		public EncryptedPrivateKeyInfo() { }

		public EncryptedPrivateKeyInfo(byte[] data) { }

		private void Decode(byte[] data) { }

		public string get_Algorithm() { }

		public byte[] get_EncryptedData() { }

		public int get_IterationCount() { }

		public byte[] get_Salt() { }

	}

	public class PrivateKeyInfo
	{
		private int _version; //Field offset: 0x8
		private string _algorithm; //Field offset: 0xC
		private byte[] _key; //Field offset: 0x10
		private ArrayList _list; //Field offset: 0x14

		public byte[] PrivateKey
		{
			 get { } //Length: 900
		}

		public PrivateKeyInfo() { }

		public PrivateKeyInfo(byte[] data) { }

		private void Decode(byte[] data) { }

		public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

		public static RSA DecodeRSA(byte[] keypair) { }

		public static byte[] Encode(RSA rsa) { }

		public static byte[] Encode(DSA dsa) { }

		public static byte[] Encode(AsymmetricAlgorithm aa) { }

		public byte[] get_PrivateKey() { }

		private static byte[] Normalize(byte[] bigInt, int length) { }

		private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	}


}

