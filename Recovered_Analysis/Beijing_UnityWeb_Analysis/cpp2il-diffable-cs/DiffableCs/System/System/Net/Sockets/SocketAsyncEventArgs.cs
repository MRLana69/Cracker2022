namespace System.Net.Sockets;

public class SocketAsyncEventArgs : EventArgs
{
	private bool disposed; //Field offset: 0x8
	internal int in_progress; //Field offset: 0xC
	internal EndPoint remote_ep; //Field offset: 0x10
	internal Socket current_socket; //Field offset: 0x14
	private Socket <AcceptSocket>k__BackingField; //Field offset: 0x18
	private int <BytesTransferred>k__BackingField; //Field offset: 0x1C
	private SocketError <SocketError>k__BackingField; //Field offset: 0x20
	private EventHandler<SocketAsyncEventArgs> Completed; //Field offset: 0x24

	public Socket AcceptSocket
	{
		 get { } //Length: 2670
		 set { } //Length: 21
	}

	internal int BytesTransferred
	{
		 set { } //Length: 11
	}

	public SocketError SocketError
	{
		 set { } //Length: 8
	}

	internal void Complete() { }

	private void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public Socket get_AcceptSocket() { }

	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	public void set_AcceptSocket(Socket value) { }

	internal void set_BytesTransferred(int value) { }

	public void set_SocketError(SocketError value) { }

}

