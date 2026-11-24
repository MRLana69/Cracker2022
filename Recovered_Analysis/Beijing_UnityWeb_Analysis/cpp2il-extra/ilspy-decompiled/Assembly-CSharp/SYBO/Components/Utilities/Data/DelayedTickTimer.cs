using System;
using Cpp2ILInjected;

namespace SYBO.Components.Utilities.Data;

public class DelayedTickTimer
{
	private const float UnsetFloat = -1f;

	private float _targetFPS;

	private long _ticksLast;

	private long _ticksCurrent;

	private float _delayTarget;

	private float _deltaTime;

	public float TargetFPS
	{
		get
		{
			//IL_0007: Expected F4, but got I8
			return _ticksCurrent;
		}
		set
		{
			//IL_005b: Expected Obj, but got I4
			//IL_007e: Expected I, but got Obj
			//IL_0094: Expected Obj, but got I
			//IL_00c2: Expected Obj, but got VT
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected I8, but got Unknown
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			_targetFPS = 1f;
			_targetFPS = value;
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<System.DateTime>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v19 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime utcNow = DateTime.UtcNow;
			obj = utcNow;
			long ticksLast = obj & 0x3FFFFFFFFFFFFFFFL;
			_ticksLast = ticksLast;
		}
	}

	public float DeltaTime
	{
		get
		{
			return _targetFPS;
		}
		set
		{
			_targetFPS = value;
		}
	}

	public DelayedTickTimer(float targetFPS)
	{
		//IL_000a: Expected I8, but got F4
		_ticksCurrent = (long)targetFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public bool Tick()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.Data.DelayedTickTimer)+14]");
		return (nint)0 != 0;
	}
}
