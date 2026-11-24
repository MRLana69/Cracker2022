namespace UnityEngine;

public class RemoteConfigSettings
{
	internal nint m_Ptr; //Field offset: 0x8
	private Action<bool> Updated; //Field offset: 0xC

	private void Destroy() { }

	protected override void Finalize() { }

	internal static void Internal_Destroy(nint ptr) { }

	internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) { }

}

