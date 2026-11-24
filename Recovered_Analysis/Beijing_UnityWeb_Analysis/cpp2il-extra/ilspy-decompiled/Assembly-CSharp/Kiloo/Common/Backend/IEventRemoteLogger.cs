using System;
using UnityEngine;

namespace Kiloo.Common.Backend;

public interface IEventRemoteLogger : IEventLogger
{
	bool isSending { get; }

	void Send(float maximumSendTime, float requestTimeWindow);

	Coroutine SendAsync(Action onComplete = null);
}
