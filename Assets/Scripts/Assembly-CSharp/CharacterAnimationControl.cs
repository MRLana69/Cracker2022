using System;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterAnimationControl : MonoBehaviour
{
	private AnimationClip _runAnimation;

	private Animation _animationComponent;

	private AnimationClip _currentAnimation;

	public void Play()
	{
		GameObject gameObject = base.gameObject;
		if (gameObject != null)
		{
			GameObject gameObject2 = base.gameObject;
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S3_v12 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInParent>>)+4] (should have been resolved before IL gen)");
			UnityEngine.Object obj = default;
			if (obj != null)
			{
				CharacterAssetsBundle componentInChildren = ((Component)obj).GetComponentInChildren<CharacterAssetsBundle>();
				AnimationClip currentAnimation = ((!(componentInChildren.RunIdle != null)) ? _runAnimation : componentInChildren.RunIdle);
				_currentAnimation = currentAnimation;
			}
		}
		if (_animationComponent == null)
		{
			GameObject gameObject3 = base.gameObject;
			nint num3 = 0;
			nint num4 = 0;
			IntPtr intPtr2 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ S4_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			Animation animationComponent = default;
			_animationComponent = animationComponent;
		}
		string text = _currentAnimation.name;
		AnimationClip clip = _animationComponent.GetClip(text);
		if (!clip)
		{
			string newName = _currentAnimation.name;
			_animationComponent.AddClip(_currentAnimation, newName);
		}
		string animation = _currentAnimation.name;
		bool flag = _animationComponent.Play(animation);
	}

	public void Speed(float speed)
	{
		string text = _currentAnimation.name;
		AnimationState animationState = _animationComponent.get_Item(text);
		animationState.speed = speed;
	}
}
