namespace SYBO.Components.Utilities;

public class NetworkReachabilityMonitor
{
	private sealed class <PollToCheckNetworkReachability>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public NetworkReachabilityMonitor <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 222
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PollToCheckNetworkReachability>d__10(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const int TimeDelayBetweenPolling = 1; //Field offset: 0x0
	public UnityEvent OnNetworkReachabilityChanged; //Field offset: 0x10
	private NetworkReachability _previousNetworkReachability; //Field offset: 0x14
	private Coroutine _checkNetworkReachability; //Field offset: 0x18

	public bool IsNetworkReachable
	{
		 get { } //Length: 139
	}

	public NetworkReachability NetworkReachability
	{
		 get { } //Length: 10
	}

	public NetworkReachabilityMonitor() { }

	public bool get_IsNetworkReachable() { }

	public NetworkReachability get_NetworkReachability() { }

	protected override void OnDestroy() { }

	private IEnumerator PollToCheckNetworkReachability() { }

	protected override void SubclassInitialize() { }

}

