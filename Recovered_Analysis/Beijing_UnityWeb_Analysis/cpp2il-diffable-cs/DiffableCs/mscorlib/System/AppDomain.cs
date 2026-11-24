namespace System;

public sealed class AppDomain : MarshalByRefObject
{
	private static Dictionary<string, object> type_resolve_in_progress; //Field offset: 0x80000000
	private static Dictionary<string, object> assembly_resolve_in_progress; //Field offset: 0x80000004
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; //Field offset: 0x80000008
	private static object _principal; //Field offset: 0x8000000C
	private static string _process_guid; //Field offset: 0x0
	private static AppDomain default_domain; //Field offset: 0x4
	private nint _mono_app_domain; //Field offset: 0xC
	private object _evidence; //Field offset: 0x10
	private object _granted; //Field offset: 0x14
	private int _principalPolicy; //Field offset: 0x18
	private AssemblyLoadEventHandler AssemblyLoad; //Field offset: 0x1C
	private ResolveEventHandler AssemblyResolve; //Field offset: 0x20
	private EventHandler DomainUnload; //Field offset: 0x24
	private EventHandler ProcessExit; //Field offset: 0x28
	private ResolveEventHandler ResourceResolve; //Field offset: 0x2C
	private ResolveEventHandler TypeResolve; //Field offset: 0x30
	private UnhandledExceptionEventHandler UnhandledException; //Field offset: 0x34
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; //Field offset: 0x38
	private object _domain_manager; //Field offset: 0x3C
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; //Field offset: 0x40
	private object _activation; //Field offset: 0x44
	private object _applicationIdentity; //Field offset: 0x48
	private List<string> compatibility_switch; //Field offset: 0x4C

	public event EventHandler DomainUnload
	{
		 add { } //Length: 80
		 remove { } //Length: 111
	}

	public event UnhandledExceptionEventHandler UnhandledException
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public static AppDomain CurrentDomain
	{
		 get { } //Length: 37
	}

	private AppDomain() { }

	public void add_DomainUnload(EventHandler value) { }

	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	private void DoAssemblyLoad(Assembly assembly) { }

	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	private void DoDomainUnload() { }

	internal Assembly DoTypeResolve(object name_or_tb) { }

	public static AppDomain get_CurrentDomain() { }

	private Assembly[] GetAssemblies(bool refOnly) { }

	public Assembly[] GetAssemblies() { }

	private static AppDomain getCurDomain() { }

	public object GetData(string name) { }

	private int getDomainID() { }

	private string getFriendlyName() { }

	internal byte[] GetMarshalledDomainObjRef() { }

	internal static string GetProcessGuid() { }

	public override object InitializeLifetimeService() { }

	internal static Context InternalGetContext() { }

	internal static Context InternalGetDefaultContext() { }

	internal static string InternalGetProcessGuid(string newguid) { }

	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	internal static void InternalPopDomainRef() { }

	internal static void InternalPushDomainRefByID(int domain_id) { }

	internal static Context InternalSetContext(Context context) { }

	private static AppDomain InternalSetDomain(AppDomain context) { }

	private static AppDomain InternalSetDomainByID(int domain_id) { }

	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	public bool IsFinalizingForUnload() { }

	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	public Assembly Load(string assemblyString) { }

	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	public void remove_DomainUnload(EventHandler value) { }

	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	public override string ToString() { }

}

