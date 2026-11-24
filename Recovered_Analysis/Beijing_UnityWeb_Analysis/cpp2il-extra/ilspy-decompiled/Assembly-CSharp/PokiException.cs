using System;
using Cpp2ILInjected;

public class PokiException : Exception
{
	public PokiException(string message)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0019: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [3B0E1C]");
		object obj = 0;
		PokiException ex = (PokiException)0;
		base._className = null;
		object obj2 = message + 4;
		if ((nint)obj2 != message.m_stringLength)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v5+80]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v5+D8]");
			object obj3 = num + 0;
			object obj4 = this + 4;
			object obj5 = this + 8;
			object obj6 = this + 12;
			object obj8 = default;
			object obj7 = obj8 + 4;
			object obj9 = obj8 + 8;
			object obj10 = obj8 + 12;
			int stringLength = message.m_stringLength;
			int stringLength2 = message.m_stringLength;
			object obj13 = default;
			object obj15 = default;
			object obj17 = default;
			object obj19 = default;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ L4_v3 (System.Int32)+8]");
				object obj11 = (nint)0 + (nint)(-36);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5F6A");
				object obj12 = obj13 + obj7;
				object obj14 = obj15 + obj9;
				object obj16 = obj17 + obj10;
				object obj18 = obj19 + obj8;
				ex = (PokiException)obj18;
				obj4 = obj12;
				obj5 = obj14;
				obj6 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ L1_v2 (System.Int32)+4]");
			}
			while (obj2 != null);
		}
	}
}
