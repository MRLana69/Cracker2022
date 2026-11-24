namespace Mono.Security;

public sealed class PKCS7
{
	public class ContentInfo
	{
		private string contentType; //Field offset: 0x8
		private ASN1 content; //Field offset: 0xC

		public ASN1 ASN1
		{
			 get { } //Length: 31
		}

		public ASN1 Content
		{
			 get { } //Length: 9
			 set { } //Length: 305
		}

		public string ContentType
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public ContentInfo() { }

		public ContentInfo(string oid) { }

		public ContentInfo(byte[] data) { }

		public ContentInfo(ASN1 asn1) { }

		public ASN1 get_ASN1() { }

		public ASN1 get_Content() { }

		public string get_ContentType() { }

		internal ASN1 GetASN1() { }

		public void set_Content(ASN1 value) { }

		public void set_ContentType(string value) { }

	}

	public class EncryptedData
	{
		private byte _version; //Field offset: 0x8
		private ContentInfo _content; //Field offset: 0xC
		private ContentInfo _encryptionAlgorithm; //Field offset: 0x10
		private byte[] _encrypted; //Field offset: 0x14

		public byte[] EncryptedContent
		{
			 get { } //Length: 6
		}

		public ContentInfo EncryptionAlgorithm
		{
			 get { } //Length: 127
		}

		public EncryptedData() { }

		public EncryptedData(ASN1 asn1) { }

		public byte[] get_EncryptedContent() { }

		public ContentInfo get_EncryptionAlgorithm() { }

	}


}

