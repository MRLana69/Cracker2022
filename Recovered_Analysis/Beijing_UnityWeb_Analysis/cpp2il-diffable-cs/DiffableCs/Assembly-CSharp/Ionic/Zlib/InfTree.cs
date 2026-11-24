namespace Ionic.Zlib;

internal sealed class InfTree
{
	private const int MANY = 1440; //Field offset: 0x0
	internal const int BMAX = 15; //Field offset: 0x0
	internal const int fixed_bd = 5; //Field offset: 0x0
	internal const int fixed_bl = 9; //Field offset: 0x0
	private const int Z_VERSION_ERROR = -6; //Field offset: 0x0
	private const int Z_BUF_ERROR = -5; //Field offset: 0x0
	private const int Z_MEM_ERROR = -4; //Field offset: 0x0
	internal static readonly int[] fixed_tl; //Field offset: 0x0
	private const int Z_STREAM_ERROR = -2; //Field offset: 0x0
	private const int Z_ERRNO = -1; //Field offset: 0x0
	private const int Z_NEED_DICT = 2; //Field offset: 0x0
	private const int Z_STREAM_END = 1; //Field offset: 0x0
	private const int Z_OK = 0; //Field offset: 0x0
	private const int Z_DATA_ERROR = -3; //Field offset: 0x0
	internal static readonly int[] fixed_td; //Field offset: 0x4
	internal static readonly int[] cplens; //Field offset: 0x8
	internal static readonly int[] cplext; //Field offset: 0xC
	internal static readonly int[] cpdist; //Field offset: 0x10
	internal static readonly int[] cpdext; //Field offset: 0x14
	internal int[] hn; //Field offset: 0x8
	internal int[] v; //Field offset: 0xC
	internal int[] c; //Field offset: 0x10
	internal int[] r; //Field offset: 0x14
	internal int[] u; //Field offset: 0x18
	internal int[] x; //Field offset: 0x1C

	private static InfTree() { }

	public InfTree() { }

	private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v) { }

	internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z) { }

	internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z) { }

	internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z) { }

	private void initWorkArea(int vsize) { }

}

