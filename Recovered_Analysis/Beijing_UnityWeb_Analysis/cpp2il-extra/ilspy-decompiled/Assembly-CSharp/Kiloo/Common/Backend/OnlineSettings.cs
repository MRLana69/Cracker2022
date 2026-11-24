using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Backend;

public sealed class OnlineSettings<T>
{
	private class Data
	{
		public T data;

		public DateTime expires;

		public byte[] hash;

		public Data()
		{
			//IL_005d: Expected I4, but got Obj
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			string message = string.ConcatArray((string[])(object)"[OnlineSettings] ", (int)this);
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
	}

	private Action m_downloaded;

	private bool isDownloading__BackingField;

	private const string API_GET_SETTINGS = "api/v2/settings";

	private const string ONLINESETTINGS_EXPIRES = "onlinesettings_expires";

	private const string ONLINESETTINGS_HASH = "onlinesettings_hash";

	private Data _data;

	private readonly Uri _baseUri;

	private readonly string _file;

	private readonly IJsonSerializer _jsonSerializer;

	private readonly IDictionary<string, string> _parameters;

	public bool isDownloading
	{
		get
		{
			//IL_0009: Expected Obj, but got I4
			//IL_0078: Expected I4, but got Obj
			//IL_0033: Expected Obj, but got I
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			object obj = 0;
			if (this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
				object obj2 = 0;
				object obj3 = obj2;
				object obj4 = obj3 & 0x3FFF;
				object obj5 = obj4 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v23 @ S2_v5 (should have been resolved before IL gen)");
				bool result = default;
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			return (byte)(int)obj != 0;
		}
		private set
		{
			//IL_002a: Expected Obj, but got I
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected Obj, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected Obj, but got Unknown
			if (this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj2 & 0x3FFF;
				object obj4 = obj3 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S3_v5 (should have been resolved before IL gen)");
			}
		}
	}

	public T data
	{
		get
		{
			//IL_0019: Expected VT, but got I4
			bool flag = isDownloading__BackingField;
			return (T)flag;
		}
	}

	public IDictionary<string, string> parameters
	{
		get
		{
			//IL_0014: Expected Obj, but got VT
			Data data = _data;
			return (IDictionary<string, string>)data.data;
		}
	}

	public event Action downloaded
	{
		add
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			isDownloading__BackingField = flag;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.downloaded;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public OnlineSettings(Uri baseUri, string file, IJsonSerializer jsonSerializer)
	{
		//IL_002a: Expected Obj, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L4 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x7FF;
			object obj4 = obj3 + 121922;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	public Coroutine DownloadIfExpired()
	{
		return (Coroutine)(object)_parameters;
	}

	public Coroutine Download()
	{
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I8
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		Data data = _data;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v33 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		object obj3 = default;
		object obj2 = obj3 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Kiloo.Common.Backend.OnlineSettings`1<T>+Data<T>)+10]");
		obj2 = 0;
		obj3 = systemTimeAsFileTime;
		object obj4 = obj3 + 16;
		obj4 = obj2;
		object obj5 = obj3 + 24;
		obj5 = obj3;
		object obj6 = obj4 & 0x3FFFFFFFFFFFFFFFL;
		object obj7 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v20+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v21+4]");
			object obj10 = 0;
			object obj11 = obj10 & 0x3FFF;
			object obj12 = obj11 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v80 @ S2_v6 (should have been resolved before IL gen)");
			Coroutine result = default;
			return result;
		}
		return null;
	}

	private unsafe Data Load()
	{
		//IL_0227: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I
		//IL_0253: Expected Obj, but got I
		//IL_0263: Expected Obj, but got I
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I
		//IL_02b1: Expected Obj, but got I
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected Obj, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0360: Expected I, but got Obj
		//IL_0376: Expected Obj, but got I
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0094: Expected I, but got Obj
		//IL_00aa: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_0122: Expected I, but got Obj
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected VT, but got Unknown
		//IL_01ef: Expected I4, but got Obj
		//IL_01ea: Expected native int or pointer, but got VT
		//IL_0204: Expected Obj, but got I
		//IL_01ff: Expected native int or pointer, but got VT
		//IL_0215: Expected Obj, but got I4
		//IL_00d5: Expected I, but got Obj
		object obj = 0;
		_ = 0;
		nint num = default;
		object obj2 = num + 12;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v8+8]");
		object obj5 = 0;
		object obj6 = obj5 & 0x3FFF;
		object obj7 = obj6 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S2_v5 (should have been resolved before IL gen)");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v7+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v8+10]");
		object obj10 = 0;
		object obj11 = obj10 & 0x3FFF;
		object obj12 = obj11 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S3_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri._002Ector(_baseUri, (Uri)(object)"api/v2/settings");
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v13+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v14+14]");
		object obj15 = 0;
		object obj16 = obj15 & 0x3FFF;
		object obj17 = obj16 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v76 @ S2_v15 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj18 = default;
		bool flag = (nint)obj18 >= 1;
		bool flag2 = !flag;
		Uri uri2 = uri;
		if (!flag2)
		{
			object obj19 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v37+60]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v38+14]");
			object obj21 = 0;
			object obj22 = obj21 & 0x3FFF;
			object obj23 = obj22 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98 @ S2_v36 (should have been resolved before IL gen)");
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v41 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num3 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v47 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IEnumerable<KeyValuePair<string, string>> queryParameters = default;
			Uri uri3 = WebClient.AddQueryParametersToUri((string)(object)uri, queryParameters);
			uri2 = uri3;
		}
		nint num4 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v25 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num5 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v34 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IRequest request = KilooWebClient.CreatePut(uri2);
		IRequest tag = KilooWebClient.WithKilooTags(request);
		bool flag3 = KilooWebClient.HasTag((string)(object)tag);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S2_v19+60]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v20+18]");
		nint num6 = 0;
		WebClient.RequestCompleteHandler requestCompleteHandler = default;
		((Delegate)requestCompleteHandler).method_ptr = (nint)((IntPtr*)num6)->m_value;
		((Delegate)requestCompleteHandler).method = num6;
		object obj28 = requestCompleteHandler + 16;
		obj28 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
		return (Data)(object)RequestExtensions.SendAsync((IRequest)flag3, requestCompleteHandler, sendOptions);
	}

	private static void LogError(string msg)
	{
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[OnlineSettings] ", (int)msg);
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

	private void _003CDownload_003Eb__13_0(IRequest request, bool fromCache)
	{
		//IL_002a: Expected Obj, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x1FFF;
			object obj4 = obj3 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v18 @ S4_v5 (should have been resolved before IL gen)");
		}
	}
}
