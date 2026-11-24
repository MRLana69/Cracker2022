using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents.CarActivities;

public class DeceleratedLerpedTurn : LerpedTurn
{
	public override void Turn()
	{
		//IL_000b: Expected Obj, but got F4
		_movingCarActivity = (MovingCarActivity)1f;
		CancelInvoke();
	}

	public DeceleratedLerpedTurn()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		if (~(_turning ? 1u : 0u) != 0)
		{
			return;
		}
		MovingCarActivity movingCarActivity = _movingCarActivity;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v7 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v13 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = Mathf.DeltaAngle(_colliderPassProgress, 0.5f);
		float num4 = 1f - num3;
		movingCarActivity.Acceleration__BackingField = num4;
	}
}
