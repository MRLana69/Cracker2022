using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using SYBO.Components.Crypt;
using SYBO.Components.EditorExtensions;
using SYBO.Components.Logging;
using SYBO.Components.Settings;
using SYBO.Components.Utilities;

namespace SYBO.Components.Json.Internal;

public static class JsonReflectionParser
{
	public const string DateTimeFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFF'Z'";

	public const string DateTimeFormatString2 = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'";

	public unsafe static T Deserialize<T>(object json, JsonContext context = null)
	{
		//IL_00c3: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_0132: Expected VT, but got Obj
		//IL_0074: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S3_v4 (should have been resolved before IL gen)");
		bool flag = context == null;
		bool flag2 = !flag;
		JsonCustomSerializer jsonCustomSerializer = (JsonCustomSerializer)(object)context;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonCustomSerializer jsonCustomSerializer2 = default;
			jsonCustomSerializer2._002Ector();
			jsonCustomSerializer = jsonCustomSerializer2;
		}
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v7 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v12 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string json2 = default;
		return (T)JsonParser.ParseObject(json2, ref *(int*)jsonCustomSerializer);
	}

	public unsafe static void DeserializeOnto<T>(T obj, JsonDict json, JsonContext context = null)
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Ref, but got Unknown
		//IL_012d: Expected Obj, but got I
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected I, but got Unknown
		//IL_0295: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_01a8: Expected I, but got Obj
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_01e8: Expected I, but got Obj
		//IL_020b: Expected Obj, but got I
		//IL_021b: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_00c9: Expected I, but got Obj
		object obj2 = default;
		ref JsonObjectStore.JsonObjectStoreTypeEntry reference = ref *(JsonObjectStore.JsonObjectStoreTypeEntry*)(obj2 + 8);
		reference = ref *(JsonObjectStore.JsonObjectStoreTypeEntry*)null;
		nint num = default;
		object obj3 = num + 24;
		object obj4 = obj3;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v10 (Il2CppClass<System.Type>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v38 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 4;
		object obj7 = obj2 + 12;
		obj7 = obj4;
		nint num4 = (nint)(obj2 + 16);
		((IntPtr*)num4)->m_value = (void*)(nint)obj7;
		Type key = Type.internal_from_handle((IntPtr)num4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ L0 (T)+8]");
		if (!((Dictionary<Type, JsonObjectStore.JsonObjectStoreTypeEntry>)0).TryGetValue(key, out reference))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CachingRootFileJsonSettingsParser._003C_003Ec obj8 = default;
			obj8._002Ector();
			reference = ref *(JsonObjectStore.JsonObjectStoreTypeEntry*)obj8;
			object obj9 = obj3;
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v26 (Il2CppClass<System.Type>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v37 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj6 = obj9;
			((IntPtr*)num4)->m_value = (void*)(nint)obj6;
			object obj11 = obj8 + 12;
			Type type = Type.internal_from_handle((IntPtr)num4);
			obj11 = type;
			object obj12 = obj3;
			obj2 = obj12;
			((IntPtr*)num4)->m_value = (void*)(nint)obj2;
			Type type2 = Type.internal_from_handle((IntPtr)num4);
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S4_v4+60]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S4_v5+48]");
			object obj15 = 0;
			object obj16 = obj15 & 0x7FF;
			object obj17 = obj16 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v78 @ S5_v5 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj18 = default;
		((CachingRootFileJsonSettingsParser.FileTextByPathGetter)(object)reference)._002Ector(obj18, (IntPtr)context);
	}

	public static object Deserialize(Type type, object json, JsonContext context = null)
	{
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected Obj, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected Obj, but got Unknown
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Expected Obj, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected Obj, but got Unknown
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected Obj, but got Unknown
		//IL_0a5e: Expected Obj, but got I4
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_0aee: Expected Obj, but got I4
		//IL_0089: Expected I, but got Obj
		//IL_0146: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_0b1d: Expected Obj, but got I4
		//IL_0187: Expected I, but got Obj
		//IL_0244: Expected I, but got Obj
		//IL_025a: Expected Obj, but got I
		//IL_0285: Expected I, but got Obj
		//IL_038f: Expected I, but got Obj
		//IL_03a5: Expected Obj, but got I
		//IL_0491: Expected I, but got Obj
		//IL_04a7: Expected Obj, but got I
		//IL_0bd1: Expected I, but got Obj
		//IL_0be7: Expected Obj, but got I
		//IL_0546: Expected I, but got Obj
		//IL_055c: Expected Obj, but got I
		//IL_0c47: Expected Obj, but got I4
		//IL_0c1a: Expected Obj, but got I4
		//IL_03d0: Expected I, but got Obj
		//IL_0c74: Expected Obj, but got I4
		//IL_04d2: Expected I, but got Obj
		//IL_041d: Expected I, but got Obj
		//IL_0587: Expected I, but got Obj
		//IL_0cae: Expected I, but got Obj
		//IL_0cc4: Expected Obj, but got I
		//IL_0f2f: Expected I, but got Obj
		//IL_0e14: Expected I4, but got Obj
		//IL_0728: Expected I, but got Obj
		//IL_0775: Expected I, but got Obj
		//IL_078b: Expected Obj, but got I
		//IL_0d00: Expected I, but got Obj
		//IL_07b6: Expected I, but got Obj
		//IL_0803: Expected I, but got Obj
		//IL_0819: Expected Obj, but got I
		//IL_0d4d: Expected I, but got Obj
		//IL_0844: Expected I, but got Obj
		//IL_0891: Expected I, but got Obj
		//IL_08a7: Expected Obj, but got I
		//IL_0d9a: Expected I, but got Obj
		//IL_08d2: Expected I, but got Obj
		//IL_0905: Expected I, but got Obj
		//IL_091b: Expected Obj, but got I
		//IL_0de7: Expected I, but got Obj
		//IL_0946: Expected I, but got Obj
		//IL_09a5: Expected I, but got Obj
		//IL_09bb: Expected Obj, but got I
		//IL_0e26: Expected I4, but got Obj
		//IL_0e38: Expected I, but got Obj
		//IL_0e4e: Expected Obj, but got I
		//IL_09e6: Expected I, but got Obj
		//IL_0a19: Expected I, but got Obj
		object obj = default;
		byte[] array = (byte[])(obj + 24);
		object obj2 = obj + 16;
		object obj3 = obj + 12;
		object obj4 = obj + 8;
		object obj5 = obj + 4;
		object result;
		if ((object)type != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			Type type2 = default;
			if (type2.IsSzArray)
			{
				nint num = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v256 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v264 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				IList anArray = default;
				bool flag = JsonParser.SerializeArray(anArray, (StringBuilder)json, context);
				result = 1;
			}
			else
			{
				Type type3;
				if ((object)type == null)
				{
					type3 = null;
				}
				else
				{
					type3 = (((object)((object)type).GetType() != typeof(string)) ? null : type);
				}
				if ((object)type3 != null)
				{
					nint num3 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v237 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num4 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v244 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
					StringBuilder builder = default;
					JsonParser.AppendIndentation(builder, (JsonContext)json);
					result = 1;
				}
				else
				{
					Type type4;
					if ((object)type == null)
					{
						type4 = null;
					}
					else
					{
						type4 = (((object)((object)type).GetType() != typeof(char)) ? null : type);
					}
					if ((object)type4 != null)
					{
						nint num5 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v216 (Il2CppClass<System.Convert>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num6 = (nint)typeof(Convert);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v225 (Il2CppClass<System.Convert>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						throw new NullReferenceException();
					}
					Type type5;
					if ((object)type == null)
					{
						type5 = null;
					}
					else
					{
						type5 = (((object)((object)type).GetType() != typeof(decimal)) ? null : type);
					}
					if ((object)type5 != null)
					{
						nint num7 = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v195 (Il2CppClass<System.Convert>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num8 = (nint)typeof(Convert);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v204 (Il2CppClass<System.Convert>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						NullReferenceException ex = new NullReferenceException();
						array = (byte[])(object)ex;
						_ = ((Exception)ex)._className;
						string builder2 = Convert.ToBase64String(array);
						nint num9 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S1_v97 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num10 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v102 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						JsonParser.AppendIndentation((StringBuilder)(object)builder2, (JsonContext)json);
						result = 1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
						object obj11 = default;
						if (obj11 != null)
						{
							nint num11 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v182 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
							object obj12 = (nint)0 & (nint)0x200;
							if (obj12 != null)
							{
								nint num12 = (nint)typeof(JsonParser);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v190 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
							Array anArray2 = default;
							bool flag2 = JsonParser.SerializeArray(anArray2, (StringBuilder)json, context);
							result = 1;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
							object obj13 = default;
							if (obj13 == null)
							{
								Type type6;
								if ((object)type == null)
								{
									type6 = null;
								}
								else
								{
									type6 = (((object)((object)type).GetType() != typeof(bool)) ? null : type);
								}
								if ((object)type6 != null)
								{
									throw new NullReferenceException();
								}
								Type type7;
								if ((object)type == null)
								{
									type7 = null;
								}
								else
								{
									type7 = (((object)((object)type).GetType() != typeof(bool)) ? null : type);
								}
								if ((object)type7 != null)
								{
									throw new NullReferenceException();
								}
								nint num13 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S0_v56 (Il2CppClass<System.Type>)+BA]");
								object obj14 = (nint)0 & (nint)0x200;
								if (obj14 != null)
								{
									nint num14 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v137 (Il2CppClass<System.Type>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								obj2 = typeof(sbyte);
								array = (byte[])obj2;
								Type type8 = Type.internal_from_handle((IntPtr)array);
								if ((object)type2 != type8)
								{
									nint num15 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v70 (Il2CppClass<System.Type>)+BA]");
									object obj15 = (nint)0 & (nint)0x200;
									if (obj15 != null)
									{
										nint num16 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v133 (Il2CppClass<System.Type>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									obj3 = typeof(byte);
									array = (byte[])obj3;
									Type type9 = Type.internal_from_handle((IntPtr)array);
									if ((object)type2 != type9)
									{
										nint num17 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v81 (Il2CppClass<System.Type>)+BA]");
										object obj16 = (nint)0 & (nint)0x200;
										if (obj16 != null)
										{
											nint num18 = (nint)typeof(Type);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S0_v129 (Il2CppClass<System.Type>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										obj4 = typeof(short);
										array = (byte[])obj4;
										Type type10 = Type.internal_from_handle((IntPtr)array);
										if ((object)type2 != type10)
										{
											nint num19 = (nint)typeof(Type);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S0_v92 (Il2CppClass<System.Type>)+BA]");
											object obj17 = (nint)0 & (nint)0x200;
											if (obj17 != null)
											{
												nint num20 = (nint)typeof(Type);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S0_v126 (Il2CppClass<System.Type>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											obj5 = typeof(int);
											array = (byte[])obj5;
											Type type11 = Type.internal_from_handle((IntPtr)array);
											if ((object)type2 != type11)
											{
												nint num21 = (nint)typeof(Type);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S0_v103 (Il2CppClass<System.Type>)+BA]");
												object obj18 = (nint)0 & (nint)0x200;
												if (obj18 != null)
												{
													nint num22 = (nint)typeof(Type);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S0_v123 (Il2CppClass<System.Type>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												obj = typeof(long);
												array = (byte[])obj;
												Type type12 = Type.internal_from_handle((IntPtr)array);
												if ((object)type2 != type12)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8592");
													object obj19 = default;
													bool flag3 = obj19 == null;
													result = null;
													if (!flag3)
													{
														nint num23 = (nint)typeof(Convert);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v113 (Il2CppClass<System.Convert>)+BA]");
														object obj20 = (nint)0 & (nint)0x200;
														if (obj20 != null)
														{
															nint num24 = (nint)typeof(Convert);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ S0_v120 (Il2CppClass<System.Convert>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														double num25 = Convert.ToDouble((sbyte)(int)type);
														nint num26 = (nint)typeof(JsonParser);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S1_v63 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
														object obj21 = (nint)0 & (nint)0x200;
														if (obj21 != null)
														{
															nint num27 = (nint)typeof(JsonParser);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ S1_v68 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														throw new OverflowException();
													}
													goto IL_0af3;
												}
											}
										}
									}
								}
								StringBuilder stringBuilder = ((StringBuilder)json).FindChunkForIndex((int)type);
								goto IL_0a55;
							}
							nint num28 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v169 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
							object obj22 = (nint)0 & (nint)0x200;
							if (obj22 != null)
							{
								nint num29 = (nint)typeof(JsonParser);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v177 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
							object value = default;
							bool flag4 = JsonParser.SerializeValue(value, (StringBuilder)json, context);
							result = 1;
						}
					}
				}
			}
			goto IL_0af3;
		}
		StringBuilder stringBuilder2 = ((StringBuilder)json).AppendLine("null");
		goto IL_0a55;
		IL_0a55:
		result = 1;
		goto IL_0af3;
		IL_0af3:
		return result;
	}

	public unsafe static object Serialize<T>(T obj, JsonContext context = null)
	{
		//IL_006f: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected I, but got Unknown
		//IL_00db: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = default;
		object obj2 = num + 24;
		object obj3 = obj2;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v24 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj3;
		nint num4 = (nint)(obj5 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj5;
		Type type = Type.internal_from_handle((IntPtr)num4);
		object obj6 = Serialize(type, obj, context);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		object result = default;
		return result;
	}

	public static object Serialize(Type type, object obj, JsonContext context = null)
	{
		bool flag = context == null;
		bool flag2 = !flag;
		JsonCustomSerializer jsonCustomSerializer = (JsonCustomSerializer)(object)context;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonCustomSerializer jsonCustomSerializer2 = default;
			jsonCustomSerializer2._002Ector();
			jsonCustomSerializer = jsonCustomSerializer2;
		}
		((JsonContext)(object)jsonCustomSerializer).EndDeserialize();
		object result = DictionaryResolveKey((string)(object)type, (Type)obj, (JsonContext)(object)jsonCustomSerializer);
		((JsonContext)(object)jsonCustomSerializer).BeginSerialize();
		return result;
	}

	public unsafe static void CollectReferenceUnknownKeys(Type type, object value, JsonContext context, Dictionary<Type, HashSet<string>> output)
	{
		//IL_00bb: Expected Obj, but got VT
		//IL_00ff: Expected I, but got Obj
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		ref JsonObjectStore.JsonObjectStoreTypeEntry reference = ref *(JsonObjectStore.JsonObjectStoreTypeEntry*)null;
		if (!((Dictionary<Type, JsonObjectStore.JsonObjectStoreTypeEntry>)type._impl).TryGetValue((Type)value, out reference))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CachingRootFileJsonSettingsParser._003C_003Ec obj = default;
			obj._002Ector();
			reference = ref *(JsonObjectStore.JsonObjectStoreTypeEntry*)obj;
			object obj2 = obj + 12;
			obj2 = value;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S4_v4+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S4_v5+48]");
			object obj5 = 0;
			object obj6 = obj5 & 0x7FF;
			object obj7 = obj6 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S5_v5 (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj8 = default;
		((CachingRootFileJsonSettingsParser.FileTextByPathGetter)(object)reference)._002Ector(obj8, (IntPtr)output);
	}

	public static object ReadReference(Type type, object value, JsonContext context)
	{
		//IL_0040: Expected I4, but got Obj
		bool flag = context == null;
		bool flag2 = !flag;
		JsonCustomSerializer jsonCustomSerializer = (JsonCustomSerializer)(object)context;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonCustomSerializer jsonCustomSerializer2 = default;
			jsonCustomSerializer2._002Ector();
			jsonCustomSerializer = jsonCustomSerializer2;
		}
		((JsonContext)(object)jsonCustomSerializer).EndSerialize();
		object result = ((Aes128CounterMode)value).CreateEncryptor((byte[])(object)type, (byte[])null, (int)jsonCustomSerializer);
		((JsonContext)(object)jsonCustomSerializer).ResolveKnownReferences();
		return result;
	}

	public unsafe static object ReflectionDeserialize(Type objType, JsonDict json, JsonContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected I, but got Unknown
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected Obj, but got Unknown
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected Obj, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Expected Obj, but got Unknown
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected Obj, but got Unknown
		//IL_086c: Expected Obj, but got I4
		//IL_0881: Expected Obj, but got I4
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_08d5: Expected I, but got Obj
		//IL_0062: Expected I, but got Obj
		//IL_0793: Expected I, but got Obj
		//IL_07a9: Expected Obj, but got I
		//IL_03d6: Expected I, but got Obj
		//IL_03ec: Expected Obj, but got I
		//IL_0780: Expected Obj, but got I4
		//IL_0abd: Expected I, but got Obj
		//IL_07d4: Expected I, but got Obj
		//IL_0417: Expected I, but got Obj
		//IL_010c: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_013d: Expected Obj, but got I4
		//IL_093b: Expected Obj, but got I4
		//IL_094d: Expected Obj, but got I4
		//IL_0965: Expected I, but got Obj
		//IL_097b: Expected Obj, but got I
		//IL_09da: Expected I, but got Obj
		//IL_01b3: Expected I, but got Obj
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_050f: Expected Obj, but got I4
		//IL_052a: Expected Obj, but got I4
		//IL_04b6: Expected I4, but got Obj
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_0546: Expected Obj, but got I
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected Obj, but got Unknown
		//IL_0655: Expected Obj, but got I4
		//IL_059e: Expected Obj, but got I
		//IL_06bc: Expected Obj, but got I
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		nint num = (nint)(obj2 + 8);
		object obj3 = obj2 + 48;
		object obj4 = obj2 + 36;
		object obj5 = obj2 + 32;
		object obj6 = obj2 + 56;
		obj6 = 0;
		_ = 0;
		_ = 0;
		obj2 = 0;
		object obj7 = obj2 + 40;
		obj7 = obj;
		_ = -1;
		if (json != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v36 (Il2CppClass<System.Type>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v275 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = typeof(IList<>);
			((IntPtr*)num)->m_value = (void*)(nint)obj3;
			Type directoryPath = Type.internal_from_handle((IntPtr)num);
			bool flag = ((AssetLoaderPathAttribute)(object)objType).ValidateDirectoryPath((string)(object)directoryPath);
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				JsonObjectStore jsonObjectStore = default;
				if (jsonObjectStore == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					jsonObjectStore._002Ector();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					int num4 = default;
					object obj9 = num4 + 16;
					obj9 = 44;
					string text2 = default;
					string text = text2.Substring(num4);
					object obj10 = text + 12;
					object obj11 = 0;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
					{
						object obj12 = text + 16;
						object obj13 = obj11 << 2;
						object str = obj12 + obj13;
						string item = string.Copy((string)str);
						((List<object>)(object)jsonObjectStore).Add((object)item);
						object obj14 = obj11 + 1;
						obj11 = obj14;
					}
				}
				bool flag2 = ReflectionWrapper.IsPrimitive((Type)flag);
				object obj15 = (flag2 ? 1 : 0) + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v199 (Il2CppClass<System.Type>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num6 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v255 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj4 = typeof(int);
				((IntPtr*)num)->m_value = (void*)(nint)obj4;
				Type type = Type.internal_from_handle((IntPtr)num);
				throw new ArrayTypeMismatchException();
			}
			if (ReflectionWrapper.IsAbstract(objType))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				nint num7 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v37 (Il2CppClass<System.Type>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num8 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v113 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj5 = typeof(Dictionary<, >);
				((IntPtr*)num)->m_value = (void*)(nint)obj5;
				Type type2 = Type.internal_from_handle((IntPtr)num);
				object obj18 = default;
				if (obj18 == type2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
					object obj19 = default;
					if (obj19 == null)
					{
						string text3 = $"Cannot translate value {(object[])(object)json} to a Dictionary";
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						StringBuilder outputBuffer = default;
						System.DateTimeFormat.HebrewFormatDigits(outputBuffer, (int)text3);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					}
					object uninitializedObject = ReflectionWrapper.GetUninitializedObject(objType);
					bool flag3 = ((ConstructorInfo)uninitializedObject).Equals((object)null);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
					bool flag4 = ReflectionWrapper.IsPrimitive(objType);
					object obj20 = (flag4 ? 1 : 0) + 16;
					bool flag5 = ReflectionWrapper.IsPrimitive(objType);
					object obj21 = (flag5 ? 1 : 0) + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
					obj6 = (object)((IntPtr*)num)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+10]");
					_ = 0;
					object obj22 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj22 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						obj2 = (object)((IntPtr*)num)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
					}
					object obj23 = obj7 + 4;
					object obj24 = obj23 + 1;
					obj23 = obj24;
					object obj25 = obj24 << 2;
					object obj26 = obj7 + obj25;
					obj26 = 464;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25+4]");
					object result = default;
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25+4]");
						object obj27 = (nint)0 << 2;
						object obj28 = obj7 + obj27;
						if ((nint)obj28 == 464)
						{
							object obj29 = obj7 + 4;
							if ((nint)obj29 > -1)
							{
								object obj30 = obj29 + -1;
								obj29 = obj30;
							}
							return result;
						}
					}
					object obj31 = default;
					if (obj31 == null)
					{
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
			if (!ReflectionWrapper.IsEnum(objType))
			{
				bool flag6 = context.ObjectStore.HasObject(objType, json);
				return flag6;
			}
			nint num9 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v51 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num10 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v58 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object[] args = default;
			Log.Json.LogErrorFormat("Unsupported data type in Settings: {0}", args);
		}
		return null;
	}

	public unsafe static void ReflectionDeserializeOnto(Type objType, object obj, JsonDict json, JsonContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected I, but got Unknown
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected Obj, but got Unknown
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected Obj, but got Unknown
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected Obj, but got Unknown
		//IL_09db: Expected Obj, but got I4
		//IL_09f0: Expected Obj, but got I4
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Expected Obj, but got Unknown
		//IL_0a07: Expected Obj, but got I4
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0a5b: Expected I, but got Obj
		//IL_0062: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_01db: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_08b6: Expected Obj, but got I
		//IL_0b89: Expected I, but got Obj
		//IL_0ada: Expected Obj, but got I4
		//IL_0ae3: Expected Obj, but got I4
		//IL_021c: Expected I, but got Obj
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I4
		//IL_0c86: Expected Obj, but got I
		//IL_0c96: Expected Obj, but got I
		//IL_0ca6: Expected Obj, but got I
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected Obj, but got Unknown
		//IL_0cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Expected Obj, but got Unknown
		//IL_029d: Expected Obj, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_02bd: Expected Obj, but got I4
		//IL_02d4: Expected Obj, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_094f: Expected Obj, but got I
		//IL_095f: Expected Obj, but got I
		//IL_096f: Expected Obj, but got I
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected Obj, but got Unknown
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected Obj, but got Unknown
		//IL_0c13: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got I4
		//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcb: Expected Obj, but got Unknown
		//IL_032c: Expected Obj, but got I4
		//IL_033e: Expected Obj, but got I
		//IL_034c: Expected I, but got Obj
		//IL_0362: Expected Obj, but got I
		//IL_0bfb: Expected Obj, but got I4
		//IL_038d: Expected I, but got Obj
		//IL_0452: Expected Obj, but got I4
		//IL_03d0: Expected Obj, but got I4
		//IL_07fe: Expected Obj, but got I
		//IL_0422: Expected Obj, but got I4
		//IL_043a: Expected Obj, but got I4
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected Obj, but got Unknown
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected Obj, but got Unknown
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Expected Obj, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected Obj, but got Unknown
		//IL_0797: Expected Obj, but got I4
		object obj3 = default;
		object obj2 = obj3 + 80;
		nint num = (nint)(obj3 + 8);
		object obj4 = obj3 + 48;
		object obj5 = obj3 + 32;
		object obj6 = obj3 + 56;
		obj6 = 0;
		_ = 0;
		_ = 0;
		obj3 = 0;
		object obj7 = obj3 + 52;
		obj7 = 0;
		object obj8 = obj3 + 40;
		obj8 = obj2;
		_ = -1;
		if (obj == null)
		{
			return;
		}
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (Il2CppClass<System.Type>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v234 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj4 = typeof(IList<>);
		((IntPtr*)num)->m_value = (void*)(nint)obj4;
		Type directoryPath = Type.internal_from_handle((IntPtr)num);
		bool flag = ((AssetLoaderPathAttribute)(object)objType).ValidateDirectoryPath((string)(object)directoryPath);
		if (flag)
		{
			bool flag2 = ReflectionWrapper.IsPrimitive((Type)flag);
			object objType2 = (flag2 ? 1 : 0) + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			List<object> list = default;
			if (list != null)
			{
				int num4 = 0;
				while (num4 < list._size)
				{
					object obj10 = list.get_Item(num4);
					ReflectionDeserializeOnto((Type)objType2, obj10, json, context);
					int num5 = num4 + 1;
					num4 = num5;
				}
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num6 = default;
			object obj11 = num6 + 16;
			obj11 = 44;
			string text2 = default;
			string text = text2.Substring(num6);
			object obj12 = text + 12;
			object obj13 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				object obj14 = text + 16;
				object obj15 = obj13 << 2;
				object str = obj14 + obj15;
				string obj16 = string.Copy((string)str);
				ReflectionDeserializeOnto((Type)objType2, obj16, json, context);
				object obj17 = obj13 + 1;
				obj13 = obj17;
			}
			return;
		}
		object obj34;
		object obj35 = default;
		object obj32;
		if (ReflectionWrapper.IsAbstract(objType))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num7 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v40 (Il2CppClass<System.Type>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num8 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v121 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = typeof(Dictionary<, >);
			((IntPtr*)num)->m_value = (void*)(nint)obj5;
			Type type = Type.internal_from_handle((IntPtr)num);
			object obj19 = default;
			if (obj19 == type)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				object obj20 = default;
				if (obj20 == null)
				{
					return;
				}
				bool flag3 = ReflectionWrapper.IsPrimitive(objType);
				object obj21 = (flag3 ? 1 : 0) + 16;
				bool flag4 = ReflectionWrapper.IsPrimitive(objType);
				object obj22 = (flag4 ? 1 : 0) + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
				obj6 = (object)((IntPtr*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+10]");
				_ = 0;
				object obj24 = default;
				object obj26 = default;
				object obj23;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj23 = 44;
					bool flag5 = obj24 == null;
					obj23 = 45;
					if (flag5)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj23 = 26;
					obj3 = (object)((IntPtr*)num)->m_value;
					nint num9 = (nint)typeof(JsonClassInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S0_v158 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num10 = (nint)typeof(JsonClassInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S0_v200 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							obj23 = 27;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj23 = 31;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj26 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						obj23 = 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
						obj23 = 41;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj23 = 42;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
				}
				object obj27 = obj23 - 26;
				if ((nint)obj23 != 26 && (nint)obj27 != 1)
				{
					if ((nint)obj27 != 2 && (nint)obj27 != 3 && (nint)obj27 != 4)
					{
						if ((nint)obj27 == 5 || (nint)obj27 == 6)
						{
							goto IL_079c;
						}
						if ((nint)obj27 != 7 && (nint)obj27 != 8 && (nint)obj27 != 9 && (nint)obj27 != 10 && (nint)obj27 != 11 && (nint)obj27 != 12 && (nint)obj27 != 13)
						{
							if ((nint)obj27 != 14)
							{
								if ((nint)obj27 != 15)
								{
									if ((nint)obj27 != 16)
									{
										if ((nint)obj27 != 17)
										{
											if ((nint)obj27 != 18)
											{
												if ((nint)obj27 == 19)
												{
													object obj28 = obj8 + 4;
													object obj29 = obj28 + 1;
													obj28 = obj29;
													object obj30 = obj29 << 2;
													object obj31 = obj8 + obj30;
													obj31 = 373;
												}
												goto IL_0cd1;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj33 = default;
											obj32 = obj33;
											obj34 = obj35;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj36 = default;
											obj32 = obj36;
											obj34 = obj35;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj37 = default;
										obj32 = obj37;
										obj34 = obj35;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj38 = default;
									obj32 = obj38;
									obj34 = obj35;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj39 = default;
								obj32 = obj39;
								obj34 = obj35;
							}
							goto IL_0c1d;
						}
					}
					goto IL_0cd1;
				}
				goto IL_079c;
			}
		}
		goto IL_0b3d;
		IL_0cd1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v25+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v25+4]");
			object obj40 = (nint)0 << 2;
			object obj41 = obj8 + obj40;
			if ((nint)obj41 == 373)
			{
				object obj42 = obj8 + 4;
				if ((nint)obj42 > -1)
				{
					object obj43 = obj42 + -1;
					obj42 = obj43;
				}
				return;
			}
		}
		object obj44 = default;
		if (obj44 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0b3d;
		IL_0c1d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj45 = default;
		if (obj34 == obj45)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0cd1;
		IL_0b3d:
		if (ReflectionWrapper.IsEnum(objType))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [json @ L2 (SYBO.Components.Json.JsonDict)+8]");
		ref bool success = default;
		object obj46 = JsonParser.ParseValue((string)0, ref *(int*)objType, ref success);
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
			object obj47 = default;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				HashSet<> hashSet = default;
				((HashSet<T>)(object)hashSet).Clear();
				obj7 = hashSet;
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S4_v7 (Il2CppMethodInfo)+C]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S4_v8+60]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S4_v9+48]");
				object obj50 = 0;
				object obj51 = obj50 & 0x7FF;
				object obj52 = obj51 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v335 @ S5_v7 (should have been resolved before IL gen)");
			}
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S2_v9 (Il2CppMethodInfo)+C]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S2_v10+60]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S2_v11+38]");
			object obj55 = 0;
			object obj56 = obj55 & 0x1FFF;
			object obj57 = obj56 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v117 @ S3_v10 (should have been resolved before IL gen)");
		}
		return;
		IL_079c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj58 = default;
		obj32 = obj58;
		obj34 = obj35;
		goto IL_0c1d;
	}

	private static void DeserializeFieldsOnto(JsonFieldInfo[] fields, object obj, JsonDict json, JsonContext context)
	{
		//IL_00d6: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(JsonClassInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		JsonClassInfo nonCachedTypeReflection = JsonClassInfo.GetNonCachedTypeReflection((Type)(object)fields);
		DeserializeFieldOnto((JsonFieldInfo)(object)nonCachedTypeReflection.CachedSerializedFields, obj, json, context);
		if (~(context.IncludeStatics ? 1u : 0u) == 0)
		{
			DeserializeFieldOnto((JsonFieldInfo)(object)nonCachedTypeReflection.CachedSerializedStaticFields, obj, json, context);
		}
		if (JsonClassInfo.IsClassInfoCached((Type)(object)nonCachedTypeReflection))
		{
			object context2 = nonCachedTypeReflection.Construct((JsonContext)obj);
			CollectReferenceUnknownKeys((Type)(object)context.ObjectStore, fields, (JsonContext)context2, (Dictionary<Type, HashSet<string>>)obj);
		}
	}

	public static void DeserializeFieldOnto(JsonFieldInfo jsonField, object obj, JsonDict json, JsonContext context)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		object obj2 = jsonField + 12;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = jsonField + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			if (context.ShouldFilterField == null || !context.ShouldFilterField((JsonFieldInfo)obj6))
			{
				string[] callstackPrefixes = ((EditorExtensionsLogCategory)obj6).GetCallstackPrefixes();
				if (callstackPrefixes != null)
				{
					((DecryptionException)obj)._002Ector((string)obj6, (Exception)(object)context);
				}
				else
				{
					SerializeFieldsFrom((JsonFieldInfo[])obj6, obj, json, context);
				}
			}
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
	}

	public static JsonDict ReflectionSerialize(Type type, object obj, JsonContext context)
	{
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_0102: Expected I4, but got Obj
		//IL_0074: Expected I, but got Obj
		bool flag = context == null;
		bool flag2 = !flag;
		JsonCustomSerializer jsonCustomSerializer = (JsonCustomSerializer)(object)context;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonCustomSerializer jsonCustomSerializer2 = default;
			jsonCustomSerializer2._002Ector();
			jsonCustomSerializer = jsonCustomSerializer2;
		}
		nint num = (nint)typeof(JsonClassInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v9 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		JsonClassInfo nonCachedTypeReflection = JsonClassInfo.GetNonCachedTypeReflection(type);
		JsonFieldInfo[] jsonFields = nonCachedTypeReflection.GetJsonFields((BindingFlags)jsonCustomSerializer);
		DeserializeFieldsOnto((JsonFieldInfo[])(object)type, jsonFields, (JsonDict)obj, (JsonContext)(object)jsonCustomSerializer);
		return (JsonDict)(object)jsonFields;
	}

	public static void PrepareReflectionForSerialization(Type[] serializationObjectTypes)
	{
	}

	private static void PrepareReflectionRecursively(Type type, HashSet<Type> preparedClasses)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [preparedClasses @ L1 (System.Collections.Generic.HashSet`1<System.Type>)+11]");
		if ((nint)0 != 0)
		{
			return;
		}
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] value = SimpleAES.GenerateKey();
		StringBuilder stringBuilder = ((StringBuilder)(object)type).AppendLine((string)(object)value);
	}

	private static void SerializeFieldsFrom(JsonFieldInfo[] fields, object obj, JsonDict json, JsonContext context)
	{
		//IL_008c: Expected Obj, but got I
		object key = ((JsonFieldInfo)(object)fields).GetKey((object)json);
		if (key != null)
		{
			if (fields[0] != null)
			{
				((JsonObjectStore)(object)context).Set((Type)obj, (object)fields, key);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [fields @ L0 (SYBO.Components.Json.JsonFieldInfo[])+8]");
			((CounterModeCryptoTransform)obj)._002Ector((SymmetricAlgorithm)0, (byte[])key, (byte[])(object)context);
		}
	}

	private static bool NeedsFileReference(JsonFieldInfo field)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		bool result = default;
		return result;
	}

	private static void CreateFileReference(object obj, JsonFieldInfo field, JsonContext context)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		object obj2 = context & 1;
	}

	private static object RecursiveWriteValue(object value, Type ft, JsonFieldInfo field, JsonContext context)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8DFD");
		string text = default;
		JsonFieldInfo obj;
		if (text != null)
		{
			JsonList jsonList = JsonList.ParseString(text);
			if (jsonList != null)
			{
				obj = (JsonFieldInfo)(object)jsonList;
				goto IL_005c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonFieldInfo jsonFieldInfo = default;
		jsonFieldInfo._002Ector();
		obj = jsonFieldInfo;
		goto IL_005c;
		IL_005c:
		return ReflectionSerialize(ft, obj, context);
	}

	private static string GetKey(object obj, Type type)
	{
		//IL_0d2c: Expected I, but got Obj
		//IL_0d42: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_08a6: Expected Obj, but got I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_03b8: Expected Obj, but got I4
		//IL_0d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d72: Expected Obj, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Expected Obj, but got Unknown
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0910: Expected Obj, but got Unknown
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd6: Expected Obj, but got Unknown
		//IL_0e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Expected Obj, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected Obj, but got Unknown
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Expected Obj, but got Unknown
		//IL_0ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abe: Expected Obj, but got Unknown
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Expected Obj, but got Unknown
		//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be1: Expected Obj, but got Unknown
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Expected Obj, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_099b: Expected Obj, but got Unknown
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected Obj, but got Unknown
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected Obj, but got Unknown
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected Obj, but got Unknown
		//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c36: Expected Obj, but got Unknown
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Expected Obj, but got Unknown
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected Obj, but got Unknown
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Expected Obj, but got Unknown
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected Obj, but got Unknown
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Expected Obj, but got Unknown
		//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8b: Expected Obj, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected Obj, but got Unknown
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected Obj, but got Unknown
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected Obj, but got Unknown
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Expected Obj, but got Unknown
		//IL_0bce: Expected Obj, but got I4
		//IL_0cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce0: Expected Obj, but got Unknown
		//IL_0cf1: Expected Obj, but got I4
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0aab: Expected Obj, but got I4
		//IL_03cb: Expected Obj, but got I4
		//IL_03d9: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I4
		//IL_03f5: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got I4
		//IL_0411: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I4
		//IL_042d: Expected Obj, but got I4
		//IL_043b: Expected Obj, but got I4
		//IL_0449: Expected Obj, but got I4
		//IL_0457: Expected Obj, but got I4
		//IL_0465: Expected Obj, but got I4
		//IL_0473: Expected Obj, but got I4
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_049e: Expected Obj, but got I4
		//IL_08b4: Expected Obj, but got I4
		//IL_08c2: Expected Obj, but got I4
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v121 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		JsonParser.SerializeString((string)obj, (StringBuilder)(object)type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ L0 (System.Object)+8]");
		string result;
		Type type2;
		if ((object)type == null)
		{
			result = null;
		}
		else
		{
			string[] array = ((string)obj).Split((char[])(object)type);
			object obj3 = type + 1;
			type2 = (Type)obj3;
			object obj4 = array & 0xFFFF;
			if ((nint)obj4 < 92)
			{
				object obj5 = array & 0xFFFF;
				object obj6 = obj5 - 34;
				if ((nint)obj5 != 34)
				{
					if ((nint)obj6 == 1 || (nint)obj6 == 2 || (nint)obj6 == 3 || (nint)obj6 == 4 || (nint)obj6 == 5 || (nint)obj6 == 6 || (nint)obj6 == 7 || (nint)obj6 == 8 || (nint)obj6 == 9)
					{
						goto IL_0d64;
					}
					if ((nint)obj6 != 10)
					{
						if ((nint)obj6 != 11)
						{
							if ((nint)obj6 == 12 || (nint)obj6 == 13)
							{
								goto IL_0d64;
							}
							if ((nint)obj6 != 14)
							{
								if ((nint)obj6 != 15)
								{
									if ((nint)obj6 != 16)
									{
										if ((nint)obj6 != 17)
										{
											if ((nint)obj6 != 18)
											{
												if ((nint)obj6 != 19)
												{
													if ((nint)obj6 != 20)
													{
														if ((nint)obj6 != 21)
														{
															if ((nint)obj6 != 22)
															{
																if ((nint)obj6 != 23)
																{
																	if ((nint)obj6 == 24)
																	{
																		result = (string)5;
																	}
																	else
																	{
																		object obj7 = array & 0xFFFF;
																		bool flag = (nint)obj7 == 91;
																		result = (string)3;
																		if (!flag)
																		{
																			goto IL_0d64;
																		}
																	}
																}
																else
																{
																	result = (string)8;
																}
															}
															else
															{
																result = (string)8;
															}
														}
														else
														{
															result = (string)8;
														}
													}
													else
													{
														result = (string)8;
													}
												}
												else
												{
													result = (string)8;
												}
											}
											else
											{
												result = (string)8;
											}
										}
										else
										{
											result = (string)8;
										}
									}
									else
									{
										result = (string)8;
									}
								}
								else
								{
									result = (string)8;
								}
							}
							else
							{
								result = (string)8;
							}
						}
						else
						{
							result = (string)8;
						}
					}
					else
					{
						result = (string)6;
					}
				}
				else
				{
					result = (string)7;
				}
			}
			else
			{
				object obj8 = (object)array << 16;
				object obj9 = obj8 >> 16;
				object obj10 = obj9 - 93;
				if ((nint)obj9 != 93)
				{
					if ((nint)obj10 == 1 || (nint)obj10 == 2 || (nint)obj10 == 3 || (nint)obj10 == 4 || (nint)obj10 == 5 || (nint)obj10 == 6 || (nint)obj10 == 7 || (nint)obj10 == 8 || (nint)obj10 == 9 || (nint)obj10 == 10 || (nint)obj10 == 11 || (nint)obj10 == 12 || (nint)obj10 == 13 || (nint)obj10 == 14 || (nint)obj10 == 15 || (nint)obj10 == 16 || (nint)obj10 == 17 || (nint)obj10 == 18 || (nint)obj10 == 19 || (nint)obj10 == 20 || (nint)obj10 == 21 || (nint)obj10 == 22 || (nint)obj10 == 23 || (nint)obj10 == 24 || (nint)obj10 == 25 || (nint)obj10 == 26 || (nint)obj10 == 27 || (nint)obj10 == 28 || (nint)obj10 == 29)
					{
						goto IL_0d64;
					}
					if ((nint)obj10 != 30)
					{
						if ((nint)obj10 == 31 || (nint)obj10 != 32)
						{
							goto IL_0d64;
						}
						result = (string)2;
					}
					else
					{
						result = (string)1;
					}
				}
				else
				{
					result = (string)4;
				}
			}
		}
		goto IL_0d5f;
		IL_0d64:
		object obj11 = type - 1;
		type2 = (Type)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ L0 (System.Object)+8]");
		object obj12 = 0 - type;
		if ((nint)obj12 < 5)
		{
			bool flag2 = (nint)obj12 != 4;
			result = null;
			if (flag2)
			{
				goto IL_0d5f;
			}
		}
		else
		{
			string[] array2 = ((string)obj).Split((char[])(object)type);
			object obj13 = array2 & 0xFFFF;
			if ((nint)obj13 == 102)
			{
				char[] separator = (char[])(type + 1);
				string[] array3 = ((string)obj).Split(separator);
				object obj14 = array3 & 0xFFFF;
				if ((nint)obj14 == 97)
				{
					char[] separator2 = (char[])(type + 2);
					string[] array4 = ((string)obj).Split(separator2);
					object obj15 = array4 & 0xFFFF;
					if ((nint)obj15 == 108)
					{
						char[] separator3 = (char[])(type + 3);
						string[] array5 = ((string)obj).Split(separator3);
						object obj16 = array5 & 0xFFFF;
						if ((nint)obj16 == 115)
						{
							char[] separator4 = (char[])(type + 4);
							string[] array6 = ((string)obj).Split(separator4);
							object obj17 = array6 & 0xFFFF;
							if ((nint)obj17 == 101)
							{
								object obj18 = type + 5;
								type2 = (Type)obj18;
								result = (string)10;
								goto IL_0d5f;
							}
						}
					}
				}
			}
		}
		string[] array7 = ((string)obj).Split((char[])(object)type);
		object obj19 = array7 & 0xFFFF;
		if ((nint)obj19 == 116)
		{
			char[] separator5 = (char[])(type + 1);
			string[] array8 = ((string)obj).Split(separator5);
			object obj20 = array8 & 0xFFFF;
			if ((nint)obj20 == 114)
			{
				char[] separator6 = (char[])(type + 2);
				string[] array9 = ((string)obj).Split(separator6);
				object obj21 = array9 & 0xFFFF;
				if ((nint)obj21 == 117)
				{
					char[] separator7 = (char[])(type + 3);
					string[] array10 = ((string)obj).Split(separator7);
					object obj22 = array10 & 0xFFFF;
					if ((nint)obj22 == 101)
					{
						object obj23 = type + 4;
						type2 = (Type)obj23;
						result = (string)9;
						goto IL_0d5f;
					}
				}
			}
		}
		string[] array11 = ((string)obj).Split((char[])(object)type);
		object obj24 = array11 & 0xFFFF;
		if ((nint)obj24 == 110)
		{
			char[] separator8 = (char[])(type + 1);
			string[] array12 = ((string)obj).Split(separator8);
			object obj25 = array12 & 0xFFFF;
			if ((nint)obj25 == 117)
			{
				char[] separator9 = (char[])(type + 2);
				string[] array13 = ((string)obj).Split(separator9);
				object obj26 = array13 & 0xFFFF;
				if ((nint)obj26 == 108)
				{
					char[] separator10 = (char[])(type + 3);
					string[] array14 = ((string)obj).Split(separator10);
					object obj27 = array14 & 0xFFFF;
					if ((nint)obj27 == 108)
					{
						object obj28 = type + 4;
						type2 = (Type)obj28;
						result = (string)11;
					}
					else
					{
						result = null;
					}
				}
				else
				{
					result = null;
				}
			}
			else
			{
				result = null;
			}
		}
		else
		{
			result = null;
		}
		goto IL_0d5f;
		IL_0d5f:
		return result;
	}

	private static JsonDict RecursiveWriteObject(object obj, JsonContext context)
	{
		//IL_0092: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(JsonClassInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		JsonClassInfo nonCachedTypeReflection = JsonClassInfo.GetNonCachedTypeReflection((Type)(object)context);
		if (JsonClassInfo.IsClassInfoCached((Type)(object)nonCachedTypeReflection))
		{
			return (JsonDict)nonCachedTypeReflection.Construct((JsonContext)obj);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		JsonDict result = default;
		return result;
	}

	private static object RecursiveReadValue(Type type, object value, JsonContext context)
	{
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(JsonClassInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		JsonClassInfo nonCachedTypeReflection = JsonClassInfo.GetNonCachedTypeReflection(type);
		JsonFieldInfo[] cachedSerializedFields = nonCachedTypeReflection.CachedSerializedFields;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonList jsonList = default;
		jsonList._002Ector(cachedSerializedFields.Length);
		if (JsonClassInfo.IsClassInfoCached((Type)(object)nonCachedTypeReflection))
		{
			object context2 = nonCachedTypeReflection.Construct((JsonContext)value);
			CollectReferenceUnknownKeys((Type)(object)context.ObjectStore, type, (JsonContext)context2, (Dictionary<Type, HashSet<string>>)value);
		}
		RecursiveReadField(nonCachedTypeReflection.CachedSerializedFields, (FieldInfo)value, jsonList, context);
		if (~(context.IncludeStatics ? 1u : 0u) == 0)
		{
			RecursiveReadField(nonCachedTypeReflection.CachedSerializedStaticFields, (FieldInfo)value, jsonList, context);
		}
		return jsonList;
	}

	private static object ConvertOrDefault<T>(object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02d6: Expected Obj, but got I
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 20;
		obj4 = 0;
		object obj5 = obj2 + 8;
		obj5 = obj;
		_ = -1;
		nint num = default;
		object obj6 = num + 24;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj8 = default;
		if (obj8 != null)
		{
			return value;
		}
		object obj9 = obj6;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v27 (Il2CppClass<System.Type>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v109 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+4]");
		obj2 = 0;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj15 = default;
		if (obj13 == obj15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj17 = default;
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj19 = default;
			object obj18 = obj19;
		}
		else
		{
			object obj18 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		object result = default;
		return result;
	}

	private unsafe static object DictionaryResolveKey(string key, Type type, JsonContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0b: Expected I, but got Unknown
		//IL_1d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d19: Expected Obj, but got Unknown
		//IL_1d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d27: Expected Obj, but got Unknown
		//IL_1d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d35: Expected Obj, but got Unknown
		//IL_1d3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d43: Expected Obj, but got Unknown
		//IL_1d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d51: Expected Obj, but got Unknown
		//IL_1d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5f: Expected Obj, but got Unknown
		//IL_1d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6d: Expected Obj, but got Unknown
		//IL_1d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7b: Expected Obj, but got Unknown
		//IL_1d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d89: Expected Obj, but got Unknown
		//IL_1d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d97: Expected Obj, but got Unknown
		//IL_1da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da5: Expected Obj, but got Unknown
		//IL_1dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db3: Expected Obj, but got Unknown
		//IL_1dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc1: Expected Obj, but got Unknown
		//IL_1dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dcf: Expected Obj, but got Unknown
		//IL_1dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddd: Expected Obj, but got Unknown
		//IL_1de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1deb: Expected Obj, but got Unknown
		//IL_1df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df9: Expected Obj, but got Unknown
		//IL_1e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e07: Expected Obj, but got Unknown
		//IL_1e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e15: Expected Obj, but got Unknown
		//IL_1e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e23: Expected Obj, but got Unknown
		//IL_1e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e31: Expected Obj, but got Unknown
		//IL_1e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3f: Expected Obj, but got Unknown
		//IL_1e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4d: Expected Obj, but got Unknown
		//IL_1e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5b: Expected Obj, but got Unknown
		//IL_1e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e69: Expected Obj, but got Unknown
		//IL_1e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e77: Expected Obj, but got Unknown
		//IL_1e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e85: Expected Obj, but got Unknown
		//IL_1e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e93: Expected Obj, but got Unknown
		//IL_1e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea1: Expected Obj, but got Unknown
		//IL_1eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eaf: Expected Obj, but got Unknown
		//IL_1eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebd: Expected Obj, but got Unknown
		//IL_1ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecb: Expected Obj, but got Unknown
		//IL_1ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed9: Expected Obj, but got Unknown
		//IL_1ee2: Expected Obj, but got I4
		//IL_1ef7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efc: Expected Obj, but got Unknown
		//IL_1f05: Expected Obj, but got I4
		//IL_1f0e: Expected Obj, but got I4
		//IL_1f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1c: Expected Obj, but got Unknown
		//IL_0178: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I
		//IL_1fc0: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I
		//IL_01b9: Expected I, but got Obj
		//IL_1f62: Expected I, but got Obj
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_0095: Expected I, but got Obj
		//IL_2024: Expected I, but got Obj
		//IL_0247: Expected I, but got Obj
		//IL_0294: Expected I, but got Obj
		//IL_02aa: Expected Obj, but got I
		//IL_2076: Expected I, but got Obj
		//IL_02d5: Expected I, but got Obj
		//IL_0322: Expected I, but got Obj
		//IL_0338: Expected Obj, but got I
		//IL_20e2: Expected I, but got Obj
		//IL_0363: Expected I, but got Obj
		//IL_03b0: Expected I, but got Obj
		//IL_03c6: Expected Obj, but got I
		//IL_2134: Expected I, but got Obj
		//IL_03f1: Expected I, but got Obj
		//IL_043e: Expected I, but got Obj
		//IL_0454: Expected Obj, but got I
		//IL_21a0: Expected I, but got Obj
		//IL_047f: Expected I, but got Obj
		//IL_04cc: Expected I, but got Obj
		//IL_04e2: Expected Obj, but got I
		//IL_21f2: Expected I, but got Obj
		//IL_050d: Expected I, but got Obj
		//IL_0540: Expected I, but got Obj
		//IL_0556: Expected Obj, but got I
		//IL_2244: Expected I, but got Obj
		//IL_0581: Expected I, but got Obj
		//IL_05b4: Expected I, but got Obj
		//IL_05ca: Expected Obj, but got I
		//IL_22a2: Expected I, but got Obj
		//IL_05f5: Expected I, but got Obj
		//IL_0628: Expected I, but got Obj
		//IL_063e: Expected Obj, but got I
		//IL_22f4: Expected I, but got Obj
		//IL_0669: Expected I, but got Obj
		//IL_069c: Expected I, but got Obj
		//IL_06b2: Expected Obj, but got I
		//IL_2352: Expected I, but got Obj
		//IL_06dd: Expected I, but got Obj
		//IL_0710: Expected I, but got Obj
		//IL_0726: Expected Obj, but got I
		//IL_23a4: Expected I, but got Obj
		//IL_0751: Expected I, but got Obj
		//IL_0784: Expected I, but got Obj
		//IL_079a: Expected Obj, but got I
		//IL_2402: Expected I, but got Obj
		//IL_07c5: Expected I, but got Obj
		//IL_07f8: Expected I, but got Obj
		//IL_080e: Expected Obj, but got I
		//IL_2454: Expected I, but got Obj
		//IL_0839: Expected I, but got Obj
		//IL_086c: Expected I, but got Obj
		//IL_0882: Expected Obj, but got I
		//IL_24b2: Expected I, but got Obj
		//IL_08ad: Expected I, but got Obj
		//IL_08e0: Expected I, but got Obj
		//IL_08f6: Expected Obj, but got I
		//IL_2504: Expected I, but got Obj
		//IL_0921: Expected I, but got Obj
		//IL_0954: Expected I, but got Obj
		//IL_096a: Expected Obj, but got I
		//IL_2562: Expected I, but got Obj
		//IL_0995: Expected I, but got Obj
		//IL_09c8: Expected I, but got Obj
		//IL_09de: Expected Obj, but got I
		//IL_25b4: Expected I, but got Obj
		//IL_0a09: Expected I, but got Obj
		//IL_0a3c: Expected I, but got Obj
		//IL_0a52: Expected Obj, but got I
		//IL_2612: Expected I, but got Obj
		//IL_0a7d: Expected I, but got Obj
		//IL_0ab0: Expected I, but got Obj
		//IL_0ac6: Expected Obj, but got I
		//IL_2664: Expected I, but got Obj
		//IL_0af1: Expected I, but got Obj
		//IL_0b24: Expected I, but got Obj
		//IL_0b3a: Expected Obj, but got I
		//IL_26c2: Expected I, but got Obj
		//IL_0b65: Expected I, but got Obj
		//IL_0b98: Expected I, but got Obj
		//IL_0bae: Expected Obj, but got I
		//IL_2714: Expected I, but got Obj
		//IL_0bd9: Expected I, but got Obj
		//IL_0c0c: Expected I, but got Obj
		//IL_0c22: Expected Obj, but got I
		//IL_1ce4: Expected I4, but got Obj
		//IL_2775: Expected I, but got Obj
		//IL_0d07: Expected I, but got Obj
		//IL_0d1d: Expected Obj, but got I
		//IL_0c4d: Expected I, but got Obj
		//IL_27c9: Expected I, but got Obj
		//IL_0dd8: Expected I, but got Obj
		//IL_0dee: Expected Obj, but got I
		//IL_0d48: Expected I, but got Obj
		//IL_2818: Expected I, but got Obj
		//IL_0ea9: Expected I, but got Obj
		//IL_0ebf: Expected Obj, but got I
		//IL_0e19: Expected I, but got Obj
		//IL_2867: Expected I, but got Obj
		//IL_0eea: Expected I, but got Obj
		//IL_0dbb: Expected I4, but got Obj
		//IL_2a56: Expected I, but got Obj
		//IL_2a6c: Expected Obj, but got I
		//IL_2b4c: Expected I, but got Obj
		//IL_121d: Expected I, but got Obj
		//IL_1233: Expected Obj, but got I
		//IL_0e8c: Expected I4, but got Obj
		//IL_18c2: Expected I, but got Obj
		//IL_18d8: Expected Obj, but got I
		//IL_1591: Expected I, but got Obj
		//IL_2a1c: Expected I, but got Obj
		//IL_2ce7: Expected I, but got Obj
		//IL_125e: Expected I, but got Obj
		//IL_0f7a: Expected Obj, but got I4
		//IL_0f83: Expected Obj, but got I4
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Expected Obj, but got Unknown
		//IL_0fab: Expected Obj, but got I4
		//IL_28cd: Expected Obj, but got I4
		//IL_28df: Expected Obj, but got I4
		//IL_28f7: Expected I, but got Obj
		//IL_290d: Expected Obj, but got I
		//IL_1903: Expected I, but got Obj
		//IL_296c: Expected I, but got Obj
		//IL_1021: Expected I, but got Obj
		//IL_1671: Expected I, but got Obj
		//IL_1687: Expected Obj, but got I
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbe: Expected Obj, but got Unknown
		//IL_2b9c: Expected I, but got Obj
		//IL_2bb2: Expected Obj, but got I
		//IL_133c: Expected Obj, but got I4
		//IL_1357: Expected Obj, but got I4
		//IL_12e3: Expected I4, but got Obj
		//IL_1001: Unknown result type (might be due to invalid IL or missing references)
		//IL_1006: Expected Obj, but got Unknown
		//IL_1a9c: Expected I4, but got Obj
		//IL_2bea: Expected Obj, but got I4
		//IL_2bea: Expected I4, but got Obj
		//IL_16b2: Expected I, but got Obj
		//IL_1654: Expected I4, but got Obj
		//IL_1373: Expected Obj, but got I
		//IL_1b0c: Expected I, but got Obj
		//IL_1b22: Expected Obj, but got I
		//IL_1a12: Expected I4, but got Obj
		//IL_19a2: Expected I, but got Obj
		//IL_2c9a: Expected I, but got Obj
		//IL_16e5: Expected I, but got Obj
		//IL_2d90: Expected Obj, but got I4
		//IL_1718: Expected I, but got Obj
		//IL_172e: Expected Obj, but got I
		//IL_1b4d: Expected I, but got Obj
		//IL_2c2d: Expected I, but got Obj
		//IL_2c43: Expected Obj, but got I
		//IL_1443: Unknown result type (might be due to invalid IL or missing references)
		//IL_1448: Expected Obj, but got Unknown
		//IL_1451: Unknown result type (might be due to invalid IL or missing references)
		//IL_1456: Expected Obj, but got Unknown
		//IL_1482: Expected Obj, but got I4
		//IL_1bf0: Expected I, but got Obj
		//IL_1c06: Expected Obj, but got I
		//IL_2c7b: Expected Obj, but got I4
		//IL_2c7b: Expected I4, but got Obj
		//IL_1759: Expected I, but got Obj
		//IL_2daf: Expected I4, but got Obj
		//IL_178c: Expected I, but got Obj
		//IL_13cb: Expected Obj, but got I
		//IL_1c31: Expected I, but got Obj
		//IL_14e9: Expected Obj, but got I
		//IL_151f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1524: Expected Obj, but got Unknown
		//IL_1555: Unknown result type (might be due to invalid IL or missing references)
		//IL_155a: Expected Obj, but got Unknown
		CultureInfo cultureInfo = default;
		object obj = cultureInfo + 224;
		nint num = (nint)(cultureInfo + 16);
		object obj2 = cultureInfo + 212;
		object obj3 = cultureInfo + 208;
		object obj4 = cultureInfo + 204;
		object obj5 = cultureInfo + 200;
		object obj6 = cultureInfo + 196;
		object obj7 = cultureInfo + 192;
		object obj8 = cultureInfo + 188;
		object obj9 = cultureInfo + 184;
		object obj10 = cultureInfo + 180;
		object obj11 = cultureInfo + 176;
		object obj12 = cultureInfo + 172;
		object obj13 = cultureInfo + 168;
		object obj14 = cultureInfo + 164;
		object obj15 = cultureInfo + 160;
		object obj16 = cultureInfo + 156;
		object obj17 = cultureInfo + 152;
		object obj18 = cultureInfo + 148;
		object obj19 = cultureInfo + 144;
		object obj20 = cultureInfo + 140;
		object obj21 = cultureInfo + 136;
		object obj22 = cultureInfo + 132;
		object obj23 = cultureInfo + 128;
		object obj24 = cultureInfo + 124;
		object obj25 = cultureInfo + 120;
		object obj26 = cultureInfo + 116;
		object obj27 = cultureInfo + 112;
		object obj28 = cultureInfo + 80;
		object obj29 = cultureInfo + 76;
		object obj30 = cultureInfo + 72;
		object obj31 = cultureInfo + 60;
		object obj32 = cultureInfo + 56;
		object obj33 = cultureInfo + 40;
		object obj34 = cultureInfo + 88;
		obj34 = 0;
		_ = 0;
		_ = 0;
		object obj35 = cultureInfo + 8;
		obj35 = 0;
		cultureInfo = (CultureInfo)0;
		object obj36 = cultureInfo - -64;
		obj36 = obj;
		_ = -1;
		object result;
		object obj111;
		if ((object)type != null)
		{
			JsonDict dict = ((JsonDict)(object)context.CustomSerializers).GetDict(key);
			if (dict != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v971 (Il2CppClass<System.Type>)+BA]");
				object obj37 = (nint)0 & (nint)0x200;
				if (obj37 != null)
				{
					nint num3 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v986 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(IList<>);
				((IntPtr*)num)->m_value = (void*)(nint)obj2;
				Type directoryPath = Type.internal_from_handle((IntPtr)num);
				bool flag = ((AssetLoaderPathAttribute)(object)key).ValidateDirectoryPath((string)(object)directoryPath);
				bool flag2 = flag;
				context.EndDeserialize();
				JsonList jsonList;
				if (flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
					string filename = default;
					object obj38 = ((JsonFileSerializer)(object)context.CustomSerializers).DeserializeFromMultipleFiles((Type)(object)key, filename, context);
					jsonList = (JsonList)obj38;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
					object obj39 = default;
					jsonList = context.CustomSerializers.SerializeList((Type)(object)key, obj39, context);
				}
				context.BeginSerialize();
				result = jsonList;
				goto IL_1fa0;
			}
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v99 (Il2CppClass<System.Type>)+BA]");
			object obj40 = (nint)0 & (nint)0x200;
			if (obj40 != null)
			{
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v964 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = typeof(int);
			((IntPtr*)num)->m_value = (void*)(nint)obj3;
			Type type2 = Type.internal_from_handle((IntPtr)num);
			if ((object)key != type2)
			{
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v113 (Il2CppClass<System.Type>)+BA]");
				object obj41 = (nint)0 & (nint)0x200;
				if (obj41 != null)
				{
					nint num7 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S0_v960 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj4 = typeof(int?);
				((IntPtr*)num)->m_value = (void*)(nint)obj4;
				Type type3 = Type.internal_from_handle((IntPtr)num);
				if ((object)key != type3)
				{
					nint num8 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v124 (Il2CppClass<System.Type>)+BA]");
					object obj42 = (nint)0 & (nint)0x200;
					if (obj42 != null)
					{
						nint num9 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v956 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj5 = typeof(short);
					((IntPtr*)num)->m_value = (void*)(nint)obj5;
					Type type4 = Type.internal_from_handle((IntPtr)num);
					if ((object)key != type4)
					{
						nint num10 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S0_v138 (Il2CppClass<System.Type>)+BA]");
						object obj43 = (nint)0 & (nint)0x200;
						if (obj43 != null)
						{
							nint num11 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S0_v952 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj6 = typeof(short?);
						((IntPtr*)num)->m_value = (void*)(nint)obj6;
						Type type5 = Type.internal_from_handle((IntPtr)num);
						if ((object)key != type5)
						{
							nint num12 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ S0_v149 (Il2CppClass<System.Type>)+BA]");
							object obj44 = (nint)0 & (nint)0x200;
							if (obj44 != null)
							{
								nint num13 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S0_v948 (Il2CppClass<System.Type>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj7 = typeof(uint);
							((IntPtr*)num)->m_value = (void*)(nint)obj7;
							Type type6 = Type.internal_from_handle((IntPtr)num);
							if ((object)key != type6)
							{
								nint num14 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v163 (Il2CppClass<System.Type>)+BA]");
								object obj45 = (nint)0 & (nint)0x200;
								if (obj45 != null)
								{
									nint num15 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v944 (Il2CppClass<System.Type>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								obj8 = typeof(uint?);
								((IntPtr*)num)->m_value = (void*)(nint)obj8;
								Type type7 = Type.internal_from_handle((IntPtr)num);
								if ((object)key != type7)
								{
									nint num16 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ S0_v174 (Il2CppClass<System.Type>)+BA]");
									object obj46 = (nint)0 & (nint)0x200;
									if (obj46 != null)
									{
										nint num17 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ S0_v941 (Il2CppClass<System.Type>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									obj9 = typeof(ushort);
									((IntPtr*)num)->m_value = (void*)(nint)obj9;
									Type type8 = Type.internal_from_handle((IntPtr)num);
									if ((object)key != type8)
									{
										nint num18 = (nint)typeof(Type);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ S0_v188 (Il2CppClass<System.Type>)+BA]");
										object obj47 = (nint)0 & (nint)0x200;
										if (obj47 != null)
										{
											nint num19 = (nint)typeof(Type);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ S0_v938 (Il2CppClass<System.Type>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										obj10 = typeof(ushort?);
										((IntPtr*)num)->m_value = (void*)(nint)obj10;
										Type type9 = Type.internal_from_handle((IntPtr)num);
										if ((object)key != type9)
										{
											nint num20 = (nint)typeof(Type);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S0_v199 (Il2CppClass<System.Type>)+BA]");
											object obj48 = (nint)0 & (nint)0x200;
											if (obj48 != null)
											{
												nint num21 = (nint)typeof(Type);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ S0_v935 (Il2CppClass<System.Type>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											obj11 = typeof(sbyte);
											((IntPtr*)num)->m_value = (void*)(nint)obj11;
											Type type10 = Type.internal_from_handle((IntPtr)num);
											if ((object)key != type10)
											{
												nint num22 = (nint)typeof(Type);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ S0_v213 (Il2CppClass<System.Type>)+BA]");
												object obj49 = (nint)0 & (nint)0x200;
												if (obj49 != null)
												{
													nint num23 = (nint)typeof(Type);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S0_v932 (Il2CppClass<System.Type>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												obj12 = typeof(sbyte?);
												((IntPtr*)num)->m_value = (void*)(nint)obj12;
												Type type11 = Type.internal_from_handle((IntPtr)num);
												if ((object)key != type11)
												{
													nint num24 = (nint)typeof(Type);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ S0_v224 (Il2CppClass<System.Type>)+BA]");
													object obj50 = (nint)0 & (nint)0x200;
													if (obj50 != null)
													{
														nint num25 = (nint)typeof(Type);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ S0_v929 (Il2CppClass<System.Type>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
													obj13 = typeof(byte);
													((IntPtr*)num)->m_value = (void*)(nint)obj13;
													Type type12 = Type.internal_from_handle((IntPtr)num);
													if ((object)key != type12)
													{
														nint num26 = (nint)typeof(Type);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ S0_v238 (Il2CppClass<System.Type>)+BA]");
														object obj51 = (nint)0 & (nint)0x200;
														if (obj51 != null)
														{
															nint num27 = (nint)typeof(Type);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ S0_v926 (Il2CppClass<System.Type>)+74]");
															if ((nint)0 == 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
															}
														}
														obj14 = typeof(byte?);
														((IntPtr*)num)->m_value = (void*)(nint)obj14;
														Type type13 = Type.internal_from_handle((IntPtr)num);
														if ((object)key != type13)
														{
															nint num28 = (nint)typeof(Type);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S0_v249 (Il2CppClass<System.Type>)+BA]");
															object obj52 = (nint)0 & (nint)0x200;
															if (obj52 != null)
															{
																nint num29 = (nint)typeof(Type);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S0_v923 (Il2CppClass<System.Type>)+74]");
																if ((nint)0 == 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																}
															}
															obj15 = typeof(char);
															((IntPtr*)num)->m_value = (void*)(nint)obj15;
															Type type14 = Type.internal_from_handle((IntPtr)num);
															if ((object)key != type14)
															{
																nint num30 = (nint)typeof(Type);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S0_v263 (Il2CppClass<System.Type>)+BA]");
																object obj53 = (nint)0 & (nint)0x200;
																if (obj53 != null)
																{
																	nint num31 = (nint)typeof(Type);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ S0_v920 (Il2CppClass<System.Type>)+74]");
																	if ((nint)0 == 0)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																	}
																}
																obj16 = typeof(char?);
																((IntPtr*)num)->m_value = (void*)(nint)obj16;
																Type type15 = Type.internal_from_handle((IntPtr)num);
																if ((object)key != type15)
																{
																	nint num32 = (nint)typeof(Type);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ S0_v274 (Il2CppClass<System.Type>)+BA]");
																	object obj54 = (nint)0 & (nint)0x200;
																	if (obj54 != null)
																	{
																		nint num33 = (nint)typeof(Type);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ S0_v917 (Il2CppClass<System.Type>)+74]");
																		if ((nint)0 == 0)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																		}
																	}
																	obj17 = typeof(long);
																	((IntPtr*)num)->m_value = (void*)(nint)obj17;
																	Type type16 = Type.internal_from_handle((IntPtr)num);
																	if ((object)key != type16)
																	{
																		nint num34 = (nint)typeof(Type);
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ S0_v288 (Il2CppClass<System.Type>)+BA]");
																		object obj55 = (nint)0 & (nint)0x200;
																		if (obj55 != null)
																		{
																			nint num35 = (nint)typeof(Type);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ S0_v914 (Il2CppClass<System.Type>)+74]");
																			if ((nint)0 == 0)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																			}
																		}
																		obj18 = typeof(long?);
																		((IntPtr*)num)->m_value = (void*)(nint)obj18;
																		Type type17 = Type.internal_from_handle((IntPtr)num);
																		if ((object)key != type17)
																		{
																			nint num36 = (nint)typeof(Type);
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ S0_v299 (Il2CppClass<System.Type>)+BA]");
																			object obj56 = (nint)0 & (nint)0x200;
																			if (obj56 != null)
																			{
																				nint num37 = (nint)typeof(Type);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ S0_v911 (Il2CppClass<System.Type>)+74]");
																				if ((nint)0 == 0)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																				}
																			}
																			obj19 = typeof(float);
																			((IntPtr*)num)->m_value = (void*)(nint)obj19;
																			Type type18 = Type.internal_from_handle((IntPtr)num);
																			if ((object)key != type18)
																			{
																				nint num38 = (nint)typeof(Type);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ S0_v313 (Il2CppClass<System.Type>)+BA]");
																				object obj57 = (nint)0 & (nint)0x200;
																				if (obj57 != null)
																				{
																					nint num39 = (nint)typeof(Type);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ S0_v908 (Il2CppClass<System.Type>)+74]");
																					if ((nint)0 == 0)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																					}
																				}
																				obj20 = typeof(float?);
																				((IntPtr*)num)->m_value = (void*)(nint)obj20;
																				Type type19 = Type.internal_from_handle((IntPtr)num);
																				if ((object)key != type19)
																				{
																					nint num40 = (nint)typeof(Type);
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ S0_v324 (Il2CppClass<System.Type>)+BA]");
																					object obj58 = (nint)0 & (nint)0x200;
																					if (obj58 != null)
																					{
																						nint num41 = (nint)typeof(Type);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ S0_v905 (Il2CppClass<System.Type>)+74]");
																						if ((nint)0 == 0)
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																						}
																					}
																					obj21 = typeof(double);
																					((IntPtr*)num)->m_value = (void*)(nint)obj21;
																					Type type20 = Type.internal_from_handle((IntPtr)num);
																					if ((object)key != type20)
																					{
																						nint num42 = (nint)typeof(Type);
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ S0_v338 (Il2CppClass<System.Type>)+BA]");
																						object obj59 = (nint)0 & (nint)0x200;
																						if (obj59 != null)
																						{
																							nint num43 = (nint)typeof(Type);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ S0_v902 (Il2CppClass<System.Type>)+74]");
																							if ((nint)0 == 0)
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																							}
																						}
																						obj22 = typeof(double?);
																						((IntPtr*)num)->m_value = (void*)(nint)obj22;
																						Type type21 = Type.internal_from_handle((IntPtr)num);
																						if ((object)key != type21)
																						{
																							nint num44 = (nint)typeof(Type);
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ S0_v349 (Il2CppClass<System.Type>)+BA]");
																							object obj60 = (nint)0 & (nint)0x200;
																							if (obj60 != null)
																							{
																								nint num45 = (nint)typeof(Type);
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ S0_v899 (Il2CppClass<System.Type>)+74]");
																								if ((nint)0 == 0)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																								}
																							}
																							obj23 = typeof(bool);
																							((IntPtr*)num)->m_value = (void*)(nint)obj23;
																							Type type22 = Type.internal_from_handle((IntPtr)num);
																							if ((object)key != type22)
																							{
																								nint num46 = (nint)typeof(Type);
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ S0_v379 (Il2CppClass<System.Type>)+BA]");
																								object obj61 = (nint)0 & (nint)0x200;
																								if (obj61 != null)
																								{
																									nint num47 = (nint)typeof(Type);
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ S0_v896 (Il2CppClass<System.Type>)+74]");
																									if ((nint)0 == 0)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																									}
																								}
																								obj24 = typeof(bool?);
																								((IntPtr*)num)->m_value = (void*)(nint)obj24;
																								Type type23 = Type.internal_from_handle((IntPtr)num);
																								if ((object)key != type23)
																								{
																									nint num48 = (nint)typeof(Type);
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1102 @ S0_v390 (Il2CppClass<System.Type>)+BA]");
																									object obj62 = (nint)0 & (nint)0x200;
																									if (obj62 != null)
																									{
																										nint num49 = (nint)typeof(Type);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ S0_v893 (Il2CppClass<System.Type>)+74]");
																										if ((nint)0 == 0)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																										}
																									}
																									obj25 = typeof(string);
																									((IntPtr*)num)->m_value = (void*)(nint)obj25;
																									Type type24 = Type.internal_from_handle((IntPtr)num);
																									if ((object)key == type24)
																									{
																										Type type25;
																										if ((object)type == null)
																										{
																											type25 = null;
																										}
																										else
																										{
																											type25 = (((object)((object)type).GetType() != typeof(string)) ? null : type);
																										}
																										result = type;
																										if ((object)type25 == null)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
																											object obj63 = default;
																											result = obj63;
																										}
																									}
																									else
																									{
																										nint num50 = (nint)typeof(Type);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ S0_v401 (Il2CppClass<System.Type>)+BA]");
																										object obj64 = (nint)0 & (nint)0x200;
																										if (obj64 != null)
																										{
																											nint num51 = (nint)typeof(Type);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ S0_v877 (Il2CppClass<System.Type>)+74]");
																											if ((nint)0 == 0)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																											}
																										}
																										obj26 = typeof(JsonList);
																										((IntPtr*)num)->m_value = (void*)(nint)obj26;
																										Type type26 = Type.internal_from_handle((IntPtr)num);
																										if ((object)key == type26)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
																											result = type;
																											object obj65 = default;
																											if (obj65 != null)
																											{
																												goto IL_1fa0;
																											}
																											string text = $"Cannot translate value {(object[])(object)type} to a JsonList";
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																											StringBuilder outputBuffer = default;
																											System.DateTimeFormat.HebrewFormatDigits(outputBuffer, (int)text);
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
																										}
																										nint num52 = (nint)typeof(Type);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ S0_v413 (Il2CppClass<System.Type>)+BA]");
																										object obj66 = (nint)0 & (nint)0x200;
																										if (obj66 != null)
																										{
																											nint num53 = (nint)typeof(Type);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ S0_v865 (Il2CppClass<System.Type>)+74]");
																											if ((nint)0 == 0)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																											}
																										}
																										obj27 = typeof(JsonDict);
																										((IntPtr*)num)->m_value = (void*)(nint)obj27;
																										Type type27 = Type.internal_from_handle((IntPtr)num);
																										if ((object)key == type27)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
																											result = type;
																											object obj67 = default;
																											if (obj67 != null)
																											{
																												goto IL_1fa0;
																											}
																											string text2 = $"Cannot translate value {(object[])(object)type} to a JsonDict";
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																											StringBuilder outputBuffer2 = default;
																											System.DateTimeFormat.HebrewFormatDigits(outputBuffer2, (int)text2);
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
																										}
																										nint num54 = (nint)typeof(Type);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ S0_v425 (Il2CppClass<System.Type>)+BA]");
																										object obj68 = (nint)0 & (nint)0x200;
																										if (obj68 != null)
																										{
																											nint num55 = (nint)typeof(Type);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ S0_v853 (Il2CppClass<System.Type>)+74]");
																											if ((nint)0 == 0)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																											}
																										}
																										obj28 = typeof(IList<>);
																										((IntPtr*)num)->m_value = (void*)(nint)obj28;
																										Type directoryPath2 = Type.internal_from_handle((IntPtr)num);
																										bool flag3 = ((AssetLoaderPathAttribute)(object)key).ValidateDirectoryPath((string)(object)directoryPath2);
																										if (flag3)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
																											JsonObjectStore jsonObjectStore = default;
																											if (jsonObjectStore == null)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																												jsonObjectStore._002Ector();
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
																												int num56 = default;
																												object obj69 = num56 + 16;
																												obj69 = 44;
																												string text4 = default;
																												string text3 = text4.Substring(num56);
																												object obj70 = text3 + 12;
																												object obj71 = 0;
																												while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj70))
																												{
																													object obj72 = text3 + 16;
																													object obj73 = obj71 << 2;
																													object str = obj72 + obj73;
																													string item = string.Copy((string)str);
																													((List<object>)(object)jsonObjectStore).Add((object)item);
																													object obj74 = obj71 + 1;
																													obj71 = obj74;
																												}
																											}
																											bool flag4 = ReflectionWrapper.IsPrimitive((Type)flag3);
																											object obj75 = (flag4 ? 1 : 0) + 16;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
																											nint num57 = (nint)typeof(Type);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ S0_v778 (Il2CppClass<System.Type>)+BA]");
																											object obj76 = (nint)0 & (nint)0x200;
																											if (obj76 != null)
																											{
																												nint num58 = (nint)typeof(Type);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ S0_v834 (Il2CppClass<System.Type>)+74]");
																												if ((nint)0 == 0)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																												}
																											}
																											obj29 = typeof(int);
																											((IntPtr*)num)->m_value = (void*)(nint)obj29;
																											Type type28 = Type.internal_from_handle((IntPtr)num);
																											throw new ArrayTypeMismatchException();
																										}
																										if (ReflectionWrapper.IsAbstract((Type)(object)key))
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
																											nint num59 = (nint)typeof(Type);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ S1_v334 (Il2CppClass<System.Type>)+BA]");
																											object obj77 = (nint)0 & (nint)0x200;
																											if (obj77 != null)
																											{
																												nint num60 = (nint)typeof(Type);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ S1_v410 (Il2CppClass<System.Type>)+74]");
																												if ((nint)0 == 0)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																												}
																											}
																											obj30 = typeof(Dictionary<, >);
																											((IntPtr*)num)->m_value = (void*)(nint)obj30;
																											Type type29 = Type.internal_from_handle((IntPtr)num);
																											object obj78 = default;
																											if (obj78 == type29)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
																												object obj79 = default;
																												if (obj79 == null)
																												{
																													string text5 = $"Cannot translate value {(object[])(object)type} to a Dictionary";
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																													StringBuilder outputBuffer3 = default;
																													System.DateTimeFormat.HebrewFormatDigits(outputBuffer3, (int)text5);
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
																												}
																												object uninitializedObject = ReflectionWrapper.GetUninitializedObject((Type)(object)key);
																												bool flag5 = ((ConstructorInfo)uninitializedObject).Equals((object)null);
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
																												bool flag6 = ReflectionWrapper.IsPrimitive((Type)(object)key);
																												object obj80 = (flag6 ? 1 : 0) + 16;
																												bool flag7 = ReflectionWrapper.IsPrimitive((Type)(object)key);
																												object obj81 = (flag7 ? 1 : 0) + 20;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
																												obj34 = (object)((IntPtr*)num)->m_value;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+8]");
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+10]");
																												_ = 0;
																												object obj82 = default;
																												while (true)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
																													if (obj82 == null)
																													{
																														break;
																													}
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
																													obj35 = (object)((IntPtr*)num)->m_value;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
																												}
																												object obj83 = obj36 + 4;
																												object obj84 = obj83 + 1;
																												obj83 = obj84;
																												object obj85 = obj84 << 2;
																												object obj86 = obj36 + obj85;
																												obj86 = 1184;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v85+4]");
																												object obj91 = default;
																												if ((nint)0 != -1)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v85+4]");
																													object obj87 = (nint)0 << 2;
																													object obj88 = obj36 + obj87;
																													if ((nint)obj88 == 1184)
																													{
																														object obj89 = obj36 + 4;
																														if ((nint)obj89 > -1)
																														{
																															object obj90 = obj89 + -1;
																															obj89 = obj90;
																														}
																														result = obj91;
																														goto IL_1fa0;
																													}
																												}
																												object obj92 = default;
																												if (obj92 == null)
																												{
																													result = obj91;
																													goto IL_1fa0;
																												}
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
																											}
																										}
																										nint num61 = (nint)typeof(Type);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ S0_v439 (Il2CppClass<System.Type>)+BA]");
																										object obj93 = (nint)0 & (nint)0x200;
																										if (obj93 != null)
																										{
																											nint num62 = (nint)typeof(Type);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1333 @ S0_v643 (Il2CppClass<System.Type>)+74]");
																											if ((nint)0 == 0)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																											}
																										}
																										obj31 = typeof(DateTime);
																										((IntPtr*)num)->m_value = (void*)(nint)obj31;
																										Type type30 = Type.internal_from_handle((IntPtr)num);
																										if ((object)key == type30)
																										{
																											Type type31;
																											if ((object)type == null)
																											{
																												type31 = null;
																											}
																											else
																											{
																												type31 = (((object)((object)type).GetType() != typeof(string)) ? null : type);
																											}
																											if ((object)type31 == null)
																											{
																												string text6 = $"Cannot translate value {(object[])(object)type} to a DateTime";
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																												StringBuilder outputBuffer4 = default;
																												System.DateTimeFormat.HebrewFormatDigits(outputBuffer4, (int)text6);
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
																											}
																											nint num63 = (nint)typeof(CultureInfo);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ S0_v555 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
																											object obj94 = (nint)0 & (nint)0x200;
																											if (obj94 != null)
																											{
																												nint num64 = (nint)typeof(CultureInfo);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1563 @ S0_v626 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
																												if ((nint)0 == 0)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																												}
																											}
																											CultureInfo currentCulture = CultureInfo.CurrentCulture;
																											nint num65 = (nint)typeof(DateTime);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1595 @ S0_v562 (Il2CppClass<System.DateTime>)+BA]");
																											object obj95 = (nint)0 & (nint)0x200;
																											if (obj95 != null)
																											{
																												nint num66 = (nint)typeof(DateTime);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ S0_v623 (Il2CppClass<System.DateTime>)+74]");
																												if ((nint)0 == 0)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																												}
																											}
																											FieldInfo fieldInfo = ((System.DefaultBinder)(object)type31).BindToField((BindingFlags)"yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFF'Z'", (FieldInfo[])(object)currentCulture, (object)64, cultureInfo);
																											if ((object)fieldInfo == null)
																											{
																												nint num67 = (nint)typeof(CultureInfo);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1722 @ S0_v575 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
																												object obj96 = (nint)0 & (nint)0x200;
																												if (obj96 != null)
																												{
																													nint num68 = (nint)typeof(CultureInfo);
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1787 @ S0_v620 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
																													if ((nint)0 == 0)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																													}
																												}
																												CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
																												nint num69 = (nint)typeof(DateTime);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1857 @ S0_v582 (Il2CppClass<System.DateTime>)+BA]");
																												object obj97 = (nint)0 & (nint)0x200;
																												if (obj97 != null)
																												{
																													nint num70 = (nint)typeof(DateTime);
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1894 @ S0_v617 (Il2CppClass<System.DateTime>)+74]");
																													if ((nint)0 == 0)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																													}
																												}
																												FieldInfo fieldInfo2 = ((System.DefaultBinder)(object)type31).BindToField((BindingFlags)"yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'", (FieldInfo[])(object)currentCulture2, (object)64, cultureInfo);
																												if ((object)fieldInfo2 == null)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
																													throw new ArrayTypeMismatchException();
																												}
																											}
																											((IntPtr*)num)->m_value = (void*)(nint)cultureInfo;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
																											goto IL_1c56;
																										}
																										nint num71 = (nint)typeof(Type);
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ S0_v451 (Il2CppClass<System.Type>)+BA]");
																										object obj98 = (nint)0 & (nint)0x200;
																										if (obj98 != null)
																										{
																											nint num72 = (nint)typeof(Type);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ S0_v545 (Il2CppClass<System.Type>)+74]");
																											if ((nint)0 == 0)
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																											}
																										}
																										obj32 = typeof(Guid);
																										((IntPtr*)num)->m_value = (void*)(nint)obj32;
																										Type type32 = Type.internal_from_handle((IntPtr)num);
																										if ((object)key == type32)
																										{
																											Type type33;
																											if ((object)type == null)
																											{
																												type33 = null;
																											}
																											else
																											{
																												type33 = (((object)((object)type).GetType() != typeof(string)) ? null : type);
																											}
																											if ((object)type33 != null)
																											{
																												((IntPtr*)num)->m_value = (void*)unchecked((nint)null);
																												_ = 0;
																												throw new ArrayTypeMismatchException();
																											}
																											string text7 = $"Cannot translate value {(object[])(object)type} to a DateTime";
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																											StringBuilder outputBuffer5 = default;
																											System.DateTimeFormat.HebrewFormatDigits(outputBuffer5, (int)text7);
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
																										}
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8595");
																										object obj99 = default;
																										if (obj99 == null)
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
																											byte[] array = default;
																											if (array != null)
																											{
																												ICryptoTransform cryptoTransform = ((Aes128CounterMode)(object)key).CreateEncryptor(array, (byte[])(object)context);
																												result = cryptoTransform;
																												goto IL_1fa0;
																											}
																											string text8 = string.Format((IFormatProvider)(object)"Cannot translate value {0} to a {1}", (string)(object)type, key);
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																											StringBuilder outputBuffer6 = default;
																											System.DateTimeFormat.HebrewFormatDigits(outputBuffer6, (int)text8);
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
																										}
																										Type type34;
																										if ((object)type == null)
																										{
																											type34 = null;
																										}
																										else
																										{
																											type34 = (((object)((object)type).GetType() != typeof(string)) ? null : type);
																										}
																										if ((object)type34 != null)
																										{
																											nint num73 = (nint)typeof(Enum);
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1766 @ S0_v492 (Il2CppClass<System.Enum>)+BA]");
																											object obj100 = (nint)0 & (nint)0x200;
																											if (obj100 != null)
																											{
																												nint num74 = (nint)typeof(Enum);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1796 @ S0_v498 (Il2CppClass<System.Enum>)+74]");
																												if ((nint)0 == 0)
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																												}
																											}
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
																											string text10 = default;
																											string text9 = ((Enum)(object)key).ToString(text10, (IFormatProvider)1);
																											result = text9;
																										}
																										else
																										{
																											Type type35;
																											if ((object)type == null)
																											{
																												type35 = null;
																											}
																											else
																											{
																												type35 = (((object)((object)type).GetType() != typeof(int)) ? null : type);
																											}
																											result = type;
																											if ((object)type35 == null)
																											{
																												nint num75 = (nint)typeof(Convert);
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ S0_v473 (Il2CppClass<System.Convert>)+BA]");
																												object obj101 = (nint)0 & (nint)0x200;
																												if (obj101 != null)
																												{
																													nint num76 = (nint)typeof(Convert);
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1914 @ S0_v481 (Il2CppClass<System.Convert>)+74]");
																													if ((nint)0 == 0)
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
																													}
																												}
																												int num77 = Convert.ToInt32((byte)(int)type != 0);
																												((IntPtr*)num)->m_value = (void*)num77;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
																												goto IL_1c56;
																											}
																										}
																									}
																									goto IL_1fa0;
																								}
																							}
																							Type type36;
																							if ((object)type == null)
																							{
																								type36 = null;
																							}
																							else
																							{
																								type36 = (((object)((object)type).GetType() != typeof(bool)) ? null : type);
																							}
																							result = type;
																							if ((object)type36 != null)
																							{
																								goto IL_1fa0;
																							}
																							string text11 = $"Cannot translate value {(object[])(object)type} to a bool";
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
																							StringBuilder outputBuffer7 = default;
																							System.DateTimeFormat.HebrewFormatDigits(outputBuffer7, (int)text11);
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
																						}
																					}
																					object obj102 = ConvertOrDefault<double>(type);
																					result = obj102;
																					goto IL_1fa0;
																				}
																			}
																			object obj103 = ConvertOrDefault<float>(type);
																			result = obj103;
																			goto IL_1fa0;
																		}
																	}
																	object obj104 = ConvertOrDefault<long>(type);
																	result = obj104;
																	goto IL_1fa0;
																}
															}
															object obj105 = ConvertOrDefault<char>(type);
															result = obj105;
															goto IL_1fa0;
														}
													}
													object obj106 = ConvertOrDefault<byte>(type);
													result = obj106;
													goto IL_1fa0;
												}
											}
											object obj107 = ConvertOrDefault<T>((object)type);
											result = obj107;
											goto IL_1fa0;
										}
									}
									object obj108 = ConvertOrDefault<ushort>(type);
									result = obj108;
									goto IL_1fa0;
								}
							}
							object obj109 = ConvertOrDefault<uint>(type);
							result = obj109;
							goto IL_1fa0;
						}
					}
					object obj110 = ConvertOrDefault<short>(type);
					result = obj110;
					goto IL_1fa0;
				}
			}
			obj111 = ConvertOrDefault<int>(type);
		}
		else
		{
			obj111 = null;
		}
		result = obj111;
		goto IL_1fa0;
		IL_1fa0:
		return result;
		IL_1c56:
		object obj112 = default;
		result = obj112;
		goto IL_1fa0;
	}

	private static void RecursiveReadField(object obj, FieldInfo field, object jsonValue, JsonContext context)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0102: Expected I4, but got Obj
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		object obj2 = obj + 12;
		object obj3 = default;
		byte[] rgbKey = default;
		object obj7 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = obj + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			JsonFieldInfo jsonFieldInfo = (JsonFieldInfo)obj6;
			if (context.ShouldFilterField == null || !context.ShouldFilterField((JsonFieldInfo)obj6))
			{
				string[] callstackPrefixes = ((EditorExtensionsLogCategory)obj6).GetCallstackPrefixes();
				if (callstackPrefixes != null)
				{
					((DecryptionException)(object)field)._002Ector((string)obj6, (Exception)(object)context);
				}
				else
				{
					Aes128CounterMode aes128CounterMode = (Aes128CounterMode)((JsonFieldInfo)obj6).ReadValue((JsonDict)(object)field);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					ICryptoTransform getFileText = aes128CounterMode.CreateEncryptor(rgbKey, (byte[])obj6, (int)context);
					((JsonFileSerializer)obj6)._002Ector((JsonFileSerializer.GetFileTextDelegate)(object)getFileText, (JsonFileSerializer.WriteFileTextDelegate)jsonValue);
				}
			}
			obj3 = obj7 + 1;
		}
	}

	private static object RecursiveReadObject(Type objType, JsonDict json, JsonContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0387: Expected I, but got Obj
		//IL_039d: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0155: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_03dd: Expected Obj, but got I4
		//IL_0196: Expected I, but got Obj
		//IL_0108: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(JsonClassInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v117 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		JsonClassInfo nonCachedTypeReflection = JsonClassInfo.GetNonCachedTypeReflection((Type)(object)json);
		bool flag2 = default;
		if (JsonClassInfo.IsClassInfoCached((Type)(object)nonCachedTypeReflection))
		{
			bool flag = context.ObjectStore.HasObject((Type)(object)json, objType);
			flag2 = flag;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8595");
			object obj4 = default;
			if (obj4 == null)
			{
				nint num3 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v104 (Il2CppClass<System.Convert>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num4 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v110 (Il2CppClass<System.Convert>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = Convert.ToBoolean(objType, (IFormatProvider)json);
				flag2 = flag3;
			}
			else
			{
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v28 (Il2CppClass<System.Enum>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v93 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj8 = default;
				object obj7 = obj8;
				object obj10 = default;
				object obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj11 = default;
				if (obj9 == obj11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj13 = default;
					object obj12 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj15 = default;
					object obj14 = obj15;
				}
				else
				{
					object obj14 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
		}
		return flag2;
	}
}
