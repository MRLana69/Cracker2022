namespace Kiloo.Common.Backend;

public sealed class OnlineSettings`1
{
	private class Data
	{
		public T data; //Field offset: 0x0
		public DateTime expires; //Field offset: 0x0
		public byte[] hash; //Field offset: 0x0

		public Data() { }

	}

	private const string API_GET_SETTINGS = "api/v2/settings"; //Field offset: 0x0
	private const string ONLINESETTINGS_EXPIRES = "onlinesettings_expires"; //Field offset: 0x0
	private const string ONLINESETTINGS_HASH = "onlinesettings_hash"; //Field offset: 0x0
	private Action downloaded; //Field offset: 0x0
	private bool <isDownloading>k__BackingField; //Field offset: 0x0
	private Data<T> _data; //Field offset: 0x0
	private readonly Uri _baseUri; //Field offset: 0x0
	private readonly string _file; //Field offset: 0x0
	private readonly IJsonSerializer _jsonSerializer; //Field offset: 0x0
	private readonly IDictionary<string, string> _parameters; //Field offset: 0x0

	public event Action downloaded
	{
		 add { } //Length: 11
		 remove { } //Length: 111
	}

	public T data
	{
		 get { } //Length: 9
	}

	public bool isDownloading
	{
		 get { } //Length: 70
		private set { } //Length: 38
	}

	public IDictionary<string, string> parameters
	{
		 get { } //Length: 9
	}

	public OnlineSettings`1(Uri baseUri, string file, IJsonSerializer jsonSerializer) { }

	private void <Download>b__13_0(IRequest request, bool fromCache) { }

	public void add_downloaded(Action value) { }

	public Coroutine Download() { }

	public Coroutine DownloadIfExpired() { }

	public T get_data() { }

	public bool get_isDownloading() { }

	public IDictionary<string, string> get_parameters() { }

	private Data<T> Load() { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	public void remove_downloaded(Action value) { }

	private void set_isDownloading(bool value) { }

}

