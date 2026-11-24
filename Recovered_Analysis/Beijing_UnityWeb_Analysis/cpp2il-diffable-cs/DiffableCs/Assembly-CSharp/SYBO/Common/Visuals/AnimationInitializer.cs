namespace SYBO.Common.Visuals;

public class AnimationInitializer : MonoBehaviour
{
	public struct Config
	{
		public float StartTimeMin; //Field offset: 0x0
		public float StartTimeMax; //Field offset: 0x4

	}

	private Config _config; //Field offset: 0xC
	private Animation _animation; //Field offset: 0x14
	private bool _initialized; //Field offset: 0x18

	public AnimationInitializer() { }

	public Config ClampToDefaultAnimationLength(Config config, bool validating = false) { }

	private void Initialize() { }

	public void InitializeAnimation(Config config) { }

	private void OnEnable() { }

	private void OnValidate() { }

}

