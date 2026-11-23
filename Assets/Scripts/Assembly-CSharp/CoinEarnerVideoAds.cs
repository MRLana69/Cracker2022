using System;
using Cpp2ILInjected;
using UnityEngine;

public class CoinEarnerVideoAds : MonoBehaviour
{
	public enum ButtonState
	{
		Loading,
		NoVideo,
		VideoReady
	}

	private GameObject _videoAvailableGameObject;

	private GameObject _loadingGameObject;

	private GameObject _noVideosGameObject;

	private GameObject _contentMinibox;

	private GameObject _contentKeys;

	private UISprite _fillOverlay;

	private UISprite _backgroundFill;

	private UISprite _icon;

	private UILabel _title;

	private UILabel _description;

	private UILabel _priceLabelKeys;

	private int _earnCurrencyProfileIndex;

	private Action _onClickDelegate;

	private ButtonState _currentButtonState;

	private static VideoAdsManager _adsManagerInstance;

	private UIButtonColor _btColor;

	private string _defaultTitle;

	private string _defaultDescription;

	private int _defaultPrice;

	private const string BG_SPRITENAME_ACTIVE_DEFAULT = "button_fill_shopItem_main";

	private const string BG_SPRITENAME_OVERLAY_DEFAULT = "button_fill_shopItem_highlight";

	private const string BG_SPRITENAME_ACTIVE_SPECIAL = "button_fill_shopItem_main_sale";

	private const string BG_SPRITENAME_OVERLAY_SPECIAL = "button_fill_shopItem_highlight_sale";

	private const string BG_SPRITENAME_INACTIVE = "button_generic_1";

	public void Init(int earnCurrencyProfileIndex, string title, string desc, string iconName, int price, Action onClickDelegate, UIScrollView _panel)
	{
		_defaultTitle = title;
		_defaultDescription = desc;
		_onClickDelegate = onClickDelegate;
		_earnCurrencyProfileIndex = earnCurrencyProfileIndex;
		_defaultPrice = price;
		_icon.spriteName = iconName;
		GameObject gameObject = base.gameObject;
		UIDragScrollView component = gameObject.GetComponent<UIDragScrollView>();
		component.scrollView = _panel;
		GetVideoState();
	}

	private unsafe void SetButtonText(string title, string desc, int price, bool keys)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_title.text = title;
		_description.text = desc;
		if (keys && _priceLabelKeys != null)
		{
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			_priceLabelKeys.text = text;
		}
	}

	private void OnClick()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		object obj3 = _currentButtonState - 1;
		if (_currentButtonState != ButtonState.NoVideo)
		{
			if ((nint)obj3 == 1)
			{
				_ = 2;
				_ = -1;
				obj = (Enum)(object)typeof(ButtonState);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
				_ = 0;
				string text = obj.ToString();
				string text2 = text + string.Empty;
				EarnCoinsData.Trigger(_earnCurrencyProfileIndex);
				Action onClickDelegate = _onClickDelegate;
				if (_onClickDelegate != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
		else
		{
			_ = 1;
			_ = -1;
			obj = (Enum)(object)typeof(ButtonState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string text3 = obj.ToString();
			string text4 = text3 + string.Empty;
			_adsManagerInstance.TryCachingVideosAgain();
		}
	}

	private void Awake()
	{
		VideoAdsManager instance = VideoAdsManager.instance;
		_adsManagerInstance = instance;
	}

	private void SetButtonState(ButtonState state)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		_currentButtonState = state;
		SetStateGameObjectActive(state switch
		{
			ButtonState.VideoReady => (GameObject)(this + 12), 
			ButtonState.Loading => (GameObject)(this + 16), 
			ButtonState.NoVideo => (GameObject)(this + 20), 
			_ => (GameObject)(this + 16), 
		});
	}

	private unsafe void SetStateGameObjectActive(GameObject go)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0770: Expected Obj, but got VT
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected Obj, but got Unknown
		//IL_07a2: Expected Obj, but got VT
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_07f7: Expected Obj, but got VT
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected VT, but got Unknown
		//IL_089b: Expected Obj, but got VT
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected Obj, but got Unknown
		//IL_08cd: Expected Obj, but got VT
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected Obj, but got Unknown
		//IL_0922: Expected Obj, but got VT
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got Unknown
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected VT, but got Unknown
		//IL_097e: Expected Obj, but got VT
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected Obj, but got Unknown
		//IL_09b0: Expected Obj, but got VT
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e1: Expected Obj, but got Unknown
		//IL_0a05: Expected Obj, but got VT
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected Obj, but got Unknown
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Expected VT, but got Unknown
		//IL_0c96: Expected Obj, but got VT
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca4: Expected Obj, but got Unknown
		//IL_0cc8: Expected Obj, but got VT
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected Obj, but got Unknown
		//IL_0d1d: Expected Obj, but got VT
		//IL_0d26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2b: Expected Obj, but got Unknown
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected VT, but got Unknown
		//IL_0a66: Expected Obj, but got VT
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected Obj, but got Unknown
		//IL_0a98: Expected Obj, but got VT
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected Obj, but got Unknown
		//IL_0aed: Expected Obj, but got VT
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Expected Obj, but got Unknown
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Expected VT, but got Unknown
		//IL_0b49: Expected Obj, but got VT
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected Obj, but got Unknown
		//IL_0b7b: Expected Obj, but got VT
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Expected Obj, but got Unknown
		//IL_0bd0: Expected Obj, but got VT
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected Obj, but got Unknown
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Expected VT, but got Unknown
		//IL_0251: Expected Obj, but got VT
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_0283: Expected Obj, but got VT
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_02d8: Expected Obj, but got VT
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected VT, but got Unknown
		//IL_037c: Expected Obj, but got VT
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03ae: Expected Obj, but got VT
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_0403: Expected Obj, but got VT
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected VT, but got Unknown
		//IL_045f: Expected Obj, but got VT
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_0491: Expected Obj, but got VT
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected Obj, but got Unknown
		//IL_04e6: Expected Obj, but got VT
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected VT, but got Unknown
		//IL_0547: Expected Obj, but got VT
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_0579: Expected Obj, but got VT
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_05ce: Expected Obj, but got VT
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected VT, but got Unknown
		//IL_062a: Expected Obj, but got VT
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_065c: Expected Obj, but got VT
		//IL_0686: Expected F4, but got I
		//IL_0681: Expected native int or pointer, but got VT
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected Obj, but got Unknown
		//IL_06b9: Expected Obj, but got VT
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected Obj, but got Unknown
		//IL_06f1: Expected F4, but got I
		//IL_06ec: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 352);
		if (_videoAvailableGameObject != null)
		{
			_videoAvailableGameObject.SetActive(value: false);
		}
		if (_loadingGameObject != null)
		{
			_loadingGameObject.SetActive(value: false);
		}
		if (_noVideosGameObject != null)
		{
			_noVideosGameObject.SetActive(value: false);
		}
		if (go != null)
		{
			go.SetActive(value: true);
		}
		if (go == _videoAvailableGameObject || go == _noVideosGameObject)
		{
			if (_currentButtonState == ButtonState.VideoReady)
			{
				VideoAdsManager instance = VideoAdsManager.instance;
				if (instance.IsVideoForKeysAvailable())
				{
					string title = Strings.Get(StringID.EARN_KEYS_SPONSORED_VIDEO);
					string desc = Strings.Get(StringID.EARN_KEYS_SPONSORED_VIDEO_DESCRIPTION);
					VideoAdsManager instance2 = VideoAdsManager.instance;
					int amountOfKeysRewardedForVideo = instance2.GetAmountOfKeysRewardedForVideo();
					SetButtonText(title, desc, amountOfKeysRewardedForVideo, keys: true);
					_contentKeys.SetActive(value: true);
					_contentMinibox.SetActive(value: false);
					_backgroundFill.spriteName = "button_fill_shopItem_main_sale";
					object obj2 = GlobalColors.COLOR_WHITE >> 16;
					object obj3 = obj2 & 0xFF;
					float num = (float)obj3 / 255f;
					object obj4 = GlobalColors.COLOR_WHITE >> 24;
					float num2 = (float)obj4 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+158]");
					_ = 0;
					object obj5 = GlobalColors.COLOR_WHITE & 0xFF;
					float num3 = (float)obj5 / 255f;
					object obj6 = GlobalColors.COLOR_WHITE >> 8;
					object obj7 = obj6 & 0xFF;
					float num4 = (float)obj7 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+150]");
					_ = 0;
					Color color2 = color - -64;
					_backgroundFill.color = color2;
					_fillOverlay.spriteName = "button_fill_shopItem_highlight_sale";
					AddButtonColor(_backgroundFill);
					GameObject gameObject = _fillOverlay.gameObject;
					gameObject.SetActive(value: true);
					object obj8 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_KEYS >> 16;
					object obj9 = obj8 & 0xFF;
					float num5 = (float)obj9 / 255f;
					object obj10 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_KEYS >> 24;
					float num6 = (float)obj10 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
					_ = 0;
					object obj11 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_KEYS & 0xFF;
					float num7 = (float)obj11 / 255f;
					object obj12 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_KEYS >> 8;
					object obj13 = obj12 & 0xFF;
					float num8 = (float)obj13 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+140]");
					_ = 0;
					Color color3 = color + 48;
					_title.color = color3;
					object obj14 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_KEYS >> 16;
					object obj15 = obj14 & 0xFF;
					float num9 = (float)obj15 / 255f;
					object obj16 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_KEYS >> 24;
					float num10 = (float)obj16 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+138]");
					_ = 0;
					object obj17 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_KEYS & 0xFF;
					float num11 = (float)obj17 / 255f;
					object obj18 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_KEYS >> 8;
					object obj19 = obj18 & 0xFF;
					float num12 = (float)obj19 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+130]");
					_ = 0;
					Color effectColor = color + 32;
					_title.effectColor = effectColor;
					object obj20 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_KEYS >> 16;
					object obj21 = obj20 & 0xFF;
					float num13 = (float)obj21 / 255f;
					object obj22 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_KEYS >> 24;
					float num14 = (float)obj22 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+128]");
					_ = 0;
					object obj23 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_KEYS & 0xFF;
					float num15 = (float)obj23 / 255f;
					object obj24 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_KEYS >> 8;
					object obj25 = obj24 & 0xFF;
					float num16 = (float)obj25 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+120]");
					_ = 0;
					Color color4 = color + 16;
					_description.color = color4;
					object obj26 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_KEYS >> 16;
					object obj27 = obj26 & 0xFF;
					float num17 = (float)obj27 / 255f;
					object obj28 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_KEYS >> 24;
					float num18 = (float)obj28 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+118]");
					((Color*)(nint)color)->b = 0f;
					object obj29 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_KEYS & 0xFF;
					float num19 = (float)obj29 / 255f;
					object obj30 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_KEYS >> 8;
					object obj31 = obj30 & 0xFF;
					float num20 = (float)obj31 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+110]");
					((Color*)(nint)color)->r = 0f;
					_description.effectColor = color;
					return;
				}
			}
			SetButtonText(_defaultTitle, _defaultDescription, _defaultPrice, keys: false);
			_contentKeys.SetActive(value: false);
			_contentMinibox.SetActive(value: true);
			_backgroundFill.spriteName = "button_fill_shopItem_main";
			object obj32 = GlobalColors.COLOR_WHITE >> 16;
			object obj33 = obj32 & 0xFF;
			float num21 = (float)obj33 / 255f;
			object obj34 = GlobalColors.COLOR_WHITE >> 24;
			float num22 = (float)obj34 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+108]");
			_ = 0;
			object obj35 = GlobalColors.COLOR_WHITE & 0xFF;
			float num23 = (float)obj35 / 255f;
			object obj36 = GlobalColors.COLOR_WHITE >> 8;
			object obj37 = obj36 & 0xFF;
			float num24 = (float)obj37 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+100]");
			_ = 0;
			Color color5 = color + 144;
			_backgroundFill.color = color5;
			_fillOverlay.spriteName = "button_fill_shopItem_highlight";
			AddButtonColor(_backgroundFill);
			GameObject gameObject2 = _fillOverlay.gameObject;
			gameObject2.SetActive(value: true);
			object obj38 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_COINS >> 16;
			object obj39 = obj38 & 0xFF;
			float num25 = (float)obj39 / 255f;
			object obj40 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_COINS >> 24;
			float num26 = (float)obj40 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+F8]");
			_ = 0;
			object obj41 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_COINS & 0xFF;
			float num27 = (float)obj41 / 255f;
			object obj42 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_COINS >> 8;
			object obj43 = obj42 & 0xFF;
			float num28 = (float)obj43 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+F0]");
			_ = 0;
			Color color6 = color + 128;
			_title.color = color6;
			object obj44 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_COINS >> 16;
			object obj45 = obj44 & 0xFF;
			float num29 = (float)obj45 / 255f;
			object obj46 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_COINS >> 24;
			float num30 = (float)obj46 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E8]");
			_ = 0;
			object obj47 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_COINS & 0xFF;
			float num31 = (float)obj47 / 255f;
			object obj48 = GlobalColors.WATCH_VIDEO_FOR_COINS_TITLE_SHADOW_COINS >> 8;
			object obj49 = obj48 & 0xFF;
			float num32 = (float)obj49 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
			_ = 0;
			Color effectColor2 = color + 112;
			_title.effectColor = effectColor2;
			object obj50 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_COINS >> 16;
			object obj51 = obj50 & 0xFF;
			float num33 = (float)obj51 / 255f;
			object obj52 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_COINS >> 24;
			float num34 = (float)obj52 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D8]");
			_ = 0;
			object obj53 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_COINS & 0xFF;
			float num35 = (float)obj53 / 255f;
			object obj54 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_COINS >> 8;
			object obj55 = obj54 & 0xFF;
			float num36 = (float)obj55 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D0]");
			_ = 0;
			Color color7 = color + 96;
			_description.color = color7;
			object obj56 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_COINS >> 16;
			object obj57 = obj56 & 0xFF;
			float num37 = (float)obj57 / 255f;
			object obj58 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_COINS >> 24;
			float num38 = (float)obj58 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
			_ = 0;
			object obj59 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_COINS & 0xFF;
			float num39 = (float)obj59 / 255f;
			object obj60 = GlobalColors.WATCH_VIDEO_FOR_COINS_DESCRIPTION_SHADOW_COINS >> 8;
			object obj61 = obj60 & 0xFF;
			float num40 = (float)obj61 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
			_ = 0;
			Color effectColor3 = color + 80;
			_description.effectColor = effectColor3;
		}
		else
		{
			if (_btColor != null)
			{
				UnityEngine.Object.Destroy(_btColor);
			}
			GameObject gameObject3 = _fillOverlay.gameObject;
			gameObject3.SetActive(value: false);
			object obj62 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE >> 16;
			object obj63 = obj62 & 0xFF;
			float num41 = (float)obj63 / 255f;
			object obj64 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE >> 24;
			float num42 = (float)obj64 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
			_ = 0;
			object obj65 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE & 0xFF;
			float num43 = (float)obj65 / 255f;
			object obj66 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE >> 8;
			object obj67 = obj66 & 0xFF;
			float num44 = (float)obj67 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
			_ = 0;
			Color color8 = color + 160;
			_backgroundFill.color = color8;
			_backgroundFill.spriteName = "button_generic_1";
		}
	}

	private void AddButtonColor(UISprite tweenTarget)
	{
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got VT
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00bc: Expected VT, but got F4
		//IL_00cb: Expected Obj, but got VT
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got VT
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got VT
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_017a: Expected VT, but got F4
		//IL_0189: Expected Obj, but got VT
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01bb: Expected Obj, but got VT
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		object obj = this + 68;
		if (_btColor != null)
		{
			UnityEngine.Object.Destroy((UnityEngine.Object)obj);
		}
		GameObject gameObject = base.gameObject;
		UIButtonColor btColor = gameObject.AddComponent<UIButtonColor>();
		_btColor = btColor;
		UIButtonColor btColor2 = _btColor;
		GameObject tweenTarget2 = tweenTarget.gameObject;
		btColor2.tweenTarget = tweenTarget2;
		UIButtonColor btColor3 = _btColor;
		object obj2 = GlobalColors.COLOR_WHITE >> 24;
		float num = (float)obj2 / 255f;
		object obj3 = GlobalColors.COLOR_WHITE & 0xFF;
		float num2 = (float)obj3 / 255f;
		btColor3.hover = (Color)num2;
		object obj4 = GlobalColors.COLOR_WHITE >> 16;
		object obj5 = obj4 & 0xFF;
		float num3 = (float)obj5 / 255f;
		object obj6 = GlobalColors.COLOR_WHITE >> 8;
		object obj7 = obj6 & 0xFF;
		float num4 = (float)obj7 / 255f;
		UIButtonColor btColor4 = _btColor;
		object obj8 = GlobalColors.COLOR_PRESSED >> 24;
		float num5 = (float)obj8 / 255f;
		object obj9 = GlobalColors.COLOR_PRESSED & 0xFF;
		float num6 = (float)obj9 / 255f;
		btColor4.pressed = (Color)num6;
		object obj10 = GlobalColors.COLOR_PRESSED >> 16;
		object obj11 = obj10 & 0xFF;
		float num7 = (float)obj11 / 255f;
		object obj12 = GlobalColors.COLOR_PRESSED >> 8;
		object obj13 = obj12 & 0xFF;
		float num8 = (float)obj13 / 255f;
		UIButtonColor btColor5 = _btColor;
		btColor5.duration = 0.05f;
	}

	private unsafe void OnEnable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CoinEarnerVideoAds.GetVideoState));
		_adsManagerInstance.AddOnVideoStateChangedHandler(action);
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(CoinEarnerVideoAds.GetVideoState));
		_adsManagerInstance.AddOnKeyVideoWatchedChangedHandler(action2);
		GameObject gameObject = base.gameObject;
		UIDragScrollView component = gameObject.GetComponent<UIDragScrollView>();
		bool flag = component.scrollView != null;
	}

	private unsafe void OnDisable()
	{
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CoinEarnerVideoAds.GetVideoState));
		_adsManagerInstance.RemoveOnVideoStateChangedHandler(action);
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(CoinEarnerVideoAds.GetVideoState));
		_adsManagerInstance.RemoveOnKeyVideoWatchedChangedHandler(action2);
	}

	private void GetVideoState()
	{
		//IL_003a: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0050: Expected I4, but got Obj
		VideoAdsManager adsManagerInstance = _adsManagerInstance;
		bool flag = (byte)(~(Globals.DEBUG_SKIP_VIDEO_ADS ? 1u : 0u)) != 0;
		bool flag2 = !flag;
		ButtonState buttonState = ButtonState.VideoReady;
		if (!flag2)
		{
			if (adsManagerInstance.currentVideoState__BackingField > VideoAdsManager.VideoState.NoVideos)
			{
				return;
			}
			object obj = (int)adsManagerInstance.currentVideoState__BackingField << 2;
			object obj2 = obj + 2281092;
			buttonState = (ButtonState)obj2;
		}
		SetButtonState(buttonState);
	}
}
