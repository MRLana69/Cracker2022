using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common;

public class SafeAnimation
{
	public class SafeAnimationEventEventArgs : EventArgs
	{
		private string _message;

		public string Message => _message;

		public SafeAnimationEventEventArgs(string message)
		{
			_message = message;
		}
	}

	private bool _loggingEnabled;

	private Animation _animation;

	private EventHandler<SafeAnimationEventEventArgs> m_OnSafeAnimationEvent;

	public Animation Animation
	{
		get
		{
			return _animation;
		}
		set
		{
			_animation = value;
		}
	}

	public event EventHandler<SafeAnimationEventEventArgs> OnSafeAnimationEvent
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_OnSafeAnimationEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_OnSafeAnimationEvent;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public SafeAnimation(Animation animation, bool loggingEnabled)
	{
		_animation = animation;
		_loggingEnabled = loggingEnabled;
	}

	public void DebugLog(string methodName, object message = null)
	{
	}

	public void SetSpeed(string animationClipName, float speed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I
		//IL_01f2: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj10 = default;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
						object obj11 = (nint)0 << 2;
						object obj12 = obj3 + obj11;
						obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S0_v4+4]");
						object obj14 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj15 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					obj6 = obj15;
					if (flag2)
					{
						goto IL_0314;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj16 = default;
			obj6 = obj16;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj6 = obj16;
			}
		}
		goto IL_0314;
		IL_0314:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	public void SetSpeed(AnimationState animationState, float speed)
	{
		animationState.speed = speed;
	}

	public unsafe void SetRotation(Quaternion rotation)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002a: Expected native int or pointer, but got VT
		//IL_003c: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 16);
		Transform transform = _animation.transform;
		((Quaternion*)(nint)quaternion)->z = rotation.z;
		((Quaternion*)(nint)quaternion)->x = rotation.x;
		transform.rotation = quaternion;
	}

	public unsafe void SetLocalRotation(Quaternion rotation)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002a: Expected native int or pointer, but got VT
		//IL_003c: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 16);
		Transform transform = _animation.transform;
		((Quaternion*)(nint)quaternion)->z = rotation.z;
		((Quaternion*)(nint)quaternion)->x = rotation.x;
		transform.localRotation = quaternion;
	}

	public bool HasAnimationClip(string animationClipName)
	{
		if (animationClipName != null)
		{
			AnimationClip clip = _animation.GetClip(animationClipName);
			return clip != null;
		}
		return false;
	}

	public AnimationClip GetAnimationClip(string animationClipName)
	{
		return _animation.GetClip(animationClipName);
	}

	public AnimationState GetAnimationState(string animationStateName)
	{
		return _animation.get_Item(animationStateName);
	}

	public bool HasAnimationState(string animationStateName)
	{
		AnimationState animationState = GetAnimationState(animationStateName);
		return animationState != null;
	}

	public void AddClip(AnimationClip animationClip, string newName)
	{
		_animation.AddClip(animationClip, newName);
	}

	public void CrossFadeQueued(string animationName)
	{
		AnimationState animationState = _animation.CrossFadeQueued(animationName);
		RaiseOnSafeAnimationEvent("CrossFadeQueued", animationName);
	}

	public unsafe void CrossFadeQueued(string animationName, float fadeLength)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0090: Expected Ref, but got F4
		//IL_0031: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		AnimationState animationState = _animation.CrossFadeQueued(animationName, fadeLength);
		float num = (float)obj + 12f;
		string text = ((float*)num)->ToString();
		string text2 = animationName + " , " + text;
		float num2 = (float)obj + 12f;
		string text3 = ((float*)num2)->ToString();
		string message = animationName + " , " + text3;
		RaiseOnSafeAnimationEvent("CrossFadeQueued", message);
	}

	public void CrossFade(string animationName)
	{
		_animation.CrossFade(animationName);
		RaiseOnSafeAnimationEvent("CrossFade", animationName);
	}

	public void TryAddAnimationEvent(Animation animationInstance, string animationName, AnimationEvent animationEvent)
	{
		bool flag = Globals.TryAddAnimationEvent(animationInstance, animationName, animationEvent);
	}

	public unsafe void CrossFade(string animationName, float fadeLength)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008c: Expected Ref, but got F4
		//IL_0031: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		_animation.CrossFade(animationName, fadeLength);
		float num = (float)obj + 12f;
		string text = ((float*)num)->ToString();
		string text2 = animationName + " , " + text;
		float num2 = (float)obj + 12f;
		string text3 = ((float*)num2)->ToString();
		string message = animationName + " , " + text3;
		RaiseOnSafeAnimationEvent("CrossFade", message);
	}

	public void SetEnabled(string animationName, bool isEnabled)
	{
		AnimationState animationState = _animation.get_Item(animationName);
		animationState.enabled = isEnabled;
	}

	public void Stop()
	{
		_animation.Stop();
		RaiseOnSafeAnimationEvent("Stop");
	}

	public void PlayQueued(string animationName)
	{
		AnimationState animationState = _animation.PlayQueued(animationName);
		RaiseOnSafeAnimationEvent("PlayQueued", animationName);
	}

	public void Play(string animationName)
	{
		bool flag = _animation.Play(animationName);
		string text = animationName + " , " + animationName;
		string message = animationName + " , " + animationName;
		RaiseOnSafeAnimationEvent("Play", message);
	}

	public void Play()
	{
		bool flag = _animation.Play();
		RaiseOnSafeAnimationEvent("Play");
	}

	public bool IsPlaying(string animationName)
	{
		return _animation.IsPlaying(animationName);
	}

	public bool HasAnimation()
	{
		return _animation != null;
	}

	private void RaiseOnSafeAnimationEvent(string methodName, object message = null)
	{
		//IL_000d: Expected I, but got Obj
		string text = default;
		if (message != null)
		{
			nint num = (nint)message;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S3_v7 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
		}
		else
		{
			text = null;
		}
		string message2 = methodName + "() " + text;
		EventHandler<SafeAnimationEventEventArgs> onSafeAnimationEvent = this.m_OnSafeAnimationEvent;
		if (this.m_OnSafeAnimationEvent != null)
		{
			SafeAnimationEventEventArgs e = default;
			e._002Ector(message2);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S0_v8 (System.EventHandler`1<SYBO.Common.SafeAnimation+SafeAnimationEventEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}
}
