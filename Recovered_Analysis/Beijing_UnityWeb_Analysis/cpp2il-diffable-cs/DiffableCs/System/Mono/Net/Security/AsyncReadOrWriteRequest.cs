namespace Mono.Net.Security;

internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest
{
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; //Field offset: 0x24
	private int <CurrentSize>k__BackingField; //Field offset: 0x28

	protected int CurrentSize
	{
		 get { } //Length: 6
		 set { } //Length: 14
	}

	protected BufferOffsetSize UserBuffer
	{
		 get { } //Length: 61
	}

	public AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	protected int get_CurrentSize() { }

	protected BufferOffsetSize get_UserBuffer() { }

	protected void set_CurrentSize(int value) { }

	public override string ToString() { }

}

