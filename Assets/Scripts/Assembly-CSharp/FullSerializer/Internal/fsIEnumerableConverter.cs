using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsIEnumerableConverter : fsConverter
{
	public override bool CanProcess(Type type)
	{
		//IL_0043: Expected VT, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IEnumerable));
		nint num = (nint)typeFromHandle;
		object obj = typeFromHandle + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S2_v2 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null)
		{
			MethodInfo addMethod = GetAddMethod(type);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
			bool result = default;
			return result;
		}
		return false;
	}

	public override object CreateInstance(fsData data, Type storageType)
	{
		fsSerializer serializer = Serializer;
		fsMetaType fsMetaType2 = fsMetaType.Get(serializer.Config, storageType);
		return fsMetaType2.CreateInstance();
	}

	public unsafe override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03eb: Expected native int or pointer, but got VT
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_048b: Expected VT, but got I
		//IL_01bb: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		object obj = default;
		fsIEnumerableConverter fsIEnumerableConverter2 = (fsIEnumerableConverter)(obj + -64);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		_ = fsResult.Success;
		Type elementType = GetElementType(storageType);
		IEnumerable collection = default;
		int capacity = HintSize(collection);
		fsData fsData2 = fsData.CreateList(capacity);
		ref fsData reference = ref *(fsData*)fsData2;
		List<fsData> asList = serialized.AsList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj2 = fsIEnumerableConverter2 + 36;
		object obj3 = fsIEnumerableConverter2 + 52;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsIEnumerableConverter)+10]");
		_ = 0;
		object obj4 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		Type type = default;
		fsResult fsResult2 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj4 == null)
				{
					goto IL_037c;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj5 = fsIEnumerableConverter2 + 16;
					object obj6 = fsIEnumerableConverter2 + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsIEnumerableConverter)+10]");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							fsIEnumerableConverter fsIEnumerableConverter3 = fsIEnumerableConverter2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsIEnumerableConverter)+10]");
							fsIEnumerableConverter3.Serializer = (fsSerializer)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsIEnumerableConverter)+10]");
							fsIEnumerableConverter2 = (fsIEnumerableConverter)0;
							object obj7 = fsIEnumerableConverter2 + 56;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsIEnumerableConverter)+28]");
								bool flag = (nint)0 == 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (flag)
									{
										continue;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								goto IL_02ed;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
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
			goto IL_02ed;
			IL_02ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 != obj9;
			object obj10 = obj11;
			if (flag2)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_037c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_037c:
			object obj13 = fsIEnumerableConverter2 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @25E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			if (fsIEnumerableConverter2.IsStack(type))
			{
				asList.Reverse();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.Internal.fsIEnumerableConverter)+38]");
			((fsResult*)(nint)fsResult2)->_success = false;
			return fsResult2;
		}
		_ = 0;
		object obj14 = fsIEnumerableConverter2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		return (fsResult)0;
	}

	private bool IsStack(Type type)
	{
		//IL_0066: Expected I, but got Obj
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0039: Expected VT, but got Obj
		nint num = (nint)type;
		object obj = type + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v3 (Il2CppClass<System.Type>)+1FC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null)
		{
			nint num2 = (nint)type;
			object obj3 = type + 384;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S1_v8 (Il2CppClass<System.Type>)+23C] (should have been resolved before IL gen)");
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Stack<>));
			object obj4 = default;
			return typeFromHandle == obj4;
		}
		return false;
	}

	public unsafe override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_00b3: Expected native int or pointer, but got VT
		//IL_034f: Expected native int or pointer, but got VT
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Ref, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected VT, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected VT, but got Unknown
		//IL_0417: Expected Ref, but got VT
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		_ = fsResult.Success;
		fsData fsData2 = default;
		fsResult fsResult2 = CheckType(fsData2, fsDataType.Array);
		_ = fsResult.Success;
		_ = fsResult.Success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		fsResult fsResult3 = (fsResult)(obj + 24);
		fsResult fsResult4 = (fsResult)(obj + 16);
		fsResult fsResult5 = fsResult3 + fsResult4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		fsResult fsResult6 = default;
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			((fsResult*)(nint)fsResult6)->_success = false;
		}
		else
		{
			Type elementType = GetElementType(storageType);
			MethodInfo addMethod = GetAddMethod(storageType);
			MethodInfo flattenedMethod = fsPortableReflection.GetFlattenedMethod(storageType, "get_Item");
			MethodInfo flattenedMethod2 = fsPortableReflection.GetFlattenedMethod(storageType, "set_Item");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
			object obj3 = default;
			object instance = default;
			if (obj3 != null)
			{
				TryClear(storageType, instance);
			}
			int num = TryGetExistingSize(storageType, instance);
			List<fsData> asList = fsData2.AsList;
			int num2 = 0;
			object obj4 = default;
			object obj7 = default;
			while (num2 < asList._size)
			{
				fsData data2 = asList.get_Item(num2);
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
				if (obj4 != null && num2 < num)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					object obj5 = obj + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					throw new ArrayTypeMismatchException();
				}
				fsResult fsResult7 = Serializer.TryDeserialize(data2, elementType, ref *(object*)(obj + 76));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				_ = 0;
				fsResult fsResult8 = (fsResult)(obj + 88);
				fsResult result = (fsResult)(obj + 8);
				((fsResult*)fsResult8)->AddMessages(result);
				object obj6 = obj - -64;
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
					if (obj7 != null && num2 < num)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						object obj8 = obj + 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					throw new ArrayTypeMismatchException();
				}
				int num3 = num2 + 1;
				num2 = num3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			((fsResult*)(nint)fsResult6)->_success = false;
		}
		return fsResult6;
	}

	private static int HintSize(IEnumerable collection)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
		return 0;
	}

	private static Type GetElementType(Type objectType)
	{
		//IL_00a6: Expected I, but got Obj
		//IL_002b: Expected VT, but got Obj
		//IL_000d: Expected I, but got Obj
		//IL_0090: Expected VT, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		nint num = (nint)objectType;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<System.Type>)+224] (should have been resolved before IL gen)");
		object obj = default;
		if (obj != null)
		{
			nint num2 = (nint)objectType;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v12 (Il2CppClass<System.Type>)+22C] (should have been resolved before IL gen)");
			Type result = default;
			return result;
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IEnumerable<>));
		Type type = fsReflectionUtility.GetInterface(objectType, typeFromHandle);
		if ((object)type != null)
		{
			nint num3 = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S1_v9 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v20+10]");
			return (Type)0;
		}
		return Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(object));
	}

	private static void TryClear(Type type, object instance)
	{
		//IL_002a: Expected I, but got Obj
		MethodInfo flattenedMethod = fsPortableReflection.GetFlattenedMethod(type, "Clear");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		object obj = default;
		if (obj != null)
		{
			nint num = (nint)flattenedMethod;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S6_v3 (Il2CppClass<System.Reflection.MethodInfo>)+1BC] (should have been resolved before IL gen)");
		}
	}

	private static int TryGetExistingSize(Type type, object instance)
	{
		//IL_002a: Expected I, but got Obj
		PropertyInfo flattenedProperty = fsPortableReflection.GetFlattenedProperty(type, "Count");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		object obj = default;
		if (obj != null)
		{
			nint num = (nint)flattenedProperty;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S2_v5 (Il2CppClass<System.Reflection.PropertyInfo>)+174] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S6_v3+1BC] (should have been resolved before IL gen)");
			throw new NullReferenceException();
		}
		return 0;
	}

	private static MethodInfo GetAddMethod(Type type)
	{
		//IL_00e6: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ICollection<>));
		Type type2 = fsReflectionUtility.GetInterface(type, typeFromHandle);
		MethodInfo result;
		if ((object)type2 != null)
		{
			MethodInfo declaredMethod = fsPortableReflection.GetDeclaredMethod(type2, "Add");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
			result = declaredMethod;
			object obj = default;
			if (obj != null)
			{
				goto IL_0100;
			}
		}
		MethodInfo flattenedMethod = fsPortableReflection.GetFlattenedMethod(type, "Add");
		result = flattenedMethod;
		if ((object)flattenedMethod == null)
		{
			MethodInfo flattenedMethod2 = fsPortableReflection.GetFlattenedMethod(type, "Push");
			result = flattenedMethod2;
			if ((object)flattenedMethod2 == null)
			{
				MethodInfo flattenedMethod3 = fsPortableReflection.GetFlattenedMethod(type, "Enqueue");
				result = flattenedMethod3;
			}
		}
		goto IL_0100;
		IL_0100:
		return result;
	}
}
