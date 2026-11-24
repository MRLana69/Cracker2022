using System;
using Cpp2ILInjected;
using SYBO.Common.StateSystem;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Inputs;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States;

public class RunningState : InGameState
{
	public RunningState(int id)
	{
		Character character = _character;
		character.x = 20f;
		Character character2 = _character;
		character2._killSwitchEnabled = true;
		Character character3 = _character;
		character3.StopColliding = false;
		Character character4 = _character;
		character4.ImmuneToCriticalHit = false;
		Character character5 = _character;
		character5._characterController.isTrigger = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			_character.NotifyOnJumpOverTrain();
		}
	}

	public override void Enter(State fromState)
	{
		//IL_000a: Expected I4, but got Obj
		base.HandleSwipe((SwipeDir)fromState);
	}

	public override void OnUpdate()
	{
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_034f: Expected Obj, but got I4
		//IL_0391: Invalid comparison between I and F4
		//IL_029c: Expected I, but got Obj
		//IL_02b2: Expected Obj, but got I
		//IL_0498: Expected Obj, but got I4
		//IL_0498: Expected Obj, but got I4
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01cb: Expected I, but got Obj
		//IL_01e1: Expected Obj, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got F4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_02dd: Expected I, but got Obj
		//IL_0402: Expected F4, but got Obj
		//IL_0402: Expected F4, but got Obj
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_043d: Expected F4, but got I
		//IL_043d: Expected F4, but got I
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_0478: Expected F4, but got I
		//IL_0478: Expected F4, but got I
		//IL_0253: Expected Obj, but got F4
		//IL_020c: Expected I, but got Obj
		object obj = default;
		Character character = (Character)(obj + 36);
		object obj2 = obj + 12;
		object obj3 = obj + 24;
		obj3 = 0;
		_ = 0;
		base.HandleCriticalHit();
		float unscaledTime = Time.unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.RunningState)+18]");
		float num = 0f + unscaledTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.RunningState)+18]");
		if (0f < 0.5f)
		{
			_character.MoveForward();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.RunningState)+1C]");
		if ((nint)0 == 0)
		{
			Character character2 = _character;
			character2._characterController.isTrigger = false;
			Character character3 = _character;
			character3.ImmuneToCriticalHit = true;
			Character character4 = _character;
			character4.StopColliding = true;
			((CharacterRendering)(object)_character).OnTutorialMoveBackToCheckPoint(1f);
			object obj4 = _character + 236;
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v44+8]");
			_ = 0;
			character = (Character)obj2;
			Character character5 = character;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((UnityEngine.Object)character5).m_CachedPtr = (IntPtr)0;
			object obj5 = this + 32;
			obj5 = character;
			_ = ((UnityEngine.Object)character).m_CachedPtr;
			object obj6 = this + 32;
			Character character6 = _character;
			obj = 0;
			_ = 0;
			obj = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v78+4]");
			_ = 0;
			_ = character6._lastCheckpointGamePositionZ;
			character = (Character)obj;
			Character character7 = character;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)character7).m_CachedPtr = (IntPtr)0;
			object obj7 = this + 44;
			obj7 = character;
			_ = ((UnityEngine.Object)character).m_CachedPtr;
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.RunningState)+18]");
		float num2 = 0f - 0.5f;
		if (num2 < 1f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.RunningState)+18]");
			float value = 0f - 0.5f;
			object obj8 = this + 32;
			object obj9 = this + 44;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S2_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S2_v22 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num5 = Mathf.InverseLerp((float)obj8, (float)obj9, value);
			object obj11 = this + 32;
			object obj12 = this + 44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v49+4]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S1_v26+4]");
			float num7 = Mathf.InverseLerp(num6, 0f, value);
			object obj13 = this + 32;
			object obj14 = this + 44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v53+8]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v30+8]");
			float num9 = Mathf.InverseLerp(num8, 0f, value);
			obj3 = num5;
			character = (Character)obj3;
			Character character8 = character;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((UnityEngine.Object)character8).m_CachedPtr = (IntPtr)0;
			_character.UpdateGroundTag(character);
			return;
		}
		nint num10 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v31 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num11 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v37 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)102);
	}

	public unsafe override void HandleCriticalHit()
	{
		Game game = _game;
		if (~(game._isLockedGameSpeed ? 1u : 0u) != 0)
		{
			Game game2 = _game;
			Game game3 = _game;
			game2.__currentSpeed = game3.__currentLevelSpeed;
		}
		_character.MoveWithGravity();
		_character.CachePositions();
		Character character = _character;
		if (~(character.TransitioningFromHeight__BackingField ? 1u : 0u) == 0)
		{
			Character character2 = _character;
			Variable<bool> isGrounded = character2.IsGrounded;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v27 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 != 0)
			{
				goto IL_00d6;
			}
			Character character3 = _character;
			if (~(character3.inAirJump ? 1u : 0u) == 0)
			{
				Character character4 = _character;
				string text = ((PhysicsScene*)character4._characterController)->ToString();
				if (text != null)
				{
					goto IL_00d6;
				}
			}
		}
		goto IL_0130;
		IL_00d6:
		Character character5 = _character;
		character5.TransitioningFromHeight__BackingField = false;
		_character.Jump();
		goto IL_0130;
		IL_0130:
		_character.Roll();
		_character.CreateExplosionAtCharactersFeet();
		base.HandleCriticalHit();
	}

	public override void HandleSwipe(SwipeDir swipeDir)
	{
		//IL_0061: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00de: Expected F4, but got I
		Vector3 cameraPositionValue = ((CharacterCamera)1).CameraPositionValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj2 = default;
			if (obj2 == null)
			{
				Character character = _character;
				character.TransitioningFromHeight__BackingField = false;
				goto IL_007d;
			}
		}
		Character character2 = _character;
		character2.TransitioningFromHeight__BackingField = true;
		goto IL_007d;
		IL_007d:
		Character character3 = _character;
		character3.CharacterTrigger.isTrigger = true;
		Character character4 = _character;
		object obj3 = _character + 236;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S2_v5+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		character4.LastGroundedY = 0f;
	}

	public override void HandleDoubleTap()
	{
		_game.ResetEnemy();
	}

	private void LogEventForHoverboardStartAttempt(bool successful)
	{
		float num = ((!_character.IsDoubleJumping) ? 30f : 20f);
		Game game = _game;
		float duration = num / game.__currentSpeed;
		switch (successful)
		{
		case false:
			_character.CheckInAirJump();
			break;
		case true:
			_character.EnterRoute();
			break;
		case true:
			_character.ForceChangeTrack(-1, duration);
			break;
		case true:
			_character.ForceChangeTrack(1, duration);
			break;
		}
	}
}
