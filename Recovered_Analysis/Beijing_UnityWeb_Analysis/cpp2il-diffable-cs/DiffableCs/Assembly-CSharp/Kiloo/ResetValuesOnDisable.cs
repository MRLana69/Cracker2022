namespace Kiloo;

public class ResetValuesOnDisable : MonoBehaviour
{
	private SpaceType _positionSpaceType; //Field offset: 0xC
	private SpaceType _rotationSpaceType; //Field offset: 0x10
	private IValueResetter<Transform>[] _valueResetters; //Field offset: 0x14

	public ResetValuesOnDisable() { }

	private void CreateValueResetters() { }

	private void InitValueResetters() { }

	private void OnDisable() { }

	private void ResetValues() { }

	private void Start() { }

}

