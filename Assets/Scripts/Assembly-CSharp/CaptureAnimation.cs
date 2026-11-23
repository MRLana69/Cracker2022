using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using UnityEngine;

public class CaptureAnimation : AScreenCapture
{
	private sealed class _003CCaptureAnimationToEnd_003Ed__5(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CaptureAnimation _003C_003E4__this;

		private int _003CframeCount_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0065: Expected I4, but got I8
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected I4, but got Unknown
			//IL_0225: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I
			//IL_010c: Expected Obj, but got I
			//IL_010c: Expected Obj, but got I
			//IL_017f: Expected I, but got Obj
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			CaptureAnimation captureAnimation = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				int num;
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						bool result = default;
						return result;
					}
					_003C_003E1__state = -1;
					num = _003CframeCount_003E5__2;
				}
				else
				{
					_003CframeCount_003E5__2 = 0;
					_003C_003E1__state = -1;
					num = 0;
				}
				int num2 = num + 1;
				_003CframeCount_003E5__2 = num2;
				int num3 = obj + 12;
				string text = ((int*)num3)->ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (CaptureAnimation)+24]");
				string name = (string)0 + "_" + text;
				captureAnimation.SaveScreenshot(name);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (CaptureAnimation)+20]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (CaptureAnimation)+24]");
				AnimationState animationState = ((Animation)num4).get_Item((string)0);
				float time = animationState.time;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (CaptureAnimation)+20]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (CaptureAnimation)+24]");
				AnimationState animationState2 = ((Animation)num5).get_Item((string)0);
				float length = animationState2.length;
				if (time < length)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				nint num6 = (nint)captureAnimation;
				object obj3 = captureAnimation + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ S1_v23 (Il2CppClass<AScreenCapture>)+DC] (should have been resolved before IL gen)");
				return false;
			}
			_003C_003E1__state = -1;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private Animation _animation;

	private string _animationName = string.Empty;

	private Action _onDone;

	private GameObject _coroutineObject;

	public CaptureAnimation(Animation animation, string captureFolder, string animationName, int width, int height, int fps, Camera camera, Action onDone)
		: base(Path.Combine(captureFolder, animationName), width, height, camera)
	{
		//IL_0058: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		Time.captureFramerate = fps;
		_animation = animation;
		_animationName = animationName;
		_onDone = onDone;
		string[] files = Directory.GetFiles(Path.Combine(captureFolder, animationName));
		object obj = 0;
		while (files.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)files + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v43+10]");
			File.Delete((string)0);
			object obj4 = obj + 1;
			obj = obj4;
		}
		GameObject gameObject = default;
		gameObject._002Ector();
		_coroutineObject = gameObject;
		_coroutineObject.hideFlags = HideFlags.HideAndDontSave;
		if (_animation.IsPlaying(_animationName))
		{
			_animation.Stop();
			_animation.Rewind();
		}
		bool flag = _animation.Play(_animationName, PlayMode.StopAll);
		Coroutine coroutine = _coroutineObject.AddComponent<NewMonoBehaviour>().StartCoroutine(CaptureAnimationToEnd());
	}

	private IEnumerator CaptureAnimationToEnd()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void Cleanup()
	{
		base.Cleanup();
		UnityEngine.Object.Destroy(_coroutineObject);
		Time.captureFramerate = 0;
		Action onDone = _onDone;
		if (_onDone != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v23.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
