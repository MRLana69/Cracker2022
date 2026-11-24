//Type is in global namespace

public class HoverboardRendering : MonoBehaviour
{
	public class AbilityAnimationList
	{
		public BoardAbility ability; //Field offset: 0x8
		public bool prio; //Field offset: 0xC
		public AnimationClip defaultHoverboardAnimation; //Field offset: 0x10
		public AnimationPair[] runAnimations; //Field offset: 0x14
		public AnimationPair[] landAnimations; //Field offset: 0x18
		public AnimationPair[] jumpAnimations; //Field offset: 0x1C
		public AnimationPair[] hangtimeAnimations; //Field offset: 0x20
		public AnimationPair[] rollAnimations; //Field offset: 0x24
		public AnimationPair[] dodgeLeftAnimations; //Field offset: 0x28
		public AnimationPair[] dodgeRightAnimations; //Field offset: 0x2C
		public AnimationPair[] grindAnimations; //Field offset: 0x30
		public AnimationPair[] grindLandAnimations; //Field offset: 0x34
		public AnimationPair[] getOnBoardAnimations; //Field offset: 0x38

		public AbilityAnimationList() { }

	}

	public class AnimationPair
	{
		public AnimationClip characterAnimationClip; //Field offset: 0x8
		public AnimationClip hoverboardAnimationClip; //Field offset: 0xC

		public AnimationPair() { }

	}

	public class AnimationStringPair
	{
		public string characterAnimation; //Field offset: 0x8
		public string hoverboardAnimation; //Field offset: 0xC

		public AnimationStringPair() { }

	}

	public AnimationClip defaultHoverboardAnimation; //Field offset: 0xC
	public AnimationPair[] runAnimations; //Field offset: 0x10
	public AnimationPair[] landAnimations; //Field offset: 0x14
	public AnimationPair[] jumpAnimations; //Field offset: 0x18
	public AnimationPair[] hangtimeAnimations; //Field offset: 0x1C
	public AnimationPair[] rollAnimations; //Field offset: 0x20
	public AnimationPair[] dodgeLeftAnimations; //Field offset: 0x24
	public AnimationPair[] dodgeRightAnimations; //Field offset: 0x28
	public AnimationPair[] grindAnimations; //Field offset: 0x2C
	public AnimationPair[] grindLandAnimations; //Field offset: 0x30
	public AnimationPair[] getOnBoardAnimations; //Field offset: 0x34
	public AbilityAnimationList[] abilityAnimationLists; //Field offset: 0x38
	private bool hasInitializedAnimationSounds; //Field offset: 0x3C

	public HoverboardRendering() { }

	private void AddClipsToAnimationComp(Animation animation, AnimationClip clip, List<AnimationClip> addedClipsList) { }

	private List<string> GetNamesAddAnimationClips(AnimationPair[] abilityPairs, AnimationPair[] pairs, Animation avaterAnimation, Animation hoverboardAnimation, List<AnimationClip> addedClipsList) { }

	public void Initialize(Animation avatarAnimation, Animation hoverboardAnimation, AbilityAnimationList defaultAbilityAnimationLists, List<AnimationClip> addedClipsList, BoardAbility[] abilities) { }

}

