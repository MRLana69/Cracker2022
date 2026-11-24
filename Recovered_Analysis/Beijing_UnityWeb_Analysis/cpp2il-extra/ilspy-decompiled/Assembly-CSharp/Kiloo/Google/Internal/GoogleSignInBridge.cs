using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Plugins.Facebook;
using UnityEngine;

namespace Kiloo.Google.Internal;

internal abstract class GoogleSignInBridge : MonoBehaviour, IGoogleSignInBridge, IDisposable
{
	private class ConnectResult : IGoogleConnectResult
	{
		private string errorMessage__BackingField;

		private int errorCode__BackingField;

		public string errorMessage
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return (string)errorCode__BackingField;
			}
			set
			{
				errorMessage__BackingField = value;
			}
		}

		public int errorCode
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (int)errorMessage__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0013: Expected Obj, but got I4
				object obj = this + 8;
				obj = value;
			}
		}

		public ConnectResult()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	[Serializable]
	private class SignInResultReceivedPayload
	{
		public ProfilePayload profile;

		public string errorMessage;

		public int errorCode;
	}

	[Serializable]
	private class ProfilePayload
	{
		public string displayName;

		public string photoUrl;

		public string idToken;

		public string userId;
	}

	[Serializable]
	private class ConnectionSuspendedPayload
	{
		public int cause;
	}

	[Serializable]
	private class ConnectionFailedPayload
	{
		public string errorMessage;

		public int errorCode;
	}

	private class GoogleSignInResult : IGoogleSignInResult
	{
		private IGoogleProfile profile__BackingField;

		private string errorMessage__BackingField;

		public IGoogleProfile profile
		{
			get
			{
				return (IGoogleProfile)(object)errorMessage__BackingField;
			}
			set
			{
				errorMessage__BackingField = (string)(object)value;
			}
		}

		public string errorMessage
		{
			get
			{
				return (string)(object)profile__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 8;
				obj = value;
			}
		}

		public int errorCode
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (int)errorMessage__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0013: Expected Obj, but got I4
				object obj = this + 12;
				obj = value;
			}
		}
	}

	private class GoogleProfile : IGoogleProfile
	{
		private string displayName__BackingField;

		private string photoUrl__BackingField;

		private string idToken__BackingField;

		public string displayName
		{
			get
			{
				return idToken__BackingField;
			}
			set
			{
				idToken__BackingField = value;
			}
		}

		public string photoUrl
		{
			get
			{
				return displayName__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 8;
				obj = value;
			}
		}

		public string idToken
		{
			get
			{
				return photoUrl__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 12;
				obj = value;
			}
		}

		public string userId
		{
			get
			{
				return idToken__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 16;
				obj = value;
			}
		}
	}

	private sealed class _003CConnectCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleSignInBridgeRequest<IGoogleConnectResult> request;

		public GoogleSignInBridge _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Expected Obj, but got Unknown
				//IL_00c0: Expected Obj, but got I4
				//IL_0155: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Expected Obj, but got Unknown
				//IL_0163: Expected Obj, but got I4
				//IL_0177: Expected Obj, but got I4
				//IL_01de: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e3: Expected Obj, but got Unknown
				//IL_0249: Unknown result type (might be due to invalid IL or missing references)
				//IL_024e: Expected Obj, but got Unknown
				//IL_0257: Expected Obj, but got I4
				//IL_026b: Expected Obj, but got I4
				//IL_022b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Expected Obj, but got Unknown
				//IL_0239: Expected Obj, but got I4
				GoogleSignInBridge googleSignInBridge = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest = request;
							if (~(googleSignInBridgeRequest.canceled ? 1u : 0u) == 0)
							{
								GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest2 = request;
								googleSignInBridgeRequest2.done = true;
							}
							goto IL_01fc;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest3 = request;
					googleSignInBridgeRequest3.done = false;
					GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest4 = request;
					googleSignInBridgeRequest4.canceled = false;
					object obj = request + 12;
					obj = 0;
				}
				if (googleSignInBridge._pendingConnectRequest != null)
				{
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				if (~(googleSignInBridge._connectionIsSuspended ? 1u : 0u) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj3 = default;
					if (obj3 == null)
					{
						object obj4 = googleSignInBridge + 16;
						obj4 = request;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
						goto IL_01fc;
					}
				}
				GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest5 = request;
				googleSignInBridgeRequest5.canceled = true;
				GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest6 = request;
				googleSignInBridgeRequest6.done = true;
				return null;
				IL_01fc:
				GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest7 = request;
				if (~(googleSignInBridgeRequest7.done ? 1u : 0u) == 0)
				{
					object obj5 = googleSignInBridge + 16;
					obj5 = 0;
					return null;
				}
				object obj6 = this + 12;
				obj6 = 0;
				_003C_003E1__state = 2;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CConnectCoroutine_003Ed__13(int _003C_003E1__state)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 20;
			obj = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E4__this != 0;
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

	private sealed class _003CSignInCoroutine_003Ed__14(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleSignInBridgeRequest<IGoogleSignInResult> request;

		public GoogleSignInBridge _003C_003E4__this;

		public bool silent;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Expected Obj, but got Unknown
				//IL_00c0: Expected Obj, but got I4
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018a: Expected Obj, but got Unknown
				//IL_0155: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Expected Obj, but got Unknown
				//IL_0163: Expected Obj, but got I4
				//IL_0177: Expected Obj, but got I4
				//IL_0248: Unknown result type (might be due to invalid IL or missing references)
				//IL_024d: Expected Obj, but got Unknown
				//IL_0256: Expected Obj, but got I4
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_021d: Expected Obj, but got Unknown
				//IL_0226: Expected Obj, but got I4
				//IL_023a: Expected Obj, but got I4
				GoogleSignInBridge googleSignInBridge = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest = request;
							if (~(googleSignInBridgeRequest.canceled ? 1u : 0u) == 0)
							{
								GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest2 = request;
								googleSignInBridgeRequest2.done = true;
							}
							goto IL_01f5;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest3 = request;
					googleSignInBridgeRequest3.done = false;
					GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest4 = request;
					googleSignInBridgeRequest4.canceled = false;
					object obj = request + 12;
					obj = 0;
				}
				if (googleSignInBridge._pendingSignInRequest != null)
				{
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				object obj3 = googleSignInBridge + 20;
				obj3 = request;
				bool flag = silent;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				object obj4 = default;
				if (obj4 != null)
				{
					goto IL_01f5;
				}
				GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest5 = request;
				googleSignInBridgeRequest5.canceled = true;
				GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest6 = request;
				googleSignInBridgeRequest6.done = true;
				goto IL_023f;
				IL_023f:
				object obj5 = googleSignInBridge + 20;
				obj5 = 0;
				return null;
				IL_01f5:
				GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest7 = request;
				if (!googleSignInBridgeRequest7.done)
				{
					object obj6 = this + 12;
					obj6 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				goto IL_023f;
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

	private sealed class _003CSignOutCoroutine_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleSignInBridgeRequest<IGoogleSignOutResult> request;

		public GoogleSignInBridge _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b7: Expected Obj, but got Unknown
				//IL_00c0: Expected Obj, but got I4
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018a: Expected Obj, but got Unknown
				//IL_0155: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Expected Obj, but got Unknown
				//IL_0163: Expected Obj, but got I4
				//IL_0177: Expected Obj, but got I4
				//IL_0234: Unknown result type (might be due to invalid IL or missing references)
				//IL_0239: Expected Obj, but got Unknown
				//IL_0242: Expected Obj, but got I4
				//IL_0204: Unknown result type (might be due to invalid IL or missing references)
				//IL_0209: Expected Obj, but got Unknown
				//IL_0212: Expected Obj, but got I4
				//IL_0226: Expected Obj, but got I4
				GoogleSignInBridge googleSignInBridge = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							GoogleSignInBridgeRequest<IGoogleSignOutResult> googleSignInBridgeRequest = request;
							if (~(googleSignInBridgeRequest.canceled ? 1u : 0u) == 0)
							{
								GoogleSignInBridgeRequest<IGoogleSignOutResult> googleSignInBridgeRequest2 = request;
								googleSignInBridgeRequest2.done = true;
							}
							goto IL_01e1;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					GoogleSignInBridgeRequest<IGoogleSignOutResult> googleSignInBridgeRequest3 = request;
					googleSignInBridgeRequest3.done = false;
					GoogleSignInBridgeRequest<IGoogleSignOutResult> googleSignInBridgeRequest4 = request;
					googleSignInBridgeRequest4.canceled = false;
					object obj = request + 12;
					obj = 0;
				}
				if (googleSignInBridge._pendingSignOutRequest != null)
				{
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				object obj3 = googleSignInBridge + 24;
				obj3 = request;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj4 = default;
				if (obj4 != null)
				{
					goto IL_01e1;
				}
				GoogleSignInBridgeRequest<IGoogleSignOutResult> googleSignInBridgeRequest5 = request;
				googleSignInBridgeRequest5.canceled = true;
				GoogleSignInBridgeRequest<IGoogleSignOutResult> googleSignInBridgeRequest6 = request;
				googleSignInBridgeRequest6.done = true;
				goto IL_022b;
				IL_022b:
				object obj5 = googleSignInBridge + 24;
				obj5 = 0;
				return null;
				IL_01e1:
				GoogleSignInBridgeRequest<IGoogleSignOutResult> googleSignInBridgeRequest7 = request;
				if (!googleSignInBridgeRequest7.done)
				{
					object obj6 = this + 12;
					obj6 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				goto IL_022b;
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

	private bool _connectionIsSuspended;

	private GoogleSignInBridgeRequest<IGoogleConnectResult> _pendingConnectRequest;

	private GoogleSignInBridgeRequest<IGoogleSignInResult> _pendingSignInRequest;

	private GoogleSignInBridgeRequest<IGoogleSignOutResult> _pendingSignOutRequest;

	public void Dispose()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public bool IsConnected()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return false;
	}

	public Coroutine Connect(GoogleSignInBridgeRequest<IGoogleConnectResult> request)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		((AndroidGoogleSignInBridge)(object)ex).PluginSignIn(false);
		return null;
	}

	public Coroutine SignIn(GoogleSignInBridgeRequest<IGoogleSignInResult> request, bool silent)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = this;
		object obj2 = coroutine + 20;
		obj2 = request;
		object obj3 = coroutine + 24;
		obj3 = silent;
		return coroutine;
	}

	public Coroutine SignOut(GoogleSignInBridgeRequest<IGoogleSignOutResult> request)
	{
		IEnumerator routine = SignOutCoroutine(request);
		return StartCoroutine_Auto(routine);
	}

	protected abstract bool PluginIsConnected();

	protected abstract void PluginConnect();

	protected abstract bool PluginSignIn(bool silent);

	protected abstract bool PluginSignOut();

	private IEnumerator ConnectCoroutine(GoogleSignInBridgeRequest<IGoogleConnectResult> request)
	{
		IGoogleSignInResult routine = ToGoogleSignInResult((SignInResultReceivedPayload)(object)request);
		return (IEnumerator)(object)StartCoroutine_Auto((IEnumerator)routine);
	}

	private IEnumerator SignInCoroutine(GoogleSignInBridgeRequest<IGoogleSignInResult> request, bool silent)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		bool flag = ((FacebookSession)this)._Init((string)(object)request, (string)silent);
		return (IEnumerator)(object)StartCoroutine_Auto((IEnumerator)flag);
	}

	private IEnumerator SignOutCoroutine(GoogleSignInBridgeRequest<IGoogleSignOutResult> request)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = request;
		return enumerator;
	}

	private IGoogleSignInResult ToGoogleSignInResult(SignInResultReceivedPayload signInResultReceivedPayload)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IGoogleSignInResult googleSignInResult = default;
		object obj = googleSignInResult + 20;
		obj = this;
		object obj2 = googleSignInResult + 16;
		obj2 = signInResultReceivedPayload;
		return googleSignInResult;
	}

	private IGoogleProfile ToGoogleProfile(ProfilePayload profile)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002c: Expected I4, but got Obj
		//IL_003d: Expected Obj, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		if (profile != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			IGoogleProfile googleProfile = default;
			object obj = googleProfile + 8;
			bool flag = ((SimulatedGoogleSignInBridge)null).PluginSignIn((byte)(int)profile.displayName != 0);
			obj = flag;
			_ = profile.idToken;
			object obj2 = googleProfile + 12;
			obj2 = profile.photoUrl;
			return googleProfile;
		}
		return null;
	}

	private void OnGoogleConnected()
	{
		//IL_0103: Expected I, but got Obj
		//IL_0119: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		string o = tag;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)o))
		{
			return;
		}
		string obj2 = tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj2);
	}

	private void OnGoogleConnectionSuspended(string payload)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = payload;
	}

	private void OnGoogleConnectionFailed(string payload)
	{
		_connectionIsSuspended = true;
	}

	private void OnGoogleSignInResultReceived(string payload)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		ConnectionFailedPayload connectionFailedPayload = JsonUtility.FromJson<ConnectionFailedPayload>(payload);
		if (_pendingConnectRequest != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 8;
			obj = connectionFailedPayload.errorMessage;
			_ = connectionFailedPayload.errorCode;
			object obj3 = _pendingConnectRequest + 12;
			obj3 = obj2;
			GoogleSignInBridgeRequest<IGoogleConnectResult> pendingConnectRequest = _pendingConnectRequest;
			pendingConnectRequest.done = true;
		}
	}

	private void OnGoogleSignedOut()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		if (_pendingConnectRequest != null)
		{
			object obj = _pendingConnectRequest + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			obj = obj2;
			GoogleSignInBridgeRequest<IGoogleConnectResult> pendingConnectRequest = _pendingConnectRequest;
			pendingConnectRequest.done = true;
		}
		_connectionIsSuspended = false;
	}

	protected GoogleSignInBridge()
	{
		if (_pendingSignOutRequest != null)
		{
			GoogleSignInBridgeRequest<IGoogleSignOutResult> pendingSignOutRequest = _pendingSignOutRequest;
			pendingSignOutRequest.done = true;
		}
	}
}
