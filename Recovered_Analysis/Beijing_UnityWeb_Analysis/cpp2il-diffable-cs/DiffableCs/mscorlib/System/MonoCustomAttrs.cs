namespace System;

internal static class MonoCustomAttrs
{
	private class AttributeInfo
	{
		private AttributeUsageAttribute _usage; //Field offset: 0x8
		private int _inheritanceLevel; //Field offset: 0xC

		public int InheritanceLevel
		{
			 get { } //Length: 6
		}

		public AttributeUsageAttribute Usage
		{
			 get { } //Length: 417
		}

		public AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel) { }

		public int get_InheritanceLevel() { }

		public AttributeUsageAttribute get_Usage() { }

	}

	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; //Field offset: 0x80000000
	private static Assembly corlib; //Field offset: 0x0
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; //Field offset: 0x4

	private static MonoCustomAttrs() { }

	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	private static object[] GetPseudoCustomAttributes(Type type) { }

	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	private static bool IsUserCattrProvider(object obj) { }

	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

}

