namespace System;

public abstract class Type : MemberInfo, _Type
{
	public static readonly MemberFilter FilterAttribute; //Field offset: 0x0
	private const BindingFlags DefaultLookup = 28; //Field offset: 0x0
	internal const BindingFlags DeclaredOnlyLookup = 62; //Field offset: 0x0
	public static readonly MemberFilter FilterName; //Field offset: 0x4
	public static readonly MemberFilter FilterNameIgnoreCase; //Field offset: 0x8
	public static readonly object Missing; //Field offset: 0xC
	public static readonly char Delimiter; //Field offset: 0x10
	public static readonly Type[] EmptyTypes; //Field offset: 0x14
	private static Binder defaultBinder; //Field offset: 0x18
	internal RuntimeTypeHandle _impl; //Field offset: 0x8

	public abstract Assembly Assembly
	{
		 get { } //Length: 0
	}

	public abstract string AssemblyQualifiedName
	{
		 get { } //Length: 0
	}

	public TypeAttributes Attributes
	{
		 get { } //Length: 82
	}

	public abstract Type BaseType
	{
		 get { } //Length: 0
	}

	public virtual bool ContainsGenericParameters
	{
		 get { } //Length: 85
	}

	public virtual MethodBase DeclaringMethod
	{
		 get { } //Length: 3
	}

	public override Type DeclaringType
	{
		 get { } //Length: 3
	}

	public static Binder DefaultBinder
	{
		 get { } //Length: 166
	}

	public abstract string FullName
	{
		 get { } //Length: 0
	}

	public virtual GenericParameterAttributes GenericParameterAttributes
	{
		 get { } //Length: 10
	}

	public virtual int GenericParameterPosition
	{
		 get { } //Length: 3
	}

	public bool HasElementType
	{
		 get { } //Length: 10
	}

	public bool IsAbstract
	{
		 get { } //Length: 10
	}

	public bool IsArray
	{
		 get { } //Length: 130
	}

	public bool IsByRef
	{
		 get { } //Length: 134
	}

	public bool IsClass
	{
		 get { } //Length: 16
	}

	public bool IsCOMObject
	{
		 get { } //Length: 10
	}

	public bool IsContextful
	{
		 get { } //Length: 10
	}

	public virtual bool IsEnum
	{
		 get { } //Length: 17
	}

	public bool IsExplicitLayout
	{
		 get { } //Length: 16
	}

	public virtual bool IsGenericParameter
	{
		 get { } //Length: 3
	}

	public virtual bool IsGenericType
	{
		 get { } //Length: 3
	}

	public virtual bool IsGenericTypeDefinition
	{
		 get { } //Length: 3
	}

	public bool IsInterface
	{
		 get { } //Length: 30
	}

	public bool IsMarshalByRef
	{
		 get { } //Length: 10
	}

	public bool IsNested
	{
		 get { } //Length: 11
	}

	public bool IsNestedAssembly
	{
		 get { } //Length: 16
	}

	public bool IsNestedPublic
	{
		 get { } //Length: 16
	}

	public bool IsNotPublic
	{
		 get { } //Length: 73
	}

	public bool IsPointer
	{
		 get { } //Length: 10
	}

	public bool IsPrimitive
	{
		 get { } //Length: 10
	}

	public bool IsPublic
	{
		 get { } //Length: 14
	}

	public bool IsSealed
	{
		 get { } //Length: 17
	}

	public virtual bool IsSerializable
	{
		 get { } //Length: 98
	}

	internal virtual bool IsSzArray
	{
		 get { } //Length: 10
	}

	public bool IsValueType
	{
		 get { } //Length: 116
	}

	public override MemberTypes MemberType
	{
		 get { } //Length: 20
	}

	public abstract Module Module
	{
		 get { } //Length: 0
	}

	public abstract string Namespace
	{
		 get { } //Length: 0
	}

	public override Type ReflectedType
	{
		 get { } //Length: 3
	}

	public virtual RuntimeTypeHandle TypeHandle
	{
		 get { } //Length: 195
	}

	public abstract Type UnderlyingSystemType
	{
		 get { } //Length: 0
	}

	private static Type() { }

	protected Type() { }

	private static int BinarySearch(Array array, object value) { }

	private static void CreateBinder() { }

	public virtual bool Equals(Type o) { }

	public override bool Equals(object o) { }

	internal virtual string FormatTypeName(bool serialization) { }

	internal string FormatTypeName() { }

	public abstract Assembly get_Assembly() { }

	public abstract string get_AssemblyQualifiedName() { }

	public TypeAttributes get_Attributes() { }

	public abstract Type get_BaseType() { }

	public virtual bool get_ContainsGenericParameters() { }

	public virtual MethodBase get_DeclaringMethod() { }

	public override Type get_DeclaringType() { }

	public static Binder get_DefaultBinder() { }

	public abstract string get_FullName() { }

	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	public virtual int get_GenericParameterPosition() { }

	public bool get_HasElementType() { }

	public bool get_IsAbstract() { }

	public bool get_IsArray() { }

	public bool get_IsByRef() { }

	public bool get_IsClass() { }

	public bool get_IsCOMObject() { }

	public bool get_IsContextful() { }

	public virtual bool get_IsEnum() { }

	public bool get_IsExplicitLayout() { }

	public virtual bool get_IsGenericParameter() { }

	public virtual bool get_IsGenericType() { }

	public virtual bool get_IsGenericTypeDefinition() { }

	public bool get_IsInterface() { }

	public bool get_IsMarshalByRef() { }

	public bool get_IsNested() { }

	public bool get_IsNestedAssembly() { }

	public bool get_IsNestedPublic() { }

	public bool get_IsNotPublic() { }

	public bool get_IsPointer() { }

	public bool get_IsPrimitive() { }

	public bool get_IsPublic() { }

	public bool get_IsSealed() { }

	public virtual bool get_IsSerializable() { }

	internal virtual bool get_IsSzArray() { }

	public bool get_IsValueType() { }

	public override MemberTypes get_MemberType() { }

	public abstract Module get_Module() { }

	public abstract string get_Namespace() { }

	public override Type get_ReflectedType() { }

	public virtual RuntimeTypeHandle get_TypeHandle() { }

	public abstract Type get_UnderlyingSystemType() { }

	public virtual int GetArrayRank() { }

	protected abstract TypeAttributes GetAttributeFlagsImpl() { }

	public ConstructorInfo GetConstructor(Type[] types) { }

	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	public ConstructorInfo[] GetConstructors() { }

	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	public abstract Type GetElementType() { }

	private void GetEnumData(out string[] enumNames, out Array enumValues) { }

	public virtual string GetEnumName(object value) { }

	public virtual string[] GetEnumNames() { }

	private Array GetEnumRawConstantValues() { }

	public virtual Type GetEnumUnderlyingType() { }

	public virtual Array GetEnumValues() { }

	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	public FieldInfo GetField(string name) { }

	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	public virtual Type[] GetGenericArguments() { }

	public virtual Type[] GetGenericParameterConstraints() { }

	public virtual Type GetGenericTypeDefinition() { }

	public override int GetHashCode() { }

	public abstract Type GetInterface(string name, bool ignoreCase) { }

	public Type GetInterface(string name) { }

	public abstract Type[] GetInterfaces() { }

	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	public MemberInfo[] GetMember(string name) { }

	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	public MethodInfo GetMethod(string name, Type[] types) { }

	public MethodInfo GetMethod(string name) { }

	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	public MethodInfo[] GetMethods() { }

	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	public abstract Type GetNestedType(string name, BindingFlags bindingAttr) { }

	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	public PropertyInfo GetProperty(string name, Type returnType) { }

	public PropertyInfo GetProperty(string name) { }

	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	internal Type GetRootElementType() { }

	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

	public static Type GetType(string typeName) { }

	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	public static Type GetType(string typeName, bool throwOnError) { }

	public Type GetType() { }

	public static TypeCode GetTypeCode(Type type) { }

	protected virtual TypeCode GetTypeCodeImpl() { }

	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	protected abstract bool HasElementTypeImpl() { }

	internal bool ImplementInterface(Type ifaceType) { }

	private static Type internal_from_handle(nint handle) { }

	private static Type internal_from_name(string name, bool throwOnError, bool ignoreCase) { }

	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	protected abstract bool IsArrayImpl() { }

	public virtual bool IsAssignableFrom(Type c) { }

	protected abstract bool IsByRefImpl() { }

	protected abstract bool IsCOMObjectImpl() { }

	protected virtual bool IsContextfulImpl() { }

	public virtual bool IsEnumDefined(object value) { }

	public virtual bool IsEquivalentTo(Type other) { }

	public virtual bool IsInstanceOfType(object o) { }

	internal static bool IsIntegerType(Type t) { }

	protected virtual bool IsMarshalByRefImpl() { }

	protected abstract bool IsPointerImpl() { }

	protected abstract bool IsPrimitiveImpl() { }

	public virtual bool IsSubclassOf(Type c) { }

	protected virtual bool IsValueTypeImpl() { }

	public virtual Type MakeArrayType(int rank) { }

	public virtual Type MakeArrayType() { }

	public virtual Type MakeByRefType() { }

	public virtual Type MakeGenericType(Type[] typeArguments) { }

	public virtual Type MakePointerType() { }

	public static bool op_Equality(Type left, Type right) { }

	public static bool op_Inequality(Type left, Type right) { }

	public override string ToString() { }

}

