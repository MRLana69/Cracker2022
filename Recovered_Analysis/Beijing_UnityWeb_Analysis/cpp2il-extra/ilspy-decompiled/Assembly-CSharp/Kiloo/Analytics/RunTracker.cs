using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Utility;
using SYBO.Subway;
using UnityEngine;
using UnityEngine.UI;

namespace Kiloo.Analytics;

internal static class RunTracker
{
	private sealed class _003CRunEnded_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<Event> onLogReady;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_019f: Expected Obj, but got I4
				//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01aa: Expected Obj, but got Unknown
				//IL_01d0: Expected Obj, but got I4
				//IL_0083: Expected I, but got Obj
				//IL_00db: Expected I, but got Obj
				//IL_00f1: Expected Obj, but got I
				//IL_0200: Expected I, but got Obj
				//IL_0216: Expected Obj, but got I
				//IL_021f: Expected Obj, but got I4
				//IL_011c: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(RunTracker);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v18 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(RunTracker);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v26 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						IEnumerator obj2 = TrackRunLengthInSeconds();
						onLogReady((Event)obj2);
						nint num3 = (nint)typeof(RunTracker);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v32 (Il2CppClass<Kiloo.Analytics.RunTracker>)+5C]");
						object obj3 = (nint)0 + (nint)52;
						obj3 = 0;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				nint num4 = (nint)typeof(RunTracker);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num5 = (nint)typeof(RunTracker);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v22 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isReadyToLog = _isReadyToLog;
				object obj5 = isReadyToLog;
				object obj6 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object obj7 = default;
				obj6 = obj7;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CRunEnded_003Ed__17(int _003C_003E1__state)
		{
			//IL_0154: Expected Obj, but got I4
			//IL_00a1: Expected I, but got Obj
			//IL_00b7: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_00e2: Expected I, but got Obj
			//IL_0054: Expected I, but got Obj
			bool flag = _003C_003E1__state != 0;
			bool flag2 = this._003C_003E1__state != 0;
			object obj = flag & flag2;
			if (obj != null)
			{
				nint num = (nint)typeof(Manager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v20 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(Manager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v25 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Manager.Initialize();
			}
			nint num3 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v10 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Manager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v15 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Manager.UpdateSettings((byte)_003C_003E1__state != 0);
		}

		void IDisposable.Dispose()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Manager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Tracker.CreateEvent(EventType.DailyData, null);
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

	private sealed class _003CTrackRunLengthInSeconds_003Ed__24(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Expected Obj, but got Unknown
				//IL_00f0: Expected Obj, but got I4
				//IL_0104: Expected Obj, but got I4
				//IL_0052: Expected I, but got Obj
				//IL_0068: Expected Obj, but got I
				//IL_0093: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					nint num = (nint)typeof(RunTracker);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v16 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(RunTracker);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v28 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float unscaledTime = Time.unscaledTime;
					float runLengthInSeconds = _runLengthInSeconds + unscaledTime;
					_runLengthInSeconds = runLengthInSeconds;
				}
				else
				{
					_003C_003E1__state = -1;
				}
				object obj2 = this + 12;
				obj2 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

	private static bool _initialized;

	private static bool _initialMenuScreenShown;

	private static float _runLengthInSeconds;

	private static IEnumerator _runLengthTracker;

	private static int _saveMeCountInRun;

	private static bool _hasUsedSaveMe;

	private static float? _runLengthUntilFirstSaveMe;

	private static int _baseScoreMultiplierAtStartOfRun;

	private static int _hoverboardCountInRun;

	private static bool _wasFirstMysteryBoxPicked;

	private static int _MBCount;

	private static float _firstMysteryBoxCollectedAfterSeconds;

	private static bool _runDidEnd;

	private static bool _runWasAborted;

	private static bool _isReadyToLog;

	private static IEnumerator _runEnded;

	public unsafe static void LogRunEndedData(Action<Event> onLogReady)
	{
		//IL_03aa: Expected I, but got Obj
		//IL_03c0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_040d: Expected I, but got Obj
		//IL_0423: Expected Obj, but got I
		//IL_015a: Expected I, but got Obj
		//IL_01a7: Expected I, but got Obj
		//IL_01f4: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_0465: Expected I4, but got Obj
		//IL_028e: Expected I, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_0235: Expected I, but got Obj
		//IL_02cf: Expected I, but got Obj
		//IL_031c: Expected I, but got Obj
		//IL_0332: Expected Obj, but got I
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Unknown
		//IL_050f: Expected I, but got Obj
		//IL_0525: Expected Obj, but got I
		//IL_035d: Expected I, but got Obj
		nint num = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v78 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Manager._initialized ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v74 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!Manager.Sample())
		{
			return;
		}
		object obj3;
		if (onLogReady != null)
		{
			obj3 = 1;
		}
		else
		{
			nint num5 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v62 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Manager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v69 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Event runEndedData = GetRunEndedData();
			obj3 = runEndedData & 1;
		}
		nint num7 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v25 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v55 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isPartOfSample = obj3 != null;
		Manager._isPartOfSample = isPartOfSample;
		if (~(Manager._isPartOfSample ? 1u : 0u) != 0)
		{
			return;
		}
		nint num9 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v36 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v51 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Manager.Initialize((byte)(int)onLogReady != 0);
		Manager._initialized = true;
		Tracker.CreateEvent(EventType.StaticData, null);
		Tracker.CreateEvent(EventType.DailyData, null);
		Tracker.CreateEvent(EventType.SyboUserId, null);
		nint num11 = (nint)typeof(Manager._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v16 (Il2CppClass<Kiloo.Analytics.Manager+<>c>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(Manager._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v50 (Il2CppClass<Kiloo.Analytics.Manager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Manager._003C_003Ec._003C_003E9__29_0 == null;
		bool flag2 = !flag;
		Action value = Manager._003C_003Ec._003C_003E9__29_0;
		if (!flag2)
		{
			nint num13 = (nint)typeof(Manager._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v27 (Il2CppClass<Kiloo.Analytics.Manager+<>c>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num14 = (nint)typeof(Manager._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v44 (Il2CppClass<Kiloo.Analytics.Manager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(Manager._003C_003Ec._003CInitialize_003Eb__29_0);
			object obj9 = action + 16;
			obj9 = Manager._003C_003Ec._003C_003E9;
			nint num15 = (nint)typeof(Manager._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S1_v41 (Il2CppClass<Kiloo.Analytics.Manager+<>c>)+5C]");
			object obj10 = (nint)0 + (nint)4;
			obj10 = action;
			value = action;
		}
		Manager._eventRemoteLogger.onResume -= value;
	}

	private static IEnumerator RunEnded(Action<Event> onLogReady)
	{
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [onLogReady @ L0 (System.Action`1<Kiloo.Analytics.Event>)+8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	private unsafe static Event GetRunEndedData()
	{
		//IL_02c6: Expected I, but got Obj
		//IL_02dc: Expected Obj, but got I
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Obj, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0315: Expected I4, but got Obj
		//IL_0327: Expected I, but got Obj
		//IL_033d: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_039c: Expected I, but got Obj
		//IL_03b2: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got VT
		//IL_03e0: Expected Obj, but got VT
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_018a: Expected I, but got Obj
		//IL_022e: Expected I, but got Obj
		//IL_0244: Expected Obj, but got I
		//IL_01d7: Expected I, but got Obj
		//IL_0474: Expected Obj, but got I4
		//IL_026f: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v99 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 24;
		object obj4 = obj3 + 16;
		object obj5 = obj3 + 8;
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		if (((OnlineSettings)(object)saveDataPath).TryGetValue("kiloo_analytics_enabled", out *(string*)null))
		{
			nint num3 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v25 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v94 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			float startOffset = ((LayoutGroup)(object)saveDataPath2).GetStartOffset((int)"kiloo_analytics_sample", 0f);
			nint num5 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v33 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v90 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string firstInstalledVersion = UserSave.firstInstalledVersion;
			if (firstInstalledVersion != null)
			{
				return (Event)1;
			}
			nint num7 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v41 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v85 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime lastTimeAVideoForKeysWasSeen = UserSave.lastTimeAVideoForKeysWasSeen;
			nint num9 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v48 (Il2CppClass<System.DateTime>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num10 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v79 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = lastTimeAVideoForKeysWasSeen;
			obj3 = DateTime.MinValue;
			obj4 = obj5;
			obj2 = obj3;
			object obj10 = obj4 & 0x3FFFFFFFFFFFFFFFL;
			object obj11 = obj2 & 0x3FFFFFFFFFFFFFFFL;
			if (obj10 == obj11)
			{
				return null;
			}
			nint num11 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v64 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num12 = (nint)typeof(Manager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v74 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num13 = GUIUtil.ScaleGUI();
			bool flag = !(num13 < 0f);
			bool flag2 = !(num13 > startOffset);
			return (Event)(flag & flag2);
		}
		return null;
	}

	public static void Initialize()
	{
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		nint num = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool initialized = Manager._initialized;
		nint num3 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v5 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 != null;
		if (initialized)
		{
			if (flag)
			{
				nint num4 = (nint)typeof(Manager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Manager.Initialize();
			return;
		}
		if (flag)
		{
			nint num5 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v18 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogRunEndedData(null);
	}

	private unsafe static void OnGameStarted()
	{
		//IL_024d: Expected I, but got Obj
		//IL_0263: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_00e4: Expected I, but got Obj
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I4
		//IL_01bf: Expected I, but got Obj
		//IL_01d5: Expected Obj, but got I
		//IL_0200: Expected I, but got Obj
		nint num = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v68 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<void>)(&OnGameStarted);
		object obj2 = action + 16;
		obj2 = 0;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v22 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v64 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)(delegate*<void>)(&OnGameEnded);
		object obj4 = action2 + 16;
		obj4 = 0;
		Game.OnGameEnded -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<bool> action3 = default;
		object obj5 = action3 + 16;
		obj5 = 0;
		Game.OnRunEnded -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action4 = default;
		((Delegate)action4).method_ptr = method_ptr3;
		((Delegate)action4).method = (nint)(delegate*<void>)(&OnMenuScreenShown);
		object obj6 = action4 + 16;
		obj6 = 0;
		Game.OnMenuScreenShown -= action4;
		nint num6 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v52 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num7 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v58 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_initialized = true;
	}

	private unsafe static void OnGameEnded()
	{
		//IL_0247: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I
		//IL_03a4: Expected I, but got Obj
		//IL_03ba: Expected Obj, but got I
		//IL_03d2: Expected I, but got Obj
		//IL_03e8: Expected Obj, but got I
		//IL_02e9: Expected I, but got Obj
		//IL_02ff: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_0366: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_016a: Expected Obj, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_022b: Expected Obj, but got I4
		nint num = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v85 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_runLengthInSeconds = 0f;
		_saveMeCountInRun = 0;
		_hasUsedSaveMe = false;
		nint num3 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (Il2CppClass<Kiloo.Analytics.RunTracker>)+5C]");
		object obj2 = (nint)0 + (nint)20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num4 = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v81 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool allowSellConsumablesDuringRun = SellConsumable.allowSellConsumablesDuringRun;
		_baseScoreMultiplierAtStartOfRun = (allowSellConsumablesDuringRun ? 1 : 0);
		_hoverboardCountInRun = 0;
		_wasFirstMysteryBoxPicked = false;
		_MBCount = 0;
		_firstMysteryBoxCollectedAfterSeconds = -1f;
		_runDidEnd = false;
		_runWasAborted = false;
		_isReadyToLog = false;
		Event staticData = Tracker.GetStaticData();
		nint num6 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v56 (Il2CppClass<Kiloo.Analytics.RunTracker>)+5C]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = staticData;
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_runLengthTracker);
		nint num7 = (nint)typeof(Revive);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v65 (Il2CppClass<Revive>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(Revive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v77 (Il2CppClass<Revive>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceToken = RemoteNotificationControl.GetDeviceToken();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Revive.OnReviveDelegate onReviveDelegate = default;
		((Delegate)onReviveDelegate).method_ptr = method_ptr;
		((Delegate)onReviveDelegate).method = (nint)(delegate*<void>)(&OnRevive);
		object obj6 = onReviveDelegate + 16;
		obj6 = 0;
		((Revive)(object)deviceToken).OnRevive -= onReviveDelegate;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<UpgradeType> action = default;
		object obj7 = action + 16;
		obj7 = 0;
		((GameStats)(object)privacyPolicyUrl).PowerupTriggered -= action;
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)(delegate*<void>)(&OnMysteryOrSuperMysteryBoxPickup);
		object obj8 = action2 + 16;
		obj8 = 0;
		((GameStats)(object)privacyPolicyUrl2).OnMysteryBoxPickup -= action2;
		string privacyPolicyUrl3 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)(delegate*<void>)(&OnMysteryOrSuperMysteryBoxPickup);
		object obj9 = action3 + 16;
		obj9 = 0;
		((GameStats)(object)privacyPolicyUrl3).OnSuperMysteryBoxPickup -= action3;
	}

	private static void OnRunEnded(bool playerWasAutoRevived)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012b: Expected Obj, but got I4
		//IL_013d: Expected I, but got Obj
		//IL_0153: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v35 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_runEnded != null)
		{
			return;
		}
		nint num3 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v31 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Event validInAppPurchase = Tracker.GetValidInAppPurchase((string)playerWasAutoRevived);
		nint num5 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v23 (Il2CppClass<Kiloo.Analytics.RunTracker>)+5C]");
		object obj3 = (nint)0 + (nint)52;
		obj3 = validInAppPurchase;
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_runEnded);
	}

	private unsafe static void OnMenuScreenShown()
	{
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a3: Expected Obj, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_0150: Expected Obj, but got I4
		nint num = (nint)typeof(Revive);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Revive>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Revive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Revive>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceToken = RemoteNotificationControl.GetDeviceToken();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		string text = default;
		text.m_stringLength = (int)num3;
		_ = 0;
		object obj2 = text + 16;
		obj2 = 0;
		((Friend)(object)deviceToken).name = text;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<UpgradeType, void>)(&OnPowerupTriggered);
		object obj3 = action + 16;
		obj3 = 0;
		((GameStats)(object)privacyPolicyUrl).OnMysteryBoxPickup += action;
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)(delegate*<void>)(&OnMysteryOrSuperMysteryBoxPickup);
		object obj4 = action2 + 16;
		obj4 = 0;
		((GameStats)(object)privacyPolicyUrl2).OnSuperMysteryBoxPickup += action2;
		string privacyPolicyUrl3 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		int num5 = default;
		object obj5 = num5 + 16;
		obj5 = 0;
		((GameStats)(object)privacyPolicyUrl3).CoinsCollected = num5;
	}

	private unsafe static IEnumerator TrackRunLengthInSeconds()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected Obj, but got Unknown
		//IL_07f9: Expected Obj, but got I4
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected Obj, but got Unknown
		//IL_081c: Expected Obj, but got I4
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected Obj, but got Unknown
		//IL_0858: Expected Obj, but got I
		//IL_0868: Expected Obj, but got I
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Expected Obj, but got Unknown
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected Obj, but got Unknown
		//IL_08a4: Expected I, but got Obj
		//IL_08ba: Expected Obj, but got I
		//IL_08e5: Expected I, but got Obj
		//IL_08fb: Expected Obj, but got I
		//IL_0cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdc: Expected Obj, but got Unknown
		//IL_0cf7: Expected Obj, but got F8
		//IL_0d17: Expected Obj, but got I
		//IL_0d27: Expected Obj, but got I
		//IL_0d37: Expected Obj, but got I
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected Obj, but got Unknown
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d53: Expected Obj, but got Unknown
		//IL_0d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6b: Expected Obj, but got Unknown
		//IL_0d74: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I4
		//IL_09bb: Expected Obj, but got I
		//IL_09cb: Expected Obj, but got I
		//IL_09db: Expected Obj, but got I
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected Obj, but got Unknown
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Expected Obj, but got Unknown
		//IL_0a0f: Expected I, but got Obj
		//IL_0a25: Expected Obj, but got I
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_0193: Expected I, but got Obj
		//IL_0d8c: Expected Obj, but got I4
		//IL_0dac: Expected Obj, but got I
		//IL_0dbc: Expected Obj, but got I
		//IL_0dcc: Expected Obj, but got I
		//IL_0dd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dda: Expected Obj, but got Unknown
		//IL_0de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de8: Expected Obj, but got Unknown
		//IL_0dfb: Expected Obj, but got I4
		//IL_0e1b: Expected Obj, but got I
		//IL_0e2b: Expected Obj, but got I
		//IL_0e3b: Expected Obj, but got I
		//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e49: Expected Obj, but got Unknown
		//IL_0e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e57: Expected Obj, but got Unknown
		//IL_0e82: Expected I, but got Obj
		//IL_0e98: Expected Obj, but got I
		//IL_092e: Expected VT, but got I
		//IL_0937: Expected Ref, but got VT
		//IL_0949: Expected I, but got Obj
		//IL_095f: Expected Obj, but got I
		//IL_0a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected Obj, but got Unknown
		//IL_0a58: Expected Obj, but got I4
		//IL_0a78: Expected Obj, but got I
		//IL_0a88: Expected Obj, but got I
		//IL_0a98: Expected Obj, but got I
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected Obj, but got Unknown
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected Obj, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected Obj, but got Unknown
		//IL_0ad5: Expected Obj, but got I4
		//IL_0af5: Expected Obj, but got I
		//IL_0b05: Expected Obj, but got I
		//IL_0b15: Expected Obj, but got I
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected Obj, but got Unknown
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Expected Obj, but got Unknown
		//IL_0b49: Expected I, but got Obj
		//IL_0b5f: Expected Obj, but got I
		//IL_0273: Expected I, but got Obj
		//IL_0996: Expected Obj, but got F8
		//IL_01af: Expected I, but got Obj
		//IL_01df: Expected I, but got Obj
		//IL_0b97: Expected Obj, but got F8
		//IL_0bb7: Expected Obj, but got I
		//IL_0bc7: Expected Obj, but got I
		//IL_0bd7: Expected Obj, but got I
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected Obj, but got Unknown
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Expected Obj, but got Unknown
		//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Expected Obj, but got Unknown
		//IL_02c0: Expected I, but got Obj
		//IL_0218: Expected I, but got Obj
		//IL_035c: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I
		//IL_039c: Expected Obj, but got I
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_030d: Expected I, but got Obj
		//IL_0205: Expected I, but got Obj
		//IL_03ee: Expected Obj, but got I
		//IL_040e: Expected Obj, but got I
		//IL_041e: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected Obj, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_0471: Expected Obj, but got I
		//IL_0496: Expected Obj, but got I
		//IL_04a6: Expected Obj, but got I
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got Unknown
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected Obj, but got Unknown
		//IL_0684: Expected Obj, but got I4
		//IL_0ec3: Expected I, but got Obj
		//IL_0ed9: Expected Obj, but got I
		//IL_06eb: Expected Obj, but got I
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Expected Obj, but got Unknown
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Expected Obj, but got Unknown
		//IL_07a3: Expected I, but got Obj
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 112;
		object obj3 = obj2 + 80;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = 0;
		object obj5 = obj2 + 72;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num3 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v273 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num4 = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v32 (Il2CppClass<System.Math>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num5 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v269 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj13 = obj2 + 8;
		double num6 = Math.Round(_runLengthInSeconds, MidpointRounding.AwayFromZero);
		obj13 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v7+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S4_v8+48]");
		object obj16 = 0;
		object obj17 = obj16 & 0x7FF;
		object obj18 = obj17 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S5_v6 (should have been resolved before IL gen)");
		object obj19 = obj2 - -64;
		obj19 = _saveMeCountInRun;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S4_v12+60]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S4_v13+48]");
		object obj22 = 0;
		object obj23 = obj22 & 0x7FF;
		object obj24 = obj23 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v160 @ S5_v10 (should have been resolved before IL gen)");
		nint num9 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S2_v6 (Il2CppClass<Kiloo.Analytics.RunTracker>)+5C]");
		object obj25 = (nint)0 + (nint)20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S2_v8+4]");
		if ((nint)0 != 0)
		{
			nint num10 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S2_v48 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			bool flag = obj26 == null;
			nint num11 = (nint)typeof(RunTracker);
			if (!flag)
			{
				nint num12 = (nint)typeof(RunTracker);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S2_v69 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num11 = (nint)typeof(RunTracker);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num11 = (nint)typeof(RunTracker);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ L0_v62 (Il2CppClass<Kiloo.Analytics.RunTracker>)+5C]");
			float? num13 = (float?)(object)((nint)0 + (nint)20);
			float value = ((float?*)num13)->Value;
			nint num14 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S2_v57 (Il2CppClass<System.Math>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num15 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S2_v65 (Il2CppClass<System.Math>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			double num16 = Math.Round(value, MidpointRounding.AwayFromZero);
			obj13 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		}
		else
		{
			object obj28 = 0;
		}
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S4_v17 (Il2CppMethodInfo)+C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S4_v18+60]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S4_v19+48]");
		object obj31 = 0;
		object obj32 = obj31 & 0x7FF;
		object obj33 = obj32 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v224 @ S5_v15 (should have been resolved before IL gen)");
		nint num18 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v55 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num19 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v263 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj13 = _baseScoreMultiplierAtStartOfRun;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S4_v22 (Il2CppMethodInfo)+C]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S4_v23+60]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S4_v24+48]");
		object obj37 = 0;
		object obj38 = obj37 & 0x7FF;
		object obj39 = obj38 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v285 @ S5_v19 (should have been resolved before IL gen)");
		obj19 = _hoverboardCountInRun;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S4_v27 (Il2CppMethodInfo)+C]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S4_v28+60]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S4_v29+48]");
		object obj42 = 0;
		object obj43 = obj42 & 0x7FF;
		object obj44 = obj43 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v316 @ S5_v23 (should have been resolved before IL gen)");
		bool runWasAborted = _runWasAborted;
		nint num22 = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v77 (Il2CppClass<System.Convert>)+BA]");
		object obj45 = (nint)0 & (nint)0x200;
		if (obj45 != null)
		{
			nint num23 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v259 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj46 = obj2 + 60;
		obj46 = runWasAborted;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S4_v32 (Il2CppMethodInfo)+C]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S4_v33+60]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S4_v34+48]");
		object obj49 = 0;
		object obj50 = obj49 & 0x7FF;
		object obj51 = obj50 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v367 @ S5_v27 (should have been resolved before IL gen)");
		object obj52 = obj2 + 56;
		obj52 = _MBCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S4_v37 (Il2CppMethodInfo)+C]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S4_v38+60]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S4_v39+48]");
		object obj55 = 0;
		object obj56 = obj55 & 0x7FF;
		object obj57 = obj56 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v398 @ S5_v31 (should have been resolved before IL gen)");
		nint num26 = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v100 (Il2CppClass<System.Math>)+BA]");
		object obj58 = (nint)0 & (nint)0x200;
		if (obj58 != null)
		{
			nint num27 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v255 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		double num28 = Math.Round(_firstMysteryBoxCollectedAfterSeconds, MidpointRounding.AwayFromZero);
		obj2 = num28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S4_v42 (Il2CppMethodInfo)+C]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S4_v43+60]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S4_v44+48]");
		object obj61 = 0;
		object obj62 = obj61 & 0x7FF;
		object obj63 = obj62 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v445 @ S5_v35 (should have been resolved before IL gen)");
		object obj64 = obj2 + 52;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S1_v70 (System.String)+F4]");
		obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S4_v47 (Il2CppMethodInfo)+C]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S4_v48+60]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S4_v49+48]");
		object obj67 = 0;
		object obj68 = obj67 & 0x7FF;
		object obj69 = obj68 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v475 @ S5_v39 (should have been resolved before IL gen)");
		object obj70 = obj2 + 48;
		string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S1_v77 (System.String)+FC]");
		obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S4_v52 (Il2CppMethodInfo)+C]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S4_v53+60]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ S4_v54+48]");
		object obj73 = 0;
		object obj74 = obj73 & 0x7FF;
		object obj75 = obj74 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v505 @ S5_v43 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22+10]");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22+1C]");
		object obj76 = num32 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S3_v21 (Il2CppMethodInfo)+C]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S3_v22+60]");
		object obj78 = 0;
		object obj79 = obj78;
		object obj80 = obj79 & 0x1FFF;
		object obj81 = obj80 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v532 @ S4_v59 (should have been resolved before IL gen)");
		object obj82 = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj82;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v133+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v133+10]");
		_ = 0;
		object obj83 = default;
		object obj84 = default;
		string text2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj83 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj84 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				string text = text2;
			}
			else
			{
				string text = string.Empty;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj85 = obj5 + 4;
		object obj86 = obj85 + 1;
		obj85 = obj86;
		object obj87 = obj86 << 2;
		object obj88 = obj5 + obj87;
		obj88 = 367;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj89 = (nint)0 << 2;
			object obj90 = obj5 + obj89;
			if ((nint)obj90 == 367)
			{
				object obj91 = obj5 + 4;
				if ((nint)obj91 > -1)
				{
					object obj92 = obj91 + -1;
					obj91 = obj92;
				}
				goto IL_0eb5;
			}
		}
		object obj93 = default;
		if (obj93 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0eb5;
		IL_0eb5:
		nint num34 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ S0_v151 (Il2CppClass<Flurry>)+BA]");
		object obj94 = (nint)0 & (nint)0x200;
		if (obj94 != null)
		{
			nint num35 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S0_v163 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IEnumerator enumerator = default;
		object obj95 = enumerator + 8;
		obj95 = "run_ended";
		object obj96 = enumerator + 12;
		object obj97 = default;
		obj96 = obj97;
		return enumerator;
	}

	private unsafe static void OnRevive()
	{
		//IL_02e6: Expected I, but got Obj
		//IL_02fc: Expected Obj, but got I
		//IL_03eb: Expected I, but got Obj
		//IL_0401: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0299: Expected I, but got Obj
		//IL_0331: Expected I, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00f1: Expected Obj, but got I4
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03a8: Expected Obj, but got I4
		//IL_014d: Expected I, but got Obj
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01dd: Expected Obj, but got I4
		//IL_021e: Expected Obj, but got I4
		//IL_0227: Expected Obj, but got I4
		nint num = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v63 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool initialMenuScreenShown = _initialMenuScreenShown;
		nint num3 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v5 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 != null;
		if (initialMenuScreenShown)
		{
			if (flag)
			{
				nint num4 = (nint)typeof(RunTracker);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v57 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CoroutineUtil.StopCoroutine((Coroutine)(object)_runLengthTracker);
			nint num5 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v31 (Il2CppClass<Kiloo.Analytics.RunTracker>)+5C]");
			object obj3 = (nint)0 + (nint)8;
			obj3 = 0;
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)(delegate*<UpgradeType, void>)(&OnPowerupTriggered);
			object obj4 = action + 16;
			obj4 = 0;
			((GameStats)(object)privacyPolicyUrl).OnMysteryBoxPickup += action;
			nint num6 = (nint)typeof(Revive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v37 (Il2CppClass<Revive>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num7 = (nint)typeof(Revive);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v53 (Il2CppClass<Revive>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string deviceToken = RemoteNotificationControl.GetDeviceToken();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num8 = 0;
			string text = default;
			text.m_stringLength = (int)num8;
			_ = 0;
			object obj6 = text + 16;
			obj6 = 0;
			((Friend)(object)deviceToken).name = text;
			string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action2 = default;
			((Delegate)action2).method_ptr = method_ptr2;
			((Delegate)action2).method = (nint)(delegate*<void>)(&OnMysteryOrSuperMysteryBoxPickup);
			object obj7 = action2 + 16;
			obj7 = 0;
			((GameStats)(object)privacyPolicyUrl2).OnSuperMysteryBoxPickup += action2;
			string privacyPolicyUrl3 = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num9 = 0;
			_ = 0;
			int num10 = default;
			object obj8 = num10 + 16;
			obj8 = 0;
			((GameStats)(object)privacyPolicyUrl3).CoinsCollected = num10;
			bool runDidEnd = _runDidEnd;
			bool runWasAborted = (byte)((runDidEnd ? 1u : 0u) ^ 1u) != 0;
			_runWasAborted = runWasAborted;
			_isReadyToLog = true;
			return;
		}
		if (flag)
		{
			nint num11 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v19 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_initialMenuScreenShown = true;
	}

	private static void OnPowerupTriggered(UpgradeType upgradeType)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_runDidEnd = true;
	}

	private static void OnMysteryOrSuperMysteryBoxPickup()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_0143: Expected Obj, but got F4
		//IL_015c: Expected VT, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v55 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		object obj4 = obj3 + 8;
		int saveMeCountInRun = _saveMeCountInRun + 1;
		_saveMeCountInRun = saveMeCountInRun;
		_runDidEnd = false;
		if (~(_hasUsedSaveMe ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v31 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v49 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_hasUsedSaveMe = true;
		obj4 = 0;
		_ = 1;
		obj4 = _runLengthInSeconds;
		obj3 = obj4;
		obj2 = obj3;
		_runLengthUntilFirstSaveMe = (float?)obj2;
	}

	static RunTracker()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int mBCount = _MBCount + 1;
		_MBCount = mBCount;
		if (~(_wasFirstMysteryBoxPicked ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(RunTracker);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppClass<Kiloo.Analytics.RunTracker>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(RunTracker);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v30 (Il2CppClass<Kiloo.Analytics.RunTracker>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_firstMysteryBoxCollectedAfterSeconds = _runLengthInSeconds;
		_wasFirstMysteryBoxPicked = true;
	}
}
