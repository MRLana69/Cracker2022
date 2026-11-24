namespace Kiloo.Common.Backend;

public interface IEventRemoteLogger : IEventLogger
{

	public bool isSending
	{
		 get { } //Length: 0
	}

	public bool get_isSending() { }

	public void Send(float maximumSendTime, float requestTimeWindow) { }

	public Coroutine SendAsync(Action onComplete = null) { }

}

