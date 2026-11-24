using System;
using Cpp2ILInjected;
using Kiloo.Common.Security;
using Kiloo.Common.Utility;

namespace Kiloo.Common.Timer;

public class Timer : BaseTimer
{
	private double _currentInterval;

	private string _name;

	public Timer(float timerInterval, bool oneShot = false)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected Obj, but got VT
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00bc: Expected F8, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v20 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = DateTime.MinValue;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		_currentInterval = (double)obj3;
		base.interval__BackingField = timerInterval;
		singleShot = oneShot;
	}

	public Timer()
	{
	}

	public void SetName(string name)
	{
		//IL_0036: Expected F4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BaseTimer baseTimer = default;
		baseTimer.interval__BackingField = 0f;
		baseTimer.singleShot = true;
		baseTimer.interval__BackingField = (float)this;
		baseTimer.intervalElapsed -= (Action)(object)name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public override void Start()
	{
	}

	public override void Stop()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		if (~(_running ? 1u : 0u) != 0)
		{
			_running = true;
			_currentInterval = base.interval__BackingField;
			string text = TOTP.NewTOTP();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Action<float> action = default;
			object obj = action + 16;
			obj = this;
			((StaticUpdater)(object)text).onUpdate -= action;
		}
	}

	private unsafe void Update(float deltaTime)
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected VT, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0191: Expected Obj, but got I4
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got F8
		//IL_01c9: Expected I8, but got Obj
		//IL_01c4: Expected native int or pointer, but got VT
		//IL_01de: Expected Ref, but got VT
		//IL_01ea: Expected Obj, but got I8
		//IL_005e: Expected I, but got Obj
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_012e: Expected F8, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 40);
		DateTime dateTime = (DateTime)(obj + 32);
		object obj2 = obj + 16;
		object obj3 = obj + 8;
		object obj4 = obj + 24;
		obj4 = 0;
		if (~(_running ? 1u : 0u) != 0)
		{
			return;
		}
		object obj6 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v28 (Il2CppClass<System.DateTime>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v57 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = obj6;
			obj = _currentInterval;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj3;
			formatProvider = (IFormatProvider)obj;
			long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			obj4 = num3;
			double num4 = (double)obj4 * 1E-07;
			if (!(num4 < (double)base.interval__BackingField))
			{
				if (1 == 0 || _name != null)
				{
					((FrameTimer)this).Start();
				}
				if (~(singleShot ? 1u : 0u) != 0)
				{
					object obj7 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
					obj2 = obj8;
					formatProvider = (IFormatProvider)obj2;
					_currentInterval = (double)formatProvider;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				break;
			}
			break;
		}
	}

	public static void ExecuteWithDelay(float delay, Action action)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static void ExecuteNextFrame(Action action)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [action @ L0 (System.Action)+9]");
		if ((nint)0 != 0)
		{
			_ = 0;
			string text = TOTP.NewTOTP();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Action<float> action2 = default;
			object obj = action2 + 16;
			obj = action;
			((StaticUpdater)(object)text).onLateUpdate += action2;
		}
	}

	private static void Log(string message)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BaseTimer baseTimer = default;
		baseTimer.interval__BackingField = 0f;
		baseTimer.singleShot = true;
		baseTimer.intervalElapsed -= (Action)(object)message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}
}
