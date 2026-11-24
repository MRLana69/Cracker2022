using Cpp2ILInjected;

namespace Ionic.Zlib;

internal sealed class StaticTree
{
	internal static readonly short[] lengthAndLiteralsTreeCodes;

	internal static readonly short[] distTreeCodes;

	internal static readonly StaticTree Literals;

	internal static readonly StaticTree Distances;

	internal static readonly StaticTree BitLengths;

	internal short[] treeCodes;

	internal int[] extraBits;

	internal int extraBase;

	internal int elems;

	internal int maxLength;

	private StaticTree(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength)
	{
		if (this.extraBits != null)
		{
			switch (maxLength)
			{
			case 0:
			case 2:
			case 3:
			case 4:
			{
				int num = maxLength;
				break;
			}
			default:
			{
				int num = 1;
				break;
			}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8940");
		}
	}

	static StaticTree()
	{
		//IL_0046: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		InternalConstants.MAX_BITS = 15;
		InternalConstants.BL_CODES = 19;
		InternalConstants.D_CODES = 30;
		InternalConstants.LITERALS = 256;
		InternalConstants.LENGTH_CODES = 29;
		object obj = InternalConstants.LITERALS + 1;
		int l_CODES = InternalConstants.LENGTH_CODES + obj;
		InternalConstants.L_CODES = l_CODES;
		InternalConstants.MAX_BL_BITS = 7;
		InternalConstants.REP_3_6 = 16;
		InternalConstants.REPZ_3_10 = 17;
		InternalConstants.REPZ_11_138 = 18;
	}
}
