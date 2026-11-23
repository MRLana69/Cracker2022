using System;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

public class InRunAverageFPSCounter : MonoBehaviour
{
	private float _runStartedTime;

	private float _runEndedTime;

	private float _runPausedTime;

	private float _runResumedTime;

	private float _appMinimizedTime;

	private float _appResumedTime;

	private float _amountOfTimePaused;

	private int _frameCount;

	private bool _isInitialized;

	private bool _isInRun;

	private bool _isPaused;

	private bool _isSubscribedToOnPause;

	private const int MAX_NUMBER_OF_INTERVALS = 10;

	private string _gpuName = string.Empty;

	private static int runAverageFPS__BackingField;

	private static int runLength__BackingField;

	public static int runAverageFPS
	{
		get
		{
			return runAverageFPS__BackingField;
		}
		private set
		{
			runAverageFPS__BackingField = value;
		}
	}

	public static int runLength
	{
		get
		{
			return runLength__BackingField;
		}
		private set
		{
			runLength__BackingField = value;
		}
	}

	public unsafe void Initialize()
	{
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(InRunAverageFPSCounter.RunStarted));
			Game.OnGameStarted += action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(InRunAverageFPSCounter.RunEnded));
			Game.OnMenuScreenShown += action2;
			Action action3 = default;
			action3._002Ector(this, (nint)__ldftn(InRunAverageFPSCounter.SubscribeToGameInstanceEvents));
			Game.OnGameAwake += action3;
			string graphicsDeviceName = SystemInfo.GetGraphicsDeviceName();
			_gpuName = graphicsDeviceName;
			_isInitialized = true;
		}
	}

	private void SubscribeToGameInstanceEvents()
	{
		if (~(_isSubscribedToOnPause ? 1u : 0u) != 0)
		{
			Game instance = Game.Instance;
			throw new ArgumentException();
		}
	}

	private void Update()
	{
		if (~(_isInRun ? 1u : 0u) == 0 && !_isPaused)
		{
			int frameCount = _frameCount + 1;
			_frameCount = frameCount;
		}
	}

	private void RunStarted()
	{
		_amountOfTimePaused = 0f;
		_isInRun = true;
		runAverageFPS__BackingField = 0;
		runLength__BackingField = 0;
		SubscribeToGameInstanceEvents();
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		_runStartedTime = realtimeSinceStartup;
	}

	private void RunEnded()
	{
		//IL_001b: Expected F8, but got I4
		//IL_013b: Expected I4, but got F8
		_isInRun = false;
		float num = (_runEndedTime = Time.realtimeSinceStartup);
		float num2 = _runStartedTime + _amountOfTimePaused;
		float num3 = num - num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
		double num4 = Math.Abs((double)num3);
		double num5 = ((!(num4 < 2147483648.0)) ? (-2147483648.0) : ((double)num3));
		runLength__BackingField = (int)num5;
		int num6 = _frameCount / runLength__BackingField;
		runAverageFPS__BackingField = num6;
		if (runAverageFPS__BackingField >= 1)
		{
			string text = RoundUpToTargetValue(runAverageFPS__BackingField, 6);
			string text2 = "FPS range " + text;
			string text3 = "GPU name " + _gpuName;
		}
	}

	private unsafe string RoundUpToTargetValue(int total, int factor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_013f: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected I4, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = 1;
		string result;
		while (true)
		{
			bool flag = (nint)obj3 >= 11;
			result = string.Empty;
			if (flag)
			{
				break;
			}
			object obj4 = obj3 * factor;
			if (total > (nint)obj4)
			{
				if ((nint)obj3 != 10)
				{
					goto IL_0116;
				}
				object obj5 = factor * 10;
				if (total <= (nint)obj5)
				{
					goto IL_0116;
				}
			}
			object obj6 = obj3 * factor;
			object obj7 = obj6 - factor;
			int num = obj + 8;
			string text = ((int*)num)->ToString();
			int num2 = obj + 12;
			string text2 = ((int*)num2)->ToString();
			string text3 = text + " - " + text2;
			result = text3;
			break;
			IL_0116:
			object obj8 = obj3 + 1;
			obj3 = obj8;
		}
		return result;
	}

	private void PauseChange(bool pause)
	{
		if (~(_isInRun ? 1u : 0u) == 0)
		{
			_isPaused = pause;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (pause)
			{
				_runPausedTime = realtimeSinceStartup;
				return;
			}
			_runResumedTime = realtimeSinceStartup;
			float num = realtimeSinceStartup - _runPausedTime;
			float amountOfTimePaused = _amountOfTimePaused + num;
			_amountOfTimePaused = amountOfTimePaused;
		}
	}

	private void OnApplicationPause(bool paused)
	{
		if (~(_isInRun ? 1u : 0u) == 0 && !_isPaused)
		{
			_isPaused = paused;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (paused)
			{
				_appMinimizedTime = realtimeSinceStartup;
				return;
			}
			_appResumedTime = realtimeSinceStartup;
			float num = realtimeSinceStartup - _appMinimizedTime;
			float amountOfTimePaused = _amountOfTimePaused + num;
			_amountOfTimePaused = amountOfTimePaused;
		}
	}
}
