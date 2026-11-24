namespace UnityEngine.Networking;

public class PlayerController
{
	internal const short kMaxLocalPlayers = 8; //Field offset: 0x0
	public const int MaxPlayersPerClient = 32; //Field offset: 0x0
	public short playerControllerId; //Field offset: 0x8
	public NetworkIdentity unetView; //Field offset: 0xC
	public GameObject gameObject; //Field offset: 0x10

	public bool IsValid
	{
		 get { } //Length: 113
	}

	public PlayerController() { }

	internal PlayerController(GameObject go, short playerControllerId) { }

	public bool get_IsValid() { }

	public override string ToString() { }

}

