using System;
using Cpp2ILInjected;
using Kiloo.Common.Utility;

namespace Kiloo.Common.Timer;

public class RealTimer : BaseTimer
{
	private DateTime _startStamp;

	public bool multiTrigger;

	public RealTimer(float timerInterval, bool oneShot = false)
	{
		_startStamp = DateTime.MinValue;
		singleShot = oneShot;
		base.interval__BackingField = timerInterval;
	}

	public RealTimer()
	{
		_startStamp = DateTime.MinValue;
	}

	public override void Start()
	{
		if (~(running ? 1u : 0u) != 0)
		{
			running = true;
			DateTime utcNow = CDateTime.UtcNow;
			_startStamp = utcNow;
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

	private unsafe void Update(float deltaTime)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected VT, but got Unknown
		//IL_015e: Expected I, but got Obj
		//IL_0106: Expected I, but got Obj
		//IL_00e9: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (~(running ? 1u : 0u) != 0)
		{
			return;
		}
		DateTime dateTime = (DateTime)(this + 24);
		DateTime dateTime2 = default;
		while (true)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S1_v9 (Il2CppClass<Kiloo.Common.Timer.RealTimer>)+EC] (should have been resolved before IL gen)");
			TimeSpan timeSpan = dateTime2 - _startStamp;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num2 = 0.0 * 1E-07;
			if ((double)base.interval__BackingField > num2)
			{
				break;
			}
			if (1 == 0 || ~(multiTrigger ? 1u : 0u) == 0)
			{
				Action action = base.intervalElapsed;
				if (base.intervalElapsed != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v113.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			if (~(singleShot ? 1u : 0u) != 0)
			{
				DateTime startStamp = ((DateTime*)dateTime)->AddSeconds(base.interval__BackingField);
				_startStamp = startStamp;
				continue;
			}
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ S1_v18 (Il2CppClass<Kiloo.Common.Timer.RealTimer>)+E4] (should have been resolved before IL gen)");
			break;
		}
	}

	protected virtual DateTime GetCurrentTime()
	{
		return CDateTime.UtcNow;
	}

	private static void Log(string message)
	{
	}
}
