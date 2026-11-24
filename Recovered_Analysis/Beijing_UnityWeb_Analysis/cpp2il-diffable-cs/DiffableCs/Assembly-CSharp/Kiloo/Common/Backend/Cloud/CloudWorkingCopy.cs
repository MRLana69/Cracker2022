namespace Kiloo.Common.Backend.Cloud;

public sealed class CloudWorkingCopy
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair<string, ItemMetadata>, <>f__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata>> <>9__29_0; //Field offset: 0x4
		public static Func<KeyValuePair<string, ItemMetadata>, <>f__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata>> <>9__67_0; //Field offset: 0x8
		public static Func<<>f__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata>, bool> <>9__67_1; //Field offset: 0xC
		public static Func<ICloudConflict, bool> <>9__69_0; //Field offset: 0x10
		public static Func<KeyValuePair<string, ItemMetadata>, bool> <>9__72_0; //Field offset: 0x14

		private static <>c() { }

		public <>c() { }

		internal bool <ApplyUpdate>b__69_0(ICloudConflict conflict) { }

		internal <>f__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata> <GetItems>b__29_0(KeyValuePair<string, ItemMetadata> entry) { }

		internal bool <PrepareCommitContext>b__72_0(KeyValuePair<string, ItemMetadata> entry) { }

		internal <>f__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata> <PrepareUpdateContext>b__67_0(KeyValuePair<string, ItemMetadata> element) { }

		internal bool <PrepareUpdateContext>b__67_1(<>f__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata> <>h__TransparentIdentifier0) { }

	}

	private sealed class <>c__DisplayClass70_0
	{
		public UpdateContext context; //Field offset: 0x8

		public <>c__DisplayClass70_0() { }

		internal void <UpdateCoroutine>b__0(CloudServerResult result) { }

	}

	private sealed class <>c__DisplayClass73_0
	{
		public string localItemName; //Field offset: 0x8

		public <>c__DisplayClass73_0() { }

		internal bool <ProcessCommitResult>b__0(ICloudItem item) { }

	}

	private sealed class <>c__DisplayClass73_1
	{
		public ICloudItem theirItem; //Field offset: 0x8

		public <>c__DisplayClass73_1() { }

		internal bool <ProcessCommitResult>b__1(ICloudItem item) { }

	}

	private sealed class <>c__DisplayClass74_0
	{
		public CommitContext context; //Field offset: 0x8

		public <>c__DisplayClass74_0() { }

		internal void <CommitCoroutine>b__0(CloudServerCommitResult result) { }

	}

	private sealed class <>c__DisplayClass77_0
	{
		public CommitContext context; //Field offset: 0x8

		public <>c__DisplayClass77_0() { }

		internal void <UpdateMetadataCoroutine>b__0(CloudServerResult result) { }

	}

	private sealed class <>c__DisplayClass78_0
	{
		public bool updateSuccess; //Field offset: 0x8
		public bool commitSuccess; //Field offset: 0x9

		public <>c__DisplayClass78_0() { }

		internal void <SynchronizeCoroutine>b__0(bool success) { }

		internal void <SynchronizeCoroutine>b__1(bool success) { }

	}

	private sealed class <CommitCoroutine>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudWorkingCopy <>4__this; //Field offset: 0x10
		public bool calledFromSynchronize; //Field offset: 0x14
		private <>c__DisplayClass74_0 <>8__1; //Field offset: 0x18
		public CompleteHandler completeHandler; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 342
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CommitCoroutine>d__74(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <SynchronizeCoroutine>d__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudWorkingCopy <>4__this; //Field offset: 0x10
		public CloudConflictResolver conflictResolver; //Field offset: 0x14
		private <>c__DisplayClass78_0 <>8__1; //Field offset: 0x18
		public SynchronizeCompleteHandler completeHandler; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 502
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SynchronizeCoroutine>d__78(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <UpdateCoroutine>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudWorkingCopy <>4__this; //Field offset: 0x10
		public CloudConflictResolver conflictResolver; //Field offset: 0x14
		public bool calledFromSynchronize; //Field offset: 0x18
		private <>c__DisplayClass70_0 <>8__1; //Field offset: 0x1C
		public CompleteHandler completeHandler; //Field offset: 0x20
		private bool <success>5__2; //Field offset: 0x24
		private Enumerator<ICloudConflict> <>7__wrap2; //Field offset: 0x28
		private ICloudConflict <conflict>5__4; //Field offset: 0x38

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1503
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UpdateCoroutine>d__70(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <UpdateMetadataCoroutine>d__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CloudWorkingCopy <>4__this; //Field offset: 0x10
		private <>c__DisplayClass77_0 <>8__1; //Field offset: 0x14
		public CompleteHandler completeHandler; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 319
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <UpdateMetadataCoroutine>d__77(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class CommitContext
	{
		public string method; //Field offset: 0x8
		public ICloudItem[] modifiedLocalItems; //Field offset: 0xC
		public CloudServerCommitResult result; //Field offset: 0x10

		public CommitContext() { }

	}

	public delegate CompleteHandler
	{

		public CompleteHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool success, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(bool success) { }

	}

	private class Conflict : ICloudConflict
	{
		private sealed class <>c__DisplayClass20_0
		{
			public byte[] copy; //Field offset: 0x8

			public <>c__DisplayClass20_0() { }

			internal Stream <ResolveWith>b__0(LocalItem s) { }

		}

		private ICloudItem <mine>k__BackingField; //Field offset: 0x8
		private ICloudItem <theirs>k__BackingField; //Field offset: 0xC
		private ICloudItem <resolution>k__BackingField; //Field offset: 0x10
		private CloudConflictResolution <resolveMethod>k__BackingField; //Field offset: 0x14

		public ICloudItem mine
		{
			 get { } //Length: 54
			private set { } //Length: 8
		}

		public string name
		{
			 get { } //Length: 6
		}

		public ICloudItem resolution
		{
			 get { } //Length: 6
			private set { } //Length: 11
		}

		public CloudConflictResolution resolveMethod
		{
			 get { } //Length: 6
			private set { } //Length: 11
		}

		public ICloudItem theirs
		{
			 get { } //Length: 6
			private set { } //Length: 11
		}

		public Conflict(ICloudItem mine, ICloudItem theirs) { }

		private Stream <ResolveUsingMine>b__18_0(LocalItem s) { }

		public ICloudItem get_mine() { }

		public string get_name() { }

		public ICloudItem get_resolution() { }

		public CloudConflictResolution get_resolveMethod() { }

		public ICloudItem get_theirs() { }

		public void ResolveUsingMine() { }

		public void ResolveUsingTheirs() { }

		public void ResolveWith(byte[] data, ICloudUserData userData) { }

		private void set_mine(ICloudItem value) { }

		private void set_resolution(ICloudItem value) { }

		private void set_resolveMethod(CloudConflictResolution value) { }

		private void set_theirs(ICloudItem value) { }

	}

	private class ItemMetadata
	{
		private string <revision>k__BackingField; //Field offset: 0x8
		private Nullable<DateTime> <lastModified>k__BackingField; //Field offset: 0x10
		private bool <isOutOfDate>k__BackingField; //Field offset: 0x20
		private bool <isModified>k__BackingField; //Field offset: 0x21
		private int <serverDataVersion>k__BackingField; //Field offset: 0x24
		private int <pristineCrc32>k__BackingField; //Field offset: 0x28
		private Dictionary<string, string> <userData>k__BackingField; //Field offset: 0x2C

		public bool isModified
		{
			 get { } //Length: 9
			private set { } //Length: 11
		}

		public bool isOutOfDate
		{
			 get { } //Length: 6
			private set { } //Length: 61
		}

		public Nullable<DateTime> lastModified
		{
			 get { } //Length: 11
			private set { } //Length: 26
		}

		public int pristineCrc32
		{
			 get { } //Length: 6
			private set { } //Length: 8
		}

		public string revision
		{
			 get { } //Length: 6
			private set { } //Length: 10
		}

		public int serverDataVersion
		{
			 get { } //Length: 9
			private set { } //Length: 11
		}

		public Dictionary<string, string> userData
		{
			 get { } //Length: 6
			private set { } //Length: 8
		}

		public ItemMetadata(ICloudItem cloudItem, int pristineCrc32 = 0) { }

		public ItemMetadata(string revision = null, Nullable<DateTime> lastModified = null, bool isOutOfDate = false, bool isModified = false, int serverDataVersion = 0, int pristineCrc32 = 0, Dictionary<string, string> userData = null) { }

		public bool get_isModified() { }

		public bool get_isOutOfDate() { }

		public Nullable<DateTime> get_lastModified() { }

		public int get_pristineCrc32() { }

		public string get_revision() { }

		public int get_serverDataVersion() { }

		public Dictionary<string, string> get_userData() { }

		private void set_isModified(bool value) { }

		private void set_isOutOfDate(bool value) { }

		private void set_lastModified(Nullable<DateTime> value) { }

		private void set_pristineCrc32(int value) { }

		private void set_revision(string value) { }

		private void set_serverDataVersion(int value) { }

		private void set_userData(Dictionary<string, string> value) { }

		public ItemMetadata WithIsModified(bool newIsModified) { }

		public ItemMetadata WithIsOutOfDate(bool newIsOutOfDate) { }

		public ItemMetadata WithRevision(string newRevision) { }

		public ItemMetadata WithServerDataVersion(int newServerDataVersion) { }

		public ItemMetadata WithUserData(string key, string value) { }

		public ItemMetadata WithUserData(Dictionary<string, string> newUserData) { }

	}

	private class LocalItem : ICloudItem
	{
		public delegate GetDataStreamFunction
		{

			public GetDataStreamFunction(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(LocalItem localItem, AsyncCallback callback, object object) { }

			public virtual Stream EndInvoke(IAsyncResult result) { }

			public virtual Stream Invoke(LocalItem localItem) { }

		}

		private string <name>k__BackingField; //Field offset: 0x8
		private string <revision>k__BackingField; //Field offset: 0xC
		private Nullable<DateTime> <lastModified>k__BackingField; //Field offset: 0x10
		private bool <isModified>k__BackingField; //Field offset: 0x20
		private bool <isOutOfDate>k__BackingField; //Field offset: 0x21
		private string <sourceDescription>k__BackingField; //Field offset: 0x24
		private string <sourceInstallationId>k__BackingField; //Field offset: 0x28
		private int <dataVersion>k__BackingField; //Field offset: 0x2C
		private ICloudUserData <userData>k__BackingField; //Field offset: 0x30
		private bool <bytesAreSaved>k__BackingField; //Field offset: 0x34
		private readonly GetDataStreamFunction _getDataStreamFunction; //Field offset: 0x38

		public bool bytesAreSaved
		{
			 get { } //Length: 24
			private set { } //Length: 11
		}

		public int dataVersion
		{
			 get { } //Length: 6
			private set { } //Length: 11
		}

		public bool isModified
		{
			 get { } //Length: 6
			private set { } //Length: 61
		}

		public bool isOutOfDate
		{
			 get { } //Length: 9
			private set { } //Length: 11
		}

		public Nullable<DateTime> lastModified
		{
			 get { } //Length: 11
			private set { } //Length: 26
		}

		public string name
		{
			 get { } //Length: 6
			private set { } //Length: 11
		}

		public string revision
		{
			 get { } //Length: 6
			private set { } //Length: 11
		}

		public string sourceDescription
		{
			 get { } //Length: 9
			private set { } //Length: 11
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

		public LocalItem(string name, string revision, Nullable<DateTime> lastModified, bool isModified, bool isOutOfDate, string sourceDescription, string sourceInstallationId, int dataVersion, ICloudUserData userData, bool bytesAreSaved, GetDataStreamFunction getDataStreamFunction) { }

		public bool get_bytesAreSaved() { }

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

		private void set_bytesAreSaved(bool value) { }

		private void set_dataVersion(int value) { }

		private void set_isModified(bool value) { }

		private void set_isOutOfDate(bool value) { }

		private void set_lastModified(Nullable<DateTime> value) { }

		private void set_name(string value) { }

		private void set_revision(string value) { }

		private void set_sourceDescription(string value) { }

		private void set_sourceInstallationId(string value) { }

		private void set_userData(ICloudUserData value) { }

	}

	private class Metadata
	{
		public string kilooTag; //Field offset: 0x8
		public Dictionary<string, ItemMetadata> items; //Field offset: 0xC

		public Metadata() { }

	}

	public delegate SynchronizeCompleteHandler
	{

		public SynchronizeCompleteHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(bool updateSuccess, bool commitSuccess, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(bool updateSuccess, bool commitSuccess) { }

	}

	private class UpdateContext
	{
		public string method; //Field offset: 0x8
		public CloudConflictResolver conflictResolver; //Field offset: 0xC
		public ICloudItem[] localItemsWithRevisionIds; //Field offset: 0x10
		public CloudServerResult result; //Field offset: 0x14
		public List<ICloudConflict> conflicts; //Field offset: 0x18
		public List<ICloudItem> saveItems; //Field offset: 0x1C
		public List<CloudItemUpdatedArgs> itemUpdatedEventArgs; //Field offset: 0x20

		public UpdateContext() { }

	}

	private const string METADATA_FILE = ".cloudsave"; //Field offset: 0x0
	private EventHandler<CloudItemUpdatedArgs> itemUpdated; //Field offset: 0x8
	private string <sourceDescription>k__BackingField; //Field offset: 0xC
	private readonly ICloudServer _cloudServer; //Field offset: 0x10
	private readonly IFileSaver _fileSaver; //Field offset: 0x14
	private readonly string _installationId; //Field offset: 0x18
	private readonly int _dataVersion; //Field offset: 0x1C
	private readonly string _rootDir; //Field offset: 0x20
	private readonly string _metadataFile; //Field offset: 0x24
	private Metadata _meta; //Field offset: 0x28
	private bool _abortUpdate; //Field offset: 0x2C
	private bool _abortSynchronize; //Field offset: 0x2D
	private bool _isMetadataUpdating; //Field offset: 0x2E
	private bool _isUpdating; //Field offset: 0x2F
	private bool _isCommitting; //Field offset: 0x30
	private bool _isSynchronizing; //Field offset: 0x31

	public event EventHandler<CloudItemUpdatedArgs> itemUpdated
	{
		 add { } //Length: 119
		 remove { } //Length: 111
	}

	public bool isAccountMismatch
	{
		 get { } //Length: 628
	}

	public bool isIncompatible
	{
		 get { } //Length: 623
	}

	public bool isModified
	{
		 get { } //Length: 42
	}

	public bool isOutOfDate
	{
		 get { } //Length: 623
	}

	public bool isSynchronizing
	{
		 get { } //Length: 54
	}

	public string kilooTag
	{
		 get { } //Length: 107
	}

	public string sourceDescription
	{
		 get { } //Length: 9
		 set { } //Length: 111
	}

	public CloudWorkingCopy(int dataVersion, string rootDir, ICloudServer cloudServer, IFileSaver fileSaver, string installationId) { }

	private string <GetFiles>b__32_0(KeyValuePair<string, ItemMetadata> item) { }

	private ICloudItem <GetItems>b__29_1(<>f__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata> <>h__TransparentIdentifier0) { }

	private ICloudItem <PrepareCommitContext>b__72_1(KeyValuePair<string, ItemMetadata> entry) { }

	private ICloudItem <PrepareUpdateContext>b__67_2(<>f__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata> <>h__TransparentIdentifier0) { }

	public void Abort() { }

	public void Add(string file) { }

	public void add_itemUpdated(EventHandler<CloudItemUpdatedArgs> value) { }

	private bool ApplyUpdate(UpdateContext context) { }

	public void Clear() { }

	public bool Commit() { }

	private bool Commit(bool calledFromSynchronize) { }

	public Coroutine CommitAsync(CompleteHandler completeHandler = null) { }

	private IEnumerator CommitCoroutine(CompleteHandler completeHandler, bool calledFromSynchronize) { }

	public bool get_isAccountMismatch() { }

	public bool get_isIncompatible() { }

	public bool get_isModified() { }

	public bool get_isOutOfDate() { }

	public bool get_isSynchronizing() { }

	public string get_kilooTag() { }

	public string get_sourceDescription() { }

	public string GetFile(ICloudItem item) { }

	private string GetFilePathFromItemName(string name) { }

	public string[] GetFiles() { }

	public ICloudItem GetItem(string file) { }

	private ItemMetadata GetItemMetadata(string name) { }

	private string GetItemNameFromFilePath(string filePath) { }

	public ICloudItem[] GetItems() { }

	private LocalItem GetLocalItem(string name) { }

	private Stream GetLocalItemFileStream(LocalItem item) { }

	public bool IsFileAdded(string path) { }

	private void LoadWorkingCopy() { }

	private static void Log(string msg) { }

	private static void LogEach(IEnumerable<T> items, Action<T> logMethod) { }

	private static void LogError(string msg) { }

	private CommitContext PrepareCommitContext(string method, bool calledFromSynchronize) { }

	private UpdateContext PrepareUpdateContext(string method, CloudConflictResolver conflictResolver, bool calledFromSynchronize) { }

	private CommitContext PrepareUpdateMetadataContext(string method) { }

	private bool ProcessCommitResult(CommitContext context) { }

	private bool ProcessUpdateResult(UpdateContext context) { }

	private void RaiseItemUpdatedWithArgs(List<CloudItemUpdatedArgs> args) { }

	public void RefreshIsModified() { }

	public void remove_itemUpdated(EventHandler<CloudItemUpdatedArgs> value) { }

	private void SaveWorkingCopy() { }

	public void ScanForLocalModifications() { }

	public void set_sourceDescription(string value) { }

	public void SetUserData(string file, ICloudUserData userData) { }

	public void SetUserData(string file, Dictionary<string, string> userData) { }

	public void SetUserData(string file, string key, string value) { }

	public bool Synchronize(CloudConflictResolver conflictResolver, out bool updateSuccess, out bool commitSuccess) { }

	public Coroutine SynchronizeAsync(CloudConflictResolver conflictResolver, SynchronizeCompleteHandler completeHandler = null) { }

	private IEnumerator SynchronizeCoroutine(CloudConflictResolver conflictResolver, SynchronizeCompleteHandler completeHandler) { }

	private bool Update(CloudConflictResolver conflictResolver, bool calledFromSynchronize) { }

	public bool Update(CloudConflictResolver conflictResolver) { }

	public Coroutine UpdateAsync(CloudConflictResolver conflictResolver, CompleteHandler completeHandler = null) { }

	private IEnumerator UpdateCoroutine(CloudConflictResolver conflictResolver, CompleteHandler completeHandler, bool calledFromSynchronize) { }

	public bool UpdateMetadata() { }

	public Coroutine UpdateMetadataAsync(CompleteHandler completeHandler = null) { }

	private IEnumerator UpdateMetadataCoroutine(CompleteHandler completeHandler) { }

}

