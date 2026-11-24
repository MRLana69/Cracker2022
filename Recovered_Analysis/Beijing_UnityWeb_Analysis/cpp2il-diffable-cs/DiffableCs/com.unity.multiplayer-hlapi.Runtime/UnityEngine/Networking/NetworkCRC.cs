namespace UnityEngine.Networking;

public class NetworkCRC
{
	internal static NetworkCRC s_Singleton; //Field offset: 0x0
	private Dictionary<string, int> m_Scripts; //Field offset: 0x8
	private bool m_ScriptCRCCheck; //Field offset: 0xC

	public static bool scriptCRCCheck
	{
		 get { } //Length: 103
		 set { } //Length: 22
	}

	public Dictionary<string, int> scripts
	{
		 get { } //Length: 277
	}

	internal static NetworkCRC singleton
	{
		 get { } //Length: 1191
	}

	public NetworkCRC() { }

	private void Dump(CRCMessageEntry[] remoteScripts) { }

	public static bool get_scriptCRCCheck() { }

	public Dictionary<string, int> get_scripts() { }

	internal static NetworkCRC get_singleton() { }

	public static void RegisterBehaviour(string name, int channel) { }

	public static void ReinitializeScriptCRCs(Assembly callingAssembly) { }

	public static void set_scriptCRCCheck(bool value) { }

	internal static bool Validate(CRCMessageEntry[] scripts, int numChannels) { }

	private bool ValidateInternal(CRCMessageEntry[] remoteScripts, int numChannels) { }

}

