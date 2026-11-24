//Type is in global namespace

public class JetpackModel : MonoBehaviour
{
	private MeshRenderer mesh; //Field offset: 0xC
	private Transform jetpackCloudPositionL; //Field offset: 0x10
	private Transform jetpackCloudPositionR; //Field offset: 0x14
	private Transform[] jetpackThrusters; //Field offset: 0x18

	public Transform JetpackCloudPositionL
	{
		 get { } //Length: 6
	}

	public Transform JetpackCloudPositionR
	{
		 get { } //Length: 6
	}

	public Transform[] JetpackThrusters
	{
		 get { } //Length: 6
	}

	public MeshRenderer Mesh
	{
		 get { } //Length: 66
	}

	public JetpackModel() { }

	public Transform get_JetpackCloudPositionL() { }

	public Transform get_JetpackCloudPositionR() { }

	public Transform[] get_JetpackThrusters() { }

	public MeshRenderer get_Mesh() { }

}

