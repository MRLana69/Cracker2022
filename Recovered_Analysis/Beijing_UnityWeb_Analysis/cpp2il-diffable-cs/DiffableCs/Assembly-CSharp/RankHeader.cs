//Type is in global namespace

public class RankHeader : MonoBehaviour
{
	private UILabel _title; //Field offset: 0xC
	private UILabel _best; //Field offset: 0x10
	private UILabel _rankMedal; //Field offset: 0x14
	private UISprite _background; //Field offset: 0x18

	public RankHeader() { }

	public void InitHeader(int rank, int bestScore) { }

	private void setTextAndColours(int rank, int score) { }

}

