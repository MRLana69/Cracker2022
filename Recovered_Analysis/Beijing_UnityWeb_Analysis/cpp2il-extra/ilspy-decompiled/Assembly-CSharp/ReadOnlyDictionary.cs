using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	private readonly IDictionary<TKey, TValue> _dictionary;

	public ICollection<TKey> Keys => (ICollection<TKey>)_dictionary;

	public ICollection<TValue> Values
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v2+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			ICollection<TValue> result = default;
			return result;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public TValue get_Item(TKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14 @ S3_v4 (should have been resolved before IL gen)");
		TValue result = default;
		return result;
	}

	// C# has no syntax for parameterized property 'System.Collections.Generic.IDictionary<TKey,TValue>.Item'.
	TValue IDictionary<TKey, TValue>.get_Item(TKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		TValue result = default;
		return result;
	}

	void IDictionary<TKey, TValue>.set_Item(TKey key, TValue value)
	{
		//IL_000a: Expected Obj, but got VT
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got VT
		_dictionary = (IDictionary<TKey, TValue>)value;
		object obj = this + 16;
		obj = key;
	}

	public int Count
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v2+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int result = default;
			return result;
		}
	}

	public bool IsReadOnly
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v2+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			bool result = default;
			return result;
		}
	}

	public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
	{
		throw new InvalidOperationException();
	}

	void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0xFFF;
		object obj5 = obj4 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22 @ S1_v5 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public bool ContainsKey(TKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S2_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S2_v3+C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v15 @ S3_v4 (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	bool IDictionary<TKey, TValue>.Remove(TKey key)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		bool result = default;
		return result;
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		//IL_0133: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_02e0: Expected I, but got Obj
		//IL_02f6: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_021d: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_0297: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I
		//IL_00eb: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		object obj = 0;
		nint num = default;
		object obj2 = num + 12;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v3+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S3_v4+34]");
		object obj5 = 0;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 30963;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v39 @ S4_v5 (should have been resolved before IL gen)");
		object obj8 = default;
		if (obj8 == null)
		{
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v14+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S2_v16+60]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S2_v17+3C]");
			object obj13 = 0;
			object obj14 = obj13 & 0x3FFF;
			object obj15 = obj14 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v114 @ S3_v20 (should have been resolved before IL gen)");
			object obj16 = default;
			obj = obj16;
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S3_v22+60]");
			object obj18 = -(-64);
			object obj19 = obj18;
			object obj20 = obj19 & 0x1FFF;
			object obj21 = obj20 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v56 @ S4_v17 (should have been resolved before IL gen)");
		}
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v8+60]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v9+44]");
		object obj25 = 0;
		object obj26 = obj25 & 0x3FFF;
		object obj27 = obj26 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v96 @ S2_v6 (should have been resolved before IL gen)");
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v22+60]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S2_v8+60]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S2_v9+4C]");
		object obj32 = 0;
		object obj33 = obj32 & 0x3FFF;
		object obj34 = obj33 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v140 @ S3_v12 (should have been resolved before IL gen)");
		object obj35 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S2_v12+60]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S2_v13+50]");
		object obj37 = 0;
		object obj38 = obj37 & 0x3FFF;
		object obj39 = obj38 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v155 @ S3_v16 (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got VT
		object obj = this + 8;
		obj = item;
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Clear()
	{
		//IL_0035: Expected Obj, but got I
		//IL_0045: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ReadOnlyDictionary`2<TKey, TValue>)+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S2_v3+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v4+4]");
			object obj3 = 0;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0xFFF;
		object obj5 = obj4 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22 @ S1_v5 (should have been resolved before IL gen)");
		ReadOnlyDictionary<object, object> readOnlyDictionary = default;
		readOnlyDictionary.System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002ERemove(null);
		return false;
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0xFFF;
		object obj5 = obj4 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22 @ S1_v5 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0032: Expected Obj, but got VT
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		object obj3 = item;
		object obj4 = obj3 + 8;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C194");
		bool result = default;
		return result;
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		//IL_0006: Expected Obj, but got I4
		return (IEnumerator<KeyValuePair<TKey, TValue>>)1;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		IEnumerator result = default;
		return result;
	}

	private static Exception ReadOnlyException()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		nint num = default;
		object obj = num + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v7+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v22+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v25+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v30+60]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v5+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v6+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v11+60]");
		object obj10 = 0;
		object obj11 = obj9 & 0x3FFF;
		object obj12 = obj11 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S2_v3 (should have been resolved before IL gen)");
		Exception result = default;
		return result;
	}
}
