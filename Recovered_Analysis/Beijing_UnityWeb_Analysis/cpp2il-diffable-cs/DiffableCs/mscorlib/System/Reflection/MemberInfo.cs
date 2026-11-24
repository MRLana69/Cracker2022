namespace System.Reflection;

public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo
{

	public abstract Type DeclaringType
	{
		 get { } //Length: 0
	}

	public abstract MemberTypes MemberType
	{
		 get { } //Length: 0
	}

	public virtual int MetadataToken
	{
		 get { } //Length: 73
	}

	public virtual Module Module
	{
		 get { } //Length: 7
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public abstract Type ReflectedType
	{
		 get { } //Length: 0
	}

	protected MemberInfo() { }

	public override bool Equals(object obj) { }

	public abstract Type get_DeclaringType() { }

	public abstract MemberTypes get_MemberType() { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public abstract string get_Name() { }

	public abstract Type get_ReflectedType() { }

	public abstract object[] GetCustomAttributes(bool inherit) { }

	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	public override int GetHashCode() { }

	public abstract bool IsDefined(Type attributeType, bool inherit) { }

	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

}

