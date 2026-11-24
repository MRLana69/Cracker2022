using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.Notifications.Internal;
using UnityEngine;
using UnityEngine.Networking;

namespace Kiloo.Common.Utility;

public class Wait
{
	public class Config
	{
		public struct TimeConfig
		{
			private readonly Config _config;

			public TimeConfig(Config wait)
			{
			}

			public Config ScaledSeconds()
			{
				return null;
			}

			public unsafe Config UnscaledSeconds()
			{
				//IL_000b: Expected Obj, but got Ref
				object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
				object obj2 = obj;
				_ = 0;
				return (Config)obj;
			}
		}

		private sealed class _003CWaitCoroutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Config _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CcurrentTime_003E5__3;

			private double _003CpausedTimeTotal_003E5__4;

			private double _003CpausedTime_003E5__5;

			private float _003CpausedStartTime_003E5__6;

			object IEnumerator<object>.Current
			{
				get
				{
					//IL_0378: Unknown result type (might be due to invalid IL or missing references)
					//IL_037d: Expected Obj, but got Unknown
					//IL_0386: Expected Obj, but got I4
					//IL_039a: Expected Obj, but got I4
					Config config = _003C_003E4__this;
					if (_003C_003E1__state != 0)
					{
						if (_003C_003E1__state != 1)
						{
							return null;
						}
						_003C_003E1__state = -1;
						if (config._time > 0f)
						{
							if (config._pauseWhileCondition != null)
							{
								float num = ((config._timeOption != TimeOption.UnscaledTime) ? Time.timeSinceLevelLoad : NetworkServer.maxDelay);
								_003CcurrentTime_003E5__3 = num;
								if (!config._pauseWhileCondition())
								{
									if (_003CpausedStartTime_003E5__6 > 0f)
									{
										double num2 = _003CpausedTimeTotal_003E5__4 + _003CpausedTime_003E5__5;
										_003CpausedTimeTotal_003E5__4 = num2;
										_003CpausedTime_003E5__5 = 0.0;
										_003CpausedStartTime_003E5__6 = 0f;
									}
								}
								else
								{
									if (!(_003CpausedStartTime_003E5__6 > 0f))
									{
										_003CpausedStartTime_003E5__6 = _003CcurrentTime_003E5__3;
									}
									float num3 = _003CcurrentTime_003E5__3 - _003CpausedStartTime_003E5__6;
									_003CpausedTime_003E5__5 = num3;
								}
							}
							else
							{
								float num4 = ((config._timeOption != TimeOption.UnscaledTime) ? Time.timeSinceLevelLoad : NetworkServer.maxDelay);
								_003CcurrentTime_003E5__3 = num4;
							}
							float num5 = _003CcurrentTime_003E5__3 - _003CstartTime_003E5__2;
							double num6 = _003CpausedTimeTotal_003E5__4 + _003CpausedTime_003E5__5;
							float num7 = num5 - (float)num6;
							if (num7 > config._time)
							{
								config.didTimeout__BackingField = true;
								goto IL_039f;
							}
						}
					}
					else
					{
						_003C_003E1__state = -1;
						float num8 = ((config._timeOption != TimeOption.UnscaledTime) ? Time.timeSinceLevelLoad : NetworkServer.maxDelay);
						_003CstartTime_003E5__2 = num8;
						_003CcurrentTime_003E5__3 = _003CstartTime_003E5__2;
						_003CpausedTimeTotal_003E5__4 = 0.0;
						_003CpausedTime_003E5__5 = 0.0;
						float num9;
						if (config._pauseWhileCondition == null)
						{
							num9 = 0f;
						}
						else
						{
							num9 = ((!config._pauseWhileCondition()) ? 0f : _003CstartTime_003E5__2);
						}
						_003CpausedStartTime_003E5__6 = num9;
					}
					if (config._whileCondition == null || config._whileCondition())
					{
						object obj = this + 12;
						obj = 0;
						_003C_003E1__state = 1;
						return 1;
					}
					goto IL_039f;
					IL_039f:
					config.isDone__BackingField = true;
					if (config._thenInvokeAction != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						return null;
					}
					if (config._thenInvokeActionWithConfig != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
					}
					return null;
				}
			}

			object IEnumerator.Current => _003C_003E2__current;

			public _003CWaitCoroutine_003Ed__21(int _003C_003E1__state)
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0013: Expected Obj, but got I4
				object obj = this + 8;
				obj = _003C_003E1__state;
			}

			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_001e: Expected I4, but got Obj
				object obj = this + 8;
				object obj2 = obj;
				_ = 1;
				return (byte)(int)obj != 0;
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

		private float _time;

		private TimeOption _timeOption;

		private Func<bool> _whileCondition;

		private Func<bool> _pauseWhileCondition;

		private Action _thenInvokeAction;

		private Action<Config> _thenInvokeActionWithConfig;

		private bool didTimeout__BackingField;

		private bool isDone__BackingField;

		public bool didTimeout
		{
			get
			{
				return (byte)_timeOption != 0;
			}
			private set
			{
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Expected Obj, but got Unknown
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Expected Obj, but got Unknown
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Expected Obj, but got Unknown
				//IL_0045: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Expected Obj, but got Unknown
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Expected Obj, but got Unknown
				while (true)
				{
					object obj = this + 20;
					object obj2 = obj + 1;
					obj = obj2;
					object obj3 = obj2 - 1;
					Action thenInvokeAction = _thenInvokeAction;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<Action, UIntPtr>(ref thenInvokeAction))
					{
						bool flag = (nint)_timeOption >= (nint)_whileCondition;
						bool flag2 = !flag;
						object obj4 = obj3;
						if (!flag2)
						{
							object obj5 = _timeOption - obj3;
							object obj6 = obj5 - 1;
							obj4 = obj6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
						continue;
					}
					break;
				}
			}
		}

		public bool isDone
		{
			get
			{
				return didTimeout__BackingField;
			}
			private set
			{
				didTimeout__BackingField = value;
			}
		}

		public TimeConfig For(float time)
		{
			//IL_0011: Expected VT, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
			return (TimeConfig)this;
		}

		public Config While(Func<bool> condition)
		{
			//IL_002c: Expected Obj, but got I4
			bool flag = ((string)(object)condition).EndsWith("..", StringComparison.Ordinal);
			bool flag2 = !flag;
			return (Config)flag2;
		}

		public Config PauseWhile(Func<bool> condition)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = condition;
			return this;
		}

		public Config ThenInvoke(Action action)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = action;
			return this;
		}

		public Config ThenInvoke(Action<Config> action)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = action;
			return this;
		}

		public Coroutine StartCoroutine()
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = isDone__BackingField;
			return (Coroutine)flag;
		}

		public Coroutine StartCoroutineOn(MonoBehaviour proxy)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 28;
			obj = proxy;
			return (Coroutine)(object)this;
		}

		private IEnumerator WaitCoroutine()
		{
			//IL_0013: Expected Obj, but got I4
			bool flag = ((DummyNotifications._003CGetEnumerator_003Ed__23)this).MoveNext();
			return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])flag);
		}
	}

	public static Config.TimeConfig For(float time)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		Config.TimeConfig result = default;
		return result;
	}

	public static Config While(Func<bool> condition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		object current = ((Transform.Enumerator)(object)condition).Current;
		object obj3 = default;
		object obj5 = default;
		Config config = default;
		Config result = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj4 = obj5 + (object)config;
			result = (Config)(obj4 + 1);
		}
		object obj6 = obj2 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj2 + obj8;
		obj9 = 63;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj10 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj2 + obj11;
			if ((nint)obj12 == 63)
			{
				object obj13 = obj2 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0286;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0286;
		IL_0286:
		return result;
	}

	private static void Log(string msg)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Action> list = default;
		list._002Ector();
		object obj = msg + 12;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Action> list2 = default;
		list2._002Ector();
		object obj2 = msg + 16;
		obj2 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Exception> list3 = default;
		list3._002Ector();
		object obj3 = msg + 20;
		obj3 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Exception> list4 = default;
		list4._002Ector();
		object obj4 = msg + 24;
		obj4 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
