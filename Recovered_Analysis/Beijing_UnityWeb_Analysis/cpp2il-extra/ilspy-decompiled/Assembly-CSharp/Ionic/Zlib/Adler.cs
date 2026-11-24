using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace Ionic.Zlib;

public sealed class Adler
{
	private static readonly uint BASE;

	private static readonly int NMAX;

	public static uint Adler32(uint adler, byte[] buf, int index, int len)
	{
		//IL_0104: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		if (buf.Length != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			uint num = default;
			if (num != 0)
			{
				int num2 = index;
				object obj5 = default;
				while (true)
				{
					object obj = (int)num + index;
					if (num2 >= (nint)obj)
					{
						break;
					}
					object obj2 = buf + 16;
					object obj3 = obj2 + num2;
					object obj4 = obj5 + 16;
					int num3 = num2 << 1;
					object obj6 = obj4 + num3;
					obj3 = obj6;
					int num4 = num2 + 1;
					num2 = num4;
				}
				return num;
			}
			return uint.MaxValue;
		}
		return 0u;
	}

	unsafe static Adler()
	{
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01b7: Expected Obj, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected I4, but got Unknown
		//IL_01d2: Expected I4, but got Obj
		//IL_000b: Expected Obj, but got I
		//IL_0018: Expected I4, but got Obj
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_0075: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_027f: Expected Obj, but got I4
		//IL_029e: Expected I, but got Obj
		//IL_02b4: Expected Obj, but got I
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_0314: Expected I, but got Obj
		//IL_032a: Expected Obj, but got I
		//IL_00a0: Expected I, but got Obj
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		CallingConvention callingConvention = (CallingConvention)(obj2 + 8);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		StaticTree.lengthAndLiteralsTreeCodes = (short[])(object)unmanagedFunctionPointerAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj2 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute2 = default;
		unmanagedFunctionPointerAttribute2._002Ector(callingConvention);
		nint num = (nint)typeof(StaticTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26 (Il2CppClass<Ionic.Zlib.StaticTree>)+5C]");
		object obj3 = (nint)0 + (nint)4;
		obj3 = unmanagedFunctionPointerAttribute2;
		nint num2 = (nint)typeof(Tree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v34 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Tree);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v131 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num4 = (nint)typeof(InternalConstants);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v42 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v125 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj7 = default;
		object obj6 = obj7 + 8;
		obj6 = StaticTree.lengthAndLiteralsTreeCodes;
		object obj8 = obj7 + 12;
		obj8 = Tree.ExtraLengthBits;
		object obj9 = InternalConstants.LITERALS + 1;
		_ = InternalConstants.L_CODES;
		_ = InternalConstants.MAX_BITS;
		nint num6 = (nint)typeof(StaticTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v67 (Il2CppClass<Ionic.Zlib.StaticTree>)+5C]");
		object obj10 = (nint)0 + (nint)8;
		obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj12 = default;
		object obj11 = obj12 + 8;
		obj11 = StaticTree.distTreeCodes;
		object obj13 = obj12 + 12;
		obj13 = Tree.ExtraDistanceBits;
		_ = 0;
		_ = InternalConstants.D_CODES;
		_ = InternalConstants.MAX_BITS;
		nint num7 = (nint)typeof(StaticTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v96 (Il2CppClass<Ionic.Zlib.StaticTree>)+5C]");
		object obj14 = (nint)0 + (nint)12;
		obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj16 = default;
		object obj15 = obj16 + 8;
		obj15 = 0;
		object obj17 = obj16 + 12;
		obj17 = Tree.extra_blbits;
		_ = 0;
		_ = InternalConstants.BL_CODES;
		_ = InternalConstants.MAX_BL_BITS;
		nint num8 = (nint)typeof(StaticTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v121 (Il2CppClass<Ionic.Zlib.StaticTree>)+5C]");
		object obj18 = (nint)0 + (nint)16;
		obj18 = obj16;
	}
}
