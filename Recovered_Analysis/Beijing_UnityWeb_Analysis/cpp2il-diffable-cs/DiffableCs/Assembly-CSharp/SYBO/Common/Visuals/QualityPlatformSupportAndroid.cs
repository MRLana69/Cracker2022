namespace SYBO.Common.Visuals;

public class QualityPlatformSupportAndroid : IQualityPlatformSupport
{
	private enum AndroidQualityCategory
	{
		HighPerformanceDevice = 0,
	}

	private Dictionary<QualityFeature, AndroidQualityCategory> _qualityFeatureCategory; //Field offset: 0x8
	private Dictionary<AndroidQualityCategory, bool> _qualityCategorySupport; //Field offset: 0xC

	public QualityPlatformSupportAndroid() { }

	public void Initialize() { }

	public bool IsSupported(QualityFeature feature) { }

}

