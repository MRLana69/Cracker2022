namespace SYBO.Subway.Coins;

public class CoinCurve : MonoBehaviour
{
	public enum CoinSpaceMode
	{
		NonStraight = 0,
		Straight = 1,
	}

	public enum ScaleMode
	{
		NoScale = 0,
		PreserveSpacing = 1,
		ScaleSpacing = 2,
	}

	public const float TOP_LEVEL_HEIGHT_THRESHOLD = 70; //Field offset: 0x0
	public const float StraightSpacing = 30; //Field offset: 0x0
	public const float NonStraightSpacing = 15; //Field offset: 0x0
	private CurveParent _curveParent; //Field offset: 0xC
	private ScaleMode _scaleMode; //Field offset: 0x10
	private CoinSpaceMode _spacingMode; //Field offset: 0x14
	private float _curveOffset; //Field offset: 0x18
	private int _coinIndexToSkip; //Field offset: 0x1C
	private bool _redistributeAlongCurveOnSpeedChange; //Field offset: 0x20
	private bool _debugIsMovingTrain; //Field offset: 0x21
	private CoinManager _coinManager; //Field offset: 0x24
	private Character _character; //Field offset: 0x28
	private TrackObject _trackObject; //Field offset: 0x2C
	private List<Coin> _placedCoins; //Field offset: 0x30
	private Game _game; //Field offset: 0x34
	private bool _allCoinsActive; //Field offset: 0x38
	private int _coinsAtSpawn; //Field offset: 0x3C
	private bool _activating; //Field offset: 0x40
	private int lastSpawnedCoinIndex; //Field offset: 0x44

	private bool IsOnTopLevel
	{
		 get { } //Length: 66
	}

	private float SpeedForCurve
	{
		 get { } //Length: 6
	}

	private float UnscaledCoinSpacing
	{
		 get { } //Length: 123
	}

	public CoinCurve() { }

	private void ActivateOneCoinUtilDone() { }

	protected void Awake() { }

	private float CoinSpacing(float speed) { }

	public void DeactivateCoin(Coin coin) { }

	public void DrawCurve(float speed, Color color) { }

	private Vector3 EvaluateCurve(float t, float speed) { }

	private Vector3 EvaluateCurve(float t) { }

	private void Game_OnSpeedChanged(float newSpeed) { }

	private bool get_IsOnTopLevel() { }

	private float get_SpeedForCurve() { }

	private float get_UnscaledCoinSpacing() { }

	private Vector3 GetCoinPosition(int index) { }

	private Vector3 GetCoinPosition(int index, float speed, bool speedChanged = false) { }

	public List<Vector3> GetCoinPositions() { }

	private bool IsSkippingCoin(float speed) { }

	protected bool IsZAvailableToJetpackState() { }

	private void Jetpack_OnStart() { }

	private void JetpackStart() { }

	private float JumpLength(float speed) { }

	private float LengthOfCurve(float speed) { }

	private int NumberOfCoins(float speed) { }

	private int NumberOfCoinsIgnoringSkip(float speed) { }

	public void OnDrawGizmos() { }

	protected void OnValidate() { }

	private void PogoStick_OnStart() { }

	private void PogostickStart() { }

	private void RepositionCoins(float speed) { }

	private void ResizeIfNeeded(float speed) { }

	private float ScaleZ(float speed, float z) { }

	private Coin SpawnCoin(Vector3 spawnPos) { }

	private void SpeedChanged(float newSpeed) { }

	private void ToggleRenderers(bool doRender) { }

	private void TrackObject_OnActivate() { }

	private void TrackObject_OnDeactivate() { }

	private void Update() { }

}

