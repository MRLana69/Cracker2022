using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UITable : UIWidgetContainer
{
	public delegate void OnReposition();

	public enum Direction
	{
		Down,
		Up
	}

	public enum Sorting
	{
		None,
		Alphabetic,
		Horizontal,
		Vertical,
		Custom
	}

	public int columns;

	public Direction direction;

	public Sorting sorting;

	public UIWidget.Pivot pivot;

	public UIWidget.Pivot cellAlignment;

	public bool hideInactive = true;

	public bool keepWithinPanel;

	public Vector2 padding = Vector2.zeroVector;

	public OnReposition onReposition;

	public Comparison<Transform> onCustomSort;

	protected UIPanel mPanel;

	protected bool mInitDone;

	protected bool mReposition;

	private static Comparison<Transform> _003C_003Ef__mg_0024cache0;

	private static Comparison<Transform> _003C_003Ef__mg_0024cache1;

	private static Comparison<Transform> _003C_003Ef__mg_0024cache2;

	private static Comparison<Transform> _003C_003Ef__mg_0024cache3;

	public bool repositionNow
	{
		set
		{
			if (value)
			{
				mReposition = true;
				enabled = true;
			}
		}
	}

	public List<Transform> GetChildList()
	{
		//IL_0214: Expected I, but got Obj
		Transform transform = base.transform;
		List<Transform> list = default;
		list._002Ector();
		int num = default;
		GameObject gameObject2 = default;
		int num2 = default;
		while (true)
		{
			int childCount = transform.childCount;
			if (childCount <= num)
			{
				break;
			}
			Transform child = transform.GetChild(num);
			GameObject gameObject;
			if (~(hideInactive ? 1u : 0u) == 0)
			{
				bool flag = child;
				bool flag2 = !flag;
				gameObject = gameObject2;
				if (flag2)
				{
					goto IL_00f8;
				}
				GameObject gameObject3 = child.gameObject;
				bool active = NGUITools.GetActive(gameObject3);
				bool flag3 = !active;
				gameObject2 = gameObject3;
				gameObject = gameObject3;
				if (flag3)
				{
					goto IL_00f8;
				}
			}
			list.Add(child);
			gameObject = gameObject2;
			goto IL_00f8;
			IL_00f8:
			num = num2 + 1;
			gameObject2 = gameObject;
		}
		if (sorting != Sorting.None)
		{
			if (sorting == Sorting.Alphabetic)
			{
				throw new ArgumentException();
			}
			if (sorting == Sorting.Horizontal)
			{
				throw new ArgumentException();
			}
			if (sorting == Sorting.Vertical)
			{
				throw new ArgumentException();
			}
			if (onCustomSort != null)
			{
				list.Sort(onCustomSort);
				return list;
			}
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ S2_v13 (Il2CppClass<UITable>)+DC] (should have been resolved before IL gen)");
		}
		return list;
	}

	protected virtual void Sort(List<Transform> list)
	{
		throw new ArgumentException();
	}

	protected virtual void Start()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UITable>)+EC] (should have been resolved before IL gen)");
		object obj2 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v7+BC] (should have been resolved before IL gen)");
		enabled = false;
	}

	protected virtual void Init()
	{
		mInitDone = true;
		GameObject go = gameObject;
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>(go);
		mPanel = uIPanel;
	}

	protected virtual void LateUpdate()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		if (~(mReposition ? 1u : 0u) == 0)
		{
			object obj = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S1_v5+BC] (should have been resolved before IL gen)");
		}
		enabled = false;
	}

	private void OnValidate()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		if (!Application.isPlaying && NGUITools.GetActive(this))
		{
			object obj = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S1_v6+BC] (should have been resolved before IL gen)");
		}
	}

	protected unsafe void RepositionVariableSize(List<Transform> children)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0f01: Expected Obj, but got I4
		//IL_0f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_0502: Expected F4, but got I
		//IL_051c: Invalid comparison between I and F4
		//IL_0f7b: Expected F4, but got I
		//IL_0f90: Invalid comparison between I and F4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected VT, but got Unknown
		//IL_011c: Expected Ref, but got VT
		//IL_0fb6: Expected Obj, but got I4
		//IL_0fda: Expected Obj, but got I4
		//IL_0142: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected VT, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected VT, but got Unknown
		//IL_01ce: Expected Ref, but got VT
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected VT, but got Unknown
		//IL_01e5: Expected Ref, but got VT
		//IL_020b: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0245: Expected Obj, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected VT, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected VT, but got Unknown
		//IL_0297: Expected Ref, but got VT
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02b5: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected VT, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected VT, but got Unknown
		//IL_03d5: Expected Ref, but got VT
		//IL_0430: Expected VT, but got I
		//IL_042b: Expected native int or pointer, but got VT
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected VT, but got Unknown
		//IL_0466: Expected Ref, but got VT
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_0574: Expected Obj, but got I
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected VT, but got Unknown
		//IL_075c: Expected Ref, but got VT
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected VT, but got Unknown
		//IL_0777: Expected Ref, but got VT
		//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbb: Expected VT, but got Unknown
		//IL_0cc4: Expected Ref, but got VT
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected VT, but got Unknown
		//IL_0797: Expected Ref, but got VT
		//IL_07b8: Expected Obj, but got I
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Expected Obj, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected VT, but got Unknown
		//IL_07e4: Expected Ref, but got VT
		//IL_0cfb: Expected F4, but got I
		//IL_0d10: Invalid comparison between I and F4
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected Obj, but got Unknown
		//IL_04d8: Expected Obj, but got I4
		//IL_10fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1100: Expected VT, but got Unknown
		//IL_1109: Expected Ref, but got VT
		//IL_114b: Expected F4, but got I
		//IL_1160: Invalid comparison between I and F4
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected VT, but got Unknown
		//IL_0a7c: Expected Ref, but got VT
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Expected VT, but got Unknown
		//IL_0a97: Expected Ref, but got VT
		//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Expected VT, but got Unknown
		//IL_0ab7: Expected Ref, but got VT
		//IL_0ad8: Expected Obj, but got I
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected Obj, but got Unknown
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Expected VT, but got Unknown
		//IL_0b04: Expected Ref, but got VT
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected VT, but got Unknown
		//IL_0904: Expected Ref, but got VT
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected VT, but got Unknown
		//IL_091f: Expected Ref, but got VT
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected Obj, but got Unknown
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Expected VT, but got Unknown
		//IL_093f: Expected Ref, but got VT
		//IL_0960: Expected Obj, but got I
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected Obj, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected VT, but got Unknown
		//IL_098c: Expected Ref, but got VT
		//IL_0fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fed: Expected VT, but got Unknown
		//IL_0ff6: Expected Ref, but got VT
		//IL_100b: Expected Obj, but got VT
		//IL_101b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1020: Expected Obj, but got Unknown
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_106e: Expected VT, but got Unknown
		//IL_1084: Unknown result type (might be due to invalid IL or missing references)
		//IL_1089: Expected Obj, but got Unknown
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected Obj, but got Unknown
		//IL_0e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e52: Expected VT, but got Unknown
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected Obj, but got Unknown
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected VT, but got Unknown
		//IL_0bd0: Expected Ref, but got VT
		//IL_0bf1: Expected Obj, but got I
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected Obj, but got Unknown
		//IL_0c37: Expected Obj, but got I4
		//IL_0db7: Expected VT, but got F4
		object obj = default;
		Bounds bounds = (Bounds)(obj - 384);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag = columns >= 1;
		bool flag2 = !flag;
		object obj2 = 1;
		int num2;
		object obj4;
		if (!flag2)
		{
			int num = children._size / columns;
			object obj3 = num + 1;
			bool flag3 = columns > 0;
			obj2 = obj3;
			num2 = columns;
			obj4 = obj3;
			if (flag3)
			{
				goto IL_0f0f;
			}
		}
		num2 = children._size;
		obj4 = obj2;
		goto IL_0f0f;
		IL_0f0f:
		object obj5 = bounds + 240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FB3");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num3 = 0;
		object obj6 = 0;
		object obj16 = default;
		object obj20 = default;
		object obj23 = default;
		object obj26 = default;
		object obj28 = default;
		while (num3 < children._size)
		{
			Transform transform = children.get_Item(num3);
			bool considerInactive = (byte)(~(hideInactive ? 1u : 0u)) != 0;
			Bounds bounds2 = NGUIMath.CalculateRelativeWidgetBounds(transform, considerInactive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+100]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
			_ = 0;
			Vector3 localScale = transform.localScale;
			Bounds bounds3 = (Bounds)(bounds + 336);
			Vector3 min = ((Bounds*)bounds3)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
			object obj7 = num4 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
			object obj8 = num5 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F8]");
			object obj9 = num6 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+E8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+E0]");
			_ = 0;
			Bounds bounds4 = (Bounds)(bounds + 336);
			Vector3 min2 = (Vector3)(bounds + 88);
			((Bounds*)bounds4)->min = min2;
			Bounds bounds5 = (Bounds)(bounds + 336);
			Vector3 max = ((Bounds*)bounds5)->max;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
			object obj10 = num7 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
			object obj11 = num8 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F8]");
			object obj12 = num9 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+D0]");
			_ = 0;
			Bounds bounds6 = (Bounds)(bounds + 336);
			Vector3 max2 = (Vector3)(bounds + 72);
			((Bounds*)bounds6)->max = max2;
			object obj13 = bounds - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+160]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+158]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+150]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v31+8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S1_v320+8]");
			object obj15 = 0 * obj16;
			object obj17 = obj15 + obj6;
			object obj18 = obj17 * 24;
			object obj19 = obj20 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+160]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+158]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+150]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+100]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
			_ = 0;
			object obj21 = obj6 * 24;
			object obj22 = obj23 + obj21;
			Bounds bounds7 = (Bounds)(obj22 + 16);
			Bounds bounds8 = (Bounds)(bounds + 24);
			((Bounds*)bounds7)->Encapsulate(bounds8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+160]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+158]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+150]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+B8]");
			((Bounds*)(nint)bounds)->m_Center = (Vector3)0;
			object obj24 = obj16 * 24;
			object obj25 = obj26 + obj24;
			Bounds bounds9 = (Bounds)(obj25 + 16);
			((Bounds*)bounds9)->Encapsulate(bounds);
			object obj27 = obj6 + 1;
			bool flag4 = (nint)obj27 < columns;
			obj6 = obj27;
			if (!flag4)
			{
				bool flag5 = columns < 1;
				obj6 = obj27;
				if (!flag5)
				{
					obj16 = obj28 + 1;
					obj6 = 0;
				}
			}
			int num10 = num3 + 1;
			num3 = num10;
		}
		Vector2 pivotOffset = NGUIMath.GetPivotOffset(cellAlignment);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
		float num11 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
		bool flag6 = 0f < 0f;
		float num12 = 0f;
		if (!flag6)
		{
			num12 = num11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
		float num13 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
		bool flag7 = 0f < 0f;
		float num14 = 0f;
		if (!flag7)
		{
			num14 = num13;
		}
		object obj29 = 0;
		float num15 = 0f;
		float num16 = 0f;
		int num17 = 0;
		object obj30 = 0;
		while (num17 < children._size)
		{
			Transform transform2 = children.get_Item(num17);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v31+8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S2_v37+8]");
			object obj32 = 0 * obj29;
			object obj33 = obj32 + obj30;
			object obj34 = obj33 * 24;
			object obj35 = obj20 + obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S1_v100+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S1_v100+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S1_v100+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+100]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
			_ = 0;
			object obj36 = obj30 * 24;
			object obj37 = obj23 + obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S1_v113+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S1_v113+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S1_v113+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+100]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
			_ = 0;
			object obj38 = obj29 * 24;
			object obj39 = obj26 + obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ S1_v126+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ S1_v126+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ S1_v126+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+B8]");
			_ = 0;
			Vector3 localPosition = transform2.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+144]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+14C]");
			_ = 0;
			float num18 = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+A8]");
			float num19 = num18 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+138]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+140]");
			_ = 0;
			float num20 = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+A8]");
			float num21 = num20 - 0f;
			Bounds bounds10 = (Bounds)(bounds + 312);
			Vector3 max3 = ((Bounds*)bounds10)->max;
			Bounds bounds11 = (Bounds)(bounds + 312);
			Vector3 min3 = ((Bounds*)bounds11)->min;
			Bounds bounds12 = (Bounds)(bounds + 288);
			Vector3 max4 = ((Bounds*)bounds12)->max;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+A8]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+A8]");
			object obj40 = num22 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+A8]");
			object obj41 = obj40 - 0;
			Bounds bounds13 = (Bounds)(bounds + 288);
			Vector3 min4 = ((Bounds*)bounds13)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+A8]");
			object obj42 = obj41 + 0;
			float num23 = (float)obj42 - 0f;
			float num24 = num23 * num14;
			float num25 = num24 + 0f;
			float num26 = num25 - (float)padding;
			float num27 = num21 - num26;
			if (direction == Direction.Down)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+144]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+14C]");
				_ = 0;
				float num28 = 0f - num16;
				float num29 = num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				float num30 = num29 - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+138]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+140]");
				_ = 0;
				float num31 = num30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				float num32 = num31 - 0f;
				Bounds bounds14 = (Bounds)(bounds + 312);
				Vector3 max5 = ((Bounds*)bounds14)->max;
				Bounds bounds15 = (Bounds)(bounds + 312);
				Vector3 min5 = ((Bounds*)bounds15)->min;
				Bounds bounds16 = (Bounds)(bounds + 264);
				Vector3 max6 = ((Bounds*)bounds16)->max;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				nint num33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				object obj43 = num33 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				object obj44 = obj43 - 0;
				Bounds bounds17 = (Bounds)(bounds + 264);
				Vector3 min6 = ((Bounds*)bounds17)->min;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				object obj45 = obj44 + 0;
				float num34 = 0f - (float)obj45;
				float num35 = num34 * num12;
				float num36 = (float)obj45 + num35;
				float num37 = num36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITable)+28]");
				float num38 = num37 - 0f;
				float num39 = num32 + num38;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+144]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+14C]");
				_ = 0;
				float num40 = num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				float num41 = num40 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+138]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+140]");
				_ = 0;
				float num42 = num41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				float num43 = num42 - 0f;
				Bounds bounds18 = (Bounds)(bounds + 312);
				Vector3 max7 = ((Bounds*)bounds18)->max;
				Bounds bounds19 = (Bounds)(bounds + 312);
				Vector3 min7 = ((Bounds*)bounds19)->min;
				Bounds bounds20 = (Bounds)(bounds + 264);
				Vector3 max8 = ((Bounds*)bounds20)->max;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				nint num44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				object obj46 = num44 - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				object obj47 = obj46 - 0;
				Bounds bounds21 = (Bounds)(bounds + 264);
				Vector3 min8 = ((Bounds*)bounds21)->min;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
				object obj48 = obj47 + 0;
				float num45 = (float)obj48 - 0f;
				float num46 = num45 * num12;
				float num47 = num46 + 0f;
				float num48 = num47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITable)+28]");
				float num49 = num48 - 0f;
				float num39 = num43 - num49;
			}
			Bounds bounds22 = (Bounds)(bounds + 288);
			Vector3 size = ((Bounds*)bounds22)->size;
			object obj49 = padding + padding;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
			object obj50 = 0 + obj49;
			float num50 = num15 + (float)obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+B0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+98]");
			_ = 0;
			Vector3 localPosition2 = (Vector3)(bounds + 104);
			transform2.localPosition = localPosition2;
			object obj51 = obj30 + 1;
			bool flag8 = (nint)obj51 < columns;
			num15 = num50;
			obj30 = obj51;
			if (!flag8)
			{
				bool flag9 = columns < 1;
				num15 = num50;
				obj30 = obj51;
				if (!flag9)
				{
					object obj52 = obj29 + 1;
					Bounds bounds23 = (Bounds)(bounds + 264);
					Vector3 size2 = ((Bounds*)bounds23)->size;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITable)+28]");
					nint num51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UITable)+28]");
					object obj53 = num51 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
					object obj54 = 0 + obj53;
					float num52 = num16 + (float)obj54;
					obj29 = obj52;
					num15 = 0f;
					num16 = num52;
					obj30 = 0;
				}
			}
			int num53 = num17 + 1;
			num17 = num53;
		}
		if (pivot == UIWidget.Pivot.TopLeft)
		{
			return;
		}
		Vector2 pivotOffset2 = NGUIMath.GetPivotOffset(pivot);
		Transform trans = base.transform;
		Bounds bounds24 = NGUIMath.CalculateRelativeWidgetBounds(trans);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+100]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
		_ = 0;
		Bounds bounds25 = (Bounds)(bounds + 360);
		Vector3 size3 = ((Bounds*)bounds25)->size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
		float num54 = 0f - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
		float num55 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
		bool flag10 = 0f < 0f;
		float num56 = 0f;
		if (!flag10)
		{
			num56 = num55;
		}
		float num57 = num54 * num56;
		float num58 = num57 + 0f;
		Bounds bounds26 = (Bounds)(bounds + 360);
		Vector3 size4 = ((Bounds*)bounds26)->size;
		float num59 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
		float num60 = num59 - 0f;
		float num61 = 0f - num60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
		float num62 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
		bool flag11 = 0f < 0f;
		float num63 = 0f;
		if (!flag11)
		{
			num63 = num62;
		}
		float num64 = num61 * num63;
		float num65 = num60 + num64;
		Transform transform3 = base.transform;
		int num66 = 0;
		while (true)
		{
			int childCount = transform3.childCount;
			if (childCount > num66)
			{
				Transform child = transform3.GetChild(num66);
				SpringPosition component = child.GetComponent<SpringPosition>();
				if (component != null)
				{
					float num67 = (float)component.target - num58;
					component.target = (Vector3)num67;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ S0_v103 (SpringPosition)+10]");
					float num68 = 0f - num65;
				}
				else
				{
					size4 = child.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F0]");
					float num69 = 0f - num58;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F4]");
					float num70 = 0f - num65;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+F8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+90]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+88]");
					_ = 0;
					Vector3 localPosition3 = (Vector3)(bounds + 120);
					child.localPosition = localPosition3;
				}
				int num71 = num66 + 1;
				num66 = num71;
				continue;
			}
			break;
		}
	}

	public virtual void Reposition()
	{
		//IL_0042: Expected I, but got Obj
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		if (Application.isPlaying && !mInitDone && NGUITools.GetActive(this))
		{
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S1_v21 (Il2CppClass<UITable>)+EC] (should have been resolved before IL gen)");
		}
		mReposition = false;
		Transform target = transform;
		List<Transform> childList = GetChildList();
		if (childList._size >= 1)
		{
			RepositionVariableSize(childList);
		}
		if (~(keepWithinPanel ? 1u : 0u) == 0 && mPanel != null)
		{
			bool flag = mPanel.ConstrainTargetToBounds(target, immediate: true);
			UIScrollView component = mPanel.GetComponent<UIScrollView>();
			if (component != null)
			{
				object obj2 = component - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ S2_v12+BC] (should have been resolved before IL gen)");
			}
		}
		OnReposition onReposition = this.onReposition;
		if (this.onReposition != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
