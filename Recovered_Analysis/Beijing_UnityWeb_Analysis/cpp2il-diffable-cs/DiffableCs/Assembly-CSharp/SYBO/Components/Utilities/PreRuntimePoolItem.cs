namespace SYBO.Components.Utilities;

public class PreRuntimePoolItem : MonoBehaviour
{
	public string poolName; //Field offset: 0xC
	public string prefabName; //Field offset: 0x10
	public bool despawnOnStart; //Field offset: 0x14
	public bool doNotReparent; //Field offset: 0x15

	public PreRuntimePoolItem() { }

	private void Start() { }

}

