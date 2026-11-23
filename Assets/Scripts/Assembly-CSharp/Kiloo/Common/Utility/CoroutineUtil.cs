using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Utility;

public static class CoroutineUtil
{
	private sealed class _003CWaitForAllCoroutine_003Ed__5(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public IEnumerable<YieldInstruction> list;

		private IEnumerator<YieldInstruction> _003C_003E7__wrap1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0020: Expected Obj, but got I4
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected Obj, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			object obj3 = _003C_003E1__state + 3;
			if (obj3 == null || ((nint)obj3 != 1 && (nint)obj3 != 2 && (nint)obj3 != 3 && (nint)obj3 == 4))
			{
				object obj4 = obj + 28;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj5 = obj + 20;
				object obj6 = obj5;
				((_003CWaitForAllCoroutine_003Ed__5)obj6)._003C_003Em__Finally1();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @254");
				}
			}
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Expected Obj, but got Unknown
			//IL_03db: Expected Obj, but got I
			//IL_00a0: Expected Obj, but got I
			//IL_00b5: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I
			//IL_0337: Unknown result type (might be due to invalid IL or missing references)
			//IL_033c: Expected Obj, but got Unknown
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Expected Obj, but got Unknown
			//IL_047c: Expected Obj, but got I
			//IL_020a: Expected Obj, but got I
			//IL_021f: Expected Obj, but got I
			//IL_017d: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
			object obj3 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
			object obj6;
			bool result = default;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
				bool flag = (nint)0 == 1;
				object obj5 = obj4;
				if (!flag)
				{
					obj6 = obj;
					goto IL_0444;
				}
			}
			else
			{
				_ = -1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result = false;
					goto IL_0253;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				object obj5 = 0;
			}
			_ = -3;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = default;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				result = flag2;
				goto IL_0253;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			object obj8 = 0;
			if (!flag2)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					result = false;
					goto IL_0253;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				object obj9 = 0;
				_ = 0;
				result = false;
				obj6 = obj;
			}
			else
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					result = true;
					goto IL_0253;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				object obj11 = 0;
				_ = 1;
				result = true;
				obj6 = obj;
			}
			goto IL_0444;
			IL_0444:
			object obj12 = obj6 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A1D1");
			return result;
			IL_0253:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj13 = default;
			object obj14 = default;
			bool flag3 = obj13 == obj14;
			bool flag4 = !flag3;
			object obj16 = default;
			object obj15 = obj16;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				result = false;
				obj6 = obj;
				if (flag5)
				{
					goto IL_0444;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = false;
				object obj17 = default;
				obj15 = obj17;
			}
			_ = 0;
			object obj18 = obj + 16;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj6 = 0;
			goto IL_0444;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			}
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

	private sealed class _003CWaitForRealSeconds_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float timeToWait;

		private float _003Cstart_003E5__2;

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
					goto IL_0076;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				_003Cstart_003E5__2 = realtimeSinceStartup;
			}
			float realtimeSinceStartup2 = Time.realtimeSinceStartup;
			float num = _003Cstart_003E5__2 + timeToWait;
			if (realtimeSinceStartup2 < num)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_0076;
			IL_0076:
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

	private static MonoBehaviour _coroutineRunner;

	public static Coroutine StartCoroutine(IEnumerator coroutine)
	{
		if (Application.isPlaying)
		{
			if (_coroutineRunner == null)
			{
				GameObject gameObject = default;
				gameObject._002Ector("CoroutineRunner");
				NewMonoBehaviour coroutineRunner = gameObject.AddComponent<NewMonoBehaviour>();
				_coroutineRunner = coroutineRunner;
				GameObject gameObject2 = _coroutineRunner.gameObject;
				UnityEngine.Object.DontDestroyOnLoad(gameObject2);
			}
			return _coroutineRunner.StartCoroutine(coroutine);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Exception ex = default;
		ex._002Ector("CoroutineUtil.StartCoroutine must be in play mode (or objects will leak)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (Coroutine)(object)ex;
	}

	public static void StopCoroutine(IEnumerator coroutine)
	{
		bool flag = _coroutineRunner != null;
		if (coroutine != null && flag)
		{
			_coroutineRunner.StopCoroutine(coroutine);
		}
	}

	public static Coroutine WaitForAll(IEnumerable<YieldInstruction> list, MonoBehaviour proxy = null)
	{
		IEnumerator enumerator = WaitForAllCoroutine(list);
		if (proxy != null)
		{
			return proxy.StartCoroutine(enumerator);
		}
		return StartCoroutine(enumerator);
	}

	public static Coroutine WaitForAll(YieldInstruction[] list)
	{
		return WaitForAll(list, null);
	}

	private static IEnumerator WaitForAllCoroutine(IEnumerable<YieldInstruction> list)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public static IEnumerator WaitForRealSeconds(float timeToWait)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
