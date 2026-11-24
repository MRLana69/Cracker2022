namespace Kiloo.Common.Ads;

public class AdLocationInfo
{
	public readonly string id; //Field offset: 0x8
	public readonly AdType adType; //Field offset: 0xC
	public readonly bool isPoolLocation; //Field offset: 0x10

	public AdLocationInfo(string id, AdType adType, bool isPoolLocation) { }

}

