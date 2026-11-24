using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cloud.Internal;
using Cpp2ILInjected;
using Info;
using SYBO.Common.StateSystem;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.StateSystem.States.Settings;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States;

public abstract class FlyingState : InGameState
{
	private const float MaxJetpackFlightDurationIncreaseSeconds = 4f;

	private FlyingStateSettings _settings;

	public Action OnStart;

	public Action OnStop;

	public Action OnFlyAheadStart;

	public Action<float> OnFlyAheadUpdate;

	private ActivePowerup _powerup;

	private List<Action> _startHandlers;

	protected float _flyAheadDistance;

	protected float _speedPositionAdjustment;

	private float _startGamePositionZ;

	protected int _targetGamePositionZ;

	private float _startY;

	private Vector3 _startCameraOffset;

	private float _startCameraAimOffset;

	private SmoothDampFloat _smoothCameraX;

	private Vector3 _cameraPositionStart;

	private Vector3 _cameraTargetStart;

	private bool _hasExploded;

	protected FlyingStateSettings FlyingStateSettings
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			FlyingStateSettings result = default;
			return result;
		}
	}

	protected abstract UpgradeType UpgradeType { get; }

	public int TargetGamePositionZ
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_settings;
		}
	}

	public FlyingState(int id)
	{
		//IL_02e4: Expected I, but got Obj
		//IL_02fa: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got F4
		//IL_0419: Expected Obj, but got I
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_045e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00bd: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00fe: Expected I, but got Obj
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_0256: Expected I, but got Obj
		//IL_026c: Expected Obj, but got I
		//IL_038c: Expected I, but got Obj
		//IL_03a2: Expected Obj, but got I
		//IL_018c: Expected I, but got Obj
		//IL_0297: Expected I, but got Obj
		//IL_01d9: Expected I, but got Obj
		nint num = (nint)typeof(CharacterRendering);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v77 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterCamera instance = CharacterCamera.Instance;
		MeshRenderer meshCoinMagnet = ((CharacterModel)instance._previousCameraEndXRotation).MeshCoinMagnet;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		object obj6 = obj7 + 12;
		object obj8 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			object obj9 = obj7 + 16;
			object obj10 = obj8 << 2;
			object obj11 = obj9 + obj10;
			((ParticleSystem)obj11).Clear();
			object obj12 = obj8 + 1;
			obj8 = obj12;
		}
		((Camera)(object)_game).orthographicSize = 68f;
		nint num4 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v23 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num5 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v67 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v28 (System.Boolean)+43]");
		if ((nint)0 != 0)
		{
			nint num6 = (nint)typeof(FollowingGuard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v46 (Il2CppClass<FollowingGuard>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num7 = (nint)typeof(FollowingGuard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v63 (Il2CppClass<FollowingGuard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IEnumerator enumerator = HouseKeeper.InitAuthAndCloudSave();
			((FollowingGuard)enumerator).MuteProximityLoop();
			nint num8 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v53 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num9 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v59 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated2 = Game.IsInstantiated;
			_ = 0;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L1 (System.Int32)+8]");
		if ((nint)0 != 2)
		{
			return;
		}
		nint num10 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v35 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num11 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v41 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated3 = Game.IsInstantiated;
		_ = 1;
	}

	public override void Enter(State fromState)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00e7: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0091: Expected I4, but got Obj
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Action> list = default;
		list._002Ector();
		object obj = this + 48;
		obj = list;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 24;
		Vector3 one = Vector3.one;
		object obj5 = obj4 + 36;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19+8]");
		_ = 0;
		object obj6 = this + 72;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21+8]");
		_ = 0;
		object obj7 = obj4 + 12;
		Vector3 one2 = Vector3.one;
		obj5 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v27+8]");
		_ = 0;
		object obj8 = this + 92;
		obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21+8]");
		_ = 0;
		Vector3 one3 = Vector3.one;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj9 = this + 104;
		obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21+8]");
		_ = 0;
		base.HandleSwipe((SwipeDir)fromState);
		object obj10 = this + 24;
		_0021_00210[] array = (_0021_00210[])(object)NGUITools.FindActive<T>();
		obj10 = array;
	}

	public unsafe override void OnUpdate()
	{
		//IL_01a9: Expected I4, but got Obj
		//IL_01b6: Expected Obj, but got I4
		//IL_01ca: Expected I4, but got Obj
		//IL_000e: Expected Obj, but got I4
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_003f: Expected I4, but got Obj
		//IL_0159: Expected I, but got Obj
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_01f7: Expected F4, but got Obj
		//IL_00cb: Expected I, but got Obj
		bool flag = ((Animation)(object)_character).Play((PlayMode)"introRun");
		float normalizedTime = ((AnimationState)flag).normalizedTime;
		bool flag2 = ((Animation)(object)_character).Play((PlayMode)"introRun");
		if (((AnimationState)flag2).wrapMode != WrapMode.Default)
		{
			bool flag3 = ((Animation)(object)_character).Play((PlayMode)"introRun");
			float distance = (flag3 ? ((RaycastHit*)1) : ((RaycastHit*)null))->distance;
			if (normalizedTime < distance)
			{
				nint num = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S2_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float t = normalizedTime * 0.75f;
				float orthographicSize = Mathf.LerpUnclamped((float)_characterCamera, 68f, t);
				((Camera)(object)_game).orthographicSize = orthographicSize;
				return;
			}
		}
		nint num3 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v17 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)102);
	}

	private void UpdateFlyAhead(float remainingRatio)
	{
		//IL_000a: Expected Obj, but got F4
		_settings = (FlyingStateSettings)remainingRatio;
	}

	protected unsafe virtual void UpdateFlying(float remainingRatio)
	{
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Expected Obj, but got Unknown
		//IL_09f4: Expected Obj, but got I4
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected Obj, but got Unknown
		//IL_0a11: Expected Obj, but got I4
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Expected Obj, but got Unknown
		//IL_0a2e: Expected Obj, but got I4
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected Obj, but got Unknown
		//IL_0a4b: Expected Obj, but got I4
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5f: Expected Obj, but got Unknown
		//IL_0a68: Expected Obj, but got I4
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected Obj, but got Unknown
		//IL_0a85: Expected Obj, but got I4
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected Obj, but got Unknown
		//IL_0aa2: Expected Obj, but got I4
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected Obj, but got Unknown
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Expected Obj, but got Unknown
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Expected Obj, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected Obj, but got Unknown
		//IL_0b24: Expected I, but got Obj
		//IL_0b3a: Expected Obj, but got I
		//IL_0c57: Expected I, but got Obj
		//IL_0c6d: Expected Obj, but got I
		//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected VT, but got Unknown
		//IL_0b72: Expected F4, but got Obj
		//IL_0b6d: Expected native int or pointer, but got VT
		//IL_0b87: Expected F4, but got I
		//IL_0b82: Expected native int or pointer, but got VT
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Expected VT, but got Unknown
		//IL_0ba2: Expected F4, but got Obj
		//IL_0b9d: Expected native int or pointer, but got VT
		//IL_0bb7: Expected F4, but got I
		//IL_0bb2: Expected native int or pointer, but got VT
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_010e: Expected F4, but got Obj
		//IL_0109: Expected native int or pointer, but got VT
		//IL_0123: Expected F4, but got I
		//IL_011e: Expected native int or pointer, but got VT
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0163: Expected F4, but got Obj
		//IL_015e: Expected native int or pointer, but got VT
		//IL_0178: Expected F4, but got I
		//IL_0173: Expected native int or pointer, but got VT
		//IL_0185: Expected F4, but got Obj
		//IL_0180: Expected native int or pointer, but got VT
		//IL_019a: Expected F4, but got I
		//IL_0195: Expected native int or pointer, but got VT
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01cb: Expected F4, but got Obj
		//IL_01c6: Expected native int or pointer, but got VT
		//IL_01e0: Expected F4, but got I
		//IL_01db: Expected native int or pointer, but got VT
		//IL_01ef: Expected Obj, but got VT
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0258: Expected F4, but got I
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_02ac: Expected F4, but got Obj
		//IL_02a7: Expected native int or pointer, but got VT
		//IL_02c1: Expected F4, but got I
		//IL_02bc: Expected native int or pointer, but got VT
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02ed: Expected F4, but got Obj
		//IL_02e8: Expected native int or pointer, but got VT
		//IL_02ff: Expected F4, but got Obj
		//IL_02fa: Expected native int or pointer, but got VT
		//IL_030c: Expected F4, but got Obj
		//IL_0307: Expected native int or pointer, but got VT
		//IL_0321: Expected F4, but got I
		//IL_031c: Expected native int or pointer, but got VT
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0367: Expected F4, but got Obj
		//IL_0362: Expected native int or pointer, but got VT
		//IL_037c: Expected F4, but got I
		//IL_0377: Expected native int or pointer, but got VT
		//IL_038b: Expected Obj, but got VT
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04c1: Expected Obj, but got I4
		//IL_04d4: Expected Obj, but got F4
		//IL_04fb: Expected F4, but got Obj
		//IL_04f6: Expected native int or pointer, but got VT
		//IL_0510: Expected F4, but got I
		//IL_050b: Expected native int or pointer, but got VT
		//IL_051d: Expected F4, but got Obj
		//IL_0518: Expected native int or pointer, but got VT
		//IL_0532: Expected F4, but got I
		//IL_052d: Expected native int or pointer, but got VT
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Obj, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected Obj, but got Unknown
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected Obj, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05cd: Expected Obj, but got I4
		//IL_05e0: Expected Obj, but got F4
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected Obj, but got Unknown
		//IL_0623: Expected F4, but got Obj
		//IL_061e: Expected native int or pointer, but got VT
		//IL_0638: Expected F4, but got I
		//IL_0633: Expected native int or pointer, but got VT
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_0664: Expected F4, but got Obj
		//IL_065f: Expected native int or pointer, but got VT
		//IL_0679: Expected F4, but got I
		//IL_0674: Expected native int or pointer, but got VT
		//IL_0686: Expected F4, but got Obj
		//IL_0681: Expected native int or pointer, but got VT
		//IL_069b: Expected F4, but got I
		//IL_0696: Expected native int or pointer, but got VT
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected Obj, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected Obj, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected Obj, but got Unknown
		//IL_072f: Expected F4, but got Obj
		//IL_072a: Expected native int or pointer, but got VT
		//IL_0744: Expected F4, but got I
		//IL_073f: Expected native int or pointer, but got VT
		//IL_0751: Expected F4, but got Obj
		//IL_074c: Expected native int or pointer, but got VT
		//IL_0766: Expected F4, but got I
		//IL_0761: Expected native int or pointer, but got VT
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected Obj, but got Unknown
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got Unknown
		//IL_07de: Expected F4, but got Obj
		//IL_07d9: Expected native int or pointer, but got VT
		//IL_07f3: Expected F4, but got I
		//IL_07ee: Expected native int or pointer, but got VT
		//IL_0800: Expected F4, but got Obj
		//IL_07fb: Expected native int or pointer, but got VT
		//IL_0815: Expected F4, but got I
		//IL_0810: Expected native int or pointer, but got VT
		//IL_0856: Expected Obj, but got F4
		//IL_086d: Expected Obj, but got F4
		//IL_087a: Expected F4, but got Obj
		//IL_0875: Expected native int or pointer, but got VT
		//IL_088f: Expected F4, but got I
		//IL_088a: Expected native int or pointer, but got VT
		//IL_08ab: Expected F4, but got Obj
		//IL_08a6: Expected native int or pointer, but got VT
		//IL_08c0: Expected F4, but got I
		//IL_08bb: Expected native int or pointer, but got VT
		//IL_08cf: Expected Obj, but got VT
		//IL_0933: Expected F4, but got Obj
		//IL_092e: Expected native int or pointer, but got VT
		//IL_0948: Expected F4, but got I
		//IL_0943: Expected native int or pointer, but got VT
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected Obj, but got Unknown
		//IL_0965: Invalid comparison between F4 and Obj
		object obj2 = default;
		object obj = obj2 + 408;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 396;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 384;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 372;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 360;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 348;
		obj7 = 0;
		_ = 0;
		object obj8 = obj2 + 336;
		obj8 = 0;
		_ = 0;
		object obj9 = obj2 + 324;
		object obj10 = this + 72;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v26+8]");
		_ = 0;
		object obj11 = obj2 + 312;
		CharacterCamera characterCamera = _characterCamera;
		object obj12 = characterCamera._currentCameraData + 44;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v34+8]");
		_ = 0;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v36 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v218 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float t = Mathf.InverseLerp(0f, 1f, remainingRatio);
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v214 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 420);
		((Vector3*)(nint)vector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 432);
		((Vector3*)(nint)vector2)->x = (float)obj11;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v33+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj15 = obj2 + 300;
		Vector3 vector4 = Vector3.LerpUnclamped(vector, vector2, t);
		obj = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v54+8]");
		_ = 0;
		FlyingStateSettings settings = _settings;
		float t2 = Mathf.InverseLerp(0f, 1f, remainingRatio);
		float num5 = Mathf.LerpUnclamped(_startCameraAimOffset, settings._cameraAimOffsetY, t2);
		object obj16 = obj2 + 288;
		object obj17 = _character + 236;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S2_v10+8]");
		_ = 0;
		Game game = _game;
		float unscaledTime = Time.unscaledTime;
		object obj18 = obj2 + 276;
		Vector3 back = Vector3.back;
		((Vector3*)(nint)vector2)->x = (float)obj18;
		Vector3 vector5 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v69+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj19 = obj2 + 264;
		float angle = game.__currentSpeed * unscaledTime;
		Quaternion quaternion = Quaternion.AngleAxis(angle, vector2);
		((Vector3*)(nint)vector)->x = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v61+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj19;
		Vector3 vector6 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S1_v73+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		object obj20 = obj2 + 252;
		Vector3 vector7 = vector - vector2;
		((Vector3*)(nint)vector2)->x = (float)obj20;
		Vector3 vector8 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v79+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		_character.UpdateGroundTag((Character)vector2);
		Character character = _character;
		object obj21 = obj2 + 240;
		object obj22 = _character + 236;
		obj21 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v86+8]");
		_ = 0;
		RouteBuilder routeBuilder = (RouteBuilder)(obj2 + 228);
		float x = character.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v66+8]");
		routeBuilder.HideLogic(x, 0f);
		object obj23 = obj2 + 216;
		Vector3 down = Vector3.down;
		FlyingStateSettings settings2 = _settings;
		float num6 = Mathf.InverseLerp(_startY, settings2._flyHeight, remainingRatio);
		((Vector3*)(nint)vector2)->x = (float)obj23;
		Vector3 vector9 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v71+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		object obj24 = obj2 + 204;
		Vector3 vector10 = vector2 / num6;
		((Vector3*)(nint)vector)->x = (float)routeBuilder;
		((Vector3*)(nint)vector)->z = (float)routeBuilder.OnCompletedLayingSections;
		((Vector3*)(nint)vector2)->x = (float)obj24;
		Vector3 vector11 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v78+8]");
		((Vector3*)(nint)vector11)->z = 0f;
		object obj25 = obj2 + 192;
		Vector3 vector12 = vector - vector2;
		obj3 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v84+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Vector3 vector13 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		_character.UpdateGroundTag((Character)vector2);
		((SmoothDampVector3)(object)_smoothCameraX).Update();
		SmoothDampFloat smoothCameraX = _smoothCameraX;
		object obj26 = obj2 + 180;
		object obj27 = _character + 236;
		obj26 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S2_v52+8]");
		_ = 0;
		float target = (float)obj26 * 0.9f;
		smoothCameraX._target = target;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj28 = obj2 + 168;
		object obj29 = _character + 248;
		obj28 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v134+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v96+8]");
		_ = 0;
		SmoothDampFloat smoothCameraX2 = _smoothCameraX;
		object obj30 = obj2 + 156;
		obj30 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj31 = obj2 + 144;
		object obj32 = _character + 248;
		obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S1_v148+8]");
		_ = 0;
		object obj33 = obj2 + 132;
		obj33 = 0;
		_ = 0;
		obj33 = smoothCameraX2._value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S0_v103+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v108+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S0_v113+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Vector3 vector14 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector14)->z = 0f;
		object obj34 = obj2 + 120;
		Vector3 vector15 = vector - vector2;
		obj5 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v123+8]");
		_ = 0;
		SmoothDampFloat smoothCameraX3 = _smoothCameraX;
		object obj35 = obj2 + 108;
		obj35 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj36 = obj2 + 96;
		obj36 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj37 = obj2 + 84;
		obj37 = 0;
		_ = 0;
		obj37 = smoothCameraX3._value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S0_v130+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S0_v135+8]");
		_ = 0;
		object obj38 = obj2 + 72;
		Vector3 down2 = Vector3.down;
		((Vector3*)(nint)vector2)->x = (float)obj38;
		Vector3 vector16 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v146+8]");
		((Vector3*)(nint)vector16)->z = 0f;
		object obj39 = obj2 + 60;
		Vector3 vector17 = vector2 / num5;
		((Vector3*)(nint)vector)->x = (float)obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v140+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj39;
		Vector3 vector18 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S0_v150+8]");
		((Vector3*)(nint)vector18)->z = 0f;
		object obj40 = obj2 + 48;
		Vector3 vector19 = vector - vector2;
		obj6 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S0_v156+8]");
		_ = 0;
		FlyingStateSettings settings3 = _settings;
		float t3 = PlayerPrefs.GetFloat((string)(object)settings3._flyAheadCameraMovement, remainingRatio);
		object obj41 = obj2 + 36;
		object obj42 = this + 92;
		obj41 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S1_v213+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S0_v164+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj5;
		Vector3 vector20 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		((Vector3*)(nint)vector20)->z = 0f;
		object obj43 = obj2 + 24;
		Vector3 vector21 = Vector3.LerpUnclamped(vector, vector2, t3);
		obj7 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ S0_v171+8]");
		_ = 0;
		object obj44 = obj2 + 12;
		object obj45 = this + 104;
		obj44 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S1_v233+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ S0_v175+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Vector3 vector22 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
		((Vector3*)(nint)vector22)->z = 0f;
		Vector3 vector23 = Vector3.LerpUnclamped(vector, vector2, t3);
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		SmoothDampFloat smoothCameraX4 = _smoothCameraX;
		obj7 = smoothCameraX4._value;
		SmoothDampFloat smoothCameraX5 = _smoothCameraX;
		obj8 = smoothCameraX5._value;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector24 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
		((Vector3*)(nint)vector24)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7516");
		((Vector3*)(nint)vector2)->x = (float)obj8;
		Vector3 vector25 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
		((Vector3*)(nint)vector25)->z = 0f;
		_characterCamera.SetCameraDataForcefully((CameraData)vector2);
		if (OnFlyAheadUpdate != null)
		{
			OnFlyAheadUpdate(remainingRatio);
		}
		if (~(_hasExploded ? 1u : 0u) == 0)
		{
			return;
		}
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Vector3 vector26 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector26)->z = 0f;
		object obj46 = _character - -64;
		float y = vector2.y;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)y) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46))
		{
			Character character2 = _character;
			if (~(character2._isInsideSubway ? 1u : 0u) == 0)
			{
				Character character3 = _character;
				character3.TurboHeadstartParticleSystem.Stop();
				_hasExploded = true;
				_character.Jump();
			}
		}
	}

	private float GetRatioRemainingForFlyAhead()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0165: Unsupported input type for neg.
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got I
		object obj = -1;
		object obj2 = default;
		object obj13 = default;
		object obj15 = default;
		while (true)
		{
			Game game = _game;
			Action onStageMenuSequence = game.OnStageMenuSequence;
			if ((nint)obj2 >= (nint)((Delegate)onStageMenuSequence).invoke_impl)
			{
				break;
			}
			Game game2 = _game;
			object obj3 = game2.OnStageMenuSequence + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v25+1C]");
			if (0 > (nint)obj)
			{
				Game game3 = _game;
				object obj7 = game3.OnStageMenuSequence + 16;
				object obj8 = obj2 << 2;
				object obj9 = obj7 + obj8;
				object obj10 = obj9;
				Game game4 = _game;
				object obj11 = game4.OnStageMenuSequence + 16;
				object obj12 = obj2 << 2;
				obj13 = obj11 + obj12;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v36+1C]");
				obj = 0;
			}
			obj2 = obj15 + 1;
		}
		if (obj13 != null)
		{
			Game game5 = _game;
			object obj16 = obj13 + 32;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v10+8]");
			_ = 0;
			object obj18 = 0 - game5.OnPauseChange;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v43+1C]");
			object obj19 = 0 * obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			object obj20 = obj19 + 0;
			return 1000f + (float)obj20;
		}
		return 1000f;
	}

	private float GetRatioRemainingForFlying()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = _character + 236;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S1_v4+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float num = 0f - _startGamePositionZ;
		return num / _flyAheadDistance;
	}

	protected virtual float GetFlyHeight()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		object obj = _character + 236;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S1_v4+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float num = 0f - _startGamePositionZ;
		float num2 = num - _flyAheadDistance;
		object obj3 = this - -64;
		float num3 = (float)obj3 - _startGamePositionZ;
		float num4 = num3 - _flyAheadDistance;
		return num2 / num4;
	}

	public override void HandleSwipe(SwipeDir swipeDir)
	{
		//IL_0634: Expected I, but got Obj
		//IL_064a: Expected Obj, but got I
		//IL_09a5: Expected Obj, but got I4
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		nint num = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v181 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		((GamePositionRoot)isRestricted).RemoveLock(this);
		object obj2 = this + 44;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string clipName = default;
		bool flag = Globals.TryAddAnimationEvent((Animation)(object)privacyPolicyUrl, clipName, null);
		obj2 = flag;
		Vector3 cameraPositionValue = ((CharacterCamera)2).CameraPositionValue;
		Character character = _character;
		character._characterRendering.Character_OnEnterRoute();
		throw new NullReferenceException();
	}

	public override void Leave(State toState)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = toState - 2;
		if ((nint)toState != 2)
		{
			if ((nint)obj == 1)
			{
				FlyingStateSettings settings = _settings;
				Game game = _game;
				float duration = settings._characterChangeTrackLength / game.__currentSpeed;
				_character.ForceChangeTrack(1, duration);
			}
		}
		else
		{
			FlyingStateSettings settings2 = _settings;
			Game game2 = _game;
			float duration2 = settings2._characterChangeTrackLength / game2.__currentSpeed;
			_character.ForceChangeTrack(-1, duration2);
		}
	}

	public unsafe void RegisterStartHandler(Action handler)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00db: Expected Obj, but got I4
		//IL_0047: Expected I, but got Obj
		//IL_005d: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_0088: Expected I, but got Obj
		object obj = this - -64;
		obj = 0;
		_characterCamera.RevertFOV();
		Character character = _character;
		character._characterController.get_velocity_Injected(out *(Vector3*)1);
		Character character2 = _character;
		float fOVForAspectRatio = ((CharacterCamera)(object)_character).GetFOVForAspectRatio(0f);
		character2.verticalSpeed = fOVForAspectRatio;
		Game game = _game;
		game._modifiers.Reset();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E03");
		nint num = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v25 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		((BackgroundLayer)isRestricted)._002Ector((BackgroundLayer)(object)this);
	}

	protected float GetFlyingDuration()
	{
		FlyingStateSettings settings = _settings;
		return settings._flyHeight;
	}

	public float GetTotalRemainingRatio()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		ActivePowerup powerup = _powerup;
		nint num = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v11 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float recommendationEvaluation = ((CloudSaveConflictResolver)powerup.type).recommendationEvaluation;
		FlyingStateSettings settings = _settings;
		return recommendationEvaluation - settings._flyAheadDuration;
	}

	protected abstract float GetFlyingSpeed();

	private void NotifyOnStart()
	{
		//IL_00c5: Expected I, but got Obj
		//IL_00db: Expected Obj, but got I
		//IL_0195: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_0106: Expected I, but got Obj
		base.HandleCriticalHit();
		float ratioRemainingForFlying = GetRatioRemainingForFlying();
		if (ratioRemainingForFlying < 1f)
		{
			UpdateFlying(ratioRemainingForFlying);
			return;
		}
		Character character = _character;
		if (!character.CharacterTrigger.isTrigger)
		{
			Character character2 = _character;
			character2.CharacterTrigger.isTrigger = true;
		}
		float flyHeight = GetFlyHeight();
		if (flyHeight < 1f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			return;
		}
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v20 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v26 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)102);
	}

	private void NotifyOnStop()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (OnStart != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 70)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
