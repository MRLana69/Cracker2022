using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public class MovingCarDirectionChange : MonoBehaviour
{
	private Transform _targetDirection;

	public Transform TargetDirection => _targetDirection;
}
