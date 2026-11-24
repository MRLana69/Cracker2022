using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Ionic.Zlib;

internal static class InternalInflateConstants
{
	internal static readonly int[] InflateMask;

	unsafe static InternalInflateConstants()
	{
		//IL_0015: Expected Obj, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		//IL_0030: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj = 0;
		CallingConvention callingConvention = (CallingConvention)(obj + 4);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		InflateBlocks.border = (int[])(object)unmanagedFunctionPointerAttribute;
	}
}
