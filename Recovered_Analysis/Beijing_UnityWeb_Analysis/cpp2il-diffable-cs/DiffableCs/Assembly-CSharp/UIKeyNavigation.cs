//Type is in global namespace

public class UIKeyNavigation : MonoBehaviour
{
	public enum Constraint
	{
		None = 0,
		Vertical = 1,
		Horizontal = 2,
		Explicit = 3,
	}

	public static BetterList<UIKeyNavigation> list; //Field offset: 0x0
	public static int mLastFrame; //Field offset: 0x4
	public Constraint constraint; //Field offset: 0xC
	public GameObject onUp; //Field offset: 0x10
	public GameObject onDown; //Field offset: 0x14
	public GameObject onLeft; //Field offset: 0x18
	public GameObject onRight; //Field offset: 0x1C
	public GameObject onClick; //Field offset: 0x20
	public GameObject onTab; //Field offset: 0x24
	public bool startsSelected; //Field offset: 0x28
	private bool mStarted; //Field offset: 0x29

	public static UIKeyNavigation current
	{
		 get { } //Length: 452
	}

	public bool isColliderEnabled
	{
		 get { } //Length: 87
	}

	private static UIKeyNavigation() { }

	public UIKeyNavigation() { }

	public GameObject Get(Vector3 myDir, float x = 1, float y = 1) { }

	public static UIKeyNavigation get_current() { }

	public bool get_isColliderEnabled() { }

	protected static Vector3 GetCenter(GameObject go) { }

	public GameObject GetDown() { }

	public GameObject GetLeft() { }

	public GameObject GetRight() { }

	public GameObject GetUp() { }

	private static bool IsActive(GameObject go) { }

	protected virtual void OnClick() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public virtual void OnKey(KeyCode key) { }

	public virtual void OnNavigate(KeyCode key) { }

	private void Start() { }

}

