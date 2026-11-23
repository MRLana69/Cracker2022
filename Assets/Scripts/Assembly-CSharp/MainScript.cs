using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Models;
using Proyecto26;
using RSG;
using UnityEngine;
using UnityEngine.Networking;

public class MainScript : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<RequestException, int> _003C_003E9__5_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CPut_003Eb__5_1(RequestException err, int retries)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected Obj, but got Unknown
			//IL_004c: Expected Obj, but got I8
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			obj = err._statusCode;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			object arg2 = default;
			string message = $"Retry #{arg} Status {arg2}\nError: {err}";
			Debug.Log(message);
		}
	}

	private readonly string basePath = "https://jsonplaceholder.typicode.com";

	private RequestHelper currentRequest;

	private void LogMessage(string title, string message)
	{
		Debug.Log(message);
	}

	public void Get()
	{
		//IL_00b2: Expected Obj, but got I
		Dictionary<string, string> defaultRequestHeaders = RestClient.DefaultRequestHeaders;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S5_v4+4] (should have been resolved before IL gen)");
		_ = 0;
		string url = basePath + "/posts";
		IPromise<Post[]> array = RestClient.GetArray<Post>(url);
		throw new ArgumentException();
	}

	public void Post()
	{
		//IL_014b: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I
		Dictionary<string, string> defaultRequestParams = RestClient.DefaultRequestParams;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S5_v4+4] (should have been resolved before IL gen)");
		Dictionary<string, string> defaultRequestParams2 = RestClient.DefaultRequestParams;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S5_v9+4] (should have been resolved before IL gen)");
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		string uri = basePath + "/posts";
		requestHelper._uri = uri;
		nint num5 = 0;
		nint num6 = 0;
		IntPtr intPtr = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S4_v14 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ S5_v14+4] (should have been resolved before IL gen)");
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ S5_v19+4] (should have been resolved before IL gen)");
		Dictionary<string, string> dictionary = default;
		requestHelper._params = dictionary;
		_ = 1;
		object body = default;
		requestHelper._body = body;
		requestHelper._enableDebug = true;
		currentRequest = requestHelper;
		IPromise<Post> promise = RestClient.Post<Post>(currentRequest);
		throw new ArgumentException();
	}

	public void Put()
	{
		//IL_0043: Expected I4, but got I8
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		string uri = basePath + "/posts/1";
		requestHelper._uri = uri;
		_ = 1;
		object body = default;
		requestHelper._body = body;
		requestHelper._retries = 5;
		bool flag = _003C_003Ec._003C_003E9__5_1 == null;
		bool flag2 = !flag;
		Action<RequestException, int> retryCallback = _003C_003Ec._003C_003E9__5_1;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		requestHelper._retryCallback = retryCallback;
		currentRequest = requestHelper;
		throw new ArgumentException();
	}

	public void Delete()
	{
		string text = basePath + "/posts/1";
		throw new ArgumentException();
	}

	public void AbortRequest()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		if (currentRequest != null)
		{
			currentRequest.Abort();
			object obj = this + 16;
			obj = 0;
		}
	}

	public void DownloadFile()
	{
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._uri = "https://raw.githubusercontent.com/IonDen/ion.sound/master/sounds/bell_ring.ogg";
		DownloadHandlerAudioClip downloadHandlerAudioClip = default;
		downloadHandlerAudioClip._002Ector("https://raw.githubusercontent.com/IonDen/ion.sound/master/sounds/bell_ring.ogg", AudioType.OGGVORBIS);
		requestHelper._downloadHandler = downloadHandlerAudioClip;
		IPromise<ResponseHelper> promise = RestClient.Get(requestHelper);
		throw new ArgumentException();
	}

	private void _003CPost_003Eb__4_0(Post res)
	{
		RestClient.ClearDefaultParams();
		string message = JsonUtility.ToJson(res, prettyPrint: true);
		((MainScript)(object)res).LogMessage((string)(object)res, message);
	}

	private void _003CPost_003Eb__4_1(Exception err)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		nint num = (nint)err;
		object obj = err + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S3_v2 (Il2CppClass<System.Exception>)+E4] (should have been resolved before IL gen)");
		string message = default;
		((MainScript)(object)err).LogMessage((string)(object)err, message);
	}

	private void _003CPut_003Eb__5_0(RequestException err, ResponseHelper res, Post body)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		MainScript mainScript = default;
		if (err != null)
		{
			nint num = (nint)err;
			object obj = err + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S1_v6 (Il2CppClass<Proyecto26.RequestException>)+E4] (should have been resolved before IL gen)");
		}
		else
		{
			string text = JsonUtility.ToJson(body, prettyPrint: true);
			mainScript = (MainScript)(object)text;
		}
		mainScript.LogMessage((string)(object)mainScript, (string)(object)mainScript);
	}

	private unsafe void _003CDelete_003Eb__6_0(RequestException err, ResponseHelper res)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0063: Expected I, but got I8
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected I8, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		object obj = default;
		MainScript mainScript = (MainScript)(obj - 16);
		if (err != null)
		{
			nint num = (nint)err;
			object obj2 = err + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S3_v5 (Il2CppClass<Proyecto26.RequestException>)+E4] (should have been resolved before IL gen)");
			string message = default;
			mainScript.LogMessage((string)(object)mainScript, message);
		}
		else
		{
			long statusCode = res.StatusCode;
			((UnityEngine.Object)mainScript).m_CachedPtr = (nint)statusCode;
			long num2 = mainScript + 8;
			string text = ((long*)num2)->ToString();
			string message2 = "Status: " + text;
			mainScript.LogMessage((string)(object)mainScript, message2);
		}
	}

	private void _003CDownloadFile_003Eb__8_0(ResponseHelper res)
	{
		AudioSource component = GetComponent<AudioSource>();
		UnityWebRequest unityWebRequest = res.Request__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		DownloadHandlerAudioClip downloadHandlerAudioClip = default;
		AudioClip audioClip = downloadHandlerAudioClip.audioClip;
		component.clip = audioClip;
		component.Play();
	}

	private void _003CDownloadFile_003Eb__8_1(Exception err)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		nint num = (nint)err;
		object obj = err + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S3_v2 (Il2CppClass<System.Exception>)+E4] (should have been resolved before IL gen)");
		string message = default;
		((MainScript)(object)err).LogMessage((string)(object)err, message);
	}
}
