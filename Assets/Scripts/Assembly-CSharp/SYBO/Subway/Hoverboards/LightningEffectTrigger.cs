using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Subway.Characters;
using UnityEngine;

namespace SYBO.Subway.Hoverboards;

public class LightningEffectTrigger : MonoBehaviour
{
	private sealed class _003CDelayedDisable_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public LightningEffectTrigger _003C_003E4__this;

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
			LightningEffectTrigger lightningEffectTrigger = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					object obj = 0;
					while (true)
					{
						GameObject[] children = lightningEffectTrigger._children;
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
							object obj5 = (object)lightningEffectTrigger._children + obj4;
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
			_ = lightningEffectTrigger._duration;
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

	private const float InAirThreshold = 0.1f;

	private float _duration = 0.3f;

	private Vector3 _direction;

	private CharacterController _characterController;

	private float _inAirTime;

	private GameObject[] _children;

	private void Awake()
	{
		Character instance = Character.Instance;
		_characterController = instance._characterController;
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

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected VT, but got Unknown
		//IL_01a8: Expected F4, but got I
		//IL_01a3: Expected native int or pointer, but got VT
		//IL_01ca: Expected F4, but got I
		//IL_01c5: Expected native int or pointer, but got VT
		//IL_00c7: Expected Obj, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + -64);
		bool isGrounded = _characterController.isGrounded;
		if (isGrounded && !(_inAirTime < 0.1f))
		{
			object obj2 = default;
			object obj4 = default;
			while (true)
			{
				GameObject[] children = _children;
				if (children.Length <= (nint)obj2)
				{
					break;
				}
				object obj3 = obj4 << 2;
				object obj5 = (object)children + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v42+10]");
				((GameObject)0).SetActive(value: true);
				obj2 = obj4 + 1;
			}
			IEnumerator coroutine = DelayedDisable();
			CoroutineUtil.StopCoroutine(coroutine);
			IEnumerator coroutine2 = DelayedDisable();
			Coroutine coroutine3 = CoroutineUtil.StartCoroutine(coroutine2);
		}
		GameObject[] children2 = _children;
		if (children2[0].activeSelf)
		{
			Transform transform = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Hoverboards.LightningEffectTrigger)+18]");
			_ = 0;
			_ = _direction;
			Vector3 forward = (Vector3)(quaternion + 16);
			Quaternion quaternion2 = Quaternion.LookRotation(forward);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			transform.rotation = quaternion;
		}
		float inAirTime;
		if (isGrounded)
		{
			inAirTime = 0f;
		}
		else
		{
			float deltaTime = Time.deltaTime;
			inAirTime = _inAirTime + deltaTime;
		}
		_inAirTime = inAirTime;
	}

	private IEnumerator DelayedDisable()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public LightningEffectTrigger()
	{
		//IL_001e: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		_ = 0;
		_direction = Vector3.forwardVector;
		base._002Ector();
	}
}
