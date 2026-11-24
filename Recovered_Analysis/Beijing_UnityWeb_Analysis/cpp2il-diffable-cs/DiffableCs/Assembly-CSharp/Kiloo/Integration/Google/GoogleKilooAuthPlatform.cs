namespace Kiloo.Integration.Google;

public class GoogleKilooAuthPlatform : IKilooAuthPlatform
{
	private sealed class <UpdateAsyncCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GoogleKilooAuthPlatform <>4__this; //Field offset: 0x10
		private GoogleSignInPluginRequest <request>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 284
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UpdateAsyncCoroutine>d__9(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public const string NAME = "Google"; //Field offset: 0x0
	private IGoogleProfile _profile; //Field offset: 0x8

	public string name
	{
		 get { } //Length: 153
	}

	public string signature
	{
		 get { } //Length: 248
	}

	public IDictionary<string, string> value
	{
		 get { } //Length: 43
	}

	public GoogleKilooAuthPlatform() { }

	public string get_name() { }

	public string get_signature() { }

	public IDictionary<string, string> get_value() { }

	public Coroutine UpdateAsync() { }

	private IEnumerator UpdateAsyncCoroutine() { }

}

