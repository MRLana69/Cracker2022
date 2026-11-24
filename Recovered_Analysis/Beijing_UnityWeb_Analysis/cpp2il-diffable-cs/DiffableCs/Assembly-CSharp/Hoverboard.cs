//Type is in global namespace

public class Hoverboard : CharacterModifier
{
	private sealed class <Begin>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Hoverboard <>4__this; //Field offset: 0x10
		private HoverboardBundle <newBoard>5__2; //Field offset: 0x14
		private float <timeLeft>5__3; //Field offset: 0x18
		private float <newCoolDownDist>5__4; //Field offset: 0x1C
		private float <distanceLeft>5__5; //Field offset: 0x20
		private bool <didStopCooldown>5__6; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1721
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Begin>d__84(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum BoardAbility
	{
		None = 0,
		Jumper = 1,
		Lowrider = 2,
		HighSpeed = 3,
		Speed = 4,
		DoubleJump = 5,
		Glider = 6,
		Teleport = 7,
		Vanity = 8,
	}

	public delegate OnEndHoverboardDelegate
	{

		public OnEndHoverboardDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnHoverboardJumpDelegate
	{

		public OnHoverboardJumpDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnRunDelegate
	{

		public OnRunDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnSpeedEndDelegate
	{

		public OnSpeedEndDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnSpeedStartDelegate
	{

		public OnSpeedStartDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnSwitchToHoverboardDelegate
	{

		public OnSwitchToHoverboardDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(HoverboardBundle hoverbooardBundle, BoardAbility[] abilities, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(HoverboardBundle hoverbooardBundle, BoardAbility[] abilities) { }

	}

	private static Hoverboard instance; //Field offset: 0x0
	private bool isJumper; //Field offset: 0x20
	private bool isLowrider; //Field offset: 0x21
	private bool isHighSpeedBoard; //Field offset: 0x22
	private bool isSpeedBoard; //Field offset: 0x23
	private bool isGlider; //Field offset: 0x24
	private bool isVTol; //Field offset: 0x25
	private bool isTeleporter; //Field offset: 0x26
	private bool isDoubleJump; //Field offset: 0x27
	private bool isVanity; //Field offset: 0x28
	public GameObject currentHoverboard; //Field offset: 0x2C
	public AudioClipInfo powerDownSound; //Field offset: 0x30
	public float cooldownDstance; //Field offset: 0x34
	public float slowMotionDistance; //Field offset: 0x38
	public float slowDownToScale; //Field offset: 0x3C
	private GameObject hoverboardRoot; //Field offset: 0x40
	public float WaitForParticlesDelay; //Field offset: 0x44
	public float RemoveObstaclesDistance; //Field offset: 0x48
	private LongMagnet longMagnet; //Field offset: 0x4C
	private Character character; //Field offset: 0x50
	public bool isActive; //Field offset: 0x54
	public bool _isInCooldown; //Field offset: 0x55
	private bool __isAllowed; //Field offset: 0x56
	private bool _isARewardFromMysteryPowerup; //Field offset: 0x57
	public AudioClipInfo CrashSound; //Field offset: 0x58
	public AudioClipInfo StartSound; //Field offset: 0x5C
	private BoardId _currentRandomBoard; //Field offset: 0x60
	private OnSwitchToHoverboardDelegate OnSwitchToHoverboard; //Field offset: 0x64
	private OnEndHoverboardDelegate OnEndHoverboard; //Field offset: 0x68
	private OnHoverboardJumpDelegate OnJump; //Field offset: 0x6C
	private OnRunDelegate OnRun; //Field offset: 0x70
	private OnSpeedStartDelegate OnSpeedStart; //Field offset: 0x74
	private OnSpeedEndDelegate OnSpeedEnd; //Field offset: 0x78

	public event OnEndHoverboardDelegate OnEndHoverboard
	{
		 add { } //Length: 112
		 remove { } //Length: 112
	}

	public event OnHoverboardJumpDelegate OnJump
	{
		 add { } //Length: 112
		 remove { } //Length: 112
	}

	public event OnRunDelegate OnRun
	{
		 add { } //Length: 112
		 remove { } //Length: 112
	}

	public event OnSpeedEndDelegate OnSpeedEnd
	{
		 add { } //Length: 112
		 remove { } //Length: 112
	}

	public event OnSpeedStartDelegate OnSpeedStart
	{
		 add { } //Length: 112
		 remove { } //Length: 112
	}

	public event OnSwitchToHoverboardDelegate OnSwitchToHoverboard
	{
		 add { } //Length: 11
		 remove { } //Length: 112
	}

	public static Hoverboard Instance
	{
		 get { } //Length: 52
	}

	public bool IsAllowed
	{
		 get { } //Length: 9
		 set { } //Length: 261
	}

	public bool IsARewardFromMysteryPowerup
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool IsDoubleJump
	{
		 get { } //Length: 9
	}

	public bool IsGlider
	{
		 get { } //Length: 9
	}

	public bool IsHighSpeedBoard
	{
		 get { } //Length: 9
	}

	public bool IsInCooldown
	{
		 get { } //Length: 9
	}

	public bool IsJumper
	{
		 get { } //Length: 66
	}

	public bool IsLowrider
	{
		 get { } //Length: 9
	}

	public bool IsSpeedBoard
	{
		 get { } //Length: 9
	}

	public bool IsTeleporter
	{
		 get { } //Length: 9
	}

	public bool IsVanity
	{
		 get { } //Length: 9
	}

	public bool IsVTol
	{
		 get { } //Length: 9
	}

	public override bool ShouldPauseInAlternateRoutes
	{
		 get { } //Length: 3
	}

	public override bool ShouldPauseInJetpack
	{
		 get { } //Length: 66
	}

	private static Hoverboard() { }

	public Hoverboard() { }

	public void add_OnEndHoverboard(OnEndHoverboardDelegate value) { }

	public void add_OnJump(OnHoverboardJumpDelegate value) { }

	public void add_OnRun(OnRunDelegate value) { }

	public void add_OnSpeedEnd(OnSpeedEndDelegate value) { }

	public void add_OnSpeedStart(OnSpeedStartDelegate value) { }

	public void add_OnSwitchToHoverboard(OnSwitchToHoverboardDelegate value) { }

	public void Awake() { }

	public override IEnumerator Begin() { }

	public override void ExpireSoon() { }

	private void FinishRandomBoard() { }

	private void Game_OnCharacterModelRecreated() { }

	public static Hoverboard get_Instance() { }

	public bool get_IsAllowed() { }

	public bool get_IsARewardFromMysteryPowerup() { }

	public bool get_IsDoubleJump() { }

	public bool get_IsGlider() { }

	public bool get_IsHighSpeedBoard() { }

	public bool get_IsInCooldown() { }

	public bool get_IsJumper() { }

	public bool get_IsLowrider() { }

	public bool get_IsSpeedBoard() { }

	public bool get_IsTeleporter() { }

	public bool get_IsVanity() { }

	public bool get_IsVTol() { }

	public override bool get_ShouldPauseInAlternateRoutes() { }

	public override bool get_ShouldPauseInJetpack() { }

	public void HardReset() { }

	public void intialize() { }

	public override void Pause() { }

	public void PlayCrashSound() { }

	private void RaiseOnEndHoverboard() { }

	public void remove_OnEndHoverboard(OnEndHoverboardDelegate value) { }

	public void remove_OnJump(OnHoverboardJumpDelegate value) { }

	public void remove_OnRun(OnRunDelegate value) { }

	public void remove_OnSpeedEnd(OnSpeedEndDelegate value) { }

	public void remove_OnSpeedStart(OnSpeedStartDelegate value) { }

	public void remove_OnSwitchToHoverboard(OnSwitchToHoverboardDelegate value) { }

	public override void Reset() { }

	public void ResetBoardAndAbilitys() { }

	public override void Resume() { }

	public void set_IsAllowed(bool value) { }

	public void set_IsARewardFromMysteryPowerup(bool value) { }

	public void SetupAbilitiesAndVisuals(HoverboardBundle hoverboardBundle) { }

}

