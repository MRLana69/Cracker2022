namespace UI.ModelCamera;

public class ModelScreenSetup
{
	private const int NOT_SET_INT_VALUE = -1; //Field offset: 0x0
	private Vector3 <localPosition>k__BackingField; //Field offset: 0x8
	private Vector3 <localScale>k__BackingField; //Field offset: 0x14
	private Vector3 <localRotation>k__BackingField; //Field offset: 0x20
	private int <localScaleOnAllAxes>k__BackingField; //Field offset: 0x2C
	private int <modelGoLayer>k__BackingField; //Field offset: 0x30
	private Vector3 <cameraLocalPosition>k__BackingField; //Field offset: 0x34
	private Vector3 <cameraLocalScale>k__BackingField; //Field offset: 0x40
	private Vector3 <cameraLocalRotation>k__BackingField; //Field offset: 0x4C

	public Vector3 cameraLocalPosition
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	public Vector3 cameraLocalRotation
	{
		 get { } //Length: 61
		 set { } //Length: 27
	}

	public Vector3 cameraLocalScale
	{
		 get { } //Length: 61
		 set { } //Length: 26
	}

	public Vector3 localPosition
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	public Vector3 localRotation
	{
		 get { } //Length: 61
		 set { } //Length: 26
	}

	public Vector3 localScale
	{
		 get { } //Length: 61
		 set { } //Length: 26
	}

	public int localScaleOnAllAxes
	{
		 get { } //Length: 18
		 set { } //Length: 61
	}

	public int modelGoLayer
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public ModelScreenSetup() { }

	public Vector3 get_cameraLocalPosition() { }

	public Vector3 get_cameraLocalRotation() { }

	public Vector3 get_cameraLocalScale() { }

	public Vector3 get_localPosition() { }

	public Vector3 get_localRotation() { }

	public Vector3 get_localScale() { }

	public int get_localScaleOnAllAxes() { }

	public int get_modelGoLayer() { }

	public void set_cameraLocalPosition(Vector3 value) { }

	public void set_cameraLocalRotation(Vector3 value) { }

	public void set_cameraLocalScale(Vector3 value) { }

	public void set_localPosition(Vector3 value) { }

	public void set_localRotation(Vector3 value) { }

	public void set_localScale(Vector3 value) { }

	public void set_localScaleOnAllAxes(int value) { }

	public void set_modelGoLayer(int value) { }

	private void SetLocalScale(Transform modelTransform) { }

	public void SetupScreen(Transform modelTransform, Transform cameraTransform, int cameraLayer) { }

}

