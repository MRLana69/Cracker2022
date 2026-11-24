using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Cloud;
using Kiloo.GameCenter;
using UnityEngine;

namespace Authentication.Internal;

public class GameCenterLogin : ILoginService
{
	private sealed class _003CLogin_003Ed__10(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterLogin _003C_003E4__this;

		private float _003Ctimeout_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0090: Expected I, but got Obj
				//IL_00a6: Expected Obj, but got I
				//IL_02f8: Expected I, but got Obj
				//IL_030e: Expected Obj, but got I
				//IL_00d1: Expected I, but got Obj
				//IL_0336: Unknown result type (might be due to invalid IL or missing references)
				//IL_033b: Expected Obj, but got Unknown
				//IL_0175: Expected I, but got Obj
				//IL_01c2: Expected I, but got Obj
				//IL_01d8: Expected Obj, but got I
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				//IL_0145: Expected Obj, but got Unknown
				//IL_014e: Expected Obj, but got I4
				//IL_0162: Expected Obj, but got I4
				//IL_037f: Expected I, but got Obj
				//IL_0395: Expected Obj, but got I
				//IL_0203: Expected I, but got Obj
				//IL_0250: Expected I, but got Obj
				GameCenterLogin gameCenterLogin = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					float unscaledTime = Time.unscaledTime;
					float num = _003Ctimeout_003E5__2 + unscaledTime;
					_003Ctimeout_003E5__2 = num;
				}
				else
				{
					_003C_003E1__state = -1;
					_003Ctimeout_003E5__2 = 0f;
				}
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num3 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v62 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!GameCenterPlugin.ArePhotosSupported() && _003Ctimeout_003E5__2 < 5f)
				{
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				nint num4 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v21 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v51 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (GameCenterPlugin.initialAuthenticationComplete)
				{
					nint num6 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v31 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num7 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v47 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					GameCenterPlugin._002Ecctor();
					nint num8 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v40 (Il2CppClass<Flurry>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num9 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v43 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
				}
				object obj6 = _003C_003E4__this + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v9+D]");
				bool isConsideredLoggedIn = (nint)0 != 0;
				gameCenterLogin._isConsideredLoggedIn = isConsideredLoggedIn;
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

	private sealed class _003CLogout_003Ed__11(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterLogin _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Expected Obj, but got Unknown
				//IL_007a: Expected Obj, but got I4
				//IL_008e: Expected Obj, but got I4
				GameCenterLogin gameCenterLogin = _003C_003E4__this;
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
				gameCenterLogin._isConsideredLoggedIn = false;
				object obj = this + 12;
				obj = 0;
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

	private const float LOGIN_TIMEOUT = 5f;

	private GameCenterPlugin.LocalPlayer _user;

	private bool _isConsideredLoggedIn;

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
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			//IL_0046: Expected Obj, but got I4
			if (~(_isConsideredLoggedIn ? 1u : 0u) == 0)
			{
				object obj = this + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v6+D]");
				bool flag = (nint)0 != 0;
				return (string)flag;
			}
			return null;
		}
	}

	public string alias
	{
		get
		{
			//IL_002e: Expected Obj, but got I4
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0020: Expected Obj, but got I
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected Obj, but got Unknown
			//IL_004e: Expected Obj, but got I
			object obj2;
			if (~(_isConsideredLoggedIn ? 1u : 0u) == 0)
			{
				object obj = this + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18+D]");
				obj2 = 0;
			}
			else
			{
				obj2 = 0;
			}
			if (obj2 != null)
			{
				object obj3 = this + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v14+8]");
				return (string)0;
			}
			return string.Empty;
		}
	}

	public IEnumerator Login()
	{
		//IL_002e: Expected Obj, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		object obj2;
		if (~(_isConsideredLoggedIn ? 1u : 0u) == 0)
		{
			object obj = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18+D]");
			obj2 = 0;
		}
		else
		{
			obj2 = 0;
		}
		if (obj2 != null)
		{
			object obj3 = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v14+4]");
			return (IEnumerator)0;
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

	private void OnAuthenticateHandler(bool view, string error)
	{
		//IL_01c7: Expected Obj, but got I4
		//IL_01b7: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		string file = ((CloudWorkingCopy)this).GetFile((ICloudItem)view);
		if (file != null)
		{
			bool flag = error == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj = default;
			bool flag2 = obj == null;
			object obj2 = flag | flag2;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				IDictionary<string, string> dict = default;
				ICloudUserData cloudUserData = CloudUserDataExtensions.ToUserData(dict);
				Dictionary<string, string>.ValueCollection values = ((Dictionary<string, string>)cloudUserData).Values;
				string[] array = Enumerable.ToArray(values);
				ICloudUserData cloudUserData2 = CloudUserDataExtensions.ToUserData((IDictionary<string, string>)(object)error);
				Dictionary<string, string>.ValueCollection values2 = ((Dictionary<string, string>)cloudUserData2).Values;
				string[] array2 = Enumerable.ToArray(values2);
				object obj3 = array + 12;
				if ((nint)obj3 == array2.Length)
				{
					object obj4 = 1;
					object obj5 = obj3;
					object obj6 = default;
					object obj9 = default;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
					{
						object obj7 = array + 16;
						object obj8 = obj9 << 2;
						object obj10 = obj7 + obj8;
						object obj11 = array2 + 16;
						object obj12 = obj9 << 2;
						object obj13 = obj11 + obj12;
						bool flag3 = (string)obj10 != (string)obj13;
						object obj14 = obj4 & flag3;
						obj6 = obj9 + 1;
						obj4 = obj14;
						obj5 = obj3;
					}
					if (obj4 != null)
					{
						return;
					}
				}
			}
		}
		((CloudConflictResolver)this)._002Ector((object)view, (IntPtr)error);
	}
}
