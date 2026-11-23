using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Subway;
using UnityEngine;

namespace Kiloo.Analytics;

internal static class RunTracker
{
	private sealed class _003CRunEnded_003Ed__24(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<Event> onLogReady;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Action<Event> action = onLogReady;
					Event runEndedData = GetRunEndedData();
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S0_v20 (System.Action`1<Kiloo.Analytics.Event>)+C] (should have been resolved before IL gen)");
					_runEnded = null;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_ = _isReadyToLog;
				object obj3 = obj + 15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object obj4 = default;
				_003C_003E2__current = obj4;
				_003C_003E1__state = 1;
			}
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

	private sealed class _003CTrackRunLengthInSeconds_003Ed__31(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				float deltaTime = Time.deltaTime;
				float runLengthInSeconds = _runLengthInSeconds + deltaTime;
				_runLengthInSeconds = runLengthInSeconds;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			_003C_003E2__current = null;
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

	private static bool _initialized;

	private static bool _initialMenuScreenShown;

	private static float _runLengthInSeconds;

	private static IEnumerator _runLengthTracker;

	private static int _saveMeCountInRun;

	private static bool _hasUsedSaveMe;

	private static float? _runLengthUntilFirstSaveMe;

	private static int _baseScoreMultiplierAtStartOfRun;

	private static int _hoverboardCountInRun;

	private static bool _runDidEnd;

	private static bool _runWasAborted;

	private static bool _isReadyToLog;

	private static IEnumerator _runEnded;

	private static Action _003C_003Ef__mg_0024cache0;

	private static Action _003C_003Ef__mg_0024cache1;

	private static Action<bool> _003C_003Ef__mg_0024cache2;

	private static Action _003C_003Ef__mg_0024cache3;

	private static Revive.OnReviveDelegate _003C_003Ef__mg_0024cache4;

	private static Action<PowerupType> _003C_003Ef__mg_0024cache5;

	private static Revive.OnReviveDelegate _003C_003Ef__mg_0024cache6;

	private static Action<PowerupType> _003C_003Ef__mg_0024cache7;

	private static Action<PowerupType> _003C_003Ef__mg_0024cache8;

	private static Revive.OnReviveDelegate _003C_003Ef__mg_0024cache9;

	public static void LogRunEndedData(Action<Event> onLogReady)
	{
		if (_runEnded == null)
		{
			IEnumerator runEnded = RunEnded(onLogReady);
			_runEnded = runEnded;
			Coroutine coroutine = CoroutineUtil.StartCoroutine(_runEnded);
		}
	}

	private static IEnumerator RunEnded(Action<Event> onLogReady)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe static Event GetRunEndedData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_058f: Expected Obj, but got I4
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I
		//IL_0087: Invalid comparison between VT and I4
		//IL_00e4: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got I
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_0691: Expected Obj, but got I
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected Obj, but got Unknown
		//IL_06d5: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected VT, but got I
		//IL_00c8: Expected Ref, but got VT
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I
		//IL_0144: Expected Obj, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01aa: Expected Obj, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Expected Obj, but got Unknown
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected Obj, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_0770: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
		double num3 = Math.Round(_runLengthInSeconds, 1, MidpointRounding.ToEven);
		object obj4 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		nint num4 = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S5_v4+4] (should have been resolved before IL gen)");
		_ = _saveMeCountInRun;
		object obj6 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		nint num6 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v124 @ S5_v9+4] (should have been resolved before IL gen)");
		if (_runLengthUntilFirstSaveMe != (object)0)
		{
			nint num8 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v36 (Il2CppClass<Kiloo.Analytics.RunTracker>)+5C]");
			float? num9 = (float?)(object)((nint)0 + (nint)20);
			float value = ((float?*)num9)->Value;
			double num10 = Math.Round(value, 1, MidpointRounding.ToEven);
			object obj8 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		}
		else
		{
			object obj9 = 0;
		}
		nint num11 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S5_v14 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ S5_v15+4] (should have been resolved before IL gen)");
		_ = _baseScoreMultiplierAtStartOfRun;
		object obj11 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S5_v19 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ S5_v20+4] (should have been resolved before IL gen)");
		_ = _hoverboardCountInRun;
		object obj13 = obj + 44;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S5_v24 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ S5_v25+4] (should have been resolved before IL gen)");
		_ = _runWasAborted;
		object obj15 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		nint num17 = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S5_v29 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v287 @ S5_v30+4] (should have been resolved before IL gen)");
		Dictionary<string, object> dictionary = default;
		object obj17 = dictionary._count - dictionary._freeCount;
		nint num19 = 0;
		nint num20 = 0;
		IntPtr intPtr2 = num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ S4_v41 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		object obj18 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		object obj19 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj20 = obj + 56;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj22 = default;
		object obj23;
		string text = default;
		object obj24 = default;
		object obj25 = default;
		object obj27 = default;
		object obj28 = default;
		while (true)
		{
			_ = 0;
			object obj21 = obj + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = obj22 == null;
				obj23 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
							if ((nint)0 == 0)
							{
								string empty = string.Empty;
								goto IL_03c5;
							}
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag2 = (nint)0 != 1;
								string empty = text;
								if (flag2)
								{
									goto IL_03c5;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			goto IL_0412;
			IL_03c5:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0412;
			IL_0412:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj24 == obj25;
			bool flag4 = !flag3;
			object obj26 = obj27;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				obj23 = obj;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj26 = obj28;
			}
			_ = 0;
			object obj29 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj23 = 0;
			break;
		}
		object obj30 = obj23 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDF");
		Event obj31 = default;
		obj31.name = "run_ended";
		obj31.parameters = dictionary;
		return obj31;
	}

	public unsafe static void Initialize()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Action action = default;
			action._002Ector(null, (nint)(delegate*<void>)(&OnGameStarted));
			Game.OnGameStarted += action;
			Action action2 = default;
			action2._002Ector(null, (nint)(delegate*<void>)(&OnGameEnded));
			Game.OnGameEnded += action2;
			throw new ArgumentException();
		}
	}

	private unsafe static void OnGameStarted()
	{
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		_runLengthInSeconds = 0f;
		_saveMeCountInRun = 0;
		_hasUsedSaveMe = false;
		nint num = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v15 (Il2CppClass<Kiloo.Analytics.RunTracker>)+5C]");
		object obj = (nint)0 + (nint)20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		PlayerInfo instance = PlayerInfo.Instance;
		int num2 = instance._currentMissionSet + 1;
		if (num2 >= 30)
		{
			num2 = 30;
		}
		if (num2 <= 1)
		{
			num2 = 1;
		}
		_baseScoreMultiplierAtStartOfRun = num2;
		_hoverboardCountInRun = 0;
		_runDidEnd = false;
		_runWasAborted = false;
		_isReadyToLog = false;
		IEnumerator runLengthTracker = TrackRunLengthInSeconds();
		_runLengthTracker = runLengthTracker;
		Coroutine coroutine = CoroutineUtil.StartCoroutine(_runLengthTracker);
		Revive instance2 = Revive.Instance;
		Revive.OnReviveDelegate onReviveDelegate = default;
		onReviveDelegate._002Ector(null, (nint)(delegate*<void>)(&OnRevive));
		instance2.OnRevive += onReviveDelegate;
		GameStats instance3 = GameStats.Instance;
		throw new ArgumentException();
	}

	private unsafe static void OnGameEnded()
	{
		Revive instance = Revive.Instance;
		Revive.OnReviveDelegate onReviveDelegate = default;
		onReviveDelegate._002Ector(null, (nint)(delegate*<void>)(&OnRevive));
		instance.OnRevive -= onReviveDelegate;
		GameStats instance2 = GameStats.Instance;
		throw new ArgumentException();
	}

	private static void OnRunEnded(bool playerWasAutoRevived)
	{
		_runDidEnd = true;
	}

	private static void OnMenuScreenShown()
	{
		if (~(_initialMenuScreenShown ? 1u : 0u) != 0)
		{
			_initialMenuScreenShown = true;
			return;
		}
		CoroutineUtil.StopCoroutine(_runLengthTracker);
		_runLengthTracker = null;
		GameStats instance = GameStats.Instance;
		throw new ArgumentException();
	}

	private static IEnumerator TrackRunLengthInSeconds()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private static void OnRevive()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0040: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		int saveMeCountInRun = _saveMeCountInRun + 1;
		_saveMeCountInRun = saveMeCountInRun;
		_runDidEnd = false;
		if (~(_hasUsedSaveMe ? 1u : 0u) != 0)
		{
			_hasUsedSaveMe = true;
			_ = 0;
			_ = 1;
			_ = _runLengthInSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_runLengthUntilFirstSaveMe = (float?)(object)0;
		}
	}

	private static void OnPowerupTriggered(PowerupType powerupType)
	{
		if (powerupType == PowerupType.hoverboard)
		{
			Hoverboard instance = Hoverboard.Instance;
			if (!instance._isARewardFromMysteryPowerup)
			{
				int hoverboardCountInRun = _hoverboardCountInRun + 1;
				_hoverboardCountInRun = hoverboardCountInRun;
			}
		}
	}
}
