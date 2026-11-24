namespace SYBO.Common.Visuals;

public class QualityToggle : MonoBehaviour
{
	private QualityFeature _feature; //Field offset: 0xC
	private GameObject _unsupported; //Field offset: 0x10
	private GameObject _supported; //Field offset: 0x14

	public QualityToggle() { }

	private void Awake() { }

}

