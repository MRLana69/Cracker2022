namespace Kiloo.Common.HTTP;

public static class HTTPStatus
{
	public const int CONTINUE = 100;

	public const int SWITCHING_PROTOCOLS = 101;

	public const int OK = 200;

	public const int CREATED = 201;

	public const int ACCEPTED = 202;

	public const int NON_AUTHORITATIVE_INFORMATION = 203;

	public const int NO_CONTENT = 204;

	public const int RESET_CONTENT = 205;

	public const int PARTIAL_CONTENT = 206;

	public const int MULTIPLE_CHOICES = 300;

	public const int MOVED_PERMANENTLY = 301;

	public const int FOUND = 302;

	public const int SEE_OTHER = 303;

	public const int NOT_MODIFIED = 304;

	public const int USE_PROXY = 305;

	public const int TEMPORARY_REDIRECT = 307;

	public const int BAD_REQUEST = 400;

	public const int UNAUTHORIZED = 401;

	public const int PAYMENT_REQUIRED = 402;

	public const int FORBIDDEN = 403;

	public const int NOT_FOUND = 404;

	public const int METHOD_NOT_ALLOWED = 405;

	public const int NOT_ACCEPTABLE = 406;

	public const int PROXY_AUTHENTICATION_REQUIRED = 407;

	public const int REQUEST_TIMEOUT = 408;

	public const int CONFLICT = 409;

	public const int GONE = 410;

	public const int LENGTH_REQUIRED = 411;

	public const int PRECONDITION_FAILED = 412;

	public const int REQUEST_ENTITY_TOO_LARGE = 413;

	public const int REQUEST_URI_TOO_LONG = 414;

	public const int UNSUPPORTED_MEDIA_TYPE = 415;

	public const int REQUESTED_RANGE_NOT_SATISFIABLE = 416;

	public const int EXPECTATION_FAILED = 417;

	public const int INTERNAL_SERVER_ERROR = 500;

	public const int NOT_IMPLEMENTED = 501;

	public const int BAD_GATEWAY = 502;

	public const int SERVICE_UNAVAILABLE = 503;

	public const int GATEWAY_TIMEOUT = 504;

	public const int HTTP_VERSION_NOT_SUPPORTED = 505;

	public unsafe static string ToString(int status)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected I4, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		if (status <= 206)
		{
			object obj3 = status - 100;
			if (status == 100)
			{
				return "Continue";
			}
			if ((nint)obj3 == 1)
			{
				return "Switching Protocols";
			}
			object obj4 = status - 200;
			if (status == 200)
			{
				return "OK";
			}
			if ((nint)obj4 == 1)
			{
				return "Created";
			}
			if ((nint)obj4 == 2)
			{
				return "Accepted";
			}
			if ((nint)obj4 == 3)
			{
				return "Non-Authoritative Information";
			}
			if ((nint)obj4 == 4)
			{
				return "No Content";
			}
			if ((nint)obj4 == 5)
			{
				return "Reset Content";
			}
			if ((nint)obj4 == 6)
			{
				return "Partial Content";
			}
		}
		else
		{
			object obj5 = status - 300;
			if (status == 300)
			{
				return "Multiple Choices";
			}
			if ((nint)obj5 == 1)
			{
				return "Moved Permanently";
			}
			if ((nint)obj5 == 2)
			{
				return "Found";
			}
			if ((nint)obj5 == 3)
			{
				return "See Other";
			}
			if ((nint)obj5 == 4)
			{
				return "Not Modified";
			}
			if ((nint)obj5 == 5)
			{
				return "Use Proxy";
			}
			if ((nint)obj5 != 6)
			{
				if ((nint)obj5 == 7)
				{
					return "Temporary Redirect";
				}
				object obj6 = status - 400;
				if (status == 400)
				{
					return "Bad Request";
				}
				if ((nint)obj6 == 1)
				{
					return "Unauthorized";
				}
				if ((nint)obj6 == 2)
				{
					return "Payment Required";
				}
				if ((nint)obj6 == 3)
				{
					return "Forbidden";
				}
				if ((nint)obj6 == 4)
				{
					return "Not Found";
				}
				if ((nint)obj6 == 5)
				{
					return "Method Not Allowed";
				}
				if ((nint)obj6 == 6)
				{
					return "Not Acceptable";
				}
				if ((nint)obj6 == 7)
				{
					return "Proxy Authentication Required";
				}
				if ((nint)obj6 == 8)
				{
					return "Request Time-out";
				}
				if ((nint)obj6 == 9)
				{
					return "Conflict";
				}
				if ((nint)obj6 == 10)
				{
					return "Gone";
				}
				if ((nint)obj6 == 11)
				{
					return "Length Required";
				}
				if ((nint)obj6 == 12)
				{
					return "Precondition Failed";
				}
				if ((nint)obj6 == 13)
				{
					return "Request Entity Too Large";
				}
				if ((nint)obj6 == 14)
				{
					return "Request-URI Too Long";
				}
				if ((nint)obj6 == 15)
				{
					return "Unsupported Media Type";
				}
				if ((nint)obj6 == 16)
				{
					return "Requested range not satisfiable";
				}
				if ((nint)obj6 == 17)
				{
					return "Expectation Failed";
				}
				object obj7 = status - 500;
				if (status == 500)
				{
					return "Internal Server Error";
				}
				if ((nint)obj7 == 1)
				{
					return "Not Implemented";
				}
				if ((nint)obj7 == 2)
				{
					return "Bad Gateway";
				}
				if ((nint)obj7 == 3)
				{
					return "Service Unavailable";
				}
				if ((nint)obj7 == 4)
				{
					return "Gateway Time-out";
				}
				if ((nint)obj7 == 5)
				{
					return "HTTP Version not supported";
				}
			}
		}
		int num = obj + 12;
		string text = ((int*)num)->ToString();
		return "Unknown " + text;
	}
}
