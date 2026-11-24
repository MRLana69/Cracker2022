namespace SYBO.Subway.Routes.Builders;

public abstract class RouteBuilder
{
	private sealed class <>c__DisplayClass159_0
	{
		public int startPositionZ; //Field offset: 0x8

		public <>c__DisplayClass159_0() { }

		internal bool <GetBuilderConstrainingStartAt>b__0(IConstrainingRouteBuilder cb) { }

	}

	private sealed class <>c__DisplayClass169_0
	{
		public RouteType routeType; //Field offset: 0x8

		public <>c__DisplayClass169_0() { }

		internal bool <AddTransitionSectionTo>b__0(TransitionSectionInfo s) { }

	}

	private sealed class <DespawnRouteChunkASync>d__176 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RouteChunk chunk; //Field offset: 0x10
		public RouteBuilder <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 293
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DespawnRouteChunkASync>d__176(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <PerformSelectionAndActivationASync>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RouteBuilder <>4__this; //Field offset: 0x10
		public RouteChunk chunk; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 123
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PerformSelectionAndActivationASync>d__145(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <PerformSelectionASync>d__182 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RouteBuilder <>4__this; //Field offset: 0x10
		public RouteChunk chunk; //Field offset: 0x14
		private List<Selector> <spawnPoints>5__2; //Field offset: 0x18
		private List<GameObject> <objectsToVisit>5__3; //Field offset: 0x1C
		private Enumerator<Selector> <>7__wrap3; //Field offset: 0x20
		private Enumerator<GameObject> <>7__wrap4; //Field offset: 0x30

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1520
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PerformSelectionASync>d__182(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RecursiveSelectionASync>d__183 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public List<GameObject> objectsToVisit; //Field offset: 0x10
		public List<Selector> selectors; //Field offset: 0x14
		public RouteBuilder <>4__this; //Field offset: 0x18
		public List<Selector> spawnPoints; //Field offset: 0x1C
		private Enumerator<Selector> <>7__wrap1; //Field offset: 0x20
		private List<Selector> <subSelectors>5__3; //Field offset: 0x30
		private Enumerator<GameObject> <>7__wrap3; //Field offset: 0x34

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1580
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RecursiveSelectionASync>d__183(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private struct BuildDirective
	{
		public readonly int GamePositionZ; //Field offset: 0x0
		public readonly bool IsApplicablePositionStrict; //Field offset: 0x4
		public readonly RouteSection Section; //Field offset: 0x8
		public readonly SectionSpawnMode SectionSpawnMode; //Field offset: 0xC
		public readonly ChunkBuildMode ChunkBuildMode; //Field offset: 0x10

		public bool HasSection
		{
			 get { } //Length: 6
		}

		public BuildDirective(int gamePositionZ, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, bool isApplicablePositionStrict = true, RouteSection section = null) { }

		public bool get_HasSection() { }

		public override string ToString() { }

	}

	public class EnvironmentKindRepeatConfig
	{
		public EnvironmentKind EnvironmentKind; //Field offset: 0x8
		public int RepeatDistance; //Field offset: 0xC

		public EnvironmentKindRepeatConfig() { }

		public void Validate() { }

	}

	private class EnvironmentRangeWrapper
	{
		public EnvironmentKind EnvironmentKind; //Field offset: 0x8
		public float StartGamePositionZ; //Field offset: 0xC
		public float EndGamePositionZ; //Field offset: 0x10

		public EnvironmentRangeWrapper(EnvironmentKind kind, float startGamePositionZ, float endGamePositionZ) { }

	}

	public class TransitionSectionInfo
	{
		public RouteType TransitionRouteType; //Field offset: 0x8
		public RouteSection Section; //Field offset: 0xC

		public TransitionSectionInfo() { }

	}

	private const int RouteChunksToBuildForEntry = 1; //Field offset: 0x0
	public const int CameraToBackgroundGameDistance = 1000; //Field offset: 0x0
	public const int DistanceToChunksSpawned = 2000; //Field offset: 0x0
	public const int DistanceToChunksBuildStart = 1200; //Field offset: 0x0
	public const int DistanceToChunksReady = 1100; //Field offset: 0x0
	public const int DistanceStartCleanupAfterCharacter = 170; //Field offset: 0x0
	public const int DistanceDoneCleanupAfterCharacter = 2000; //Field offset: 0x0
	public static Action<Route, RouteSection, float> OnGlobalAddedSection; //Field offset: 0x0
	private EventHandler OnCompletedLayingSections; //Field offset: 0x8
	public Action<Route, RouteSection, float> OnAddedSection; //Field offset: 0xC
	public Action<Route, RouteChunk, float> OnRouteChunkSpawned; //Field offset: 0x10
	internal RouteHeight _routeHeight; //Field offset: 0x14
	private bool _midSectionsCountLimited; //Field offset: 0x18
	private int _midSectionsCountTarget; //Field offset: 0x1C
	protected List<TransitionSectionInfo> _startSectionPrefabs; //Field offset: 0x20
	protected WeightRandomizedRouteSectionContainter _midSectionPrefabs; //Field offset: 0x24
	private List<RouteSectionGroup> _midSectionGroupPrefabs; //Field offset: 0x28
	protected List<TransitionSectionInfo> _endSectionPrefabs; //Field offset: 0x2C
	private int _minDistanceBetweenSectionRepeats; //Field offset: 0x30
	internal RouteSection _fallbackSection; //Field offset: 0x34
	protected int _length; //Field offset: 0x38
	protected SectionSpawnMode _secionSpawnMode; //Field offset: 0x3C
	protected ChunkBuildMode _chunkBuildMode; //Field offset: 0x40
	protected Route _route; //Field offset: 0x44
	protected Bounds _bounds; //Field offset: 0x48
	private List<RouteBuilder> _buildersAbove; //Field offset: 0x60
	private List<RouteBuilder> _buildersBelow; //Field offset: 0x64
	private RouteBuilder _builderForward; //Field offset: 0x68
	private List<RouteBuilder> _buildersOnSides; //Field offset: 0x6C
	private PickupSpawnPoint _buildLimitingSpawnPoint; //Field offset: 0x70
	private List<RouteChunk> _chunks; //Field offset: 0x74
	private int _chunksBuiltCount; //Field offset: 0x78
	protected int _spawnedChunkCount; //Field offset: 0x7C
	private RouteSection _lastSpawnedSection; //Field offset: 0x80
	private RouteBuildProgress _sectionLayingProgress; //Field offset: 0x84
	private int _midSectionCountUsed; //Field offset: 0x88
	protected RouteManager _routeManager; //Field offset: 0x8C
	protected bool _stopped; //Field offset: 0x90
	private bool _completedSectionLayingThisUpdate; //Field offset: 0x91
	protected List<RouteChunk> _chunksSpawnedThisUpdate; //Field offset: 0x94
	protected List<RouteChunk> _chunksSpawnedDelayedBuild; //Field offset: 0x98
	protected List<IConstrainingRouteBuilder> _constrainingBuilders; //Field offset: 0x9C
	protected LogicAssetsManager _logicAssetManager; //Field offset: 0xA0
	protected ThemeManager _themeManager; //Field offset: 0xA4
	protected Vector3 _originGamePosition; //Field offset: 0xA8
	protected RouteSection _currentSection; //Field offset: 0xB4
	private List<RouteSection> _sections; //Field offset: 0xB8
	private List<BuildDirective> _buildDirectives; //Field offset: 0xBC
	private RouteBuilderWorker _worker; //Field offset: 0xC0
	private RouteChunk _lastBuiltChunk; //Field offset: 0xC4
	private HashSet<Selector> _processedSelectors; //Field offset: 0xC8
	private LinkedList<EnvironmentRangeWrapper> _environmentWrapperQueue; //Field offset: 0xCC
	private EnvironmentKind _lastSpawnedEnvironmentKind; //Field offset: 0xD0
	private SyboRandom <RandomGenerator>k__BackingField; //Field offset: 0xD4
	private int <SectionCountUsed>k__BackingField; //Field offset: 0xD8
	private EnvironmentKind <DesiredEnvironmentKind>k__BackingField; //Field offset: 0xDC
	private EnvironmentKind <PreviousDesiredEnvironmentKind>k__BackingField; //Field offset: 0xE0
	private int <DistanceBuilt>k__BackingField; //Field offset: 0xE4

	public event EventHandler OnCompletedLayingSections
	{
		 add { } //Length: 23
		 remove { } //Length: 111
	}

	public Bounds Bounds
	{
		 get { } //Length: 12
	}

	public RouteBuilder BuilderForward
	{
		 get { } //Length: 6
	}

	public List<RouteBuilder> BuildersAbove
	{
		 get { } //Length: 113
	}

	public List<RouteBuilder> BuildersBelow
	{
		 get { } //Length: 6
	}

	private List<RouteBuilder> BuildersOnSides
	{
		 get { } //Length: 7
	}

	public int BuiltLeadingEdgeGamePositionZ
	{
		 get { } //Length: 149
	}

	public ChunkBuildMode ChunkBuildMode
	{
		 get { } //Length: 6
	}

	public List<IConstrainingRouteBuilder> ConstrainingBuilders
	{
		 get { } //Length: 163
	}

	public virtual EnvironmentKind DesiredEnvironmentKind
	{
		 get { } //Length: 103
		protected set { } //Length: 9
	}

	protected int DistanceBuilt
	{
		 get { } //Length: 7
		private set { } //Length: 12
	}

	public virtual int DistanceVisibleFromEntry
	{
		 get { } //Length: 185
	}

	public RouteChunk FallbackRouteChunk
	{
		 get { } //Length: 22
	}

	public bool IsCleanedUp
	{
		 get { } //Length: 6
	}

	public bool IsDone
	{
		 get { } //Length: 6
	}

	public bool IsDoneLayingSections
	{
		 get { } //Length: 81
	}

	public RouteChunk LastChunk
	{
		 get { } //Length: 18
	}

	public virtual int LastPositionVisibleFromEntry
	{
		 get { } //Length: 4
	}

	private RouteSection LastSection
	{
		 get { } //Length: 109
	}

	public int MidSectionCountUsed
	{
		 get { } //Length: 7
	}

	private EnvironmentKind PreviousDesiredEnvironmentKind
	{
		 get { } //Length: 7
		 set { } //Length: 12
	}

	protected SyboRandom RandomGenerator
	{
		 get { } //Length: 7
		private set { } //Length: 111
	}

	public bool ReadyToAddSection
	{
		 get { } //Length: 7
	}

	public Route Route
	{
		 get { } //Length: 9
	}

	public RouteHeight RouteHeight
	{
		 get { } //Length: 7
	}

	public int SectionCountUsed
	{
		 get { } //Length: 7
		private set { } //Length: 37
	}

	protected RouteBuildProgress SectionLayingProgress
	{
		 get { } //Length: 6
	}

	public SectionSpawnMode SectionSpawnMode
	{
		 get { } //Length: 74
	}

	public int SpawnedChunkCount
	{
		 get { } //Length: 53
	}

	public int SpawnedLeadingEdgeGamePositionZ
	{
		 get { } //Length: 6
	}

	public int SpawnedLeadingEdgeWorldPositionZ
	{
		 get { } //Length: 71
	}

	public RouteBuilder() { }

	public void add_OnCompletedLayingSections(EventHandler value) { }

	protected virtual void AddNextSection() { }

	protected RouteSection AddSection(RouteSection sectionPrefab) { }

	public bool AddTransitionSectionTo(RouteType routeType, out RouteSection routeSection) { }

	private void BuildChunk(RouteChunk chunk, ChunkBuildMode buildMode) { }

	private void BuildChunks(float buildUntilGamePositionZ, ChunkBuildMode previouslySpawnedBuildMode = 1, ChunkBuildMode thisUpdateSpawnedBuildMode = 1) { }

	private void CalculateBounds() { }

	private bool CanDespawnPassedChunk(RouteChunk chunk, float characterGamePositionZ) { }

	public bool CanSpawnChunk(RouteChunk chunk) { }

	protected virtual bool CanSpawnSection(RouteSection section) { }

	private void CollectConstrainingBuilders(ICollection<RouteBuilder> builders) { }

	private void CollectConstrainingBuilders() { }

	private void CollectIfConstrainingBuilder(RouteBuilder builder) { }

	public virtual void ConnectBuilder(RouteBuilder builderToConnect) { }

	protected void DespawnAllRouteChunks() { }

	protected void DespawnPassedChunks(float characterGamePositionZ) { }

	protected void DespawnRouteChunk(RouteChunk chunk, bool instantDespawn) { }

	private IEnumerator DespawnRouteChunkASync(RouteChunk chunk) { }

	protected void DespawnUnbuiltChunks() { }

	public virtual void Destruct() { }

	private void DisconnectAllBuilders() { }

	public virtual void DisconnectBuilder(RouteBuilder builderToDisconnect) { }

	internal void EnqueueBuildDirective(int gamePositionZ, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, bool isApplicablePositionStict = true, RouteSection section = null) { }

	public void EnqueueStartSection(RouteType fromRouteType, int positionZ) { }

	protected virtual EnvironmentKind EvalNextChunkDesiredEnvironment(RouteChunk spawnedChunk) { }

	public Bounds get_Bounds() { }

	public RouteBuilder get_BuilderForward() { }

	public List<RouteBuilder> get_BuildersAbove() { }

	public List<RouteBuilder> get_BuildersBelow() { }

	private List<RouteBuilder> get_BuildersOnSides() { }

	public int get_BuiltLeadingEdgeGamePositionZ() { }

	public ChunkBuildMode get_ChunkBuildMode() { }

	public List<IConstrainingRouteBuilder> get_ConstrainingBuilders() { }

	public virtual EnvironmentKind get_DesiredEnvironmentKind() { }

	protected int get_DistanceBuilt() { }

	public virtual int get_DistanceVisibleFromEntry() { }

	public RouteChunk get_FallbackRouteChunk() { }

	public bool get_IsCleanedUp() { }

	public bool get_IsDone() { }

	public bool get_IsDoneLayingSections() { }

	public RouteChunk get_LastChunk() { }

	public virtual int get_LastPositionVisibleFromEntry() { }

	private RouteSection get_LastSection() { }

	public int get_MidSectionCountUsed() { }

	private EnvironmentKind get_PreviousDesiredEnvironmentKind() { }

	protected SyboRandom get_RandomGenerator() { }

	public bool get_ReadyToAddSection() { }

	public Route get_Route() { }

	public RouteHeight get_RouteHeight() { }

	public int get_SectionCountUsed() { }

	protected RouteBuildProgress get_SectionLayingProgress() { }

	public SectionSpawnMode get_SectionSpawnMode() { }

	public int get_SpawnedChunkCount() { }

	public int get_SpawnedLeadingEdgeGamePositionZ() { }

	public int get_SpawnedLeadingEdgeWorldPositionZ() { }

	protected IConstrainingRouteBuilder GetBuilderConstrainingStartAt(int startPositionZ) { }

	public RouteChunk GetChunkContainingPoint(Vector3 gamePosition) { }

	public IConstrainingRouteBuilder GetConstrainingBuilderAt(float gamePositionZ) { }

	protected RouteSection GetEndSectionPrefab(RouteType nextRouteType) { }

	public EnvironmentKind GetEnvironmentKindAt(float gamePositionZ) { }

	public float GetLastSectionMinEndGamePosition() { }

	public float GetLastSectionStartGamePosition() { }

	protected RouteSection GetMidSectionPrefab() { }

	protected virtual RouteSection GetNextSectionPrefab() { }

	private int GetProgressStateSectionCount(RouteBuildProgress progressState) { }

	private float GetSectionMinEndGamePosition(RouteSection section) { }

	protected virtual RouteSection GetSectionPrefab(RouteBuildProgress progressState, RouteType transitionRouteType = 0) { }

	protected RouteSection GetStartSectionPrefab(RouteType previousRouteType) { }

	protected virtual RouteSection GetTransitionSectionPrefab(List<TransitionSectionInfo> transitionSections, RouteType transitionRouteType) { }

	public void HideLogic(float fromGamePositionZ, float distance) { }

	private void IncrementSectionProgressState() { }

	public virtual void Initialize(RouteManager routeManager, Route route, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator) { }

	private void InitializeSectionGroups() { }

	private bool IsConstraintBlockingSpawningAt(int spawnedLeadingEdgeGamePositionZ) { }

	private bool IsPositionWithinConnectedBuilder(Vector3 position) { }

	protected bool IsStartPositionConstrained(int startPositionZ) { }

	private IEnumerator PerformSelectionAndActivationASync(RouteChunk chunk, ChunkBuildMode buildMode) { }

	private IEnumerator PerformSelectionASync(RouteChunk chunk) { }

	private bool ProcessBuildDirectives(int spawnedLeadingEdgeGamePositionZ) { }

	private IEnumerator RecursiveSelectionASync(List<Selector> selectors, List<GameObject> objectsToVisit, List<Selector> spawnPoints) { }

	public void remove_OnCompletedLayingSections(EventHandler value) { }

	public void RemoveChunk(RouteChunk chunk) { }

	protected void RemoveEmptySections() { }

	private void RouteBuilder_OnCompletedLayingSections(object sender, EventArgs args) { }

	private void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind spawnedKind, int gamePositionZ, Route route) { }

	protected virtual void set_DesiredEnvironmentKind(EnvironmentKind value) { }

	private void set_DistanceBuilt(int value) { }

	private void set_PreviousDesiredEnvironmentKind(EnvironmentKind value) { }

	private void set_RandomGenerator(SyboRandom value) { }

	private void set_SectionCountUsed(int value) { }

	public void SetBuildMode(SectionSpawnMode spawnMode, ChunkBuildMode chunkBuildMode) { }

	private void SetChunkCrossReferences(RouteChunk previous, RouteChunk next) { }

	protected void SpawnNextChunk(RouteSection section) { }

	protected RouteChunk SpawnRouteChunk(RouteChunk chunkPrefab) { }

	public void StopBuilding() { }

	public virtual void UpdateBuilder(float characterGamePositionZ) { }

	public virtual void Validate(Route route) { }

	public virtual bool WillChangeEnvironment(int addedDistance) { }

}

