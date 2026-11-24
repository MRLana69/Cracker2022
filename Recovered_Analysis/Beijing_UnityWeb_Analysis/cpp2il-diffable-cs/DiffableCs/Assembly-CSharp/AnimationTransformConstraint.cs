//Type is in global namespace

public class AnimationTransformConstraint : MonoBehaviour
{
	private class ConstraintRange
	{
		public int StartKeyframe; //Field offset: 0x8
		public int EndKeyframe; //Field offset: 0xC

		public ConstraintRange() { }

	}

	private string _animationName; //Field offset: 0xC
	private ConstraintRange _range; //Field offset: 0x10
	private string _targetTransformName; //Field offset: 0x14
	private Animation _animation; //Field offset: 0x18
	private Transform _targetTransform; //Field offset: 0x1C

	public AnimationTransformConstraint() { }

	private Animation FindAnimationInParent(Transform current) { }

	private void LateUpdate() { }

	private void Start() { }

}

