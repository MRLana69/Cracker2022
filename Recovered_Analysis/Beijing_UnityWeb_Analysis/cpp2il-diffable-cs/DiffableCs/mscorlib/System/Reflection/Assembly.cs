namespace System.Reflection;

public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly
{
	internal class ResolveEventHolder
	{

		public ResolveEventHolder() { }

	}

	internal nint _mono_assembly; //Field offset: 0x8
	private ResolveEventHolder resolve_event_holder; //Field offset: 0xC
	private object _evidence; //Field offset: 0x10
	private object _minimum; //Field offset: 0x14
	private object _optional; //Field offset: 0x18
	private object _refuse; //Field offset: 0x1C
	private object _granted; //Field offset: 0x20
	private object _denied; //Field offset: 0x24
	private bool fromByteArray; //Field offset: 0x28
	private string assemblyName; //Field offset: 0x2C

	public virtual string CodeBase
	{
		 get { } //Length: 7
	}

	public virtual string FullName
	{
		 get { } //Length: 11
	}

	public bool IsFullyTrusted
	{
		 get { } //Length: 13
	}

	protected Assembly() { }

	private static Exception CreateNIE() { }

	public override bool Equals(object o) { }

	private string get_code_base(bool escaped) { }

	public virtual string get_CodeBase() { }

	private string get_fullname() { }

	public virtual string get_FullName() { }

	public bool get_IsFullyTrusted() { }

	internal static string GetAotId() { }

	public static Assembly GetAssembly(Type type) { }

	public static Assembly GetCallingAssembly() { }

	private string GetCodeBase(bool escaped) { }

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public static Assembly GetExecutingAssembly() { }

	public override int GetHashCode() { }

	internal nint GetManifestResourceInternal(string name, out int size, out Module module) { }

	public virtual Module GetModule(string name) { }

	public virtual Module[] GetModules(bool getResourceModules) { }

	internal virtual Module[] GetModulesInternal() { }

	public virtual AssemblyName GetName(bool copiedName) { }

	public virtual AssemblyName GetName() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual Type GetType(string name) { }

	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	public virtual Type[] GetTypes() { }

	internal virtual Type[] GetTypes(bool exportedOnly) { }

	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public static Assembly Load(string assemblyString) { }

	private static Assembly load_with_partial_name(string name, Evidence e) { }

	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	public static bool op_Equality(Assembly left, Assembly right) { }

	public static bool op_Inequality(Assembly left, Assembly right) { }

	public override string ToString() { }

}

