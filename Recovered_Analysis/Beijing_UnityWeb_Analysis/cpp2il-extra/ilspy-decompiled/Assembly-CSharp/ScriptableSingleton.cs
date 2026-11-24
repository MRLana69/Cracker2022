using System;
using Cpp2ILInjected;
using UnityEngine;

public abstract class ScriptableSingleton<T> : ScriptableObject where T : ScriptableSingleton<T>
{
	private static T _cachedInstance;

	private static string _fileName
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector("This dictionary is read-only");
			return (string)(object)ex;
		}
	}

	private unsafe static string _resourcePath
	{
		get
		{
			//IL_006c: Expected Obj, but got I
			//IL_007a: Expected I, but got Obj
			//IL_0090: Expected Obj, but got I
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected I, but got Unknown
			//IL_00d0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10+60]");
			object obj = 0;
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<System.Type>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v23 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = obj;
			nint num3 = (nint)(obj3 + 4);
			((IntPtr*)num3)->m_value = (void*)(nint)obj3;
			Type type = Type.internal_from_handle((IntPtr)num3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string result = default;
			return result;
		}
	}

	public static T instance
	{
		get
		{
			//IL_000e: Expected Obj, but got I
			//IL_0028: Expected Obj, but got I
			//IL_0038: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			nint num = default;
			object obj = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v5+4]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v10+60]");
			object obj4 = 0;
			object obj5 = obj3 & 0xFFF;
			object obj6 = obj5 + 1797;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S1_v4 (should have been resolved before IL gen)");
			T result = default;
			return result;
		}
	}

	protected virtual void OnCreate()
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0xFFF;
		object obj5 = obj4 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22 @ S1_v5 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}
}
