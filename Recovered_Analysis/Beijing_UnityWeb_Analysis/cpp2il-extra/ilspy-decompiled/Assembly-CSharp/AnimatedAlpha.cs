using Cpp2ILInjected;
using UnityEngine;

public class AnimatedAlpha : MonoBehaviour
{
	public float alpha;

	private UIWidget mWidget;

	private UIPanel mPanel;

	private void OnEnable()
	{
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002d: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got F4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		Color black = Color.black;
		object obj3 = obj2 + 32;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj4 = this + 80;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
		_ = 0;
		_ = 4;
		_ = 100;
		_ = 100;
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UIRect uIRect = default;
		uIRect.OnEnable();
		object obj5 = this + 148;
		obj5 = uIRect;
		_ = 1;
		_ = 1;
		obj2 = 0;
		_ = 0;
		obj2 = 0f;
		_ = 0f;
		_ = 1f;
		_ = 1f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = this + 156;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
		_ = 0;
		_ = 1;
		_ = 1;
		_ = 1;
		object obj7 = this + 252;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj8 = default;
		obj7 = obj8;
		_ = -1;
		_ = -1;
		nint num = (nint)typeof(UIRect);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v46 (Il2CppClass<UIRect>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(UIRect);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v52 (Il2CppClass<UIRect>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UISnapshotPoint)this).Start();
	}

	private void LateUpdate()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		object obj = this + 16;
		UIWidget component = GetComponent<UIWidget>();
		obj = component;
		object obj2 = this + 20;
		UIPanel component2 = GetComponent<UIPanel>();
		obj2 = component2;
		this._002Ector();
	}

	public AnimatedAlpha()
	{
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b0: Expected I, but got Obj
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mWidget).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		}
		nint num3 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mPanel).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		}
	}
}
