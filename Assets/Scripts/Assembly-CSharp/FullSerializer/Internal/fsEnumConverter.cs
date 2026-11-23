using System;
using System.Collections;
using System.Text;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsEnumConverter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 560;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v3 (Il2CppClass<System.Type>)+2EC] (should have been resolved before IL gen)");
		bool result = default;
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

	public override object CreateInstance(fsData data, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object value = default;
		return Enum.ToObject(storageType, value);
	}

	public unsafe override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_056c: Expected I4, but got VT
		//IL_0567: Expected native int or pointer, but got VT
		//IL_0579: Expected VT, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_0419: Expected I, but got Obj
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_0491: Expected VT, but got I
		//IL_0517: Expected VT, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected I8, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0351: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		fsSerializer serializer = Serializer;
		fsConfig config = serializer.Config;
		object value = default;
		fsData fsData3;
		Type type = default;
		fsResult fsResult2 = default;
		if (~(config.SerializeEnumsAsInteger ? 1u : 0u) == 0)
		{
			long i = Convert.ToInt64(value);
			fsData fsData2 = default;
			fsData2._002Ector(i);
			fsData3 = fsData2;
		}
		else
		{
			FlagsAttribute attribute = fsPortableReflection.GetAttribute<FlagsAttribute>(type);
			if (attribute == null)
			{
				goto IL_0579;
			}
			long num = Convert.ToInt64(value);
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector();
			Array values = Enum.GetValues(type);
			IEnumerator enumerator = values.GetEnumerator();
			object obj3 = obj + 24;
			object obj4 = obj + 28;
			obj = obj4;
			_ = 0;
			type = (Type)1;
			object obj5 = default;
			object obj6 = default;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			object obj11 = default;
			fsData fsData4 = default;
			object value2 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj5 == null)
					{
						goto IL_03f9;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								long num2 = num & obj6;
								if (num2 == 0)
								{
									continue;
								}
								object obj7 = type & 1;
								if (obj7 == null)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										type = (Type)0;
										goto IL_036a;
									}
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag = (nint)0 != 1;
									type = null;
									if (flag)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									type = null;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									type = (Type)0;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_036a;
				IL_036a:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj8 != obj9;
				value = obj10;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_03f9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					value = obj11;
				}
				_ = 0;
				object obj12 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				fsResult2 = (fsResult)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_04bc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				return (fsResult)0;
				IL_03f9:
				object obj13 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @25E");
				nint num3 = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v254 @ S1_v37 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
				fsData4._value = value2;
				fsData3 = fsData4;
				break;
			}
		}
		goto IL_0556;
		IL_0556:
		ref fsData reference = ref *(fsData*)fsData3;
		((fsResult*)(nint)fsResult2)->_success = (byte)(int)fsResult.Success != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		return (fsResult)0;
		IL_0579:
		string name = Enum.GetName(type, value);
		fsData fsData5 = default;
		fsData5._value = name;
		fsData3 = fsData5;
		goto IL_0556;
		IL_04bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0579;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0269: Expected native int or pointer, but got VT
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_0241: Expected I4, but got VT
		//IL_023c: Expected native int or pointer, but got VT
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_01bb: Expected I4, but got VT
		//IL_01b6: Expected native int or pointer, but got VT
		//IL_00a8: Expected VT, but got I
		//IL_00da: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I
		//IL_0164: Expected I, but got Obj
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_00f2: Expected VT, but got Obj
		//IL_019b: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		fsResult fsResult3 = default;
		if (data.IsString)
		{
			string asString = data.AsString;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			char[] array = default;
			array[0] = ',';
			string[] array2 = asString.Split(array, StringSplitOptions.RemoveEmptyEntries);
			object obj3 = 0;
			if (array2.Length > (nint)obj3)
			{
				object obj4 = obj3 << 2;
				object obj5 = (object)array2 + obj4;
				string[] names = Enum.GetNames(storageType);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v52+10]");
				if (ArrayContains<T>((T[])(object)names, (T)0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v52+10]");
					object value = Enum.Parse(storageType, (string)0);
					Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(long));
					object obj6 = Convert.ChangeType(value, typeFromHandle);
					throw new NullReferenceException();
				}
				string text = default;
				if ((object)storageType != null)
				{
					nint num = (nint)storageType;
					object obj7 = storageType + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ S4_v5 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
				}
				else
				{
					text = null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v52+10]");
				string warning = "Cannot find enum name " + (string)0 + " on type " + text;
				fsResult fsResult2 = fsResult.Fail(warning);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((fsResult*)(nint)fsResult3)->_success = false;
			}
			else
			{
				object obj8 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object value2 = default;
				object obj9 = Enum.ToObject(storageType, value2);
				ref object reference = ref *(object*)obj9;
				((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
			}
		}
		else if (data.IsInt64)
		{
			long asInt = data.AsInt64;
			object obj10 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value3 = default;
			object obj11 = Enum.ToObject(storageType, value3);
			ref object reference = ref *(object*)obj11;
			((fsResult*)(nint)fsResult3)->_success = (byte)(int)fsResult.Success != 0;
		}
		else
		{
			fsResult fsResult4 = fsResult.Fail("EnumConverter encountered an unknown JSON data type");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((fsResult*)(nint)fsResult3)->_success = false;
		}
		return fsResult3;
	}

	private static bool ArrayContains<T>(T[] values, T value)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		bool flag;
		object obj = default;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		while (true)
		{
			flag = (nint)obj < values.Length;
			if (!flag)
			{
				break;
			}
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S1_v7 (Il2CppClass<Il2CppMethodRgctx<FullSerializer.Internal.fsEnumConverter::ArrayContains>>)+4] (should have been resolved before IL gen)");
			object obj2 = obj << 2;
			object obj3 = (object)values + obj2;
			object obj4 = obj5 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S3_v6+BC] (should have been resolved before IL gen)");
			if (obj6 != null)
			{
				break;
			}
			obj = obj7 + 1;
		}
		return flag;
	}
}
