namespace SYBO.Subway.Routes.Builders.Worker;

public class RouteBuilderWorker
{
	private enum WorkType
	{
		Spawning = 0,
		Despawning = 1,
	}

	private class WorkWrapper
	{
		private readonly Stack<IEnumerator> _workStack; //Field offset: 0x8
		public readonly RouteChunk Chunk; //Field offset: 0xC
		public readonly WorkType WorkType; //Field offset: 0x10
		private int _workIteration; //Field offset: 0x14

		public bool IsDone
		{
			 get { } //Length: 6
		}

		public WorkWrapper(RouteChunk chunk, Stack<IEnumerator> workStack, WorkType workType) { }

		public bool get_IsDone() { }

		public bool Work() { }

		public void WorkUntilDone() { }

	}

	private const float WorkSpeedupDistanceFactorDefault = 0; //Field offset: 0x0
	private const float WorkSpeedupDistanceFactorMax = 1; //Field offset: 0x0
	private const float WorkTimeAllowanceMin = 0.002; //Field offset: 0x0
	private const float WorkTimeAllowanceMax = 0.005; //Field offset: 0x0
	private const int SpawnSpeedupDistance = 100; //Field offset: 0x0
	private const int CleanupSpeedupDistance = 1830; //Field offset: 0x0
	private Dictionary<RouteChunk, WorkWrapper> _chunkToWorkWrapperMap; //Field offset: 0x8
	private Queue<WorkWrapper> _spawnWorkQueue; //Field offset: 0xC
	private Queue<WorkWrapper> _despawnWorkQueue; //Field offset: 0x10
	private Queue<WorkWrapper> _activeWorkQueue; //Field offset: 0x14

	public RouteBuilderWorker() { }

	private float ComputeDistanceFactor(float chunkEdgeZ, float requiredDonePositionZ, float workRampupDistance) { }

	public void EnqueueDespawnWork(RouteChunk chunk, IEnumerator workRoutine, bool instantComplete = false) { }

	public void EnqueueSpawnWork(RouteChunk chunk, IEnumerator workRoutine, bool instantComplete = false) { }

	private void EnqueueWork(RouteChunk chunk, IEnumerator workRoutine, WorkType workType, bool instantComplete = false) { }

	private void SwitchActiveWorkQueue() { }

	public void UpdateWorker(float reqPositionReadyGameZ, float reqPositionCleanedUpGameZ) { }

}

