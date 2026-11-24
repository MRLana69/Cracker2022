using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Managers;
using Kiloo.GameCenter;
using Kiloo.Google;
using UnityEngine;

namespace Authentication.Internal;

public class GoogleLogin : ILoginService
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public GoogleSignInPluginRequest requestResult;

		public _003C_003Ec__DisplayClass8_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CLogin_003Eb__0(GoogleSignInPluginRequest result)
		{
			requestResult = result;
		}

		internal void _003CLogin_003Eb__1(GoogleSignInPluginRequest result)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = result;
		}
	}

	private sealed class _003CLogin_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleLogin _003C_003E4__this;

		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Expected Obj, but got Unknown
				//IL_00a6: Expected Obj, but got I4
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Expected Obj, but got Unknown
				//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e1: Expected Obj, but got Unknown
				//IL_011c: Expected Obj, but got I4
				//IL_0188: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Expected Obj, but got Unknown
				//IL_0196: Expected Obj, but got I4
				//IL_0234: Expected I, but got Obj
				//IL_024a: Expected Obj, but got I
				//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Expected Obj, but got Unknown
				//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d6: Expected Obj, but got Unknown
				//IL_020c: Expected Obj, but got I4
				//IL_0275: Expected I, but got Obj
				GoogleLogin googleLogin = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							nint num = (nint)typeof(Flurry);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v72 (Il2CppClass<Flurry>)+BA]");
							object obj = (nint)0 & (nint)0x200;
							if (obj != null)
							{
								nint num2 = (nint)typeof(Flurry);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v77 (Il2CppClass<Flurry>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass8_0 obj2 = _003C_003E8__1;
					GoogleSignInPluginRequest requestResult = obj2.requestResult;
					if (requestResult.errorCode__BackingField != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						GoogleSignInPluginRequest googleSignInPluginRequest = default;
						googleSignInPluginRequest.silent__BackingField = false;
						object obj3 = _003C_003E8__1 + 8;
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num3 = 0;
						_ = 0;
						Action<GoogleSignInPluginRequest> action = default;
						object obj4 = action + 16;
						obj4 = _003C_003E8__1;
						object obj5 = this + 12;
						Coroutine coroutine = googleLogin._google.SignOut(googleSignInPluginRequest, action);
						obj5 = coroutine;
						_003C_003E1__state = 2;
						return 1;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj6 = this + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj7 = default;
				obj6 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				GoogleSignInPluginRequest googleSignInPluginRequest2 = default;
				googleSignInPluginRequest2.silent__BackingField = true;
				object obj8 = _003C_003E8__1 + 8;
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num4 = 0;
				_ = 0;
				Action<GoogleSignInPluginRequest> action2 = default;
				object obj9 = action2 + 16;
				obj9 = _003C_003E8__1;
				object obj10 = this + 12;
				Coroutine coroutine2 = googleLogin._google.SignOut(googleSignInPluginRequest2, action2);
				obj10 = coroutine2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CLogin_003Ed__8(int _003C_003E1__state)
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<GoogleSignInPluginRequest> _003C_003E9__9_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			BoardManager._003C_003Ec obj = default;
			BoardManager._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CLogout_003Eb__9_0(GoogleSignInPluginRequest result)
		{
		}
	}

	private sealed class _003CLogout_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleLogin _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004c: Expected I, but got Obj
				//IL_0062: Expected Obj, but got I
				//IL_0247: Unknown result type (might be due to invalid IL or missing references)
				//IL_024c: Expected Obj, but got Unknown
				//IL_0282: Expected Obj, but got I4
				//IL_008d: Expected I, but got Obj
				//IL_00da: Expected I, but got Obj
				//IL_00f0: Expected Obj, but got I
				//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fa: Expected Obj, but got Unknown
				//IL_0211: Expected I, but got Obj
				//IL_0227: Expected Obj, but got I
				//IL_011b: Expected I, but got Obj
				GoogleLogin googleLogin = _003C_003E4__this;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v17 (Il2CppClass<Authentication.Internal.GoogleLogin+<>c>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v57 (Il2CppClass<Authentication.Internal.GoogleLogin+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = _003C_003Ec._003C_003E9__9_0 == null;
				bool flag2 = !flag;
				Action<GoogleSignInPluginRequest> onComplete = _003C_003Ec._003C_003E9__9_0;
				if (!flag2)
				{
					nint num3 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v31 (Il2CppClass<Authentication.Internal.GoogleLogin+<>c>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v51 (Il2CppClass<Authentication.Internal.GoogleLogin+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = 0;
					_ = 0;
					Action<GoogleSignInPluginRequest> action = default;
					object obj3 = action + 16;
					obj3 = _003C_003Ec._003C_003E9;
					nint num6 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v48 (Il2CppClass<Authentication.Internal.GoogleLogin+<>c>)+5C]");
					object obj4 = (nint)0 + (nint)4;
					obj4 = action;
					onComplete = action;
				}
				object obj5 = this + 12;
				GoogleSignInPluginRequest request = default;
				IEnumerator enumerator = googleLogin._google.SignInCoroutine(request, onComplete);
				obj5 = enumerator;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CLogout_003Ed__9(int _003C_003E1__state)
		{
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

	private GoogleSignInPlugin _google;

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
	}

	public string displayName
	{
		get
		{
			//IL_004f: Expected Obj, but got I4
			GoogleSignInPlugin google = _google;
			if (~(google.profileIsUpdated__BackingField ? 1u : 0u) == 0)
			{
				GoogleSignInPlugin google2 = _google;
				bool flag = google2.profile__BackingField != null;
				return (string)flag;
			}
			return null;
		}
	}

	public string alias
	{
		get
		{
			GoogleSignInPlugin google = _google;
			IGoogleProfile googleProfile;
			if (~(google.profileIsUpdated__BackingField ? 1u : 0u) == 0)
			{
				GoogleSignInPlugin google2 = _google;
				googleProfile = google2.profile__BackingField;
			}
			else
			{
				googleProfile = null;
			}
			if (googleProfile != null)
			{
				GoogleSignInPlugin google3 = _google;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				string result = default;
				return result;
			}
			return string.Empty;
		}
	}

	public unsafe GoogleLogin()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		GameCenterPlugin.AuthenticateHandler authenticateHandler = default;
		((Delegate)authenticateHandler).method_ptr = method_ptr;
		((Delegate)authenticateHandler).method = (nint)__ldftn(GameCenterLogin.OnAuthenticateHandler);
		object obj = authenticateHandler + 16;
		obj = this;
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v18 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameCenterPlugin.authenticationEvent -= authenticateHandler;
		GameCenterPlugin.ShowLoginView();
	}

	public IEnumerator Login()
	{
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
