using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Data.Save;
using Debugging;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.DeviceUtility;
using UnityEngine;

namespace WeeklyHunt;

public class WeeklyHuntIconPositioning : MonoBehaviour
{
	public enum IconPlacement
	{
		NotSet,
		FrontUIButton,
		CelebrationPopup,
		WeeklyHuntPopupActive,
		WeeklyHuntPopupInactive,
		SlideIn,
		IngameCounter,
		IngameCounterBackground,
		WeeklyHuntPageProgress
	}

	private IconPlacement _placement;

	private bool RUN_ONCE;

	private int CELEBRATION_POPUP_ICON_PADDING;

	private float CELEBRATION_POPUP_ICON_Y_OFFSET;

	private Vector3 PAGE_ICON_POSITION;

	private Vector3 INGAME_COUNTER_ICON_POSITION;

	private Vector3 INGAME_COUNTER_BACKGROUND_POSITION;

	private Vector3 SLIDEIN_ICON_POSITION;

	private int HEIGHT_PAGE_PROGRESS;

	private int HEIGHT_INGAME;

	private int HEIGHT_SLIDE_IN;

	private int HEIGHT_CELEBRATION_POPUP;

	public void ForceUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0601: Expected Obj, but got I4
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Obj, but got Unknown
		//IL_0618: Expected Obj, but got I4
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Obj, but got Unknown
		//IL_063b: Expected Obj, but got I4
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_0678: Expected I, but got Obj
		//IL_068e: Expected Obj, but got I
		//IL_06bc: Expected Obj, but got VT
		//IL_06ca: Expected I, but got Obj
		//IL_06e0: Expected Obj, but got I
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0211: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_0252: Expected I, but got Obj
		//IL_074c: Expected I, but got Obj
		//IL_0762: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_048c: Expected Obj, but got I4
		//IL_01c4: Expected I, but got Obj
		//IL_086e: Expected I, but got Obj
		//IL_0884: Expected Obj, but got I
		//IL_04f3: Expected Obj, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_05ab: Expected I, but got Obj
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		//IL_031f: Expected I, but got Obj
		//IL_0335: Expected Obj, but got I
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_0360: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 32;
		obj3 = 0;
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		object obj6 = obj2 + 40;
		obj6 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FPSCounter fPSCounter = default;
		fPSCounter.Awake();
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v207 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimeSpan timeLeftForActivePeriod = WeeklyHuntManager.GetTimeLeftForActivePeriod();
		obj3 = timeLeftForActivePeriod;
		nint num3 = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v32 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v203 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = fPSCounter + 8;
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF7");
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<int> list = default;
		list._002Ector();
		list.Add(0);
		list.Add(0);
		list.Add(0);
		list.Add(0);
		object obj11 = fPSCounter + 12;
		obj11 = list;
		if ((object)this != null)
		{
			nint num5 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v193 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num6 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v199 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
			nint num7 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v102 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num8 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v107 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EventsSave.weeklyHuntProgressData = (WeeklyHuntProgressData)(object)bundleIdentifier;
		}
		nint num9 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v50 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num10 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v186 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj15 = default;
		object obj17 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj15 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj16 = obj17 - 1;
			if ((object)this != null)
			{
				_ = 0;
				nint num11 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S0_v155 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num12 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v176 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
		}
		object obj19 = obj6 + 4;
		object obj20 = obj19 + 1;
		obj19 = obj20;
		object obj21 = obj20 << 2;
		object obj22 = obj6 + obj21;
		obj22 = 194;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj6 + obj23;
			if ((nint)obj24 == 194)
			{
				object obj25 = obj6 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				goto IL_0860;
			}
		}
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0860;
		IL_0860:
		nint num13 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v72 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num14 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v78 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventsSave.wordHuntDailyWord = (string)(object)fPSCounter;
	}

	private void Awake()
	{
		SetPosition();
		SetSize();
	}

	private void Update()
	{
		Awake();
	}

	private void SetSize()
	{
		this._002Ector();
		if (~(RUN_ONCE ? 1u : 0u) == 0)
		{
			tag = null;
		}
	}

	private void SetPosition()
	{
		//IL_01f6: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_016f: Expected I, but got Obj
		//IL_00ef: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		//IL_00d1: Expected Obj, but got I4
		object obj = _placement - 2;
		UIWidget uIWidget;
		if (_placement != IconPlacement.CelebrationPopup)
		{
			if ((nint)obj == 1 || (nint)obj == 2)
			{
				return;
			}
			if ((nint)obj != 3)
			{
				if ((nint)obj != 4)
				{
					if ((nint)obj == 5 || (nint)obj != 6)
					{
						return;
					}
					uIWidget = (UIWidget)HEIGHT_PAGE_PROGRESS;
				}
				else
				{
					uIWidget = (UIWidget)HEIGHT_INGAME;
				}
			}
			else
			{
				uIWidget = (UIWidget)HEIGHT_SLIDE_IN;
			}
		}
		else
		{
			uIWidget = (UIWidget)HEIGHT_CELEBRATION_POPUP;
		}
		if ((object)uIWidget == null)
		{
			return;
		}
		UISprite component = GetComponent<UISprite>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)component))
		{
			component.keepAspectRatio = UIWidget.AspectRatioSource.Free;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			component.keepAspectRatio = UIWidget.AspectRatioSource.BasedOnHeight;
			Color color = uIWidget.color;
		}
	}

	public unsafe WeeklyHuntIconPositioning()
	{
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected VT, but got Unknown
		//IL_0368: Expected VT, but got I4
		//IL_0388: Expected Obj, but got I4
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_03b1: Expected Obj, but got VT
		//IL_01ec: Expected I, but got Obj
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02d0: Expected VT, but got Obj
		//IL_02cb: Expected native int or pointer, but got VT
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_0281: Expected VT, but got Obj
		//IL_027c: Expected native int or pointer, but got VT
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0151: Expected VT, but got Obj
		//IL_014c: Expected native int or pointer, but got VT
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_0102: Expected VT, but got Obj
		//IL_00fd: Expected native int or pointer, but got VT
		object obj = default;
		Transform transform = (Transform)(obj + 32);
		Vector3? vector = (Vector3?)(object)(obj + 16);
		vector = (Vector3?)(object)0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj2 = _placement - 2;
		if (_placement != IconPlacement.CelebrationPopup)
		{
			if ((nint)obj2 != 1 && (nint)obj2 != 2)
			{
				if ((nint)obj2 != 3)
				{
					if ((nint)obj2 != 4)
					{
						if ((nint)obj2 != 5)
						{
							if ((nint)obj2 == 6)
							{
								object obj3 = this + 28;
								obj = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v59+8]");
								_ = 0;
								transform = (Transform)obj;
								Transform transform2 = transform;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
								((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
								*(Vector3?*)(nint)vector = (Vector3)transform;
							}
						}
						else
						{
							object obj4 = this + 52;
							obj = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v49+8]");
							_ = 0;
							transform = (Transform)obj;
							Transform transform3 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
							*(Vector3?*)(nint)vector = (Vector3)transform;
						}
					}
					else
					{
						object obj5 = this + 40;
						obj = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v39+8]");
						_ = 0;
						transform = (Transform)obj;
						Transform transform4 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						*(Vector3?*)(nint)vector = (Vector3)transform;
					}
				}
				else
				{
					object obj6 = this - -64;
					obj = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v29+8]");
					_ = 0;
					transform = (Transform)obj;
					Transform transform5 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					*(Vector3?*)(nint)vector = (Vector3)transform;
				}
			}
		}
		else
		{
			GameObject gameObject = base.gameObject;
			TransformExtensions.SetLocalPosZ((Transform)(object)gameObject, CELEBRATION_POPUP_ICON_Y_OFFSET);
			GameObject gameObject2 = base.gameObject;
			Transform parentInternal = ((Transform)(object)gameObject2).parentInternal;
			_0021_00210 componentInChildren = (_0021_00210)((Component)parentInternal).GetComponentInChildren<T>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
			{
				_ = CELEBRATION_POPUP_ICON_PADDING;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (System.Nullable`1<UnityEngine.Vector3>)+C]");
		if ((nint)0 != 0)
		{
			GameObject gameObject3 = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8807");
			transform = (Transform)obj;
			Transform transform6 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
		}
	}
}
