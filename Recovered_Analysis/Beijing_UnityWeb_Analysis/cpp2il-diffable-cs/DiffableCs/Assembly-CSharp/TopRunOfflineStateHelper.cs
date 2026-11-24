//Type is in global namespace

public class TopRunOfflineStateHelper : MonoBehaviour
{
	public enum OfflineState
	{
		TryAgain = 0,
		Loading = 1,
	}

	private GameObject _tryAgainState; //Field offset: 0xC
	private GameObject _loadingState; //Field offset: 0x10
	private UILabel _tryAgainDescriptionLabel; //Field offset: 0x14
	private UILabel _tryAgainButtonLabel; //Field offset: 0x18
	private UILabel _loadingLabel; //Field offset: 0x1C
	private Layout _tryAgainLayout; //Field offset: 0x20
	private Layout _loadingLayout; //Field offset: 0x24
	private TopRunOnlineScreen _topRunOnlineScreen; //Field offset: 0x28
	private TopRunOnlineGameOverScreen _topRunOnlineGameOverScreen; //Field offset: 0x2C

	public TopRunOfflineStateHelper() { }

	private void EnableLoadingOverlay() { }

	private void OnClick() { }

	private void SetLoadingState() { }

	public void SetState(OfflineState newState, TopRunOnlineScreen topRunScreen = null, TopRunOnlineGameOverScreen topRunGOScreen = null) { }

	private void SetTryAgainState() { }

}

