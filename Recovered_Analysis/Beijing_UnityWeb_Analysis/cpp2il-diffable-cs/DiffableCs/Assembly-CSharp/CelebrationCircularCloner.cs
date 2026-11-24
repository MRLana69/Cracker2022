//Type is in global namespace

public class CelebrationCircularCloner : MonoBehaviour
{
	public enum Axis
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	private GameObject _targetObject; //Field offset: 0xC
	private int _copyCount; //Field offset: 0x10
	private bool _destroyOriginal; //Field offset: 0x14
	private Axis _axis; //Field offset: 0x18
	private bool _alignToCloner; //Field offset: 0x1C
	private float _radius; //Field offset: 0x20

	public CelebrationCircularCloner() { }

	private void Awake() { }

	private Vector3 CalcCenterOffset(int index) { }

	private void OnDrawGizmos() { }

}

