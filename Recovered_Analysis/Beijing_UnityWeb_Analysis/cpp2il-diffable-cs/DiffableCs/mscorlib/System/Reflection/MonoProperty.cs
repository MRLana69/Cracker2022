namespace System.Reflection;

internal class MonoProperty : RuntimePropertyInfo
{
	private delegate Getter`2
	{

		public Getter`2(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(T _this, AsyncCallback callback, object object) { }

		public virtual R EndInvoke(IAsyncResult result) { }

		public virtual R Invoke(T _this) { }

	}

	private delegate GetterAdapter
	{

		public GetterAdapter(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(object _this, AsyncCallback callback, object object) { }

		public virtual object EndInvoke(IAsyncResult result) { }

		public virtual object Invoke(object _this) { }

	}

	private delegate StaticGetter`1
	{

		public StaticGetter`1(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual R EndInvoke(IAsyncResult result) { }

		public virtual R Invoke() { }

	}

	internal nint klass; //Field offset: 0x8
	internal nint prop; //Field offset: 0xC
	private MonoPropertyInfo info; //Field offset: 0x10
	private PInfo cached; //Field offset: 0x28
	private GetterAdapter cached_getter; //Field offset: 0x2C

	public override PropertyAttributes Attributes
	{
		 get { } //Length: 11
	}

	public override bool CanRead
	{
		 get { } //Length: 19
	}

	public override bool CanWrite
	{
		 get { } //Length: 27
	}

	public override Type DeclaringType
	{
		 get { } //Length: 19
	}

	public override string Name
	{
		 get { } //Length: 19
	}

	public override Type PropertyType
	{
		 get { } //Length: 27
	}

	public override Type ReflectedType
	{
		 get { } //Length: 83
	}

	public MonoProperty() { }

	private void CachePropertyInfo(PInfo flags) { }

	private static GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	public override PropertyAttributes get_Attributes() { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public override Type get_DeclaringType() { }

	public override string get_Name() { }

	public override Type get_PropertyType() { }

	public override Type get_ReflectedType() { }

	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	public override object GetConstantValue() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	public override MethodInfo GetGetMethod(bool nonPublic) { }

	public override ParameterInfo[] GetIndexParameters() { }

	public override Type[] GetOptionalCustomModifiers() { }

	public override object GetRawConstantValue() { }

	public override Type[] GetRequiredCustomModifiers() { }

	public override MethodInfo GetSetMethod(bool nonPublic) { }

	private static object GetterAdapterFrame(Getter<T, R> getter, object obj) { }

	public override object GetValue(object obj, object[] index) { }

	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	private static object StaticGetterAdapterFrame(StaticGetter<R> getter, object obj) { }

}

