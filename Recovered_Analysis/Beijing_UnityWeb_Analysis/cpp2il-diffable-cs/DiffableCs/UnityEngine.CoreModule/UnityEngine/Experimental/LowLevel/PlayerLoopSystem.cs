namespace UnityEngine.Experimental.LowLevel;

public struct PlayerLoopSystem
{
	public delegate UpdateFunction
	{

		public UpdateFunction(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public Type type; //Field offset: 0x0
	public PlayerLoopSystem[] subSystemList; //Field offset: 0x4
	public UpdateFunction updateDelegate; //Field offset: 0x8
	public nint updateFunction; //Field offset: 0xC
	public nint loopConditionFunction; //Field offset: 0x10

}

