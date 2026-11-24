//Type is in global namespace

public class DayHelper : MonoBehaviour
{
	public enum DayType
	{
		NotSet = 0,
		Regular = 1,
		LastDay = 2,
	}

	private DayType _dayType; //Field offset: 0xC
	private UILabel _dayLabel; //Field offset: 0x10
	private UILabel _rewardLabel; //Field offset: 0x14
	private UILabel _checkBackLabel; //Field offset: 0x18
	private UISprite _checkMark; //Field offset: 0x1C
	private UISprite _divider; //Field offset: 0x20
	private UISprite _backgroundInactive; //Field offset: 0x24
	private UISprite _backgroundActive; //Field offset: 0x28
	private UISprite _checkbackBackground; //Field offset: 0x2C
	private UISprite[] _gradientEffectSprites; //Field offset: 0x30
	private UISprite _glowEffect; //Field offset: 0x34
	private bool _forceActive; //Field offset: 0x38
	private bool _unlockColors; //Field offset: 0x39
	private Color32 _inactiveDayColor; //Field offset: 0x3C
	private Color32 _activeDayColor; //Field offset: 0x40
	private Color32 _inactiveDayShadowColor; //Field offset: 0x44
	private Color32 _activeDayShadowColor; //Field offset: 0x48
	private Color32 _inactiveRewardColor; //Field offset: 0x4C
	private Color32 _activeRewardColor; //Field offset: 0x50
	private Color32 _inactiveRewardShadowColor; //Field offset: 0x54
	private Color32 _activeRewardShadowColor; //Field offset: 0x58
	private Color32 _inactiveLastDayDayColor; //Field offset: 0x5C
	private Color32 _activeLastDayDayColor; //Field offset: 0x60
	private Color32 _inactiveLastDayDayShadowColor; //Field offset: 0x64
	private Color32 _activeLastDayDayShadowColor; //Field offset: 0x68
	private Color32 _inactiveLastDayRewardShadowColor; //Field offset: 0x6C
	private Color32 _activeLastDayRewardShadowColor; //Field offset: 0x70
	private Color32 _activeLastDayBackgroundColor; //Field offset: 0x74
	private Color32 _inactiveLastDayBackgroundColor; //Field offset: 0x78
	private Color32 _activeLastDayGradientColor; //Field offset: 0x7C
	private Color32 _inactiveLastDayGradientColor; //Field offset: 0x80
	private Color32 _activeLastDayGlow; //Field offset: 0x84
	private Color32 _inactiveLastDayGlow; //Field offset: 0x88
	private int _dayIndex; //Field offset: 0x8C

	public DayHelper() { }

	public void Init(int dayIndex) { }

	public void RefreshDay() { }

}

