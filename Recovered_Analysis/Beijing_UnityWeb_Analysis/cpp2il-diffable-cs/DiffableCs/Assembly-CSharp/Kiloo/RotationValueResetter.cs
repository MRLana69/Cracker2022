namespace Kiloo;

public class RotationValueResetter : BaseTransformValueResetter
{
	private Vector3 _startRotation; //Field offset: 0xC

	public RotationValueResetter(SpaceType spaceType) { }

	protected override void OnInitLocalSpace(Transform transform) { }

	protected override void OnInitWorldSpace(Transform transform) { }

	protected override void OnResetLocalSpace(Transform transform) { }

	protected override void OnResetWorldSpace(Transform transform) { }

}

