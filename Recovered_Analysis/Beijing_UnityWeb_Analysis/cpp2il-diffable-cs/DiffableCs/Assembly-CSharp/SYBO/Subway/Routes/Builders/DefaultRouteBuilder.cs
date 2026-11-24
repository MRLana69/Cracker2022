namespace SYBO.Subway.Routes.Builders;

public class DefaultRouteBuilder : RouteBuilder
{
	private sealed class <>c__DisplayClass14_0
	{
		public RouteChunk spawnedChunk; //Field offset: 0x8
		public DefaultRouteBuilder <>4__this; //Field offset: 0xC

		public <>c__DisplayClass14_0() { }

		internal bool <EvalNextChunkDesiredEnvironment>b__1(EnvironmentKindRepeatConfig ec) { }

	}

	private sealed class <>c__DisplayClass14_1
	{
		public RouteConstraint constraint; //Field offset: 0x8

		public <>c__DisplayClass14_1() { }

		internal bool <EvalNextChunkDesiredEnvironment>b__0(EnvironmentKindRepeatConfig envRepeatConfig) { }

	}

	private sealed class <>c__DisplayClass14_2
	{
		public bool oneEnvironmentAllowed; //Field offset: 0x8
		public <>c__DisplayClass14_0 CS$<>8__locals1; //Field offset: 0xC

		public <>c__DisplayClass14_2() { }

		internal bool <EvalNextChunkDesiredEnvironment>b__2(EnvironmentKindRepeatConfig envRepeatConfig) { }

	}

	private sealed class <>c__DisplayClass19_0
	{
		public RouteSection section; //Field offset: 0x8

		public <>c__DisplayClass19_0() { }

		internal bool <CanSpawnSection>b__0(EnvironmentKind ae) { }

	}

	private sealed class <>c__DisplayClass19_1
	{
		public RouteConstraint constraint; //Field offset: 0x8

		public <>c__DisplayClass19_1() { }

		internal bool <CanSpawnSection>b__1(EnvironmentKind le) { }

	}

	public static readonly int ChunkLengthForcingEnvironmentSwitch; //Field offset: 0x0
	private RouteSection _tutorialSection; //Field offset: 0xE8
	private EnvironmentKindRepeatConfig[] _environmentRepeatSettings; //Field offset: 0xEC
	private SemiRandomlyOrderedList<EnvironmentKindRepeatConfig> _randomizedEnvironmentRepeatConfigs; //Field offset: 0xF0
	private RouteSection _jetpackEndSection; //Field offset: 0xF4
	private EnvironmentKindRepeatConfig _currentEnvironmentRepeatConfig; //Field offset: 0xF8
	private int _desiredEnvironmentChangeDistance; //Field offset: 0xFC

	public RouteSection JetpackEndSection
	{
		 get { } //Length: 7
	}

	public RouteSection TutorialSection
	{
		 get { } //Length: 7
	}

	private static DefaultRouteBuilder() { }

	public DefaultRouteBuilder() { }

	protected override bool CanSpawnSection(RouteSection section) { }

	public override void ConnectBuilder(RouteBuilder builderToConnect) { }

	private void ConstrainingRouteBuilder_OnCompletedLayingSections(object sender, EventArgs args) { }

	private void ConstrainingRouteBuilder_OnReachedLengthVisibleFromEntry(object sender, EventArgs args) { }

	public override void Destruct() { }

	public override void DisconnectBuilder(RouteBuilder builderToDisconnect) { }

	public void EnqueueJetpackEndSection(int gamePositionZ) { }

	protected override EnvironmentKind EvalNextChunkDesiredEnvironment(RouteChunk spawnedChunk) { }

	public RouteSection get_JetpackEndSection() { }

	public RouteSection get_TutorialSection() { }

	protected override RouteSection GetTransitionSectionPrefab(List<TransitionSectionInfo> transitionSections, RouteType transitionRouteType) { }

	public override void Initialize(RouteManager routeManager, Route route, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator) { }

	public override void Validate(Route route) { }

	public override bool WillChangeEnvironment(int addedDistance) { }

}

