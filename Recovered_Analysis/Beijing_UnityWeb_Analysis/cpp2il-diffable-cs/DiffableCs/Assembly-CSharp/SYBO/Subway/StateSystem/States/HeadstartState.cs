namespace SYBO.Subway.StateSystem.States;

public class HeadstartState : FlyingState
{
	private sealed class <>c__DisplayClass28_0
	{
		public HeadstartState <>4__this; //Field offset: 0x8
		public float fov_start; //Field offset: 0xC
		public float fov_end; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal void <SetFOV>b__0(float t) { }

	}

	private sealed class <>c__DisplayClass29_0
	{
		public HeadstartState <>4__this; //Field offset: 0x8
		public float fov_start; //Field offset: 0xC
		public float fov_end; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal void <RevertFOV>b__0(float t) { }

	}

	private const float ChangeHeightSpeed = 50; //Field offset: 0x0
	private HeadstartStateSettings _settings; //Field offset: 0x78
	public Action OnActivateTurboHeadstart; //Field offset: 0x7C
	public Action OnDeactivateTurboHeadstart; //Field offset: 0x80
	public Action OnHidTurboHeadstartButtons; //Field offset: 0x84
	private GameObject[] _pickupSpawnPointPrefabInstances; //Field offset: 0x88
	private bool _activateTurboHeadstart; //Field offset: 0x8C
	private bool _deactivateTurboHeadstart; //Field offset: 0x8D
	private int _turboHeadstart; //Field offset: 0x90

	public int TurboHeadstart
	{
		 get { } //Length: 3
	}

	protected override UpgradeType UpgradeType
	{
		 get { } //Length: 9
	}

	public HeadstartState(int id) { }

	public void ActivateLongHeadstart() { }

	public override void Enter(State fromState) { }

	private void ExtraHeadstart() { }

	public int get_TurboHeadstart() { }

	protected override UpgradeType get_UpgradeType() { }

	protected override float GetFlyHeight() { }

	private float GetFlyHeightFromHeadstart() { }

	protected override float GetFlyingSpeed() { }

	private void InitializePickups() { }

	public override void Leave(State toState) { }

	private void PlacePickups(float gamePositionZ) { }

	private void ResetPickups() { }

	public void ResetTurboHeadstart() { }

	private void RevertFOV() { }

	private void SetActivePickupSpawnPointPrefabInstance(int i, bool isActive) { }

	private void SetFOV() { }

	protected override void UpdateFlying(float remainingRatio) { }

	private void UpdateHeadstart(HeadstartTier tier) { }

}

