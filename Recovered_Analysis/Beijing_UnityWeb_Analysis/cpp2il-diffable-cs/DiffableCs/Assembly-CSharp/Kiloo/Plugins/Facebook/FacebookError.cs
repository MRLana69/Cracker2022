namespace Kiloo.Plugins.Facebook;

public class FacebookError
{
	public enum Category
	{
		INVALID = 0,
		AUTHENTICATION_RETRY = 1,
		AUTHENTICATION_REOPEN_SESSION = 2,
		PERMISSION = 3,
		SERVER = 4,
		THROTTLING = 5,
		CANCELED = 6,
		OTHER = 7,
		BAD_REQUEST = 8,
		CLIENT = 9,
	}

	public const int INVALID_ERROR_CODE = -1; //Field offset: 0x0
	public const int INVALID_HTTP_STATUS_CODE = -1; //Field offset: 0x0
	public Category category; //Field offset: 0x8
	public int requestStatusCode; //Field offset: 0xC
	public int errorCode; //Field offset: 0x10
	public int subErrorCode; //Field offset: 0x14
	public string errorType; //Field offset: 0x18
	public string errorMessage; //Field offset: 0x1C
	public bool shouldNotifyUser; //Field offset: 0x20
	public string userActionMessage; //Field offset: 0x24
	public string exceptionType; //Field offset: 0x28
	public string exceptionMessage; //Field offset: 0x2C

	public FacebookError() { }

	public FacebookError(IDictionary<string, object> error) { }

	public override string ToString() { }

}

