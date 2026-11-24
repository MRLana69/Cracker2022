//Type is in global namespace

public class CharacterAssetsBundle : MonoBehaviour
{
	private class OutfitBreathAnimation
	{
		private string OutfitIdentifier; //Field offset: 0x8
		public int OutfitIndex; //Field offset: 0xC
		public AnimationClip Breath; //Field offset: 0x10

		public OutfitBreathAnimation() { }

	}

	public Mesh MainMesh; //Field offset: 0xC
	public Mesh HeadMesh; //Field offset: 0x10
	public int EyeMaterialID; //Field offset: 0x14
	public bool AnimatedEyesHaveDoubleMaterial; //Field offset: 0x18
	public AvatarEyeAnimation _avatarEyeAnimation; //Field offset: 0x1C
	public AnimationClip Breath; //Field offset: 0x20
	public AnimationClip ScrollbarPose; //Field offset: 0x24
	public AnimationClip ScrollbarHeadPose; //Field offset: 0x28
	public AnimationClip EventScreenPose; //Field offset: 0x2C
	public AnimationClip NameEventScreenIdle; //Field offset: 0x30
	public bool UseCustomEventScreenIdle; //Field offset: 0x34
	private List<OutfitBreathAnimation> _outfitBreathAnimations; //Field offset: 0x38

	public CharacterAssetsBundle() { }

	public AnimationClip GetOutfitBreatheOrNull(int outfitIndex) { }

}

