using System;
using Cpp2ILInjected;
using UnityEngine;

public class RunnerAnimation : MonoBehaviour
{
	private static bool addedListeners;

	public float AnimationSpeedUpFactor;

	private AnimationEventBroadcaster animationEventBroadcaster;

	private void Awake()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public void SetAnimationSpeedEvent(AnimationEvent animEvent)
	{
		//IL_0030: Expected Obj, but got I
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RunnerAnimation)+3C]");
		Delegate obj = (Delegate)0;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)animEvent);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 60;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private void SetSpeed(AnimationState animationState, float speed)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4EF0");
	}

	public unsafe RunnerAnimation()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0031: Expected Obj, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		object obj = this + 16;
		string text = tag;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v29 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		obj = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		AnimationEventBroadcaster.SendSetAnimationSpeedEventDelegate sendSetAnimationSpeedEventDelegate = default;
		((Delegate)sendSetAnimationSpeedEventDelegate).method_ptr = method_ptr;
		((Delegate)sendSetAnimationSpeedEventDelegate).method = (nint)__ldftn(RunnerAnimation.SetAnimationSpeedEvent);
		object obj7 = sendSetAnimationSpeedEventDelegate + 16;
		obj7 = this;
		animationEventBroadcaster.SendSetAnimationSpeedEvent -= sendSetAnimationSpeedEventDelegate;
	}
}
