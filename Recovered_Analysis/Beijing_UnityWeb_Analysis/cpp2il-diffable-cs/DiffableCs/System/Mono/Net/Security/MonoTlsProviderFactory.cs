namespace Mono.Net.Security;

internal static class MonoTlsProviderFactory
{
	private static object locker; //Field offset: 0x0
	private static bool initialized; //Field offset: 0x4
	private static MonoTlsProvider defaultProvider; //Field offset: 0x8
	private static Dictionary<string, Tuple<Guid, string>> providerRegistration; //Field offset: 0xC
	private static Dictionary<Guid, MonoTlsProvider> providerCache; //Field offset: 0x10
	internal static readonly Guid UnityTlsId; //Field offset: 0x14
	internal static readonly Guid AppleTlsId; //Field offset: 0x24
	internal static readonly Guid BtlsId; //Field offset: 0x34
	internal static readonly Guid LegacyId; //Field offset: 0x44

	private static MonoTlsProviderFactory() { }

	private static MonoTlsProvider CreateDefaultProviderImpl() { }

	internal static MonoTlsProvider GetProvider() { }

	internal static MonoTlsProvider GetProviderInternal() { }

	internal static void InitializeInternal() { }

	private static void InitializeProviderRegistration() { }

	private static MonoTlsProvider LookupProvider(string name, bool throwOnError) { }

}

