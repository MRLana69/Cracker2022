//Type is in global namespace

public class UIRoot : MonoBehaviour
{
	public enum Constraint
	{
		Fit = 0,
		Fill = 1,
		FitWidth = 2,
		FitHeight = 3,
	}

	public enum Scaling
	{
		Flexible = 0,
		Constrained = 1,
		ConstrainedOnMobiles = 2,
	}

	public static List<UIRoot> list; //Field offset: 0x0
	public Scaling scalingStyle; //Field offset: 0xC
	public int manualWidth; //Field offset: 0x10
	public int manualHeight; //Field offset: 0x14
	public int minimumHeight; //Field offset: 0x18
	public int maximumHeight; //Field offset: 0x1C
	public bool fitWidth; //Field offset: 0x20
	public bool fitHeight; //Field offset: 0x21
	public bool adjustByDPI; //Field offset: 0x22
	public bool shrinkPortraitUI; //Field offset: 0x23
	private Transform mTrans; //Field offset: 0x24

	public int activeHeight
	{
		 get { } //Length: 19
	}

	public Scaling activeScaling
	{
		 get { } //Length: 43
	}

	public Constraint constraint
	{
		 get { } //Length: 83
	}

	public float pixelSizeAdjustment
	{
		 get { } //Length: 31
	}

	private static UIRoot() { }

	public UIRoot() { }

	protected virtual void Awake() { }

	public static void Broadcast(string funcName) { }

	public static void Broadcast(string funcName, object param) { }

	public int get_activeHeight() { }

	public Scaling get_activeScaling() { }

	public Constraint get_constraint() { }

	public float get_pixelSizeAdjustment() { }

	public static float GetPixelSizeAdjustment(GameObject go) { }

	public float GetPixelSizeAdjustment(int height) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void Start() { }

	private void Update() { }

	public void UpdateScale(bool updateAnchors = true) { }

}

