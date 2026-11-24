namespace System.Reflection;

public abstract class Module : ISerializable, ICustomAttributeProvider, _Module
{
	public static readonly TypeFilter FilterTypeName; //Field offset: 0x0
	private const BindingFlags defaultBindingFlags = 28; //Field offset: 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; //Field offset: 0x4
	internal nint _impl; //Field offset: 0x8
	internal Assembly assembly; //Field offset: 0xC
	internal string fqname; //Field offset: 0x10
	internal string name; //Field offset: 0x14
	internal string scopename; //Field offset: 0x18
	internal bool is_resource; //Field offset: 0x1C
	internal int token; //Field offset: 0x20

	public virtual Assembly Assembly
	{
		 get { } //Length: 13
	}

	public virtual Guid ModuleVersionId
	{
		 get { } //Length: 36
	}

	public virtual string ScopeName
	{
		 get { } //Length: 93
	}

	private static Module() { }

	protected Module() { }

	private static Exception CreateNIE() { }

	public override bool Equals(object o) { }

	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	public virtual Assembly get_Assembly() { }

	public virtual Guid get_ModuleVersionId() { }

	public virtual string get_ScopeName() { }

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	private string GetGuidInternal() { }

	public override int GetHashCode() { }

	internal virtual Guid GetModuleVersionId() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual bool IsResource() { }

	public static bool op_Equality(Module left, Module right) { }

	public override string ToString() { }

}

