namespace UI.SlideIns;

public class SlideInData : ScriptableObject
{
	public enum SlideInType
	{
		TopRunTimer = 0,
		Mission = 1,
		MissionSet = 2,
		Letters = 3,
		LettersCompleteMysteryBox = 4,
		LettersCompleteCoins = 5,
		Unlock = 6,
		ErrorMessage = 7,
		WeeklyHunt = 8,
		OfferWall = 9,
		VideoPayout = 10,
		Brag = 11,
		Awards = 12,
		Facebook = 13,
		CharacterEventWord = 14,
		CharacterEventWordReward = 15,
		RemoveAds = 16,
		Gift = 17,
		FirstPurchaseBonus = 18,
		CloudSave = 19,
		CloudSaveMessage = 20,
	}

	private static SlideInData _instance; //Field offset: 0x0
	private List<UISlideIn> _slideInPrefabs; //Field offset: 0xC
	private AudioClipInfo _slideInSound; //Field offset: 0x10
	private AudioClipInfo _slideInFanfare; //Field offset: 0x14

	public static SlideInData instance
	{
		 get { } //Length: 103
	}

	private static SlideInData() { }

	public SlideInData() { }

	public static SlideInData get_instance() { }

	private T GetPrefab() { }

	public AudioClipInfo GetSlideInSound(SlideIn slideIn) { }

	public T InstantiateSlideIn(Transform parent) { }

	private void OnValidate() { }

}

