namespace SYBO.Components.Utilities;

public static class ReflectionWrapper
{
	private sealed class <GetDerivedTypes>d__10 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private Type <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private Type parentType; //Field offset: 0x14
		public Type <>3__parentType; //Field offset: 0x18
		private Assembly[] <>7__wrap1; //Field offset: 0x1C
		private int <>7__wrap2; //Field offset: 0x20
		private Type[] <>7__wrap3; //Field offset: 0x24
		private int <>7__wrap4; //Field offset: 0x28

		private Type System.Collections.Generic.IEnumerator<System.Type>.Current
		{
			 get { } //Length: 312
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GetDerivedTypes>d__10(int <>1__state) { }

		private bool MoveNext() { }

		private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator() { }

		private Type System.Collections.Generic.IEnumerator<System.Type>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}


	public static bool DerivesFrom(Type type, Type parentType) { }

	public static Assembly GetAssembly(Type type) { }

	internal static Type GetBaseType(Type type) { }

	public static ConstructorInfo GetConstructor(Type type) { }

	public static ConstructorInfo GetConstructor(Type type, Type[] types) { }

	public static ConstructorInfo[] GetConstructors(Type type, BindingFlags bindingFlags) { }

	public static Attribute GetCustomAttribute(MemberInfo type, Type attributeType) { }

	public static Attribute GetCustomAttribute(Type type, Type attributeType) { }

	public static IEnumerable<object> GetCustomAttributes(MemberInfo type, bool inherit) { }

	public static IEnumerable<Type> GetDerivedTypes(Type parentType) { }

	public static FieldInfo[] GetFields(Type type, BindingFlags bindingFlags) { }

	public static FieldInfo[] GetFieldsForTree(Type type, BindingFlags bindingFlags) { }

	private static void GetFieldsForTreeIntoSet(Type type, BindingFlags bindingFlags, Dictionary<nint, FieldInfo> resultSet) { }

	public static Type[] GetGenericArguments(Type type) { }

	public static Type GetInterface(Type type, Type interfaceType) { }

	public static MethodInfo GetMethod(Type type, string methodName, BindingFlags bindingFlags) { }

	public static Type[] GetTypes(Assembly assembly) { }

	public static object GetUninitializedObject(Type type) { }

	public static bool HasCustomAttributes(Type type, bool inherit) { }

	public static bool HasCustomAttributes(MemberInfo type, bool inherit) { }

	public static bool IsAbstract(Type type) { }

	public static bool IsEnum(Type type) { }

	public static bool IsGenericType(Type type) { }

	public static bool IsPrimitive(Type type) { }

	public static bool IsValueType(Type type) { }

}

