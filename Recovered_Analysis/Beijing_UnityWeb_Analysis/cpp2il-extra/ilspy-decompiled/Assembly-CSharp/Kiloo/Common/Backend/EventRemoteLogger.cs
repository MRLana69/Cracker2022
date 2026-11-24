using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Diagnostics;
using Kiloo.Common.Extensions;
using Kiloo.Common.HTTP;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using SYBO.Components.Json;
using SYBO.Subway.Level;
using UnityEngine;

namespace Kiloo.Common.Backend;

public class EventRemoteLogger : IEventRemoteLogger, IEventLogger
{
	private class Event
	{
		public string Name;

		public JsonDict Stats;

		public DateTime TimeStamp;

		public Event()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Exception);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Exception.ReportUnhandledException((Exception)(object)this);
		}
	}

	private class Session
	{
		public Guid SessionId;

		public string DeviceId;

		public DateTime StopTimeStamp;

		public List<Event> Events;

		public DateTime StartTimeStamp;

		public int Aborted;
	}

	[StructLayout((LayoutKind)0, Size = 20)]
	private struct SessionFileInfo
	{
		public string File;

		public Guid SessionId;
	}

	private sealed class _003CSendCoroutine_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EventRemoteLogger _003C_003E4__this;

		public Action onComplete;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Expected Obj, but got Unknown
				//IL_00d9: Expected Obj, but got I4
				//IL_00ed: Expected Obj, but got I4
				EventRemoteLogger eventRemoteLogger = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (Kiloo.Common.Backend.EventRemoteLogger)+48]");
					if ((nint)0 == 0)
					{
						((UIRect.AnchorPoint)(object)eventRemoteLogger).Set(0f, 0f);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (Kiloo.Common.Backend.EventRemoteLogger)+48]");
				if ((nint)0 != 0)
				{
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				if (onComplete != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public unsafe _003CSendCoroutine_003Ed__43(int _003C_003E1__state)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c1: Expected Obj, but got Unknown
			//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_09cf: Expected VT, but got Unknown
			//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09dd: Expected Obj, but got Unknown
			//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09eb: Expected Ref, but got Unknown
			//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a02: Expected Obj, but got Unknown
			//IL_0a0b: Expected Obj, but got I4
			//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a19: Expected Obj, but got Unknown
			//IL_0a22: Expected Obj, but got I4
			//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a36: Expected Obj, but got Unknown
			//IL_0a54: Expected Obj, but got I4
			//IL_0963: Expected Obj, but got I
			//IL_0023: Expected Obj, but got I4
			//IL_004c: Expected I, but got Obj
			//IL_0062: Expected Obj, but got I
			//IL_0a74: Expected I, but got Obj
			//IL_0a8a: Expected Obj, but got I
			//IL_008d: Expected I, but got Obj
			//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bae: Expected Obj, but got Unknown
			//IL_00da: Expected I, but got Obj
			//IL_0124: Invalid comparison between Obj and F4
			//IL_01e1: Expected Obj, but got I
			//IL_0151: Expected I, but got Obj
			//IL_0167: Expected Obj, but got I
			//IL_0ae2: Expected Obj, but got I8
			//IL_0af9: Expected I8, but got Obj
			//IL_0af4: Expected native int or pointer, but got VT
			//IL_0b0e: Expected Ref, but got VT
			//IL_0b1a: Expected Obj, but got I8
			//IL_0b4f: Invalid comparison between F8 and I
			//IL_0b5e: Expected Obj, but got I4
			//IL_0192: Expected I, but got Obj
			//IL_026c: Expected Obj, but got I4
			//IL_0275: Expected Obj, but got I4
			//IL_0287: Expected Obj, but got I4
			//IL_0290: Expected Obj, but got I4
			//IL_0254: Expected Obj, but got I
			//IL_02fd: Expected Obj, but got I
			//IL_030b: Expected I, but got Obj
			//IL_0321: Expected Obj, but got I
			//IL_03b6: Expected Obj, but got I4
			//IL_034c: Expected I, but got Obj
			//IL_03d7: Expected Obj, but got I4
			//IL_041b: Expected Obj, but got I4
			//IL_08d1: Expected Obj, but got I
			//IL_043c: Expected Obj, but got I4
			//IL_0872: Expected Obj, but got I4
			//IL_093f: Expected Obj, but got I
			//IL_0484: Expected Obj, but got I4
			//IL_04f9: Expected Obj, but got I4
			//IL_0519: Expected Obj, but got I4
			//IL_04c1: Expected Obj, but got I
			//IL_04d9: Expected Obj, but got I4
			//IL_0bd0: Expected Obj, but got I4
			//IL_0581: Expected Obj, but got I4
			//IL_05a1: Expected Obj, but got I4
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b4: Expected Obj, but got Unknown
			//IL_079b: Expected Obj, but got I4
			//IL_0bef: Expected Obj, but got I
			//IL_0c07: Expected Obj, but got I4
			//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b3: Expected Obj, but got Unknown
			//IL_085b: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 80;
			IFormatProvider formatProvider = (IFormatProvider)(obj2 + 40);
			DateTime dateTime = (DateTime)(obj2 + 32);
			object obj3 = obj2 + 8;
			ref DateTime reference = ref *(DateTime*)(obj2 + 24);
			reference = ref *(DateTime*)null;
			object obj4 = obj2 + 16;
			obj4 = 0;
			object obj5 = obj2 - -64;
			obj5 = 0;
			_ = 0;
			object obj6 = obj2 + 56;
			obj6 = obj;
			_ = -1;
			object obj7 = this._003C_003E1__state + 12;
			object obj8 = default;
			object obj17 = default;
			object obj22 = default;
			object obj23 = default;
			object obj24 = default;
			object obj26 = default;
			IntPtr intPtr = default;
			object obj28 = default;
			object obj30 = default;
			object obj33 = default;
			IntPtr intPtr2 = default;
			object obj35 = default;
			object obj19 = default;
			object obj15 = default;
			object obj37 = default;
			object obj41 = default;
			while (true)
			{
				object obj11;
				object obj18;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
				{
					object obj9 = this._003C_003E1__state + 16;
					object obj10 = obj8 << 2;
					obj11 = obj9 + obj10;
					nint num = (nint)typeof(Path);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v42 (Il2CppClass<System.IO.Path>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num2 = (nint)typeof(Path);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v253 (Il2CppClass<System.IO.Path>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string fullPath = Path.GetFullPath((string)obj11);
					nint num3 = (nint)typeof(TimeUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v49 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num4 = (nint)typeof(TimeUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v249 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!TimeUtility.TryParseRFC1123(fullPath, out reference))
					{
						goto IL_0ba0;
					}
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref _003C_003E2__current) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
					{
						nint num5 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v109 (Il2CppClass<System.DateTime>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num6 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v127 (Il2CppClass<System.DateTime>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
						obj3 = systemTimeAsFileTime;
						obj2 = _003C_003E4__this;
						((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj3;
						formatProvider = (IFormatProvider)obj2;
						long num7 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
						obj4 = num7;
						double num8 = (double)obj4 * 1E-07;
						double num9 = (double)_003C_003E2__current - num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.EventRemoteLogger+<SendCoroutine>d__43)+18]");
						bool flag = num9 < 0.0;
						obj15 = 0;
						if (flag)
						{
							goto IL_0953;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.EventRemoteLogger+<SendCoroutine>d__43)+1C]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v63+48]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						object obj20;
						object obj21;
						if (obj17 != null)
						{
							obj18 = obj19;
							obj20 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.EventRemoteLogger+<SendCoroutine>d__43)+24]");
							obj21 = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
							obj18 = 0;
							obj20 = 0;
							obj21 = obj22;
							obj19 = 0;
							obj15 = 0;
						}
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							obj19 = obj18;
							obj15 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
							if (obj23 != obj24)
							{
								object obj25 = obj26;
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
							object obj27 = (nint)intPtr;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							if (obj28 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
								object obj29 = (nint)intPtr;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
								object obj25 = obj30;
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.EventRemoteLogger+<SendCoroutine>d__43)+1C]");
							object obj31 = 0;
							nint num10 = (nint)typeof(KilooWebClient);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v118 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
							object obj32 = (nint)0 & (nint)0x200;
							if (obj32 != null)
							{
								nint num11 = (nint)typeof(KilooWebClient);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S0_v210 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
									obj19 = obj18;
									obj15 = obj20;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							obj19 = obj18;
							obj15 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
							obj19 = obj18;
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
							obj19 = obj18;
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
							formatProvider = (IFormatProvider)obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							obj19 = obj18;
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							obj19 = obj18;
							obj15 = 0;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								obj19 = obj18;
								obj15 = 0;
								if (intPtr2 == (IntPtr)0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.EventRemoteLogger+<SendCoroutine>d__43)+1C]");
									object obj34 = 0;
									_ = 0;
									obj19 = obj18;
									obj15 = 0;
									goto IL_0ba0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								obj19 = obj18;
								obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								obj19 = obj18;
								obj15 = 0;
								bool flag2;
								if (obj35 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ S0_v177+8]");
									flag2 = (nint)0 == 0;
								}
								else
								{
									flag2 = true;
								}
								bool flag3 = !flag2;
								obj19 = obj18;
								obj15 = 0;
								if (flag3)
								{
									goto IL_0ba0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								obj19 = obj18;
								obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								obj19 = obj18;
								obj15 = 0;
								object obj36 = obj37 - 400;
								if ((nint)obj37 != 400 && (nint)obj36 != 1 && (nint)obj36 != 2 && (nint)obj36 != 3 && (nint)obj36 != 4 && (nint)obj36 != 5 && (nint)obj36 != 6 && (nint)obj36 != 7)
								{
									if ((nint)obj36 != 8)
									{
										if ((nint)obj36 == 9 || (nint)obj36 == 10)
										{
											goto IL_0789;
										}
										if ((nint)obj36 != 11)
										{
											if ((nint)obj36 == 12 || (nint)obj36 == 13 || (nint)obj36 == 14 || (nint)obj36 == 15)
											{
												goto IL_0789;
											}
											object obj38 = obj37 - 501;
											if ((nint)obj37 == 501 || ((nint)obj38 != 1 && (nint)obj38 != 2 && (nint)obj38 != 3 && (nint)obj38 == 4))
											{
												obj19 = obj18;
												obj15 = 0;
												goto IL_0912;
											}
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.EventRemoteLogger+<SendCoroutine>d__43)+1C]");
									object obj39 = 0;
									_ = 0;
									obj19 = obj18;
									obj15 = 0;
									goto IL_0ba0;
								}
								goto IL_0789;
							}
							obj19 = obj18;
							obj15 = 0;
						}
						goto IL_0912;
					}
				}
				goto IL_0953;
				IL_0953:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.EventRemoteLogger+<SendCoroutine>d__43)+1C]");
				object obj40 = 0;
				_ = 0;
				return;
				IL_0789:
				obj19 = obj18;
				obj15 = 0;
				goto IL_0912;
				IL_0ba0:
				obj8 = obj41 + 1;
				continue;
				IL_0912:
				((FileStream)obj11).ExposeHandle();
				goto IL_0ba0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}

		void IDisposable.Dispose()
		{
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

	public static readonly EventRemoteLogger instance;

	public bool isPartOfSample;

	public bool allowSending;

	public bool allowSaving;

	private const string FOLDER = "event_logs";

	private const string API_POST_EVENTS_ROUTE = "api/v2/log";

	private const int MAX_UNSENT_FILES = 25;

	private readonly TimeSpan _dataExpireTime;

	private Session _session;

	private byte[] _lastSavedData;

	private string _lastSavedFilename;

	private bool _didAddApplicationStateHandlers;

	private Action m_onPauseOrQuit;

	private Action m_onResume;

	private Uri _loggingServiceUri;

	private string _dataFolder;

	private int _maximumSessionPauseInSeconds;

	private bool _sendOnPause;

	private float _sendOnPauseMaximumSendTime;

	private float _sendOnPauseRequestTimeWindow;

	private bool isSending__BackingField;

	public bool isSending
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected Obj, but got Unknown
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Expected Obj, but got Unknown
			//IL_0247: Expected I, but got Obj
			//IL_025d: Expected Obj, but got I
			//IL_00ac: Expected I, but got Obj
			//IL_00c2: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_00ed: Expected I, but got Obj
			//IL_020f: Expected I4, but got Obj
			object obj2 = default;
			object obj = obj2 + 32;
			object obj3 = obj2 + 16;
			object obj4 = obj2 + 8;
			obj4 = obj;
			_ = -1;
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19 (Il2CppClass<System.Type>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v105 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj2 = typeof(ErrorCategory);
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v31 (Il2CppClass<System.Enum>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v55 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj8 = default;
			object obj7 = obj8;
			object obj10 = default;
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj11 = default;
			if (obj9 == obj11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj13 = default;
				object obj12 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj15 = default;
				object obj14 = obj15;
			}
			else
			{
				object obj14 = obj7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			object obj16 = default;
			return (byte)(int)obj16 != 0;
		}
		private set
		{
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onResume;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 44;
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

	public unsafe event Action onPauseOrQuit
	{
		add
		{
			//IL_0392: Unknown result type (might be due to invalid IL or missing references)
			//IL_0397: Expected Obj, but got Unknown
			//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a5: Expected Obj, but got Unknown
			//IL_03ae: Expected Obj, but got I4
			//IL_03c4: Expected Obj, but got I
			//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Expected Obj, but got Unknown
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Expected I4, but got Unknown
			//IL_03ff: Expected I4, but got Obj
			//IL_0408: Unknown result type (might be due to invalid IL or missing references)
			//IL_040d: Expected Obj, but got Unknown
			//IL_042b: Expected I4, but got Obj
			//IL_043e: Expected Obj, but got I4
			//IL_01ff: Expected I, but got Obj
			//IL_0215: Expected Obj, but got I
			//IL_001c: Expected Obj, but got I4
			//IL_0060: Expected Obj, but got I4
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected Obj, but got Unknown
			//IL_0548: Expected I4, but got Obj
			//IL_00f6: Expected I, but got Obj
			//IL_010c: Expected Obj, but got I
			//IL_0298: Expected I4, but got F4
			//IL_0240: Expected I, but got Obj
			//IL_0470: Expected I, but got Obj
			//IL_0486: Expected Obj, but got I
			//IL_0088: Expected I4, but got Obj
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected Obj, but got Unknown
			//IL_00bf: Expected Obj, but got I4
			//IL_04b0: Expected I4, but got Obj
			//IL_04d3: Expected I4, but got Obj
			//IL_04fc: Expected Obj, but got I4
			//IL_0137: Expected I, but got Obj
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected Obj, but got Unknown
			//IL_0184: Expected I, but got Obj
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Expected Obj, but got Unknown
			//IL_030c: Expected I4, but got Obj
			object obj2 = default;
			object obj = obj2 + 32;
			object obj3 = obj2 + 48;
			obj3 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.EventRemoteLogger)+14]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
			object obj4 = obj2 + 24;
			obj4 = obj2;
			GUILayoutOption.Type type = (GUILayoutOption.Type)(obj2 - -64);
			((GUILayoutOption.Type*)(int)type)->value__ = (int)obj4;
			GUILayoutOption gUILayoutOption = (GUILayoutOption)(obj2 + 16);
			object value2 = default;
			gUILayoutOption._002Ector(type, value2);
			((GUILayoutOption.Type*)(int)type)->value__ = (int)gUILayoutOption;
			_ = ((GUILayoutOption.Type*)(int)type)->value__;
			object obj5 = 0;
			GUILayoutOption[] options = default;
			while (true)
			{
				TimeSpan dataExpireTime = _dataExpireTime;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v23 (System.TimeSpan)+C]");
				if ((nint)obj6 >= 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
				obj3 = ((GUILayoutOption.Type*)(int)type)->value__;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (UnityEngine.GUILayoutOption+Type)+8]");
				_ = 0;
				bool flag = (nint)obj5 < 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.EventRemoteLogger)+1D]");
				bool flag2 = (nint)0 != 0;
				object obj7 = (flag2 ? 1 : 0) ^ 1;
				object obj8 = flag | obj7;
				if (obj8 == null)
				{
					((GUILayoutOption.Type*)(int)type)->value__ = (int)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					_ = 0;
					object obj9 = obj5 - 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
					if ((string)((GUILayoutOption.Type*)(int)type)->value__ != (string)obj2)
					{
						goto IL_01c3;
					}
				}
				nint num = (nint)typeof(Kiloo.Common.Diagnostics.Console);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v85 (Il2CppClass<Kiloo.Common.Diagnostics.Console>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num2 = (nint)typeof(Kiloo.Common.Diagnostics.Console);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v111 (Il2CppClass<Kiloo.Common.Diagnostics.Console>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10A8A");
				nint num3 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v96 (Il2CppClass<UnityEngine.GUI>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num4 = (nint)typeof(GUI);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v107 (Il2CppClass<UnityEngine.GUI>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((GUILayoutOption.Type*)(int)type)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				GUI.changed = (byte)type != 0;
				((GUILayoutOption.Type*)(int)type)->value__ = (int)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
				GUILayout.BeginHorizontal((GUIStyle)((GUILayoutOption.Type*)(int)type)->value__, options);
				goto IL_01c3;
				IL_01c3:
				object obj12 = obj5 + 1;
				obj5 = obj12;
			}
			GUILayoutUtility.Layout();
			Color black = Color.black;
			nint num5 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v34 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num6 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v70 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((GUILayoutOption.Type*)(int)type)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			GUI.changed = (byte)type != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
			GUILayoutOption[] options2 = default;
			GUILayout.BeginVertical(options2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
			bool isWindow = default;
			GUILayoutUtility.LayoutCache layoutCache = GUILayoutUtility.SelectIDList((int)_sendOnPauseRequestTimeWindow, isWindow);
			if (layoutCache != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
			}
			if (value != null)
			{
				object obj14 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
				bool isWindow2 = default;
				GUILayoutUtility.LayoutCache layoutCache2 = GUILayoutUtility.SelectIDList((int)obj14, isWindow2);
				if (layoutCache2 != null)
				{
					_lastSavedData = null;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.EventRemoteLogger)+1D]");
			bool flag3 = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			UnityEngine.GUILayoutGroup gUILayoutGroup = GUILayoutUtility.CreateGUILayoutGroupInstanceOfType((Type)null);
			throw new ArrayTypeMismatchException();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPauseOrQuit;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
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

	public event Action onResume
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onPauseOrQuit;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onResume;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 44;
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

	private EventRemoteLogger()
	{
	}

	public void SetServiceInfo(Uri baseUri, int maximumSessionPauseInSeconds = 600)
	{
		//IL_0013: Expected I4, but got Obj
		//IL_0024: Expected Obj, but got I4
		if (this != null)
		{
			string msg = string.ConcatArray((string[])(object)"Assert failed: ", (int)baseUri);
			SDebug.LogFormat(msg, (object[])maximumSessionPauseInSeconds);
			Kiloo.Common.Diagnostics.Console._002Ecctor();
		}
	}

	public void CheckSessionRemoval()
	{
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_0284: Expected Obj, but got VT
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02a4: Expected VT, but got Obj
		//IL_02bd: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_0115: Expected I, but got Obj
		nint num = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v57 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimeSpan timeSpan = TimeSpan.FromHours(28.0);
		object obj2 = timeSpan;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		_dataExpireTime = (TimeSpan)obj3;
		_maximumSessionPauseInSeconds = 600;
		nint num3 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v19 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v53 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		if (cachePath == null || cachePath.m_stringLength == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v30 (Il2CppClass<System.IO.Path>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v45 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 52;
		bool flag = Path.SameRoot(cachePath, "event_logs");
		obj6 = flag;
		if (_dataFolder != null && !Directory.IsRootDirectory(_dataFolder))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectoriesInternal(_dataFolder);
		}
	}

	private string GetSessionJSON()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = isSending__BackingField;
		return (string)flag;
	}

	public void LogEvent(string eventName, Dictionary<string, object> parameters = null)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_003e: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri._002Ector((Uri)(object)eventName, (Uri)(object)"api/v2/log");
		object obj = this + 48;
		obj = uri;
		_maximumSessionPauseInSeconds = (int)parameters;
	}

	private JsonDict ConvertFromDictionary(Dictionary<string, object> dict)
	{
		//IL_0013: Expected Obj, but got I4
		return (JsonDict)Enumerable.Contains((IEnumerable<string>)dict, (string)(object)this);
	}

	public void Send(float maximumSendTime, float requestTimeWindow)
	{
		IEnumerator enumerator = CoroutineUtil.WaitForRealSeconds(maximumSendTime);
		int activeTrainCount = MovingTrain.GetActiveTrainCount();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		throw new ArrayTypeMismatchException();
	}

	public Coroutine SendAsync(Action onComplete = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0224: Expected Obj, but got I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0247: Expected Obj, but got I4
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonFieldInfo jsonFieldInfo = default;
		jsonFieldInfo._002Ector();
		if (onComplete != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			object obj7 = obj5 + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj5 + obj9;
			obj10 = 71;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj5 + obj11;
				if ((nint)obj12 == 71)
				{
					object obj13 = obj5 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					goto IL_0328;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_0328;
		IL_0328:
		return (Coroutine)(object)jsonFieldInfo;
	}

	public void SendOnPause(bool enable, float maximumSendTime = 3f, float requestTimeWindow = 2f)
	{
		//IL_0019: Expected VT, but got F4
		isPartOfSample = enable;
		_dataExpireTime = (TimeSpan)requestTimeWindow;
		bool flag = maximumSendTime > requestTimeWindow;
		bool flag2 = maximumSendTime < requestTimeWindow;
	}

	private void Save()
	{
		if (~(isPartOfSample ? 1u : 0u) == 0)
		{
			CleanAndSend();
		}
		else
		{
			StartSession();
		}
	}

	private void StartSession()
	{
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_0032: Expected I, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_026b: Expected Obj, but got I8
		//IL_0280: Expected VT, but got Obj
		//IL_02ac: Expected I, but got Obj
		//IL_02c2: Expected Obj, but got I
		//IL_02ed: Expected Obj, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected I4, but got Unknown
		//IL_0073: Expected I, but got Obj
		//IL_00c0: Expected I, but got Obj
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0210: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I8
		//IL_0349: Expected I, but got Obj
		//IL_035f: Expected Obj, but got I
		//IL_03a8: Expected Obj, but got I4
		//IL_03a8: Expected Obj, but got I4
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_0170: Expected I, but got Obj
		//IL_01bd: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		if (_session == null || _dataFolder == null)
		{
			return;
		}
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v19 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v64 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		Session session = _session;
		obj3 = systemTimeAsFileTime;
		obj = obj3;
		session.StopTimeStamp = (DateTime)obj;
		Session session2 = _session;
		bool flag = isPartOfSample;
		nint num3 = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v7 (Il2CppClass<System.Convert>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v18 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = (flag ? 1 : 0) ^ 1;
		int aborted = obj6 & 1;
		session2.Aborted = aborted;
		if (~(allowSaving ? 1u : 0u) == 0)
		{
			string id = ((InstallationInfo)this).id;
			Encoding uTF = Encoding.UTF32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			nint num5 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v45 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v60 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = systemTimeAsFileTime;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D770");
			nint num7 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v30 (Il2CppClass<System.IO.Path>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v40 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = default;
			bool flag2 = Path.SameRoot(_dataFolder, text);
			List<DebugSettingsCell> list = default;
			((DebugSettingsPopup.DebugSettingsListAdapter)flag2)._002Ector(list, null, null, (GameObject)(-1), null, null, null, null, null);
			object obj9 = this + 28;
			obj9 = list;
			object obj10 = this + 32;
			obj10 = text;
		}
		Session session3 = _session;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		if (~(isPartOfSample ? 1u : 0u) != 0)
		{
			object obj11 = this + 24;
			obj11 = 0;
		}
	}

	private unsafe void CleanAndSend()
	{
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected VT, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_03f7: Expected Obj, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_0187: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_0423: Expected Obj, but got VT
		//IL_042c: Expected Obj, but got VT
		//IL_0439: Expected I8, but got Obj
		//IL_0434: Expected native int or pointer, but got VT
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0568: Expected Obj, but got VT
		//IL_0575: Expected Obj, but got I8
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_05c8: Expected Obj, but got I4
		//IL_05e0: Expected I, but got Obj
		//IL_05f6: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_0624: Expected Obj, but got I8
		//IL_0639: Expected VT, but got Obj
		//IL_01c8: Expected I, but got Obj
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0215: Expected I, but got Obj
		//IL_049d: Expected Obj, but got VT
		//IL_04b2: Expected VT, but got Obj
		//IL_04c3: Expected Obj, but got I8
		//IL_04d0: Expected Obj, but got VT
		//IL_04dd: Expected I8, but got Obj
		//IL_04d8: Expected native int or pointer, but got VT
		//IL_04f2: Expected Ref, but got VT
		//IL_04fe: Expected Obj, but got I8
		//IL_051c: Invalid comparison between F8 and I4
		//IL_0100: Expected I, but got Obj
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02a1: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Obj, but got Unknown
		//IL_02e2: Expected I, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 72);
		DateTime dateTime = (DateTime)(obj + 48);
		object obj2 = obj - -64;
		object obj3 = obj + 40;
		object obj4 = obj + 32;
		object obj5 = obj + 24;
		object obj6 = obj + 16;
		object obj7 = obj + 8;
		obj7 = 0;
		if (_session != null)
		{
			Session session = _session;
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v82 (Il2CppClass<System.DateTime>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v113 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = session.StopTimeStamp;
			obj3 = DateTime.MinValue;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
			formatProvider = (IFormatProvider)obj3;
			long num3 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
			object obj9 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
			if (num3 != (long)obj9)
			{
				Session session2 = _session;
				Session session3 = _session;
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v87 (Il2CppClass<System.DateTime>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num5 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v107 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj4 = DateTime.MinValue;
				formatProvider = (IFormatProvider)obj4;
				session3.StopTimeStamp = (DateTime)formatProvider;
				long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
				obj5 = systemTimeAsFileTime;
				obj6 = session2.StopTimeStamp;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
				formatProvider = (IFormatProvider)obj6;
				long num6 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
				obj7 = num6;
				double num7 = (double)obj7 * 1E-07;
				if (!(num7 < (double)_maximumSessionPauseInSeconds))
				{
					goto IL_0179;
				}
			}
			goto IL_053b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_003C_003Ec__DisplayClass34_0 obj11 = default;
		obj11._002Ector();
		object obj12 = this + 24;
		obj12 = obj11;
		goto IL_0179;
		IL_0179:
		nint num8 = (nint)typeof(Guid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v39 (Il2CppClass<System.Guid>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num9 = (nint)typeof(Guid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v67 (Il2CppClass<System.Guid>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((IndexOutOfRangeException)dateTime)._002Ector();
		formatProvider = (IFormatProvider)dateTime.dateData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (System.DateTime)+8]");
		_ = 0;
		object obj14 = _session + 8;
		obj14 = formatProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IFormatProvider)+8]");
		_ = 0;
		object obj15 = _session + 24;
		bool hasLoggedGameCenterLogin = AnalyticsSave.hasLoggedGameCenterLogin;
		obj15 = hasLoggedGameCenterLogin;
		Session session4 = _session;
		nint num10 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v55 (Il2CppClass<System.DateTime>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num11 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S1_v63 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime2 = DateTime.GetSystemTimeAsFileTime();
		obj = systemTimeAsFileTime2;
		formatProvider = (IFormatProvider)obj;
		session4.StartTimeStamp = (DateTime)formatProvider;
		goto IL_053b;
		IL_053b:
		if (~(_didAddApplicationStateHandlers ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(EventRemoteLogger.OnApplicationQuit);
		object obj17 = action + 16;
		obj17 = this;
		nint num12 = (nint)typeof(ApplicationState);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v39 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num13 = (nint)typeof(ApplicationState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v59 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ApplicationState.quit -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(EventRemoteLogger.OnApplicationPause);
		object obj19 = action2 + 16;
		obj19 = this;
		ApplicationState.paused -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(EventRemoteLogger.OnApplicationResume);
		object obj20 = action3 + 16;
		obj20 = this;
		ApplicationState.resumed -= action3;
		_didAddApplicationStateHandlers = true;
	}

	private void OnApplicationQuit()
	{
		KilooWebClient.InitAutomatically((string)(object)this);
		IEnumerator enumerator = SendCoroutine(null);
	}

	private unsafe void OnApplicationResume()
	{
		//IL_0102: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		ApplicationState applicationState = default;
		((UnityEngine.Object)applicationState).m_CachedPtr = cachedPtr;
		applicationState._focused = (Action)0;
		object obj = applicationState + 16;
		obj = this;
		nint num = (nint)typeof(ApplicationState);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(ApplicationState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v38 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		applicationState.OnApplicationQuit();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(EventRemoteLogger.OnApplicationPause);
		object obj3 = action + 16;
		obj3 = this;
		ApplicationState.resumed += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(EventRemoteLogger.OnApplicationResume);
		object obj4 = action2 + 16;
		obj4 = this;
		ApplicationState.focused += action2;
		_didAddApplicationStateHandlers = false;
		if (~(isPartOfSample ? 1u : 0u) == 0)
		{
			TransformExtensions.Reset((Transform)(object)this.m_onPauseOrQuit);
			StartSession();
		}
	}

	private void OnApplicationPause()
	{
		if (~(isPartOfSample ? 1u : 0u) == 0)
		{
			OnApplicationQuit();
			CleanAndSend();
			TransformExtensions.Reset((Transform)(object)this.m_onResume);
		}
	}

	private IEnumerator SendCoroutine(Action onComplete)
	{
		Error serviceError = HTTPExtensions.GetServiceError((IRequest)this, (IJsonSerializer)(object)onComplete);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)serviceError);
	}

	private void CleanupOldUnsentFiles()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0063: Expected F4, but got Obj
		if (~(isPartOfSample ? 1u : 0u) == 0)
		{
			TransformExtensions.Reset((Transform)(object)this.m_onPauseOrQuit);
			StartSession();
		}
		if (~(_sendOnPause ? 1u : 0u) == 0)
		{
			object obj = this - -64;
			((UIRect.AnchorPoint)this).Set((float)obj, _sendOnPauseRequestTimeWindow);
		}
	}

	private void LogError(string msg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(msg & 1) != 0;
		isSending__BackingField = flag;
	}

	private void LogWarning(string msg)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[EventLogger] ", (int)msg);
		SDebug.LogFormat(msg2, null);
	}

	private void Log(string msg)
	{
	}

	unsafe static EventRemoteLogger()
	{
		//IL_0161: Expected Obj, but got I
		//IL_0171: Expected Obj, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected VT, but got Unknown
		//IL_01d1: Expected F4, but got Obj
		//IL_01cc: Expected native int or pointer, but got VT
		//IL_01e6: Expected F4, but got I
		//IL_01e1: Expected native int or pointer, but got VT
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0029: Expected F4, but got Obj
		//IL_0024: Expected native int or pointer, but got VT
		//IL_003e: Expected F4, but got I
		//IL_0039: Expected native int or pointer, but got VT
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0079: Expected F4, but got Obj
		//IL_0074: Expected native int or pointer, but got VT
		//IL_008e: Expected F4, but got I
		//IL_0089: Expected native int or pointer, but got VT
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00c9: Expected F4, but got Obj
		//IL_00c4: Expected native int or pointer, but got VT
		//IL_00de: Expected F4, but got I
		//IL_00d9: Expected native int or pointer, but got VT
		//IL_010b: Expected F4, but got Obj
		//IL_0106: Expected native int or pointer, but got VT
		//IL_0120: Expected F4, but got I
		//IL_011b: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		object obj6 = obj7 - -64;
		Color black = Color.black;
		Color color = (Color)(obj7 + 80);
		((Color*)(nint)color)->r = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v12+8]");
		((Color*)(nint)color)->b = 0f;
		Dictionary<LogType, Color> dictionary = default;
		dictionary.Add(LogType.Assert, color);
		object obj8 = obj7 + 48;
		Color green = Color.green;
		((Color*)(nint)color)->r = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v20+8]");
		((Color*)(nint)color)->b = 0f;
		dictionary.Add(LogType.Error, color);
		object obj9 = obj7 + 32;
		Color green2 = Color.green;
		((Color*)(nint)color)->r = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27+8]");
		((Color*)(nint)color)->b = 0f;
		dictionary.Add(LogType.Exception, color);
		object obj10 = obj7 + 16;
		Color black2 = Color.black;
		((Color*)(nint)color)->r = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v34+8]");
		((Color*)(nint)color)->b = 0f;
		dictionary.Add(LogType.Log, color);
		Color magenta = Color.magenta;
		((Color*)(nint)color)->r = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Color*)(nint)color)->b = 0f;
		dictionary.Add(LogType.Warning, color);
		Kiloo.Common.Diagnostics.Console.logTypeColors = dictionary;
	}
}
