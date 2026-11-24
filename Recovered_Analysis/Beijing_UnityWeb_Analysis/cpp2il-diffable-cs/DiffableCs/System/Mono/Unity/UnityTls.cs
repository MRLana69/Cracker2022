namespace Mono.Unity;

internal static class UnityTls
{
	public enum unitytls_ciphersuite
	{
		UNITYTLS_CIPHERSUITE_INVALID = 16777215,
	}

	public enum unitytls_error_code
	{
		UNITYTLS_SUCCESS = 0,
		UNITYTLS_INVALID_ARGUMENT = 1,
		UNITYTLS_INVALID_FORMAT = 2,
		UNITYTLS_INVALID_PASSWORD = 3,
		UNITYTLS_INVALID_STATE = 4,
		UNITYTLS_BUFFER_OVERFLOW = 5,
		UNITYTLS_OUT_OF_MEMORY = 6,
		UNITYTLS_INTERNAL_ERROR = 7,
		UNITYTLS_NOT_SUPPORTED = 8,
		UNITYTLS_ENTROPY_SOURCE_FAILED = 9,
		UNITYTLS_STREAM_CLOSED = 10,
		UNITYTLS_USER_CUSTOM_ERROR_START = 1048576,
		UNITYTLS_USER_WOULD_BLOCK = 1048577,
		UNITYTLS_USER_READ_FAILED = 1048578,
		UNITYTLS_USER_WRITE_FAILED = 1048579,
		UNITYTLS_USER_UNKNOWN_ERROR = 1048580,
		UNITYTLS_USER_CUSTOM_ERROR_END = 2097152,
	}

	public struct unitytls_errorstate
	{
		private uint magic; //Field offset: 0x0
		public unitytls_error_code code; //Field offset: 0x4
		private ulong reserved; //Field offset: 0x8

	}

	public class unitytls_interface_struct
	{
		public delegate unitytls_errorstate_create_t
		{

			public unitytls_errorstate_create_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

			public virtual unitytls_errorstate EndInvoke(IAsyncResult result) { }

			public virtual unitytls_errorstate Invoke() { }

		}

		public delegate unitytls_errorstate_raise_error_t
		{

			public unitytls_errorstate_raise_error_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_errorstate* errorState, unitytls_error_code errorCode, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_errorstate* errorState, unitytls_error_code errorCode) { }

		}

		public delegate unitytls_key_free_t
		{

			public unitytls_key_free_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_key* key, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_key* key) { }

		}

		public delegate unitytls_key_get_ref_t
		{

			public unitytls_key_get_ref_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_key* key, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_key_ref EndInvoke(IAsyncResult result) { }

			public virtual unitytls_key_ref Invoke(unitytls_key* key, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_key_parse_der_t
		{

			public unitytls_key_parse_der_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_key* EndInvoke(IAsyncResult result) { }

			public virtual unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_key_parse_pem_t
		{

			public unitytls_key_parse_pem_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_key* EndInvoke(IAsyncResult result) { }

			public virtual unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_random_generate_bytes_t
		{

			public unitytls_random_generate_bytes_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(byte* buffer, nint bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(byte* buffer, nint bufferLen, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_create_client_t
		{

			public unitytls_tlsctx_create_client_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, byte* cn, nint cnLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_tlsctx* EndInvoke(IAsyncResult result) { }

			public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, byte* cn, nint cnLen, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_create_server_t
		{

			public unitytls_tlsctx_create_server_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_tlsctx* EndInvoke(IAsyncResult result) { }

			public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_free_t
		{

			public unitytls_tlsctx_free_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_tlsctx* ctx) { }

		}

		public delegate unitytls_tlsctx_get_ciphersuite_t
		{

			public unitytls_tlsctx_get_ciphersuite_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_ciphersuite EndInvoke(IAsyncResult result) { }

			public virtual unitytls_ciphersuite Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_get_protocol_t
		{

			public unitytls_tlsctx_get_protocol_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_protocol EndInvoke(IAsyncResult result) { }

			public virtual unitytls_protocol Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_notify_close_t
		{

			public unitytls_tlsctx_notify_close_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_process_handshake_t
		{

			public unitytls_tlsctx_process_handshake_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

			public virtual unitytls_x509verify_result Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_read_t
		{

			public unitytls_tlsctx_read_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, byte* buffer, nint bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual nint EndInvoke(IAsyncResult result) { }

			public virtual nint Invoke(unitytls_tlsctx* ctx, byte* buffer, nint bufferLen, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_server_require_client_authentication_t
		{

			public unitytls_tlsctx_server_require_client_authentication_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_set_certificate_callback_t
		{

			public unitytls_tlsctx_set_certificate_callback_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, void* userData, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, void* userData, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_set_supported_ciphersuites_t
		{

			public unitytls_tlsctx_set_supported_ciphersuites_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, nint supportedCiphersuitesLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, nint supportedCiphersuitesLen, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_set_trace_callback_t
		{

			public unitytls_tlsctx_set_trace_callback_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, void* userData, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, void* userData, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_set_x509verify_callback_t
		{

			public unitytls_tlsctx_set_x509verify_callback_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, void* userData, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, void* userData, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_tlsctx_write_t
		{

			public unitytls_tlsctx_write_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_tlsctx* ctx, byte* data, nint bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual nint EndInvoke(IAsyncResult result) { }

			public virtual nint Invoke(unitytls_tlsctx* ctx, byte* data, nint bufferLen, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_x509_export_der_t
		{

			public unitytls_x509_export_der_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_x509_ref cert, byte* buffer, nint bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual nint EndInvoke(IAsyncResult result) { }

			public virtual nint Invoke(unitytls_x509_ref cert, byte* buffer, nint bufferLen, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_x509list_append_der_t
		{

			public unitytls_x509list_append_der_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_x509list* list, byte* buffer, nint bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_x509list* list, byte* buffer, nint bufferLen, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_x509list_append_t
		{

			public unitytls_x509list_append_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_x509list_create_t
		{

			public unitytls_x509list_create_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_x509list* EndInvoke(IAsyncResult result) { }

			public virtual unitytls_x509list* Invoke(unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_x509list_free_t
		{

			public unitytls_x509list_free_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_x509list* list, AsyncCallback callback, object object) { }

			public virtual void EndInvoke(IAsyncResult result) { }

			public virtual void Invoke(unitytls_x509list* list) { }

		}

		public delegate unitytls_x509list_get_ref_t
		{

			public unitytls_x509list_get_ref_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_x509list* list, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_x509list_ref EndInvoke(IAsyncResult result) { }

			public virtual unitytls_x509list_ref Invoke(unitytls_x509list* list, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_x509list_get_x509_t
		{

			public unitytls_x509list_get_x509_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_x509list_ref list, nint index, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_x509_ref EndInvoke(IAsyncResult result) { }

			public virtual unitytls_x509_ref Invoke(unitytls_x509list_ref list, nint index, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_x509verify_default_ca_t
		{

			public unitytls_x509verify_default_ca_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_x509list_ref chain, byte* cn, nint cnLen, unitytls_x509verify_callback cb, void* userData, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

			public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, byte* cn, nint cnLen, unitytls_x509verify_callback cb, void* userData, unitytls_errorstate* errorState) { }

		}

		public delegate unitytls_x509verify_explicit_ca_t
		{

			public unitytls_x509verify_explicit_ca_t(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, byte* cn, nint cnLen, unitytls_x509verify_callback cb, void* userData, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

			public virtual unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

			public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, byte* cn, nint cnLen, unitytls_x509verify_callback cb, void* userData, unitytls_errorstate* errorState) { }

		}

		public readonly ulong UNITYTLS_INVALID_HANDLE; //Field offset: 0x8
		public readonly unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT; //Field offset: 0x10
		public unitytls_errorstate_create_t unitytls_errorstate_create; //Field offset: 0x18
		public unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error; //Field offset: 0x1C
		public unitytls_key_get_ref_t unitytls_key_get_ref; //Field offset: 0x20
		public unitytls_key_parse_der_t unitytls_key_parse_der; //Field offset: 0x24
		public unitytls_key_parse_pem_t unitytls_key_parse_pem; //Field offset: 0x28
		public unitytls_key_free_t unitytls_key_free; //Field offset: 0x2C
		public unitytls_x509_export_der_t unitytls_x509_export_der; //Field offset: 0x30
		public unitytls_x509list_get_ref_t unitytls_x509list_get_ref; //Field offset: 0x34
		public unitytls_x509list_get_x509_t unitytls_x509list_get_x509; //Field offset: 0x38
		public unitytls_x509list_create_t unitytls_x509list_create; //Field offset: 0x3C
		public unitytls_x509list_append_t unitytls_x509list_append; //Field offset: 0x40
		public unitytls_x509list_append_der_t unitytls_x509list_append_der; //Field offset: 0x44
		public unitytls_x509list_append_der_t unitytls_x509list_append_pem; //Field offset: 0x48
		public unitytls_x509list_free_t unitytls_x509list_free; //Field offset: 0x4C
		public unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca; //Field offset: 0x50
		public unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca; //Field offset: 0x54
		public unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server; //Field offset: 0x58
		public unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client; //Field offset: 0x5C
		public unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication; //Field offset: 0x60
		public unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback; //Field offset: 0x64
		public unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback; //Field offset: 0x68
		public unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback; //Field offset: 0x6C
		public unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites; //Field offset: 0x70
		public unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite; //Field offset: 0x74
		public unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol; //Field offset: 0x78
		public unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake; //Field offset: 0x7C
		public unitytls_tlsctx_read_t unitytls_tlsctx_read; //Field offset: 0x80
		public unitytls_tlsctx_write_t unitytls_tlsctx_write; //Field offset: 0x84
		public unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close; //Field offset: 0x88
		public unitytls_tlsctx_free_t unitytls_tlsctx_free; //Field offset: 0x8C
		public unitytls_random_generate_bytes_t unitytls_random_generate_bytes; //Field offset: 0x90

		public unitytls_interface_struct() { }

	}

	public struct unitytls_key
	{

	}

	public struct unitytls_key_ref
	{
		public ulong handle; //Field offset: 0x0

	}

	public enum unitytls_protocol
	{
		UNITYTLS_PROTOCOL_TLS_1_0 = 0,
		UNITYTLS_PROTOCOL_TLS_1_1 = 1,
		UNITYTLS_PROTOCOL_TLS_1_2 = 2,
		UNITYTLS_PROTOCOL_INVALID = 3,
	}

	public struct unitytls_tlsctx
	{

	}

	public struct unitytls_tlsctx_callbacks
	{
		public unitytls_tlsctx_read_callback read; //Field offset: 0x0
		public unitytls_tlsctx_write_callback write; //Field offset: 0x4
		public void* data; //Field offset: 0x8

	}

	public delegate unitytls_tlsctx_certificate_callback
	{

		public unitytls_tlsctx_certificate_callback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(void* userData, unitytls_tlsctx* ctx, byte* cn, nint cnLen, unitytls_x509name* caList, nint caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(void* userData, unitytls_tlsctx* ctx, byte* cn, nint cnLen, unitytls_x509name* caList, nint caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	}

	public struct unitytls_tlsctx_protocolrange
	{
		public unitytls_protocol min; //Field offset: 0x0
		public unitytls_protocol max; //Field offset: 0x4

	}

	public delegate unitytls_tlsctx_read_callback
	{

		public unitytls_tlsctx_read_callback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(void* userData, byte* buffer, nint bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

		public virtual nint EndInvoke(IAsyncResult result) { }

		public virtual nint Invoke(void* userData, byte* buffer, nint bufferLen, unitytls_errorstate* errorState) { }

	}

	public delegate unitytls_tlsctx_trace_callback
	{

		public unitytls_tlsctx_trace_callback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(void* userData, unitytls_tlsctx* ctx, byte* traceMessage, nint traceMessageLen, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(void* userData, unitytls_tlsctx* ctx, byte* traceMessage, nint traceMessageLen) { }

	}

	public delegate unitytls_tlsctx_write_callback
	{

		public unitytls_tlsctx_write_callback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(void* userData, byte* data, nint bufferLen, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

		public virtual nint EndInvoke(IAsyncResult result) { }

		public virtual nint Invoke(void* userData, byte* data, nint bufferLen, unitytls_errorstate* errorState) { }

	}

	public delegate unitytls_tlsctx_x509verify_callback
	{

		public unitytls_tlsctx_x509verify_callback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

		public virtual unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

		public virtual unitytls_x509verify_result Invoke(void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	}

	public struct unitytls_x509_ref
	{
		public ulong handle; //Field offset: 0x0

	}

	public struct unitytls_x509list
	{

	}

	public struct unitytls_x509list_ref
	{
		public ulong handle; //Field offset: 0x0

	}

	public struct unitytls_x509name
	{

	}

	public delegate unitytls_x509verify_callback
	{

		public unitytls_x509verify_callback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

		public virtual unitytls_x509verify_result EndInvoke(IAsyncResult result) { }

		public virtual unitytls_x509verify_result Invoke(void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

	}

	public enum unitytls_x509verify_result
	{
		UNITYTLS_X509VERIFY_SUCCESS = 0,
		UNITYTLS_X509VERIFY_NOT_DONE = 2147483648,
		UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295,
		UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1,
		UNITYTLS_X509VERIFY_FLAG_REVOKED = 2,
		UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4,
		UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608,
		UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728,
	}

	private static unitytls_interface_struct marshalledInterface; //Field offset: 0x0

	public static bool IsSupported
	{
		 get { } //Length: 9
	}

	public static unitytls_interface_struct NativeInterface
	{
		 get { } //Length: 10
	}

	public static bool get_IsSupported() { }

	public static unitytls_interface_struct get_NativeInterface() { }

	private static nint GetUnityTlsInterface() { }

}

