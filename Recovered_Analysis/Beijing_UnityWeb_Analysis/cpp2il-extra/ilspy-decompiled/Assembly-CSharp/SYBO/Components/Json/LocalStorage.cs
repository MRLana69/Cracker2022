using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace SYBO.Components.Json;

public class LocalStorage<T>
{
	protected JsonContext _jsonContext;

	protected string _localUrl;

	private IStringStorage _stringStorage;

	private T _object;

	public T Object
	{
		get
		{
			//IL_0019: Expected VT, but got I4
			bool flag = _jsonContext != null;
			return (T)flag;
		}
	}

	public string LocalUrl
	{
		get
		{
			//IL_0007: Expected Obj, but got VT
			return (string)_object;
		}
	}

	public bool CanLoad
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_localUrl != 0;
		}
	}

	public LocalStorage(T obj, string localUrl, JsonContext jsonContext = null, IStringStorage stringStorage = null)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.LocalStorage`1<T>)+34]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.LocalStorage`1<T>)+34]");
		object obj4;
		object obj5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.LocalStorage`1<T>)+34]");
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
		object obj26 = default;
		object obj18 = default;
		object obj24 = default;
		for (; obj6 != obj4; obj6 = obj26 + 1)
		{
			object obj7 = obj6 << 2;
			object obj8 = obj5 + obj7;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+14]");
			IStringStorage stringStorage2 = (IStringStorage)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (SYBO.Components.Json.IStringStorage)+28]");
			if ((nint)0 == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (SYBO.Components.Json.IStringStorage)+2A]");
			bool flag = (nint)0 == 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (SYBO.Components.Json.IStringStorage)+24]");
			object obj11 = (nint)0 & (nint)0x10;
			bool flag2 = obj11 == null;
			object obj12 = (flag2 ? 1 : 0) ^ 1;
			IStringStorage stringStorage4;
			IStringStorage stringStorage3;
			if (obj12 != null)
			{
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+8]");
					object obj13 = (nint)0 & (nint)0x7FF;
					stringStorage3 = (IStringStorage)(obj13 + 121922);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v206 @ S5_v16 (SYBO.Components.Json.IStringStorage) (should have been resolved before IL gen)");
					stringStorage4 = (IStringStorage)121922;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+8]");
					object obj14 = (nint)0 & (nint)0x3FF;
					stringStorage4 = (IStringStorage)(obj14 + 123986);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v204 @ S6_v6 (SYBO.Components.Json.IStringStorage) (should have been resolved before IL gen)");
					stringStorage3 = stringStorage2;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (SYBO.Components.Json.IStringStorage)+28]");
			bool flag3 = (nint)0 != -1;
			if (!flag)
			{
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+10]");
					bool flag4;
					if ((nint)0 != 0)
					{
						object obj15 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v94+9C]");
						object obj16 = (nint)0 & (nint)0x100;
						flag4 = obj16 != null;
					}
					else
					{
						flag4 = false;
					}
					if (!flag4 && _localUrl != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (SYBO.Components.Json.IStringStorage)+2B]");
						object obj17 = (nint)0 & (nint)3;
						bool flag5 = (nint)obj17 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag5)
						{
							if (obj18 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8961");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8962");
							}
						}
						else if (obj18 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
							stringStorage3 = stringStorage;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+8]");
				object obj19 = (nint)0 & (nint)0x7FF;
				stringStorage3 = (IStringStorage)(obj19 + 121922);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v206 @ S5_v16 (SYBO.Components.Json.IStringStorage) (should have been resolved before IL gen)");
				stringStorage4 = (IStringStorage)121922;
				continue;
			}
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+10]");
				bool flag6;
				if ((nint)0 != 0)
				{
					object obj20 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v66+9C]");
					object obj21 = (nint)0 & (nint)0x100;
					flag6 = obj21 != null;
				}
				else
				{
					flag6 = false;
				}
				if (!flag6 && _localUrl != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+10]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+8]");
						object obj22 = (nint)0 & (nint)0x7FF;
						stringStorage3 = (IStringStorage)(obj22 + 121922);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v206 @ S5_v16 (SYBO.Components.Json.IStringStorage) (should have been resolved before IL gen)");
						stringStorage4 = (IStringStorage)121922;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v19 (SYBO.Components.Json.IStringStorage)+2B]");
					object obj23 = (nint)0 & (nint)3;
					bool flag7 = (nint)obj23 == 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
					if (flag7)
					{
						if (obj24 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8963");
							stringStorage3 = stringStorage;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8964");
							stringStorage3 = stringStorage;
						}
					}
					else if (obj24 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
						stringStorage4 = stringStorage;
						stringStorage3 = (IStringStorage)jsonContext;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8966");
						stringStorage3 = stringStorage;
					}
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v14+8]");
			object obj25 = (nint)0 & (nint)0x3FF;
			stringStorage4 = (IStringStorage)(obj25 + 123986);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v204 @ S6_v6 (SYBO.Components.Json.IStringStorage) (should have been resolved before IL gen)");
			stringStorage3 = stringStorage2;
		}
	}

	public void DeleteLocalFile()
	{
	}

	public bool Read()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		bool result = default;
		return result;
	}

	public void ReadAndSerializeOnto(T targetObject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		JsonContext jsonContext = (JsonContext)(targetObject & 1);
		_jsonContext = jsonContext;
	}

	public bool Write()
	{
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00f2: Expected I4, but got Obj
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		bool flag;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v6+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			Dictionary<Type, HashSet<string>> dictionary = _jsonContext.CollectUnknownReferences();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S2_v6+60]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44 @ S3_v5 (should have been resolved before IL gen)");
			object obj7 = default;
			if (obj7 != null)
			{
				object obj8 = this + 20;
				obj8 = obj7;
			}
			else
			{
				string text = string.Format((IFormatProvider)(object)"obj.IsValid() = false. Stored file may be broken for obj={0} at url={1}.", null, _localUrl);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Exception ex = default;
				ex.SetErrorCode((int)text);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		return true;
	}

	public unsafe bool Clear()
	{
		//IL_0159: Invalid comparison between VT and I4
		//IL_008e: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected I, but got Unknown
		//IL_0198: Expected I, but got Obj
		//IL_0024: Expected Obj, but got I
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0139: Expected I4, but got Obj
		//IL_00ed: Expected I, but got Obj
		if (_object != (T)(object)0)
		{
			Dictionary<Type, HashSet<string>> dictionary = _jsonContext.CollectUnknownReferences();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v7+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v8+C]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S3_v4 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			bool result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v11+60]");
		object obj7 = 0;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v15 (Il2CppClass<System.Type>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v32 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v12+10]");
		object obj9 = 0;
		nint num3 = (nint)(obj9 + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)obj9;
		Type args = Type.internal_from_handle((IntPtr)num3);
		string text = $"_object is null. Do nullcheck before calling {(object[])(object)args}.Write().";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Exception ex = default;
		ex.SetErrorCode((int)text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return false;
	}
}
