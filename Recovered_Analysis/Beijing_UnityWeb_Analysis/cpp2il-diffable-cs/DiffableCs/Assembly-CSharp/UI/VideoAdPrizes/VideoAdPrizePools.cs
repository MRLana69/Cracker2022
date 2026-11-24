namespace UI.VideoAdPrizes;

public class VideoAdPrizePools
{
	public List<VideoAdPrize> introPrizePool; //Field offset: 0x8
	private List<VideoAdPrize> randomPrizePool; //Field offset: 0xC

	public VideoAdPrizePools() { }

	public List<VideoAdPrize> GetShuffledCloneOfRandomPrizePool(int seed) { }

}

