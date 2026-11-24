namespace SYBO.Components.Utilities;

public static class SubTypeReflector
{

	public static List<Type> GetSubTypes() { }

	public static List<Type> GetSubTypes(Type typeT) { }

	private static bool IsCorrectType(Type type, Type typeT) { }

	private static bool IsSubclassOfGenericType(Type type, Type genericType) { }

	private static bool IsUnwantedAssembly(Assembly assembly) { }

}

