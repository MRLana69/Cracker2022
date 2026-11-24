namespace Kiloo.Common.JsonUtil;

public class WaterFallReach
{
	private static readonly string[] SCREENS_THAT_CAN_CACHE_A_VIDEO_AD; //Field offset: 0x0
	private bool _hasCachedSuccesFullyOnCurrentScreen; //Field offset: 0x8
	private bool _isFirstScreen; //Field offset: 0x9
	private int _currentScreenCacheFailCount; //Field offset: 0xC
	private string _previousScreenName; //Field offset: 0x10

	private static WaterFallReach() { }

	public WaterFallReach() { }

	private bool CanCacheAVideoAdOnScreen(string screenName) { }

	private bool IsOnMissionTab() { }

	private void LogWaterFallReach() { }

	private void OnCachedVideo(string adLocationId, bool wasAlreadyCached) { }

	private void OnChangedScreen(string screenName) { }

	private void OnFailedToCacheVideo(string adLocationId) { }

	private void Reset() { }

}

