using UnityEngine;

public class JetpackModel : MonoBehaviour
{
	private MeshRenderer mesh;

	private Transform jetpackCloudPositionL;

	private Transform jetpackCloudPositionR;

	private Transform[] jetpackThrusters;

	public MeshRenderer Mesh => mesh;

	public Transform JetpackCloudPositionL => jetpackCloudPositionL;

	public Transform JetpackCloudPositionR => jetpackCloudPositionR;

	public Transform[] JetpackThrusters => jetpackThrusters;
}
