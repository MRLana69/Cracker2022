using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Ads;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UI;
using UnityEngine;

public class NativeInterstitialHelper : MonoBehaviour
{
	private UILabel _callToActionLabel;

	private UILabel _titleLabel;

	private UILabel _descriptionLabel;

	private UILabel _sponsoredLabel;

	private UITexture _iconTexture;

	private UITexture _coverTexture;

	private Texture2D _icon;

	private Texture2D _cover;

	private const float ICON_ASPECT_RATIO = 1f;

	private const float ICON_ASPECT_RATIO_BUFFER = 0.1f;

	private const float COVER_ASPECT_RATIO = 1.9f;

	private const float COVER_ASPECT_RATIO_BUFFER = 0.1f;

	private Action m_onActionClicked;

	private Action m_onExitClicked;

	private Action m_onAdShown;

	private Action m_onAdHidden;

	private const string RTL_ALIGNED_LANGUAGES_REGEX = "\\p{IsArabic}|\\p{IsHebrew}|\\p{IsSyriac}|\\p{IsThaana}";

	private const string RTL_ALIGNED_ONLINESETTINGS_KEY = "native_adview_rtl_regex";

	private const string LANGUAGES_WITH_HEIGHT_ISSUES_REGEX = "\\p{IsThai}";

	private const string ADCHOICE_ONLINESETTINGS_KEY = "fb_adchoice_link";

	private int _spacing;

	private Vector2 _savedLabelSize;

	public event Action onActionClicked
	{
		add
		{
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onActionClicked;
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

	public event Action onExitClicked
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onActionClicked;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onExitClicked;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 48;
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

	public event Action onAdShown
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onExitClicked;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 48;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onAdShown;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 52;
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

	public event Action onAdHidden
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onAdShown;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 52;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onAdHidden;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 56;
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

	private void Awake()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_008e: Expected Obj, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00de: Expected Obj, but got I4
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = this + 8;
		obj = 0;
		object obj2 = this + 12;
		obj2 = 0;
		object obj3 = this + 16;
		obj3 = 0;
		object obj4 = this + 20;
		obj4 = 0;
		object obj5 = this + 24;
		obj5 = 0;
		object obj6 = this + 28;
		obj6 = 0;
		object obj7 = this + 32;
		obj7 = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(_icon);
		object obj9 = this + 36;
		obj9 = 0;
		UnityEngine.Object.DestroyImmediate(_cover);
		object obj10 = this + 40;
		obj10 = 0;
		this.m_onActionClicked = null;
	}

	private void Update()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_015e: Expected I4, but got Obj
		//IL_015e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_013e: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)"native_adview_rtl_regex");
		if (outfitForCharacter == null)
		{
			return;
		}
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		bool value = ((OnlineSettings)(object)saveDataPath2).GetValue("native_adview_rtl_regex", (byte)(int)"\\p{IsArabic}|\\p{IsHebrew}|\\p{IsSyriac}|\\p{IsThaana}" != 0);
	}

	public void OnExitClick()
	{
		//IL_003f: Expected Obj, but got I4
		string text = tag;
		if (((GameObject)(object)text).activeInHierarchy && Input.GetKeyDown((string)27))
		{
			OnActionClick();
		}
	}

	public void OnActionClick()
	{
		TransformExtensions.Reset((Transform)(object)this.m_onExitClicked);
		this._002Ector();
	}

	public void OnAdChoiceClick()
	{
		TransformExtensions.Reset((Transform)(object)this.m_onActionClicked);
		this._002Ector();
	}

	public bool UpdateAdObject(NativeInterstitialAdObject adObject)
	{
		return ((AdController)(object)_callToActionLabel).HasPriorityListChanged((AdLocation)(object)adObject);
	}

	private void UpdateLabelSpacing(NativeInterstitialAdObject adObject)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_onAdHidden;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)adObject);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 56;
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

	private void UpdateRTLLabels(NativeInterstitialAdObject adObject)
	{
		//IL_04c3: Expected I, but got Obj
		//IL_04d9: Expected Obj, but got I
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected Obj, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_067a: Expected I, but got Obj
		//IL_0690: Expected Obj, but got I
		//IL_032b: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_05ec: Expected I, but got Obj
		//IL_0602: Expected Obj, but got I
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected Obj, but got Unknown
		//IL_050e: Expected I4, but got Obj
		//IL_0224: Invalid comparison between Obj and F4
		//IL_03f8: Expected I, but got Obj
		//IL_025d: Invalid comparison between Obj and F4
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected Obj, but got Unknown
		//IL_0562: Expected Obj, but got I
		//IL_02ac: Invalid comparison between I and F4
		//IL_02ed: Invalid comparison between I and F4
		//IL_0296: Expected Obj, but got I4
		//IL_02d7: Expected Obj, but got I4
		//IL_0318: Expected Obj, but got I4
		nint num = (nint)typeof(Regex);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<System.Text.RegularExpressions.Regex>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Regex);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v126 (Il2CppClass<System.Text.RegularExpressions.Regex>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 16;
		object obj4 = obj3 + 8;
		if (((Regex)(object)adObject._title).IsMatch("\\p{IsThai}"))
		{
			UILabel titleLabel = _titleLabel;
			if (titleLabel.mSpacingY == 0)
			{
				_titleLabel.useFloatSpacing = (byte)_spacing != 0;
				UILabel titleLabel2 = _titleLabel;
				UILabel titleLabel3 = _titleLabel;
				obj4 = 0;
				obj4 = ((UIWidget)titleLabel2).mWidth;
				_ = ((UIWidget)titleLabel3).mHeight;
				obj3 = obj4;
				obj2 = obj3;
				object obj5 = this - -64;
				obj5 = obj2;
				_titleLabel.effectStyle = UILabel.Effect.Outline;
				UILabel titleLabel4 = _titleLabel;
				if (titleLabel4.mOverflow != UILabel.Overflow.ShrinkContent)
				{
					titleLabel4.mOverflow = UILabel.Overflow.ShrinkContent;
					((UIRect)titleLabel4).mChanged = true;
					titleLabel4.mShouldBeProcessed = true;
				}
				goto IL_066c;
			}
		}
		UILabel titleLabel5 = _titleLabel;
		if (titleLabel5.mSpacingY == _spacing)
		{
			_titleLabel.useFloatSpacing = false;
			_titleLabel.effectStyle = UILabel.Effect.Outline8;
			UILabel titleLabel6 = _titleLabel;
			if (titleLabel6.mOverflow != UILabel.Overflow.ClampContent)
			{
				titleLabel6.mOverflow = UILabel.Overflow.ClampContent;
				((UIRect)titleLabel6).mChanged = true;
				titleLabel6.mShouldBeProcessed = true;
			}
			object obj6 = this - -64;
			int height = (int)obj6;
			if (obj6 != obj6)
			{
				height = int.MinValue;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2.1474836E+09f))
			{
				height = int.MinValue;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2.1474836E+09f)))
			{
				height = int.MinValue;
			}
			_titleLabel.height = height;
			object obj7 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v37+4]");
			UIWidget uIWidget = (UIWidget)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v37+4]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v37+4]");
			if (num3 != 0)
			{
				uIWidget = (UIWidget)int.MinValue;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v37+4]");
				if (!(0f < 2.1474836E+09f))
				{
					uIWidget = (UIWidget)int.MinValue;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v37+4]");
					if (!(0f > -2.1474836E+09f))
					{
						uIWidget = (UIWidget)int.MinValue;
					}
				}
			}
			Color color = uIWidget.color;
		}
		goto IL_066c;
		IL_066c:
		nint num4 = (nint)typeof(Regex);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v26 (Il2CppClass<System.Text.RegularExpressions.Regex>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(Regex);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v74 (Il2CppClass<System.Text.RegularExpressions.Regex>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((Regex)(object)adObject._body).IsMatch("\\p{IsThai}"))
		{
			UILabel descriptionLabel = _descriptionLabel;
			if (descriptionLabel.mSpacingY == 0)
			{
				_descriptionLabel.useFloatSpacing = (byte)_spacing != 0;
				goto IL_05de;
			}
		}
		UILabel descriptionLabel2 = _descriptionLabel;
		if (descriptionLabel2.mSpacingY == _spacing)
		{
			_descriptionLabel.useFloatSpacing = false;
		}
		goto IL_05de;
		IL_05de:
		nint num6 = (nint)typeof(Regex);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v37 (Il2CppClass<System.Text.RegularExpressions.Regex>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(Regex);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v58 (Il2CppClass<System.Text.RegularExpressions.Regex>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((Regex)(object)adObject._callToActionText).IsMatch("\\p{IsThai}"))
		{
			UILabel callToActionLabel = _callToActionLabel;
			if (callToActionLabel.mSpacingY == 0)
			{
				_callToActionLabel.useFloatSpacing = true;
				return;
			}
		}
		UILabel callToActionLabel2 = _callToActionLabel;
		if (callToActionLabel2.mSpacingY == -6)
		{
			_callToActionLabel.useFloatSpacing = false;
		}
	}

	private bool ValidateAdObject(NativeInterstitialAdObject adObject)
	{
		//IL_025b: Expected Obj, but got I4
		//IL_0265: Expected I4, but got Obj
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_02a3: Expected I4, but got Obj
		//IL_00bb: Expected I4, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_00f1: Expected I4, but got Obj
		//IL_0127: Expected I4, but got Obj
		//IL_0135: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I
		//IL_0176: Expected I, but got Obj
		//IL_030d: Expected I, but got Obj
		//IL_0323: Expected Obj, but got I
		//IL_01e4: Expected I, but got Obj
		CameraSettings cameraSettings = (CameraSettings)0;
		AssetBundle assetBundle = AssetBundleCache.LoadAssetBundle((string)(object)this, (int)adObject);
		if ((object)assetBundle != null)
		{
			Log((string)(object)adObject);
			UpdateRTLLabels(adObject);
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v10 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v33 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("NATIVE_INTERSTITIAL_SPONSORED_TEXT");
			_sponsoredLabel.fontSize = (int)text;
			RenderTexture renderTextureFor = ((RenderTextureManager)null).GetRenderTextureFor((GameObject)(object)adObject._callToActionText, (AnimationClip)(object)_callToActionLabel, cameraSettings, true);
			_callToActionLabel.fontSize = (int)cameraSettings;
			RenderTexture renderTextureFor2 = ((RenderTextureManager)null).GetRenderTextureFor((GameObject)(object)adObject._title, (AnimationClip)(object)_titleLabel, cameraSettings, true);
			_titleLabel.fontSize = (int)cameraSettings;
			RenderTexture renderTextureFor3 = ((RenderTextureManager)null).GetRenderTextureFor((GameObject)(object)adObject._body, (AnimationClip)(object)_descriptionLabel, cameraSettings, true);
			_descriptionLabel.fontSize = (int)cameraSettings;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)adObject._iconImage))
			{
				Texture2D iconImage = adObject._iconImage;
			}
			else
			{
				Texture2D iconImage = _icon;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)adObject._coverImage))
			{
				Texture2D coverImage = adObject._coverImage;
			}
			else
			{
				Texture2D coverImage = _cover;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			return true;
		}
		return false;
	}

	private unsafe bool AdjustTextForLabel(string text, UILabel label, out string result, int minimumShownCharacters = 0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0490: Expected Obj, but got I
		//IL_04a3: Expected Obj, but got I4
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_04ba: Expected Obj, but got I4
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_04d1: Expected Obj, but got I4
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_04e8: Expected Obj, but got I4
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected Obj, but got Unknown
		//IL_0540: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I
		//IL_020f: Expected F8, but got I4
		//IL_024c: Expected F8, but got I4
		//IL_0289: Expected F8, but got I4
		//IL_0297: Expected F8, but got I4
		//IL_02d4: Expected F8, but got I4
		//IL_0311: Expected F8, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_06fc: Expected Obj, but got I
		//IL_0705: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got I4
		//IL_0430: Expected Obj, but got I
		//IL_046d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 60;
		object obj3 = obj2 + 56;
		object obj4 = obj2 + 28;
		IntPtr intPtr = default;
		if (intPtr == (IntPtr)0)
		{
			obj2 = 0;
			_ = 0;
			object obj5 = obj2 + 24;
			obj5 = 73;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12271");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			obj4 = 0;
			_ = 0;
			object obj6 = obj4 + 24;
			obj6 = 73;
			_ = 0;
			object obj7 = text + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5BBE");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5B73");
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v50+4]");
				if ((nint)0 != 0)
				{
					obj3 = obj6;
					obj = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120E");
				}
			}
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if ((nint)0 != 0)
				{
					obj3 = obj5;
					obj = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120E");
				}
			}
			object obj8 = default;
			if (obj8 != null)
			{
				return true;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [218554]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @123A");
		object obj9 = 0;
		object obj10 = obj9 + 20;
		obj10 = 0;
		object obj11 = obj9 + 24;
		obj11 = 73;
		object obj12 = obj9 + 4;
		obj12 = 0;
		object obj13 = obj9 + 28;
		obj13 = 0;
		_ = 0;
		_ = 73;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 73;
		_ = 0;
		object obj14 = obj9 + 92;
		obj14 = 0;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [456F7B]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C25");
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [456F7C]");
		object obj15;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [392B60]");
			obj15 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1504");
			object obj17 = default;
			object obj16 = obj17 + -621355968000000000L;
			object obj18 = obj16 / 10000;
			_ = 1;
			obj15 = obj18;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C25");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [392B58]");
		object obj20 = default;
		object obj19 = obj20 - 0;
		double num = (double)obj19 * 1000.0;
		double num2 = num + (double)obj15;
		if (num2 != num2)
		{
			num2 = 0.0;
		}
		else if (!(num2 < 1.8446744073709552E+19))
		{
			num2 = 0.0;
		}
		else if (!(num2 > -1.0))
		{
			num2 = 0.0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C25");
		object obj21 = default;
		double num3 = (double)obj21 * 1000000.0;
		if (num3 != num3)
		{
			num3 = 0.0;
		}
		else if (!(num3 < 1.8446744073709552E+19))
		{
			num3 = 0.0;
		}
		else if (!(num3 > -1.0))
		{
			num3 = 0.0;
		}
		double num4 = num3 - (double)_titleLabel;
		UILabel uILabel = default;
		object obj22 = default;
		object obj24 = default;
		if ((object)uILabel != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C93");
			if (obj4 == obj9)
			{
				goto IL_06c7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v50+4]");
			bool flag = (nint)0 != 0;
			bool flag2 = obj4 == null;
			obj22 = flag | flag2;
			object obj23 = obj4 + 4;
			bool flag3 = !flag2;
			bool flag4 = !flag3;
			obj24 = obj23;
			if (!flag4)
			{
				obj24 = obj4;
			}
		}
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		}
		else
		{
			if (obj9 != null && obj12 != null)
			{
				obj3 = obj11;
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120E");
			}
			obj9 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v50+14]");
			obj10 = 0;
			obj12 = 0;
		}
		goto IL_06c7;
		IL_06c7:
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v50+4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v50+18]");
				obj3 = 0;
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120E");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L1 (System.String)+20]");
		_ = 0;
		if (((UnityEngine.Object)this).m_CachedPtr != (IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref result))
		{
			object obj25 = ((System.Runtime.CompilerServices.Unsafe.AsPointer(ref result) == null) ? ((object)1) : ((object)2));
			obj14 = obj25;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C94");
		bool result2 = default;
		return result2;
	}

	public void Show()
	{
		//IL_0099: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_010c: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		bool value = ((OnlineSettings)(object)saveDataPath).GetValue("fb_adchoice_link", (byte)(int)string.Empty != 0);
		bool flag;
		if (value)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v12 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			Application.targetFrameRate = (value ? 1 : 0);
		}
	}

	public void Hide()
	{
		//IL_0018: Expected Obj, but got I4
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		TransformExtensions.Reset((Transform)(object)this.m_onAdShown);
	}

	private void Log(string message)
	{
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_03ec: Expected Obj, but got I4
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0409: Expected Obj, but got I4
		//IL_041d: Expected I, but got Obj
		//IL_0433: Expected Obj, but got I
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_049c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0274: Expected VT, but got Obj
		//IL_028f: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got F4
		//IL_00b0: Expected VT, but got Obj
		//IL_00cb: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got F4
		//IL_0330: Expected VT, but got Obj
		//IL_0350: Expected Obj, but got I4
		//IL_035f: Expected Obj, but got F4
		//IL_016c: Expected VT, but got Obj
		//IL_018c: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(Regex);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<System.Text.RegularExpressions.Regex>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Regex);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v117 (Il2CppClass<System.Text.RegularExpressions.Regex>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 72);
		Transform transform2 = (Transform)(obj2 + 36);
		object obj5 = obj2 + 24;
		Transform transform3 = (Transform)(obj2 + 12);
		bool flag = ((Regex)message.m_stringLength).IsMatch("\\p{IsArabic}|\\p{IsHebrew}|\\p{IsSyriac}|\\p{IsThaana}");
		UILabel titleLabel = _titleLabel;
		if (flag)
		{
			if (titleLabel.mAlignment == NGUIText.Alignment.Left)
			{
				_titleLabel.applyGradient = true;
				GameObject gameObject = _titleLabel.gameObject;
				transform2.position = (Vector3)gameObject;
				obj = transform2;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				obj5 = 0;
				_ = 0;
				obj5 = -1f;
				_ = 1f;
				_ = 1f;
				transform = (Transform)obj5;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v19+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11455");
				GameObject gameObject2 = _titleLabel.gameObject;
				transform = (Transform)obj;
				Transform transform5 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				Vector3 localPosition = transform.localPosition;
				GameObject gameObject3 = _iconTexture.gameObject;
				transform3.position = (Vector3)gameObject3;
				obj = transform3;
				_ = ((UnityEngine.Object)transform3).m_CachedPtr;
				obj2 = 0;
				_ = 0;
				obj2 = -1f;
				_ = 1f;
				_ = 1f;
				transform = (Transform)obj2;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11455");
				GameObject gameObject4 = _iconTexture.gameObject;
				transform = (Transform)obj;
				Transform transform7 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
				Vector3 localPosition2 = transform.localPosition;
			}
		}
		else if (titleLabel.mAlignment == NGUIText.Alignment.Right)
		{
			_titleLabel.applyGradient = true;
			GameObject gameObject5 = _titleLabel.gameObject;
			transform2.position = (Vector3)gameObject5;
			obj3 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			obj5 = 0;
			_ = 0;
			obj5 = -1f;
			_ = 1f;
			_ = 1f;
			transform = (Transform)obj5;
			Transform transform8 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v19+8]");
			((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11455");
			GameObject gameObject6 = _titleLabel.gameObject;
			transform = (Transform)obj3;
			Transform transform9 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition3 = transform.localPosition;
			GameObject gameObject7 = _iconTexture.gameObject;
			transform3.position = (Vector3)gameObject7;
			obj3 = transform3;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			obj2 = 0;
			_ = 0;
			obj2 = -1f;
			_ = 1f;
			_ = 1f;
			transform = (Transform)obj2;
			Transform transform10 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11455");
			GameObject gameObject8 = _iconTexture.gameObject;
			transform = (Transform)obj3;
			Transform transform11 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition4 = transform.localPosition;
		}
	}

	private void LogWarning(string message)
	{
	}

	private void LogError(string message)
	{
	}

	public NativeInterstitialHelper()
	{
		string text = tag;
		((GameObject)(object)text).tag = null;
		TransformExtensions.Reset((Transform)(object)this.m_onAdHidden);
	}
}
