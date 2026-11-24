namespace SYBO.Subway.Placeholders;

public class MovingTrainPlaceholder : Placeholder
{
	private float _speed; //Field offset: 0x1C

	public float Speed
	{
		 get { } //Length: 6
	}

	public MovingTrainPlaceholder() { }

	public float get_Speed() { }

	protected override Transform InitializeSpawnedInstance(Transform objectTransform, string newName) { }

	public void OnDrawGizmos() { }

}

