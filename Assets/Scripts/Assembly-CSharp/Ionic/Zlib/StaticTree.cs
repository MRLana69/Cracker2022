using System;
using System.Runtime.CompilerServices;
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
		this.treeCodes = treeCodes;
		this.extraBits = extraBits;
		this.maxLength = maxLength;
		this.elems = elems;
		this.extraBase = extraBase;
	}

	static StaticTree()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E._36B8FDA0BFB1D93A07326EE7CAC8EB99FF1AF237D234FFA3210F64D3EB774C38));
		lengthAndLiteralsTreeCodes = (short[])array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array2 = default;
		RuntimeHelpers.InitializeArray(array2, __ldtoken(_003CPrivateImplementationDetails_003E._9476220840D3CE82203B4A722E278773B1DA458A22F49FCB9FC45B851DF7D503));
		distTreeCodes = (short[])array2;
		StaticTree staticTree = default;
		staticTree.treeCodes = lengthAndLiteralsTreeCodes;
		staticTree.extraBits = Tree.ExtraLengthBits;
		staticTree.maxLength = InternalConstants.MAX_BITS;
		staticTree.elems = InternalConstants.L_CODES;
		int num = InternalConstants.LITERALS + 1;
		staticTree.extraBase = num;
		Literals = staticTree;
		StaticTree staticTree2 = default;
		staticTree2.treeCodes = distTreeCodes;
		staticTree2.extraBits = Tree.ExtraDistanceBits;
		staticTree2.maxLength = InternalConstants.MAX_BITS;
		staticTree2.elems = InternalConstants.D_CODES;
		staticTree2.extraBase = 0;
		Distances = staticTree2;
		StaticTree staticTree3 = default;
		staticTree3.treeCodes = null;
		staticTree3.extraBits = Tree.extra_blbits;
		staticTree3.maxLength = InternalConstants.MAX_BL_BITS;
		staticTree3.elems = InternalConstants.BL_CODES;
		staticTree3.extraBase = 0;
		BitLengths = staticTree3;
	}
}
