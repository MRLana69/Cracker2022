using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace FullSerializer;

public sealed class fsContext
{
	private readonly Dictionary<Type, object> _contextObjects;

	public void Reset()
	{
		throw new IndexOutOfRangeException();
	}

	public void Set<T>(T obj)
	{
		//IL_0014: Expected VT, but got I
		//IL_0034: Expected Obj, but got I
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Object>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	public bool Has<T>()
	{
		//IL_0014: Expected VT, but got I
		//IL_0034: Expected Obj, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_005a: Expected I4, but got Obj
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Object>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public unsafe T Get<T>()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0102: Expected VT, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Ref, but got Unknown
		//IL_005d: Expected VT, but got I
		//IL_0099: Expected I, but got Obj
		object obj = default;
		Type type = (Type)(obj - 16);
		_ = 0;
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		bool flag = _contextObjects.TryGetValue(typeFromHandle, out *(object*)(type + 12));
		bool flag2 = !flag;
		bool flag3 = !flag2;
		Type type2 = type;
		if (!flag3)
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)num2);
			bool flag4 = (object)typeFromHandle2 == null;
			string text = "There is no context object of type ";
			string text2 = null;
			if (!flag4)
			{
				nint num3 = (nint)typeFromHandle2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ S1_v18 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
				text = "There is no context object of type ";
				string text3 = default;
				text2 = text3;
			}
			string message = text + text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			InvalidOperationException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			type2 = typeFromHandle2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		T result = default;
		return result;
	}

	public fsContext()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Object>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, object> contextObjects = default;
		_contextObjects = contextObjects;
	}
}
