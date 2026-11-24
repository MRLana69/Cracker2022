//Type is in global namespace

public class UITextShadowHelper : MonoBehaviour
{
	public UILabel shadowLabel; //Field offset: 0xC
	public Color frontColor; //Field offset: 0x10
	public Color shadowColor; //Field offset: 0x20
	public bool updateDynamically; //Field offset: 0x30
	public bool fakeHD; //Field offset: 0x31
	private UILabel _frontLabel; //Field offset: 0x34
	public Vector3 shadowOffset; //Field offset: 0x38
	private Transform _frontTransform; //Field offset: 0x44
	private Transform _shadowTransform; //Field offset: 0x48

	public UITextShadowHelper() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

	public void UpdateNow() { }

	private void UpdateText() { }

}

