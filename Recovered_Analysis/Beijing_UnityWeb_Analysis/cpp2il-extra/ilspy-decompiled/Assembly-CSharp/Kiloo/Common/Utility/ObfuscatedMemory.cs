using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Kiloo.Common.Utility;

public class ObfuscatedMemory
{
	private static readonly byte[] Key;

	private readonly IDictionary<string, byte[]> _dictionary;

	static ObfuscatedMemory()
	{
		//IL_002f: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		Depository._nextTicket = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(Depository);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v12 (Il2CppClass<Kiloo.Common.Utility.Depository>)+5C]");
		object obj6 = (nint)0 + (nint)4;
		object obj7 = default;
		obj6 = obj7;
	}

	public bool GetBoolean(string key)
	{
		StaticUpdater instance = StaticUpdater.instance;
		if (System.Runtime.CompilerServices.Unsafe.As<ObfuscatedMemory, UIntPtr>(ref this) > System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref key))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		}
		bool result = default;
		return result;
	}

	public bool TryGetBoolean(string key, out bool result)
	{
		//IL_00f1: Expected F8, but got Obj
		//IL_00f1: Expected F8, but got Obj
		//IL_0103: Expected I, but got Obj
		//IL_0119: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00e2: Expected I4, but got F8
		double d = Math.Pow((double)this, (double)key);
		nint num = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v4 (Il2CppClass<System.Math>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v12 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		double num3 = Math.Floor(d);
		if (num3 != num3)
		{
			return false;
		}
		if (!(num3 < 2147483648.0))
		{
			return false;
		}
		if (!(num3 > -2147483649.0))
		{
			return false;
		}
		return (byte)(int)num3 != 0;
	}

	public void SetBoolean(string key, bool value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @32");
	}

	public byte GetByte(string key)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		object obj = text + 16;
		return (obj != null) ? ((byte)1) : ((byte)0);
	}

	public unsafe bool TryGetByte(string key, out byte result)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		bool flag2;
		bool result2;
		if (text != null)
		{
			object obj = text + 16;
			bool flag = obj != null;
			flag2 = flag;
			result2 = true;
		}
		else
		{
			flag2 = false;
			result2 = false;
		}
		ref byte reference = ref *(flag2 ? ((byte*)1) : ((byte*)null));
		return result2;
	}

	public void SetByte(string key, byte value)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Action action = default;
		object obj = action + 16;
		int num = value & 1;
		obj = num;
		((ThreadPooling)this).RunAsync((Action<ThreadPooling.ProgressDelegate>)(object)key, action);
	}

	public char GetChar(string key)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0021: Expected I4, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		object obj = text + 16;
		return (char)(int)obj;
	}

	public unsafe bool TryGetChar(string key, out char result)
	{
		//IL_0058: Expected Obj, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		object obj2;
		bool result2;
		if (text != null)
		{
			object obj = text + 16;
			obj2 = obj;
			result2 = true;
		}
		else
		{
			obj2 = 0;
			result2 = false;
		}
		ref char reference = ref *(char*)obj2;
		return result2;
	}

	public void SetChar(string key, char value)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Action action = default;
		object obj = action + 16;
		obj = value;
		((ThreadPooling)this).RunAsync((Action<ThreadPooling.ProgressDelegate>)(object)key, action);
	}

	public DateTime GetDateTime(string key)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0143: Expected Obj, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_0045: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I4
		//IL_0086: Expected I, but got Obj
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 16;
		obj5 = 0;
		object obj6 = this & 0x3FFFFFFFFFFFFFFFL;
		object obj7 = obj6 / 864000000000L;
		object obj8 = obj7 + 1;
		object obj9 = obj8 / 7;
		object obj10 = obj9 * 7;
		object obj11 = obj8 - obj10;
		object obj12 = (object)key - obj11;
		object obj13 = obj12 + 7;
		object obj14 = obj13 / 7;
		object obj15 = obj14 * 7;
		object obj16 = obj13 - obj15;
		bool flag = obj16 == null;
		bool flag2 = !flag;
		object obj17 = obj16;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC87");
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v30 (Il2CppClass<System.DateTime>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v51 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = this;
			obj2 = obj5;
			obj3 = obj4;
			obj = obj2;
			object obj19 = obj3 & 0x3FFFFFFFFFFFFFFFL;
			object obj20 = obj & 0x3FFFFFFFFFFFFFFFL;
			object obj21;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
			{
				obj21 = 1;
			}
			else
			{
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20);
				object obj22 = (flag3 ? 1u : 0u) << 31;
				obj21 = obj22 >> 31;
			}
			object obj23 = obj21 >> 31;
			object obj24 = obj23 & -7;
			object obj25 = obj24 + 7;
			obj17 = obj25;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		DateTime result = default;
		return result;
	}

	public unsafe bool TryGetDateTime(string key, out DateTime result)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		short num4;
		bool result2;
		if (text != null)
		{
			nint num = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11 (Il2CppClass<System.BitConverter>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v18 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			short num3 = BitConverter.ToInt16((byte[])(object)text, 0);
			num4 = num3;
			result2 = true;
		}
		else
		{
			num4 = 0;
			result2 = false;
		}
		ref DateTime reference = ref *(DateTime*)num4;
		return result2;
	}

	public void SetDateTime(string key, DateTime value)
	{
		_dictionary = (IDictionary<string, byte[]>)(object)key;
	}

	public double GetDouble(string key)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0.0;
	}

	public unsafe bool TryGetDouble(string key, out double result)
	{
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0185: Expected Ref, but got VT
		//IL_00e2: Expected I, but got Obj
		//IL_0163: Expected I8, but got I4
		//IL_0054: Expected I, but got Obj
		ref short reference = ref *(short*)null;
		DateTime dateTime2;
		bool result2;
		if (TryGetInt16(key, out reference))
		{
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v10 (Il2CppClass<System.DateTime>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v15 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime dateTime = DateTime.FromBinaryRaw((long)reference);
			dateTime2 = dateTime;
			result2 = true;
		}
		else
		{
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v13 (Il2CppClass<System.DateTime>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v21 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			dateTime2 = DateTime.MinValue;
			result2 = false;
		}
		ref double reference2 = ref *(double*)dateTime2;
		return result2;
	}

	public void SetDouble(string key, double value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public int GetInt32(string key)
	{
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string value = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return BitConverter.ToInt16((byte[])(object)value, 0);
	}

	public unsafe bool TryGetInt32(string key, out int result)
	{
		//IL_00f0: Expected Ref, but got F8
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		double num3 = default;
		bool result2;
		if (text != null)
		{
			nint num = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<System.BitConverter>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v17 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num3 = ((bool*)text)->System_002EIConvertible_002EToDouble((IFormatProvider)null);
			result2 = true;
		}
		else
		{
			result2 = false;
		}
		ref int reference = ref *(int*)num3;
		return result2;
	}

	public void SetInt32(string key, int value)
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBA");
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v13 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E22C");
		Action callback = default;
		((ThreadPooling)this).RunAsync((Action<ThreadPooling.ProgressDelegate>)(object)key, callback);
	}

	public long GetInt64(string key)
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00a5: Expected I8, but got Obj
		//IL_00a9: Expected I8, but got VT
		//IL_0013: Expected I, but got Obj
		ArgumentNullException ex = new ArgumentNullException();
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (long)DateTime.FromBinaryRaw((long)ex);
	}

	public unsafe bool TryGetInt64(string key, out long result)
	{
		//IL_009c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		object obj2;
		bool result2;
		if (text != null)
		{
			nint num = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11 (Il2CppClass<System.BitConverter>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v18 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E234");
			object obj3 = default;
			obj2 = obj3;
			result2 = true;
		}
		else
		{
			obj2 = 0;
			result2 = false;
		}
		ref long reference = ref *(long*)obj2;
		return result2;
	}

	public void SetInt64(string key, long value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got Unknown
		//IL_06ca: Expected Obj, but got I4
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj6 = default;
		object obj5 = obj6;
		object obj8 = default;
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj9 = default;
		if (obj5 == obj9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj11 = default;
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj13 = default;
			object obj12 = obj13;
		}
		else
		{
			object obj12 = obj7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	public short GetInt16(string key)
	{
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E234");
		short result = default;
		return result;
	}

	public unsafe bool TryGetInt16(string key, out short result)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		NullReferenceException ex = default;
		bool result2;
		if (text != null)
		{
			nint num = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<System.BitConverter>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v17 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ex = new NullReferenceException();
			result2 = true;
		}
		else
		{
			result2 = false;
		}
		ref short reference = ref *(short*)ex;
		return result2;
	}

	public void SetInt16(string key, short value)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] bytes = BitConverter.GetBytes((ushort)value);
		((ThreadPooling)this).RunAsync((Action<ThreadPooling.ProgressDelegate>)(object)key, (Action)(object)bytes);
	}

	public float GetSingle(string key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = 0 - key;
		float num = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.ObfuscatedMemory)+2C]");
		return num * 0f;
	}

	public unsafe bool TryGetSingle(string key, out float result)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		int num4;
		bool result2;
		if (text != null)
		{
			nint num = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11 (Il2CppClass<System.BitConverter>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v18 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = BitConverter.ToInt32((byte[])(object)text, 0);
			num4 = num3;
			result2 = true;
		}
		else
		{
			num4 = 0;
			result2 = false;
		}
		ref float reference = ref *(float*)num4;
		return result2;
	}

	public unsafe void SetSingle(string key, float value)
	{
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_0424: Expected Obj, but got I4
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_0441: Expected Obj, but got I4
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_045e: Expected Obj, but got I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_047b: Expected Obj, but got I4
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected Obj, but got Unknown
		//IL_0498: Expected Obj, but got I4
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_04e6: Expected I, but got Obj
		//IL_04fc: Expected Obj, but got I
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected VT, but got Unknown
		//IL_06fc: Expected F4, but got Obj
		//IL_06f7: Expected native int or pointer, but got VT
		//IL_0711: Expected F4, but got I
		//IL_070c: Expected native int or pointer, but got VT
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected VT, but got Unknown
		//IL_072c: Expected F4, but got Obj
		//IL_0727: Expected native int or pointer, but got VT
		//IL_0741: Expected F4, but got I
		//IL_073c: Expected native int or pointer, but got VT
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected Obj, but got Unknown
		//IL_078c: Expected Obj, but got F4
		//IL_07a3: Expected native int or pointer, but got VT
		//IL_07b5: Expected native int or pointer, but got VT
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Expected Obj, but got Unknown
		//IL_07eb: Expected I, but got Obj
		//IL_0801: Expected Obj, but got I
		//IL_0533: Expected F4, but got I
		//IL_0013: Expected I, but got Obj
		//IL_013a: Expected F4, but got Obj
		//IL_0135: Expected native int or pointer, but got VT
		//IL_014f: Expected F4, but got I
		//IL_014a: Expected native int or pointer, but got VT
		//IL_015c: Expected F4, but got Obj
		//IL_0157: Expected native int or pointer, but got VT
		//IL_0171: Expected F4, but got I
		//IL_016c: Expected native int or pointer, but got VT
		//IL_017a: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got F4
		//IL_01a1: Expected Obj, but got F4
		//IL_0060: Expected I, but got Obj
		//IL_05b1: Expected I, but got Obj
		//IL_05c7: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_082b: Expected F4, but got Obj
		//IL_0826: Expected native int or pointer, but got VT
		//IL_0840: Expected F4, but got I
		//IL_083b: Expected native int or pointer, but got VT
		//IL_084d: Expected F4, but got Obj
		//IL_0848: Expected native int or pointer, but got VT
		//IL_0862: Expected F4, but got I
		//IL_085d: Expected native int or pointer, but got VT
		//IL_0895: Expected F4, but got Obj
		//IL_0890: Expected native int or pointer, but got VT
		//IL_08aa: Expected F4, but got I
		//IL_08a5: Expected native int or pointer, but got VT
		//IL_08da: Expected F4, but got Obj
		//IL_08d5: Expected native int or pointer, but got VT
		//IL_08e9: Expected F4, but got Obj
		//IL_08e4: Expected native int or pointer, but got VT
		//IL_08f6: Expected F4, but got Obj
		//IL_08f1: Expected native int or pointer, but got VT
		//IL_0908: Expected F4, but got I4
		//IL_0903: Expected native int or pointer, but got VT
		//IL_056a: Expected Obj, but got F4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_01ed: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_05f1: Expected F4, but got Obj
		//IL_05ec: Expected native int or pointer, but got VT
		//IL_0606: Expected F4, but got I
		//IL_0601: Expected native int or pointer, but got VT
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected Obj, but got Unknown
		//IL_0633: Expected F4, but got Obj
		//IL_062e: Expected native int or pointer, but got VT
		//IL_0648: Expected F4, but got I
		//IL_0643: Expected native int or pointer, but got VT
		//IL_0655: Expected F4, but got Obj
		//IL_0650: Expected native int or pointer, but got VT
		//IL_066a: Expected F4, but got I
		//IL_0665: Expected native int or pointer, but got VT
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected VT, but got Unknown
		//IL_0689: Expected Ref, but got VT
		//IL_0696: Expected F4, but got Obj
		//IL_0691: Expected native int or pointer, but got VT
		//IL_06ab: Expected F4, but got I
		//IL_06a6: Expected native int or pointer, but got VT
		//IL_06b8: Expected native int or pointer, but got VT
		//IL_06ca: Expected native int or pointer, but got VT
		//IL_06dc: Expected Ref, but got VT
		//IL_06dc: Expected Ref, but got VT
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_032a: Expected F4, but got Obj
		//IL_0325: Expected native int or pointer, but got VT
		//IL_033f: Expected F4, but got I
		//IL_033a: Expected native int or pointer, but got VT
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_036c: Expected F4, but got Obj
		//IL_0367: Expected native int or pointer, but got VT
		//IL_0381: Expected F4, but got I
		//IL_037c: Expected native int or pointer, but got VT
		//IL_038e: Expected F4, but got Obj
		//IL_0389: Expected native int or pointer, but got VT
		//IL_03a3: Expected F4, but got I
		//IL_039e: Expected native int or pointer, but got VT
		//IL_03b4: Expected Ref, but got VT
		//IL_02be: Expected I, but got Obj
		//IL_03c6: Expected F4, but got Obj
		//IL_03c1: Expected native int or pointer, but got VT
		//IL_03db: Expected F4, but got I
		//IL_03d6: Expected native int or pointer, but got VT
		//IL_03e8: Expected native int or pointer, but got VT
		//IL_03fa: Expected native int or pointer, but got VT
		//IL_040c: Expected Ref, but got VT
		//IL_040c: Expected Ref, but got VT
		Quaternion quaternion = default;
		object obj = quaternion + 192;
		obj = 0;
		_ = 0;
		object obj2 = quaternion + 180;
		obj2 = 0;
		_ = 0;
		object obj3 = quaternion + 168;
		obj3 = 0;
		_ = 0;
		object obj4 = quaternion + 156;
		obj4 = 0;
		_ = 0;
		object obj5 = quaternion + 144;
		obj5 = 0;
		_ = 0;
		object obj6 = quaternion + 132;
		obj6 = this;
		_ = _dictionary;
		object obj7 = quaternion + 120;
		obj7 = key;
		_ = key.m_stringLength;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v161 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(quaternion + 208);
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)(quaternion + 224);
		((Vector3*)(nint)vector3)->x = (float)obj7;
		Vector3 vector4 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj9 = quaternion + 108;
		Quaternion quaternion2 = Quaternion.FromToRotation(vector, vector3);
		obj4 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v41+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
		obj = vector3.x;
		_ = vector3.z;
		((Vector3*)(nint)vector)->x = vector3.x;
		((Vector3*)(nint)vector)->z = vector3.z;
		object obj10 = quaternion + 96;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S2_v25 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float x = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v55+8]");
		if (BaseInputModule.DetermineMoveDirection(x, 0f) != MoveDirection.Left)
		{
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v150 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v157 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Quaternion identity = Quaternion.identity;
			obj5 = vector3.x;
			_ = vector3.z;
		}
		else
		{
			((Vector3*)(nint)vector3)->x = (float)obj;
			Vector3 vector5 = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector6 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			obj6 = 0;
			_ = 0;
			obj6 = vector3.z;
			_ = 0f;
			object obj13 = 0f - vector.x;
			obj4 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11463");
			obj5 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27+8]");
			_ = 0;
		}
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
		_ = 0;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v58 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v127 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj7;
		Vector3 vector8 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		Vector3 vector9 = Vector3.Min(vector, vector3);
		obj2 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v41+8]");
		_ = 0;
		((Vector3*)(nint)vector3)->x = (float)obj;
		Vector3 vector10 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		Vector3 vector11 = vector3 / value;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v55+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)this;
		((Vector3*)(nint)vector)->z = (float)_dictionary;
		((Vector3*)(nint)vector3)->x = (float)key;
		((Vector3*)(nint)vector3)->z = key.m_stringLength;
		Gizmos.DrawWireCube(vector, vector3);
		object obj15 = quaternion + 84;
		obj15 = key;
		_ = key.m_stringLength;
		object obj16 = quaternion + 72;
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		nint num9 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v86 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num10 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v123 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector3)->x = (float)obj16;
		Vector3 vector12 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v83+8]");
		((Vector3*)(nint)vector12)->z = 0f;
		object obj18 = quaternion + 56;
		Vector2 vector13 = 25f * (Vector2)vector3;
		((Vector3*)(nint)vector)->x = (float)obj18;
		Vector3 vector14 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S0_v93+8]");
		((Vector3*)(nint)vector14)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Vector3 vector15 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector15)->z = 0f;
		Quaternion quaternion3 = (Quaternion)(quaternion + 44);
		((Quaternion*)quaternion3)->SetLookRotation(vector, vector3);
		((Vector3*)(nint)vector)->x = (float)obj15;
		Vector3 vector16 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v80+8]");
		((Vector3*)(nint)vector16)->z = 0f;
		((Vector3*)(nint)vector3)->x = quaternion3.x;
		((Vector3*)(nint)vector3)->z = quaternion3.z;
		Gizmos.DrawLine_Injected(ref *(Vector3*)vector, ref *(Vector3*)vector3);
		object obj19 = quaternion + 32;
		obj19 = key;
		_ = key.m_stringLength;
		((Vector3*)(nint)vector3)->x = (float)obj2;
		Vector3 vector17 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector17)->z = 0f;
		object obj20 = quaternion + 16;
		Vector2 vector18 = -25f * (Vector2)vector3;
		((Vector3*)(nint)vector)->x = (float)obj20;
		Vector3 vector19 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v111+8]");
		((Vector3*)(nint)vector19)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Vector3 vector20 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector20)->z = 0f;
		((Quaternion*)quaternion)->SetLookRotation(vector, vector3);
		((Vector3*)(nint)vector)->x = (float)obj19;
		Vector3 vector21 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v106+8]");
		((Vector3*)(nint)vector21)->z = 0f;
		((Vector3*)(nint)vector3)->x = quaternion.x;
		((Vector3*)(nint)vector3)->z = quaternion.z;
		Gizmos.DrawLine_Injected(ref *(Vector3*)vector, ref *(Vector3*)vector3);
	}

	public string GetString(string key)
	{
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		string value = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)BitConverter.ToInt32((byte[])(object)value, 0);
	}

	public unsafe bool TryGetString(string key, out string result)
	{
		//IL_00f0: Expected Ref, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		float num3 = default;
		bool result2;
		if (text != null)
		{
			nint num = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<System.BitConverter>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v17 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num3 = ((bool*)text)->System_002EIConvertible_002EToSingle((IFormatProvider)null);
			result2 = true;
		}
		else
		{
			result2 = false;
		}
		ref string reference = ref *(string*)num3;
		return result2;
	}

	public void SetString(string key, string value)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] bytes = BitConverter.GetBytes((int)value);
		((ThreadPooling)this).RunAsync((Action<ThreadPooling.ProgressDelegate>)(object)key, (Action)(object)bytes);
	}

	public uint GetUInt32(string key)
	{
		Encoding uTF = Encoding.UTF32;
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		uint result = default;
		return result;
	}

	public unsafe bool TryGetUInt32(string key, out uint result)
	{
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		ref uint reference;
		if (text != null)
		{
			Encoding uTF = Encoding.UTF32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			object obj = default;
			reference = ref *(uint*)obj;
			return true;
		}
		reference = ref *(uint*)null;
		return false;
	}

	public void SetUInt32(string key, uint value)
	{
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		Action callback = default;
		((ThreadPooling)this).RunAsync((Action<ThreadPooling.ProgressDelegate>)(object)key, callback);
	}

	public ulong GetUInt64(string key)
	{
		//IL_0005: Expected I, but got Obj
		//IL_001b: Expected Obj, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I4
		//IL_006a: Expected I8, but got I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I
		//IL_00cf: Expected I8, but got I4
		//IL_021b: Expected Obj, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_027b: Expected I, but got Obj
		//IL_0281: Expected I8, but got I4
		//IL_0205: Expected I8, but got I4
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S1_v2 (Il2CppClass<Kiloo.Common.Utility.ObfuscatedMemory>)+98]");
		object obj = (nint)0 & (nint)0xFFF;
		object obj2 = obj + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v8 @ S1_v5 (should have been resolved before IL gen)");
		object obj3 = default;
		nint num2;
		if (obj3 == null)
		{
			num2 = 0;
			return 8uL;
		}
		object obj4 = this + 164;
		object obj5 = obj4 + 16;
		object obj6 = obj5 + obj5;
		if (obj5 == null)
		{
			obj6 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @327");
		object obj7 = default;
		if ((nint)obj7 == -1)
		{
			num2 = 0;
			return 4uL;
		}
		object obj8 = obj4 + 16;
		object obj9 = obj8 + obj8;
		object obj10 = obj9 + 4;
		object obj11 = obj10 + obj10;
		object obj12 = obj7 * 12;
		object obj13 = obj11 + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22+4]");
		object obj14 = -4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22+4]");
		if ((nint)0 != 4 && ((nint)obj14 == 1 || (nint)obj14 == 2 || (nint)obj14 == 3 || (nint)obj14 == 4 || (nint)obj14 != 5))
		{
			num2 = 0;
			return 2uL;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.ObfuscatedMemory)+AC]");
		object obj15 = (nint)0 + (nint)16;
		object obj16 = obj15 + obj15;
		object obj17 = obj16 + 44;
		object obj18 = obj17 + obj17;
		object obj19 = obj7 * 12;
		object obj20 = obj11 + obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S2_v9+8]");
		object obj21 = obj18 + 0;
		num2 = (nint)obj21;
		return 1uL;
	}

	public unsafe bool TryGetUInt64(string key, out ulong result)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		string text3;
		bool result2;
		if (text != null)
		{
			nint num = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11 (Il2CppClass<System.BitConverter>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v18 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = ((bool*)text)->ToString(null);
			text3 = text2;
			result2 = true;
		}
		else
		{
			text3 = null;
			result2 = false;
		}
		ref ulong reference = ref *(ulong*)text3;
		return result2;
	}

	public unsafe void SetUInt64(string key, ulong value)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I8
		//IL_01fd: Expected Obj, but got I
		//IL_049f: Expected I, but got Obj
		//IL_04b5: Expected Obj, but got I
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0236: Expected Obj, but got I4
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_0172: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I8
		//IL_00b6: Expected Obj, but got I4
		//IL_0325: Expected Obj, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0355: Expected Obj, but got I
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_0388: Expected Obj, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_0303: Expected Obj, but got I
		//IL_0483: Expected Obj, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_0102: Expected I8, but got I4
		//IL_03a3: Expected Obj, but got I4
		object obj = this + 212;
		bool flag = obj == null;
		object obj2 = 212;
		IntPtr intPtr = default;
		if (!flag)
		{
			object obj3 = this + 164;
			object obj4 = obj3 + 16;
			object obj5 = obj4 + obj4;
			bool flag2 = (nint)obj5 > 0;
			bool flag3 = !flag2;
			object obj6 = obj4;
			object obj7 = obj5;
			object obj8 = obj3;
			object obj9 = obj;
			if (!flag3)
			{
				object obj10 = value + 4;
				object obj11 = 0;
				object obj12 = obj;
				while (true)
				{
					object obj13 = obj11 << 2;
					object obj14 = obj12 + obj13;
					if ((nint)obj14 != -1)
					{
						object obj15 = obj10 + 28;
						object obj16 = obj15 + obj15;
						object obj17 = obj16 + obj14;
						obj17 = 1;
						((ulong*)value)->m_value = 1uL;
					}
					object obj18 = obj11 + 1;
					if (obj18 == obj5)
					{
						break;
					}
					obj11 = obj18;
					obj12 = obj;
				}
				object obj19 = obj3 + 16;
				object obj20 = obj19 + obj19;
				obj6 = obj19;
				obj7 = obj20;
				obj8 = obj3;
				obj9 = obj;
			}
			object obj21 = obj8 + 20;
			object obj22 = obj21 + obj21;
			if (obj6 != null)
			{
				object obj23 = obj7;
			}
			else
			{
				object obj23 = 0;
			}
			if (obj21 != null)
			{
				obj2 = obj22;
			}
			else
			{
				obj2 = 0;
			}
			object obj24 = (nint)intPtr;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @439");
		}
		object obj26 = ((ulong*)value)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L2 (System.UInt64)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L2 (System.UInt64)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L2 (System.UInt64)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L2 (System.UInt64)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L2 (System.UInt64)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.ObfuscatedMemory)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.ObfuscatedMemory)+18]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v9+18]");
		if ((nint)0 > (nint)0)
		{
			object obj28 = 0;
			object obj29 = default;
			bool flag4;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @356");
				if (obj29 != null)
				{
					object obj30 = obj29 - -64;
					object obj31 = obj30 & 0x1FFF;
					object obj25 = obj31 + 113696;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S4_v6 (should have been resolved before IL gen)");
				}
				object obj32 = obj28 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v9+18]");
				flag4 = obj32 != null;
				obj28 = obj32;
			}
			while (flag4);
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v24 (Il2CppClass<Kiloo.Common.Utility.ObfuscatedMemory>)+98]");
		object obj33 = (nint)0 & (nint)0xFFF;
		object obj34 = obj33 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v151 @ S1_v27 (should have been resolved before IL gen)");
		object obj35 = default;
		if (obj35 == null)
		{
			return;
		}
		object obj36 = this + 172;
		object obj37 = obj36;
		if (obj37 != null)
		{
			object obj38 = obj37 + 4;
			object obj39 = obj38 + obj38;
			object obj40 = obj39 + obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v43+6D]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L2 (System.UInt64)+8]");
				object obj41 = 0;
				_ = -1;
			}
		}
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.ObfuscatedMemory)+A4]");
			object obj42 = (nint)0 + (nint)16;
			object obj43 = obj42 + obj42;
			object obj44 = obj36 + 16;
			object obj45 = obj44 + obj44;
			object obj46 = (nint)intPtr;
			if (obj42 != null)
			{
				object obj47 = obj43;
			}
			else
			{
				object obj47 = 0;
			}
			if (obj44 != null)
			{
				object obj48 = obj45;
			}
			else
			{
				object obj48 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @43C");
		}
	}

	public unsafe ushort GetUInt16(string key)
	{
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (ushort)(int)((bool*)text)->ToString(null);
	}

	public unsafe bool TryGetUInt16(string key, out ushort result)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		string text = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		long num3 = default;
		bool result2;
		if (text != null)
		{
			nint num = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<System.BitConverter>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v17 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num3 = ((bool*)text)->System_002EIConvertible_002EToInt64((IFormatProvider)null);
			result2 = true;
		}
		else
		{
			result2 = false;
		}
		ref ushort reference = ref *(ushort*)num3;
		return result2;
	}

	public void SetUInt16(string key, ushort value)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		char hexValue = BitConverter.GetHexValue((int)value);
		((ThreadPooling)this).RunAsync((Action<ThreadPooling.ProgressDelegate>)(object)key, (Action)hexValue);
	}

	public byte[] GetBuffer(string key)
	{
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		string value = PathHandling.RelativeToAbsolutePath((string)(object)this, key);
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte[])BitConverter.ToUInt32((byte[])(object)value, 0);
	}

	public void SetBuffer(string key, byte[] value)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.BitConverter>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] bytes = BitConverter.GetBytes((uint)(int)value);
		((ThreadPooling)this).RunAsync((Action<ThreadPooling.ProgressDelegate>)(object)key, (Action)(object)bytes);
	}

	public ObfuscatedMemory()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[JsonFileSaver] ", (int)this);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
	}
}
