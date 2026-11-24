using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Profiling.Memory.Experimental;

namespace SYBO.Components.Utilities;

[Serializable]
public class NetworkReachabilityMonitor : SingletonMonoBehaviour<NetworkReachabilityMonitor>
{
	private sealed class _003CPollToCheckNetworkReachability_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkReachabilityMonitor _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Expected Obj, but got Unknown
				//IL_0166: Expected Obj, but got I4
				//IL_008e: Expected I, but got Obj
				//IL_00a4: Expected Obj, but got I
				//IL_00cf: Expected I, but got Obj
				NetworkReachabilityMonitor networkReachabilityMonitor = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				bool genuine = Application.genuine;
				if (networkReachabilityMonitor._previousNetworkReachability != (genuine ? NetworkReachability.ReachableViaCarrierDataNetwork : NetworkReachability.NotReachable))
				{
					nint num = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v25 (Il2CppClass<UnityEngine.Debug>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v33 (Il2CppClass<UnityEngine.Debug>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Debug.LogError("CheckNetworkReachability() Ping!");
					((MetaData)(object)networkReachabilityMonitor.OnNetworkReachabilityChanged)._002Ector();
				}
				bool genuine2 = Application.genuine;
				networkReachabilityMonitor._previousNetworkReachability = (genuine2 ? NetworkReachability.ReachableViaCarrierDataNetwork : NetworkReachability.NotReachable);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = -1f;
				_ = 1f;
				object obj2 = this + 12;
				object obj3 = default;
				obj2 = obj3;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CPollToCheckNetworkReachability_003Ed__10(int _003C_003E1__state)
		{
			//IL_001d: Expected Obj, but got I4
			this._003C_003E1__state = _003C_003E1__state;
			bool hasShutdownStarted = Environment.HasShutdownStarted;
			_003C_003E4__this = (NetworkReachabilityMonitor)hasShutdownStarted;
		}

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_000a: Expected I4, but got Obj
			return (byte)(int)((IEnumerable)(object)this).GetEnumerator() != 0;
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

	public UnityEvent OnNetworkReachabilityChanged;

	private const int TimeDelayBetweenPolling = 1;

	private NetworkReachability _previousNetworkReachability;

	private Coroutine _checkNetworkReachability;

	public bool IsNetworkReachable
	{
		get
		{
			//IL_004b: Expected I, but got Obj
			//IL_0061: Expected Obj, but got I
			//IL_0113: Expected Obj, but got I4
			//IL_0113: Expected Obj, but got I4
			//IL_011f: Expected I4, but got Obj
			//IL_0038: Expected I4, but got Obj
			//IL_008c: Expected I, but got Obj
			bool flag;
			if ((object)this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.NetworkReachabilityMonitor)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				return (byte)(int)"" != 0;
			}
			nint num = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v9 (Il2CppClass<System.IO.Path>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v15 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = ((string)(object)this).Replace((string)Path.AltDirectorySeparatorChar, (string)Path.DirectorySeparatorChar);
			return (byte)(int)text != 0;
		}
	}

	public NetworkReachability NetworkReachability => Application.genuine ? NetworkReachability.ReachableViaCarrierDataNetwork : NetworkReachability.NotReachable;

	protected override void SubclassInitialize()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Exception);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Exception.ReportUnhandledException((Exception)(object)this);
	}

	protected override void OnDestroy()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		bool genuine = Application.genuine;
		_previousNetworkReachability = (genuine ? NetworkReachability.ReachableViaCarrierDataNetwork : NetworkReachability.NotReachable);
		object obj = this + 24;
		string routine = PathUtility.CombinePaths((string[])(object)this);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)routine);
		obj = coroutine;
	}

	private IEnumerator PollToCheckNetworkReachability()
	{
		//IL_0009: Expected Obj, but got I4
		return (IEnumerator)Application.genuine;
	}

	public NetworkReachabilityMonitor()
	{
		if (_checkNetworkReachability != null)
		{
			StopCoroutine((string)(object)_checkNetworkReachability);
		}
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
