//Type is in global namespace

public class CharacterScreenController : MonoBehaviour
{
	private float _shadowFadeFactor; //Field offset: 0xC
	private float _characterFadeFactor; //Field offset: 0x10
	private AnimationClip _idleClip; //Field offset: 0x14
	public float _freeze; //Field offset: 0x18
	public bool _freezing; //Field offset: 0x1C
	public bool _defreezing; //Field offset: 0x1D
	private bool _wasFreezing; //Field offset: 0x1E
	private bool _wasDefreezing; //Field offset: 0x1F
	private Animation _animation; //Field offset: 0x20
	public AnimationState _idleState; //Field offset: 0x24
	private Renderer[] _renderers; //Field offset: 0x28
	private List<Material> _materials; //Field offset: 0x2C
	private Material _shadowMaterial; //Field offset: 0x30
	private AvatarEyeAnimation _avatarEyeAnimation; //Field offset: 0x34
	private Color _overlayColor; //Field offset: 0x38

	public float Freeze
	{
		 set { } //Length: 64
	}

	public CharacterScreenController() { }

	public void Initialize(AnimationClip idleClip, Shader characterShader, Shader outfitShader, float characterFadeFactor, float shadowFadeFactor) { }

	private void OnDestroy() { }

	public void set_Freeze(float value) { }

	private void SetFreeze(float freeze) { }

}

