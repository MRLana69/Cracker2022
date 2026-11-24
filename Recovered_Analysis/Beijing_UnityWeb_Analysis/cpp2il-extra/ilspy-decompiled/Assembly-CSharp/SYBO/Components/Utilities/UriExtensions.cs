using System;
using Cpp2ILInjected;

namespace SYBO.Components.Utilities;

public static class UriExtensions
{
	public unsafe static Uri Append(Uri uri, string[] paths)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected I, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_02cb: Expected I4, but got Obj
		//IL_002b: Expected I, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_0353: Expected I, but got Obj
		//IL_006c: Expected I, but got Obj
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_03c4: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I
		//IL_03f7: Expected I4, but got Obj
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		nint num = (nint)(obj2 + 16);
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj4 = default;
		string text;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v10 (Il2CppClass<System.Type>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S2_v65 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = typeof(string);
			((IntPtr*)num)->m_value = (void*)(nint)obj2;
			Type type = Type.internal_from_handle((IntPtr)num);
			object obj6 = default;
			if (obj6 != type)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				text = "";
				object obj7 = default;
				string text2 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj7 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					text = text2;
				}
				object obj8 = obj3 + 4;
				object obj9 = obj8 + 1;
				obj8 = obj9;
				object obj10 = obj9 << 2;
				object obj11 = obj3 + obj10;
				obj11 = 114;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj12 = default;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
					object obj13 = (nint)0 << 2;
					object obj14 = obj3 + obj13;
					if ((nint)obj14 == 114)
					{
						object obj15 = obj3 + 4;
						if ((nint)obj15 > -1)
						{
							object obj16 = obj15 + -1;
							obj15 = obj16;
						}
						goto IL_0423;
					}
				}
				object obj17 = default;
				if (obj17 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_0423;
			}
		}
		string text3 = $"{paths}";
		int totalLength = (int)text3;
		goto IL_02d0;
		IL_02d0:
		return (Uri)(object)string.ConcatArray((string[])(object)"", totalLength);
		IL_0423:
		if (text.m_stringLength >= 1)
		{
			int length = text.m_stringLength - 2;
			string text4 = text.InternalSubString(0, length);
			text = text4;
		}
		string text5 = $"{(object[])(object)text}";
		totalLength = (int)text5;
		goto IL_02d0;
	}
}
