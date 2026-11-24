namespace UnityEngine.Experimental.GlobalIllumination;

public static class Lightmapping
{
	public delegate RequestLightsDelegate
	{

		public RequestLightsDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Light[] requests, NativeArray<LightDataGI> lightsOutput, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	}

	private static readonly RequestLightsDelegate s_DefaultDelegate; //Field offset: 0x0
	private static RequestLightsDelegate s_RequestLightsDelegate; //Field offset: 0x4

	private static Lightmapping() { }

	private static void <s_DefaultDelegate>m__0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	public static RequestLightsDelegate GetDelegate() { }

	internal static void RequestLights(Light[] lights, nint outLightsPtr, int outLightsCount) { }

	public static void ResetDelegate() { }

	public static void SetDelegate(RequestLightsDelegate del) { }

}

