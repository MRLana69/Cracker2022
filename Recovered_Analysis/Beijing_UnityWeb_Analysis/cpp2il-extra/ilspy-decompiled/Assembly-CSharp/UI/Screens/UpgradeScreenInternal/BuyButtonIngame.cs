using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using InApp;
using Info;
using Kiloo.Common.Plugins.DeviceUtility;
using UnityEngine;

namespace UI.Screens.UpgradeScreenInternal;

public class BuyButtonIngame : MonoBehaviour, IBuyButton
{
	public UpgradeHelper updater;

	private UpgradeType _type;

	private bool _purchaseInProgress = false;

	public unsafe UpgradeType type
	{
		get
		{
			//IL_0686: Expected I, but got Obj
			//IL_069c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00a7: Expected Obj, but got I4
			//IL_00a7: Expected Obj, but got I4
			//IL_00be: Expected I, but got Obj
			//IL_00d4: Expected Obj, but got I
			//IL_01a4: Expected I4, but got Obj
			//IL_00ff: Expected I, but got Obj
			//IL_0726: Expected I, but got Obj
			//IL_073c: Expected Obj, but got I
			//IL_025c: Expected I4, but got Obj
			//IL_01b7: Expected I, but got Obj
			//IL_077a: Expected Obj, but got I4
			//IL_07b0: Expected Obj, but got I4
			//IL_07c1: Expected I4, but got Obj
			//IL_07d4: Expected Obj, but got I4
			//IL_07d4: Expected Obj, but got I4
			//IL_07e5: Expected I4, but got Obj
			//IL_07f3: Expected Obj, but got I4
			//IL_0281: Expected I4, but got Obj
			//IL_0294: Expected Obj, but got I4
			//IL_0294: Expected Obj, but got I4
			//IL_02a5: Expected I4, but got Obj
			//IL_02b3: Expected I, but got Obj
			//IL_02c9: Expected Obj, but got I
			//IL_026f: Expected I4, but got Obj
			//IL_080f: Expected I4, but got Obj
			//IL_080f: Expected Obj, but got I4
			//IL_081c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0821: Expected Obj, but got Unknown
			//IL_082a: Expected Obj, but got I4
			//IL_02f4: Expected I, but got Obj
			//IL_03ce: Expected I, but got Obj
			//IL_03e4: Expected Obj, but got I
			//IL_0869: Expected I4, but got Obj
			//IL_0869: Expected Obj, but got I4
			//IL_0876: Unknown result type (might be due to invalid IL or missing references)
			//IL_087b: Expected Obj, but got Unknown
			//IL_0884: Expected Obj, but got I4
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected Obj, but got Unknown
			//IL_040f: Expected I, but got Obj
			//IL_04ee: Expected Obj, but got I4
			//IL_08c3: Expected Obj, but got I4
			//IL_0457: Unknown result type (might be due to invalid IL or missing references)
			//IL_045c: Expected Obj, but got Unknown
			//IL_0514: Expected Obj, but got I4
			//IL_05ac: Expected Obj, but got I4
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_0535: Expected Obj, but got Unknown
			//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cd: Expected Obj, but got Unknown
			//IL_0620: Unknown result type (might be due to invalid IL or missing references)
			//IL_0625: Expected Obj, but got Unknown
			//IL_0583: Unknown result type (might be due to invalid IL or missing references)
			//IL_0588: Expected Obj, but got Unknown
			bool flag2 = default;
			bool flag = (byte)((flag2 ? 1u : 0u) + 4u) != 0;
			((bool*)(flag ? 1 : 0))->m_value = false;
			((bool*)(flag2 ? 1 : 0))->m_value = false;
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v141 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
			if (unfilteredLocale == null || unfilteredLocale.m_stringLength == 0)
			{
				return UpgradeType._notset;
			}
			string text = unfilteredLocale.ToLowerInvariant();
			string text2 = text.Replace((string)45, (string)95);
			nint num3 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v26 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v132 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"bundles_enabled_locales", flag))
			{
				bool value = ((bool*)(flag ? 1 : 0))->m_value;
				bool flag3;
				if (~(((bool*)(flag ? 1 : 0))->m_value ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v126 (System.Boolean)+8]");
					flag3 = (nint)0 == 0;
				}
				else
				{
					flag3 = true;
				}
				if (!flag3)
				{
					goto IL_0718;
				}
			}
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)"all" != 0;
			goto IL_0718;
			IL_0767:
			if (!((string)((bool*)(flag ? 1 : 0))->m_value).EndsWith("all"))
			{
				((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)"all" != 0;
			}
			string text3 = ((string)((bool*)(flag ? 1 : 0))->m_value).ToLowerInvariant();
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)text3 != 0;
			string text4 = text3.Replace((string)45, (string)95);
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)text4 != 0;
			string text5 = ((string)((bool*)(flag2 ? 1 : 0))->m_value).ToLowerInvariant();
			((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)text5 != 0;
			string text6 = text5.Replace((string)45, (string)95);
			((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)text6 != 0;
			nint num5 = (nint)typeof(UpgradeScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v32 (Il2CppClass<UI.Screens.UpgradeScreen>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UpgradeScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S1_v101 (Il2CppClass<UI.Screens.UpgradeScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text7 = ((string)((bool*)(flag ? 1 : 0))->m_value).Substring((int)UpgradeScreen.SPLIT_CHARACTER);
			object obj4 = text7 + 12;
			object obj5 = 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				object obj6 = text7 + 16;
				object obj7 = obj5 << 2;
				object str = obj6 + obj7;
				string text8 = string.Copy((string)str);
				throw new ArrayTypeMismatchException();
			}
			nint num7 = (nint)typeof(UpgradeScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S1_v44 (Il2CppClass<UI.Screens.UpgradeScreen>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(UpgradeScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S1_v85 (Il2CppClass<UI.Screens.UpgradeScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text9 = ((string)((bool*)(flag2 ? 1 : 0))->m_value).Substring((int)UpgradeScreen.SPLIT_CHARACTER);
			object obj9 = text9 + 12;
			object obj10 = 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
			{
				object obj11 = text9 + 16;
				object obj12 = obj10 << 2;
				object str2 = obj11 + obj12;
				string text10 = string.Copy((string)str2);
				throw new ArrayTypeMismatchException();
			}
			if (((string)((bool*)(flag ? 1 : 0))->m_value).EndsWith("all"))
			{
				object obj13 = 0;
				while (true)
				{
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
					{
						return UpgradeType._notset;
					}
					object obj14 = text9 + 16;
					object obj15 = obj13 << 2;
					object value2 = obj14 + obj15;
					if (!text2.EndsWith((string)value2))
					{
						break;
					}
					object obj16 = obj13 + 1;
					obj13 = obj16;
				}
				return UpgradeType.hoverboard;
			}
			if (((string)((bool*)(flag2 ? 1 : 0))->m_value).EndsWith("all"))
			{
				object obj17 = 0;
				while (true)
				{
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
					{
						return UpgradeType._notset;
					}
					object obj18 = text7 + 16;
					object obj19 = obj17 << 2;
					object value3 = obj18 + obj19;
					if (text2.EndsWith((string)value3))
					{
						break;
					}
					object obj20 = obj17 + 1;
					obj17 = obj20;
				}
				return UpgradeType.hoverboard;
			}
			return UpgradeType._notset;
			IL_0718:
			nint num9 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v36 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num10 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v119 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath2).RestoreNonConsumablePurchases((string[])(object)"bundles_disabled_locales", flag2))
			{
				bool value4 = ((bool*)(flag2 ? 1 : 0))->m_value;
				bool flag4;
				if (~(((bool*)(flag2 ? 1 : 0))->m_value ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v113 (System.Boolean)+8]");
					flag4 = (nint)0 == 0;
				}
				else
				{
					flag4 = true;
				}
				if (!flag4)
				{
					goto IL_0767;
				}
			}
			((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)"none" != 0;
			goto IL_0767;
		}
	}

	private unsafe void OnClick()
	{
		//IL_0103: Expected I, but got Obj
		//IL_0119: Expected Obj, but got I
		//IL_015c: Expected Obj, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected I4, but got Unknown
		//IL_0081: Expected I4, but got Obj
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_00c3: Expected I4, but got Obj
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		nint num = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v46 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<UpgradeType, Upgrade> upgrades = Upgrades.upgrades;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (System.Collections.Generic.Dictionary`2<Info.UpgradeType, Info.Upgrade>)+10]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (System.Collections.Generic.Dictionary`2<Info.UpgradeType, Info.Upgrade>)+1C]");
		IEnumerable<_00210> collection = (IEnumerable<_00210>)(num3 - 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)collection);
		object obj2 = this + 72;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		object obj3 = obj4 + 4;
		obj3 = 0;
		CallingConvention callingConvention = (CallingConvention)(obj4 + 8);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj3;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		object obj5 = this + 88;
		obj5 = unmanagedFunctionPointerAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj4 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj4;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute2 = default;
		unmanagedFunctionPointerAttribute2._002Ector(callingConvention);
		object obj6 = this + 92;
		obj6 = unmanagedFunctionPointerAttribute2;
		_ = -1;
		((UpgradeScreen)this).Start();
	}

	public unsafe void InitBuyButton(UpgradeType type)
	{
		//IL_0032: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.UpgradeScreenInternal.BuyButtonIngame)+70]");
		if ((nint)0 != 0)
		{
			object obj = ((UpgradeType*)(int)type)->value__;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [type @ L1 (Info.UpgradeType)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.UpgradeScreenInternal.BuyButtonIngame)+68]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj2 = num - 0;
			((UpgradeScreen)this).OnProductRequestDone();
		}
	}

	public void OnPurchaseSuccessful()
	{
		if (~(_purchaseInProgress ? 1u : 0u) != 0)
		{
			SlideinPowerupHelper instance = SlideinPowerupHelper.Instance;
			((PurchaseHandler)(object)instance).PurchaseSkipMission((int)_type, (IBuyButton)this);
		}
	}

	public void OnPurchaseFailure()
	{
		updater.animState = (UpgradeHelper.AnimState)_type;
		_purchaseInProgress = false;
	}
}
