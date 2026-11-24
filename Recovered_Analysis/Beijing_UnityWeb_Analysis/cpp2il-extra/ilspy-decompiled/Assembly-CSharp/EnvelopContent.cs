using System;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using UnityEngine;

public class EnvelopContent : MonoBehaviour
{
	public Transform targetRoot;

	public int padLeft;

	public int padRight;

	public int padBottom;

	public int padTop;

	public bool ignoreDisabled;

	private bool mStarted;

	private void Start()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AdController)(object)this).ChangeToNextProvider();
	}

	private void OnEnable()
	{
		mStarted = true;
		this._002Ector();
	}

	public void Execute()
	{
		if (~(mStarted ? 1u : 0u) == 0)
		{
			this._002Ector();
		}
	}

	public EnvelopContent()
	{
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_03f7: Expected Obj, but got I4
		//IL_041b: Expected I, but got Obj
		//IL_0431: Expected Obj, but got I
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_0244: Expected Obj, but got I4
		//IL_025c: Expected Obj, but got I4
		//IL_025c: Expected VT, but got Obj
		//IL_0186: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02c1: Expected Obj, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_0300: Expected Obj, but got I
		//IL_01c7: Expected I, but got Obj
		//IL_0343: Expected Obj, but got I4
		//IL_0360: Expected I, but got Obj
		//IL_0376: Expected Obj, but got I
		//IL_03a1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		_ = 0;
		GameObject gameObject = base.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S2_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 48;
		object obj5 = obj2 + 36;
		object obj6 = obj2 + 24;
		object obj7 = obj2 + 12;
		if (targetRoot != gameObject)
		{
			nint num3 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v56 (Il2CppClass<UnityEngine.Debug>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num4 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v62 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogErrorFormat("Target Root object cannot be the same object that has Envelop Content. Make it a sibling instead.", (object[])(object)this);
			return;
		}
		GameObject bytes = base.gameObject;
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S2_v19 (Il2CppClass<NGUITools>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v38 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NGUITools.Save((string)(object)targetRoot, (byte[])(object)bytes))
		{
			nint num7 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v45 (Il2CppClass<UnityEngine.Debug>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num8 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v51 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogErrorFormat("Target Root object should not be a parent of Envelop Content. Make it a sibling instead.", (object[])(object)this);
			return;
		}
		Transform parentInternal = ((Transform)(object)base.gameObject).parentInternal;
		Vector3 vector = NGUIMath.WorldToLocalPoint(uiCam: (Camera)((ignoreDisabled ? 1 : 0) ^ 1), worldPos: (Vector3)parentInternal, worldCam: (Camera)(object)targetRoot, relativeTo: (Transform)1);
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v8+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v8+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		object obj8 = obj5 + padLeft;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S2_v12+4]");
		object obj9 = (nint)0 + (nint)padBottom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		object obj10 = obj7 + padRight;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		object obj11 = (nint)0 + (nint)padTop;
		UIWidget component = GetComponent<UIWidget>();
		object obj12 = obj10 - obj8;
		object obj13 = obj11 - obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7F5D");
		((GameObject)(object)this)._002Ector("UpdateAnchors", (Type[])1);
		string w = tag;
		nint num9 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v39 (Il2CppClass<NGUITools>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num10 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v44 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.UpdateWidgetCollider((UIWidget)(object)w);
	}
}
