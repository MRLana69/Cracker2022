namespace SYBO.Subway.Routes;

public class RouteSection : MonoBehaviour
{
	public class RepeatConfiguration
	{
		private int _sectionsBetweenRepeats; //Field offset: 0x8
		private int _remainingSectionsBetweenRepeats; //Field offset: 0xC
		private int _distanceBetweenRepeats; //Field offset: 0x10
		private int _lastSpawnZPosition; //Field offset: 0x14
		private List<RouteSection> _doNotSpawnAfter; //Field offset: 0x18

		public int RemainingSectionsBetweenRepeat
		{
			 get { } //Length: 59
		}

		public RepeatConfiguration() { }

		public bool CanSpawnAfter(RouteSection previousSection) { }

		public bool CanSpawnAtPositionZ(int posZ, int routeSpecificDistanceBetweenRepeats) { }

		public int get_RemainingSectionsBetweenRepeat() { }

		public void NotifySectionSpawn(int posZ, int maxLength) { }

		public void Reset() { }

		public void UpdateRepeatConfiguration() { }

		public void Validate(RouteSection mySection) { }

	}

	private int _zMinimum; //Field offset: 0xC
	private bool _zMaximumActive; //Field offset: 0x10
	private int _zMaximum; //Field offset: 0x14
	private int _minSpawnOrder; //Field offset: 0x18
	private RepeatConfiguration _repeatConfiguration; //Field offset: 0x1C
	private bool _middleChunkCountLimited; //Field offset: 0x20
	private int _middleChunkCountMin; //Field offset: 0x24
	private int _middleChunkCountMax; //Field offset: 0x28
	protected WeightRandomizedRouteChunkContainter _startChunks; //Field offset: 0x2C
	protected WeightRandomizedRouteChunkContainter _midChunks; //Field offset: 0x30
	protected WeightRandomizedRouteChunkContainter _endChunks; //Field offset: 0x34
	private List<EnvironmentKind> _limitedAllowedEnvironmentKinds; //Field offset: 0x38
	private List<EnvironmentKind> _forcedEnvironmentKinds; //Field offset: 0x3C
	private int _lengthMin; //Field offset: 0x40
	private int _lengthMax; //Field offset: 0x44
	private int _lengthMinPrev; //Field offset: 0x48
	private int _lengthMaxPrev; //Field offset: 0x4C
	private int _middleChunkCountMinPrev; //Field offset: 0x50
	private int _middleChunkCountMaxPrev; //Field offset: 0x54
	private RouteBuildProgress _progressState; //Field offset: 0x58
	private WeightRandomizedRouteChunkContainter _filteredChunks; //Field offset: 0x5C
	private int _midChunksCountUsed; //Field offset: 0x60
	private int _midChunksCountTarget; //Field offset: 0x64
	private RouteBuilder _builder; //Field offset: 0x68
	private List<RouteChunk> _pickedChunks; //Field offset: 0x6C
	private ReadOnlyCollection<RouteChunk> _pickedChunksReadOnly; //Field offset: 0x70
	protected List<RouteChunk> _spawnedChunks; //Field offset: 0x74

	public WeightRandomizedRouteChunkContainter EndChunks
	{
		 get { } //Length: 6
	}

	public List<EnvironmentKind> ForcedEnvironmentKinds
	{
		 get { } //Length: 255
	}

	public bool IsDone
	{
		 get { } //Length: 6
	}

	public int LengthMax
	{
		 get { } //Length: 9
	}

	public int LengthMin
	{
		 get { } //Length: 6
	}

	public WeightRandomizedRouteChunkContainter MidChunks
	{
		 get { } //Length: 6
	}

	public int MinSpawnOrder
	{
		 get { } //Length: 9
	}

	public ReadOnlyCollection<RouteChunk> PickedChunks
	{
		 get { } //Length: 6
	}

	public int SpawnedChunkCount
	{
		 get { } //Length: 6
	}

	public List<RouteChunk> SpawnedChunks
	{
		 get { } //Length: 75
	}

	public WeightRandomizedRouteChunkContainter StartChunks
	{
		 get { } //Length: 6
	}

	public int ZMaximum
	{
		 get { } //Length: 6
	}

	public bool ZMaximumActive
	{
		 get { } //Length: 6
	}

	public int ZMinimum
	{
		 get { } //Length: 9
	}

	public RouteSection() { }

	public void AddSpawnedChunk(RouteChunk chunk) { }

	private bool CanSpawnChunk(RouteChunk chunk) { }

	public WeightRandomizedRouteChunkContainter get_EndChunks() { }

	public List<EnvironmentKind> get_ForcedEnvironmentKinds() { }

	public bool get_IsDone() { }

	public int get_LengthMax() { }

	public int get_LengthMin() { }

	public WeightRandomizedRouteChunkContainter get_MidChunks() { }

	public int get_MinSpawnOrder() { }

	public ReadOnlyCollection<RouteChunk> get_PickedChunks() { }

	public int get_SpawnedChunkCount() { }

	public List<RouteChunk> get_SpawnedChunks() { }

	public WeightRandomizedRouteChunkContainter get_StartChunks() { }

	public int get_ZMaximum() { }

	public bool get_ZMaximumActive() { }

	public int get_ZMinimum() { }

	public RouteChunk GetNextChunk(RouteBuilder builder, SyboRandom random) { }

	private WeightRandomizedRouteChunkContainter GetProgressStateChunks(RouteBuildProgress progressState) { }

	public RouteChunk GetRandomMidChunk(SyboRandom random) { }

	public RepeatConfiguration GetRepeatConfiguration() { }

	public RouteChunk GetSpawnedChunk(int index) { }

	public IRouteTransitionTrigger GetTransitionTrigger() { }

	public bool HasChunk(RouteChunk chunk) { }

	private void IncrementProgressState() { }

	public void RemoveSpawnedChunk(RouteChunk chunk) { }

	public void Reset(RouteBuilder builder) { }

	public bool SupportsEnvironment(EnvironmentKind envKind) { }

	public override string ToString() { }

}

