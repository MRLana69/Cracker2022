namespace Kiloo.Common.HTTP;

public static class HTTPStatus
{
	public const int CONTINUE = 100; //Field offset: 0x0
	public const int NOT_ACCEPTABLE = 406; //Field offset: 0x0
	public const int PROXY_AUTHENTICATION_REQUIRED = 407; //Field offset: 0x0
	public const int REQUEST_TIMEOUT = 408; //Field offset: 0x0
	public const int CONFLICT = 409; //Field offset: 0x0
	public const int GONE = 410; //Field offset: 0x0
	public const int LENGTH_REQUIRED = 411; //Field offset: 0x0
	public const int PRECONDITION_FAILED = 412; //Field offset: 0x0
	public const int METHOD_NOT_ALLOWED = 405; //Field offset: 0x0
	public const int REQUEST_ENTITY_TOO_LARGE = 413; //Field offset: 0x0
	public const int UNSUPPORTED_MEDIA_TYPE = 415; //Field offset: 0x0
	public const int REQUESTED_RANGE_NOT_SATISFIABLE = 416; //Field offset: 0x0
	public const int EXPECTATION_FAILED = 417; //Field offset: 0x0
	public const int INTERNAL_SERVER_ERROR = 500; //Field offset: 0x0
	public const int NOT_IMPLEMENTED = 501; //Field offset: 0x0
	public const int BAD_GATEWAY = 502; //Field offset: 0x0
	public const int SERVICE_UNAVAILABLE = 503; //Field offset: 0x0
	public const int REQUEST_URI_TOO_LONG = 414; //Field offset: 0x0
	public const int NOT_FOUND = 404; //Field offset: 0x0
	public const int FORBIDDEN = 403; //Field offset: 0x0
	public const int PAYMENT_REQUIRED = 402; //Field offset: 0x0
	public const int SWITCHING_PROTOCOLS = 101; //Field offset: 0x0
	public const int OK = 200; //Field offset: 0x0
	public const int CREATED = 201; //Field offset: 0x0
	public const int ACCEPTED = 202; //Field offset: 0x0
	public const int NON_AUTHORITATIVE_INFORMATION = 203; //Field offset: 0x0
	public const int NO_CONTENT = 204; //Field offset: 0x0
	public const int RESET_CONTENT = 205; //Field offset: 0x0
	public const int PARTIAL_CONTENT = 206; //Field offset: 0x0
	public const int MULTIPLE_CHOICES = 300; //Field offset: 0x0
	public const int MOVED_PERMANENTLY = 301; //Field offset: 0x0
	public const int FOUND = 302; //Field offset: 0x0
	public const int SEE_OTHER = 303; //Field offset: 0x0
	public const int NOT_MODIFIED = 304; //Field offset: 0x0
	public const int USE_PROXY = 305; //Field offset: 0x0
	public const int TEMPORARY_REDIRECT = 307; //Field offset: 0x0
	public const int BAD_REQUEST = 400; //Field offset: 0x0
	public const int UNAUTHORIZED = 401; //Field offset: 0x0
	public const int GATEWAY_TIMEOUT = 504; //Field offset: 0x0
	public const int HTTP_VERSION_NOT_SUPPORTED = 505; //Field offset: 0x0

	public static string ToString(int status) { }

}

