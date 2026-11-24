namespace Kiloo.Plugins.Facebook;

public class FacebookSession : MonoBehaviour
{
	public delegate DialogCompleteHandler
	{

		public DialogCompleteHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(IDictionary<string, object> result, FacebookError error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(IDictionary<string, object> result, FacebookError error) { }

	}

	public delegate RequestCompleteHandler
	{

		public RequestCompleteHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(IDictionary<string, object> result, FacebookError error, bool isFromCache, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(IDictionary<string, object> result, FacebookError error, bool isFromCache) { }

	}

	public enum State
	{
		CREATED = 0,
		CREATED_TOKEN_LOADED = 1,
		OPENING = 2,
		OPENED = 3,
		OPENED_TOKEN_UPDATED = 4,
		CLOSED_LOGIN_FAILED = 5,
		CLOSED = 6,
	}

	public delegate StatusChangedHandler
	{

		public StatusChangedHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(State status, FacebookError error, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(State status, FacebookError error) { }

	}

	private static readonly IJsonSerializer _jsonConverter; //Field offset: 0x0
	private static FacebookSession _instance; //Field offset: 0x4
	private static StatusChangedHandler statusChangedEvent; //Field offset: 0x8
	private static string <appId>k__BackingField; //Field offset: 0xC
	private int _id; //Field offset: 0xC

	public static event StatusChangedHandler statusChangedEvent
	{
		 add { } //Length: 79
		 remove { } //Length: 209
	}

	public static string appId
	{
		 get { } //Length: 110
		 set { } //Length: 209
	}

	public static bool dialogsSupported
	{
		 get { } //Length: 73
	}

	public static FacebookSession instance
	{
		 get { } //Length: 3
	}

	public static bool isSupported
	{
		 get { } //Length: 89
	}

	private void _Cancel() { }

	private bool _CanShowNativeShareDialog() { }

	private void _Close(bool clearToken) { }

	private string _GetAccessToken() { }

	private string _GetAndroidKeyHash() { }

	private long _GetExpirationDate() { }

	private string _GetLoginType() { }

	private string _GetPermissions() { }

	private string _GetState() { }

	private bool _GraphRequest(string graphPath, IDictionary<string, object> paramsJSON, string httpMethod, int cookie) { }

	private bool _Init(string permissions, string defaultAudience) { }

	private static bool _IsSupported() { }

	private bool _OpenForRead() { }

	private bool _RequestNewPublishPermissions(string permissions, string defaultAudience) { }

	private bool _RequestNewReadPermissions(string permissions) { }

	private static void _SetLoggingLevel(FacebookLogLevel level) { }

	private bool _ShowDialog(string action, string paramsJSON, int cookie) { }

	private bool _ShowNativeShareDialog(string paramsJSON, int cookie) { }

	private bool _ShowNativeShareDialogWithOpenGraphAction(string paramsJSON, int cookie) { }

	private void _Test() { }

	private bool _UploadPhotoRequest(Texture2D image, string graphPath, string caption, int cookie) { }

	private bool _UploadPhotoRequest(string file, string graphPath, string caption, int cookie) { }

	private static FacebookSession() { }

	public FacebookSession() { }

	public static void add_statusChangedEvent(StatusChangedHandler value) { }

	public void Cancel() { }

	public bool CanShowNativeShareDialog() { }

	public void Close(bool clearToken) { }

	public static FacebookSession Create(string permissions, FacebookDefaultAudience defaultAudience) { }

	private void EnableInput(bool enable) { }

	public static string get_appId() { }

	public static bool get_dialogsSupported() { }

	public static FacebookSession get_instance() { }

	public static bool get_isSupported() { }

	public string GetAccessToken() { }

	public string GetAndroidKeyHash() { }

	public Nullable<DateTime> GetExpirationDateUTC() { }

	public FacebookLoginType GetLoginType() { }

	public string GetPermissions() { }

	public State GetState() { }

	public void GraphRequest(string graphPath, IDictionary<string, object> parameters, HttpMethod httpMethod, RequestCompleteHandler requestCompleteHandler) { }

	public static bool HasOpenInstance() { }

	public static bool IsClosed(State state) { }

	public static bool IsOpened(State state) { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	private static void LogWarning(string msg) { }

	private void OnFacebookSessionDialogComplete(string json) { }

	private void OnFacebookSessionRequestComplete(string json) { }

	private void OnFacebookSessionRequestCompleteWithObject(IDictionary<string, object> result, IDictionary<string, object> error, int cookie) { }

	private void OnFacebookSessionStateChanged(string json) { }

	private void OnFacebookSessionStateChangedWithObject(string state, IDictionary<string, object> error) { }

	public void OpenForRead() { }

	public static void remove_statusChangedEvent(StatusChangedHandler value) { }

	public void RequestNewPublishPermissions(string permissions, FacebookDefaultAudience defaultAudience) { }

	public void RequestNewReadPermissions(string permissions) { }

	public static void set_appId(string value) { }

	public static void SetLoggingLevel(FacebookLogLevel level) { }

	public void ShowDialog(string action, IDictionary<string, object> parameters, DialogCompleteHandler dialogCompleteHandler) { }

	public void ShowNativeShareDialog(IDictionary<string, object> parameters, DialogCompleteHandler dialogCompleteHandler) { }

	private void Start() { }

	public void Test() { }

	public void UploadPhotoRequest(string file, string graphPath, string caption, RequestCompleteHandler requestCompleteHandler) { }

	public void UploadPhotoRequest(Texture2D image, string graphPath, string caption, RequestCompleteHandler requestCompleteHandler) { }

}

