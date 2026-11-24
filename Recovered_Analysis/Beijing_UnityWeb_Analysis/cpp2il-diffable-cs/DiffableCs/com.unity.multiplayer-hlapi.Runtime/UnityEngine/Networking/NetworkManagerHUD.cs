namespace UnityEngine.Networking;

public class NetworkManagerHUD : MonoBehaviour
{
	public NetworkManager manager; //Field offset: 0xC
	public bool showGUI; //Field offset: 0x10
	public int offsetX; //Field offset: 0x14
	public int offsetY; //Field offset: 0x18
	private bool m_ShowServer; //Field offset: 0x1C

	public NetworkManagerHUD() { }

	private void Awake() { }

	private void OnGUI() { }

	private void Update() { }

}

