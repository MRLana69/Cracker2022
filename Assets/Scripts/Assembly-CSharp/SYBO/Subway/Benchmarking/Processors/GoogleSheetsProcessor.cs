using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Common.Benchmarking;
using SYBO.Subway.Themes;
using UnityEngine;
using UnityEngine.Networking;

namespace SYBO.Subway.Benchmarking.Processors;

public class GoogleSheetsProcessor : IBenchmarkProcessor
{
	private class ParameterContainer
	{
		private string Key__BackingField;

		private string Value__BackingField;

		public string Key
		{
			get
			{
				return Key__BackingField;
			}
			private set
			{
				Key__BackingField = value;
			}
		}

		public string Value
		{
			get
			{
				return Value__BackingField;
			}
			private set
			{
				Value__BackingField = value;
			}
		}

		public ParameterContainer(string key, string value)
		{
			Key__BackingField = key;
			Value__BackingField = value;
		}
	}

	private class GoogleSheetsProcessorUpdater : MonoBehaviour
	{
	}

	private sealed class _003CUploadReportToGoogleSheets_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleSheetsProcessor _003C_003E4__this;

		public IBenchmark benchmark;

		private UnityWebRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected VT, but got Unknown
			//IL_0119: Expected Ref, but got VT
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected Obj, but got Unknown
			//IL_0334: Expected Ref, but got F4
			//IL_03f9: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			_ = 0;
			GoogleSheetsProcessor googleSheetsProcessor = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					bool isNetworkError = _003Crequest_003E5__2.isNetworkError;
					UIScreenController instance = UIScreenController.Instance;
					StringID key = StringID.UPLOAD_FAILED_MESSAGE;
					if (!isNetworkError)
					{
						key = StringID.UPLOAD_SUCCESS_MESSAGE;
					}
					string message = Strings.Get(key);
					instance.QueueErrorMessageSlidein(message);
					if (OnUploadCompleted != null)
					{
						Action onUploadCompleted = OnUploadCompleted;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v169.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					GameObject gameObject = googleSheetsProcessor._processorUpdater.gameObject;
					UnityEngine.Object.Destroy(gameObject);
					googleSheetsProcessor._processorUpdater = null;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				List<ParameterContainer> list = default;
				list._002Ector();
				ParameterContainer parameterContainer = default;
				parameterContainer.Key__BackingField = "ssid";
				parameterContainer.Value__BackingField = googleSheetsProcessor._spreadsheetId;
				list.Add(parameterContainer);
				ParameterContainer parameterContainer2 = default;
				parameterContainer2.Key__BackingField = "sheet";
				parameterContainer2.Value__BackingField = googleSheetsProcessor._worksheetName;
				list.Add(parameterContainer2);
				string deviceModel = SystemInfo.GetDeviceModel();
				ParameterContainer parameterContainer3 = default;
				parameterContainer3.Key__BackingField = "groupby";
				parameterContainer3.Value__BackingField = deviceModel;
				list.Add(parameterContainer3);
				DateTime now = DateTime.Now;
				DateTime dateTime = (DateTime)(obj + 24);
				string text = ((DateTime*)dateTime)->ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
				ParameterContainer parameterContainer4 = default;
				parameterContainer4.Key__BackingField = "val";
				parameterContainer4.Value__BackingField = text;
				list.Add(parameterContainer4);
				string deviceModel2 = SystemInfo.GetDeviceModel();
				ParameterContainer parameterContainer5 = default;
				parameterContainer5.Key__BackingField = "val";
				parameterContainer5.Value__BackingField = deviceModel2;
				list.Add(parameterContainer5);
				string deviceName = SystemInfo.GetDeviceName();
				ParameterContainer parameterContainer6 = default;
				parameterContainer6.Key__BackingField = "val";
				parameterContainer6.Value__BackingField = deviceName;
				list.Add(parameterContainer6);
				DeviceInfo instance2 = DeviceInfo.Instance;
				Enum obj3 = (Enum)(obj + 8);
				_ = -1;
				obj3 = (Enum)(object)typeof(DeviceInfo.PerformanceLevel);
				_ = instance2.performanceLevel;
				string text2 = obj3.ToString();
				ParameterContainer parameterContainer7 = default;
				parameterContainer7.Key__BackingField = "val";
				parameterContainer7.Value__BackingField = text2;
				list.Add(parameterContainer7);
				string bundleVersion = DeviceUtility.GetBundleVersion();
				ParameterContainer parameterContainer8 = default;
				parameterContainer8.Key__BackingField = "val";
				parameterContainer8.Value__BackingField = bundleVersion;
				list.Add(parameterContainer8);
				ThemeManager instance3 = ThemeManager.Instance;
				string name = instance3._theme.name;
				ParameterContainer parameterContainer9 = default;
				parameterContainer9.Key__BackingField = "val";
				parameterContainer9.Value__BackingField = name;
				list.Add(parameterContainer9);
				string operatingSystem = SystemInfo.GetOperatingSystem();
				ParameterContainer parameterContainer10 = default;
				parameterContainer10.Key__BackingField = "val";
				parameterContainer10.Value__BackingField = operatingSystem;
				list.Add(parameterContainer10);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2CB");
				object obj4 = default;
				float num = (float)obj4 / 60f;
				float num2 = (float)obj + 20f;
				string text3 = ((float*)num2)->ToString("0.00");
				ParameterContainer parameterContainer11 = default;
				parameterContainer11.Key__BackingField = "val";
				parameterContainer11.Value__BackingField = text3;
				list.Add(parameterContainer11);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				IBenchmarkMetric[] metrics = default;
				List<string> list2 = googleSheetsProcessor.Serialize(metrics);
				int num3 = 0;
				ParameterContainer parameterContainer12 = default;
				while (num3 < list2._size)
				{
					string text4 = list2.get_Item(num3);
					parameterContainer12.Key__BackingField = "val";
					parameterContainer12.Value__BackingField = text4;
					list.Add(parameterContainer12);
					int num4 = num3 + 1;
					num3 = num4;
				}
				WWWForm formData = ((GoogleSheetsProcessor)num3).ConstructPostParametersForm(list);
				UnityWebRequest unityWebRequest = UnityWebRequest.Post(googleSheetsProcessor._googleScriptUrl, formData);
				_003Crequest_003E5__2 = unityWebRequest;
				AsyncOperation asyncOperation = _003Crequest_003E5__2.Send();
				_003C_003E2__current = asyncOperation;
				_003C_003E1__state = 1;
			}
			return true;
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

	private sealed class _003CTestGoogleConnection_003Ed__25(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleSheetsProcessor _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected Obj, but got Unknown
			GoogleSheetsProcessor googleSheetsProcessor = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (!_003Crequest_003E5__2.isNetworkError)
					{
						UnityWebRequest unityWebRequest = _003Crequest_003E5__2;
						DownloadHandler downloadHandler = unityWebRequest.m_DownloadHandler;
						object obj = downloadHandler - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ S1_v37+BC] (should have been resolved before IL gen)");
						string text = default;
						if (text.Equals("Connection Established"))
						{
							googleSheetsProcessor._connectionSuccessful = true;
							return false;
						}
					}
					UIScreenController instance = UIScreenController.Instance;
					string message = Strings.Get(StringID.CONNECTION_TEST_FAILED_ERROR_MESSAGE);
					instance.QueueErrorMessageSlidein(message);
					googleSheetsProcessor._connectionSuccessful = false;
				}
				return false;
			}
			_003C_003E1__state = -1;
			List<ParameterContainer> list = default;
			list._002Ector();
			ParameterContainer parameterContainer = default;
			parameterContainer.Key__BackingField = "ssid";
			parameterContainer.Value__BackingField = googleSheetsProcessor._spreadsheetId;
			list.Add(parameterContainer);
			ParameterContainer parameterContainer2 = default;
			parameterContainer2.Key__BackingField = "sheet";
			parameterContainer2.Value__BackingField = googleSheetsProcessor._worksheetName;
			list.Add(parameterContainer2);
			ParameterContainer parameterContainer3 = default;
			parameterContainer3.Key__BackingField = "template";
			parameterContainer3.Value__BackingField = googleSheetsProcessor._template;
			list.Add(parameterContainer3);
			ParameterContainer parameterContainer4 = default;
			parameterContainer4.Key__BackingField = "action";
			parameterContainer4.Value__BackingField = "ConnectionTest";
			list.Add(parameterContainer4);
			string uri = ConstructGetUriWithParameters(googleSheetsProcessor._googleScriptUrl, list);
			UnityWebRequest unityWebRequest2 = UnityWebRequest.Get(uri);
			_003Crequest_003E5__2 = unityWebRequest2;
			AsyncOperation asyncOperation = _003Crequest_003E5__2.Send();
			_003C_003E2__current = asyncOperation;
			_003C_003E1__state = 1;
			return true;
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

	public static Action OnUploadCompleted;

	private const string ValueParameterKey = "val";

	private const string SpreadsheetIdParameterKey = "ssid";

	private const string WorksheetNameParameterKey = "sheet";

	private const string TemplateParameterKey = "template";

	private const string ActionParameterKey = "action";

	private const string GroupByParameterKey = "groupby";

	private string _spreadsheetId;

	private string _googleScriptUrl;

	private const string UploadSuccessResponse = "Upload Successful";

	private const string ActionConnectTestParameter = "ConnectionTest";

	private const string ConnectionTestSuccessResponse = "Connection Established";

	private string _worksheetName;

	private string _template;

	private GoogleSheetsProcessorUpdater _processorUpdater;

	private bool _connectionSuccessful;

	public char SeparatorCharacter => ';';

	public GoogleSheetsProcessor(string worksheetNamePostfix = "", string overrideSheetId = "1zlH66LBgQDKCTbArHEk9Sl9r4t5SHKtVo8NnzlxtU5c", string overrideScriptUrl = "https://script.google.com/macros/s/AKfycbzysbyZuNXvOTJh5llqjN4N2dP4PAXusuwfaHjvTD3ESkx5Sas/exec")
	{
		_spreadsheetId = string.Empty;
		_googleScriptUrl = string.Empty;
		_worksheetName = string.Empty;
		_template = string.Empty;
		_worksheetName = DeviceUtility.GetBundleVersion() + "_" + worksheetNamePostfix;
		_spreadsheetId = overrideSheetId;
		_googleScriptUrl = overrideScriptUrl;
		bool flag = worksheetNamePostfix.Contains("memory");
		object template = "template_memory";
		if (!flag)
		{
			template = "template";
		}
		_template = (string)template;
		GameObject gameObject = default;
		gameObject._002Ector();
		gameObject.hideFlags = HideFlags.HideAndDontSave;
		_processorUpdater = gameObject.AddComponent<GoogleSheetsProcessorUpdater>();
		_connectionSuccessful = false;
		IEnumerator routine = TestGoogleConnection();
		Coroutine coroutine = _processorUpdater.StartCoroutine(routine);
	}

	public void Process(IBenchmark benchmark)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		if (~(_connectionSuccessful ? 1u : 0u) == 0)
		{
			IEnumerator routine = UploadReportToGoogleSheets(benchmark);
			Coroutine coroutine = _processorUpdater.StartCoroutine(routine);
			return;
		}
		object obj = this + 24;
		GameObject gameObject = ((Component)obj).gameObject;
		UnityEngine.Object.Destroy(gameObject);
		obj = 0;
	}

	private IEnumerator UploadReportToGoogleSheets(IBenchmark benchmark)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private List<string> Serialize(IBenchmarkMetric[] metrics)
	{
		//IL_0035: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		List<string> list = default;
		list._002Ector();
		GoogleSheetsProcessor googleSheetsProcessor = null;
		while (metrics.Length > (nint)googleSheetsProcessor)
		{
			object obj = (object)googleSheetsProcessor << 2;
			object obj2 = (object)metrics + obj;
			GoogleSheetsProcessor googleSheetsProcessor2 = googleSheetsProcessor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v7+10]");
			List<string> list2 = googleSheetsProcessor2.SerializeMetric((IBenchmarkMetric)0);
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S4_v4 (Il2CppRgctx<System.Collections.Generic.List`1<System.String>>)+3C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S4_v5+4] (should have been resolved before IL gen)");
			GoogleSheetsProcessor googleSheetsProcessor3 = (GoogleSheetsProcessor)(googleSheetsProcessor + 1);
			googleSheetsProcessor = googleSheetsProcessor3;
		}
		return list;
	}

	private List<string> SerializeMetric(IBenchmarkMetric metric)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		List<string> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj3 = default;
		List<string> list2 = default;
		if (obj3 != null)
		{
			string text = list2.get_Item(0);
			string item = "=COUNTIF(SPLIT(\"" + text + "\", \";\"), \"> 0\")";
			list2.Add(item);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj4 = default;
		bool flag = obj4 == null;
		bool flag2 = !flag;
		object obj5 = ")";
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			object obj6 = ")";
			object obj7 = default;
			if (obj7 == null)
			{
				obj6 = ", {\"charttype\",\"column\"})";
			}
			obj5 = obj6;
		}
		int num = 0;
		while (num < list2._size)
		{
			string item2 = list2.get_Item(num);
			list.Add(item2);
			int num2 = num + 1;
			num = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private IEnumerator TestGoogleConnection()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private string ConstructGetUriWithParameters(string url, List<ParameterContainer> parameters)
	{
		//IL_0104: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I4
		if (parameters._size != 0)
		{
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector(url);
			StringBuilder stringBuilder2 = stringBuilder.Append("?");
			int num = 0;
			while (num < parameters._size)
			{
				ParameterContainer parameterContainer = parameters.get_Item(num);
				StringBuilder stringBuilder3 = stringBuilder.Append(parameterContainer.Key__BackingField);
				StringBuilder stringBuilder4 = stringBuilder.Append("=");
				StringBuilder stringBuilder5 = stringBuilder.Append(parameterContainer.Value__BackingField);
				object obj = parameters._size - 1;
				if (num < (nint)obj)
				{
					StringBuilder stringBuilder6 = stringBuilder.Append("&");
				}
				int num2 = num + 1;
				num = num2;
			}
			nint num3 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S1_v9 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			string result = default;
			return result;
		}
		return url;
	}

	private WWWForm ConstructPostParametersForm(List<ParameterContainer> parameters)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		WWWForm wWWForm = default;
		wWWForm._002Ector();
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj9 = default;
		object obj10 = default;
		WWWForm wWWForm2 = default;
		WWWForm wWWForm3 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj9 == obj10;
			bool flag3 = !flag2;
			WWWForm result = wWWForm2;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = wWWForm3;
			}
			_ = 0;
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		object obj12 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4C9");
		return wWWForm;
	}
}
