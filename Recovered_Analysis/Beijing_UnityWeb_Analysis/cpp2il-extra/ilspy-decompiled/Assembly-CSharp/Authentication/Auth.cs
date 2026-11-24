using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using AppRefresh;
using Authentication.Internal;
using Cloud;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Backend;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Kiloo.GameCenter;
using Kiloo.Google.Internal;
using Kiloo.Monetization.FlurryPlugin;
using UnityEngine;

namespace Authentication;

public class Auth
{
	private class AuthResult
	{
		private bool success__BackingField;

		private Error error__BackingField;

		public bool success
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (byte)(int)error__BackingField != 0;
			}
			set
			{
				success__BackingField = value;
			}
		}

		public Error error
		{
			get
			{
				//IL_0019: Expected Obj, but got I4
				bool flag = success__BackingField;
				return (Error)flag;
			}
			set
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected I4, but got Unknown
				bool flag = (byte)(value & 1) != 0;
				success__BackingField = flag;
			}
		}

		public AuthResult()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public AuthResult result;

		internal void _003CInitRoutine_003Eb__0(bool success, Error error)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected Obj, but got Unknown
			//IL_0022: Expected Obj, but got I4
			result = (AuthResult)(object)error;
			object obj = this + 16;
			obj = success;
		}

		internal void _003CInitRoutine_003Eb__1(bool success, Error error)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected Obj, but got Unknown
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 12;
			obj = error;
			object obj3 = this + 8;
			obj3 = obj2;
		}
	}

	private sealed class _003CInitRoutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Auth _003C_003E4__this;

		private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Expected Obj, but got Unknown
				//IL_00a8: Expected Obj, but got I4
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Expected Obj, but got Unknown
				//IL_011f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0124: Expected Obj, but got Unknown
				//IL_012d: Expected Obj, but got I4
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Expected Obj, but got Unknown
				//IL_0170: Unknown result type (might be due to invalid IL or missing references)
				//IL_0175: Expected Obj, but got Unknown
				//IL_0193: Expected Obj, but got I4
				//IL_01a7: Expected Obj, but got I4
				//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b5: Expected Obj, but got Unknown
				//IL_03be: Expected Obj, but got I4
				//IL_0257: Expected Obj, but got I4
				//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0303: Expected Obj, but got Unknown
				//IL_0313: Unknown result type (might be due to invalid IL or missing references)
				//IL_0318: Expected Obj, but got Unknown
				//IL_0336: Expected Obj, but got I4
				//IL_034a: Expected Obj, but got I4
				Auth auth = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state != 3)
							{
								return null;
							}
							_003C_003E1__state = -1;
							_003C_003Ec__DisplayClass30_0 obj = _003C_003E8__1;
							AuthResult result = obj.result;
							if (~(result.success__BackingField ? 1u : 0u) == 0)
							{
								TransformExtensions.Reset((Transform)(object)auth.m_authenticatedEvent);
							}
						}
						else
						{
							_003C_003E1__state = -1;
							_003C_003Ec__DisplayClass30_0 obj2 = _003C_003E8__1;
							AuthResult result2 = obj2.result;
							if (~(result2.success__BackingField ? 1u : 0u) == 0)
							{
								TransformExtensions.Reset((Transform)(object)auth.m_authenticatedEvent);
							}
							else
							{
								_003C_003Ec__DisplayClass30_0 obj3 = _003C_003E8__1;
								AuthResult result3 = obj3.result;
								ErrorCategory errorCategory = Error.GetErrorCategory((string)(object)result3.error__BackingField);
								if (errorCategory == ErrorCategory.KilooAuth)
								{
									_003C_003Ec__DisplayClass30_0 obj4 = _003C_003E8__1;
									AuthResult result4 = obj4.result;
									Error error = result4.error__BackingField;
									object obj5 = error.code - 1014;
									if (error.code == 1014 || ((nint)obj5 != 1 && (nint)obj5 == 2))
									{
										auth._kilooAuth.Load();
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
										nint num = 0;
										string text = default;
										text.m_stringLength = (int)num;
										_ = 0;
										object obj6 = text + 16;
										obj6 = _003C_003E8__1;
										object obj7 = this + 12;
										bool flag = auth._kilooAuth.HasPlatform(text);
										obj7 = flag;
										_003C_003E1__state = 3;
										return 1;
									}
								}
							}
						}
						object obj8 = this + 20;
						obj8 = 0;
						return null;
					}
					_003C_003E1__state = -1;
					_003C_003E4__this._002Ector();
					string displayName = auth._native.displayName;
					if (displayName != null)
					{
						object obj9 = this + 20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj10 = default;
						obj9 = obj10;
						object obj11 = _003C_003E8__1 + 8;
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num2 = 0;
						string text2 = default;
						text2.m_stringLength = (int)num2;
						_ = 0;
						object obj12 = text2 + 16;
						obj12 = _003C_003E8__1;
						object obj13 = this + 12;
						bool flag2 = auth._kilooAuth.HasPlatform(text2);
						obj13 = flag2;
						_003C_003E1__state = 2;
						return 1;
					}
					auth._kilooAuth.Load();
					return null;
				}
				_003C_003E1__state = -1;
				object obj14 = this + 12;
				IEnumerator enumerator = _003C_003E4__this.LogoutAsync();
				obj14 = enumerator;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CInitRoutine_003Ed__30(int _003C_003E1__state)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 12;
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

	private sealed class _003CInitNativeAndLoginAsync_003Ed__31(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Auth _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e7: Expected Obj, but got Unknown
				//IL_0115: Expected Obj, but got I4
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Expected Obj, but got Unknown
				//IL_008f: Expected Obj, but got I4
				Auth auth = _003C_003E4__this;
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
				if (auth._native == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					bool flag = default;
					AppRefreshHandler.refreshInProgress = flag;
					object obj = auth + 8;
					obj = flag;
				}
				object obj2 = this + 12;
				Coroutine coroutine = auth._native.LogoutAsync();
				obj2 = coroutine;
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

	private sealed class _003CLogoutAsync_003Ed__32(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Auth _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0085: Expected Obj, but got Unknown
				//IL_00b3: Expected Obj, but got I4
				Auth auth = _003C_003E4__this;
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
				if (auth._native != null)
				{
					object obj = this + 12;
					IEnumerator enumerator = auth._native.LoginRoutine();
					obj = enumerator;
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

	private static Auth _instance;

	private const string DEFAULT_AUTH_BASE_URL = "https://auth.kiloo-games.com/";

	private const string ONLINESETTINGS_AUTH_URL_KEY = "kilooauth_url";

	private const string AUTH_FILENAME = "kilooauth";

	private const bool ALLOW_ANONYMOUS_IN_EDITOR = true;

	private NativeLogin _native;

	private KilooAuth _kilooAuth;

	private Action m_authenticatedEvent;

	private static Auth instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (Auth)CloudSave.DEBUG_MakeUserData();
		}
	}

	private bool allowAnonymous
	{
		get
		{
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj2 = default;
			object obj = obj2 + 32;
			obj = _native;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
	}

	public static string kilooTag
	{
		get
		{
			//IL_00f8: Expected I, but got Obj
			//IL_010e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			nint num = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = _instance == null;
			bool flag2 = !flag;
			string result = (string)(object)_instance;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (Il2CppClass<Authentication.Auth>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27 (Il2CppClass<Authentication.Auth>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = default;
				_instance = (Auth)(object)text;
				result = text;
			}
			return result;
		}
	}

	public static bool isInitialized
	{
		get
		{
			//IL_018a: Expected I, but got Obj
			//IL_01a0: Expected Obj, but got I
			//IL_0177: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_01ff: Expected Obj, but got I4
			//IL_012f: Expected I, but got Obj
			nint num = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = kilooTag;
			if (text.m_firstChar != '\0')
			{
				nint num3 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v21 (Il2CppClass<Authentication.Auth>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v42 (Il2CppClass<Authentication.Auth>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				KilooAuth kilooAuth = Auth.kilooAuth;
				if (kilooAuth != null)
				{
					nint num5 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<Authentication.Auth>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(Auth);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v38 (Il2CppClass<Authentication.Auth>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text2 = kilooTag;
					object obj4 = text2.m_firstChar + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v36+14]");
					return false;
				}
			}
			return (byte)(int)string.Empty != 0;
		}
	}

	public static bool isLoggedIn
	{
		get
		{
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = kilooTag;
			if (text.m_firstChar != '\0')
			{
				nint num3 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16 (Il2CppClass<Authentication.Auth>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v24 (Il2CppClass<Authentication.Auth>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = kilooTag;
				return text2.m_stringLength != 0;
			}
			return false;
		}
	}

	public static bool isAuthorized
	{
		get
		{
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0146: Expected Obj, but got I4
			//IL_0152: Expected I4, but got Obj
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (isLoggedIn)
			{
				nint num3 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<Authentication.Auth>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v23 (Il2CppClass<Authentication.Auth>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = kilooTag;
				string text2 = ((NativeLogin)text.m_stringLength).displayName;
				return (byte)(int)text2 != 0;
			}
			return false;
		}
	}

	public static KilooAuth kilooAuth
	{
		get
		{
			//IL_00f8: Expected I, but got Obj
			//IL_010e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0142: Expected Obj, but got I4
			//IL_015d: Expected Obj, but got I4
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (isLoggedIn)
			{
				nint num3 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<Authentication.Auth>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v24 (Il2CppClass<Authentication.Auth>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = kilooTag;
				bool flag = ((KilooAuth)text.m_firstChar).allowAnonymous;
				bool flag2 = (flag ? 1 : 0) == 2;
				return (KilooAuth)flag2;
			}
			return null;
		}
	}

	public static string displayName
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a6: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = kilooTag;
			return (string)text.m_firstChar;
		}
	}

	private unsafe event Action authenticatedEvent
	{
		add
		{
			//IL_014f: Expected I4, but got Obj
			//IL_014f: Expected I4, but got Obj
			//IL_016a: Expected Obj, but got I4
			//IL_0178: Expected I4, but got Obj
			//IL_0178: Expected I4, but got Obj
			//IL_001c: Expected Obj, but got I4
			//IL_002a: Expected I4, but got Obj
			//IL_002a: Expected I4, but got Obj
			//IL_004a: Expected Obj, but got I4
			//IL_0058: Expected I4, but got Obj
			//IL_0058: Expected I4, but got Obj
			//IL_0081: Expected I4, but got Obj
			//IL_0081: Expected I4, but got Obj
			//IL_0093: Expected Obj, but got I4
			//IL_00aa: Expected I4, but got Obj
			//IL_00aa: Expected I4, but got Obj
			//IL_00d3: Expected I4, but got Obj
			//IL_00d3: Expected I4, but got Obj
			//IL_00fc: Expected I4, but got Obj
			//IL_00fc: Expected I4, but got Obj
			//IL_0125: Expected I4, but got Obj
			//IL_0125: Expected I4, but got Obj
			bool flag = AppRefreshHandler.HasFlag((RefreshType)value, (RefreshType)"multiplier");
			TypeCode typeCode = (flag ? ((int*)1) : ((int*)null))->GetTypeCode();
			_native = (NativeLogin)typeCode;
			bool flag2 = AppRefreshHandler.HasFlag((RefreshType)value, (RefreshType)"highscore");
			TypeCode typeCode2 = (flag2 ? ((int*)1) : ((int*)null))->GetTypeCode();
			_kilooAuth = (KilooAuth)typeCode2;
			bool flag3 = AppRefreshHandler.HasFlag((RefreshType)value, (RefreshType)"keys");
			TypeCode typeCode3 = (flag3 ? ((int*)1) : ((int*)null))->GetTypeCode();
			this.m_authenticatedEvent = (Action)typeCode3;
			bool flag4 = AppRefreshHandler.HasFlag((RefreshType)value, (RefreshType)"upgrades");
			TypeCode typeCode4 = (flag4 ? ((int*)1) : ((int*)null))->GetTypeCode();
			bool flag5 = AppRefreshHandler.HasFlag((RefreshType)value, (RefreshType)"awards");
			float num = ((BinaryReader)flag5).ReadSingle();
			bool flag6 = AppRefreshHandler.HasFlag((RefreshType)value, (RefreshType)"characters");
			TypeCode typeCode5 = (flag6 ? ((int*)1) : ((int*)null))->GetTypeCode();
			bool flag7 = AppRefreshHandler.HasFlag((RefreshType)value, (RefreshType)"board");
			TypeCode typeCode6 = (flag7 ? ((int*)1) : ((int*)null))->GetTypeCode();
			bool flag8 = AppRefreshHandler.HasFlag((RefreshType)value, (RefreshType)"outfits");
			TypeCode typeCode7 = (flag8 ? ((int*)1) : ((int*)null))->GetTypeCode();
			bool flag9 = AppRefreshHandler.HasFlag((RefreshType)value, (RefreshType)"boardThemes");
			TypeCode typeCode8 = (flag9 ? ((int*)1) : ((int*)null))->GetTypeCode();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_authenticatedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action authenticated
	{
		add
		{
		}
		remove
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = kilooTag;
			((Auth)(object)text).authenticatedEvent -= value;
		}
	}

	public static Coroutine Init()
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(Auth);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<Authentication.Auth>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (isLoggedIn)
		{
			nint num3 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v18 (Il2CppClass<Authentication.Auth>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v26 (Il2CppClass<Authentication.Auth>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = kilooTag;
			return ((NativeLogin)text.m_stringLength).LoginAsync();
		}
		return (Coroutine)(object)string.Empty;
	}

	private IEnumerator InitRoutine()
	{
		return null;
	}

	private IEnumerator InitNativeAndLoginAsync()
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

	private IEnumerator LogoutAsync()
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

	private void InitKilooAuth()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Auth);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Authentication.Auth>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Auth);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Authentication.Auth>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string msg = kilooTag;
		Log(msg, (UnityEngine.Object)(object)this);
	}

	public static void DeleteKilooAuthDebug()
	{
		//IL_0263: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_03aa: Expected I, but got Obj
		//IL_03c0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_02df: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I4
		//IL_0337: Expected I, but got Obj
		//IL_034d: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v70 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(CloudSave._mayQueueCelebration ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v25 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v66 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UserSave.introductionPopupShownCount == 0)
			{
				nint num5 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v33 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v62 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UserSave.introductionPopupShownCount = 1;
				nint num7 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v39 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v58 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag).QueuePopup("CloudSaveCelebrationPopup");
				nint num9 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v46 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v52 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CloudSave._mayQueueCelebration = false;
			}
		}
		nint num11 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v15 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v20 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSave.errorState = CloudSaveErrorState.Unauthenticated;
	}

	private static void Log(string msg, UnityEngine.Object obj = null)
	{
		//IL_0030: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+10]");
		Delegate obj2 = (Delegate)0;
		object obj5 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)obj);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj4 = msg + 16;
			if (obj4 == obj2)
			{
				obj4 = obj5;
			}
			if (obj4 != obj2)
			{
				obj2 = (Delegate)obj4;
				continue;
			}
			break;
		}
	}

	private static void LogError(string msg, UnityEngine.Object obj = null)
	{
	}

	public Auth()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02d3: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_0326: Expected I, but got Obj
		//IL_033c: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0375: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_013a: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01f4: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_0235: Expected I, but got Obj
		if (_kilooAuth != null)
		{
			return;
		}
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v61 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v5 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num4 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v27 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot(cachePath, "kilooauth");
		nint num5 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v18 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num6 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v57 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		bool value = ((OnlineSettings)(object)saveDataPath).GetValue("kilooauth_url", (byte)(int)"https://auth.kiloo-games.com/" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri.CreateThisFromUri((Uri)value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		KilooAuth kilooAuth = default;
		IEnumerable<IKilooAuthPlatform> platforms = default;
		kilooAuth._002Ector(uri, (string)flag, allowAnonymous: false, (IJsonSerializer)(object)text, platforms);
		object obj3 = this + 12;
		obj3 = kilooAuth;
		IGoogleSignInBridge googleSignInBridge = GoogleSignInBridgeFactory.Create();
		if (googleSignInBridge != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string platformKey = default;
			_kilooAuth.RemovePlatform(platformKey);
		}
		nint num7 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v43 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v51 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (GameCenterPlugin.hasLoginView)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string platformKey2 = default;
			_kilooAuth.RemovePlatform(platformKey2);
		}
	}

	static Auth()
	{
		//IL_015f: Expected I, but got Obj
		//IL_0175: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_01f7: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I4
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v27 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string cachePath = DeviceUtility.GetCachePath();
			nint num5 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v7 (Il2CppClass<System.IO.Path>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v16 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Path.SameRoot(cachePath, "kilooauth");
			if (File.GetAttributes((string)flag) != 0)
			{
				((FileStream)flag).ExposeHandle();
			}
		}
		else
		{
			SDebug.LogFormat("DEBUG is not enabled - you cannot delete files with current project settings!", null);
		}
	}
}
