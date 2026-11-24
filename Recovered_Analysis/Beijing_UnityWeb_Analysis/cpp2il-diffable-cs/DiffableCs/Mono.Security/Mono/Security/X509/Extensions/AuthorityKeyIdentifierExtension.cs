namespace Mono.Security.X509.Extensions;

public class AuthorityKeyIdentifierExtension : X509Extension
{
	private byte[] aki; //Field offset: 0x14

	public byte[] Identifier
	{
		 get { } //Length: 109
	}

	public AuthorityKeyIdentifierExtension(X509Extension extension) { }

	protected override void Decode() { }

	protected override void Encode() { }

	public byte[] get_Identifier() { }

	public override string ToString() { }

}

