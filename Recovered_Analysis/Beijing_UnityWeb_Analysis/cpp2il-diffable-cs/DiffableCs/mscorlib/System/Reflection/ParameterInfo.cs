namespace System.Reflection;

public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo
{
	protected Type ClassImpl; //Field offset: 0x8
	protected object DefaultValueImpl; //Field offset: 0xC
	protected MemberInfo MemberImpl; //Field offset: 0x10
	protected string NameImpl; //Field offset: 0x14
	protected int PositionImpl; //Field offset: 0x18
	protected ParameterAttributes AttrsImpl; //Field offset: 0x1C
	internal MarshalAsAttribute marshalAs; //Field offset: 0x20

	public virtual ParameterAttributes Attributes
	{
		 get { } //Length: 6
	}

	public virtual object DefaultValue
	{
		 get { } //Length: 6
	}

	public bool IsIn
	{
		 get { } //Length: 6
	}

	public bool IsOptional
	{
		 get { } //Length: 15
	}

	public bool IsOut
	{
		 get { } //Length: 15
	}

	public bool IsRetval
	{
		 get { } //Length: 15
	}

	public virtual string Name
	{
		 get { } //Length: 15
	}

	public virtual Type ParameterType
	{
		 get { } //Length: 310
	}

	public virtual int Position
	{
		 get { } //Length: 6
	}

	protected ParameterInfo() { }

	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	public virtual ParameterAttributes get_Attributes() { }

	public virtual object get_DefaultValue() { }

	public bool get_IsIn() { }

	public bool get_IsOptional() { }

	public bool get_IsOut() { }

	public bool get_IsRetval() { }

	public virtual string get_Name() { }

	public virtual Type get_ParameterType() { }

	public virtual int get_Position() { }

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	internal object GetDefaultValueImpl() { }

	internal object[] GetPseudoCustomAttributes() { }

	public object GetRealObject(StreamingContext context) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

	public override string ToString() { }

}

