using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Automation;
using SYBO.Common.Utility;
using UnityEngine;

namespace SYBO.Common.Benchmarking.Utility;

public class LastMonobehaviour : SubscribableMonobehaviour
{
	private sealed class _003CFixedUpdateCoroutine_003Ed__3(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public LastMonobehaviour _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Expected Obj, but got Unknown
				//IL_00cf: Expected Obj, but got I4
				LastMonobehaviour lastMonobehaviour = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					if (lastMonobehaviour.OnYieldFixedUpdate != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
					}
				}
				else
				{
					_003C_003E1__state = -1;
				}
				object obj = this + 12;
				obj = lastMonobehaviour._fixedUpdateYield;
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

	public Action OnYieldFixedUpdate;

	private YieldInstruction _fixedUpdateYield;

	private void Awake()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private IEnumerator FixedUpdateCoroutine()
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0148: Expected Obj, but got I4
		//IL_0151: Expected Obj, but got I4
		//IL_0014: Expected Obj, but got I
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_0067: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I
		//IL_01d9: Expected Obj, but got I4
		List<string> list = ((BenchmarkMetric<int>)(object)this).Serialize();
		object obj2 = default;
		object obj = obj2 + 4;
		obj = int.MaxValue;
		obj2 = 0;
		int num = 0;
		int num2 = int.MaxValue;
		int num4 = default;
		int num11 = default;
		while (true)
		{
			IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			int num3 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v10 (System.IntPtr)+C]");
			if ((nint)num3 >= (nint)0)
			{
				break;
			}
			int num5 = ((List<int>)(nint)((UnityEngine.Object)this).m_CachedPtr).get_Item(num4);
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v36 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num8;
			if (num2 < num5)
			{
				num8 = num2;
			}
			else
			{
				num2 = num5;
				num8 = num5;
			}
			obj = num8;
			int num9 = ((List<int>)(nint)((UnityEngine.Object)this).m_CachedPtr).get_Item(num4);
			int num10;
			if (num > num9)
			{
				num10 = num;
			}
			else
			{
				num = num9;
				num10 = num9;
			}
			obj2 = num10;
			num4 = num11 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string item = default;
		list.Add(item);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string item2 = default;
		list.Add(item2);
		return (IEnumerator)list;
	}

	public LastMonobehaviour()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I4
		object obj = this + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		obj = obj2;
		bool isRunning = ((AutomationController)(object)this).IsRunning;
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)isRunning);
	}
}
