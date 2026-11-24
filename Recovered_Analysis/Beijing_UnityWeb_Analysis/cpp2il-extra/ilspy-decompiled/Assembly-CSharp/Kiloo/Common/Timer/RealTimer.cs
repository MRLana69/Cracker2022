using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Security;
using Kiloo.Common.Utility;

namespace Kiloo.Common.Timer;

public class RealTimer : BaseTimer
{
	private DateTime _startStamp;

	public bool multiTrigger;

	public RealTimer(float timerInterval, bool oneShot = false)
	{
		base.interval__BackingField = timerInterval;
		singleShot = oneShot;
	}

	public RealTimer()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		if (~(_running ? 1u : 0u) == 0)
		{
			_running = false;
			string text = TOTP.NewTOTP();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Action<float> action = default;
			object obj = action + 16;
			obj = this;
			((StaticUpdater)(object)text).onLateUpdate += action;
		}
	}

	public override void Start()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected Obj, but got VT
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00bc: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = DateTime.MinValue;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		_startStamp = (DateTime)obj3;
	}

	public override void Stop()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got VT
		//IL_0033: Expected VT, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		if (~(_running ? 1u : 0u) != 0)
		{
			_running = true;
			DateTime today = CDateTime.Today;
			obj2 = today;
			obj = obj2;
			_startStamp = (DateTime)obj;
			string text = TOTP.NewTOTP();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Action<float> action = default;
			object obj3 = action + 16;
			obj3 = this;
			((StaticUpdater)(object)text).onUpdate -= action;
		}
	}

	private void Update(float deltaTime)
	{
		//IL_002f: Expected Obj, but got I
		//IL_0046: Invalid comparison between I and VT
		if (~(_running ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.RealTimer)+14]");
		object obj = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Timer.RealTimer)+14]");
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0) >= System.Runtime.CompilerServices.Unsafe.As<DateTime, UIntPtr>(ref _startStamp))
		{
			((FrameTimer)this).Start();
			if (~(singleShot ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			else
			{
				_ = 0;
			}
		}
	}

	protected unsafe virtual DateTime GetCurrentTime()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected VT, but got Unknown
		//IL_00b3: Expected I8, but got Obj
		//IL_00ae: Expected native int or pointer, but got VT
		//IL_00c1: Expected I8, but got I4
		//IL_00c1: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v20 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime dateTime = (DateTime)(this + 8);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)this;
		return ((DateTime*)dateTime)->AddTicks(10000L);
	}

	private static void Log(string message)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [message @ L0 (System.String)+9]");
		if ((nint)0 != 0)
		{
			_ = 0;
			string text = TOTP.NewTOTP();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Action<float> action = default;
			object obj = action + 16;
			obj = message;
			((StaticUpdater)(object)text).onLateUpdate += action;
		}
	}
}
