namespace SYBO.Subway.Level.Environments;

public class TransitionConfig
{
	private class WeightedTransitionPrefab
	{

		public WeightedTransitionPrefab() { }

	}

	private class WeightRandomizedTransitionPrefabContainer
	{
		public EnvironmentKind[] ExcludeEnvironments; //Field offset: 0x1C
		public float SpawnProbability; //Field offset: 0x20

		public WeightRandomizedTransitionPrefabContainer() { }

	}

	private EnvironmentKind _environmentKind; //Field offset: 0x8
	private WeightRandomizedTransitionPrefabContainer _transitionStart; //Field offset: 0xC
	private WeightRandomizedTransitionPrefabContainer _transitionEnd; //Field offset: 0x10

	public EnvironmentKind EnvironmentKind
	{
		 get { } //Length: 6
	}

	public TransitionConfig() { }

	public EnvironmentKind get_EnvironmentKind() { }

	public void Initialize() { }

	public bool TryGetEndPrefab(EnvironmentKind toEnvironment, SyboRandom random, out Transform prefab) { }

	public bool TryGetStartPrefab(EnvironmentKind fromEnvironment, SyboRandom random, out Transform prefab) { }

}

