namespace Mono;

internal struct RuntimeRemoteClassHandle
{
	private RemoteClass* value; //Field offset: 0x0

	internal RuntimeClassHandle ProxyClass
	{
		 get { } //Length: 12
	}

	internal RuntimeClassHandle get_ProxyClass() { }

}

