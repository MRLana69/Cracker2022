//Type is in global namespace

public class UIToggledComponents : MonoBehaviour
{
	public List<MonoBehaviour> activate; //Field offset: 0xC
	public List<MonoBehaviour> deactivate; //Field offset: 0x10
	private MonoBehaviour target; //Field offset: 0x14
	private bool inverse; //Field offset: 0x18

	public UIToggledComponents() { }

	private void Awake() { }

	public void Toggle() { }

}

