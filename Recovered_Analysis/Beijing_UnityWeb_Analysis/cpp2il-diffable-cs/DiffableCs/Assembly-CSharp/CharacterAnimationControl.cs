//Type is in global namespace

public class CharacterAnimationControl : MonoBehaviour
{
	private AnimationClip _runAnimation; //Field offset: 0xC
	private AnimationClip[] _alternateRunAnimations; //Field offset: 0x10
	private Animation _animationComponent; //Field offset: 0x14
	private AnimationClip _currentAnimation; //Field offset: 0x18

	public AnimationClip[] AlternateRunAnimations
	{
		 get { } //Length: 6
	}

	public CharacterAnimationControl() { }

	public AnimationClip[] get_AlternateRunAnimations() { }

	public void Play() { }

	public void Speed(float speed) { }

}

