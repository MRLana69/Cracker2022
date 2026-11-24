using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using Info.VideoRewardCooldowns;
using Kiloo.Plugins.Facebook;
using SYBO.Subway.Info;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Popups;
using UI.Popups.ConsumablesPopupInternal;
using UI.RenderTexture;
using UnityEngine;
using UnityEngine.U2D;

namespace UI.Screens;

public class FbPromotionPopup : UIScreen
{
	private sealed class _003CRunAnimations_003Ed__40(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FbPromotionPopup _003C_003E4__this;

		private float _003CstarAnimationTime_003E5__2;

		private int _003Cx_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Expected Obj, but got Unknown
				//IL_00e7: Expected Obj, but got I4
				//IL_036d: Expected Obj, but got I4
				//IL_041d: Expected Obj, but got I4
				//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c9: Expected Obj, but got Unknown
				//IL_03e5: Expected Obj, but got I4
				//IL_016e: Expected Obj, but got I4
				//IL_018c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0191: Expected Obj, but got Unknown
				//IL_01ad: Expected Obj, but got I4
				//IL_0543: Unknown result type (might be due to invalid IL or missing references)
				//IL_0548: Expected Obj, but got Unknown
				//IL_0564: Expected Obj, but got I4
				//IL_020e: Expected Obj, but got I4
				//IL_045d: Expected Obj, but got I4
				//IL_046a: Expected Obj, but got I4
				//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dc: Expected Obj, but got Unknown
				//IL_02f8: Expected Obj, but got I4
				//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_05cc: Expected Obj, but got Unknown
				//IL_026c: Expected Obj, but got I4
				//IL_0279: Expected Obj, but got I4
				//IL_0298: Unknown result type (might be due to invalid IL or missing references)
				//IL_029d: Expected Obj, but got Unknown
				//IL_04e4: Expected Obj, but got I4
				//IL_04f1: Expected Obj, but got I4
				//IL_0510: Expected Obj, but got I4
				FbPromotionPopup fbPromotionPopup = _003C_003E4__this;
				Sprite sprite = default;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							int num = _003Cx_003E5__3 + 1;
							_003Cx_003E5__3 = num;
							goto IL_034d;
						}
						if (_003C_003E1__state == 3)
						{
							_003C_003E1__state = -1;
							IEnumerator enumerator = fbPromotionPopup._buttonBounce.GetEnumerator();
							bool isPlaying = fbPromotionPopup._buttonBounce.isPlaying;
							float frameRate = ((AnimationClip)isPlaying).frameRate;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							object obj = this + 12;
							object obj2 = default;
							obj = obj2;
							_003C_003E1__state = 4;
							return 1;
						}
						if (_003C_003E1__state == 4)
						{
							_003C_003E1__state = -1;
							List<GameObject> stars = fbPromotionPopup._stars;
							int index = stars._size - 1;
							GameObject gameObject = fbPromotionPopup._stars.get_Item(index);
							int layer = gameObject.layer;
							int siblingIndex = ((Transform)layer).GetSiblingIndex();
							while ((nint)sprite < siblingIndex)
							{
								List<GameObject> stars2 = fbPromotionPopup._stars;
								int index2 = stars2._size - 1;
								GameObject gameObject2 = fbPromotionPopup._stars.get_Item(index2);
								int layer2 = gameObject2.layer;
								bool flag = ((SpriteAtlas)layer2).CanBindTo(sprite);
								Animation component = ((Component)flag).GetComponent<Animation>();
								IEnumerator enumerator2 = component.GetEnumerator();
								Sprite sprite2 = (Sprite)(sprite + 1);
								sprite = sprite2;
							}
							IEnumerator enumerator3 = fbPromotionPopup._buttonSlideStar.GetEnumerator();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							_ = 4f;
							object obj3 = this + 12;
							object obj4 = default;
							obj3 = obj4;
							_003C_003E1__state = 5;
							return 1;
						}
						if (_003C_003E1__state != 5)
						{
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						_003CstarAnimationTime_003E5__2 = 0f;
					}
					if (~(fbPromotionPopup._runAnimations ? 1u : 0u) == 0)
					{
						_003Cx_003E5__3 = 0;
						goto IL_034d;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 2f;
				object obj5 = this + 12;
				object obj6 = default;
				obj5 = obj6;
				_003C_003E1__state = 1;
				return 1;
				IL_034d:
				List<GameObject> stars3 = fbPromotionPopup._stars;
				object obj7 = stars3._size - 1;
				if (_003Cx_003E5__3 >= (nint)obj7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					float num2 = _003CstarAnimationTime_003E5__2 - fbPromotionPopup._starCountDown;
					object obj8 = this + 12;
					object obj9 = default;
					obj8 = obj9;
					_003C_003E1__state = 3;
					return 1;
				}
				GameObject gameObject3 = fbPromotionPopup._stars.get_Item(_003Cx_003E5__3);
				int layer3 = gameObject3.layer;
				int siblingIndex2 = ((Transform)layer3).GetSiblingIndex();
				while ((nint)sprite < siblingIndex2)
				{
					GameObject gameObject4 = fbPromotionPopup._stars.get_Item(_003Cx_003E5__3);
					int layer4 = gameObject4.layer;
					bool flag2 = ((SpriteAtlas)layer4).CanBindTo(sprite);
					Animation component2 = ((Component)flag2).GetComponent<Animation>();
					IEnumerator enumerator4 = component2.GetEnumerator();
					if (!(_003CstarAnimationTime_003E5__2 > 0f))
					{
						GameObject gameObject5 = fbPromotionPopup._stars.get_Item(_003Cx_003E5__3);
						int layer5 = gameObject5.layer;
						bool flag3 = ((SpriteAtlas)layer5).CanBindTo(sprite);
						Animation component3 = ((Component)flag3).GetComponent<Animation>();
						bool isPlaying2 = component3.isPlaying;
						float frameRate2 = ((AnimationClip)isPlaying2).frameRate;
						_003CstarAnimationTime_003E5__2 = frameRate2;
					}
					Sprite sprite3 = (Sprite)(sprite + 1);
					sprite = sprite3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = fbPromotionPopup._starCountDown;
				object obj10 = this + 12;
				object obj11 = default;
				obj10 = obj11;
				_003C_003E1__state = 2;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			((Cooldowns)(object)"headstart")._002Ector();
		}

		private bool MoveNext()
		{
			//IL_00de: Expected I, but got Obj
			//IL_00f4: Expected Obj, but got I
			//IL_0153: Expected I, but got Obj
			//IL_0169: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			nint num3 = (nint)typeof(SellConsumablesHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SellConsumablesHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v11 (Il2CppClass<UI.Popups.ConsumablesPopupInternal.SellConsumablesHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B30");
			Dictionary<UpgradeType, string> dictionary = default;
			string key = dictionary.get_Item(UpgradeType.headstart2000);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8475");
			Dictionary<UpgradeType, int> dictionary2 = default;
			int defaultValue = dictionary2.get_Item(UpgradeType.headstart2000);
			return (byte)((OnlineSettings)(object)saveDataPath).GetValue(key, (uint)defaultValue) != 0;
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

	private UILabel _headlineLabel;

	private UILabel _sublineLabel;

	private UISprite _0BackgroundSprite;

	private UISprite _1BackgroundSprite;

	private UISprite _coinSignSprite;

	private UISprite _coinSignTriangleSprite;

	private UISprite _coinSignBGSprite;

	private UISprite _coinSignTriangleBGSprite;

	private UILabel _coinSignAmountLabel;

	private UILabel _coinSignTextLabel;

	private Layout _coinSignLayout;

	private UISprite _dinoSignSprite;

	private UISprite _dinoSignTriangleSprite;

	private UISprite _dinoSignBGSprite;

	private UISprite _dinoSignTriangleBGSprite;

	private UILabel _dinoSignTextLabel;

	private UISprite _coinGlowSprite;

	private UILabel _buttonLabel;

	private GameObject _facebookLogoSprite;

	private List<GameObject> _starPosition;

	private GameObject _starPrefab;

	private float _starCountDown;

	private Animation _buttonBounce;

	private Animation _buttonSlideStar;

	private FacebookDinoLogoRenderTextureSetup _dinoCharacterRenderTextureSetup;

	private const int COIN_REWARD_AMOUNT = 5000;

	private static Action<FacebookRewardsInfo.FacebookRewardType, int> m_OnFacebookRewardPaidOut;

	private static Action<Characters.CharacterId, int> m_OnFacebookCharacterReceived;

	private List<GameObject> _stars;

	private bool _runAnimations;

	public static event Action<FacebookRewardsInfo.FacebookRewardType, int> OnFacebookRewardPaidOut
	{
		add
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
		remove
		{
			Delegate onFacebookRewardPaidOut = FbPromotionPopup.m_OnFacebookRewardPaidOut;
			Action<FacebookRewardsInfo.FacebookRewardType, int> onFacebookRewardPaidOut2 = default;
			while (true)
			{
				Delegate obj = onFacebookRewardPaidOut.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)FbPromotionPopup.m_OnFacebookRewardPaidOut == onFacebookRewardPaidOut)
				{
					FbPromotionPopup.m_OnFacebookRewardPaidOut = onFacebookRewardPaidOut2;
				}
				if ((object)FbPromotionPopup.m_OnFacebookRewardPaidOut != onFacebookRewardPaidOut)
				{
					onFacebookRewardPaidOut = FbPromotionPopup.m_OnFacebookRewardPaidOut;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<Characters.CharacterId, int> OnFacebookCharacterReceived
	{
		add
		{
			Delegate onFacebookRewardPaidOut = FbPromotionPopup.m_OnFacebookRewardPaidOut;
			Action<FacebookRewardsInfo.FacebookRewardType, int> onFacebookRewardPaidOut2 = default;
			while (true)
			{
				Delegate obj = onFacebookRewardPaidOut.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)FbPromotionPopup.m_OnFacebookRewardPaidOut == onFacebookRewardPaidOut)
				{
					FbPromotionPopup.m_OnFacebookRewardPaidOut = onFacebookRewardPaidOut2;
				}
				if ((object)FbPromotionPopup.m_OnFacebookRewardPaidOut != onFacebookRewardPaidOut)
				{
					onFacebookRewardPaidOut = FbPromotionPopup.m_OnFacebookRewardPaidOut;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = FbPromotionPopup.m_OnFacebookCharacterReceived;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(FbPromotionPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<UI.Screens.FbPromotionPopup>)+5C]");
				object obj3 = (nint)0 + (nint)4;
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

	public override void Show()
	{
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		Delegate obj = FbPromotionPopup.m_OnFacebookCharacterReceived;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num = (nint)typeof(FbPromotionPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<UI.Screens.FbPromotionPopup>)+5C]");
			object obj3 = (nint)0 + (nint)4;
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

	private void OnEnable()
	{
		//IL_01ac: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_01f1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		base.Hide();
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v51 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v41 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v47 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
			return;
		}
		OnDisable();
		SetColors();
		if (_stars == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<GameObject> list = default;
			list._002Ector();
			object obj3 = this + 140;
			obj3 = list;
		}
		List<GameObject> starPosition = _starPosition;
		if (starPosition._size > 0)
		{
			List<GameObject> stars = _stars;
			if (stars._size < 1)
			{
				_runAnimations = true;
				ActivateDinoLogoAnimation();
			}
		}
	}

	private void Localization()
	{
		OnDinoLogoBecameInactive();
	}

	private void SetColors()
	{
		//IL_0199: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_0221: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I4
		//IL_00ac: Expected I4, but got Obj
		//IL_00ce: Expected I4, but got Obj
		//IL_00f0: Expected I4, but got Obj
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I4
		//IL_013f: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v38 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("FACEBOOK_PROMOTION_POPUP_HEADLINE");
		_headlineLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("FACEBOOK_PROMOTION_POPUP_SUBLINE");
		_sublineLabel.fontSize = (int)text2;
		string format = Strings.GetDefault("FACEBOOK_PROMOTION_COIN_CALLOUT_AMOUNT");
		object obj2 = 5000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text3 = string.Format(format, args);
		_coinSignAmountLabel.fontSize = (int)text3;
		string text4 = Strings.GetDefault("FACEBOOK_PROMOTION_COIN_CALLOUT");
		_coinSignTextLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("FACEBOOK_REWARDS_POPUP_CONNECT_BUTTON_TEXT");
		_buttonLabel.fontSize = (int)text5;
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v25 (Il2CppClass<SocialManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v34 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		bool flag = ((SocialManager)facebookDialogsSupported).HasFacebookAccessToken();
		string text6 = (string)((flag ? 1 : 0) ^ 1);
		_facebookLogoSprite.tag = text6;
		((RewardForVideoButton)(object)_coinSignLayout).Init((VideoButtonPayload)null);
	}

	private unsafe void OnDisable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected VT, but got Unknown
		//IL_006c: Expected F4, but got Obj
		//IL_0067: Expected native int or pointer, but got VT
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0094: Expected F4, but got Obj
		//IL_008f: Expected native int or pointer, but got VT
		//IL_00a9: Expected F4, but got I
		//IL_00a4: Expected native int or pointer, but got VT
		//IL_00b8: Expected I4, but got VT
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_011b: Expected F4, but got Obj
		//IL_0116: Expected native int or pointer, but got VT
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0143: Expected F4, but got Obj
		//IL_013e: Expected native int or pointer, but got VT
		//IL_0158: Expected F4, but got I
		//IL_0153: Expected native int or pointer, but got VT
		//IL_0167: Expected I4, but got VT
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I4
		//IL_018c: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01ca: Expected F4, but got Obj
		//IL_01c5: Expected native int or pointer, but got VT
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01f2: Expected F4, but got Obj
		//IL_01ed: Expected native int or pointer, but got VT
		//IL_0207: Expected F4, but got I
		//IL_0202: Expected native int or pointer, but got VT
		//IL_0216: Expected I4, but got VT
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0232: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_0244: Expected Obj, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_0279: Expected F4, but got Obj
		//IL_0274: Expected native int or pointer, but got VT
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_02a1: Expected F4, but got Obj
		//IL_029c: Expected native int or pointer, but got VT
		//IL_02b6: Expected F4, but got I
		//IL_02b1: Expected native int or pointer, but got VT
		//IL_02c5: Expected I4, but got VT
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02e1: Expected Obj, but got I4
		//IL_02ea: Expected Obj, but got I4
		//IL_02f3: Expected Obj, but got I4
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_0328: Expected F4, but got Obj
		//IL_0323: Expected native int or pointer, but got VT
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0350: Expected F4, but got Obj
		//IL_034b: Expected native int or pointer, but got VT
		//IL_0365: Expected F4, but got I
		//IL_0360: Expected native int or pointer, but got VT
		//IL_0374: Expected I4, but got VT
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_0390: Expected Obj, but got I4
		//IL_0399: Expected Obj, but got I4
		//IL_03a2: Expected Obj, but got I4
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03d7: Expected F4, but got Obj
		//IL_03d2: Expected native int or pointer, but got VT
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_03ff: Expected F4, but got Obj
		//IL_03fa: Expected native int or pointer, but got VT
		//IL_0414: Expected F4, but got I
		//IL_040f: Expected native int or pointer, but got VT
		//IL_0423: Expected I4, but got VT
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_044a: Expected Obj, but got I4
		//IL_0453: Expected Obj, but got I4
		//IL_045c: Expected Obj, but got I4
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0491: Expected F4, but got Obj
		//IL_048c: Expected native int or pointer, but got VT
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_04b9: Expected F4, but got Obj
		//IL_04b4: Expected native int or pointer, but got VT
		//IL_04ce: Expected F4, but got I
		//IL_04c9: Expected native int or pointer, but got VT
		//IL_04db: Expected I4, but got VT
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected Obj, but got Unknown
		//IL_04f7: Expected Obj, but got I4
		//IL_0500: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got I4
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected Obj, but got Unknown
		//IL_053e: Expected F4, but got Obj
		//IL_0539: Expected native int or pointer, but got VT
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_0566: Expected F4, but got Obj
		//IL_0561: Expected native int or pointer, but got VT
		//IL_057b: Expected F4, but got I
		//IL_0576: Expected native int or pointer, but got VT
		//IL_058a: Expected I4, but got VT
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected Obj, but got Unknown
		//IL_05a6: Expected Obj, but got I4
		//IL_05af: Expected Obj, but got I4
		//IL_05b8: Expected Obj, but got I4
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected Obj, but got Unknown
		//IL_05ed: Expected F4, but got Obj
		//IL_05e8: Expected native int or pointer, but got VT
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected Obj, but got Unknown
		//IL_0615: Expected F4, but got Obj
		//IL_0610: Expected native int or pointer, but got VT
		//IL_062a: Expected F4, but got I
		//IL_0625: Expected native int or pointer, but got VT
		//IL_0639: Expected I4, but got VT
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_0655: Expected Obj, but got I4
		//IL_065e: Expected Obj, but got I4
		//IL_0667: Expected Obj, but got I4
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_069c: Expected F4, but got Obj
		//IL_0697: Expected native int or pointer, but got VT
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected Obj, but got Unknown
		//IL_06c4: Expected F4, but got Obj
		//IL_06bf: Expected native int or pointer, but got VT
		//IL_06d9: Expected F4, but got I
		//IL_06d4: Expected native int or pointer, but got VT
		//IL_06e8: Expected I4, but got VT
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected Obj, but got Unknown
		//IL_0704: Expected Obj, but got I4
		//IL_070d: Expected Obj, but got I4
		//IL_0716: Expected Obj, but got I4
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected Obj, but got Unknown
		//IL_074b: Expected F4, but got Obj
		//IL_0746: Expected native int or pointer, but got VT
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected Obj, but got Unknown
		//IL_0773: Expected F4, but got Obj
		//IL_076e: Expected native int or pointer, but got VT
		//IL_0788: Expected F4, but got I
		//IL_0783: Expected native int or pointer, but got VT
		//IL_0797: Expected I4, but got VT
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got Unknown
		//IL_07b3: Expected Obj, but got I4
		//IL_07bc: Expected Obj, but got I4
		//IL_07c5: Expected Obj, but got I4
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected Obj, but got Unknown
		//IL_07fa: Expected F4, but got Obj
		//IL_07f5: Expected native int or pointer, but got VT
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected Obj, but got Unknown
		//IL_0822: Expected F4, but got Obj
		//IL_081d: Expected native int or pointer, but got VT
		//IL_0837: Expected F4, but got I
		//IL_0832: Expected native int or pointer, but got VT
		//IL_0846: Expected I4, but got VT
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected Obj, but got Unknown
		//IL_0862: Expected Obj, but got I4
		//IL_086b: Expected Obj, but got I4
		//IL_0874: Expected Obj, but got I4
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected Obj, but got Unknown
		//IL_08a9: Expected F4, but got Obj
		//IL_08a4: Expected native int or pointer, but got VT
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected Obj, but got Unknown
		//IL_08d1: Expected F4, but got Obj
		//IL_08cc: Expected native int or pointer, but got VT
		//IL_08e6: Expected F4, but got I
		//IL_08e1: Expected native int or pointer, but got VT
		//IL_08f5: Expected I4, but got VT
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected Obj, but got Unknown
		//IL_0911: Expected Obj, but got I4
		//IL_091a: Expected Obj, but got I4
		//IL_0923: Expected Obj, but got I4
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected Obj, but got Unknown
		//IL_0958: Expected F4, but got Obj
		//IL_0953: Expected native int or pointer, but got VT
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Expected Obj, but got Unknown
		//IL_0980: Expected F4, but got Obj
		//IL_097b: Expected native int or pointer, but got VT
		//IL_0995: Expected F4, but got I
		//IL_0990: Expected native int or pointer, but got VT
		//IL_09a4: Expected I4, but got VT
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected Obj, but got Unknown
		//IL_09cd: Expected F4, but got Obj
		//IL_09c8: Expected native int or pointer, but got VT
		//IL_09e2: Expected F4, but got I
		//IL_09dd: Expected native int or pointer, but got VT
		//IL_09f1: Expected I4, but got VT
		//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a04: Expected Obj, but got Unknown
		//IL_0a0d: Expected Obj, but got I4
		//IL_0a16: Expected Obj, but got I4
		//IL_0a1f: Expected Obj, but got I4
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		//IL_0a54: Expected F4, but got Obj
		//IL_0a4f: Expected native int or pointer, but got VT
		//IL_0a6e: Expected F4, but got Obj
		//IL_0a69: Expected native int or pointer, but got VT
		//IL_0a83: Expected F4, but got I
		//IL_0a7e: Expected native int or pointer, but got VT
		//IL_0a92: Expected I4, but got VT
		object obj2 = default;
		object obj = obj2 + 368;
		obj = 0;
		obj = 0;
		obj = 7;
		_ = 41;
		_ = 74;
		_ = -1;
		object obj3 = obj2 + 408;
		obj3 = obj;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 416);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		object obj4 = obj2 + 352;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v14+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_headlineLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj5 = obj2 + 348;
		obj5 = 0;
		obj5 = 0;
		obj5 = 3;
		_ = 116;
		_ = -91;
		_ = -1;
		object obj6 = obj2 + 404;
		obj6 = obj5;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		object obj7 = obj2 + 328;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v29+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_sublineLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj8 = obj2 + 324;
		obj8 = 0;
		obj8 = 0;
		obj8 = -117;
		_ = -51;
		_ = -22;
		_ = -1;
		object obj9 = obj2 + 400;
		obj9 = obj8;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		object obj10 = obj2 + 304;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v44+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_0BackgroundSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj11 = obj2 + 296;
		obj11 = 0;
		obj11 = 0;
		obj11 = -82;
		_ = -108;
		_ = -22;
		_ = -1;
		object obj12 = obj2 + 396;
		obj12 = obj11;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
		object obj13 = obj2 + 280;
		Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v59+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_1BackgroundSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj14 = obj2 + 272;
		obj14 = 0;
		obj14 = 0;
		obj14 = -1;
		_ = -52;
		_ = 0;
		_ = -1;
		object obj15 = obj2 + 392;
		obj15 = obj14;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
		object obj16 = obj2 + 256;
		Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v74+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_coinSignSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj17 = obj2 + 248;
		obj17 = 0;
		obj17 = 0;
		obj17 = -1;
		_ = -52;
		_ = 0;
		_ = -1;
		object obj18 = obj2 + 388;
		obj18 = obj17;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
		object obj19 = obj2 + 232;
		Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v89+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_coinSignTriangleSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj20 = this - -64;
		object obj21 = obj2 + 224;
		obj21 = 0;
		obj21 = 0;
		obj21 = -67;
		_ = 20;
		_ = 33;
		_ = -1;
		object obj22 = obj2 + 384;
		obj22 = obj21;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj22;
		object obj23 = obj2 + 208;
		Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S1_v105+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)obj20).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj24 = obj2 + 204;
		obj24 = 0;
		obj24 = 0;
		obj24 = -67;
		_ = 20;
		_ = 33;
		_ = -1;
		object obj25 = obj2 + 380;
		obj25 = obj24;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj25;
		object obj26 = obj2 + 184;
		Matrix4x4 matrix4x9 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S1_v120+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_coinSignTriangleBGSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj27 = obj2 + 176;
		obj27 = 0;
		obj27 = 0;
		obj27 = -67;
		_ = 20;
		_ = 33;
		_ = -1;
		object obj28 = obj2 + 376;
		obj28 = obj27;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj28;
		object obj29 = obj2 + 160;
		Matrix4x4 matrix4x10 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S1_v135+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_coinSignTextLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj30 = obj2 + 152;
		obj30 = 0;
		obj30 = 0;
		obj30 = -67;
		_ = 20;
		_ = 33;
		_ = -1;
		object obj31 = obj2 + 372;
		obj31 = obj30;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj31;
		object obj32 = obj2 + 136;
		Matrix4x4 matrix4x11 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S1_v150+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_coinSignAmountLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj33 = obj2 + 128;
		obj33 = 0;
		obj33 = 0;
		obj33 = 28;
		_ = 103;
		_ = -98;
		_ = -1;
		object obj34 = obj2 + 344;
		obj34 = obj33;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj34;
		object obj35 = obj2 + 112;
		Matrix4x4 matrix4x12 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S1_v165+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_dinoSignSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj36 = obj2 + 104;
		obj36 = 0;
		obj36 = 0;
		obj36 = 28;
		_ = 103;
		_ = -98;
		_ = -1;
		object obj37 = obj2 + 320;
		obj37 = obj36;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj37;
		object obj38 = obj2 + 88;
		Matrix4x4 matrix4x13 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S1_v180+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_dinoSignTriangleSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj39 = obj2 + 80;
		obj39 = 0;
		obj39 = 0;
		obj39 = 0;
		_ = 74;
		_ = -128;
		_ = -1;
		object obj40 = obj2 + 276;
		obj40 = obj39;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj40;
		object obj41 = obj2 - -64;
		Matrix4x4 matrix4x14 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S1_v195+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_dinoSignBGSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj42 = obj2 + 56;
		obj42 = 0;
		obj42 = 0;
		obj42 = 0;
		_ = 74;
		_ = -128;
		_ = -1;
		object obj43 = obj2 + 228;
		obj43 = obj42;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj43;
		object obj44 = obj2 + 40;
		Matrix4x4 matrix4x15 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S1_v210+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_dinoSignTriangleBGSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj45 = obj2 + 24;
		Color black = Color.black;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S1_v215+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_dinoSignTextLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj46 = obj2 + 16;
		obj46 = 0;
		obj46 = 0;
		obj46 = -1;
		_ = -23;
		_ = -112;
		_ = -1;
		object obj47 = obj2 + 200;
		obj47 = obj46;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj47;
		Matrix4x4 matrix4x16 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_coinGlowSprite.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	private void ActivateAnimations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_026b: Expected Obj, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		_runAnimations = false;
		DeactivateDinoLogoAnimation();
		if (_stars == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v81 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v90 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 72)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0305;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		goto IL_0305;
		IL_0305:
		throw new IndexOutOfRangeException();
	}

	private IEnumerator RunAnimations()
	{
		return (IEnumerator)_dinoSignSprite;
	}

	private void ActivateDinoLogoAnimation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_03a4: Expected Obj, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0260: Expected Obj, but got I4
		//IL_04be: Expected Obj, but got I4
		//IL_02c7: Expected Obj, but got I
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_00ac: Expected I, but got Obj
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_0149: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 56;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 40;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 32;
		obj6 = obj;
		_ = -1;
		object obj7 = obj2 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj5 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
		_ = 0;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v104 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num2 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v151 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S0_v122 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v144 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj11 = obj6 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj6 + obj13;
		obj14 = 106;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj6 + obj15;
			if ((nint)obj16 == 106)
			{
				object obj17 = obj6 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_04aa;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04aa;
		IL_04aa:
		bool flag = ((AwardsScreen)this).SetListContent();
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag);
	}

	private void OnDinoLogoBecameInactive()
	{
		((CharacterPromotionPopup)(object)_dinoCharacterRenderTextureSetup).OnCharacterPurchaseSuccess(Characters.CharacterId.slick, 1);
	}

	private void DeactivateDinoLogoAnimation()
	{
		OnConnectClicked();
	}

	public void OnConnectClicked()
	{
		((RenderTextureSetupBase)_dinoCharacterRenderTextureSetup).OnReleaseRenderTexture();
	}

	public void OnBackBtnClicked()
	{
		//IL_01e2: Expected I, but got Obj
		//IL_01f8: Expected Obj, but got I
		//IL_02ce: Expected Obj, but got I4
		//IL_0223: Expected I, but got Obj
		//IL_0239: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_030e: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0195: Expected I, but got Obj
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_0297: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0107: Expected I, but got Obj
		//IL_011d: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I4
		//IL_02b7: Expected Obj, but got I4
		//IL_0148: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (!((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v27 (Il2CppClass<SocialManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v45 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			object obj4 = default;
			object obj3 = obj4 + 16;
			obj3 = this;
			if (SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported2, obj4))
			{
				nint num6 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v35 (Il2CppClass<UIScreenController>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num7 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag).QueueMessage((string)1);
			}
		}
		nint num8 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num9 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v22 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).ClosePopup((GameObject)(object)screenName);
	}

	private void OnFacebookLoginResult(bool loggedIn)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 84;
		obj = loggedIn;
	}

	private void DeliverRemainingFacebookRewards()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		bool flag = ((SocialManager)facebookDialogsSupported).HasFacebookAccessToken();
	}
}
