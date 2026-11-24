//Type is in global namespace

public class SpecialAssetAttachment : CharacterCustomizationProp
{
	public enum AttachmentPoint
	{
		LeftHand = 0,
		RightHand = 1,
		Head = 2,
		AttachmentPoint1 = 3,
		AttachmentPoint2 = 4,
		AttachmentPoint3 = 5,
		AttachmentPoint4 = 6,
		AttachmentPoint5 = 7,
		AttachmentPoint6 = 8,
		AttachmentPoint7 = 9,
		AttachmentPoint8 = 10,
		AttachmentPoint9 = 11,
	}

	private AttachmentPoint attachmentPoint; //Field offset: 0xC

	public SpecialAssetAttachment() { }

	public override void Initialize(CharacterRig characterRig, bool alternateSetup) { }

}

