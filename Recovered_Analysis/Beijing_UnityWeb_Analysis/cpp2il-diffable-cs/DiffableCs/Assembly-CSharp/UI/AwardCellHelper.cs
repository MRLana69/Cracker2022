namespace UI;

public class AwardCellHelper : MonoBehaviour
{
	private sealed class <AnimateChangingOfTierSprite>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UISprite effectSprite; //Field offset: 0x10
		public AwardTierHelper tierIconToChange; //Field offset: 0x14
		public AwardCellHelper <>4__this; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 818
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateChangingOfTierSprite>d__91(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateEffectColor>d__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AwardCellHelper <>4__this; //Field offset: 0x10
		public float speedFactor; //Field offset: 0x14
		public UISprite spriteToAnimate; //Field offset: 0x18
		public Color color1; //Field offset: 0x1C
		public Color color2; //Field offset: 0x2C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 317
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateEffectColor>d__92(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum AwardCellState
	{
		NotSet = 0,
		SocialNetworksLocked = 1,
		PreviewInProgress = 2,
		InProgress = 3,
		Collectible = 4,
		PreviewFinished = 5,
		Finished = 6,
	}

	private const string AWARD_IN_PROGRESS_DESCRIPTION_HEX_COLOR = "[2486BB]"; //Field offset: 0x0
	private const string IN_PROGRESS_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_bg_small"; //Field offset: 0x0
	private const string DIAMOND_TIER_ITEM_BACKGROUND_SPRITE_NAME = "icon_diamond_award_bg"; //Field offset: 0x0
	private const string COLLECTIBLE_DIAMOND_TIER_ITEM_BACKGROUND_SPRITE_NAME = "icon_diamond_award_collect_bg"; //Field offset: 0x0
	private const string COMPLETED_GOAL_ICON_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed"; //Field offset: 0x0
	private const string COLLECTIBLE_GOAL_ICON_BACKGROUND_SPRITE_NAME = "icon_award_collect_bg"; //Field offset: 0x0
	private const string IN_PROGRESS_GOAL_ICON_BACKGROUND_SPRITE_NAME = "icon_award_bg"; //Field offset: 0x0
	private const string COLLECTIBLE_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_collect_bg_small"; //Field offset: 0x0
	private const string COMPLETED_ITEM_BACKGROUND_SPRITE_NAME = "icon_award_bg_completed_small"; //Field offset: 0x0
	private const string END_COLOR_SYMBOL = "[-]"; //Field offset: 0x0
	private const string AWARD_COMPLETE_VALUE_HEX_COLOR = "[015A01]"; //Field offset: 0x0
	private const string AWARD_COMPLETE_DESCRIPTION_HEX_COLOR = "[549133]"; //Field offset: 0x0
	private const string AWARD_IN_PROGRESS_VALUE_HEX_COLOR = "[004A7D]"; //Field offset: 0x0
	private static readonly Color32 COMPLETED_TITLE_TEXT_COLOR; //Field offset: 0x0
	private static readonly Color32 ACTIVE_TITLE_TEXT_COLOR; //Field offset: 0x4
	private static readonly Color32 ACTIVE_TITLE_TEXT_SHADOW_COLOR; //Field offset: 0x8
	private static readonly Color32 COMPLETED_TITLE_TEXT_SHADOW_COLOR; //Field offset: 0xC
	private static readonly Color32 COLLECTIBLE_SEGMENT_BACKGROUND_COLOR; //Field offset: 0x10
	private static readonly Color32 PROGRESS_SEGMENT_BACKGROUND_COLOR; //Field offset: 0x14
	private static readonly Color32 COMPLETE_SEGMENT_BACKGROUND_COLOR; //Field offset: 0x18
	private static readonly Color32 REWARD_BIG_BACKGROUND_FINISHED_COLOR; //Field offset: 0x1C
	private static readonly Color32 REWARD_BIG_BACKGROUND_IN_PROGRESS_COLOR; //Field offset: 0x20
	private static readonly Color32 REWARD_BIG_BACKGROUND_COLLECTIBLE_COLOR; //Field offset: 0x24
	private static readonly Color32 EFFECT_INITIAL_COLOR; //Field offset: 0x28
	private static readonly Color32 MYSTERYBOX_BACKGROUND_PROGRESS_COLOR; //Field offset: 0x2C
	private static readonly Color32 MYSTERYBOX_BACKGROUND_FINISHED_COLOR; //Field offset: 0x30
	private AudioClip _awardTierUnlockSound; //Field offset: 0xC
	private AwardCollectibleHelper _mainGoalElementsHelper; //Field offset: 0x10
	private GameObject _expandedParent; //Field offset: 0x14
	private UILabel _missionTitle; //Field offset: 0x18
	private UILabel _missionTextDescription; //Field offset: 0x1C
	private GameObject _missionIconsDescriptionParent; //Field offset: 0x20
	private UISprite _cellBackground; //Field offset: 0x24
	private GameObject _collectButtonParent; //Field offset: 0x28
	private UILabel _collectButtonLabel; //Field offset: 0x2C
	private UISprite _progressIconsBG; //Field offset: 0x30
	private GameObject _progressBarParent; //Field offset: 0x34
	private UISlider _progressBarSlider; //Field offset: 0x38
	private GameObject _progressBarFG; //Field offset: 0x3C
	private GameObject _tieredParent; //Field offset: 0x40
	private AwardTierHelper _notTieredParent; //Field offset: 0x44
	private UISprite _rewardBigBG; //Field offset: 0x48
	private UILabel _previewCompleteLabel; //Field offset: 0x4C
	private GameObject _loginFBButton; //Field offset: 0x50
	private GameObject _loginButtonContents; //Field offset: 0x54
	private GameObject _connectingButtonContents; //Field offset: 0x58
	private Layout _connectingContentsLayout; //Field offset: 0x5C
	private Layout _loginContentLayout; //Field offset: 0x60
	private UISprite _loginFBButtonFill; //Field offset: 0x64
	private UILabel _loginFBLabel; //Field offset: 0x68
	private UILabel _connectingLabel; //Field offset: 0x6C
	private AwardTierHelper[] _tierIconHelpers; //Field offset: 0x70
	private UISprite _tierEffectSprite; //Field offset: 0x74
	private UISprite _noTierEffectSprite; //Field offset: 0x78
	private AwardCollectibleHelper[] _goalIcons; //Field offset: 0x7C
	private UISprite _mysteryBoxIcon; //Field offset: 0x80
	private UISprite _mysteryBoxArrowBackground; //Field offset: 0x84
	private UILabel _progressAmount; //Field offset: 0x88
	private GameObject _rewardContentParent; //Field offset: 0x8C
	private UILabel _rewardAmount; //Field offset: 0x90
	private HorizontalLayout _rewardContentLayout; //Field offset: 0x94
	private GameObject _stickerParent; //Field offset: 0x98
	private UISprite _stickerIconSprite; //Field offset: 0x9C
	private UISprite _stickerIconNew; //Field offset: 0xA0
	private UISprite _stickerSprite; //Field offset: 0xA4
	private Animation wiggleAnimation; //Field offset: 0xA8
	private BoxCollider _loginCollider; //Field offset: 0xAC
	private UISprite _socialLock; //Field offset: 0xB0
	private string[] _mainTierGoalSpriteNames; //Field offset: 0xB4
	private string[] _mysteryBoxIconNames; //Field offset: 0xB8
	private float soundVolume; //Field offset: 0xBC
	private float soundPitch; //Field offset: 0xC0
	private AwardCellState _currentCellState; //Field offset: 0xC4
	private AwardsScreen _awardsScreen; //Field offset: 0xC8
	private bool _hasManyTiers; //Field offset: 0xCC
	private Award _currentAward; //Field offset: 0xD0
	private bool _enablePreview; //Field offset: 0xD4
	private float _animationLerpFactor; //Field offset: 0xD8
	private bool _isConnectedToFacebook; //Field offset: 0xDC

	private static AwardCellHelper() { }

	public AwardCellHelper() { }

	private IEnumerator AnimateChangingOfTierSprite(UISprite effectSprite, AwardTierHelper tierIconToChange) { }

	private IEnumerator AnimateEffectColor(UISprite spriteToAnimate, Color color1, Color color2, float speedFactor = 1) { }

	public void CollectRewardClicked() { }

	public void FacebookLoginClicked() { }

	private string FindBackgroundToUse(bool mainGoalIcon) { }

	private AwardCellState GetCellState() { }

	private int GetNbToAnimate() { }

	private int GetTierNumberToEnable() { }

	public void InitCell(Award award, AwardsScreen awardsScreen) { }

	private void OnDisable() { }

	private void SetFBLoginButtonToConnectingState() { }

	private void SetFBLoginButtonToNormalState() { }

	private void SetupCellColors() { }

	private void SetupCellContent() { }

	private void SetupCellStructure() { }

}

