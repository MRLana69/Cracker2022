namespace Kiloo.Common.Backend.Authentication;

public static class KilooAuthRequestExtensions
{
	private sealed class <>c__DisplayClass6_0
	{
		public IRequest request; //Field offset: 0x8
		public bool isFromCache; //Field offset: 0xC

		public <>c__DisplayClass6_0() { }

		internal void <SendAuthenticatedAsyncCoroutine>b__0(bool success, Error error) { }

		internal void <SendAuthenticatedAsyncCoroutine>b__1(IRequest rqst, bool fromCache) { }

	}

	private sealed class <SendAuthenticatedAsyncCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public IRequest request; //Field offset: 0x10
		public IKilooAuth kilooAuth; //Field offset: 0x14
		private <>c__DisplayClass6_0 <>8__1; //Field offset: 0x18
		public SendOptions options; //Field offset: 0x1C
		public RequestCompleteHandler onComplete; //Field offset: 0x2C
		private int <tries>5__2; //Field offset: 0x30
		private bool <retry>5__3; //Field offset: 0x34

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 610
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SendAuthenticatedAsyncCoroutine>d__6(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const string AUTHORIZATION_HEADER = "Authorization"; //Field offset: 0x0
	private const string AUTHORIZATION_FORMAT = "KilooAuth AccessToken="{0}""; //Field offset: 0x0

	public static bool IsAuthenticationErrorResponse(IRequest request) { }

	private static void Log(string msg) { }

	public static void SendAuthenticated(IRequest request, IKilooAuth kilooAuth, SendOptions options = null) { }

	public static Coroutine SendAuthenticatedAsync(IRequest request, IKilooAuth kilooAuth, RequestCompleteHandler onComplete = null, SendOptions options = null) { }

	private static IEnumerator SendAuthenticatedAsyncCoroutine(IRequest request, IKilooAuth kilooAuth, RequestCompleteHandler onComplete, SendOptions options) { }

	public static IRequest WithKilooAuth(IRequest request, IKilooAuth kilooAuth) { }

}

