using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public static class BsonConverterExtensions
{
	public static byte[] ToBson(IBsonSerializer serializer, object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0254: Expected Obj, but got I
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		byte[] array2 = default;
		byte[] array = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj4 = default;
		object obj3 = obj4;
		object obj6 = default;
		object obj5 = obj6;
		object obj8 = default;
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj9 = default;
		object obj10;
		if (obj7 != obj9)
		{
			obj10 = obj3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj12 = default;
			object obj11 = obj12;
			object obj13 = obj5;
			array2 = array;
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj15 = (nint)0 << 2;
				object obj16 = obj2 + obj15;
				if ((nint)obj16 == 65)
				{
					object obj17 = obj2 + 4;
					if ((nint)obj17 > -1)
					{
						object obj18 = obj17 + -1;
						obj17 = obj18;
					}
					goto IL_069a;
				}
			}
			if (obj11 == null)
			{
				goto IL_069a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj19 = default;
			obj10 = obj19;
			obj7 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj20 = default;
		if (obj7 == obj20)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj21 = default;
			string text = (string)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj23 = default;
			object obj22 = obj23;
		}
		else
		{
			object obj22 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		goto IL_0573;
		IL_0573:
		return array2;
		IL_069a:
		if (value != null)
		{
			object obj24 = array2 + 12;
			object obj25 = value + 12;
			object obj26 = obj24 + obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
		}
		else
		{
			byte[] array3 = array2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		}
		else
		{
			array2 = null;
		}
		goto IL_0573;
	}

	public static T FromBson<T>(IBsonSerializer serializer, byte[] data)
	{
		//IL_002b: Expected VT, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0175: Expected VT, but got Obj
		//IL_00b0: Expected Obj, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_016b: Expected VT, but got Obj
		//IL_00be: Expected VT, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		bool flag = serializer == null;
		bool flag2 = data == null;
		T val = (T)(flag & flag2);
		object obj = flag | flag2;
		bool flag3 = obj == null;
		bool flag4 = !flag3;
		T result = val;
		if (!flag4)
		{
			object obj2 = serializer + 12;
			if ((nint)obj2 == data.Length)
			{
				object obj3 = obj2;
				object obj4 = 0;
				while (true)
				{
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
					{
						result = (T)1;
						break;
					}
					object obj5 = serializer + 16;
					object obj6 = obj4 << 2;
					object obj7 = obj5 + obj6;
					object obj8 = data + 16;
					object obj9 = obj4 << 2;
					object result2 = obj8 + obj9;
					Assembly assembly = ((ResolveEventHandler)obj7).EndInvoke((IAsyncResult)result2);
					if ((object)assembly != null)
					{
						object obj10 = obj4 + 1;
						obj3 = obj2;
						obj4 = obj10;
						continue;
					}
					result = (T)null;
					break;
				}
			}
			else
			{
				result = (T)null;
			}
		}
		return result;
	}
}
