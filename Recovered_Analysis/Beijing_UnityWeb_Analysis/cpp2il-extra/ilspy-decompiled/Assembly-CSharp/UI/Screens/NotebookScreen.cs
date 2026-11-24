using System;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UI.DoubleCoinsVideo;
using UnityEngine;

namespace UI.Screens;

public class NotebookScreen : UIScreen
{
	private UISprite _background;

	private UISprite _decal;

	public UIScrollBar _scrollbar;

	private const int PIXELS_OUTSIDE_THE_BACKGROUND = 84;

	private const int DECAL_OFFSET = 145;

	private static NotebookScreen _instance;

	public override void AdjustToResolution()
	{
	}

	private void Awake()
	{
		//IL_0598: Expected I, but got Obj
		//IL_05ae: Expected Obj, but got I
		//IL_0811: Expected I, but got Obj
		//IL_0827: Expected Obj, but got I
		//IL_05d5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0622: Expected I, but got Obj
		//IL_0638: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_060f: Expected Obj, but got I
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected Obj, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected Obj, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected Obj, but got Unknown
		//IL_0145: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_019c: Expected I, but got Obj
		//IL_01b2: Expected Obj, but got I
		//IL_022a: Expected I, but got Obj
		//IL_0240: Expected Obj, but got I
		//IL_01dd: Expected I, but got Obj
		//IL_026b: Expected I, but got Obj
		//IL_02b8: Expected I, but got Obj
		//IL_02ce: Expected Obj, but got I
		//IL_02f9: Expected I, but got Obj
		//IL_0346: Expected I, but got Obj
		//IL_035c: Expected Obj, but got I
		//IL_075a: Expected I, but got Obj
		//IL_0770: Expected Obj, but got I
		//IL_0387: Expected I, but got Obj
		//IL_03d4: Expected I, but got Obj
		//IL_04e0: Expected VT, but got Obj
		//IL_0430: Expected I, but got Obj
		//IL_0446: Expected Obj, but got I
		//IL_07bd: Expected F4, but got I4
		//IL_07d6: Expected Obj, but got I4
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_0518: Expected VT, but got Obj
		//IL_0521: Expected Obj, but got I4
		//IL_0471: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v85 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v93 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj4;
		if (((ComputeShader)flag).FindKernel(null) != 0)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v74 (Il2CppClass<UIScreenController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v81 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v79 (System.Boolean)+3C]");
			obj4 = (UnityEngine.Object)0;
		}
		else
		{
			obj4 = null;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = obj4 != null;
		bool flag4 = !flag3;
		UnityEngine.Object obj6 = obj4;
		if (!flag4)
		{
			string go = tag;
			nint num9 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v82 (Il2CppClass<NGUITools>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v88 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIRoot uIRoot = NGUITools.FindInParents<UIRoot>((GameObject)(object)go);
			obj6 = uIRoot;
		}
		object obj8 = default;
		Transform transform = (Transform)(obj8 + 36);
		Transform transform2 = (Transform)(obj8 + 24);
		Transform transform3 = (Transform)(obj8 + 12);
		if (UI.DoubleCoinsVideo.DoubleCoinsVideo.payoutCap == 0)
		{
			return;
		}
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v76 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_background).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_decal).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num15 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S2_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num16 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S2_v45 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ L1_v4 (UnityEngine.Object)+14]");
		float width = 0f - 84f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		Color color = ((UIWidget)(object)gUILayoutOption).color;
		nint num17 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v44 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num18 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v61 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			GameObject gameObject = _background.gameObject;
			nint num19 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v57 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num20 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v66 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TransformExtensions.OffsetLocalPosZ((Transform)(object)gameObject, IPhoneXSupport.OFFSET_BOTTOM);
			UISprite background = _background;
			object obj14 = IPhoneXSupport.OFFSET_TOP + IPhoneXSupport.OFFSET_BOTTOM;
			UIWidget uIWidget = (UIWidget)(((UIWidget)background).mHeight - obj14);
			Color color2 = uIWidget.color;
		}
		GameObject gameObject2 = _decal.gameObject;
		GameObject gameObject3 = _decal.gameObject;
		transform2.localPosition = (Vector3)gameObject3;
		int sleepTimeout = Screen.sleepTimeout;
		int height = Screen.height;
		GameObject gameObject4 = _decal.gameObject;
		transform3.localPosition = (Vector3)gameObject4;
		obj8 = 0;
		_ = 0;
		obj8 = transform2;
		int num21 = sleepTimeout / height;
		float num22 = (float)num21 * 145f;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		transform = (Transform)obj8;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	public static void SetDecalState(bool active)
	{
		//IL_000e: Expected Obj, but got I4
		_instance = (NotebookScreen)active;
	}

	public NotebookScreen()
	{
		NotebookScreen instance = _instance;
		string text = instance._decal.tag;
		((GameObject)(object)text).tag = (string)(object)this;
	}
}
