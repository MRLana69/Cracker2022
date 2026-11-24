namespace Debugging;

public class FreeMemoryStatus : MonoBehaviour
{
	private static FreeMemoryStatus _instance; //Field offset: 0x0
	public float UpdateInterval; //Field offset: 0xC
	private UILabel _label; //Field offset: 0x10
	private float _timeleft; //Field offset: 0x14
	private GameObject _prefabInstanceRoot; //Field offset: 0x18

	public static FreeMemoryStatus Instance
	{
		 get { } //Length: 49
	}

	public FreeMemoryStatus() { }

	private void Awake() { }

	public static FreeMemoryStatus Create(GameObject anchor) { }

	public static FreeMemoryStatus get_Instance() { }

	public void ToggleVisible(bool visible) { }

	private void Update() { }

}

