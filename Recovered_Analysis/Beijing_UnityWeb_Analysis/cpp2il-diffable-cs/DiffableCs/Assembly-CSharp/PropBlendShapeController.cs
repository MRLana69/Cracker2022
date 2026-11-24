//Type is in global namespace

public class PropBlendShapeController : MonoBehaviour
{
	private class BlendShapeLink
	{
		public int BlendShapeIndex; //Field offset: 0x8
		public int BlendShapeControllerIndex; //Field offset: 0xC

		public BlendShapeLink() { }

	}

	private BlendShapeLink[] _blendShapeLinks; //Field offset: 0xC
	private SkinnedMeshRenderer _renderer; //Field offset: 0x10
	private AvatarAnimations _avatarAnimations; //Field offset: 0x14

	public PropBlendShapeController() { }

	private AvatarAnimations GetAvatarAnimationsInAncestors(Transform transform) { }

	private void Start() { }

	private void Update() { }

}

