namespace Kiloo.Common.HTTP.Internal;

internal class UnityRequest : Request
{
	private sealed class <SendCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UnityRequest <>4__this; //Field offset: 0x10
		private bool <ok>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1167
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SendCoroutine>d__4(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private AsyncOperation _sendAsyncOperation; //Field offset: 0x48
	private UnityWebRequest _unityWebRequest; //Field offset: 0x4C

	public UnityRequest(string method, Uri uri, byte[] bytes) { }

	private IResponse CreateResponseFromUnityWebRequest() { }

	public override void FetchResponse() { }

	public override void FetchResponseAsync() { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	public override void PrepareFetchResponse() { }

	private IEnumerator SendCoroutine() { }

	private void SendUnityWebRequest() { }

}

