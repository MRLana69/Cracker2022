namespace Kiloo.Common.HTTP;

public enum RequestState
{
	None,
	Waiting,
	Reading,
	Done,
	Canceled,
	TimedOut,
	Error
}
