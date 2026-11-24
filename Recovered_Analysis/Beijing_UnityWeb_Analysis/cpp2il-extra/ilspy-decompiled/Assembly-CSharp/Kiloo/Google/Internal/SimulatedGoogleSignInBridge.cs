using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Level;
using SYBO.Subway.Level.Environments;
using SYBO.Subway.StateSystem.States;
using UnityEngine;

namespace Kiloo.Google.Internal;

internal sealed class SimulatedGoogleSignInBridge : GoogleSignInBridge
{
	[Serializable]
	public class Profile
	{
		public string displayName;

		public string userId;

		public string photoUrl;

		public string idToken;

		public Profile()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	[Serializable]
	public class SignInResult
	{
		public Profile profile;

		public int errorCode;

		public string errorMessage;
	}

	private sealed class _003CWaitAndDo_003Ed__17(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float wait;

		public Action action;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Expected Obj, but got Unknown
				//IL_0072: Expected Obj, but got I4
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = -1f;
				_ = wait;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_001b: Expected I4, but got Obj
			//IL_001b: Expected Obj, but got I4
			((Component)_003C_003E1__state).SendMessage("OnGoogleSignInResultReceived", (SendMessageOptions)_003C_003E2__current);
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

	public string userId;

	public string displayName;

	public int signInError;

	public string signInErrorMessage;

	public float latency;

	private const string PHOTO_URL_FORMAT = "http://imaginary-photo-cdn.com/{0}/picture";

	private bool _connected;

	private bool _signedIn;

	protected override bool PluginIsConnected()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	protected override void PluginConnect()
	{
	}

	protected override bool PluginSignIn(bool silent)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0237: Expected Obj, but got I4
		//IL_0247: Expected Obj, but got I
		//IL_0255: Expected Obj, but got I4
		//IL_0265: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I4
		//IL_0283: Expected Obj, but got I
		//IL_0291: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		if (silent)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+8]");
			bool flag;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v10+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+C]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+C]");
				bool flag2;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v24+8]");
					flag2 = (nint)0 == 0;
				}
				else
				{
					flag2 = true;
				}
				if (flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+10]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+10]");
					bool flag3;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v27+8]");
						flag3 = (nint)0 == 0;
					}
					else
					{
						flag3 = true;
					}
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+14]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+14]");
						bool flag4;
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v30+8]");
							flag4 = (nint)0 == 0;
						}
						else
						{
							flag4 = true;
						}
						if (flag4)
						{
							return false;
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			bool flag5 = default;
			object obj5 = (flag5 ? 1 : 0) + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+8]");
			obj5 = 0;
			object obj6 = (flag5 ? 1 : 0) + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+C]");
			obj6 = 0;
			object obj7 = (flag5 ? 1 : 0) + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+10]");
			obj7 = 0;
			object obj8 = (flag5 ? 1 : 0) + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [silent @ L1 (System.Boolean)+14]");
			obj8 = 0;
			return flag5;
		}
		return false;
	}

	protected override bool PluginSignOut()
	{
		return _connected;
	}

	public static bool IsSupported()
	{
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 11)
		{
			bool isPlatformSupported = GoogleSignInBridgeFactory.isPlatformSupported;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		return false;
	}

	public static GoogleSignInBridge Create()
	{
		//IL_0006: Expected Obj, but got I4
		return (GoogleSignInBridge)1;
	}

	private string MakeIdToken()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I4
		//IL_000b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		EnvironmentKind environmentKind = default;
		environmentKind._type = (EnvironmentType)num;
		_ = 0;
		object obj = environmentKind + 16;
		obj = this;
		bool flag = ((DistantEnvironmentController.DistantObjectSpawner)null).CanSpawnAt(latency, environmentKind);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag);
		return (string)1;
	}

	private IEnumerator WaitAndDo(float wait, Action action)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_005d: Expected Obj, but got F4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DeathState._003CDelayGameOverScreen_003Ed__8 obj = default;
		((IDisposable)obj).Dispose();
		object obj3 = default;
		object obj2 = obj3 + 48;
		obj2 = action;
		_ = ((Delegate)action).method_ptr;
		object obj4 = obj + 8;
		float num = wait + (float)obj2;
		obj4 = num;
		object obj5 = obj3 + 32;
		obj5 = action;
		_ = ((Delegate)action).method_ptr;
		object obj6 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17+4]");
		_ = 0;
		object obj7 = obj3 + 16;
		obj7 = action;
		_ = ((Delegate)action).method_ptr;
		object obj8 = obj + 8;
		float num2 = wait;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v22+8]");
		float num3 = num2 + 0f;
		obj3 = action;
		_ = ((Delegate)action).method_ptr;
		object obj9 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
		_ = 0;
		_ = 1;
		return obj;
	}

	public SimulatedGoogleSignInBridge()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		EnvironmentKind environmentKind = default;
		environmentKind._type = (EnvironmentType)num;
		_ = 0;
		object obj = environmentKind + 16;
		obj = this;
		bool flag = ((DistantEnvironmentController.DistantObjectSpawner)null).CanSpawnAt(0.1f, environmentKind);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag);
	}

	private void _003CPluginConnect_003Eb__9_0()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		object obj = this + 28;
		obj = "10101010";
		object obj2 = this + 32;
		obj2 = "John Doe";
		latency = 0.1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private void _003CPluginSignOut_003Eb__13_0()
	{
		//IL_0015: Expected I4, but got Obj
		SendMessage("OnGoogleConnected", (SendMessageOptions)"");
	}
}
