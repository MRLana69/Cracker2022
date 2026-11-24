using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Data.Save;
using Data.Save.Internal;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.LocalizationManager;
using Kiloo.Common.Timer;
using Kiloo.Common.Utility;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using UnityEngine;
using UnityEngine.Networking;

namespace Kiloo.Common.HTTP;

public static class WebClient
{
	public struct SendOptions
	{
		public bool disableCache;

		public bool useCacheOnError;

		public float simulatedRequestLatency;

		public IList<SimulatedRequestResult> simulatedRequestResults;

		public int debugOutputLimit;
	}

	public delegate void RequestCompleteHandler(IRequest request, bool isFromCache);

	private class CacheInfo
	{
		public bool expired;

		public CacheMetaData metadata;

		public string filename;

		public string metaFilename;

		public CacheInfo()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public enum ClearCacheFlags
	{
		All = 1,
		Expired = 2,
		Old = 4
	}

	private class CacheMetaData
	{
		public DateTime timestamp = (DateTime)1;

		public Headers requestHeaders;

		public Headers responseHeaders;

		public CacheMetaData()
		{
			//IL_000b: Expected VT, but got I4
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__11_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			LocaleData._003C_003Ec obj = default;
			LocaleData._003C_003Ec._003C_003E9 = obj;
		}

		internal string _003CAddQueryParametersToUri_003Eb__11_0(KeyValuePair<string, string> pair)
		{
			//IL_0008: Expected Obj, but got VT
			//IL_003e: Expected Obj, but got I4
			object obj = pair;
			_ = pair.key;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pair @ L1 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			bool flag = (nint)0 != 0;
			return (string)flag;
		}
	}

	private sealed class _003CSendRequestCoroutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IRequest request;

		public SendOptions options;

		public RequestCompleteHandler onComplete;

		private CacheInfo _003Ccache_003E5__2;

		private Action _003CapplySimulationToRequest_003E5__3;

		private float _003CrequestTimeout_003E5__4;

		private float _003CstartTime_003E5__5;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0061: Expected I, but got Obj
				//IL_0077: Expected Obj, but got I
				//IL_07da: Unknown result type (might be due to invalid IL or missing references)
				//IL_07df: Expected Obj, but got Unknown
				//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_07ea: Expected Obj, but got Unknown
				//IL_00f9: Expected I, but got Obj
				//IL_010f: Expected Obj, but got I
				//IL_00a2: Expected I, but got Obj
				//IL_013a: Expected I, but got Obj
				//IL_024a: Invalid comparison between Obj and F4
				//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d1: Expected Obj, but got Unknown
				//IL_01da: Expected Obj, but got I4
				//IL_027a: Expected I, but got Obj
				//IL_0290: Expected Obj, but got I
				//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a6: Expected Obj, but got Unknown
				//IL_04af: Expected Obj, but got I4
				//IL_05a7: Expected Obj, but got I4
				//IL_02bb: Expected I, but got Obj
				//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f3: Expected Obj, but got Unknown
				//IL_041b: Expected I, but got Obj
				//IL_0431: Expected Obj, but got I
				//IL_085e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0863: Expected Obj, but got Unknown
				//IL_086c: Expected Obj, but got I4
				//IL_0880: Expected Obj, but got I4
				//IL_089a: Expected Obj, but got I4
				//IL_0599: Expected Obj, but got I4
				//IL_045c: Expected I, but got Obj
				//IL_04f8: Expected I, but got Obj
				//IL_050e: Expected Obj, but got I
				//IL_06d3: Expected I4, but got Obj
				//IL_06d3: Expected I4, but got Obj
				//IL_06df: Expected Obj, but got I4
				//IL_058b: Expected Obj, but got I4
				//IL_0539: Expected I, but got Obj
				//IL_06f2: Expected I, but got Obj
				//IL_0708: Expected Obj, but got I
				//IL_0733: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							goto IL_0335;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v104 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(WebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v120 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CloseIdleConnectionsToHost((string)(object)this.request);
					object obj2 = this + 40;
					object obj3 = this + 20;
					CacheMetaData cacheMetaData;
					if (obj3 != null)
					{
						cacheMetaData = null;
					}
					else
					{
						nint num3 = (nint)typeof(WebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S2_v54 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num4 = (nint)typeof(WebClient);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S2_v59 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						cacheMetaData = LoadCacheMetaData((string)(object)this.request);
					}
					obj2 = cacheMetaData;
					if (_003Ccache_003E5__2 != null)
					{
						CacheInfo cacheInfo = _003Ccache_003E5__2;
						if (~(cacheInfo.expired ? 1u : 0u) != 0)
						{
							goto IL_081b;
						}
					}
					object obj5 = this + 44;
					obj5 = 0;
				}
				if (_003CapplySimulationToRequest_003E5__3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
					goto IL_03c9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8685");
				object obj6 = default;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
				{
					nint num5 = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v106 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num6 = (nint)typeof(WebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v113 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4DE");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8685");
				float num7 = default;
				_003CrequestTimeout_003E5__4 = num7;
				float maxDelay = NetworkServer.maxDelay;
				_003CstartTime_003E5__5 = maxDelay;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				goto IL_0335;
				IL_0335:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj8 = default;
				if (obj8 == null)
				{
					if (_003CrequestTimeout_003E5__4 > 0f)
					{
						float maxDelay2 = NetworkServer.maxDelay;
						float num8 = maxDelay2 - _003CstartTime_003E5__5;
						if (num8 > _003CrequestTimeout_003E5__4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
							goto IL_03c9;
						}
					}
					object obj9 = this + 12;
					obj9 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				goto IL_03c9;
				IL_081b:
				if (_003Ccache_003E5__2 != null)
				{
					CacheInfo cacheInfo2 = _003Ccache_003E5__2;
					if (cacheInfo2.metadata != null)
					{
						CacheInfo cacheInfo3 = _003Ccache_003E5__2;
						nint num9 = (nint)typeof(WebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S1_v53 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num10 = (nint)typeof(WebClient);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v63 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						SimulatedRequestResult randomSimulatedRequestResult = GetRandomSimulatedRequestResult((IList<SimulatedRequestResult>)(object)cacheInfo3.filename);
						CacheInfo cacheInfo4 = _003Ccache_003E5__2;
						CacheMetaData metadata = cacheInfo4.metadata;
						IRequest request = RequestExtensions.WithHeaders((IRequest)metadata.responseHeaders, (IDictionary<string, string>)randomSimulatedRequestResult);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
						object obj11 = 1;
					}
					else
					{
						object obj11 = 0;
					}
				}
				else
				{
					object obj11 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj12 = default;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj13 = default;
					if (obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Uri uri = default;
					string localPath = uri.LocalPath;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					int count = default;
					int num11 = "SendRequestAsync Failed: \"".IndexOf((char)(int)localPath, (int)"\" status: ", count);
					string msg = (string)num11;
					nint num12 = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S1_v15 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num13 = (nint)typeof(WebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S1_v20 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					LogWarning(msg);
				}
				if (onComplete != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				}
				return null;
				IL_03c9:
				if (_003Ccache_003E5__2 != null)
				{
					object obj15 = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S2_v33+1]");
					bool flag = (nint)0 != 0;
					nint num14 = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S3_v21 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num15 = (nint)typeof(WebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S3_v26 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Response)this.request)._002Ector((Headers)(object)_003Ccache_003E5__2, (byte[])flag);
				}
				object obj17 = this + 44;
				obj17 = 0;
				goto IL_081b;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CSendRequestCoroutine_003Ed__22(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = _003C_003E2__current;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			bool result = default;
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public const string META_DATA_SUFFIX = ".metadata";

	public const string KILOO_DEVICE_TIME_HEADER = "Kiloo-Device-Time";

	private static string _cachePath;

	private static readonly string[] _cachedHeadersToUpdate;

	public static float defaultSimulatedRequestLatency;

	public static IList<SimulatedRequestResult> defaultSimulatedRequestResults;

	private static System.Random _random;

	public unsafe static float timeout
	{
		get
		{
			//IL_00c6: Expected Obj, but got Ref
			//IL_00cf: Expected Obj, but got I4
			//IL_00dd: Expected Obj, but got F4
			//IL_00f6: Expected I, but got Obj
			//IL_010c: Expected Obj, but got I
			//IL_0167: Expected I, but got Obj
			//IL_017d: Expected Obj, but got I
			//IL_01a7: Expected Ref, but got VT
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			int height = Screen.height;
			float num = (float)height / 320f;
			ref Matrix4x4 reference = default;
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref reference, -64));
			obj = 0;
			_ = 0;
			obj = num;
			_ = 1f;
			nint num2 = (nint)typeof(Matrix4x4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18 (Il2CppClass<UnityEngine.Matrix4x4>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(Matrix4x4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v46 (Il2CppClass<UnityEngine.Matrix4x4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ref Matrix4x4 reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 80);
			reference2 = ref *(Matrix4x4*)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+8]");
			_ = 0;
			Matrix4x4.Inverse_Injected(ref reference, out reference2);
			nint num4 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v42 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			reference2 = ref *(Matrix4x4*)reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Matrix4x4&)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Matrix4x4&)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Matrix4x4&)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Matrix4x4&)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Matrix4x4&)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Matrix4x4&)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Matrix4x4&)+38]");
			_ = 0;
			GUI.EndScrollView((byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != 0);
			return num;
		}
		set
		{
			LocalDebugData localDebug = DataManager<>.localDebug;
		}
	}

	public static string cachePath
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			X509Certificate2Enumerator x509Certificate2Enumerator = default;
			((IEnumerator)x509Certificate2Enumerator).Reset();
			TextAsset[] array = Resources.LoadAll<TextAsset>("trusted_roots");
			object obj3 = array + 12;
			bool flag = obj3 == null;
			object obj4 = obj3;
			if (!flag)
			{
				object obj5 = default;
				object obj9 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
				{
					object obj6 = array + 16;
					object obj7 = obj5 << 2;
					object obj8 = obj6 + obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj5 = obj9 + 1;
					obj4 = obj3;
				}
			}
			return (string)(object)x509Certificate2Enumerator;
		}
	}

	public static Uri AddQueryParametersToUri(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters)
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [queryParameters @ L1 (System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String, System.String>>)+8]");
		_ = 0;
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IResponse response = (IResponse)(queryParameters + 16);
		response = (IResponse)queryParameters;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return (Uri)((SocketsRequest)(object)uri).RedirectCheck(response);
	}

	public static Uri AddQueryParametersToUri(string uri, IEnumerable<KeyValuePair<string, string>> queryParameters)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected Obj, but got Unknown
		//IL_0b1e: Expected Obj, but got I4
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected Obj, but got Unknown
		//IL_0c84: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0ca8: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_0c70: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I4
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Expected Obj, but got Unknown
		//IL_0bc6: Expected I, but got Obj
		//IL_0bdc: Expected Obj, but got I
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Expected Obj, but got Unknown
		//IL_00f0: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_0262: Expected Obj, but got I4
		//IL_0c38: Expected Obj, but got I4
		//IL_0a13: Expected Obj, but got I
		//IL_0282: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_02f8: Expected I, but got Obj
		//IL_030e: Expected Obj, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_02b0: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I4
		//IL_0c58: Expected Obj, but got I4
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected Obj, but got Unknown
		//IL_086a: Expected Obj, but got I4
		//IL_03a4: Expected Obj, but got I4
		//IL_0339: Expected I, but got Obj
		//IL_03c4: Expected Obj, but got I4
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected Obj, but got Unknown
		//IL_0878: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I4
		//IL_0384: Expected Obj, but got I4
		//IL_0404: Expected Obj, but got I4
		//IL_0886: Expected Obj, but got I4
		//IL_0894: Expected Obj, but got I4
		//IL_08af: Expected Obj, but got I4
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected Obj, but got Unknown
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected Obj, but got Unknown
		//IL_0947: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (queryParameters == null)
		{
			goto IL_0c7f;
		}
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14 (Il2CppClass<Kiloo.Common.HTTP.WebClient+<>c>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v255 (Il2CppClass<Kiloo.Common.HTTP.WebClient+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__11_0 == null;
		bool flag2 = !flag;
		Predicate<_00210> match = (Predicate<_00210>)(object)_003C_003Ec._003C_003E9__11_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v229 (Il2CppClass<Kiloo.Common.HTTP.WebClient+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v249 (Il2CppClass<Kiloo.Common.HTTP.WebClient+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Predicate<_00210> predicate = default;
			object obj7 = predicate + 16;
			obj7 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v246 (Il2CppClass<Kiloo.Common.HTTP.WebClient+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)4;
			obj8 = predicate;
			match = predicate;
		}
		List<_00210> list = (List<_00210>)(object)((List<T>)queryParameters).FindAll((Predicate<T>)(object)match);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj9 = 0;
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		object obj16 = default;
		object obj14 = default;
		object obj10;
		object obj17 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj10 = 50;
			bool flag3 = obj11 == null;
			obj10 = 51;
			if (flag3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj10 = 15;
			obj3 = obj2;
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj12 = obj9;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj10 = 19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if ((nint)obj13 < 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					obj10 = 30;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj10 = 30;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj10 = 25;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					obj14 = obj12;
					obj10 = 26;
					object obj15 = obj16 - 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
					obj14 = obj12;
					obj10 = 26;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					obj14 = obj12;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj17 = obj12;
			obj10 = 37;
			nint num7 = (nint)typeof(Uri);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ S0_v119 (Il2CppClass<System.Uri>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num8 = (nint)typeof(Uri);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S0_v162 (Il2CppClass<System.Uri>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj17 = obj12;
					obj10 = 37;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj17 = obj12;
			obj10 = 46;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj17 = obj12;
			obj10 = 46;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj17 = obj12;
			obj10 = 47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj17 = obj12;
			obj10 = 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj17 = obj12;
			obj10 = 49;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj17 = obj12;
			obj9 = obj12;
		}
		object obj19 = obj10 - 15;
		object obj24 = default;
		if ((nint)obj10 != 15)
		{
			if ((nint)obj19 == 1 || (nint)obj19 == 2 || (nint)obj19 == 3)
			{
				goto IL_0cad;
			}
			if ((nint)obj19 != 4)
			{
				if ((nint)obj19 != 5)
				{
					if ((nint)obj19 == 6 || (nint)obj19 == 7 || (nint)obj19 == 8 || (nint)obj19 == 9)
					{
						goto IL_0cad;
					}
					if ((nint)obj19 != 10)
					{
						if ((nint)obj19 != 11)
						{
							if ((nint)obj19 != 12)
							{
								if ((nint)obj19 == 13 || (nint)obj19 == 14)
								{
									goto IL_0cad;
								}
								if ((nint)obj19 != 15)
								{
									if ((nint)obj19 == 16 || (nint)obj19 == 17 || (nint)obj19 == 18 || (nint)obj19 == 19 || (nint)obj19 == 20)
									{
										goto IL_0cad;
									}
									if ((nint)obj19 != 21)
									{
										if ((nint)obj19 != 22)
										{
											if ((nint)obj19 == 23 || (nint)obj19 == 24 || (nint)obj19 == 25 || (nint)obj19 == 26 || (nint)obj19 == 27 || (nint)obj19 == 28 || (nint)obj19 == 29 || (nint)obj19 == 30)
											{
												goto IL_0cad;
											}
											if ((nint)obj19 != 31)
											{
												if ((nint)obj19 != 32)
												{
													if ((nint)obj19 != 33)
													{
														if ((nint)obj19 != 34)
														{
															if ((nint)obj19 != 35)
															{
																if ((nint)obj19 == 36)
																{
																	object obj20 = obj4 + 4;
																	object obj21 = obj20 + 1;
																	obj20 = obj21;
																	object obj22 = obj21 << 2;
																	object obj23 = obj4 + obj22;
																	obj23 = 203;
																	obj24 = obj9;
																}
																goto IL_0cad;
															}
														}
														else
														{
															obj9 = obj17;
														}
													}
													else
													{
														obj9 = obj17;
													}
												}
												else
												{
													obj9 = obj17;
												}
											}
											else
											{
												obj9 = obj17;
											}
										}
										else
										{
											obj9 = obj17;
										}
									}
								}
								else
								{
									obj9 = 0;
								}
							}
							else
							{
								obj9 = obj14;
							}
						}
						else
						{
							obj9 = 0;
						}
					}
					else
					{
						obj9 = 0;
					}
				}
				else
				{
					obj9 = 0;
				}
			}
			else
			{
				obj9 = 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj25 = default;
		object obj26 = default;
		if (obj25 == obj26)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			obj24 = obj9;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0cad;
		IL_0c7f:
		int hashCode = default;
		return (Uri)hashCode;
		IL_0cca:
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			UriBuilder uriBuilder = default;
			string uri2 = default;
			uriBuilder.Init((Uri)(object)uri2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Uri fieldsFromUri = default;
			uriBuilder.SetFieldsFromUri(fieldsFromUri);
			hashCode = uriBuilder.GetHashCode();
		}
		goto IL_0c7f;
		IL_0cad:
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v7+4]");
			object obj28 = (nint)0 << 2;
			object obj29 = obj4 + obj28;
			if ((nint)obj29 == 203)
			{
				object obj30 = obj4 + 4;
				if ((nint)obj30 > -1)
				{
					object obj31 = obj30 + -1;
					obj30 = obj31;
				}
				goto IL_0cca;
			}
		}
		object obj32 = default;
		if (obj32 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0cca;
	}

	public static IRequest CreatePost(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null)
	{
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri2 = default;
		uri2.CreateThisFromUri(uri);
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v15 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (IRequest)AddQueryParametersToUri((string)(object)uri2, queryParameters);
	}

	public static IRequest CreateGet(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Uri uri2 = AddQueryParametersToUri((string)(object)uri, queryParameters);
		return HTTPFactory.CreatePut(uri2);
	}

	public static IRequest CreatePut(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Uri uri2 = AddQueryParametersToUri((string)(object)uri, queryParameters);
		return HTTPFactory.CreatePost(uri2);
	}

	public static IRequest CreateDelete(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Uri uri2 = AddQueryParametersToUri((string)(object)uri, queryParameters);
		return HTTPFactory.CreateDelete(uri2);
	}

	public unsafe static Coroutine RequestAsync(IRequest request, RequestCompleteHandler onComplete = null, SendOptions options = default(SendOptions))
	{
		//IL_005f: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected VT, but got Unknown
		//IL_00c5: Expected I4, but got Obj
		//IL_00c0: Expected native int or pointer, but got VT
		//IL_00da: Expected Obj, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = options.disableCache;
		_ = options.simulatedRequestResults;
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SendOptions sendOptions = (SendOptions)(obj + 16);
		((SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		System.Runtime.CompilerServices.Unsafe.Write(&((SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
		return (Coroutine)(object)SendRequestCoroutine(request, onComplete, sendOptions);
	}

	public unsafe static Coroutine SendRequestAsync(IRequest request, RequestCompleteHandler onComplete = null, SendOptions options = default(SendOptions))
	{
		//IL_005f: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected VT, but got Unknown
		//IL_00c5: Expected I4, but got Obj
		//IL_00c0: Expected native int or pointer, but got VT
		//IL_00da: Expected Obj, but got I
		//IL_00d5: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = options.disableCache;
		_ = options.simulatedRequestResults;
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SendOptions sendOptions = (SendOptions)(obj + 16);
		((SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		System.Runtime.CompilerServices.Unsafe.Write(&((SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
		return (Coroutine)(object)SendRequestCoroutine(request, onComplete, sendOptions);
	}

	public static IRequest Request(IRequest request, SendOptions options)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got VT
		//IL_00ad: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Uri uri = AddQueryParametersToUri((string)(object)request, (IEnumerable<KeyValuePair<string, string>>)options);
		return (IRequest)(object)HTTPStatus.ToString((int)uri);
	}

	public static IRequest SendRequest(IRequest request, SendOptions options = default(SendOptions))
	{
		//IL_005f: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = options.disableCache;
		_ = options.simulatedRequestResults;
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v20 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IResponse response = (IResponse)(obj + 16);
		response = (IResponse)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return (IRequest)((SocketsRequest)request).RedirectCheck(response);
	}

	private static void PrepareRequest(IRequest request)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[TrustedRoots] ", (int)request);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(message);
	}

	private unsafe static IEnumerator SendRequestCoroutine(IRequest request, RequestCompleteHandler onComplete, SendOptions options)
	{
		//IL_005f: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected I4, but got Unknown
		//IL_00c5: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj = options.disableCache;
		_ = options.simulatedRequestResults;
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v21 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = obj + 16;
		((int*)num3)->m_value = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		string list = Util.ContentAsString((byte[])(object)request, (Headers)(object)onComplete, num3);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private unsafe static CacheInfo HandleCacheBeforeRequest(IRequest request)
	{
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02b6: Expected Obj, but got I4
		//IL_0033: Expected native int or pointer, but got Obj
		//IL_006a: Expected Obj, but got I4
		//IL_0077: Expected I4, but got Obj
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d7: Expected I4, but got Obj
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I
		//IL_01bb: Expected Obj, but got I4
		//IL_01d6: Expected Obj, but got I
		//IL_01e4: Expected I4, but got Obj
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		object obj3 = obj2 + 8;
		obj3 = 0;
		CacheInfo cacheInfo;
		if (TrustedRoots._trusted != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			X509Chain x509Chain = default;
			x509Chain.Dispose();
			X509ChainStatus[] chainStatus = x509Chain.ChainStatus;
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)chainStatus, new X509ChainStatus(X509ChainStatusFlags.NoError));
			X509ChainStatus[] chainStatus2 = x509Chain.ChainStatus;
			X509RevocationFlag revocationFlag = ((X509ChainPolicy)(object)chainStatus2).RevocationFlag;
			((X509Certificate2Collection)revocationFlag).Import((byte[])(object)TrustedRoots._trusted);
			int num = ((X509ChainElement)(object)x509Chain).Count((X509ChainStatusFlags)request);
			X509Certificate2 certificate = ((X509ChainElement)(object)x509Chain).Certificate;
			object obj4 = certificate + 12;
			object obj5 = 0;
			cacheInfo = (CacheInfo)1;
			bool flag = false;
			object obj6 = default;
			object obj9 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				object obj7 = certificate + 16;
				flag = (byte)(obj6 << 3) != 0;
				object obj8 = obj7 + flag;
				obj2 = obj8;
				obj = obj2;
				if ((nint)obj == 32)
				{
					obj5 = 1;
				}
				else
				{
					bool flag2 = obj == null;
					CacheInfo cacheInfo2 = (CacheInfo)(cacheInfo & flag2);
					cacheInfo = cacheInfo2;
				}
				obj6 = obj9 + 1;
			}
			if (obj5 != null)
			{
				X509ChainPolicy chainPolicy = x509Chain.ChainPolicy;
				IEnumerator enumerator = ((IEnumerable)(object)chainPolicy).GetEnumerator();
				while (((System.Security.Cryptography.X509Certificates.X509ChainImplMono)enumerator).IsValid)
				{
					object obj10 = enumerator.Current;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v49 (System.Object)+C]");
					object obj11 = (nint)0 + (nint)12;
					object obj12 = 0;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v49 (System.Object)+C]");
						object obj13 = (nint)0 + (nint)16;
						flag = (byte)(obj12 << 3) != 0;
						object obj14 = obj13 + flag;
						obj2 = obj14;
						obj3 = obj2;
						if ((nint)obj3 == 32)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v49 (System.Object)+8]");
							flag = false;
							X509Certificate2Collection trusted = TrustedRoots._trusted;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v49 (System.Object)+8]");
							string issuerName = ((System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono)(object)trusted).GetIssuerName(false);
							CacheInfo cacheInfo3 = (CacheInfo)((object)cacheInfo & (object)issuerName);
							cacheInfo = cacheInfo3;
						}
						object obj15 = obj12 + 1;
						obj12 = obj15;
					}
				}
			}
		}
		else
		{
			TrustedRoots.Log("Trusted roots not loaded. Make sure you have called TrustedRoots.Init before making secure requests (from the Unity main thread).");
			cacheInfo = null;
		}
		return cacheInfo;
	}

	private static void HandleCacheAfterRequest(IRequest request, CacheInfo cacheInfo, bool useCacheOnError)
	{
		//IL_0011: Expected Obj, but got I4
		((HTTPSecurityException)request)._002Ector((string)(object)cacheInfo, (Exception)useCacheOnError);
	}

	private static void UpdateCachedHeaders(Headers cached, Headers updated)
	{
		((HTTPRequestCanceledException)(object)cached)._002Ector((string)(object)updated);
	}

	public static void ClearCache(ClearCacheFlags flags, float olderThanSeconds)
	{
		//IL_0056: Invalid comparison between I and F8
		//IL_007e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [flags @ L0 (Kiloo.Common.HTTP.WebClient+ClearCacheFlags)+9]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [flags @ L0 (Kiloo.Common.HTTP.WebClient+ClearCacheFlags)+18]");
		float num = 0f - olderThanSeconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [flags @ L0 (Kiloo.Common.HTTP.WebClient+ClearCacheFlags)+18]");
		if (0.0 < 0.0)
		{
			((FrameTimer)flags).Start();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [flags @ L0 (Kiloo.Common.HTTP.WebClient+ClearCacheFlags)+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [flags @ L0 (Kiloo.Common.HTTP.WebClient+ClearCacheFlags)+C]");
			_ = 0;
		}
	}

	private static void SaveCacheMetaData(string file, CacheMetaData metadata)
	{
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0089: Expected VT, but got Obj
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = _cachedHeadersToUpdate + 12;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = _cachedHeadersToUpdate + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			Headers headers = ((Headers)(object)metadata).Add((KeyValuePair<string, string>)obj6);
			if (headers != null)
			{
				((Headers)(object)file).ReadFrom((BinaryReader)obj6);
				Headers bytes = ((Headers)(object)metadata).SetAll((IEnumerable<KeyValuePair<string, string>>)obj6);
				IRequest request = HTTPFactory.CreateRequest(file, (Uri)obj6, (byte[])(object)bytes);
			}
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
	}

	private static CacheMetaData LoadCacheMetaData(string file)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7d: Expected Obj, but got Unknown
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8b: Expected Obj, but got Unknown
		//IL_0d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Expected Obj, but got Unknown
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected Obj, but got Unknown
		//IL_0db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Expected Obj, but got Unknown
		//IL_002b: Expected VT, but got I4
		//IL_0039: Expected I, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_007a: Expected I, but got Obj
		//IL_0232: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0273: Expected I, but got Obj
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_03bb: Expected I, but got Obj
		//IL_03d1: Expected Obj, but got I
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0494: Expected Obj, but got I
		//IL_03fc: Expected I, but got Obj
		//IL_0750: Expected Obj, but got I
		//IL_075e: Expected I, but got Obj
		//IL_0774: Expected Obj, but got I
		//IL_0efb: Expected Obj, but got VT
		//IL_079f: Expected I, but got Obj
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected Obj, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected Obj, but got Unknown
		//IL_05b5: Expected Obj, but got I4
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_056b: Expected Obj, but got I4
		//IL_0f3b: Invalid comparison between VT and I4
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected Obj, but got Unknown
		//IL_08e6: Expected Obj, but got I
		//IL_08c4: Expected VT, but got I4
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_0f8e: Expected Obj, but got I
		//IL_065c: Expected Obj, but got I
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_072e: Expected Obj, but got I4
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 16;
		object obj6 = obj2 + 8;
		object obj7 = obj2 + 40;
		obj7 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		string b = default;
		if (string.Equals("GET", b, StringComparison.InvariantCultureIgnoreCase))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CacheMetaData cacheMetaData = default;
			cacheMetaData.timestamp = (DateTime)1;
			nint num = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v34 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v528 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj9 = default;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			nint num3 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S0_v71 (Il2CppClass<System.IO.Path>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v456 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj11 = cacheMetaData + 16;
			object obj12 = default;
			obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj13 = cacheMetaData + 20;
			object obj14 = default;
			obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj15 = default;
			if (obj15 == null)
			{
				return cacheMetaData;
			}
			nint num5 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ S0_v102 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num6 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ S0_v439 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj17 = cacheMetaData + 12;
			object obj18 = default;
			obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v32 (Kiloo.Common.HTTP.WebClient+CacheMetaData)+C]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj20 = default;
			bool flag;
			if (obj20 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ S0_v194+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj21 = default;
				if (obj21 != null)
				{
					object obj22 = cacheMetaData + 12;
					obj22 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj24 = default;
					object obj23 = obj24 + 16;
					obj23 = 44;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj26 = default;
					object obj25 = obj26 + 12;
					object obj27 = default;
					object obj32 = default;
					object obj33 = default;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25))
					{
						object obj28 = obj26 + 16;
						object obj29 = obj27 << 2;
						object obj30 = obj28 + obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v32 (Kiloo.Common.HTTP.WebClient+CacheMetaData)+C]");
						object obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj32 == null)
						{
							obj27 = obj33 + 1;
							continue;
						}
						object obj34 = cacheMetaData + 12;
						obj34 = 0;
						break;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v32 (Kiloo.Common.HTTP.WebClient+CacheMetaData)+C]");
			if ((nint)0 == 0)
			{
				return cacheMetaData;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v32 (Kiloo.Common.HTTP.WebClient+CacheMetaData)+C]");
			object obj35 = 0;
			nint num7 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ S0_v208 (Il2CppClass<System.DateTime>)+BA]");
			object obj36 = (nint)0 & (nint)0x200;
			if (obj36 != null)
			{
				nint num8 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v897 @ S0_v333 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj5 = DateTime.MinValue;
			obj3 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DE");
			object obj38 = default;
			object obj37 = obj38 << 32;
			object obj40 = default;
			object obj39 = obj40 | obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D9");
			object obj41 = obj38 << 32;
			object obj43 = default;
			object obj42 = obj43 | obj41;
			obj6 = obj42;
			obj2 = obj39;
			obj4 = obj6;
			obj3 = obj2;
			object obj44 = obj4 & 0x3FFFFFFFFFFFFFFFL;
			object obj45 = obj3 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj44) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45))
			{
				cacheMetaData.timestamp = (DateTime)0;
			}
			if (cacheMetaData.timestamp == (DateTime)(object)0)
			{
				return cacheMetaData;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v32 (Kiloo.Common.HTTP.WebClient+CacheMetaData)+C]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj47 = default;
			bool flag2;
			if (obj47 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ S0_v250+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v32 (Kiloo.Common.HTTP.WebClient+CacheMetaData)+C]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj49 = default;
			bool flag3;
			if (obj49 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ S0_v264+8]");
				flag3 = (nint)0 == 0;
			}
			else
			{
				flag3 = true;
			}
			if (flag3)
			{
				return cacheMetaData;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj51 = default;
			object obj50 = obj51;
			object obj52 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj53 = default;
			object obj57;
			if (obj52 == obj53)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj55 = default;
				object obj54 = obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj56 = default;
				obj50 = obj56;
				obj57 = obj38;
			}
			else
			{
				obj57 = obj52;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj58 = default;
			if (obj57 == obj58)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj59 = default;
				string text = (string)obj59;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj60 = default;
				obj50 = obj60;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745C");
		}
		CacheMetaData result = default;
		return result;
	}

	private static void SaveCacheContents(string file, byte[] bytes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_0020: Expected I4, but got Obj
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_010f: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I
		//IL_006f: Expected I, but got Obj
		//IL_0468: Expected Obj, but got I
		//IL_0150: Expected I, but got Obj
		//IL_02eb: Expected Obj, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 24;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FileStream fileStream = default;
		fileStream.Write((byte[])(object)file, 2, 2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryWriter binaryWriter = default;
		binaryWriter.Dispose((byte)(int)fileStream != 0);
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25 (Il2CppClass<System.DateTime>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v131 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D9");
		object obj8 = default;
		object obj7 = obj8 << 32;
		object obj10 = default;
		object obj9 = obj10 | obj7;
		obj4 = obj9;
		obj3 = obj4;
		nint num3 = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v70 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v118 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bytes @ L1 (System.Byte[])+8]");
		obj2 = 0;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
		object obj12 = obj8 << 32;
		object obj14 = default;
		object obj13 = obj14 | obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj16 = default;
		object obj15 = obj16;
		object obj17 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj18 = default;
		if (obj17 == obj18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		if (binaryWriter != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj5 + obj19;
			if ((nint)obj20 == 78)
			{
				object obj21 = obj5 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				return;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private static byte[] LoadCacheContents(string file)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_002a: Expected I4, but got Obj
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_00a8: Expected I, but got Obj
		//IL_02c2: Expected Obj, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FileStream fileStream = default;
		fileStream.Write((byte[])(object)file, 3, 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BinaryReader binaryReader = default;
		binaryReader.Dispose((byte)(int)fileStream != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
		object obj6 = default;
		object obj5 = obj6 << 32;
		object obj8 = default;
		object obj7 = obj8 | obj5;
		nint num = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v69 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v150 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		object obj10 = obj7 >> 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E4");
		object obj11 = obj6 << 32;
		object obj13 = default;
		object obj12 = obj13 | obj11;
		obj2 = obj12;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj15 = default;
		object obj14 = obj15;
		object obj16 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj17 = default;
		if (obj16 == obj17)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		if (binaryReader != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj4 + obj18;
			if ((nint)obj19 == 97)
			{
				object obj20 = obj4 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_048f;
			}
		}
		object obj22 = default;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_048f;
		IL_048f:
		byte[] result = default;
		return result;
	}

	public static void CloseExpiredIdleConnections()
	{
		if (TrustedRoots._trusted == null)
		{
			string trusted = cachePath;
			TrustedRoots._trusted = (X509Certificate2Collection)(object)trusted;
		}
	}

	public static void CloseIdleConnectionsToHost(string host)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_015e: Expected VT, but got Obj
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Headers headers2 = default;
		Headers headers = headers2.Add((KeyValuePair<string, string>)"Kiloo-Device-Time");
		if (headers == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num = (nint)typeof(DateTimeOffset);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v16 (Il2CppClass<System.DateTimeOffset>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTimeOffset);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v41 (Il2CppClass<System.DateTimeOffset>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTimeOffset utcNow = DateTimeOffset.UtcNow;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		nint num3 = (nint)typeof(DateTimeFormatInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v24 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DateTimeFormatInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v37 (Il2CppClass<System.Globalization.DateTimeFormatInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTimeFormatInfo currentInfo = DateTimeFormatInfo.CurrentInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F785");
		Type type = default;
		object innerException = ((IConvertible)"\"").ToType(type, (IFormatProvider)(object)"\"");
		HTTPBackOffException ex = default;
		ex._002Ector("Kiloo-Device-Time", (Exception)innerException);
	}

	public static void CloseIdleConnections()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Connection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Connection.CloseIdleConnections();
	}

	private unsafe static void ApplyDefaultSimulationParameters(ref SendOptions options)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Connection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Connection)System.Runtime.CompilerServices.Unsafe.AsPointer(ref options)).Close();
	}

	private static float GetSimulatedRequestResponseChanceTotal(IList<SimulatedRequestResult> simulatedRequestResults)
	{
		//IL_000d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [simulatedRequestResults @ L0 (System.Collections.Generic.IList`1<Kiloo.Common.HTTP.SimulatedRequestResult>)+C]");
		return 0f;
	}

	private static SimulatedRequestResult GetRandomSimulatedRequestResult(IList<SimulatedRequestResult> simulatedRequestResults)
	{
		byte[] array = FileUtil.ReadAllBytes((Stream)simulatedRequestResults);
		if (array.Length != 0)
		{
			return (SimulatedRequestResult)(object)array;
		}
		return null;
	}

	private unsafe static void DoSimulation(IRequest request, ref Action applySimulationToRequest, ref float waitTimeBeforeApply, float simulatedRequestLatency, IList<SimulatedRequestResult> simulatedRequestResults)
	{
		//IL_0169: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_005f: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		//IL_0144: Expected Obj, but got Ref
		//IL_0155: Expected VT, but got Obj
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got Ref
		//IL_011e: Expected Obj, but got Ref
		//IL_00dd: Expected Obj, but got I
		//IL_01b1: Expected Obj, but got Ref
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [applySimulationToRequest @ L1 (System.Action&)+C]");
		if ((UnityEngine.Object)0 == null)
		{
			int num3 = ((CoinCurve)System.Runtime.CompilerServices.Unsafe.AsPointer(ref applySimulationToRequest)).NumberOfCoins(simulatedRequestLatency);
			if (num3 > 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [applySimulationToRequest @ L1 (System.Action&)+20]");
				bool flag = (nint)0 != 0;
				object obj2 = flag & simulatedRequestResults;
				float catchUpTime;
				if (obj2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [applySimulationToRequest @ L1 (System.Action&)+3C]");
					object obj3 = -1;
					catchUpTime = (float)(ref waitTimeBeforeApply) / (float)obj3;
				}
				else
				{
					float num4 = ((Character)System.Runtime.CompilerServices.Unsafe.AsPointer(ref applySimulationToRequest)).CalculateJumpVerticalSpeed(simulatedRequestLatency);
					float num5 = (float)(ref waitTimeBeforeApply) * num4;
					float num6 = ((CoinCurve)System.Runtime.CompilerServices.Unsafe.AsPointer(ref applySimulationToRequest)).CoinSpacing(simulatedRequestLatency);
					catchUpTime = num5 / num6;
				}
				((CharacterRendering)request).OnCatchPlayer((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref applySimulationToRequest), catchUpTime, simulatedRequestLatency);
				return;
			}
		}
		GameObject gameObject = ((Component)System.Runtime.CompilerServices.Unsafe.AsPointer(ref applySimulationToRequest)).gameObject;
		((Transform)request).position = (Vector3)gameObject;
	}

	private static void LogError(string msg)
	{
		//IL_0132: Invalid comparison between I and F4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_00e2: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+4]");
		if (!(0f > 0f))
		{
			nint num = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v32 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_ = defaultSimulatedRequestLatency;
		}
		if (msg.m_stringLength != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v14 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v20 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = msg + 8;
		obj3 = defaultSimulatedRequestResults;
	}

	private static void LogWarning(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[WebClient] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[WebClient] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogAssertion(message);
	}

	static WebClient()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Connection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Connection._002Ecctor();
	}
}
