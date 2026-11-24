using System;
using Cpp2ILInjected;
using SYBO.Subway.Level.TrackEvents;
using SYBO.Subway.Level.TrackEvents.CarActivities;
using UnityEngine;

namespace SYBO.Subway.Placeholders.Lifecycles;

public class TrackEventPlaceholderLifecycle : PlaceholderLifecycle
{
	private TrackEvent _trackEvent;

	protected override void Initialize()
	{
		CancelInvoke();
	}

	private unsafe void OnDestroy()
	{
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected Obj, but got Unknown
		SpawnInstancesEditor();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_trackEvent).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(TrackEventPlaceholderLifecycle.TrackEvent_Launching);
			object obj2 = action + 16;
			obj2 = this;
			_trackEvent.Launching -= action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action2 = default;
			((Delegate)action2).method_ptr = method_ptr2;
			((Delegate)action2).method = (nint)__ldftn(TrackEventPlaceholderLifecycle.TrackEvent_Stopped);
			object obj3 = action2 + 16;
			obj3 = this;
			_trackEvent.Stopped -= action2;
		}
	}

	private unsafe void TrackEvent_Launching()
	{
		//IL_0103: Expected I, but got Obj
		//IL_0119: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_trackEvent).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(TrackEventPlaceholderLifecycle.TrackEvent_Launching);
			object obj2 = action + 16;
			obj2 = this;
			_trackEvent.Stopped += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			MovingCarActivity movingCarActivity = default;
			((UnityEngine.Object)movingCarActivity).m_CachedPtr = cachedPtr;
			((Activity)movingCarActivity)._running = false;
			object obj3 = movingCarActivity + 16;
			obj3 = this;
			((LerpedTurn)(object)_trackEvent).Init(movingCarActivity);
		}
	}

	private void TrackEvent_Stopped()
	{
		Despawn();
	}

	public TrackEventPlaceholderLifecycle()
	{
		base.DespawnInstances();
	}
}
