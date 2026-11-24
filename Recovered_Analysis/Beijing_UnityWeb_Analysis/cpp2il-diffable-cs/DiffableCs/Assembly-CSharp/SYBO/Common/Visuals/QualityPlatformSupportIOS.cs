namespace SYBO.Common.Visuals;

public class QualityPlatformSupportIOS : IQualityPlatformSupport
{
	private enum IPhoneQualityCategory
	{
		HighPerformanceDevice = 0,
	}

	private bool _isInitialized; //Field offset: 0x8
	private Dictionary<IPhoneQualityCategory, bool> _qualityCategorySupport; //Field offset: 0xC
	private Dictionary<QualityFeature, IPhoneQualityCategory> _qualityFeatureCategory; //Field offset: 0x10

	public QualityPlatformSupportIOS() { }

	public void Initialize() { }

	public bool IsSupported(QualityFeature feature) { }

}

