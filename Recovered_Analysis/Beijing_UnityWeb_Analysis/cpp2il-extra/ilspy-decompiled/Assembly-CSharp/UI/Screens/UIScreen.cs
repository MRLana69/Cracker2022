using System;
using Cpp2ILInjected;
using Onboarding;
using UnityEngine;

namespace UI.Screens;

public class UIScreen : MonoBehaviour
{
	public bool showOldFooterSection;

	protected GameObject _footerPrefab;

	protected int _selectedFooterButton;

	protected UIFooterHandler _footerHandler;

	private bool _footerInited;

	private bool _isActive;

	[NonSerialized]
	public string screenName;

	private string parentScreen__BackingField;

	public unsafe bool isActive
	{
		get
		{
			//IL_00b5: Expected Obj, but got I
			//IL_00c7: Expected I, but got Obj
			//IL_00dd: Expected Obj, but got I
			//IL_010f: Expected Obj, but got I
			//IL_0121: Expected I, but got Obj
			//IL_0137: Expected Obj, but got I
			//IL_016b: Expected Obj, but got I4
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected I4, but got Unknown
			//IL_019b: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_00a4: Expected I4, but got Obj
			//IL_0060: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.UIScreen)+34]");
			GameObject parent = ((Component)0).gameObject;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.UIScreen)+54]");
			UISprite uISprite = UnityEngine.Object.Instantiate((UISprite)0, (Transform)(object)parent);
			nint num3 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v12 (Il2CppClass<UI.ColorData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v25 (Il2CppClass<UI.ColorData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj3 = (flag ? 1 : 0) + 60;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v9+8]");
			_ = 0;
			UIWidget.Pivot pivot = (UIWidget.Pivot)(obj4 + 16);
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			uISprite.rawPivot = pivot;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			return (byte)(int)uISprite != 0;
		}
	}

	public string parentScreen
	{
		protected get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = _isActive;
			return (string)flag;
		}
		set
		{
			((CharacterPopup)this).OnDisable();
		}
	}

	public virtual void Init()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72D5");
	}

	public void ShowIfInactive()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public void HideIfActive()
	{
		if (~(_isActive ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public virtual void Show()
	{
		if (~(_isActive ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public virtual void Hide()
	{
		//IL_01d0: Expected Obj, but got I4
		//IL_02b6: Expected I4, but got Obj
		//IL_00d5: Expected I, but got Obj
		//IL_00eb: Expected Obj, but got I
		//IL_00c2: Expected I4, but got Obj
		//IL_0254: Expected I, but got Obj
		//IL_026a: Expected Obj, but got I
		//IL_0290: Expected I4, but got Obj
		//IL_0116: Expected I, but got Obj
		//IL_0163: Expected I, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		_isActive = true;
		string original = tag;
		UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		if (!((string)(object)obj).EndsWith("NotebookScreen"))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			int num = default;
			bool flag;
			if (num != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v21 (System.Int32)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			bool flag2 = !flag;
			int totalLength = num;
			if (!flag2)
			{
				string original2 = tag;
				UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original2);
				totalLength = (int)obj2;
			}
			string text2 = string.ConcatArray((string[])(object)"UI Screen ", totalLength);
			if (text2.get_Chars((int)string.Empty) != '\0')
			{
				nint num2 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v29 (Il2CppClass<Flurry>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num3 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v36 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string original3 = tag;
				UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original3);
				nint num4 = (nint)typeof(OnboardingTracking);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v24 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num5 = (nint)typeof(OnboardingTracking);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v29 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				OnboardingTracking.DisableOnboardingTracking((OnboardingTracking.ScreenType)obj4);
			}
		}
		if (~(_footerInited ? 1u : 0u) != 0)
		{
			this._002Ector();
			_footerInited = true;
		}
	}

	protected virtual string GetFlurryName()
	{
		return parentScreen__BackingField;
	}

	public virtual void LoseFocus()
	{
		string text = tag;
		((GameObject)(object)text).tag = null;
		_isActive = false;
	}

	public virtual void GainFocus()
	{
	}

	public virtual void AdjustToResolution()
	{
	}

	public virtual bool BlocksCelebrationPopup()
	{
		//IL_000b: Expected I4, but got Obj
		return (byte)(int)string.Empty != 0;
	}

	private void InitFooter()
	{
	}

	public static bool IsScreenHeightOutOfProportion()
	{
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_0210: Expected I, but got Obj
		//IL_0226: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0202: Expected I4, but got Obj
		//IL_0130: Expected I, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_011d: Expected I, but got Obj
		nint num = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PromotionManager.instance == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PromotionManager promotionManager = default;
			promotionManager.OnPromotionPurchaseFailed();
			nint num3 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 == null;
			nint num4 = (nint)typeof(PromotionManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v40 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(PromotionManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(PromotionManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L0_v8 (Il2CppClass<UI.Screens.PromotionManager>)+5C]");
			object obj3 = (nint)0 + (nint)8;
			obj3 = promotionManager;
		}
		nint num6 = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)PromotionManager.instance != 0;
	}

	protected GameObject InitializeCoinbox(UIWidget widgetAnchor, bool fundsEnabled, bool coinsEnabled, bool keysEnabled, float xOffset = 0f, float yOffset = 0f, float zOffset = 0f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public UIScreen()
	{
		//IL_01b5: Expected I, but got Obj
		//IL_01cb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0202: Expected I4, but got Obj
		//IL_020f: Expected Obj, but got I4
		//IL_021b: Expected Obj, but got VT
		//IL_022b: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_footerPrefab).FindKernel((string)null) == 0)
		{
			return;
		}
		string go = tag;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v20 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v38 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 24;
		int num5 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)_footerPrefab != 0);
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)num5).GetComponentInChildren<T>();
		obj3 = componentInChildren;
		object obj4 = _selectedFooterButton - 1;
		if (_selectedFooterButton != 1)
		{
			if ((nint)obj4 != 1)
			{
				if ((nint)obj4 == 2)
				{
					UIFooterHandler footerHandler = _footerHandler;
					UIButtonOverlayOff button = footerHandler.button3;
					button._buttonStateLocked = true;
				}
			}
			else
			{
				UIFooterHandler footerHandler2 = _footerHandler;
				UIButtonOverlayOff button2 = footerHandler2.button2;
				button2._buttonStateLocked = true;
			}
		}
		else
		{
			UIFooterHandler footerHandler3 = _footerHandler;
			UIButtonOverlayOff button3 = footerHandler3.button1;
			button3._buttonStateLocked = true;
		}
	}
}
