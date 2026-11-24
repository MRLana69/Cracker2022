using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.Utility;

namespace Authentication.Internal;

public class EditorLogin : ILoginService
{
	private sealed class _003CLogin_003Ed__13(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public EditorLogin _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Expected Obj, but got I4
				//IL_0077: Expected Obj, but got I4
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Expected Obj, but got Unknown
				//IL_00be: Expected Obj, but got I4
				object obj = 0;
				EditorLogin editorLogin = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						editorLogin.isLoggedIn__BackingField = true;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				int num = Util.ConvertTimeoutToMilliseconds(1f);
				obj = num;
				object obj2 = this + 12;
				object obj3 = obj;
				_ = 1;
				IEnumerator enumerator = ((Wait.Config)obj).WaitCoroutine();
				obj2 = enumerator;
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

	private sealed class _003CLogout_003Ed__14(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public EditorLogin _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Expected Obj, but got I4
				//IL_0077: Expected Obj, but got I4
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0082: Expected Obj, but got Unknown
				//IL_00be: Expected Obj, but got I4
				object obj = 0;
				EditorLogin editorLogin = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						editorLogin.isLoggedIn__BackingField = false;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				int num = Util.ConvertTimeoutToMilliseconds(0.5f);
				obj = num;
				object obj2 = this + 12;
				object obj3 = obj;
				_ = 1;
				IEnumerator enumerator = ((Wait.Config)obj).WaitCoroutine();
				obj2 = enumerator;
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

	private const float SIMULATED_LOGIN_TIME = 1f;

	private const float SIMULATED_LOGOUT_TIME = 0.5f;

	private const bool SIMULATE_LOGIN_FAIL = false;

	private const string SIMULATED_USER_NAME = "EditorUser";

	private const string SIMULATED_USER_ALIAS = "EditorAlias";

	private bool isLoggedIn__BackingField;

	public bool isLoggedIn
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
		private set
		{
			//IL_0010: Expected I4, but got Obj
			//IL_0021: Expected Obj, but got I4
			string msg = string.ConcatArray((string[])(object)"[Auth] ", (int)this);
			SDebug.LogFormat(msg, (object[])value);
		}
	}

	public string displayName
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = isLoggedIn__BackingField;
			return (string)flag;
		}
	}

	public string alias
	{
		get
		{
			if (~(isLoggedIn__BackingField ? 1u : 0u) == 0)
			{
				return "EditorUser";
			}
			return string.Empty;
		}
	}

	public IEnumerator Login()
	{
		if (~(isLoggedIn__BackingField ? 1u : 0u) == 0)
		{
			return (IEnumerator)(object)"EditorAlias";
		}
		return (IEnumerator)(object)string.Empty;
	}

	public IEnumerator Logout()
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
}
