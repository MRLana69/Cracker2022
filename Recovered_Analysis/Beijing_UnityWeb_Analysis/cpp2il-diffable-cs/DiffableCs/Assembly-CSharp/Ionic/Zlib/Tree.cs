namespace Ionic.Zlib;

internal sealed class Tree
{
	private static readonly int HEAP_SIZE; //Field offset: 0x0
	internal const int Buf_size = 16; //Field offset: 0x0
	internal static readonly int[] ExtraLengthBits; //Field offset: 0x4
	internal static readonly int[] ExtraDistanceBits; //Field offset: 0x8
	internal static readonly int[] extra_blbits; //Field offset: 0xC
	internal static readonly sbyte[] bl_order; //Field offset: 0x10
	private static readonly sbyte[] _dist_code; //Field offset: 0x14
	internal static readonly sbyte[] LengthCode; //Field offset: 0x18
	internal static readonly int[] LengthBase; //Field offset: 0x1C
	internal static readonly int[] DistanceBase; //Field offset: 0x20
	internal short[] dyn_tree; //Field offset: 0x8
	internal int max_code; //Field offset: 0xC
	internal StaticTree staticTree; //Field offset: 0x10

	private static Tree() { }

	public Tree() { }

	internal static int bi_reverse(int code, int len) { }

	internal void build_tree(DeflateManager s) { }

	internal static int DistanceCode(int dist) { }

	internal void gen_bitlen(DeflateManager s) { }

	internal static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

}

