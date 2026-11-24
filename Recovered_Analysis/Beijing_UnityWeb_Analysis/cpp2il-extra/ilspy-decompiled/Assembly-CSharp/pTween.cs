using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;

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

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0114: Expected I, but got Obj
				//IL_012a: Expected Obj, but got I
				//IL_0208: Unknown result type (might be due to invalid IL or missing references)
				//IL_020d: Expected Obj, but got Unknown
				//IL_0216: Expected Obj, but got I4
				//IL_022a: Expected Obj, but got I4
				//IL_0155: Expected I, but got Obj
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
					float timeSinceLevelLoad = Time.timeSinceLevelLoad;
					float num = timeSinceLevelLoad + duration;
					_003Cend_003E5__2 = num;
					float num2 = 1f / duration;
					_003CdurationInv_003E5__3 = num2;
					float num3 = timeSinceLevelLoad / duration;
					_003CstartMulDurationInv_003E5__4 = num3;
				}
				float timeSinceLevelLoad2 = Time.timeSinceLevelLoad;
				if (!(timeSinceLevelLoad2 < _003Cend_003E5__2))
				{
					callback(endValue);
					return null;
				}
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v22 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v31 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num6 = timeSinceLevelLoad2 * _003CdurationInv_003E5__3;
				float t = num6 - _003CstartMulDurationInv_003E5__4;
				float obj2 = Mathf.LerpUnclamped(startValue, endValue, t);
				callback(obj2);
				object obj3 = this + 12;
				obj3 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

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

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0114: Expected I, but got Obj
				//IL_012a: Expected Obj, but got I
				//IL_0208: Unknown result type (might be due to invalid IL or missing references)
				//IL_020d: Expected Obj, but got Unknown
				//IL_0216: Expected Obj, but got I4
				//IL_022a: Expected Obj, but got I4
				//IL_0155: Expected I, but got Obj
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
					float num = maxDelay + duration;
					_003Cend_003E5__2 = num;
					float num2 = 1f / duration;
					_003CdurationInv_003E5__3 = num2;
					float num3 = maxDelay / duration;
					_003CstartMulDurationInv_003E5__4 = num3;
				}
				float maxDelay2 = NetworkServer.maxDelay;
				if (!(maxDelay2 < _003Cend_003E5__2))
				{
					callback(endValue);
					return null;
				}
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v22 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v31 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num6 = maxDelay2 * _003CdurationInv_003E5__3;
				float t = num6 - _003CstartMulDurationInv_003E5__4;
				float obj2 = Mathf.LerpUnclamped(startValue, endValue, t);
				callback(obj2);
				object obj3 = this + 12;
				obj3 = 0;
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

	public static IEnumerator To(float duration, float startValue, float endValue, Action<float> callback)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public static IEnumerator RealtimeTo(float duration, float startValue, float endValue, Action<float> callback)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = callback;
		return enumerator;
	}

	public static IEnumerator To(float duration, Action<float> callback)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public pTween()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
