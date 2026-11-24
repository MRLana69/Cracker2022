namespace SYBO.Components.Analytics;

public class PersistentAnalyticsEventLog
{
	public const string LogFilePrefix = "Sybo_Analytics"; //Field offset: 0x0
	private const int DefaultQueueSize = 16; //Field offset: 0x0
	private const byte LogBegin = 91; //Field offset: 0x0
	private const byte LogSeperator = 44; //Field offset: 0x0
	private const byte LogEnd = 93; //Field offset: 0x0
	private const string WriteFilename = "Sybo_Analytics_Buffer.log"; //Field offset: 0x0
	private const string ChunkFilenameFormat = "Sybo_Analytics_Chunk_{0}.log"; //Field offset: 0x0
	private string _writeFilePath; //Field offset: 0x8
	private string _chunkPathFormat; //Field offset: 0xC
	private int _chunkSizeThresholdBytes; //Field offset: 0x10
	private int _maxChunkCount; //Field offset: 0x14
	private long _storageLimitBytes; //Field offset: 0x18
	private MD5 _md5; //Field offset: 0x20
	private Queue<byte[]> _events; //Field offset: 0x24
	private EncryptedCTRStream _writeStream; //Field offset: 0x28
	private AutoResetEvent _workerThreadEvent; //Field offset: 0x2C
	private int _chunkCount; //Field offset: 0x30
	private bool _full; //Field offset: 0x34
	private Thread _workerThread; //Field offset: 0x38
	private bool _workerThreadRunning; //Field offset: 0x3C
	private bool _consumeChunk; //Field offset: 0x3D
	private bool _isWorking; //Field offset: 0x3E
	private AsyncRes _getChunkAsyncRes; //Field offset: 0x40
	private long _chunkSizes; //Field offset: 0x48
	private bool <HasData>k__BackingField; //Field offset: 0x50

	public bool HasData
	{
		 get { } //Length: 6
		private set { } //Length: 351
	}

	private bool HasWorkerThread
	{
		 get { } //Length: 81
	}

	public bool IsWorking
	{
		 get { } //Length: 9
	}

	public string LogWriteFilePath
	{
		 get { } //Length: 43
	}

	public PersistentAnalyticsEventLog(string storagePath, int chunkSizeThresholdKB, int storageLimitKB) { }

	public void Append(string eventData) { }

	private void CloseWriteStream() { }

	public void ConsumeChunk() { }

	public bool get_HasData() { }

	private bool get_HasWorkerThread() { }

	public bool get_IsWorking() { }

	public string get_LogWriteFilePath() { }

	private string GetChunkFilename(int chunkIdx) { }

	private Stream GetChunkReader() { }

	public string GetMD5Hash(byte[] data) { }

	public AsyncRes GetNextChunkForServerAsync() { }

	private bool GetWriteStream(bool openForAppend) { }

	private byte[] ReadChunk() { }

	public void Replace(string current, string replacement) { }

	private void set_HasData(bool value) { }

	public void Shutdown() { }

	private void StartWorkerThreadIfNeeded() { }

	private void UpdateChunkSizes() { }

	private void WakeWorkerThread() { }

	public void Wipe() { }

	private void WorkerThreadLoop(object ignored) { }

}

