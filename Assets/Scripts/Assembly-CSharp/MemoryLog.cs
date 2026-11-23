using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Subway;
using UnityEngine;

public class MemoryLog
{
	private sealed class _003CUploadToGoogleSheets_003Ed__45(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MemoryLog _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected VT, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected VT, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected VT, but got Unknown
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected VT, but got Unknown
			//IL_014c: Expected Ref, but got VT
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected VT, but got Unknown
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected VT, but got Unknown
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected VT, but got Unknown
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Expected VT, but got Unknown
			//IL_02d8: Expected Obj, but got I
			//IL_02d3: Expected native int or pointer, but got VT
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Expected VT, but got Unknown
			//IL_0345: Expected VT, but got I
			//IL_03ba: Expected Obj, but got VT
			//IL_03fe: Expected Obj, but got I
			object obj = default;
			KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)(obj - 224);
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				goto IL_0446;
			}
			_003C_003E1__state = -1;
			MemoryLog memoryLog = _003C_003E4__this;
			List<KeyValuePair<string, string>> list = default;
			list._002Ector();
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+C8]");
			_ = 0;
			KeyValuePair<string, string> item = (KeyValuePair<string, string>)(keyValuePair - -64);
			list.Add(item);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+B8]");
			_ = 0;
			KeyValuePair<string, string> item2 = (KeyValuePair<string, string>)(keyValuePair + 56);
			list.Add(item2);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+A8]");
			_ = 0;
			KeyValuePair<string, string> item3 = (KeyValuePair<string, string>)(keyValuePair + 48);
			list.Add(item3);
			DateTime now = DateTime.Now;
			DateTime dateTime = (DateTime)(keyValuePair + 208);
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = ((DateTime*)dateTime)->ToString(invariantCulture);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+98]");
			_ = 0;
			KeyValuePair<string, string> item4 = (KeyValuePair<string, string>)(keyValuePair + 40);
			list.Add(item4);
			string deviceModel = SystemInfo.GetDeviceModel();
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+88]");
			_ = 0;
			KeyValuePair<string, string> item5 = (KeyValuePair<string, string>)(keyValuePair + 32);
			list.Add(item5);
			string deviceName = SystemInfo.GetDeviceName();
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+78]");
			_ = 0;
			KeyValuePair<string, string> item6 = (KeyValuePair<string, string>)(keyValuePair + 24);
			list.Add(item6);
			string operatingSystem = SystemInfo.GetOperatingSystem();
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+68]");
			_ = 0;
			KeyValuePair<string, string> item7 = (KeyValuePair<string, string>)(keyValuePair + 16);
			list.Add(item7);
			string bundleVersion = DeviceUtility.GetBundleVersion();
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+58]");
			_ = 0;
			KeyValuePair<string, string> keyValuePair2 = keyValuePair;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+58]");
			System.Runtime.CompilerServices.Unsafe.Write(&((KeyValuePair<string, string>*)(nint)keyValuePair2)->key, (string)0);
			KeyValuePair<string, string> item8 = (KeyValuePair<string, string>)(keyValuePair + 8);
			list.Add(item8);
			int num = 0;
			while (true)
			{
				List<string> rawDataLogs = memoryLog._rawDataLogs;
				if (num >= rawDataLogs._size)
				{
					break;
				}
				string text2 = memoryLog._rawDataLogs.get_Item(num);
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+C8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+C8]");
				keyValuePair = (KeyValuePair<string, string>)0;
				list.Add(keyValuePair);
				int num2 = num + 1;
				num = num2;
			}
			Uri uri = default;
			uri._002Ector("https://script.google.com/macros/s/AKfycbz2lBaGXHu05CgN1mXAr217sresz20BwK_3YwuHO2sHx_eJu5g/exec");
			Uri uri2 = WebClient.AddQueryParametersToUri(uri, list);
			string absoluteUri = uri2.AbsoluteUri;
			KeyValuePair<bool, string> keyValuePair3 = ((MemoryLog)keyValuePair).SendRequest(absoluteUri, 5f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+D8]");
			StringID key;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+DC]");
				bool flag = (string)0 != "Upload Successful";
				key = StringID.UPLOAD_SUCCESS_MESSAGE;
				if (!flag)
				{
					goto IL_04bb;
				}
			}
			key = StringID.UPLOAD_FAILED_MESSAGE;
			goto IL_04bb;
			IL_04bb:
			UIScreenController instance = UIScreenController.Instance;
			string message = Strings.Get(key);
			instance.QueueErrorMessageSlidein(message);
			goto IL_0446;
			IL_0446:
			return false;
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

	private sealed class _003CRunMemoryBenchmark_003Ed__51(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MemoryLog _003C_003E4__this;

		private int _003CoriginalScreenTimeout_003E5__2;

		private int _003Cj_003E5__3;

		private int _003Ci_003E5__4;

		private int _003CstartLogIndex2_003E5__5;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_03db: Expected Obj, but got I4
			//IL_0387: Expected Obj, but got I4
			//IL_03b4: Expected Obj, but got I4
			//IL_07d1: Expected Obj, but got I4
			//IL_09a8: Expected Obj, but got I4
			//IL_054d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Expected Obj, but got Unknown
			//IL_0597: Unknown result type (might be due to invalid IL or missing references)
			//IL_059c: Expected Obj, but got Unknown
			//IL_07c3: Expected Obj, but got I4
			//IL_05ea: Expected Obj, but got I4
			//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09dd: Expected Obj, but got Unknown
			//IL_062d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0632: Expected Obj, but got Unknown
			//IL_0677: Unknown result type (might be due to invalid IL or missing references)
			//IL_067c: Expected Obj, but got Unknown
			//IL_06a9: Expected I, but got Obj
			//IL_06d8: Expected Obj, but got I4
			//IL_0701: Expected Obj, but got I4
			//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06eb: Expected Obj, but got Unknown
			//IL_0729: Expected I, but got Obj
			//IL_070f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0714: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			MemoryLog memoryLog = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						object obj3;
						bool flag = default;
						if (_003C_003E1__state != 3)
						{
							if (_003C_003E1__state != 4)
							{
								if (_003C_003E1__state != 5)
								{
									if (_003C_003E1__state != 6)
									{
										goto IL_08b7;
									}
									_003C_003E1__state = -1;
									goto IL_0953;
								}
								_003C_003E1__state = -1;
								string formattedTime = _003C_003E4__this.GetFormattedTime(180);
								obj3 = 1;
							}
							else
							{
								_003C_003E1__state = -1;
								if (++_003Ci_003E5__4 < 10)
								{
									goto IL_081c;
								}
								obj3 = 0;
							}
						}
						else
						{
							_003Cj_003E5__3 = 0;
							_003C_003E1__state = -1;
							flag = true;
							obj3 = 2;
						}
						object obj4 = obj3;
						while (true)
						{
							if (obj4 != null)
							{
								if ((nint)obj4 == 1)
								{
									if (_003Cj_003E5__3 == 2)
									{
										int endMemory = _003C_003E4__this.LogCurrentMemoryUsage();
										memoryLog._endMemory = endMemory;
									}
									_003C_003E4__this.DumpRawData();
									bool flag2 = ++_003Cj_003E5__3 < 3;
									flag = flag2;
									obj4 = 2;
									continue;
								}
								if (!flag)
								{
									break;
								}
								if (~(memoryLog.RUN_UI_BENCHMARK ? 1u : 0u) == 0)
								{
									goto IL_051c;
								}
								obj4 = 0;
								continue;
							}
							_003C_003E4__this.DumpRawData();
							if (~(memoryLog.RUN_GAME_BENCHMARK ? 1u : 0u) == 0)
							{
								StringBuilder logMemory = memoryLog._logMemory;
								int num = logMemory.m_ChunkOffset + logMemory.m_ChunkLength;
								_003Ci_003E5__4 = num;
								IEnumerator coroutine = _003C_003E4__this.GameBenchmark();
								Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
								_003C_003E2__current = coroutine2;
								_003C_003E1__state = 5;
								return true;
							}
							obj4 = 1;
						}
						StringBuilder stringBuilder = default;
						stringBuilder._002Ector();
						_ = memoryLog._startMemory;
						object obj5 = obj + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object arg = default;
						StringBuilder stringBuilder2 = stringBuilder.AppendFormat("Start: {0} MB", arg);
						StringBuilder stringBuilder3 = stringBuilder.AppendLine();
						_ = memoryLog._endMemory;
						object obj6 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object arg2 = default;
						StringBuilder stringBuilder4 = stringBuilder.AppendFormat("End: {0}", arg2);
						StringBuilder stringBuilder5 = stringBuilder.AppendLine();
						object obj7 = memoryLog._maxMemory - memoryLog._minMemory;
						if ((nint)obj7 <= 0)
						{
						}
						object obj8 = obj + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object arg3 = default;
						StringBuilder stringBuilder6 = stringBuilder.AppendFormat("Change: {0}{1}", string.Empty, arg3);
						StringBuilder stringBuilder7 = stringBuilder.AppendLine();
						_ = memoryLog._minMemory;
						object obj9 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object arg4 = default;
						StringBuilder stringBuilder8 = stringBuilder.AppendFormat("Min: {0}", arg4);
						StringBuilder stringBuilder9 = stringBuilder.AppendLine();
						_ = memoryLog._maxMemory;
						object obj10 = obj + 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						object arg5 = default;
						StringBuilder stringBuilder10 = stringBuilder.AppendFormat("Max: {0}", arg5);
						nint num2 = (nint)stringBuilder;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v572 @ S1_v120 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
						string text = default;
						string[] array = text.Split('\n');
						object obj11 = 0;
						while (array.Length > (nint)obj11)
						{
							object obj12 = obj11 + 1;
							obj11 = obj12;
						}
						object obj13 = 0;
						while (true)
						{
							List<string> rawDataLogs = memoryLog._rawDataLogs;
							if ((nint)obj13 >= rawDataLogs._size)
							{
								break;
							}
							object obj14 = obj13 + 1;
							obj13 = obj14;
						}
						nint num3 = (nint)stringBuilder;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v614 @ S1_v130 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
						string message = default;
						DeviceUtility.ShowNativePopup("Benchmark results", message, "OK");
						if (~(memoryLog.UPLOAD_TO_GOOGLE ? 1u : 0u) == 0 && !memoryLog.INCLUDE_LOG_DETAILS)
						{
							IEnumerator coroutine3 = _003C_003E4__this.UploadToGoogleSheets();
							Coroutine coroutine4 = CoroutineUtil.StartCoroutine(coroutine3);
							_003C_003E2__current = coroutine4;
							_003C_003E1__state = 6;
							return true;
						}
						goto IL_0953;
					}
					_003C_003E1__state = -1;
					UIScreenController instance = UIScreenController.Instance;
					instance.ClosePopup();
					UIScreenController instance2 = UIScreenController.Instance;
					instance2.ClosePopup();
					UIScreenController instance3 = UIScreenController.Instance;
					instance3.ClosePopup();
					Coroutine coroutine5 = _003C_003E4__this.StartWaitForRealSeconds(1f);
					_003C_003E2__current = coroutine5;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E1__state = -1;
				if (~(memoryLog.UPLOAD_TO_GOOGLE ? 1u : 0u) != 0 || memoryLog.INCLUDE_LOG_DETAILS || _003C_003E4__this.TestGoogleConnection())
				{
					int sleepTimeout = Screen.sleepTimeout;
					_003CoriginalScreenTimeout_003E5__2 = sleepTimeout;
					Screen.sleepTimeout = -1;
					((List<T>)(object)memoryLog._rawDataLogs).Clear();
					StringBuilder stringBuilder11 = default;
					stringBuilder11._002Ector();
					memoryLog._logMemory = stringBuilder11;
					int num4 = _003C_003E4__this.LogCurrentMemoryUsage();
					memoryLog._maxMemory = 0;
					memoryLog._minMemory = num4;
					memoryLog._startMemory = num4;
					memoryLog._endMemory = 0;
					float num5 = 0.25f;
					if (!memoryLog.RUN_GAME_BENCHMARK)
					{
						num5 = 1f;
					}
					float progressIncreaseUI = num5 * (1f / 30f);
					memoryLog._progressIncreaseUI = progressIncreaseUI;
					float num6 = 0.75f;
					if (!memoryLog.RUN_UI_BENCHMARK)
					{
						num6 = 1f;
					}
					float progressIncreaseGame = num6 * (1f / 90f);
					memoryLog._currentProgress = 0f;
					memoryLog._progressIncreaseGame = progressIncreaseGame;
					Coroutine coroutine6 = _003C_003E4__this.StartPushScreen("FrontUI", 0f, closeAfterwards: false, logMemory: false);
					_003C_003E2__current = coroutine6;
					_003C_003E1__state = 2;
					return true;
				}
				UIScreenController instance4 = UIScreenController.Instance;
				string message2 = Strings.Get(StringID.CONNECTION_TEST_FAILED_ERROR_MESSAGE);
				instance4.QueueErrorMessageSlidein(message2);
				benchmarkInProgress__BackingField = false;
				UIScreenController instance5 = UIScreenController.Instance;
				instance5.HideMemoryBenchmarkOverlay();
			}
			else
			{
				_003C_003E1__state = -1;
				if (!benchmarkInProgress__BackingField)
				{
					benchmarkInProgress__BackingField = true;
					UIScreenController instance6 = UIScreenController.Instance;
					instance6.ShowMemoryBenchmarkOverlay();
					UIScreenController instance7 = UIScreenController.Instance;
					instance7.UpdateMemoryBenchmarkPercent(0f);
					Coroutine coroutine7 = _003C_003E4__this.StartWaitForRealSeconds(0.2f);
					_003C_003E2__current = coroutine7;
					_003C_003E1__state = 1;
					return true;
				}
			}
			goto IL_08b7;
			IL_081c:
			StringBuilder logMemory2 = memoryLog._logMemory;
			int num7 = logMemory2.m_ChunkOffset + logMemory2.m_ChunkLength;
			_003CstartLogIndex2_003E5__5 = num7;
			IEnumerator coroutine8 = _003C_003E4__this.UIBenchmark();
			Coroutine coroutine9 = CoroutineUtil.StartCoroutine(coroutine8);
			_003C_003E2__current = coroutine9;
			_003C_003E1__state = 4;
			return true;
			IL_051c:
			_003Ci_003E5__4 = 0;
			goto IL_081c;
			IL_0953:
			Screen.sleepTimeout = _003CoriginalScreenTimeout_003E5__2;
			benchmarkInProgress__BackingField = false;
			UIScreenController instance8 = UIScreenController.Instance;
			instance8.HideMemoryBenchmarkOverlay();
			UIScreenController instance9 = UIScreenController.Instance;
			instance9.PushPopup("SettingsPopup");
			UIScreenController instance10 = UIScreenController.Instance;
			instance10.PushPopup("DebugSettingsPopup");
			return false;
			IL_08b7:
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CPushPopup_003Ed__52(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string popup;

		public MemoryLog _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num;
			bool result;
			int num3;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 2;
					num = -1;
					result = false;
					if (flag)
					{
						goto IL_0177;
					}
					result = false;
					goto IL_0186;
				}
				_003C_003E1__state = -1;
				if (!_003C_003E4__this.ShouldSkipLog())
				{
					int num2 = _003C_003E4__this.LogCurrentMemoryUsage(popup);
				}
				UIScreenController instance = UIScreenController.Instance;
				instance.CloseActivePopups(popup);
				Coroutine coroutine = StartWaitForRealSeconds(0.2f);
				_003C_003E2__current = coroutine;
				num3 = 2;
			}
			else
			{
				_003C_003E1__state = -1;
				UIScreenController instance2 = UIScreenController.Instance;
				instance2.PushPopup(popup);
				Coroutine coroutine2 = StartWaitForRealSeconds(0.2f);
				_003C_003E2__current = coroutine2;
				num3 = 1;
			}
			num = num3;
			result = true;
			goto IL_0177;
			IL_0177:
			_003C_003E1__state = num;
			goto IL_0186;
			IL_0186:
			return result;
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

	private sealed class _003CPushScreen_003Ed__53(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string screen;

		public MemoryLog _003C_003E4__this;

		public float extraDelay;

		public bool logMemory;

		public bool closeAfterwards;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						goto IL_017a;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					if (~(logMemory ? 1u : 0u) == 0 && !_003C_003E4__this.ShouldSkipLog())
					{
						int num = _003C_003E4__this.LogCurrentMemoryUsage(screen);
					}
					if (~(closeAfterwards ? 1u : 0u) == 0)
					{
						UIScreenController instance = UIScreenController.Instance;
						instance.BackToPrevious();
						Coroutine coroutine = StartWaitForRealSeconds(0.2f);
						_003C_003E2__current = coroutine;
						_003C_003E1__state = 2;
						return true;
					}
				}
				UIScreenController instance2 = UIScreenController.Instance;
				instance2.ClosePopup();
				goto IL_017a;
			}
			_003C_003E1__state = -1;
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.PushScreen(screen);
			float delay = extraDelay + 0.2f;
			Coroutine coroutine2 = StartWaitForRealSeconds(delay);
			_003C_003E2__current = coroutine2;
			_003C_003E1__state = 1;
			return true;
			IL_017a:
			return false;
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

	private sealed class _003CUIBenchmark_003Ed__54(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MemoryLog _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0322: Expected I4, but got I8
			MemoryLog memoryLog = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							if (_003C_003E1__state != 4)
							{
								if (_003C_003E1__state != 5)
								{
									if (_003C_003E1__state != 6)
									{
										if (_003C_003E1__state != 7)
										{
											if (_003C_003E1__state != 8)
											{
												if (_003C_003E1__state != 9)
												{
													if (_003C_003E1__state != 10)
													{
														if (_003C_003E1__state != 11)
														{
															if (_003C_003E1__state != 12)
															{
																if (_003C_003E1__state != 13)
																{
																	if (_003C_003E1__state != 14)
																	{
																		if (_003C_003E1__state != 15)
																		{
																			if (_003C_003E1__state != 16)
																			{
																				if (_003C_003E1__state != 17)
																				{
																					if (_003C_003E1__state != 18)
																					{
																						if (_003C_003E1__state != 19)
																						{
																							if (_003C_003E1__state != 20)
																							{
																								if (_003C_003E1__state != 21)
																								{
																									if (_003C_003E1__state == 22)
																									{
																										_003C_003E1__state = -1;
																										_003C_003E4__this.IncreaseAndUpdateProgress(memoryLog._progressIncreaseUI);
																									}
																									return false;
																								}
																								_003C_003E1__state = -1;
																								Coroutine coroutine = _003C_003E4__this.StartPushScreen("UpgradesUI_shop");
																								_003C_003E2__current = coroutine;
																								_003C_003E1__state = 22;
																							}
																							else
																							{
																								_003C_003E1__state = -1;
																								Coroutine coroutine2 = _003C_003E4__this.StartPushScreen("TopRunUI", 0.2f);
																								_003C_003E2__current = coroutine2;
																								_003C_003E1__state = 21;
																							}
																						}
																						else
																						{
																							_003C_003E1__state = -1;
																							Coroutine coroutine3 = _003C_003E4__this.StartPushScreen("LeaderboardUI", 0.2f);
																							_003C_003E2__current = coroutine3;
																							_003C_003E1__state = 20;
																						}
																					}
																					else
																					{
																						_003C_003E1__state = -1;
																						Coroutine coroutine4 = _003C_003E4__this.StartPushScreen("GameoverUI");
																						_003C_003E2__current = coroutine4;
																						_003C_003E1__state = 19;
																					}
																				}
																				else
																				{
																					_003C_003E1__state = -1;
																					Coroutine coroutine5 = _003C_003E4__this.StartPushScreen("FriendsUI", 0.2f);
																					_003C_003E2__current = coroutine5;
																					_003C_003E1__state = 18;
																				}
																			}
																			else
																			{
																				_003C_003E1__state = -1;
																				Coroutine coroutine6 = _003C_003E4__this.StartPushScreen("EarnCoinsScreen");
																				_003C_003E2__current = coroutine6;
																				_003C_003E1__state = 17;
																			}
																		}
																		else
																		{
																			_003C_003E1__state = -1;
																			Coroutine coroutine7 = _003C_003E4__this.StartPushScreen("CoinsUI_shop");
																			_003C_003E2__current = coroutine7;
																			_003C_003E1__state = 16;
																		}
																	}
																	else
																	{
																		_003C_003E1__state = -1;
																		Coroutine coroutine8 = _003C_003E4__this.StartPushScreen("BoardScreen");
																		_003C_003E2__current = coroutine8;
																		_003C_003E1__state = 15;
																	}
																}
																else
																{
																	_003C_003E1__state = -1;
																	Coroutine coroutine9 = _003C_003E4__this.StartPushScreen("AwardsScreen");
																	_003C_003E2__current = coroutine9;
																	_003C_003E1__state = 14;
																}
															}
															else
															{
																_003C_003E1__state = -1;
																Coroutine coroutine10 = _003C_003E4__this.StartPushScreen("CharacterScreen");
																_003C_003E2__current = coroutine10;
																_003C_003E1__state = 13;
															}
														}
														else
														{
															_003C_003E1__state = -1;
															Coroutine coroutine11 = _003C_003E4__this.StartPushPopup("UpdateAppPopup");
															_003C_003E2__current = coroutine11;
															_003C_003E1__state = 12;
														}
													}
													else
													{
														_003C_003E1__state = -1;
														Coroutine coroutine12 = _003C_003E4__this.StartPushPopup("FacebookRewardsPopup");
														_003C_003E2__current = coroutine12;
														_003C_003E1__state = 11;
													}
												}
												else
												{
													_003C_003E1__state = -1;
													Coroutine coroutine13 = _003C_003E4__this.StartPushPopup("CountryPopup");
													_003C_003E2__current = coroutine13;
													_003C_003E1__state = 10;
												}
											}
											else
											{
												_003C_003E1__state = -1;
												Coroutine coroutine14 = _003C_003E4__this.StartPushPopup("CoinsUI_quick");
												_003C_003E2__current = coroutine14;
												_003C_003E1__state = 9;
											}
										}
										else
										{
											_003C_003E1__state = -1;
											Coroutine coroutine15 = _003C_003E4__this.StartPushPopup("CelebrationPopup");
											_003C_003E2__current = coroutine15;
											_003C_003E1__state = 8;
										}
									}
									else
									{
										_003C_003E1__state = -1;
										Coroutine coroutine16 = _003C_003E4__this.StartPushPopup("TopRunPopup");
										_003C_003E2__current = coroutine16;
										_003C_003E1__state = 7;
									}
								}
								else
								{
									_003C_003E1__state = -1;
									Coroutine coroutine17 = _003C_003E4__this.StartPushPopup("EventsPopup");
									_003C_003E2__current = coroutine17;
									_003C_003E1__state = 6;
								}
							}
							else
							{
								_003C_003E1__state = -1;
								Coroutine coroutine18 = _003C_003E4__this.StartPushPopup("SettingsPopup");
								_003C_003E2__current = coroutine18;
								_003C_003E1__state = 5;
							}
						}
						else
						{
							_003C_003E1__state = -1;
							Coroutine coroutine19 = _003C_003E4__this.StartPushPopup("HoverboardPopup");
							_003C_003E2__current = coroutine19;
							_003C_003E1__state = 4;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						Coroutine coroutine20 = _003C_003E4__this.StartPushPopup("ItemHuntPopup");
						_003C_003E2__current = coroutine20;
						_003C_003E1__state = 3;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Coroutine coroutine21 = _003C_003E4__this.StartPushPopup("DailyChallengePopup");
					_003C_003E2__current = coroutine21;
					_003C_003E1__state = 2;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if (!Globals.DEBUG_USE_CELEBRATION_TESTER)
				{
					int rewardsToUnlockCount = RewardManager.rewardsToUnlockCount;
					if (rewardsToUnlockCount <= 0)
					{
						CelebrationReward celebrationReward = default;
						celebrationReward._002Ector();
						celebrationReward.amount = 1;
						celebrationReward.CelebrationRewardOrigin = CelebrationRewardOrigin.MysteryBox;
						RewardManager.AddRewardToUnlock(celebrationReward, shouldSaveToDisk: false);
					}
				}
				Coroutine coroutine22 = _003C_003E4__this.StartPushPopup("Mission_popup");
				_003C_003E2__current = coroutine22;
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

	private sealed class _003CGameBenchmark_003Ed__55(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MemoryLog _003C_003E4__this;

		private bool _003CcolliderState_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0182: Expected Obj, but got I4
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected I4, but got Unknown
			MemoryLog memoryLog = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						goto IL_03af;
					}
					if (_003C_003E1__state != 3)
					{
						if (_003C_003E1__state != 4)
						{
							if (_003C_003E1__state == 5)
							{
								_003C_003E1__state = -1;
								Layers instance = Layers.Instance;
								Layers instance2 = Layers.Instance;
								Physics.IgnoreLayerCollision(instance.Character, instance2.Hit, _003CcolliderState_003E5__2);
							}
							return false;
						}
						_003C_003E1__state = -1;
						Coroutine coroutine = _003C_003E4__this.StartPushScreen("FrontUI", 0f, closeAfterwards: false);
						_003C_003E2__current = coroutine;
						_003C_003E1__state = 5;
						return true;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj = _003Ci_003E5__3 + 1;
					int time = obj * 6;
					string formattedTime = GetFormattedTime(time);
					int num = _003C_003E4__this.LogCurrentMemoryUsage(formattedTime);
					_003C_003E4__this.IncreaseAndUpdateProgress(memoryLog._progressIncreaseGame);
					if (++_003Ci_003E5__3 < 30)
					{
						goto IL_035c;
					}
					Game instance3 = Game.Instance;
					if (instance3.IsInJetpackMode)
					{
						goto IL_03af;
					}
				}
				Game instance4 = Game.Instance;
				instance4.ChangeState(null, Game.GameStateCoroutineType.DieSequence);
				Coroutine coroutine2 = StartWaitForRealSeconds(10f);
				_003C_003E2__current = coroutine2;
				_003C_003E1__state = 4;
				return true;
			}
			_003C_003E1__state = -1;
			_003CcolliderState_003E5__2 = Globals.DEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS;
			Layers instance5 = Layers.Instance;
			Layers instance6 = Layers.Instance;
			Physics.IgnoreLayerCollision(instance5.Character, instance6.Hit, ignore: true);
			Game instance7 = Game.Instance;
			instance7.StartNewGame(duel: false);
			UIScreenController instance8 = UIScreenController.Instance;
			instance8.PushScreen("IngameUI");
			string formattedTime2 = GetFormattedTime(0);
			int num2 = _003C_003E4__this.LogCurrentMemoryUsage(formattedTime2);
			_003Ci_003E5__3 = 0;
			goto IL_035c;
			IL_035c:
			Coroutine coroutine3 = StartWaitForRealSeconds(6f);
			_003C_003E2__current = coroutine3;
			_003C_003E1__state = 1;
			return true;
			IL_03af:
			Game instance9 = Game.Instance;
			if (!instance9.IsInJetpackMode)
			{
				Coroutine coroutine4 = StartWaitForRealSeconds(2f);
				_003C_003E2__current = coroutine4;
				_003C_003E1__state = 3;
				return true;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 2;
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

	private const float POPUP_DELAY = 0.2f;

	private const float POPUP_DELAY_CLOSE = 0.2f;

	private const float SCREEN_DELAY = 0.2f;

	private const float SCREEN_DELAY_CLOSE = 0.2f;

	private const int TOTAL_REPEAT_COUNT = 3;

	private const int UI_REPEAT_COUNT = 10;

	private const int UI_LOG_SKIP = 4;

	private const int GAME_LOG_INTERVAL = 6;

	private const int GAME_LOG_COUNT = 30;

	private readonly bool RUN_UI_BENCHMARK = true;

	private readonly bool RUN_GAME_BENCHMARK;

	private readonly bool UPLOAD_TO_GOOGLE = true;

	private readonly bool VERBOSE_LOG;

	private readonly bool INCLUDE_LOG_DETAILS;

	private const char LOG_SPLITTER = ';';

	private StringBuilder _logMemory;

	private List<string> _rawDataLogs;

	private int _uiCurrentLogSkipCount;

	private int _startMemory;

	private int _endMemory;

	private int _minMemory;

	private int _maxMemory;

	private float _progressIncreaseGame;

	private float _progressIncreaseUI;

	private float _currentProgress;

	private static MemoryLog _instance;

	private const string GOOGLE_SCRIPT_URL = "https://script.google.com/macros/s/AKfycbz2lBaGXHu05CgN1mXAr217sresz20BwK_3YwuHO2sHx_eJu5g/exec";

	private const string GOOGLE_SHEET_ID = "1d4AZJWVKm1c438UX21RZIMHGpzjRd013Bmk10_n5tmU";

	private const string WORKSHEET_NAME = "Memory_Data";

	private const string UPLOAD_SUCCESS_RESPONSE = "Upload Successful";

	private const string CONNECTION_TEST_SUCCESS_RESPONSE = "Connection Established";

	private const string GOOGLE_PARAMETER_KEY = "val";

	private const string SPREADSHEET_ID_PARAMETER_KEY = "ssid";

	private const string WORKSHEET_NAME_PARAMETER_KEY = "sheet";

	private const string ACTION_PARAMETER_KEY = "action";

	private const string ACTION_CONNECT_TEST_PARAMETER_VALUE = "ConnectionTest";

	private const string ACTION_UPLOAD_PARAMETER_VALUE = "POST";

	private static bool benchmarkInProgress__BackingField;

	public static bool benchmarkInProgress
	{
		get
		{
			return benchmarkInProgress__BackingField;
		}
		private set
		{
			benchmarkInProgress__BackingField = value;
		}
	}

	public static MemoryLog Instance
	{
		get
		{
			if (_instance == null)
			{
				MemoryLog memoryLog = default;
				memoryLog._002Ector();
				_instance = memoryLog;
			}
			return _instance;
		}
	}

	private unsafe bool TestGoogleConnection()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected VT, but got Unknown
		//IL_00ad: Expected Obj, but got I
		//IL_00a8: Expected native int or pointer, but got VT
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected VT, but got Unknown
		//IL_00f7: Expected VT, but got I
		//IL_013e: Expected Obj, but got VT
		//IL_0182: Expected Obj, but got I
		object obj = default;
		KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)(obj - 80);
		_ = 0;
		Uri uri = default;
		uri._002Ector("https://script.google.com/macros/s/AKfycbz2lBaGXHu05CgN1mXAr217sresz20BwK_3YwuHO2sHx_eJu5g/exec");
		List<KeyValuePair<string, string>> list = default;
		list._002Ector();
		_ = 0;
		object obj2 = keyValuePair - -64;
		obj2 = "ssid";
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+40]");
		_ = 0;
		KeyValuePair<string, string> item = (KeyValuePair<string, string>)(keyValuePair + 16);
		list.Add(item);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+30]");
		_ = 0;
		KeyValuePair<string, string> keyValuePair2 = keyValuePair;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+30]");
		System.Runtime.CompilerServices.Unsafe.Write(&((KeyValuePair<string, string>*)(nint)keyValuePair2)->key, (string)0);
		KeyValuePair<string, string> item2 = (KeyValuePair<string, string>)(keyValuePair + 8);
		list.Add(item2);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+20]");
		keyValuePair = (KeyValuePair<string, string>)0;
		list.Add(keyValuePair);
		Uri uri2 = WebClient.AddQueryParametersToUri(uri, list);
		string absoluteUri = uri2.AbsoluteUri;
		KeyValuePair<bool, string> keyValuePair3 = ((MemoryLog)keyValuePair).SendRequest(absoluteUri, 5f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+48]");
		bool result;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Collections.Generic.KeyValuePair`2<System.String, System.String>)+4C]");
			bool flag = (string)0 != "Connection Established";
			result = true;
			if (!flag)
			{
				goto IL_01c4;
			}
		}
		result = false;
		goto IL_01c4;
		IL_01c4:
		return result;
	}

	public KeyValuePair<bool, string> SendRequest(string url, float timeout)
	{
		//IL_0017: Expected Obj, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0041: Invalid comparison between I8 and F4
		//IL_00b1: Expected VT, but got I4
		//IL_00be: Expected VT, but got I4
		//IL_0069: Expected Obj, but got I4
		WWW wWW = default;
		wWW._002Ector(url);
		Stopwatch stopwatch = default;
		stopwatch.Start();
		object obj = 0;
		while (true)
		{
			bool isDone = wWW.isDone;
			object obj2 = isDone | obj;
			object obj3 = obj2 & 1;
			if (obj3 != null)
			{
				break;
			}
			long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
			float num = timeout * 1000f;
			if ((float)elapsedMilliseconds > num)
			{
				obj = 1;
			}
		}
		stopwatch.Stop();
		bool isDone2 = wWW.isDone;
		bool isDone3 = wWW.isDone;
		string text = wWW.text;
		KeyValuePair<bool, string> keyValuePair = (KeyValuePair<bool, string>)0;
		return (KeyValuePair<bool, string>)isDone3;
	}

	private IEnumerator UploadToGoogleSheets()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private Coroutine StartPushPopup(string popup)
	{
		IEnumerator coroutine = PushPopup(popup);
		return CoroutineUtil.StartCoroutine(coroutine);
	}

	private Coroutine StartPushScreen(string screen, float extraDelay = 0f, bool closeAfterwards = true, bool logMemory = true)
	{
		IEnumerator coroutine = PushScreen(screen, extraDelay, closeAfterwards, logMemory);
		return CoroutineUtil.StartCoroutine(coroutine);
	}

	private Coroutine StartWaitForRealSeconds(float delay)
	{
		IEnumerator coroutine = CoroutineUtil.WaitForRealSeconds(delay);
		return CoroutineUtil.StartCoroutine(coroutine);
	}

	public void PromptStartMemoryBenchmark()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(benchmarkInProgress__BackingField ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			_ = 10;
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
		UIScreenController instance = UIScreenController.Instance;
		instance.QueueErrorMessageSlidein("Benchmark already running.");
	}

	private void MemoryBenchmarkPopupDismissed(string popupResult)
	{
		if (popupResult == "OK")
		{
			IEnumerator coroutine = RunMemoryBenchmark();
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
		}
	}

	private IEnumerator RunMemoryBenchmark()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator PushPopup(string popup)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator PushScreen(string screen, float extraDelay = 0f, bool closeAfterwards = true, bool logMemory = true)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator UIBenchmark()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator GameBenchmark()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private string GetFormattedTime(int time)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Expected F8, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		double value = (double)time / 60.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num = Math.Abs(value);
		if (!(num < 2147483648.0))
		{
			value = -2147483648.0;
		}
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		int num2 = time / 60;
		object obj4 = num2 * 60;
		object obj5 = time - obj4;
		object obj6 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		return $"{arg}m{arg2}s";
	}

	private bool ShouldSkipLog()
	{
		bool result = false;
		if (!INCLUDE_LOG_DETAILS)
		{
			result = false;
			if (!VERBOSE_LOG)
			{
				int uiCurrentLogSkipCount = ((_uiCurrentLogSkipCount >= 1) ? (_uiCurrentLogSkipCount - 1) : 4);
				bool flag = _uiCurrentLogSkipCount > 0;
				_uiCurrentLogSkipCount = uiCurrentLogSkipCount;
				result = flag;
			}
		}
		return result;
	}

	private void DumpRawData()
	{
		//IL_0017: Expected I, but got Obj
		StringBuilder logMemory = _logMemory;
		nint num = (nint)logMemory;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v3 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string item = default;
		_rawDataLogs.Add(item);
		StringBuilder logMemory2 = _logMemory;
		int length = logMemory2.m_ChunkOffset + logMemory2.m_ChunkLength;
		StringBuilder stringBuilder = logMemory2.Remove(0, length);
	}

	private void IncreaseAndUpdateProgress(float deltaProgress)
	{
		float currentProgress = _currentProgress + deltaProgress;
		_currentProgress = currentProgress;
		UIScreenController instance = UIScreenController.Instance;
		instance.UpdateMemoryBenchmarkPercent(_currentProgress);
	}

	private int LogCurrentMemoryUsage(string details = null)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I4
		int currentMemoryUsage = DeviceUtility.GetCurrentMemoryUsage();
		object obj;
		if (currentMemoryUsage > _maxMemory)
		{
			obj = this + 40;
		}
		else
		{
			if (currentMemoryUsage >= _minMemory)
			{
				goto IL_0080;
			}
			obj = this + 36;
		}
		obj = currentMemoryUsage;
		goto IL_0080;
		IL_0080:
		LogMemory(currentMemoryUsage, details);
		return currentMemoryUsage;
	}

	private void LogMemory(int memoryValue, string details = null)
	{
		//IL_0047: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		if (~(INCLUDE_LOG_DETAILS ? 1u : 0u) != 0)
		{
			goto IL_0069;
		}
		object obj;
		if (details != null)
		{
			obj = 0;
			if (details._stringLength != 0)
			{
				goto IL_00af;
			}
		}
		obj = 1;
		goto IL_00af;
		IL_00af:
		if (obj == null)
		{
			StringBuilder stringBuilder = _logMemory.AppendFormat("{0}=", details);
		}
		goto IL_0069;
		IL_0069:
		StringBuilder stringBuilder2 = _logMemory.Append(memoryValue);
		StringBuilder stringBuilder3 = _logMemory.Append(';');
	}

	private void Log(string text)
	{
	}

	public MemoryLog()
	{
		List<string> list = default;
		list._002Ector();
		_rawDataLogs = list;
	}
}
