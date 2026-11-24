//Type is in global namespace

public class FPSLog
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<string, float> <>9__82_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal float <Send2GoogleSheet>b__82_0(string x) { }

	}

	private sealed class <AutoFPSTest>d__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public FPSLog <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 867
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AutoFPSTest>d__73(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <FPSTestRoutine>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public bool runPreset; //Field offset: 0x10
		public FPSLog <>4__this; //Field offset: 0x14
		public bool runFrameTimes; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 562
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <FPSTestRoutine>d__70(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Send2GoogleSheet>d__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string dataPoints; //Field offset: 0x10
		public FPSLog <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 3190
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Send2GoogleSheet>d__82(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <SendFPSAndFrameTime2Google>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public FPSLog <>4__this; //Field offset: 0x10
		public string fps; //Field offset: 0x14
		public string frametimes; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 275
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SendFPSAndFrameTime2Google>d__76(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Update>d__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public FPSLog <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 547
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Update>d__78(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static FPSLog _instance; //Field offset: 0x0
	private const string GROUPING_FRAMETIME_UNCAPPED_NAME = "FrameTime_Data_Uncapped"; //Field offset: 0x0
	private const string UPLOAD_SUCCESS_RESPONSE = "Upload Successful"; //Field offset: 0x0
	private const string SPREADSHEET_ID_PARAMETER_KEY = "ssid"; //Field offset: 0x0
	private const string WORKSHEET_NAME_PARAMETER_KEY = "sheet"; //Field offset: 0x0
	private const string ACTION_PARAMETER_KEY = "action"; //Field offset: 0x0
	private const string GROUPBY_PARAMETER_KEY = "groupby"; //Field offset: 0x0
	private const string ACTION_CONNECT_TEST_PARAMETER_VALUE = "ConnectionTest"; //Field offset: 0x0
	private const string GROUPING_FRAMETIME_DEFAULT_NAME = "FrameTime_Data"; //Field offset: 0x0
	private const string ACTION_UPLOAD_PARAMETER_VALUE = "POST"; //Field offset: 0x0
	private const string DATA_TARGETFRAMERATE_PARAMETER_KEY = "targetframerate"; //Field offset: 0x0
	public const int DEFAULT_AUTORUN_LENGTH = 600; //Field offset: 0x0
	public const int DEFAULT_PERFORMANCE_DEVICE_FRAMERATE = 60; //Field offset: 0x0
	public const int LOW_PERFORMANCE_DEVICE_FRAMERATE = 20; //Field offset: 0x0
	public const int HIGH_PERFORMANCE_DEVICE_FRAMERATE = 40; //Field offset: 0x0
	public const int HIGH_PERFORMANCE_IOS_DEVICE_FRAMERATE = 30; //Field offset: 0x0
	public const int DEFAULT_LOGGING_FREQUENCY = 60; //Field offset: 0x0
	private const string DATA_DEFAULT_PARAMETER_KEY = "val"; //Field offset: 0x0
	private const string GROUPING_UNCAPPED_NAME = "FPS_Data_Uncapped"; //Field offset: 0x0
	private const string CONNECTION_TEST_SUCCESS_RESPONSE = "Connection Established"; //Field offset: 0x0
	private const string GOOGLE_SHEET_ID = "1d4AZJWVKm1c438UX21RZIMHGpzjRd013Bmk10_n5tmU"; //Field offset: 0x0
	private const string GOOGLE_SCRIPT_URL = "https://script.google.com/macros/s/AKfycbz2lBaGXHu05CgN1mXAr217sresz20BwK_3YwuHO2sHx_eJu5g/exec"; //Field offset: 0x0
	private const string GROUPING_DEFAULT_NAME = "FPS_Data"; //Field offset: 0x0
	private const int MAX_LOG_SIZE = 1000; //Field offset: 0x0
	private bool _logging; //Field offset: 0x8
	private int _frameCount; //Field offset: 0xC
	private int _fps; //Field offset: 0x10
	private double _timeElapsed; //Field offset: 0x18
	private double _totalTimeElapsed; //Field offset: 0x20
	private double _timeSinceLog; //Field offset: 0x28
	private double _timeToLog; //Field offset: 0x30
	private StringBuilder _fpsLog; //Field offset: 0x38
	private bool _loggingFrameTimes; //Field offset: 0x3C
	private List<float> _frameTimes; //Field offset: 0x40
	private StringBuilder _frameTimeLog; //Field offset: 0x44
	private bool previousColliderState; //Field offset: 0x48
	private int originalScreenTimeout; //Field offset: 0x4C
	private IEnumerator _updateCoroutine; //Field offset: 0x50
	private string _groupingUsed; //Field offset: 0x54
	private bool _skipEntry; //Field offset: 0x58
	private bool _retryUploadIfFailed; //Field offset: 0x59
	private int _autoRunLength; //Field offset: 0x5C
	private bool _useCustomFramerate; //Field offset: 0x60
	private int _targetFramerate; //Field offset: 0x64
	public bool RunTestologyCappedTest; //Field offset: 0x68
	public bool RunTestologyUnCappedTest; //Field offset: 0x69
	private string _lastCappedRunResult; //Field offset: 0x6C
	private string _lastUncappedRunResult; //Field offset: 0x70
	private bool <IsLoggingFPS>k__BackingField; //Field offset: 0x74
	private bool <IsUploadingFPS>k__BackingField; //Field offset: 0x75

	public int autoRunLength
	{
		 get { } //Length: 89
	}

	public static FPSLog instance
	{
		 get { } //Length: 251
	}

	public bool IsLoggingFPS
	{
		 get { } //Length: 9
		private set { } //Length: 35
	}

	public bool IsUploadingFPS
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	private string SetLastRunResult
	{
		 set { } //Length: 782
	}

	public int targetFramerate
	{
		 get { } //Length: 6
	}

	public bool useCustomFramerate
	{
		 get { } //Length: 6
	}

	public FPSLog() { }

	private IEnumerator AutoFPSTest() { }

	private IEnumerator FPSTestRoutine(bool runPreset = false, bool runFrameTimes = false) { }

	public int get_autoRunLength() { }

	public static FPSLog get_instance() { }

	public bool get_IsLoggingFPS() { }

	public bool get_IsUploadingFPS() { }

	public int get_targetFramerate() { }

	public bool get_useCustomFramerate() { }

	private void Log() { }

	private void PauseChanged(bool isPaused) { }

	private void ResetAutoFPS() { }

	private void RunEnded() { }

	private void RunStarted() { }

	private IEnumerator Send2GoogleSheet(string dataPoints) { }

	private IEnumerator SendFPSAndFrameTime2Google(string fps, string frametimes) { }

	public KeyValuePair<bool, string> SendRequest(string url, float timeout) { }

	private void set_IsLoggingFPS(bool value) { }

	private void set_IsUploadingFPS(bool value) { }

	private void set_SetLastRunResult(string value) { }

	public void SetFPSAutoLength(int value = 0) { }

	public void SetFPSFramerate(int value = 0) { }

	public void SetFPSLogging(bool shouldEnable, int frequency = 60) { }

	public void SetFPSUpload(bool value) { }

	public void StartAutoFPSTest(bool runPreset = false, bool runFrameTimes = false) { }

	public bool TestGoogleConnection() { }

	private IEnumerator Update() { }

}

