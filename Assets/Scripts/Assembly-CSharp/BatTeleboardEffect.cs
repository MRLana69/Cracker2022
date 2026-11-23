using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Subway;
using SYBO.Subway.Characters;
using UnityEngine;

public class BatTeleboardEffect : ATeleboardEffect
{
	private sealed class _003CResetCharacterTeleportFX_003Ed__13(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BatTeleboardEffect _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			BatTeleboardEffect batTeleboardEffect = _003C_003E4__this;
			if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 2)
				{
					goto IL_01b7;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (!batTeleboardEffect._overrideEnd)
				{
					if (batTeleboardEffect._animation != null && batTeleboardEffect._animation.isPlaying)
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
					}
					if (!batTeleboardEffect._overrideEnd)
					{
						_ = batTeleboardEffect._reappearDelay;
						object obj = default;
						_003C_003E2__current = obj;
						_003C_003E1__state = 2;
						return true;
					}
				}
			}
			batTeleboardEffect._correctEndYPos = false;
			Character instance = Character.Instance;
			GameObject gameObject = instance._characterModel.gameObject;
			gameObject.SetActive(value: true);
			Game instance2 = Game.Instance;
			if (!instance2.IsInJetpackMode)
			{
				Game instance3 = Game.Instance;
				if (!instance3.IsInPogostickMode)
				{
					Character instance4 = Character.Instance;
					Variable<bool> isGrounded = instance4.IsGrounded;
					CharacterRendering instance5 = CharacterRendering.Instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v27 (Variable`1<System.Boolean>)+8]");
					if ((nint)0 != 0)
					{
						instance5.OnRun();
						return false;
					}
					instance5.Character_OnHangtime();
				}
			}
			goto IL_01b7;
			IL_01b7:
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

	private Animation _animation;

	private string _leftAnimationName = string.Empty;

	private string _rightAnimationName = string.Empty;

	private Transform _endPoof;

	private Vector3 _offset;

	private float _reappearDelay;

	private bool _overrideEnd;

	private Vector3 pos;

	private bool _correctEndYPos;

	public override void StartTeleBoardEffect()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0077: Expected VT, but got Obj
		//IL_009d: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 32;
		_overrideEnd = false;
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = base.gameObject;
		gameObject2.SetActive(value: true);
		Character instance = Character.Instance;
		Transform transform = instance.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		pos = (Vector3)obj;
		Character instance2 = Character.Instance;
		bool flag = instance2._trackMovement > -1;
		object obj3 = 20;
		if (!flag)
		{
			obj3 = 16;
		}
		object animation = (object)this + obj3;
		_animation.Stop();
		bool flag2 = _animation.Play((string)animation);
		AnimationState animationState = _animation.get_Item((string)animation);
		AnimationState animationState2 = _animation.get_Item((string)animation);
		float length = animationState2.length;
		Game instance3 = Game.Instance;
		float num = 20f / instance3.__currentSpeed;
		float speed = length / num;
		animationState.speed = speed;
		Character instance4 = Character.Instance;
		GameObject gameObject3 = instance4._characterModel.gameObject;
		gameObject3.SetActive(value: false);
		_correctEndYPos = true;
		IEnumerator coroutine = ResetCharacterTeleportFX();
		CoroutineUtil.StopCoroutine(coroutine);
		IEnumerator coroutine2 = ResetCharacterTeleportFX();
		Coroutine coroutine3 = CoroutineUtil.StartCoroutine(coroutine2);
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0041: Expected Obj, but got VT
		//IL_005e: Expected Obj, but got I
		//IL_007b: Expected Obj, but got I
		//IL_0095: Expected F4, but got I
		//IL_0090: Expected native int or pointer, but got VT
		//IL_00b4: Expected F4, but got I
		//IL_00af: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		Character instance = Character.Instance;
		_ = instance.z;
		Transform transform = base.transform;
		object obj2 = pos + _offset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BatTeleboardEffect)+34]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BatTeleboardEffect)+20]");
		object obj3 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BatTeleboardEffect)+38]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BatTeleboardEffect)+24]");
		object obj4 = num2 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.position = vector;
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0085: Expected Obj, but got I
		//IL_00a7: Expected F4, but got I
		//IL_00a2: Expected native int or pointer, but got VT
		//IL_00ce: Expected F4, but got I
		//IL_00c9: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (~(_correctEndYPos ? 1u : 0u) == 0)
		{
			Vector3 position = _endPoof.position;
			Character instance = Character.Instance;
			Transform transform = instance._characterModel.transform;
			Vector3 position2 = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BatTeleboardEffect)+20]");
			object obj2 = num + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			_endPoof.position = vector;
		}
	}

	public override void ResetTeleboardEffect()
	{
		_overrideEnd = true;
	}

	private IEnumerator ResetCharacterTeleportFX()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public BatTeleboardEffect()
	{
		//IL_006b: Expected I, but got Obj
		//IL_002e: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_offset = Vector3.zeroVector;
		_reappearDelay = 0.2f;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		pos = Vector3.zeroVector;
		base._002Ector();
	}
}
