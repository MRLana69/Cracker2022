using System;
using System.Reflection;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using UnityEngine;

namespace SYBO.Components.Utilities.Attributes;

public class SectionHeaderAttribute : PropertyAttribute
{
	public const int SizeH1 = 18;

	public const int SizeH2 = 16;

	public const int SizeH3 = 12;

	public const int SizeDefault = 12;

	public string Text;

	public int Size;

	public SectionHeaderAttribute(string text, int size)
	{
		//IL_01f6: Expected VT, but got I4
		//IL_0204: Expected I, but got Obj
		//IL_021a: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00a4: Expected VT, but got I4
		//IL_00f8: Expected I, but got Obj
		((FieldInfo)(object)text).SetValueDirect((TypedReference)0, (object)null);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)size).FindKernel(null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj2 = default;
		if (obj2 != null)
		{
			((FieldInfo)(object)text).SetValueDirect((TypedReference)0, (object)size);
			return;
		}
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v17 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v24 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)size);
		throw new ArrayTypeMismatchException();
	}

	public SectionHeaderAttribute(string text)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = text & 1;
	}
}
