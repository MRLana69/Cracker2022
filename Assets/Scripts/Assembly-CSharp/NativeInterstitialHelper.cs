using System;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

public class NativeInterstitialHelper : MonoBehaviour
{
	private UILabel _callToActionLabel;

	private UILabel _titleLabel;

	private UILabel _descriptionLabel;

	private UITexture _iconTexture;

	private UITexture _coverTexture;

	private Texture2D _icon;

	private Texture2D _cover;

	private const float ICON_ASPECT_RATIO = 1f;

	private const float ICON_ASPECT_RATIO_BUFFER = 0.1f;

	private const float COVER_ASPECT_RATIO = 1.9f;

	private const float COVER_ASPECT_RATIO_BUFFER = 0.1f;

	private const string RTL_ALIGNED_LANGUAGES_REGEX = "\\p{IsArabic}|\\p{IsHebrew}|\\p{IsSyriac}|\\p{IsThaana}";

	private const string RTL_ALIGNED_ONLINESETTINGS_KEY = "native_adview_rtl_regex";

	private const string LANGUAGES_WITH_HEIGHT_ISSUES_REGEX = "\\p{IsThai}";

	private const string ADCHOICE_ONLINESETTINGS_KEY = "fb_adchoice_link";

	private int _spacing = 7;

	private Vector2 _savedLabelSize;

	private Action m_onActionClicked;

	private Action m_onExitClicked;

	private Action m_onAdShown;

	private Action m_onAdHidden;

	public event Action onActionClicked
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_onActionClicked;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_onActionClicked;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action onExitClicked
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 56;
			Delegate obj2 = this.m_onExitClicked;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 56;
			Delegate obj2 = this.m_onExitClicked;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action onAdShown
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 60;
			Delegate obj2 = this.m_onAdShown;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 60;
			Delegate obj2 = this.m_onAdShown;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action onAdHidden
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this - -64;
			Delegate obj2 = this.m_onAdHidden;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this - -64;
			Delegate obj2 = this.m_onAdHidden;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	private void Awake()
	{
		OnlineSettings instance = OnlineSettings.instance;
		if (instance.HasValue("native_adview_rtl_regex"))
		{
			OnlineSettings instance2 = OnlineSettings.instance;
			string value = instance2.GetValue("native_adview_rtl_regex", "\\p{IsArabic}|\\p{IsHebrew}|\\p{IsSyriac}|\\p{IsThaana}");
		}
	}

	private void Update()
	{
		GameObject gameObject = base.gameObject;
		if (gameObject.activeSelf && Input.GetKeyDown(KeyCode.Escape))
		{
			OnExitClick();
		}
	}

	public void OnExitClick()
	{
		Action action = this.m_onExitClicked;
		if (this.m_onExitClicked != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		Hide();
	}

	public void OnActionClick()
	{
		Action action = this.m_onActionClicked;
		if (this.m_onActionClicked != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		Hide();
	}

	public void OnAdChoiceClick()
	{
		//IL_0047: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		OnlineSettings instance = OnlineSettings.instance;
		string value = instance.GetValue("fb_adchoice_link", string.Empty);
		object obj;
		if (value != null)
		{
			obj = 0;
			if (value._stringLength != 0)
			{
				goto IL_0080;
			}
		}
		obj = 1;
		goto IL_0080;
		IL_0080:
		if (obj == null)
		{
			Application.OpenURL(value);
		}
	}

	public unsafe bool UpdateAdObject(NativeInterstitialAdObject adObject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Ref, but got Unknown
		//IL_0073: Expected Obj, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Ref, but got Unknown
		//IL_00bf: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Ref, but got Unknown
		//IL_010b: Expected Obj, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_01ac: Expected I, but got Obj
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_020f: Expected I, but got Obj
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = ValidateAdObject(adObject);
		if (flag)
		{
			UpdateRTLLabels(adObject);
			UpdateLabelSpacing(adObject);
			bool flag2 = AdjustTextForLabel(adObject._callToActionText, _callToActionLabel, out *(string*)(obj + 12), 25);
			UILabel callToActionLabel = _callToActionLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			callToActionLabel.text = (string)0;
			bool flag3 = AdjustTextForLabel(adObject._title, _titleLabel, out *(string*)(obj + 12), 20);
			UILabel titleLabel = _titleLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			titleLabel.text = (string)0;
			bool flag4 = AdjustTextForLabel(adObject._body, _descriptionLabel, out *(string*)(obj + 12), 72);
			UILabel descriptionLabel = _descriptionLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			descriptionLabel.text = (string)0;
			UITexture iconTexture = _iconTexture;
			object obj3 = adObject + 36;
			object obj4 = this + 32;
			if (!adObject._iconImage)
			{
				obj3 = obj4;
			}
			nint num = (nint)iconTexture;
			object obj5 = iconTexture + 216;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ S2_v18 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
			UITexture coverTexture = _coverTexture;
			object obj6 = adObject + 40;
			object obj7 = this + 36;
			if (!adObject._coverImage)
			{
				obj6 = obj7;
			}
			nint num2 = (nint)coverTexture;
			object obj8 = coverTexture + 216;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v156 @ S2_v25 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		}
		return flag;
	}

	private void UpdateLabelSpacing(NativeInterstitialAdObject adObject)
	{
		//IL_03fa: Expected F8, but got VT
		//IL_00fc: Expected I, but got Obj
		//IL_0366: Expected VT, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_044a: Expected F8, but got I
		//IL_0144: Expected I4, but got VT
		//IL_024e: Expected I, but got Obj
		//IL_02fa: Expected I, but got Obj
		bool flag = Regex.IsMatch(adObject._title, "\\p{IsThai}");
		UILabel titleLabel = _titleLabel;
		if (flag && titleLabel.mSpacingY == 0)
		{
			if (_spacing != titleLabel.mSpacingY)
			{
				titleLabel.mSpacingY = _spacing;
				nint num = (nint)titleLabel;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S1_v67 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
			}
			UILabel titleLabel2 = _titleLabel;
			_ = ((UIWidget)titleLabel2).mHeight;
			_savedLabelSize = (Vector2)((UIWidget)titleLabel2).mWidth;
			titleLabel2.maxLineCount = 2;
			UILabel titleLabel3 = _titleLabel;
			if (titleLabel3.mOverflow != UILabel.Overflow.ShrinkContent)
			{
				titleLabel3.mOverflow = UILabel.Overflow.ShrinkContent;
				((UIRect)titleLabel3).mChanged = true;
				titleLabel3.mShouldBeProcessed = true;
			}
		}
		else if (titleLabel.mSpacingY == _spacing)
		{
			if (titleLabel.mSpacingY != 0)
			{
				titleLabel.mSpacingY = 0;
				nint num2 = (nint)titleLabel;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ S1_v52 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
			}
			_titleLabel.maxLineCount = 3;
			UILabel titleLabel4 = _titleLabel;
			if (titleLabel4.mOverflow != UILabel.Overflow.ClampContent)
			{
				titleLabel4.mOverflow = UILabel.Overflow.ClampContent;
				((UIRect)titleLabel4).mChanged = true;
				titleLabel4.mShouldBeProcessed = true;
			}
			double num3 = Math.Abs((double)_savedLabelSize);
			int width = ((!(num3 < 2147483648.0)) ? int.MinValue : ((int)_savedLabelSize));
			_titleLabel.width = width;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NativeInterstitialHelper)+30]");
			double num4 = Math.Abs(0.0);
			int height;
			if (num4 < 2147483648.0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (NativeInterstitialHelper)+30]");
				height = 0;
			}
			else
			{
				height = int.MinValue;
			}
			_titleLabel.height = height;
		}
		bool flag2 = Regex.IsMatch(adObject._body, "\\p{IsThai}");
		UILabel descriptionLabel = _descriptionLabel;
		int num5;
		if (flag2 && descriptionLabel.mSpacingY == 0)
		{
			num5 = _spacing;
		}
		else
		{
			bool flag3 = _spacing != descriptionLabel.mSpacingY;
			num5 = 0;
			if (flag3)
			{
				goto IL_048e;
			}
		}
		if (num5 != descriptionLabel.mSpacingY)
		{
			descriptionLabel.mSpacingY = num5;
			nint num6 = (nint)descriptionLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ S1_v24 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
		}
		goto IL_048e;
		IL_048e:
		bool flag4 = Regex.IsMatch(adObject._callToActionText, "\\p{IsThai}");
		UILabel callToActionLabel = _callToActionLabel;
		int num7;
		if (flag4)
		{
			bool flag5 = callToActionLabel.mSpacingY == 0;
			num7 = -6;
			if (flag5)
			{
				goto IL_02b6;
			}
		}
		bool flag6 = callToActionLabel.mSpacingY != -6;
		num7 = 0;
		if (!flag6)
		{
			goto IL_02b6;
		}
		return;
		IL_02b6:
		if (num7 != callToActionLabel.mSpacingY)
		{
			callToActionLabel.mSpacingY = num7;
			nint num8 = (nint)callToActionLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v264 @ S1_v16 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
		}
	}

	private unsafe void UpdateRTLLabels(NativeInterstitialAdObject adObject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected VT, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected VT, but got Unknown
		//IL_019e: Expected F4, but got I
		//IL_0199: Expected native int or pointer, but got VT
		//IL_01bd: Expected F4, but got I
		//IL_01b8: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		bool flag = Regex.IsMatch(adObject._title, "\\p{IsArabic}|\\p{IsHebrew}|\\p{IsSyriac}|\\p{IsThaana}");
		UILabel titleLabel = _titleLabel;
		if (flag)
		{
			if (titleLabel.mAlignment == NGUIText.Alignment.Left)
			{
				titleLabel.alignment = NGUIText.Alignment.Right;
				Transform transform = _titleLabel.transform;
				Vector3 position = transform.position;
				float num = -0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				float num2 = num - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
				float num3 = 0f * 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				float num4 = 0f * 1f;
				Transform transform2 = _titleLabel.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				_ = 0;
				Vector3 position2 = vector + 16;
				transform2.position = position2;
				Transform transform3 = _iconTexture.transform;
				Vector3 position3 = transform3.position;
				float num5 = -0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				float num6 = num5 - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
				float num7 = 0f * 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				float num8 = 0f * 1f;
				Transform transform4 = _iconTexture.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				((Vector3*)(nint)vector)->x = 0f;
				transform4.position = vector;
			}
		}
		else if (titleLabel.mAlignment == NGUIText.Alignment.Right)
		{
			titleLabel.alignment = NGUIText.Alignment.Left;
			Transform transform5 = _titleLabel.transform;
			Vector3 position4 = transform5.position;
			float num9 = -0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			float num10 = num9 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
			float num11 = 0f * 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			float num12 = 0f * 1f;
			Transform transform6 = _titleLabel.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			_ = 0;
			Vector3 position5 = vector + 48;
			transform6.position = position5;
			Transform transform7 = _iconTexture.transform;
			Vector3 position6 = transform7.position;
			float num13 = -0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			float num14 = num13 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
			float num15 = 0f * 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			float num16 = 0f * 1f;
			Transform transform8 = _iconTexture.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 position7 = vector + 32;
			transform8.position = position7;
		}
	}

	private unsafe bool ValidateAdObject(NativeInterstitialAdObject adObject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Ref, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Ref, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Ref, but got Unknown
		//IL_061c: Expected I, but got Obj
		//IL_063b: Expected I, but got Obj
		//IL_0652: Expected I, but got Obj
		//IL_065b: Invalid comparison between I and F4
		//IL_066a: Invalid comparison between I and F4
		//IL_0803: Expected I, but got Obj
		//IL_0707: Expected I, but got Obj
		//IL_0726: Expected I, but got Obj
		//IL_073d: Expected I, but got Obj
		//IL_0746: Invalid comparison between I and F4
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected Obj, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected Obj, but got Unknown
		//IL_076e: Invalid comparison between I and F4
		object obj = default;
		NativeInterstitialHelper nativeInterstitialHelper = (NativeInterstitialHelper)(obj - 32);
		nativeInterstitialHelper._coverTexture = null;
		nativeInterstitialHelper._iconTexture = null;
		nativeInterstitialHelper._descriptionLabel = null;
		if (~(adObject._valid ? 1u : 0u) == 0)
		{
			if (!nativeInterstitialHelper.AdjustTextForLabel(adObject._title, _titleLabel, out *(string*)(nativeInterstitialHelper + 28), 20))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
			if (!nativeInterstitialHelper.AdjustTextForLabel(adObject._callToActionText, _callToActionLabel, out *(string*)(nativeInterstitialHelper + 28)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
			if (!nativeInterstitialHelper.AdjustTextForLabel(adObject._body, _descriptionLabel, out *(string*)(nativeInterstitialHelper + 28)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
			Texture2D iconImage = adObject._iconImage;
			nint num = (nint)iconImage;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ S1_v126 (Il2CppClass<UnityEngine.Texture2D>)+DC] (should have been resolved before IL gen)");
			Texture2D iconImage2 = adObject._iconImage;
			nint num2 = (nint)iconImage2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v244 @ S2_v76 (Il2CppClass<UnityEngine.Texture2D>)+EC] (should have been resolved before IL gen)");
			object obj2 = default;
			object obj3 = default;
			nint num3 = obj2 / obj3;
			bool flag = (float)num3 < 1.1f;
			if (!((float)num3 > 0.9f))
			{
				flag = false;
			}
			if (!flag)
			{
				string text = string.Format("image_{0}", "Icon");
				((UnityEngine.Object)nativeInterstitialHelper).m_CachedPtr = num3;
				object obj4 = nativeInterstitialHelper + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				string locale = DeviceUtility.GetLocale();
				object arg = default;
				string text2 = $"ratio: {arg} - country:{locale}";
			}
			else
			{
				Texture2D coverImage = adObject._coverImage;
				nint num4 = (nint)coverImage;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v322 @ S1_v134 (Il2CppClass<UnityEngine.Texture2D>)+DC] (should have been resolved before IL gen)");
				Texture2D coverImage2 = adObject._coverImage;
				nint num5 = (nint)coverImage2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v332 @ S2_v83 (Il2CppClass<UnityEngine.Texture2D>)+EC] (should have been resolved before IL gen)");
				object obj5 = default;
				object obj6 = default;
				nint num6 = obj5 / obj6;
				if ((float)num6 < 2f)
				{
					bool flag2 = (float)num6 > 1.8f;
					bool result = true;
					if (flag2)
					{
						return result;
					}
				}
				string text3 = string.Format("image_{0}", "Cover");
				((UnityEngine.Object)nativeInterstitialHelper).m_CachedPtr = num6;
				object obj7 = nativeInterstitialHelper + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				string locale2 = DeviceUtility.GetLocale();
				object arg2 = default;
				string text4 = $"ratio: {arg2} - country:{locale2}";
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num7 = (nint)adObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ S2_v4 (Il2CppClass<NativeInterstitialAdObject>)+D4] (should have been resolved before IL gen)");
		throw new ArrayTypeMismatchException();
	}

	private unsafe bool AdjustTextForLabel(string text, UILabel label, out string result, int minimumShownCharacters = 0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_01e2: Expected Obj, but got I4
		//IL_01c0: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		ref string reference = ref *(string*)string.Empty;
		if (label.mOverflow != UILabel.Overflow.ResizeFreely)
		{
			label.mOverflow = UILabel.Overflow.ResizeFreely;
			((UIRect)label).mChanged = true;
			label.mShouldBeProcessed = true;
		}
		label.UpdateNGUIText();
		bool result2;
		if (label.mOverflow != UILabel.Overflow.ShrinkContent)
		{
			Vector2 vector = NGUIText.CalculatePrintedSize(text);
			int mWidth = ((UIWidget)label).mWidth;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if ((nint)mWidth < (nint)0)
			{
				string[] array = text.Split(' ');
				bool flag = true;
				int num = 0;
				int num2 = 0;
				object obj3 = default;
				while (true)
				{
					if (num < array.Length)
					{
						obj3++;
						int num3 = array.Length;
						int num5;
						while (true)
						{
							if (num < num3)
							{
								num2 = num3 - num;
								string text2 = string.Join(" ", array, num, num2);
								bool flag2 = (nint)obj3 < label.mMaxLineCount;
								string text3 = text2;
								flag = true;
								if (!flag2)
								{
									bool flag3 = num3 >= array.Length;
									text3 = text2;
									flag = true;
									if (!flag3)
									{
										string text4 = text2 + "...";
										text3 = text4;
										flag = false;
									}
								}
								vector = NGUIText.CalculatePrintedSize(text3);
								int num4 = num3 - 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
								bool flag4 = (nint)0 < (nint)((UIWidget)label).mWidth;
								bool flag5 = !flag4;
								num3 = num4;
								if (!flag5)
								{
									string text5 = result + text3 + " ";
									reference = ref *(string*)text5;
									num5 = num4;
									num2 = (int)" ";
									break;
								}
								continue;
							}
							num5 = num;
							break;
						}
						if (label.mMaxLineCount > (nint)obj3)
						{
							object obj4 = array.Length - 1;
							if (num5 < (nint)obj4)
							{
								int num6 = num5 + 1;
								num = num6;
								continue;
							}
						}
						string text6 = result;
						bool flag6 = text6._stringLength >= minimumShownCharacters;
						result2 = flag & flag6;
					}
					else
					{
						result2 = flag;
					}
					break;
				}
				goto IL_037c;
			}
		}
		reference = ref *(string*)text;
		result2 = true;
		goto IL_037c;
		IL_037c:
		if (label.mOverflow != label.mOverflow)
		{
			label.mOverflow = label.mOverflow;
			((UIRect)label).mChanged = true;
			label.mShouldBeProcessed = true;
		}
		label.width = ((UIWidget)label).mWidth;
		label.height = ((UIWidget)label).mHeight;
		return result2;
	}

	public void Show()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		Action action = this.m_onAdShown;
		if (this.m_onAdShown != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v7.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void Hide()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		Action action = this.m_onAdHidden;
		if (this.m_onAdHidden != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v7.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void Log(string message)
	{
	}

	private void LogWarning(string message)
	{
	}

	private void LogError(string message)
	{
		string text = "NativeInterstitialHelper: " + message;
	}
}
