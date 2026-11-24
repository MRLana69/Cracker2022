namespace UnityEngine.Networking.Match;

public class NetworkMatch : MonoBehaviour
{
	private sealed class <ProcessMatchResponse>c__Iterator0`2 : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal UnityWebRequest client; //Field offset: 0x0
		internal JSONRESPONSE <jsonInterface>__0; //Field offset: 0x0
		internal InternalResponseDelegate<JSONRESPONSE, USERRESPONSEDELEGATETYPE> internalCallback; //Field offset: 0x0
		internal USERRESPONSEDELEGATETYPE userCallback; //Field offset: 0x0
		internal object $current; //Field offset: 0x0
		internal bool $disposing; //Field offset: 0x0
		internal int $PC; //Field offset: 0x0

		private object System.Collections.Generic.IEnumerator<object>.Current
		{
			 get { } //Length: 257
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ProcessMatchResponse>c__Iterator0`2() { }

		public void Dispose() { }

		public bool MoveNext() { }

		public void Reset() { }

		private object System.Collections.Generic.IEnumerator<object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

	}

	public delegate BasicResponseDelegate
	{

		public BasicResponseDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool success, string extendedInfo, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(bool success, string extendedInfo) { }

	}

	public delegate DataResponseDelegate`1
	{

		public DataResponseDelegate`1(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool success, string extendedInfo, T responseData, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(bool success, string extendedInfo, T responseData) { }

	}

	private delegate InternalResponseDelegate`2
	{

		public InternalResponseDelegate`2(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(T response, U userCallback, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(T response, U userCallback) { }

	}

	private Uri m_BaseUri; //Field offset: 0xC

	public Uri baseUri
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public NetworkMatch() { }

	internal Coroutine CreateMatch(CreateMatchRequest req, DataResponseDelegate<MatchInfo> callback) { }

	public Coroutine CreateMatch(string matchName, uint matchSize, bool matchAdvertise, string matchPassword, string publicClientAddress, string privateClientAddress, int eloScoreForMatch, int requestDomain, DataResponseDelegate<MatchInfo> callback) { }

	public Coroutine DestroyMatch(NetworkID netId, int requestDomain, BasicResponseDelegate callback) { }

	internal Coroutine DestroyMatch(DestroyMatchRequest req, BasicResponseDelegate callback) { }

	public Coroutine DropConnection(NetworkID netId, NodeID dropNodeId, int requestDomain, BasicResponseDelegate callback) { }

	internal Coroutine DropConnection(DropConnectionRequest req, BasicResponseDelegate callback) { }

	public Uri get_baseUri() { }

	public Coroutine JoinMatch(NetworkID netId, string matchPassword, string publicClientAddress, string privateClientAddress, int eloScoreForClient, int requestDomain, DataResponseDelegate<MatchInfo> callback) { }

	internal Coroutine JoinMatch(JoinMatchRequest req, DataResponseDelegate<MatchInfo> callback) { }

	public Coroutine ListMatches(int startPageNumber, int resultPageSize, string matchNameFilter, bool filterOutPrivateMatchesFromResults, int eloScoreTarget, int requestDomain, DataResponseDelegate<List<MatchInfoSnapshot>> callback) { }

	internal Coroutine ListMatches(ListMatchRequest req, DataResponseDelegate<List<MatchInfoSnapshot>> callback) { }

	internal void OnDropConnection(DropConnectionResponse response, BasicResponseDelegate userCallback) { }

	internal virtual void OnMatchCreate(CreateMatchResponse response, DataResponseDelegate<MatchInfo> userCallback) { }

	internal void OnMatchDestroyed(BasicResponse response, BasicResponseDelegate userCallback) { }

	internal void OnMatchJoined(JoinMatchResponse response, DataResponseDelegate<MatchInfo> userCallback) { }

	internal void OnMatchList(ListMatchResponse response, DataResponseDelegate<List<MatchInfoSnapshot>> userCallback) { }

	internal void OnSetMatchAttributes(BasicResponse response, BasicResponseDelegate userCallback) { }

	private IEnumerator ProcessMatchResponse(UnityWebRequest client, InternalResponseDelegate<JSONRESPONSE, USERRESPONSEDELEGATETYPE> internalCallback, USERRESPONSEDELEGATETYPE userCallback) { }

	public void set_baseUri(Uri value) { }

	public Coroutine SetMatchAttributes(NetworkID networkId, bool isListed, int requestDomain, BasicResponseDelegate callback) { }

	internal Coroutine SetMatchAttributes(SetMatchAttributesRequest req, BasicResponseDelegate callback) { }

	public void SetProgramAppID(AppID programAppID) { }

}

