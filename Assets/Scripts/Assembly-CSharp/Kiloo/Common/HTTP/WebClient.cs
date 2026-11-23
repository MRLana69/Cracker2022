using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

namespace Kiloo.Common.HTTP;

public static class WebClient
{
	public struct SendOptions
	{
		public bool disableCache;

		public bool useCacheOnError;

		public float simulatedRequestLatency;

		public IList<SimulatedRequestResult> simulatedRequestResults;
	}

	public delegate void RequestCompleteHandler(IRequest request, bool isFromCache);

	private class CacheInfo
	{
		public bool expired = true;

		public CacheMetaData metadata;

		public string filename;

		public string metaFilename;
	}

	public enum ClearCacheFlags
	{
		All = 1,
		Expired = 2,
		Old = 4
	}

	private class CacheMetaData
	{
		public DateTime timestamp;

		public Headers requestHeaders;

		public Headers responseHeaders;
	}

	private sealed class _003CSendRequestCoroutine_003Ed__27(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SendOptions options;

		public IRequest request;

		public RequestCompleteHandler onComplete;

		private CacheInfo _003Ccache_003E5__2;

		private Action _003CapplySimulationToRequest_003E5__3;

		private float _003CrequestTimeout_003E5__4;

		private float _003CstartTime_003E5__5;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_005e: Invalid comparison between VT and I4
			//IL_0127: Invalid comparison between Obj and F4
			//IL_02c4: Expected Obj, but got I4
			//IL_0299: Expected Obj, but got I4
			//IL_0338: Expected Obj, but got I4
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Expected Obj, but got Unknown
			CacheInfo cacheInfo3;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						goto IL_0457;
					}
					_003C_003E1__state = -1;
					goto IL_0495;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				CacheInfo cacheInfo = ((options == (SendOptions)(object)0) ? HandleCacheBeforeRequest(this.request) : null);
				_003Ccache_003E5__2 = cacheInfo;
				CacheInfo cacheInfo2 = _003Ccache_003E5__2;
				if (_003Ccache_003E5__2 != null)
				{
					bool flag = (byte)(~(cacheInfo2.expired ? 1u : 0u)) != 0;
					cacheInfo3 = _003Ccache_003E5__2;
					if (flag)
					{
						goto IL_02a7;
					}
				}
				_003CapplySimulationToRequest_003E5__3 = null;
			}
			Action action = _003CapplySimulationToRequest_003E5__3;
			if (_003CapplySimulationToRequest_003E5__3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				goto IL_022d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2CB");
			object obj = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2CB");
			float num = default;
			_003CrequestTimeout_003E5__4 = num;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			_003CstartTime_003E5__5 = realtimeSinceStartup;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			goto IL_0495;
			IL_0457:
			return false;
			IL_02a7:
			bool flag2 = cacheInfo3.metadata == null;
			object obj2 = 0;
			if (!flag2)
			{
				byte[] bytes = LoadCacheContents(cacheInfo3.filename);
				CacheInfo cacheInfo4 = _003Ccache_003E5__2;
				CacheMetaData metadata = cacheInfo4.metadata;
				IResponse response = HTTPFactory.CreateResponse(metadata.responseHeaders, bytes);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
				obj2 = 1;
			}
			goto IL_04ad;
			IL_022d:
			if (_003Ccache_003E5__2 != null)
			{
				IRequest request = this.request;
				CacheInfo cacheInfo5 = _003Ccache_003E5__2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.HTTP.WebClient+<SendRequestCoroutine>d__27)+11]");
				HandleCacheAfterRequest(request, cacheInfo5, useCacheOnError: false);
			}
			_003CapplySimulationToRequest_003E5__3 = null;
			bool flag3 = _003Ccache_003E5__2 == null;
			cacheInfo3 = _003Ccache_003E5__2;
			obj2 = 0;
			if (!flag3)
			{
				goto IL_02a7;
			}
			goto IL_04ad;
			IL_04ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Uri uri = default;
				string absoluteUri = uri.AbsoluteUri;
				object obj4 = default;
				if (obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj5 = default;
					string text = default;
					if (obj5 != null)
					{
						object obj6 = obj5;
						object obj7 = obj5 + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v384 @ S4_v9+D4] (should have been resolved before IL gen)");
					}
					else
					{
						text = null;
					}
					string text2 = "SendRequestAsync Failed: \"" + absoluteUri + "\" exception: " + text;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					string text4 = default;
					string text3 = "SendRequestAsync Failed: \"" + absoluteUri + "\" status: " + text4;
				}
			}
			RequestCompleteHandler requestCompleteHandler = onComplete;
			if (onComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v323.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			goto IL_0457;
			IL_0495:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj8 = default;
			if (obj8 == null)
			{
				if (_003CrequestTimeout_003E5__4 > 0f)
				{
					float realtimeSinceStartup2 = Time.realtimeSinceStartup;
					float num2 = realtimeSinceStartup2 - _003CstartTime_003E5__5;
					if (num2 > _003CrequestTimeout_003E5__4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
						goto IL_022d;
					}
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			goto IL_022d;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public IRequest request;

		public SimulatedRequestResult simulatedResult;

		internal void _003CDoSimulation_003Eb__0()
		{
			SimulatedRequestResult simulatedRequestResult = simulatedResult;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			SimulatedRequestResult simulatedRequestResult2 = simulatedResult;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			SimulatedRequestResult simulatedRequestResult3 = simulatedResult;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
	}

	public const string META_DATA_SUFFIX = ".metadata";

	private static string _cachePath = null;

	private static readonly string[] _cachedHeadersToUpdate;

	public static float defaultSimulatedRequestLatency;

	public static IList<SimulatedRequestResult> defaultSimulatedRequestResults;

	private static System.Random _random;

	public static float timeout
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public static string cachePath
	{
		get
		{
			//IL_0050: Expected Obj, but got I4
			//IL_0034: Expected Obj, but got I4
			if (_cachePath != null)
			{
				goto IL_00a9;
			}
			string text = DeviceUtility.GetCachePath();
			object obj;
			if (text != null)
			{
				obj = 0;
				if (text._stringLength != 0)
				{
					goto IL_00ff;
				}
			}
			obj = 1;
			goto IL_00ff;
			IL_00ff:
			if (obj == null)
			{
				string text2 = Path.Combine(text, "webclientcache");
				_cachePath = text2;
				if (!Directory.Exists(_cachePath))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(_cachePath);
				}
				goto IL_00a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Exception ex = default;
			ex._002Ector("Unable to get cache path");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			return (string)(object)ex;
			IL_00a9:
			return _cachePath;
		}
	}

	public static Uri AddQueryParametersToUri(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got I4
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_0586: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I4
		//IL_059e: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		if (queryParameters != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = obj + 28;
			obj = obj3;
			_ = 0;
			object obj4 = 0;
			object obj5 = default;
			object obj7 = default;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			Uri uri2 = default;
			Uri uri3 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj5 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj4 == null)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v178+8]");
								if ((nint)0 >= (nint)2)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v178+8]");
										object obj6 = -1;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag = (nint)0 != 1;
											obj4 = obj7;
											if (flag)
											{
												goto IL_0311;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											obj4 = obj7;
											goto IL_05a3;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									obj4 = 0;
								}
								else
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag2 = (nint)0 != 1;
										obj4 = obj8;
										if (flag2)
										{
											goto IL_0311;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									obj4 = 0;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								obj4 = 0;
							}
						}
						else
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								goto IL_0311;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_05a3;
				IL_05a3:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag3 = obj9 != obj10;
				Uri result = uri2;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result = uri3;
				}
				_ = 0;
				object obj11 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result;
				IL_0311:
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												continue;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_05a3;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_05a3;
			}
			object obj12 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
			if (obj4 != null)
			{
				UriBuilder uriBuilder = default;
				Uri uri4 = default;
				uriBuilder._002Ector(uri4);
				object obj13 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v306 @ S2_v11+D4] (should have been resolved before IL gen)");
				string query = default;
				uriBuilder.Query = query;
				return uriBuilder.Uri;
			}
		}
		Uri result2 = default;
		return result2;
	}

	public static Uri AddQueryParametersToUri(string uri, IEnumerable<KeyValuePair<string, string>> queryParameters)
	{
		Uri uri2 = default;
		uri2._002Ector(uri);
		return AddQueryParametersToUri(uri2, queryParameters);
	}

	public static IRequest CreatePost(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null)
	{
		Uri uri2 = AddQueryParametersToUri(uri, queryParameters);
		return HTTPFactory.CreatePost(uri2);
	}

	public static IRequest CreateGet(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null)
	{
		Uri uri2 = AddQueryParametersToUri(uri, queryParameters);
		return HTTPFactory.CreateGet(uri2);
	}

	public static IRequest CreatePut(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null)
	{
		Uri uri2 = AddQueryParametersToUri(uri, queryParameters);
		return HTTPFactory.CreatePut(uri2);
	}

	public static IRequest CreateDelete(Uri uri, IEnumerable<KeyValuePair<string, string>> queryParameters = null)
	{
		Uri uri2 = AddQueryParametersToUri(uri, queryParameters);
		return HTTPFactory.CreateDelete(uri2);
	}

	public unsafe static Coroutine RequestAsync(IRequest request, RequestCompleteHandler onComplete = null, SendOptions options = default(SendOptions))
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		object obj = default;
		SendOptions sendOptions = (SendOptions)(obj - 16);
		System.Runtime.CompilerServices.Unsafe.Write(&((SendOptions*)(nint)sendOptions)->simulatedRequestResults, options.simulatedRequestResults);
		((SendOptions*)(nint)sendOptions)->disableCache = options.disableCache;
		return SendRequestAsync(request, onComplete, sendOptions);
	}

	public unsafe static Coroutine SendRequestAsync(IRequest request, RequestCompleteHandler onComplete = null, SendOptions options = default(SendOptions))
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0025: Expected native int or pointer, but got VT
		//IL_0037: Expected native int or pointer, but got VT
		object obj = default;
		SendOptions sendOptions = (SendOptions)(obj - 16);
		System.Runtime.CompilerServices.Unsafe.Write(&((SendOptions*)(nint)sendOptions)->simulatedRequestResults, options.simulatedRequestResults);
		((SendOptions*)(nint)sendOptions)->disableCache = options.disableCache;
		IEnumerator coroutine = SendRequestCoroutine(request, onComplete, sendOptions);
		return CoroutineUtil.StartCoroutine(coroutine);
	}

	public unsafe static IRequest Request(IRequest request, SendOptions options)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0020: Expected native int or pointer, but got VT
		//IL_0032: Expected native int or pointer, but got VT
		object obj = default;
		SendOptions sendOptions = (SendOptions)(obj - 16);
		System.Runtime.CompilerServices.Unsafe.Write(&((SendOptions*)(nint)sendOptions)->simulatedRequestResults, options.simulatedRequestResults);
		((SendOptions*)(nint)sendOptions)->disableCache = options.disableCache;
		return SendRequest(request, sendOptions);
	}

	public static IRequest SendRequest(IRequest request, SendOptions options = default(SendOptions))
	{
		//IL_023f: Expected Obj, but got I4
		//IL_007d: Invalid comparison between Obj and F4
		//IL_002f: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		object obj = 1;
		CacheInfo cacheInfo = default;
		CacheInfo cacheInfo2;
		if (!options.disableCache)
		{
			cacheInfo = HandleCacheBeforeRequest(request);
			bool flag = cacheInfo == null;
			obj = 1;
			if (!flag)
			{
				bool flag2 = (byte)(~(cacheInfo.expired ? 1u : 0u)) != 0;
				obj = 0;
				cacheInfo2 = cacheInfo;
				if (flag2)
				{
					goto IL_0252;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2CB");
		object obj2 = default;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
		if (obj != null)
		{
			goto IL_013c;
		}
		HandleCacheAfterRequest(request, cacheInfo, options.useCacheOnError);
		cacheInfo2 = cacheInfo;
		goto IL_0252;
		IL_0252:
		if (cacheInfo2.metadata != null)
		{
			byte[] bytes = LoadCacheContents(cacheInfo2.filename);
			CacheMetaData metadata = cacheInfo2.metadata;
			IResponse response = HTTPFactory.CreateResponse(metadata.responseHeaders, bytes);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		}
		goto IL_013c;
		IL_013c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = default;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Uri uri = default;
			string absoluteUri = uri.AbsoluteUri;
			object obj4 = default;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj5 = default;
				string text = default;
				if (obj5 != null)
				{
					object obj6 = obj5;
					object obj7 = obj5 + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ S4_v7+D4] (should have been resolved before IL gen)");
				}
				else
				{
					text = null;
				}
				string text2 = "SendRequest Failed: \"" + absoluteUri + "\" exception: " + text;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				string text4 = default;
				string text3 = "SendRequest Failed: \"" + absoluteUri + "\" status: " + text4;
			}
		}
		return request;
	}

	private static IEnumerator SendRequestCoroutine(IRequest request, RequestCompleteHandler onComplete, SendOptions options)
	{
		_ = 0;
		_ = options.simulatedRequestResults;
		_ = options.disableCache;
		IEnumerator result = default;
		return result;
	}

	private static CacheInfo HandleCacheBeforeRequest(IRequest request)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_13ba: Expected Obj, but got I
		//IL_13d2: Expected Obj, but got I
		//IL_1343: Expected Obj, but got I
		//IL_11fc: Expected Obj, but got I
		//IL_1227: Expected Obj, but got I
		//IL_124c: Expected Obj, but got I
		//IL_1262: Unknown result type (might be due to invalid IL or missing references)
		//IL_1267: Expected Obj, but got Unknown
		//IL_12dd: Expected Obj, but got I
		//IL_04f9: Expected Obj, but got I4
		//IL_0ebb: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I4
		//IL_0ee1: Expected Obj, but got I
		//IL_0e3c: Expected Obj, but got I
		//IL_0d68: Expected Obj, but got I
		//IL_0d93: Expected Obj, but got I
		//IL_0efc: Expected Obj, but got I
		//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Expected Obj, but got Unknown
		//IL_0f6e: Expected Obj, but got I4
		//IL_10e5: Expected Obj, but got I
		//IL_09ff: Expected Obj, but got I4
		//IL_09e0: Expected Obj, but got I4
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_0b35: Expected Obj, but got I4
		//IL_0b16: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string value = default;
		bool flag = "GET".Equals(value, StringComparison.OrdinalIgnoreCase);
		bool flag2 = !flag;
		CacheInfo result = null;
		CacheInfo cacheInfo = default;
		object obj6;
		if (!flag2)
		{
			cacheInfo.expired = true;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj3 = default;
						if (obj3 == null)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_1115;
							}
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												string filename = default;
												cacheInfo.filename = filename;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													string metaFilename = default;
													cacheInfo.metaFilename = metaFilename;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														object obj4 = default;
														if (obj4 == null)
														{
															result = cacheInfo;
															goto IL_1463;
														}
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																CacheMetaData metadata = default;
																cacheInfo.metadata = metadata;
																CacheMetaData metadata2 = cacheInfo.metadata;
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	object obj5 = default;
																	if (obj5 != null)
																	{
																		obj6 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ S0_v374+8]");
																		if ((nint)0 != 0)
																		{
																			goto IL_1477;
																		}
																	}
																	obj6 = 1;
																	goto IL_1477;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														goto IL_0c58;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_1115;
		}
		goto IL_1463;
		IL_0fb9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_1115;
		IL_0aa2:
		CacheMetaData metadata3 = cacheInfo.metadata;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj8;
		if ((nint)0 != 1)
		{
			_ = 0;
			object obj7 = default;
			if (obj7 != null)
			{
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ S0_v478+8]");
				if ((nint)0 != 0)
				{
					goto IL_1504;
				}
			}
			obj8 = 1;
			goto IL_1504;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0c58;
		IL_0c58:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj9 = default;
		object obj10 = default;
		bool flag3 = obj9 != obj10;
		object obj12 = default;
		object obj11 = obj12;
		object obj13 = obj9;
		result = cacheInfo;
		object obj28;
		CacheInfo cacheInfo2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj15 = default;
				object obj14 = obj15;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj16 = default;
					if (obj16 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						object obj17 = (nint)0 << 2;
						object obj18 = obj + obj17;
						obj18 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						object obj19 = (nint)0 + (nint)1;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							object obj20 = (nint)0 << 2;
							object obj21 = obj20 + obj;
							object obj22 = obj21 - 4;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								goto IL_0fb9;
							}
							bool flag4 = obj22 == null;
							object obj23 = 0;
							object obj24 = "Could not load headers for cache: ";
							if (!flag4)
							{
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_0fb9;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag5 = (nint)0 == 1;
								object obj25 = default;
								obj23 = obj25;
								obj24 = "Could not load headers for cache: ";
								if (flag5)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_1115;
								}
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										cacheInfo.metadata = null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
										object obj26 = -1;
										result = cacheInfo;
										goto IL_1463;
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_1115;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj27 = obj15;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj28 = 0;
					cacheInfo2 = cacheInfo;
					if (flag6)
					{
						goto IL_1408;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 != 1;
			object obj29 = default;
			obj11 = obj29;
			object obj30 = default;
			obj13 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			result = (CacheInfo)0;
			if (!flag7)
			{
				obj28 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				cacheInfo2 = (CacheInfo)0;
				goto IL_13e0;
			}
		}
		goto IL_152f;
		IL_0772:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0c58;
		IL_1504:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			result = cacheInfo;
			if (obj8 != null)
			{
				goto IL_1463;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag8 = (nint)0 != 1;
				result = cacheInfo;
				if (flag8)
				{
					goto IL_1463;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_0c58;
		IL_0781:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0c58;
		IL_1463:
		return result;
		IL_1115:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj31 = default;
		obj11 = obj31;
		object obj32 = default;
		obj13 = obj32;
		result = cacheInfo;
		goto IL_152f;
		IL_0790:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0c58;
		IL_07ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0c58;
		IL_152f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj33 = default;
		if (obj33 == obj13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj35 = default;
				object obj34 = obj35;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					CacheInfo cacheInfo3 = default;
					if (cacheInfo3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						object obj36 = (nint)0 << 2;
						object obj37 = obj + obj36;
						obj37 = obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						object obj38 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						object obj39 = (nint)0 << 2;
						object obj40 = obj39 + obj;
						object obj41 = obj40 - 4;
						object obj42 = obj41;
						bool flag9 = obj41 == null;
						string text = "Error handling cache, cache disabled: ";
						string text2 = null;
						if (!flag9)
						{
							object obj43 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v588 @ S1_v54+D4] (should have been resolved before IL gen)");
							text = "Error handling cache, cache disabled: ";
							string text3 = default;
							text2 = text3;
						}
						string text4 = text + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						object obj44 = -1;
						result = null;
						goto IL_1463;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj45 = obj35;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag10 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj28 = 0;
					cacheInfo2 = cacheInfo3;
					if (flag10)
					{
						goto IL_1408;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag11 = (nint)0 != 1;
			object obj46 = default;
			obj28 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			cacheInfo2 = (CacheInfo)0;
			obj11 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			result = (CacheInfo)0;
			if (!flag11)
			{
				goto IL_13e0;
			}
		}
		goto IL_1558;
		IL_07bd:
		cacheInfo.metadata = null;
		goto IL_14a2;
		IL_1558:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_1463;
		IL_1477:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			if (obj6 != null)
			{
				goto IL_14a2;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj47 = default;
				if (obj47 != null)
				{
					goto IL_07bd;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj49 = default;
					object obj52 = default;
					object obj53 = default;
					object obj54 = default;
					while (true)
					{
						object obj48 = obj49;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ S0_v557+C]");
						if ((nint)obj48 >= 0)
						{
							break;
						}
						object obj50 = obj49 << 2;
						object obj51 = obj52 + obj50;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_0772;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_0781;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_0790;
						}
						CacheMetaData metadata4 = cacheInfo.metadata;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_079f;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_07ae;
						}
						if (obj53 == null)
						{
							obj49 = obj54 + 1;
							continue;
						}
						goto IL_07bd;
					}
					goto IL_14a2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_0c58;
		IL_1408:
		obj11 = obj28;
		result = cacheInfo2;
		goto IL_1558;
		IL_14a2:
		CacheMetaData metadata5 = cacheInfo.metadata;
		bool flag12 = cacheInfo.metadata == null;
		result = cacheInfo;
		object obj57;
		if (!flag12)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB6D");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @691");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DF");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj55 = default;
							if (obj55 != null)
							{
								cacheInfo.expired = false;
								result = cacheInfo;
							}
							else
							{
								bool flag13 = (byte)(~(cacheInfo.expired ? 1u : 0u)) != 0;
								result = cacheInfo;
								if (!flag13)
								{
									CacheMetaData metadata6 = cacheInfo.metadata;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										object obj56 = default;
										if (obj56 != null)
										{
											obj57 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ S0_v452+8]");
											if ((nint)0 != 0)
											{
												goto IL_14d9;
											}
										}
										obj57 = 1;
										goto IL_14d9;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_0c58;
								}
							}
							goto IL_1463;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0c58;
		}
		goto IL_1463;
		IL_14d9:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			if (obj57 != null)
			{
				goto IL_0aa2;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0aa2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_0c58;
		IL_13e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_1408;
		IL_079f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0c58;
	}

	private static void HandleCacheAfterRequest(IRequest request, CacheInfo cacheInfo, bool useCacheOnError)
	{
		//IL_00d3: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		Headers headers = default;
		bool flag;
		string text2;
		object obj2;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			DateTime dateTime = headers.Get("Expires", DateTime.MinValue);
			DateTime utcNow = CDateTime.UtcNow;
			flag = dateTime > utcNow;
			string text = headers.get_Item("ETag");
			text2 = headers.get_Item("Last-Modified");
			if (text != null)
			{
				obj2 = 0;
				if (text._stringLength != 0)
				{
					goto IL_02c2;
				}
			}
			obj2 = 1;
			goto IL_02c2;
		}
		if (!useCacheOnError)
		{
			cacheInfo.metadata = null;
		}
		return;
		IL_02c2:
		if (obj2 == null)
		{
			goto IL_011f;
		}
		object obj3;
		if (text2 != null)
		{
			obj3 = 0;
			if (text2._stringLength != 0)
			{
				goto IL_02df;
			}
		}
		obj3 = 1;
		goto IL_02df;
		IL_02f6:
		object obj4 = default;
		bool flag2;
		if ((nint)obj4 != 304)
		{
			if ((nint)obj4 == 200)
			{
				cacheInfo.metadata = null;
				if (flag2)
				{
					CacheMetaData cacheMetaData = default;
					cacheMetaData.responseHeaders = headers;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					Headers requestHeaders = default;
					cacheMetaData.requestHeaders = requestHeaders;
					SaveCacheMetaData(cacheInfo.metaFilename, cacheMetaData);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					byte[] bytes = default;
					SaveCacheContents(cacheInfo.filename, bytes);
				}
			}
			else if (!useCacheOnError)
			{
				cacheInfo.metadata = null;
			}
		}
		else
		{
			CacheMetaData metadata = cacheInfo.metadata;
			if (cacheInfo.metadata != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Headers requestHeaders2 = default;
				metadata.requestHeaders = requestHeaders2;
				CacheMetaData metadata2 = cacheInfo.metadata;
				UpdateCachedHeaders(metadata2.responseHeaders, headers);
				SaveCacheMetaData(cacheInfo.metaFilename, cacheInfo.metadata);
			}
		}
		return;
		IL_02df:
		flag2 = flag;
		if (obj3 == null)
		{
			goto IL_011f;
		}
		goto IL_02f6;
		IL_011f:
		flag2 = true;
		goto IL_02f6;
	}

	private static void UpdateCachedHeaders(Headers cached, Headers updated)
	{
		//IL_00d6: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		string[] cachedHeadersToUpdate = _cachedHeadersToUpdate;
		object obj = 0;
		while (cachedHeadersToUpdate.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)cachedHeadersToUpdate + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v5+10]");
			if (updated.Contains((string)0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v5+10]");
				cached.Remove((string)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v5+10]");
				IEnumerable<string> all = updated.GetAll((string)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v5+10]");
				Headers headers = cached.SetAll((string)0, all);
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	public static void ClearCache(ClearCacheFlags flags, float olderThanSeconds)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_141a: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_1226: Expected Obj, but got I
		//IL_1251: Expected Obj, but got I
		//IL_1276: Expected Obj, but got I
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1291: Expected Obj, but got Unknown
		//IL_026b: Expected Obj, but got I4
		//IL_0279: Expected Obj, but got I4
		//IL_0282: Expected Obj, but got I4
		//IL_1307: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_149f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a4: Expected Obj, but got Unknown
		//IL_03da: Expected Obj, but got I
		//IL_070f: Expected Obj, but got I
		//IL_073a: Expected Obj, but got I
		//IL_0887: Expected Obj, but got I
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected Obj, but got Unknown
		//IL_09b0: Expected Obj, but got I
		//IL_0919: Expected Obj, but got I
		//IL_092b: Expected Obj, but got I4
		//IL_0b74: Expected Obj, but got I
		//IL_0a96: Expected Obj, but got I
		//IL_0d64: Expected Obj, but got I
		//IL_0d8f: Expected Obj, but got I
		//IL_0edc: Expected Obj, but got I
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Expected Obj, but got Unknown
		//IL_0f70: Expected Obj, but got I4
		//IL_10cb: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj28;
		object obj32 = default;
		object obj50 = default;
		object obj29;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj4 = default;
					if (obj4 == null)
					{
						return;
					}
					object obj5 = flags & ClearCacheFlags.All;
					if (obj5 != null)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj6 = 0;
							object obj10 = default;
							while (true)
							{
								object obj7 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v553+C]");
								if ((nint)obj7 < 0)
								{
									object obj8 = obj6 << 2;
									object obj9 = obj10 + obj8;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										break;
									}
									object obj11 = obj6 + 1;
									obj6 = obj11;
									continue;
								}
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @691");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj12 = flags & ClearCacheFlags.Expired;
								object obj13 = flags & ClearCacheFlags.Old;
								object obj14 = 0;
								object obj18 = default;
								object obj20 = default;
								object obj21 = default;
								object obj22 = default;
								double num2 = default;
								object obj24 = default;
								object obj26 = default;
								object obj27 = default;
								object obj30 = default;
								object obj33 = default;
								object obj42 = default;
								object obj46 = default;
								object obj47 = default;
								object obj48 = default;
								object obj51 = default;
								object obj60 = default;
								object obj62 = default;
								object obj63 = default;
								while (true)
								{
									object obj15 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v137+C]");
									if ((nint)obj15 >= 0)
									{
										return;
									}
									object obj16 = obj14 << 2;
									object obj17 = obj18 + obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v155+10]");
									object obj19 = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										break;
									}
									if (obj20 == null)
									{
										goto IL_1496;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									object obj23;
									double num3;
									object obj25;
									bool flag7;
									bool flag;
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											flag = obj13 == null;
											if (flag)
											{
												goto IL_051c;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag2 = (nint)0 == 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ S0_v474+8]");
											obj21 = 0;
											if (!flag2)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8B4");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag3 = (nint)0 == 1;
												obj21 = obj22;
												if (!flag3)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag4 = (nint)0 == 1;
													obj21 = obj22;
													if (!flag4)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
														double num = 0.0 * 1E-07;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag5 = (nint)0 == 1;
														num2 = num;
														obj21 = obj22;
														if (!flag5)
														{
															bool flag6 = (double)olderThanSeconds < num;
															num2 = num;
															obj21 = obj22;
															obj23 = obj24;
															num3 = num;
															obj25 = obj22;
															flag7 = flag;
															if (!flag6)
															{
																goto IL_051c;
															}
															goto IL_0b13;
														}
													}
												}
											}
										}
									}
									goto IL_05fd;
									IL_05fd:
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
									bool flag8 = obj26 != obj27;
									obj28 = obj26;
									obj29 = obj30;
									if (!flag8)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj31 = obj32;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												if (obj33 == null)
												{
													goto IL_079b;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
												object obj34 = (nint)0 << 2;
												object obj35 = obj3 + obj34;
												obj35 = obj32;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
												object obj36 = (nint)0 + (nint)1;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													goto IL_077d;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
												object obj37 = (nint)0 << 2;
												object obj38 = obj37 + obj3;
												object obj39 = obj38 - 4;
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													goto IL_0964;
												}
												bool flag9 = obj39 == null;
												flag7 = !flag9;
												if (!flag7)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													obj23 = 0;
													object obj40 = "Error while clearing cache: ";
													object obj41 = 0;
												}
												else
												{
													_ = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														goto IL_0964;
													}
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag10 = (nint)0 == 1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													obj23 = 0;
													object obj40 = "Error while clearing cache: ";
													object obj41 = obj42;
													if (flag10)
													{
														goto IL_0ab0;
													}
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
															object obj43 = -1;
															num3 = num2;
															obj25 = obj21;
															goto IL_0b13;
														}
													}
												}
												goto IL_0abf;
											}
										}
										goto IL_078c;
									}
									goto IL_14b1;
									IL_0b13:
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										object obj44 = ".metadata";
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ S0_v156+8]");
										nint num4 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ S1_v165+8]");
										object obj45 = num4 - 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ S0_v324+8]");
											bool flag11 = (nint)0 < (nint)1;
											obj24 = obj23;
											num2 = num3;
											obj21 = obj25;
											flag = flag7;
											if (flag11)
											{
												goto IL_1496;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag12 = (nint)0 != 1;
											obj24 = obj23;
											num2 = num3;
											obj21 = obj25;
											flag = flag7;
											if (flag12)
											{
												goto IL_1496;
											}
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
									bool flag13 = obj46 != obj47;
									obj28 = obj46;
									obj29 = obj48;
									if (!flag13)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj49 = obj50;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												if (obj51 == null)
												{
													goto IL_0df0;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
												object obj52 = (nint)0 << 2;
												object obj53 = obj3 + obj52;
												obj53 = obj50;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
												object obj54 = (nint)0 + (nint)1;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													goto IL_0dd2;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
												object obj55 = (nint)0 << 2;
												object obj56 = obj55 + obj3;
												object obj57 = obj56 - 4;
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													goto IL_0fa9;
												}
												if (obj57 == null)
												{
													object obj58 = "Error while clearing cache: ";
													object obj59 = 0;
												}
												else
												{
													_ = 0;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														goto IL_0fa9;
													}
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag14 = (nint)0 == 1;
													object obj58 = "Error while clearing cache: ";
													object obj59 = obj60;
													if (flag14)
													{
														goto IL_10ed;
													}
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
															object obj61 = -1;
															obj24 = obj23;
															num2 = num3;
															obj21 = obj25;
															goto IL_1496;
														}
													}
												}
												goto IL_10fc;
											}
										}
										goto IL_0de1;
									}
									goto IL_14b1;
									IL_051c:
									if (obj12 == null)
									{
										goto IL_1496;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB6D");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag15 = (nint)0 == 1;
										obj21 = obj62;
										if (!flag15)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DF");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag16 = (nint)0 != 1;
											obj21 = obj62;
											if (flag16)
											{
												bool flag17 = obj63 == null;
												obj23 = obj24;
												num3 = num2;
												obj25 = obj62;
												flag7 = flag;
												obj21 = obj62;
												if (flag17)
												{
													goto IL_1496;
												}
												goto IL_0b13;
											}
										}
									}
									goto IL_05fd;
									IL_1496:
									object obj64 = obj14 + 1;
									obj14 = obj64;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_1147;
		IL_13d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_13fd;
		IL_13fd:
		object obj65;
		obj29 = obj65;
		goto IL_14da;
		IL_0df0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
		object obj66 = obj50;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag18 = (nint)0 != 1;
		obj65 = obj66;
		if (!flag18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0e5c;
		}
		goto IL_13fd;
		IL_0ab0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_1147;
		IL_0964:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_1147;
		IL_10ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_1147;
		IL_10fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_1147;
		IL_1147:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj67 = default;
		obj28 = obj67;
		object obj68 = default;
		obj29 = obj68;
		goto IL_14b1;
		IL_0fa9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_1147;
		IL_078c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0807;
		IL_0dd2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_1147;
		IL_079b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
		object obj69 = obj32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag19 = (nint)0 != 1;
		obj65 = obj69;
		if (!flag19)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0807;
		}
		goto IL_13fd;
		IL_0807:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag20 = (nint)0 != 1;
		object obj70 = default;
		obj28 = obj70;
		object obj71 = default;
		obj29 = obj71;
		if (!flag20)
		{
			obj65 = obj71;
			goto IL_13d5;
		}
		goto IL_14b1;
		IL_077d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_1147;
		IL_0e5c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag21 = (nint)0 != 1;
		object obj72 = default;
		obj28 = obj72;
		object obj73 = default;
		obj29 = obj73;
		if (!flag21)
		{
			obj65 = obj73;
			goto IL_13d5;
		}
		goto IL_14b1;
		IL_14b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj74 = default;
		if (obj74 == obj28)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj76 = default;
				object obj75 = obj76;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj77 = default;
					if (obj77 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						object obj78 = (nint)0 << 2;
						object obj79 = obj3 + obj78;
						obj79 = obj76;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						object obj80 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						object obj81 = (nint)0 << 2;
						object obj82 = obj81 + obj3;
						object obj83 = obj82 - 4;
						object obj84 = obj83;
						bool flag22 = obj83 == null;
						string text = "Error while clearing cache: ";
						string text2 = null;
						if (!flag22)
						{
							object obj85 = obj84;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v648 @ S1_v50+D4] (should have been resolved before IL gen)");
							text = "Error while clearing cache: ";
							string text3 = default;
							text2 = text3;
						}
						string text4 = text + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						object obj86 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj87 = obj76;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag23 = (nint)0 != 1;
					obj65 = obj87;
					if (flag23)
					{
						goto IL_13fd;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag24 = (nint)0 != 1;
			object obj88 = default;
			obj65 = obj88;
			obj29 = obj88;
			if (!flag24)
			{
				goto IL_13d5;
			}
		}
		goto IL_14da;
		IL_0abf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_1147;
		IL_0de1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0e5c;
		IL_14da:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private static void SaveCacheMetaData(string file, CacheMetaData metadata)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		FileStream fileStream = default;
		fileStream._002Ector(file, FileMode.Create);
		BinaryWriter binaryWriter = default;
		binaryWriter._002Ector(fileStream);
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @691");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			DateTime timestamp = default;
			metadata.timestamp = timestamp;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16B9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1478");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								goto IL_036e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_021b;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_021b;
		IL_021b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 == obj5;
		bool flag2 = !flag;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_036e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj8 = default;
			obj6 = obj8;
		}
		_ = 0;
		object obj9 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			goto IL_036e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_036e:
		object obj10 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
	}

	private static CacheMetaData LoadCacheMetaData(string file)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		FileStream fileStream = default;
		fileStream._002Ector(file, FileMode.Open);
		BinaryReader binaryReader = default;
		binaryReader._002Ector(fileStream);
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		CacheMetaData result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16B9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					CacheMetaData cacheMetaData = default;
					DateTime timestamp = default;
					cacheMetaData.timestamp = timestamp;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Headers responseHeaders = default;
							cacheMetaData.responseHeaders = responseHeaders;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Headers requestHeaders = default;
										cacheMetaData.requestHeaders = requestHeaders;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag = (nint)0 != 1;
										result = cacheMetaData;
										if (!flag)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											goto IL_02ef;
										}
										goto IL_044b;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							goto IL_02ef;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_02ef;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_02ef;
		IL_044b:
		object obj4 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
		IL_02ef:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag2 = obj5 == obj6;
		bool flag3 = !flag2;
		CacheMetaData cacheMetaData2 = default;
		result = cacheMetaData2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			result = null;
			if (flag4)
			{
				goto IL_044b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			CacheMetaData cacheMetaData3 = default;
			result = cacheMetaData3;
		}
		_ = 0;
		object obj7 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			goto IL_044b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result;
	}

	private static void SaveCacheContents(string file, byte[] bytes)
	{
		byte[] bytes2 = default;
		if (bytes != null)
		{
			bytes2 = bytes;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		}
		FileUtil.WriteAllBytes(file, bytes2);
	}

	private static byte[] LoadCacheContents(string file)
	{
		byte[] array = FileUtil.ReadAllBytes(file);
		byte[] result = array;
		if (array.Length == 0)
		{
			result = null;
		}
		return result;
	}

	private unsafe static void ApplyDefaultSimulationParameters(ref SendOptions options)
	{
		//IL_003d: Invalid comparison between I and F4
		//IL_001e: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [options @ L0 (SendOptions&)+4]");
		if (!(0f > 0f))
		{
			_ = defaultSimulatedRequestLatency;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [options @ L0 (SendOptions&)+8]");
		if ((nint)0 == 0)
		{
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref options, 8));
			obj = defaultSimulatedRequestResults;
		}
	}

	private static float GetSimulatedRequestResponseChanceTotal(IList<SimulatedRequestResult> simulatedRequestResults)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_00b6: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 32;
		float result = default;
		if (simulatedRequestResults != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj4 = default;
			float num2 = default;
			object obj5 = default;
			object obj6 = default;
			float num3 = default;
			float num4 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj4 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v62+8]");
						if (0f > 0f)
						{
							float num = num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v62+8]");
							result = num + 0f;
						}
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj5 != obj6;
				float result2 = num3;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result2 = num4;
				}
				_ = 0;
				object obj7 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result2;
			}
			object obj8 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		}
		return result;
	}

	private static SimulatedRequestResult GetRandomSimulatedRequestResult(IList<SimulatedRequestResult> simulatedRequestResults)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		float simulatedRequestResponseChanceTotal = GetSimulatedRequestResponseChanceTotal(simulatedRequestResults);
		SimulatedRequestResult result = default;
		if (simulatedRequestResponseChanceTotal > 0f)
		{
			if (_random == null)
			{
				System.Random random = default;
				random._002Ector();
				_random = random;
			}
			System.Random random2 = _random;
			object obj3 = random2 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v116 @ S1_v10+BC] (should have been resolved before IL gen)");
			object obj4 = default;
			float num = (float)obj4 * simulatedRequestResponseChanceTotal;
			if (num < simulatedRequestResponseChanceTotal)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj5 = obj + 28;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				float num2 = num;
				object obj6 = default;
				SimulatedRequestResult simulatedRequestResult = default;
				object obj7 = default;
				object obj8 = default;
				SimulatedRequestResult simulatedRequestResult2 = default;
				SimulatedRequestResult simulatedRequestResult3 = default;
				while (true)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						if (obj6 == null)
						{
							result = null;
							break;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (!(simulatedRequestResult.chance < 0f))
							{
								float num3 = num2 - simulatedRequestResult.chance;
								bool flag = !((double)num3 > 0.0);
								result = simulatedRequestResult;
								if (flag)
								{
									break;
								}
								num2 = num3;
							}
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag2 = obj7 != obj8;
					SimulatedRequestResult result2 = simulatedRequestResult2;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 == 1;
						result = null;
						if (!flag3)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						result2 = simulatedRequestResult3;
					}
					_ = 0;
					object obj9 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					return result2;
				}
				object obj10 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
			}
		}
		return result;
	}

	private unsafe static void DoSimulation(IRequest request, ref Action applySimulationToRequest, ref float waitTimeBeforeApply, float simulatedRequestLatency, IList<SimulatedRequestResult> simulatedRequestResults)
	{
		//IL_0118: Expected Ref, but got F4
		//IL_001a: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		ref float reference = ref *(float*)simulatedRequestLatency;
		ref Action reference2 = ref *(Action*)null;
		SimulatedRequestResult randomSimulatedRequestResult = GetRandomSimulatedRequestResult(simulatedRequestResults);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+C]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14+14]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14+C]");
			reference = ref *(float*)null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (System.Object)+C]");
			object obj2 = 0;
			float num = waitTimeBeforeApply;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14+C]");
			object obj3 = num + 0;
			reference = ref *(float*)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v25+14]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v25+18]");
				if ((nint)0 == 0)
				{
					return;
				}
			}
		}
		Action action = default;
		object obj4 = default;
		action._002Ector(obj4, (nint)__ldftn(_003C_003Ec__DisplayClass39_0._003CDoSimulation_003Eb__0));
		reference2 = ref *(Action*)action;
	}

	private static void LogError(string msg)
	{
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
	}

	static WebClient()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
