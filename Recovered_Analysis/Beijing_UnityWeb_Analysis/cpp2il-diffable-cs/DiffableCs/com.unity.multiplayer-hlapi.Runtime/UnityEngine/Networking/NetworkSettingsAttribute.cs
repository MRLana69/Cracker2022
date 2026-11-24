namespace UnityEngine.Networking;

public class NetworkSettingsAttribute : Attribute
{
	public int channel; //Field offset: 0x8
	public float sendInterval; //Field offset: 0xC

	public NetworkSettingsAttribute() { }

}

