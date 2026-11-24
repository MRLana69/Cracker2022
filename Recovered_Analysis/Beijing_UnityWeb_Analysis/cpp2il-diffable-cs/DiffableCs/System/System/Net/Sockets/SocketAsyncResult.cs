namespace System.Net.Sockets;

internal sealed class SocketAsyncResult : IOAsyncResult
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static WaitCallback <>9__27_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Complete>b__27_0(object state) { }

	}

	public Socket socket; //Field offset: 0x18
	public SocketOperation operation; //Field offset: 0x1C
	private Exception DelayedException; //Field offset: 0x20
	public EndPoint EndPoint; //Field offset: 0x24
	public byte[] Buffer; //Field offset: 0x28
	public int Offset; //Field offset: 0x2C
	public int Size; //Field offset: 0x30
	public SocketFlags SockFlags; //Field offset: 0x34
	public Socket AcceptSocket; //Field offset: 0x38
	public IPAddress[] Addresses; //Field offset: 0x3C
	public int Port; //Field offset: 0x40
	public IList<ArraySegment<byte>> Buffers; //Field offset: 0x44
	public bool ReuseSocket; //Field offset: 0x48
	public int CurrentAddress; //Field offset: 0x4C
	public Socket AcceptedSocket; //Field offset: 0x50
	public int Total; //Field offset: 0x54
	internal int error; //Field offset: 0x58
	public int EndCalled; //Field offset: 0x5C

	public SocketError ErrorCode
	{
		 get { } //Length: 57
	}

	public nint Handle
	{
		 get { } //Length: 6
	}

	public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	public void CheckIfThrowDelayedException() { }

	public void Complete() { }

	public void Complete(bool synch) { }

	public void Complete(int total) { }

	public void Complete(Exception e, bool synch) { }

	public void Complete(Exception e) { }

	public void Complete(Socket s) { }

	public void Complete(Socket s, int total) { }

	internal override void CompleteDisposed() { }

	public SocketError get_ErrorCode() { }

	public nint get_Handle() { }

}

