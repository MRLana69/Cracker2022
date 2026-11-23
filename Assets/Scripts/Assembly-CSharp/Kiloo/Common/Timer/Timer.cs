using System;
using Cpp2ILInjected;
using Kiloo.Common.Utility;

namespace Kiloo.Common.Timer;

public class Timer : BaseTimer
{
	private double _currentInterval;

	private string _name;

	public Timer(float timerInterval, bool oneShot = false)
	{
		singleShot = oneShot;
		base.interval__BackingField = timerInterval;
	}

	public Timer()
	{
	}

	public void SetName(string name)
	{
		_name = name;
	}

	public override void Start()
	{
		if (~(running ? 1u : 0u) != 0)
		{
			running = true;
			_currentInterval = base.interval__BackingField;
			StaticUpdater instance = StaticUpdater.instance;
			throw new ArgumentException();
		}
	}

	public override void Stop()
	{
		if (~(running ? 1u : 0u) == 0)
		{
			running = false;
			StaticUpdater instance = StaticUpdater.instance;
			throw new ArgumentException();
		}
	}

	private void Update(float deltaTime)
	{
		//IL_009d: Expected I, but got Obj
		if (~(running ? 1u : 0u) != 0)
		{
			return;
		}
		float num = (float)_currentInterval - deltaTime;
		_currentInterval = num;
		if ((double)num < 0.0)
		{
			Action action = base.intervalElapsed;
			if (base.intervalElapsed != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			if (~(singleShot ? 1u : 0u) == 0)
			{
				nint num2 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S1_v10 (Il2CppClass<Kiloo.Common.Timer.Timer>)+E4] (should have been resolved before IL gen)");
			}
			else
			{
				_currentInterval = base.interval__BackingField;
			}
		}
	}

	public static void ExecuteWithDelay(float delay, Action action)
	{
		//IL_0035: Expected I, but got Obj
		BaseTimer baseTimer = default;
		baseTimer.singleShot = true;
		baseTimer.interval__BackingField = delay;
		baseTimer.intervalElapsed += action;
		nint num = (nint)baseTimer;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S1_v6 (Il2CppClass<Kiloo.Common.Timer.BaseTimer>)+DC] (should have been resolved before IL gen)");
	}

	public static void ExecuteNextFrame(Action action)
	{
		//IL_0036: Expected I, but got Obj
		BaseTimer baseTimer = default;
		baseTimer.singleShot = true;
		baseTimer.interval__BackingField = 0f;
		baseTimer.intervalElapsed += action;
		nint num = (nint)baseTimer;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S1_v6 (Il2CppClass<Kiloo.Common.Timer.BaseTimer>)+DC] (should have been resolved before IL gen)");
	}

	private static void Log(string message)
	{
	}
}
