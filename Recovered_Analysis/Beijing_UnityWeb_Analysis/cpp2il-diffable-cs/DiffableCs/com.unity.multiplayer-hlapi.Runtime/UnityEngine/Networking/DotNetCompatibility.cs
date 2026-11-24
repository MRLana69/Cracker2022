namespace UnityEngine.Networking;

internal static class DotNetCompatibility
{

	internal static Type GetBaseType(Type type) { }

	internal static string GetErrorCode(SocketException e) { }

	internal static string GetMethodName(Delegate func) { }

}

