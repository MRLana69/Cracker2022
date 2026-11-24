using Cpp2ILInjected;
using UnityEngine;

namespace UI;

public class UIWidgetResizer : MonoBehaviour
{
	private UIWidget _anchorBackground;

	private const int PIXELS_OUTSIDE_THE_BACKGROUND = 84;

	private void OnEnable()
	{
		CancelInvoke();
	}

	public void AdjustAnchorBackgroundToResolution()
	{
		this._002Ector();
	}

	public UIWidgetResizer()
	{
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I4
		//IL_029c: Expected I, but got Obj
		//IL_02b2: Expected Obj, but got I
		//IL_0427: Expected I, but got Obj
		//IL_043d: Expected Obj, but got I
		//IL_02d9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0326: Expected I, but got Obj
		//IL_033c: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I
		//IL_037a: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got I
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03c3: Expected I, but got Obj
		//IL_03d9: Expected Obj, but got I
		//IL_0145: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0492: Expected F4, but got Obj
		//IL_04a5: Expected I4, but got Obj
		//IL_04be: Expected F4, but got I
		//IL_019c: Expected I, but got Obj
		//IL_01b2: Expected Obj, but got I
		//IL_022a: Expected I, but got Obj
		//IL_01dd: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v58 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		nint num3 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Object obj6;
		if (((ComputeShader)flag).FindKernel(null) != 0)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v47 (Il2CppClass<UIScreenController>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v54 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v52 (System.Boolean)+3C]");
			obj6 = (Object)0;
		}
		else
		{
			obj6 = null;
		}
		nint num7 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		Object obj8 = obj6;
		if (!flag4)
		{
			string go = tag;
			nint num9 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v34 (Il2CppClass<NGUITools>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v40 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIRoot uIRoot = NGUITools.FindInParents<UIRoot>((GameObject)(object)go);
			obj8 = uIRoot;
		}
		UIWidget anchorBackground = _anchorBackground;
		UIWidget anchorBackground2 = _anchorBackground;
		obj = anchorBackground2.mWidth;
		_ = anchorBackground.mHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ L1_v5 (UnityEngine.Object)+14]");
		object obj10 = -84;
		object obj11 = obj2 + 8;
		obj11 = obj;
		nint num11 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S2_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num12 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S2_v20 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width((float)obj11);
		_anchorBackground.height = (int)gUILayoutOption;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
		Color color = ((UIWidget)(object)gUILayoutOption2).color;
	}
}
