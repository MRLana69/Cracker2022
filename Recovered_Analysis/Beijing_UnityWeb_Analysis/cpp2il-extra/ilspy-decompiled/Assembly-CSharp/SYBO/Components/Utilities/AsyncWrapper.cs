using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public abstract class AsyncWrapper
{
	protected IAsyncResult _asyncResult;

	protected Action _asyncMethod;

	protected Exception Error;

	public void EndInvoke()
	{
	}

	protected AsyncWrapper()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78BB");
		if (Error != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
public class AsyncWrapper<T> : AsyncWrapper
{
	private Action<T> _method;

	private T _argument;

	public void ThreadCatchingWrapper()
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0027: Expected Obj, but got I
		//IL_0037: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F5BB");
		object obj = this + 12;
		object obj2 = default;
		obj = obj2;
		nint num = default;
		object obj3 = num + 12;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v8+18]");
		object obj8 = 0;
		object obj9 = obj8 & 0x3FFF;
		object obj10 = obj9 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v42 @ S2_v4 (should have been resolved before IL gen)");
		object obj11 = this + 20;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj13 = this + 24;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724B");
	}

	public AsyncWrapper(Action<T> method)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = method;
	}

	public void BeginInvoke(T argument, AsyncCallback callback)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.AsyncWrapper`1<T>)+C]");
		if ((nint)0 != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v11+1C]");
		object obj3 = 0;
		object obj4 = obj3 & 0xFFF;
		object obj5 = obj4 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S1_v6 (should have been resolved before IL gen)");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj7 = default;
		if (obj7 != (UnityEngine.Object)(object)this)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}
}
public class AsyncWrapper<T1, T2> : AsyncWrapper
{
	private Action<T1, T2> _method;

	private T1 _argument1;

	private T2 _argument2;

	public void ThreadCatchingWrapper()
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18+60]");
		object obj4 = 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
	}

	public AsyncWrapper(Action<T1, T2> method)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0052: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = method;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6+4]");
		object obj4 = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = this;
		object obj7 = this + 12;
		obj7 = obj6;
	}

	public void BeginInvoke(T1 argument1, T2 argument2, AsyncCallback callback)
	{
		//IL_008d: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I
		//IL_01d6: Expected Obj, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0211: Expected Obj, but got VT
		//IL_0211: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_0239: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_0012: Expected Obj, but got VT
		//IL_0012: Expected Obj, but got VT
		//IL_0024: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_014e: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.AsyncWrapper`2<T1, T2>)+10]");
		nint num = default;
		object obj7;
		if ((nint)0 != 0)
		{
			AssetBundleRequest assetBundleRequest = ((AssetBundle)argument1).LoadAssetAsync<T>((string)argument2);
			object obj = num + 12;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v20+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S3_v21+20]");
			object obj4 = 0;
			object obj5 = obj4 & 0x3FFF;
			object obj6 = obj5 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S4_v27 (should have been resolved before IL gen)");
			obj7 = obj;
		}
		else
		{
			object obj8 = num + 12;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S4_v18+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S4_v19+24]");
			object obj11 = 0;
			object obj12 = obj11 & 0x1FFF;
			object obj13 = obj12 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S5_v12 (should have been resolved before IL gen)");
			obj7 = obj8;
		}
		object obj14 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S3_v3+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S3_v4+28]");
		object obj16 = 0;
		object obj17 = obj16 & 0x1FFF;
		object obj18 = obj17 + 30963;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v75 @ S4_v5 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.AsyncWrapper`2<T1, T2>)+8]");
		int num2 = ((Dictionary<string, int>)0).get_Item((string)argument2);
		object obj19 = num2 - 1;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S4_v8+60]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S4_v9+48]");
		object obj22 = 0;
		object obj23 = obj22 & 0x7FF;
		object obj24 = obj23 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v103 @ S5_v7 (should have been resolved before IL gen)");
		if (callback != null)
		{
			object obj25 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v9+60]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S2_v10+2C]");
			object obj27 = 0;
			object obj28 = obj27 & 0x3FFF;
			object obj29 = obj28 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v120 @ S3_v11 (should have been resolved before IL gen)");
			object obj30 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S2_v13+60]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S2_v14+30]");
			object obj32 = 0;
			object obj33 = obj32 & 0x3FFF;
			object obj34 = obj33 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v132 @ S3_v15 (should have been resolved before IL gen)");
		}
	}
}
