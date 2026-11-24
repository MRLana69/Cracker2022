//Type is in global namespace

public abstract class UIRect : MonoBehaviour
{
	public class AnchorPoint
	{
		public Transform target; //Field offset: 0x8
		public float relative; //Field offset: 0xC
		public int absolute; //Field offset: 0x10
		public UIRect rect; //Field offset: 0x14
		public Camera targetCam; //Field offset: 0x18

		public AnchorPoint() { }

		public AnchorPoint(float relative) { }

		public Vector3[] GetSides(Transform relativeTo) { }

		public void Set(float relative, float absolute) { }

		public void Set(Transform target, float relative, float absolute) { }

		public void SetHorizontal(Transform parent, float localPos) { }

		public void SetToNearest(float abs0, float abs1, float abs2) { }

		public void SetToNearest(float rel0, float rel1, float rel2, float abs0, float abs1, float abs2) { }

		public void SetVertical(Transform parent, float localPos) { }

	}

	public enum AnchorUpdate
	{
		OnEnable = 0,
		OnUpdate = 1,
		OnStart = 2,
	}

	protected static Vector3[] mSides; //Field offset: 0x0
	public AnchorPoint leftAnchor; //Field offset: 0xC
	public AnchorPoint rightAnchor; //Field offset: 0x10
	public AnchorPoint bottomAnchor; //Field offset: 0x14
	public AnchorPoint topAnchor; //Field offset: 0x18
	public AnchorUpdate updateAnchors; //Field offset: 0x1C
	protected GameObject mGo; //Field offset: 0x20
	protected Transform mTrans; //Field offset: 0x24
	protected BetterList<UIRect> mChildren; //Field offset: 0x28
	protected bool mChanged; //Field offset: 0x2C
	protected bool mParentFound; //Field offset: 0x2D
	private bool mUpdateAnchors; //Field offset: 0x2E
	private int mUpdateFrame; //Field offset: 0x30
	private bool mAnchorsCached; //Field offset: 0x34
	private UIRoot mRoot; //Field offset: 0x38
	private UIRect mParent; //Field offset: 0x3C
	private bool mRootSet; //Field offset: 0x40
	protected Camera mCam; //Field offset: 0x44
	protected bool mStarted; //Field offset: 0x48
	public float finalAlpha; //Field offset: 0x4C

	public abstract float alpha
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Camera anchorCamera
	{
		 get { } //Length: 108
	}

	public GameObject cachedGameObject
	{
		 get { } //Length: 107
	}

	public Transform cachedTransform
	{
		 get { } //Length: 108
	}

	protected float cameraRayDistance
	{
		 get { } //Length: 6
	}

	public virtual bool canBeAnchored
	{
		 get { } //Length: 141
	}

	public bool isAnchored
	{
		 get { } //Length: 201
	}

	public virtual bool isAnchoredHorizontally
	{
		 get { } //Length: 253
	}

	public virtual bool isAnchoredVertically
	{
		 get { } //Length: 141
	}

	public bool isFullyAnchored
	{
		 get { } //Length: 118
	}

	public abstract Vector3[] localCorners
	{
		 get { } //Length: 0
	}

	public UIRect parent
	{
		 get { } //Length: 3
	}

	public UIRoot root
	{
		 get { } //Length: 130
	}

	public abstract Vector3[] worldCorners
	{
		 get { } //Length: 0
	}

	private static UIRect() { }

	protected UIRect() { }

	protected virtual void Awake() { }

	public abstract float CalculateFinalAlpha(int frameID) { }

	private void FindCameraFor(AnchorPoint ap) { }

	public abstract float get_alpha() { }

	public Camera get_anchorCamera() { }

	public GameObject get_cachedGameObject() { }

	public Transform get_cachedTransform() { }

	protected float get_cameraRayDistance() { }

	public virtual bool get_canBeAnchored() { }

	public bool get_isAnchored() { }

	public virtual bool get_isAnchoredHorizontally() { }

	public virtual bool get_isAnchoredVertically() { }

	public bool get_isFullyAnchored() { }

	public abstract Vector3[] get_localCorners() { }

	public UIRect get_parent() { }

	public UIRoot get_root() { }

	public abstract Vector3[] get_worldCorners() { }

	protected Vector3 GetLocalPos(AnchorPoint ac, Transform trans) { }

	public virtual Vector3[] GetSides(Transform relativeTo) { }

	public virtual void Invalidate(bool includeChildren) { }

	protected abstract void OnAnchor() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnInit() { }

	protected abstract void OnStart() { }

	protected virtual void OnUpdate() { }

	public virtual void ParentHasChanged() { }

	public void ResetAnchors() { }

	public void ResetAndUpdateAnchors() { }

	public abstract void set_alpha(float value) { }

	public void SetAnchor(GameObject go, float left, int leftOffset, float bottom, int bottomOffset, float right, int rightOffset, float top, int topOffset) { }

	public void SetAnchor(GameObject go, int left, int bottom, int right, int top) { }

	public void SetAnchor(GameObject go) { }

	public void SetAnchor(Transform t) { }

	public void SetAnchor(GameObject go, float left, float bottom, float right, float top) { }

	public void SetAnchor(float left, int leftOffset, float bottom, int bottomOffset, float right, int rightOffset, float top, int topOffset) { }

	public abstract void SetRect(float x, float y, float width, float height) { }

	public void SetScreenRect(int left, int top, int width, int height) { }

	protected void Start() { }

	public void Update() { }

	public void UpdateAnchors() { }

	protected void UpdateAnchorsInternal(int frame) { }

}

