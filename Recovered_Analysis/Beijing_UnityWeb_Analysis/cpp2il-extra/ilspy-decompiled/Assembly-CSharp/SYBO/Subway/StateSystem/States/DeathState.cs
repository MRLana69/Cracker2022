using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Missions;
using SYBO.Common.StateSystem;
using SYBO.Subway.Routes;
using UI.Screens;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

namespace SYBO.Subway.StateSystem.States;

public class DeathState : State
{
	private sealed class _003CDelayGameOverScreen_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0048: Expected Obj, but got I4
				//IL_005c: Expected Obj, but got I4
				//IL_007a: Expected I, but got Obj
				//IL_0090: Expected Obj, but got I
				//IL_0187: Expected Obj, but got I4
				//IL_0195: Expected I, but got Obj
				//IL_01ab: Expected Obj, but got I
				//IL_01df: Expected Obj, but got I4
				//IL_01df: Expected Obj, but got I4
				//IL_00bb: Expected I, but got Obj
				//IL_0108: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v33 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						((UIScreenController)flag).PayWeeklyHuntIfNeeded();
						nint num3 = (nint)typeof(GameStateMachine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v22 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(GameStateMachine);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v29 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
						((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)100);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 12;
				obj3 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CDelayGameOverScreen_003Ed__8(int _003C_003E1__state)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0027: Expected Obj, but got I4
			object obj = this + 12;
			obj = _003C_003E1__state;
			object obj2 = this + 8;
			UnityEngine.Object obj3 = UnityEngine.Object.Instantiate((UnityEngine.Object)_003C_003E1__state);
			obj2 = obj3;
		}

		void IDisposable.Dispose()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected Obj, but got Unknown
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v21 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MessageEventArgs e = default;
			e._002Ector();
			object obj2 = e + 16;
			obj2 = e;
			_ = e.playerId;
			object obj3 = this + 8;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v15+8]");
			_ = 0;
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const float WaitTimeBeforeSkip = 0.5f;

	private const float WaitTimeBeforeScreen = 3f;

	private float _currentWaitTime;

	private bool _hasShownSaveMePopup;

	public DeathState(int id)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I4
		object obj = this + 16;
		Delegate obj2 = ((Delegate)_hasShownSaveMePopup).CombineImpl((Delegate)id);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj3 = default;
		obj = obj3;
	}

	public override void Enter(State fromState)
	{
		//IL_000a: Expected I4, but got Obj
		Id = (int)fromState;
	}

	public override void OnUpdate()
	{
		base.OnUpdate();
	}

	private void ReturnToTopMenu()
	{
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_046e: Expected Obj, but got I4
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04af: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_0543: Expected I, but got Obj
		//IL_0559: Expected Obj, but got I
		//IL_0587: Expected F4, but got I
		//IL_05a2: Expected Obj, but got I4
		//IL_05a2: Expected Obj, but got I4
		//IL_05a2: Expected Obj, but got I4
		//IL_00eb: Expected I, but got Obj
		//IL_0138: Expected I, but got Obj
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_064e: Expected I, but got Obj
		//IL_0664: Expected Obj, but got I
		//IL_01c6: Expected I, but got Obj
		//IL_0213: Expected I, but got Obj
		//IL_0229: Expected Obj, but got I
		//IL_0418: Expected I, but got Obj
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_0630: Expected Obj, but got I4
		//IL_0254: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 68;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		float unscaledTime = Time.unscaledTime;
		float currentWaitTime = _currentWaitTime + unscaledTime;
		_currentWaitTime = currentWaitTime;
		if (_currentWaitTime < 0.5f)
		{
			return;
		}
		nint num = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v27 (Il2CppClass<UI.Screens.PauseScreen>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(PauseScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v105 (Il2CppClass<UI.Screens.PauseScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(PauseScreen.pauseScreenIsShown ? 1u : 0u) == 0)
		{
			return;
		}
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v21 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v78 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		nint num5 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v29 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v74 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v26 (System.Boolean)+5C]");
		int num7 = Mathf.RoundToInt(0f);
		((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)29, (PersistentAwardProgress)num7, (Action<Award>)(-1));
		if (~(_hasShownSaveMePopup ? 1u : 0u) != 0)
		{
			nint num8 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v83 (Il2CppClass<SaveMeManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num9 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v101 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SSEventsManagerController instance2 = SSEventsManagerController.instance;
			if (instance2 != null)
			{
				nint num10 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v90 (Il2CppClass<UIScreenController>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num11 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v97 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag)._ActivateNextPopup("SaveMePopup");
				_hasShownSaveMePopup = true;
			}
		}
		if (!(_currentWaitTime < 3f))
		{
			((DieWhenGroundedState)this).OnUpdate();
		}
		else if (Input.GetKey(KeyCode.None))
		{
			((DieWhenGroundedState)this).OnUpdate();
		}
		else
		{
			bool touchSupported = Input.touchSupported;
			if ((touchSupported ? 1 : 0) >= (true ? 1 : 0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11712");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8187");
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+38]");
				_ = 0;
				object obj9 = obj - -64;
				object obj10 = obj2 - -64;
				obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+24]");
				if ((nint)0 != 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+24]");
					if ((nint)0 != 4)
					{
						goto IL_0640;
					}
				}
				((DieWhenGroundedState)this).OnUpdate();
			}
		}
		goto IL_0640;
		IL_0640:
		nint num12 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v46 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num13 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v52 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		_ = 0;
	}

	private IEnumerator DelayGameOverScreen()
	{
		return (IEnumerator)((StateMachine)(object)this).TryGetCurrentState<T>();
	}
}
