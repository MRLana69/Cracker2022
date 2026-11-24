namespace UnityEngine;

public static class RemoteSettings
{
	public delegate UpdatedEventHandler
	{

		public UpdatedEventHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	private static UpdatedEventHandler Updated; //Field offset: 0x0
	private static Action BeforeFetchFromServer; //Field offset: 0x4
	private static Action<bool, bool, int> Completed; //Field offset: 0x8

	internal static void RemoteSettingsBeforeFetchFromServer() { }

	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

}

