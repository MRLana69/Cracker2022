namespace Kiloo.Common.HTTP;

public class HTTPBackOffException : HTTPException
{

	public HTTPBackOffException(string message) { }

	public HTTPBackOffException(string message, Exception innerException) { }

}

