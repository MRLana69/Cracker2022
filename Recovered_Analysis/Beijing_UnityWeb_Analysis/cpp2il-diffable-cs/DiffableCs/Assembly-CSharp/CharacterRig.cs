//Type is in global namespace

public class CharacterRig : MonoBehaviour
{
	private string modelName; //Field offset: 0xC
	private string outfitModelName; //Field offset: 0x10
	private string headModelName; //Field offset: 0x14
	private string meshSuperSneakerName; //Field offset: 0x18
	private string doubleJumpersName; //Field offset: 0x1C
	private string rocketSkatesName; //Field offset: 0x20
	private string spineTransformName; //Field offset: 0x24
	private string rightShoulderTransformName; //Field offset: 0x28
	private string attachPoint1Name; //Field offset: 0x2C
	private string attachPoint2Name; //Field offset: 0x30
	private string attachPoint3Name; //Field offset: 0x34
	private string attachPoint4Name; //Field offset: 0x38
	private string attachPoint5Name; //Field offset: 0x3C
	private string attachPoint6Name; //Field offset: 0x40
	private string attachPoint7Name; //Field offset: 0x44
	private string attachPoint8Name; //Field offset: 0x48
	private string attachPoint9Name; //Field offset: 0x4C
	private string hipName; //Field offset: 0x50
	private string leftFootName; //Field offset: 0x54
	private string rightFootName; //Field offset: 0x58
	private string headJointName; //Field offset: 0x5C
	private string rightHandName; //Field offset: 0x60
	private string eyeFocusPointOriginName; //Field offset: 0x64
	private string eyeFocusPointTargetName; //Field offset: 0x68
	private string eyeSwitchName; //Field offset: 0x6C
	private string blendShapeControllerName; //Field offset: 0x70
	private Material powerupMaterial; //Field offset: 0x74
	private Animation characterAnimation; //Field offset: 0x78
	private AvatarAnimations avatarAnimations; //Field offset: 0x7C
	private CharacterCustomization characterCustomization; //Field offset: 0x80
	private SkinnedMeshRenderer model; //Field offset: 0x84
	private SkinnedMeshRenderer outfitModel; //Field offset: 0x88
	private SkinnedMeshRenderer headModel; //Field offset: 0x8C
	private SkinnedMeshRenderer meshSuperSneaker; //Field offset: 0x90
	private SkinnedMeshRenderer doubleJumpers; //Field offset: 0x94
	private SkinnedMeshRenderer rocketSkates; //Field offset: 0x98
	private Transform spineTransform; //Field offset: 0x9C
	private Transform rightShoulderTransform; //Field offset: 0xA0
	private Transform attachPoint1; //Field offset: 0xA4
	private Transform attachPoint2; //Field offset: 0xA8
	private Transform attachPoint3; //Field offset: 0xAC
	private Transform attachPoint4; //Field offset: 0xB0
	private Transform attachPoint5; //Field offset: 0xB4
	private Transform attachPoint6; //Field offset: 0xB8
	private Transform attachPoint7; //Field offset: 0xBC
	private Transform attachPoint8; //Field offset: 0xC0
	private Transform attachPoint9; //Field offset: 0xC4
	private Transform hip; //Field offset: 0xC8
	private Transform leftFoot; //Field offset: 0xCC
	private Transform rightFoot; //Field offset: 0xD0
	private Transform headJoint; //Field offset: 0xD4
	private Transform rightHand; //Field offset: 0xD8
	private Transform eyeFocusTarget; //Field offset: 0xDC
	private Transform eyeFocusOrigin; //Field offset: 0xE0
	private Transform eyeSwitch; //Field offset: 0xE4
	private Transform blendShapeController; //Field offset: 0xE8

	public Transform AttachPoint1
	{
		 get { } //Length: 7
	}

	public Transform AttachPoint2
	{
		 get { } //Length: 7
	}

	public Transform AttachPoint3
	{
		 get { } //Length: 7
	}

	public Transform AttachPoint4
	{
		 get { } //Length: 7
	}

	public Transform AttachPoint5
	{
		 get { } //Length: 7
	}

	public Transform AttachPoint6
	{
		 get { } //Length: 7
	}

	public Transform AttachPoint7
	{
		 get { } //Length: 7
	}

	public Transform AttachPoint8
	{
		 get { } //Length: 7
	}

	public Transform AttachPoint9
	{
		 get { } //Length: 7
	}

	public AvatarAnimations AvatarAnimations
	{
		 get { } //Length: 6
	}

	public Transform BlendShapeController
	{
		 get { } //Length: 7
	}

	public Animation CharacterAnimation
	{
		 get { } //Length: 6
	}

	public CharacterCustomization CharacterCustomization
	{
		 get { } //Length: 6
	}

	public SkinnedMeshRenderer DoubleJumpers
	{
		 get { } //Length: 7
	}

	public Transform EyeFocusOrigin
	{
		 get { } //Length: 7
	}

	public Transform EyeFocusTarget
	{
		 get { } //Length: 7
	}

	public Transform EyeSwitch
	{
		 get { } //Length: 7
	}

	public Transform HeadJoint
	{
		 get { } //Length: 7
	}

	public SkinnedMeshRenderer HeadModel
	{
		 get { } //Length: 7
	}

	public Transform Hip
	{
		 get { } //Length: 7
	}

	public Transform LeftFoot
	{
		 get { } //Length: 7
	}

	public SkinnedMeshRenderer MeshSuperSneaker
	{
		 get { } //Length: 7
	}

	public SkinnedMeshRenderer Model
	{
		 get { } //Length: 7
	}

	public SkinnedMeshRenderer OutfitModel
	{
		 get { } //Length: 7
	}

	public Transform RightFoot
	{
		 get { } //Length: 7
	}

	public Transform RightHand
	{
		 get { } //Length: 7
	}

	public SkinnedMeshRenderer RocketSkates
	{
		 get { } //Length: 7
	}

	public Transform ShoulderTransform
	{
		 get { } //Length: 7
	}

	public Transform SpineTransform
	{
		 get { } //Length: 7
	}

	public CharacterRig() { }

	private void Awake() { }

	public Transform get_AttachPoint1() { }

	public Transform get_AttachPoint2() { }

	public Transform get_AttachPoint3() { }

	public Transform get_AttachPoint4() { }

	public Transform get_AttachPoint5() { }

	public Transform get_AttachPoint6() { }

	public Transform get_AttachPoint7() { }

	public Transform get_AttachPoint8() { }

	public Transform get_AttachPoint9() { }

	public AvatarAnimations get_AvatarAnimations() { }

	public Transform get_BlendShapeController() { }

	public Animation get_CharacterAnimation() { }

	public CharacterCustomization get_CharacterCustomization() { }

	public SkinnedMeshRenderer get_DoubleJumpers() { }

	public Transform get_EyeFocusOrigin() { }

	public Transform get_EyeFocusTarget() { }

	public Transform get_EyeSwitch() { }

	public Transform get_HeadJoint() { }

	public SkinnedMeshRenderer get_HeadModel() { }

	public Transform get_Hip() { }

	public Transform get_LeftFoot() { }

	public SkinnedMeshRenderer get_MeshSuperSneaker() { }

	public SkinnedMeshRenderer get_Model() { }

	public SkinnedMeshRenderer get_OutfitModel() { }

	public Transform get_RightFoot() { }

	public Transform get_RightHand() { }

	public SkinnedMeshRenderer get_RocketSkates() { }

	public Transform get_ShoulderTransform() { }

	public Transform get_SpineTransform() { }

}

