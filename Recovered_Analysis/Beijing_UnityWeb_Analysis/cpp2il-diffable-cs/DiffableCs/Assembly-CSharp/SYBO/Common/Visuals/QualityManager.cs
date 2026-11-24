namespace SYBO.Common.Visuals;

public class QualityManager
{
	private List<QualityFeature> _prewarmParticleSystems; //Field offset: 0x10
	private IQualityPlatformSupport _platformSupport; //Field offset: 0x14

	public QualityManager() { }

	public bool IsSupported(QualityFeature feature) { }

	public bool PrewarmParticleSystems(QualityFeature feature) { }

	protected override void SubclassInitialize() { }

}

