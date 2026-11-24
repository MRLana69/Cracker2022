namespace System.Reflection;

public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName
{
	private string name; //Field offset: 0x8
	private string codebase; //Field offset: 0xC
	private int major; //Field offset: 0x10
	private int minor; //Field offset: 0x14
	private int build; //Field offset: 0x18
	private int revision; //Field offset: 0x1C
	private CultureInfo cultureinfo; //Field offset: 0x20
	private AssemblyNameFlags flags; //Field offset: 0x24
	private AssemblyHashAlgorithm hashalg; //Field offset: 0x28
	private StrongNameKeyPair keypair; //Field offset: 0x2C
	private byte[] publicKey; //Field offset: 0x30
	private byte[] keyToken; //Field offset: 0x34
	private AssemblyVersionCompatibility versioncompat; //Field offset: 0x38
	private Version version; //Field offset: 0x3C
	private ProcessorArchitecture processor_architecture; //Field offset: 0x40
	private AssemblyContentType contentType; //Field offset: 0x44

	public CultureInfo CultureInfo
	{
		 get { } //Length: 6
	}

	public AssemblyNameFlags Flags
	{
		 get { } //Length: 6
	}

	public string FullName
	{
		 get { } //Length: 6
	}

	private bool IsPublicKeyValid
	{
		 get { } //Length: 207
	}

	public string Name
	{
		 get { } //Length: 3
	}

	public Version Version
	{
		 get { } //Length: 558
		 set { } //Length: 931
	}

	public AssemblyName() { }

	public AssemblyName(string assemblyName) { }

	internal AssemblyName(SerializationInfo si, StreamingContext sc) { }

	public object Clone() { }

	private byte[] ComputePublicKeyToken() { }

	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }

	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	public CultureInfo get_CultureInfo() { }

	public AssemblyNameFlags get_Flags() { }

	public string get_FullName() { }

	private bool get_IsPublicKeyValid() { }

	public string get_Name() { }

	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	public Version get_Version() { }

	private static MonoAssemblyName* GetNativeName(nint assembly_ptr) { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public byte[] GetPublicKeyToken() { }

	private byte[] InternalGetPublicKeyToken() { }

	public void OnDeserialization(object sender) { }

	private static bool ParseAssemblyName(nint name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	public void set_Version(Version value) { }

	public override string ToString() { }

}

