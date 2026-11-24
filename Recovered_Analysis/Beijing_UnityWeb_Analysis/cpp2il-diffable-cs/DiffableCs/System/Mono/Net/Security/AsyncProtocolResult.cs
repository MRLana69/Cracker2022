namespace Mono.Net.Security;

internal class AsyncProtocolResult
{
	private readonly int <UserResult>k__BackingField; //Field offset: 0x8
	private readonly ExceptionDispatchInfo <Error>k__BackingField; //Field offset: 0xC

	public ExceptionDispatchInfo Error
	{
		 get { } //Length: 6
	}

	public int UserResult
	{
		 get { } //Length: 125
	}

	public AsyncProtocolResult(int result) { }

	public AsyncProtocolResult(ExceptionDispatchInfo error) { }

	public ExceptionDispatchInfo get_Error() { }

	public int get_UserResult() { }

}

