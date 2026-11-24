namespace UnityEngine;

public sealed class ReflectionProbe : Behaviour
{
	public enum ReflectionProbeEvent
	{
		ReflectionProbeAdded = 0,
		ReflectionProbeRemoved = 1,
	}

	private static Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged; //Field offset: 0x0
	private static Action<Cubemap> defaultReflectionSet; //Field offset: 0x4

	public bool boxProjection
	{
		 set { } //Length: 53
	}

	public Texture customBakedTexture
	{
		 set { } //Length: 53
	}

	public ReflectionProbeMode mode
	{
		 set { } //Length: 53
	}

	public int resolution
	{
		 set { } //Length: 10
	}

	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	public void set_boxProjection(bool value) { }

	public void set_customBakedTexture(Texture value) { }

	public void set_mode(ReflectionProbeMode value) { }

	public void set_resolution(int value) { }

}

