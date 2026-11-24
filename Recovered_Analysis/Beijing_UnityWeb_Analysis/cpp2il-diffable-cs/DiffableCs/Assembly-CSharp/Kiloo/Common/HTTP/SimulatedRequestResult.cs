namespace Kiloo.Common.HTTP;

public class SimulatedRequestResult
{
	public float chance; //Field offset: 0x8
	public float latency; //Field offset: 0xC
	public RequestState state; //Field offset: 0x10
	public Exception exception; //Field offset: 0x14
	public IResponse response; //Field offset: 0x18

	public SimulatedRequestResult() { }

}

