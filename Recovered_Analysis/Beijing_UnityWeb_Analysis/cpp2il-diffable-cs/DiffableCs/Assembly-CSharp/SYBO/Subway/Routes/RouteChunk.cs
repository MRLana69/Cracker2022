namespace SYBO.Subway.Routes;

public class RouteChunk : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<EnvironmentBase> <>9__40_0; //Field offset: 0x4
		public static Comparison<Environment> <>9__40_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <Awake>b__40_0(EnvironmentBase l, EnvironmentBase r) { }

		internal int <Awake>b__40_1(Environment l, Environment r) { }

	}

	private sealed class <ActivateTrackObjectsASync>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RouteChunk <>4__this; //Field offset: 0x10
		private int <i>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 841
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ActivateTrackObjectsASync>d__84(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <DeactivateTrackObjects>d__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RouteChunk <>4__this; //Field offset: 0x10
		private int <i>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 909
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DeactivateTrackObjects>d__85(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Destruct>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public RouteChunk <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 345
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Destruct>d__41(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class ChunkBlockConstraint
	{
		public static readonly ChunkBlockConstraint None; //Field offset: 0x0
		public readonly EnvironmentKind EnvironmentKind; //Field offset: 0x8
		public readonly EnvironmentBaseKind EnvironmentBaseKind; //Field offset: 0xC

		private static ChunkBlockConstraint() { }

		public ChunkBlockConstraint(EnvironmentKind envKind, EnvironmentBaseKind envBaseKind) { }

		public override bool Equals(object other) { }

		public override int GetHashCode() { }

		public static bool op_Equality(ChunkBlockConstraint c1, ChunkBlockConstraint c2) { }

		public static bool op_Inequality(ChunkBlockConstraint c1, ChunkBlockConstraint c2) { }

	}

	public const int TrackLaneWidth = 20; //Field offset: 0x0
	public const int TrackWidth = 60; //Field offset: 0x0
	public const int TrackHeight = 90; //Field offset: 0x0
	public const int BlockLength = 90; //Field offset: 0x0
	public const int BlockCountMin = 2; //Field offset: 0x0
	public const int MinChunkLength = 180; //Field offset: 0x0
	private const float BaseColliderCenterY = -9.4; //Field offset: 0x0
	private const float BaseColliderSizeY = 20; //Field offset: 0x0
	public static Action<EnvironmentKind, int, Route> OnEnvironmentSegmentSpawned; //Field offset: 0x0
	private readonly Vector3 LogicHideOffset; //Field offset: 0xC
	private Action OnDeactivate; //Field offset: 0x18
	private bool _isRepeatableInSections; //Field offset: 0x1C
	private int _blockCount; //Field offset: 0x20
	private bool _generateEnvironment; //Field offset: 0x24
	private bool _generateEnvironmentBase; //Field offset: 0x25
	private EnvironmentKind[] _limitedAllowedEnvironmentKinds; //Field offset: 0x28
	private List<TrackObject> _trackObjects; //Field offset: 0x2C
	private List<TrackObject> _environmentTrackObjects; //Field offset: 0x30
	private EnvironmentBase[] _forcedEnvironmentBases; //Field offset: 0x34
	private Environment[] _forcedEnvironments; //Field offset: 0x38
	private List<Selector> _selectors; //Field offset: 0x3C
	private List<Selector> _environmentSelectors; //Field offset: 0x40
	private RouteTransitionTrigger _routeTransitionTrigger; //Field offset: 0x44
	public RouteChunk Previous; //Field offset: 0x48
	public RouteChunk Next; //Field offset: 0x4C
	private string _reportedName; //Field offset: 0x50
	public int PreviewEnvironmentIndex; //Field offset: 0x54
	private Transform _transform; //Field offset: 0x58
	private Transform _environmentTransform; //Field offset: 0x5C
	private List<ChunkBlockConstraint> _blockConstraints; //Field offset: 0x60
	private LogicAssetsManager _logicAssetManager; //Field offset: 0x64
	private ThemeManager _themeManager; //Field offset: 0x68
	private bool _built; //Field offset: 0x6C
	private Dictionary<Transform, Vector3> _hiddenObstacles; //Field offset: 0x70
	private RouteBuilder _builder; //Field offset: 0x74
	internal RouteSection _section; //Field offset: 0x78
	private RouteChunk _sourcePrefab; //Field offset: 0x7C

	public event Action OnDeactivate
	{
		 add { } //Length: 207
		 remove { } //Length: 111
	}

	public int BlockCount
	{
		 get { } //Length: 10
	}

	public List<Selector> EnvironmentSelectors
	{
		 get { } //Length: 6
	}

	public Transform EnvironmentTransform
	{
		 get { } //Length: 9
	}

	public Vector3 GamePositionEnd
	{
		 get { } //Length: 90
	}

	public Vector3 GamePositionStart
	{
		 get { } //Length: 485
	}

	public float GamePositionStartZ
	{
		 get { } //Length: 6
	}

	public bool GenerateEnvironment
	{
		 get { } //Length: 6
	}

	public bool GenerateEnvironmentBase
	{
		 get { } //Length: 66
	}

	public bool IsBuilt
	{
		 get { } //Length: 9
	}

	public bool IsRepeatableInSections
	{
		 get { } //Length: 6
	}

	public int Length
	{
		 get { } //Length: 9
	}

	public IList<EnvironmentKind> LimitedAllowedEnvironmentKinds
	{
		 get { } //Length: 9
	}

	public string ReportedName
	{
		 get { } //Length: 6
	}

	public RouteBuilder RouteBuilder
	{
		 get { } //Length: 6
	}

	public RouteTransitionTrigger RouteTransitionTrigger
	{
		 get { } //Length: 6
	}

	public RouteSection Section
	{
		 get { } //Length: 6
	}

	public List<Selector> Selectors
	{
		 get { } //Length: 9
	}

	public Bounds TrackBounds
	{
		 get { } //Length: 111
	}

	public RouteChunk() { }

	public IEnumerator ActivateTrackObjectsASync() { }

	public void add_OnDeactivate(Action value) { }

	protected void Awake() { }

	public void Build(EnvironmentKind routeDesiredEnvironmentKind, EnvironmentKind previousDesiredEnvironmentKind) { }

	private int CreateEnvironmentBase(int blockIndex, EnvironmentBaseKind baseKind, EnvironmentBaseKind baseKindNext, EnvironmentKind envKind) { }

	private void CreateEnvironmentLogic(EnvironmentType envType, EnvironmentSequence sequence, float positionZ) { }

	private int CreateEnvironmentModel(EnvironmentInfo environmentInfo, EnvironmentSequence sequence, int prevVariation, float positionZ) { }

	private int CreateEnvironmentSegment(int blockIndex, EnvironmentInfo environmentInfo, EnvironmentSequence sequence, ref int prevSegmentVariation) { }

	public IEnumerator DeactivateTrackObjects() { }

	public IEnumerator Destruct() { }

	public void DrawSegments(Vector3 from, float length, float ySize, float zStep, Color startColor, Color midColor, Color endColor) { }

	public static EnvironmentBaseKind EnvironentBaseToBaseKind(EnvironmentBase envBase) { }

	private EnvironmentSequence EvalNextEnvironmentSequence(int nextEnvBlockIndex, int envEndBlockIndex, EnvironmentInfo environmentInfo, bool shouldStartCurrentEnvironment, bool shouldEndCurrentEnvironment) { }

	private void EvaluateEnvironmentConstraints() { }

	public int get_BlockCount() { }

	public List<Selector> get_EnvironmentSelectors() { }

	public Transform get_EnvironmentTransform() { }

	public Vector3 get_GamePositionEnd() { }

	public Vector3 get_GamePositionStart() { }

	public float get_GamePositionStartZ() { }

	public bool get_GenerateEnvironment() { }

	public bool get_GenerateEnvironmentBase() { }

	public bool get_IsBuilt() { }

	public bool get_IsRepeatableInSections() { }

	public int get_Length() { }

	public IList<EnvironmentKind> get_LimitedAllowedEnvironmentKinds() { }

	public string get_ReportedName() { }

	public RouteBuilder get_RouteBuilder() { }

	public RouteTransitionTrigger get_RouteTransitionTrigger() { }

	public RouteSection get_Section() { }

	public List<Selector> get_Selectors() { }

	public Bounds get_TrackBounds() { }

	public static float GetBaseColliderOffsetY() { }

	public static int GetBlockIndexFromLocalPosition(Vector3 localPos) { }

	private int GetCurrentEnvironmentEndBlock(int currentBlockIndex) { }

	private EnvironmentBaseKind GetDefaultEnvironmentBaseKind(RouteType routeType) { }

	private EnvironmentBaseKind GetEndEnvironmentBase(int numTracks) { }

	private EnvironmentBase GetEnvironmentBaseConstraint(int blockIndex) { }

	private EnvironmentBaseKind GetEnvironmentBaseKindToPlace(EnvironmentKind envKind, EnvironmentKind previousEnvKind, EnvironmentKind routeDesiredEnvironment, EnvironmentBaseKind envBaseKindConstraint, EnvironmentBaseKind nextConstraint, int blockIndex, int envKindEndBlock) { }

	private Environment GetEnvironmentConstraint(int blockIndex) { }

	private ChunkBlockConstraint GetEnvironmentConstraintFromIndex(int blockIndex) { }

	private ChunkBlockConstraint GetNextEnvironmentConstraint(int currentBlockIndex) { }

	public static RouteChunk GetParentRouteChunk(Transform childTransform) { }

	public EnvironmentKind GetRandomAllowedEnvironmentKind(SyboRandom random) { }

	private EnvironmentBaseKind GetStartEnvironmentBase(int numTracks) { }

	public static bool HasParentRouteChunk(Transform childTransform) { }

	public void HideLogic(float untilGamePositionZ) { }

	private void HideLogicRecursive(Transform target, float maxGamePositionZ) { }

	public void Initialize(RouteBuilder builder, RouteSection section, RouteChunk sourcePrefab) { }

	private void OnDrawGizmos() { }

	private void PlaceEnvironmentModel(EnvironmentKind envTypeInfo, EnvironmentSequence sequence, EnvironmentSide side, int variation, float positionZ) { }

	public void remove_OnDeactivate(Action value) { }

	public void RestoreHiddenLogic() { }

	public bool SupportsAnyEnvironmentOf(IList<EnvironmentKind> environmentKinds) { }

	public bool SupportsEnvironment(EnvironmentKind environmentKind) { }

	public override string ToString() { }

}

