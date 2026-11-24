namespace System;

public abstract class Delegate : ICloneable, ISerializable
{
	private nint method_ptr; //Field offset: 0x8
	private nint invoke_impl; //Field offset: 0xC
	private object m_target; //Field offset: 0x10
	private nint method; //Field offset: 0x14
	private nint delegate_trampoline; //Field offset: 0x18
	private nint extra_arg; //Field offset: 0x1C
	private nint method_code; //Field offset: 0x20
	private MethodInfo method_info; //Field offset: 0x24
	private MethodInfo original_method_info; //Field offset: 0x28
	private DelegateData data; //Field offset: 0x2C
	private bool method_is_virtual; //Field offset: 0x30

	public MethodInfo Method
	{
		 get { } //Length: 9
	}

	public object Target
	{
		 get { } //Length: 42
	}

	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }

	private static bool arg_type_match(Type delArgType, Type argType) { }

	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	public virtual object Clone() { }

	public static Delegate Combine(Delegate[] delegates) { }

	public static Delegate Combine(Delegate a, Delegate b) { }

	protected virtual Delegate CombineImpl(Delegate d) { }

	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, object target, string method) { }

	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method) { }

	public override bool Equals(object obj) { }

	public MethodInfo get_Method() { }

	public object get_Target() { }

	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	public override int GetHashCode() { }

	public virtual Delegate[] GetInvocationList() { }

	protected virtual MethodInfo GetMethodImpl() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private MethodInfo GetVirtualMethod_internal() { }

	public static bool op_Equality(Delegate d1, Delegate d2) { }

	public static bool op_Inequality(Delegate d1, Delegate d2) { }

	public static Delegate Remove(Delegate source, Delegate value) { }

	protected virtual Delegate RemoveImpl(Delegate d) { }

	private static bool return_type_match(Type delReturnType, Type returnType) { }

}

