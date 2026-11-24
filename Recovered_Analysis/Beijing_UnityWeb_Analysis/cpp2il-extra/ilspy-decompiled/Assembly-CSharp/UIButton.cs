using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Ads;
using Kiloo.Monetization.FlurryPlugin;
using Kiloo.Monetization.FlurryPlugin.Internal;
using UnityEngine;

public class UIButton : UIButtonColor
{
	public static UIButton current;

	public bool dragHighlight;

	public string hoverSprite;

	public string pressedSprite;

	public string disabledSprite;

	public Sprite hoverSprite2D;

	public Sprite pressedSprite2D;

	public Sprite disabledSprite2D;

	public bool pixelSnap;

	public List<EventDelegate> onClick;

	[NonSerialized]
	private UISprite mSprite;

	[NonSerialized]
	private UI2DSprite mSprite2D;

	[NonSerialized]
	private string mNormalSprite;

	[NonSerialized]
	private Sprite mNormalSprite2D;

	public override bool isEnabled
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButton)+39]");
			return (nint)0 != 0;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got VT
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AbstractAdProvider.eventInvoker.ChangedProvider(AdType.Video, "flurry", (string)hover);
		}
	}

	public string normalSprite
	{
		get
		{
			//IL_002f: Expected I, but got Obj
			//IL_0045: Expected Obj, but got I
			//IL_00eb: Expected I, but got Obj
			//IL_0101: Expected Obj, but got I
			//IL_0070: Expected I, but got Obj
			//IL_00c5: Expected Obj, but got I4
			//IL_012c: Expected I, but got Obj
			//IL_0180: Expected Obj, but got I4
			string result;
			if (isActiveAndEnabled)
			{
				string text = tag;
				Collider component = ((GameObject)(object)text).GetComponent<Collider>();
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)component))
				{
					bool isTrigger = component.isTrigger;
					result = (string)1;
					if (isTrigger)
					{
						goto IL_01e2;
					}
				}
				Collider2D component2 = GetComponent<Collider2D>();
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)component2))
				{
					bool flag = component2.isActiveAndEnabled;
					result = (string)flag;
				}
				else
				{
					result = null;
				}
			}
			else
			{
				result = null;
			}
			goto IL_01e2;
			IL_01e2:
			return result;
		}
		set
		{
			//IL_002f: Expected I, but got Obj
			//IL_0045: Expected Obj, but got I
			//IL_02e4: Expected I, but got Obj
			//IL_02fa: Expected Obj, but got I
			//IL_0070: Expected I, but got Obj
			//IL_00bc: Expected I4, but got Obj
			//IL_016e: Expected I, but got Obj
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected Obj, but got Unknown
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected Obj, but got Unknown
			//IL_010d: Expected Obj, but got I4
			//IL_021a: Expected Obj, but got I4
			//IL_0320: Expected Obj, but got I4
			//IL_00ff: Expected Obj, but got I4
			//IL_0384: Expected Obj, but got I4
			//IL_020c: Expected Obj, but got I4
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected Obj, but got Unknown
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected Obj, but got Unknown
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected Obj, but got Unknown
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj2 = default;
			object obj = obj2 ^ (object)value;
			if (obj == null)
			{
				return;
			}
			string text = tag;
			Collider component = ((GameObject)(object)text).GetComponent<Collider>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v64 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				component.isTrigger = (byte)(int)value != 0;
				UIButton[] components = GetComponents<UIButton>();
				object obj4 = components + 12;
				if (value != null)
				{
					object obj5 = 0;
				}
				else
				{
					object obj5 = 3;
				}
				object obj6 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
				{
					object obj7 = components + 16;
					object obj8 = obj6 << 2;
					object obj9 = obj7 + obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
					object obj10 = obj6 + 1;
					obj6 = obj10;
				}
				return;
			}
			Collider2D component2 = GetComponent<Collider2D>();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) == 0)
			{
				tag = value;
				return;
			}
			component2.tag = value;
			UIButton[] components2 = GetComponents<UIButton>();
			object obj12 = components2 + 12;
			if (value != null)
			{
				object obj13 = 0;
			}
			else
			{
				object obj13 = 3;
			}
			object obj14 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				object obj15 = components2 + 16;
				object obj16 = obj14 << 2;
				object obj17 = obj15 + obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
				object obj18 = obj14 + 1;
				obj14 = obj18;
			}
		}
	}

	public Sprite normalSprite2D
	{
		get
		{
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			return (Sprite)(object)mNormalSprite;
		}
		set
		{
			//IL_0022: Expected I, but got Obj
			//IL_0038: Expected Obj, but got I
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected Obj, but got Unknown
			//IL_0063: Expected I, but got Obj
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_0158: Expected I, but got Obj
			//IL_016e: Expected Obj, but got I
			//IL_0199: Expected I, but got Obj
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mSprite).FindKernel((string)null) != 0)
			{
				string text = mNormalSprite;
				if (mNormalSprite != null && text.m_stringLength != 0)
				{
					UISprite uISprite = mSprite;
					if (mNormalSprite != uISprite.mSpriteName)
					{
						object obj2 = this + 156;
						obj2 = value;
						SetSprite(value);
						nint num3 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v40 (Il2CppClass<NGUITools>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num4 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v44 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						return;
					}
				}
			}
			object obj4 = this + 156;
			obj4 = value;
			if (mState == State.Normal)
			{
				SetSprite(value);
			}
		}
	}

	protected override void OnInit()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		tweenTarget = (GameObject)20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list = default;
		list._002Ector();
		object obj = this + 36;
		obj = list;
		object obj2 = this + 44;
		obj2 = "";
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = this + 60;
		object obj4 = default;
		obj3 = obj4;
		CancelInvoke();
	}

	protected override void OnEnable()
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0031: Expected Obj, but got I
		//IL_01ae: Expected I, but got Obj
		//IL_01c4: Expected Obj, but got I
		//IL_005c: Expected I, but got Obj
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00d0: Expected I, but got Obj
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		base.OnEnable();
		object obj = this + 148;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj2 = default;
		obj = obj2;
		object obj3 = this + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj4 = default;
		obj3 = obj4;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mSprite).FindKernel((string)null) != 0)
		{
			object obj6 = this + 156;
			UISprite uISprite = mSprite;
			obj6 = uISprite.mSpriteName;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mSprite2D).FindKernel((string)null) != 0)
		{
			object obj8 = this + 160;
			UI2DSprite uI2DSprite = mSprite2D;
			obj8 = uI2DSprite.mSprite;
		}
	}

	protected override void OnDragOver()
	{
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_00ba: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj != null)
		{
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				return;
			}
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13 (Il2CppClass<UICamera>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject controllerNavigationObject = UICamera.controllerNavigationObject;
			string text = tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = controllerNavigationObject != (UnityEngine.Object)(object)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		}
	}

	protected override void OnDragOut()
	{
		//IL_0037: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_0078: Expected I, but got Obj
		//IL_00c5: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		if (~(dragHighlight ? 1u : 0u) != 0)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<UICamera>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
			string text = tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(currentTouch.pressed != (UnityEngine.Object)(object)text))
			{
				return;
			}
		}
		base.OnDragOut();
	}

	protected virtual void OnClick()
	{
		//IL_0037: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_0157: Expected I, but got Obj
		//IL_016d: Expected Obj, but got I
		//IL_0078: Expected I, but got Obj
		//IL_00c5: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		if (~(dragHighlight ? 1u : 0u) != 0)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<UICamera>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
			string text = tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(currentTouch.pressed != (UnityEngine.Object)(object)text))
			{
				return;
			}
		}
		base._002Ector();
	}

	public override void SetState(State state, bool immediate)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = this + 16;
		obj = state;
		nint num = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FlurryVideoAds.onTakeoverWillDisplay += (FlurryAdsCallback)immediate;
	}

	protected void SetSprite(string sp)
	{
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_0063: Expected I, but got Obj
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_022c: Expected I4, but got Obj
		//IL_00fb: Expected I, but got Obj
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0157: Expected I4, but got Obj
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01a6: Expected I, but got Obj
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mSprite2D).FindKernel((string)null) != 0)
		{
			UI2DSprite uI2DSprite = mSprite2D;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mNormalSprite2D != uI2DSprite.mSprite)
			{
				object obj3 = this + 160;
				obj3 = sp;
				state = (State)sp;
				nint num5 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v37 (Il2CppClass<NGUITools>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v41 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return;
			}
		}
		object obj5 = this + 160;
		obj5 = sp;
		if (mState == State.Normal)
		{
			state = (State)sp;
		}
	}

	protected void SetSprite(Sprite sp)
	{
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b2: Expected I4, but got Obj
		//IL_00e2: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mSprite).FindKernel((string)null) == 0 || (object)sp == null || ((UnityEngine.Object)sp).m_CachedPtr == (IntPtr)0)
		{
			return;
		}
		UISprite uISprite = mSprite;
		if (uISprite.mSpriteName.get_Chars((int)sp) != '\0')
		{
			mSprite.fillCenter = (byte)(int)sp != 0;
			if (~(pixelSnap ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public UIButton()
	{
		//IL_0237: Expected I, but got Obj
		//IL_024d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_01ea: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(current != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v14 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v45 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID == -2)
		{
			return;
		}
		nint num5 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v23 (Il2CppClass<UICamera>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v39 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID == -3)
		{
			return;
		}
		current = this;
		nint num7 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v16 (Il2CppClass<EventDelegate>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v22 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Localization.dictionary = (Dictionary<string, string[]>)(object)onClick;
		current = null;
	}
}
