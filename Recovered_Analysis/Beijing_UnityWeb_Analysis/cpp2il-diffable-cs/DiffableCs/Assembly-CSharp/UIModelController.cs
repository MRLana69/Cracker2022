//Type is in global namespace

public class UIModelController : MonoBehaviour
{
	private sealed class <AnimateRunningCharacterForBragCelebration>d__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public GameObject model; //Field offset: 0x10
		public UIModelController <>4__this; //Field offset: 0x14
		private CharacterAnimationControl <_charAnimCtrl>5__2; //Field offset: 0x18
		private float <factor>5__3; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 694
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateRunningCharacterForBragCelebration>d__79(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <AnimateUnlockBackground>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIModelController <>4__this; //Field offset: 0x10
		public GameObject go; //Field offset: 0x14
		private Vector3 <charWithBoardPosition>5__2; //Field offset: 0x18
		private Vector3 <rotation1CharWithBoard>5__3; //Field offset: 0x24
		private Vector3 <rotation2CharWithBoard>5__4; //Field offset: 0x30
		private Vector3 <rotation3CharWithBoard>5__5; //Field offset: 0x3C
		private Vector3 <offset1PosBoard>5__6; //Field offset: 0x48
		private Vector3 <offset2PosBoard>5__7; //Field offset: 0x54
		private Vector3 <offset3PosBoard>5__8; //Field offset: 0x60
		private Vector3 <charPosition>5__9; //Field offset: 0x6C
		private Vector3 <rotation1character>5__10; //Field offset: 0x78
		private Vector3 <rotation2character>5__11; //Field offset: 0x84
		private Vector3 <rotation3character>5__12; //Field offset: 0x90
		private Vector3 <offset1PosCharacter>5__13; //Field offset: 0x9C
		private Vector3 <offset2PosCharacter>5__14; //Field offset: 0xA8
		private Vector3 <offset3PosCharacter>5__15; //Field offset: 0xB4
		private Vector3 <offset1BgRotationCharScreen>5__16; //Field offset: 0xC0
		private Vector3 <offset2BgRotationCharScreen>5__17; //Field offset: 0xCC
		private Vector3 <offset3BgRotationCharScreen>5__18; //Field offset: 0xD8
		private int <index>5__19; //Field offset: 0xE4
		private Vector3 <currentBackgroundRotationOffset>5__20; //Field offset: 0xE8

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 3908
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateUnlockBackground>d__80(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum ModelScreen
	{
		Character = 0,
		GameOver = 1,
		TutorialPopup = 2,
		Popup = 3,
		Boards = 4,
		CelebrationCharacterUnlock = 5,
		CelebrationBoardUnlock = 6,
		CelebrationHighScore = 7,
		DuelResultPopup = 8,
		CelebrationTopRun = 9,
		LimitedCharacterPopup = 10,
		LimitedBoardPopup = 11,
		BoardPromotionPopup = 12,
		FirstPurchaseBonusBigCharacter = 13,
		CloudSaveReminderPopup = 14,
		CharacterPromotionPopup = 15,
	}

	private const string CELEBRATION_STRIPE_COROUTINE_NAME = "AnimateUnlockBackground"; //Field offset: 0x0
	private const float PARTICLE_ANIMATION_SPEED_FACTOR_LOW = 0.5; //Field offset: 0x0
	private const float DURATION = 3.5; //Field offset: 0x0
	private const float RUNNING_SPEED_LOW = 1; //Field offset: 0x0
	private const float RUNNING_SPEED_HIGH = 3; //Field offset: 0x0
	private static Action OnChangedCurrentlyShownCharacter; //Field offset: 0x0
	private const string BRAG_CELEBRATION_ANIMATION_COROUTINE = "AnimateRunningCharacterForBragCelebration"; //Field offset: 0x0
	private const float PARTICLE_ANIMATION_SPEED_FACTOR_HIGH = 3.5; //Field offset: 0x0
	private static Action OnChangedCurrentlyShownHoverboard; //Field offset: 0x4
	private static UIModelController _instance; //Field offset: 0x8
	public GameObject CharacterAnchor; //Field offset: 0xC
	public GameObject GameOverAnchor; //Field offset: 0x10
	public GameObject CelebrationPopupAnchor; //Field offset: 0x14
	public GameObject TutorialPopupAnchor; //Field offset: 0x18
	public GameObject HuntPrizeAnchor; //Field offset: 0x1C
	public GameObject PauseScreenAnchor; //Field offset: 0x20
	public GameObject WeeklyHuntRewardAnchor; //Field offset: 0x24
	public GameObject DailyChallengeRewardAnchor; //Field offset: 0x28
	public GameObject FirstPurchaseBonusAnchor; //Field offset: 0x2C
	public GameObject CharacterPromotionAnchor; //Field offset: 0x30
	private GameObject _maskedCharacterAnchor; //Field offset: 0x34
	private GameObject <limitedCharacterPopupAnchor>k__BackingField; //Field offset: 0x38
	private GameObject <limitedBoardPopupAnchor>k__BackingField; //Field offset: 0x3C
	private GameObject <BoardPromotionPopupAnchor>k__BackingField; //Field offset: 0x40
	public GameObject ModelPrefab; //Field offset: 0x44
	public CelebrationBackgroundHelper celebrationBackgroundHelper; //Field offset: 0x48
	private AnimationClip _firstPurchaseBonusIdleAnimation; //Field offset: 0x4C
	private AnimationClip _firstPurchaseBonusBreakDanceAnimation; //Field offset: 0x50
	private AnimationClip _firstPurchaseBonusBreakDanceAnimation2; //Field offset: 0x54
	private Dictionary<ModelScreen, ModelScreenData> _cachedModelScreenDataEntries; //Field offset: 0x58
	private bool celebrationShouldAnimateStripes; //Field offset: 0x5C
	private bool _isCelebrationCharacterScreen; //Field offset: 0x5D
	private bool _isCelebrationBackgroundRotating; //Field offset: 0x5E
	private Vector3 _discoBgRotation; //Field offset: 0x60
	private Vector3 _tunnerBgRotationNormal; //Field offset: 0x6C
	private ModelScreen _currentActivatedScreenModel; //Field offset: 0x78
	private BoardId _currentMysteryBoxBoardId; //Field offset: 0x7C
	private int _currentlyShownThemeIndex; //Field offset: 0x80
	private CharacterId _currentlyShownModel; //Field offset: 0x84
	private Vector3 CHAR_TO_POS; //Field offset: 0x88
	private Vector3 CHAR_FROM_POS; //Field offset: 0x94

	public static event Action OnChangedCurrentlyShownCharacter
	{
		 add { } //Length: 12
		 remove { } //Length: 126
	}

	public static event Action OnChangedCurrentlyShownHoverboard
	{
		 add { } //Length: 126
		 remove { } //Length: 129
	}

	public GameObject BoardPromotionPopupAnchor
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public CharacterId currentlyShownModel
	{
		 get { } //Length: 7
	}

	public int currentlyShownThemeIndex
	{
		 get { } //Length: 9
	}

	public static UIModelController Instance
	{
		 get { } //Length: 306
	}

	public GameObject limitedBoardPopupAnchor
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public GameObject limitedCharacterPopupAnchor
	{
		 get { } //Length: 66
		 set { } //Length: 31
	}

	private GameObject _ActivateModel(ModelScreenData modelScreenData, CharacterId characterId, int modelVersion, ModelScreen screen, bool cache, Nullable<CharacterId> friendsCharacterName = null, int friendsModelVersion = -1) { }

	private GameObject _SetupModelAndActivateIt(CharacterId charId, int themeVersion, ModelScreen screen, bool cache = true) { }

	public UIModelController() { }

	public void ActivateCelebrationBoardWithStripes(BoardId boardId, ModelScreen screen) { }

	public void ActivateCelebrationTunnel() { }

	public void ActivateGameOverModel() { }

	public void ActivateHoverboardModel(ModelScreen screen = 4) { }

	public void ActivateModelScreen(ModelScreen screen) { }

	public static void add_OnChangedCurrentlyShownCharacter(Action value) { }

	public static void add_OnChangedCurrentlyShownHoverboard(Action value) { }

	private IEnumerator AnimateRunningCharacterForBragCelebration(GameObject model) { }

	private IEnumerator AnimateUnlockBackground(GameObject go) { }

	public void ClearScreenAnchor(ModelScreen screen) { }

	public void DeactivateCelebrationPopupModels() { }

	public void DeactivateCelebrationTunnel() { }

	public void DeactivateModelScreen(ModelScreen screen) { }

	public bool ExistsTransformModelInModelScreen(ModelScreen screen, Transform transformModel) { }

	public GameObject get_BoardPromotionPopupAnchor() { }

	public CharacterId get_currentlyShownModel() { }

	public int get_currentlyShownThemeIndex() { }

	public static UIModelController get_Instance() { }

	public GameObject get_limitedBoardPopupAnchor() { }

	public GameObject get_limitedCharacterPopupAnchor() { }

	public CharacterId GetActiveCharacterId(ModelScreen screen) { }

	public CharacterModel GetActiveCharacterModel(ModelScreen screen) { }

	private GameObject GetScreenAnchor(ModelScreen screen) { }

	private void Init() { }

	private bool IsModelCurrentlyShown(CharacterId charId, int themeVersion, ModelScreen screen) { }

	public static void remove_OnChangedCurrentlyShownCharacter(Action value) { }

	public static void remove_OnChangedCurrentlyShownHoverboard(Action value) { }

	public void SelectCharacterForPlay(CharacterId characterId, int themeIndex) { }

	public void SelectCurrentlyShownBoard(BoardId boardId) { }

	public void SelectCurrentModelForPlay() { }

	public void SelectThemeForCurrentModel(int themeVersion) { }

	public void set_BoardPromotionPopupAnchor(GameObject value) { }

	public void set_limitedBoardPopupAnchor(GameObject value) { }

	public void set_limitedCharacterPopupAnchor(GameObject value) { }

	public void SetDiscoLightBackground() { }

	private void SetupModelScreen(ModelScreen screen, ModelScreenSetup screenSetup, ModelScreenData modelScreenData) { }

	private bool ShouldCreateABrandNewModel() { }

	public GameObject ShowCharacterInCelebration(CharacterId charId, int themeIndex, ModelScreen screen, bool cache) { }

	public void ShowHoverboardMenuModel(BoardId currentlyShownBoard, ModelScreen screen, bool willUpdateAnimation, bool willAllowSignatureAnimation, BoardAbility boardAbility) { }

	public void ShowMenuModel(CharacterId charId, int themeVersion, ModelScreen screen = 0) { }

	private void UpdateCelebrationRotation(GameObject go, Vector3 charRotation, Vector3 charPosition, Vector3 charPositionOffset, Vector3 backgroundRotationOffset, bool shouldAnimateStripes, bool rotateBackground) { }

}

