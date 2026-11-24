namespace Mono.Security.Cryptography;

public class MD2Managed : MD2
{
	private static readonly byte[] PI_SUBST; //Field offset: 0x0
	private byte[] state; //Field offset: 0x18
	private byte[] checksum; //Field offset: 0x1C
	private byte[] buffer; //Field offset: 0x20
	private int count; //Field offset: 0x24
	private byte[] x; //Field offset: 0x28

	private static MD2Managed() { }

	public MD2Managed() { }

	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	public override void Initialize() { }

	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	private byte[] Padding(int nLength) { }

}

