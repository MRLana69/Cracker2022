namespace System;

internal class RuntimeType : TypeInfo, ISerializable, ICloneable
{
	private struct ListBuilder`1
	{
		private T[] _items; //Field offset: 0x0
		private T _item; //Field offset: 0x0
		private int _count; //Field offset: 0x0
		private int _capacity; //Field offset: 0x0

		public int Count
		{
			 get { } //Length: 42
		}

		public T Item
		{
			 get { } //Length: 14
		}

		public ListBuilder`1(int capacity) { }

		public void Add(T item) { }

		public void CopyTo(object[] array, int index) { }

		public int get_Count() { }

		public T get_Item(int index) { }

		public T[] ToArray() { }

	}

	internal enum MemberListType
	{
		All = 0,
		CaseSensitive = 1,
		CaseInsensitive = 2,
		HandleToInfo = 3,
	}

	internal static readonly RuntimeType ValueType; //Field offset: 0x0
	private const BindingFlags ClassicBindingMask = 61696; //Field offset: 0x0
	private const BindingFlags BinderNonFieldGetSet = 16773888; //Field offset: 0x0
	private const BindingFlags BinderSetInvokeField = 2304; //Field offset: 0x0
	private const BindingFlags BinderGetSetField = 3072; //Field offset: 0x0
	private const BindingFlags BinderSetInvokeProperty = 8448; //Field offset: 0x0
	private const BindingFlags BinderNonCreateInstance = 15616; //Field offset: 0x0
	private const BindingFlags BinderGetSetProperty = 12288; //Field offset: 0x0
	private const BindingFlags MemberBindingMask = 255; //Field offset: 0x0
	private const BindingFlags InvocationMask = 65280; //Field offset: 0x0
	internal static readonly RuntimeType EnumType; //Field offset: 0x4
	private static readonly RuntimeType ObjectType; //Field offset: 0x8
	private static readonly RuntimeType StringType; //Field offset: 0xC
	private static readonly RuntimeType DelegateType; //Field offset: 0x10
	private static Type[] s_SICtorParamTypes; //Field offset: 0x14
	private static RuntimeType s_typedRef; //Field offset: 0x18
	private MonoTypeInfo type_info; //Field offset: 0xC
	internal object GenericCache; //Field offset: 0x10
	private RuntimeConstructorInfo m_serializationCtor; //Field offset: 0x14

	public override Assembly Assembly
	{
		 get { } //Length: 7
	}

	public override string AssemblyQualifiedName
	{
		 get { } //Length: 7
	}

	public override Type BaseType
	{
		 get { } //Length: 41
	}

	public override bool ContainsGenericParameters
	{
		 get { } //Length: 79
	}

	public override MethodBase DeclaringMethod
	{
		 get { } //Length: 7
	}

	public override Type DeclaringType
	{
		 get { } //Length: 13
	}

	public override string FullName
	{
		 get { } //Length: 161
	}

	public override GenericParameterAttributes GenericParameterAttributes
	{
		 get { } //Length: 9
	}

	public override int GenericParameterPosition
	{
		 get { } //Length: 44
	}

	public override bool IsEnum
	{
		 get { } //Length: 307
	}

	public override bool IsGenericParameter
	{
		 get { } //Length: 7
	}

	public override bool IsGenericType
	{
		 get { } //Length: 105
	}

	public override bool IsGenericTypeDefinition
	{
		 get { } //Length: 109
	}

	internal override bool IsSzArray
	{
		 get { } //Length: 107
	}

	public override MemberTypes MemberType
	{
		 get { } //Length: 9
	}

	public override int MetadataToken
	{
		 get { } //Length: 9
	}

	public override Module Module
	{
		 get { } //Length: 221
	}

	public override string Name
	{
		 get { } //Length: 10
	}

	public override string Namespace
	{
		 get { } //Length: 7
	}

	public override Type ReflectedType
	{
		 get { } //Length: 32
	}

	public override RuntimeTypeHandle TypeHandle
	{
		 get { } //Length: 7
	}

	public override Type UnderlyingSystemType
	{
		 get { } //Length: 411
	}

	private static RuntimeType() { }

	internal RuntimeType() { }

	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	public object Clone() { }

	private void CreateInstanceCheckThis() { }

	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	private static object CreateInstanceInternal(Type type) { }

	private object CreateInstanceMono(bool nonPublic) { }

	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	public override bool Equals(object obj) { }

	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out MemberListType listType) { }

	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out MemberListType listType) { }

	internal override string FormatTypeName(bool serialization) { }

	public override Assembly get_Assembly() { }

	public override string get_AssemblyQualifiedName() { }

	public override Type get_BaseType() { }

	public override bool get_ContainsGenericParameters() { }

	public override MethodBase get_DeclaringMethod() { }

	public override Type get_DeclaringType() { }

	public override string get_FullName() { }

	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	public override int get_GenericParameterPosition() { }

	public override bool get_IsEnum() { }

	public override bool get_IsGenericParameter() { }

	public override bool get_IsGenericType() { }

	public override bool get_IsGenericTypeDefinition() { }

	internal override bool get_IsSzArray() { }

	public override MemberTypes get_MemberType() { }

	public override int get_MetadataToken() { }

	public override Module get_Module() { }

	public override string get_Name() { }

	public override string get_Namespace() { }

	public override Type get_ReflectedType() { }

	public override RuntimeTypeHandle get_TypeHandle() { }

	public override Type get_UnderlyingSystemType() { }

	public override int GetArrayRank() { }

	protected override TypeAttributes GetAttributeFlagsImpl() { }

	private RuntimeType GetBaseType() { }

	private string GetCachedName(TypeNameKind kind) { }

	private ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	private nint GetConstructors_native(BindingFlags bindingAttr) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	internal MonoCMethod GetDefaultConstructor() { }

	private string GetDefaultMemberName() { }

	public override Type GetElementType() { }

	public override string GetEnumName(object value) { }

	public override string[] GetEnumNames() { }

	public override Type GetEnumUnderlyingType() { }

	public override Array GetEnumValues() { }

	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	private ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	private nint GetEvents_native(nint name, BindingFlags bindingAttr) { }

	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	private ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	private nint GetFields_native(nint name, BindingFlags bindingAttr) { }

	internal string getFullName(bool full_name, bool assembly_qualified) { }

	public override Type[] GetGenericArguments() { }

	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	internal RuntimeType[] GetGenericArgumentsInternal() { }

	private GenericParameterAttributes GetGenericParameterAttributes() { }

	public override Type[] GetGenericParameterConstraints() { }

	private int GetGenericParameterPosition() { }

	public override Type GetGenericTypeDefinition() { }

	public override int GetHashCode() { }

	public override Type GetInterface(string fullname, bool ignoreCase) { }

	public override Type[] GetInterfaces() { }

	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	private ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	internal nint GetMethodsByName_native(nint namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	private ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	private nint GetNestedTypes_native(nint name, BindingFlags bindingAttr) { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	private nint GetPropertiesByName_native(nint name, BindingFlags bindingAttr, bool icase) { }

	private ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	internal RuntimeAssembly GetRuntimeAssembly() { }

	internal RuntimeModule GetRuntimeModule() { }

	internal RuntimeConstructorInfo GetSerializationCtor() { }

	protected override TypeCode GetTypeCodeImpl() { }

	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	protected override bool HasElementTypeImpl() { }

	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	protected override bool IsArrayImpl() { }

	public override bool IsAssignableFrom(Type c) { }

	protected override bool IsByRefImpl() { }

	protected override bool IsCOMObjectImpl() { }

	protected override bool IsContextfulImpl() { }

	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override bool IsEnumDefined(object value) { }

	public override bool IsEquivalentTo(Type other) { }

	private bool IsGenericCOMObjectImpl() { }

	public override bool IsInstanceOfType(object o) { }

	protected override bool IsPointerImpl() { }

	protected override bool IsPrimitiveImpl() { }

	internal bool IsSpecialSerializableType() { }

	public override bool IsSubclassOf(Type type) { }

	protected override bool IsValueTypeImpl() { }

	private Type make_array_type(int rank) { }

	private Type make_byref_type() { }

	public override Type MakeArrayType(int rank) { }

	public override Type MakeArrayType() { }

	public override Type MakeByRefType() { }

	public override Type MakeGenericType(Type[] instantiation) { }

	private static Type MakeGenericType(Type gt, Type[] types) { }

	private static Type MakePointerType(Type type) { }

	public override Type MakePointerType() { }

	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	private static void SplitName(string fullname, out string name, out string ns) { }

	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	public override string ToString() { }

	private object TryConvertToType(object value, ref bool failed) { }

}

