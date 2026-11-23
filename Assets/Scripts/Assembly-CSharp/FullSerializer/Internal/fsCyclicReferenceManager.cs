using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public class fsCyclicReferenceManager
{
	private class ObjectReferenceEqualityComparator : IEqualityComparer<object>
	{
		public static readonly IEqualityComparer<object> Instance;

		bool IEqualityComparer<object>.Equals(object x, object y)
		{
			return x == y;
		}

		int IEqualityComparer<object>.GetHashCode(object obj)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected I4, but got Unknown
			object obj2 = obj >> 2;
			return obj2 * -1640531535;
		}

		static ObjectReferenceEqualityComparator()
		{
			IEqualityComparer<object> instance = default;
			Instance = instance;
		}
	}

	private Dictionary<object, int> _objectIds;

	private int _nextId;

	private Dictionary<int, object> _marked;

	private int _depth;

	public void Enter()
	{
		int depth = _depth + 1;
		_depth = depth;
	}

	public bool Exit()
	{
		int num = --_depth;
		bool flag = num == 0;
		bool flag2 = !flag;
		int num2 = num;
		if (!flag2)
		{
			nint num3 = 0;
			nint num4 = 0;
			IntPtr intPtr = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Object, System.Int32>>>)+4] (should have been resolved before IL gen)");
			Dictionary<object, int> objectIds = default;
			_objectIds = objectIds;
			_nextId = 0;
			nint num5 = 0;
			nint num6 = 0;
			IntPtr intPtr2 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S4_v10 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Object>>>)+4] (should have been resolved before IL gen)");
			Dictionary<int, object> marked = default;
			_marked = marked;
			num2 = _depth;
		}
		if (num2 <= -1)
		{
			_depth = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			InvalidOperationException ex = default;
			ex._002Ector("Internal Error - Mismatched Enter/Exit. Please report a bug at https://github.com/jacobdufault/fullserializer/issues with the serialization data.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		return num2 == 0;
	}

	public unsafe object GetReferenceObject(int id)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_010b: Expected I4, but got Obj
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Object>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		string text2 = default;
		InvalidOperationException ex = default;
		if (obj6 == null)
		{
			int num3 = obj + 12;
			string text = ((int*)num3)->ToString();
			text2 = "Internal Deserialization Error - Object definition has not been encountered for object with id=" + text + "; have you reordered or modified the serialized data? If this is an issue with an unmodified Full Serializer implementation and unmodified serialization data, please report an issue with an included test case.";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector(text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		return ((fsCyclicReferenceManager)(object)text2)._marked.get_Item((int)ex);
	}

	public void AddReferenceWithId(int id, object reference)
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Object>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	public unsafe int GetReferenceId(object item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Ref, but got Unknown
		//IL_0050: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (!_objectIds.TryGetValue(item, out *(int*)(obj + 12)))
		{
			int nextId = _nextId + 1;
			_nextId = nextId;
			_ = _nextId;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Object, System.Int32>>)+5C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return 0;
	}

	public bool IsReference(object item)
	{
		//IL_002f: Expected Obj, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0055: Expected I4, but got Obj
		int referenceId = GetReferenceId(item);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Object>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S3_v5+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public void MarkSerialized(object item)
	{
		//IL_00b7: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_003c: Expected I, but got Obj
		object obj = default;
		int referenceId = GetReferenceId(obj);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Object>>)+54]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj4 = default;
		object obj3 = obj4 ^ -1;
		object obj5 = obj3 >> 31;
		bool flag = obj5 == null;
		int num3 = referenceId;
		if (!flag)
		{
			bool flag2 = obj == null;
			string text = "Internal Error - ";
			num3 = 0;
			if (!flag2)
			{
				nint num4 = (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ S1_v14 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
				text = "Internal Error - ";
				int num5 = default;
				num3 = num5;
			}
			string message = text + (string)num3 + " has already been marked as serialized";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			InvalidOperationException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Object>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	public fsCyclicReferenceManager()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Object, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<object, int> objectIds = default;
		_objectIds = objectIds;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Object>>>)+4] (should have been resolved before IL gen)");
		Dictionary<int, object> marked = default;
		_marked = marked;
	}
}
