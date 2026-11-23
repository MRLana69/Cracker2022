using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
{
	private Dictionary<string, Transform> _prefabs;

	bool ICollection<KeyValuePair<string, Transform>>.IsReadOnly => true;

	public int Count
	{
		get
		{
			Dictionary<string, Transform> prefabs = _prefabs;
			return prefabs._count - prefabs._freeCount;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public Transform get_Item(string key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_031d: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_035f: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag = (nint)0 == 1;
		bool flag2 = !flag;
		Transform transform = default;
		Transform result = transform;
		if (flag2)
		{
			goto IL_0302;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag3 = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		PrefabsDict prefabsDict = default;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 == 1;
			Transform transform3 = default;
			Transform transform2 = transform3;
			if (!flag4)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 == 1;
				Transform transform4 = default;
				transform2 = transform4;
				if (!flag5)
				{
					obj6 = obj9;
					if ((object)transform4 != null)
					{
						goto IL_0307;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj10 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					transform2 = transform4;
					result = transform4;
					if (flag6)
					{
						goto IL_0302;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			prefabsDict = (PrefabsDict)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 != 1;
			object obj11 = default;
			obj6 = obj11;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				result = transform2;
				goto IL_0302;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0307;
		IL_0307:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj12 = (nint)0 << 2;
		object obj13 = obj3 + obj12;
		obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj14 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
		nint num = (nint)prefabsDict;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ S1_v25 (Il2CppClass<SYBO.Components.Utilities.PrefabsDict>)+D4] (should have been resolved before IL gen)");
		string text = default;
		string message = "A Prefab with the name '" + key + "' not found. \nPrefabs=" + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		KeyNotFoundException ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj15 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (Transform)(object)ex;
		IL_0302:
		return result;
	}

	public void set_Item(string key, Transform value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Read-only.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public ICollection<string> Keys => _prefabs.Keys;

	public ICollection<Transform> Values => _prefabs.Values;

	private bool IsReadOnly => true;

	public override string ToString()
	{
		//IL_0054: Expected Obj, but got I4
		Dictionary<string, Transform> prefabs = _prefabs;
		object obj = prefabs._count - prefabs._freeCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Dictionary<string, Transform>.KeyCollection keys = _prefabs.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5436");
		string[] value = default;
		string arg = string.Join(", ", value);
		return $"[{arg}]";
	}

	internal void _Add(string prefabName, Transform prefab)
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UnityEngine.Transform>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	internal bool _Remove(string prefabName)
	{
		return _prefabs.Remove(prefabName);
	}

	internal void _Clear()
	{
		throw new IndexOutOfRangeException();
	}

	public bool ContainsKey(string prefabName)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UnityEngine.Transform>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public bool TryGetValue(string prefabName, out Transform prefab)
	{
		return _prefabs.TryGetValue(prefabName, out prefab);
	}

	public void Add(string key, Transform value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Read-Only");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public bool Remove(string prefabName)
	{
		//IL_0041: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Read-Only");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	public bool Contains(KeyValuePair<string, Transform> item)
	{
		//IL_0041: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Use Contains(string prefabName) instead.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	public void Add(KeyValuePair<string, Transform> item)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Read-only");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public void Clear()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Cannot be copied");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	void ICollection<KeyValuePair<string, Transform>>.CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Cannot be copied");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public bool Remove(KeyValuePair<string, Transform> item)
	{
		//IL_0041: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector("Read-only");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (byte)(int)ex != 0;
	}

	public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		obj = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		IEnumerator<KeyValuePair<string, Transform>> result = default;
		return result;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		obj = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		IEnumerator result = default;
		return result;
	}

	public PrefabsDict()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, UnityEngine.Transform>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, Transform> prefabs = default;
		_prefabs = prefabs;
	}
}
