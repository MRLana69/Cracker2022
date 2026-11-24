namespace SYBO.Subway.Level.TrackEvents.CarActivities;

public interface ITurnable
{

	public void Init(MovingCarActivity movingCarActivity) { }

	public void Reset() { }

	public void StartTurning(Collider trigger) { }

	public void Turn() { }

}

