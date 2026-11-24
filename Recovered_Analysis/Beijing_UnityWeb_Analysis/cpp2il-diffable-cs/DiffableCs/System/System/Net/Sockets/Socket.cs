namespace System.Net.Sockets;

public class Socket : IDisposable
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static IOAsyncCallback <>9__241_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__309_0(IAsyncResult ares) { }

		internal void <.cctor>b__309_1(IOAsyncResult ares) { }

		internal void <.cctor>b__309_10(IAsyncResult ares) { }

		internal void <.cctor>b__309_11(IOAsyncResult ares) { }

		internal void <.cctor>b__309_12(IAsyncResult ares) { }

		internal void <.cctor>b__309_13(IOAsyncResult ares) { }

		internal void <.cctor>b__309_14(IAsyncResult ares) { }

		internal void <.cctor>b__309_2(IOAsyncResult ares) { }

		internal void <.cctor>b__309_3(IAsyncResult ares) { }

		internal void <.cctor>b__309_4(IOAsyncResult ares) { }

		internal void <.cctor>b__309_5(IAsyncResult ares) { }

		internal void <.cctor>b__309_6(IOAsyncResult ares) { }

		internal void <.cctor>b__309_7(IAsyncResult ares) { }

		internal void <.cctor>b__309_8(IOAsyncResult ares) { }

		internal void <.cctor>b__309_9(IOAsyncResult ares) { }

		internal void <BeginSend>b__241_0(IOAsyncResult s) { }

	}

	private sealed class <>c__DisplayClass242_0
	{
		public int sent_so_far; //Field offset: 0x8

		public <>c__DisplayClass242_0() { }

		internal void <BeginSendCallback>b__0(IOAsyncResult s) { }

	}

	private sealed class <>c__DisplayClass298_0
	{
		public Socket <>4__this; //Field offset: 0x8
		public IOSelectorJob job; //Field offset: 0xC
		public nint handle; //Field offset: 0x10

		public <>c__DisplayClass298_0() { }

		internal void <QueueIOSelectorJob>b__0(Task t) { }

	}

	private struct WSABUF
	{
		public int len; //Field offset: 0x0
		public nint buf; //Field offset: 0x4

	}

	private static object s_InternalSyncObject; //Field offset: 0x0
	internal static bool s_SupportsIPv4; //Field offset: 0x4
	internal static bool s_SupportsIPv6; //Field offset: 0x5
	internal static bool s_OSSupportsIPv6; //Field offset: 0x6
	internal static bool s_Initialized; //Field offset: 0x7
	private static bool s_LoggingEnabled; //Field offset: 0x8
	private static AsyncCallback AcceptAsyncCallback; //Field offset: 0xC
	private static IOAsyncCallback BeginAcceptCallback; //Field offset: 0x10
	private static IOAsyncCallback BeginAcceptReceiveCallback; //Field offset: 0x14
	private static AsyncCallback ConnectAsyncCallback; //Field offset: 0x18
	private static IOAsyncCallback BeginConnectCallback; //Field offset: 0x1C
	private static AsyncCallback DisconnectAsyncCallback; //Field offset: 0x20
	private static IOAsyncCallback BeginDisconnectCallback; //Field offset: 0x24
	private static AsyncCallback ReceiveAsyncCallback; //Field offset: 0x28
	private static IOAsyncCallback BeginReceiveCallback; //Field offset: 0x2C
	private static IOAsyncCallback BeginReceiveGenericCallback; //Field offset: 0x30
	private static AsyncCallback ReceiveFromAsyncCallback; //Field offset: 0x34
	private static IOAsyncCallback BeginReceiveFromCallback; //Field offset: 0x38
	private static AsyncCallback SendAsyncCallback; //Field offset: 0x3C
	private static IOAsyncCallback BeginSendGenericCallback; //Field offset: 0x40
	private static AsyncCallback SendToAsyncCallback; //Field offset: 0x44
	private bool is_closed; //Field offset: 0x8
	private bool is_listening; //Field offset: 0x9
	private bool useOverlappedIO; //Field offset: 0xA
	private int linger_timeout; //Field offset: 0xC
	private AddressFamily addressFamily; //Field offset: 0x10
	private SocketType socketType; //Field offset: 0x14
	private ProtocolType protocolType; //Field offset: 0x18
	internal SafeSocketHandle m_Handle; //Field offset: 0x1C
	internal EndPoint seed_endpoint; //Field offset: 0x20
	internal SemaphoreSlim ReadSem; //Field offset: 0x24
	internal SemaphoreSlim WriteSem; //Field offset: 0x28
	internal bool is_blocking; //Field offset: 0x2C
	internal bool is_bound; //Field offset: 0x2D
	internal bool is_connected; //Field offset: 0x2E
	private int m_IntCleanedUp; //Field offset: 0x30
	internal bool connect_in_progress; //Field offset: 0x34

	public AddressFamily AddressFamily
	{
		 get { } //Length: 9
	}

	public bool Blocking
	{
		 get { } //Length: 9
		 set { } //Length: 127
	}

	internal bool CleanedUp
	{
		 get { } //Length: 23
	}

	public bool Connected
	{
		 get { } //Length: 9
	}

	public bool DontFragment
	{
		 set { } //Length: 116
	}

	public bool DualMode
	{
		 get { } //Length: 6
		 set { } //Length: 112
	}

	internal static int FamilyHint
	{
		 get { } //Length: 235
	}

	public nint Handle
	{
		 get { } //Length: 9
	}

	private static object InternalSyncObject
	{
		 get { } //Length: 94
	}

	private bool IsDualMode
	{
		 get { } //Length: 126
	}

	public bool NoDelay
	{
		 set { } //Length: 175
	}

	public static bool OSSupportsIPv4
	{
		 get { } //Length: 94
	}

	public static bool OSSupportsIPv6
	{
		 get { } //Length: 94
	}

	public ProtocolType ProtocolType
	{
		 get { } //Length: 6
	}

	public int ReceiveTimeout
	{
		 set { } //Length: 718
	}

	public SocketType SocketType
	{
		 get { } //Length: 6
	}

	public static bool SupportsIPv4
	{
		 get { } //Length: 41
	}

	public static bool SupportsIPv6
	{
		 get { } //Length: 94
	}

	private static Socket() { }

	internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	public Socket Accept() { }

	internal void Accept(Socket acceptSocket) { }

	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	private static nint Accept_internal(nint sock, out int error, bool blocking) { }

	private static void BeginMConnect(SocketAsyncResult sockares) { }

	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	private static void BeginSConnect(SocketAsyncResult sockares) { }

	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	internal static void Blocking_internal(nint socket, bool block, out int error) { }

	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	internal static void cancel_blocking_socket_operation(Thread thread) { }

	public void Close() { }

	public void Close(int timeout) { }

	internal static void Close_internal(nint socket, out int error) { }

	public void Connect(EndPoint remoteEP) { }

	public void Connect(IPAddress address, int port) { }

	private static void Connect_internal(nint sock, SocketAddress sa, out int error, bool blocking) { }

	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	public void Disconnect(bool reuseSocket) { }

	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	private static void Disconnect_internal(nint sock, bool reuse, out int error) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public Socket EndAccept(IAsyncResult asyncResult) { }

	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	public void EndConnect(IAsyncResult asyncResult) { }

	public void EndDisconnect(IAsyncResult asyncResult) { }

	public int EndReceive(IAsyncResult asyncResult) { }

	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	public int EndSend(IAsyncResult asyncResult) { }

	public int EndSendTo(IAsyncResult asyncResult) { }

	protected override void Finalize() { }

	public AddressFamily get_AddressFamily() { }

	public bool get_Blocking() { }

	internal bool get_CleanedUp() { }

	public bool get_Connected() { }

	public bool get_DualMode() { }

	internal static int get_FamilyHint() { }

	public nint get_Handle() { }

	private static object get_InternalSyncObject() { }

	private bool get_IsDualMode() { }

	public static bool get_OSSupportsIPv4() { }

	public static bool get_OSSupportsIPv6() { }

	public ProtocolType get_ProtocolType() { }

	public SocketType get_SocketType() { }

	public static bool get_SupportsIPv4() { }

	public static bool get_SupportsIPv6() { }

	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	private static void GetSocketOption_obj_internal(nint socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	internal static void InitializeSockets() { }

	internal void InternalShutdown(SocketShutdown how) { }

	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	private void Linger(nint handle) { }

	private static bool Poll_internal(nint socket, SelectMode mode, int timeout, out int error) { }

	private void QueueIOSelectorJob(SemaphoreSlim sem, nint handle, IOSelectorJob job) { }

	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	public int Receive(byte[] buffer, int size, SocketFlags socketFlags) { }

	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(nint sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(nint sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	private static int ReceiveFrom_internal(nint sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	public int Send(byte[] buffer, int size, SocketFlags socketFlags) { }

	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	private static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(nint sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(nint sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	public void set_Blocking(bool value) { }

	public void set_DontFragment(bool value) { }

	public void set_DualMode(bool value) { }

	public void set_NoDelay(bool value) { }

	public void set_ReceiveTimeout(int value) { }

	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	private static void SetSocketOption_internal(nint socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	internal static void Shutdown_internal(nint socket, SocketShutdown how, out int error) { }

	private nint Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	private void SocketDefaults() { }

	private void ThrowIfBufferNull(byte[] buffer) { }

	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	private void ThrowIfDisposedAndClosed() { }

	private void ThrowIfUdp() { }

	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

}

