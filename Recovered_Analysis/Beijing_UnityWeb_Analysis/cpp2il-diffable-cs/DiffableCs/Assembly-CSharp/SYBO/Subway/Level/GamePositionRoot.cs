namespace SYBO.Subway.Level;

public class GamePositionRoot
{
	public const int ZDistanceThreshold = 50000; //Field offset: 0x0
	public const int ZDistanceTargetPosition = 1000; //Field offset: 0x0
	public const int DebugZDistanceTargetOffset = 5000; //Field offset: 0x0
	private static GamePositionRoot _instance; //Field offset: 0x0
	private static bool _instantiated; //Field offset: 0x4
	private int _currentGameOffsetZ; //Field offset: 0x10
	private Character _character; //Field offset: 0x14
	private HashSet<Transform> _offsetTransforms; //Field offset: 0x18
	private HashSet<object> _locks; //Field offset: 0x1C

	public float CurrentGameOffsetZ
	{
		 get { } //Length: 6
	}

	public static GamePositionRoot Instance
	{
		 get { } //Length: 65
	}

	private static GamePositionRoot() { }

	public GamePositionRoot() { }

	public void AddLock(object lockObject) { }

	public void AddOffsetTransform(Transform transform) { }

	private void Game_OnGameEnded() { }

	private void Game_OnGameStarted() { }

	public float get_CurrentGameOffsetZ() { }

	public static GamePositionRoot get_Instance() { }

	public Vector3 GetGamePosition(Transform transform) { }

	public Vector3 GetGamePosition(Vector3 worldPosition) { }

	public Vector3 GetWorldPosition(Vector3 gamePosition) { }

	public float GetWorldPositionZ(float gamePositionZ) { }

	private int GetZDistanceTargetPosition() { }

	private void LateUpdate() { }

	public void RemoveLock(object lockObject) { }

	public void RemoveOffsetTransform(Transform transform) { }

	private void ResetGamePosition() { }

	private void Start() { }

}

