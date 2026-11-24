//Type is in global namespace

public class RenderQueueModifier : MonoBehaviour
{
	public enum RenderType
	{
		FRONT = 0,
		BACK = 1,
	}

	public UIWidget m_target; //Field offset: 0xC
	public RenderType m_type; //Field offset: 0x10
	private Renderer[] _renderers; //Field offset: 0x14
	private int _lastQueue; //Field offset: 0x18

	public RenderQueueModifier() { }

	private void LateUpdate() { }

	private void Start() { }

}

