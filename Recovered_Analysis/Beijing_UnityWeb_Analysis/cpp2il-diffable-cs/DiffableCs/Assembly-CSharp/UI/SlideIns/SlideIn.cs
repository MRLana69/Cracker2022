namespace UI.SlideIns;

public class SlideIn
{
	public SlideInType type; //Field offset: 0x8
	public string stringValue; //Field offset: 0xC
	public AwardTierType awardTierType; //Field offset: 0x10
	public FacebookSlideInState facebookState; //Field offset: 0x14
	public Action onDidShowCallback; //Field offset: 0x18
	public int value; //Field offset: 0x1C
	public Type mysteryBoxType; //Field offset: 0x20
	public CloudSaveState cloudSaveState; //Field offset: 0x24
	public SellableConsumable consumableReward; //Field offset: 0x28

	public SlideIn() { }

}

