namespace SYBO.Common.Components;

public class DeselectMeComponent : MonoBehaviour
{
	private Transform _redirectTarget; //Field offset: 0xC
	private DeselectMeMode _deselectMeMode; //Field offset: 0x10

	public DeselectMeMode DeselectMeMode
	{
		 get { } //Length: 6
		 set { } //Length: 26
	}

	public Transform RedirectTarget
	{
		 get { } //Length: 6
	}

	public DeselectMeComponent() { }

	public DeselectMeMode get_DeselectMeMode() { }

	public Transform get_RedirectTarget() { }

	public void set_DeselectMeMode(DeselectMeMode value) { }

}

