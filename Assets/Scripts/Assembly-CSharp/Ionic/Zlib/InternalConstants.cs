namespace Ionic.Zlib;

internal static class InternalConstants
{
	internal static readonly int MAX_BITS = 15;

	internal static readonly int BL_CODES = 19;

	internal static readonly int D_CODES = 30;

	internal static readonly int LITERALS = 256;

	internal static readonly int LENGTH_CODES = 29;

	internal static readonly int L_CODES;

	internal static readonly int MAX_BL_BITS;

	internal static readonly int REP_3_6;

	internal static readonly int REPZ_3_10;

	internal static readonly int REPZ_11_138;

	static InternalConstants()
	{
		//IL_0046: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		object obj = LITERALS + 1;
		int l_CODES = LENGTH_CODES + obj;
		L_CODES = l_CODES;
		MAX_BL_BITS = 7;
		REP_3_6 = 16;
		REPZ_3_10 = 17;
		REPZ_11_138 = 18;
	}
}
