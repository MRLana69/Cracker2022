using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.Json;

public class JsonList : List<object>
{
	public static JsonList EmptyList
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonFieldInfo jsonFieldInfo = default;
			jsonFieldInfo._002Ector();
			return (JsonList)(object)jsonFieldInfo;
		}
	}

	public JsonList()
	{
	}

	public JsonList(int capacity)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S4_v4 (should have been resolved before IL gen)");
	}

	public JsonDict GetDict(int index)
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0257: Expected Obj, but got I4
		//IL_017f: Expected I, but got Obj
		//IL_0195: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		//IL_02bd: Expected I4, but got Obj
		//IL_01c0: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj3 = default;
		bool flag = obj3 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonList)+18]");
		bool flag2 = (nint)0 < (nint)0;
		object obj4 = flag | flag2;
		bool flag3 = obj4 == null;
		bool flag4 = !flag3;
		JsonDict result = (JsonDict)obj3;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (System.Object)+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonList)+18]");
			bool flag5 = num > 0;
			bool flag6 = !flag5;
			result = (JsonDict)obj3;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonList)+1C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					throw new ArrayTypeMismatchException();
				}
				nint num2 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v26 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num3 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v35 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonList)+18]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string format = default;
				Log.Json.LogErrorFormat((int)"Json - Truncating field value due to limit ({0})\n{1}", format, obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonList)+18]");
				string text = ((string)obj3).InternalSubString(0, 0);
				result = (JsonDict)(object)text;
			}
		}
		return result;
	}

	public JsonList GetList(int index)
	{
		object obj = base.get_Item(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		JsonList jsonList = default;
		bool flag = jsonList == null;
		bool flag2 = !flag;
		JsonList result = jsonList;
		if (!flag2)
		{
			JsonList emptyList = EmptyList;
			result = emptyList;
		}
		return result;
	}

	public unsafe int GetInt(int index, int defaultValue = 0)
	{
		//IL_00c7: Expected Obj, but got I4
		//IL_009d: Expected I4, but got Obj
		ref object reference = ref *(object*)null;
		if (((Dictionary<string, object>)(object)this).TryGetValue((string)index, out reference))
		{
			object obj = reference;
			if (reference == null)
			{
				return 0;
			}
			if (reference != null)
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
			if (obj != null)
			{
				return (int)obj;
			}
		}
		int result = default;
		return result;
	}

	public unsafe long GetInt64(int index, long defaultValue = 0L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Ref, but got Unknown
		//IL_0274: Expected Obj, but got I4
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_0150: Expected I8, but got Obj
		//IL_00e7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		ref object reference = ref *(object*)(obj2 + 8);
		reference = ref *(object*)null;
		obj2 = obj;
		_ = -1;
		if (((Dictionary<string, object>)(object)this).TryGetValue((string)index, out reference))
		{
			object obj3 = reference;
			if (reference != null)
			{
				if ((object)obj3.GetType() != typeof(long))
				{
					obj3 = null;
				}
			}
			else
			{
				obj3 = null;
			}
			if (obj3 != null)
			{
				throw new NullReferenceException();
			}
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v29 (Il2CppClass<System.Convert>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v80 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
			object obj6 = default;
			object obj5 = obj6 << 32;
			object obj7 = default;
			long num3 = obj7 | obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj9 = default;
			object obj8 = obj9;
			object obj10 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj11 = default;
			if (obj10 == obj11)
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
				object obj14 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			long result = default;
			return result;
		}
		return defaultValue;
	}

	public unsafe float GetFloat(int index, float defaultValue = 0f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Ref, but got Unknown
		//IL_0259: Expected Obj, but got I4
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_00e7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		ref object reference = ref *(object*)(obj2 + 8);
		reference = ref *(object*)null;
		obj2 = obj;
		_ = -1;
		if (((Dictionary<string, object>)(object)this).TryGetValue((string)index, out reference))
		{
			object obj3 = reference;
			if (reference != null)
			{
				if ((object)obj3.GetType() != typeof(float))
				{
					obj3 = null;
				}
			}
			else
			{
				obj3 = null;
			}
			if (obj3 != null)
			{
				throw new NullReferenceException();
			}
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v29 (Il2CppClass<System.Convert>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v79 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj6 = default;
			object obj5 = obj6;
			object obj8 = default;
			object obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj9 = default;
			if (obj7 == obj9)
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
				object obj12 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			float result = default;
			return result;
		}
		return defaultValue;
	}

	public unsafe double GetDouble(int index, double defaultValue = 0.0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Ref, but got Unknown
		//IL_0259: Expected Obj, but got I4
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_00e7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		ref object reference = ref *(object*)(obj2 + 8);
		reference = ref *(object*)null;
		obj2 = obj;
		_ = -1;
		if (((Dictionary<string, object>)(object)this).TryGetValue((string)index, out reference))
		{
			object obj3 = reference;
			if (reference != null)
			{
				if ((object)obj3.GetType() != typeof(double))
				{
					obj3 = null;
				}
			}
			else
			{
				obj3 = null;
			}
			if (obj3 != null)
			{
				throw new NullReferenceException();
			}
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v29 (Il2CppClass<System.Convert>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v79 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj6 = default;
			object obj5 = obj6;
			object obj8 = default;
			object obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj9 = default;
			if (obj7 == obj9)
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
				object obj12 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			double result = default;
			return result;
		}
		return defaultValue;
	}

	public bool GetBool(int index, bool defaultValue = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		object obj3 = base.get_Item(index);
		object obj4;
		if (obj3 == null)
		{
			obj4 = null;
		}
		else
		{
			obj4 = (((object)obj3.GetType() != typeof(int)) ? null : obj3);
		}
		if (obj4 != null)
		{
			throw new NullReferenceException();
		}
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v23 (Il2CppClass<System.Convert>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v73 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		if (obj8 == obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj12 = default;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj14 = default;
			object obj13 = obj14;
		}
		else
		{
			object obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		bool result = default;
		return result;
	}

	public string GetString(int index, string defaultValue = "")
	{
		//IL_00c1: Expected I4, but got Obj
		//IL_00aa: Expected Obj, but got I4
		object obj = base.get_Item(index);
		if (obj != null)
		{
			if ((object)obj.GetType() != typeof(bool))
			{
				obj = null;
			}
		}
		else
		{
			obj = null;
		}
		bool flag = obj == null;
		bool flag2 = (byte)(int)defaultValue != 0;
		if (!flag)
		{
			throw new NullReferenceException();
		}
		return (string)flag2;
	}

	public static JsonList ParseString(string json)
	{
		bool typeHasKey = ((JsonClassInfo)(object)json).TypeHasKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		JsonList jsonList = default;
		bool flag = jsonList == null;
		bool flag2 = !flag;
		JsonList result = jsonList;
		if (!flag2)
		{
			JsonList emptyList = EmptyList;
			result = emptyList;
		}
		return result;
	}
}
