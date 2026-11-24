using System.Collections;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UI.FreeStuff;
using UI.Pages.MissionsPageInternal;
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

	public bool autosizeWidget;

	public float autosizeWidgetMargin;

	public float autosizeWidgetMinWidth;

	public UIWidget targetWidget;

	public bool adjustWidgetPosition;

	public AlignMode mode;

	public int padding;

	private bool _alignNow;

	protected bool _snapToLabelContent;

	protected UIPanel _panel;

	protected float _calculatedHeight;

	protected float _calculatedWidth;

	public float calculatedHeight => autosizeWidgetMinWidth;

	public float calculateWidth => _calculatedHeight;

	private void Start()
	{
		CancelInvoke();
	}

	private void OnEnable()
	{
		if (Application.platform != RuntimePlatform.OSXEditor && mode != AlignMode.Off)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	private void Update()
	{
		if (Application.platform != RuntimePlatform.OSXEditor && mode == AlignMode.OnEnable)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	private void LateUpdate()
	{
		if (Application.platform != RuntimePlatform.OSXEditor && mode == AlignMode.OnUpdate)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		if (~(_alignNow ? 1u : 0u) == 0)
		{
			_alignNow = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public void Align(bool once = false)
	{
		//IL_0015: Invalid comparison between F4 and I4
		//IL_0059: Expected Obj, but got F4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I4
		autosizeWidget = once;
		if (autosizeWidgetMinWidth != 0f && ~(autosizeWidget ? 1u : 0u) != 0)
		{
			StopCoroutine((string)autosizeWidgetMinWidth);
			targetWidget = null;
		}
		if (~(autosizeWidget ? 1u : 0u) == 0)
		{
			Transform transform = base.transform;
			if ((object)transform != null && (object)targetWidget == null)
			{
				object obj = this + 20;
				int cachedRewardAmount = ((RewardForVideoButton)this).cachedRewardAmount;
				Coroutine coroutine = StartCoroutine_Auto((IEnumerator)cachedRewardAmount);
				obj = coroutine;
			}
		}
	}

	public void SetToAlignModeForSpecfiedDuration(AlignMode alignMode, float duration)
	{
		//IL_0049: Expected Obj, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I
		string text = tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Generic.Layout.Layout)+60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v6+C]");
		if ((nint)0 == (nint)alignMode)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Generic.Layout.Layout)+5C]");
			if ((nint)0 == 0)
			{
				object obj2 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Generic.Layout.Layout)+60]");
				object obj3 = (nint)0 + (nint)20;
				float num = duration;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S3_v4+4]");
				float f = num * 0f;
				int completedMissionsCount = NumberExtensions.CeilToInt(f);
				IEnumerator routine = ((MissionCell)this).CompleteAnimationInternal(completedMissionsCount);
				Coroutine coroutine = StartCoroutine_Auto(routine);
			}
		}
	}

	private void TurnOff()
	{
		if (Application.platform != RuntimePlatform.OSXEditor && mode == AlignMode.OnLateUpdate)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected virtual void Align_Internal()
	{
		mode = AlignMode.Off;
	}
}
