namespace SYBO.Common.Visuals;

public interface IQualityPlatformSupport
{

	public void Initialize() { }

	public bool IsSupported(QualityFeature feature) { }

}

