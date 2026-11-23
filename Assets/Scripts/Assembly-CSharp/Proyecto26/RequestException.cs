using System;

namespace Proyecto26;

public class RequestException : Exception
{
	private bool _isHttpError;

	private bool _isNetworkError;

	private long _statusCode;

	private string _serverMessage;

	private string _response;

	public bool IsHttpError
	{
		get
		{
			return _isHttpError;
		}
		private set
		{
			_isHttpError = value;
		}
	}

	public bool IsNetworkError
	{
		get
		{
			return _isNetworkError;
		}
		private set
		{
			_isNetworkError = value;
		}
	}

	public long StatusCode
	{
		get
		{
			return _statusCode;
		}
		private set
		{
			_statusCode = value;
		}
	}

	public string ServerMessage
	{
		get
		{
			return _serverMessage;
		}
		set
		{
			_serverMessage = value;
		}
	}

	public string Response
	{
		get
		{
			return _response;
		}
		set
		{
			_response = value;
		}
	}

	public RequestException()
	{
	}

	public RequestException(string message)
		: base(message)
	{
	}

	public RequestException(string format, object[] args)
		: base(string.Format(format, args))
	{
	}

	public RequestException(string message, bool isHttpError, bool isNetworkError, long statusCode, string response)
		: base(message)
	{
		_response = response;
		_statusCode = statusCode;
		_isNetworkError = isNetworkError;
		_isHttpError = isHttpError;
	}
}
