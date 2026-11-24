namespace WeeklyHunt;

public class PrizeIconPrefabReferences : MonoBehaviour
{
	private struct PrizeModel
	{
		public WeeklyHuntPrize rewardType; //Field offset: 0x0
		public GameObject iconPrefab; //Field offset: 0x4

	}

	private PrizeModel[] modelReferences; //Field offset: 0xC

	public PrizeIconPrefabReferences() { }

	public GameObject GetPrefab(PrizeData prizeData) { }

}

