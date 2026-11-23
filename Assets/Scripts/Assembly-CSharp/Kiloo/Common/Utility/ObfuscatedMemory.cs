using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public class ObfuscatedMemory
{
	private static readonly byte[] Key;

	private readonly IDictionary<string, byte[]> _dictionary;

	static ObfuscatedMemory()
	{
		//IL_0073: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		byte[] key = Convert.FromBase64String("SkYxaKhp/oTeXLy00IHiqg==");
		Key = key;
		object obj = 0;
		while (true)
		{
			byte[] key2 = Key;
			if (key2.Length > (nint)obj)
			{
				object obj2 = obj + (object)Key;
				object obj3 = obj2 + 16;
				object obj4 = obj3 ^ 0xA4;
				obj3 = obj4;
				object obj5 = obj + 1;
				obj = obj5;
				continue;
			}
			break;
		}
	}

	public bool GetBoolean(string key)
	{
		byte[] buffer = GetBuffer(key);
		return buffer[0] != 0;
	}

	public unsafe bool TryGetBoolean(string key, out bool result)
	{
		byte[] buffer = GetBuffer(key);
		bool flag = buffer != null && buffer[0] != 0;
		ref bool reference = ref *(flag ? ((bool*)1) : ((bool*)null));
		return buffer != null;
	}

	public void SetBoolean(string key, bool value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] array = default;
		array[0] = (value ? ((byte)1) : ((byte)0));
		SetBuffer(key, array);
	}

	public byte GetByte(string key)
	{
		byte[] buffer = GetBuffer(key);
		return buffer[0];
	}

	public unsafe bool TryGetByte(string key, out byte result)
	{
		byte[] buffer = GetBuffer(key);
		byte b = (byte)((buffer != null) ? buffer[0] : 0);
		ref byte reference = ref *(byte*)b;
		return buffer != null;
	}

	public void SetByte(string key, byte value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] array = default;
		array[0] = value;
		SetBuffer(key, array);
	}

	public char GetChar(string key)
	{
		byte[] buffer = GetBuffer(key);
		return BitConverter.ToChar(buffer, 0);
	}

	public unsafe bool TryGetChar(string key, out char result)
	{
		byte[] buffer = GetBuffer(key);
		char c = ((buffer != null) ? BitConverter.ToChar(buffer, 0) : '\0');
		ref char reference = ref *(char*)(ushort)c;
		return buffer != null;
	}

	public void SetChar(string key, char value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		SetBuffer(key, bytes);
	}

	public DateTime GetDateTime(string key)
	{
		long @int = GetInt64(key);
		return DateTime.FromBinary(@int);
	}

	public unsafe bool TryGetDateTime(string key, out DateTime result)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Ref, but got Unknown
		//IL_0032: Expected I8, but got I
		//IL_0043: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = TryGetInt64(key, out *(long*)(obj + 8));
		DateTime dateTime;
		if (!flag)
		{
			dateTime = DateTime.MinValue;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			dateTime = DateTime.FromBinary(0L);
		}
		ref DateTime reference = ref *(DateTime*)dateTime;
		return flag;
	}

	public unsafe void SetDateTime(string key, DateTime value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected VT, but got Unknown
		//IL_0050: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		DateTime dateTime = (DateTime)(obj + 8);
		long value2 = ((DateTime*)dateTime)->ToBinary();
		byte[] bytes = BitConverter.GetBytes(value2);
		SetBuffer(key, bytes);
	}

	public double GetDouble(string key)
	{
		byte[] buffer = GetBuffer(key);
		return BitConverter.ToDouble(buffer, 0);
	}

	public unsafe bool TryGetDouble(string key, out double result)
	{
		//IL_0066: Expected Ref, but got F8
		byte[] buffer = GetBuffer(key);
		double num = ((buffer == null) ? 0.0 : BitConverter.ToDouble(buffer, 0));
		ref double reference = ref *(double*)num;
		return buffer != null;
	}

	public void SetDouble(string key, double value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		SetBuffer(key, bytes);
	}

	public int GetInt32(string key)
	{
		byte[] buffer = GetBuffer(key);
		return BitConverter.ToInt32(buffer, 0);
	}

	public unsafe bool TryGetInt32(string key, out int result)
	{
		byte[] buffer = GetBuffer(key);
		int num = ((buffer != null) ? BitConverter.ToInt32(buffer, 0) : 0);
		ref int reference = ref *(int*)num;
		return buffer != null;
	}

	public void SetInt32(string key, int value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		SetBuffer(key, bytes);
	}

	public long GetInt64(string key)
	{
		byte[] buffer = GetBuffer(key);
		return BitConverter.ToInt64(buffer, 0);
	}

	public unsafe bool TryGetInt64(string key, out long result)
	{
		//IL_002a: Expected I8, but got I4
		byte[] buffer = GetBuffer(key);
		long num = ((buffer == null) ? 0 : BitConverter.ToInt64(buffer, 0));
		ref long reference = ref *(long*)num;
		return buffer != null;
	}

	public void SetInt64(string key, long value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		SetBuffer(key, bytes);
	}

	public short GetInt16(string key)
	{
		byte[] buffer = GetBuffer(key);
		return BitConverter.ToInt16(buffer, 0);
	}

	public unsafe bool TryGetInt16(string key, out short result)
	{
		byte[] buffer = GetBuffer(key);
		short num = (short)((buffer != null) ? BitConverter.ToInt16(buffer, 0) : 0);
		ref short reference = ref *(short*)num;
		return buffer != null;
	}

	public void SetInt16(string key, short value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		SetBuffer(key, bytes);
	}

	public float GetSingle(string key)
	{
		byte[] buffer = GetBuffer(key);
		return BitConverter.ToSingle(buffer, 0);
	}

	public unsafe bool TryGetSingle(string key, out float result)
	{
		//IL_0062: Expected Ref, but got F4
		byte[] buffer = GetBuffer(key);
		float num = ((buffer == null) ? 0f : BitConverter.ToSingle(buffer, 0));
		ref float reference = ref *(float*)num;
		return buffer != null;
	}

	public void SetSingle(string key, float value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		SetBuffer(key, bytes);
	}

	public string GetString(string key)
	{
		//IL_0024: Expected I, but got Obj
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		Encoding uTF = Encoding.UTF8;
		byte[] buffer = GetBuffer(key);
		nint num = (nint)uTF;
		object obj = uTF + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v3 (Il2CppClass<System.Text.Encoding>)+1EC] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public unsafe bool TryGetString(string key, out string result)
	{
		//IL_0055: Expected I, but got Obj
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		byte[] buffer = GetBuffer(key);
		if (buffer == null)
		{
			ref string reference = ref *(string*)null;
		}
		else
		{
			Encoding uTF = Encoding.UTF8;
			nint num = (nint)uTF;
			object obj = uTF + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S3_v3 (Il2CppClass<System.Text.Encoding>)+1EC] (should have been resolved before IL gen)");
			object obj2 = default;
			ref string reference = ref *(string*)obj2;
		}
		return buffer != null;
	}

	public void SetString(string key, string value)
	{
		//IL_0011: Expected I, but got Obj
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		Encoding uTF = Encoding.UTF8;
		nint num = (nint)uTF;
		object obj = uTF + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S4_v2 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		byte[] value2 = default;
		SetBuffer(key, value2);
	}

	public uint GetUInt32(string key)
	{
		byte[] buffer = GetBuffer(key);
		return BitConverter.ToUInt32(buffer, 0);
	}

	public unsafe bool TryGetUInt32(string key, out uint result)
	{
		byte[] buffer = GetBuffer(key);
		uint num = ((buffer != null) ? BitConverter.ToUInt32(buffer, 0) : 0u);
		ref uint reference = ref *(uint*)num;
		return buffer != null;
	}

	public void SetUInt32(string key, uint value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		SetBuffer(key, bytes);
	}

	public ulong GetUInt64(string key)
	{
		byte[] buffer = GetBuffer(key);
		return BitConverter.ToUInt64(buffer, 0);
	}

	public unsafe bool TryGetUInt64(string key, out ulong result)
	{
		//IL_002a: Expected I8, but got I4
		byte[] buffer = GetBuffer(key);
		ulong num = ((buffer == null) ? 0 : BitConverter.ToUInt64(buffer, 0));
		ref ulong reference = ref *(ulong*)num;
		return buffer != null;
	}

	public void SetUInt64(string key, ulong value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		SetBuffer(key, bytes);
	}

	public ushort GetUInt16(string key)
	{
		byte[] buffer = GetBuffer(key);
		return BitConverter.ToUInt16(buffer, 0);
	}

	public unsafe bool TryGetUInt16(string key, out ushort result)
	{
		byte[] buffer = GetBuffer(key);
		ushort num = (ushort)((buffer != null) ? BitConverter.ToUInt16(buffer, 0) : 0);
		ref ushort reference = ref *(ushort*)num;
		return buffer != null;
	}

	public void SetUInt16(string key, ushort value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		SetBuffer(key, bytes);
	}

	public byte[] GetBuffer(string key)
	{
		//IL_004a: Expected Obj, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj = default;
		bool flag = obj == null;
		byte[] result = null;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (System.Array)+C]");
			Array src = default;
			Array array = default;
			Buffer.BlockCopy(src, 0, array, 0, 0);
			object obj2 = 0;
			while (true)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v8 (System.Array)+C]");
				bool flag2 = (nint)obj3 >= 0;
				result = (byte[])array;
				if (flag2)
				{
					break;
				}
				object obj4 = obj2 + (object)array;
				object obj5 = obj4 + 16;
				byte[] key2 = Key;
				object obj6 = obj2 / key2.Length;
				object obj7 = obj6 * key2.Length;
				object obj8 = obj2 - obj7;
				object obj9 = (object)Key + obj8;
				object obj10 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S2_v14+10]");
				object obj11 = obj10 ^ 0;
				obj5 = obj11;
				object obj12 = obj2 + 1;
				obj2 = obj12;
			}
		}
		return result;
	}

	public void SetBuffer(string key, byte[] value)
	{
		//IL_00d5: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		Buffer.BlockCopy(value, 0, array, 0, value.Length);
		object obj = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3 (System.Array)+C]");
			if (0 <= (nint)obj)
			{
				break;
			}
			object obj2 = obj + (object)array;
			object obj3 = obj2 + 16;
			byte[] key2 = Key;
			object obj4 = obj / key2.Length;
			object obj5 = obj4 * key2.Length;
			object obj6 = obj - obj5;
			object obj7 = (object)Key + obj6;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v11+10]");
			object obj9 = obj8 ^ 0;
			obj3 = obj9;
			object obj10 = obj + 1;
			obj = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
	}

	public ObfuscatedMemory()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Byte[]>>>)+4] (should have been resolved before IL gen)");
		IDictionary<string, byte[]> dictionary = default;
		_dictionary = dictionary;
	}
}
