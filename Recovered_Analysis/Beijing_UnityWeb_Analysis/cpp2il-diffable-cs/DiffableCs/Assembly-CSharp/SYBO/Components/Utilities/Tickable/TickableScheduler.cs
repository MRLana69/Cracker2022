namespace SYBO.Components.Utilities.Tickable;

public class TickableScheduler
{
	public const float TargetEditTimeFPS = 60; //Field offset: 0x0
	public TickableEvent OnRegisteredTickablesChanged; //Field offset: 0x10
	private List<ITickable> _registeredTickables; //Field offset: 0x14
	private bool _isApplicationPaused; //Field offset: 0x18
	private bool _isApplicationFocused; //Field offset: 0x19
	private DelayedTickTimer _editTimeDelayedTickTimer; //Field offset: 0x1C

	public bool IsPaused
	{
		 get { } //Length: 39
		 set { } //Length: 145
	}

	public int RegisteredTickablesCount
	{
		 get { } //Length: 9
	}

	public TickableScheduler() { }

	public bool get_IsPaused() { }

	public int get_RegisteredTickablesCount() { }

	public bool HasRegisteredTickable(ITickable tickable) { }

	public void Initialize() { }

	protected void OnApplicationFocus(bool hasFocus) { }

	protected void OnApplicationPause(bool isPaused) { }

	protected override void OnDestroy() { }

	private void OnDisable() { }

	protected void OnEnable() { }

	public void RegisterTickable(ITickable tickable) { }

	public void set_IsPaused(bool value) { }

	public void Tick(float deltaTime) { }

	private void UnregisterAllTickables() { }

	public void UnregisterTickable(ITickable tickable) { }

	protected void Update() { }

}

