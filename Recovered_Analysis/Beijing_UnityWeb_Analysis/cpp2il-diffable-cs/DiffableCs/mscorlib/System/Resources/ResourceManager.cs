namespace System.Resources;

public class ResourceManager
{
	internal class CultureNameResourceSetPair
	{

		public CultureNameResourceSetPair() { }

	}

	internal class ResourceManagerMediator
	{
		private ResourceManager _rm; //Field offset: 0x8

		internal ResourceManagerMediator(ResourceManager rm) { }

	}

	public static readonly int MagicNumber; //Field offset: 0x0
	public static readonly int HeaderVersionNumber; //Field offset: 0x4
	private static readonly Type _minResourceSet; //Field offset: 0x8
	internal static readonly string ResReaderTypeName; //Field offset: 0xC
	internal static readonly string ResSetTypeName; //Field offset: 0x10
	internal static readonly string MscorlibName; //Field offset: 0x14
	internal static readonly int DEBUG; //Field offset: 0x18
	protected Hashtable ResourceSets; //Field offset: 0x8
	private Dictionary<string, ResourceSet> _resourceSets; //Field offset: 0xC
	protected Assembly MainAssembly; //Field offset: 0x10
	private CultureInfo _neutralResourcesCulture; //Field offset: 0x14
	private CultureNameResourceSetPair _lastUsedResourceCache; //Field offset: 0x18
	private bool UseManifest; //Field offset: 0x1C
	private bool UseSatelliteAssem; //Field offset: 0x1D
	private UltimateResourceFallbackLocation _fallbackLoc; //Field offset: 0x20
	private Assembly _callingAssembly; //Field offset: 0x24
	private RuntimeAssembly m_callingAssembly; //Field offset: 0x28
	private IResourceGroveler resourceGroveler; //Field offset: 0x2C

	private static ResourceManager() { }

	protected ResourceManager() { }

	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	private void Init() { }

	private void OnDeserialized(StreamingContext ctx) { }

	private void OnDeserializing(StreamingContext ctx) { }

	private void OnSerializing(StreamingContext ctx) { }

}

