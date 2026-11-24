using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;

namespace Kiloo.Serialization;

public static class ConversionHelper
{
	public static string ValueAsString(object value, IFormatProvider formatProvider)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = formatProvider + 1;
			IFormatProvider formatProvider2 = (IFormatProvider)obj;
			object obj2 = obj3 & 0xFF;
			if (obj2 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		string result = default;
		return result;
	}

	public static IDictionary ValueAsDictionary(object obj)
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		IDictionary result;
		if (obj != null)
		{
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = (((object)obj.GetType() != typeof(string)) ? null : obj);
			}
			if (obj2 != null)
			{
				result = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj3 = default;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
					object obj4 = default;
					bool flag = obj4 == null;
					result = null;
					if (flag)
					{
						goto IL_015f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
				Type type = default;
				if (type.IsCOMObject)
				{
					result = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj5 = default;
					result = (IDictionary)(obj5 ^ 1);
				}
			}
		}
		else
		{
			result = null;
		}
		goto IL_015f;
		IL_015f:
		return result;
	}

	private static object GetDefault(Type type)
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01db: Expected Obj, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_02d7: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		object result;
		if ((object)type != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v4+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v161 @ S4_v8 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			object obj7 = default;
			object obj6 = obj7 + 12;
			object obj8 = 113696;
			object obj9 = default;
			object obj14 = default;
			object obj15 = default;
			object obj16 = default;
			object obj20 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				object obj10 = obj7 + 16;
				object obj11 = obj9 << 2;
				object obj12 = obj10 + obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj13 = obj14 & 0x80;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E38");
					if (obj15 != obj16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S4_v16 (Il2CppMethodInfo)+C]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S4_v17+60]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S4_v18+48]");
						obj5 = 0;
						object obj19 = obj5 & 0x7FF;
						obj8 = obj19 + 39195;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v160 @ S5_v6 (should have been resolved before IL gen)");
					}
				}
				obj9 = obj20 + 1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			object obj22 = default;
			object obj21 = obj22 + 12;
			object obj23 = 0;
			object obj24 = default;
			object obj28 = default;
			object obj29 = default;
			object obj30 = default;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21);
				result = obj24;
				if (flag)
				{
					break;
				}
				object obj25 = obj22 + 16;
				object obj26 = obj23 << 2;
				object obj27 = obj25 + obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				if (obj28 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v31+C]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E38");
						if (obj29 != obj30)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S4_v10 (Il2CppMethodInfo)+C]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S4_v11+60]");
							object obj32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S4_v12+48]");
							obj5 = 0;
							object obj33 = obj5 & 0x7FF;
							obj8 = obj33 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v160 @ S5_v6 (should have been resolved before IL gen)");
						}
					}
				}
				object obj34 = obj23 + 1;
				obj23 = obj34;
			}
		}
		else
		{
			result = null;
		}
		return result;
	}
}
