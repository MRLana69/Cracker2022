using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public abstract class GroupedAssetLoader<T, Loader> : AssetLoader<T, Loader> where T : UnityEngine.Object where Loader : AssetLoader<T, Loader>
{
	public Action<string, List<T>> OnNeedPopupForAssetSelection;

	public unsafe T GetGroupAsset(string groupName)
	{
		//IL_0090: Expected Obj, but got I
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected I, but got Unknown
		//IL_00fc: Expected I, but got Obj
		//IL_0117: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v25 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2;
		nint num4 = (nint)(obj4 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj4;
		Type sourcePath = Type.internal_from_handle((IntPtr)num4);
		bool flag = CopyFolderUtility.CopyFolder((string)(object)sourcePath, (string)(object)this, (CopyFolderUtility.CopyMode)groupName);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		T result = default;
		return result;
	}

	protected abstract string GetGroup(T asset);

	protected GroupedAssetLoader()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20+60]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
	}
}
