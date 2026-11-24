using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Analytics.Albatross;
using UnityEngine;

namespace SYBO.Components.Utilities;

public static class CopyFolderUtility
{
	public enum CopyMode
	{
		OverwriteParentAndKeepChildren = 0,
		OverwriteParentAndChildren = 2
	}

	public static bool CopyFolder(string sourcePath, string destinationPath, CopyMode copyMode)
	{
		//IL_0275: Expected I, but got Obj
		//IL_028b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0254: Expected I4, but got Obj
		//IL_014e: Expected I, but got Obj
		//IL_01ac: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I4
		//IL_01ed: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I4
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v57 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (sourcePath != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v53 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)destinationPath != null)
			{
				return false;
			}
			Component componentInParent = ((GameObject)(object)destinationPath).GetComponentInParent((Type)(object)sourcePath);
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (componentInParent != null)
			{
				bool flag = ((GameObject)(object)destinationPath).CompareTag(sourcePath);
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num9 = ((ComputeShader)flag).FindKernel(null);
				if (((uint)num9 & (uint)copyMode) != 0)
				{
					UnityEngine.Object.CheckNullArgument((object)flag, (string)2);
				}
				return flag;
			}
			return (byte)(int)componentInParent != 0;
		}
		return false;
	}

	private unsafe static bool CopyFilesInFolder(string sourcePath, string destinationPath, bool willOverwriteChildFiles, bool displayProgressBar = true)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		//IL_0064: Expected I4, but got Obj
		Dictionary<string, string> dictionary = (Dictionary<string, string>)((bool*)(willOverwriteChildFiles ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [willOverwriteChildFiles @ L2 (System.Boolean)+8]");
		dictionary.buckets = (int[])0;
		byte[] array = (byte[])(dictionary + 16);
		array = (byte[])((bool*)(displayProgressBar ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [displayProgressBar @ L3 (System.Boolean)+8]");
		_ = 0;
		return (byte)(int)((MinimalHTTPPost)(object)sourcePath).WaitForWWWRequest(destinationPath, dictionary, array, (Action<int, string, string>)null) != 0;
	}
}
