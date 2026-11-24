namespace WeeklyHunt;

public class PrizeIconPrefabData : ScriptableObject
{
	private static PrizeIconPrefabData _instance; //Field offset: 0x0
	private GameObject _keyIconPrefab; //Field offset: 0xC
	private GameObject _superMysteryBoxIconPrefab; //Field offset: 0x10
	private GameObject _hoverboardIconPrefab; //Field offset: 0x14
	private GameObject _scoreBoosterIconPrefab; //Field offset: 0x18
	private GameObject _headstartIconPrefab; //Field offset: 0x1C
	private GameObject _christmasBoardIconPrefab; //Field offset: 0x20
	private GameObject _rioBoard2IconPrefab; //Field offset: 0x24
	private GameObject _northpoleBoard2016IconPrefab; //Field offset: 0x28
	private GameObject _cherryBoardIconPrefab; //Field offset: 0x2C

	public static PrizeIconPrefabData instance
	{
		 get { } //Length: 178
	}

	public PrizeIconPrefabData() { }

	public static PrizeIconPrefabData get_instance() { }

	public GameObject GetPrefab(PrizeData prizeData) { }

}

