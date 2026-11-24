using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public abstract class CharacterTriggeredTrackEvent : TrackEvent
{
	protected CharacterPassTrigger _trigger;

	public TrackEventTrigger Trigger
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = (object)base._trackObject != null;
			return (TrackEventTrigger)flag;
		}
	}

	protected override void Initialize()
	{
		CancelInvoke();
	}

	protected unsafe override void OnDestroy()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		Start();
		object obj = this + 16;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventHandler eventHandler = default;
		((Delegate)eventHandler).method_ptr = method_ptr;
		((Delegate)eventHandler).method = (nint)__ldftn(CharacterTriggeredTrackEvent.CharacterPassTrigger_Triggered);
		object obj2 = eventHandler + 16;
		obj2 = this;
		_trigger.Triggered -= eventHandler;
	}

	private void CharacterPassTrigger_Triggered(object sender, EventArgs e)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		if ((object)base._trackObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	protected CharacterTriggeredTrackEvent()
	{
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		EvaluateAndLaunchEvent();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_trigger).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			Collider collider = default;
			((UnityEngine.Object)collider).m_CachedPtr = cachedPtr;
			_ = 0;
			object obj2 = collider + 16;
			obj2 = this;
			_trigger.OnTriggerEnter(collider);
		}
	}
}
