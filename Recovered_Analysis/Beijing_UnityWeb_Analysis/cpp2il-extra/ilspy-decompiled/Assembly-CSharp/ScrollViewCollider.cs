using System;
using Cpp2ILInjected;
using UnityEngine;

public class ScrollViewCollider : MonoBehaviour
{
	private GameObject _scrollCollider;

	private bool _addTopCollider;

	private bool _addBottomCollider;

	private float _zDepth;

	private bool _added;

	private void Start()
	{
		//IL_000b: Expected I4, but got F4
		_addTopCollider = true;
		CancelInvoke();
	}

	public void AddTopAndBottomColliders()
	{
		this._002Ector();
	}

	public ScrollViewCollider()
	{
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected Obj, but got Unknown
		//IL_0699: Expected Obj, but got I4
		//IL_06ad: Expected I, but got Obj
		//IL_06c3: Expected Obj, but got I
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected Obj, but got Unknown
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected Obj, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I4
		//IL_03f3: Expected Obj, but got I4
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_0417: Expected I, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_074b: Expected Obj, but got I4
		//IL_0794: Expected Obj, but got I4
		//IL_01db: Expected I4, but got Obj
		//IL_01db: Expected Obj, but got I4
		//IL_018e: Expected I, but got Obj
		//IL_04a5: Expected I4, but got Obj
		//IL_04a5: Expected Obj, but got I4
		//IL_0458: Expected I, but got Obj
		//IL_0205: Expected VT, but got I4
		//IL_04cf: Expected VT, but got I4
		//IL_0226: Expected VT, but got I4
		//IL_04f0: Expected VT, but got I4
		//IL_0558: Expected Obj, but got I4
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_02e4: Expected VT, but got I4
		//IL_02ed: Expected Obj, but got I4
		//IL_05bc: Expected VT, but got I4
		//IL_05c5: Expected Obj, but got I4
		//IL_02ff: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got F4
		//IL_0350: Expected Obj, but got I4
		//IL_05d7: Expected Obj, but got I4
		//IL_05e6: Expected Obj, but got F4
		//IL_0628: Expected Obj, but got I4
		//IL_0362: Expected Obj, but got I4
		//IL_0370: Expected Obj, but got I4
		//IL_03a5: Expected Obj, but got I4
		//IL_063a: Expected Obj, but got I4
		//IL_0648: Expected Obj, but got I4
		//IL_067d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v142 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoxCollider boxCollider = (BoxCollider)(obj2 + 72);
		Transform transform = (Transform)(obj2 + 48);
		Transform transform2 = (Transform)(obj2 + 36);
		Transform transform3 = (Transform)(obj2 + 24);
		object obj4 = obj2 + 12;
		if (((ComputeShader)(object)_scrollCollider).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v17 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v88 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj = boxCollider;
		_ = ((UnityEngine.Object)boxCollider).m_CachedPtr;
		_ = _zDepth;
		if (~(_addTopCollider ? 1u : 0u) == 0 && ~(_added ? 1u : 0u) != 0)
		{
			string text = tag;
			int layer = ((GameObject)(object)text).layer;
			Transform parentInternal = ((Transform)layer).parentInternal;
			string go = parentInternal.tag;
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v94 (Il2CppClass<NGUITools>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v138 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num7 = NGUITools.CalculateRaycastDepth((GameObject)(object)go);
			BoxCollider boxCollider2 = ((GameObject)num7).AddComponent<BoxCollider>();
			boxCollider = (BoxCollider)obj;
			BoxCollider boxCollider3 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)boxCollider3).m_CachedPtr = (IntPtr)0;
			Vector3 size = boxCollider.size;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num7, (byte)(int)"TopScrollBlocker" != 0);
			int sleepTimeout = Screen.sleepTimeout;
			int layer2 = _scrollCollider.layer;
			transform.localScale = (Vector3)layer2;
			int layer3 = _scrollCollider.layer;
			transform2.localPosition = (Vector3)layer3;
			int num8 = sleepTimeout / 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v14 (UnityEngine.Transform)+4]");
			float num9 = 0f * 0.5f;
			float num10 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v16 (UnityEngine.Transform)+4]");
			float num11 = num10 + 0f;
			float num12 = (float)num8 - num11;
			int sleepTimeout2 = Screen.sleepTimeout;
			int num13 = sleepTimeout2 / 2;
			float num14 = num12 * 0.5f;
			float num15 = (float)num13 - num14;
			int height = Screen.height;
			string text2 = tag;
			int layer4 = ((GameObject)(object)text2).layer;
			transform3.localPosition = (Vector3)layer4;
			int layer5 = ((GameObject)num7).layer;
			obj4 = 0;
			_ = 0;
			obj4 = 0f;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			boxCollider = (BoxCollider)obj4;
			BoxCollider boxCollider4 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v20+8]");
			((UnityEngine.Object)boxCollider4).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = ((Transform)(object)boxCollider).eulerAngles;
			int layer6 = ((GameObject)num7).layer;
			obj2 = 0;
			_ = 0;
			obj2 = height;
			_ = 1f;
			boxCollider = (BoxCollider)obj2;
			BoxCollider boxCollider5 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)boxCollider5).m_CachedPtr = (IntPtr)0;
			((Transform)layer6).parent = (Transform)(object)boxCollider;
		}
		if (~(_addBottomCollider ? 1u : 0u) == 0 && ~(_added ? 1u : 0u) != 0)
		{
			string text3 = tag;
			int layer7 = ((GameObject)(object)text3).layer;
			Transform parentInternal2 = ((Transform)layer7).parentInternal;
			string go2 = parentInternal2.tag;
			nint num16 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v39 (Il2CppClass<NGUITools>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num17 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v85 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num18 = NGUITools.CalculateRaycastDepth((GameObject)(object)go2);
			BoxCollider boxCollider6 = ((GameObject)num18).AddComponent<BoxCollider>();
			boxCollider = (BoxCollider)obj;
			BoxCollider boxCollider7 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)boxCollider7).m_CachedPtr = (IntPtr)0;
			Vector3 size2 = boxCollider.size;
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num18, (byte)(int)"BottomScrollBlocker" != 0);
			int sleepTimeout3 = Screen.sleepTimeout;
			int layer8 = _scrollCollider.layer;
			transform.localScale = (Vector3)layer8;
			int layer9 = _scrollCollider.layer;
			transform2.localPosition = (Vector3)layer9;
			int num19 = sleepTimeout3 / 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v14 (UnityEngine.Transform)+4]");
			float num20 = 0f * 0.5f;
			float num21 = num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v16 (UnityEngine.Transform)+4]");
			float num22 = num21 - 0f;
			float num23 = (float)num19 - num22;
			int sleepTimeout4 = Screen.sleepTimeout;
			object obj8 = -sleepTimeout4;
			object obj9 = obj8 / 2;
			float num24 = num23 * 0.5f;
			float num25 = (float)obj9 + num24;
			int height2 = Screen.height;
			string text4 = tag;
			int layer10 = ((GameObject)(object)text4).layer;
			transform3.localPosition = (Vector3)layer10;
			int layer11 = ((GameObject)num18).layer;
			obj4 = 0;
			_ = 0;
			obj4 = 0f;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			boxCollider = (BoxCollider)obj4;
			BoxCollider boxCollider8 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v20+8]");
			((UnityEngine.Object)boxCollider8).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles2 = ((Transform)(object)boxCollider).eulerAngles;
			int layer12 = ((GameObject)num18).layer;
			obj2 = 0;
			_ = 0;
			obj2 = height2;
			_ = 1f;
			boxCollider = (BoxCollider)obj2;
			BoxCollider boxCollider9 = boxCollider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)boxCollider9).m_CachedPtr = (IntPtr)0;
			((Transform)layer12).parent = (Transform)(object)boxCollider;
		}
		_added = true;
	}
}
