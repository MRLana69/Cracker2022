using Cpp2ILInjected;
using SYBO.Common.Automation;
using SYBO.Common.Benchmarking;
using SYBO.Common.StateSystem;
using SYBO.Subway.Inputs;
using SYBO.Subway.StateSystem.States;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.StateSystem;

public class GameStateMachine : StateMachine
{
	private static GameStateMachine _instance;

	public const int MenuStateId = 0;

	public const int EnterPlayStateId = 1;

	public const int RunningStateId = 2;

	public const int HeadstartStateId = 3;

	public const int JetpackStateId = 4;

	public const int PogostickStateId = 5;

	public const int ReturnToCheckpointStateId = 6;

	public const int DieWhenGroundedStateId = 7;

	public const int DeathStateId = 8;

	public const int MenuTriggerId = 100;

	public const int EnterPlayTriggerId = 101;

	public const int RunningTriggerId = 102;

	public const int HeadstartTriggerId = 103;

	public const int JetpackTriggerId = 104;

	public const int PogostickTriggerId = 105;

	public const int ReturnToCheckpointTriggerId = 106;

	public const int DieWhenGroundedTriggerId = 107;

	public const int DeathTriggerId = 108;

	public static GameStateMachine Instance
	{
		get
		{
			//IL_02af: Expected I, but got Obj
			//IL_02c5: Expected Obj, but got I
			//IL_0090: Expected I, but got Obj
			//IL_00a6: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_02f5: Expected I, but got Obj
			//IL_030b: Expected Obj, but got I
			//IL_00d1: Expected I, but got Obj
			//IL_0336: Expected I, but got Obj
			//IL_034c: Expected Obj, but got I
			//IL_011e: Expected I, but got Obj
			//IL_016b: Expected I, but got Obj
			//IL_0181: Expected Obj, but got I
			//IL_0262: Expected I, but got Obj
			//IL_0373: Expected Obj, but got I4
			//IL_0377: Expected VT, but got Obj
			//IL_0385: Expected I, but got Obj
			//IL_039b: Expected Obj, but got I
			//IL_03b8: Expected I, but got Obj
			//IL_03dc: Expected Obj, but got I
			//IL_03e4: Expected Obj, but got VT
			//IL_01ac: Expected I, but got Obj
			//IL_01f9: Expected I, but got Obj
			//IL_0229: Expected I, but got Obj
			//IL_024f: Expected I, but got Obj
			nint num = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ThemeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v75 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(ThemeManager._applicationQuitting ? 1u : 0u) == 0 && Application.platform != RuntimePlatform.OSXEditor)
			{
				return null;
			}
			nint num3 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(ThemeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v65 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (ThemeManager._instance != null)
			{
				nint num7 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v41 (Il2CppClass<Utils>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v61 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				_0021_00210 val = (_0021_00210)Utils.FindComponentInThisOrParents<T>((MonoBehaviour)1);
				nint num9 = (nint)typeof(ThemeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v48 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				bool flag = obj5 == null;
				nint num10 = (nint)typeof(ThemeManager);
				if (!flag)
				{
					nint num11 = (nint)typeof(ThemeManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v55 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num10 = (nint)typeof(ThemeManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num10 = (nint)typeof(ThemeManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ L0_v13 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+5C]");
				object obj6 = (nint)0 + (nint)4;
				obj6 = val;
			}
			nint num12 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v27 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num13 = (nint)typeof(ThemeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v34 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (GameStateMachine)(object)ThemeManager._instance;
		}
	}

	public static void Initialize()
	{
	}

	private unsafe GameStateMachine(IScheduler scheduler)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected VT, but got Unknown
		//IL_007e: Expected F4, but got Obj
		//IL_0079: Expected native int or pointer, but got VT
		//IL_0093: Expected F4, but got I
		//IL_008e: Expected native int or pointer, but got VT
		object obj = this + 16;
		if (scheduler != null)
		{
			_ = 0.0003f;
		}
		else
		{
			_ = -0.0003f;
		}
		object obj2 = this + 16;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v6+8]");
		_ = 0;
		Color color = (Color)(obj3 + 16);
		((Color*)(nint)color)->r = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Color*)(nint)color)->b = 0f;
		Shader.SetGlobalColor("_Distort", color);
	}

	public static void GenerateStateMachine()
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_instance == null)
		{
			nint num3 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v30 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v35 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameStateMachine._002Ecctor();
		}
		nint num5 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v23 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_instance.AddState(null);
	}

	public bool IsInGame()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		return false;
	}

	public void HandleSwipe(SwipeDir swipeDir)
	{
		EnterInitialState((int)swipeDir);
	}

	public void HandleDoubleTap()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got F4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		object obj = 0;
		_ = 0;
		obj = -0.0005f;
		_ = -0.0003f;
		_ = 0f;
		_ = 0f;
		object obj2 = obj + 16;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj3 = this + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void HandleCriticalHit()
	{
		InGameState inGameState = TryGetCurrentState<InGameState>();
		if (inGameState != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	static GameStateMachine()
	{
		//IL_0492: Expected I, but got Obj
		//IL_04a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		//IL_0098: Expected I4, but got Obj
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_04f0: Expected I4, but got Obj
		//IL_00e7: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I4
		//IL_0174: Expected I4, but got Obj
		//IL_0191: Expected Obj, but got I4
		//IL_019f: Expected I4, but got Obj
		//IL_01bc: Expected Obj, but got I4
		//IL_01cf: Expected I4, but got Obj
		//IL_01ec: Expected Obj, but got I4
		//IL_01fa: Expected I4, but got Obj
		//IL_0217: Expected Obj, but got I4
		//IL_022a: Expected I4, but got Obj
		//IL_0247: Expected Obj, but got I4
		//IL_0255: Expected I4, but got Obj
		//IL_0292: Expected Obj, but got I4
		//IL_0292: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I4
		//IL_02fc: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I4
		//IL_0311: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I4
		//IL_032f: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0362: Expected Obj, but got I4
		//IL_0362: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I4
		//IL_037b: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_03cc: Expected Obj, but got I4
		//IL_03e5: Expected Obj, but got I4
		//IL_03e5: Expected Obj, but got I4
		//IL_03e5: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I4
		//IL_03ff: Expected Obj, but got I4
		//IL_0414: Expected Obj, but got I4
		//IL_0414: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I4
		//IL_0432: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got I4
		//IL_044b: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I4
		//IL_047e: Expected Obj, but got I4
		//IL_047e: Expected Obj, but got I4
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v152 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_instance != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"StateMachineScheduler";
		MonobehaviourScheduler monobehaviourScheduler = gameObject.AddComponent<MonobehaviourScheduler>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameStateMachine gameStateMachine = default;
		gameStateMachine.HandleSwipe((SwipeDir)monobehaviourScheduler);
		nint num3 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v24 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v146 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_instance = gameStateMachine;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MenuState menuState = default;
		menuState.Enter(null);
		_instance.ActivateTrigger((int)menuState);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1;
		int id = default;
		_instance.ActivateTrigger(id);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RunningState runningState = default;
		runningState.Enter((State)2);
		_instance.ActivateTrigger((int)runningState);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HeadstartState headstartState = default;
		headstartState.Enter((State)3);
		_instance.ActivateTrigger((int)headstartState);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JetpackState jetpackState = default;
		jetpackState.Enter((State)4);
		_instance.ActivateTrigger((int)jetpackState);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PogostickState pogostickState = default;
		pogostickState.Enter((State)5);
		_instance.ActivateTrigger((int)pogostickState);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ReturnToCheckpointState returnToCheckpointState = default;
		returnToCheckpointState.Enter((State)6);
		_instance.ActivateTrigger((int)returnToCheckpointState);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DieWhenGroundedState dieWhenGroundedState = default;
		dieWhenGroundedState.Enter((State)7);
		_instance.ActivateTrigger((int)dieWhenGroundedState);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 8;
		int id2 = default;
		_instance.ActivateTrigger(id2);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])null, (IBenchmarkMetric[])1, (IMetricSampler[])101);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])1, (IBenchmarkMetric[])null, (IMetricSampler[])100);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])1, (IBenchmarkMetric[])2, (IMetricSampler[])102);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])2, (IBenchmarkMetric[])3, (IMetricSampler[])103);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])3, (IBenchmarkMetric[])2, (IMetricSampler[])102);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])3, (IBenchmarkMetric[])null, (IMetricSampler[])100);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])2, (IBenchmarkMetric[])4, (IMetricSampler[])104);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])4, (IBenchmarkMetric[])2, (IMetricSampler[])102);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])4, (IBenchmarkMetric[])null, (IMetricSampler[])100);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])2, (IBenchmarkMetric[])5, (IMetricSampler[])105);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])5, (IBenchmarkMetric[])2, (IMetricSampler[])102);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])5, (IBenchmarkMetric[])null, (IMetricSampler[])100);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])2, (IBenchmarkMetric[])6, (IMetricSampler[])106);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])6, (IBenchmarkMetric[])2, (IMetricSampler[])102);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])6, (IBenchmarkMetric[])null, (IMetricSampler[])100);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])2, (IBenchmarkMetric[])null, (IMetricSampler[])100);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])2, (IBenchmarkMetric[])7, (IMetricSampler[])107);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])7, (IBenchmarkMetric[])8, (IMetricSampler[])108);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])8, (IBenchmarkMetric[])2, (IMetricSampler[])102);
		((Benchmark)(object)_instance)._002Ector((IAutomationStep[])8, (IBenchmarkMetric[])null, (IMetricSampler[])100);
	}
}
