using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cloud;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Cloud;
using Kiloo.GameCenter;

namespace Kiloo.Serialization;

public static class BsonBinaryReaderExtensions
{
	public static IDictionary ReadBsonObject(BinaryReader reader, bool ignoreCase)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_081a: Expected I4, but got Obj
		//IL_074b: Expected Obj, but got I
		//IL_0637: Expected Obj, but got I
		//IL_0663: Expected Obj, but got I4
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected Obj, but got Unknown
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.Dispose((byte)(int)reader != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj4 = default;
		object obj3 = obj4;
		IDictionary dictionary = null;
		object obj6 = default;
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj7 = default;
		IDictionary result = default;
		object obj14 = default;
		if (obj5 == obj7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj9 = default;
			object obj8 = obj9;
			object obj10 = default;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 == -1)
			{
				if (obj8 == null)
				{
					result = dictionary;
					goto IL_096f;
				}
			}
			else
			{
				bool flag = obj8 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj2 + obj11;
				bool flag2 = (nint)obj12 != 165;
				object obj13 = flag & flag2;
				if (obj13 == null)
				{
					obj14 = obj8;
					result = dictionary;
					goto IL_096f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj15 = default;
			obj3 = obj15;
			obj5 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj16 = default;
		if (obj5 == obj16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj17 = default;
			obj14 = obj17;
			result = dictionary;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_096f;
		IL_0a59:
		return result;
		IL_096f:
		if (memoryStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj2 + obj18;
			if ((nint)obj19 == 165)
			{
				object obj20 = obj2 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_0a59;
			}
		}
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0a59;
	}

	private unsafe static IDictionary ReadBsonObject(BinaryReader reader, bool ignoreCase, ref int bytesRead)
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_0067: Expected Obj, but got Ref
		//IL_0067: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri.CreateThisFromUri((Uri)(object)reader);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CloudWorkingCopy cloudWorkingCopy = default;
		cloudWorkingCopy.SetUserData((string)(object)uri, (string)ignoreCase, (string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bytesRead));
		return (IDictionary)(object)cloudWorkingCopy;
	}

	private unsafe static KeyValuePair<string, object> ReadBsonProperty(BinaryReader reader, bool ignoreCase, ref int bytesRead)
	{
		//IL_0008: Expected native int or pointer, but got VT
		//IL_001a: Expected Obj, but got I4
		//IL_0015: Expected native int or pointer, but got VT
		KeyValuePair<string, object> keyValuePair = default;
		System.Runtime.CompilerServices.Unsafe.Write(&((KeyValuePair<string, object>*)(nint)keyValuePair)->key, reader);
		System.Runtime.CompilerServices.Unsafe.Write(&((KeyValuePair<string, object>*)(nint)keyValuePair)->value, (object)ignoreCase);
		bool flag = (nint)(ignoreCase ? 1 : 0) > (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bytesRead);
		bool flag2 = (nint)(ignoreCase ? 1 : 0) < (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bytesRead);
		return keyValuePair;
	}

	private unsafe static IList ReadBsonArray(BinaryReader reader, bool ignoreCase, ref int bytesRead)
	{
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01ca: Expected Obj, but got I4
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0298: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got I
		//IL_0250: Expected Obj, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I4
		string text = default;
		object obj = text + 8;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj3 = default;
		object obj2 = obj3 - 4;
		object obj4 = bytesRead + 4;
		ref int reference = ref *(int*)obj4;
		IList result;
		if (ignoreCase)
		{
			nint num = (nint)typeof(StringComparer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v36 (Il2CppClass<System.StringComparer>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(StringComparer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v45 (Il2CppClass<System.StringComparer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E25");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S3_v11 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S3_v12+60]");
			object obj7 = 0;
			object obj8 = obj7;
			object obj9 = obj8 & 0x1FFF;
			object obj10 = obj9 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S4_v16 (should have been resolved before IL gen)");
			IList list = default;
			result = list;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S3_v6 (Il2CppMethodInfo)+C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S3_v7+60]");
			object obj12 = 0;
			object obj13 = obj12;
			object obj14 = obj13 & 0x1FFF;
			object obj15 = obj14 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v71 @ S4_v12 (should have been resolved before IL gen)");
			IList list2 = default;
			result = list2;
		}
		object obj16 = bytesRead;
		while (true)
		{
			object obj17 = obj2 + bytesRead;
			object obj18 = obj17 - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18))
			{
				break;
			}
			GameCenterPlugin._GameCenterLoadLeaderboardForIDs(text, (string)(object)reader, ignoreCase ? 1 : 0, (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bytesRead));
			obj = text;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S4_v6+60]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S4_v7+48]");
			object obj21 = 0;
			object obj22 = obj21 & 0x7FF;
			object obj23 = obj22 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v113 @ S5_v6 (should have been resolved before IL gen)");
			obj16 = bytesRead;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj24 = bytesRead + 1;
		reference = ref *(int*)obj24;
		return result;
	}

	private unsafe static string ReadBsonString(BinaryReader reader, ref int bytesRead)
	{
		return (string)(object)ReadBsonArray(reader, (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bytesRead) != 0, ref *(int*)null);
	}

	private unsafe static string ReadBsonCString(BinaryReader reader, ref int bytesRead)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj2 = default;
		object obj = obj2 - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + bytesRead;
		ref int reference = ref *(int*)obj4;
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		string result = default;
		return result;
	}
}
