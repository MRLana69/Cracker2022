//Type is in global namespace

public class playThruster : MonoBehaviour
{
	private sealed class <>c__DisplayClass22_0
	{
		public float offset; //Field offset: 0x8
		public playThruster <>4__this; //Field offset: 0xC

		public <>c__DisplayClass22_0() { }

		internal void <PlayEffects>b__1(float t) { }

	}

	public enum JumpStyle
	{
		Super = 0,
		Double = 1,
	}

	private Hoverboard _hoverboard; //Field offset: 0xC
	private Renderer[] _renderes; //Field offset: 0x10
	private AnimationClip _clip; //Field offset: 0x14
	private ParticleSystem _particles; //Field offset: 0x18
	private float thrusterPlayTime; //Field offset: 0x1C
	private JumpStyle _jumpStyle; //Field offset: 0x20
	private AnimationState[] _states; //Field offset: 0x24
	private Character _character; //Field offset: 0x28
	private HoverboardModelPreviewFactory _factory; //Field offset: 0x2C
	private bool addedEvent; //Field offset: 0x30
	private bool addedMenuEvent; //Field offset: 0x31

	public JumpStyle jumpStyle
	{
		 get { } //Length: 667
	}

	public playThruster() { }

	private void <PlayEffects>b__22_0(float t) { }

	private void Character_OnDoubleJump() { }

	private void Character_OnJump(float jumpHeight, bool willPlaySound) { }

	private void Factory_OnJump() { }

	public JumpStyle get_jumpStyle() { }

	public void Initialize() { }

	public void InitializeMenu(HoverboardModelPreviewFactory factory) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void PlayEffects(bool playParticleEffect = true) { }

}

