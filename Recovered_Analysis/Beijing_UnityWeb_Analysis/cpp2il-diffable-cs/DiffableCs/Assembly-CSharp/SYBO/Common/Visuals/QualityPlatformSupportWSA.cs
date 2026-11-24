namespace SYBO.Common.Visuals;

public class QualityPlatformSupportWSA : IQualityPlatformSupport
{
	private enum WSAQualityCategory
	{
		HighPerformanceDevice = 0,
	}

	private Dictionary<QualityFeature, WSAQualityCategory> _qualityFeatureCategory; //Field offset: 0x8
	private Dictionary<WSAQualityCategory, bool> _qualityCategorySupport; //Field offset: 0xC

	public QualityPlatformSupportWSA() { }

	public void Initialize() { }

	public bool IsSupported(QualityFeature feature) { }

}

