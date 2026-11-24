//Type is in global namespace

public class UIEventListener : MonoBehaviour
{
	public delegate BoolDelegate
	{

		public BoolDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, bool state, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, bool state) { }

	}

	public delegate FloatDelegate
	{

		public FloatDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, float delta, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, float delta) { }

	}

	public delegate KeyCodeDelegate
	{

		public KeyCodeDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, KeyCode key, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, KeyCode key) { }

	}

	public delegate ObjectDelegate
	{

		public ObjectDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, GameObject obj, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, GameObject obj) { }

	}

	public delegate VectorDelegate
	{

		public VectorDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, Vector2 delta, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, Vector2 delta) { }

	}

	public delegate VoidDelegate
	{

		public VoidDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go) { }

	}

	public object parameter; //Field offset: 0xC
	public VoidDelegate onSubmit; //Field offset: 0x10
	public VoidDelegate onClick; //Field offset: 0x14
	public VoidDelegate onDoubleClick; //Field offset: 0x18
	public BoolDelegate onHover; //Field offset: 0x1C
	public BoolDelegate onPress; //Field offset: 0x20
	public BoolDelegate onSelect; //Field offset: 0x24
	public FloatDelegate onScroll; //Field offset: 0x28
	public VoidDelegate onDragStart; //Field offset: 0x2C
	public VectorDelegate onDrag; //Field offset: 0x30
	public VoidDelegate onDragOver; //Field offset: 0x34
	public VoidDelegate onDragOut; //Field offset: 0x38
	public VoidDelegate onDragEnd; //Field offset: 0x3C
	public ObjectDelegate onDrop; //Field offset: 0x40
	public KeyCodeDelegate onKey; //Field offset: 0x44
	public BoolDelegate onTooltip; //Field offset: 0x48
	public bool needsActiveCollider; //Field offset: 0x4C

	private bool isColliderEnabled
	{
		 get { } //Length: 253
	}

	public UIEventListener() { }

	public void Clear() { }

	public static UIEventListener Get(GameObject go) { }

	private bool get_isColliderEnabled() { }

	private void OnClick() { }

	private void OnDoubleClick() { }

	private void OnDrag(Vector2 delta) { }

	private void OnDragEnd() { }

	private void OnDragOut() { }

	private void OnDragOver() { }

	private void OnDragStart() { }

	private void OnDrop(GameObject go) { }

	private void OnHover(bool isOver) { }

	private void OnKey(KeyCode key) { }

	private void OnPress(bool isPressed) { }

	private void OnScroll(float delta) { }

	private void OnSelect(bool selected) { }

	private void OnSubmit() { }

	private void OnTooltip(bool show) { }

}

