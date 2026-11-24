using System.IO;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Utility;

public class JsonFileSaver : IFileSaver
{
	private readonly IJsonSerializer _jsonSerializer;

	public unsafe JsonFileSaver(IJsonSerializer jsonSerializer)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected VT, but got Unknown
		//IL_0146: Expected F4, but got Obj
		//IL_0141: Expected native int or pointer, but got VT
		//IL_015b: Expected F4, but got I
		//IL_0156: Expected native int or pointer, but got VT
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected VT, but got Unknown
		//IL_0176: Expected F4, but got Obj
		//IL_0171: Expected native int or pointer, but got VT
		//IL_018b: Expected F4, but got I
		//IL_0186: Expected native int or pointer, but got VT
		//IL_01d8: Expected F4, but got Obj
		//IL_01d3: Expected native int or pointer, but got VT
		//IL_01ed: Expected F4, but got I
		//IL_01e8: Expected native int or pointer, but got VT
		//IL_01fa: Expected F4, but got Obj
		//IL_01f5: Expected native int or pointer, but got VT
		//IL_020f: Expected F4, but got I
		//IL_020a: Expected native int or pointer, but got VT
		//IL_0220: Expected Obj, but got VT
		//IL_0220: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 48;
		obj3 = this;
		_ = _jsonSerializer;
		object obj4 = obj2 + 36;
		obj4 = jsonSerializer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [jsonSerializer @ L1 (Kiloo.Common.Utility.IJsonSerializer)+8]");
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = this;
		_ = _jsonSerializer;
		object obj6 = obj2 + 12;
		obj6 = jsonSerializer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [jsonSerializer @ L1 (Kiloo.Common.Utility.IJsonSerializer)+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v46 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 72);
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 84);
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v21+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
		object obj8 = default;
		float value = (float)obj8 * 0.1f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((ObfuscatedMemory)vector).SetSingle((string)vector2, value);
	}

	public void Save(string file, object obj)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj3 = obj2;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @32");
	}

	public T Load<T>(string file)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_021c: Expected I4, but got Obj
		//IL_0020: Expected I4, but got Obj
		//IL_0030: Expected Obj, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.Dispose((byte)(int)file != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryReader binaryReader = default;
		binaryReader.Dispose((byte)(int)memoryStream != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 32;
		if (binaryReader != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj2 + obj8;
			if ((nint)obj9 == 32)
			{
				object obj10 = obj2 + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
				goto IL_024d;
			}
		}
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_024d;
		IL_024d:
		T result = default;
		return result;
	}

	public unsafe bool TryLoad<T>(string file, out T obj)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj3 = obj2;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj6 = default;
		ref T reference = ref *(T*)obj6;
		return true;
	}

	private static void LogError(string msg)
	{
	}
}
