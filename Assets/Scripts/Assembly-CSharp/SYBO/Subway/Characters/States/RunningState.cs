using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Inputs;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Characters.States;

public class RunningState : CharacterState
{
	public enum RunPositions
	{
		ground,
		station,
		train,
		movingTrain,
		air
	}

	private sealed class _003CBegin_003Ed__27(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RunningState _003C_003E4__this;

		private bool _003CtransitionWithRoll_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_007e: Invalid comparison between I and F4
			//IL_05aa: Expected F4, but got I
			//IL_00c0: Invalid comparison between I and F4
			//IL_0123: Invalid comparison between I and F4
			//IL_02ae: Expected Obj, but got I4
			//IL_02df: Expected Obj, but got I
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			RunningState runningState = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0534;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				runningState.transitionFromHeight = false;
				_003CtransitionWithRoll_003E5__2 = false;
				Vector3 position = runningState._characterTransform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				if (0f > 70f)
				{
					Vector3 position2 = runningState._characterTransform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
					if (0f < 125f)
					{
						runningState.transitionFromHeight = true;
					}
				}
				if (~(runningState.transitionFromPogostick ? 1u : 0u) == 0)
				{
					runningState.transitionFromHeight = true;
					Vector3 position3 = runningState._characterTransform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
					if (0f < 155f)
					{
						_003CtransitionWithRoll_003E5__2 = true;
					}
				}
				Character character = runningState._character;
				character.CharacterTrigger.enabled = true;
				Character character2 = runningState._character;
				Vector3 currentTransformPosition = runningState._character.CurrentTransformPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				character2.LastGroundedY = 0f;
				AnimationEvent animationEvent = default;
				animationEvent._002Ector();
				animationEvent.m_FunctionName = "SetAnimationSpeedEvent";
				animationEvent.m_Time = 0.1f;
				animationEvent.m_MessageOptions = 0;
				CharacterRendering characterRendering = runningState._characterRendering;
				SafeAnimation characterSafeAnimation = characterRendering._characterSafeAnimation;
				characterRendering.SafeTryAddAnimationEvent(characterSafeAnimation._animation, "run", animationEvent);
				CharacterRendering characterRendering2 = runningState._characterRendering;
				SafeAnimation characterSafeAnimation2 = characterRendering2._characterSafeAnimation;
				characterRendering2.SafeTryAddAnimationEvent(characterSafeAnimation2._animation, "run2", animationEvent);
				CharacterRendering characterRendering3 = runningState._characterRendering;
				SafeAnimation characterSafeAnimation3 = characterRendering3._characterSafeAnimation;
				characterRendering3.SafeTryAddAnimationEvent(characterSafeAnimation3._animation, "run3", animationEvent);
				CharacterRendering characterRendering4 = runningState._characterRendering;
				SafeAnimation characterSafeAnimation4 = characterRendering4._characterSafeAnimation;
				characterRendering4.SafeTryAddAnimationEvent(characterSafeAnimation4._animation, "run4_long", animationEvent);
				CharacterRendering characterRendering5 = runningState._characterRendering;
				GameObject sprayCanModel = characterRendering5._characterModel.SprayCanModel;
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v302 @ S3_v9 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
				object obj3 = 0;
				object obj7 = default;
				while (true)
				{
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v122+C]");
					if ((nint)obj4 >= 0)
					{
						break;
					}
					object obj5 = obj3 << 2;
					object obj6 = obj7 + obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v128+10]");
					((ParticleSystem)0).Stop();
					object obj8 = obj3 + 1;
					obj3 = obj8;
				}
			}
			Game game = runningState._game;
			if (~(game._isLockedGameSpeed ? 1u : 0u) != 0)
			{
				game.__currentSpeed = game.__currentLevelSpeed;
			}
			runningState._character.ApplyGravity();
			runningState._character.MoveForward();
			Character character3 = runningState._character;
			Variable<bool> isGrounded = character3.IsGrounded;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v25 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 != 0 && ~(runningState.transitionFromHeight ? 1u : 0u) == 0 && !_003CtransitionWithRoll_003E5__2)
			{
				Game game2 = runningState._game;
				if (game2.pogoJumpsLeft >= 1)
				{
					int pogoJumpsLeft = game2.pogoJumpsLeft - 1;
					game2.pogoJumpsLeft = pogoJumpsLeft;
					runningState._game.StartPogostick();
				}
			}
			else if (~(_003CtransitionWithRoll_003E5__2 ? 1u : 0u) == 0)
			{
				Game game3 = runningState._game;
				if (game3.pogoJumpsLeft == 0)
				{
					runningState.transitionFromPogostick = false;
				}
			}
			if (~(runningState.transitionFromHeight ? 1u : 0u) == 0)
			{
				Character character4 = runningState._character;
				Variable<bool> isGrounded2 = character4.IsGrounded;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v45 (Variable`1<System.Boolean>)+8]");
				if ((nint)0 == 0)
				{
					Character character5 = runningState._character;
					if (~(character5.inAirJump ? 1u : 0u) != 0 || !runningState._characterController.isGrounded)
					{
						goto IL_04ba;
					}
				}
				runningState.transitionFromHeight = false;
				_003CtransitionWithRoll_003E5__2 = false;
				runningState._character.ForceLeaveSubway();
			}
			goto IL_04ba;
			IL_0534:
			return true;
			IL_04ba:
			runningState._character.CheckInAirJump();
			runningState._game.UpdateMeters();
			runningState.UpdateInAirRunPosition();
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_0534;
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

	public float slowDownDuration = 0.625f;

	public float slowDownRatio;

	public float tunnelDelta = -20f;

	public Vector3 cameraOffset;

	public float cameraAimOffset = 20f;

	public float cameraFOV;

	public float smoothCameraXDuration = 0.05f;

	public float ySmoothDuration;

	public const float CHARACTER_CHANGE_TRACK_LENGTH = 30f;

	public float ySmoothDurationPogostick = 0.1f;

	public float transitionTimeMax;

	public float speedupTransitionTime = 5f;

	public float speedupTransitionTimeLow;

	public AnimationCurve transitionFromJetpackY;

	public AnimationCurve transitionFromJetpackZ;

	public float transitionTimeJetpack = 1f;

	public bool transitionFromHeight;

	public bool transitionFromPogostick;

	private Transform _characterTransform;

	public RunPositions currentRunPosition;

	private Queue<Collider> GrindedTrains;

	private int GrindedTrainsBufferSize;

	private static RunningState instance;

	public static RunningState Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			RunningState result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(RunningState));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				RunningState runningState = default;
				instance = runningState;
				result = runningState;
			}
			return result;
		}
	}

	protected unsafe override void Awake()
	{
		base.Awake();
		Transform characterTransform = _character.transform;
		_characterTransform = characterTransform;
		Character.OnStumbleDelegate onStumbleDelegate = default;
		onStumbleDelegate._002Ector(this, (nint)__ldftn(RunningState._003CAwake_003Eb__26_0));
		_character.OnStumble += onStumbleDelegate;
	}

	public override IEnumerator Begin()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void UpdateInAirRunPosition()
	{
		if (!_characterController.isGrounded)
		{
			currentRunPosition = RunPositions.air;
		}
	}

	private void LandedOnTrain(Collider trainCollider)
	{
		//IL_0014: Expected VT, but got Obj
		Character character = _character;
		if (character._hoverboard.enabled && !((Queue<T>)(object)GrindedTrains).Contains((T)trainCollider))
		{
			Queue<Collider> grindedTrains = GrindedTrains;
			if (grindedTrains._size > GrindedTrainsBufferSize)
			{
				Collider collider = GrindedTrains.Dequeue();
			}
			GrindedTrains.Enqueue(trainCollider);
		}
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.LandOnTrainInRow);
	}

	public unsafe void UpdateGroundTag(Character character)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_022d: Expected I, but got Obj
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_025c: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I
		//IL_029d: Unsupported input type for neg.
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected VT, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected VT, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected VT, but got Unknown
		//IL_02fd: Expected native int or pointer, but got VT
		//IL_0331: Expected VT, but got I
		//IL_032c: Expected native int or pointer, but got VT
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Ref, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected VT, but got Unknown
		//IL_002a: Expected Ref, but got VT
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected VT, but got Unknown
		//IL_0196: Expected Ref, but got VT
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected VT, but got Unknown
		//IL_015c: Expected Ref, but got VT
		object obj = default;
		Ray ray = (Ray)(obj - 160);
		object obj2 = ray + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		Vector3 position = character._characterRoot.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+48]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		object obj3 = ray - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v20 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		object obj4 = -0;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+68]");
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v20 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		object obj5 = -0;
		object obj6 = 0 - Vector3.upVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+60]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+38]");
		_ = 0;
		Ray ray2 = (Ray)(ray + 72);
		Vector3 origin = (Vector3)(ray + 40);
		Vector3 direction = (Vector3)(ray + 24);
		*(Ray*)(nint)ray2 = new Ray(origin, direction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+48]");
		((Ray*)(nint)ray)->m_Origin = (Vector3)0;
		if (!Physics.Raycast(ray, out *(RaycastHit*)(ray + 112)))
		{
			return;
		}
		RaycastHit raycastHit = (RaycastHit)(ray + 112);
		Collider collider = ((RaycastHit*)raycastHit)->collider;
		string text = collider.tag;
		if (text != null)
		{
			switch (text)
			{
			case "Station":
				currentRunPosition = RunPositions.station;
				break;
			case "HitMovingTrain":
			{
				currentRunPosition = RunPositions.movingTrain;
				RaycastHit raycastHit3 = (RaycastHit)(ray + 112);
				Collider collider3 = ((RaycastHit*)raycastHit3)->collider;
				LandedOnTrain(collider3);
				break;
			}
			case "HitTrain":
			{
				currentRunPosition = RunPositions.train;
				RaycastHit raycastHit2 = (RaycastHit)(ray + 112);
				Collider collider2 = ((RaycastHit*)raycastHit2)->collider;
				LandedOnTrain(collider2);
				break;
			}
			case "Ground":
			{
				currentRunPosition = RunPositions.ground;
				MissionsManager missionsManager = MissionsManager.Instance;
				missionsManager.RemoveProgressForThis(MissionTarget.LandOnTrainInRow);
				break;
			}
			}
		}
	}

	public override void HandleCriticalHit()
	{
		Character character = _character;
		character._characterCamera.Shake();
		_game.Die();
	}

	public unsafe override void HandleSwipe(SwipeDir swipeDir)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01aa: Expected VT, but got Obj
		//IL_01b8: Expected Obj, but got VT
		//IL_01de: Expected VT, but got Obj
		//IL_0214: Expected F4, but got I
		//IL_020f: Expected native int or pointer, but got VT
		//IL_0236: Expected F4, but got I
		//IL_0231: Expected native int or pointer, but got VT
		//IL_024b: Expected Obj, but got I
		//IL_0260: Invalid comparison between I and F4
		//IL_02a0: Expected F4, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		switch (swipeDir)
		{
		case SwipeDir.Left:
		{
			bool isTeleboard2 = _character.IsTeleboard;
			Game game2 = _game;
			if (isTeleboard2)
			{
				float duration3 = 20f / game2.__currentSpeed;
				_character.ChangeTrackBy(-1, duration3);
			}
			else
			{
				float duration4 = 30f / game2.__currentSpeed;
				_character.ChangeTrackBy(-1, duration4);
			}
			break;
		}
		case SwipeDir.Right:
		{
			bool isTeleboard = _character.IsTeleboard;
			Game game = _game;
			if (isTeleboard)
			{
				float duration = 20f / game.__currentSpeed;
				_character.ChangeTrackBy(1, duration);
			}
			else
			{
				float duration2 = 30f / game.__currentSpeed;
				_character.ChangeTrackBy(1, duration2);
			}
			break;
		}
		case SwipeDir.Up:
			Jump();
			break;
		case SwipeDir.Down:
		{
			_character.Roll();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			if (((RouteManager)val).IsCharacterInAnyRoute)
			{
				_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
				Vector3 currentTransformPosition = _character.CurrentTransformPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v21 (T)+3C]");
				Vector3 relativePosition = ((Route)0).GetRelativePosition(vector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				if (0f > 200f)
				{
					Character character = _character;
					Character character2 = _character;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					float num = character2.CalculateJumpVerticalSpeed(0f);
					float verticalSpeed = 0f - num;
					character.verticalSpeed = verticalSpeed;
				}
			}
			break;
		}
		}
	}

	private void Jump()
	{
		_character.Jump();
	}

	public void DebugSuperJump()
	{
		_character.DebugSuperJump();
	}

	public override void HandleDoubleTap()
	{
		if (Globals.DEBUG_DISABLE_HOVERBOARD)
		{
			return;
		}
		PlayerInfo playerInfo = PlayerInfo.Instance;
		int upgradeAmount = playerInfo.GetUpgradeAmount(PowerupType.hoverboard);
		if (upgradeAmount >= 1)
		{
			Game game = _game;
			CharacterModifierCollection modifiers = game._modifiers;
			if (!game._modifiers.IsActive(modifiers.hoverboard))
			{
				Game game2 = _game;
				CharacterModifierCollection modifiers2 = game2._modifiers;
				game2._modifiers.Add(modifiers2.hoverboard);
			}
		}
		else if (upgradeAmount == 0)
		{
			Game game3 = _game;
			CharacterModifierCollection modifiers3 = game3._modifiers;
			if (!game3._modifiers.IsActive(modifiers3.hoverboard))
			{
				Game game4 = _game;
				CharacterModifierCollection modifiers4 = game4._modifiers;
				Hoverboard hoverboard = modifiers4.hoverboard;
				if (!hoverboard._isInCooldown)
				{
					SellConsumablesHelper sellConsumablesHelper = SellConsumablesHelper.instance;
					sellConsumablesHelper.Sell(SellableConsumable.hoverboard);
				}
			}
		}
		Game game5 = _game;
		CharacterModifierCollection modifiers5 = game5._modifiers;
		Hoverboard hoverboard2 = modifiers5.hoverboard;
		if (!hoverboard2._isInCooldown)
		{
			bool successful = upgradeAmount > 0;
			LogEventForHoverboardStartAttempt(successful);
		}
	}

	private void LogEventForHoverboardStartAttempt(bool successful)
	{
		if (successful)
		{
		}
	}

	public RunningState()
	{
		_ = -4466444929337131008L;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S2_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Queue`1<UnityEngine.Collider>>>)+4] (should have been resolved before IL gen)");
		Queue<Collider> queue = default;
		Collider[] array = default;
		queue._array = array;
		GrindedTrains = queue;
		GrindedTrainsBufferSize = 5;
		base._002Ector();
	}

	private void _003CAwake_003Eb__26_0(Character.StumbleType _003Cp0_003E, Character.StumbleHorizontalHit _003Cp1_003E, Character.StumbleVerticalHit _003Cp2_003E, string _003Cp3_003E, bool _003Cp4_003E)
	{
		Character character = _character;
		character._characterCamera.Shake();
	}
}
