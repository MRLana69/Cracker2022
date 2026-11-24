using System;
using System.Collections;
using System.IO;
using Cpp2ILInjected;

namespace Kiloo.Common.Backend.Cloud;

public static class CloudItemExtensions
{
	public static byte[] GetBytes(ICloudItem item)
	{
		//IL_001b: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00f6: Expected I4, but got Obj
		//IL_010d: Expected Obj, but got I4
		IEnumerator enumerator = ((CloudWorkingCopy)(object)item).UpdateMetadataCoroutine((CloudWorkingCopy.CompleteHandler)(object)"UpdateMetadata");
		if (enumerator != null)
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L0 (Kiloo.Common.Backend.Cloud.ICloudItem)+28]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+8]");
			_ = 0;
			object obj3 = default;
			object obj2 = obj3 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+C]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v6 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S3_v7+60]");
			object obj5 = 0;
			object obj6 = obj5;
			object obj7 = obj6 & 0x1FFF;
			object obj8 = obj7 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44 @ S4_v5 (should have been resolved before IL gen)");
			object obj9 = obj3 + 16;
			object obj10 = default;
			obj9 = obj10;
			object obj11 = enumerator + 16;
			obj11 = obj3;
			bool flag = ((CloudWorkingCopy)(object)item).Commit((byte)(int)enumerator != 0);
			_ = 0;
			return (byte[])flag;
		}
		return null;
	}

	public static int WriteToStream(ICloudItem item, Stream stream)
	{
		//IL_001e: Expected I4, but got Obj
		return (int)((CloudWorkingCopy)(object)item).GetItemMetadata((string)(object)stream);
	}

	public static void SaveToFile(ICloudItem item, string path)
	{
		throw new InvalidOperationException();
	}

	public static int SaveToFileComputingCrc32(ICloudItem item, string path)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Expected I4, but got Obj
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0085: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
		object obj4 = default;
		object obj3 = obj4 << 32;
		object obj5 = default;
		int result = obj5 | obj3;
		object obj6 = obj2 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj2 + obj8;
		obj9 = 34;
		object obj10 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj2 + obj11;
			if ((nint)obj12 == 34)
			{
				object obj13 = obj2 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0234;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0234;
		IL_0234:
		return result;
	}

	public static int SaveToFileAndOptionallyComputeCrc32(ICloudItem item, string path, bool calclulateCrc32)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = item;
		object obj2 = num + 20;
		obj2 = path;
		object obj3 = num + 28;
		obj3 = calclulateCrc32;
		return num;
	}
}
