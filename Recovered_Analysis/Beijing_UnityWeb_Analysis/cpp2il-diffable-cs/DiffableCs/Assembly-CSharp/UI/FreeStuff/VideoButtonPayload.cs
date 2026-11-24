namespace UI.FreeStuff;

public class VideoButtonPayload
{
	private string <iconBackgroundName>k__BackingField; //Field offset: 0x8
	private string <iconName>k__BackingField; //Field offset: 0xC
	private Action <onVideoWatched>k__BackingField; //Field offset: 0x10
	private Func<bool> <isAvailable>k__BackingField; //Field offset: 0x14
	private Func<int> <getRewardAmount>k__BackingField; //Field offset: 0x18
	private string <title>k__BackingField; //Field offset: 0x1C
	private string <description>k__BackingField; //Field offset: 0x20
	private AdLocationInfo <adLocation>k__BackingField; //Field offset: 0x24
	private CelebrationRewardType <rewardType>k__BackingField; //Field offset: 0x28
	private UpgradeType <upgradeType>k__BackingField; //Field offset: 0x2C
	private UnlockItemSource <unlockItemSource>k__BackingField; //Field offset: 0x30
	private Color32 <firstColor>k__BackingField; //Field offset: 0x34
	private Color32 <firstColorDark>k__BackingField; //Field offset: 0x38
	private Color32 <firstHighlightColor>k__BackingField; //Field offset: 0x3C
	private Color32 <secondColor>k__BackingField; //Field offset: 0x40
	private Color32 <secondColorDark>k__BackingField; //Field offset: 0x44
	private Color32 <secondHighlightColor>k__BackingField; //Field offset: 0x48
	private Color32 <titleColor>k__BackingField; //Field offset: 0x4C
	private Color32 <descriptionColor>k__BackingField; //Field offset: 0x50
	private string <flurryName>k__BackingField; //Field offset: 0x54

	public AdLocationInfo adLocation
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string description
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Color32 descriptionColor
	{
		 get { } //Length: 51
		 set { } //Length: 11
	}

	public Color32 firstColor
	{
		 get { } //Length: 8
		 set { } //Length: 11
	}

	public Color32 firstColorDark
	{
		 get { } //Length: 51
		 set { } //Length: 11
	}

	public Color32 firstHighlightColor
	{
		 get { } //Length: 51
		 set { } //Length: 11
	}

	public string flurryName
	{
		 get { } //Length: 6
		 set { } //Length: 51
	}

	public Func<int> getRewardAmount
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string iconBackgroundName
	{
		 get { } //Length: 66
		 set { } //Length: 304
	}

	public string iconName
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Func<bool> isAvailable
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Action onVideoWatched
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public CelebrationRewardType rewardType
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Color32 secondColor
	{
		 get { } //Length: 51
		 set { } //Length: 14
	}

	public Color32 secondColorDark
	{
		 get { } //Length: 54
		 set { } //Length: 11
	}

	public Color32 secondHighlightColor
	{
		 get { } //Length: 51
		 set { } //Length: 11
	}

	public string title
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Color32 titleColor
	{
		 get { } //Length: 51
		 set { } //Length: 11
	}

	public UnlockItemSource unlockItemSource
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public UpgradeType upgradeType
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public VideoButtonPayload() { }

	public AdLocationInfo get_adLocation() { }

	public string get_description() { }

	public Color32 get_descriptionColor() { }

	public Color32 get_firstColor() { }

	public Color32 get_firstColorDark() { }

	public Color32 get_firstHighlightColor() { }

	public string get_flurryName() { }

	public Func<int> get_getRewardAmount() { }

	public string get_iconBackgroundName() { }

	public string get_iconName() { }

	public Func<bool> get_isAvailable() { }

	public Action get_onVideoWatched() { }

	public CelebrationRewardType get_rewardType() { }

	public Color32 get_secondColor() { }

	public Color32 get_secondColorDark() { }

	public Color32 get_secondHighlightColor() { }

	public string get_title() { }

	public Color32 get_titleColor() { }

	public UnlockItemSource get_unlockItemSource() { }

	public UpgradeType get_upgradeType() { }

	public void set_adLocation(AdLocationInfo value) { }

	public void set_description(string value) { }

	public void set_descriptionColor(Color32 value) { }

	public void set_firstColor(Color32 value) { }

	public void set_firstColorDark(Color32 value) { }

	public void set_firstHighlightColor(Color32 value) { }

	public void set_flurryName(string value) { }

	public void set_getRewardAmount(Func<int> value) { }

	public void set_iconBackgroundName(string value) { }

	public void set_iconName(string value) { }

	public void set_isAvailable(Func<bool> value) { }

	public void set_onVideoWatched(Action value) { }

	public void set_rewardType(CelebrationRewardType value) { }

	public void set_secondColor(Color32 value) { }

	public void set_secondColorDark(Color32 value) { }

	public void set_secondHighlightColor(Color32 value) { }

	public void set_title(string value) { }

	public void set_titleColor(Color32 value) { }

	public void set_unlockItemSource(UnlockItemSource value) { }

	public void set_upgradeType(UpgradeType value) { }

}

