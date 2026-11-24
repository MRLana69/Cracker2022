namespace Kiloo;

public class PositionValueResetter : BaseTransformValueResetter
{
	private Vector3 _startPosition; //Field offset: 0xC

	public PositionValueResetter(SpaceType spaceType) { }

	protected override void OnInitLocalSpace(Transform transform) { }

	protected override void OnInitWorldSpace(Transform transform) { }

	protected override void OnResetLocalSpace(Transform transform) { }

	protected override void OnResetWorldSpace(Transform transform) { }

}

