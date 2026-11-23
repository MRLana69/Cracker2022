using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Subway;
using UnityEngine;

public class FPSLog
{
	private sealed class _003CFPSTestRoutine_003Ed__71(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public bool runPreset;

		public FPSLog _003C_003E4__this;

		public bool runFrameTimes;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_02bb: Expected Obj, but got I
			//IL_02bb: Expected Obj, but got I
			FPSLog fPSLog = _003C_003E4__this;
			int num;
			bool result = default;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Action action = default;
					action._002Ector(fPSLog, (nint)__ldftn(FPSLog.ResetAutoFPS));
					Game.OnMenuScreenShown += action;
					goto IL_020b;
				}
				if (_003C_003E1__state == 2)
				{
					_003C_003E1__state = -1;
					goto IL_026f;
				}
				if (_003C_003E1__state == 3)
				{
					_003C_003E1__state = -1;
					goto IL_0294;
				}
				bool flag = _003C_003E1__state == 4;
				num = -1;
				if (!flag)
				{
					goto IL_026a;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if (~(runPreset ? 1u : 0u) == 0)
				{
					_ = runFrameTimes;
					IEnumerator enumerator = fPSLog.AutoFPSTest();
					_003C_003E2__current = enumerator;
					result = true;
					num = 1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (FPSLog)+68]");
					if ((nint)0 == 0)
					{
						goto IL_026f;
					}
					_ = runFrameTimes;
					fPSLog.SetFPSFramerate(-1);
					_ = 1;
					IEnumerator enumerator2 = fPSLog.AutoFPSTest();
					_003C_003E2__current = enumerator2;
					result = true;
					num = 2;
				}
			}
			goto IL_025b;
			IL_026a:
			return result;
			IL_0294:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (FPSLog)+6C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (FPSLog)+70]");
			string message = "FPS tests have been executed\n\nTest results:\n  Capped Test: " + (string)num2 + "\n  UncappedTest: " + (string)0;
			DeviceUtility.ShowNativePopup("FPS Results", message, "Ok");
			goto IL_020b;
			IL_025b:
			_003C_003E1__state = num;
			goto IL_026a;
			IL_020b:
			fPSLog.ResetAutoFPS();
			_003C_003E2__current = null;
			result = true;
			num = 4;
			goto IL_025b;
			IL_026f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (FPSLog)+69]");
			if ((nint)0 != 0)
			{
				_ = runFrameTimes;
				fPSLog.SetFPSFramerate(60);
				_ = 1;
				IEnumerator enumerator3 = fPSLog.AutoFPSTest();
				_003C_003E2__current = enumerator3;
				result = true;
				num = 3;
				goto IL_025b;
			}
			goto IL_0294;
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

	private sealed class _003CAutoFPSTest_003Ed__74(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FPSLog _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0187: Expected F4, but got I4
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
							UIScreenController instance = UIScreenController.Instance;
							instance.ClosePopup();
						}
						return false;
					}
					_003C_003E1__state = -1;
					UIScreenController instance3;
					while (true)
					{
						UIScreenController instance2 = UIScreenController.Instance;
						bool isShowingPopup = instance2.isShowingPopup;
						instance3 = UIScreenController.Instance;
						if (!isShowingPopup)
						{
							break;
						}
						instance3.ClosePopup();
					}
					instance3.PushScreen("FrontUI");
					_ = 0.2f;
					object obj = default;
					_003C_003E2__current = obj;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E1__state = -1;
				GameStats instance4 = GameStats.Instance;
				instance4.ResetGame();
				Game instance5 = Game.Instance;
				instance5.ChangeState(null, Game.GameStateCoroutineType.DieSequence);
				fPSLog.RunEnded();
				_ = 10f;
				object obj2 = default;
				_003C_003E2__current = obj2;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			fPSLog.previousColliderState = Globals.DEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS;
			Layers instance6 = Layers.Instance;
			Layers instance7 = Layers.Instance;
			Physics.IgnoreLayerCollision(instance6.Character, instance7.Hit, ignore: true);
			fPSLog.SetFPSLogging(shouldEnable: true, fPSLog._autoRunLength);
			fPSLog.IsUploadingFPS__BackingField = true;
			fPSLog.RunStarted();
			Game instance8 = Game.Instance;
			instance8.StartNewGame(duel: false);
			UIScreenController instance9 = UIScreenController.Instance;
			instance9.PushScreen("IngameUI");
			while (true)
			{
				UIScreenController instance10 = UIScreenController.Instance;
				if (!instance10.isShowingPopup)
				{
					break;
				}
				UIScreenController instance11 = UIScreenController.Instance;
				instance11.ClosePopup();
			}
			IEnumerator coroutine = CoroutineUtil.WaitForRealSeconds(fPSLog._autoRunLength);
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
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

	private sealed class _003CSendFPSAndFrameTime2Google_003Ed__77(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FPSLog _003C_003E4__this;

		public string fps;

		public string frametimes;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			FPSLog fPSLog = _003C_003E4__this;
			int num;
			bool result = default;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						bool flag = _003C_003E1__state == 3;
						num = -1;
						if (flag)
						{
							goto IL_0159;
						}
						goto IL_0168;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					if (~(fPSLog._loggingFrameTimes ? 1u : 0u) == 0)
					{
						bool flag2 = fPSLog._groupingUsed != "FPS_Data";
						object groupingUsed = "FrameTime_Data";
						if (flag2)
						{
							groupingUsed = "FrameTime_Data_Uncapped";
						}
						fPSLog._groupingUsed = (string)groupingUsed;
						fPSLog._retryUploadIfFailed = true;
						IEnumerator enumerator = fPSLog.Send2GoogleSheet(frametimes);
						_003C_003E2__current = enumerator;
						result = true;
						num = 2;
						goto IL_0159;
					}
				}
				_003C_003E2__current = null;
				result = true;
				num = 3;
			}
			else
			{
				_003C_003E1__state = -1;
				fPSLog._retryUploadIfFailed = true;
				IEnumerator enumerator2 = fPSLog.Send2GoogleSheet(fps);
				_003C_003E2__current = enumerator2;
				result = true;
				num = 1;
			}
			goto IL_0159;
			IL_0168:
			return result;
			IL_0159:
			_003C_003E1__state = num;
			goto IL_0168;
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

	private sealed class _003CUpdate_003Ed__79(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FPSLog _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0198: Expected F8, but got I4
			//IL_0391: Expected I4, but got F8
			//IL_01c2: Expected I4, but got F8
			//IL_03d0: Expected Ref, but got F4
			//IL_02d0: Expected Obj, but got I
			//IL_021c: Expected Obj, but got I4
			//IL_025e: Invalid comparison between F4 and I
			//IL_040f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0414: Expected Obj, but got Unknown
			//IL_02a8: Expected F4, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			if (_003C_003E1__state <= 1)
			{
				FPSLog fPSLog = _003C_003E4__this;
				_003C_003E1__state = -1;
				if (~(fPSLog._logging ? 1u : 0u) == 0)
				{
					int frameCount = fPSLog._frameCount + 1;
					fPSLog._frameCount = frameCount;
					float unscaledDeltaTime = Time.unscaledDeltaTime;
					float num = (float)fPSLog._timeElapsed + unscaledDeltaTime;
					fPSLog._timeElapsed = num;
					float unscaledDeltaTime2 = Time.unscaledDeltaTime;
					float num2 = (float)fPSLog._totalTimeElapsed + unscaledDeltaTime2;
					fPSLog._totalTimeElapsed = num2;
					float unscaledDeltaTime3 = Time.unscaledDeltaTime;
					float num3 = (float)fPSLog._timeSinceLog + unscaledDeltaTime3;
					fPSLog._timeSinceLog = num3;
					float unscaledDeltaTime4 = Time.unscaledDeltaTime;
					fPSLog._frameTimes.Add(unscaledDeltaTime4);
					if (fPSLog._timeElapsed > 1.0)
					{
						double num4 = (double)fPSLog._frameCount / fPSLog._timeElapsed;
						double num5 = Math.Abs(num4);
						if (!(num5 < 2147483648.0))
						{
							num4 = -2147483648.0;
						}
						fPSLog._timeElapsed = 0.0;
						fPSLog._frameCount = 0;
						fPSLog._fps = (int)num4;
						if (~(fPSLog._skipEntry ? 1u : 0u) == 0)
						{
							fPSLog._skipEntry = false;
						}
						else
						{
							StringBuilder stringBuilder = fPSLog._fpsLog.Append((int)num4);
							StringBuilder stringBuilder2 = fPSLog._fpsLog.Append(';');
							float[] array = fPSLog._frameTimes.ToArray();
							if (array.Length != 0)
							{
								object obj3 = 1;
								float num6 = array[0];
								while ((nint)obj3 < array.Length)
								{
									object obj4 = obj3 << 2;
									object obj5 = (object)array + obj4;
									float num7 = num6;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v52+10]");
									if (num7 < 0f)
									{
										object obj6 = obj3 << 2;
										object obj7 = (object)array + obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v92+10]");
										num6 = 0f;
									}
									object obj8 = obj3 + 1;
									obj3 = obj8;
								}
							}
							float num8 = (float)obj + 12f;
							string value = ((float*)num8)->ToString("0.00");
							StringBuilder stringBuilder3 = fPSLog._frameTimeLog.Append(value);
							StringBuilder stringBuilder4 = fPSLog._frameTimeLog.Append(';');
						}
						List<float> frameTimes = fPSLog._frameTimes;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v50 (System.Collections.Generic.List`1<System.Single>)+10]");
						object obj9 = (nint)0 + (nint)1;
						_ = 0;
						if (fPSLog._timeSinceLog > fPSLog._timeToLog)
						{
							fPSLog.Log();
						}
					}
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
			}
			return _003C_003E1__state < 2;
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

	private sealed class _003CSend2GoogleSheet_003Ed__83(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string dataPoints;

		public FPSLog _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			object obj = default;
			KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)(obj - 464);
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
				}
			}
			else
			{
				FPSLog fPSLog = _003C_003E4__this;
				_003C_003E1__state = -1;
				string text = dataPoints;
				if (text._stringLength >= 61)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					char[] array = default;
					array[0] = ';';
					string[] source = text.Split(array, StringSplitOptions.RemoveEmptyEntries);
					List<string> list = Enumerable.ToList(source);
					throw new ArgumentException();
				}
			}
			bool result = default;
			return result;
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

	private static FPSLog _instance;

	private bool _logging;

	private int _frameCount;

	private int _fps;

	private double _timeElapsed;

	private double _totalTimeElapsed;

	private double _timeSinceLog;

	private double _timeToLog = 60.0;

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

	private static Func<string, float> _003C_003Ef__mg_0024cache0;

	private bool IsLoggingFPS__BackingField;

	private bool IsUploadingFPS__BackingField;

	public static FPSLog instance
	{
		get
		{
			if (_instance == null)
			{
				FPSLog fPSLog = default;
				fPSLog._002Ector();
				_instance = fPSLog;
			}
			return _instance;
		}
	}

	public int autoRunLength => _autoRunLength;

	public int targetFramerate => _targetFramerate;

	public bool useCustomFramerate => _useCustomFramerate;

	private string SetLastRunResult
	{
		set
		{
			if (_targetFramerate == 60)
			{
				_lastUncappedRunResult = value;
			}
			else
			{
				_lastCappedRunResult = value;
			}
		}
	}

	public bool IsLoggingFPS
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

	public bool IsUploadingFPS
	{
		get
		{
			return IsUploadingFPS__BackingField;
		}
		private set
		{
			IsUploadingFPS__BackingField = value;
		}
	}

	public void SetFPSUpload(bool value)
	{
		IsUploadingFPS__BackingField = value;
	}

	public void SetFPSFramerate(int value = 0)
	{
		//IL_018c: Expected Obj, but got I4
		int num = default;
		object obj = num + 1;
		if (obj != null)
		{
			if ((nint)obj == 1)
			{
				_targetFramerate = 60;
				_useCustomFramerate = false;
				num = 60;
			}
			else
			{
				_targetFramerate = num;
				_useCustomFramerate = true;
			}
		}
		else
		{
			_useCustomFramerate = false;
			DeviceInfo deviceInfo = DeviceInfo.Instance;
			if (deviceInfo.performanceLevel != DeviceInfo.PerformanceLevel.Low)
			{
				if (deviceInfo.performanceLevel != DeviceInfo.PerformanceLevel.Medium && deviceInfo.performanceLevel == DeviceInfo.PerformanceLevel.High)
				{
					RuntimePlatform platform = Application.platform;
					if (platform == RuntimePlatform.IPhonePlayer)
					{
						_targetFramerate = 30;
						num = 30;
					}
					else
					{
						_targetFramerate = 40;
						num = 40;
					}
				}
				else
				{
					_targetFramerate = 60;
					num = 60;
				}
			}
			else
			{
				_targetFramerate = 20;
				num = 20;
			}
		}
		Application.targetFrameRate = num;
	}

	public void SetFPSAutoLength(int value = 0)
	{
		int num = value;
		if (value == 0)
		{
			num = 600;
		}
		_autoRunLength = num;
	}

	public void StartAutoFPSTest(bool runPreset = false, bool runFrameTimes = false)
	{
		IEnumerator coroutine = FPSTestRoutine(runPreset, runFrameTimes);
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
	}

	private IEnumerator FPSTestRoutine(bool runPreset = false, bool runFrameTimes = false)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void ResetAutoFPS()
	{
		Layers layers = Layers.Instance;
		Layers layers2 = Layers.Instance;
		Physics.IgnoreLayerCollision(layers.Character, layers2.Hit, previousColliderState);
		_groupingUsed = "FPS_Data";
		_lastCappedRunResult = "Not Run";
		_lastUncappedRunResult = "Not Run";
		SetFPSLogging(shouldEnable: false);
		IsUploadingFPS__BackingField = false;
		SetFPSFramerate();
		_loggingFrameTimes = false;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FPSLog.ResetAutoFPS));
		Game.OnMenuScreenShown -= action;
	}

	public void SetFPSLogging(bool shouldEnable, int frequency = 60)
	{
		//IL_0045: Expected F8, but got I4
		if (shouldEnable)
		{
			int sleepTimeout = Screen.sleepTimeout;
			originalScreenTimeout = sleepTimeout;
			Screen.sleepTimeout = -1;
			_timeToLog = frequency;
			IsLoggingFPS__BackingField = true;
			IEnumerator updateCoroutine = Update();
			_updateCoroutine = updateCoroutine;
			Coroutine coroutine = CoroutineUtil.StartCoroutine(_updateCoroutine);
			if (!_useCustomFramerate)
			{
				SetFPSFramerate(-1);
			}
		}
		else
		{
			Screen.sleepTimeout = originalScreenTimeout;
			IsLoggingFPS__BackingField = false;
			CoroutineUtil.StopCoroutine(_updateCoroutine);
			Application.targetFrameRate = 60;
		}
	}

	private IEnumerator AutoFPSTest()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void RunStarted()
	{
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		_fpsLog = stringBuilder;
		StringBuilder stringBuilder2 = default;
		stringBuilder2._002Ector();
		_frameTimeLog = stringBuilder2;
		_timeElapsed = 0.0;
		_frameCount = 0;
		_totalTimeElapsed = 0.0;
		_timeSinceLog = 0.0;
		_skipEntry = true;
		_logging = true;
	}

	private void RunEnded()
	{
		//IL_003c: Expected I, but got Obj
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0078: Expected I, but got Obj
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		_logging = false;
		Log();
		if (~(IsUploadingFPS__BackingField ? 1u : 0u) == 0)
		{
			StringBuilder fpsLog = _fpsLog;
			nint num = (nint)fpsLog;
			object obj = fpsLog + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S2_v3 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			string text = default;
			string fps = text.TrimEnd(';');
			StringBuilder frameTimeLog = _frameTimeLog;
			nint num2 = (nint)frameTimeLog;
			object obj2 = frameTimeLog + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S3_v7 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			string text2 = default;
			string frametimes = text2.TrimEnd(';');
			IEnumerator coroutine = SendFPSAndFrameTime2Google(fps, frametimes);
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
		}
		IsUploadingFPS__BackingField = false;
		CoroutineUtil.StopCoroutine(_updateCoroutine);
	}

	private IEnumerator SendFPSAndFrameTime2Google(string fps, string frametimes)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void PauseChanged(bool isPaused)
	{
		bool logging = (byte)((isPaused ? 1u : 0u) ^ 1u) != 0;
		_logging = logging;
	}

	private IEnumerator Update()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void Log()
	{
		//IL_0021: Expected I, but got Obj
		//IL_0056: Expected F8, but got I4
		//IL_00b9: Expected Obj, but got I4
		//IL_00c6: Invalid comparison between Obj and F8
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		_timeSinceLog = 0.0;
		StringBuilder fpsLog = _fpsLog;
		nint num = (nint)fpsLog;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v4+8]");
		double num2 = 0.0 / 1000.0;
		double num3 = Math.Abs(num2);
		if (!(num3 < 2147483648.0))
		{
			num2 = -2147483648.0;
		}
		object obj = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2))
		{
			object obj2 = obj + 1;
			obj = obj2;
		}
	}

	public unsafe bool TestGoogleConnection()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected VT, but got Unknown
		//IL_00ae: Expected Obj, but got I
		//IL_00a9: Expected native int or pointer, but got VT
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected VT, but got Unknown
		//IL_00f8: Expected VT, but got I
		//IL_013f: Expected Obj, but got VT
		//IL_0183: Expected Obj, but got I
		object obj = default;
		KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)(obj - 80);
		_ = 0;
		Uri uri = default;
		uri._002Ector("https://script.google.com/macros/s/AKfycbz2lBaGXHu05CgN1mXAr217sresz20BwK_3YwuHO2sHx_eJu5g/exec");
		List<KeyValuePair<string, string>> list = default;
		list._002Ector();
		_ = 0;
		object obj2 = keyValuePair - -64;
		obj2 = "ssid";
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+40]");
		_ = 0;
		KeyValuePair<string, string> item = (KeyValuePair<string, string>)(keyValuePair + 16);
		list.Add(item);
		_ = 0;
		_ = _groupingUsed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+30]");
		_ = 0;
		KeyValuePair<string, string> keyValuePair2 = keyValuePair;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+30]");
		System.Runtime.CompilerServices.Unsafe.Write(&((KeyValuePair<string, string>*)(nint)keyValuePair2)->key, (string)0);
		KeyValuePair<string, string> item2 = (KeyValuePair<string, string>)(keyValuePair + 8);
		list.Add(item2);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+20]");
		keyValuePair = (KeyValuePair<string, string>)0;
		list.Add(keyValuePair);
		Uri uri2 = WebClient.AddQueryParametersToUri(uri, list);
		string absoluteUri = uri2.AbsoluteUri;
		KeyValuePair<bool, string> keyValuePair3 = ((FPSLog)keyValuePair).SendRequest(absoluteUri, 5f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+48]");
		bool result;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+4C]");
			bool flag = (string)0 != "Connection Established";
			result = true;
			if (!flag)
			{
				goto IL_01c5;
			}
		}
		result = false;
		goto IL_01c5;
		IL_01c5:
		return result;
	}

	public KeyValuePair<bool, string> SendRequest(string url, float timeout)
	{
		//IL_0017: Expected Obj, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0041: Invalid comparison between I8 and F4
		//IL_00b1: Expected VT, but got I4
		//IL_00be: Expected VT, but got I4
		//IL_0069: Expected Obj, but got I4
		WWW wWW = default;
		wWW._002Ector(url);
		Stopwatch stopwatch = default;
		stopwatch.Start();
		object obj = 0;
		while (true)
		{
			bool isDone = wWW.isDone;
			object obj2 = isDone | obj;
			object obj3 = obj2 & 1;
			if (obj3 != null)
			{
				break;
			}
			long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
			float num = timeout * 1000f;
			if ((float)elapsedMilliseconds > num)
			{
				obj = 1;
			}
		}
		stopwatch.Stop();
		bool isDone2 = wWW.isDone;
		bool isDone3 = wWW.isDone;
		string text = wWW.text;
		KeyValuePair<bool, string> keyValuePair = (KeyValuePair<bool, string>)0;
		return (KeyValuePair<bool, string>)isDone3;
	}

	private IEnumerator Send2GoogleSheet(string dataPoints)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public FPSLog()
	{
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		_fpsLog = stringBuilder;
		List<float> list = default;
		list._002Ector();
		_frameTimes = list;
		StringBuilder stringBuilder2 = default;
		stringBuilder2._002Ector();
		_frameTimeLog = stringBuilder2;
		_groupingUsed = "FPS_Data";
		RunTestologyCappedTest = true;
		_targetFramerate = 60;
		_autoRunLength = 600;
		_lastCappedRunResult = "Not Run";
		_lastUncappedRunResult = "Not Run";
	}
}
