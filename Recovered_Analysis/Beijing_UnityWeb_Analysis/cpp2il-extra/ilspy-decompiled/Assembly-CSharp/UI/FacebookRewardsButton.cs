using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using UI.Popups.AgeRestrictionPopupInternal;
using UnityEngine;

namespace UI;

public class FacebookRewardsButton : MonoBehaviour
{
	private GameObject activeContent;

	private GameObject connectingContent;

	private UILabel _connectingLabel;

	private UIAnchor contentAnchor;

	private UILabel titleLabel;

	private UILabel _description;

	private UILabel _priceLabel;

	private UILabel _getLabel;

	private Action m_onFacebookClick;

	public event Action onFacebookClick
	{
		add
		{
			//IL_01b4: Expected I, but got Obj
			//IL_01ca: Expected Obj, but got I
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected Obj, but got Unknown
			//IL_0112: Expected Obj, but got I4
			//IL_0112: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0125: Expected I, but got Obj
			//IL_013b: Expected Obj, but got I
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_0257: Expected I4, but got Obj
			//IL_01f0: Expected Obj, but got I4
			//IL_01ff: Expected Obj, but got F4
			//IL_0166: Expected I, but got Obj
			//IL_00ab: Expected I, but got Obj
			nint num = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v27 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			Transform transform = (Transform)(obj2 + 12);
			if (IPhoneXSupport.CheckIsiPhoneXDevice())
			{
				GameObject gameObject = base.gameObject;
				nint num3 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v24 (Il2CppClass<IPhoneXSupport>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(IPhoneXSupport);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v39 (Il2CppClass<IPhoneXSupport>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = 0;
				_ = 0;
				obj2 = 0.5f;
				_ = IPhoneXSupport.OFFSET_BOTTOM;
				_ = 0f;
				transform = (Transform)obj2;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
			}
			FriendsLoginFBButton component = activeContent.GetComponent<FriendsLoginFBButton>();
			((ListContentElementAdapter)(object)component)._002Ector((List<ListContentElement>)(object)value, (GameObject)1, (ScrollView)1, (CenterOnChild)null, (string)null);
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v10 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v18 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("FACEBOOK_PROMOTION_RECONNECT_WARNING");
			((UILabel)(object)connectingContent).fontSize = (int)text;
			((FacebookPromotionReconnect)this)._002Ector();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onFacebookClick;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 44;
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

	private void OnEnable()
	{
		CancelInvoke();
	}

	private void InitializeButton()
	{
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UserSave.allAssetBundlesDownloaded)
		{
			string obj2 = tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj2);
		}
		else
		{
			OnClick();
			GoToConnectingState();
		}
	}

	private void OnClick()
	{
		//IL_02aa: Expected I, but got Obj
		//IL_02c0: Expected Obj, but got I
		//IL_03ad: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0071: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0093: Expected I4, but got Obj
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_01c2: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_00e7: Expected I, but got Obj
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I4
		//IL_0281: Expected Obj, but got F4
		//IL_0203: Expected I, but got Obj
		//IL_0327: Expected I4, but got Obj
		//IL_038f: Expected VT, but got Obj
		//IL_024b: Expected Obj, but got I4
		//IL_0254: Expected Obj, but got F4
		//IL_0175: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v65 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("FACEBOOK_LOGIN");
		titleLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("FACEBOOK_EARN_COINS_DESCRIPTION");
		_description.fontSize = (int)text2;
		_priceLabel.fontSize = (int)"5000";
		string text3 = Strings.GetDefault("SOCIAL_BUTTON_FEEDBACK_CONNECTING");
		_connectingLabel.fontSize = (int)text3;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_getLabel).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v50 (Il2CppClass<Strings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v57 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault("COIN_BUTTON_EARNER_GET");
			_getLabel.fontSize = (int)text4;
		}
		nint num7 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v21 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v46 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = default;
		object obj5 = obj6 + 24;
		object obj7 = obj6 + 16;
		object obj8 = obj6 + 8;
		bool allAssetBundlesDownloaded = UserSave.allAssetBundlesDownloaded;
		UIAnchor uIAnchor = contentAnchor;
		if (allAssetBundlesDownloaded)
		{
			obj7 = 0;
			obj7 = 34f;
			_ = -2f;
			obj8 = obj7;
			obj5 = obj8;
		}
		else
		{
			obj7 = 0;
			obj7 = 64f;
			_ = -2f;
			obj6 = obj7;
			obj5 = obj6;
		}
		uIAnchor.pixelOffset = (Vector2)obj5;
	}

	public void GoToActiveState()
	{
		this._002Ector();
		if (this.m_onFacebookClick != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public void GoToConnectingState()
	{
		//IL_0024: Expected Obj, but got I4
		activeContent.tag = (string)1;
		connectingContent.tag = null;
		BoxCollider component = GetComponent<BoxCollider>();
		component.isTrigger = true;
	}

	public FacebookRewardsButton()
	{
		//IL_0030: Expected Obj, but got I4
		activeContent.tag = null;
		connectingContent.tag = (string)1;
		BoxCollider component = GetComponent<BoxCollider>();
		component.isTrigger = false;
	}
}
