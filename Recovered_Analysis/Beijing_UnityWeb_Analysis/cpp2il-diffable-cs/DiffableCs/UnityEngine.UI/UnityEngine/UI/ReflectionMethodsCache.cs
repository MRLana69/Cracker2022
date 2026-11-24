namespace UnityEngine.UI;

internal class ReflectionMethodsCache
{
	public delegate GetRaycastNonAllocCallback
	{

		public GetRaycastNonAllocCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

		public virtual int EndInvoke(IAsyncResult result) { }

		public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	}

	public delegate GetRayIntersectionAllCallback
	{

		public GetRayIntersectionAllCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

		public virtual RaycastHit2D[] EndInvoke(IAsyncResult result) { }

		public virtual RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	}

	public delegate GetRayIntersectionAllNonAllocCallback
	{

		public GetRayIntersectionAllNonAllocCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

		public virtual int EndInvoke(IAsyncResult result) { }

		public virtual int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	}

	public delegate Raycast2DCallback
	{

		public Raycast2DCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

		public virtual RaycastHit2D EndInvoke(IAsyncResult result) { }

		public virtual RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	}

	public delegate Raycast3DCallback
	{

		public Raycast3DCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

		public virtual bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }

		public virtual bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	}

	public delegate RaycastAllCallback
	{

		public RaycastAllCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

		public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }

		public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	}

	private static ReflectionMethodsCache s_ReflectionMethodsCache; //Field offset: 0x0
	public Raycast3DCallback raycast3D; //Field offset: 0x8
	public RaycastAllCallback raycast3DAll; //Field offset: 0xC
	public Raycast2DCallback raycast2D; //Field offset: 0x10
	public GetRayIntersectionAllCallback getRayIntersectionAll; //Field offset: 0x14
	public GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; //Field offset: 0x18
	public GetRaycastNonAllocCallback getRaycastNonAlloc; //Field offset: 0x1C

	public static ReflectionMethodsCache Singleton
	{
		 get { } //Length: 109
	}

	private static ReflectionMethodsCache() { }

	public ReflectionMethodsCache() { }

	public static ReflectionMethodsCache get_Singleton() { }

}

