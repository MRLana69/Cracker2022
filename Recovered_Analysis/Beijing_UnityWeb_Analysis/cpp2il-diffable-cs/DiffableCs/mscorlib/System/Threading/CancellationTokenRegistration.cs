namespace System.Threading;

public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable
{
	private readonly CancellationCallbackInfo m_callbackInfo; //Field offset: 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; //Field offset: 0x4

	internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	public void Dispose() { }

	public override bool Equals(object obj) { }

	public bool Equals(CancellationTokenRegistration other) { }

	public override int GetHashCode() { }

	internal bool TryDeregister() { }

}

