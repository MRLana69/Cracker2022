namespace Kiloo.Common.Backend.Authentication;

public sealed class KilooAuth : IKilooAuth
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair<string, IKilooAuthPlatform>, bool> <>9__44_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <CanAuthenticate>b__44_0(KeyValuePair<string, IKilooAuthPlatform> pair) { }

	}

	private sealed class <AuthenticateCoroutine>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public KilooAuth <>4__this; //Field offset: 0x10
		public AuthenticateCompleteHandler completeHandler; //Field offset: 0x14
		private Error <error>5__2; //Field offset: 0x18
		private Dictionary<string, string> <signatures>5__3; //Field offset: 0x1C
		private IRequest <request>5__4; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1234
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AuthenticateCoroutine>d__48(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DetachPlatformsCoroutine>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string[] platformsToDetach; //Field offset: 0x10
		public KilooAuth <>4__this; //Field offset: 0x14
		public DetachPlatformsCompleteHandler completeHandler; //Field offset: 0x18
		private IRequest <request>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 902
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DetachPlatformsCoroutine>d__49(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <GenerateTemporaryCodeCoroutine>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public KilooAuth <>4__this; //Field offset: 0x10
		public GenerateTemporaryCodeCompleteHandler completeHandler; //Field offset: 0x14
		private IRequest <request>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 741
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GenerateTemporaryCodeCoroutine>d__50(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <get_platforms>d__30 : IEnumerable<IKilooAuthPlatform>, IEnumerable, IEnumerator<IKilooAuthPlatform>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private IKilooAuthPlatform <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		public KilooAuth <>4__this; //Field offset: 0x14
		private Enumerator<string, IKilooAuthPlatform> <>7__wrap1; //Field offset: 0x18

		private IKilooAuthPlatform System.Collections.Generic.IEnumerator<Kiloo.Common.Backend.Authentication.IKilooAuthPlatform>.Current
		{
			 get { } //Length: 485
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <get_platforms>d__30(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private IEnumerator<IKilooAuthPlatform> System.Collections.Generic.IEnumerable<Kiloo.Common.Backend.Authentication.IKilooAuthPlatform>.GetEnumerator() { }

		private IKilooAuthPlatform System.Collections.Generic.IEnumerator<Kiloo.Common.Backend.Authentication.IKilooAuthPlatform>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class AccessTokenResult
	{
		public string accessToken; //Field offset: 0x8
		public string kilooId; //Field offset: 0xC
		public string kilooTag; //Field offset: 0x10
		public DateTime expires; //Field offset: 0x18

		public AccessTokenResult() { }

	}

	public delegate DetachPlatformsCompleteHandler
	{

		public DetachPlatformsCompleteHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool success, Error error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(bool success, Error error) { }

	}

	public delegate GenerateTemporaryCodeCompleteHandler
	{

		public GenerateTemporaryCodeCompleteHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(TempCode tempCode, Error error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(TempCode tempCode, Error error) { }

	}

	private struct PersistentAuthData
	{
		public string loginToken; //Field offset: 0x0
		public KilooAuthState state; //Field offset: 0x4
		public DateTime expires; //Field offset: 0x8
		public string kilooId; //Field offset: 0x10
		public string kilooTag; //Field offset: 0x14
		public Dictionary<string, string> signatures; //Field offset: 0x18

	}

	public class TempCode
	{
		public string code; //Field offset: 0x8
		public DateTimeOffset expires; //Field offset: 0x10

		public TempCode() { }

	}

	public const string KILOO_ID_KEY = "kilooId"; //Field offset: 0x0
	public const string TEMPORARY_CODE_KEY = "temporaryCode"; //Field offset: 0x0
	private const float TIME_TOLERANCE = 60; //Field offset: 0x0
	private const string API_CREATE = "api/v3/user/create"; //Field offset: 0x0
	private const string API_LOGIN = "api/v3/user/login"; //Field offset: 0x0
	private const string API_DETACH = "api/v3/user/detach"; //Field offset: 0x0
	private const string API_GENERATE_TEMPORARY_CODE = "api/v3/user/generatetemporarycode"; //Field offset: 0x0
	private string <temporaryCode>k__BackingField; //Field offset: 0x8
	private bool <allowAnonymous>k__BackingField; //Field offset: 0xC
	private readonly Uri _baseUri; //Field offset: 0x10
	private readonly string _file; //Field offset: 0x14
	private readonly IJsonSerializer _jsonSerializer; //Field offset: 0x18
	private readonly Dictionary<string, IKilooAuthPlatform> _platforms; //Field offset: 0x1C
	private PersistentAuthData _data; //Field offset: 0x20

	public string accessToken
	{
		 get { } //Length: 9
	}

	public bool allowAnonymous
	{
		 get { } //Length: 245
		 set { } //Length: 11
	}

	public string kilooTag
	{
		 get { } //Length: 6
	}

	public IEnumerable<IKilooAuthPlatform> platforms
	{
		 get { } //Length: 9
	}

	public KilooAuthState state
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public string temporaryCode
	{
		 get { } //Length: 1428
		 set { } //Length: 10
	}

	public KilooAuth(Uri baseUri, string file, bool allowAnonymous, IJsonSerializer jsonSerializer, IKilooAuthPlatform[] platforms) { }

	public KilooAuth(Uri baseUri, string file, bool allowAnonymous, IJsonSerializer jsonSerializer, IEnumerable<IKilooAuthPlatform> platforms) { }

	private bool <IsCachedTokenValid>b__45_0(KeyValuePair<string, IKilooAuthPlatform> pair) { }

	public void AddPlatform(IKilooAuthPlatform platform) { }

	public Coroutine AuthenticateAsync(AuthenticateCompleteHandler completeHandler = null) { }

	private IEnumerator AuthenticateCoroutine(AuthenticateCompleteHandler completeHandler) { }

	private Dictionary<string, object> BuildAuthenticationRequestContent(out Dictionary<string, string> signatures) { }

	private bool CanAuthenticate() { }

	public Coroutine DetachPlatformsAsync(string[] platformsToDetach, DetachPlatformsCompleteHandler completeHandler = null) { }

	private IEnumerator DetachPlatformsCoroutine(string[] platformsToDetach, DetachPlatformsCompleteHandler completeHandler) { }

	public Coroutine GenerateTemporaryCodeAsync(GenerateTemporaryCodeCompleteHandler completeHandler = null) { }

	private IEnumerator GenerateTemporaryCodeCoroutine(GenerateTemporaryCodeCompleteHandler completeHandler) { }

	public string get_accessToken() { }

	public bool get_allowAnonymous() { }

	public string get_kilooTag() { }

	public IEnumerable<IKilooAuthPlatform> get_platforms() { }

	public KilooAuthState get_state() { }

	public string get_temporaryCode() { }

	private string GetAuthenticatedSignature(string platformName) { }

	private Error HandleAuthenticationResult(IRequest request, Dictionary<string, string> signatures) { }

	public bool HasPlatform(string platformKey) { }

	public void Invalidate() { }

	private bool IsCachedTokenValid() { }

	private void Load() { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	public void RemovePlatform(string platformKey) { }

	public void Reset() { }

	private void Save() { }

	public void set_allowAnonymous(bool value) { }

	private void set_state(KilooAuthState value) { }

	public void set_temporaryCode(string value) { }

}

