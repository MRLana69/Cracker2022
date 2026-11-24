namespace SYBO.Common.Benchmarking;

public class InstantiatedObjectsMetric
{
	private int _instantiatedObjectsCount; //Field offset: 0xC
	private bool _reportObjectNames; //Field offset: 0x10
	private StringBuilder _instantiatedObjectsString; //Field offset: 0x14
	private List<string> _stringEntries; //Field offset: 0x18

	public InstantiatedObjectsMetric(bool reportObjectNames = false) { }

	public override void Cleanup() { }

	public override void Initialize(int initialSampleCount) { }

	private void PoolManager_OnObjectInstantiated(Transform transform) { }

	public override void Sample() { }

	public override List<string> Serialize() { }

	public override void Update(float unscaledDeltaTime) { }

}

