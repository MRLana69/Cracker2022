using System;
using Cpp2ILInjected;
using SYBO.Components.Utilities.Validators;

namespace SYBO.Common.Exceptions;

public class SwitchDefaultException : Exception
{
	public SwitchDefaultException(string missingSwitchValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got I
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		//IL_010b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v70+8]");
				if (0 == (nint)base._className)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v70+10]");
					if (0 == (nint)missingSwitchValue)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						object obj6 = this + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v70+C]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						object obj7 = obj4 + 4;
						object obj8 = obj7 + 1;
						obj7 = obj8;
						object obj9 = obj8 << 2;
						object obj10 = obj4 + obj9;
						obj10 = 118;
						break;
					}
				}
				continue;
			}
			object obj11 = obj4 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj4 + obj13;
			obj14 = 118;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 118)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				return;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public static void Throw(string missingSwitchValue)
	{
		_ = 1f;
		_ = 1f;
		((Validator<>)(object)missingSwitchValue)._002Ector();
	}
}
