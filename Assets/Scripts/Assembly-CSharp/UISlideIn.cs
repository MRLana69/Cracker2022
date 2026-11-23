using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UISlideIn : MonoBehaviour
{
	private sealed class _003CInvokeDidShowCallback_003Ed__10(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public UISlideIn _003C_003E4__this;

		private float _003CstartPoint_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			UISlideIn uISlideIn = _003C_003E4__this;
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0103;
				}
				_003C_003E1__state = -1;
				num = _003CstartPoint_003E5__2;
			}
			else
			{
				_003CstartPoint_003E5__2 = 0f;
				_003C_003E1__state = -1;
				num = 0f;
			}
			if (!(num < waitTime))
			{
				Action onDidShowCallback = uISlideIn._onDidShowCallback;
				if (uISlideIn._onDidShowCallback != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				goto IL_0103;
			}
			float deltaTime = RealTimeTracker.deltaTime;
			float num2 = num + deltaTime;
			_003C_003E2__current = null;
			_003CstartPoint_003E5__2 = num2;
			_003C_003E1__state = 1;
			return true;
			IL_0103:
			return false;
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

	private sealed class _003CPreloadSlideIn_003Ed__14(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UISlideIn _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00b6: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						GameObject gameObject = _003C_003E4__this.gameObject;
						gameObject.SetActive(value: false);
					}
					return false;
				}
				_003C_003E1__state = -1;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			GameObject gameObject2 = _003C_003E4__this.gameObject;
			gameObject2.SetActive(value: true);
			_003C_003E2__current = null;
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

	protected Vector3 posOff = (Vector3)4803651952544055296L;

	protected Vector3 posOn;

	private bool _triggerSlideOut;

	private float _slideOutTimer = 3f;

	private bool _triggerReadyForNext;

	private float _readyForNextTimer = 1f;

	private Action _onDidShowCallback;

	protected unsafe virtual void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002d: Expected F4, but got I
		//IL_0028: Expected native int or pointer, but got VT
		//IL_003c: Expected F4, but got VT
		//IL_0037: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlideIn)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)posOff;
		transform.localPosition = vector;
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	public void SetupSlideIn()
	{
		//IL_0022: Expected I, but got Obj
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S2_v3 (Il2CppClass<UISlideIn>)+E4] (should have been resolved before IL gen)");
	}

	protected unsafe virtual void SlideIn(Action onDidShowCallback = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0037: Expected F4, but got I
		//IL_0032: Expected native int or pointer, but got VT
		//IL_0046: Expected F4, but got VT
		//IL_0041: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		_onDidShowCallback = onDidShowCallback;
		GameObject go = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlideIn)+20]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)posOn;
		SpringPosition springPosition = SpringPosition.Begin(go, vector, 10f);
		springPosition.ignoreTimeScale = true;
		_readyForNextTimer = 1f;
		_slideOutTimer = 3f;
		IEnumerator routine = InvokeDidShowCallback(0.5f);
		Coroutine coroutine = StartCoroutine(routine);
		_triggerSlideOut = true;
	}

	private IEnumerator InvokeDidShowCallback(float waitTime)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	protected unsafe virtual void SlideOut()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002d: Expected F4, but got I
		//IL_0028: Expected native int or pointer, but got VT
		//IL_003c: Expected F4, but got VT
		//IL_0037: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		GameObject go = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISlideIn)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)posOff;
		SpringPosition springPosition = SpringPosition.Begin(go, vector, 10f);
		springPosition.ignoreTimeScale = true;
		_triggerReadyForNext = true;
	}

	protected virtual void ReadyForNewMessage()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		UIScreenController instance = UIScreenController.Instance;
		instance.ReadyForNextSlide();
	}

	private void Update()
	{
		//IL_00aa: Expected I, but got Obj
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_0125: Expected I, but got Obj
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		if (~(_triggerReadyForNext ? 1u : 0u) == 0 || ~(_triggerSlideOut ? 1u : 0u) == 0)
		{
			float deltaTime = RealTimeTracker.deltaTime;
			if (~(_triggerSlideOut ? 1u : 0u) == 0 && !((_slideOutTimer -= deltaTime) > 0f))
			{
				nint num = (nint)this;
				object obj = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S1_v17 (Il2CppClass<UISlideIn>)+EC] (should have been resolved before IL gen)");
				_triggerSlideOut = false;
			}
			if (~(_triggerReadyForNext ? 1u : 0u) == 0 && !((_readyForNextTimer -= deltaTime) > 0f))
			{
				_triggerReadyForNext = false;
				nint num2 = (nint)this;
				object obj2 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S1_v9 (Il2CppClass<UISlideIn>)+F4] (should have been resolved before IL gen)");
			}
		}
	}

	public IEnumerator PreloadSlideIn()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public UISlideIn()
	{
		//IL_0025: Expected VT, but got I8
		_ = 3265921024L;
		_ = 0;
		base._002Ector();
	}
}
