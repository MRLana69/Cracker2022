//Type is in global namespace

public class UIToggledObjects : MonoBehaviour
{
	public List<GameObject> activate; //Field offset: 0xC
	public List<GameObject> deactivate; //Field offset: 0x10
	private GameObject target; //Field offset: 0x14
	private bool inverse; //Field offset: 0x18

	public UIToggledObjects() { }

	private void Awake() { }

	private void Set(GameObject go, bool state) { }

	public void Toggle() { }

}

