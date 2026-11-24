namespace System.Reflection;

internal sealed class MonoEvent : RuntimeEventInfo
{
	private nint klass; //Field offset: 0xC
	private nint handle; //Field offset: 0x10

	public override Type DeclaringType
	{
		 get { } //Length: 13
	}

	public override string Name
	{
		 get { } //Length: 31
	}

	public override Type ReflectedType
	{
		 get { } //Length: 31
	}

	public MonoEvent() { }

	public override Type get_DeclaringType() { }

	public override string get_Name() { }

	public override Type get_ReflectedType() { }

	public override MethodInfo GetAddMethod(bool nonPublic) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override string ToString() { }

}

