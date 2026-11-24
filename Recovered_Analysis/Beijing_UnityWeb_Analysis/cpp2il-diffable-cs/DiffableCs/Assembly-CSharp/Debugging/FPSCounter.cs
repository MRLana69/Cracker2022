namespace Debugging;

public class FPSCounter : MonoBehaviour
{
	private static FPSCounter _instance; //Field offset: 0x0
	public UILabel OptionalMinFPSLabel; //Field offset: 0xC
	public float UpdateInterval; //Field offset: 0x10
	private UILabel _label; //Field offset: 0x14
	private float accum; //Field offset: 0x18
	private int frames; //Field offset: 0x1C
	private float timeleft; //Field offset: 0x20
	private float maxFrame; //Field offset: 0x24
	private bool _visible; //Field offset: 0x28
	private GameObject _prefabInstanceRoot; //Field offset: 0x2C

	public static FPSCounter Instance
	{
		 get { } //Length: 77
	}

	public bool Visible
	{
		 get { } //Length: 709
	}

	public FPSCounter() { }

	private void Awake() { }

	public static FPSCounter Create(GameObject anchor) { }

	public static FPSCounter get_Instance() { }

	public bool get_Visible() { }

	public void ToggleVisible(bool visible) { }

	private void Update() { }

}

