namespace SYBO.Common.Utility;

public class SubscribableMonobehaviour : MonoBehaviour
{
	public Action OnUpdate; //Field offset: 0xC
	public Action OnLateUpdate; //Field offset: 0x10
	public Action OnFixedUpdate; //Field offset: 0x14

	public SubscribableMonobehaviour() { }

	private void FixedUpdate() { }

	private void LateUpdate() { }

	private void Update() { }

}

