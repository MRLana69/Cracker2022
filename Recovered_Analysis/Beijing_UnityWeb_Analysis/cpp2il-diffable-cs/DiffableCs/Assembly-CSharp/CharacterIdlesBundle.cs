//Type is in global namespace

public class CharacterIdlesBundle : MonoBehaviour
{
	private class OutfitIdleAnimations
	{
		private string OutfitIdentifier; //Field offset: 0x8
		public int OutfitIndex; //Field offset: 0xC
		public AnimationClip StartClip; //Field offset: 0x10
		public List<AnimationClip> Idles; //Field offset: 0x14

		public OutfitIdleAnimations() { }

	}

	public AnimationClip StartClip; //Field offset: 0xC
	public List<AnimationClip> Idles; //Field offset: 0x10
	public List<AnimationClip> ExcludedCelebrationIdles; //Field offset: 0x14
	public List<AnimationClip> ExcludedGameOverIdles; //Field offset: 0x18
	private List<OutfitIdleAnimations> _outfitIdles; //Field offset: 0x1C

	public CharacterIdlesBundle() { }

	public List<AnimationClip> GetOutfitIdles(int outfitIndex) { }

	public AnimationClip GetOutfitStartClip(int outfitIndex) { }

}

