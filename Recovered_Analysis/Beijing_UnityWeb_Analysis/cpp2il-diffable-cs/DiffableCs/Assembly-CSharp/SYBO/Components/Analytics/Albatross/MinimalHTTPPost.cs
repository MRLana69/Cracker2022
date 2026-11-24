namespace SYBO.Components.Analytics.Albatross;

public class MinimalHTTPPost : IHTTPPostLayer
{
	private sealed class <WaitForWWWRequest>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string url; //Field offset: 0x10
		public byte[] bytes; //Field offset: 0x14
		public Dictionary<string, string> headers; //Field offset: 0x18
		public MinimalHTTPPost <>4__this; //Field offset: 0x1C
		public Action<int, string, string> onFinish; //Field offset: 0x20
		private WWW <www>5__2; //Field offset: 0x24
		private float <timeoutPoint>5__3; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1154
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <WaitForWWWRequest>d__4(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private MonoBehaviour _coroutineHost; //Field offset: 0x8
	private float _timeout; //Field offset: 0xC

	public MinimalHTTPPost(MonoBehaviour coroutineHost, float timeout = 60) { }

	public static int GetResponseCode(WWW request) { }

	public static int ParseResponseCode(string statusLine) { }

	public void POST(string url, Dictionary<string, string> headers, byte[] bytes, Action<int, string, string> onFinish) { }

	private IEnumerator WaitForWWWRequest(string url, Dictionary<string, string> headers, byte[] bytes, Action<int, string, string> onFinish) { }

}

