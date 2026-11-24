namespace UnityEngine.Networking;

public class NetworkProximityChecker : NetworkBehaviour
{
	public enum CheckMethod
	{
		Physics3D = 0,
		Physics2D = 1,
	}

	public int visRange; //Field offset: 0x1C
	public float visUpdateInterval; //Field offset: 0x20
	public CheckMethod checkMethod; //Field offset: 0x24
	public bool forceHidden; //Field offset: 0x28
	private float m_VisUpdateTime; //Field offset: 0x2C

	public NetworkProximityChecker() { }

	public override bool OnCheckObserver(NetworkConnection newObserver) { }

	public override bool OnRebuildObservers(HashSet<NetworkConnection> observers, bool initial) { }

	public override void OnSetLocalVisibility(bool vis) { }

	private static void SetVis(GameObject go, bool vis) { }

	private void Update() { }

}

