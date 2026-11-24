namespace System;

internal class DefaultBinder : Binder
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Type> <>9__3_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <SelectProperty>b__3_0(Type t) { }

	}

	internal class BinderState
	{
		internal int[] m_argsMap; //Field offset: 0x8
		internal int m_originalSize; //Field offset: 0xC
		internal bool m_isParamArray; //Field offset: 0x10

		internal BinderState(int[] argsMap, int originalSize, bool isParamArray) { }

	}


	public DefaultBinder() { }

	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) { }

	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	public override object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) { }

	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	internal static int GetHierarchyDepth(Type t) { }

	public override void ReorderArgumentArray(ref object[] args, object state) { }

	private static void ReorderParams(int[] paramOrder, object[] vars) { }

	public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

}

