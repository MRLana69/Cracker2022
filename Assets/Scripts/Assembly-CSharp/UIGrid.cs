using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIGrid : UIWidgetContainer
{
	public delegate void OnReposition();

	public enum Arrangement
	{
		Horizontal,
		Vertical,
		CellSnap
	}

	public enum Sorting
	{
		None,
		Alphabetic,
		Horizontal,
		Vertical,
		Custom
	}

	public Arrangement arrangement;

	public Sorting sorting;

	public UIWidget.Pivot pivot;

	public int maxPerLine;

	public float cellWidth = 200f;

	public float cellHeight;

	public bool animateSmoothly;

	public bool hideInactive;

	public bool keepWithinPanel;

	public OnReposition onReposition;

	public Comparison<Transform> onCustomSort;

	private bool sorted;

	protected bool mReposition;

	protected UIPanel mPanel;

	protected bool mInitDone;

	private static Comparison<Transform> _003C_003Ef__mg_0024cache0;

	private static Comparison<Transform> _003C_003Ef__mg_0024cache1;

	private static Comparison<Transform> _003C_003Ef__mg_0024cache2;

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
		//IL_0161: Expected Obj, but got I4
		//IL_023f: Expected I, but got Obj
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
		if (sorting != Sorting.None && arrangement != Arrangement.CellSnap)
		{
			object obj = sorting - 1;
			if (sorting == Sorting.Alphabetic)
			{
				throw new ArgumentException();
			}
			if ((nint)obj == 1)
			{
				throw new ArgumentException();
			}
			if ((nint)obj == 2)
			{
				throw new ArgumentException();
			}
			if (onCustomSort != null)
			{
				list.Sort(onCustomSort);
				return list;
			}
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ S2_v13 (Il2CppClass<UIGrid>)+F4] (should have been resolved before IL gen)");
		}
		return list;
	}

	public Transform GetChild(int index)
	{
		List<Transform> childList = GetChildList();
		if (index < childList._size)
		{
			return childList.get_Item(index);
		}
		return null;
	}

	public int GetIndex(Transform trans)
	{
		//IL_002b: Expected Obj, but got I
		List<Transform> childList = GetChildList();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.List`1<UnityEngine.Transform>>)+8C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S5_v4+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public void AddChild(Transform trans)
	{
		AddChild(trans, sort: false);
	}

	public void AddChild(Transform trans, bool sort)
	{
		//IL_0030: Expected I, but got Obj
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		if (trans != null)
		{
			Transform parent = transform;
			trans.parent = parent;
			List<Transform> childList = GetChildList();
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S2_v7 (Il2CppClass<UIGrid>)+104] (should have been resolved before IL gen)");
		}
	}

	public bool RemoveChild(Transform t)
	{
		//IL_000a: Expected I, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		List<Transform> childList = GetChildList();
		bool flag = childList.Remove(t);
		if (flag)
		{
			nint num = (nint)this;
			object obj = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S2_v5 (Il2CppClass<UIGrid>)+104] (should have been resolved before IL gen)");
		}
		return flag;
	}

	protected virtual void Init()
	{
		mInitDone = true;
		GameObject go = gameObject;
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>(go);
		mPanel = uIPanel;
	}

	protected virtual void Start()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v10 (Il2CppClass<UIGrid>)+DC] (should have been resolved before IL gen)");
		}
		animateSmoothly = false;
		object obj2 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S1_v5+BC] (should have been resolved before IL gen)");
		animateSmoothly = animateSmoothly;
		enabled = false;
	}

	protected virtual void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v3+BC] (should have been resolved before IL gen)");
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

	public static int SortByName(Transform a, Transform b)
	{
		string text = a.name;
		string strB = b.name;
		return text.CompareTo(strB);
	}

	public unsafe static int SortHorizontal(Transform a, Transform b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0068: Expected F4, but got Obj
		//IL_0068: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		Vector3 localPosition = a.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Vector3 localPosition2 = b.localPosition;
		float num = (float)obj + 16f;
		return ((float*)num)->CompareTo((float)obj);
	}

	public unsafe static int SortVertical(Transform a, Transform b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected F4, but got Unknown
		//IL_007c: Expected F4, but got I
		//IL_007c: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		Vector3 localPosition = b.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Vector3 localPosition2 = a.localPosition;
		object obj3 = obj + 16;
		float num = obj3 | 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		return ((float*)num)->CompareTo(0f);
	}

	protected virtual void Sort(List<Transform> list)
	{
	}

	public virtual void Reposition()
	{
		//IL_00bd: Expected I, but got Obj
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_004f: Expected I, but got Obj
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		if (Application.isPlaying && !mInitDone)
		{
			GameObject go = gameObject;
			if (NGUITools.GetActive(go))
			{
				nint num = (nint)this;
				object obj = this + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ S1_v17 (Il2CppClass<UIGrid>)+DC] (should have been resolved before IL gen)");
			}
		}
		if (~(sorted ? 1u : 0u) == 0)
		{
			sorted = false;
			if (sorting == Sorting.None)
			{
				sorting = Sorting.Alphabetic;
			}
		}
		List<Transform> childList = GetChildList();
		nint num2 = (nint)this;
		object obj2 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S2_v4 (Il2CppClass<UIGrid>)+104] (should have been resolved before IL gen)");
		if (~(keepWithinPanel ? 1u : 0u) == 0)
		{
			ConstrainWithinPanel();
		}
		OnReposition onReposition = this.onReposition;
		if (this.onReposition != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v78.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ConstrainWithinPanel()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		if (mPanel != null)
		{
			Transform target = transform;
			bool flag = mPanel.ConstrainTargetToBounds(target, immediate: true);
			UIScrollView component = mPanel.GetComponent<UIScrollView>();
			if (component != null)
			{
				object obj = component - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S2_v8+BC] (should have been resolved before IL gen)");
			}
		}
	}

	protected unsafe virtual void ResetPosition(List<Transform> list)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_06de: Expected F4, but got I
		//IL_06f3: Invalid comparison between I and F4
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected Obj, but got Unknown
		//IL_0826: Expected F4, but got I
		//IL_083b: Invalid comparison between I and F4
		//IL_0370: Expected F4, but got I
		//IL_036b: Expected native int or pointer, but got VT
		//IL_038f: Expected F4, but got I
		//IL_038a: Expected native int or pointer, but got VT
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_00c4: Expected F4, but got I
		//IL_0656: Expected F4, but got I
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_043f: Expected Obj, but got I4
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected VT, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected VT, but got Unknown
		//IL_0548: Expected VT, but got F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		mReposition = false;
		Transform transform = base.transform;
		int num = default;
		object obj2 = default;
		object obj3 = default;
		object obj4 = default;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		int num23 = default;
		while (num < list._size)
		{
			Transform transform2 = list.get_Item(num);
			Vector3 localPosition = transform2.localPosition;
			float num2;
			float num5;
			if (arrangement != Arrangement.Horizontal)
			{
				if (arrangement != Arrangement.Vertical && arrangement == Arrangement.CellSnap)
				{
					bool flag = cellWidth > 0f;
					bool flag2 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
					num2 = 0f;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
						float num3 = 0f / cellWidth;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
						float num4 = (float)obj2 * cellWidth;
						num2 = num4;
					}
					bool flag3 = cellHeight > 0f;
					bool flag4 = !flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
					num5 = 0f;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
						float num6 = 0f / cellHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
						float num7 = (float)obj3 * cellHeight;
						num5 = num7;
					}
				}
				else
				{
					float num8 = cellWidth * (float)obj4;
					float num9 = 0f - cellHeight;
					float num10 = num9 * (float)obj5;
					num2 = num8;
					num5 = num10;
				}
			}
			else
			{
				float num11 = cellWidth * (float)obj5;
				float num12 = 0f - cellHeight;
				float num13 = num12 * (float)obj4;
				num2 = num11;
				num5 = num13;
			}
			if (~(animateSmoothly ? 1u : 0u) == 0 && Application.isPlaying)
			{
				Vector3 localPosition2 = transform2.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				float num14 = 0f - num2;
				float num15 = num14 * num14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				float num16 = 0f - num5;
				float num17 = num16 * num16;
				float num18 = num15 + num17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				float num19 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				float num20 = num19 - 0f;
				float num21 = num20 * num20;
				float num22 = num18 + num21;
				if (!(num22 < 0.0001f))
				{
					GameObject go = transform2.gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
					_ = 0;
					Vector3 pos = vector + 16;
					SpringPosition springPosition = SpringPosition.Begin(go, pos, 15f);
					springPosition.ignoreTimeScale = true;
					goto IL_03a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			((Vector3*)(nint)vector)->x = 0f;
			transform2.localPosition = vector;
			goto IL_03a1;
			IL_03a1:
			bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
			bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj8 = obj5 + 1;
			bool flag7 = (nint)obj8 < maxPerLine;
			obj5 = obj8;
			obj4 = obj4;
			if (!flag7)
			{
				bool flag8 = maxPerLine < 1;
				obj5 = obj8;
				obj4 = obj4;
				if (!flag8)
				{
					obj4++;
					obj5 = 0;
				}
			}
			obj6 = obj6;
			if (!flag5)
			{
				obj6 = obj4;
			}
			obj7 = obj7;
			if (!flag6)
			{
				obj7 = obj5;
			}
			num = num23 + 1;
		}
		if (pivot == UIWidget.Pivot.TopLeft)
		{
			return;
		}
		Vector2 pivotOffset = NGUIMath.GetPivotOffset(pivot);
		object obj9 = obj6;
		if (arrangement == Arrangement.Horizontal)
		{
			obj9 = obj7;
		}
		float num24 = (float)obj9 * cellWidth;
		float num25 = num24 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		float num26 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		bool flag9 = 0f < 0f;
		float num27 = 0f;
		if (!flag9)
		{
			num27 = num26;
		}
		float num28 = num25 * num27;
		float num29 = num28 + 0f;
		object obj10 = obj7;
		if (arrangement == Arrangement.Horizontal)
		{
			obj10 = obj6;
		}
		object obj11 = 0 - obj10;
		float num30 = (float)obj11 * cellHeight;
		float num31 = 0f - num30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
		float num32 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
		bool flag10 = 0f < 0f;
		float num33 = 0f;
		if (!flag10)
		{
			num33 = num32;
		}
		float num34 = num31 * num33;
		float num35 = num30 + num34;
		int num36 = 0;
		while (true)
		{
			int childCount = transform.childCount;
			if (childCount > num36)
			{
				Transform child = transform.GetChild(num36);
				SpringPosition component = child.GetComponent<SpringPosition>();
				if (component != null)
				{
					float num37 = (float)component.target - num29;
					component.target = (Vector3)num37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v42 (SpringPosition)+10]");
					float num38 = 0f - num35;
				}
				else
				{
					Vector3 localPosition3 = child.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
					float num39 = 0f - num29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
					float num40 = 0f - num35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_ = 0;
					Vector3 localPosition4 = vector + 32;
					child.localPosition = localPosition4;
				}
				int num41 = num36 + 1;
				num36 = num41;
				continue;
			}
			break;
		}
	}
}
