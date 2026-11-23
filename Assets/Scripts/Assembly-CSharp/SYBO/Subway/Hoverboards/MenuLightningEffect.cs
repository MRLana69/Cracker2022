using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using UnityEngine;

namespace SYBO.Subway.Hoverboards;

public class MenuLightningEffect : MonoBehaviour
{
	private sealed class _003CDelayedDisable_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MenuLightningEffect _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_006d: Expected Obj, but got I4
			//IL_009f: Expected Obj, but got I
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected Obj, but got Unknown
			//IL_00f7: Expected Obj, but got I
			MenuLightningEffect menuLightningEffect = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					object obj = 0;
					while (true)
					{
						GameObject[] children = menuLightningEffect._children;
						if ((nint)obj >= children.Length)
						{
							break;
						}
						object obj2 = obj << 2;
						object obj3 = (object)children + obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v26+10]");
						if ((UnityEngine.Object)0 != null)
						{
							object obj4 = obj << 2;
							object obj5 = (object)menuLightningEffect._children + obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v37+10]");
							((GameObject)0).SetActive(value: false);
						}
						object obj6 = obj + 1;
						obj = obj6;
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = menuLightningEffect._duration;
			object obj7 = default;
			_003C_003E2__current = obj7;
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

	private float _duration;

	private float _minDelay;

	private float _maxDelay;

	private float _currentDelay;

	private GameObject[] _children;

	private void Awake()
	{
		Transform transform = base.transform;
		int childCount = transform.childCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] children = default;
		_children = children;
		int num = 0;
		GameObject[] children2 = _children;
		if (children2.Length > num)
		{
			Transform transform2 = base.transform;
			Transform child = transform2.GetChild(num);
			GameObject gameObject = child.gameObject;
			throw new ArrayTypeMismatchException();
		}
	}

	private void Update()
	{
		//IL_00a5: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		if (!(_currentDelay > 0f))
		{
			float currentDelay = UnityEngine.Random.Range(_minDelay, _maxDelay);
			_currentDelay = currentDelay;
			return;
		}
		float deltaTime = Time.deltaTime;
		if ((_currentDelay -= deltaTime) > 0f)
		{
			return;
		}
		object obj = 0;
		while (true)
		{
			GameObject[] children = _children;
			if (children.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)children + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v20+10]");
			((GameObject)0).SetActive(value: true);
			object obj4 = obj + 1;
			obj = obj4;
		}
		IEnumerator coroutine = DelayedDisable();
		CoroutineUtil.StopCoroutine(coroutine);
		IEnumerator coroutine2 = DelayedDisable();
		Coroutine coroutine3 = CoroutineUtil.StartCoroutine(coroutine2);
	}

	private IEnumerator DelayedDisable()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
