namespace Ionic.Crc;

public class CRC32
{
	private const int BUFFER_SIZE = 8192; //Field offset: 0x0
	private uint dwPolynomial; //Field offset: 0x8
	private long _TotalBytesRead; //Field offset: 0x10
	private bool reverseBits; //Field offset: 0x18
	private uint[] crc32Table; //Field offset: 0x1C
	private uint _register; //Field offset: 0x20

	public int Crc32Result
	{
		 get { } //Length: 413
	}

	public long TotalBytesRead
	{
		 get { } //Length: 53
	}

	internal int _InternalComputeCrc32(uint W, byte B) { }

	public CRC32(bool reverseBits) { }

	public CRC32() { }

	public CRC32(int polynomial, bool reverseBits) { }

	public void Combine(int crc, int length) { }

	public int ComputeCrc32(int W, byte B) { }

	private void GenerateLookupTable() { }

	public int get_Crc32Result() { }

	public long get_TotalBytesRead() { }

	public int GetCrc32(Stream input) { }

	public int GetCrc32AndCopy(Stream input, Stream output) { }

	private void gf2_matrix_square(uint[] square, uint[] mat) { }

	private uint gf2_matrix_times(uint[] matrix, uint vec) { }

	public void Reset() { }

	private static byte ReverseBits(byte data) { }

	private static uint ReverseBits(uint data) { }

	public void SlurpBlock(byte[] block, int offset, int count) { }

	public void UpdateCRC(byte b, int n) { }

	public void UpdateCRC(byte b) { }

}

