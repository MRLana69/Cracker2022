namespace Kiloo.Common.Backend;

public class KilooBackendException : Exception
{
	private Error <backendError>k__BackingField; //Field offset: 0x44

	public Error backendError
	{
		 get { } //Length: 377
		private set { } //Length: 93
	}

	public KilooBackendException(string message) { }

	public KilooBackendException(Error error) { }

	public Error get_backendError() { }

	private void set_backendError(Error value) { }

}

