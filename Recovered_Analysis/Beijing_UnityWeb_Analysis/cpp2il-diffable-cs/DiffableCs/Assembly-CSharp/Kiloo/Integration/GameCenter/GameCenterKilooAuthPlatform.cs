namespace Kiloo.Integration.GameCenter;

public class GameCenterKilooAuthPlatform : IKilooAuthPlatform
{
	private sealed class <UpdateAsyncCoroutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameCenterKilooAuthPlatform <>4__this; //Field offset: 0x10
		private LocalPlayer <gameCenterPlayer>5__2; //Field offset: 0x14
		private GameCenterGenerateIdentityVerificationSignatureRequest <signatureRequest>5__3; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1035
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UpdateAsyncCoroutine>d__11(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public const string NAME = "GameCenter"; //Field offset: 0x0
	private bool _updated; //Field offset: 0x8
	private Dictionary<string, string> _value; //Field offset: 0xC
	private string _signature; //Field offset: 0x10

	public string name
	{
		 get { } //Length: 66
	}

	public string signature
	{
		 get { } //Length: 14
	}

	public IDictionary<string, string> value
	{
		 get { } //Length: 43
	}

	public GameCenterKilooAuthPlatform() { }

	public string get_name() { }

	public string get_signature() { }

	public IDictionary<string, string> get_value() { }

	private void IsUpdatedOrThrow() { }

	private static void LogError(string msg) { }

	public Coroutine UpdateAsync() { }

	private IEnumerator UpdateAsyncCoroutine() { }

}

