namespace SYBO.Components.Crypt;

public interface ICrypt
{

	public string Decrypt(string encrypted) { }

	public byte[] Decrypt(byte[] buffer) { }

	public string Encrypt(string unencrypted) { }

	public byte[] Encrypt(byte[] buffer) { }

}

