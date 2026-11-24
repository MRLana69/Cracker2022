using System;
using Cpp2ILInjected;
using SYBO.Common.Managers;
using SYBO.Common.StateSystem;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States;

public class EnterPlayState(int id) : State
{
	private const string EnterPlayAnimationName = "introRun";

	private const string EnterPlayCameraAnimationName = "startPan";

	private Camera _camera;

	private Animation _characterAnimation = null;

	private float _fovStart;

	public override void Enter(State fromState)
	{
		//IL_000a: Expected I4, but got Obj
		Id = (int)fromState;
	}

	public unsafe override void OnUpdate()
	{
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I
		//IL_010e: Invalid comparison between Obj and F4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0136: Expected VT, but got Obj
		//IL_029a: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_01b9: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_02c3: Expected Obj, but got I4
		//IL_02c3: Expected Obj, but got I4
		//IL_01fa: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		Camera camera = _camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Camera)+B8]");
		string text = ((PhysicsScene*)null)->ToString();
		if (text != null)
		{
			nint num = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v52 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v58 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
			((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)108);
			return;
		}
		object obj4 = _camera + 236;
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v8+8]");
		_ = 0;
		((Character)(object)_camera).MoveForward();
		object obj5 = _camera + 236;
		obj2 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		object obj6 = num3 - 0;
		if (obj6 == (object)0f)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (realtimeSinceStartup != 0f)
			{
				Animation characterAnimation = (Animation)(_characterAnimation + 1);
				_characterAnimation = characterAnimation;
				if ((nint)_characterAnimation <= 3)
				{
					return;
				}
				nint num4 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v41 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num5 = (nint)typeof(GameStateMachine);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v47 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
				((StateMachine)useBenchmarkRoute2).Trigger_OnTriggered((StateMachine.Trigger)108);
				return;
			}
		}
		_characterAnimation = null;
	}

	public override void Leave(State toState)
	{
		//IL_03b2: Expected VT, but got Obj
		//IL_03bb: Expected VT, but got Obj
		//IL_03d0: Expected F4, but got I
		//IL_03d0: Expected Obj, but got VT
		//IL_002a: Expected I, but got Obj
		//IL_0040: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_006b: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_0126: Expected VT, but got Obj
		//IL_0139: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got VT
		//IL_0147: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_0433: Expected I, but got Obj
		//IL_0449: Expected Obj, but got I
		//IL_0466: Expected I, but got Obj
		//IL_048d: Expected Obj, but got VT
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_0188: Expected I, but got Obj
		//IL_023e: Expected I, but got Obj
		//IL_0254: Expected Obj, but got I
		//IL_01d5: Expected I, but got Obj
		//IL_0205: Expected I, but got Obj
		//IL_04fb: Expected Obj, but got I4
		//IL_02d9: Expected Obj, but got I4
		//IL_027f: Expected I, but got Obj
		//IL_022b: Expected I, but got Obj
		//IL_02ff: Expected I, but got Obj
		//IL_0315: Expected Obj, but got I
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0542: Expected Obj, but got I
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_038f: Expected Obj, but got I
		//IL_0340: Expected I, but got Obj
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (T)+14]");
		((TimeScaleManager)val).TimeScaleInMenuDefault = 0f;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		((GameStats)(object)privacyPolicyUrl).ResetRun();
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v84 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19 (System.Boolean)+8C]");
		((CharacterModifierCollection)0).ExpireSoon();
		bool isInstantiated2 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22 (System.Boolean)+8C]");
		((CharacterModifierCollection)0).StopWithNoEnding();
		bool isInstantiated3 = Game.IsInstantiated;
		object obj2 = (isInstantiated3 ? 1 : 0) - -64;
		obj2 = 0;
		bool isInstantiated4 = Game.IsInstantiated;
		_ = 1;
		bool isInstantiated5 = Game.IsInstantiated;
		((Game)isInstantiated5)._002Ector();
		bool isInstantiated6 = Game.IsInstantiated;
		((Game)isInstantiated6).DisableEnemy();
		_00210 val3 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		((AudioStateLoop)val3).PlayLoop((AudioSource)1);
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v37 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v80 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		CharacterModel characterModel = instance._characterModel;
		int layer = characterModel._rigPrefab.layer;
		nint num5 = (nint)typeof(CharacterPickupParticles);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v20 (Il2CppClass<CharacterPickupParticles>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag = obj4 == null;
		nint num6 = (nint)typeof(CharacterPickupParticles);
		if (!flag)
		{
			nint num7 = (nint)typeof(CharacterPickupParticles);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v54 (Il2CppClass<CharacterPickupParticles>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num6 = (nint)typeof(CharacterPickupParticles);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num6 = (nint)typeof(CharacterPickupParticles);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ L1_v4 (Il2CppClass<CharacterPickupParticles>)+5C]");
		nint num8 = 0;
		object obj5 = CharacterPickupParticles.coinEfxOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S2_v5 (Il2CppStaticFields<CharacterPickupParticles>)+8]");
		_ = 0;
		Transform transform = (Transform)(obj5 + 12);
		transform = (Transform)obj5;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		CharacterRendering instance2 = CharacterRendering.Instance;
		((Character)(object)instance2).Revive();
		nint num9 = (nint)typeof(CharacterCamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v49 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v76 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		GameObject gameObject = ((Component)selectedBenchmarkIndex).gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		Animation component = parentInternal.GetComponent<Animation>();
		component.tag = (string)1;
		AudioSource.PlayOneShotHelper((AudioSource)(object)component, (AudioClip)(object)"startPan", 0.2f);
		nint num11 = (nint)typeof(CharacterRendering);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v60 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v72 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = this + 16;
		CharacterCamera instance3 = CharacterCamera.Instance;
		Vector3 diff = instance3._diff;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v43 (UnityEngine.Vector3)+10]");
		obj8 = 0;
		AudioSource.PlayOneShotHelper((AudioSource)(object)_characterAnimation, (AudioClip)(object)"introRun", 0.2f);
		object obj9 = this + 12;
		int selectedBenchmarkIndex2 = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v49 (System.Int32)+6C]");
		obj9 = 0;
		float orthographicSize = _camera.orthographicSize;
		_fovStart = orthographicSize;
	}
}
