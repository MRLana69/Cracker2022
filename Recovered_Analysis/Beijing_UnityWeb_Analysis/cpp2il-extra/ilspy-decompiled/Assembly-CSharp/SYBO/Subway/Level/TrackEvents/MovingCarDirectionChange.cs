using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public class MovingCarDirectionChange : MonoBehaviour
{
	private Transform _targetDirection;

	public Transform TargetDirection
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarDirectionChange)+24]");
			return (Transform)0;
		}
	}

	public MovingCarDirectionChange()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}
}
