using Cpp2ILInjected;

namespace SYBO.Subway.Level;

public class EnvironmentObstacle : Obstacle
{
	private EnvironmentObstacleType _obstacleType = EnvironmentObstacleType.Pillar;

	private TrackLane _blockedLanes;

	private EnvironmentSegmentLength _obstacleLength = EnvironmentSegmentLength.Standard;

	private EnvironmentConstraint _environmentConstraint;

	public EnvironmentObstacleType ObstacleType => _obstacleType;

	public TrackLane BlockedLanes => _blockedLanes;

	public EnvironmentSegmentLength ObstacleLength => _obstacleLength;

	public unsafe EnvironmentConstraint EnvironmentConstraint
	{
		get
		{
			//IL_000f: Expected I4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_001f: Expected native int or pointer, but got VT
			EnvironmentConstraint environmentConstraint = default;
			((EnvironmentConstraint*)(nint)environmentConstraint)->Type = (EnvironmentType)_environmentConstraint;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Level.EnvironmentObstacle)+20]");
			((EnvironmentConstraint*)(nint)environmentConstraint)->SegmentLength = (EnvironmentSegmentLength)0;
			return environmentConstraint;
		}
	}

	private void OnValidate()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0096: Expected VT, but got I4
		//IL_00a5: Expected I4, but got I8
		//IL_00be: Expected VT, but got I4
		//IL_00e7: Expected I4, but got I8
		object obj = _obstacleType - 1;
		if (_obstacleType != EnvironmentObstacleType.Pillar)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2 && (nint)obj == 3)
				{
					_obstacleLength = EnvironmentSegmentLength.Extended;
					_ = 0;
					EnvironmentSegmentLength environmentSegmentLength = EnvironmentSegmentLength.Extended;
				}
			}
			else
			{
				_environmentConstraint = (EnvironmentConstraint)16;
				_blockedLanes = TrackLane.Sides;
				EnvironmentSegmentLength environmentSegmentLength = _obstacleLength;
			}
		}
		else
		{
			_environmentConstraint = (EnvironmentConstraint)4;
			_blockedLanes = TrackLane.None;
			EnvironmentSegmentLength environmentSegmentLength = EnvironmentSegmentLength.Standard;
		}
	}
}
