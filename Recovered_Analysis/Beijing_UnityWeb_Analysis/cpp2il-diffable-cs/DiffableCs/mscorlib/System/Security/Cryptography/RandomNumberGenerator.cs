namespace System.Security.Cryptography;

public abstract class RandomNumberGenerator : IDisposable
{

	protected RandomNumberGenerator() { }

	public static RandomNumberGenerator Create() { }

	public static RandomNumberGenerator Create(string rngName) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public abstract void GetBytes(byte[] data) { }

	public virtual void GetBytes(byte[] data, int offset, int count) { }

	public virtual void GetNonZeroBytes(byte[] data) { }

}

