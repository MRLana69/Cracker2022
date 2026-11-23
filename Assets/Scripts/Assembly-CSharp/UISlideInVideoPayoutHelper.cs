public class UISlideInVideoPayoutHelper : UISlideIn
{
	private UILabel _price;

	public unsafe void SetupSlideInVideoPayout()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		SetupSlideIn();
		if (_price != null)
		{
			VideoAdsManager instance = VideoAdsManager.instance;
			int amountOfKeysRewardedForVideo = instance.GetAmountOfKeysRewardedForVideo();
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			_price.text = text;
		}
	}
}
