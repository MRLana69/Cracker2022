namespace UI;

public class CameraSettings
{
	private static CameraSettings _renderTextureCameraSettings; //Field offset: 0x0
	private Dictionary<Type, object> _defaultValues; //Field offset: 0x8
	private int <layer>k__BackingField; //Field offset: 0xC
	private CameraClearFlags <clearFlags>k__BackingField; //Field offset: 0x10
	private float <nearClipPlane>k__BackingField; //Field offset: 0x14
	private float <farClipPlane>k__BackingField; //Field offset: 0x18
	private Color <backgroundColor>k__BackingField; //Field offset: 0x1C
	private float <depth>k__BackingField; //Field offset: 0x2C
	private int <fieldOfView>k__BackingField; //Field offset: 0x30

	public Color backgroundColor
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	public CameraClearFlags clearFlags
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float depth
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public float farClipPlane
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int fieldOfView
	{
		 get { } //Length: 6
		 set { } //Length: 61
	}

	public int layer
	{
		 get { } //Length: 683
		 set { } //Length: 9
	}

	public float nearClipPlane
	{
		 get { } //Length: 12
		 set { } //Length: 124
	}

	private static CameraSettings() { }

	public CameraSettings() { }

	public static void ApplyRenderTextureCameraSettings(Camera camera, CameraSettings overrideCameraSettings = null) { }

	public void ApplySettingsToCamera(Camera camera, CameraSettings overrideCameraSettings) { }

	public Color get_backgroundColor() { }

	public CameraClearFlags get_clearFlags() { }

	public float get_depth() { }

	public float get_farClipPlane() { }

	public int get_fieldOfView() { }

	public int get_layer() { }

	public float get_nearClipPlane() { }

	private T GetDefaultValue() { }

	private T GetValue(T overrideValue, T defaultCameraValue) { }

	public void set_backgroundColor(Color value) { }

	public void set_clearFlags(CameraClearFlags value) { }

	public void set_depth(float value) { }

	public void set_farClipPlane(float value) { }

	public void set_fieldOfView(int value) { }

	public void set_layer(int value) { }

	public void set_nearClipPlane(float value) { }

}

