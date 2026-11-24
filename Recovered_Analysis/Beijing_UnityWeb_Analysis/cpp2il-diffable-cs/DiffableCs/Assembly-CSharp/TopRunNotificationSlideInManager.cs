//Type is in global namespace

public class TopRunNotificationSlideInManager : MonoBehaviour
{
	private const string GAME_OBJECT_NAME = "TopRunNotificationManager"; //Field offset: 0x0
	private static TopRunNotificationSlideInManager _instance; //Field offset: 0x0
	private static bool _applicationIsQuitting; //Field offset: 0x4
	private int[] _warningTimesInMinutes; //Field offset: 0xC
	private bool[] _areWarningTimesGameOnly; //Field offset: 0x10
	private bool _isCurrentWarningTimerGameOnly; //Field offset: 0x14
	private float timeUntilSlideInInSeconds; //Field offset: 0x18
	private int timeToShowOnLabel; //Field offset: 0x1C
	private float timeLeftForCurrentWarning; //Field offset: 0x20
	private bool _doUseTimer; //Field offset: 0x24
	private DateTime _originalTourEndDate; //Field offset: 0x28

	public static TopRunNotificationSlideInManager instance
	{
		 get { } //Length: 193
	}

	private static TopRunNotificationSlideInManager() { }

	public TopRunNotificationSlideInManager() { }

	private void CalculateNextWarningTime() { }

	public static TopRunNotificationSlideInManager get_instance() { }

	public static void Init() { }

	private void InitiateWarningTimes() { }

	private void OnApplicationQuit() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void TournamentChanged(object sender, EventArgs eventArg) { }

	private void Update() { }

}

