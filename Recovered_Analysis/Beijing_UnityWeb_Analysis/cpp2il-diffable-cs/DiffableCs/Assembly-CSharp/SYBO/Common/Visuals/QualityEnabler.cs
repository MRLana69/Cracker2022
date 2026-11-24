namespace SYBO.Common.Visuals;

public class QualityEnabler : MonoBehaviour
{
	private QualityFeature _feature; //Field offset: 0xC

	public QualityFeature Feature
	{
		 get { } //Length: 9
	}

	public QualityEnabler() { }

	public void ApplyQuality() { }

	public QualityFeature get_Feature() { }

	private void OnEnable() { }

}

