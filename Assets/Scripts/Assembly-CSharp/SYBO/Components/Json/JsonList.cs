using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace SYBO.Components.Json;

public class JsonList : List<object>
{
	public static JsonList EmptyList
	{
		get
		{
			JsonList jsonList = default;
			jsonList._002Ector();
			return jsonList;
		}
	}

	public JsonList()
	{
	}

	public JsonList(int capacity)
		: base(capacity)
	{
	}

	public JsonDict GetDict(int index)
	{
		object obj = base.get_Item(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		JsonDict jsonDict = default;
		if (jsonDict == null)
		{
			return JsonDict.EmptyDict;
		}
		return jsonDict;
	}

	public JsonList GetList(int index)
	{
		object obj = base.get_Item(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		JsonList jsonList = default;
		if (jsonList == null)
		{
			return EmptyList;
		}
		return jsonList;
	}

	public int GetInt(int index, int defaultValue = 0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_020c: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I
		//IL_025c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		object obj4 = base.get_Item(index);
		bool flag = obj4 == null;
		object obj5 = null;
		if (!flag)
		{
			bool flag2 = (object)obj4.GetType() == typeof(int);
			obj5 = obj4;
			if (!flag2)
			{
				obj5 = null;
			}
		}
		if (obj5 != null)
		{
			throw new NullReferenceException();
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		int result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			int num = default;
			result = num;
			if (flag3)
			{
				goto IL_03c9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag4 = obj6 != obj7;
		int num2 = default;
		result = num2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj10 = default;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj11 = (nint)0 << 2;
						object obj12 = obj3 + obj11;
						obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj14 = -1;
						result = defaultValue;
						goto IL_03c9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj15 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result = 0;
					if (flag5)
					{
						goto IL_03ce;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 != 1;
			int num3 = default;
			result = num3;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				result = num3;
			}
		}
		goto IL_03ce;
		IL_03ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_03c9;
		IL_03c9:
		return result;
	}

	public long GetInt64(int index, long defaultValue = 0L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_02cd: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		object obj4 = base.get_Item(index);
		bool flag = obj4 == null;
		object obj5 = null;
		if (!flag)
		{
			bool flag2 = (object)obj4.GetType() == typeof(long);
			obj5 = obj4;
			if (!flag2)
			{
				obj5 = null;
			}
		}
		if (obj5 != null)
		{
			throw new NullReferenceException();
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		long result = default;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			long num = default;
			result = num;
			if (flag3)
			{
				goto IL_03d1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			result = num;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag4 = obj6 != obj7;
		object obj9 = default;
		object obj8 = obj9;
		if (!flag4)
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj16 = -1;
						result = defaultValue;
						goto IL_03d1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj17 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj8 = 0;
					if (flag5)
					{
						goto IL_03d6;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 != 1;
			object obj18 = default;
			obj8 = obj18;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj8 = obj18;
			}
		}
		goto IL_03d6;
		IL_03d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_03d1;
		IL_03d1:
		return result;
	}

	public float GetFloat(int index, float defaultValue = 0f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_02cd: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		object obj4 = base.get_Item(index);
		bool flag = obj4 == null;
		object obj5 = null;
		if (!flag)
		{
			bool flag2 = (object)obj4.GetType() == typeof(float);
			obj5 = obj4;
			if (!flag2)
			{
				obj5 = null;
			}
		}
		if (obj5 != null)
		{
			throw new NullReferenceException();
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		float result = default;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			float num = default;
			result = num;
			if (flag3)
			{
				goto IL_03d1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			result = num;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag4 = obj6 != obj7;
		object obj9 = default;
		object obj8 = obj9;
		if (!flag4)
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj16 = -1;
						result = defaultValue;
						goto IL_03d1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj17 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj8 = 0;
					if (flag5)
					{
						goto IL_03d6;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 != 1;
			object obj18 = default;
			obj8 = obj18;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj8 = obj18;
			}
		}
		goto IL_03d6;
		IL_03d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_03d1;
		IL_03d1:
		return result;
	}

	public double GetDouble(int index, double defaultValue = 0.0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_02cd: Expected Obj, but got I
		//IL_0214: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		object obj4 = base.get_Item(index);
		bool flag = obj4 == null;
		object obj5 = null;
		if (!flag)
		{
			bool flag2 = (object)obj4.GetType() == typeof(double);
			obj5 = obj4;
			if (!flag2)
			{
				obj5 = null;
			}
		}
		if (obj5 != null)
		{
			throw new NullReferenceException();
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		double result = default;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			double num = default;
			result = num;
			if (flag3)
			{
				goto IL_03d1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			result = num;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag4 = obj6 != obj7;
		object obj9 = default;
		object obj8 = obj9;
		if (!flag4)
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj16 = -1;
						result = defaultValue;
						goto IL_03d1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj17 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj8 = 0;
					if (flag5)
					{
						goto IL_03d6;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 != 1;
			object obj18 = default;
			obj8 = obj18;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj8 = obj18;
			}
		}
		goto IL_03d6;
		IL_03d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_03d1;
		IL_03d1:
		return result;
	}

	public bool GetBool(int index, bool defaultValue = false)
	{
		object obj = base.get_Item(index);
		bool flag = obj == null;
		object obj2 = null;
		if (!flag)
		{
			bool flag2 = (object)obj.GetType() == typeof(bool);
			obj2 = obj;
			if (!flag2)
			{
				obj2 = null;
			}
		}
		if (obj2 != null)
		{
			throw new NullReferenceException();
		}
		return defaultValue;
	}

	public string GetString(int index, string defaultValue = "")
	{
		object obj = base.get_Item(index);
		bool flag = obj == null;
		object obj2 = null;
		if (!flag)
		{
			bool flag2 = (object)obj.GetType() == typeof(string);
			obj2 = obj;
			if (!flag2)
			{
				obj2 = null;
			}
		}
		string result = (string)obj2;
		if (obj2 == null)
		{
			result = defaultValue;
		}
		return result;
	}

	public static JsonList ParseString(string json)
	{
		object obj = JsonApi.DeserializeDom(json);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		JsonList result = default;
		return result;
	}
}
