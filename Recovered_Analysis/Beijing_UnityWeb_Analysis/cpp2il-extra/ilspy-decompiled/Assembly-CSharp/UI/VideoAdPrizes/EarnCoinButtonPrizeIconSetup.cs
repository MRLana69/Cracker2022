using System;

namespace UI.VideoAdPrizes;

[Serializable]
public class EarnCoinButtonPrizeIconSetup : PrizeIconSetup
{
	public override UISprite iconSprite
	{
		get
		{
			//IL_0009: Expected Obj, but got I4
			return (UISprite)WelcomePackManager.ParseFirstInstalledVersion();
		}
		set
		{
		}
	}
}
