using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Common.Automation;
using SYBO.Common.Benchmarking;
using SYBO.Subway.Level;
using UI.SlideIns;
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
				return Value__BackingField;
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
				return Key__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 8;
				obj = value;
			}
		}

		public ParameterContainer(string key, string value)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected Obj, but got Unknown
			Key__BackingField = value;
			object obj = this + 16;
			obj = key;
		}
	}

	private class GoogleSheetsProcessorUpdater : MonoBehaviour
	{
	}

	private sealed class _003CUploadReportToGoogleSheets_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleSheetsProcessor _003C_003E4__this;

		public IBenchmark benchmark;

		private UnityWebRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0992: Expected Obj, but got I4
				//IL_099b: Unknown result type (might be due to invalid IL or missing references)
				//IL_09a0: Expected Obj, but got Unknown
				//IL_09a9: Expected Obj, but got I4
				//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_09b7: Expected Obj, but got Unknown
				//IL_09c0: Expected Obj, but got F4
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected Obj, but got Unknown
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected Obj, but got Unknown
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b2: Expected Obj, but got Unknown
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Expected Obj, but got Unknown
				//IL_06f8: Expected I, but got Obj
				//IL_070e: Expected Obj, but got I
				//IL_0109: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Expected Obj, but got Unknown
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Expected Obj, but got Unknown
				//IL_0148: Expected I, but got Obj
				//IL_015e: Expected Obj, but got I
				//IL_0b76: Expected I, but got Obj
				//IL_0b8c: Expected Obj, but got I
				//IL_09fa: Expected Obj, but got VT
				//IL_0bc4: Expected Obj, but got I4
				//IL_0826: Expected I, but got Obj
				//IL_0b0c: Expected I, but got Obj
				//IL_0b22: Expected Obj, but got I
				//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d6: Expected Obj, but got Unknown
				//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ed: Expected Obj, but got Unknown
				//IL_0189: Expected I, but got Obj
				//IL_0873: Expected I, but got Obj
				//IL_0b5a: Expected Obj, but got I4
				//IL_0768: Expected I, but got Obj
				//IL_0223: Unknown result type (might be due to invalid IL or missing references)
				//IL_0228: Expected Obj, but got Unknown
				//IL_023a: Unknown result type (might be due to invalid IL or missing references)
				//IL_023f: Expected Obj, but got Unknown
				//IL_08ff: Expected I, but got Obj
				//IL_0915: Expected Obj, but got I
				//IL_07b5: Expected I, but got Obj
				//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0be0: Expected Obj, but got Unknown
				//IL_0be9: Expected Obj, but got I4
				//IL_027a: Unknown result type (might be due to invalid IL or missing references)
				//IL_027f: Expected Obj, but got Unknown
				//IL_0291: Unknown result type (might be due to invalid IL or missing references)
				//IL_0296: Expected Obj, but got Unknown
				//IL_02b9: Expected I, but got Obj
				//IL_02cf: Expected Obj, but got I
				//IL_0940: Expected I, but got Obj
				//IL_0a2c: Expected Obj, but got I
				//IL_02fa: Expected I, but got Obj
				object obj = 0;
				object obj2 = obj + 12;
				obj2 = 0;
				object obj3 = obj + 8;
				obj3 = 0f;
				GoogleSheetsProcessor googleSheetsProcessor = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						bool isHttpError = _003Crequest_003E5__2.isHttpError;
						nint num = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v127 (Il2CppClass<UIScreenController>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						bool flag = obj4 == null;
						if (isHttpError)
						{
							if (!flag)
							{
								nint num2 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v222 (Il2CppClass<UIScreenController>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag2 = UIScreenController.ShouldShowOnlineScreen();
							nint num3 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v160 (Il2CppClass<Strings>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num4 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v167 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string slideIn = Strings.GetDefault("UPLOAD_FAILED_MESSAGE");
							((UIScreenController)flag2).QueueSlideIn((SlideIn)(object)slideIn);
						}
						else
						{
							if (!flag)
							{
								nint num5 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v213 (Il2CppClass<UIScreenController>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag3 = UIScreenController.ShouldShowOnlineScreen();
							nint num6 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v148 (Il2CppClass<Strings>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num7 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v155 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string slideIn2 = Strings.GetDefault("UPLOAD_SUCCESS_MESSAGE");
							((UIScreenController)flag3).QueueSlideIn((SlideIn)(object)slideIn2);
						}
						if (OnUploadCompleted != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						}
						string tag = googleSheetsProcessor._processorUpdater.tag;
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S1_v135 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num9 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S1_v142 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
						object obj8 = googleSheetsProcessor + 24;
						obj8 = 0;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<ParameterContainer> list = default;
				list._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ParameterContainer parameterContainer = default;
				object obj9 = parameterContainer + 8;
				obj9 = "ssid";
				object obj10 = parameterContainer + 12;
				obj10 = googleSheetsProcessor._spreadsheetId;
				list.Add(parameterContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ParameterContainer parameterContainer2 = default;
				object obj11 = parameterContainer2 + 8;
				obj11 = "sheet";
				object obj12 = parameterContainer2 + 12;
				obj12 = googleSheetsProcessor._worksheetName;
				list.Add(parameterContainer2);
				string graphicsDeviceName = SystemInfo.GetGraphicsDeviceName();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ParameterContainer parameterContainer3 = default;
				object obj13 = parameterContainer3 + 8;
				obj13 = "groupby";
				object obj14 = parameterContainer3 + 12;
				obj14 = graphicsDeviceName;
				list.Add(parameterContainer3);
				nint num10 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v50 (Il2CppClass<System.DateTime>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num11 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v184 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime utcNow = DateTime.UtcNow;
				obj = utcNow;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ParameterContainer parameterContainer4 = default;
				object obj16 = parameterContainer4 + 8;
				obj16 = "val";
				object obj17 = parameterContainer4 + 12;
				object obj18 = default;
				obj17 = obj18;
				list.Add(parameterContainer4);
				string graphicsDeviceName2 = SystemInfo.GetGraphicsDeviceName();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ParameterContainer parameterContainer5 = default;
				object obj19 = parameterContainer5 + 8;
				obj19 = "val";
				object obj20 = parameterContainer5 + 12;
				obj20 = graphicsDeviceName2;
				list.Add(parameterContainer5);
				string deviceModel = SystemInfo.GetDeviceModel();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ParameterContainer parameterContainer6 = default;
				object obj21 = parameterContainer6 + 8;
				obj21 = "val";
				object obj22 = parameterContainer6 + 12;
				obj22 = deviceModel;
				list.Add(parameterContainer6);
				nint num12 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v83 (Il2CppClass<DeviceInfo>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num13 = (nint)typeof(DeviceInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v180 (Il2CppClass<DeviceInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S1_v56 (System.Int32)+8]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CUploadReportToGoogleSheets_003Ed__20(int _003C_003E1__state)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 12;
			obj = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
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

	private sealed class _003CTestGoogleConnection_003Ed__23(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleSheetsProcessor _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected Obj, but got Unknown
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected Obj, but got Unknown
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b2: Expected Obj, but got Unknown
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Expected Obj, but got Unknown
				//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Expected Obj, but got Unknown
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Expected Obj, but got Unknown
				//IL_0149: Unknown result type (might be due to invalid IL or missing references)
				//IL_014e: Expected Obj, but got Unknown
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0165: Expected Obj, but got Unknown
				//IL_0238: Expected I, but got Obj
				//IL_024e: Expected Obj, but got I
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_018b: Expected Obj, but got Unknown
				//IL_0393: Expected I4, but got Obj
				//IL_04d0: Expected I, but got Obj
				//IL_04e6: Expected Obj, but got I
				//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Expected Obj, but got Unknown
				//IL_01f2: Expected Obj, but got I4
				//IL_03b4: Expected I, but got Obj
				//IL_03ca: Expected Obj, but got I
				//IL_051e: Expected Obj, but got I4
				//IL_0279: Expected I, but got Obj
				//IL_054d: Expected I, but got Obj
				//IL_0563: Expected Obj, but got I
				//IL_02c6: Expected I, but got Obj
				//IL_059b: Expected Obj, but got I4
				//IL_03f5: Expected I, but got Obj
				//IL_0442: Expected I, but got Obj
				GoogleSheetsProcessor googleSheetsProcessor = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						if (_003Crequest_003E5__2.isHttpError)
						{
							nint num = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v89 (Il2CppClass<UIScreenController>)+BA]");
							object obj = (nint)0 & (nint)0x200;
							if (obj != null)
							{
								nint num2 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v97 (Il2CppClass<UIScreenController>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag = UIScreenController.ShouldShowOnlineScreen();
							nint num3 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v64 (Il2CppClass<Strings>)+BA]");
							object obj2 = (nint)0 & (nint)0x200;
							if (obj2 != null)
							{
								nint num4 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v72 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string slideIn = Strings.GetDefault("CONNECTION_TEST_FAILED_ERROR_MESSAGE");
							((UIScreenController)flag).QueueSlideIn((SlideIn)(object)slideIn);
							googleSheetsProcessor._connectionSuccessful = false;
							return null;
						}
						UnityWebRequest unityWebRequest = _003Crequest_003E5__2;
						byte[] data = unityWebRequest.m_DownloadHandler.GetData();
						if (string.Equals((string)(object)data, "Connection Established"))
						{
							googleSheetsProcessor._connectionSuccessful = true;
							return null;
						}
						UnityWebRequest unityWebRequest2 = _003Crequest_003E5__2;
						byte[] data2 = unityWebRequest2.m_DownloadHandler.GetData();
						string msg = string.ConcatArray((string[])(object)"Error connecting to Google Sheets: ", (int)data2);
						SDebug.LogFormat(msg, null);
						nint num5 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v74 (Il2CppClass<UIScreenController>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num6 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v82 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag2 = UIScreenController.ShouldShowOnlineScreen();
						nint num7 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v49 (Il2CppClass<Strings>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v57 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string slideIn2 = Strings.GetDefault("CONNECTION_TEST_FAILED_ERROR_MESSAGE");
						((UIScreenController)flag2).QueueSlideIn((SlideIn)(object)slideIn2);
						googleSheetsProcessor._connectionSuccessful = false;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<ParameterContainer> list = default;
				list._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ParameterContainer parameterContainer = default;
				object obj5 = parameterContainer + 8;
				obj5 = "ssid";
				object obj6 = parameterContainer + 12;
				obj6 = googleSheetsProcessor._spreadsheetId;
				list.Add(parameterContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ParameterContainer parameterContainer2 = default;
				object obj7 = parameterContainer2 + 8;
				obj7 = "sheet";
				object obj8 = parameterContainer2 + 12;
				obj8 = googleSheetsProcessor._worksheetName;
				list.Add(parameterContainer2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ParameterContainer parameterContainer3 = default;
				object obj9 = parameterContainer3 + 8;
				obj9 = "template";
				object obj10 = parameterContainer3 + 12;
				obj10 = googleSheetsProcessor._template;
				list.Add(parameterContainer3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ParameterContainer parameterContainer4 = default;
				object obj11 = parameterContainer4 + 8;
				obj11 = "action";
				object obj12 = parameterContainer4 + 12;
				obj12 = "ConnectionTest";
				list.Add(parameterContainer4);
				object obj13 = this + 20;
				BackgroundObject backgroundObject = ((EnvironmentBackground)null).InitializeBackgroundObject((BackgroundObject)(object)googleSheetsProcessor._googleScriptUrl, (BackgroundLayer)(object)list);
				Dictionary<string, string> headers = ((WWWForm)(object)backgroundObject).headers;
				obj13 = headers;
				object obj14 = this + 12;
				UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = _003Crequest_003E5__2.SendWebRequest();
				obj14 = unityWebRequestAsyncOperation;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
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

	public char SeparatorCharacter
	{
		get
		{
			//IL_0065: Expected I, but got Obj
			//IL_007b: Expected Obj, but got I
			//IL_00e6: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v22 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.Processors.GoogleSheetsProcessor)+28]");
			float width = 0f / 60f;
			GUILayoutOption gUILayoutOption = GUILayout.Width(width);
			object obj2 = gUILayoutOption;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			return (char)(int)("This benchmark will run for " + text + " minutes. Please ensure that the device is connected to a charger during this test.");
		}
	}

	public GoogleSheetsProcessor(string worksheetNamePostfix = "", string overrideSheetId = "1HIlWcwxXV0dVjsf0gLpgFE0B0bei1vdn2xJNTAIxFv4", string overrideScriptUrl = "https://script.google.com/macros/s/AKfycbzysbyZuNXvOTJh5llqjN4N2dP4PAXusuwfaHjvTD3ESkx5Sas/exec")
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = worksheetNamePostfix;
		object obj2 = this + 24;
		obj2 = overrideSheetId;
		object obj3 = this + 28;
		obj3 = overrideScriptUrl;
	}

	public void Process(IBenchmark benchmark)
	{
		//IL_000a: Expected I4, but got Obj
		((FramerateTracker)this).FirstMonobehaviour_OnOnApplicationPause((byte)(int)benchmark != 0);
	}

	private IEnumerator UploadReportToGoogleSheets(IBenchmark benchmark)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_0043: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		MovingTrain.ActivateAutoPilot();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = benchmark + 1;
		IEnumerable<_00210> collection = (IEnumerable<_00210>)((object)this * obj);
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)collection);
		object obj2 = default;
		IAutomationStep item = default;
		object obj3 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<GoogleSheetsProcessor, UIntPtr>(ref this))
		{
			bool requiresConfirmation = ((SubwayRunningBenchmark)benchmark).RequiresConfirmation;
			((List<IAutomationStep>)(object)list).Add((IAutomationStep)requiresConfirmation);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 180f;
			((List<IAutomationStep>)(object)list).Add(item);
			obj2 = obj3 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
		IEnumerator result = default;
		return result;
	}

	private List<string> Serialize(IBenchmarkMetric[] metrics)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._items = null;
		object obj = list + 16;
		obj = this;
		object obj2 = list + 20;
		obj2 = metrics;
		return list;
	}

	private List<string> SerializeMetric(IBenchmarkMetric metric)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj = metric + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = metric + 16;
			object obj4 = obj2 << 2;
			object parameters = obj3 + obj4;
			WWWForm wWWForm = ((GoogleSheetsProcessor)null).ConstructPostParametersForm((List<ParameterContainer>)parameters);
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S3_v4 (Il2CppMethodInfo)+C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S3_v5+60]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S3_v6+38]");
			object obj7 = 0;
			object obj8 = obj7 & 0x1FFF;
			object obj9 = obj8 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S4_v5 (should have been resolved before IL gen)");
			object obj10 = obj2 + 1;
			obj2 = obj10;
		}
		return list;
	}

	private IEnumerator TestGoogleConnection()
	{
		//IL_0006: Expected Obj, but got I4
		return (IEnumerator)59;
	}

	private string ConstructGetUriWithParameters(string url, List<ParameterContainer> parameters)
	{
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I
		//IL_00fa: Expected I4, but got Obj
		//IL_00fa: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj = url + 12;
		bool flag = parameters == null;
		object obj2 = default;
		object obj7 = default;
		for (; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj); obj2 = obj7 + 1)
		{
			object obj3 = url + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			if (!flag)
			{
				UnityEngine.Object value = UnityEngine.Object.Instantiate((UnityEngine.Object)obj5);
				if (Enumerable.Contains((IEnumerable<string>)parameters, (string)(object)value))
				{
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.Processors.GoogleSheetsProcessor)+90]");
			if (!((List<AnimationClip>)0).Contains((AnimationClip)obj5))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.Processors.GoogleSheetsProcessor)+90]");
				((List<AnimationClip>)0).Add((AnimationClip)obj5);
				UnityEngine.Object obj6 = UnityEngine.Object.Instantiate((UnityEngine.Object)obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Benchmarking.Processors.GoogleSheetsProcessor)+5C]");
				((SafeAnimation)0).SetEnabled((string)obj5, (byte)(int)obj6 != 0);
			}
			UnityEngine.Object item = UnityEngine.Object.Instantiate((UnityEngine.Object)obj5);
			list.Add((string)(object)item);
		}
		return (string)(object)list;
	}

	private WWWForm ConstructPostParametersForm(List<ParameterContainer> parameters)
	{
		//IL_027b: Expected Obj, but got I4
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj2 = default;
		List<string> list2 = default;
		if (obj2 != null)
		{
			string type = list2.get_Item(0);
			object item = ((IConvertible)"=COUNTIF(SPLIT(\"").ToType((Type)(object)type, (IFormatProvider)(object)"\", \";\"), \"> 0\")");
			list2.Add((string)item);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj3 = default;
		if (obj3 != null)
		{
			bool flag = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj4 = default;
			bool flag = obj4 == null;
		}
		int num = 0;
		while (num < list2._size)
		{
			string item2 = list2.get_Item(num);
			list.Add(item2);
			int num2 = num + 1;
			num = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
