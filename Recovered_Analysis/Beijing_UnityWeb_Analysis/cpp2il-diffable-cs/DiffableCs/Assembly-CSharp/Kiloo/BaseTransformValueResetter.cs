namespace Kiloo;

public abstract class BaseTransformValueResetter : IValueResetter<Transform>
{
	protected SpaceType _spaceType; //Field offset: 0x8

	protected BaseTransformValueResetter(SpaceType spaceType) { }

	public void Init(Transform transform) { }

	protected abstract void OnInitLocalSpace(Transform transform) { }

	protected abstract void OnInitWorldSpace(Transform transform) { }

	protected abstract void OnResetLocalSpace(Transform transform) { }

	protected abstract void OnResetWorldSpace(Transform transform) { }

	public void ResetValues(Transform transform) { }

}

