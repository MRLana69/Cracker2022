using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	private readonly IDictionary<TKey, TValue> _dictionary;

	// C# has no syntax for parameterized property 'System.Collections.Generic.IDictionary<TKey,TValue>.Item'.
	TValue IDictionary<TKey, TValue>.get_Item(TKey key)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S3_v4 (Il2CppClass<Il2CppRgctx<ReadOnlyDictionary`2>>)+4] (should have been resolved before IL gen)");
		TValue result = default;
		return result;
	}

	void IDictionary<TKey, TValue>.set_Item(TKey key, TValue value)
	{
		//IL_001c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3 (Il2CppRgctx<ReadOnlyDictionary`2>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S1_v4+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public ICollection<TKey> Keys
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			ICollection<TKey> result = default;
			return result;
		}
	}

	public ICollection<TValue> Values
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			ICollection<TValue> result = default;
			return result;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public TValue get_Item(TKey key)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		TValue result = default;
		return result;
	}

	public int Count
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int result = default;
			return result;
		}
	}

	public bool IsReadOnly => true;

	public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
	{
		_dictionary = dictionary;
	}

	void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
	{
		//IL_001c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3 (Il2CppRgctx<ReadOnlyDictionary`2>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S1_v4+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public bool ContainsKey(TKey key)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		bool result = default;
		return result;
	}

	bool IDictionary<TKey, TValue>.Remove(TKey key)
	{
		//IL_001c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3 (Il2CppRgctx<ReadOnlyDictionary`2>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S1_v4+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		bool result = default;
		return result;
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
		bool result = default;
		return result;
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
	{
		//IL_001c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3 (Il2CppRgctx<ReadOnlyDictionary`2>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S1_v4+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Clear()
	{
		//IL_001c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3 (Il2CppRgctx<ReadOnlyDictionary`2>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S1_v4+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		obj = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @703");
		bool result = default;
		return result;
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
	{
		//IL_001c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3 (Il2CppRgctx<ReadOnlyDictionary`2>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S1_v4+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		bool result = default;
		return result;
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		IEnumerator<KeyValuePair<TKey, TValue>> result = default;
		return result;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//IL_001c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S2_v3 (Il2CppRgctx<ReadOnlyDictionary`2>)+3C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v4+4] (should have been resolved before IL gen)");
		IEnumerator result = default;
		return result;
	}

	private static Exception ReadOnlyException()
	{
		NotSupportedException ex = default;
		ex._002Ector("This dictionary is read-only");
		return ex;
	}
}
