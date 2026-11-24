//Type is in global namespace

public class Glow : MonoBehaviour
{
	private MeshRenderer meshRenderer; //Field offset: 0xC
	private bool _isDebugGlowEnabled; //Field offset: 0x10

	public bool IsDebugGlowEnabled
	{
		 get { } //Length: 6
		internal set { } //Length: 92
	}

	public Glow() { }

	public void Awake() { }

	public bool get_IsDebugGlowEnabled() { }

	internal void set_IsDebugGlowEnabled(bool value) { }

	public void SetVisible(bool visible) { }

}

