namespace Kiloo.Common.UI;

public class Container
{
	public Action onRecycleContainer; //Field offset: 0x8
	public Action onPositionContainer; //Field offset: 0xC
	public long rowId; //Field offset: 0x10
	public GameObject model; //Field offset: 0x18
	public Vector2 coordinates; //Field offset: 0x1C
	private readonly Transform _modelTransform; //Field offset: 0x24
	public Bounds bounds; //Field offset: 0x28
	public int dataIndex; //Field offset: 0x40
	public int modelType; //Field offset: 0x44
	public float height; //Field offset: 0x48
	public float width; //Field offset: 0x4C
	public bool isMeasured; //Field offset: 0x50
	private bool _parentSet; //Field offset: 0x51
	private bool _scaleSet; //Field offset: 0x52
	public object tag; //Field offset: 0x54
	private bool <hasTransientState>k__BackingField; //Field offset: 0x58
	public float top; //Field offset: 0x5C
	public float bottom; //Field offset: 0x60
	public float right; //Field offset: 0x64
	public float left; //Field offset: 0x68

	public bool hasTransientState
	{
		 get { } //Length: 6
		 set { } //Length: 61
	}

	public Transform modelTransform
	{
		 get { } //Length: 3
	}

	public Container(GameObject model) { }

	public bool get_hasTransientState() { }

	public Transform get_modelTransform() { }

	public virtual void Measure(bool includeInactive = true) { }

	public void set_hasTransientState(bool value) { }

	public void SetModelType(int mType) { }

	public void SetParent(Transform parent) { }

	public void SetPosition() { }

	public void SetScale(Vector3 scale) { }

	public override string ToString() { }

}

