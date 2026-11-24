namespace UI.Screens;

public class GameOverTabHelper : MonoBehaviour
{
	private const int TOPRUN_LABEL_PIXEL_OFFSET_X = 14; //Field offset: 0x0
	private const int TOPRUN_LABEL_PIXEL_OFFSET_Y = -2; //Field offset: 0x0
	private GameObject _leaderboardTabActive; //Field offset: 0xC
	private GameObject _leaderboardTabInactive; //Field offset: 0x10
	private UILabel _leaderboardTabLabel; //Field offset: 0x14
	private GameObject _toprunTabActive; //Field offset: 0x18
	private GameObject _toprunTabInactive; //Field offset: 0x1C
	private UILabel _toprunTabLabel; //Field offset: 0x20
	private UISprite _toprunTabFlag; //Field offset: 0x24

	public GameOverTabHelper() { }

	private void Awake() { }

	public void LeaderboardTapped() { }

	private void OnEnable() { }

	public void RefreshFlag() { }

	private void SetLabelActive(UILabel label, bool isActive) { }

	public void TopRunTapped() { }

}

