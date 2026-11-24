using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.Utility;
using Kiloo.GameCenter;
using UnityEngine;

namespace Authentication.Internal;

public class NativeLogin
{
	private sealed class _003CLoginRoutine_003Ed__11(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public NativeLogin _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_00f0: Expected Obj, but got I4
				NativeLogin nativeLogin = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				Coroutine coroutine;
				if (nativeLogin._service != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					YieldInstruction[] list = default;
					coroutine = CoroutineUtil.WaitForAll(list);
				}
				else
				{
					coroutine = null;
				}
				obj = coroutine;
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

	private sealed class _003CLogoutRoutine_003Ed__12(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public NativeLogin _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_00f0: Expected Obj, but got I4
				NativeLogin nativeLogin = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				Coroutine coroutine;
				if (nativeLogin._service != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					YieldInstruction[] list = default;
					coroutine = CoroutineUtil.WaitForAll(list);
				}
				else
				{
					coroutine = null;
				}
				obj = coroutine;
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

	private const bool SIMULATE_IN_EDITOR = true;

	private readonly ILoginService _service;

	private bool isInitialized
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public bool isLoggedIn => _service != null;

	public string displayName
	{
		get
		{
			if (_service != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				string result = default;
				return result;
			}
			return null;
		}
	}

	public NativeLogin()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		GameCenterPlugin._GameCenterShowLoginView();
		object obj = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A068");
		object obj2 = default;
		obj = obj2;
	}

	public Coroutine LoginAsync()
	{
		string text = displayName;
		if (text != null)
		{
			string dataPath = Application.dataPath;
			if ((nint)dataPath == 8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			}
			Coroutine result = default;
			return result;
		}
		return (Coroutine)(object)string.Empty;
	}

	public Coroutine LogoutAsync()
	{
		IEnumerator list = LogoutRoutine();
		return CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private IEnumerator LoginRoutine()
	{
		IEnumerator list = ((AnimationPlayAfterDelay)this).PlayAnimationAfterDelay();
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private IEnumerator LogoutRoutine()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private static void Log(string msg, UnityEngine.Object obj = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		int stringLength = obj & 1;
		msg.m_stringLength = stringLength;
	}

	private static void LogError(string msg, UnityEngine.Object obj = null)
	{
	}
}
