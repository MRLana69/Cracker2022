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

	public bool hideInactive;

	public bool keepWithinPanel;

	public Vector2 padding;

	public OnReposition onReposition;

	public Comparison<Transform> onCustomSort;

	protected UIPanel mPanel;

	protected bool mInitDone;

	protected bool mReposition;

	public unsafe bool repositionNow
	{
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0061: Expected Obj, but got I4
			object obj = default;
			UIScrollView uIScrollView = (UIScrollView)(obj + 8);
			if (isActiveAndEnabled && ((UISlider)this).inverted)
			{
				obj = ((bool*)(value ? 1 : 0))->m_value;
				uIScrollView = (UIScrollView)obj;
				Bounds bounds = uIScrollView.bounds;
			}
		}
	}

	public List<Transform> GetChildList()
	{
		//IL_0051: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		if (hideInactive)
		{
			return (List<Transform>)1;
		}
		bool flag = (hideInactive ? 1 : 0) == 3;
		return (List<Transform>)flag;
	}

	protected virtual void Sort(List<Transform> list)
	{
		//IL_0033: Expected Obj, but got I4
		if (list != null)
		{
			mReposition = true;
			tag = (string)1;
		}
	}

	protected virtual void Start()
	{
		CancelInvoke();
	}

	protected virtual void Init()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		tag = null;
	}

	protected virtual void LateUpdate()
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		mInitDone = true;
		string go = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v15 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 52;
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>((GameObject)(object)go);
		obj2 = uIPanel;
	}

	private void OnValidate()
	{
		if (~(mReposition ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		tag = null;
	}

	protected void RepositionVariableSize(List<Transform> children)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		throw new NullReferenceException();
	}

	public virtual void Reposition()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			return;
		}
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v10 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v17 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NGUITools.GetActive((GameObject)(object)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public UITable()
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0037: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_013d: Expected I, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_0190: Expected I4, but got Obj
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_01f7: Expected I, but got Obj
		if (Application.platform != RuntimePlatform.OSXEditor && ~(mInitDone ? 1u : 0u) != 0)
		{
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v50 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v57 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUITools.GetActive((GameObject)(object)this))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
		mReposition = false;
		GameObject gameObject = base.gameObject;
		bool value = ((UIToggle)this).value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v12 (System.Boolean)+C]");
		if ((nint)0 >= (nint)1)
		{
			((UIToggle)this).value = value;
		}
		if (~(keepWithinPanel ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mPanel).FindKernel((string)null) != 0)
			{
				UIPanel uIPanel = UIPanel.Find((Transform)(object)mPanel, (byte)(int)gameObject != 0, 1);
				UIScrollView component = mPanel.GetComponent<UIScrollView>();
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				}
			}
		}
		if (onReposition != null)
		{
			onReposition();
		}
	}
}
