namespace UnityEngine.Experimental.LowLevel;

internal struct PlayerLoopSystemInternal
{
	public Type type; //Field offset: 0x0
	public UpdateFunction updateDelegate; //Field offset: 0x4
	public nint updateFunction; //Field offset: 0x8
	public nint loopConditionFunction; //Field offset: 0xC
	public int numSubSystems; //Field offset: 0x10

}

