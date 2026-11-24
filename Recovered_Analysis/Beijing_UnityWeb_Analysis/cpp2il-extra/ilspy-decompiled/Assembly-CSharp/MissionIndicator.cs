using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;

[StructLayout((LayoutKind)0, Size = 12)]
public struct MissionIndicator
{
	public int versionNo;

	public int missionSet;

	public int missionNumberInSet;

	public MissionIndicator(int versionNumber, int missionSet, int missionIndexInSet)
	{
		//IL_02b4: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected I4, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00fe: Expected I4, but got Obj
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_00ec: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		bool flag = string.IsNullOrEmpty((string)versionNumber);
		object obj = (flag ? 1 : 0) + 12;
		object obj2 = 0;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj4 = (flag ? 1 : 0) + 16;
			object obj5 = obj3 << 1;
			object obj6 = obj4 + obj5;
			int num = obj6 & 0xFFFF;
			bool flag2;
			if (num == 59)
			{
				flag2 = true;
			}
			else
			{
				object obj7 = obj6 + -32;
				object obj8 = obj7 << 16;
				object obj9 = obj8 >> 16;
				object obj10 = obj9 & 0xFFFF;
				flag2 = (nint)obj10 > 94;
			}
			if (flag2)
			{
				obj2 = 1;
			}
			else
			{
				StringBuilder stringBuilder2 = stringBuilder.Append((int)obj6);
			}
			object obj11 = obj3 + 1;
			obj3 = obj11;
		}
		if (obj2 != null)
		{
			StringBuilder stringBuilder3 = stringBuilder.AppendLine(" [IllegalChars]");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
