using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using InApp;
using Kiloo.Common.Timer;
using Kiloo.Plugins.Facebook;
using UI.FreeStuff;
using UI.Generic;
using UI.Generic.Layout;
using UnityEngine;

namespace UI;

public class FacebookLoginButtonOnline : MonoBehaviour
{
	private enum LoginButtonState
	{
		Simple,
		CouldNotConnectTryAgain,
		Connecting
	}

	private sealed class _003CUserFeedback_003Ed__24(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FacebookLoginButtonOnline _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected Obj, but got Unknown
				//IL_006b: Expected Obj, but got I4
				//IL_009b: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003E4__this.OnPress(pressed: true);
						((FacebookPromotionReconnect)(object)_003C_003E4__this).Init((Action)1);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 2f;
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

	private GameObject _simpleContent;

	private UILabel _simpleLabel;

	private Layout _simpleLayout;

	private GameObject _connectingToGameObject;

	private Layout _connectingLayout;

	private UILabel _connectingLabel;

	private GameObject _couldNotConnectTryAgainGameObject;

	private Layout _tryAgainLayout;

	private UILabel _tryAgain1;

	private UILabel _tryAgain2;

	private UIButtonOverlayOff _btnOverlayOffDefault;

	private UIButtonOverlayOff _btnOverlayOffTryAgain;

	private bool _isGameOverScreen;

	private bool _shouldDisplayAwardsSpecific;

	private bool _shouldDisplayTopRunSpecific;

	private LoginButtonState _loginButtonState;

	private bool _enabled;

	public void Init(bool isLoggedIntoFacebook, bool isAwardsSpecific = false, bool isLoggedIntoGC = false, bool isTopRunSpecific = false, bool noGCFriends = false, bool isGameOverScreen = false)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_03f1: Expected Obj, but got I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0413: Expected Obj, but got I4
		//IL_001b: Expected I, but got Obj
		//IL_0031: Expected Obj, but got I
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_005c: Expected I, but got Obj
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_0253: Expected I, but got Obj
		//IL_0269: Expected Obj, but got I
		//IL_0178: Expected I, but got Obj
		//IL_0480: Expected I4, but got Obj
		//IL_01c5: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_00ea: Expected I, but got Obj
		//IL_030e: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_0294: Expected I, but got Obj
		//IL_04cf: Expected I4, but got Obj
		//IL_0206: Expected I, but got Obj
		//IL_034f: Expected I, but got Obj
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		object obj = noGCFriends;
		_btnOverlayOffTryAgain = (UIButtonOverlayOff)isLoggedIntoFacebook;
		((UILabel)(object)_tryAgainLayout).fontSize = (isAwardsSpecific ? 1 : 0);
		object obj2 = this + 60;
		obj2 = isGameOverScreen;
		((UISprite)(object)_couldNotConnectTryAgainGameObject).fillCenter = isTopRunSpecific;
		_tryAgain1.fontSize = (isLoggedIntoGC ? 1 : 0);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_btnOverlayOffDefault).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v68 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v75 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("COIN_BUTTON_EARNER_GET");
			((UILabel)(object)_btnOverlayOffDefault).fontSize = (int)text;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_connectingLabel).FindKernel((string)null) != 0)
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v52 (Il2CppClass<Strings>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v59 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("SOCIAL_BUTTON_FEEDBACK_CONNECTING");
			_connectingLabel.fontSize = (int)text2;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_tryAgain2).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			int fontSize = default;
			_tryAgain2.fontSize = fontSize;
		}
		FitSpriteToWidget component = ((Component)(object)_couldNotConnectTryAgainGameObject).GetComponent<FitSpriteToWidget>();
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			component.FitStretch();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num13 = 0;
			string text3 = default;
			text3.m_stringLength = (int)num13;
			_ = 0;
			object obj9 = text3 + 16;
			obj9 = component;
			Timer.Log(text3);
		}
		((CoinEarnerButtonHelper)this).GoToConnectingState();
	}

	private void SetState(LoginButtonState newState)
	{
	}

	private void OnDestroy()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got F4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got F4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got F4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0195: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		_ = 0;
		obj = 126f;
		_ = 28f;
		_ = 0f;
		object obj3 = obj2 + 36;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj4 = this + 356;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		object obj5 = obj2 + 12;
		obj5 = 0;
		_ = 0;
		obj5 = 125f;
		_ = 28.5f;
		_ = 0f;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v21+8]");
		_ = 0;
		object obj6 = this + 368;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 127f;
		_ = 29f;
		_ = 0f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = this + 380;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		_ = 0;
		nint num = (nint)typeof(DiscountButton);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v42 (Il2CppClass<UI.DiscountButton>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(DiscountButton);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v48 (Il2CppClass<UI.DiscountButton>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DoubleCoinUpgradeHelper)this).ForceEndDiscount();
	}

	private void OnPress(bool pressed)
	{
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_02fc: Expected Obj, but got I4
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0325: Expected Obj, but got I4
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_034e: Expected Obj, but got I4
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_0377: Expected Obj, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_038c: Expected Obj, but got I4
		//IL_0105: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I
		//IL_0268: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_03ae: Expected I4, but got Obj
		//IL_0410: Expected I4, but got Obj
		//IL_0420: Expected Obj, but got I4
		//IL_03de: Expected I4, but got Obj
		//IL_0194: Expected I4, but got Obj
		//IL_01a4: Expected Obj, but got I4
		//IL_0146: Expected I, but got Obj
		//IL_02a9: Expected I, but got Obj
		//IL_0216: Expected I, but got Obj
		object obj = this - -64;
		obj = pressed;
		object obj2 = this - -64;
		bool flag = (nint)obj2 == 2;
		_connectingToGameObject.tag = (string)flag;
		object obj3 = this - -64;
		bool flag2 = (nint)obj3 == 1;
		_couldNotConnectTryAgainGameObject.tag = (string)flag2;
		object obj4 = this - -64;
		bool flag3 = obj4 == null;
		_simpleContent.tag = (string)flag3;
		_btnOverlayOffDefault.LockState(locked: true);
		object obj5 = this - -64;
		if (obj5 != null)
		{
			if ((nint)obj5 != 1)
			{
				if ((nint)obj5 != 2)
				{
					return;
				}
				nint num = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v54 (Il2CppClass<Strings>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v62 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("SOCIAL_BUTTON_FEEDBACK_CONNECTING");
				_connectingLabel.fontSize = (int)text;
				((RewardForVideoButton)(object)_connectingLayout).Init((VideoButtonPayload)1);
			}
			else if (~(_isGameOverScreen ? 1u : 0u) == 0)
			{
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v38 (Il2CppClass<Strings>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v49 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = Strings.GetDefault("SOCIAL_BUTTON_FEEDBACK_TRY_AGAIN_1");
				_tryAgain1.fontSize = (int)text2;
				string text3 = Strings.GetDefault("BUTTON_TRY_AGAIN");
				_tryAgain2.fontSize = (int)text3;
				((RewardForVideoButton)(object)_tryAgainLayout).Init((VideoButtonPayload)1);
			}
			else
			{
				if (~(_shouldDisplayTopRunSpecific ? 1u : 0u) != 0)
				{
					return;
				}
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v25 (Il2CppClass<Strings>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v33 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text4 = Strings.GetDefault("FACEBOOK_BUTTON_RECONNECT");
				_tryAgain2.fontSize = (int)text4;
				_btnOverlayOffDefault.LockState(locked: true);
			}
		}
		else
		{
			_btnOverlayOffDefault.LockState(locked: true);
			if (~(_shouldDisplayTopRunSpecific ? 1u : 0u) == 0 && ~(_isGameOverScreen ? 1u : 0u) != 0)
			{
				_btnOverlayOffDefault.LockState(locked: true);
			}
			((RewardForVideoButton)(object)_simpleLayout).Init((VideoButtonPayload)1);
		}
	}

	private void OnClick()
	{
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I4
		//IL_0098: Expected Obj, but got I4
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		SocialManager.FacebookState facebookState = default;
		object obj2 = facebookState + 16;
		obj2 = this;
		((SocialManager)facebookDialogsSupported).facebookState = facebookState;
		bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		bool flag = default;
		object obj3 = (flag ? 1 : 0) + 16;
		obj3 = this;
		((SocialManager)facebookDialogsSupported2).FriendConsolidationDidFinish(flag);
	}

	private void FacebookLoggedIn(bool success)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00f6: Expected I, but got Obj
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_0184: Expected I, but got Obj
		if (~(_enabled ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_btnOverlayOffDefault).FindKernel((string)null) != 0)
		{
			((UIButtonSender)(object)_btnOverlayOffDefault).OnHover(success);
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_btnOverlayOffTryAgain).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_couldNotConnectTryAgainGameObject).FindKernel((string)null) != 0)
		{
			string text = _couldNotConnectTryAgainGameObject.tag;
			if (text != null)
			{
				((UIButtonSender)(object)_btnOverlayOffTryAgain).OnHover(success);
			}
		}
	}

	private IEnumerator UserFeedback()
	{
		//IL_0153: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a2: Expected I, but got Obj
		//IL_01b8: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I4
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (InAppManager.IsAnyCurrencyDiscountActive)
		{
			nint num3 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v17 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v27 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string ignoredInAppOnlineSettingsId = InAppData.GetIgnoredInAppOnlineSettingsId("com.kiloo.subwaysurfers.doublecoins");
			nint num5 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v8 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v14 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = InAppManager.TryAddTransactionToHistory(ignoredInAppOnlineSettingsId, null);
			if ((flag ? 1 : 0) < (false ? 1 : 0))
			{
				return (IEnumerator)1;
			}
		}
		return null;
	}

	private void QueueSlideIn(bool success)
	{
		//IL_016d: Expected I, but got Obj
		//IL_0183: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_0120: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)this))
		{
			string text = tag;
			string text2 = ((GameObject)(object)text).tag;
			if (text2 != null)
			{
				if (!success)
				{
					IEnumerator routine = ((FacebookLoginPromotion)this).ActivateStars();
					Coroutine coroutine = StartCoroutine_Auto(routine);
				}
				else
				{
					nint num3 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v20 (Il2CppClass<UIScreenController>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = UIScreenController.ShouldShowOnlineScreen();
					((UIScreenController)flag).QueueMessage((string)1);
					((FacebookPromotionReconnect)this).Init((Action)null);
				}
			}
		}
		((FacebookLoginButtonOnline)null).FriendsConsolidated(success);
	}

	private void FacebookStateChanged()
	{
		//IL_002a: Expected I, but got Obj
		//IL_0040: Expected Obj, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I4
		//IL_006b: Expected I, but got Obj
		if (~(_enabled ? 1u : 0u) != 0)
		{
			return;
		}
		OnPress(pressed: true);
		((FacebookPromotionReconnect)this).Init((Action)null);
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v11 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj2 = this;
		bool flag = SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported, obj3);
	}

	private void FriendsConsolidated(bool success)
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 13;
		((UIScreenController)flag)._QueueMessage(text);
	}

	private void EnableTouch(bool enable)
	{
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0220: Expected I4, but got Obj
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (!((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			return;
		}
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v28 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v20 (System.Boolean)+70]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			return;
		}
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v8 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SOCIAL_BUTTON_FEEDBACK_COULD_NOT_CONNECT_1");
		_simpleLabel.fontSize = (int)text;
		OnPress(pressed: false);
		((FacebookPromotionReconnect)this).Init((Action)null);
	}

	public FacebookLoginButtonOnline()
	{
		//IL_0147: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)this))
		{
			return;
		}
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v26 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v19 (System.Boolean)+60]");
		object obj3 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v19 (System.Boolean)+60]");
		if ((nint)0 != 1)
		{
			if ((nint)obj3 == 1)
			{
				OnPress(pressed: true);
				((FacebookPromotionReconnect)this).Init((Action)null);
			}
		}
		else
		{
			OnPress(pressed: true);
			((FacebookPromotionReconnect)this).Init((Action)1);
		}
	}
}
