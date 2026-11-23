using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace SYBO.Components.Json;

public class JsonObjectStore
{
	private class JsonObjectStoreTypeEntry
	{
		private Dictionary<string, object> _storedObjects;

		public Type StoreType;

		public unsafe object Get(string key)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected Ref, but got Unknown
			//IL_0032: Expected I, but got Obj
			//IL_0020: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			if (_storedObjects.TryGetValue(key, out *(object*)(obj + 12)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				return 0;
			}
			Type storeType = StoreType;
			nint num = (nint)storeType;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S1_v6 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
			string text = default;
			string message = "JsonObjectStore doesn't contain the " + text + " with key " + key;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			return ex;
		}

		public void Add(string key, object obj)
		{
			//IL_009d: Expected Obj, but got I
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected Obj, but got Unknown
			//IL_00fc: Expected Obj, but got I
			//IL_0017: Expected I, but got Obj
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+54]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
			object obj4 = default;
			object obj3 = obj4 ^ -1;
			object obj5 = obj3 >> 31;
			if (obj5 != null)
			{
				Type storeType = StoreType;
				nint num3 = (nint)storeType;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S1_v8 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
				string text = default;
				string text2 = default;
				string message = "JsonObjectStore already contains the " + text + " with key " + text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ArgumentException ex = default;
				ex._002Ector(message);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S5_v4+4] (should have been resolved before IL gen)");
		}

		public bool Contains(string key)
		{
			//IL_0021: Expected Obj, but got I
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_0047: Expected I4, but got Obj
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			return (byte)(obj2 >> 31) != 0;
		}

		public JsonObjectStoreTypeEntry Duplicate()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Expected Obj, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected Obj, but got Unknown
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Expected Obj, but got Unknown
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Expected Obj, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I
			//IL_02ef: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 + -64;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			JsonObjectStoreTypeEntry jsonObjectStoreTypeEntry = default;
			jsonObjectStoreTypeEntry._002Ector();
			jsonObjectStoreTypeEntry.StoreType = StoreType;
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj4 = obj + 40;
			obj = obj4;
			_ = 0;
			object obj6 = default;
			object obj7;
			object obj8 = default;
			object obj9 = default;
			JsonObjectStoreTypeEntry jsonObjectStoreTypeEntry2 = default;
			JsonObjectStoreTypeEntry jsonObjectStoreTypeEntry3 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					bool flag = obj6 == null;
					obj7 = obj;
					if (flag)
					{
						break;
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj8 == obj9;
				bool flag3 = !flag2;
				JsonObjectStoreTypeEntry result = jsonObjectStoreTypeEntry2;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 != 1;
					obj7 = obj;
					if (flag4)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result = jsonObjectStoreTypeEntry3;
				}
				_ = 0;
				object obj10 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj7 = 0;
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result;
			}
			object obj11 = obj7 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDF");
			return jsonObjectStoreTypeEntry;
		}

		public JsonObjectStoreTypeEntry()
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			Dictionary<string, object> storedObjects = default;
			_storedObjects = storedObjects;
		}
	}

	private Dictionary<Type, JsonObjectStoreTypeEntry> _types;

	public unsafe T Get<T>(object key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0115: Expected VT, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Ref, but got Unknown
		//IL_0093: Expected VT, but got I
		//IL_009f: Expected I, but got Obj
		//IL_0034: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_0100: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		if (_types.TryGetValue(typeFromHandle, out *(JsonObjectStoreTypeEntry*)(obj + 12)))
		{
			nint num2 = (nint)key;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S2_v9 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			string key2 = default;
			object obj3 = ((JsonObjectStoreTypeEntry)0).Get(key2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			T result = default;
			return result;
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)num3);
		nint num4 = (nint)typeFromHandle2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S1_v8 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
		string text = default;
		string message = "JsonObjectStore doesn't contain any objects of type " + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ArgumentException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (T)ex;
	}

	public unsafe object Get(Type type, object key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Ref, but got Unknown
		//IL_004b: Expected I, but got Obj
		//IL_001b: Expected I, but got Obj
		//IL_003a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_types.TryGetValue(type, out *(JsonObjectStoreTypeEntry*)(obj + 12)))
		{
			nint num = (nint)key;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S2_v8 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			string key2 = default;
			return ((JsonObjectStoreTypeEntry)0).Get(key2);
		}
		nint num2 = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S1_v6 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
		string text = default;
		string message = "JsonObjectStore doesn't contain any objects of type " + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ArgumentException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return ex;
	}

	public unsafe void Set<T>(object key, T obj)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c2: Expected VT, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Ref, but got Unknown
		//IL_00f8: Expected I, but got Obj
		//IL_011b: Expected Obj, but got VT
		//IL_011b: Expected Obj, but got I
		//IL_0059: Expected VT, but got I
		//IL_007e: Expected VT, but got I
		//IL_009e: Expected Obj, but got I
		object obj3 = default;
		object obj2 = obj3 - 16;
		_ = 0;
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		if (!_types.TryGetValue(typeFromHandle, out *(JsonObjectStoreTypeEntry*)(obj2 + 12)))
		{
			JsonObjectStoreTypeEntry jsonObjectStoreTypeEntry = default;
			jsonObjectStoreTypeEntry._002Ector();
			nint num2 = 0;
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)num2);
			jsonObjectStoreTypeEntry.StoreType = typeFromHandle2;
			nint num3 = 0;
			Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)num3);
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, SYBO.Components.Json.JsonObjectStore+JsonObjectStoreTypeEntry>>)+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		nint num6 = (nint)key;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S2_v6 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		string key2 = default;
		((JsonObjectStoreTypeEntry)0).Add(key2, obj);
	}

	public unsafe void Set(Type type, object key, object obj)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Ref, but got Unknown
		//IL_00b5: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		object obj3 = default;
		object obj2 = obj3 - 16;
		_ = 0;
		if (!_types.TryGetValue(type, out *(JsonObjectStoreTypeEntry*)(obj2 + 12)))
		{
			JsonObjectStoreTypeEntry jsonObjectStoreTypeEntry = default;
			jsonObjectStoreTypeEntry._002Ector();
			jsonObjectStoreTypeEntry.StoreType = type;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, SYBO.Components.Json.JsonObjectStore+JsonObjectStoreTypeEntry>>)+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		nint num3 = (nint)key;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S2_v5 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		string key2 = default;
		((JsonObjectStoreTypeEntry)0).Add(key2, obj);
	}

	public unsafe bool HasObject(Type type, object key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Ref, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_types.TryGetValue(type, out *(JsonObjectStoreTypeEntry*)(obj + 12)))
		{
			nint num = (nint)key;
			object obj3 = key + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S2_v5 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			string key2 = default;
			return ((JsonObjectStoreTypeEntry)0).Contains(key2);
		}
		bool result = default;
		return result;
	}

	public JsonObjectStore Duplicate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I
		//IL_0339: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		JsonObjectStore jsonObjectStore = default;
		jsonObjectStore._002Ector();
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		JsonObjectStore jsonObjectStore2 = default;
		JsonObjectStore jsonObjectStore3 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			JsonObjectStore result = jsonObjectStore2;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = jsonObjectStore3;
			}
			_ = 0;
			object obj10 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		object obj11 = obj7 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AFF1");
		return jsonObjectStore;
	}

	public JsonObjectStore()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, SYBO.Components.Json.JsonObjectStore+JsonObjectStoreTypeEntry>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, JsonObjectStoreTypeEntry> types = default;
		_types = types;
	}
}
