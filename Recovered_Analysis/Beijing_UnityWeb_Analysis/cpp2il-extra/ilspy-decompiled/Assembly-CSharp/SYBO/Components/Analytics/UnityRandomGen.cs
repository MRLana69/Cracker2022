namespace SYBO.Components.Analytics;

public class UnityRandomGen : IRandomGen
{
	public uint NextUint()
	{
		float num = ((SyboRandom)this).Value();
		return (num > 0.5f) ? 1u : 0u;
	}

	public float NextFloat()
	{
		return ((SyboRandom)this).Value();
	}

	public UnityRandomGen()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		string text = MTRandomGenTest.TestIncrement();
		obj = text;
	}
}
