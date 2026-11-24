using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AppRefresh;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Common.Events;
using SYBO.Common.StateSystem;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.StateSystem.States;
using UI.Screens;
using UnityEngine;

public class UIPowerupHelper : MonoBehaviour
{
	private enum FadeTarget
	{
		white,
		green,
		darkgreen,
		none
	}

	private UISlider slider;

	private UISprite sliderBG;

	private UISprite icon;

	private UISprite iconBG;

	private UISprite iconBGMystery;

	private UILabel amountLabel;

	private UISprite foreground;

	private GameObject container;

	private Color originalColor;

	private float sliderSteps;

	private bool _amountLabelRepositioned;

	private const float AMOUNT_LABEL_HIGH_RES_OFFSET = 0.5f;

	private const float COLOR_CHANGE_SPEED = 8.2343f;

	private IngameScreen _ingameScreen;

	private bool _inverse;

	private ActivePowerup _powerup;

	private Color32[] _colorTargets;

	private FadeTarget currentFadeTarget;

	private FadeTarget oldFadeTarget;

	private Color storedColor;

	private float lerpTime;

	private IngameScreen ingameScreen
	{
		get
		{
			//IL_001c: Expected Obj, but got I4
			//IL_0063: Expected Obj, but got I4
			//IL_00cf: Expected Obj, but got I4
			//IL_00e9: Expected Obj, but got I4
			string dataPath = Application.dataPath;
			if ((nint)dataPath == 8)
			{
				OperatingSystemFamily operatingSystemFamily = SystemInfo.GetOperatingSystemFamily();
				bool flag;
				if (((string)operatingSystemFamily).EndsWith("iPhone OS 7"))
				{
					flag = true;
				}
				else
				{
					OperatingSystemFamily operatingSystemFamily2 = SystemInfo.GetOperatingSystemFamily();
					flag = ((string)operatingSystemFamily2).EndsWith("iOS 7");
				}
				string graphicsDeviceVersion = SystemInfo.GetGraphicsDeviceVersion();
				bool flag2 = graphicsDeviceVersion.EndsWith("Apple A7");
				object obj = flag & flag2;
				bool flag3 = obj != null;
				return (IngameScreen)flag3;
			}
			return null;
		}
	}

	private void Awake()
	{
		//IL_0011: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		sliderBG = (UISprite)26;
		icon = (UISprite)5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 24;
		object obj2 = default;
		obj = obj2;
		CancelInvoke();
	}

	private void OnDisable()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		int sliderWidth = getSliderWidth();
		object obj = sliderWidth + 156;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v4+8]");
		_ = 0;
		object obj3 = obj2 + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 44;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v7+8]");
		_ = 0;
	}

	private void OnEnable()
	{
		HidePowerupSlot();
	}

	private void ReturnToNormal()
	{
		//IL_001c: Expected F4, but got Obj
		//IL_005d: Invalid comparison between Obj and F4
		//IL_0096: Invalid comparison between Obj and F4
		//IL_004f: Expected F4, but got I4
		//IL_0088: Expected F4, but got I4
		//IL_00c1: Expected F4, but got I4
		UISlider uISlider = slider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		object obj = default;
		float num = (float)obj;
		if (obj != obj)
		{
			num = -2.1474836E+09f;
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2.1474836E+09f))
		{
			num = -2.1474836E+09f;
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2.1474836E+09f)))
		{
			num = -2.1474836E+09f;
		}
		sliderSteps = num;
	}

	public unsafe void HidePowerupSlot()
	{
		//IL_02b4: Expected I, but got Obj
		//IL_02ca: Expected Obj, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected VT, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_037d: Expected Obj, but got I4
		//IL_03a7: Expected F4, but got Obj
		//IL_03a2: Expected native int or pointer, but got VT
		//IL_03b9: Expected F4, but got I
		//IL_03b4: Expected native int or pointer, but got VT
		//IL_03c9: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0356: Expected I4, but got VT
		//IL_02f0: Expected Obj, but got VT
		//IL_0305: Expected F4, but got Obj
		//IL_0300: Expected native int or pointer, but got VT
		//IL_031f: Expected F4, but got Obj
		//IL_031a: Expected native int or pointer, but got VT
		//IL_0334: Expected F4, but got I
		//IL_032f: Expected native int or pointer, but got VT
		//IL_0344: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_017c: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01db: Expected F4, but got Obj
		//IL_01d6: Expected native int or pointer, but got VT
		//IL_01f0: Expected F4, but got I
		//IL_01eb: Expected native int or pointer, but got VT
		//IL_01fd: Expected I, but got VT
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_025e: Expected F4, but got Obj
		//IL_0259: Expected native int or pointer, but got VT
		//IL_0270: Expected F4, but got I
		//IL_026b: Expected native int or pointer, but got VT
		//IL_0285: Expected I4, but got VT
		//IL_0285: Expected Obj, but got I
		lerpTime = 1f;
		_inverse = false;
		nint num = (nint)typeof(PlusMultiplier);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<PlusMultiplier>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PlusMultiplier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v80 (Il2CppClass<PlusMultiplier>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 56);
		Gradient gradient = (Gradient)(obj2 + 40);
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 32;
		UIWidget uIWidget;
		if (~(PlusMultiplier.plusMultiplierEnabled ? 1u : 0u) == 0)
		{
			int sliderWidth = getSliderWidth();
			nint num3 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v64 (Il2CppClass<GlobalColors>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v74 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			gradient = (Gradient)GlobalColors.MULTIPLIER_LIGHT_PURPLE;
			obj4 = gradient;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v20+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v61 (System.Int32)+38]");
			uIWidget = (UIWidget)0;
		}
		else
		{
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (System.String)+64]");
			if ((nint)0 == 0)
			{
				string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v43 (System.String)+70]");
				if ((nint)0 == 0)
				{
					int sliderWidth2 = getSliderWidth();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v25 (System.Int32)+38]");
					object obj6 = (nint)0 + (nint)80;
					obj3 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v27+8]");
					_ = 0;
					object obj7 = this + 44;
					obj2 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v32+8]");
					_ = 0;
					gradient = (Gradient)obj3;
					Gradient gradient2 = gradient;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v20+8]");
					gradient2.m_Ptr = (IntPtr)0;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					if (gradient.Internal_Equals((IntPtr)matrix4x))
					{
						int sliderWidth3 = getSliderWidth();
						object obj8 = this + 44;
						gradient = (Gradient)obj8;
						Gradient gradient3 = gradient;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S2_v11+8]");
						gradient3.m_Ptr = (IntPtr)0;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)gradient;
						((Matrix4x4*)(nint)matrix4x)->m20 = (nint)gradient.m_Ptr;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v58 (System.Int32)+38]");
						((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
					}
					return;
				}
			}
			int sliderWidth4 = getSliderWidth();
			int sliderWidth5 = getSliderWidth();
			object obj9 = sliderWidth5 + 108;
			gradient = (Gradient)obj9;
			Gradient gradient4 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v16+8]");
			gradient4.m_Ptr = (IntPtr)0;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)gradient;
			((Matrix4x4*)(nint)matrix4x)->m20 = (nint)gradient.m_Ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v36 (System.Int32)+38]");
			uIWidget = (UIWidget)0;
		}
		uIWidget.rawPivot = (UIWidget.Pivot)matrix4x;
	}

	public void setContainerPosition(float x, float y, float z)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public int getSliderWidth()
	{
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_00bc: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_ingameScreen != null)
		{
			object obj2 = this + 68;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73B9");
			object obj3 = default;
			obj2 = obj3;
		}
		return (int)_ingameScreen;
	}

	public float getSliderHeight()
	{
		return 5f;
	}

	public void SetPowerupSlot(ActivePowerup powerup)
	{
		//IL_0239: Expected I4, but got Obj
		//IL_0273: Expected F4, but got Obj
		//IL_0128: Expected VT, but got Obj
		//IL_0128: Expected VT, but got Obj
		//IL_0128: Expected VT, but got Obj
		//IL_0014: Expected I4, but got Obj
		//IL_0049: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_00a0: Expected I4, but got Obj
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_02bd: Expected I, but got Obj
		//IL_02d3: Expected Obj, but got I
		//IL_02ff: Expected I4, but got Obj
		//IL_015d: Expected I, but got Obj
		//IL_01aa: Expected I, but got Obj
		//IL_01c0: Expected Obj, but got I
		//IL_01eb: Expected I, but got Obj
		UIPowerupHelper uIPowerupHelper = ((List<UIPowerupHelper>)(object)iconBG).get_Item((int)powerup);
		UIAnchor component = uIPowerupHelper.GetComponent<UIAnchor>();
		bool flag = component.side == UIAnchor.Side.BottomRight;
		bool flag2 = !flag;
		float newValue = (float)sliderBG;
		if (!flag2)
		{
			UIPowerupHelper uIPowerupHelper2 = ((List<UIPowerupHelper>)(object)iconBG).get_Item((int)powerup);
			UISprite uISprite = uIPowerupHelper2.iconBG;
			UISprite uISprite2 = uIPowerupHelper2.sliderBG;
			object obj = ((UIWidget)uISprite).mWidth + ((UIWidget)uISprite2).mWidth;
			object obj2 = obj - 5;
			object obj3 = obj2 * -1;
			object obj4 = sliderBG / 2;
			float num = (float)obj4 + (float)obj3;
			newValue = num;
		}
		float num2;
		UISprite uISprite4;
		if ((object)iconBGMystery != null)
		{
			UIPowerupHelper uIPowerupHelper3 = ((List<UIPowerupHelper>)(object)iconBG).get_Item((int)powerup);
			UISprite uISprite3 = uIPowerupHelper3.iconBG;
			object obj5 = powerup + 1;
			object obj6 = sliderBG / 4;
			object obj7 = obj5 * obj6;
			object obj8 = powerup * ((UIWidget)uISprite3).mHeight;
			num2 = (float)obj7 + (float)obj8;
			uISprite4 = icon;
		}
		else
		{
			UIScreen screenFromCache = ((UIScreenController)this).GetScreenFromCache((string)(object)powerup);
			float num3 = NGUIMath.DistancePointToLineSegment((Vector2)this, (Vector2)powerup, (Vector2)powerup);
			num2 = (float)screenFromCache + num3;
			uISprite4 = icon;
		}
		float num4 = num2 + (float)uISprite4;
		nint num5 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v19 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v42 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = IPhoneXSupport.CheckIsiPhoneXDevice();
		bool flag4 = !flag3;
		float oldValue = num4;
		if (!flag4)
		{
			nint num7 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v30 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num8 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v36 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num9 = num4 + (float)IPhoneXSupport.OFFSET_BOTTOM;
			oldValue = num9;
		}
		UIPowerupHelper uIPowerupHelper4 = ((List<UIPowerupHelper>)(object)iconBG).get_Item((int)powerup);
		((ValueChangedEventArgs)(object)uIPowerupHelper4)._002Ector(newValue, oldValue, 0f);
	}

	private unsafe void FadingToWhiteToGreenToDarkGreen(bool sendInverse)
	{
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected Obj, but got Unknown
		//IL_0d92: Expected Obj, but got I4
		//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Expected Obj, but got Unknown
		//IL_0da5: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_02d7: Expected I, but got Obj
		//IL_02ed: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_0e7f: Expected I4, but got Obj
		//IL_036f: Expected I, but got Obj
		//IL_0385: Expected Obj, but got I
		//IL_0318: Expected I, but got Obj
		//IL_01e8: Expected I, but got Obj
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e92: Expected I4, but got Unknown
		//IL_0ea4: Expected Obj, but got I4
		//IL_0235: Expected I, but got Obj
		//IL_024b: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I4
		//IL_046a: Expected I, but got Obj
		//IL_0480: Expected Obj, but got I
		//IL_03b0: Expected I, but got Obj
		//IL_0e4e: Expected I4, but got Obj
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_0f0a: Expected Obj, but got I
		//IL_0276: Expected I, but got Obj
		//IL_04ab: Expected I, but got Obj
		//IL_00e3: Expected I, but got Obj
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_0503: Expected F4, but got I4
		//IL_059e: Expected I, but got Obj
		//IL_05b4: Expected Obj, but got I
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected Obj, but got Unknown
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected Obj, but got Unknown
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected Obj, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected Obj, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected Obj, but got Unknown
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected Obj, but got Unknown
		//IL_092b: Invalid comparison between I and F4
		//IL_05df: Expected I, but got Obj
		//IL_063b: Expected Obj, but got I4
		//IL_0d17: Expected I4, but got Obj
		//IL_0c81: Expected I, but got Obj
		//IL_0c97: Expected Obj, but got I
		//IL_067b: Expected Obj, but got I4
		//IL_0689: Expected I, but got Obj
		//IL_069f: Expected Obj, but got I
		//IL_0a4a: Expected I, but got Obj
		//IL_0a60: Expected Obj, but got I
		//IL_09a5: Expected I, but got Obj
		//IL_09bb: Expected Obj, but got I
		//IL_1256: Expected I4, but got Obj
		//IL_0cc2: Expected I, but got Obj
		//IL_100f: Expected I4, but got Obj
		//IL_1051: Expected I4, but got Obj
		//IL_1051: Expected Ref, but got VT
		//IL_1063: Expected I4, but got F4
		//IL_06ca: Expected I, but got Obj
		//IL_0a8b: Expected I, but got Obj
		//IL_09e6: Expected I, but got Obj
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected Obj, but got Unknown
		//IL_0bbc: Expected I, but got Obj
		//IL_0bd2: Expected Obj, but got I
		//IL_11fb: Expected I4, but got Obj
		//IL_0b17: Expected I, but got Obj
		//IL_0b2d: Expected Obj, but got I
		//IL_076c: Expected VT, but got Obj
		//IL_115a: Expected I4, but got Obj
		//IL_115a: Expected Ref, but got VT
		//IL_116c: Expected I4, but got F4
		//IL_0bfd: Expected I, but got Obj
		//IL_1101: Expected I4, but got Obj
		//IL_078d: Expected VT, but got Obj
		//IL_0b58: Expected I, but got Obj
		//IL_07ae: Expected VT, but got Obj
		//IL_07b7: Expected native int or pointer, but got VT
		//IL_07c5: Expected native int or pointer, but got VT
		//IL_07e2: Expected native int or pointer, but got VT
		//IL_07fc: Expected F4, but got I
		//IL_07f7: Expected native int or pointer, but got VT
		//IL_080e: Expected F4, but got I
		//IL_0809: Expected native int or pointer, but got VT
		//IL_0820: Expected I4, but got F4
		//IL_0833: Expected Obj, but got I4
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected Obj, but got Unknown
		//IL_0850: Expected Obj, but got I4
		Matrix4x4 matrix4x = default;
		object obj = matrix4x + 48;
		obj = 0;
		object obj2 = this + 76;
		obj2 = sendInverse;
		ActivePowerup powerup = _powerup;
		if (powerup.type != UpgradeType.plusMultiplier)
		{
			ActivePowerup powerup2 = _powerup;
			if (powerup2.type != UpgradeType.doubleJump)
			{
				ActivePowerup powerup3 = _powerup;
				if (powerup3.type != UpgradeType.doubleCoinsMysteryPowerup)
				{
					ActivePowerup powerup4 = _powerup;
					if (powerup4.type == UpgradeType.hoverboard)
					{
						nint num = (nint)typeof(Hoverboard);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v227 (Il2CppClass<Hoverboard>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num2 = (nint)typeof(Hoverboard);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v234 (Il2CppClass<Hoverboard>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v232 (CharacterModifier)+57]");
						if ((nint)0 != 0)
						{
							goto IL_0148;
						}
					}
					iconBG.tag = (string)1;
					iconBGMystery.tag = null;
					goto IL_0169;
				}
			}
		}
		goto IL_0148;
		IL_0ec5:
		UISlider uISlider = slider;
		UIWidget.Pivot pivot;
		float num4;
		if (sliderSteps == 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			sliderSteps = ((UIWidget.Pivot*)(int)pivot)->value__;
		}
		else
		{
			float num3 = num4 * sliderSteps;
			float alpha = num3 / sliderSteps;
			slider.alpha = alpha;
		}
		Transform transform = (Transform)(matrix4x + 152);
		Transform transform2 = (Transform)(matrix4x + 32);
		Transform transform3 = (Transform)(matrix4x + 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+8]");
		if ((nint)0 == 1)
		{
			nint num5 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v107 (Il2CppClass<Hoverboard>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v141 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier2 = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v112 (CharacterModifier)+57]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+8]");
				int tier = InventorySave.GetTier(UpgradeType._notset);
				obj = tier;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
				int fontSize = default;
				amountLabel.fontSize = fontSize;
				string text = amountLabel.tag;
				((GameObject)(object)text).tag = (string)1;
				nint num7 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v120 (Il2CppClass<DeviceInfo>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num8 = (nint)typeof(DeviceInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v137 (Il2CppClass<DeviceInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v125 (System.Int32)+18]");
				if ((nint)0 != 0)
				{
					object obj6 = this - -64;
					if (obj6 == null)
					{
						GameObject gameObject = amountLabel.gameObject;
						GameObject gameObject2 = amountLabel.gameObject;
						transform.localPosition = (Vector3)gameObject2;
						GameObject gameObject3 = amountLabel.gameObject;
						transform2.localPosition = (Vector3)gameObject3;
						GameObject gameObject4 = amountLabel.gameObject;
						transform3.localPosition = (Vector3)gameObject4;
						((Matrix4x4*)(nint)matrix4x)->m00 = 0f;
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						float m = (float)transform + 0.5f;
						((Matrix4x4*)(nint)matrix4x)->m00 = m;
						Matrix4x4 matrix4x2 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v43 (UnityEngine.Transform)+4]");
						((Matrix4x4*)(nint)matrix4x2)->m10 = 0f;
						((Matrix4x4*)(nint)matrix4x)->m20 = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
						((UIWidget.Pivot*)(int)pivot)->value__ = (int)matrix4x.m00;
						_ = matrix4x.m20;
						Vector3 eulerAngles = ((Transform)pivot).eulerAngles;
						object obj7 = this - -64;
						obj7 = 1;
					}
				}
				goto IL_0873;
			}
		}
		string text2 = amountLabel.tag;
		((GameObject)(object)text2).tag = null;
		goto IL_0873;
		IL_0148:
		iconBG.tag = null;
		iconBGMystery.tag = (string)1;
		goto IL_0169;
		IL_0169:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+8]");
		UISprite uISprite;
		if ((nint)0 == 1)
		{
			nint num9 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v181 (Il2CppClass<Hoverboard>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num10 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v200 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier3 = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v186 (CharacterModifier)+57]");
			bool flag = (nint)0 != 0;
			bool flag2 = !flag;
			uISprite = icon;
			if (!flag2)
			{
				nint num11 = (nint)typeof(MysteryPowerup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v191 (Il2CppClass<MysteryPowerup>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num12 = (nint)typeof(MysteryPowerup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v196 (Il2CppClass<MysteryPowerup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterModifier randomModifier = MysteryPowerup.GetRandomModifier();
				icon.fillCenter = (byte)(int)randomModifier != 0;
				goto IL_0357;
			}
		}
		else
		{
			uISprite = icon;
		}
		nint num13 = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v167 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num14 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v172 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, Upgrade> upgrades = Upgrades.upgrades;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+8]");
		Upgrade upgrade = upgrades.get_Item(UpgradeType._notset);
		uISprite.fillCenter = (byte)(int)upgrade.iconName != 0;
		goto IL_0357;
		IL_045c:
		nint num15 = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S2_v97 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num16 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S2_v102 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+8]");
		float recommendationEvaluation = ((CloudSaveConflictResolver)0).recommendationEvaluation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+C]");
		num4 = 0f / recommendationEvaluation;
		goto IL_0ec5;
		IL_0873:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+8]");
		if ((nint)0 == 10)
		{
			bool inverse = _inverse;
			((UIScreenController)this).OnWillRefresh(inverse ? RefreshType.UI : ((RefreshType)0));
		}
		object obj12 = matrix4x + 136;
		object obj13 = matrix4x + 120;
		object obj14 = matrix4x + 104;
		object obj15 = matrix4x + 88;
		object obj16 = matrix4x + 72;
		object obj17 = matrix4x + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+C]");
		bool flag3 = 0f < 0f;
		string text3 = slider.tag;
		string text4 = ((GameObject)(object)text3).tag;
		UIWidget uIWidget;
		if (flag3)
		{
			if (text4 != null)
			{
				string go = slider.tag;
				nint num17 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S1_v89 (Il2CppClass<NGUITools>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num18 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S1_v94 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.SetActiveChildren((GameObject)(object)go, state: false);
			}
			Color clear = Color.clear;
			Color black = Color.black;
			nint num19 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S2_v24 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num20 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S2_v53 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+C]");
			float num21 = 0f * (float)Math.PI;
			float num22 = num21 * 4f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
			obj12 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			obj13 = transform3;
			_ = ((UnityEngine.Object)transform3).m_CachedPtr;
			transform = (Transform)obj12;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v55+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v57+8]");
			_ = 0;
			object obj20 = default;
			float num23 = 0.5f * (float)obj20;
			float value = 0.5f + num23;
			((Matrix4x4*)matrix4x)->set_Item((int)transform, (int)pivot, value);
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)matrix4x.m00;
			_ = matrix4x.m20;
			icon.rawPivot = pivot;
			object obj22;
			if (iconBG.isActiveAndEnabled)
			{
				Color clear2 = Color.clear;
				Color black2 = Color.black;
				nint num24 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S4_v41 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num25 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ S4_v63 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+C]");
				float num26 = 0f * (float)Math.PI;
				float num27 = num26 * 4f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
				obj14 = transform2;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				obj15 = transform3;
				_ = ((UnityEngine.Object)transform3).m_CachedPtr;
				transform = (Transform)obj14;
				Transform transform5 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v59+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v61+8]");
				_ = 0;
				uIWidget = iconBG;
				object obj23 = default;
				obj22 = obj23;
			}
			else
			{
				Color clear3 = Color.clear;
				Color black3 = Color.black;
				nint num28 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S4_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num29 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ S4_v34 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+C]");
				float num30 = 0f * (float)Math.PI;
				float num31 = num30 * 4f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
				obj16 = transform2;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				obj17 = transform3;
				_ = ((UnityEngine.Object)transform3).m_CachedPtr;
				transform = (Transform)obj16;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S0_v63+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S0_v65+8]");
				_ = 0;
				uIWidget = iconBGMystery;
				object obj25 = default;
				obj22 = obj25;
			}
			float num32 = 0.5f * (float)obj22;
			float value2 = 0.5f + num32;
			((Matrix4x4*)matrix4x)->set_Item((int)transform, (int)pivot, value2);
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)matrix4x.m00;
			_ = matrix4x.m20;
		}
		else
		{
			if (text4 == null)
			{
				string go2 = slider.tag;
				nint num33 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S1_v53 (Il2CppClass<NGUITools>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num34 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ S1_v58 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.SetActiveChildren((GameObject)(object)go2, state: true);
			}
			Color black4 = Color.black;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			icon.rawPivot = pivot;
			UISprite uISprite2 = ((!iconBG.isActiveAndEnabled) ? iconBGMystery : iconBG);
			Color black5 = Color.black;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			uIWidget = uISprite2;
		}
		uIWidget.rawPivot = pivot;
		return;
		IL_0357:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		nint num35 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v23 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num36 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v161 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		pivot = (UIWidget.Pivot)(matrix4x + 168);
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		FlyingState flyingState = ((StateMachine)useBenchmarkRoute).TryGetCurrentState<FlyingState>();
		if (flyingState == null)
		{
			goto IL_045c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+8]");
		if ((nint)0 != 6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendInverse @ L1 (System.Boolean)+8]");
			if ((nint)0 != 3)
			{
				goto IL_045c;
			}
		}
		num4 = ((HeadstartState)flyingState).GetFlyHeight();
		goto IL_0ec5;
	}

	public UIPowerupHelper()
	{
		if (_powerup != null)
		{
			ActivePowerup powerup = _powerup;
			if (powerup.type == UpgradeType.doubleMultiplier)
			{
				HidePowerupSlot();
			}
		}
	}
}
