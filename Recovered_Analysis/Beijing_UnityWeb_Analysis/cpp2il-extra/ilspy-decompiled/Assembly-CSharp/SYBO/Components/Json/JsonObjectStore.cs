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

		public object Get(string key)
		{
			return new InvalidOperationException();
		}

		public void Add(string key, object obj)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I4
			//IL_061e: Expected Obj, but got I
			//IL_0627: Unknown result type (might be due to invalid IL or missing references)
			//IL_062c: Expected Obj, but got Unknown
			//IL_01d7: Expected Obj, but got I
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected Obj, but got Unknown
			//IL_0671: Unknown result type (might be due to invalid IL or missing references)
			//IL_0676: Expected Obj, but got Unknown
			//IL_05b9: Expected Obj, but got I
			//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c7: Expected Obj, but got Unknown
			//IL_05da: Expected Obj, but got I4
			//IL_019b: Expected Obj, but got I
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected Obj, but got Unknown
			//IL_01bc: Expected Obj, but got I4
			//IL_0402: Expected Obj, but got I
			//IL_0297: Expected Obj, but got I
			//IL_04c8: Expected Obj, but got I
			//IL_02f1: Expected Obj, but got I
			//IL_048c: Expected Obj, but got I
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Expected Obj, but got Unknown
			//IL_04ad: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonObjectStore+JsonObjectStoreTypeEntry)+34]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonObjectStore+JsonObjectStoreTypeEntry)+34]");
			object obj4;
			object obj5;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonObjectStore+JsonObjectStoreTypeEntry)+34]");
				object obj3 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj4 = 0;
				obj5 = obj3;
			}
			else
			{
				obj5 = this;
				obj4 = 1;
			}
			object obj6 = default;
			object obj29 = default;
			object obj21 = default;
			object obj27 = default;
			for (; obj6 != obj4; obj6 = obj29 + 1)
			{
				object obj7 = obj6 << 2;
				object obj8 = obj5 + obj7;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+14]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Object)+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Object)+2A]");
				bool flag = (nint)0 == 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Object)+24]");
				object obj12 = (nint)0 & (nint)0x10;
				bool flag2 = obj12 == null;
				object obj13 = (flag2 ? 1 : 0) ^ 1;
				object obj16;
				object obj15;
				if (obj13 != null)
				{
					if (flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
						object obj14 = (nint)0 & (nint)0x3FFF;
						obj15 = obj14 + 97173;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.Object) (should have been resolved before IL gen)");
						obj16 = 97173;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
						object obj17 = (nint)0 & (nint)0x1FFF;
						obj16 = obj17 + 113696;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S4_v6 (System.Object) (should have been resolved before IL gen)");
						obj15 = obj11;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Object)+28]");
				bool flag3 = (nint)0 != -1;
				if (!flag)
				{
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
						bool flag4;
						if ((nint)0 != 0)
						{
							object obj18 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v94+9C]");
							object obj19 = (nint)0 & (nint)0x100;
							flag4 = obj19 != null;
						}
						else
						{
							flag4 = false;
						}
						if (!flag4 && (object)StoreType != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Object)+2B]");
							object obj20 = (nint)0 & (nint)3;
							bool flag5 = (nint)obj20 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag5)
							{
								if (obj21 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A75");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A76");
								}
							}
							else if (obj21 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
								obj15 = obj;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
							}
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
					object obj22 = (nint)0 & (nint)0x3FFF;
					obj15 = obj22 + 97173;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.Object) (should have been resolved before IL gen)");
					obj16 = 97173;
					continue;
				}
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
					bool flag6;
					if ((nint)0 != 0)
					{
						object obj23 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v66+9C]");
						object obj24 = (nint)0 & (nint)0x100;
						flag6 = obj24 != null;
					}
					else
					{
						flag6 = false;
					}
					if (!flag6 && (object)StoreType != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
							object obj25 = (nint)0 & (nint)0x3FFF;
							obj15 = obj25 + 97173;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.Object) (should have been resolved before IL gen)");
							obj16 = 97173;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.Object)+2B]");
						object obj26 = (nint)0 & (nint)3;
						bool flag7 = (nint)obj26 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag7)
						{
							if (obj27 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A77");
								obj15 = obj;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A78");
								obj15 = obj;
							}
						}
						else if (obj27 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
							obj16 = obj;
							obj15 = key;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
							obj15 = obj;
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
				object obj28 = (nint)0 & (nint)0x1FFF;
				obj16 = obj28 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S4_v6 (System.Object) (should have been resolved before IL gen)");
				obj15 = obj11;
			}
		}

		public unsafe bool Contains(string key)
		{
			//IL_000b: Expected I4, but got Obj
			ref object reference = ref *(object*)null;
			if (_storedObjects.TryGetValue(key, out reference))
			{
				return (byte)(int)reference != 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string format = default;
			string message = string.Format((IFormatProvider)(object)"JsonObjectStore doesn't contain the {0} with key {1}", format, key);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonReflectionException ex = default;
			ex._002Ector(message);
			((JsonObjectStoreTypeEntry)(object)ex).Get((string)null);
			return false;
		}

		public JsonObjectStoreTypeEntry Duplicate()
		{
			return (JsonObjectStoreTypeEntry)(object)StoreType;
		}
	}

	private Dictionary<Type, JsonObjectStoreTypeEntry> _types;

	public T Get<T>(object key)
	{
		//IL_0016: Expected Obj, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		((JsonContext)this).EndDeserialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S3_v4 (should have been resolved before IL gen)");
		((JsonContext)this).BeginSerialize();
		T result = default;
		return result;
	}

	public object Get(Type type, object key)
	{
		//IL_006c: Expected I4, but got Obj
		object obj = ((List<object>)this).get_Item((int)type);
		if (obj != null)
		{
			if ((object)obj.GetType() != typeof(string))
			{
				obj = null;
			}
		}
		else
		{
			obj = null;
		}
		if (obj == null)
		{
			obj = key;
		}
		return obj;
	}

	public void Set<T>(object key, T obj)
	{
		//IL_0344: Expected Obj, but got I4
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public void Set(Type type, object key, object obj)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj3 = default;
			object obj2 = obj3 + 8;
			obj2 = type;
			object obj4 = obj3 + 12;
			obj4 = key;
			object obj5 = obj3 + 16;
			obj5 = obj;
			object obj6 = obj3 + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonObjectStore)+24]");
			obj6 = 0;
			object obj7 = this + 36;
			obj7 = obj3;
		}
	}

	public unsafe bool HasObject(Type type, object key)
	{
		ref JsonObjectStoreTypeEntry reference = ref *(JsonObjectStoreTypeEntry*)null;
		if (_types.TryGetValue(type, out reference))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string key2 = default;
			return reference.Contains(key2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object[] args = default;
		string message = $"JsonObjectStore doesn't contain any objects of type {args}";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonReflectionException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return false;
	}

	public JsonObjectStore Duplicate()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public JsonObjectStore()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(List<object>);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(List<object>);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((List<object>)this)._002Ector();
	}
}
