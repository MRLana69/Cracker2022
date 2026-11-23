using System;
using System.Collections;
using System.Globalization;
using Cpp2ILInjected;
using MiniJSON;

namespace Kiloo.Common;

public class JsonObject
{
	private readonly IDictionary _json;

	// C# has no syntax for parameterized property 'Item'.
	public object get_Item(string key)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object result = default;
		return result;
	}

	public void set_Item(string key, object value)
	{
		//IL_009c: Expected Obj, but got I
		//IL_0067: Expected I, but got Obj
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		if (obj == null)
		{
			object obj2 = default;
			if (obj2 == null || (object)obj2.GetType() != typeof(DateTime))
			{
			}
			if (!CanSerialize(obj2))
			{
				nint num = (nint)obj2;
				object obj3 = obj2 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ S1_v15 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
				object obj4 = default;
				obj2 = obj4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6+8]");
			object obj2 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
	}

	public JsonObject(object json = null)
	{
		//IL_0017: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6+8]");
			_json = (IDictionary)0;
			return;
		}
		IDictionary json2;
		if (json == null)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ S4_v6 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			IDictionary dictionary = default;
			json2 = dictionary;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			IDictionary dictionary2 = default;
			json2 = dictionary2;
		}
		_json = json2;
	}

	public static JsonObject Deserialize(string json)
	{
		object json2 = Json.Deserialize(json);
		JsonObject jsonObject = default;
		jsonObject._002Ector(json2);
		return jsonObject;
	}

	public string Serialize()
	{
		return Json.Serialize(_json);
	}

	public void Remove(string key)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
	}

	public T Get<T>(string key, IFormatProvider provider = null)
	{
		object obj = this.get_Item(key);
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.JsonObject::Get>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public T Get<T>(string key, T defaultValue, IFormatProvider provider = null)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S5_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.JsonObject::Get>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public bool TryGet<T>(string key, out T result, IFormatProvider provider = null)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S5_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.JsonObject::TryGet>>)+4] (should have been resolved before IL gen)");
		bool result2 = default;
		return result2;
	}

	public static T Get<T>(object jsonObject, string key, IFormatProvider provider = null)
	{
		//IL_001d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		}
		else
		{
			object obj2 = 0;
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S3_v4 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.JsonObject::Get>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static T Get<T>(object jsonObject, string key, T defaultValue, IFormatProvider provider = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_0062: Expected VT, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = obj + 15;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S5_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.JsonObject::Get>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		bool flag = (nint)0 != 0;
		T result = (T)flag;
		object obj4 = default;
		if (obj4 == null)
		{
			result = defaultValue;
		}
		return result;
	}

	public unsafe static bool TryGet<T>(object jsonObject, string key, out T result, IFormatProvider provider = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_0256: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj4 = default;
		bool result2;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj5 = default;
			if (obj5 != null)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					nint num = 0;
					IntPtr intPtr = num;
					nint num2 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj6 = default;
						ref T reference = ref *(T*)obj6;
						result2 = true;
						goto IL_03ad;
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
				bool flag = obj7 != obj8;
				bool flag2 = default;
				result2 = flag2;
				if (!flag)
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
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj12 = (nint)0 << 2;
								object obj13 = obj3 + obj12;
								obj13 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj14 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj15 = -1;
								goto IL_0395;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj16 = obj10;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag3 = (nint)0 != 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							result2 = false;
							if (flag3)
							{
								goto IL_03b2;
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
					bool flag5 = default;
					result2 = flag5;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						result2 = flag5;
					}
				}
				goto IL_03b2;
			}
		}
		goto IL_0395;
		IL_03ad:
		return result2;
		IL_0395:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		result2 = false;
		goto IL_03ad;
		IL_03b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_03ad;
	}

	public static T ConvertValue<T>(object json, IFormatProvider provider = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0086: Expected VT, but got I
		//IL_009e: Expected VT, but got Obj
		//IL_0133: Expected VT, but got I
		//IL_014b: Expected VT, but got Obj
		//IL_0272: Expected VT, but got I
		//IL_02f8: Expected VT, but got Obj
		//IL_04a9: Expected I, but got Obj
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		object obj3 = default;
		if (obj3 == null)
		{
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj4 = default;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			throw new NullReferenceException();
		}
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v23 (Il2CppMethodRgctx<Kiloo.Common.JsonObject::ConvertValue>)+4]");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(JsonObject));
		if ((object)typeFromHandle == typeFromHandle2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			object obj5 = default;
			if (obj5 != null)
			{
				JsonObject jsonObject = default;
				jsonObject._002Ector(obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				throw new NullReferenceException();
			}
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v32 (Il2CppMethodRgctx<Kiloo.Common.JsonObject::ConvertValue>)+4]");
		Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DateTime));
		IFormatProvider formatProvider = default;
		if ((object)typeFromHandle3 == typeFromHandle4)
		{
			bool flag = obj3 == null;
			object obj6 = null;
			if (!flag)
			{
				bool flag2 = (object)obj3.GetType() == typeof(string);
				obj6 = obj3;
				if (!flag2)
				{
					obj6 = null;
				}
			}
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				string s;
				if (formatProvider != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
					string text = default;
					s = text;
				}
				else
				{
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					formatProvider = invariantCulture;
					string text2 = default;
					s = text2;
				}
				DateTime dateTime = DateTime.Parse(s, formatProvider, (DateTimeStyles)87);
				object obj7 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				throw new NullReferenceException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v43 (Il2CppMethodRgctx<Kiloo.Common.JsonObject::ConvertValue>)+4]");
		Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		object obj8 = default;
		if (obj8 != null)
		{
			if (formatProvider == null)
			{
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				formatProvider = invariantCulture2;
			}
			object obj9 = Convert.ChangeType(obj3, typeFromHandle5, formatProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			throw new NullReferenceException();
		}
		Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
		InvalidCastException ex = default;
		if ((object)typeFromHandle6 == typeFromHandle5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			object obj10 = default;
			if (obj10 != null)
			{
				if (formatProvider == null)
				{
					CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
					formatProvider = invariantCulture3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				throw new NullReferenceException();
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		nint num4 = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v266 @ S1_v26 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		throw new NullReferenceException();
	}

	public static bool HasKey(object jsonObject, string key)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			bool result = default;
			return result;
		}
		return false;
	}

	public bool HasKey(string key)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		bool result = default;
		return result;
	}

	public bool CanSerialize()
	{
		return CanSerialize(_json);
	}

	public static bool CanSerialize(object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected Obj, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected Obj, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected Obj, but got Unknown
		//IL_076d: Expected Obj, but got I
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected Obj, but got Unknown
		//IL_0a2c: Expected Obj, but got I
		//IL_0a3c: Expected Obj, but got I
		//IL_078b: Expected Obj, but got I
		//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c57: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag = value == null;
		bool result = true;
		object obj21;
		if (!flag)
		{
			bool flag2 = value == null;
			object obj3 = null;
			if (!flag2)
			{
				bool flag3 = (object)value.GetType() == typeof(string);
				obj3 = value;
				if (!flag3)
				{
					obj3 = null;
				}
			}
			result = true;
			if (obj3 == null)
			{
				bool flag4 = value == null;
				object obj4 = null;
				if (!flag4)
				{
					bool flag5 = (object)value.GetType() == typeof(char);
					obj4 = value;
					if (!flag5)
					{
						obj4 = null;
					}
				}
				result = true;
				if (obj4 == null)
				{
					bool flag6 = value == null;
					object obj5 = null;
					if (!flag6)
					{
						bool flag7 = (object)value.GetType() == typeof(bool);
						obj5 = value;
						if (!flag7)
						{
							obj5 = null;
						}
					}
					result = true;
					if (obj5 == null)
					{
						bool flag8 = value == null;
						object obj6 = null;
						if (!flag8)
						{
							bool flag9 = (object)value.GetType() == typeof(float);
							obj6 = value;
							if (!flag9)
							{
								obj6 = null;
							}
						}
						result = true;
						if (obj6 == null)
						{
							bool flag10 = value == null;
							object obj7 = null;
							if (!flag10)
							{
								bool flag11 = (object)value.GetType() == typeof(int);
								obj7 = value;
								if (!flag11)
								{
									obj7 = null;
								}
							}
							result = true;
							if (obj7 == null)
							{
								bool flag12 = value == null;
								object obj8 = null;
								if (!flag12)
								{
									bool flag13 = (object)value.GetType() == typeof(uint);
									obj8 = value;
									if (!flag13)
									{
										obj8 = null;
									}
								}
								result = true;
								if (obj8 == null)
								{
									bool flag14 = value == null;
									object obj9 = null;
									if (!flag14)
									{
										bool flag15 = (object)value.GetType() == typeof(long);
										obj9 = value;
										if (!flag15)
										{
											obj9 = null;
										}
									}
									result = true;
									if (obj9 == null)
									{
										bool flag16 = value == null;
										object obj10 = null;
										if (!flag16)
										{
											bool flag17 = (object)value.GetType() == typeof(double);
											obj10 = value;
											if (!flag17)
											{
												obj10 = null;
											}
										}
										result = true;
										if (obj10 == null)
										{
											bool flag18 = value == null;
											object obj11 = null;
											if (!flag18)
											{
												bool flag19 = (object)value.GetType() == typeof(sbyte);
												obj11 = value;
												if (!flag19)
												{
													obj11 = null;
												}
											}
											result = true;
											if (obj11 == null)
											{
												bool flag20 = value == null;
												object obj12 = null;
												if (!flag20)
												{
													bool flag21 = (object)value.GetType() == typeof(byte);
													obj12 = value;
													if (!flag21)
													{
														obj12 = null;
													}
												}
												result = true;
												if (obj12 == null)
												{
													bool flag22 = value == null;
													object obj13 = null;
													if (!flag22)
													{
														bool flag23 = (object)value.GetType() == typeof(short);
														obj13 = value;
														if (!flag23)
														{
															obj13 = null;
														}
													}
													result = true;
													if (obj13 == null)
													{
														bool flag24 = value == null;
														object obj14 = null;
														if (!flag24)
														{
															bool flag25 = (object)value.GetType() == typeof(ushort);
															obj14 = value;
															if (!flag25)
															{
																obj14 = null;
															}
														}
														result = true;
														if (obj14 == null)
														{
															bool flag26 = value == null;
															object obj15 = null;
															if (!flag26)
															{
																bool flag27 = (object)value.GetType() == typeof(ulong);
																obj15 = value;
																if (!flag27)
																{
																	obj15 = null;
																}
															}
															result = true;
															if (obj15 == null)
															{
																bool flag28 = value == null;
																object obj16 = null;
																if (!flag28)
																{
																	bool flag29 = (object)value.GetType() == typeof(decimal);
																	obj16 = value;
																	if (!flag29)
																	{
																		obj16 = null;
																	}
																}
																result = true;
																if (obj16 == null)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
																	object obj17 = default;
																	if (obj17 != null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
																		object obj18 = obj + 40;
																		object obj19 = obj + 44;
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
																		_ = 0;
																		object obj20 = default;
																		object obj22 = default;
																		object obj23 = default;
																		object obj24 = default;
																		object obj26 = default;
																		object obj27 = default;
																		while (true)
																		{
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				bool flag30 = obj20 == null;
																				obj21 = obj;
																				if (flag30)
																				{
																					break;
																				}
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
																						if (obj22 != null)
																						{
																							continue;
																						}
																						goto IL_0c49;
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
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
																			bool flag31 = obj23 == obj24;
																			bool flag32 = !flag31;
																			object obj25 = obj26;
																			if (!flag32)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				bool flag33 = (nint)0 != 1;
																				obj21 = obj;
																				if (flag33)
																				{
																					break;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																				obj25 = obj27;
																			}
																			goto IL_071f;
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
																		object obj28 = default;
																		bool flag34 = obj28 == null;
																		result = false;
																		if (flag34)
																		{
																			goto IL_0c92;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
																		object obj29 = obj + 32;
																		object obj30 = obj + 36;
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
																		_ = 0;
																		object obj31 = default;
																		object obj32 = default;
																		object obj33 = default;
																		object obj34 = default;
																		object obj35 = default;
																		object obj36 = default;
																		while (true)
																		{
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				bool flag35 = obj31 == null;
																				obj21 = obj;
																				if (flag35)
																				{
																					break;
																				}
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																						if ((nint)0 != 1)
																						{
																							if (obj32 != null)
																							{
																								continue;
																							}
																							goto IL_0c49;
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																						goto IL_091e;
																					}
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			}
																			goto IL_091e;
																			IL_091e:
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
																			bool flag36 = obj33 == obj34;
																			bool flag37 = !flag36;
																			object obj25 = obj35;
																			if (!flag37)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				bool flag38 = (nint)0 != 1;
																				obj21 = obj;
																				if (flag38)
																				{
																					break;
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
																				obj25 = obj36;
																			}
																			goto IL_09e1;
																		}
																	}
																	goto IL_0be8;
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
						}
					}
				}
			}
		}
		goto IL_0c92;
		IL_071f:
		_ = 0;
		object obj37 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag39 = (nint)0 != 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj38 = 0;
		if (flag39)
		{
			goto IL_0a4a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		obj21 = 0;
		goto IL_0c6f;
		IL_0be8:
		object obj39 = obj21 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
		result = true;
		goto IL_0c92;
		IL_0c6f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_0be8;
		IL_09e1:
		_ = 0;
		object obj40 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag40 = (nint)0 == 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		obj21 = 0;
		if (!flag40)
		{
			goto IL_0a4a;
		}
		goto IL_0c6f;
		IL_0a4a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		obj21 = obj38;
		goto IL_0c6f;
		IL_0c92:
		return result;
		IL_0c49:
		object obj41 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
		result = false;
		goto IL_0c92;
	}
}
