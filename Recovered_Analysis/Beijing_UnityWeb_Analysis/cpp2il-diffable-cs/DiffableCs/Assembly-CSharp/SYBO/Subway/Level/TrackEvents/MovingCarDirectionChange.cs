namespace SYBO.Subway.Level.TrackEvents;

public class MovingCarDirectionChange : MonoBehaviour
{
	private Transform _targetDirection; //Field offset: 0xC

	public Transform TargetDirection
	{
		 get { } //Length: 6
	}

	public MovingCarDirectionChange() { }

	public Transform get_TargetDirection() { }

}

