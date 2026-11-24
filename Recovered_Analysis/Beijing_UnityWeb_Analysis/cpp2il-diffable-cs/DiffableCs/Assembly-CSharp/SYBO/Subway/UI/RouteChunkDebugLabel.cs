namespace SYBO.Subway.UI;

public class RouteChunkDebugLabel : MonoBehaviour
{
	private const string WAITING_FOR_CHUNKS = "Waiting for chunks..."; //Field offset: 0x0
	private UILabel _label; //Field offset: 0xC
	private UISprite _background; //Field offset: 0x10
	private StringBuilder sb; //Field offset: 0x14
	private int _originalHeight; //Field offset: 0x18
	private int _originalWidth; //Field offset: 0x1C
	private string _originalLabelText; //Field offset: 0x20

	public RouteChunkDebugLabel() { }

	private void Awake() { }

	private void DebugSettingsPopup_OnRoutePrintSettingChanged(bool isEnabled) { }

	private void EnableLabelIfNecessary() { }

	private void Game_OnGameEnded() { }

	private void Game_OnGameStarted() { }

	private void Update() { }

}

