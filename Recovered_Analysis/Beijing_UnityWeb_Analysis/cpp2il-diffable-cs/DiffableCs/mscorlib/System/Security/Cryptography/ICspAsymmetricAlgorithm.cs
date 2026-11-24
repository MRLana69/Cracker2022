namespace System.Security.Cryptography;

public interface ICspAsymmetricAlgorithm
{

	public CspKeyContainerInfo CspKeyContainerInfo
	{
		 get { } //Length: 0
	}

	public byte[] ExportCspBlob(bool includePrivateParameters) { }

	public CspKeyContainerInfo get_CspKeyContainerInfo() { }

	public void ImportCspBlob(byte[] rawData) { }

}

