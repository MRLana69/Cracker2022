//Type is in global namespace

public class ProductPlacer : MonoBehaviour
{
	public enum BillboardType
	{
		Tunnel = 0,
		Train = 1,
		Billboard = 2,
	}

	public MeshRenderer billboardMesh; //Field offset: 0xC
	public BillboardType type; //Field offset: 0x10
	public float minTimeBetweenAds; //Field offset: 0x14

	public ProductPlacer() { }

	private void OnEnable() { }

}

