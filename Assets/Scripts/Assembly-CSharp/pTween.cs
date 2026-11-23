using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class pTween
{
	private sealed class _003CTo_003Ed__0(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public Action<float> callback;

		public float startValue;

		public float endValue;

		private float _003Cend_003E5__2;

		private float _003CdurationInv_003E5__3;

		private float _003CstartMulDurationInv_003E5__4;

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
					goto IL_0147;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				float time = Time.time;
				float num = time + duration;
				_003Cend_003E5__2 = num;
				float num2 = time / duration;
				_003CstartMulDurationInv_003E5__4 = num2;
				float num3 = 1f / duration;
				_003CdurationInv_003E5__3 = num3;
			}
			float time2 = Time.time;
			Action<float> action = callback;
			if (!(time2 < _003Cend_003E5__2))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S0_v7 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
				goto IL_0147;
			}
			float num4 = endValue - startValue;
			float num5 = time2 * _003CdurationInv_003E5__3;
			float num6 = num5 - _003CstartMulDurationInv_003E5__4;
			float num7 = Math.Min(num6, 1f);
			bool flag = num6 < 0f;
			float num8 = 0f;
			if (!flag)
			{
				num8 = num7;
			}
			float num9 = num4 * num8;
			float num10 = startValue + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S0_v7 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0147:
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

	private sealed class _003CRealtimeTo_003Ed__1(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public Action<float> callback;

		public float startValue;

		public float endValue;

		private float _003Cend_003E5__2;

		private float _003CdurationInv_003E5__3;

		private float _003CstartMulDurationInv_003E5__4;

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
					goto IL_0147;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				float num = realtimeSinceStartup + duration;
				_003Cend_003E5__2 = num;
				float num2 = realtimeSinceStartup / duration;
				_003CstartMulDurationInv_003E5__4 = num2;
				float num3 = 1f / duration;
				_003CdurationInv_003E5__3 = num3;
			}
			float realtimeSinceStartup2 = Time.realtimeSinceStartup;
			Action<float> action = callback;
			if (!(realtimeSinceStartup2 < _003Cend_003E5__2))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S0_v7 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
				goto IL_0147;
			}
			float num4 = endValue - startValue;
			float num5 = realtimeSinceStartup2 * _003CdurationInv_003E5__3;
			float num6 = num5 - _003CstartMulDurationInv_003E5__4;
			float num7 = Math.Min(num6, 1f);
			bool flag = num6 < 0f;
			float num8 = 0f;
			if (!flag)
			{
				num8 = num7;
			}
			float num9 = num4 * num8;
			float num10 = startValue + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S0_v7 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0147:
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

	public static IEnumerator To(float duration, float startValue, float endValue, Action<float> callback)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public static IEnumerator RealtimeTo(float duration, float startValue, float endValue, Action<float> callback)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public static IEnumerator To(float duration, Action<float> callback)
	{
		return To(duration, 0f, 1f, callback);
	}
}
