using System;
using Cpp2ILInjected;
using Kiloo.Common.Timer;
using UnityEngine;

namespace Events;

public class SSEventsLabelTimer : MonoBehaviour
{
	private UILabel _thisLabel;

	private Timer _timer;

	private void Awake()
	{
	}

	private void OnDisable()
	{
		RefreshTimeLabel();
	}

	private void OnEnable()
	{
		if (_timer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	private void StartTimer()
	{
		RefreshTimeLabel();
	}

	private unsafe void RefreshTimeLabel()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		if (_timer == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 1f;
			_ = 0;
			object obj = this + 16;
			object obj2 = default;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(SSEventsLabelTimer.RefreshTimeLabel);
			object obj3 = action + 16;
			obj3 = this;
			_timer.intervalElapsed -= action;
		}
		Timer timer = _timer;
		if (~(((BaseTimer)timer)._running ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		this._002Ector();
	}

	public SSEventsLabelTimer()
	{
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0170: Expected I, but got Obj
		//IL_0186: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0236: Expected I, but got Obj
		//IL_024c: Expected Obj, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_0094: Expected I, but got Obj
		//IL_00e1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_thisLabel != null)
		{
			object obj2 = this + 12;
			string text = tag;
			UILabel component = ((GameObject)(object)text).GetComponent<UILabel>();
			obj2 = component;
		}
		nint num3 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v13 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		long currentEventID = ((SSEventsManagerController)(object)flurryUserId).GetCurrentEventID();
		nint num5 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v13 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v23 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
		object obj6 = default;
		object obj5 = obj6;
		object obj7 = obj5 + 8;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A56A");
		int fontSize = default;
		_thisLabel.fontSize = fontSize;
	}
}
