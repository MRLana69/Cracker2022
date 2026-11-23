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
			//IL_003c: Expected Obj, but got I
			//IL_0045: Expected VT, but got Obj
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+60]");
			object obj = 0;
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
			object obj2 = typeFromHandle - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v5+BC] (should have been resolved before IL gen)");
			string result = default;
			return result;
		}
	}

	private static string _resourcePath
	{
		get
		{
			//IL_001a: Expected Obj, but got I
			//IL_002a: Expected Obj, but got I
			//IL_0049: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v3+60]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S0_v4+4]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S0_v9+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S0_v5+4] (should have been resolved before IL gen)");
			string result = default;
			return result;
		}
	}

	public static T instance
	{
		get
		{
			//IL_02dd: Expected Obj, but got I
			//IL_019a: Expected Obj, but got I
			//IL_0046: Expected Obj, but got I
			//IL_0056: Expected Obj, but got I
			//IL_0075: Expected Obj, but got I
			//IL_0306: Expected Obj, but got I
			//IL_01e0: Expected Obj, but got I
			//IL_01f0: Expected Obj, but got I
			//IL_020f: Expected Obj, but got I
			//IL_0242: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I
			//IL_028c: Expected Obj, but got I
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9+5C]");
			object obj = 0;
			if ((UnityEngine.Object)obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v69+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v70+10]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v75+60]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S0_v71+4] (should have been resolved before IL gen)");
				string path = default;
				UnityEngine.Object obj5 = Resources.Load(path);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v86+5C]");
				object obj6 = 0;
				object obj7 = default;
				obj6 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21+5C]");
			object obj8 = 0;
			if ((UnityEngine.Object)obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v38+60]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v39+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v44+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S0_v40+4] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v52+5C]");
				object obj12 = 0;
				object obj13 = default;
				obj12 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v64+5C]");
				object obj14 = 0;
				object obj15 = obj14;
				object obj16 = obj15;
				object obj17 = obj15 + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v161 @ S1_v15+DC] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @224");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v33+5C]");
			return (T)0;
		}
	}

	protected virtual void OnCreate()
	{
	}
}
