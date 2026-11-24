namespace Kiloo.GameCenter;

public class GameCenterGenerateIdentityVerificationSignatureRequest : GameCenterRequest
{
	public string publicKeyUrl; //Field offset: 0x14
	public byte[] signature; //Field offset: 0x18
	public byte[] salt; //Field offset: 0x1C
	public ulong timestamp; //Field offset: 0x20

	public GameCenterGenerateIdentityVerificationSignatureRequest() { }

}

