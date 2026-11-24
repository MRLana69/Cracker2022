namespace Kiloo.Common.Backend.Cloud;

public sealed class SimulatedCloudServer : ICloudServer
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair<string, Item>, ICloudItem> <>9__7_0; //Field offset: 0x4
		public static Comparison<ICloudItem> <>9__33_0; //Field offset: 0x8
		public static GetBytesFunction <>9__44_0; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal ICloudItem <GetItems>b__7_0(KeyValuePair<string, Item> item) { }

		internal byte[] <GetStatusList>b__44_0(string name) { }

		internal int <InternalUpdateItems>b__33_0(ICloudItem a, ICloudItem b) { }

	}

	private sealed class <>c__DisplayClass33_0
	{
		public Item repositoryItem; //Field offset: 0x8

		public <>c__DisplayClass33_0() { }

		internal bool <InternalUpdateItems>b__1(ICloudItem item) { }

	}

	private sealed class <CommitItemsCoroutine>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SimulatedCloudServer <>4__this; //Field offset: 0x10
		public IEnumerable<ICloudItem> items; //Field offset: 0x14
		public CloudServerCommitCompleteHandler completeHandler; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 175
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CommitItemsCoroutine>d__38(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <ListItemsCoroutine>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SimulatedCloudServer <>4__this; //Field offset: 0x10
		public CloudServerRequestCompleteHandler completeHandler; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 170
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ListItemsCoroutine>d__32(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <UpdateItemsCoroutine>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SimulatedCloudServer <>4__this; //Field offset: 0x10
		public IEnumerable<ICloudItem> items; //Field offset: 0x14
		public CloudServerRequestCompleteHandler completeHandler; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 175
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UpdateItemsCoroutine>d__34(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class Item : ICloudItem
	{
		public delegate GetBytesFunction
		{

			public GetBytesFunction(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(string name, AsyncCallback callback, object object) { }

			public virtual byte[] EndInvoke(IAsyncResult result) { }

			public virtual byte[] Invoke(string name) { }

		}

		private string <name>k__BackingField; //Field offset: 0x8
		private string <revision>k__BackingField; //Field offset: 0xC
		private Nullable<DateTime> <lastModified>k__BackingField; //Field offset: 0x10
		private string <sourceDescription>k__BackingField; //Field offset: 0x20
		private string <sourceInstallationId>k__BackingField; //Field offset: 0x24
		private int <dataVersion>k__BackingField; //Field offset: 0x28
		private ICloudUserData <userData>k__BackingField; //Field offset: 0x2C
		private readonly GetBytesFunction _getBytesFunction; //Field offset: 0x30

		public int dataVersion
		{
			 get { } //Length: 6
			private set { } //Length: 11
		}

		public bool isModified
		{
			 get { } //Length: 6
		}

		public bool isOutOfDate
		{
			 get { } //Length: 3
		}

		public Nullable<DateTime> lastModified
		{
			 get { } //Length: 11
			private set { } //Length: 26
		}

		public string name
		{
			 get { } //Length: 6
			private set { } //Length: 8
		}

		public string revision
		{
			 get { } //Length: 6
			private set { } //Length: 11
		}

		public string sourceDescription
		{
			 get { } //Length: 3
			private set { } //Length: 61
		}

		public string sourceInstallationId
		{
			 get { } //Length: 6
			private set { } //Length: 11
		}

		public ICloudUserData userData
		{
			 get { } //Length: 6
			private set { } //Length: 8
		}

		public Item(string name, string revision, Nullable<DateTime> lastModified, string sourceDescription, string sourceInstallationId, int dataVersion, ICloudUserData userData, GetBytesFunction getBytesFunction) { }

		public int get_dataVersion() { }

		public bool get_isModified() { }

		public bool get_isOutOfDate() { }

		public Nullable<DateTime> get_lastModified() { }

		public string get_name() { }

		public string get_revision() { }

		public string get_sourceDescription() { }

		public string get_sourceInstallationId() { }

		public ICloudUserData get_userData() { }

		public Stream GetDataStream() { }

		private void set_dataVersion(int value) { }

		private void set_lastModified(Nullable<DateTime> value) { }

		private void set_name(string value) { }

		private void set_revision(string value) { }

		private void set_sourceDescription(string value) { }

		private void set_sourceInstallationId(string value) { }

		private void set_userData(ICloudUserData value) { }

	}

	private class Metadata
	{
		public string revision; //Field offset: 0x8
		public Nullable<DateTime> lastModified; //Field offset: 0x10
		public string sourceDescription; //Field offset: 0x20
		public string sourceInstallationId; //Field offset: 0x24
		public int dataVersion; //Field offset: 0x28
		public Dictionary<string, string> userdata; //Field offset: 0x2C

		public Metadata() { }

	}

	private static SimulatedCloudServer _instance; //Field offset: 0x0
	private const string REPOSITORY_DIR = ".simulatedcloudserver"; //Field offset: 0x0
	private const string METADATA_DIR = ".metadata"; //Field offset: 0x0
	private static readonly DateTime _epoch; //Field offset: 0x8
	public float simulatedLatency; //Field offset: 0x8
	public bool simulateError; //Field offset: 0xC
	private readonly string _localDir; //Field offset: 0x10
	private readonly string _metadataDir; //Field offset: 0x14
	private Dictionary<string, Item> _items; //Field offset: 0x18
	private readonly IJsonSerializer _jsonSerializer; //Field offset: 0x1C

	public static SimulatedCloudServer instance
	{
		 get { } //Length: 261
	}

	public string kilooTag
	{
		 get { } //Length: 261
	}

	private static SimulatedCloudServer() { }

	private SimulatedCloudServer() { }

	public CloudServerCommitResult CommitItems(string forKilooTag, IEnumerable<ICloudItem> items) { }

	public Coroutine CommitItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerCommitCompleteHandler completeHandler) { }

	private IEnumerator CommitItemsCoroutine(IEnumerable<ICloudItem> items, CloudServerCommitCompleteHandler completeHandler) { }

	private void CreateLocalDirsIfNecessary() { }

	public static void DeleteServerDebug() { }

	public static SimulatedCloudServer get_instance() { }

	public string get_kilooTag() { }

	public ICloudItem GetItem(string name) { }

	public List<ICloudItem> GetItems() { }

	private string GetMetadataPathFor(string name) { }

	private string GetNameFor(string path) { }

	private string GetPathFor(string name) { }

	private ICloudItem[] GetStatusList() { }

	private CloudServerCommitResult InternalCommitItems(IEnumerable<ICloudItem> items) { }

	private CloudServerResult InternalListItems() { }

	private CloudServerResult InternalUpdateItems(IEnumerable<ICloudItem> items) { }

	public CloudServerResult ListItems(string forKilooTag) { }

	public Coroutine ListItemsAsync(string forKilooTag, CloudServerRequestCompleteHandler completeHandler) { }

	private IEnumerator ListItemsCoroutine(CloudServerRequestCompleteHandler completeHandler) { }

	private byte[] LoadItem(string name) { }

	private Item LoadMetadata(string filename) { }

	private void LoadRepository() { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	public void Reload() { }

	private void SaveMetadata(Item item) { }

	public void SetItemDataVersion(string name, int dataVersion) { }

	public void SetItemLastModified(string name, DateTime lastModified) { }

	public void SetItemRevision(string name, string revision) { }

	public void SetItemSourceDescription(string name, string sourceDescription) { }

	public void SetItemSourceInstallationId(string name, string sourceInstallationId) { }

	public void SimulateNewRevision(string name, ICloudUserData userData) { }

	public void SimulateNewRevision(string name, byte[] bytes, string sourceDescription, string sourceInstallationId, int dataVersion, ICloudUserData userData) { }

	public void SimulateNewRevision(string name) { }

	private static string ToRevision(Nullable<DateTime> value) { }

	public CloudServerResult UpdateItems(string forKilooTag, IEnumerable<ICloudItem> items) { }

	public Coroutine UpdateItemsAsync(string forKilooTag, IEnumerable<ICloudItem> items, CloudServerRequestCompleteHandler completeHandler) { }

	private IEnumerator UpdateItemsCoroutine(IEnumerable<ICloudItem> items, CloudServerRequestCompleteHandler completeHandler) { }

}

