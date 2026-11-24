namespace UnityEngine.Networking;

public class NetworkTransformVisualizer : NetworkBehaviour
{
	private static Material s_LineMaterial; //Field offset: 0x0
	private GameObject m_VisualizerPrefab; //Field offset: 0x1C
	private NetworkTransform m_NetworkTransform; //Field offset: 0x20
	private GameObject m_Visualizer; //Field offset: 0x24

	public GameObject visualizerPrefab
	{
		 get { } //Length: 3
		 set { } //Length: 810
	}

	public NetworkTransformVisualizer() { }

	private static void CreateLineMaterial() { }

	private void DrawRotationInterpolation() { }

	private void FixedUpdate() { }

	public GameObject get_visualizerPrefab() { }

	private void OnDestroy() { }

	private void OnRenderObject() { }

	public override void OnStartClient() { }

	public override void OnStartLocalPlayer() { }

	public void set_visualizerPrefab(GameObject value) { }

}

