namespace SYBO.Subway.Routes;

public class RouteManager
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<PickupSpawnPoint> <>9__90_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <PickupManager_OnPickupSpawnPointRegistered>b__90_0(PickupSpawnPoint x, PickupSpawnPoint y) { }

	}

	private sealed class <>c__74`1
	{
		public static readonly <>c__74<T> <>9; //Field offset: 0x0
		public static Predicate<Route> <>9__74_0; //Field offset: 0x0

		private static <>c__74`1() { }

		public <>c__74`1() { }

		internal bool <GetRoutePrefab>b__74_0(Route r) { }

	}

	private sealed class <>c__80`1
	{
		public static readonly <>c__80<T> <>9; //Field offset: 0x0
		public static Predicate<Route> <>9__80_0; //Field offset: 0x0

		private static <>c__80`1() { }

		public <>c__80`1() { }

		internal bool <CanCreateRoute>b__80_0(Route r) { }

	}

	private sealed class <>c__DisplayClass72_0
	{
		public RouteType routeType; //Field offset: 0x8

		public <>c__DisplayClass72_0() { }

		internal bool <GetRoutePrefab>b__0(Route r) { }

	}

	private sealed class <>c__DisplayClass73_0
	{
		public Predicate<Route> predicate; //Field offset: 0x8

		public <>c__DisplayClass73_0() { }

		internal bool <FindAlternateRoute>b__0(WeightedAlternateRouteConfig rc) { }

	}

	private sealed class <>c__DisplayClass79_0
	{
		public RouteType routeType; //Field offset: 0x8

		public <>c__DisplayClass79_0() { }

		internal bool <CanCreateRoute>b__0(Route r) { }

	}

	public class AlternateRouteConfig
	{
		public AlternateRoute Route; //Field offset: 0x8
		public bool Enabled; //Field offset: 0xC
		public int Weight; //Field offset: 0x10

		public AlternateRouteConfig() { }

	}

	public class CharacterChunks
	{
		public string PreviousChunkReportedName; //Field offset: 0x8
		public RouteChunk Current; //Field offset: 0xC
		public RouteChunk Next; //Field offset: 0x10

		public CharacterChunks() { }

		public bool Contains(RouteChunk chunk) { }

		public void Reset() { }

	}

	public class CharacterRouteChangedEventArgs : EventArgs
	{
		private Route _fromRoute; //Field offset: 0x8
		private Route _toRoute; //Field offset: 0xC

		public Route FromRoute
		{
			 get { } //Length: 64
		}

		public bool HasFromRoute
		{
			 get { } //Length: 6
		}

		public Route ToRoute
		{
			 get { } //Length: 84
		}

		public CharacterRouteChangedEventArgs(Route fromRoute, Route toRoute) { }

		public Route get_FromRoute() { }

		public bool get_HasFromRoute() { }

		public Route get_ToRoute() { }

		public override string ToString() { }

	}

	public class RouteCreatedEventArgs : EventArgs
	{
		public readonly Route Route; //Field offset: 0x8

		public RouteCreatedEventArgs(Route route) { }

	}

	public class RouteTransitionEventArgs : EventArgs
	{
		public readonly Route CurrentRoute; //Field offset: 0x8
		public readonly Route TransitionRoute; //Field offset: 0xC
		public readonly RouteType TransitionRouteType; //Field offset: 0x10

		public bool ExistsTransitionRoute
		{
			 get { } //Length: 6
		}

		public RouteTransitionEventArgs(Route currentRoute, RouteType transitionRouteType, Route transitionRoute) { }

		public bool get_ExistsTransitionRoute() { }

		public override string ToString() { }

	}

	public enum ValueResetEvent
	{
		AppStart = 0,
		GameStart = 1,
		RunRevive = 2,
	}

	private class WeightedAlternateRouteConfig
	{

		public WeightedAlternateRouteConfig(AlternateRouteConfig routeConfig, int weight) { }

	}

	private const string RoutePoolName = "Routes"; //Field offset: 0x0
	public const int RouteBuilderHeight = 90; //Field offset: 0x0
	public const int FirstRouteStartPosZ = 0; //Field offset: 0x0
	public static string PrefabPath; //Field offset: 0x0
	private static bool <UseBenchmarkRoute>k__BackingField; //Field offset: 0x4
	private EventHandler<RouteCreatedEventArgs> OnRouteCreated; //Field offset: 0x10
	private EventHandler<CharacterRouteChangedEventArgs> OnCharacterRouteChanged; //Field offset: 0x14
	private EventHandler<RouteTransitionEventArgs> OnRouteTransitionStarted; //Field offset: 0x18
	private Route _defaultRoute; //Field offset: 0x1C
	private int _alternateRouteFirstOfferTime; //Field offset: 0x20
	private int _alternateRouteRepeatedOfferDelay; //Field offset: 0x24
	private int _alternateRouteRepeatedOfferDelayIncrement; //Field offset: 0x28
	private bool _limitAlternateOfferToHeadstart; //Field offset: 0x2C
	private ValueResetEvent _alternateRouteOfferDelayResetEvent; //Field offset: 0x30
	private List<AlternateRouteConfig> _alternateRouteConfigs; //Field offset: 0x34
	private Route _benchmarkRoute; //Field offset: 0x38
	private RouteManagerConfigurationSO _routeManagerConfiguration; //Field offset: 0x3C
	private Game _game; //Field offset: 0x40
	private Character _character; //Field offset: 0x44
	private Route _mainRoute; //Field offset: 0x48
	private Route _characterRoute; //Field offset: 0x4C
	private CharacterChunks _characterChunksNear; //Field offset: 0x50
	private RouteCollection _routeCollection; //Field offset: 0x54
	private Vector3 _originGamePosition; //Field offset: 0x58
	private WeightRandomizedOrderedContainter<WeightedAlternateRouteConfig, AlternateRouteConfig> _alternateRouteConfigsEnabled; //Field offset: 0x64
	private float _timeInDefaultRoute; //Field offset: 0x68
	private float _alternateRouteRepeatedOfferDelayIncremented; //Field offset: 0x6C
	private float _alternateRouteOfferDefaultRouteTimeNext; //Field offset: 0x70
	private bool _isWaitingForRouteChoice; //Field offset: 0x74
	private float _requiredOfferGamePositionZBeforeRouteOffer; //Field offset: 0x78
	private List<PickupSpawnPoint> _spawnPoints; //Field offset: 0x7C

	public event EventHandler<CharacterRouteChangedEventArgs> OnCharacterRouteChanged
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event EventHandler<RouteCreatedEventArgs> OnRouteCreated
	{
		 add { } //Length: 103
		 remove { } //Length: 111
	}

	public event EventHandler<RouteTransitionEventArgs> OnRouteTransitionStarted
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	private float AlternateRouteOfferDefaultRouteTimeNext
	{
		 get { } //Length: 6
		 set { } //Length: 541
	}

	public CharacterChunks CharacterChunksNear
	{
		 get { } //Length: 6
	}

	public Route CharacterRoute
	{
		 get { } //Length: 6
	}

	public Route DefaultRoute
	{
		 get { } //Length: 6
	}

	public bool IsCharacterInAnyRoute
	{
		 get { } //Length: 6
	}

	private bool IsPaused
	{
		 get { } //Length: 6
	}

	public Route MainRoute
	{
		 get { } //Length: 9
		private set { } //Length: 634
	}

	public ICollection<Route> Routes
	{
		 get { } //Length: 137
	}

	public float TimeInDefaultRoute
	{
		 get { } //Length: 31
	}

	public static bool UseBenchmarkRoute
	{
		private get { } //Length: 189
		 set { } //Length: 99
	}

	private static RouteManager() { }

	public RouteManager() { }

	public void add_OnCharacterRouteChanged(EventHandler<CharacterRouteChangedEventArgs> value) { }

	public void add_OnRouteCreated(EventHandler<RouteCreatedEventArgs> value) { }

	public void add_OnRouteTransitionStarted(EventHandler<RouteTransitionEventArgs> value) { }

	private void AlternateRoute_CharacterEntrySkipped(object sender, CharacterEntrySkippedEventArgs args) { }

	private void AlternateRouteBuilder_OnCompletedLayingSections(object sender, EventArgs args) { }

	public bool CanCreateRoute() { }

	public bool CanCreateRoute(RouteType routeType) { }

	private void ChangeCharacterRoute(Route route) { }

	private float ComputeDefaultRouteTimeUntilPosition(float gamePositionZ) { }

	private Route CreateRoute(Route routePrefab, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, Vector3 originGamePosition, RouteType previousRouteType) { }

	public Route CreateRoute(RouteType routeType, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, Vector3 originGamePosition) { }

	public Route CreateRouteAndConnect(RouteType routeType, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, Route routeConnectTo) { }

	private void CreateRouteTransition(RouteType transitionRouteType) { }

	public RouteType EvaluateAlternateRouteOffer(float offerGamePositionZ) { }

	private void FilterAlternateRouteConfigs(IList<RouteType> allowedRouteTypes = null) { }

	private Route FindAlternateRoute(Predicate<Route> predicate) { }

	private void Game_OnGameRevived() { }

	private float get_AlternateRouteOfferDefaultRouteTimeNext() { }

	public CharacterChunks get_CharacterChunksNear() { }

	public Route get_CharacterRoute() { }

	public Route get_DefaultRoute() { }

	public bool get_IsCharacterInAnyRoute() { }

	private bool get_IsPaused() { }

	public Route get_MainRoute() { }

	public ICollection<Route> get_Routes() { }

	public float get_TimeInDefaultRoute() { }

	private static bool get_UseBenchmarkRoute() { }

	public float GetRoutePositionOffsetY(RouteHeight routeHeight) { }

	public T GetRoutePrefab() { }

	public Route GetRoutePrefab(RouteType routeType) { }

	public bool IsModifierAllowedInCurrentRoute(CharacterModifier characterModifier) { }

	private void PickupManager_OnPickupSpawned(object sender, PickupEventArgs args) { }

	private void PickupManager_OnPickupSpawnPointDeregistered(PickupSpawnPoint spawnPoint) { }

	private void PickupManager_OnPickupSpawnPointRegistered(PickupSpawnPoint spawnPoint) { }

	private void ProcessCharacterRouteEnter(Route route, Route previousRoute) { }

	private void ProcessCharacterRouteExited(Route route, Route nextRoute) { }

	private void RaiseOnCharacterRouteChanged(object sender, CharacterRouteChangedEventArgs args) { }

	public void remove_OnCharacterRouteChanged(EventHandler<CharacterRouteChangedEventArgs> value) { }

	public void remove_OnRouteCreated(EventHandler<RouteCreatedEventArgs> value) { }

	public void remove_OnRouteTransitionStarted(EventHandler<RouteTransitionEventArgs> value) { }

	public void Reset() { }

	private void Route_OnDestructing(object sender, EventArgs args) { }

	private void set_AlternateRouteOfferDefaultRouteTimeNext(float value) { }

	private void set_MainRoute(Route value) { }

	public static void set_UseBenchmarkRoute(bool value) { }

	private void SetNextAlternateRouteOfferTimeFromGamePosition(float gamePositionZ) { }

	public void StartRouteTransition(Route targetRoute) { }

	protected override void SubclassInitialize() { }

	private void Update() { }

	private void UpdateCharacterNearChunks(CharacterChunks charChunks, Vector3 characterGamePosition, Route charRoute) { }

	private void UpdateCharacterRoute() { }

	private void UpdateRoutes(float characterGamePositionZ) { }

}

