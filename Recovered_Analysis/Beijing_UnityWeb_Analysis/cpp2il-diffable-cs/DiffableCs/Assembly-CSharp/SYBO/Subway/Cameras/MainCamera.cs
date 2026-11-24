namespace SYBO.Subway.Cameras;

public class MainCamera : MonoBehaviour
{
	private Transform _skyPlaneTransform; //Field offset: 0xC
	private Transform _reviveEffectTransform; //Field offset: 0x10
	private Transform _speedStripesTransform; //Field offset: 0x14
	private Camera _camera; //Field offset: 0x18

	public Transform ReviveEffectTransform
	{
		 get { } //Length: 6
	}

	public Transform SkyPlane
	{
		 get { } //Length: 57
	}

	public MainCamera() { }

	protected void Awake() { }

	public Transform get_ReviveEffectTransform() { }

	public Transform get_SkyPlane() { }

}

