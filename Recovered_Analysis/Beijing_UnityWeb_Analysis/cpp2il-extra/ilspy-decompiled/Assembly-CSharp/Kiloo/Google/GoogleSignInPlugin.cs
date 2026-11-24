using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using InAppPurchase;
using Kiloo.Analytics;
using Kiloo.Common.Plugins.DeviceUtility.Internal;
using Kiloo.Common.Utility;
using Kiloo.Google.Internal;
using Kiloo.Monetization.FacebookAds.Internal;
using UnityEngine;

namespace Kiloo.Google;

public sealed class GoogleSignInPlugin
{
	public delegate void ProfileUpdatedHandler(IGoogleProfile oldProfile, IGoogleProfile newProfile);

	private sealed class _003CSignInCoroutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleSignInPlugin _003C_003E4__this;

		public GoogleSignInPluginRequest request;

		public Action<GoogleSignInPluginRequest> onComplete;

		private GoogleSignInBridgeRequest<IGoogleSignInResult> _003CsignInRequest_003E5__2;

		private GoogleSignInBridgeRequest<IGoogleConnectResult> _003CconnectRequest_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_030e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0313: Expected Obj, but got Unknown
				//IL_0321: Unknown result type (might be due to invalid IL or missing references)
				//IL_0326: Expected Obj, but got Unknown
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Expected Obj, but got Unknown
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Expected Obj, but got Unknown
				//IL_0409: Expected Obj, but got I4
				//IL_00be: Expected Obj, but got I4
				//IL_0167: Unknown result type (might be due to invalid IL or missing references)
				//IL_016c: Expected Obj, but got Unknown
				//IL_0175: Expected Obj, but got I4
				GoogleSignInPlugin msg = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
						GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest = _003CsignInRequest_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj = default;
						if (obj != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							throw new ArrayTypeMismatchException();
						}
						GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest2 = _003CsignInRequest_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object[] args = default;
						Log((string)(object)msg, args);
						GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest3 = _003CsignInRequest_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest4 = _003CsignInRequest_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						GoogleSignInBridgeRequest<IGoogleSignInResult> googleSignInBridgeRequest5 = _003CsignInRequest_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						string optionalButton = default;
						string optionalButton2 = default;
						Action<string> onDismissed = default;
						((DeviceUtilityAndroid)null).ShowNativePopup((string)(object)request, (string)(object)onComplete, (string)null, optionalButton, optionalButton2, onDismissed);
						return null;
					}
					_003C_003E1__state = -1;
					GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest6 = _003CconnectRequest_003E5__3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj2 = default;
					if (obj2 != null)
					{
						((GoogleSignInPluginRequest)(object)"Error connecting")._002Ector();
						GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest7 = _003CconnectRequest_003E5__3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest8 = _003CconnectRequest_003E5__3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						string optionalButton3 = default;
						Action<string> onDismissed2 = default;
						((DeviceUtilityAndroid)null).ShowNativePopup((string)(object)request, (string)(object)onComplete, (string)null, (string)null, optionalButton3, onDismissed2);
						return null;
					}
					object obj3 = this + 32;
					obj3 = 0;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj4 = default;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj5 = this + 32;
						object obj6 = default;
						obj5 = obj6;
						object obj7 = this + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
						object obj8 = default;
						obj7 = obj8;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj9 = this + 28;
				object obj10 = default;
				obj9 = obj10;
				object obj11 = this + 12;
				if (request != null)
				{
					GoogleSignInPluginRequest googleSignInPluginRequest = request;
					bool flag = googleSignInPluginRequest.silent__BackingField;
				}
				else
				{
					bool flag = false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
				object obj12 = default;
				obj11 = obj12;
				_003C_003E1__state = 2;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CSignInCoroutine_003Ed__27(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
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

	private sealed class _003CSignOutCoroutine_003Ed__28(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GoogleSignInPlugin _003C_003E4__this;

		public GoogleSignInPluginRequest request;

		public Action<GoogleSignInPluginRequest> onComplete;

		private GoogleSignInBridgeRequest<IGoogleConnectResult> _003CconnectRequest_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0194: Unknown result type (might be due to invalid IL or missing references)
				//IL_0199: Expected Obj, but got Unknown
				//IL_01c4: Expected Obj, but got I4
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Expected Obj, but got Unknown
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Expected Obj, but got Unknown
				//IL_00be: Expected Obj, but got I4
				//IL_0167: Unknown result type (might be due to invalid IL or missing references)
				//IL_016c: Expected Obj, but got Unknown
				//IL_0175: Expected Obj, but got I4
				GoogleSignInPlugin msg = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
						Log((string)(object)msg, null);
						((DeviceUtilityAndroid)null).ShowNativePopup((string)(object)request, (string)(object)onComplete, (string)null, (string)null, (string)null, (Action<string>)null);
						return null;
					}
					_003C_003E1__state = -1;
					GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest = _003CconnectRequest_003E5__2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj = default;
					if (obj != null)
					{
						((GoogleSignInPluginRequest)(object)"Error connecting")._002Ector();
						GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest2 = _003CconnectRequest_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						GoogleSignInBridgeRequest<IGoogleConnectResult> googleSignInBridgeRequest3 = _003CconnectRequest_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						string optionalButton = default;
						Action<string> onDismissed = default;
						((DeviceUtilityAndroid)null).ShowNativePopup((string)(object)request, (string)(object)onComplete, (string)null, (string)null, optionalButton, onDismissed);
						return null;
					}
					object obj2 = this + 28;
					obj2 = 0;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj3 = default;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj4 = this + 28;
						object obj5 = default;
						obj4 = obj5;
						object obj6 = this + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
						object obj7 = default;
						obj6 = obj7;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj8 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj9 = default;
				obj8 = obj9;
				_003C_003E1__state = 2;
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

	private static GoogleSignInPlugin instance__BackingField;

	private ProfileUpdatedHandler m_profileUpdated;

	private bool profileIsUpdated__BackingField;

	private IGoogleProfile profile__BackingField;

	private readonly IGoogleSignInBridge _bridge;

	public static bool isSupported
	{
		get
		{
			//IL_006a: Expected I4, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_00c1: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"FacebookAdSimulatedReceiver";
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
			return (byte)(int)gameObject.AddComponent<FacebookNativeAdsSimulated>() != 0;
		}
	}

	public static GoogleSignInPlugin instance
	{
		get
		{
			return (GoogleSignInPlugin)(object)GoogleSignInBridgeFactory.Create();
		}
		private set
		{
		}
	}

	public bool profileIsUpdated
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
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_profileUpdated;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
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

	public IGoogleProfile profile
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = profileIsUpdated__BackingField;
			return (IGoogleProfile)flag;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			profileIsUpdated__BackingField = flag;
		}
	}

	public bool isSignedIn
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)profile__BackingField != 0;
		}
	}

	public static bool isInitialized
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (byte)(int)instance__BackingField != 0;
		}
	}

	public event ProfileUpdatedHandler profileUpdated
	{
		add
		{
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_profileUpdated;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
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

	public static void Init()
	{
	}

	public Coroutine SignIn(GoogleSignInPluginRequest request = null, Action<GoogleSignInPluginRequest> onComplete = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj4 = default;
		object obj3 = obj4;
		object obj6 = default;
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj7 = default;
		if (obj5 == obj7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj9 = default;
			object obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj11 = default;
			object obj10 = obj11;
		}
		else
		{
			object obj10 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		Coroutine result = default;
		return result;
	}

	public Coroutine SignOut(GoogleSignInPluginRequest request = null, Action<GoogleSignInPluginRequest> onComplete = null)
	{
		IEnumerator list = SignOutCoroutine(request, onComplete);
		return CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private GoogleSignInPlugin()
	{
		instance__BackingField = this;
	}

	private IEnumerator SignInCoroutine(GoogleSignInPluginRequest request, Action<GoogleSignInPluginRequest> onComplete)
	{
		//IL_000e: Expected I4, but got Obj
		Coroutine list = ((GoogleSignInBridge)this).SignIn((GoogleSignInBridgeRequest<IGoogleSignInResult>)(object)request, (byte)(int)onComplete != 0);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private IEnumerator SignOutCoroutine(GoogleSignInPluginRequest request, Action<GoogleSignInPluginRequest> onComplete)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = request;
		object obj3 = enumerator + 24;
		obj3 = onComplete;
		return enumerator;
	}

	private void UpdateProfile(IGoogleProfile newProfile)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = newProfile;
	}

	private unsafe void CompleteRequest(GoogleSignInPluginRequest request, Action<GoogleSignInPluginRequest> onComplete, string context, IGoogleProfile profile = null, int errorCode = 0, string errorMessage = null)
	{
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_087f: Expected Obj, but got I4
		//IL_09d4: Expected I, but got Obj
		//IL_09ea: Expected Obj, but got I
		//IL_0209: Expected I4, but got Obj
		//IL_06d5: Expected Obj, but got I4
		//IL_022c: Expected Obj, but got I4
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_0716: Expected I, but got Obj
		//IL_063c: Expected Obj, but got I4
		//IL_0763: Expected I, but got Obj
		//IL_0779: Expected Obj, but got I
		//IL_08bc: Expected I, but got Obj
		//IL_08d2: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0a19: Expected Obj, but got I4
		//IL_0a3c: Expected Obj, but got I4
		//IL_0a3c: Expected Obj, but got I
		//IL_07a4: Expected I, but got Obj
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_0283: Expected I, but got Obj
		//IL_02d0: Expected I, but got Obj
		//IL_02e6: Expected Obj, but got I
		//IL_05a3: Expected Obj, but got I4
		//IL_0486: Expected I, but got Obj
		//IL_049c: Expected Obj, but got I
		//IL_0311: Expected I, but got Obj
		//IL_035e: Expected I, but got Obj
		//IL_0374: Expected Obj, but got I
		//IL_04c7: Expected I, but got Obj
		//IL_0930: Expected Obj, but got I4
		//IL_093e: Expected I, but got Obj
		//IL_0954: Expected Obj, but got I
		//IL_097f: Expected I, but got Obj
		//IL_0995: Expected Obj, but got I
		//IL_039f: Expected I, but got Obj
		//IL_03ec: Expected I, but got Obj
		//IL_0439: Expected I, but got Obj
		switch (errorCode)
		{
		case 0:
		{
			nint num = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v31 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v120 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = MigrationSave.TryParseDummy((string)(object)onComplete, out *(CollectCoinsDummy*)request);
			string dataPath4 = Application.dataPath;
			bool flag2;
			if ((nint)dataPath4 == 11)
			{
				if (context == null || context.m_stringLength == 0)
				{
					flag2 = false;
				}
				else
				{
					nint num3 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S1_v42 (Il2CppClass<InApp.InAppManager>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v48 (Il2CppClass<InApp.InAppManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					flag2 = MigrationSave.TryParseDummy(context, out *(CollectCoinsDummy*)request);
				}
			}
			else
			{
				flag2 = false;
			}
			object obj3 = flag | flag2;
			if (obj3 == null)
			{
				break;
			}
			((InAppManager)this).NativePurchaseFinished((byte)(int)request != 0);
			bool isValidationSupportedOnCurrentPlatform4 = InAppPurchaseProvider.IsValidationSupportedOnCurrentPlatform;
			((InAppPurchaseProvider)isValidationSupportedOnCurrentPlatform4).ItemRestoredCallback((string)(object)request, (string)(object)onComplete, context);
			bool flag3;
			if (errorMessage != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj4 = default;
				flag3 = (nint)obj4 == 1;
			}
			else
			{
				flag3 = false;
			}
			bool flag4 = flag3;
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v48 (Il2CppClass<Flurry>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v112 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Google.GoogleSignInPlugin)+30]");
			((FollowingGuard)(object)request).SetupAvatarAnimationsStates((Animation)0, (AnimationClip)flag4);
			if (flag4)
			{
				nint num7 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v61 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v108 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string firstInstalledVersion = UserSave.firstInstalledVersion;
				if (firstInstalledVersion == null)
				{
					nint num9 = (nint)typeof(Manager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v80 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num10 = (nint)typeof(Manager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v104 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Tracker.CreateEvent(Kiloo.Analytics.EventType.SingleValidPurchase, (Action<Kiloo.Analytics.Event>)1);
					nint num11 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v86 (Il2CppClass<Flurry>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num12 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v100 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num13 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v91 (Il2CppClass<Data.Save.UserSave>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num14 = (nint)typeof(UserSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v96 (Il2CppClass<Data.Save.UserSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9363");
				}
				nint num15 = (nint)typeof(Manager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v70 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num16 = (nint)typeof(Manager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v75 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Tracker.CreateEvent(Kiloo.Analytics.EventType.MadeValidPurchase, null, (string)(object)request);
			}
			object obj11 = this + 48;
			obj11 = "";
			if (this.profile__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
			}
			break;
		}
		case 4:
		{
			((InAppManager)this).PurchaseCanceled((string)null);
			string dataPath2 = Application.dataPath;
			if ((nint)dataPath2 == 8)
			{
				bool isValidationSupportedOnCurrentPlatform2 = InAppPurchaseProvider.IsValidationSupportedOnCurrentPlatform;
				((InAppPurchaseProvider)isValidationSupportedOnCurrentPlatform2).ItemRestoredCallback((string)(object)request, (string)(object)onComplete, context);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Google.GoogleSignInPlugin)+1C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
			break;
		}
		case 2:
		{
			((InAppManager)this).PurchaseFailed((string)null);
			string dataPath3 = Application.dataPath;
			if ((nint)dataPath3 == 8)
			{
				bool isValidationSupportedOnCurrentPlatform3 = InAppPurchaseProvider.IsValidationSupportedOnCurrentPlatform;
				((InAppPurchaseProvider)isValidationSupportedOnCurrentPlatform3).ItemRestoredCallback((string)(object)request, (string)(object)onComplete, context);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Google.GoogleSignInPlugin)+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
			break;
		}
		default:
		{
			((InAppManager)this).PayoutInAppPurchase((string)null);
			string dataPath = Application.dataPath;
			if ((nint)dataPath == 8)
			{
				bool isValidationSupportedOnCurrentPlatform = InAppPurchaseProvider.IsValidationSupportedOnCurrentPlatform;
				((InAppPurchaseProvider)isValidationSupportedOnCurrentPlatform).ItemRestoredCallback((string)(object)request, (string)(object)onComplete, context);
			}
			if (_bridge != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
			break;
		}
		}
		nint num17 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v8 (Il2CppClass<UIScreenController>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num18 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v26 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController == null)
		{
			return;
		}
		nint num19 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num20 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v22 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag5).DelayedHideInAppPurchaseOverlay();
	}

	private static bool AreEqual(IGoogleProfile a, IGoogleProfile b)
	{
		return false;
	}

	private static void LogError(string msg)
	{
		bool flag = SimulatedGoogleSignInBridge.IsSupported();
	}

	private static void Log(string msg, object[] args)
	{
		//IL_0023: Expected I4, but got Obj
		//IL_0023: Expected Obj, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		msg.m_firstChar = '\u0001';
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+10]");
		if (!((AndroidGoogleSignInBridge)0).PluginSignIn((byte)(int)args != 0))
		{
			object obj = msg + 16;
			obj = args;
			if (msg.m_stringLength != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
		}
	}
}
