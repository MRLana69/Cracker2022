using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Cameras;
using SYBO.Subway.Inputs;
using UnityEngine;

namespace SYBO.Subway.Characters.States;

public abstract class CharacterState : MonoBehaviour
{
	private sealed class _003CBegin_003Ed__20(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state == 0)
			{
				_003C_003E1__state = -1;
			}
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

	private sealed class _003CEnd_003Ed__21(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state == 0)
			{
				_003C_003E1__state = -1;
			}
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

	protected const float CharacterChangeTrackLength = 30f;

	protected const float CharacterChangeTrackLengthTelebord = 20f;

	protected CameraData _cameraData;

	protected bool _hasEnded;

	protected Game _game;

	protected Character _character;

	protected CharacterCamera _characterCamera;

	protected CharacterRendering _characterRendering;

	protected CharacterController _characterController;

	public CameraData CameraData => _cameraData;

	public bool HasEnded => _hasEnded;

	protected virtual float LaneChangeJumpHeight => 0f;

	public virtual bool WillPauseActiveModifiers => false;

	protected virtual void Awake()
	{
		Game instance = Game.Instance;
		_game = instance;
		Game game = _game;
		_character = game._character;
		Character character = _character;
		_characterCamera = character._characterCamera;
		Character character2 = _character;
		_characterRendering = character2._characterRendering;
		Character character3 = _character;
		_characterController = character3._characterController;
	}

	protected virtual void Reset()
	{
		CameraData cameraData = default;
		cameraData._002Ector();
		_cameraData = cameraData;
	}

	public virtual void HandleSwipe(SwipeDir swipeDir)
	{
	}

	public virtual IEnumerator Begin()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public virtual IEnumerator End()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public virtual void HandleCriticalHit()
	{
	}

	public virtual void HandleDoubleTap()
	{
	}

	protected void MoveCharacterByGravity()
	{
		_character.ApplyGravity();
		_character.MoveForward();
	}

	protected unsafe void MoveCharacterBy(Vector2 positionDelta)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0087: Expected F4, but got I
		//IL_0082: Expected native int or pointer, but got VT
		//IL_00a6: Expected F4, but got I
		//IL_00a1: Expected native int or pointer, but got VT
		//IL_00e8: Expected F4, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		_character.MoveForward();
		Vector3 currentTransformPosition = _character.CurrentTransformPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		float num = 0f + positionDelta.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		float num2 = 0f + positionDelta.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		_character.CurrentTransformPosition = vector;
		Character character = _character;
		Vector3 currentTransformPosition2 = _character.CurrentTransformPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		character.LastGroundedY = 0f;
	}

	protected void ProcessInput_ChangeTrack(int trackDelta)
	{
		//IL_00aa: Expected I, but got Obj
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00c8: Invalid comparison between Obj and F4
		//IL_0042: Expected I, but got Obj
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		bool isTeleboard = _character.IsTeleboard;
		float num = 20f;
		if (!isTeleboard)
		{
			num = 30f;
		}
		Game game = _game;
		float duration = num / game.__currentSpeed;
		_character.ChangeTrackBy(trackDelta, duration);
		nint num2 = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v4 (Il2CppClass<SYBO.Subway.Characters.States.CharacterState>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
		{
			Character instance = Character.Instance;
			nint num3 = (nint)this;
			object obj3 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v9 (Il2CppClass<SYBO.Subway.Characters.States.CharacterState>)+DC] (should have been resolved before IL gen)");
			float jumpHeight = default;
			instance.JumpAdvanced(jumpHeight);
		}
	}

	protected void ProcessInput_Roll()
	{
		_character.Roll();
	}
}
