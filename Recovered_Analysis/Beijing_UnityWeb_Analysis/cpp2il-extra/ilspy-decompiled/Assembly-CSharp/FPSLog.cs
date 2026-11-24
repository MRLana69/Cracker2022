using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using Kiloo.Common.OnGUIWrappers;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using SYBO.Common.StateSystem;
using SYBO.Subway;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using UI.Screens;
using UnityEngine;
using UnityEngine.Networking;

public class FPSLog
{
	private sealed class _003CFPSTestRoutine_003Ed__70(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public bool runPreset;

		public FPSLog _003C_003E4__this;

		public bool runFrameTimes;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d6: Expected Obj, but got Unknown
				//IL_00ff: Expected Obj, but got I4
				//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f7: Expected Obj, but got Unknown
				//IL_020d: Expected I, but got Obj
				//IL_0223: Expected Obj, but got I
				//IL_039b: Expected I4, but got Obj
				//IL_039b: Expected I4, but got Obj
				//IL_039b: Expected I4, but got Obj
				//IL_03ad: Expected I, but got Obj
				//IL_03c3: Expected Obj, but got I
				//IL_0166: Unknown result type (might be due to invalid IL or missing references)
				//IL_016b: Expected Obj, but got Unknown
				//IL_017a: Unknown result type (might be due to invalid IL or missing references)
				//IL_017f: Expected Obj, but got Unknown
				//IL_04b3: Expected VT, but got I4
				//IL_032e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0333: Expected Obj, but got Unknown
				//IL_0342: Unknown result type (might be due to invalid IL or missing references)
				//IL_0347: Expected Obj, but got Unknown
				//IL_01ad: Expected Obj, but got I4
				//IL_043c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0441: Expected Obj, but got Unknown
				//IL_044a: Expected Obj, but got I4
				//IL_045e: Expected Obj, but got I4
				//IL_024e: Expected I, but got Obj
				//IL_03ee: Expected I, but got Obj
				//IL_0375: Expected Obj, but got I4
				FPSLog fPSLog = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint method_ptr = 0;
						Action action = default;
						((Delegate)action).method_ptr = method_ptr;
						((Delegate)action).method = (nint)__ldftn(FPSLog.ResetAutoFPS);
						object obj = action + 16;
						obj = fPSLog;
						nint num = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v72 (Il2CppClass<SYBO.Subway.Game>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num2 = (nint)typeof(Game);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v77 (Il2CppClass<SYBO.Subway.Game>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Game.OnMenuScreenShown -= action;
						goto IL_042d;
					}
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							if (_003C_003E1__state == 4)
							{
								_003C_003E1__state = -1;
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
						goto IL_037a;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					if (~(runPreset ? 1u : 0u) == 0)
					{
						bool loggingFrameTimes = runFrameTimes;
						fPSLog._loggingFrameTimes = loggingFrameTimes;
						object obj3 = this + 12;
						IEnumerator enumerator = fPSLog.Update();
						obj3 = enumerator;
						_003C_003E1__state = 1;
						return 1;
					}
					if (~(fPSLog.RunTestologyCappedTest ? 1u : 0u) == 0)
					{
						bool loggingFrameTimes2 = runFrameTimes;
						fPSLog._loggingFrameTimes = loggingFrameTimes2;
						fPSLog.SetFPSAutoLength(-1);
						fPSLog.IsUploadingFPS__BackingField = true;
						object obj4 = fPSLog + 84;
						obj4 = "FPS_Data";
						object obj5 = this + 12;
						IEnumerator enumerator2 = fPSLog.Update();
						obj5 = enumerator2;
						_003C_003E1__state = 2;
						return 1;
					}
				}
				if (~(fPSLog.RunTestologyUnCappedTest ? 1u : 0u) == 0)
				{
					bool loggingFrameTimes3 = runFrameTimes;
					fPSLog._loggingFrameTimes = loggingFrameTimes3;
					fPSLog.SetFPSAutoLength(60);
					fPSLog.IsUploadingFPS__BackingField = true;
					object obj6 = fPSLog + 84;
					obj6 = "FPS_Data_Uncapped";
					object obj7 = this + 12;
					IEnumerator enumerator3 = fPSLog.Update();
					obj7 = enumerator3;
					_003C_003E1__state = 3;
					return 1;
				}
				goto IL_037a;
				IL_042d:
				fPSLog.RunStarted();
				object obj8 = this + 12;
				obj8 = 0;
				_003C_003E1__state = 4;
				return 1;
				IL_037a:
				int num3 = "FPS tests have been executed\n\nTest results:\n  Capped Test: ".IndexOf((char)(int)fPSLog._lastCappedRunResult, (int)"\n  UncappedTest: ", (int)fPSLog._lastUncappedRunResult);
				nint num4 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v21 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num5 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v27 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((GUIArea)(object)"FPS Results")._002Ector((Rect)num3, "Ok", (string)null);
				goto IL_042d;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
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

	private sealed class _003CAutoFPSTest_003Ed__73(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FPSLog _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0080: Expected I, but got Obj
				//IL_0096: Expected Obj, but got I
				//IL_0708: Expected I, but got Obj
				//IL_071e: Expected Obj, but got I
				//IL_094d: Expected Obj, but got I4
				//IL_094d: Expected Obj, but got I
				//IL_094d: Expected Obj, but got I
				//IL_00c1: Expected I, but got Obj
				//IL_010e: Expected I, but got Obj
				//IL_03f7: Expected I, but got Obj
				//IL_040d: Expected Obj, but got I
				//IL_018e: Expected I, but got Obj
				//IL_01a4: Expected Obj, but got I
				//IL_080c: Expected Obj, but got I4
				//IL_080c: Expected Obj, but got I4
				//IL_074d: Expected Obj, but got I4
				//IL_075b: Expected I, but got Obj
				//IL_0771: Expected Obj, but got I
				//IL_048d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0492: Expected Obj, but got Unknown
				//IL_04ae: Expected Obj, but got I4
				//IL_0438: Expected I, but got Obj
				//IL_08a4: Expected I, but got Obj
				//IL_08ba: Expected Obj, but got I
				//IL_07a5: Expected Obj, but got I4
				//IL_01cf: Expected I, but got Obj
				//IL_082c: Expected Obj, but got I4
				//IL_083e: Expected I, but got Obj
				//IL_0854: Expected Obj, but got I
				//IL_0627: Expected I, but got Obj
				//IL_063d: Expected Obj, but got I
				//IL_0269: Expected I, but got Obj
				//IL_027f: Expected Obj, but got I
				//IL_021c: Expected I, but got Obj
				//IL_04d1: Expected I, but got Obj
				//IL_090f: Expected Obj, but got I4
				//IL_07bc: Expected Obj, but got I4
				//IL_08ee: Expected Obj, but got I4
				//IL_0668: Expected I, but got Obj
				//IL_037d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0382: Expected Obj, but got Unknown
				//IL_0390: Expected F4, but got I4
				//IL_039d: Expected Obj, but got VT
				//IL_02aa: Expected I, but got Obj
				//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05ed: Expected Obj, but got Unknown
				//IL_0609: Expected Obj, but got I4
				//IL_059d: Expected I, but got Obj
				//IL_0891: Expected Obj, but got I4
				//IL_03c2: Expected Obj, but got I4
				//IL_02f7: Expected I, but got Obj
				//IL_030d: Expected Obj, but got I
				//IL_0537: Expected I, but got Obj
				//IL_07eb: Expected Obj, but got I4
				//IL_0338: Expected I, but got Obj
				FPSLog fPSLog = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								nint num = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v151 (Il2CppClass<UIScreenController>)+BA]");
								object obj = (nint)0 & (nint)0x200;
								if (obj != null)
								{
									nint num2 = (nint)typeof(UIScreenController);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v158 (Il2CppClass<UIScreenController>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag = UIScreenController.ShouldShowOnlineScreen();
								((UIScreenController)flag).DebugCloseAllPopups();
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
						bool flag4;
						while (true)
						{
							nint num3 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v114 (Il2CppClass<UIScreenController>)+BA]");
							object obj2 = (nint)0 & (nint)0x200;
							if (obj2 != null)
							{
								nint num4 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v145 (Il2CppClass<UIScreenController>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag2 = UIScreenController.ShouldShowOnlineScreen();
							bool flag3 = ((UIScreenController)flag2).IsPopupQueueEmpty();
							nint num5 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v46 (Il2CppClass<UIScreenController>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							flag4 = obj3 != null;
							if (!flag3)
							{
								break;
							}
							if (flag4)
							{
								nint num6 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v141 (Il2CppClass<UIScreenController>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag5 = UIScreenController.ShouldShowOnlineScreen();
							((UIScreenController)flag5).DebugCloseAllPopups();
						}
						if (flag4)
						{
							nint num7 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v133 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag6 = UIScreenController.ShouldShowOnlineScreen();
						((UIScreenController)flag6).SwitchScreen("FrontScreen");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.2f;
						object obj4 = this + 12;
						object obj5 = default;
						obj4 = obj5;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
					((GameStats)(object)privacyPolicyUrl).ResetRun();
					nint num8 = (nint)typeof(GameStateMachine);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v93 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num9 = (nint)typeof(GameStateMachine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v107 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
					((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)107);
					fPSLog.Log();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 10f;
					object obj7 = this + 12;
					object obj8 = default;
					obj7 = obj8;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				nint num10 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<Globals>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num11 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v83 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool dEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS = Globals.DEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS;
				fPSLog.previousColliderState = dEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS;
				nint num12 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v18 (Il2CppClass<Layers>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num13 = (nint)typeof(Layers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v79 (Il2CppClass<Layers>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool startupFinished = LoadLevelCtrl.StartupFinished;
				bool startupFinished2 = LoadLevelCtrl.StartupFinished;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v23 (System.Boolean)+14]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v11 (System.Boolean)+C]");
				((UnityWebRequest)num14)._002Ector((string)0, (string)1);
				((IntMask*)fPSLog)->set_Item(1, (byte)fPSLog._autoRunLength != 0);
				fPSLog.IsUploadingFPS__BackingField = true;
				fPSLog.RunEnded();
				nint num15 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v29 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num16 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v75 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated = Game.IsInstantiated;
				((Game)isInstantiated).Update();
				nint num17 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v36 (Il2CppClass<UIScreenController>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num18 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v71 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag7 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag7).SwitchScreen("IngameUI");
				while (true)
				{
					nint num19 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v44 (Il2CppClass<UIScreenController>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num20 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v67 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag8 = UIScreenController.ShouldShowOnlineScreen();
					if (!((UIScreenController)flag8).IsPopupQueueEmpty())
					{
						break;
					}
					nint num21 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v57 (Il2CppClass<UIScreenController>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num22 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v63 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag9 = UIScreenController.ShouldShowOnlineScreen();
					((UIScreenController)flag9).DebugCloseAllPopups();
				}
				object obj15 = this + 12;
				Wait.Config.TimeConfig timeConfig = Wait.For(fPSLog._autoRunLength);
				Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])timeConfig);
				obj15 = coroutine;
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

	private sealed class _003CSendFPSAndFrameTime2Google_003Ed__76(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FPSLog _003C_003E4__this;

		public string fps;

		public string frametimes;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Expected Obj, but got Unknown
				//IL_0094: Expected I4, but got Obj
				//IL_00a0: Expected Obj, but got I4
				//IL_00b4: Expected Obj, but got I4
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0192: Expected Obj, but got Unknown
				//IL_019b: Expected Obj, but got I4
				//IL_01af: Expected Obj, but got I4
				//IL_00ff: Expected Obj, but got I
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Expected Obj, but got Unknown
				//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f3: Expected Obj, but got Unknown
				//IL_0204: Expected I4, but got Obj
				//IL_0210: Expected Obj, but got I4
				//IL_0224: Expected Obj, but got I4
				//IL_0127: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Expected Obj, but got Unknown
				FPSLog fPSLog = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (FPSLog)+3C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (FPSLog)+54]");
							if ((string)0 != "FPS_Data")
							{
								object obj = _003C_003E4__this + 84;
								obj = "FrameTime_Data";
							}
							else
							{
								object obj2 = _003C_003E4__this + 84;
								obj2 = "FrameTime_Data_Uncapped";
							}
							_ = 1;
							object obj3 = this + 12;
							bool flag = ((IntMask*)_003C_003E4__this)->get_Item((int)frametimes);
							obj3 = flag;
							_003C_003E1__state = 2;
							return 1;
						}
					}
					object obj4 = this + 12;
					obj4 = 0;
					_003C_003E1__state = 3;
					return 1;
				}
				_003C_003E1__state = -1;
				_ = 1;
				object obj5 = this + 12;
				bool flag2 = ((IntMask*)_003C_003E4__this)->get_Item((int)fps);
				obj5 = flag2;
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

	private sealed class _003CUpdate_003Ed__78(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FPSLog _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0393: Expected Obj, but got F4
				//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03cc: Expected Obj, but got Unknown
				//IL_03d5: Expected Obj, but got I4
				//IL_03e9: Expected Obj, but got I4
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Expected Obj, but got Unknown
				//IL_0234: Expected I4, but got F8
				//IL_0263: Expected Obj, but got I4
				//IL_028c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0291: Expected Obj, but got Unknown
				//IL_02a9: Expected I, but got Obj
				//IL_02bf: Expected Obj, but got I
				//IL_0440: Expected Ref, but got VT
				//IL_044c: Expected Obj, but got F4
				//IL_02ea: Expected I, but got Obj
				object obj = 0f;
				FPSLog fPSLog = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				if (~(fPSLog._logging ? 1u : 0u) == 0)
				{
					int frameCount = fPSLog._frameCount + 1;
					fPSLog._frameCount = frameCount;
					float fixedDeltaTime = Time.fixedDeltaTime;
					float num = (float)fPSLog._timeElapsed + fixedDeltaTime;
					fPSLog._timeElapsed = num;
					float fixedDeltaTime2 = Time.fixedDeltaTime;
					float num2 = (float)fPSLog._totalTimeElapsed + fixedDeltaTime2;
					fPSLog._totalTimeElapsed = num2;
					float fixedDeltaTime3 = Time.fixedDeltaTime;
					float num3 = (float)fPSLog._timeSinceLog + fixedDeltaTime3;
					fPSLog._timeSinceLog = num3;
					object obj2 = fPSLog - -64;
					float fixedDeltaTime4 = Time.fixedDeltaTime;
					((List<float>)obj2).Add(fixedDeltaTime4);
					if (fPSLog._timeElapsed > 1.0)
					{
						double num4 = (double)fPSLog._frameCount / fPSLog._timeElapsed;
						int fps;
						if (num4 != num4)
						{
							fps = int.MinValue;
						}
						else if (num4 < 2147483648.0)
						{
							fps = ((num4 > -2147483649.0) ? ((int)num4) : int.MinValue);
						}
						else
						{
							fps = int.MinValue;
						}
						fPSLog._fps = fps;
						fPSLog._frameCount = 0;
						fPSLog._timeElapsed = 0.0;
						if (~(fPSLog._skipEntry ? 1u : 0u) == 0)
						{
							fPSLog._skipEntry = false;
						}
						else
						{
							StringBuilder stringBuilder = fPSLog._fpsLog.Append((object)fPSLog._fps);
							StringBuilder stringBuilder2 = fPSLog._fpsLog.Append(59);
							object obj3 = fPSLog - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
							nint num5 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v49 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj4 = (nint)0 & (nint)0x200;
							if (obj4 != null)
							{
								nint num6 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v57 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Vector2 vector = default;
							float magnitude = ((Vector2*)vector)->magnitude;
							obj = magnitude;
							OverflowException value = new OverflowException();
							StringBuilder stringBuilder3 = fPSLog._frameTimeLog.AppendLine((string)(object)value);
							StringBuilder stringBuilder4 = fPSLog._frameTimeLog.Append(59);
						}
						throw new IndexOutOfRangeException();
					}
				}
				object obj5 = this + 12;
				obj5 = 0;
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, float> _003C_003E9__82_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			TutorialMultilineLabelsHelper._003C_003Ec obj = default;
			TutorialMultilineLabelsHelper._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal unsafe float _003CSend2GoogleSheet_003Eb__82_0(string x)
		{
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			string text = PathHandling.RelativeToAbsolutePath((string)(object)this, x);
			nint num = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<System.BitConverter>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return ((bool*)text)->System_002EIConvertible_002EToSingle((IFormatProvider)null);
		}
	}

	private sealed class _003CSend2GoogleSheet_003Ed__82(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string dataPoints;

		public FPSLog _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d18: Expected VT, but got Unknown
				//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d26: Expected Obj, but got Unknown
				//IL_0d2f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d34: Expected Obj, but got Unknown
				//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d42: Expected Obj, but got Unknown
				//IL_0d4b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d50: Expected Obj, but got Unknown
				//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d5e: Expected Obj, but got Unknown
				//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d6c: Expected Obj, but got Unknown
				//IL_0d75: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d7a: Expected Obj, but got Unknown
				//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d88: Expected Obj, but got Unknown
				//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d96: Expected Obj, but got Unknown
				//IL_0d9f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0da4: Expected Obj, but got Unknown
				//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
				//IL_0db2: Expected Obj, but got Unknown
				//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dc0: Expected Obj, but got Unknown
				//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dce: Expected Obj, but got Unknown
				//IL_0dd7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ddc: Expected Obj, but got Unknown
				//IL_0de5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dea: Expected Obj, but got Unknown
				//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0df8: Expected Obj, but got Unknown
				//IL_0e01: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e06: Expected Obj, but got Unknown
				//IL_0e0f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e14: Expected Obj, but got Unknown
				//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e22: Expected Obj, but got Unknown
				//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e30: Expected Obj, but got Unknown
				//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e3e: Expected Obj, but got Unknown
				//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e4c: Expected Obj, but got Unknown
				//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e5a: Expected Obj, but got Unknown
				//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e68: Expected Obj, but got Unknown
				//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e76: Expected Obj, but got Unknown
				//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e84: Expected Obj, but got Unknown
				//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e92: Expected Obj, but got Unknown
				//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ea0: Expected Obj, but got Unknown
				//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0eae: Expected Obj, but got Unknown
				//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ebc: Expected Obj, but got Unknown
				//IL_0ec5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0eca: Expected Obj, but got Unknown
				//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ed8: Expected Obj, but got Unknown
				//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ee6: Expected Obj, but got Unknown
				//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ef4: Expected Obj, but got Unknown
				//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f02: Expected Obj, but got Unknown
				//IL_0f0b: Expected Obj, but got I4
				//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f19: Expected Obj, but got Unknown
				//IL_0f22: Expected Obj, but got I4
				//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f30: Expected Obj, but got Unknown
				//IL_0f39: Expected Obj, but got I4
				//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f47: Expected Obj, but got Unknown
				//IL_0f50: Expected Obj, but got I4
				//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f5e: Expected Obj, but got Unknown
				//IL_0f67: Expected Obj, but got F4
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Expected Obj, but got Unknown
				//IL_008c: Expected Obj, but got I4
				//IL_00c4: Expected I, but got Obj
				//IL_00da: Expected Obj, but got I
				//IL_0105: Expected I, but got Obj
				//IL_0152: Expected I, but got Obj
				//IL_0168: Expected Obj, but got I
				//IL_0201: Expected Obj, but got I4
				//IL_0213: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Expected Obj, but got Unknown
				//IL_0231: Expected VT, but got Obj
				//IL_0fe3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fe8: Expected Obj, but got Unknown
				//IL_0fff: Expected I, but got Obj
				//IL_1015: Expected Obj, but got I
				//IL_0251: Expected I, but got Obj
				//IL_0267: Expected Obj, but got I
				//IL_0193: Expected I, but got Obj
				//IL_1044: Expected Obj, but got I
				//IL_1051: Expected Obj, but got I4
				//IL_1063: Unknown result type (might be due to invalid IL or missing references)
				//IL_1068: Expected Obj, but got Unknown
				//IL_1080: Expected VT, but got Obj
				//IL_02da: Expected Obj, but got I4
				//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f1: Expected Obj, but got Unknown
				//IL_030a: Expected VT, but got Obj
				//IL_0320: Expected Obj, but got I4
				//IL_0332: Unknown result type (might be due to invalid IL or missing references)
				//IL_0337: Expected Obj, but got Unknown
				//IL_0347: Expected Obj, but got I
				//IL_0357: Expected VT, but got Obj
				//IL_0292: Expected I, but got Obj
				//IL_037a: Expected Obj, but got I4
				//IL_0392: Expected Obj, but got I4
				//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a9: Expected Obj, but got Unknown
				//IL_03c1: Expected VT, but got Obj
				//IL_03dc: Expected I, but got Obj
				//IL_03f2: Expected Obj, but got I
				//IL_10a3: Expected Obj, but got VT
				//IL_10b1: Expected I, but got Obj
				//IL_10c7: Expected Obj, but got I
				//IL_1100: Expected Obj, but got I4
				//IL_1112: Unknown result type (might be due to invalid IL or missing references)
				//IL_1117: Expected Obj, but got Unknown
				//IL_112f: Expected VT, but got Obj
				//IL_041d: Expected I, but got Obj
				//IL_04bb: Expected Obj, but got I4
				//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d2: Expected Obj, but got Unknown
				//IL_04ea: Expected VT, but got Obj
				//IL_046a: Expected I, but got Obj
				//IL_050e: Expected Obj, but got I4
				//IL_0520: Unknown result type (might be due to invalid IL or missing references)
				//IL_0525: Expected Obj, but got Unknown
				//IL_053d: Expected VT, but got Obj
				//IL_055d: Expected I, but got Obj
				//IL_0573: Expected Obj, but got I
				//IL_115a: Expected Obj, but got I
				//IL_059e: Expected I, but got Obj
				object obj = default;
				KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)(obj + 312);
				object obj2 = obj + 208;
				object obj3 = obj + 288;
				object obj4 = obj + 192;
				object obj5 = obj + 280;
				object obj6 = obj + 184;
				object obj7 = obj + 272;
				object obj8 = obj + 176;
				object obj9 = obj + 264;
				object obj10 = obj + 160;
				object obj11 = obj + 256;
				object obj12 = obj + 152;
				object obj13 = obj + 240;
				object obj14 = obj + 136;
				object obj15 = obj + 224;
				object obj16 = obj + 128;
				object obj17 = obj + 216;
				object obj18 = obj + 112;
				object obj19 = obj + 200;
				object obj20 = obj + 104;
				object obj21 = obj + 168;
				object obj22 = obj + 96;
				object obj23 = obj + 144;
				object obj24 = obj + 80;
				object obj25 = obj - -64;
				object obj26 = obj + 120;
				object obj27 = obj + 56;
				object obj28 = obj + 88;
				object obj29 = obj + 40;
				object obj30 = obj + 72;
				object obj31 = obj + 32;
				object obj32 = obj + 48;
				object obj33 = obj + 16;
				object obj34 = obj + 24;
				object obj35 = obj + 8;
				UIPopupList uIPopupList = (UIPopupList)(obj + 248);
				uIPopupList = (UIPopupList)0;
				object obj36 = obj + 304;
				obj36 = 0;
				object obj37 = obj + 232;
				obj37 = 0;
				object obj38 = obj + 300;
				obj38 = 0;
				object obj39 = obj + 296;
				obj39 = 0f;
				FPSLog fPSLog = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				string text = dataPoints;
				if (text.m_stringLength > 60)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					string[] array = default;
					object obj40 = array + 16;
					obj40 = 59;
					string[] source = dataPoints.Split(array, StringSplitOptions.RemoveEmptyEntries);
					List<string> source2 = Enumerable.ToList(source);
					nint num = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v61 (Il2CppClass<FPSLog+<>c>)+BA]");
					object obj41 = (nint)0 & (nint)0x200;
					if (obj41 != null)
					{
						nint num2 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v371 (Il2CppClass<FPSLog+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = _003C_003Ec._003C_003E9__82_0 == null;
					bool flag2 = !flag;
					Func<string, float> selector = _003C_003Ec._003C_003E9__82_0;
					if (!flag2)
					{
						nint num3 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S1_v345 (Il2CppClass<FPSLog+<>c>)+BA]");
						object obj42 = (nint)0 & (nint)0x200;
						if (obj42 != null)
						{
							nint num4 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S1_v365 (Il2CppClass<FPSLog+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num5 = 0;
						_ = 0;
						Func<string, float> func = default;
						object obj43 = func + 16;
						obj43 = _003C_003Ec._003C_003E9;
						nint num6 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v362 (Il2CppClass<FPSLog+<>c>)+5C]");
						object obj44 = (nint)0 + (nint)4;
						obj44 = func;
						selector = func;
					}
					IEnumerable<float> source3 = Enumerable.Select(source2, selector);
					float[] array2 = Enumerable.ToArray(source3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Uri uri = default;
					uri.CreateThisFromUri((Uri)(object)"https://script.google.com/macros/s/AKfycbz2lBaGXHu05CgN1mXAr217sresz20BwK_3YwuHO2sHx_eJu5g/exec");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					List<KeyValuePair<string, string>> list = default;
					list._002Ector();
					obj2 = 0;
					obj2 = "ssid";
					object obj45 = obj2 + 4;
					obj45 = "1d4AZJWVKm1c438UX21RZIMHGpzjRd013Bmk10_n5tmU";
					obj3 = obj2;
					keyValuePair = (KeyValuePair<string, string>)obj3;
					list.Add(keyValuePair);
					nint num7 = (nint)typeof(ThemeManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v126 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
					object obj46 = (nint)0 & (nint)0x200;
					if (obj46 != null)
					{
						nint num8 = (nint)typeof(ThemeManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S0_v472 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					GameStateMachine instance = GameStateMachine.Instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v131 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
					UnityEngine.Object obj47 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
					obj4 = 0;
					obj4 = "sheet";
					object obj48 = obj4 + 4;
					obj48 = obj47;
					obj5 = obj4;
					keyValuePair = (KeyValuePair<string, string>)obj5;
					list.Add(keyValuePair);
					obj6 = 0;
					obj6 = "action";
					object obj49 = obj6 + 4;
					obj49 = "POST";
					obj7 = obj6;
					keyValuePair = (KeyValuePair<string, string>)obj7;
					list.Add(keyValuePair);
					obj8 = 0;
					obj8 = "groupby";
					object obj50 = obj8 + 4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v89 (FPSLog)+54]");
					obj50 = 0;
					obj9 = obj8;
					keyValuePair = (KeyValuePair<string, string>)obj9;
					list.Add(keyValuePair);
					SystemLanguage systemLanguage = Application.systemLanguage;
					obj36 = systemLanguage;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					obj10 = 0;
					obj10 = "targetframerate";
					object obj51 = obj10 + 4;
					object obj52 = default;
					obj51 = obj52;
					obj11 = obj10;
					keyValuePair = (KeyValuePair<string, string>)obj11;
					list.Add(keyValuePair);
					nint num9 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S0_v186 (Il2CppClass<System.DateTime>)+BA]");
					object obj53 = (nint)0 & (nint)0x200;
					if (obj53 != null)
					{
						nint num10 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v468 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					DateTime utcNow = DateTime.UtcNow;
					obj37 = utcNow;
					nint num11 = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S0_v192 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
					object obj54 = (nint)0 & (nint)0x200;
					if (obj54 != null)
					{
						nint num12 = (nint)typeof(CultureInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S0_v464 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CultureInfo currentCulture = CultureInfo.CurrentCulture;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF7");
					obj12 = 0;
					obj12 = "val";
					object obj55 = obj12 + 4;
					object obj56 = default;
					obj55 = obj56;
					obj13 = obj12;
					keyValuePair = (KeyValuePair<string, string>)obj13;
					list.Add(keyValuePair);
					string graphicsDeviceName = SystemInfo.GetGraphicsDeviceName();
					obj14 = 0;
					obj14 = "val";
					object obj57 = obj14 + 4;
					obj57 = graphicsDeviceName;
					obj15 = obj14;
					keyValuePair = (KeyValuePair<string, string>)obj15;
					list.Add(keyValuePair);
					string deviceModel = SystemInfo.GetDeviceModel();
					obj16 = 0;
					obj16 = "val";
					object obj58 = obj16 + 4;
					obj58 = deviceModel;
					obj17 = obj16;
					keyValuePair = (KeyValuePair<string, string>)obj17;
					list.Add(keyValuePair);
					nint num13 = (nint)typeof(DeviceInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ S0_v236 (Il2CppClass<DeviceInfo>)+BA]");
					object obj59 = (nint)0 & (nint)0x200;
					if (obj59 != null)
					{
						nint num14 = (nint)typeof(DeviceInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v460 (Il2CppClass<DeviceInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S1_v170 (System.Int32)+8]");
					obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					throw new NullReferenceException();
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
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

	private static FPSLog _instance;

	private bool _logging;

	private int _frameCount;

	private int _fps;

	private double _timeElapsed;

	private double _totalTimeElapsed;

	private double _timeSinceLog = 0.0;

	private double _timeToLog;

	private StringBuilder _fpsLog;

	private const int MAX_LOG_SIZE = 1000;

	private bool _loggingFrameTimes;

	private List<float> _frameTimes;

	private StringBuilder _frameTimeLog;

	private bool previousColliderState;

	private int originalScreenTimeout;

	private IEnumerator _updateCoroutine;

	private const string GOOGLE_SCRIPT_URL = "https://script.google.com/macros/s/AKfycbz2lBaGXHu05CgN1mXAr217sresz20BwK_3YwuHO2sHx_eJu5g/exec";

	private const string GOOGLE_SHEET_ID = "1d4AZJWVKm1c438UX21RZIMHGpzjRd013Bmk10_n5tmU";

	private string _groupingUsed;

	private const string GROUPING_DEFAULT_NAME = "FPS_Data";

	private const string GROUPING_UNCAPPED_NAME = "FPS_Data_Uncapped";

	private const string GROUPING_FRAMETIME_DEFAULT_NAME = "FrameTime_Data";

	private const string GROUPING_FRAMETIME_UNCAPPED_NAME = "FrameTime_Data_Uncapped";

	private const string UPLOAD_SUCCESS_RESPONSE = "Upload Successful";

	private const string CONNECTION_TEST_SUCCESS_RESPONSE = "Connection Established";

	private const string SPREADSHEET_ID_PARAMETER_KEY = "ssid";

	private const string WORKSHEET_NAME_PARAMETER_KEY = "sheet";

	private const string ACTION_PARAMETER_KEY = "action";

	private const string GROUPBY_PARAMETER_KEY = "groupby";

	private const string ACTION_CONNECT_TEST_PARAMETER_VALUE = "ConnectionTest";

	private const string ACTION_UPLOAD_PARAMETER_VALUE = "POST";

	private const string DATA_DEFAULT_PARAMETER_KEY = "val";

	private const string DATA_TARGETFRAMERATE_PARAMETER_KEY = "targetframerate";

	private bool _skipEntry;

	private bool _retryUploadIfFailed;

	public const int DEFAULT_AUTORUN_LENGTH = 600;

	private int _autoRunLength;

	private bool _useCustomFramerate;

	private int _targetFramerate;

	public const int DEFAULT_PERFORMANCE_DEVICE_FRAMERATE = 60;

	public const int LOW_PERFORMANCE_DEVICE_FRAMERATE = 20;

	public const int HIGH_PERFORMANCE_DEVICE_FRAMERATE = 40;

	public const int HIGH_PERFORMANCE_IOS_DEVICE_FRAMERATE = 30;

	public const int DEFAULT_LOGGING_FREQUENCY = 60;

	public bool RunTestologyCappedTest;

	public bool RunTestologyUnCappedTest;

	private string _lastCappedRunResult;

	private string _lastUncappedRunResult;

	private bool IsLoggingFPS__BackingField;

	private bool IsUploadingFPS__BackingField;

	public static FPSLog instance
	{
		get
		{
			//IL_0234: Expected I, but got Obj
			//IL_024a: Expected Obj, but got I
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_027e: Expected Obj, but got I4
			//IL_005b: Expected Obj, but got I4
			//IL_010a: Expected I, but got Obj
			//IL_0120: Expected Obj, but got I
			//IL_00af: Expected I, but got Obj
			//IL_00f7: Expected Obj, but got I4
			//IL_01a6: Expected I, but got Obj
			//IL_01bc: Expected Obj, but got I
			//IL_014b: Expected I, but got Obj
			//IL_02ff: Expected Obj, but got I4
			//IL_0193: Expected Obj, but got I4
			//IL_01e7: Expected I, but got Obj
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v55 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_USE_DEBUG_LOGIN_STATE ? 1u : 0u) == 0)
			{
				return (FPSLog)1;
			}
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<SocialManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v50 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
			{
				return (FPSLog)1;
			}
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v23 (Il2CppClass<SocialManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v45 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v28 (System.Boolean)+60]");
			if ((nint)0 == 2)
			{
				return (FPSLog)1;
			}
			nint num7 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v32 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v40 (Il2CppClass<SocialManagerIOS>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstanced = SocialManagerIOS.isInstanced;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v37 (System.Boolean)+C]");
			bool flag = (nint)0 != 0;
			return (FPSLog)flag;
		}
	}

	public int autoRunLength
	{
		get
		{
			//IL_0026: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			return (int)$"{args:#,##0.##}";
		}
	}

	public int targetFramerate => _autoRunLength;

	public bool useCustomFramerate => (byte)_targetFramerate != 0;

	private string SetLastRunResult
	{
		set
		{
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got Unknown
			//IL_0145: Expected Obj, but got I4
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected Obj, but got Unknown
			//IL_0162: Expected Obj, but got I4
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected Obj, but got Unknown
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Expected Obj, but got Unknown
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected Obj, but got Unknown
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected Obj, but got Unknown
			//IL_01fc: Expected I, but got Obj
			//IL_0212: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Expected Obj, but got Unknown
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Expected Obj, but got Unknown
			//IL_0091: Expected Obj, but got I
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Expected Obj, but got Unknown
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e7: Expected Obj, but got Unknown
			//IL_007c: Expected Obj, but got I
			//IL_00bb: Expected Obj, but got I
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Expected Obj, but got Unknown
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0370: Expected Obj, but got Unknown
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Expected Obj, but got Unknown
			//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Expected Obj, but got Unknown
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Expected Obj, but got Unknown
			//IL_00a6: Expected Obj, but got I
			//IL_0420: Unknown result type (might be due to invalid IL or missing references)
			//IL_0425: Expected Obj, but got Unknown
			//IL_0443: Unknown result type (might be due to invalid IL or missing references)
			//IL_0448: Expected Obj, but got Unknown
			//IL_00ff: Expected Obj, but got I
			//IL_049f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a4: Expected Obj, but got Unknown
			//IL_00ea: Expected Obj, but got I
			//IL_0129: Expected Obj, but got I
			//IL_0114: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 + 180;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 168;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 156;
			object obj5 = this + 20;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v11+8]");
			_ = 0;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			_ = 0;
			object obj6 = obj2 + 144;
			obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			_ = 0;
			object obj7 = obj2 + 132;
			obj7 = value;
			_ = value.m_stringLength;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v92 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7)) ? obj7 : obj6);
			obj = obj9;
			object obj10 = obj2 + 120;
			obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj11 = obj2 + 108;
			obj11 = value;
			_ = value.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v36+4]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v41+4]");
			if (num3 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v36+4]");
				object obj12 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v41+4]");
				object obj12 = 0;
			}
			object obj13 = obj2 + 96;
			obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj14 = obj2 + 84;
			obj14 = value;
			_ = value.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v45+8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v50+8]");
			if (num4 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v45+8]");
				object obj15 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v50+8]");
				object obj15 = 0;
			}
			object obj16 = obj2 + 192;
			obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7516");
			object obj17 = obj2 + 72;
			object obj18 = this + 32;
			obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v67+8]");
			_ = 0;
			obj3 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v58+8]");
			_ = 0;
			object obj19 = obj2 + 60;
			obj19 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v58+8]");
			_ = 0;
			object obj20 = obj2 + 48;
			obj20 = value;
			_ = value.m_stringLength;
			object obj21 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20)) ? obj20 : obj19);
			obj3 = obj21;
			object obj22 = obj2 + 36;
			obj22 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			object obj23 = obj2 + 24;
			obj23 = value;
			_ = value.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v72+4]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v77+4]");
			if (num5 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v72+4]");
				object obj24 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v77+4]");
				object obj24 = 0;
			}
			object obj25 = obj2 + 12;
			obj25 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			obj2 = value;
			_ = value.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v81+8]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			if (num6 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v81+8]");
				object obj26 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				object obj26 = 0;
			}
			obj16 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		}
	}

	public bool IsLoggingFPS
	{
		get
		{
			return _useCustomFramerate;
		}
		private set
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			//IL_0055: Expected Obj, but got I4
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected Obj, but got Unknown
			//IL_003d: Expected Obj, but got I4
			if (_targetFramerate == 60)
			{
				object obj = this + 112;
				obj = value;
			}
			else
			{
				object obj2 = this + 108;
				obj2 = value;
			}
		}
	}

	public bool IsUploadingFPS
	{
		get
		{
			return IsLoggingFPS__BackingField;
		}
		private set
		{
			IsLoggingFPS__BackingField = value;
		}
	}

	public void SetFPSUpload(bool value)
	{
		IsUploadingFPS__BackingField = value;
	}

	public void SetFPSFramerate(int value = 0)
	{
		int num = value & 1;
		IsUploadingFPS__BackingField = (byte)num != 0;
	}

	public void SetFPSAutoLength(int value = 0)
	{
		//IL_01c3: Expected Obj, but got I4
		//IL_005b: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_009c: Expected I, but got Obj
		object obj = value - -1;
		if (value != -1)
		{
			if ((nint)obj == 1)
			{
				_useCustomFramerate = false;
				_targetFramerate = 60;
			}
			else
			{
				_useCustomFramerate = true;
				_targetFramerate = value;
			}
		}
		else
		{
			_useCustomFramerate = false;
			nint num = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v12 (Il2CppClass<DeviceInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v27 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v17 (System.Int32)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v17 (System.Int32)+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v17 (System.Int32)+8]");
					if ((nint)0 == 2)
					{
						string dataPath = Application.dataPath;
						if ((nint)dataPath == 8)
						{
							_targetFramerate = 30;
						}
						else
						{
							_targetFramerate = 40;
						}
						goto IL_01e0;
					}
				}
				_targetFramerate = 60;
			}
			else
			{
				_targetFramerate = 20;
			}
		}
		goto IL_01e0;
		IL_01e0:
		Application.SetLogCallbackDefined((byte)_targetFramerate != 0);
	}

	public void StartAutoFPSTest(bool runPreset = false, bool runFrameTimes = false)
	{
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_00ea: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)runPreset).FindKernel(null) != 0)
		{
			((Camera)runPreset).transparencySortMode = (runFrameTimes ? TransparencySortMode.Perspective : TransparencySortMode.Default);
			if (runFrameTimes)
			{
				((Camera)runPreset).farClipPlane = -5f;
			}
			else
			{
				((Camera)runPreset).farClipPlane = 0.1f;
			}
		}
	}

	private IEnumerator FPSTestRoutine(bool runPreset = false, bool runFrameTimes = false)
	{
		//IL_0253: Expected I, but got Obj
		//IL_0269: Expected Obj, but got I
		//IL_034d: Expected Obj, but got I
		//IL_034d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_02b2: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_007c: Expected I, but got Obj
		//IL_0319: Expected Obj, but got I4
		//IL_01a1: Expected I4, but got Obj
		//IL_01a1: Expected I4, but got Obj
		//IL_0142: Expected I, but got Obj
		//IL_01b7: Expected I4, but got Obj
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v57 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = runFrameTimes;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FPSLog)+14]");
		string[] values = (string[])(object)((!((UnityEngine.Object)flag != (UnityEngine.Object)0)) ? "Prefabs/Screens/" : "Prefabs/Popups/");
		string path = string.ConcatArray(values, runPreset ? 1 : 0);
		_0021_00210[] array = (_0021_00210[])(object)Resources.LoadAll<T>(path);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)array != null)
		{
			string msg = string.ConcatArray((string[])(object)"Attempted to load invalid screenName: ", runPreset ? 1 : 0);
			SDebug.LogFormat(msg, null);
			return null;
		}
		int layer = ((GameObject)runFrameTimes).layer;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreen uIScreen = UnityEngine.Object.Instantiate((UIScreen)(object)array, (Transform)layer);
		GameObject gameObject = uIScreen.gameObject;
		UIExtensions.RepositionImmediately((UIGrid)(object)gameObject);
		UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)uIScreen);
		string text = ((string)(object)obj4).Remove((int)"(Clone)", (int)"");
		UnityEngine.Object.DestroyImmediate(uIScreen, (byte)(int)text != 0);
		object obj5 = uIScreen + 32;
		obj5 = runPreset;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S4_v4 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S4_v5+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S4_v6+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v107 @ S5_v5 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		return (IEnumerator)uIScreen;
	}

	private void ResetAutoFPS()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v22 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 12;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void SetFPSLogging(bool shouldEnable, int frequency = 60)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		IEnumerator list = SendFPSAndFrameTime2Google((string)shouldEnable, (string)frequency);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private IEnumerator AutoFPSTest()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = IsUploadingFPS__BackingField;
		return (IEnumerator)flag;
	}

	private unsafe void RunStarted()
	{
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0111: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_0152: Expected I, but got Obj
		nint num = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Layers>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool startupFinished = LoadLevelCtrl.StartupFinished;
		bool startupFinished2 = LoadLevelCtrl.StartupFinished;
		bool flag = previousColliderState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+14]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v4 (System.Boolean)+C]");
		((UnityWebRequest)num3)._002Ector((string)0, (string)flag);
		object obj2 = this + 84;
		obj2 = "FPS_Data";
		object obj3 = this + 108;
		obj3 = "Not Run";
		object obj4 = this + 112;
		obj4 = "Not Run";
		((IntMask*)this)->set_Item(0, true);
		IsUploadingFPS__BackingField = false;
		SetFPSAutoLength();
		_loggingFrameTimes = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FPSLog.ResetAutoFPS);
		object obj5 = action + 16;
		obj5 = this;
		nint num4 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v30 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v35 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameDestroyed += action;
	}

	private void RunEnded()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		object obj = this + 56;
		obj = stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder2 = default;
		System.Text.StringBuilderCache.Release(stringBuilder2);
		object obj2 = this + 68;
		obj2 = stringBuilder2;
		_frameCount = 0;
		_fps = 0;
		_timeElapsed = 0.0;
		_totalTimeElapsed = 0.0;
		_timeSinceLog = 0.0;
		_logging = true;
		_skipEntry = true;
	}

	private IEnumerator SendFPSAndFrameTime2Google(string fps, string frametimes)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		object obj2 = fps & 1;
		object obj3 = frametimes & 1;
		return enumerator;
	}

	private void PauseChanged(bool isPaused)
	{
		if (isPaused)
		{
			_autoRunLength = (isPaused ? 1 : 0);
		}
		else
		{
			_autoRunLength = 600;
		}
	}

	private IEnumerator Update()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void Log()
	{
		//IL_002c: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I4
		//IL_009a: Expected I4, but got Obj
		_logging = false;
		this._002Ector();
		if (~(IsUploadingFPS__BackingField ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			NormalizationForm normalizationForm = default;
			object obj = normalizationForm + 16;
			obj = 59;
			string text = default;
			string container = text.Normalize(normalizationForm);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			NormalizationForm normalizationForm2 = default;
			object obj2 = normalizationForm2 + 16;
			obj2 = 59;
			string text3 = default;
			string text2 = text3.Normalize(normalizationForm2);
			IEnumerator list = ((ProductPlacementManager)this).DownloadProductPlacement((SpriteContainer)(object)container, (int)text2);
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
		}
		IsUploadingFPS__BackingField = false;
		CoroutineUtil.StopCoroutine((Coroutine)(object)_updateCoroutine);
	}

	public bool TestGoogleConnection()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	public unsafe KeyValuePair<bool, string> SendRequest(string url, float timeout)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_01be: Expected I4, but got F4
		//IL_01ce: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01f3: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0223: Expected VT, but got Obj
		//IL_000e: Expected Obj, but got F4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0046: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected VT, but got Unknown
		//IL_0243: Expected F4, but got Obj
		//IL_023e: Expected native int or pointer, but got VT
		//IL_0255: Expected F4, but got I
		//IL_0250: Expected native int or pointer, but got VT
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected VT, but got Unknown
		//IL_026b: Expected VT, but got Obj
		//IL_0291: Expected VT, but got Obj
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0087: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		object obj3 = default;
		obj = obj3;
		object obj4 = obj2 + 12;
		obj4 = url;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ L0+30]");
		if (!((UIScrollView)0).canMoveVertically)
		{
			FPSLog fPSLog = (FPSLog)0f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ L0+30]");
		if (!((UIScrollView)0).shouldMoveHorizontally)
		{
			_ = 0f;
		}
		_logging = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ L0+30]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v27+68]");
		Camera anchorCamera = ((UIRect)0).anchorCamera;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ L0+30]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v31+68]");
		Transform cachedTransform = ((UIRect)0).cachedTransform;
		object obj7 = default;
		Transform transform = (Transform)(obj7 + 24);
		transform.localPosition = (Vector3)anchorCamera;
		object obj8 = obj7 + 12;
		obj8 = this;
		_ = _logging;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v43 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj7 + 36);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		KeyValuePair<bool, string> keyValuePair = (KeyValuePair<bool, string>)(obj7 + 48);
		keyValuePair = (KeyValuePair<bool, string>)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v18+8]");
		_ = 0;
		Quaternion quaternion = Quaternion.FromToRotation(vector, (Vector3)keyValuePair);
		keyValuePair = (KeyValuePair<bool, string>)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		SpringPosition springPosition = SpringPosition.Begin((GameObject)(object)cachedTransform, (Vector3)keyValuePair, timeout);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj11 = default;
		object obj10 = obj11 + 16;
		obj10 = obj2;
		object obj12 = springPosition + 28;
		obj12 = obj11;
		return keyValuePair;
	}

	private IEnumerator Send2GoogleSheet(string dataPoints)
	{
		//IL_000e: Expected I, but got Obj
		//IL_0068: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		//IL_011f: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I
		Animation component = default;
		Transform parentInternal2 = default;
		string text = default;
		while (true)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
			while (true)
			{
				int num2 = ((ComputeShader)(object)component).FindKernel((string)null);
				Animation result = component;
				if (num2 == 0)
				{
					Transform parentInternal = parentInternal2.parentInternal;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
					{
						parentInternal2 = ((Transform)(object)text).parentInternal;
						component = parentInternal2.GetComponent<Animation>();
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							break;
						}
						continue;
					}
					result = null;
				}
				return (IEnumerator)(object)result;
			}
		}
	}

	public FPSLog()
	{
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v17 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7+8]");
		float f = 0f / 1000f;
		int num3 = Mathf.FloorToInt(f);
		object obj2 = 0;
		while ((nint)obj2 <= num3)
		{
			object obj3 = obj2 + 1;
			obj2 = obj3;
		}
	}
}
