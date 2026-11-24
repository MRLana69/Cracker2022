namespace UnityEngine.Analytics;

public static class AnalyticsSessionInfo
{
	public delegate SessionStateChanged
	{

		public SessionStateChanged(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	}

	private static SessionStateChanged sessionStateChanged; //Field offset: 0x0

	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

}

