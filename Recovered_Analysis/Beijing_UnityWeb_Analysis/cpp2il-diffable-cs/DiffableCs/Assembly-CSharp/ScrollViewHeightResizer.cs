//Type is in global namespace

public class ScrollViewHeightResizer : MonoBehaviour
{
	private GameObject _scrollBar; //Field offset: 0xC
	private GameObject _scrollCollider; //Field offset: 0x10
	private UIPanel _scrollPanel; //Field offset: 0x14
	private GameObject _grid; //Field offset: 0x18
	private float _staticObjectsHeight; //Field offset: 0x1C
	private float _centerOffset; //Field offset: 0x20
	private float _topStaticObjectsHeight; //Field offset: 0x24
	private bool _addTopCollider; //Field offset: 0x28
	private bool _addBottomcollider; //Field offset: 0x29
	private float _zDepth; //Field offset: 0x2C
	private bool isCalculated; //Field offset: 0x30
	private UITable _table; //Field offset: 0x34
	private Action onRearrangedScrollView; //Field offset: 0x38
	private bool rearrange; //Field offset: 0x3C

	public event Action onRearrangedScrollView
	{
		 add { } //Length: 235
		 remove { } //Length: 111
	}

	public Vector4 clipping
	{
		 get { } //Length: 111
	}

	public float Height
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public Vector3 scrollPanelPosition
	{
		 get { } //Length: 31
	}

	public float staticObjectsHeight
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float topStaticObjectsHeight
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public ScrollViewHeightResizer() { }

	public void add_onRearrangedScrollView(Action value) { }

	private void AddColliders() { }

	public Vector4 get_clipping() { }

	public float get_Height() { }

	public Vector3 get_scrollPanelPosition() { }

	public float get_staticObjectsHeight() { }

	public float get_topStaticObjectsHeight() { }

	public void RearrangeWidgets() { }

	public void remove_onRearrangedScrollView(Action value) { }

	public void set_Height(float value) { }

	public void set_staticObjectsHeight(float value) { }

	public void set_topStaticObjectsHeight(float value) { }

	private void Start() { }

	private void Update() { }

}

