namespace UI.Breadcrumbs;

public class Breadcrumb : MonoBehaviour
{
	public enum BreadcrumbEvent
	{
		WordHunt = 0,
		WeeklyHunt = 1,
		MissionSet = 2,
		CloudSaveError = 3,
		CloudSaveConflict = 4,
		CloudSaveOk = 5,
	}

	public class BreadcrumbSave
	{
		public string lastDailyWord; //Field offset: 0x8
		public long weeklyHuntPeriodExpireDateTicks; //Field offset: 0x10
		public int lastMissionSet; //Field offset: 0x18

		public BreadcrumbSave() { }

	}

	private bool _newMissionSet; //Field offset: 0xC
	private bool _newWeeklyHunt; //Field offset: 0xD
	private bool _newWordHunt; //Field offset: 0xE
	private bool _cloudSaveError; //Field offset: 0xF
	private bool _cloudSaveConflict; //Field offset: 0x10
	private bool _cloudSaveOk; //Field offset: 0x11
	private UISprite _normalBackground; //Field offset: 0x14
	private UISprite _exclamationMark; //Field offset: 0x18
	private UILabel _number; //Field offset: 0x1C

	public Breadcrumb() { }

	private bool CheckCloudSaveConflict() { }

	private bool CheckCloudSaveError() { }

	private bool CheckCloudSaveOk() { }

	private void CheckIfListening() { }

	private void CheckListeners() { }

	private bool CheckNewMissionSet() { }

	private static bool CheckNewWeeklyHunt() { }

	private static bool CheckNewWordhunt() { }

	public static void Consume(BreadcrumbEvent e) { }

	public void EnableListeners(BreadcrumbEvent[] events) { }

	private void SetupNormalBreadcrumb(int breadcrumbNumber) { }

	private void SetupSpecialBreadcrumb(string spriteName) { }

	private void Start() { }

	private void Update() { }

}

