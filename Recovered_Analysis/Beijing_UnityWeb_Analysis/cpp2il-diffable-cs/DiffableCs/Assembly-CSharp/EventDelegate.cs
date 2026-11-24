//Type is in global namespace

public class EventDelegate
{
	public delegate Callback
	{

		public Callback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public class Parameter
	{
		public Object obj; //Field offset: 0x8
		public string field; //Field offset: 0xC
		private object mValue; //Field offset: 0x10
		public Type expectedType; //Field offset: 0x14
		public bool cached; //Field offset: 0x18
		public PropertyInfo propInfo; //Field offset: 0x1C
		public FieldInfo fieldInfo; //Field offset: 0x20

		public Type type
		{
			 get { } //Length: 472
		}

		public object value
		{
			 get { } //Length: 6
			 set { } //Length: 144
		}

		public Parameter() { }

		public Parameter(Object obj, string field) { }

		public Parameter(object val) { }

		public Type get_type() { }

		public object get_value() { }

		public void set_value(object value) { }

	}

	private static int s_Hash; //Field offset: 0x0
	private MonoBehaviour mTarget; //Field offset: 0x8
	private string mMethodName; //Field offset: 0xC
	private Parameter[] mParameters; //Field offset: 0x10
	public bool oneShot; //Field offset: 0x14
	private Callback mCachedCallback; //Field offset: 0x18
	private bool mRawDelegate; //Field offset: 0x1C
	private bool mCached; //Field offset: 0x1D
	private MethodInfo mMethod; //Field offset: 0x20
	private ParameterInfo[] mParameterInfos; //Field offset: 0x24
	private object[] mArgs; //Field offset: 0x28

	public bool isEnabled
	{
		 get { } //Length: 155
	}

	public bool isValid
	{
		 get { } //Length: 23
	}

	public string methodName
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	public Parameter[] parameters
	{
		 get { } //Length: 6
	}

	public MonoBehaviour target
	{
		 get { } //Length: 1021
		 set { } //Length: 17
	}

	private static EventDelegate() { }

	public EventDelegate(MonoBehaviour target, string methodName) { }

	public EventDelegate() { }

	public EventDelegate(Callback call) { }

	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot) { }

	public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot) { }

	public static EventDelegate Add(List<EventDelegate> list, Callback callback) { }

	public static void Add(List<EventDelegate> list, EventDelegate ev) { }

	private void Cache() { }

	public void Clear() { }

	public override bool Equals(object obj) { }

	public bool Execute() { }

	public static void Execute(List<EventDelegate> list) { }

	public bool get_isEnabled() { }

	public bool get_isValid() { }

	public string get_methodName() { }

	public Parameter[] get_parameters() { }

	public MonoBehaviour get_target() { }

	public override int GetHashCode() { }

	private static string GetMethodName(Callback callback) { }

	public static bool IsValid(List<EventDelegate> list) { }

	private static bool IsValid(Callback callback) { }

	public static bool Remove(List<EventDelegate> list, Callback callback) { }

	public static bool Remove(List<EventDelegate> list, EventDelegate ev) { }

	private void Set(Callback call) { }

	public static EventDelegate Set(List<EventDelegate> list, Callback callback) { }

	public static void Set(List<EventDelegate> list, EventDelegate del) { }

	public void Set(MonoBehaviour target, string methodName) { }

	public void set_methodName(string value) { }

	public void set_target(MonoBehaviour value) { }

	public override string ToString() { }

}

