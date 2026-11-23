using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Utility;

public class Wait
{
	public class Config
	{
		public struct TimeConfig(Config wait)
		{
			private readonly Config _config = wait;

			public Config ScaledSeconds()
			{
				Config config = _config;
				config._timeOption = TimeOption.ScaledTime;
				return config;
			}

			public Config UnscaledSeconds()
			{
				Config config = _config;
				config._timeOption = TimeOption.UnscaledTime;
				return config;
			}
		}

		private sealed class _003CWaitCoroutine_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state = _003C_003E1__state;

			private object _003C_003E2__current;

			public Config _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CcurrentTime_003E5__3;

			private double _003CpausedTimeTotal_003E5__4;

			private double _003CpausedTime_003E5__5;

			private float _003CpausedStartTime_003E5__6;

			object IEnumerator<object>.Current => _003C_003E2__current;

			object IEnumerator.Current => _003C_003E2__current;

			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				Config config = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						goto IL_0438;
					}
					_003C_003E1__state = -1;
					if (config._time > 0f)
					{
						if (config._pauseWhileCondition != null)
						{
							float num = ((config._timeOption != TimeOption.UnscaledTime) ? Time.time : Time.realtimeSinceStartup);
							_003CcurrentTime_003E5__3 = num;
							Func<bool> pauseWhileCondition = config._pauseWhileCondition;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v183 @ S0_v73 (System.Func`1<System.Boolean>)+C] (should have been resolved before IL gen)");
							object obj = default;
							if (obj != null)
							{
								bool flag = !(_003CpausedStartTime_003E5__6 > 0f);
								bool flag2 = !flag;
								float num2 = _003CpausedStartTime_003E5__6;
								if (!flag2)
								{
									_003CpausedStartTime_003E5__6 = _003CcurrentTime_003E5__3;
									num2 = _003CcurrentTime_003E5__3;
								}
								float num3 = _003CcurrentTime_003E5__3 - num2;
								_003CpausedTime_003E5__5 = num3;
							}
							else if (_003CpausedStartTime_003E5__6 > 0f)
							{
								double num4 = _003CpausedTimeTotal_003E5__4 + _003CpausedTime_003E5__5;
								_003CpausedStartTime_003E5__6 = 0f;
								_003CpausedTime_003E5__5 = 0.0;
								_003CpausedTimeTotal_003E5__4 = num4;
							}
						}
						else
						{
							float num5 = ((config._timeOption != TimeOption.UnscaledTime) ? Time.time : Time.realtimeSinceStartup);
							_003CcurrentTime_003E5__3 = num5;
						}
						float num6 = _003CcurrentTime_003E5__3 - _003CstartTime_003E5__2;
						double num7 = _003CpausedTimeTotal_003E5__4 + _003CpausedTime_003E5__5;
						float num8 = num6 - (float)num7;
						if (config._time < num8)
						{
							config.didTimeout__BackingField = true;
							goto IL_0395;
						}
					}
				}
				else
				{
					_003C_003E1__state = -1;
					float num9 = ((config._timeOption != TimeOption.UnscaledTime) ? Time.time : Time.realtimeSinceStartup);
					_003CpausedTimeTotal_003E5__4 = 0.0;
					_003CcurrentTime_003E5__3 = num9;
					_003CstartTime_003E5__2 = num9;
					_003CpausedTime_003E5__5 = 0.0;
					Func<bool> pauseWhileCondition2 = config._pauseWhileCondition;
					bool flag3 = config._pauseWhileCondition == null;
					float num10 = 0f;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S0_v41 (System.Func`1<System.Boolean>)+C] (should have been resolved before IL gen)");
						object obj2 = default;
						bool flag4 = obj2 == null;
						num10 = 0f;
						if (!flag4)
						{
							num10 = _003CstartTime_003E5__2;
						}
					}
					_003CpausedStartTime_003E5__6 = num10;
				}
				Func<bool> whileCondition = config._whileCondition;
				if (config._whileCondition != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S0_v21 (System.Func`1<System.Boolean>)+C] (should have been resolved before IL gen)");
					object obj3 = default;
					if (obj3 == null)
					{
						goto IL_0395;
					}
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
				IL_0395:
				config.isDone__BackingField = true;
				Action thenInvokeAction = config._thenInvokeAction;
				if (config._thenInvokeAction != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v179.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					return false;
				}
				Action<Config> thenInvokeActionWithConfig = config._thenInvokeActionWithConfig;
				if (config._thenInvokeActionWithConfig != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ S0_v12 (System.Action`1<Kiloo.Common.Utility.Wait+Config>)+C] (should have been resolved before IL gen)");
				}
				goto IL_0438;
				IL_0438:
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
				return didTimeout__BackingField;
			}
			private set
			{
				didTimeout__BackingField = value;
			}
		}

		public bool isDone
		{
			get
			{
				return isDone__BackingField;
			}
			private set
			{
				isDone__BackingField = value;
			}
		}

		public TimeConfig For(float time)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0027: Expected VT, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			_time = time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			return (TimeConfig)0;
		}

		public Config While(Func<bool> condition)
		{
			_whileCondition = condition;
			return this;
		}

		public Config PauseWhile(Func<bool> condition)
		{
			_pauseWhileCondition = condition;
			return this;
		}

		public Config ThenInvoke(Action action)
		{
			_thenInvokeAction = action;
			return this;
		}

		public Config ThenInvoke(Action<Config> action)
		{
			_thenInvokeActionWithConfig = action;
			return this;
		}

		public Coroutine StartCoroutine()
		{
			IEnumerator coroutine = WaitCoroutine();
			return CoroutineUtil.StartCoroutine(coroutine);
		}

		public Coroutine StartCoroutineOn(MonoBehaviour proxy)
		{
			IEnumerator routine = WaitCoroutine();
			return proxy.StartCoroutine(routine);
		}

		private IEnumerator WaitCoroutine()
		{
			_ = 0;
			IEnumerator result = default;
			return result;
		}
	}

	public static Config.TimeConfig For(float time)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002a: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
		return (Config.TimeConfig)0;
	}

	public static Config While(Func<bool> condition)
	{
		Config config = default;
		config._whileCondition = condition;
		return config;
	}

	private static void Log(string msg)
	{
	}
}
