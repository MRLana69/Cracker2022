using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Json.Internal;

public static class JsonReflectionParser
{
	public static string DateTimeFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFF'Z'";

	public static string DateTimeFormatString2 = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'";

	public static T Deserialize<T>(object json, JsonContext context = null)
	{
		//IL_0042: Expected VT, but got I
		JsonContext jsonContext = default;
		JsonContext jsonContext2 = default;
		if (jsonContext == null)
		{
			jsonContext2._002Ector();
		}
		int nestedDeserializeCounter = jsonContext2.nestedDeserializeCounter + 1;
		jsonContext2.nestedDeserializeCounter = nestedDeserializeCounter;
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		object obj = RecursiveReadValue(typeFromHandle, json, jsonContext2);
		jsonContext2.EndDeserialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		T result = default;
		return result;
	}

	public static object Serialize<T>(T obj, JsonContext context = null)
	{
		//IL_0038: Expected VT, but got I
		//IL_0053: Expected Obj, but got VT
		JsonContext jsonContext = default;
		JsonContext jsonContext2 = default;
		if (jsonContext == null)
		{
			jsonContext2._002Ector();
		}
		jsonContext2.BeginSerialize();
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v10 (Il2CppMethodRgctx<SYBO.Components.Json.Internal.JsonReflectionParser::Serialize>)+4]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		object result = RecursiveWriteValue(obj, typeFromHandle, null, jsonContext2);
		jsonContext2.EndSerialize();
		return result;
	}

	public static object ReadReference(Type type, object value, JsonContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Expected VT, but got Obj
		//IL_0033: Expected I, but got Obj
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0861: Expected I, but got Obj
		//IL_0921: Expected I, but got Obj
		//IL_02e6: Expected I, but got Obj
		//IL_02ff: Expected VT, but got Obj
		//IL_08b3: Expected VT, but got Obj
		//IL_07ab: Expected I, but got Obj
		//IL_0783: Expected Obj, but got I
		//IL_00a8: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I4
		//IL_0363: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_0384: Expected I, but got Obj
		//IL_0396: Expected I, but got Obj
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected Obj, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected Obj, but got Unknown
		//IL_072a: Expected Obj, but got I
		//IL_0438: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = default;
		Type type3 = default;
		if (obj3 != null)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IList<>));
			nint num = (nint)typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ S2_v4 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
			Type type2 = default;
			object obj4 = type2 + 920;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ S3_v6+BC] (should have been resolved before IL gen)");
			object obj5 = default;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				JsonList jsonList2 = default;
				JsonList jsonList = jsonList2;
				if (jsonList2 == null)
				{
					JsonList jsonList3 = default;
					jsonList3._002Ector();
					nint num2 = (nint)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v281 @ S1_v154 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
					string text = default;
					string[] array = text.Split(',');
					object obj6 = 0;
					while (true)
					{
						bool flag = (nint)obj6 >= array.Length;
						jsonList = jsonList3;
						if (flag)
						{
							break;
						}
						object obj7 = obj6 << 2;
						object obj8 = (object)array + obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S1_v161+10]");
						string item = ((string)0).Trim();
						jsonList3.Add(item);
						object obj9 = obj6 + 1;
						obj6 = obj9;
					}
				}
				object obj10 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v243 @ S1_v117+24C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(int));
				throw new ArrayTypeMismatchException();
			}
			nint num3 = (nint)type2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ S1_v13 (Il2CppClass<System.Type>)+1FC] (should have been resolved before IL gen)");
			object obj11 = default;
			if (obj11 != null)
			{
				nint num4 = (nint)type2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v185 @ S1_v25 (Il2CppClass<System.Type>)+23C] (should have been resolved before IL gen)");
				Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Dictionary<, >));
				object obj12 = default;
				if (typeFromHandle3 == obj12)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
					object obj13 = default;
					if (obj13 != null)
					{
						ConstructorInfo constructor = ReflectionWrapper.GetConstructor(type2);
						nint num5 = (nint)constructor;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ S5_v5 (Il2CppClass<System.Reflection.ConstructorInfo>)+1FC] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
						nint num6 = (nint)type2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v377 @ S1_v41 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
						nint num7 = (nint)type2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v387 @ S1_v44 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
						object obj14 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						object obj15 = obj + 40;
						obj = obj15;
						_ = 0;
						object obj17 = default;
						object obj18 = default;
						object obj19 = default;
						object obj20 = default;
						object obj21 = default;
						object result = default;
						while (true)
						{
							_ = 0;
							object obj16 = obj + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj17 == null)
								{
									goto IL_06b6;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
								obj = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
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
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															continue;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
							bool flag2 = obj18 != obj19;
							obj3 = obj20;
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
								goto IL_06b6;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							obj3 = obj21;
							break;
							IL_06b6:
							object obj22 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDF");
							return result;
						}
						_ = 0;
						object obj23 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						type3 = (Type)0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
							goto IL_0919;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					}
					string message = $"Cannot translate value {obj3} to a Dictionary";
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					FormatException ex = default;
					ex._002Ector(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
					return ex;
				}
			}
			goto IL_0919;
		}
		object result2 = default;
		return result2;
		IL_0919:
		nint num8 = (nint)type3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ S1_v17 (Il2CppClass<System.Type>)+31C] (should have been resolved before IL gen)");
		object obj24 = default;
		if (obj24 == null)
		{
			JsonObjectStore objectStore = context.ObjectStore;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			return objectStore.Get((Type)0, obj3);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num9 = (nint)type3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v301 @ S2_v13 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
		throw new ArrayTypeMismatchException();
	}

	public static object ReflectionDeserialize(Type objType, JsonDict json, JsonContext context)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		JsonClassInfo jsonTypeReflection = JsonClassInfo.GetJsonTypeReflection(objType);
		object obj = jsonTypeReflection.Construct(context);
		JsonFieldInfo[] cachedSerializedFields = jsonTypeReflection.CachedSerializedFields;
		object obj2 = 0;
		while (cachedSerializedFields.Length > (nint)obj2)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)cachedSerializedFields + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24+10]");
			JsonFieldInfo jsonFieldInfo = (JsonFieldInfo)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24+10]");
			object obj5 = ((JsonFieldInfo)0).ReadValue(json);
			if (obj5 != null)
			{
				if (~(jsonFieldInfo.SerializeByKey ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24+10]");
					context.RegisterSerializeByKeyReference(obj, (JsonFieldInfo)0, obj5);
				}
				else
				{
					RecursiveReadField(obj, jsonFieldInfo.Field, obj5, context);
				}
			}
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		if (jsonTypeReflection.TypeHasKey)
		{
			string key = jsonTypeReflection.GetKey(obj);
			context.ObjectStore.Set(objType, key, obj);
		}
		return obj;
	}

	public static JsonDict ReflectionSerialize(Type type, object obj, JsonContext context)
	{
		//IL_0085: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I
		//IL_00ca: Expected I, but got Obj
		//IL_00e9: Expected I, but got Obj
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		JsonClassInfo jsonTypeReflection = JsonClassInfo.GetJsonTypeReflection(type);
		JsonFieldInfo[] cachedSerializedFields = jsonTypeReflection.CachedSerializedFields;
		JsonDict jsonDict = default;
		jsonDict._002Ector(cachedSerializedFields.Length);
		if (jsonTypeReflection.TypeHasKey)
		{
			string key = jsonTypeReflection.GetKey(obj);
			context.ObjectStore.Set(type, key, obj);
		}
		JsonFieldInfo[] cachedSerializedFields2 = jsonTypeReflection.CachedSerializedFields;
		object obj2 = 0;
		object value2 = default;
		Type ft = default;
		while (cachedSerializedFields2.Length > (nint)obj2)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)cachedSerializedFields2 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v25+10]");
			JsonFieldInfo jsonFieldInfo = (JsonFieldInfo)0;
			FieldInfo field = jsonFieldInfo.Field;
			nint num = (nint)field;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S2_v6 (Il2CppClass<System.Reflection.FieldInfo>)+184] (should have been resolved before IL gen)");
			FieldInfo field2 = jsonFieldInfo.Field;
			nint num2 = (nint)field2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S1_v13 (Il2CppClass<System.Reflection.FieldInfo>)+144] (should have been resolved before IL gen)");
			object value = RecursiveWriteValue(value2, ft, jsonFieldInfo, context);
			jsonFieldInfo.WriteValue(value, jsonDict);
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
		return jsonDict;
	}

	private static object RecursiveWriteValue(object value, Type ft, JsonFieldInfo field, JsonContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Expected VT, but got Obj
		//IL_007f: Expected VT, but got Obj
		//IL_00a4: Expected I, but got Obj
		//IL_00c1: Expected VT, but got Obj
		//IL_00e6: Expected I, but got Obj
		//IL_0103: Expected VT, but got Obj
		//IL_0128: Expected I, but got Obj
		//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Expected Obj, but got Unknown
		//IL_0ba5: Expected Obj, but got I
		//IL_013e: Expected I, but got Obj
		//IL_0882: Expected I, but got Obj
		//IL_0944: Expected VT, but got Obj
		//IL_0165: Expected VT, but got Obj
		//IL_098e: Expected I, but got Obj
		//IL_0199: Expected VT, but got Obj
		//IL_01cd: Expected VT, but got Obj
		//IL_0284: Expected VT, but got Obj
		//IL_0316: Expected VT, but got Obj
		//IL_0327: Expected I, but got Obj
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_0aac: Expected VT, but got Obj
		//IL_0ab8: Expected I, but got Obj
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected Obj, but got Unknown
		//IL_03ac: Expected Obj, but got I4
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_076c: Expected Obj, but got I4
		//IL_077c: Expected I, but got Obj
		//IL_03dd: Expected Obj, but got I
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected Obj, but got Unknown
		//IL_079e: Expected Obj, but got I4
		//IL_0751: Expected Obj, but got I4
		//IL_075e: Expected I, but got Obj
		//IL_065a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag = value == null;
		object result = null;
		nint num;
		JsonSerializationException ex2;
		object obj13 = default;
		if (!flag)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
			if ((object)typeFromHandle != ft)
			{
				Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IntPtr));
				bool flag2 = (object)typeFromHandle2 == ft;
				num = (nint)typeof(IntPtr);
				if (!flag2)
				{
					Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(UIntPtr));
					bool flag3 = (object)typeFromHandle3 == ft;
					num = (nint)typeof(UIntPtr);
					if (!flag3)
					{
						Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ulong));
						bool flag4 = (object)typeFromHandle4 == ft;
						num = (nint)typeof(ulong);
						if (!flag4)
						{
							nint num2 = (nint)ft;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v237 @ S1_v46 (Il2CppClass<System.Type>)+30C] (should have been resolved before IL gen)");
							object obj3 = default;
							if (obj3 == null)
							{
								Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(JsonDict));
								if ((object)typeFromHandle5 != ft)
								{
									Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(JsonList));
									if ((object)typeFromHandle6 != ft)
									{
										Type typeFromHandle7 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DateTime));
										if ((object)typeFromHandle7 == ft)
										{
											throw new NullReferenceException();
										}
										Type typeFromHandle8 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Guid));
										if ((object)typeFromHandle8 == ft)
										{
											NullReferenceException ex = new NullReferenceException();
											_ = ((Exception)ex)._className;
											object obj4 = obj + 16;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
											object value2 = default;
											string text = field.ToLimitedString(value2);
											result = text;
										}
										else
										{
											Type typeFromHandle9 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IList<>));
											nint num3 = (nint)typeFromHandle9;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v455 @ S2_v22 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
											object obj5 = ft + 920;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v465 @ S3_v15+BC] (should have been resolved before IL gen)");
											object obj6 = default;
											if (obj6 == null)
											{
												Type typeFromHandle10 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IDictionary<, >));
												nint num4 = (nint)typeFromHandle10;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v509 @ S2_v27 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
												object obj7 = ft + 920;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v517 @ S3_v21+BC] (should have been resolved before IL gen)");
												object obj8 = default;
												bool flag5 = obj8 == null;
												ex2 = (JsonSerializationException)value;
												if (flag5)
												{
													goto IL_087a;
												}
												object obj9 = obj8;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v525 @ S1_v64+24C] (should have been resolved before IL gen)");
												object obj10 = obj8;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v534 @ S1_v67+24C] (should have been resolved before IL gen)");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
												JsonDict jsonDict = default;
												int capacity = default;
												jsonDict._002Ector(capacity);
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
												object obj11 = obj + 32;
												object obj12 = obj + 36;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
												_ = 0;
												object obj14 = default;
												object obj15 = default;
												object obj16 = default;
												object obj17 = default;
												object obj18 = default;
												object obj19 = default;
												IntPtr intPtr = default;
												while (true)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														obj13 = obj14;
													}
													else
													{
														if (obj14 == null)
														{
															break;
														}
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag6 = (nint)0 == 1;
														obj13 = obj15;
														if (!flag6)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															bool flag7 = (nint)0 == 1;
															obj13 = obj16;
															if (!flag7)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		bool flag8 = (nint)0 == 1;
																		obj13 = obj17;
																		if (!flag8)
																		{
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			bool flag9 = (nint)0 == 1;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			obj13 = 0;
																			if (!flag9)
																			{
																				continue;
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																		obj13 = obj17;
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	obj13 = obj16;
																}
																goto IL_06b9;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
													goto IL_06b9;
													IL_06b9:
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
													bool flag10 = obj18 != obj19;
													num = intPtr;
													if (!flag10)
													{
														goto IL_06f9;
													}
													goto IL_07ab;
												}
												obj13 = 0;
												ex2 = (JsonSerializationException)value;
												num = (nint)jsonDict;
												goto IL_0b76;
											}
											object obj20 = obj6;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v478 @ S1_v131+24C] (should have been resolved before IL gen)");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
											JsonList jsonList = default;
											int capacity2 = default;
											jsonList._002Ector(capacity2);
											object obj21 = 0;
											object obj22 = default;
											object value3 = default;
											while (true)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
												bool flag11 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21);
												result = jsonList;
												if (flag11)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S0_v264+10]");
												object item = RecursiveWriteValue(value3, (Type)0, field, context);
												jsonList.Add(item);
												object obj23 = obj21 + 1;
												obj21 = obj23;
											}
										}
										goto IL_0a7a;
									}
								}
							}
							result = value;
							goto IL_0a7a;
						}
						goto IL_0a8e;
					}
				}
				goto IL_0a7f;
			}
			string text2 = field.ToLimitedString(value);
			result = text2;
		}
		goto IL_0a7a;
		IL_0a7f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		JsonSerializationException ex3 = default;
		ex3._002Ector("IntPtr types are not supported.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		goto IL_0a8e;
		IL_0b76:
		object obj24 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
		bool flag12 = obj13 == null;
		result = num;
		if (!flag12)
		{
			goto IL_087a;
		}
		goto IL_0a7a;
		IL_07ab:
		_ = 0;
		object obj25 = obj + 16;
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
		goto IL_0a7f;
		IL_0a8e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		JsonSerializationException ex4 = default;
		ex4._002Ector("ulongs are not supported.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		ex2 = ex4;
		goto IL_0b76;
		IL_087a:
		nint num5 = (nint)ft;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v344 @ S1_v26 (Il2CppClass<System.Type>)+2EC] (should have been resolved before IL gen)");
		object obj26 = default;
		if (obj26 != null)
		{
			if (field == null || ~(field.EnumAsString ? 1u : 0u) != 0)
			{
				throw new NullReferenceException();
			}
			string text3 = field.ToLimitedString(ex2);
			result = text3;
		}
		else
		{
			Type typeFromHandle11 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(int?));
			if ((object)typeFromHandle11 == ft)
			{
				PropertyInfo property = ft.GetProperty("Value");
				nint num6 = (nint)property;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v445 @ S3_v9 (Il2CppClass<System.Reflection.PropertyInfo>)+18C] (should have been resolved before IL gen)");
				object obj27 = default;
				result = obj27;
			}
			else if (field != null && ~(field.SerializeByKey ? 1u : 0u) == 0)
			{
				object key = field.GetKey(ex2);
				context.RegisterSerializeByKeyReference(ex2, field, key);
				result = key;
			}
			else
			{
				JsonDict jsonDict2 = RecursiveWriteObject(ex2, context);
				result = jsonDict2;
			}
		}
		goto IL_0a7a;
		IL_06f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			obj13 = 1;
			ex2 = (JsonSerializationException)value;
			num = unchecked((nint)null);
			goto IL_0b76;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		obj13 = 1;
		IntPtr intPtr2 = default;
		num = intPtr2;
		goto IL_07ab;
		IL_0a7a:
		return result;
	}

	private static string GetKey(object obj, Type type)
	{
		//IL_003c: Expected I, but got Obj
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		JsonClassInfo jsonTypeReflection = JsonClassInfo.GetJsonTypeReflection(type);
		if (jsonTypeReflection.TypeHasKey)
		{
			return jsonTypeReflection.GetKey(obj);
		}
		nint num = (nint)obj;
		object obj2 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S1_v5 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private static JsonDict RecursiveWriteObject(object obj, JsonContext context)
	{
		context.BeginSerialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		Type type = default;
		if (context.CustomSerializers.HasSerializer(type))
		{
			return context.CustomSerializers.Serialize(type, obj, context);
		}
		JsonDict result = ReflectionSerialize(type, obj, context);
		context.EndSerialize();
		return result;
	}

	private unsafe static object RecursiveReadValue(Type type, object value, JsonContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1215: Unknown result type (might be due to invalid IL or missing references)
		//IL_121a: Expected Obj, but got Unknown
		//IL_1223: Expected Obj, but got I4
		//IL_0022: Expected VT, but got Obj
		//IL_0080: Expected VT, but got Obj
		//IL_00de: Expected VT, but got Obj
		//IL_013c: Expected VT, but got Obj
		//IL_019a: Expected VT, but got Obj
		//IL_01f8: Expected VT, but got Obj
		//IL_0256: Expected VT, but got Obj
		//IL_02b4: Expected VT, but got Obj
		//IL_0312: Expected VT, but got Obj
		//IL_0370: Expected VT, but got Obj
		//IL_03ce: Expected VT, but got Obj
		//IL_0484: Expected VT, but got Obj
		//IL_053d: Expected VT, but got Obj
		//IL_05b0: Expected VT, but got Obj
		//IL_0623: Expected VT, but got Obj
		//IL_0517: Expected I, but got Obj
		//IL_0634: Expected I, but got Obj
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_1280: Expected I, but got Obj
		//IL_1342: Expected VT, but got Obj
		//IL_0eb2: Expected VT, but got Obj
		//IL_08e7: Expected I, but got Obj
		//IL_0900: Expected VT, but got Obj
		//IL_12d2: Expected VT, but got Obj
		//IL_0fad: Expected I, but got Obj
		//IL_06a9: Expected I, but got Obj
		//IL_06d3: Expected Obj, but got I4
		//IL_11a6: Expected Obj, but got I
		//IL_114d: Expected Obj, but got I
		//IL_0de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dee: Expected Ref, but got Unknown
		//IL_0964: Expected I, but got Obj
		//IL_0704: Expected Obj, but got I
		//IL_0f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5f: Expected VT, but got Unknown
		//IL_0f67: Expected native int or pointer, but got VT
		//IL_0f89: Expected Obj, but got I
		//IL_0e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8c: Expected Obj, but got Unknown
		//IL_0985: Expected I, but got Obj
		//IL_0997: Expected I, but got Obj
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Expected Obj, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected Obj, but got Unknown
		//IL_09e4: Expected Obj, but got I
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ff: Expected Obj, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got Unknown
		//IL_139b: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a0: Expected Obj, but got Unknown
		//IL_1058: Expected Obj, but got I
		//IL_0e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected Ref, but got Unknown
		//IL_10f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f6: Expected Obj, but got Unknown
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd6: Expected Obj, but got Unknown
		//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Expected Obj, but got Unknown
		//IL_0d3c: Expected Obj, but got I
		//IL_0a4a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = default;
		bool flag = obj4 == null;
		object result = null;
		string message;
		Type type3 = default;
		if (!flag)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(int));
			Type type2 = default;
			if ((object)typeFromHandle == type2)
			{
				object obj5 = ConvertOrDefault<int>(obj4);
				result = obj5;
			}
			else
			{
				Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(short));
				if ((object)typeFromHandle2 == type2)
				{
					object obj6 = ConvertOrDefault<short>(obj4);
					result = obj6;
				}
				else
				{
					Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(uint));
					if ((object)typeFromHandle3 == type2)
					{
						object obj7 = ConvertOrDefault<uint>(obj4);
						result = obj7;
					}
					else
					{
						Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ushort));
						if ((object)typeFromHandle4 == type2)
						{
							object obj8 = ConvertOrDefault<ushort>(obj4);
							result = obj8;
						}
						else
						{
							Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(sbyte));
							if ((object)typeFromHandle5 == type2)
							{
								object obj9 = ConvertOrDefault<sbyte>(obj4);
								result = obj9;
							}
							else
							{
								Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(byte));
								if ((object)typeFromHandle6 == type2)
								{
									object obj10 = ConvertOrDefault<T>(obj4);
									result = obj10;
								}
								else
								{
									Type typeFromHandle7 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(char));
									if ((object)typeFromHandle7 == type2)
									{
										object obj11 = ConvertOrDefault<char>(obj4);
										result = obj11;
									}
									else
									{
										Type typeFromHandle8 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(long));
										if ((object)typeFromHandle8 == type2)
										{
											object obj12 = ConvertOrDefault<long>(obj4);
											result = obj12;
										}
										else
										{
											Type typeFromHandle9 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(float));
											if ((object)typeFromHandle9 == type2)
											{
												object obj13 = ConvertOrDefault<float>(obj4);
												result = obj13;
											}
											else
											{
												Type typeFromHandle10 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(double));
												if ((object)typeFromHandle10 != type2)
												{
													Type typeFromHandle11 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(bool));
													if ((object)typeFromHandle11 == type2)
													{
														bool flag2 = obj4 == null;
														object obj14 = null;
														if (!flag2)
														{
															bool flag3 = (object)obj4.GetType() == typeof(bool);
															obj14 = obj4;
															if (!flag3)
															{
																obj14 = null;
															}
														}
														if (obj14 != null)
														{
															goto IL_10c4;
														}
														message = $"Cannot translate value {obj4} to a bool";
													}
													else
													{
														Type typeFromHandle12 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
														if ((object)typeFromHandle12 == type2)
														{
															bool flag4 = obj4 == null;
															object obj15 = null;
															if (!flag4)
															{
																bool flag5 = (object)obj4.GetType() == typeof(string);
																obj15 = obj4;
																if (!flag5)
																{
																	obj15 = null;
																}
															}
															if (obj15 != null)
															{
																goto IL_10c4;
															}
															nint num = (nint)obj4;
															Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v529 @ S1_v251 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
															object obj16 = default;
															result = obj16;
															goto IL_1257;
														}
														Type typeFromHandle13 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(JsonList));
														if ((object)typeFromHandle13 == type2)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
															object obj17 = default;
															if (obj17 != null)
															{
																goto IL_10c4;
															}
															message = $"Cannot translate value {obj4} to a JsonList";
														}
														else
														{
															Type typeFromHandle14 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(JsonDict));
															if ((object)typeFromHandle14 != type2)
															{
																Type typeFromHandle15 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IList<>));
																nint num2 = (nint)typeFromHandle15;
																Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v570 @ S2_v7 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
																object obj18 = type2 + 920;
																Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v580 @ S3_v8+BC] (should have been resolved before IL gen)");
																object obj19 = default;
																if (obj19 != null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
																	JsonList jsonList2 = default;
																	JsonList jsonList = jsonList2;
																	if (jsonList2 == null)
																	{
																		JsonList jsonList3 = default;
																		jsonList3._002Ector();
																		nint num3 = (nint)obj4;
																		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v690 @ S1_v230 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
																		string text = default;
																		string[] array = text.Split(',');
																		object obj20 = 0;
																		while (true)
																		{
																			bool flag6 = (nint)obj20 >= array.Length;
																			jsonList = jsonList3;
																			if (flag6)
																			{
																				break;
																			}
																			object obj21 = obj20 << 2;
																			object obj22 = (object)array + obj21;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ S1_v237+10]");
																			string item = ((string)0).Trim();
																			jsonList3.Add(item);
																			object obj23 = obj20 + 1;
																			obj20 = obj23;
																		}
																	}
																	object obj24 = obj19;
																	Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v659 @ S1_v193+24C] (should have been resolved before IL gen)");
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
																	Type typeFromHandle16 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(int));
																	throw new ArrayTypeMismatchException();
																}
																nint num4 = (nint)type2;
																Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v594 @ S1_v48 (Il2CppClass<System.Type>)+1FC] (should have been resolved before IL gen)");
																object obj25 = default;
																if (obj25 != null)
																{
																	nint num5 = (nint)type2;
																	Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v605 @ S1_v103 (Il2CppClass<System.Type>)+23C] (should have been resolved before IL gen)");
																	Type typeFromHandle17 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Dictionary<, >));
																	object obj26 = default;
																	if (typeFromHandle17 == obj26)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
																		object obj27 = default;
																		if (obj27 != null)
																		{
																			ConstructorInfo constructor = ReflectionWrapper.GetConstructor(type2);
																			nint num6 = (nint)constructor;
																			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v795 @ S5_v12 (Il2CppClass<System.Reflection.ConstructorInfo>)+1FC] (should have been resolved before IL gen)");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
																			nint num7 = (nint)type2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v832 @ S1_v116 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
																			nint num8 = (nint)type2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v842 @ S1_v119 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
																			object obj28 = obj + 16;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
																			_ = 0;
																			object obj29 = obj - -64;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
																			obj29 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
																			_ = 0;
																			object obj30 = obj + 56;
																			obj = obj30;
																			_ = 0;
																			object obj32 = default;
																			object obj33 = default;
																			object obj34 = default;
																			object obj35 = default;
																			object obj36 = default;
																			object obj38 = default;
																			while (true)
																			{
																				_ = 0;
																				object obj31 = obj + 56;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					if (obj32 == null)
																					{
																						goto IL_0cc8;
																					}
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
																					obj = 0;
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						_ = 0;
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
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																								if ((nint)0 != 1)
																								{
																									_ = 0;
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																									if ((nint)0 != 1)
																									{
																										_ = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
																										_ = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																										if ((nint)0 != 1)
																										{
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																											if ((nint)0 != 1)
																											{
																												continue;
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
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
																				bool flag7 = obj33 != obj34;
																				obj4 = obj35;
																				if (flag7)
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
																					goto IL_0cc8;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																				obj4 = obj36;
																				break;
																				IL_0cc8:
																				object obj37 = obj + 16;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDF");
																				result = obj38;
																				goto IL_1257;
																			}
																			_ = 0;
																			object obj39 = obj + 16;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			type3 = (Type)0;
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
																				goto IL_1333;
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
																		}
																		message = $"Cannot translate value {obj4} to a Dictionary";
																		goto IL_11cb;
																	}
																}
																goto IL_1333;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
															object obj40 = default;
															if (obj40 != null)
															{
																goto IL_10c4;
															}
															message = $"Cannot translate value {obj4} to a JsonDict";
														}
													}
													goto IL_11cb;
												}
												object obj41 = ConvertOrDefault<double>(obj4);
												result = obj41;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_1257;
		IL_11b4:
		message = $"Cannot translate value {obj4} to a DateTime";
		goto IL_11cb;
		IL_1333:
		Type typeFromHandle18 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DateTime));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((object)typeFromHandle18 == null)
		{
			bool flag8 = obj4 == null;
			object obj42 = null;
			if (!flag8)
			{
				bool flag9 = (object)obj4.GetType() == typeof(string);
				obj42 = obj4;
				if (!flag9)
				{
					obj42 = null;
				}
			}
			if (obj42 == null)
			{
				goto IL_11b4;
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (!DateTime.TryParseExact((string)obj42, DateTimeFormatString, invariantCulture, DateTimeStyles.AssumeUniversal, out *(DateTime*)(obj + 40)))
			{
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				bool flag10 = DateTime.TryParseExact((string)obj42, DateTimeFormatString2, invariantCulture2, DateTimeStyles.AssumeUniversal, out *(DateTime*)(obj + 40));
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			object obj43 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object obj44 = default;
			result = obj44;
		}
		else
		{
			Type typeFromHandle19 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Guid));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((object)typeFromHandle19 == null)
			{
				bool flag11 = obj4 == null;
				object obj45 = null;
				if (!flag11)
				{
					bool flag12 = (object)obj4.GetType() == typeof(string);
					obj45 = obj4;
					if (!flag12)
					{
						obj45 = null;
					}
				}
				if (obj45 == null)
				{
					goto IL_11b4;
				}
				_ = 0;
				_ = 0;
				Guid guid = (Guid)(obj + 16);
				*(Guid*)(nint)guid = new Guid((string)obj45);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj46 = default;
				result = obj46;
			}
			else
			{
				nint num9 = (nint)type3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v818 @ S1_v58 (Il2CppClass<System.Type>)+2EC] (should have been resolved before IL gen)");
				object obj47 = default;
				if (obj47 != null)
				{
					bool flag13 = obj4 == null;
					object obj48 = null;
					if (!flag13)
					{
						bool flag14 = (object)obj4.GetType() == typeof(string);
						obj48 = obj4;
						if (!flag14)
						{
							obj48 = null;
						}
					}
					if (obj48 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						string value2 = default;
						object obj49 = Enum.Parse((Type)0, value2, ignoreCase: true);
						result = obj49;
					}
					else
					{
						bool flag15 = obj4 == null;
						object obj50 = null;
						if (!flag15)
						{
							bool flag16 = (object)obj4.GetType() == typeof(int);
							obj50 = obj4;
							if (!flag16)
							{
								obj50 = null;
							}
						}
						if (obj50 != null)
						{
							goto IL_10c4;
						}
						int num10 = Convert.ToInt32(obj4);
						object obj51 = obj + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object obj52 = default;
						result = obj52;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
					JsonDict jsonDict = default;
					if (jsonDict == null)
					{
						object arg = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						message = $"Cannot translate value {arg} to a {0}";
						goto IL_11cb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					object obj53 = RecursiveReadObject((Type)0, jsonDict, context);
					result = obj53;
				}
			}
		}
		goto IL_1257;
		IL_10c4:
		result = obj4;
		goto IL_1257;
		IL_11cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		FormatException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return ex;
		IL_1257:
		return result;
	}

	private static object ConvertOrDefault<T>(object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_036e: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I
		//IL_0276: Expected Obj, but got I
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_0305: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		object obj3 = obj + 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj4 = default;
		object result = default;
		if (obj4 == null)
		{
			nint num = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag = (nint)0 != 1;
						object obj5 = default;
						result = obj5;
						if (!flag)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_014b;
						}
						goto IL_044d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_014b;
		}
		goto IL_044d;
		IL_014b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag2 = obj6 != obj7;
		object obj8 = default;
		object result2 = obj8;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj10 = default;
				object obj9 = obj10;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj11 = default;
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj12 = (nint)0 << 2;
						object obj13 = obj3 + obj12;
						obj13 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj14 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						object obj15 = obj + 31;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
						object obj16 = obj + 15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj17 = -1;
						object obj18 = default;
						result = obj18;
						goto IL_044d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj19 = obj10;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result2 = 0;
					if (flag3)
					{
						goto IL_0452;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			object obj20 = default;
			result2 = obj20;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				result2 = obj20;
			}
		}
		goto IL_0452;
		IL_044d:
		return result;
		IL_0452:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result2;
	}

	private static object DictionaryResolveKey(string key, Type type, JsonContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_005b: Expected I, but got Obj
		//IL_032f: Expected Obj, but got I4
		//IL_024c: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		JsonClassInfo jsonTypeReflection = JsonClassInfo.GetJsonTypeReflection(type);
		object result;
		object result2 = default;
		if (jsonTypeReflection.TypeHasKey)
		{
			object obj4 = context.ObjectStore.Get(type, key);
			result = obj4;
		}
		else
		{
			nint num = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S1_v10 (Il2CppClass<System.Type>)+2EC] (should have been resolved before IL gen)");
			object obj5 = default;
			if (obj5 != null)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 != 1;
					object obj6 = default;
					result = obj6;
					if (flag)
					{
						goto IL_040a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj7 = default;
				object obj8 = default;
				bool flag2 = obj7 == obj8;
				bool flag3 = !flag2;
				object obj9 = default;
				result = obj9;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj11 = default;
						object obj10 = obj11;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj12 = default;
							if (obj12 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj13 = (nint)0 << 2;
								object obj14 = obj3 + obj13;
								obj14 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj15 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								int value = int.Parse(key);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								object obj16 = Enum.ToObject(type, value);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj17 = -1;
								result = obj16;
								goto IL_040a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj18 = obj11;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag4 = (nint)0 != 1;
							result2 = flag4;
							if (flag4)
							{
								goto IL_03d1;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 == 1;
					object obj19 = default;
					result = obj19;
					if (flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						goto IL_03d1;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
			else
			{
				object obj20 = Convert.ChangeType(key, type);
				result = obj20;
			}
		}
		goto IL_040a;
		IL_03d1:
		return result2;
		IL_040a:
		return result;
	}

	private static void RecursiveReadField(object obj, FieldInfo field, object jsonValue, JsonContext context)
	{
		//IL_000e: Expected I, but got Obj
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		nint num = (nint)field;
		object obj2 = field + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<System.Reflection.FieldInfo>)+144] (should have been resolved before IL gen)");
		Type type = default;
		object value = RecursiveReadValue(type, jsonValue, context);
		field.SetValue(obj, value);
	}

	private static object RecursiveReadObject(Type objType, JsonDict json, JsonContext context)
	{
		object result = ((!context.CustomSerializers.HasSerializer(objType)) ? ReflectionDeserialize(objType, json, context) : context.CustomSerializers.Deserialize(objType, json, context));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		ISerializationCallbackReceiver serializationCallbackReceiver = default;
		if (serializationCallbackReceiver != null)
		{
			context.RegisterSerializationCallBack(serializationCallbackReceiver);
		}
		return result;
	}
}
