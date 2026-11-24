//Type is in global namespace

public class DailyLetterPickupManager : MonoBehaviour
{
	public const char NO_LETTER = '\u0'; //Field offset: 0x0
	private static DailyLetterPickupManager instance; //Field offset: 0x0
	private char letter; //Field offset: 0xC
	private HashSet<DailyLetterPickup> pickups; //Field offset: 0x10

	public static DailyLetterPickupManager Instance
	{
		 get { } //Length: 117
	}

	public char Letter
	{
		 get { } //Length: 66
	}

	public DailyLetterPickupManager() { }

	public static DailyLetterPickupManager get_Instance() { }

	public char get_Letter() { }

	public void InitializePickup(DailyLetterPickup pickup) { }

	private void NotifyPickups() { }

	public void UpdateLetter() { }

}

