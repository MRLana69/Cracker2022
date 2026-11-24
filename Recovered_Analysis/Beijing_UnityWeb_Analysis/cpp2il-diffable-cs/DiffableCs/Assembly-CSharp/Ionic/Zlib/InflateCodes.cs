namespace Ionic.Zlib;

internal sealed class InflateCodes
{
	private const int START = 0; //Field offset: 0x0
	private const int LEN = 1; //Field offset: 0x0
	private const int LENEXT = 2; //Field offset: 0x0
	private const int DIST = 3; //Field offset: 0x0
	private const int DISTEXT = 4; //Field offset: 0x0
	private const int COPY = 5; //Field offset: 0x0
	private const int LIT = 6; //Field offset: 0x0
	private const int WASH = 7; //Field offset: 0x0
	private const int END = 8; //Field offset: 0x0
	private const int BADCODE = 9; //Field offset: 0x0
	internal int mode; //Field offset: 0x8
	internal int len; //Field offset: 0xC
	internal int[] tree; //Field offset: 0x10
	internal int tree_index; //Field offset: 0x14
	internal int need; //Field offset: 0x18
	internal int lit; //Field offset: 0x1C
	internal int bitsToGet; //Field offset: 0x20
	internal int dist; //Field offset: 0x24
	internal byte lbits; //Field offset: 0x28
	internal byte dbits; //Field offset: 0x29
	internal int[] ltree; //Field offset: 0x2C
	internal int ltree_index; //Field offset: 0x30
	internal int[] dtree; //Field offset: 0x34
	internal int dtree_index; //Field offset: 0x38

	internal InflateCodes() { }

	internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z) { }

	internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index) { }

	internal int Process(InflateBlocks blocks, int r) { }

}

