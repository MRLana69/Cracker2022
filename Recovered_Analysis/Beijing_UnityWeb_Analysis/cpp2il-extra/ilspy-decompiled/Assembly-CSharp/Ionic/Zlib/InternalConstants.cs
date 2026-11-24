using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Ionic.Zlib;

internal static class InternalConstants
{
	internal static readonly int MAX_BITS;

	internal static readonly int BL_CODES;

	internal static readonly int D_CODES;

	internal static readonly int LITERALS;

	internal static readonly int LENGTH_CODES;

	internal static readonly int L_CODES;

	internal static readonly int MAX_BL_BITS;

	internal static readonly int REP_3_6;

	internal static readonly int REPZ_3_10;

	internal static readonly int REPZ_11_138;

	unsafe static InternalConstants()
	{
		//IL_0323: Expected I, but got Obj
		//IL_0339: Expected Obj, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_039a: Expected Obj, but got I
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected I4, but got Unknown
		//IL_03b5: Expected I4, but got Obj
		//IL_03d0: Expected I, but got Obj
		//IL_03e6: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I
		//IL_0073: Expected I4, but got Obj
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I
		//IL_00dc: Expected I4, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got I
		//IL_0145: Expected I4, but got Obj
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01a1: Expected Obj, but got I
		//IL_01ae: Expected I4, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_020a: Expected Obj, but got I
		//IL_0217: Expected I4, but got Obj
		//IL_0232: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0273: Expected Obj, but got I
		//IL_0280: Expected I4, but got Obj
		//IL_029b: Expected I, but got Obj
		//IL_02b1: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I
		//IL_02db: Expected I4, but got Obj
		//IL_02f6: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I
		nint num = (nint)typeof(InternalConstants);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v105 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = L_CODES << 1;
		int hEAP_SIZE = num3 + 1;
		Tree.HEAP_SIZE = hEAP_SIZE;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = default;
		object obj2 = obj3 + 28;
		obj2 = 0;
		CallingConvention callingConvention = (CallingConvention)(obj3 + 32);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		nint num4 = (nint)typeof(Tree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v25 (Il2CppClass<Ionic.Zlib.Tree>)+5C]");
		object obj4 = (nint)0 + (nint)4;
		obj4 = unmanagedFunctionPointerAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj5 = obj3 + 24;
		obj5 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj5;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute2 = default;
		unmanagedFunctionPointerAttribute2._002Ector(callingConvention);
		nint num5 = (nint)typeof(Tree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v36 (Il2CppClass<Ionic.Zlib.Tree>)+5C]");
		object obj6 = (nint)0 + (nint)8;
		obj6 = unmanagedFunctionPointerAttribute2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj7 = obj3 + 20;
		obj7 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj7;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute3 = default;
		unmanagedFunctionPointerAttribute3._002Ector(callingConvention);
		nint num6 = (nint)typeof(Tree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v47 (Il2CppClass<Ionic.Zlib.Tree>)+5C]");
		object obj8 = (nint)0 + (nint)12;
		obj8 = unmanagedFunctionPointerAttribute3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj9 = obj3 + 16;
		obj9 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj9;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute4 = default;
		unmanagedFunctionPointerAttribute4._002Ector(callingConvention);
		nint num7 = (nint)typeof(Tree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v58 (Il2CppClass<Ionic.Zlib.Tree>)+5C]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = unmanagedFunctionPointerAttribute4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj11 = obj3 + 12;
		obj11 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj11;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute5 = default;
		unmanagedFunctionPointerAttribute5._002Ector(callingConvention);
		nint num8 = (nint)typeof(Tree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v69 (Il2CppClass<Ionic.Zlib.Tree>)+5C]");
		object obj12 = (nint)0 + (nint)20;
		obj12 = unmanagedFunctionPointerAttribute5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj13 = obj3 + 8;
		obj13 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj13;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute6 = default;
		unmanagedFunctionPointerAttribute6._002Ector(callingConvention);
		nint num9 = (nint)typeof(Tree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v80 (Il2CppClass<Ionic.Zlib.Tree>)+5C]");
		object obj14 = (nint)0 + (nint)24;
		obj14 = unmanagedFunctionPointerAttribute6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj15 = obj3 + 4;
		obj15 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj15;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute7 = default;
		unmanagedFunctionPointerAttribute7._002Ector(callingConvention);
		nint num10 = (nint)typeof(Tree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v91 (Il2CppClass<Ionic.Zlib.Tree>)+5C]");
		object obj16 = (nint)0 + (nint)28;
		obj16 = unmanagedFunctionPointerAttribute7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj3 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj3;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute8 = default;
		unmanagedFunctionPointerAttribute8._002Ector(callingConvention);
		nint num11 = (nint)typeof(Tree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v101 (Il2CppClass<Ionic.Zlib.Tree>)+5C]");
		object obj17 = (nint)0 + (nint)32;
		obj17 = unmanagedFunctionPointerAttribute8;
	}
}
