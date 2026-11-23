using System;
using Cpp2ILInjected;
using Kiloo.Common.Timer;
using UnityEngine;

namespace UI.Generic.Layout;

public class Layout : MonoBehaviour
{
	public enum AlignMode
	{
		Off,
		OnEnable,
		OnUpdate,
		OnLateUpdate
	}

	public AlignMode mode;

	public bool autosizeWidget;

	public float autosizeWidgetMargin;

	public float autosizeWidgetMinWidth;

	public UIWidget targetWidget;

	public int padding;

	public bool alignNow;

	protected UIPanel _panel;

	private void Start()
	{
		//IL_0029: Expected I, but got Obj
		//IL_0043: Expected Obj, but got I4
		if (Application.isPlaying && mode != AlignMode.Off)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S1_v4 (Il2CppClass<UI.Generic.Layout.Layout>)+DC] (should have been resolved before IL gen)");
			object obj = mode & (AlignMode)(-2);
			if ((nint)obj == 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				GameObject gameObject = base.gameObject;
				string text = gameObject.name;
				throw new ArrayTypeMismatchException();
			}
		}
	}

	private void OnEnable()
	{
		//IL_0049: Expected I, but got Obj
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		if (Application.isPlaying && mode == AlignMode.OnEnable)
		{
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v4 (Il2CppClass<UI.Generic.Layout.Layout>)+DC] (should have been resolved before IL gen)");
		}
	}

	private void Update()
	{
		//IL_0073: Expected I, but got Obj
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0049: Expected I, but got Obj
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		if (Application.isPlaying && mode == AlignMode.OnUpdate)
		{
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S1_v10 (Il2CppClass<UI.Generic.Layout.Layout>)+DC] (should have been resolved before IL gen)");
		}
		if (~(alignNow ? 1u : 0u) == 0)
		{
			alignNow = false;
			nint num2 = (nint)this;
			object obj2 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S1_v5 (Il2CppClass<UI.Generic.Layout.Layout>)+DC] (should have been resolved before IL gen)");
		}
	}

	private void LateUpdate()
	{
		//IL_0049: Expected I, but got Obj
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		if (Application.isPlaying && mode == AlignMode.OnLateUpdate)
		{
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v4 (Il2CppClass<UI.Generic.Layout.Layout>)+DC] (should have been resolved before IL gen)");
		}
	}

	public void Align(bool once = false)
	{
		//IL_0035: Expected I, but got Obj
		//IL_0021: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Generic.Layout.Layout>)+DC] (should have been resolved before IL gen)");
		if (!once)
		{
			NullReferenceException ex = new NullReferenceException();
			Action action = default;
			action._002Ector(this, (IntPtr)ex);
			Timer.ExecuteNextFrame(action);
		}
	}

	protected virtual void Align_Internal()
	{
	}
}
