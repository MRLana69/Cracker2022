using System;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class PropertyReference
{
	private Component mTarget;

	private string mName;

	private FieldInfo mField;

	private PropertyInfo mProperty;

	private static int s_Hash;

	public Component target
	{
		get
		{
			return mTarget;
		}
		set
		{
			mTarget = value;
			mProperty = null;
			mField = null;
		}
	}

	public string name
	{
		get
		{
			return mName;
		}
		set
		{
			mName = value;
			mProperty = null;
			mField = null;
		}
	}

	public bool isValid
	{
		get
		{
			//IL_0053: Expected Obj, but got I4
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected I4, but got Unknown
			//IL_0037: Expected Obj, but got I4
			object obj;
			if (mTarget != null)
			{
				string text = mName;
				if (mName != null)
				{
					obj = 0;
					if (text._stringLength != 0)
					{
						goto IL_008f;
					}
				}
				obj = 1;
				goto IL_008f;
			}
			return false;
			IL_008f:
			return (byte)(obj ^ 1) != 0;
		}
	}

	public bool isEnabled
	{
		get
		{
			bool flag = mTarget != null;
			bool result = false;
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				UnityEngine.Object obj = default;
				bool flag2 = obj != null;
				result = true;
				if (flag2)
				{
					bool enabled = ((Behaviour)obj).enabled;
					result = enabled;
				}
			}
			return result;
		}
	}

	public PropertyReference()
	{
	}

	public PropertyReference(Component target, string fieldName)
	{
		mTarget = target;
		mName = fieldName;
	}

	public Type GetPropertyType()
	{
		//IL_0119: Expected VT, but got Obj
		//IL_0097: Expected I, but got Obj
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00ed: Expected I, but got Obj
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
			object obj2 = default;
			if (obj2 != null && isValid)
			{
				bool flag = Cache();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		object obj3 = default;
		if (obj3 != null)
		{
			PropertyInfo propertyInfo = mProperty;
			nint num = (nint)propertyInfo;
			object obj4 = propertyInfo + 128;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S1_v12 (Il2CppClass<System.Reflection.PropertyInfo>)+13C] (should have been resolved before IL gen)");
			Type result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		object obj5 = default;
		if (obj5 != null)
		{
			FieldInfo fieldInfo = mField;
			nint num2 = (nint)fieldInfo;
			object obj6 = fieldInfo + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ S1_v8 (Il2CppClass<System.Reflection.FieldInfo>)+144] (should have been resolved before IL gen)");
			Type result2 = default;
			return result2;
		}
		return Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(void));
	}

	public override bool Equals(object obj)
	{
		//IL_0078: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		if (obj == null)
		{
			bool flag = isValid;
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj2 = default;
		bool flag2 = obj2 == null;
		bool result = false;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			Component component = mTarget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v10+8]");
			bool flag3 = component == (UnityEngine.Object)0;
			bool flag4 = !flag3;
			result = false;
			if (!flag4)
			{
				string a = mName;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v10+C]");
				result = string.Equals(a, (string)0);
			}
		}
		return result;
	}

	public override int GetHashCode()
	{
		return s_Hash;
	}

	public void Set(Component target, string methodName)
	{
		mTarget = target;
		mName = methodName;
	}

	public void Clear()
	{
		mTarget = null;
		mName = null;
	}

	public void Reset()
	{
		mField = null;
		mProperty = null;
	}

	public override string ToString()
	{
		return ToString(mTarget, mName);
	}

	public static string ToString(Component comp, string property)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		//IL_00ae: Expected Obj, but got I4
		string text2;
		object obj4;
		if (comp != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj2 = default;
			object obj = obj2;
			object obj3 = obj2 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S1_v5+D4] (should have been resolved before IL gen)");
			string text = default;
			int num = text.LastIndexOf('.');
			bool flag = num >= 1;
			bool flag2 = !flag;
			text2 = text;
			if (!flag2)
			{
				int startIndex = num + 1;
				string text3 = text.Substring(startIndex);
				text2 = text3;
			}
			if (property != null)
			{
				obj4 = 0;
				if (property._stringLength != 0)
				{
					goto IL_014f;
				}
			}
			obj4 = 1;
			goto IL_014f;
		}
		return null;
		IL_014f:
		if (obj4 == null)
		{
			return text2 + "." + property;
		}
		return text2 + ".[property]";
	}

	public object Get()
	{
		//IL_00b9: Expected I, but got Obj
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_0160: Expected I, but got Obj
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0105: Expected I, but got Obj
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
			object obj2 = default;
			if (obj2 != null && isValid)
			{
				bool flag = Cache();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		object obj3 = default;
		object result;
		if (obj3 != null)
		{
			PropertyInfo propertyInfo = mProperty;
			nint num = (nint)propertyInfo;
			object obj4 = propertyInfo + 152;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v11 (Il2CppClass<System.Reflection.PropertyInfo>)+154] (should have been resolved before IL gen)");
			object obj5 = default;
			bool flag2 = obj5 == null;
			result = null;
			if (!flag2)
			{
				PropertyInfo propertyInfo2 = mProperty;
				nint num2 = (nint)propertyInfo2;
				object obj6 = propertyInfo2 + 208;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S3_v10 (Il2CppClass<System.Reflection.PropertyInfo>)+18C] (should have been resolved before IL gen)");
				object result2 = default;
				return result2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
			object obj7 = default;
			bool flag3 = obj7 == null;
			result = null;
			if (!flag3)
			{
				FieldInfo fieldInfo = mField;
				nint num3 = (nint)fieldInfo;
				object obj8 = fieldInfo + 200;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ S2_v7 (Il2CppClass<System.Reflection.FieldInfo>)+184] (should have been resolved before IL gen)");
			}
		}
		return result;
	}

	public unsafe bool Set(object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Ref, but got Unknown
		//IL_0383: Expected I, but got Obj
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_036c: Expected Obj, but got I
		//IL_03d3: Expected I, but got Obj
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_0301: Expected I, but got Obj
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0526: Expected Obj, but got I
		//IL_0551: Expected Obj, but got I
		//IL_0576: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
		object obj3 = default;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
			object obj4 = default;
			if (obj4 != null && isValid)
			{
				bool flag = Cache();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
		object obj5 = default;
		bool result;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
			result = false;
			object obj6 = default;
			if (obj6 != null)
			{
				goto IL_06b5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		if ((nint)0 != 0)
		{
			goto IL_0235;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag2 = default;
		if ((nint)0 != 1)
		{
			if (flag2)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag3 = (nint)0 != 1;
				result = true;
				if (flag3)
				{
					goto IL_06b5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				result = true;
			}
			else
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = default;
				if ((nint)0 != 1)
				{
					if (!flag4)
					{
						goto IL_0235;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					result = true;
					if (flag5)
					{
						goto IL_06b5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					result = true;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					result = flag4;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			result = flag2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj7 = default;
		object obj8 = default;
		bool flag6 = obj7 == obj8;
		bool flag7 = !flag6;
		object obj10 = default;
		object obj9 = obj10;
		bool flag8 = default;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj12 = default;
				object obj11 = obj12;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj13 = default;
					if (obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj14 = (nint)0 << 2;
						object obj15 = obj + obj14;
						obj15 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj16 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj17 = -1;
						result = false;
						goto IL_06b5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj18 = obj12;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					flag8 = (nint)0 != 1;
					if (flag8)
					{
						goto IL_0682;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag9 = (nint)0 == 1;
			object obj19 = default;
			obj9 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			result = false;
			if (flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				goto IL_0682;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_06b5;
		IL_0682:
		return flag8;
		IL_0235:
		if (!Convert(ref *(object*)(obj + 12)))
		{
			bool isPlaying = Application.isPlaying;
			bool flag10 = !isPlaying;
			result = false;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
				object obj20 = default;
				bool flag11 = obj20 == null;
				string text = null;
				if (!flag11)
				{
					object obj21 = obj20;
					object obj22 = obj20 + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v325 @ S1_v28+D4] (should have been resolved before IL gen)");
					string text2 = default;
					text = text2;
				}
				Type propertyType = GetPropertyType();
				string text3 = default;
				if ((object)propertyType != null)
				{
					nint num = (nint)propertyType;
					object obj23 = propertyType + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v374 @ S4_v10 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
				}
				else
				{
					text3 = null;
				}
				string text4 = "Unable to convert " + text + " to " + text3;
				result = false;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
			object obj24 = default;
			if (obj24 != null)
			{
				FieldInfo fieldInfo = mField;
				Component obj25 = mTarget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				fieldInfo.SetValue(obj25, 0);
			}
			else
			{
				PropertyInfo propertyInfo = mProperty;
				nint num2 = (nint)propertyInfo;
				object obj26 = propertyInfo + 160;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v277 @ S1_v17 (Il2CppClass<System.Reflection.PropertyInfo>)+15C] (should have been resolved before IL gen)");
				object obj27 = default;
				bool flag12 = obj27 == null;
				result = false;
				if (flag12)
				{
					goto IL_06b5;
				}
				PropertyInfo propertyInfo2 = mProperty;
				nint num3 = (nint)propertyInfo2;
				object obj28 = propertyInfo2 + 224;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ S4_v4 (Il2CppClass<System.Reflection.PropertyInfo>)+19C] (should have been resolved before IL gen)");
			}
			result = true;
		}
		goto IL_06b5;
		IL_06b5:
		return result;
	}

	private bool Cache()
	{
		//IL_0053: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		if (!(mTarget != null))
		{
			goto IL_00a5;
		}
		string text = mName;
		object obj;
		if (mName != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_0103;
			}
		}
		obj = 1;
		goto IL_0103;
		IL_0103:
		if (obj != null)
		{
			goto IL_00a5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		Type type = default;
		nint num = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S4_v3 (Il2CppClass<System.Type>)+36C] (should have been resolved before IL gen)");
		FieldInfo fieldInfo = default;
		mField = fieldInfo;
		PropertyInfo property = type.GetProperty(mName);
		mProperty = property;
		goto IL_0111;
		IL_0111:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		object obj2 = default;
		if (obj2 != null)
		{
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		bool result = default;
		return result;
		IL_00a5:
		mField = null;
		mProperty = null;
		goto IL_0111;
	}

	private bool Convert(ref object value)
	{
		if (mTarget != null)
		{
			Type propertyType = GetPropertyType();
			Type type = default;
			if (value == null)
			{
				bool isClass = propertyType.IsClass;
				type = propertyType;
				if (!isClass)
				{
					return false;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			}
			return Convert(ref value, type, propertyType);
		}
		bool result = default;
		return result;
	}

	public unsafe static bool Convert(Type from, Type to)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		return Convert(ref *(object*)(obj + 12), from, to);
	}

	public unsafe static bool Convert(object value, Type to)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Type type = default;
		if (value == null)
		{
			_ = 0;
			type = to;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		}
		return Convert(ref *(object*)(obj + 12), type, to);
	}

	public unsafe static bool Convert(ref object value, Type from, Type to)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0373: Expected I, but got Obj
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_0022: Expected VT, but got Obj
		//IL_00e2: Expected VT, but got Obj
		//IL_0081: Expected I, but got Obj
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_026c: Expected VT, but got Obj
		//IL_0121: Expected VT, but got Obj
		//IL_02ac: Expected VT, but got Obj
		//IL_01e2: Expected VT, but got Obj
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Ref, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Ref, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		nint num = (nint)to;
		object obj3 = to + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S2_v2 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
		bool result = true;
		object obj4 = default;
		if (obj4 == null)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
			bool flag = (object)typeFromHandle == to;
			object obj5 = value;
			if (flag)
			{
				object obj7 = default;
				if (value != null)
				{
					nint num2 = (nint)obj5;
					object obj6 = obj5 + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S2_v20 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
				}
				else
				{
					obj7 = "null";
				}
				ref object reference = ref *(object*)obj7;
				goto IL_03b4;
			}
			bool flag2 = value == null;
			result = false;
			if (!flag2)
			{
				Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(int));
				if ((object)typeFromHandle2 == to)
				{
					Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
					if ((object)typeFromHandle3 == from)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
						string s = default;
						bool flag3 = int.TryParse(s, out *(int*)(obj + 8));
						bool flag4 = !flag3;
						result = false;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							object obj8 = obj + 4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							object obj9 = default;
							ref object reference = ref *(object*)obj9;
							goto IL_03b4;
						}
					}
					else
					{
						Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(float));
						bool flag5 = (object)typeFromHandle4 != from;
						result = false;
						if (!flag5)
						{
							throw new NullReferenceException();
						}
					}
				}
				else
				{
					Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(float));
					bool flag6 = (object)typeFromHandle5 != to;
					result = false;
					if (!flag6)
					{
						Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
						bool flag7 = (object)typeFromHandle6 != from;
						result = false;
						if (!flag7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
							string s2 = default;
							bool flag8 = float.TryParse(s2, out *(float*)(obj + 12));
							bool flag9 = !flag8;
							result = false;
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
								_ = 0;
								object obj10 = obj + 4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
								object obj11 = default;
								ref object reference = ref *(object*)obj11;
								goto IL_03b4;
							}
						}
					}
				}
			}
		}
		goto IL_03af;
		IL_03af:
		return result;
		IL_03b4:
		result = true;
		goto IL_03af;
	}

	static PropertyReference()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = "PropertyBinding";
		object obj2 = obj;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S1_v3+CC] (should have been resolved before IL gen)");
		int num = default;
		s_Hash = num;
	}
}
