namespace System.Threading;

internal sealed class InternalThread : CriticalFinalizerObject
{
	private int lock_thread_id; //Field offset: 0x8
	private nint handle; //Field offset: 0xC
	private nint native_handle; //Field offset: 0x10
	private nint unused3; //Field offset: 0x14
	private nint name; //Field offset: 0x18
	private int name_len; //Field offset: 0x1C
	private ThreadState state; //Field offset: 0x20
	private object abort_exc; //Field offset: 0x24
	private int abort_state_handle; //Field offset: 0x28
	internal long thread_id; //Field offset: 0x30
	private nint debugger_thread; //Field offset: 0x38
	private nuint static_data; //Field offset: 0x3C
	private nint runtime_thread_info; //Field offset: 0x40
	private object current_appcontext; //Field offset: 0x44
	private object root_domain_thread; //Field offset: 0x48
	internal byte[] _serialized_principal; //Field offset: 0x4C
	internal int _serialized_principal_version; //Field offset: 0x50
	private nint appdomain_refs; //Field offset: 0x54
	private int interruption_requested; //Field offset: 0x58
	private nint synch_cs; //Field offset: 0x5C
	internal bool threadpool_thread; //Field offset: 0x60
	private bool thread_interrupt_requested; //Field offset: 0x61
	internal int stack_size; //Field offset: 0x64
	internal byte apartment_state; //Field offset: 0x68
	internal int critical_region_level; //Field offset: 0x6C
	internal int managed_id; //Field offset: 0x70
	private int small_id; //Field offset: 0x74
	private nint manage_callback; //Field offset: 0x78
	private nint unused4; //Field offset: 0x7C
	private nint flags; //Field offset: 0x80
	private nint thread_pinning_ref; //Field offset: 0x84
	private nint abort_protected_block_count; //Field offset: 0x88
	private int priority; //Field offset: 0x8C
	private nint owned_mutex; //Field offset: 0x90
	private nint suspended_event; //Field offset: 0x94
	private int self_suspended; //Field offset: 0x98
	private nint unused1; //Field offset: 0x9C
	private nint unused2; //Field offset: 0xA0
	private nint last; //Field offset: 0xA4

	public InternalThread() { }

	protected override void Finalize() { }

	private void Thread_free_internal() { }

}

