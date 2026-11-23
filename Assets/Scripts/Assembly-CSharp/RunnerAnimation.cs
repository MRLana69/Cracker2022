using System;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

public class RunnerAnimation : MonoBehaviour
{
	private static bool addedListeners;

	public float AnimationSpeedUpFactor = 0.5f;

	private AnimationEventBroadcaster animationEventBroadcaster;

	private unsafe void Awake()
	{
		GameObject gameObject = base.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		AnimationEventBroadcaster animationEventBroadcaster = default;
		this.animationEventBroadcaster = animationEventBroadcaster;
		AnimationEventBroadcaster.SendSetAnimationSpeedEventDelegate sendSetAnimationSpeedEventDelegate = default;
		sendSetAnimationSpeedEventDelegate._002Ector(this, (nint)__ldftn(RunnerAnimation.SetAnimationSpeedEvent));
		this.animationEventBroadcaster.SendSetAnimationSpeedEvent += sendSetAnimationSpeedEventDelegate;
	}

	public void SetAnimationSpeedEvent(AnimationEvent animEvent)
	{
		if (~(addedListeners ? 1u : 0u) != 0)
		{
			addedListeners = true;
			AnimationState animationState = animEvent.animationState;
			Game instance = Game.Instance;
			Game.SpeedInfo speed = instance.speed;
			float num = instance.__currentSpeed / speed.min;
			float num2 = num - 1f;
			float num3 = num2 * AnimationSpeedUpFactor;
			float speed2 = num3 + 1f;
			SetSpeed(animationState, speed2);
		}
	}

	private void SetSpeed(AnimationState animationState, float speed)
	{
		animationState.speed = speed;
	}
}
