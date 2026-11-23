using System;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsPrimitiveConverter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_007d: Expected I, but got Obj
		//IL_0014: Expected VT, but got Obj
		//IL_0051: Expected VT, but got Obj
		nint num = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v3 (Il2CppClass<System.Type>)+30C] (should have been resolved before IL gen)");
		bool result = true;
		object obj = default;
		if (obj == null)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
			bool flag = (object)typeFromHandle == type;
			result = true;
			if (!flag)
			{
				Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(decimal));
				bool flag2 = (object)typeFromHandle2 == type;
				result = flag2;
			}
		}
		return result;
	}

	public override bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	public override bool RequestInheritanceSupport(Type storageType)
	{
		return false;
	}

	private static bool UseBool(Type type)
	{
		//IL_0014: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(bool));
		return (object)typeFromHandle == type;
	}

	private static bool UseInt64(Type type)
	{
		//IL_01b5: Expected VT, but got Obj
		//IL_0014: Expected VT, but got Obj
		//IL_0051: Expected VT, but got Obj
		//IL_008e: Expected VT, but got Obj
		//IL_00cb: Expected VT, but got Obj
		//IL_0108: Expected VT, but got Obj
		//IL_0145: Expected VT, but got Obj
		//IL_0182: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(sbyte));
		bool flag = (object)typeFromHandle == type;
		bool result = true;
		if (!flag)
		{
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(byte));
			bool flag2 = (object)typeFromHandle2 == type;
			result = true;
			if (!flag2)
			{
				Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(short));
				bool flag3 = (object)typeFromHandle3 == type;
				result = true;
				if (!flag3)
				{
					Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ushort));
					bool flag4 = (object)typeFromHandle4 == type;
					result = true;
					if (!flag4)
					{
						Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(int));
						bool flag5 = (object)typeFromHandle5 == type;
						result = true;
						if (!flag5)
						{
							Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(uint));
							bool flag6 = (object)typeFromHandle6 == type;
							result = true;
							if (!flag6)
							{
								Type typeFromHandle7 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(long));
								bool flag7 = (object)typeFromHandle7 == type;
								result = true;
								if (!flag7)
								{
									Type typeFromHandle8 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ulong));
									bool flag8 = (object)typeFromHandle8 == type;
									result = flag8;
								}
							}
						}
					}
				}
			}
		}
		return result;
	}

	private static bool UseDouble(Type type)
	{
		//IL_0084: Expected VT, but got Obj
		//IL_0014: Expected VT, but got Obj
		//IL_0051: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(float));
		bool flag = (object)typeFromHandle == type;
		bool result = true;
		if (!flag)
		{
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(double));
			bool flag2 = (object)typeFromHandle2 == type;
			result = true;
			if (!flag2)
			{
				Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(decimal));
				bool flag3 = (object)typeFromHandle3 == type;
				result = flag3;
			}
		}
		return result;
	}

	private static bool UseString(Type type)
	{
		//IL_004d: Expected VT, but got Obj
		//IL_0022: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
		if ((object)typeFromHandle == type)
		{
			return true;
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(char));
		return (object)typeFromHandle2 == type;
	}

	public unsafe override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0022: Expected VT, but got Obj
		//IL_017c: Expected VT, but got Obj
		//IL_009b: Expected VT, but got Obj
		//IL_0064: Expected VT, but got Obj
		//IL_03cc: Expected VT, but got Obj
		//IL_0217: Expected VT, but got Obj
		//IL_0340: Expected VT, but got Obj
		//IL_00e4: Expected I4, but got VT
		//IL_00df: Expected native int or pointer, but got VT
		//IL_047b: Expected native int or pointer, but got VT
		//IL_0415: Expected I4, but got VT
		//IL_0410: Expected native int or pointer, but got VT
		object obj = default;
		decimal num = obj - 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		fsSerializer serializer = Serializer;
		fsConfig config = serializer.Config;
		if (~(config.Serialize64BitIntegerAsString ? 1u : 0u) != 0)
		{
			goto IL_00e9;
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(long));
		Type type = default;
		if ((object)typeFromHandle != type)
		{
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ulong));
			if ((object)typeFromHandle2 != type)
			{
				goto IL_00e9;
			}
		}
		Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
		object obj2 = Convert.ChangeType(instance, typeFromHandle3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		object obj3 = default;
		ref fsData reference = ref *(fsData*)obj3;
		fsResult fsResult2 = default;
		((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		goto IL_04c2;
		IL_00e9:
		if (UseBool(type))
		{
			throw new NullReferenceException();
		}
		if (UseInt64(type))
		{
			Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(long));
			object obj4 = Convert.ChangeType(instance, typeFromHandle4);
			throw new NullReferenceException();
		}
		if (UseDouble(type))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(float));
			object obj5 = default;
			if (typeFromHandle5 == obj5)
			{
				throw new NullReferenceException();
			}
			Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(double));
			object obj6 = Convert.ChangeType(instance, typeFromHandle6);
			throw new NullReferenceException();
		}
		if (UseString(type))
		{
			Type typeFromHandle7 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
			object obj7 = Convert.ChangeType(instance, typeFromHandle7);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			object obj8 = default;
			reference = ref *(fsData*)obj8;
			((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		}
		else
		{
			reference = ref *(fsData*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj9 = default;
			string text = default;
			if (obj9 != null)
			{
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v265 @ S2_v6+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text = null;
			}
			string warning = "Unhandled primitive type " + text;
			fsResult fsResult3 = fsResult.Fail(warning);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Decimal)+20]");
			((fsResult*)(nint)fsResult2)->_success = false;
		}
		goto IL_04c2;
		IL_04c2:
		return fsResult2;
	}

	public unsafe override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected VT, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected VT, but got Unknown
		//IL_0094: Expected Obj, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_05fd: Expected native int or pointer, but got VT
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0308: Expected I4, but got VT
		//IL_0303: Expected native int or pointer, but got VT
		//IL_058e: Expected I, but got Obj
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected VT, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected VT, but got Unknown
		//IL_0510: Expected Obj, but got I
		//IL_0260: Expected VT, but got Obj
		//IL_05b7: Expected native int or pointer, but got VT
		//IL_0646: Expected native int or pointer, but got VT
		//IL_02a2: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		fsResult fsResult6 = default;
		if (UseBool(storageType))
		{
			fsResult fsResult2 = CheckType(storage, fsDataType.Boolean);
			_ = fsResult.Success;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			_ = fsResult.Success;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			fsResult fsResult3 = (fsResult)(obj + 16);
			fsResult fsResult4 = (fsResult)(obj + 8);
			fsResult fsResult5 = fsResult3 + fsResult4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			object obj3 = (nint)0 & (nint)0xFF;
			if (obj3 != null)
			{
				bool asBool = storage.AsBool;
				object obj4 = obj + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj5 = default;
				ref object reference = ref *(object*)obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			((fsResult*)(nint)fsResult6)->_success = false;
		}
		else if (UseDouble(storageType) || UseInt64(storageType))
		{
			string asString = default;
			if (storage.IsDouble)
			{
				double asDouble = storage.AsDouble;
				object obj6 = obj + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			}
			else if (storage.IsInt64)
			{
				long asInt = storage.AsInt64;
				object obj7 = obj + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			}
			else
			{
				fsSerializer serializer = Serializer;
				fsConfig config = serializer.Config;
				if (~(config.Serialize64BitIntegerAsString ? 1u : 0u) != 0 || !storage.IsString)
				{
					goto IL_030d;
				}
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(long));
				if ((object)typeFromHandle != storageType)
				{
					Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ulong));
					if ((object)typeFromHandle2 != storageType)
					{
						goto IL_030d;
					}
				}
				asString = storage.AsString;
			}
			object obj8 = Convert.ChangeType(asString, storageType);
			ref object reference = ref *(object*)obj8;
			((fsResult*)(nint)fsResult6)->_success = (byte)(int)fsResult.Success != 0;
		}
		else if (UseString(storageType))
		{
			fsResult fsResult7 = CheckType(storage, fsDataType.String);
			_ = fsResult.Success;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			_ = fsResult.Success;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			fsResult fsResult8 = (fsResult)(obj + 32);
			fsResult fsResult9 = (fsResult)(obj + 24);
			fsResult fsResult10 = fsResult8 + fsResult9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			object obj9 = (nint)0 & (nint)0xFF;
			if (obj9 != null)
			{
				string asString2 = storage.AsString;
				ref object reference = ref *(object*)asString2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			((fsResult*)(nint)fsResult6)->_success = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj11 = default;
			object obj10 = obj11 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v212 @ S1_v73+BC] (should have been resolved before IL gen)");
			string text = default;
			if ((object)storage != null)
			{
				nint num = (nint)storage;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ S3_v12 (Il2CppClass<FullSerializer.fsData>)+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text = null;
			}
			string text2 = default;
			string warning = text2 + ": Bad data; expected bool, number, string, but got " + text;
			fsResult fsResult11 = fsResult.Fail(warning);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			((fsResult*)(nint)fsResult6)->_success = false;
		}
		return fsResult6;
		IL_030d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		object obj13 = default;
		object obj12 = obj13 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v304 @ S2_v6+BC] (should have been resolved before IL gen)");
		throw new ArrayTypeMismatchException();
	}
}
