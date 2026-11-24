//Type is in global namespace

public class CharactersNotificationHelper : MonoBehaviour
{
	private const float UPDATE_INTERVAL = 0.1; //Field offset: 0x0
	private UISprite notificationIcon; //Field offset: 0xC
	private UILabel notificationLabel; //Field offset: 0x10
	private UISprite exclamationMark; //Field offset: 0x14
	private bool _hasGoneToZero; //Field offset: 0x18
	private float _currentInterval; //Field offset: 0x1C

	public CharactersNotificationHelper() { }

	private void OnEnable() { }

	private void RefreshNotification() { }

	private void Update() { }

}

