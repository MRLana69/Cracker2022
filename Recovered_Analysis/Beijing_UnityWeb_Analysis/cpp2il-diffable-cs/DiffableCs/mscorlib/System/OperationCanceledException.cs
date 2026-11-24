namespace System;

public class OperationCanceledException : SystemException
{
	private CancellationToken _cancellationToken; //Field offset: 0x44

	public CancellationToken CancellationToken
	{
		 get { } //Length: 6
		private set { } //Length: 18
	}

	public OperationCanceledException() { }

	public OperationCanceledException(string message) { }

	public OperationCanceledException(string message, CancellationToken token) { }

	protected OperationCanceledException(SerializationInfo info, StreamingContext context) { }

	public CancellationToken get_CancellationToken() { }

	private void set_CancellationToken(CancellationToken value) { }

}

