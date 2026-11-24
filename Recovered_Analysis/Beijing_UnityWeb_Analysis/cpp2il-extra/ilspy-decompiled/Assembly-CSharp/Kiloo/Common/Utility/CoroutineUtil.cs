using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Ionic.Crc;
using Kiloo.Common.Extensions;
using UnityEngine;
using UnityEngine.Networking;

namespace Kiloo.Common.Utility;

public static class CoroutineUtil
{
	private sealed class _003CWaitForAllCoroutine_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public IEnumerable<YieldInstruction> list;

		private IEnumerator<YieldInstruction> _003C_003E7__wrap1;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Expected Obj, but got Unknown
				//IL_0104: Unknown result type (might be due to invalid IL or missing references)
				//IL_0109: Expected Obj, but got Unknown
				//IL_0112: Expected Obj, but got I4
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Expected Obj, but got Unknown
				//IL_00e5: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 16;
				obj2 = obj;
				_ = -1;
				if (_003C_003E1__state != 0)
				{
					object result = default;
					if (_003C_003E1__state != 1)
					{
						return result;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj3 = this + 20;
					object obj4 = default;
					obj3 = obj4;
				}
				_003C_003E1__state = -3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj5 = default;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj6 = this + 12;
					object obj7 = default;
					obj6 = obj7;
					_003C_003E1__state = 1;
					return 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj8 = this + 20;
				obj8 = 0;
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0072: Expected Obj, but got I
			//IL_0082: Expected Obj, but got I
			//IL_00a2: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I
			int num = _003C_003E1__state + 1;
			_003C_003E1__state = num;
			object obj = _003C_003E2__current;
			int num2 = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v5 (System.Object)+8]");
			if ((nint)num2 >= (nint)0)
			{
				object obj2 = _003C_003E2__current;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7 (System.Object)+C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+8]");
				object obj4 = 0;
				_ = 0;
				object obj5 = _003C_003E2__current;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v11 (System.Object)+C]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v12+C]");
				TransformExtensions.Reset((Transform)0);
			}
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

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Expected Obj, but got I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected Obj, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I4
			//IL_015b: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = _003C_003E1__state - -3;
			if (_003C_003E1__state != -3 && ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 != 4))
			{
				return;
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 26;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 26)
			{
				object obj10 = obj + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
			}
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
		}
	}

	private sealed class _003CWaitForRealSeconds_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float timeToWait;

		private float _003Cstart_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Expected Obj, but got Unknown
				//IL_00d7: Expected Obj, but got I4
				//IL_00eb: Expected Obj, but got I4
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
					float maxDelay = NetworkServer.maxDelay;
					_003Cstart_003E5__2 = maxDelay;
				}
				float maxDelay2 = NetworkServer.maxDelay;
				float num = _003Cstart_003E5__2 + timeToWait;
				if (maxDelay2 < num)
				{
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
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

	private sealed class _003CExecuteActionNextFrame_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Action action;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0065: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj2 = default;
				obj = obj2;
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

	private static MonoBehaviour _coroutineRunner;

	public static Coroutine StartCoroutine(IEnumerator coroutine)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CRC32 cRC = default;
		cRC.Reset();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A91");
		Coroutine result = default;
		return result;
	}

	public static void StopCoroutine(IEnumerator coroutine)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[BsonFileSaver] ", (int)coroutine);
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

	public static void StopCoroutine(Coroutine coroutine)
	{
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = coroutine == null;
		int num3 = ((ComputeShader)(object)_coroutineRunner).FindKernel((string)null);
		int num4 = num3 ^ 1;
		if (((flag ? 1u : 0u) | (uint)num4) == 0)
		{
			_coroutineRunner.StopCoroutine(coroutine);
		}
	}

	public static Coroutine WaitForAll(IEnumerable<YieldInstruction> list, MonoBehaviour proxy = null)
	{
		//IL_004f: Expected Obj, but got I4
		if ((object)proxy != null)
		{
			Encoding encoding = (Encoding)(object)proxy;
		}
		else
		{
			Encoding encoding = Encoding.UTF32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		byte[] data = default;
		return (Coroutine)Checksum.ComputeCrc32(data);
	}

	public static Coroutine WaitForAll(YieldInstruction[] list)
	{
		//IL_003f: Expected I, but got Obj
		//IL_0055: Expected Obj, but got I
		//IL_001d: Expected I4, but got Obj
		//IL_0080: Expected I, but got Obj
		//IL_00d7: Expected I4, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_0154: Expected I, but got Obj
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Exception ex = default;
			ex.SetErrorCode((int)"CoroutineUtil.StartCoroutine must be in play mode (or objects will leak)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_coroutineRunner != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"CoroutineRunner";
			NewMonoBehaviour coroutineRunner = gameObject.AddComponent<NewMonoBehaviour>();
			_coroutineRunner = coroutineRunner;
			string tag = _coroutineRunner.tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)tag).Exec();
		}
		return _coroutineRunner.StartCoroutine_Auto((IEnumerator)(object)list);
	}

	private static IEnumerator WaitForAllCoroutine(IEnumerable<YieldInstruction> list)
	{
		//IL_000e: Expected Obj, but got I4
		return (IEnumerator)Depository.CheckIn(list, null);
	}

	public static IEnumerator WaitForRealSeconds(float timeToWait)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		throw new ArrayTypeMismatchException();
	}

	public static IEnumerator ExecuteActionNextFrame(Action action)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = action;
		return enumerator;
	}
}
